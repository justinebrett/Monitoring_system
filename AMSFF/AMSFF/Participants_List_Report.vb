Public Class Participants_List_Report

    Private Sub ReportViewer_FinalResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'thesisdbDataSet.runners_info' table. You can move, or remove it, as needed.
        Me.runners_infoTableAdapter.Fill(Me.thesisdbDataSet.runners_info)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Automated_Monitoring_System_for_Fun_Run.Enabled = True
        Automated_Monitoring_System_for_Fun_Run.Focus()
        Automated_Monitoring_System_for_Fun_Run.TSSL_statusmain.Text = "Main Form"
        Me.Hide()
    End Sub

   
End Class