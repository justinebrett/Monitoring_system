Imports System.IO.Ports

Public Class Activity_Monitoring

    Dim comPort As String
    Dim receivedData As String = ""

    Private Sub Activity_Monitoring_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        comPort = ""
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComboPort.Items.Add(sp)
        Next
        ' DisplaySavedData()
        ' DisplaySavedData2()
    End Sub



    Private Sub ComboPort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboPort.SelectedIndexChanged
        If (ComboPort.SelectedItem <> "") Then
            comPort = ComboPort.SelectedItem
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            If (Button1.Text = "Connect") Then
                If (comPort <> "") Then
                    SerialPort1.Close()
                    SerialPort1.PortName = comPort
                    SerialPort1.BaudRate = 9600
                    SerialPort1.DataBits = 8
                    SerialPort1.Parity = Parity.None
                    SerialPort1.StopBits = StopBits.One
                    SerialPort1.Handshake = Handshake.None
                    SerialPort1.Encoding = System.Text.Encoding.Default
                    SerialPort1.ReadTimeout = 10000

                    SerialPort1.Open()
                    Button1.Text = "Dis-Connect"
                    Timer1.Enabled = True
                    Timer_LBL.Text = "TIMER : ON"
                Else
                    MsgBox("Select a COM port first")
                End If
            Else
                SerialPort1.Close()
                Button1.Text = "Connect"
                Timer1.Enabled = False
                Timer_LBL.Text = "TIMER : OFF"

            End If
        Catch ex As UnauthorizedAccessException
            MessageBox.Show(ex.ToString)

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        receivedData = ReceivedSerialData()
        LBLreceived.Text &= receivedData
        If (LBLreceived.Text IsNot "") Then
            SplitMyData()
            InsertArduinoMonitoringActivity()
            LBLreceived.Text = ""
            LBLtagnum.Text = ""
            LBLStation.Text = ""
            LBLtime.Text = ""
        End If
    End Sub

    Function ReceivedSerialData() As String
        Dim Incoming As String
        Try
            Incoming = SerialPort1.ReadExisting()
            If Incoming Is Nothing Then
                Return "nothing" & vbCrLf
            Else
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Error : Serial Port read timed out."

        End Try
    End Function

    Private Sub SplitMyData()

        Try


            Dim StringList As String = LBLreceived.Text
            Dim arrList() As String = StringList.Split(",")

            LBLStation.Text = arrList(0)
            LBLtagnum.Text = arrList(1)
            LBLtime.Text = arrList(2)

        Catch ex As IndexOutOfRangeException

        End Try
    End Sub

   

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Automated_Monitoring_System_for_Fun_Run.Enabled = True
        Automated_Monitoring_System_for_Fun_Run.Focus()
        Automated_Monitoring_System_for_Fun_Run.TSSL_statusmain.Text = "Main Form"
        Me.Hide()
    End Sub

  

    Private Sub FinalResultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinalResultToolStripMenuItem.Click
        Final_Result.Show()
        Final_Result.Focus()
        DisplayDisqualifiedPlayers()
        Automated_Monitoring_System_for_Fun_Run.TSSL_statusmain.Text = "Final Result"
        Me.Hide()
    End Sub

  
End Class