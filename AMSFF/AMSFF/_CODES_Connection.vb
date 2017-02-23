Imports MySql.Data.MySqlClient
Module _CODES_Connection
    Public conn As New MySqlConnection

    Public Sub connection()
        If conn.State = ConnectionState.Closed Then
            conn.ConnectionString = "server=localhost; userid=root; password=; database=thesisdb; port=3306"
            conn.Open()
        End If
    End Sub

End Module
