Public Class Final_Result

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Automated_Monitoring_System_for_Fun_Run.Enabled = True
        Automated_Monitoring_System_for_Fun_Run.Focus()
        Automated_Monitoring_System_for_Fun_Run.TSSL_statusmain.Text = "Main Form"
        Me.Hide()
    End Sub

    Private Sub Final_Result_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FinalResultDisplay()
    End Sub

    Private Sub DataGridView1_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles DataGridView1.RowPostPaint

    End Sub

    Private Sub MonitoringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonitoringToolStripMenuItem.Click
        Activity_Monitoring.Show()
        Activity_Monitoring.Focus()
        Automated_Monitoring_System_for_Fun_Run.TSSL_statusmain.Text = "Monitoring"
        Me.Hide()
    End Sub
End Class