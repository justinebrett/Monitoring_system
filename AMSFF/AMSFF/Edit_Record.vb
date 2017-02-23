Public Class Edit_Record

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Automated_Monitoring_System_for_Fun_Run.Enabled = True
        Automated_Monitoring_System_for_Fun_Run.Focus()
        Automated_Monitoring_System_for_Fun_Run.TSSL_statusmain.Text = "Main Form"
        Me.Hide()

    End Sub

    Private Sub Edit_Record_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayEditRecord()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            ComboTag.Text = row.Cells("Tag_num").Value.ToString
            textBib.Text = row.Cells("Bib_num").Value.ToString
            textName.Text = row.Cells("F_name").Value.ToString
            textMI.Text = row.Cells("M_I").Value.ToString
            textLName.Text = row.Cells("L_name").Value.ToString
            textAge.Text = row.Cells("Age").Value.ToString
            ComboSex.Text = row.Cells("Sex").Value.ToString
            textContact.Text = row.Cells("Contact").Value.ToString
            DateTimePicker1.Text = row.Cells("Date").Value.ToString
            DateTimePicker2.Text = row.Cells("BirthDate").Value.ToString
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        textAge.Text = ""
        textBib.Text = ""
        textName.Text = ""
        textContact.Text = ""
        textMI.Text = ""
        textLName.Text = ""
        ComboSex.Text = ""
        ComboTag.Text = ""
    End Sub

    Private Sub bRegister_Click(sender As Object, e As EventArgs) Handles bRegister.Click
        Update_Record()
    End Sub
End Class