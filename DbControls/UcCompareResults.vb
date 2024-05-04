Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab
Imports DevComponents.DotNetBar

Public Class UcCompareResults
    Private CompareContext As Models.CompareContext


    Sub LoadObjects(cc As Models.CompareContext)
        CompareContext = cc
        ' To Be Modified objects
        Dim TbmGroup As New UcCompareObject With {
            .IsGroup = True,
            .GroupType = EGroupTypes.MODIFIED,
            .IsSelected = True,
            .IsExpandable = True,
            .IsExpanded = True,
            .OperationType = EOperations.MODIFY,
            .ShowHead = True
        }

        AddHandler TbmGroup.ExpandedChange, AddressOf ExpandedChangeEventHandler

        For Each itm In CompareContext.GetModifyable
            Dim TbmItem As New UcCompareObject With {
                .IsGroup = False,
                .IsSelected = True,
                .IsExpandable = True,
                .IsExpanded = False,
                .SourceObjectName = itm.NameFrom,
                .SourceObjectType = EObjectTypes.TABLE,
                .TargetObjectName = itm.NameTo,
                .TargetObjectType = EObjectTypes.TABLE,
                .OperationType = EOperations.MODIFY,
                .SourceTable = itm.dbf,
                .TargetTable = itm.dbt
            }

            AddHandler TbmItem.ExpandedChange, AddressOf ExpandedChangeEventHandler
            TbmGroup.Add(TbmItem)
        Next

        ' To Be Added objects
        Dim TbaGroup As New UcCompareObject With {
            .IsGroup = True,
            .GroupType = EGroupTypes.CREATED,
            .IsSelected = True,
            .IsExpandable = True,
            .IsExpanded = True,
            .OperationType = EOperations.ADD
        }

        AddHandler TbaGroup.ExpandedChange, AddressOf ExpandedChangeEventHandler

        For Each itm In CompareContext.GetAdded
            Dim TbaItem As New UcCompareObject With {
                .IsGroup = False,
                .IsSelected = True,
                .IsExpandable = True,
                .IsExpanded = False,
                .SourceObjectName = itm.NameFrom,
                .SourceObjectType = EObjectTypes.TABLE,
                .SourceTable = itm.dbt,
                .TargetObjectName = itm.NameTo,
                .TargetObjectType = EObjectTypes.TABLE,
                .OperationType = EOperations.ADD
            }

            AddHandler TbaItem.ExpandedChange, AddressOf ExpandedChangeEventHandler

            TbaGroup.Add(TbaItem)
        Next

        ' To Be removed objects
        Dim TbrGroup As New UcCompareObject With {
            .IsGroup = True,
            .GroupType = EGroupTypes.DELETED,
            .IsSelected = True,
            .IsExpandable = True,
            .IsExpanded = True,
            .OperationType = EOperations.REMOVE
        }

        AddHandler TbrGroup.ExpandedChange, AddressOf ExpandedChangeEventHandler

        For Each itm In CompareContext.GetDeleted
            Dim TbrItem As New UcCompareObject With {
                .IsGroup = False,
                .IsSelected = True,
                .IsExpandable = True,
                .IsExpanded = False,
                .SourceObjectName = itm.NameFrom,
                .SourceObjectType = EObjectTypes.TABLE,
                .TargetObjectName = itm.NameTo,
                .TargetObjectType = EObjectTypes.TABLE,
                .TargetTable = itm.dbt,
                .OperationType = EOperations.REMOVE
            }

            AddHandler TbrItem.ExpandedChange, AddressOf ExpandedChangeEventHandler

            TbrGroup.Add(TbrItem)
        Next

        ' Noaction objects
        Dim TbnGroup As New UcCompareObject With {
            .IsGroup = True,
            .GroupType = EGroupTypes.NOOPERATION,
            .IsSelected = False,
            .IsExpandable = True,
            .IsExpanded = True,
            .OperationType = EOperations.NONE
        }

        AddHandler TbnGroup.ExpandedChange, AddressOf ExpandedChangeEventHandler

        For Each itm In CompareContext.GetNoAction
            Dim TbnItem As New UcCompareObject With {
                .IsGroup = False,
                .IsSelected = False,
                .IsExpandable = True,
                .IsExpanded = False,
                .SourceObjectName = itm.NameFrom,
                .SourceObjectType = EObjectTypes.TABLE,
                .SourceTable = itm.dbf,
                .TargetObjectName = itm.NameTo,
                .TargetObjectType = EObjectTypes.TABLE,
                .TargetTable = itm.dbt,
                .OperationType = EOperations.NONE
            }

            AddHandler TbnItem.ExpandedChange, AddressOf ExpandedChangeEventHandler

            TbnGroup.Add(TbnItem)
        Next

        TbmGroup.RedrawItem()
        TbaGroup.RedrawItem()
        TbrGroup.RedrawItem()
        TbnGroup.RedrawItem()

        FLPMaster.SuspendLayout()
        FLPMaster.Controls.Add(TbmGroup)
        FLPMaster.Controls.Add(TbaGroup)
        FLPMaster.Controls.Add(TbrGroup)
        FLPMaster.Controls.Add(TbnGroup)
        FLPMaster.Height = TbmGroup.GetHeight + TbaGroup.GetHeight + TbrGroup.GetHeight + TbnGroup.GetHeight
        FLPMaster.ResumeLayout(True)

        VScrollBarAdv1.Maximum = Math.Max(0, FLPMaster.Height - Panel1.Height + 44)
    End Sub

    Private Sub ExpandedChangeEventHandler(sender As Object, e As ExpandedChangeEventArgs)
        Dim NewHeight As Integer = 0
        FLPMaster.SuspendLayout()

        For Each ctl As UcCompareObject In FLPMaster.Controls
            ctl.RedrawItem()
            NewHeight += ctl.GetHeight
        Next

        FLPMaster.Height = NewHeight
        VScrollBarAdv1.Maximum = Math.Max(0, FLPMaster.Height - Panel1.Height + 44)
        FLPMaster.ResumeLayout(True)
    End Sub

    Private Sub VScrollBarAdv1_ValueChanged(sender As Object, e As EventArgs) Handles VScrollBarAdv1.ValueChanged
        FLPMaster.Top = -VScrollBarAdv1.Value
    End Sub

    Private Sub FLPMaster_MouseWheel(sender As Object, e As MouseEventArgs) Handles FLPMaster.MouseWheel
        Dim newValue As Integer = VScrollBarAdv1.Value - (e.Delta * SystemInformation.MouseWheelScrollLines \ SystemInformation.MouseWheelScrollDelta)

        ' Ensure that the new value is within the valid range
        newValue = Math.Max(VScrollBarAdv1.Minimum, Math.Min(VScrollBarAdv1.Maximum, newValue))

        ' Update the value of the vertical scrollbar
        VScrollBarAdv1.Value = newValue
    End Sub

    Private Sub UcCompareResults_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        For Each ctl As UcCompareObject In FLPMaster.Controls
            ctl.Width = Width - 14
        Next
    End Sub
End Class
