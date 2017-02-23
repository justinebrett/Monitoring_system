Imports MySql.Data.MySqlClient
Imports MySql.Data

Module _CODES_Delete

    Public Sub DeleteParticipantsRecord()

        Dim DPRString As String
        Dim DPRCommand As New MySqlCommand
        Dim DPRAdapter As New MySqlDataAdapter
        Dim DPRTable As New DataTable
        Dim DPRSource As New BindingSource

        Try
            If Delete.ComboDelete.SelectedIndex = 0 And Delete.CheckDeleteRecord.Checked = True Then
                Call connection()
                DPRString = " DELETE FROM thesisdb.runners_info WHERE Tag_num = '" & Delete.TextValueDelete.Text & "'"
                DPRCommand.CommandText = DPRString
                DPRCommand.Connection = conn
                DPRAdapter.SelectCommand = DPRCommand
                DPRAdapter.Fill(DPRTable)
                DPRSource.DataSource = DPRTable
                Delete.DataGridView1.DataSource = DPRSource
                DPRAdapter.Update(DPRTable)
                conn.Close()
            ElseIf Delete.ComboDelete.SelectedIndex = 0 And Delete.CheckDeleteAllRecord.Checked = True Then
                Call connection()
                DPRString = " DELETE FROM thesisdb.runners_info"
                DPRCommand.CommandText = DPRString
                DPRCommand.Connection = conn
                DPRAdapter.SelectCommand = DPRCommand
                DPRAdapter.Fill(DPRTable)
                DPRSource.DataSource = DPRTable
                Delete.DataGridView1.DataSource = DPRSource
                DPRAdapter.Update(DPRTable)
                conn.Close()
            ElseIf Delete.ComboDelete.SelectedIndex = 1 And Delete.CheckDeleteAllRecord.Checked = True Then

                Call connection()
                DPRString = " DELETE FROM thesisdb.station1"
                DPRCommand.CommandText = DPRString
                DPRCommand.Connection = conn
                DPRAdapter.SelectCommand = DPRCommand
                DPRAdapter.Fill(DPRTable)
                DPRSource.DataSource = DPRTable
                Delete.DataGridView1.DataSource = DPRSource
                DPRAdapter.Update(DPRTable)
                conn.Close()
            ElseIf Delete.ComboDelete.SelectedIndex = 2 And Delete.CheckDeleteAllRecord.Checked = True Then
                Call connection()
                DPRString = " DELETE FROM thesisdb.station2"
                DPRCommand.CommandText = DPRString
                DPRCommand.Connection = conn
                DPRAdapter.SelectCommand = DPRCommand
                DPRAdapter.Fill(DPRTable)
                DPRSource.DataSource = DPRTable
                Delete.DataGridView1.DataSource = DPRSource
                DPRAdapter.Update(DPRTable)
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        DisplayRecordToDelete()
    End Sub

    Public Sub DisplayRecordToDelete()

        Dim DRTDString As String
        Dim DRTDCommand As New MySqlCommand
        Dim DRTDAdapter As New MySqlDataAdapter
        Dim DRTDTable As New DataTable
        Dim DRTDSource As New BindingSource

        Try

            Call connection()
            DRTDString = "SELECT * FROM thesisdb.runners_info"
            DRTDCommand.CommandText = DRTDString
            DRTDCommand.Connection = conn
            DRTDAdapter.SelectCommand = DRTDCommand
            DRTDAdapter.Fill(DRTDTable)
            DRTDSource.DataSource = DRTDTable
            Delete.DataGridView1.DataSource = DRTDSource
            DRTDAdapter.Update(DRTDTable)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub DisplayStation1Record()

        Dim DSRString As String
        Dim DSRCommand As New MySqlCommand
        Dim DSRAdapter As New MySqlDataAdapter
        Dim DSRTable As New DataTable
        Dim DSRSource As New BindingSource

        Try
            Call connection()
            DSRString = "SELECT runners_info.Tag_num, runners_info.Bib_num, runners_info.F_name, runners_info.L_name, runners_info.Age, runners_info.Sex, station1.Time FROM runners_info, station1 WHERE runners_info.Tag_num = station1.Identifier_number ORDER BY station1.Time"
            DSRCommand.CommandText = DSRString
            DSRCommand.Connection = conn
            DSRAdapter.SelectCommand = DSRCommand
            DSRAdapter.Fill(DSRTable)
            DSRSource.DataSource = DSRTable
            Delete.DataGridView1.DataSource = DSRSource
            DSRAdapter.Update(DSRTable)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub DisplayStation2Record()

        Dim DSRString As String
        Dim DSRCommand As New MySqlCommand
        Dim DSRAdapter As New MySqlDataAdapter
        Dim DSRTable As New DataTable
        Dim DSRSource As New BindingSource

        Try
            Call connection()
            DSRString = "SELECT runners_info.Tag_num, runners_info.Bib_num, runners_info.F_name, runners_info.L_name, runners_info.Age, runners_info.Sex, station2.End_Time FROM runners_info, station2 WHERE runners_info.Tag_num = station2.Identifier_number2 ORDER BY station2.End_Time"
            DSRCommand.CommandText = DSRString
            DSRCommand.Connection = conn
            DSRAdapter.SelectCommand = DSRCommand
            DSRAdapter.Fill(DSRTable)
            DSRSource.DataSource = DSRTable
            Delete.DataGridView1.DataSource = DSRSource
            DSRAdapter.Update(DSRTable)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Module
