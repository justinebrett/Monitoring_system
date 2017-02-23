Public Class thelogin

    Private Sub textLogin_TextChanged(sender As Object, e As EventArgs) Handles textUsername.TextChanged

    End Sub

    Private Sub bLogin_Click(sender As Object, e As EventArgs) Handles bLogin.Click
        LoginEntered()
        textUsername.Text = ""
        textPassword.Text = ""

    End Sub

    Private Sub thelogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Automated_Monitoring_System_for_Fun_Run.Show()
        Automated_Monitoring_System_for_Fun_Run.Enabled = False
        Automated_Monitoring_System_for_Fun_Run.TSSL_statusmain.Text = "System Disabled"
    End Sub
End Class