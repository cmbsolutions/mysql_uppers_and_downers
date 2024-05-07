Imports System.Drawing
Imports CMBSolutions.Db.InfoSchema
Imports Mysqlx.Crud
Imports Mysqlx.XDevAPI.Relational

Namespace Models
    Public Class CompareContext
        Implements ICollection(Of ComparableObject)

        Private DbFrom As Manager
        Private DbTo As Manager

        Private InternalCollection As List(Of ComparableObject)

        Sub New(f As Manager, t As Manager)
            DbFrom = f
            DbTo = t
            InternalCollection = New List(Of ComparableObject)
        End Sub

        Public ReadOnly Property Count As Integer Implements ICollection(Of ComparableObject).Count
            Get
                Return InternalCollection.Count
            End Get
        End Property

        Public ReadOnly Property IsReadOnly As Boolean Implements ICollection(Of ComparableObject).IsReadOnly
            Get
                Return False
            End Get
        End Property

        Public Sub Add(item As ComparableObject) Implements ICollection(Of ComparableObject).Add
            InternalCollection.Add(item)
        End Sub

        Public Sub Clear() Implements ICollection(Of ComparableObject).Clear
            InternalCollection.Clear()
        End Sub

        Public Sub CopyTo(array() As ComparableObject, arrayIndex As Integer) Implements ICollection(Of ComparableObject).CopyTo
            InternalCollection.CopyTo(array, arrayIndex)
        End Sub

        Public Function GetModifyable() As IEnumerable(Of ComparedItem)
            Return From dbf In DbFrom.Tables
                   Join dbt In DbTo.Tables
                       On dbf.Name Equals dbt.Name
                   Where dbf.Definition <> dbt.Definition
                   Select New ComparedItem With {
                        .Selected = True,
                        .NameFrom = dbf.Name,
                        .NameTo = dbt.Name,
                        .dbf = dbf,
                        .dbt = dbt
                   }
        End Function

        Public Function GetAdded() As IEnumerable(Of ComparedItem)
            Return From dbf In DbFrom.Tables
                   Group Join dbt In DbTo.Tables
                       On dbf.Name Equals dbt.Name Into Group
                   From d In Group.DefaultIfEmpty()
                   Where d Is Nothing
                   Select New ComparedItem With {
                        .Selected = True,
                        .NameFrom = dbf.Name,
                        .NameTo = "",
                        .dbf = dbf,
                        .dbt = Nothing
                   }
        End Function

        Public Function GetDeleted() As IEnumerable(Of ComparedItem)
            Return From dbt In DbTo.Tables
                   Group Join dbf In DbFrom.Tables
                       On dbt.Name Equals dbf.Name Into Group
                   From d In Group.DefaultIfEmpty()
                   Where d Is Nothing
                   Select New ComparedItem With {
                        .Selected = True,
                        .NameFrom = "",
                        .NameTo = dbt.Name,
                        .dbf = Nothing,
                        .dbt = dbt
                   }
        End Function

        Public Function GetNoAction() As IEnumerable(Of ComparedItem)
            Return From dbf In DbFrom.Tables
                   Join dbt In DbTo.Tables
                       On dbf.Name Equals dbt.Name
                   Where dbf.Definition = dbt.Definition
                   Select New ComparedItem With {
                        .Selected = False,
                        .NameFrom = dbf.Name,
                        .NameTo = dbt.Name,
                        .dbf = dbf,
                        .dbt = dbt
                   }
        End Function

        Public ReadOnly Property GetDatabaseObjects() As List(Of ComparableObject)
            Get
                Dim dbObjects = From table In DbFrom.Tables
                                From column In table.Columns.DefaultIfEmpty
                                From foreignKey In table.ForeignKeys.DefaultIfEmpty
                                From index In table.Indexes.DefaultIfEmpty
                                Select New ComparableObject With {
                                   .IsSelected = False,
                                   .GroupKind = "modify",
                                   .ObjectKind = If(table.IsView, "view", "table"),
                                   .ObjectImg = table.Icon,
                                   .ObjectName = table.Name,
                                   .SubKind = If(column IsNot Nothing, "column", If(foreignKey IsNot Nothing, "foreignkey", "index")),
                                   .SubName = If(column IsNot Nothing, column.Name, If(foreignKey IsNot Nothing, foreignKey.name, index.Name)),
                                   .SubType = If(column IsNot Nothing, column.MySqlColumnType, ""),
                                   .SubImg = If(column IsNot Nothing, column.Icon, If(foreignKey IsNot Nothing, foreignKey.Icon, index.Icon)),
                                   .SubAttributes = If(column IsNot Nothing, $"{If(column.IsNullable, "N", "NN")}", If(foreignKey IsNot Nothing, $"", $"{If(index.IsUnique, "U", "")}{If(index.IsNullable, "N", "NN")}"))
                               }

                Return dbObjects.ToList
            End Get
        End Property

        Public ReadOnly Property GetDatabaseObjects2() As List(Of ComparableObject)
            Get
                Dim TotalList As New List(Of ComparableObject)

                Dim ModifiableTables = From dbf In DbFrom.Tables
                                       Join dbt In DbTo.Tables
                                            On dbf.Name Equals dbt.Name
                                       Where dbf.Definition <> dbt.Definition
                                       Select dbf

                TotalList.AddRange(BuildFromObjectList("modify", ModifiableTables))

                Dim AddableTables = From dbf In DbFrom.Tables
                                    Group Join dbt In DbTo.Tables
                                       On dbf.Name Equals dbt.Name Into Group
                                    From d In Group.DefaultIfEmpty()
                                    Where d Is Nothing
                                    Select dbf

                TotalList.AddRange(BuildFromObjectList("add", AddableTables))

                Dim RemovableTables = From dbt In DbTo.Tables
                                      Group Join dbf In DbFrom.Tables
                                        On dbt.Name Equals dbf.Name Into Group
                                      From d In Group.DefaultIfEmpty()
                                      Where d Is Nothing
                                      Select dbt

                TotalList.AddRange(BuildFromObjectList("remove", RemovableTables))

                Dim NoActionTables = From dbf In DbFrom.Tables
                                     Join dbt In DbTo.Tables
                                        On dbf.Name Equals dbt.Name
                                     Where dbf.Definition = dbt.Definition
                                     Select dbf

                TotalList.AddRange(BuildFromObjectList("noaction", NoActionTables))

                Return TotalList
            End Get
        End Property

        Public ReadOnly Property GetDatabaseObjectsForSync() As List(Of ComparableObject)
            Get
                Dim TotalList As New List(Of ComparableObject)

                Dim SelectableTables = From dbf In DbFrom.Tables
                                       Join dbt In DbTo.Tables
                                            On dbf.Name Equals dbt.Name
                                       Where dbf.Definition = dbt.Definition
                                       Select dbf

                TotalList.AddRange(BuildFromObjectList("selectable", SelectableTables))

                Dim MisMatchedTables = From dbf In DbFrom.Tables
                                       Join dbt In DbTo.Tables
                                        On dbf.Name Equals dbt.Name
                                       Where dbf.Definition <> dbt.Definition
                                       Select dbf

                TotalList.AddRange(BuildFromObjectList("mismatch", MisMatchedTables))

                Return TotalList
            End Get
        End Property
        Private Function BuildFromObjectList(GroupKind As String, Tables As IEnumerable(Of InfoSchema.Table)) As List(Of ComparableObject)
            Dim combinedList = Tables.SelectMany(
                Function(table)
                    Dim columnList = table.Columns.Select(Function(col) New ComparableObject With {
                                .IsSelected = False,
                                .GroupKind = GroupKind,
                                .ObjectKind = If(table.IsView, "view", "table"),
                                .ObjectImg = table.Icon,
                                .ObjectName = table.Name,
                                .SubKind = "column",
                                .SubName = col.Name,
                                .SubType = col.MySqlColumnType,
                                .SubImg = col.Icon,
                                .SubAttributes = $"{If(col.IsNullable, "N", "NN")}{If(col.AutoIncrement, "A", "")}"
                           })
                    Dim foreignKeyList = table.ForeignKeys.Select(Function(fk) New ComparableObject With {
                                    .IsSelected = False,
                                    .GroupKind = GroupKind,
                                    .ObjectKind = If(table.IsView, "view", "table"),
                                    .ObjectImg = table.Icon,
                                    .ObjectName = table.Name,
                                    .SubKind = "foreignkey",
                                    .SubName = fk.name,
                                    .SubImg = fk.Icon,
                                    .SubAttributes = $"U {fk.OnUpdate}, D {fk.OnDelete}"
                                })
                    Dim indexList = table.Indexes.Select(Function(idx) New ComparableObject With {
                                    .IsSelected = False,
                                    .GroupKind = GroupKind,
                                    .ObjectKind = If(table.IsView, "view", "table"),
                                    .ObjectImg = table.Icon,
                                    .ObjectName = table.Name,
                                    .SubKind = "index",
                                    .SubName = idx.Name,
                                    .SubImg = idx.Icon,
                                    .SubAttributes = $"{If(idx.IsUnique, "U", "")}{If(idx.IsNullable, "N", "NN")}"
                                })
                    Return columnList.Concat(foreignKeyList).Concat(indexList)
                End Function
            )

            Return combinedList.ToList
        End Function
        Public Function Contains(item As ComparableObject) As Boolean Implements ICollection(Of ComparableObject).Contains
            Return InternalCollection.Contains(item)
        End Function

        Public Function Remove(item As ComparableObject) As Boolean Implements ICollection(Of ComparableObject).Remove
            Return InternalCollection.Remove(item)
        End Function

        Public Function GetEnumerator() As IEnumerator(Of ComparableObject) Implements IEnumerable(Of ComparableObject).GetEnumerator
            Return InternalCollection.GetEnumerator()
        End Function

        Private Function IEnumerable_GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
            Return InternalCollection.GetEnumerator
        End Function
    End Class

    Public Class ComparedItem
        Property Selected As Boolean
        Property NameFrom As String
        Property NameTo As String
        Property dbf As InfoSchema.Table
        Property dbt As InfoSchema.Table
    End Class

    Public Class ComparableObject
        Property IsSelected As Boolean
        Property GroupKind As String
        Property ObjectKind As String
        Property ObjectImg As Bitmap
        Property ObjectName As String
        Property SubKind As String
        Property SubName As String
        Property SubType As String
        Property SubImg As Bitmap
        Property SubAttributes As String
    End Class
End Namespace

