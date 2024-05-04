Public Class Compare

    Private Sub ListViewEx1_DrawItem(sender As Object, e As DrawListViewItemEventArgs)

    End Sub

    Private Sub Compare_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim grp As New ListViewGroup

        grp.Name = "LvgModify"
        grp.Header = "To be modified (0/0)"



    End Sub


End Class