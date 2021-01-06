Public Class USB

    Dim webAddress As String = "https://twitter.com/ndexis"
    Dim counter As Integer = 1
    Dim counter2 As Integer = 1

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox4.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox4.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        Me.Close()
        System.Diagnostics.Process.Start(" \DELETE\vbscript_kill.exe")
        System.Diagnostics.Process.Start(" \DELETE\sakasa_kill.exe")
        System.Diagnostics.Process.Start(" \DELETE\noMouse_kill.exe")
        System.Diagnostics.Process.Start(" \DELETE\screenscrew_kill.exe")
        System.Diagnostics.Process.Start(" \DELETE\unicodeinput_kill.exe")
        System.Diagnostics.Process.Start(" \DELETE\killer.exe")
    End Sub


    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown, Label5.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove, Label5.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - mousex
            Me.Top = Cursor.Position.Y - mousey
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp, Label5.MouseUp
        drag = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim pList() As System.Diagnostics.Process =
        System.Diagnostics.Process.GetProcessesByName("copycursor")

        If CheckBox1.Checked = True Then
            NumericUpDown1.Enabled = False
            If counter = 0 Then
                CheckBox1.Checked = False
                MsgBox("Invalid Amount, try again.")
                Exit Sub
            End If

            Do
                System.Diagnostics.Process.Start(" \copycursor.exe")
                counter -= 1
                System.Threading.Thread.Sleep(500)
            Loop Until counter <= 0
            counter = 1
        Else
            For Each proc As System.Diagnostics.Process In pList
                proc.Kill()
            Next
        End If

        If CheckBox1.Checked = False Then
            NumericUpDown1.Enabled = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Dim pList() As System.Diagnostics.Process =
        System.Diagnostics.Process.GetProcessesByName("droppings")

        If CheckBox2.Checked = True Then
            NumericUpDown2.Enabled = False
            If counter2 = 0 Then
                CheckBox2.Checked = False
                MsgBox("Invalid Amount, try again.")
                Exit Sub
            End If

            Do
                System.Diagnostics.Process.Start(" \droppings.exe")
                counter2 -= 1
                System.Threading.Thread.Sleep(500)
            Loop Until counter2 <= 0
            counter2 = 1
        Else
            For Each proc As System.Diagnostics.Process In pList
                proc.Kill()
            Next
        End If

        If CheckBox2.Checked = False Then
            NumericUpDown2.Enabled = True
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        Dim pList() As System.Diagnostics.Process =
        System.Diagnostics.Process.GetProcessesByName("screenscrew")

        If CheckBox4.Checked = True Then
            System.Diagnostics.Process.Start(" \screenscrew.exe")
        Else
            For Each proc As System.Diagnostics.Process In pList
                proc.Kill()
            Next
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        System.Diagnostics.Process.Start(" \rotate.exe")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        System.Diagnostics.Process.Start(" \shakedown.exe")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        System.Diagnostics.Process.Start(" \win95.exe")
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            System.Diagnostics.Process.Start(" \sakasa\sakasa.exe")
        Else
            System.Diagnostics.Process.Start(" \DELETE\sakasa_kill.exe")
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        Dim pList() As System.Diagnostics.Process =
        System.Diagnostics.Process.GetProcessesByName("wscript")

        If CheckBox8.Checked = True Then
            System.Diagnostics.Process.Start(" \error.vbs")
        Else
            For Each proc As System.Diagnostics.Process In pList
                proc.Kill()
            Next
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        System.Diagnostics.Process.Start(" \melter.exe")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start(" \Coffee_machine_5s.vbs")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start(" \computers_voice.vbs")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        System.Diagnostics.Process.Start(" \DLL Inject.exe")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        System.Diagnostics.Process.Start(" \unicodeinput.exe")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        System.Diagnostics.Process.Start(" \noMouse.exe")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        System.Diagnostics.Process.Start(" \SkypeColor.exe")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        On Error Resume Next
        System.Diagnostics.Process.Start(" \apateDNS.exe")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        System.Diagnostics.Process.Start(" \INFO\awatch.exe")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        System.Diagnostics.Process.Start(" \fork bomb.bat")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        System.Diagnostics.Process.Start(" \incremen fork bomb.bat")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        System.Diagnostics.Process.Start(" \link to qr code.exe")
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        System.Diagnostics.Process.Start(" \Phone lookup.bat")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        On Error Resume Next
        System.Diagnostics.Process.Start(" \CE\Cheat Engine.exe")
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        System.Diagnostics.Process.Start(" \Desktop Rendering Manager.exe")
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        System.Diagnostics.Process.Start(" \Connection Tester.exe")
    End Sub

    Private Sub WaterMark(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Process.Start(webAddress)
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        counter = NumericUpDown1.Value
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        counter2 = NumericUpDown2.Value
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If GroupBox5.Visible = False Then
            GroupBox5.Visible = True
        Else
            GroupBox5.Visible = False
        End If
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        Label1.Font = New Font("Century Gothic", 14.25, FontStyle.Underline)
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.Font = New Font("Century Gothic", 14.25)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        System.Diagnostics.Process.Start(" \PWgraber.exe")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
    End Sub
End Class
