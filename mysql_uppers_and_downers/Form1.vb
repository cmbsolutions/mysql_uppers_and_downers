Imports DevComponents.AdvTree
Imports DiffPlex.Wpf.Controls

Public Class Form1
    Private CompareProject As CompareProject
    Private CurrentStep As Integer

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

        CurrentStep = 1
        ManageSteps()
        DoCompare()
    End Sub

    Private Sub ManageSteps()
        Select Case CurrentStep
            Case 0
                SuperTabControl1.Tabs.Item(0).Enabled = True
                SuperTabControl1.Tabs.Item(1).Enabled = False

                SuperTabControl1.SelectedTabIndex = 0
            Case 1
                SuperTabControl1.Tabs.Item(0).Enabled = True
                SuperTabControl1.Tabs.Item(1).Enabled = True

                SuperTabControl1.SelectedTabIndex = 1
        End Select
    End Sub

    Private Sub DoCompare()
        Dim GroupNode = NodeGroupTemplate.DeepCopy
        Dim ObjectNode = NodeTemplateObject.DeepCopy
        Dim SubObjectNode = NodeTemplateColumn.DeepCopy

        AdvTree1.Nodes.Clear()
        Dim CurrentGroup As String = ""
        Dim CurrentObject As String = ""
        Dim CurrentSubObject As String = ""

        Dim ComparableObjects = CompareProject.Context.GetDatabaseObjects2
        Dim ComparableGroupCount = ComparableObjects.GroupBy(Function(item) New With {item.GroupKind, item.IsSelected, item.ObjectName}).Select(Function(group) New With {
                                                                                                   .GroupName = group.Key.GroupKind,
                                                                                                   group.Key.IsSelected,
                                                                                                   .TableName = group.Key.ObjectName,
                                                                                                   group.Count()
                                                                                               }).ToList

        For Each rec In ComparableObjects
            If CurrentGroup <> rec.GroupKind Then
                If CurrentGroup = "" Then
                    CurrentGroup = rec.GroupKind
                Else
                    GroupNode = NodeGroupTemplate.DeepCopy
                    CurrentGroup = rec.GroupKind
                End If
                Select Case rec.GroupKind
                    Case "modify"
                        Dim fc, tc As Integer
                        fc = ComparableGroupCount.Where(Function(c) c.GroupName = "modify" And c.IsSelected).Sum(Function(d) d.Count)
                        tc = ComparableGroupCount.Where(Function(c) c.GroupName = "modify").Sum(Function(d) d.Count)
                        GroupNode.Text = $"Objects To Be Modified ({fc}/{tc})"
                    Case "add"
                        Dim fc, tc As Integer
                        fc = ComparableGroupCount.Where(Function(c) c.GroupName = "add" And c.IsSelected).Sum(Function(d) d.Count)
                        tc = ComparableGroupCount.Where(Function(c) c.GroupName = "add").Sum(Function(d) d.Count)
                        GroupNode.Text = $"Objects To Be Added ({fc}/{tc})"
                    Case "remove"
                        Dim fc, tc As Integer
                        fc = ComparableGroupCount.Where(Function(c) c.GroupName = "remove" And c.IsSelected).Sum(Function(d) d.Count)
                        tc = ComparableGroupCount.Where(Function(c) c.GroupName = "remove").Sum(Function(d) d.Count)
                        GroupNode.Text = $"Objects To Be Removed ({fc}/{tc})"
                    Case "noaction"
                        Dim tc As Integer
                        tc = ComparableGroupCount.Where(Function(c) c.GroupName = "noaction").Sum(Function(d) d.Count)
                        GroupNode.Text = $"Objects With NoAction ({tc})"
                        GroupNode.Checked = False
                        GroupNode.Editable = False
                End Select

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

                ObjectNode.Text = rec.ObjectName
                ObjectNode.Image = rec.ObjectImg
                ObjectNode.Expanded = False
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
            ' Now you can access and set properties of MyWpfControl as needed
            diff.OldTextHeader = "Database From"
            diff.OldText = defiFrom
            diff.NewTextHeader = "Database To"
            diff.NewText = defiTo
        End If
    End Sub
End Class