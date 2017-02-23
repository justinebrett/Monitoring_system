Public Class WebCamera

    Dim Mycam As New _CODES_iCam

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        _CODES_CodesForWebCam.ResetCamera()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        _CODES_CodesForWebCam.Shot()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        _CODES_CodesForWebCam.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        _CODES_CodesForWebCam.Shot()
    End Sub

    Private Sub WebCamera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Form1.Show()
    End Sub
End Class