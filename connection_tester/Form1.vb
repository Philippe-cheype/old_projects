Public Class Form1

    Dim webAddress As String = "twitter.com/ndexis"
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Dim connection As Boolean
    Dim pingValue As Integer = 0

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown, Label2.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove, Label2.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - mousex
            Me.Top = Cursor.Position.Y - mousey
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp, Label2.MouseUp
        drag = False
    End Sub

    Private Sub WaterMark(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("chrome.exe", webAddress)
    End Sub

    Public Shared Function ITC() As Boolean
        Try
            Using client = New Net.WebClient()
                Using stream = client.OpenRead("http://www.google.com")
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ITC() = True Then
            connection = True
        Else
            connection = False
        End If

        If connection = True Then
            Red.Visible = False
            Green.Visible = True
            Gray.Visible = False
        ElseIf connection = False Then
            Red.Visible = True
            Green.Visible = False
            Gray.Visible = False
        Else
            Red.Visible = False
            Green.Visible = False
            Gray.Visible = True
        End If

    End Sub

    Private Sub Pinging_Tick(sender As Object, e As EventArgs) Handles Pinging.Tick
        If pingValue = 0 Then
            Label3.Text = "Pinging"
        ElseIf pingValue = 1 Then
            Label3.Text = "Pinging ."
        ElseIf pingValue = 2 Then
            Label3.Text = "Pinging .."
        ElseIf pingValue = 3 Then
            Label3.Text = "Pinging ..."
        End If

        pingValue += 1
        If pingValue >= 4 Then
            pingValue = 0
        End If
    End Sub
End Class
