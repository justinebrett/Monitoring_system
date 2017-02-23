Public Class Runners_List

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        viewRecord()
    End Sub

    Private Sub Runners_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDatas_Click(sender As Object, e As EventArgs) Handles btnDatas.Click
        Me.Hide()
        Monitoring.Show()
    End Sub
End Class