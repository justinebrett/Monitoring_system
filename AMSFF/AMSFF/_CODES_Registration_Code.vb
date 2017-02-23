Imports MySql.Data.MySqlClient
Imports MySql.Data.MySqlClient.MySqlParameter
Module _CODES_Registration_Code
    Dim dataTable_insert As New DataTable
    Dim dtr, dt As New DateTime
    Dim sqlAdapter As New MySqlDataAdapter
    Dim sqlcmd1 As New MySqlCommand
    Dim Insert_Runner As String

    Public Sub Add_Runner()
        Try
            _CODES_Connection.connection()


            Insert_Runner = " INSERT INTO `thesisdb`.`runners_info`(`Tag_num`,`F_name`,`M_I`,`L_name`,`Age`,`Sex`,`Bib_num`,`Date`,`BirthDate`,`Contact`) VALUES ('" & Form1.ComboTag.Text & "','" & Form1.textName.Text & "','" & Form1.textMI.Text & "','" & Form1.textLName.Text & "','" & Form1.textAge.Text & "','" & Form1.ComboSex.Text & "','" & Form1.textBib.Text & "','" & Form1.DateTimePicker1.Value.Date & "','" & Form1.DateTimePicker2.Value.Date & "','" & Form1.textContact.Text & "')"
            sqlcmd1.CommandText() = Insert_Runner
            sqlcmd1.Connection = conn
            sqlAdapter.SelectCommand = sqlcmd1
            sqlAdapter.Fill(dataTable_insert)
            conn.Close()
            MessageBox.Show("Successfully Inserted to database")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Display_Record()

        Dim DRString As String
        Dim DRCommand As New MySqlCommand
        Dim DRAdpater As New MySqlDataAdapter
        Dim DRTable As New DataTable
        Dim DRSource As New BindingSource

        Try
            connection()
            DRString = "SELECT * FROM thesisdb.runners_info"
            DRCommand.CommandText = DRString
            DRCommand.Connection = conn
            DRAdpater.SelectCommand = DRCommand
            DRAdpater.Fill(DRTable)
            DRSource.DataSource = DRTable
            Form1.DataGridView1.DataSource = DRSource
            DRAdpater.Update(DRTable)

        Catch ex As Exception

        End Try
    End Sub

End Module
