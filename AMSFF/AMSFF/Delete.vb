Public Class Delete

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Automated_Monitoring_System_for_Fun_Run.Enabled = True
        Automated_Monitoring_System_for_Fun_Run.Focus()
        Automated_Monitoring_System_for_Fun_Run.TSSL_statusmain.Text = "Main Form"
        ComboDelete.Text = ""
        Me.TextValueDelete.Text = ""
        CheckDeleteAllRecord.Checked = False
        CheckDeleteRecord.Checked = False
        Me.Hide()

    End Sub

    Private Sub btnDeletee_Click(sender As Object, e As EventArgs) Handles btnDeletee.Click
        MsgBox("All record deleted! ", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        DeleteParticipantsRecord()
        TextValueDelete.Text = ""
        ComboDelete.Text = ""
    End Sub

    Private Sub Delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DisplayRecordToDelete()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DisplayStation1Record()
        DataGridView1.Refresh()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DisplayStation2Record()
        DataGridView1.Refresh()
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub ComboDelete_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboDelete.SelectedIndexChanged
        If ComboDelete.SelectedIndex = 1 Then
            Me.CheckDeleteRecord.Visible = False
        ElseIf ComboDelete.SelectedIndex = 2 Then
            Me.CheckDeleteRecord.Visible = False
        Else
            CheckDeleteAllRecord.Visible = True
            CheckDeleteRecord.Visible = True

        End If
    End Sub
End Class