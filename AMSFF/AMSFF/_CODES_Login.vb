Imports MySql.Data.MySqlClient

Module _CODES_Login
    Public Sub LoginEntered()

        Dim data_set_login As New DataSet
        Dim cmd_login As New MySqlCommand
        Dim adapter_login As New MySqlDataAdapter
        Dim string_sql_login As String
        Dim data_table_login As New DataTable


        _CODES_Connection.connection()
        string_sql_login = "SELECT * FROM `account` WHERE `password` = '" & thelogin.textPassword.Text & "' AND `username` = '" & thelogin.textUsername.Text & "';"
        cmd_login.CommandText = string_sql_login
        cmd_login.Connection = conn
        adapter_login.SelectCommand = cmd_login
        adapter_login.Fill(data_table_login)
        conn.Close()

        Try
            If thelogin.textPassword.Text = data_table_login.Rows(0).Item(2).ToString And thelogin.textUsername.Text = data_table_login.Rows(0).Item(1).ToString Then
                MsgBox("Welcome to the System! ", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Access Granted!")
                Automated_Monitoring_System_for_Fun_Run.Show()
                Automated_Monitoring_System_for_Fun_Run.Enabled = True
                Automated_Monitoring_System_for_Fun_Run.Focus()
                Automated_Monitoring_System_for_Fun_Run.Timer1.Enabled = True
                Automated_Monitoring_System_for_Fun_Run.TSSL_Waiting.Text = "Admin"
                Automated_Monitoring_System_for_Fun_Run.TSSL_statusmain.Text = "Main Form"
                thelogin.Hide()
            Else
                MsgBox("Account Not Registered! ", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Access Denied!")

                thelogin.Hide()
                thelogin.textUsername.Clear()
                thelogin.textPassword.Clear()

            End If
        Catch ex As Exception
            MsgBox("Not a Registered Account!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Access Denied!")

        End Try


    End Sub


End Module
