Public Class Form1
    Dim input As String
    Dim api As String = "https://api.qrserver.com/v1/create-qr-code/?size=150x150&data="
    Dim qr As String
    Dim userPath As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\AppData\Local\Temp" + "\qr_temp.jpg"

    Dim webAddress As String = "https://twitter.com/ndexis"
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Dim fs As System.IO.FileStream

    Private Sub WaterMark(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start(webAddress)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown, Label1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove, Label1.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - mousex
            Me.Top = Cursor.Position.Y - mousey
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp, Label1.MouseUp
        drag = False
    End Sub

    Private Sub ProgressBar1_Enter(sender As Object, e As EventArgs) Handles ProgressBar1.Enter

    End Sub
End Class
