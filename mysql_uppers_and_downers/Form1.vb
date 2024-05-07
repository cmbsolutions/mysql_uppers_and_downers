Imports DevComponents.AdvTree
Imports DiffPlex.Wpf.Controls

Public Class Form1
    Private CompareProject As CompareProject
    Private CurrentStep As EWizardSteps = EWizardSteps.CONNECTIONS

    Private Async Sub BNext_Click(sender As Object, e As EventArgs) Handles BNext.Click
        Dim ts1 = Await Task.Run(Of Boolean)(Function()
                                                 DbFrom.InfoManager.HarvestObjects()
                                                 Return True
                                             End Function)
        Dim ts2 = Await Task.Run(Of Boolean)(Function()
                                                 DbTo.InfoManager.HarvestObjects()
                                                 Return True
                                             End Function)

        CompareProject = New CompareProject(DbFrom.InfoManager, DbTo.InfoManager)

        CurrentStep = EWizardSteps.SELECTSOURCES
        ManageSteps()
        'DoCompare()
    End Sub

    Private Sub ManageSteps()
        Select Case CurrentStep
            Case EWizardSteps.CONNECTIONS
                SuperTabControl1.Tabs.Item(0).Enabled = True
                SuperTabControl1.Tabs.Item(1).Enabled = False
                SuperTabControl1.Tabs.Item(2).Enabled = False

                SuperTabControl1.SelectedTabIndex = 0
            Case EWizardSteps.COMPARE
                SuperTabControl1.Tabs.Item(0).Enabled = True
                SuperTabControl1.Tabs.Item(1).Enabled = True
                SuperTabControl1.Tabs.Item(2).Enabled = False
                DoCompare()
                SuperTabControl1.SelectedTabIndex = 1
            Case EWizardSteps.SELECTSOURCES
                SuperTabControl1.Tabs.Item(0).Enabled = True
                SuperTabControl1.Tabs.Item(1).Enabled = False
                SuperTabControl1.Tabs.Item(2).Enabled = True
                FillForSyncSelection()
                SuperTabControl1.SelectedTabIndex = 2
        End Select
    End Sub

    Private Sub DoCompare()
        Dim GroupNode = NodeGroupTemplate.DeepCopy
        Dim GroupCountTotal As Integer = 0
        Dim GroupCountSelected As Integer = 0

        Dim ObjectNode = NodeTemplateObject.DeepCopy
        Dim SubObjectNode = NodeTemplateColumn.DeepCopy

        AdvTree1.Nodes.Clear()
        Dim CurrentGroup As String = ""
        Dim CurrentObject As String = ""
        Dim CurrentSubObject As String = ""

        Dim ComparableObjects = CompareProject.Context.GetDatabaseObjects2

        For Each rec In ComparableObjects
            If CurrentGroup <> rec.GroupKind Then
                If CurrentGroup = "" Then
                    CurrentGroup = rec.GroupKind
                Else
                    Select Case CurrentGroup
                        Case "modify"
                            GroupNode.Text = $"Objects To Be Modified ({GroupCountSelected}/{GroupCountTotal})"
                        Case "add"
                            GroupNode.Text = $"Objects To Be Added ({GroupCountSelected}/{GroupCountTotal})"
                        Case "remove"
                            GroupNode.Text = $"Objects To Be Removed ({GroupCountSelected}/{GroupCountTotal})"
                        Case "noaction"
                            GroupNode.Text = $"Objects With NoAction ({GroupCountTotal})"
                            GroupNode.Checked = False
                            GroupNode.Editable = False
                    End Select

                    GroupNode = NodeGroupTemplate.DeepCopy
                    CurrentGroup = rec.GroupKind
                    GroupNode.Checked = rec.IsSelected
                    GroupCountSelected = 0
                    GroupCountTotal = 0
                End If
                AdvTree1.Nodes.Add(GroupNode)
            End If

            If CurrentObject <> rec.ObjectName Then
                If CurrentObject = "" Then
                    CurrentObject = rec.ObjectName
                Else
                    ObjectNode = NodeTemplateObject.DeepCopy
                    CurrentObject = rec.ObjectName
                End If
                GroupNode.Nodes.Add(ObjectNode)
                GroupCountTotal += 1
                GroupCountSelected += If(rec.IsSelected, 1, 0)

                ObjectNode.Text = rec.ObjectName
                ObjectNode.Image = rec.ObjectImg
                ObjectNode.Expanded = False
                ObjectNode.Checked = rec.IsSelected
                'ObjectNode.NodesColumnsHeaderVisible = False
                AddHandler ObjectNode.NodeClick, AddressOf ObjectNodeClickEventHandler
            End If

            If CurrentSubObject <> rec.SubName Then
                If CurrentSubObject = "" Then
                    CurrentSubObject = rec.SubName
                Else
                    SubObjectNode = NodeTemplateColumn.DeepCopy
                    CurrentSubObject = rec.SubName
                End If

                ObjectNode.Nodes.Add(SubObjectNode)

                SubObjectNode.Text = rec.SubName
                SubObjectNode.Image = rec.SubImg
                'SubObjectNode.NodesColumnsHeaderVisible = False
                SubObjectNode.Cells(1).Text = rec.SubType
                SubObjectNode.Cells(2).Text = rec.SubAttributes
            End If
        Next

        Select Case CurrentGroup
            Case "modify"
                GroupNode.Text = $"Objects To Be Modified ({GroupCountSelected}/{GroupCountTotal})"
            Case "add"
                GroupNode.Text = $"Objects To Be Added ({GroupCountSelected}/{GroupCountTotal})"
            Case "remove"
                GroupNode.Text = $"Objects To Be Removed ({GroupCountSelected}/{GroupCountTotal})"
            Case "noaction"
                GroupNode.Text = $"Objects With NoAction ({GroupCountTotal})"
                GroupNode.Checked = False
                GroupNode.Editable = False
        End Select

        AdvTree1.Refresh()
    End Sub

    Private Sub ObjectNodeClickEventHandler(sender As Object, e As EventArgs)
        Dim node As Node = TryCast(sender, Node)
        Dim nodeEvent As TreeNodeMouseEventArgs = TryCast(e, TreeNodeMouseEventArgs)

        Dim defiFrom = CompareProject.DbFrom.Tables.First(Function(c) c.Name = node.Text).Definition
        Dim defiTo = CompareProject.DbTo.Tables.First(Function(c) c.Name = node.Text).Definition

        Dim diff As DiffViewer = TryCast(ElementHost2.Child, DiffViewer)

        ' Check if the cast was successful
        If diff IsNot Nothing Then
            diff.OldTextHeader = "Database From"
            diff.OldText = defiFrom
            diff.NewTextHeader = "Database To"
            diff.NewText = defiTo
        End If
    End Sub

    Private Sub FillForSyncSelection()
        Dim GroupNode As Node = Nothing

        Dim ObjectNode As Node = Nothing
        Dim SubObjectNode As Node = Nothing

        Dim CurrentGroup As String = ""
        Dim CurrentObject As String = ""
        Dim CurrentSubObject As String = ""

        Dim ComparableObjects = CompareProject.Context.GetDatabaseObjectsForSync

        For Each rec In ComparableObjects
            If CurrentGroup <> rec.GroupKind Then
                GroupNode = SelectGroupNode.DeepCopy
                GroupNode.Visible = True
                GroupNode.Name = rec.GroupKind
                CurrentGroup = rec.GroupKind
                SourceSelectionTree.Nodes.Add(GroupNode)
            End If

            If CurrentObject <> rec.ObjectName Then
                ObjectNode = TableNode.DeepCopy
                ObjectNode.Visible = True
                CurrentObject = rec.ObjectName
                GroupNode.Nodes.Add(ObjectNode)

                ObjectNode.Text = rec.ObjectName
                ObjectNode.Image = rec.ObjectImg
                ObjectNode.Expanded = False
                'ObjectNode.Checked = rec.IsSelected
                'ObjectNode.NodesColumnsHeaderVisible = False
                'AddHandler ObjectNode.NodeClick, AddressOf ObjectNodeClickEventHandler
            End If

            If CurrentSubObject <> rec.SubName Then
                SubObjectNode = ColumnNode.DeepCopy
                SubObjectNode.Visible = True
                CurrentSubObject = rec.SubName

                ObjectNode.Nodes.Add(SubObjectNode)

                SubObjectNode.Text = rec.SubName
                SubObjectNode.Image = rec.SubImg

                While SubObjectNode.Cells.Count < 3
                    SubObjectNode.Cells.Add(New Cell)
                End While
                'SubObjectNode.NodesColumnsHeaderVisible = False
                SubObjectNode.Cells(1).Text = rec.SubType
                SubObjectNode.Cells(2).Text = rec.SubAttributes
            End If
        Next

        For Each grp As Node In SourceSelectionTree.Nodes
            Select Case grp.Name
                Case "selectable"
                    grp.Text = $"Selectable Objects ({grp.Nodes.Count})"
                Case "mismatch"
                    grp.Text = $"Mismatched Objects ({grp.Nodes.Count})"
                    grp.CheckBoxVisible = False
                    grp.Checked = False
                    grp.Editable = False
            End Select
        Next

        SourceSelectionTree.Refresh()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class