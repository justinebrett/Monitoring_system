Public Class Search

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Automated_Monitoring_System_for_Fun_Run.Enabled = True
        Automated_Monitoring_System_for_Fun_Run.Focus()
        Automated_Monitoring_System_for_Fun_Run.TSSL_statusmain.Text = "Main Form"
        Me.Hide()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SearchRecord()
        TextSearchItemValue.Text = ""
        ComboSearch.Text = ""
    End Sub

    Private Sub Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplaySearchRecord()
    End Sub
End Class