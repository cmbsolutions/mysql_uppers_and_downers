Imports Microsoft.Win32

Public Class UcConnectionControl
    Private WithEvents Timer As Timers.Timer
    Private Delegate Sub ResetPasswordView()

    Property InfoManager As infoSchema.Manager

    Private Const InfoText As String = "<b><font color=""LightBlue"">Information</font></b><br /><b>Host:{0}</b><br /><b>Port:{1}</b><br /><b>Server version:{2}</b>"
    Private Sub BTest_Click(sender As Object, e As EventArgs) Handles BTest.Click
        If THost.TextLength > 0 AndAlso TPort.TextLength > 0 AndAlso TUser.TextLength > 0 Then
            If InfoManager Is Nothing Then InfoManager = New infoSchema.Manager

            If InfoManager.SetConnection(THost.Text, TUser.Text, TPassword.Text) Then
                LInfo.Text = String.Format(InfoText, THost.Text, TPort.Text, InfoManager.GetServerVersion)
                CBDatabase.DataSource = InfoManager.Databases
            Else
                LInfo.Text = String.Format(InfoText, THost.Text, TPort.Text, "<font color=""Red"">Error</font>")
                CBDatabase.DataSource = Nothing
            End If
        End If
    End Sub

    Private Sub TPassword_ButtonCustomClick(sender As Object, e As EventArgs) Handles TPassword.ButtonCustomClick
        Timer = New Timers.Timer(5000)
        Timer.Start()

        TPassword.UseSystemPasswordChar = False
    End Sub

    Private Sub Timer_Elapsed(sender As Object, e As Timers.ElapsedEventArgs) Handles Timer.Elapsed
        Timer.Stop()
        Timer.Dispose()

        If InvokeRequired Then
            Invoke(Sub()
                       TPassword.UseSystemPasswordChar = True
                   End Sub)
        Else
            TPassword.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub CBDatabase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBDatabase.SelectedIndexChanged
        InfoManager.SetDatabase(CBDatabase.Text)
    End Sub
End Class
