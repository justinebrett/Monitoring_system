Imports MySql.Data.MySqlClient
Imports MySql.Data

Module _CODES_Search

    Public Sub SearchRecord()

        Dim SRString As String
        Dim SRCommand As New MySqlCommand
        Dim SRAdapter As New MySqlDataAdapter
        Dim SRTable As New DataTable
        Dim SRSource As New BindingSource

        Try
            If (Search.ComboBox1.SelectedIndex = 0) Then
                If Search.ComboSearch.SelectedIndex = 0 Then
                    Call connection()
                    SRString = " SELECT * FROM thesisdb.runners_info WHERE Tag_num = '" & Search.TextSearchItemValue.Text & "'"
                    SRCommand.CommandText = SRString
                    SRCommand.Connection = conn
                    SRAdapter.SelectCommand = SRCommand
                    SRAdapter.Fill(SRTable)
                    SRSource.DataSource = SRTable
                    Search.DataGridView1.DataSource = SRSource
                    SRAdapter.Update(SRTable)
                    conn.Close()
                ElseIf Search.ComboSearch.SelectedIndex = 1 Then
                    Call connection()
                    SRString = " SELECT * FROM thesisdb.runners_info WHERE Bib_num = '" & Search.TextSearchItemValue.Text & "'"
                    SRCommand.CommandText = SRString
                    SRCommand.Connection = conn
                    SRAdapter.SelectCommand = SRCommand
                    SRAdapter.Fill(SRTable)
                    SRSource.DataSource = SRTable
                    Search.DataGridView1.DataSource = SRSource
                    SRAdapter.Update(SRTable)
                    conn.Close()
                ElseIf Search.ComboSearch.SelectedIndex = 2 Then
                    Call connection()
                    SRString = " SELECT * FROM thesisdb.runners_info WHERE F_name = '" & Search.TextSearchItemValue.Text & "'"
                    SRCommand.CommandText = SRString
                    SRCommand.Connection = conn
                    SRAdapter.SelectCommand = SRCommand
                    SRAdapter.Fill(SRTable)
                    SRSource.DataSource = SRTable
                    Search.DataGridView1.DataSource = SRSource
                    SRAdapter.Update(SRTable)
                    conn.Close()
                ElseIf Search.ComboSearch.SelectedIndex = 3 Then
                    Call connection()
                    SRString = " SELECT * FROM thesisdb.runners_info WHERE M_I = '" & Search.TextSearchItemValue.Text & "'"
                    SRCommand.CommandText = SRString
                    SRCommand.Connection = conn
                    SRAdapter.SelectCommand = SRCommand
                    SRAdapter.Fill(SRTable)
                    SRSource.DataSource = SRTable
                    Search.DataGridView1.DataSource = SRSource
                    SRAdapter.Update(SRTable)
                    conn.Close()
                ElseIf Search.ComboSearch.SelectedIndex = 4 Then
                    Call connection()
                    SRString = " SELECT * FROM thesisdb.runners_info WHERE L_name = '" & Search.TextSearchItemValue.Text & "'"
                    SRCommand.CommandText = SRString
                    SRCommand.Connection = conn
                    SRAdapter.SelectCommand = SRCommand
                    SRAdapter.Fill(SRTable)
                    SRSource.DataSource = SRTable
                    Search.DataGridView1.DataSource = SRSource
                    SRAdapter.Update(SRTable)
                    conn.Close()
                ElseIf Search.ComboSearch.SelectedIndex = 5 Then
                    Call connection()
                    SRString = " SELECT * FROM thesisdb.runners_info WHERE Age = '" & Search.TextSearchItemValue.Text & "'"
                    SRCommand.CommandText = SRString
                    SRCommand.Connection = conn
                    SRAdapter.SelectCommand = SRCommand
                    SRAdapter.Fill(SRTable)
                    SRSource.DataSource = SRTable
                    Search.DataGridView1.DataSource = SRSource
                    SRAdapter.Update(SRTable)
                    conn.Close()
                ElseIf Search.ComboSearch.SelectedIndex = 6 Then
                    Call connection()
                    SRString = " SELECT * FROM thesisdb.runners_info WHERE Sex = '" & Search.TextSearchItemValue.Text & "'"
                    SRCommand.CommandText = SRString
                    SRCommand.Connection = conn
                    SRAdapter.SelectCommand = SRCommand
                    SRAdapter.Fill(SRTable)
                    SRSource.DataSource = SRTable
                    Search.DataGridView1.DataSource = SRSource
                    SRAdapter.Update(SRTable)
                    conn.Close()
                ElseIf Search.ComboSearch.SelectedIndex = 7 Then
                    Call connection()
                    SRString = " SELECT * FROM thesisdb.runners_info WHERE Contact = '" & Search.TextSearchItemValue.Text & "'"
                    SRCommand.CommandText = SRString
                    SRCommand.Connection = conn
                    SRAdapter.SelectCommand = SRCommand
                    SRAdapter.Fill(SRTable)
                    SRSource.DataSource = SRTable
                    Search.DataGridView1.DataSource = SRSource
                    SRAdapter.Update(SRTable)
                    conn.Close()
                ElseIf Search.ComboSearch.SelectedIndex = 8 Then
                    Call connection()
                    SRString = " SELECT * FROM thesisdb.runners_info WHERE Date = '" & Search.TextSearchItemValue.Text & "'"
                    SRCommand.CommandText = SRString
                    SRCommand.Connection = conn
                    SRAdapter.SelectCommand = SRCommand
                    SRAdapter.Fill(SRTable)
                    SRSource.DataSource = SRTable
                    Search.DataGridView1.DataSource = SRSource
                    SRAdapter.Update(SRTable)
                    conn.Close()
                ElseIf Search.ComboSearch.SelectedIndex = 9 Then
                    Call connection()
                    SRString = " SELECT * FROM thesisdb.runners_info WHERE BirthDate = '" & Search.TextSearchItemValue.Text & "'"
                    SRCommand.CommandText = SRString
                    SRCommand.Connection = conn
                    SRAdapter.SelectCommand = SRCommand
                    SRAdapter.Fill(SRTable)
                    SRSource.DataSource = SRTable
                    Search.DataGridView1.DataSource = SRSource
                    SRAdapter.Update(SRTable)
                    conn.Close()
                End If
            ElseIf (Search.ComboBox1.SelectedIndex = 1) Then

                Call connection()
                SRString = "SELECT runners_info.Tag_num, runners_info.Bib_num, runners_info.F_name, runners_info.L_name, runners_info.Age, runners_info.Sex, station1.Time FROM runners_info, station1 WHERE station1.Identifier_number = '" & Search.TextSearchItemValue.Text & "' AND runners_info.Tag_num ='" & Search.TextSearchItemValue.Text & "'"
                SRCommand.CommandText = SRString
                SRCommand.Connection = conn
                SRAdapter.SelectCommand = SRCommand
                SRAdapter.Fill(SRTable)
                SRSource.DataSource = SRTable
                Search.DataGridView1.DataSource = SRSource
                SRAdapter.Update(SRTable)
                conn.Close()
            ElseIf (Search.ComboBox1.SelectedIndex = 2) Then

                Call connection()
                SRString = "SELECT runners_info.Tag_num, runners_info.Bib_num, runners_info.F_name, runners_info.L_name, runners_info.Age, runners_info.Sex, station2.End_Time FROM runners_info, station2 WHERE station2.Identifier_number2 = '" & Search.TextSearchItemValue.Text & "' AND runners_info.Tag_num ='" & Search.TextSearchItemValue.Text & "'"
                SRCommand.CommandText = SRString
                SRCommand.Connection = conn
                SRAdapter.SelectCommand = SRCommand
                SRAdapter.Fill(SRTable)
                SRSource.DataSource = SRTable
                Search.DataGridView1.DataSource = SRSource
                SRAdapter.Update(SRTable)
                conn.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub DisplaySearchRecord()
        Dim DSRString As String
        Dim DSRCommand As New MySqlCommand
        Dim DSRAdapter As New MySqlDataAdapter
        Dim DSRTable As New DataTable
        Dim DSRSource As New BindingSource

        Try
            Call connection()
            DSRString = "SELECT * FROM thesisdb.runners_info"
            DSRCommand.CommandText = DSRString
            DSRCommand.Connection = conn
            DSRAdapter.SelectCommand = DSRCommand
            DSRAdapter.Fill(DSRTable)
            DSRSource.DataSource = DSRTable
            Search.DataGridView1.DataSource = DSRSource
            DSRAdapter.Update(DSRTable)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Module
