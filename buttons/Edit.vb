Public Class Edit
    Dim webAddress As String = "twitter.com/ndexis"
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Dim f1 As New Form1()

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - mousex
            Me.Top = Cursor.Position.Y - mousey
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("chrome.exe", webAddress)
    End Sub

    ' ###  ###  ###  ###  ###  ###  ###  ###  ###

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If f1.tracker = 1 Then
            f1.Panel1_Link = TextBox1.Text
        ElseIf f1.tracker = 2 Then
            f1.Panel2_Link = TextBox1.Text
        ElseIf f1.tracker = 3 Then
            f1.Panel3_Link = TextBox1.Text
        ElseIf f1.tracker = 4 Then
            f1.Panel4_Link = TextBox1.Text
        ElseIf f1.tracker = 5 Then
            f1.Panel5_Link = TextBox1.Text
        ElseIf f1.tracker = 7 Then
            f1.Panel7_Link = TextBox1.Text
        ElseIf f1.tracker = 8 Then
            f1.Panel8_Link = TextBox1.Text
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Form1.TopMost = True
        Else
            Form1.TopMost = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class