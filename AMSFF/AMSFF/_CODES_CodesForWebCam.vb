Module _CODES_CodesForWebCam
    Dim Mycam As New _CODES_iCam

    Public Sub OpenCam()
        Mycam.initCam(WebCamera.PictureBox1.Handle.ToInt32)

    End Sub

    Public Sub ResetCamera()
        Mycam.resetCam()
    End Sub

    Public Sub Shot()
        ' Form1.PictureBox1.Image = Mycam.copyFrame(Form1.PictureBox1, New RectangleF(0, 0, (Form1.PictureBox1.Height), Form1.PictureBox1.Width()))


    End Sub

    Public Sub Close()
        WebCamera.Hide()
        Form1.Show()
        Mycam.closeCam()

    End Sub

End Module
