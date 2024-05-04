Imports CMBSolutions.Db.infoSchema
Imports DevComponents.DotNetBar

Public Class UcCompareObject
    Private InternalObjects As New List(Of UcCompareObject)
    Private InternalShowHead As Boolean
    Private InternalIsGroup As Boolean
    Private InternalIsSelected As Boolean
    Private InternalGroupType As EGroupTypes
    Private InternalSourceObjectType As EObjectTypes
    Private InternalTargetObjectType As EObjectTypes
    Private InternalIsExpanded As Boolean = False
    Private InternalOperationType As EOperations
    Private InternalExpandable As Boolean
    Private InternalSourceName As String
    Private InternalTargetName As String
    Private InternalSourceTable As table
    Private InternalTargetTable As table
    Private InternalGUID As Guid

    Public Event ExpandedChange(sender As Object, e As ExpandedChangeEventArgs)

    ReadOnly Property ItemGUID As Guid
        Get
            Return InternalGUID
        End Get
    End Property

    Property SubItems As List(Of UcCompareObject)
        Get
            Return InternalObjects
        End Get
        Set(value As List(Of UcCompareObject))
            InternalObjects = value
        End Set
    End Property

    Property ShowHead As Boolean
        Get
            Return InternalShowHead
        End Get
        Set(value As Boolean)
            InternalShowHead = value
        End Set
    End Property

    Property IsGroup As Boolean
        Get
            Return InternalIsGroup
        End Get
        Set(value As Boolean)
            If InternalIsGroup <> value Then
                InternalIsGroup = value
            End If
        End Set
    End Property

    Property GroupType As EGroupTypes
        Get
            Return InternalGroupType
        End Get
        Set(value As EGroupTypes)
            If InternalGroupType <> value Then
                InternalGroupType = value
            End If
        End Set
    End Property

    Property SourceObjectType As EObjectTypes
        Get
            Return InternalSourceObjectType
        End Get
        Set(value As EObjectTypes)
            If InternalSourceObjectType <> value Then
                InternalSourceObjectType = value
            End If
        End Set
    End Property

    Property TargetObjectType As EObjectTypes
        Get
            Return InternalTargetObjectType
        End Get
        Set(value As EObjectTypes)
            If InternalTargetObjectType <> value Then
                InternalTargetObjectType = value
            End If
        End Set
    End Property

    Property IsSelected As Boolean
        Get
            Return InternalIsSelected
        End Get
        Set(value As Boolean)
            If InternalIsSelected <> value Then
                InternalIsSelected = value
            End If
        End Set
    End Property

    Property SourceObjectName As String
        Get
            Return InternalSourceName
        End Get
        Set(value As String)
            If InternalSourceName <> value Then
                InternalSourceName = value
            End If
        End Set
    End Property

    Property TargetObjectName As String
        Get
            Return InternalTargetName
        End Get
        Set(value As String)
            If InternalTargetName <> value Then
                InternalTargetName = value
            End If
        End Set
    End Property

    ReadOnly Property GetHeight() As Integer
        Get
            Dim Height As Integer = 0

            If ShowHead Then Height = 24

            If InternalObjects IsNot Nothing AndAlso InternalIsExpanded Then
                Height += InternalObjects.Sum(Function(c) c.GetHeight) + 20
            Else
                Height += 20
            End If

            Return Height
        End Get
    End Property

    Property IsExpanded As Boolean
        Get
            Return InternalIsExpanded
        End Get
        Set(value As Boolean)
            If InternalIsExpanded <> value Then
                InternalIsExpanded = value
            End If
        End Set
    End Property

    Property OperationType As EOperations
        Get
            Return InternalOperationType
        End Get
        Set(value As EOperations)
            If InternalOperationType <> value Then
                InternalOperationType = value
            End If
        End Set
    End Property

    Property IsExpandable As Boolean
        Get
            Return InternalExpandable
        End Get
        Set(value As Boolean)
            If InternalExpandable <> value Then
                InternalExpandable = value
            End If
        End Set
    End Property

    Property SourceTable As table
        Get
            Return InternalSourceTable
        End Get
        Set(value As table)
            InternalSourceTable = value
        End Set
    End Property

    Property TargetTable As table
        Get
            Return InternalTargetTable
        End Get
        Set(value As table)
            InternalTargetTable = value
        End Set
    End Property

    Sub UpdateGroupCount()
        If InternalIsGroup Then
            Select Case GroupType
                Case EGroupTypes.NOOPERATION
                    SourceObjectName = $"No operation ({InternalObjects.Count} objects)"
                Case EGroupTypes.CREATED, EGroupTypes.DELETED, EGroupTypes.MODIFIED
                    SourceObjectName = $"Objects to be {InternalGroupType.ToString.ToLower} ({InternalObjects?.Where(Function(c) c.IsSelected).Count} of {InternalObjects?.Count} selected)"
            End Select
            SourceName.Text = SourceObjectName
        End If
    End Sub

    Public Sub Add(obj As UcCompareObject)
        InternalObjects.Add(obj)
        obj.RedrawItem()
    End Sub

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InternalGUID = New Guid
    End Sub

    Private Sub BExpand_Click(sender As Object, e As EventArgs) Handles BExpand.Click
        InternalIsExpanded = Not InternalIsExpanded

        ExpandOrCollapse()
        RaiseEvent ExpandedChange(Me, New ExpandedChangeEventArgs(eEventSource.Mouse, InternalIsExpanded))
    End Sub

    Private Sub ExpandOrCollapse()
        If IsExpanded Then
            BExpand.Image = My.Resources.ButtonMin9
        Else
            BExpand.Image = My.Resources.ButtonPlus9
        End If
        If IsExpanded Then
            ExpandSubItems()
        Else
            CollapseSubItems()
        End If
    End Sub
    Private Sub ExpandSubItems()
        Select Case SourceObjectType
            Case EObjectTypes.TABLE, EObjectTypes.VIEW
                If Not SubItems.Any AndAlso SourceTable IsNot Nothing Then
                    For Each c In SourceTable.Columns.OrderBy(Function(d) d.OrdinalPosition)
                        SubItems.Add(New UcCompareObject With {
                                     .IsGroup = False,
                                     .IsExpandable = False,
                                     .IsExpanded = False,
                                     .ShowHead = False,
                                     .OperationType = EOperations.NONE,
                                     .InternalIsSelected = IsSelected,
                                     .SourceObjectName = $"{c.Name} {c.MySqlColumnType}{If(c.IsNullable, " Nullable", "")}",
                                     .SourceObjectType = EObjectTypes.FIELD
                        })
                    Next

                    For Each i In SourceTable.Indexes
                        SubItems.Add(New UcCompareObject With {
                                     .IsGroup = False,
                                     .IsExpandable = False,
                                     .IsExpanded = False,
                                     .ShowHead = False,
                                     .OperationType = EOperations.NONE,
                                     .InternalIsSelected = IsSelected,
                                     .SourceObjectName = $"{i.Name}{If(i.IsUnique, " Unique", "")}{If(i.IsNullable, " Nullable", "")}",
                                     .SourceObjectType = EObjectTypes.INDEX
                        })
                    Next

                    For Each x In SourceTable.ForeignKeys
                        SubItems.Add(New UcCompareObject With {
                                     .IsGroup = False,
                                     .IsExpandable = False,
                                     .IsExpanded = False,
                                     .ShowHead = False,
                                     .OperationType = EOperations.NONE,
                                     .InternalIsSelected = IsSelected,
                                     .SourceObjectName = x.name,
                                     .SourceObjectType = EObjectTypes.FOREIGNKEY
                        })
                    Next

                End If
        End Select



        FLPSubObjects.SuspendLayout()
        FLPSubObjects.Controls.Clear()
        SubItems.ForEach(Sub(c) FLPSubObjects.Controls.Add(c))
        FLPSubObjects.ResumeLayout(True)
        Height = GetHeight
    End Sub

    Private Sub CollapseSubItems()
        FLPSubObjects.SuspendLayout()
        FLPSubObjects.Controls.Clear()
        FLPSubObjects.ResumeLayout(True)
        Height = GetHeight
    End Sub

    Public Sub RedrawItem()
        BExpand.Visible = IsExpandable
        If IsExpanded Then
            BExpand.Image = My.Resources.ButtonMin9
        Else
            BExpand.Image = My.Resources.ButtonPlus9
        End If
        SourceName.Text = SourceObjectName
        PBSourceType.Image = ResXHelper.GetImageFromEnum(SourceObjectType)
        LTargetname.Text = TargetObjectName
        PBTargetType.Image = ResXHelper.GetImageFromEnum(TargetObjectType)
        PBOperation.Image = ResXHelper.GetImageFromEnum(OperationType)
        ChkSelected.Checked = IsSelected

        UpdateGroupCount()

        LTargetname.Visible = Not IsGroup
        PBTargetType.Visible = Not IsGroup
        PBSourceType.Visible = Not IsGroup

        If IsGroup Then
            TableLayoutPanel1.BackColor = Color.SteelBlue
        Else
            BackColor = Color.FromArgb(255, 45, 45, 48)
        End If

        Panel2.Visible = ShowHead

        If Not ShowHead Then
            TableLayoutPanel1.Top = 0
            FLPSubObjects.Top = 20
        End If

        ExpandOrCollapse()
    End Sub
End Class
