Imports MySql.Data.MySqlClient
Imports MySql.Data

Module _CODES_Arduino

    Public Sub InsertArduinoMonitoringActivity()

        Dim IDMGString As String
        Dim IDMGCommand As New MySqlCommand
        Dim IDMGAdpater As New MySqlDataAdapter
        Dim IDMGTable As New DataTable
        Dim IDMGSource As New BindingSource

        Try
            If (Activity_Monitoring.LBLStation.Text = "1") Then
                Call connection()
                IDMGString = "INSERT INTO thesisdb.station1(`Identifier_number`,`Time`) VALUES('" & Activity_Monitoring.LBLtagnum.Text & "','" & Activity_Monitoring.LBLtime.Text & "')"
                IDMGCommand.CommandText = IDMGString
                IDMGCommand.Connection = conn
                IDMGAdpater.SelectCommand = IDMGCommand
                IDMGAdpater.Fill(IDMGTable)
                IDMGSource.DataSource = IDMGTable
                Activity_Monitoring.DataGridView1.DataSource = IDMGSource
                IDMGAdpater.Update(IDMGTable)
                conn.Close()
            Else  '(Activity_Monitoring.LBLStation.Text = "2") Then
                Call connection()
                IDMGString = "INSERT INTO thesisdb.station2(`Identifier_number2`,`End_Time`) VALUES('" & Activity_Monitoring.LBLtagnum.Text & "','" & Activity_Monitoring.LBLtime.Text & "')"
                IDMGCommand.CommandText = IDMGString
                IDMGCommand.Connection = conn
                IDMGAdpater.SelectCommand = IDMGCommand
                IDMGAdpater.Fill(IDMGTable)
                IDMGSource.DataSource = IDMGTable
                Activity_Monitoring.DataGridView2.DataSource = IDMGSource
                IDMGAdpater.Update(IDMGTable)
                conn.Close()
                DisplaySavedData2()
            End If
            DisplaySavedData()
        Catch ex As Exception

        End Try

    End Sub

    Public Sub DisplaySavedData()

        Dim DSDString As String
        Dim DSDCommand As New MySqlCommand
        Dim DSDAdapter As New MySqlDataAdapter
        Dim DSDTable As New DataTable
        Dim DSDSource As New BindingSource

        Try
            Call connection()
            DSDString = "SELECT runners_info.Tag_num, runners_info.Bib_num, runners_info.F_name, runners_info.L_name, runners_info.Sex ,station1.Time FROM runners_info, station1 WHERE runners_info.Tag_num = station1.Identifier_number"
            DSDCommand.CommandText = DSDString
            DSDCommand.Connection = conn
            DSDAdapter.SelectCommand = DSDCommand
            DSDAdapter.Fill(DSDTable)
            DSDSource.DataSource = DSDTable
            Activity_Monitoring.DataGridView1.DataSource = DSDSource
            DSDAdapter.Update(DSDTable)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub DisplaySavedData2()

        Dim DSDString As String
        Dim DSDCommand As New MySqlCommand
        Dim DSDAdapter As New MySqlDataAdapter
        Dim DSDTable As New DataTable
        Dim DSDSource As New BindingSource

        Try
            Call connection()
            DSDString = "SELECT runners_info.Tag_num, runners_info.Bib_num, runners_info.F_name, runners_info.L_name, runners_info.Sex ,station2.End_Time FROM runners_info, station2 WHERE runners_info.Tag_num = station2.Identifier_number2"
            DSDCommand.CommandText = DSDString
            DSDCommand.Connection = conn
            DSDAdapter.SelectCommand = DSDCommand
            DSDAdapter.Fill(DSDTable)
            DSDSource.DataSource = DSDTable
            Activity_Monitoring.DataGridView2.DataSource = DSDSource
            DSDAdapter.Update(DSDTable)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub FinalResultDisplay()

        Dim FRDString As String
        Dim FRDCommand As New MySqlCommand
        Dim FRDAdapter As New MySqlDataAdapter
        Dim FRDTable As New DataTable
        Dim FRDSource As New BindingSource

        ' UNION ALL SELECT
        Try
            Call connection()
            '            FRDString = "SELECT runners_info.Tag_num, runners_info.Bib_num, runners_info.F_name, runners_info.L_name, runners_info.Sex ,station2.End_Time FROM runners_info, station2 WHERE runners_info.Tag_num = station2.Identifier_number2 ORDER BY End_Time"
            FRDString = " SELECT runners_info.Tag_num, runners_info.Bib_num, runners_info.F_name, runners_info.L_name, runners_info.Sex, runners_info.Age, station2.End_Time FROM runners_info INNER JOIN station1 ON runners_info.Tag_num = station1.Identifier_number INNER JOIN station2 ON station2.Identifier_number2 = station1.Identifier_number ORDER BY station2.End_Time "

            FRDCommand.CommandText = FRDString
            FRDCommand.Connection = conn
            FRDAdapter.SelectCommand = FRDCommand
            FRDAdapter.Fill(FRDTable)
            FRDSource.DataSource = FRDTable
            Final_Result.DataGridView1.DataSource = FRDSource
            FRDAdapter.Update(FRDTable)
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub DisplayDisqualifiedPlayers()

        Dim DDPString As String
        Dim DDPCommand As New MySqlCommand
        Dim DDPAdapter As New MySqlDataAdapter
        Dim DDPTable As New DataTable
        Dim DDPSource As New BindingSource

        Try
            Call connection()
            '  DDPString = "SELECT station2.* FROM station2 LEFT JOIN station1 ON station2.Identifier_number2 = station1.Identifier_number WHERE station1.Identifier_number IS NULL AND station2.Identifier_number2 IS NOT NULL"
            DDPString = " SELECT runners_info.Tag_num, runners_info.Bib_num, runners_info.F_name, runners_info.L_name, runners_info.Sex, runners_info.Age, station2.End_Time FROM runners_info LEFT JOIN station2 ON runners_info.Tag_num = station2.Identifier_number2 LEFT JOIN station1 ON station1.Identifier_number = station2.Identifier_number2 WHERE station1.Identifier_number IS NULL AND station2.Identifier_number2 IS NOT NULL"

            DDPCommand.CommandText = DDPString
            DDPCommand.Connection = conn
            DDPAdapter.SelectCommand = DDPCommand
            DDPAdapter.Fill(DDPTable)
            DDPSource.DataSource = DDPTable
            Final_Result.DataGridView2.DataSource = DDPSource
            DDPAdapter.Update(DDPTable)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
  
End Module
