Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.DateTime

Module _CODES_runners_list_code


    Public Sub viewRecord()



        Dim squery As String = "select * from runners_info"
        Dim sadapter As New MySqlDataAdapter
        Dim scommand As New MySqlCommand
        Dim sqltable As New DataTable
        Dim i As Integer

        With scommand
            .CommandText = squery
            .Connection = conn

        End With

        With sadapter
            .SelectCommand = scommand
            .Fill(sqltable)

        End With

        For i = 0 To sqltable.Rows.Count - 1
            With Runners_List.ListView1
                .Items.Add(sqltable.Rows(i)("Runners_ID"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(sqltable.Rows(i)("Tag_num"))
                    .Add(sqltable.Rows(i)("Bib_num"))
                    .Add(sqltable.Rows(i)("F_name"))
                    .Add(sqltable.Rows(i)("M_I"))
                    .Add(sqltable.Rows(i)("L_name"))
                    .Add(sqltable.Rows(i)("Age"))
                    .Add(sqltable.Rows(i)("Sex"))
                    .Add(sqltable.Rows(i)("Date"))
                    .Add(sqltable.Rows(i)("BirthDate"))

                End With
            End With
        Next
        conn.Close()
        Runners_List.ListView1.Refresh()
    End Sub
End Module
