Imports MySql.Data.MySqlClient
Imports MySql.Data

Module _CODES_Edit_Record

    Public Sub DisplayEditRecord()

        Dim DERString As String
        Dim DERCommand As New MySqlCommand
        Dim DERAdapter As New MySqlDataAdapter
        Dim DERTable As New DataTable
        Dim DERSource As New BindingSource

        Try

            connection()

            DERString = "SELECT * FROM thesisdb.runners_info"
            DERCommand.CommandText = DERString
            DERCommand.Connection = conn
            DERAdapter.SelectCommand = DERCommand
            DERAdapter.Fill(DERTable)
            DERSource.DataSource = DERTable
            Edit_Record.DataGridView1.DataSource = DERSource
            DERAdapter.Update(DERTable)
            conn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub Update_Record()

        Dim URString As String
        Dim URCommand As New MySqlCommand
        Dim URAdapter As New MySqlDataAdapter
        Dim URTable As New DataTable
        Dim URSource As New BindingSource

        Try
            connection()
            URString = "UPDATE runners_info SET runners_info.Tag_num = '" & Edit_Record.ComboTag.Text & "', runners_info.Bib_num = '" & Edit_Record.textBib.Text & "', runners_info.F_name= '" & Edit_Record.textName.Text & "', runners_info.M_I='" & Edit_Record.textMI.Text & "', runners_info.L_name = '" & Edit_Record.textLName.Text & "', runners_info.Age = '" & Edit_Record.textAge.Text & "', runners_info.Sex = '" & Edit_Record.ComboSex.Text & "', runners_info.Contact = '" & Edit_Record.textContact.Text & "', runners_info.Date = '" & Edit_Record.DateTimePicker1.Text & "', runners_info.BirthDate = '" & Edit_Record.DateTimePicker2.Text & "' WHERE runners_info.Tag_num = '" & Edit_Record.ComboTag.Text & "'"
            URCommand.CommandText = URString
            URCommand.Connection = conn
            URAdapter.SelectCommand = URCommand
            URAdapter.Fill(URTable)
            URSource.DataSource = URTable
            Edit_Record.DataGridView1.DataSource = URSource
            URAdapter.Update(URTable)
            conn.Close()
            MessageBox.Show("Record successfully updated.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        DisplayEditRecord()
    End Sub
End Module
