
Public Class UcTableView
    Private SelectedTable As infoSchema.table
    Private Schema As infoSchema.Manager

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LexerStyles.SetMySQLStyle(SCDDL)
    End Sub

    Public Sub SetManager(ByRef Manager As infoSchema.Manager)
        Schema = Manager
    End Sub

    Public Sub SelectTable(ByRef t As infoSchema.table)
        SelectedTable = t
        ReloadTabs()
    End Sub

    Private Sub ReloadTabs()
        Dim cols = (From c In SelectedTable.Columns Order By c.OrdinalPosition Select c.Name, c.MysqlType, c.MaximumLength, c.IsNullable, c.AutoIncrement, c.Key, c.IsVirtual)
        DgvColumns.DataSource = cols.ToArray

        Dim fks = (From fk In SelectedTable.ForeignKeys
                   From col In fk.columns
                   From refcol In fk.referencedColumns
                   Select New With {
                        Key fk.name,
                        .Table = fk.table.Name,
                        .Column = col.column.Name,
                        .Position = col.fkPosition,
                        .RefTable = fk.referencedTable.Name,
                        .RefColumn = refcol.column.Name,
                        .Alias = fk.propertyAlias
                    })
        DgvFks.DataSource = fks.ToArray

        Dim idxPrimary = (From idx In SelectedTable.Indexes
                          From col In idx.columns
                          Where idx.Name = "PRIMARY"
                          Select New With {
                                Key idx.Name,
                                .Unique = idx.IsUnique,
                                .Nullable = idx.IsNullable,
                                .Column = col.column.Name,
                                .Position = col.indexPosition
                          })

        Dim idxs = (From idx In SelectedTable.Indexes
                    From col In idx.columns
                    Where idx.Name <> "PRIMARY"
                    Select New With {
                        Key idx.Name,
                        .Unique = idx.IsUnique,
                        .Nullable = idx.IsNullable,
                        .Column = col.column.Name,
                        .Position = col.indexPosition
                    })

        If idxPrimary IsNot Nothing Then
            Dim idxSet = idxs.Prepend(idxPrimary.First)
            DgvIndexes.DataSource = idxSet.ToArray
        Else
            DgvIndexes.DataSource = idxs.ToArray
        End If

        Dim refs = (From ref In SelectedTable.Relations
                    Select New With {
                        Key ref.alias,
                        .Table = ref.toTable.Name,
                        .Column = ref.toColumn.Name,
                        .LocalColumn = ref.localColumn.Name
                    })
        DgvReferences.DataSource = refs.ToArray

        SCDDL.ReadOnly = False
        SCDDL.Text = SelectedTable.definition
        SCDDL.Colorize(0, SCDDL.Text.Length)
        SCDDL.ReadOnly = True
    End Sub
End Class
