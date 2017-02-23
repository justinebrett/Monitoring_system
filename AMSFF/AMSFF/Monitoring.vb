Imports MySql.Data.MySqlClient
Imports System.Data.Common.DataAdapter
Imports MySql.Data
Imports System
Imports System.IO.Ports
Imports MySql.Data.MySqlClient.MySqlParameter

'Imports System.Data.SqlClient

Public Class Monitoring
    Dim comPORT As String
    Dim receivedData As String = ""

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        comPORT = ""
        For Each sp As String In My.Computer.Ports.SerialPortNames
            comPort_ComboBox.Items.Add(sp)
        Next
    End Sub


    Private Sub comPort_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comPort_ComboBox.SelectedIndexChanged
        If (comPort_ComboBox.SelectedItem <> "") Then
            comPORT = comPort_ComboBox.SelectedItem
        End If
    End Sub


    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Try


            If (btnConnect.Text = "Connect") Then
                If (comPORT <> "") Then
                    SerialPort1.Close()
                    SerialPort1.PortName = comPORT
                    SerialPort1.BaudRate = 9600
                    SerialPort1.DataBits = 8
                    SerialPort1.Parity = Parity.None
                    SerialPort1.StopBits = StopBits.One
                    SerialPort1.Handshake = Handshake.None
                    SerialPort1.Encoding = System.Text.Encoding.Default
                    SerialPort1.ReadTimeout = 10000

                    SerialPort1.Open()
                    btnConnect.Text = "Dis-connect"
                    Timer1.Enabled = True
                    Timer_LBL.Text = "Timer: ON"
                Else
                    MsgBox("Select a COM port first")
                End If
            Else
                SerialPort1.Close()
                btnConnect.Text = "Connect"
                Timer1.Enabled = False
                Timer_LBL.Text = "Timer: OFF"
            End If
        Catch ex As UnauthorizedAccessException

        End Try

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        receivedData = ReceiveSerialData()
        Label2.Text &= receivedData
        Try
            If (Label2.Text IsNot "") Then
                SplitData()
                InsertArduinoData()
                Label2.Text = ""
                ArduinoListView()
                ListView1.Refresh()

            End If

        Catch ex As IndexOutOfRangeException

        End Try

    End Sub


    Function ReceiveSerialData() As String
        Dim Incoming As String
        Try
            Incoming = SerialPort1.ReadExisting()
            If Incoming Is Nothing Then
                Return "nothing" & vbCrLf
            Else
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out."
        End Try

    End Function


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        RichTextBox1.Text = ""
    End Sub

    Private Sub InsertArduinoData()


        Dim ArduinoCommand As New MySqlCommand
        Dim ArduinoAdapter As New MySqlDataAdapter
        Dim ArduinoString As String
        Dim ArduinoTable As New DataTable

        Try
            _CODES_Connection.connection()

            ArduinoString = "INSERT INTO station(Station1,Time1)VALUES('" & Me.Label4.Text & "','" & Me.Label5.Text & "')"
            ArduinoCommand.CommandText = ArduinoString
            ArduinoCommand.Connection = conn
            ArduinoAdapter.SelectCommand = ArduinoCommand
            ArduinoAdapter.Fill(ArduinoTable)
            conn.Close()

            ' DataGridView1.DataSource = ArduinoTable
        Catch ex As SqlClient.SqlException
            MessageBox.Show("Error Inserting Data")
        End Try
    End Sub

    Private Sub SplitData()
        Try

            Dim StringList As String = Label2.Text
            Dim ArrayList() As String = StringList.Split(",")

            Label4.Text = ArrayList(0)
            Label5.Text = ArrayList(1)

        Catch ex As IndexOutOfRangeException

        End Try
    End Sub

    Private Sub ArduinoListView()

        Dim ArduioQuery As String = "select * from station"
        Dim ArduinosAdapter As New MySqlDataAdapter
        Dim ArduinosCommand As New MySqlCommand
        Dim ArduinoSqlTable As New DataTable
        Dim i As Integer

        With ArduinosCommand
            .CommandText = ArduioQuery
            .Connection = conn

        End With

        With ArduinosAdapter
            .SelectCommand = ArduinosCommand
            .Fill(ArduinoSqlTable)

        End With

        For i = 0 To ArduinoSqlTable.Rows.Count - 1
            With ListView1
                .Items.Add(ArduinoSqlTable.Rows(i)("Runners_ID"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(ArduinoSqlTable.Rows(i)("Station1"))
                    .Add(ArduinoSqlTable.Rows(i)("Time1"))
                    .Add(ArduinoSqlTable.Rows(i)("Station2"))
                    .Add(ArduinoSqlTable.Rows(i)("Time2"))

                End With
            End With
        Next
        conn.Close()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = "1,3"
        SplitData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        InsertArduinoData()
        ArduinoListView()
    End Sub
End Class