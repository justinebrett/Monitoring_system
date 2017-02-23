Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display_Record()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bExit_Click(sender As Object, e As EventArgs)
        viewRecord()
        Me.Hide()
        Runners_List.Show()


    End Sub

    Private Sub bRegister_Click(sender As Object, e As EventArgs) Handles bRegister.Click
        If (textName.Text = "" And textAge.Text = "" And textLName.Text = "") Then
            MessageBox.Show("Fill out feilds first")

        Else

            Add_Runner()
            textName.Enabled = False
            textMI.Enabled = False
            textLName.Enabled = False
            textAge.Enabled = False
            textBib.Enabled = False
            textContact.Enabled = False
            ComboSex.Enabled = False
            ComboTag.Enabled = False
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
            Display_Record()
        End If

    End Sub

    Private Sub bTakeShot_Click(sender As Object, e As EventArgs)
        Me.Hide()
        WebCamera.Show()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        textName.Enabled = True
        textMI.Enabled = True
        textLName.Enabled = True
        textAge.Enabled = True
        textBib.Enabled = True
        textContact.Enabled = True
        ComboSex.Enabled = True
        ComboTag.Enabled = True
        DateTimePicker1.Enabled = True
        DateTimePicker2.Enabled = True 
    End Sub

   

    Private Sub RegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrationToolStripMenuItem.Click
        Automated_Monitoring_System_for_Fun_Run.Enabled = True
        Automated_Monitoring_System_for_Fun_Run.Focus()
        Automated_Monitoring_System_for_Fun_Run.TSSL_statusmain.Text = "Main Form"
        Me.Hide()
    End Sub
End Class
