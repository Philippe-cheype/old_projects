Public Class Form1
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Public tracker As Integer

    Public Panel1_Image As String
    Public Panel2_Image As String
    Public Panel3_Image As String
    Public Panel4_Image As String
    Public Panel5_Image As String
    Public Panel7_Image As String
    Public Panel8_Image As String

    Public Panel1_Link As String
    Public Panel2_Link As String
    Public Panel3_Link As String
    Public Panel4_Link As String
    Public Panel5_Link As String
    Public Panel7_Link As String
    Public Panel8_Link As String

    Dim handler As Button

    Private Sub PanelMoveMouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub PanelMoveMouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - mousex
            Me.Top = Cursor.Position.Y - mousey
        End If
    End Sub

    Private Sub PanelMoveMouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        drag = False
    End Sub

    ' ### ### ### ### ### ### ### ###

    Private Sub Panel1_MouseClick(sender As Object, e As MouseEventArgs)
        If My.Computer.Keyboard.CtrlKeyDown Then
            tracker = 1
            Edit.ShowDialog()
        Else
            Try
                Process.Start("chrome.exe", Panel1_Link)

            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Panel2_MouseClick(sender As Object, e As MouseEventArgs)
        If My.Computer.Keyboard.CtrlKeyDown Then
            tracker = 2
            Edit.ShowDialog()
        Else
            Try
                Process.Start("chrome.exe", Panel2_Link)

            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Panel3_MouseClick(sender As Object, e As MouseEventArgs)
        If My.Computer.Keyboard.CtrlKeyDown Then
            tracker = 3
            Edit.ShowDialog()
        Else
            Try
                Process.Start("chrome.exe", Panel3_Link)

            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Panel4_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel4.MouseClick
        If My.Computer.Keyboard.CtrlKeyDown Then
            tracker = 4
            Edit.ShowDialog()
        Else
            Try
                Process.Start("chrome.exe", Panel4_Link)

            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Panel5_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel5.MouseClick
        If My.Computer.Keyboard.CtrlKeyDown Then
            tracker = 5
            Edit.ShowDialog()
        Else
            Try
                Process.Start("chrome.exe", Panel5_Link)

            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Panel8_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel8.MouseClick
        If My.Computer.Keyboard.CtrlKeyDown Then
            tracker = 8
            Edit.ShowDialog()
        Else
            Try
                Process.Start("chrome.exe", Panel8_Link)

            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Panel7_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel7.MouseClick
        If My.Computer.Keyboard.CtrlKeyDown Then
            tracker = 7
            Edit.ShowDialog()
        Else
            Try
                Process.Start("chrome.exe", Panel7_Link)

            Catch ex As Exception
            End Try
        End If
    End Sub
End Class
