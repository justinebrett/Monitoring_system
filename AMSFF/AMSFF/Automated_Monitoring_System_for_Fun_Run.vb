Public Class Automated_Monitoring_System_for_Fun_Run

   
    Private Sub RegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrationToolStripMenuItem.Click
        Form1.Show()
        Form1.Focus()
        TSSL_statusmain.Text = "Registration Form"
        Me.Enabled = False
    End Sub

    Private Sub Automated_Monitoring_System_for_Fun_Run_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TSSL_Clock.Text = TimeOfDay
        TSSL_today.Text = Today
    End Sub

    Private Sub InformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformationToolStripMenuItem.Click
        Edit_Record.Show()
        Edit_Record.Focus()
        TSSL_statusmain.Text = "Edit Form"
        Me.Enabled = False
    End Sub

    Private Sub RecordToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RecordToolStripMenuItem1.Click
        Search.Show()
        Search.Focus()
        TSSL_statusmain.Text = "Search"
        Me.Enabled = False
    End Sub

    Private Sub RecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecordToolStripMenuItem.Click
        Delete.Show()
        Delete.Focus()
        Delete.Refresh()
        TSSL_statusmain.Text = "Delete Section"
        Me.Enabled = False
    End Sub

    Private Sub MonitoringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonitoringToolStripMenuItem.Click
        Activity_Monitoring.Show()
        Activity_Monitoring.Focus()
        TSSL_statusmain.Text = "Monitoring"
        Me.Enabled = False
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        thelogin.Show()
        thelogin.Focus()
        Me.Enabled = False
        Timer1.Enabled = False
        TSSL_Waiting.Text = "Waiting..."
        TSSL_statusmain.Text = "System Disabled"
    End Sub

    Private Sub CreateParticipantsReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateParticipantsReportToolStripMenuItem.Click
        Participants_List_Report.Show()
        Participants_List_Report.Focus()
        TSSL_statusmain.Text = "Report Viewer"
        Me.Enabled = False
    End Sub
End Class