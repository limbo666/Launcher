Imports System.ComponentModel
Imports System.IO

Public Class Form1

    Dim DraggedObject As Boolean = False
    Dim MaxHeight As Integer = 266
    Dim MaxWidth As Integer = 266
    Dim MinHeight As Integer = 128
    Dim MinWidth As Integer = 128
    Dim LockToMax As Boolean = False
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim mousepresent As Boolean = False
    Dim CloseVerify = 10
    '  Dim flag As Integer = 0

    Dim toolTip1 As New ToolTip()
    '   Dim images(15) As String

    '  Dim WhichImage As Integer = 0


    Dim folder As String = (Application.StartupPath & "\images\")

    Sub GetStoredValues()

        '   For i As Integer = 0 To 15
        '    Next


        Button1_Target = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button1_Target", "")
        Button2_Target = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button2_Target", "")
        Button3_Target = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button3_Target", "")
        Button4_Target = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button4_Target", "")
        Button5_Target = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button5_Target", "")
        Button6_Target = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button6_Target", "")
        Button7_Target = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button7_Target", "")
        Button8_Target = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button8_Target", "")
        Button9_Target = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button9_Target", "")
        Button10_Target = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button10_Target", "")
        Button11_Target = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button11_Target", "")
        Button12_Target = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button12_Target", "")
        Button13_Target = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button13_Target", "")
        Button14_Target = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button14_Target", "")
        Button15_Target = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button15_Target", "")
        Button16_Target = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button16_Target", "")

        image1 = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button1_Image", "image1")
        image2 = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button2_Image", "image2")
        image3 = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button3_Image", "image3")
        image4 = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button4_Image", "image4")
        image5 = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button5_Image", "image5")
        image6 = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button6_Image", "image6")
        image7 = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button7_Image", "image7")
        image8 = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button8_Image", "image8")
        image9 = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button9_Image", "image9")
        image10 = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button10_Image", "image10")
        image11 = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button11_Image", "image11")
        image12 = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button12_Image", "image12")
        image13 = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button13_Image", "image13")
        image14 = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button14_Image", "image14")
        image15 = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button15_Image", "image15")
        image16 = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button16_Image", "image16")

        Button1_Text = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button1_Text", "1")
        Button2_Text = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button2_Text", "2")
        Button3_Text = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button3_Text", "3")
        Button4_Text = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button4_Text", "4")
        Button5_Text = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button5_Text", "5")
        Button6_Text = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button6_Text", "6")
        Button7_Text = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button7_Text", "7")
        Button8_Text = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button8_Text", "8")
        Button9_Text = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button9_Text", "9")
        Button10_Text = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button10_text", "10")
        Button11_Text = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button11_text", "11")
        Button12_Text = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button12_text", "12")
        Button13_Text = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button13_text", "13")
        Button14_Text = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button14_text", "14")
        Button15_Text = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button15_text", "15")
        Button16_Text = INIRead(Application.StartupPath & "\Launcher.ini", "Settings", "Button16_text", "16")


        '     MsgBox(" 2: " & Button2_Text & " " & Button2_Target & " " & image2)
        TextUpdate()
    End Sub


    Sub TextUpdate()
        If Trim(Button1_Text) <> "" Then
            Button1.Text = Button1_Text
        Else
            Button1.Text = Button1_Target
        End If

        If Trim(Button2_Text) <> "" Then
            Button2.Text = Button2_Text
        Else
            Button2.Text = Button2_Target
        End If

        If Trim(Button3_Text) <> "" Then
            Button3.Text = Button3_Text
        Else
            Button3.Text = Button3_Target
        End If

        If Trim(Button4_Text) <> "" Then
            Button4.Text = Button4_Text
        Else
            Button4.Text = Button4_Target
        End If

        If Trim(Button5_Text) <> "" Then
            Button5.Text = Button5_Text
        Else
            Button5.Text = Button5_Target
        End If

        If Trim(Button7_Text) <> "" Then
            Button7.Text = Button7_Text
        Else
            Button7.Text = Button7_Target
        End If

        If Trim(Button6_Text) <> "" Then
            Button6.Text = Button6_Text
        Else
            Button6.Text = Button6_Target
        End If

        If Trim(Button8_Text) <> "" Then
            Button8.Text = Button8_Text
        Else
            Button8.Text = Button8_Target
        End If

        If Trim(Button9_Text) <> "" Then
            Button9.Text = Button9_Text
        Else
            Button9.Text = Button9_Target
        End If
        If Trim(Button10_Text) <> "" Then
            Button10.Text = Button10_Text
        Else
            Button10.Text = Button10_Target
        End If

        If Trim(Button11_Text) <> "" Then
            Button11.Text = Button11_Text
        Else
            Button11.Text = Button11_Target
        End If

        If Trim(Button12_Text) <> "" Then
            Button12.Text = Button12_Text
        Else
            Button12.Text = Button12_Target
        End If

        If Trim(Button13_Text) <> "" Then
            Button13.Text = Button13_Text
        Else
            Button13.Text = Button13_Target
        End If

        If Trim(Button14_Text) <> "" Then
            Button14.Text = Button14_Text
        Else
            Button14.Text = Button14_Target
        End If

        If Trim(Button15_Text) <> "" Then
            Button15.Text = Button15_Text
        Else
            Button15.Text = Button15_Target
        End If

        If Trim(Button16_Text) <> "" Then
            Button16.Text = Button16_Text
        Else
            Button16.Text = Button16_Target
        End If
    End Sub

    Sub ClearButtonImages()
        Button1.BackgroundImage = Nothing
        Button2.BackgroundImage = Nothing
        Button3.BackgroundImage = Nothing
        Button4.BackgroundImage = Nothing
        Button5.BackgroundImage = Nothing
        Button6.BackgroundImage = Nothing
        Button7.BackgroundImage = Nothing
        Button8.BackgroundImage = Nothing
        Button9.BackgroundImage = Nothing
        Button10.BackgroundImage = Nothing
        Button11.BackgroundImage = Nothing
        Button12.BackgroundImage = Nothing
        Button13.BackgroundImage = Nothing
        Button14.BackgroundImage = Nothing
        Button15.BackgroundImage = Nothing
        Button16.BackgroundImage = Nothing
        Me.Refresh()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  TmrDiagnostic.Enabled = True
        GetStoredValues()
        ButtonsNonVisible()

        Me.Size = New Size(MinWidth, MinHeight)
        Me.Top = GetSetting("Launcher", "Settings", "Top", 100)
        Me.Left = GetSetting("Launcher", "Settings", "Left", 100)
        LockToMax = GetSetting("Launcher", "Settings", "LockToMax", False)
        LockToMax = Not LockToMax 'we have to incvert since calling the click event changes the valus as well
        Call KeepMaxSizeToolStripMenuItem_Click(Nothing, Nothing)
        SetTooltips()
        PictureBox1.AllowDrop = True

        '   FrmDiag.Show()

    End Sub

    Function CheckExistence(pathtocheck As String) As Boolean
        If IO.Directory.Exists(pathtocheck) = False Then
            If IO.File.Exists(pathtocheck) = True Then
                Return True
            Else
                ' Return False
                If pathtocheck.StartsWith("www.") Or pathtocheck.StartsWith("http.") Then
                    Return True
                Else
                    Return False
                End If
            End If
                Else
            Return True
        End If

    End Function



    Sub SetTooltips()

        ' Set up the delays for the ToolTip.
        toolTip1.AutoPopDelay = 5000
        toolTip1.InitialDelay = 200
        toolTip1.ReshowDelay = 200
        ' Force the ToolTip text to be displayed whether or not the form is active.
        toolTip1.ShowAlways = True
        ' Set up the ToolTip text for the Button and Checkbox.
        toolTip1.SetToolTip(Me.Button1, Button1_Target)
        toolTip1.SetToolTip(Me.Button2, Button2_Target)
        toolTip1.SetToolTip(Me.Button3, Button3_Target)
        toolTip1.SetToolTip(Me.Button4, Button4_Target)
        toolTip1.SetToolTip(Me.Button5, Button5_Target)
        toolTip1.SetToolTip(Me.Button6, Button6_Target)
        toolTip1.SetToolTip(Me.Button7, Button7_Target)
        toolTip1.SetToolTip(Me.Button8, Button8_Target)
        toolTip1.SetToolTip(Me.Button9, Button9_Target)

        toolTip1.SetToolTip(Me.Button10, Button10_Target)
        toolTip1.SetToolTip(Me.Button11, Button11_Target)
        toolTip1.SetToolTip(Me.Button12, Button12_Target)
        toolTip1.SetToolTip(Me.Button13, Button13_Target)
        toolTip1.SetToolTip(Me.Button14, Button14_Target)
        toolTip1.SetToolTip(Me.Button15, Button15_Target)
        toolTip1.SetToolTip(Me.Button16, Button16_Target)

    End Sub

    Sub LoadImages(imgno As Integer)
        Select Case imgno
            Case 0
                ' do nothing as a delay 
            Case 1
                Try
                    Dim filename1 As String = System.IO.Path.Combine(folder, image1 & ".png")
                    Button1.BackgroundImage = Image.FromFile(filename1)
                    Button1.Text = ""
                Catch ex As Exception
                End Try
            Case 2
                Try
                    Dim filename2 As String = System.IO.Path.Combine(folder, image2 & ".png")
                    Button2.BackgroundImage = Image.FromFile(filename2)
                    Button2.Text = ""
                Catch ex As Exception
                End Try
            Case 3
                Try
                    Dim filename3 As String = System.IO.Path.Combine(folder, image3 & ".png")
                    Button3.BackgroundImage = Image.FromFile(filename3)
                    Button3.Text = ""
                Catch ex As Exception
                End Try
            Case 4
                Try
                    Dim filename4 As String = System.IO.Path.Combine(folder, image4 & ".png")
                    Button4.BackgroundImage = Image.FromFile(filename4)
                    Button4.Text = ""
                Catch ex As Exception

                End Try
            Case 5
                Try
                    Dim filename5 As String = System.IO.Path.Combine(folder, image5 & ".png")
                    Button5.BackgroundImage = Image.FromFile(filename5)
                    Button5.Text = ""
                Catch ex As Exception

                End Try
            Case 6
                Try
                    Dim filename6 As String = System.IO.Path.Combine(folder, image6 & ".png")
                    Button6.BackgroundImage = Image.FromFile(filename6)
                    Button6.Text = ""
                Catch ex As Exception

                End Try
            Case 7
                Try
                    Dim filename7 As String = System.IO.Path.Combine(folder, image7 & ".png")
                    Button7.BackgroundImage = Image.FromFile(filename7)
                    Button7.Text = ""
                Catch ex As Exception

                End Try
            Case 8

                Try
                    Dim filename8 As String = System.IO.Path.Combine(folder, image8 & ".png")
                    Button8.BackgroundImage = Image.FromFile(filename8)
                    Button8.Text = ""
                Catch ex As Exception

                End Try
            Case 9
                Try
                    Dim filename9 As String = System.IO.Path.Combine(folder, image9 & ".png")
                    Button9.BackgroundImage = Image.FromFile(filename9)
                    Button9.Text = ""
                Catch ex As Exception
                End Try
            Case 10
                Try
                    Dim filename10 As String = System.IO.Path.Combine(folder, image10 & ".png")
                    Button10.BackgroundImage = Image.FromFile(filename10)
                    Button10.Text = ""
                Catch ex As Exception
                End Try
            Case 11
                Try
                    Dim filename11 As String = System.IO.Path.Combine(folder, image11 & ".png")
                    Button11.BackgroundImage = Image.FromFile(filename11)
                    Button11.Text = ""
                Catch ex As Exception
                End Try

            Case 12
                Try
                    Dim filename12 As String = System.IO.Path.Combine(folder, image12 & ".png")
                    Button12.BackgroundImage = Image.FromFile(filename12)
                    Button12.Text = ""
                Catch ex As Exception
                End Try
            Case 13
                Try
                    Dim filename13 As String = System.IO.Path.Combine(folder, image13 & ".png")
                    Button13.BackgroundImage = Image.FromFile(filename13)
                    Button13.Text = ""
                Catch ex As Exception
                End Try
            Case 14
                Try
                    Dim filename14 As String = System.IO.Path.Combine(folder, image14 & ".png")
                    Button14.BackgroundImage = Image.FromFile(filename14)
                    Button14.Text = ""
                Catch ex As Exception
                End Try
            Case 15
                Try
                    Dim filename15 As String = System.IO.Path.Combine(folder, image15 & ".png")
                    Button15.BackgroundImage = Image.FromFile(filename15)
                    Button15.Text = ""
                Catch ex As Exception
                End Try
            Case 16
                Try
                    Dim filename16 As String = System.IO.Path.Combine(folder, image16 & ".png")
                    Button16.BackgroundImage = Image.FromFile(filename16)
                    Button16.Text = ""
                Catch ex As Exception
                End Try

            Case Else
                WhichImage = 0
                TmrImgEffect.Enabled = False
        End Select


    End Sub

    Sub ButtonsVisible()
        PictureBox1.Visible = False
        Dim c As Control
        For Each c In Me.Controls
            If TypeOf c Is Button Then
                c.Visible = True
            End If
        Next
    End Sub
    Sub ButtonsNonVisible()
        PictureBox1.Visible = True
        Dim c As Control
        For Each c In Me.Controls
            If TypeOf c Is Button Then
                c.Visible = False
            End If
        Next
    End Sub

    Private Sub Form1_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        mousepresent = True

        '  flag = 1
        '  Me.ForeColor = Color.Blue
        If Me.Height = 128 Then
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        If Me.Height = MaxHeight Then
            Timer3.Enabled = True
        ElseIf Me.Height = MinHeight Then
            Timer2.Enabled = True
        Else
            Timer1.Enabled = False
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        '    Me.TransparencyKey = Nothing
        'maximize
        If Me.Height < MaxHeight Then
            Me.Height = Me.Height + 15
        End If
        If Me.Width < MaxWidth Then
            Me.Width = Me.Width + 15
        End If
        If Me.Height >= MaxHeight And Me.Width >= MaxWidth Then
            Me.Height = MaxHeight
            Me.Width = MaxWidth
            ButtonsVisible()
            Timer2.Enabled = False
            Me.Opacity = 1
            TmrDectMouse.Enabled = True
            TmrImgEffect.Enabled = True
            TmrVerifyPaths.Enabled = True
            Me.BackColor = Color.DimGray
        End If

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If LockToMax = True Then
            Timer3.Enabled = False
            Me.Opacity = 1
        Else
            'minimize
            Me.Opacity = 0.7
            ButtonsNonVisible()
            If Me.Height > MinHeight Then
                Me.Height = Me.Height - 10
            End If
            If Me.Width > MinWidth Then
                Me.Width = Me.Width - 10
            End If
            If Me.Height <= MinHeight And Me.Width <= MinWidth Then
                Me.Height = MinHeight
                Me.Width = MinWidth
                Timer3.Enabled = False

                Button1.BackgroundImage = Nothing
                Button2.BackgroundImage = Nothing
                Button3.BackgroundImage = Nothing
                Button4.BackgroundImage = Nothing
                Button5.BackgroundImage = Nothing
                Button6.BackgroundImage = Nothing
                Button7.BackgroundImage = Nothing
                Button8.BackgroundImage = Nothing
                Button9.BackgroundImage = Nothing
                Button10.BackgroundImage = Nothing
                Button11.BackgroundImage = Nothing
                Button12.BackgroundImage = Nothing
                Button13.BackgroundImage = Nothing
                Button14.BackgroundImage = Nothing
                Button15.BackgroundImage = Nothing
                Button16.BackgroundImage = Nothing
                '      Me.TransparencyKey = Color.Gray
            End If


        End If
        '   End If
    End Sub
    Sub StartClosing()
        If LockToMax = True Then
        Else
            Me.ForeColor = Color.SlateGray
            If Me.Height = MaxHeight Then
                Timer1.Enabled = True
            End If
        End If
    End Sub
    Private Sub Form1_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        '  StartClosing()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If My.Computer.Keyboard.CtrlKeyDown Then
            If My.Computer.Keyboard.ShiftKeyDown Then
                Dim ans = MsgBox("Do you want to clear button's 1 data?", vbQuestion + vbYesNo, "Launcher")
                If ans = vbYes Then
                    'deleted
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button1_Text", "")
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button1_Target", "")
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button1_Image", "")
                    Button1_Text = ""
                    Button1_Target = ""
                    image1 = ""
                    Button1.Text = Button1.Text
                    toolTip1.SetToolTip(Me.Button1, Button1_Target)
                    TextUpdate()
                    Button1.BackgroundImage = Nothing
                    TmrVerifyPaths.Enabled = True
                End If


            Else
                ButtonUnderEdit = 1
                FrmEdit.Show()
            End If
        ElseIf My.Computer.Keyboard.ShiftKeyDown Then
            ButtonUnderEdit = 1
            FrmReplace.Show()

        ElseIf My.Computer.Keyboard.AltKeyDown Then
            My.Computer.Clipboard.SetText(Button1_Target)
        Else

            Try
                Process.Start(Button1_Target)
            Catch
            End Try
            StartClosing()
        End If

    End Sub

    Private Sub Button1_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Button1.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            Dim Starget As String = ""
            Dim lastpart As String = ""
            '   MsgBox(path)
            Dim shell = CreateObject("WScript.Shell")
            If path.EndsWith(".lnk") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                lastpart = Starget.Substring(Starget.LastIndexOf("\") + 1)
            ElseIf path.EndsWith(".url") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                lastpart = Starget.Substring(Starget.LastIndexOf("/") + 1)
            End If

            If Starget = "" Then
                Button1_Target = path
                lastpart = path.Substring(path.LastIndexOf("/") + 1)
            Else
                Button1_Target = Starget
                If lastpart <> "" Then
                    lastpart = Replace(lastpart, ".exe", "")
                    lastpart = Replace(lastpart, ".bat", "")

                End If
            End If
            INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button1_Target", Button1_Target)
            toolTip1.SetToolTip(Me.Button1, Button1_Target)
            Button1_Text = lastpart
            Button1.Text = Button1_Text
            INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button1_Text", Button1_Text)
        Next

    End Sub

    Private Sub Button1_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Button1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If My.Computer.Keyboard.CtrlKeyDown Then
            If My.Computer.Keyboard.ShiftKeyDown Then
                Dim ans = MsgBox("Do you want to clear button's 2 data?", vbQuestion + vbYesNo, "Launcher")
                If ans = vbYes Then
                    'deleted
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button2_Text", "")
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button2_Target", "")
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button2_Image", "")
                    Button2_Text = ""
                    Button2_Target = ""
                    image2 = ""
                    Button2.Text = Button2.Text
                    toolTip1.SetToolTip(Me.Button2, Button2_Target)
                    TextUpdate()
                    Button2.BackgroundImage = Nothing
                    TmrVerifyPaths.Enabled = True
                End If
            Else

                ButtonUnderEdit = 2
                FrmEdit.Show()
            End If
        ElseIf My.Computer.Keyboard.ShiftKeyDown Then
            ButtonUnderEdit = 2
            FrmReplace.Show()
        ElseIf My.Computer.Keyboard.AltKeyDown Then
            My.Computer.Clipboard.SetText(Button2_Target)

        Else
            Try
                Process.Start(Button2_Target)
            Catch
            End Try
            StartClosing()
        End If

    End Sub


    Private Sub Button2_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Button2.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            Dim Starget As String = ""
            Dim lastpart As String = ""
            '   MsgBox(path)
            Dim shell = CreateObject("WScript.Shell")
            If path.EndsWith(".lnk") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                lastpart = Starget.Substring(Starget.LastIndexOf("\") + 1)
            ElseIf path.EndsWith(".url") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                lastpart = Starget.Substring(Starget.LastIndexOf("/") + 1)
            End If

            If Starget = "" Then
                Button2_Target = path
                lastpart = path.Substring(path.LastIndexOf("/") + 1)
            Else
                Button2_Target = Starget
                If lastpart <> "" Then
                    lastpart = Replace(lastpart, ".exe", "")
                    lastpart = Replace(lastpart, ".bat", "")

                End If
            End If
            INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button2_Target", Button2_Target)
            toolTip1.SetToolTip(Me.Button2, Button2_Target)
            Button2_Text = lastpart
            Button2.Text = Button2_Text
            INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button2_Text", Button2_Text)
        Next

    End Sub

    Private Sub Button2_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Button2.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            If My.Computer.Keyboard.ShiftKeyDown Then
                Dim ans = MsgBox("Do you want to clear button's 3 data?", vbQuestion + vbYesNo, "Launcher")
                If ans = vbYes Then
                    'deleted
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button3_Text", "")
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button3_Target", "")
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button3_Image", "")
                    Button3_Text = ""
                    Button3_Target = ""
                    image3 = ""
                    Button3.Text = Button3.Text
                    toolTip1.SetToolTip(Me.Button3, Button3_Target)
                    TextUpdate()
                    Button3.BackgroundImage = Nothing
                    TmrVerifyPaths.Enabled = True
                End If
            Else
                ButtonUnderEdit = 3
                FrmEdit.Show()
            End If
        ElseIf My.Computer.Keyboard.ShiftKeyDown Then
            ButtonUnderEdit = 3
            FrmReplace.Show()
        ElseIf My.Computer.Keyboard.AltKeyDown Then
            My.Computer.Clipboard.SetText(Button3_Target)
        Else
            Try
                Process.Start(Button3_Target)
            Catch
            End Try
            StartClosing()
        End If

    End Sub


    Private Sub Button3_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Button3.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            Dim Starget As String = ""
            Dim lastpart As String = ""
            '   MsgBox(path)
            Dim shell = CreateObject("WScript.Shell")
            If path.EndsWith(".lnk") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                lastpart = Starget.Substring(Starget.LastIndexOf("\") + 1)
            ElseIf path.EndsWith(".url") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                lastpart = Starget.Substring(Starget.LastIndexOf("/") + 1)
            End If

            If Starget = "" Then
                Button3_Target = path
                lastpart = path.Substring(path.LastIndexOf("/") + 1)
            Else
                Button3_Target = Starget
                If lastpart <> "" Then
                    lastpart = Replace(lastpart, ".exe", "")
                    lastpart = Replace(lastpart, ".bat", "")

                End If
            End If
            INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button3_Target", Button3_Target)
            toolTip1.SetToolTip(Me.Button3, Button3_Target)
            Button3_Text = lastpart
            Button3.Text = Button3_Text
            INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button3_Text", Button3_Text)
        Next

    End Sub

    Private Sub Button3_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Button3.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            If My.Computer.Keyboard.ShiftKeyDown Then
                Dim ans = MsgBox("Do you want to clear button's 4 data?", vbQuestion + vbYesNo, "Launcher")
                If ans = vbYes Then
                    'deleted
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button4_Text", "")
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button4_Target", "")
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button4_Image", "")
                    Button4_Text = ""
                    Button4_Target = ""
                    image4 = ""
                    Button4.Text = Button4.Text
                    toolTip1.SetToolTip(Me.Button4, Button4_Target)
                    TextUpdate()
                    Button4.BackgroundImage = Nothing
                    TmrVerifyPaths.Enabled = True
                End If
            Else
                ButtonUnderEdit = 4
                FrmEdit.Show()
            End If
        ElseIf My.Computer.Keyboard.ShiftKeyDown Then
            ButtonUnderEdit = 4
            FrmReplace.Show()
        ElseIf My.Computer.Keyboard.AltKeyDown Then
            My.Computer.Clipboard.SetText(Button4_Target)
        Else
            Try
                Process.Start(Button4_Target)
            Catch
            End Try
            StartClosing()
        End If

    End Sub


    Private Sub Button4_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Button4.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            Dim Starget As String = ""
            Dim lastpart As String = ""
            '   MsgBox(path)
            Dim shell = CreateObject("WScript.Shell")
            If path.EndsWith(".lnk") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                lastpart = Starget.Substring(Starget.LastIndexOf("\") + 1)
            ElseIf path.EndsWith(".url") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                lastpart = Starget.Substring(Starget.LastIndexOf("/") + 1)
            End If

            If Starget = "" Then
                Button4_Target = path
                lastpart = path.Substring(path.LastIndexOf("/") + 1)
            Else
                Button4_Target = Starget
                If lastpart <> "" Then
                    lastpart = Replace(lastpart, ".exe", "")
                    lastpart = Replace(lastpart, ".bat", "")

                End If
            End If
            INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button4_Target", Button4_Target)
            toolTip1.SetToolTip(Me.Button4, Button4_Target)
            Button4_Text = lastpart
            Button4.Text = Button4_Text
            INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button4_Text", Button4_Text)
        Next

    End Sub

    Private Sub Button4_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Button4.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            If My.Computer.Keyboard.ShiftKeyDown Then
                Dim ans = MsgBox("Do you want to clear button's 5 data?", vbQuestion + vbYesNo, "Launcher")
                If ans = vbYes Then
                    'deleted
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button5_Text", "")
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button5_Target", "")
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button5_Image", "")
                    Button5_Text = ""
                    Button5_Target = ""
                    image5 = ""
                    Button5.Text = Button5.Text
                    toolTip1.SetToolTip(Me.Button5, Button5_Target)
                    TextUpdate()
                    Button5.BackgroundImage = Nothing
                    TmrVerifyPaths.Enabled = True
                End If
            Else
                ButtonUnderEdit = 5
                FrmEdit.Show()
            End If
        ElseIf My.Computer.Keyboard.ShiftKeyDown Then
            ButtonUnderEdit = 5
            FrmReplace.Show()
        ElseIf My.Computer.Keyboard.AltKeyDown Then
            My.Computer.Clipboard.SetText(Button5_Target)
        Else
            Try
                Process.Start(Button5_Target)
            Catch
            End Try
            StartClosing()
        End If


    End Sub
    Private Sub Button5_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Button5.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            Dim Starget As String = ""
            Dim lastpart As String = ""
            '   MsgBox(path)
            Dim shell = CreateObject("WScript.Shell")
            If path.EndsWith(".lnk") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                lastpart = Starget.Substring(Starget.LastIndexOf("\") + 1)
            ElseIf path.EndsWith(".url") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                lastpart = Starget.Substring(Starget.LastIndexOf("/") + 1)
            End If

            If Starget = "" Then
                Button5_Target = path
                lastpart = path.Substring(path.LastIndexOf("/") + 1)
            Else
                Button5_Target = Starget
                If lastpart <> "" Then
                    lastpart = Replace(lastpart, ".exe", "")
                    lastpart = Replace(lastpart, ".bat", "")

                End If
            End If
            INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button5_Target", Button5_Target)
            toolTip1.SetToolTip(Me.Button5, Button5_Target)
            Button5_Text = lastpart
            Button5.Text = Button5_Text
            INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button5_Text", Button5_Text)
        Next

    End Sub

    Private Sub Button5_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Button5.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            If My.Computer.Keyboard.ShiftKeyDown Then
                Dim ans = MsgBox("Do you want to clear button's 6 data?", vbQuestion + vbYesNo, "Launcher")
                If ans = vbYes Then
                    'deleted
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button6_Text", "")
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button6_Target", "")
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button6_Image", "")
                    Button6_Text = ""
                    Button6_Target = ""
                    image6 = ""
                    Button6.Text = Button6.Text
                    toolTip1.SetToolTip(Me.Button6, Button6_Target)
                    TextUpdate()
                    Button6.BackgroundImage = Nothing
                    TmrVerifyPaths.Enabled = True
                End If
            Else
                ButtonUnderEdit = 6
                FrmEdit.Show()
            End If
        ElseIf My.Computer.Keyboard.ShiftKeyDown Then
            ButtonUnderEdit = 6
            FrmReplace.Show()
        ElseIf My.Computer.Keyboard.AltKeyDown Then
            My.Computer.Clipboard.SetText(Button6_Target)
        Else
            Try
                Process.Start(Button6_Target)
            Catch
            End Try
            StartClosing()
        End If
    End Sub
    Private Sub Button6_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Button6.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            Dim Starget As String = ""
            Dim lastpart As String = ""
            '   MsgBox(path)
            Dim shell = CreateObject("WScript.Shell")
            If path.EndsWith(".lnk") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                lastpart = Starget.Substring(Starget.LastIndexOf("\") + 1)
            ElseIf path.EndsWith(".url") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                lastpart = Starget.Substring(Starget.LastIndexOf("/") + 1)
            End If

            If Starget = "" Then
                Button6_Target = path
                lastpart = path.Substring(path.LastIndexOf("/") + 1)
            Else
                Button6_Target = Starget
                If lastpart <> "" Then
                    lastpart = Replace(lastpart, ".exe", "")
                    lastpart = Replace(lastpart, ".bat", "")

                End If
            End If
            INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button6_Target", Button6_Target)
            toolTip1.SetToolTip(Me.Button6, Button6_Target)
            Button6_Text = lastpart
            Button6.Text = Button6_Text
            INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button6_Text", Button6_Text)
        Next

    End Sub

    Private Sub Button6_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Button6.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            If My.Computer.Keyboard.ShiftKeyDown Then
                Dim ans = MsgBox("Do you want to clear button's 7 data?", vbQuestion + vbYesNo, "Launcher")
                If ans = vbYes Then
                    'deleted
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button7_Text", "")
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button7_Target", "")
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button7_Image", "")
                    Button7_Text = ""
                    Button7_Target = ""
                    image7 = ""
                    Button7.Text = Button7.Text
                    toolTip1.SetToolTip(Me.Button7, Button7_Target)
                    TextUpdate()
                    Button7.BackgroundImage = Nothing
                    TmrVerifyPaths.Enabled = True
                End If
            Else
                ButtonUnderEdit = 7
                FrmEdit.Show()
            End If
        ElseIf My.Computer.Keyboard.ShiftKeyDown Then
            ButtonUnderEdit = 7
            FrmReplace.Show()
        ElseIf My.Computer.Keyboard.AltKeyDown Then
            My.Computer.Clipboard.SetText(Button7_Target)
        Else
            Try
                Process.Start(Button7_Target)
            Catch
            End Try
            StartClosing()
        End If


    End Sub

    Private Sub Button7_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Button7.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            Dim Starget As String = ""
            Dim lastpart As String = ""
            '   MsgBox(path)
            Dim shell = CreateObject("WScript.Shell")
            If path.EndsWith(".lnk") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                lastpart = Starget.Substring(Starget.LastIndexOf("\") + 1)
            ElseIf path.EndsWith(".url") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                lastpart = Starget.Substring(Starget.LastIndexOf("/") + 1)
            End If

            If Starget = "" Then
                Button7_Target = path
                lastpart = path.Substring(path.LastIndexOf("/") + 1)
            Else
                Button7_Target = Starget
                If lastpart <> "" Then
                    lastpart = Replace(lastpart, ".exe", "")
                    lastpart = Replace(lastpart, ".bat", "")

                End If
            End If
            INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button7_Target", Button7_Target)
            toolTip1.SetToolTip(Me.Button7, Button7_Target)
            Button7_Text = lastpart
            Button7.Text = Button7_Text
            INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button7_Text", Button7_Text)
        Next

    End Sub

    Private Sub Button7_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Button7.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            If My.Computer.Keyboard.ShiftKeyDown Then
                Dim ans = MsgBox("Do you want to clear button's 8 data?", vbQuestion + vbYesNo, "Launcher")
                If ans = vbYes Then
                    'deleted
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button8_Text", "")
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button8_Target", "")
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button8_Image", "")
                    Button8_Text = ""
                    Button8_Target = ""
                    image8 = ""
                    Button8.Text = Button8.Text
                    toolTip1.SetToolTip(Me.Button8, Button8_Target)
                    TextUpdate()
                    Button8.BackgroundImage = Nothing
                    TmrVerifyPaths.Enabled = True
                End If
            Else
                ButtonUnderEdit = 8
                FrmEdit.Show()
            End If
        ElseIf My.Computer.Keyboard.ShiftKeyDown Then
            ButtonUnderEdit = 8
            FrmReplace.Show()
        ElseIf My.Computer.Keyboard.AltKeyDown Then
            My.Computer.Clipboard.SetText(Button8_Target)
        Else
            Try
                Process.Start(Button8_Target)
            Catch
            End Try
            StartClosing()
        End If
    End Sub


    Private Sub Button8_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Button8.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            Dim Starget As String = ""
            Dim lastpart As String = ""
            '   MsgBox(path)
            Dim shell = CreateObject("WScript.Shell")
            If path.EndsWith(".lnk") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                lastpart = Starget.Substring(Starget.LastIndexOf("\") + 1)
            ElseIf path.EndsWith(".url") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                lastpart = Starget.Substring(Starget.LastIndexOf("/") + 1)
            End If

            If Starget = "" Then
                Button8_Target = path
                lastpart = path.Substring(path.LastIndexOf("/") + 1)
            Else
                Button8_Target = Starget
                If lastpart <> "" Then
                    lastpart = Replace(lastpart, ".exe", "")
                    lastpart = Replace(lastpart, ".bat", "")

                End If
            End If
            INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button8_Target", Button8_Target)
            toolTip1.SetToolTip(Me.Button8, Button8_Target)
            Button8_Text = lastpart
            Button8.Text = Button8_Text
            INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button8_Text", Button8_Text)
        Next

    End Sub

    Private Sub Button8_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Button8.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            If My.Computer.Keyboard.ShiftKeyDown Then
                Dim ans = MsgBox("Do you want to clear button's 9 data?", vbQuestion + vbYesNo, "Launcher")
                If ans = vbYes Then
                    'deleted
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button9_Text", "")
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button9_Target", "")
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button9_Image", "")
                    Button9_Text = ""
                    Button9_Target = ""
                    image9 = ""
                    Button9.Text = Button9.Text
                    toolTip1.SetToolTip(Me.Button9, Button9_Target)
                    TextUpdate()
                    Button9.BackgroundImage = Nothing
                    TmrVerifyPaths.Enabled = True
                End If
            Else
                ButtonUnderEdit = 9
                FrmEdit.Show()
            End If
        ElseIf My.Computer.Keyboard.ShiftKeyDown Then
            ButtonUnderEdit = 9
            FrmReplace.Show()
        ElseIf My.Computer.Keyboard.AltKeyDown Then
            My.Computer.Clipboard.SetText(Button9_Target)
        Else
            Try
                Process.Start(Button9_Target)
            Catch
            End Try
            StartClosing()
        End If

    End Sub



    Private Sub Button9_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Button9.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            Dim Starget As String = ""
            Dim lastpart As String = ""
            '   MsgBox(path)
            Dim shell = CreateObject("WScript.Shell")
            If path.EndsWith(".lnk") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                lastpart = Starget.Substring(Starget.LastIndexOf("\") + 1)
            ElseIf path.EndsWith(".url") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                lastpart = Starget.Substring(Starget.LastIndexOf("/") + 1)
            End If

            If Starget = "" Then
                Button9_Target = path
                lastpart = path.Substring(path.LastIndexOf("/") + 1)
            Else
                Button9_Target = Starget
                If lastpart <> "" Then
                    lastpart = Replace(lastpart, ".exe", "")
                    lastpart = Replace(lastpart, ".bat", "")

                End If
            End If
            INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button9_Target", Button9_Target)
            toolTip1.SetToolTip(Me.Button9, Button9_Target)
            Button9_Text = lastpart
            Button9.Text = Button9_Text
            INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button9_Text", Button9_Text)
        Next

    End Sub

    Private Sub Button9_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Button9.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            If My.Computer.Keyboard.ShiftKeyDown Then
                Dim ans = MsgBox("Do you want to clear button's 10 data?", vbQuestion + vbYesNo, "Launcher")
                If ans = vbYes Then
                    'deleted
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button10_Text", "")
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button10_Target", "")
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button10_Image", "")
                    Button10_Text = ""
                    Button10_Target = ""
                    image10 = ""
                    Button10.Text = Button10.Text
                    toolTip1.SetToolTip(Me.Button10, Button10_Target)
                    TextUpdate()
                    Button10.BackgroundImage = Nothing
                    TmrVerifyPaths.Enabled = True
                End If
            Else
                ButtonUnderEdit = 10
                FrmEdit.Show()
            End If
        ElseIf My.Computer.Keyboard.ShiftKeyDown Then
            ButtonUnderEdit = 10
            FrmReplace.Show()
        ElseIf My.Computer.Keyboard.AltKeyDown Then
            My.Computer.Clipboard.SetText(Button10_Target)
        Else
            Try
                Process.Start(Button10_Target)
            Catch
            End Try
            StartClosing()
        End If
    End Sub


    Private Sub Button10_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Button10.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            Dim Starget As String = ""
            Dim lastpart As String = ""
            '   MsgBox(path)
            Dim shell = CreateObject("WScript.Shell")
            If path.EndsWith(".lnk") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                lastpart = Starget.Substring(Starget.LastIndexOf("\") + 1)
            ElseIf path.EndsWith(".url") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                lastpart = Starget.Substring(Starget.LastIndexOf("/") + 1)
            End If

            If Starget = "" Then
                Button10_Target = path
                lastpart = path.Substring(path.LastIndexOf("/") + 1)
            Else
                Button10_Target = Starget
                If lastpart <> "" Then
                    lastpart = Replace(lastpart, ".exe", "")
                    lastpart = Replace(lastpart, ".bat", "")

                End If
            End If
            INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button10_Target", Button10_Target)
            toolTip1.SetToolTip(Me.Button10, Button10_Target)
            Button10_Text = lastpart
            Button10.Text = Button10_Text
            INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button10_Text", Button10_Text)
        Next

    End Sub

    Private Sub Button10_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Button10.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            If My.Computer.Keyboard.ShiftKeyDown Then
                Dim ans = MsgBox("Do you want to clear button's 11 data?", vbQuestion + vbYesNo, "Launcher")
                If ans = vbYes Then
                    'deleted
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button11_Text", "")
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button11_Target", "")
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button11_Image", "")
                    Button11_Text = ""
                    Button11_Target = ""
                    image11 = ""
                    Button11.Text = Button11.Text
                    toolTip1.SetToolTip(Me.Button11, Button11_Target)
                    TextUpdate()
                    Button11.BackgroundImage = Nothing
                    TmrVerifyPaths.Enabled = True
                End If
            Else
                ButtonUnderEdit = 11
                FrmEdit.Show()
            End If
        ElseIf My.Computer.Keyboard.ShiftKeyDown Then
            ButtonUnderEdit = 11
            FrmReplace.Show()
        ElseIf My.Computer.Keyboard.AltKeyDown Then
            My.Computer.Clipboard.SetText(Button11_Target)
        Else
            Try
                Process.Start(Button11_Target)
            Catch
            End Try
            StartClosing()
        End If

    End Sub


    Private Sub Button11_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Button11.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            Dim Starget As String = ""
            Dim lastpart As String = ""
            '   MsgBox(path)
            Dim shell = CreateObject("WScript.Shell")
            If path.EndsWith(".lnk") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                lastpart = Starget.Substring(Starget.LastIndexOf("\") + 1)
            ElseIf path.EndsWith(".url") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                lastpart = Starget.Substring(Starget.LastIndexOf("/") + 1)
            End If

            If Starget = "" Then
                Button11_Target = path
                lastpart = path.Substring(path.LastIndexOf("/") + 1)
            Else
                Button11_Target = Starget
                If lastpart <> "" Then
                    lastpart = Replace(lastpart, ".exe", "")
                    lastpart = Replace(lastpart, ".bat", "")

                End If
            End If
            INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button11_Target", Button11_Target)
            toolTip1.SetToolTip(Me.Button11, Button11_Target)
            Button11_Text = lastpart
            Button11.Text = Button11_Text
            INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button11_Text", Button11_Text)
        Next

    End Sub

    Private Sub Button11_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Button11.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub


    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            If My.Computer.Keyboard.ShiftKeyDown Then
                Dim ans = MsgBox("Do you want to clear button's 12 data?", vbQuestion + vbYesNo, "Launcher")
                If ans = vbYes Then
                    'deleted
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button12_Text", "")
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button12_Target", "")
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button12_Image", "")
                    Button12_Text = ""
                    Button12_Target = ""
                    image12 = ""
                    Button12.Text = Button12.Text
                    toolTip1.SetToolTip(Me.Button12, Button12_Target)
                    TextUpdate()
                    Button12.BackgroundImage = Nothing
                    TmrVerifyPaths.Enabled = True
                End If
            Else
                ButtonUnderEdit = 12
                FrmEdit.Show()
            End If
        ElseIf My.Computer.Keyboard.ShiftKeyDown Then
            ButtonUnderEdit = 12
            FrmReplace.Show()
        ElseIf My.Computer.Keyboard.AltKeyDown Then
            My.Computer.Clipboard.SetText(Button12_Target)
        Else

            Try
                Process.Start(Button12_Target)
            Catch
            End Try
            StartClosing()
        End If

    End Sub


    Private Sub Button12_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Button12.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            Dim Starget As String = ""
            Dim lastpart As String = ""
            '   MsgBox(path)
            Dim shell = CreateObject("WScript.Shell")
            If path.EndsWith(".lnk") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                lastpart = Starget.Substring(Starget.LastIndexOf("\") + 1)
            ElseIf path.EndsWith(".url") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                lastpart = Starget.Substring(Starget.LastIndexOf("/") + 1)
            End If

            If Starget = "" Then
                Button12_Target = path
                lastpart = path.Substring(path.LastIndexOf("/") + 1)
            Else
                Button12_Target = Starget
                If lastpart <> "" Then
                    lastpart = Replace(lastpart, ".exe", "")
                    lastpart = Replace(lastpart, ".bat", "")

                End If
            End If
            INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button12_Target", Button12_Target)
            toolTip1.SetToolTip(Me.Button12, Button12_Target)
            Button12_Text = lastpart
            Button12.Text = Button12_Text
            INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button12_Text", Button12_Text)
        Next

    End Sub

    Private Sub Button12_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Button12.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            If My.Computer.Keyboard.ShiftKeyDown Then
                Dim ans = MsgBox("Do you want to clear button's 13 data?", vbQuestion + vbYesNo, "Launcher")
                If ans = vbYes Then
                    'deleted
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button13_Text", "")
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button13_Target", "")
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button13_Image", "")
                    Button13_Text = ""
                    Button13_Target = ""
                    image13 = ""
                    Button13.Text = Button13.Text
                    toolTip1.SetToolTip(Me.Button13, Button13_Target)
                    TextUpdate()
                    Button13.BackgroundImage = Nothing
                    TmrVerifyPaths.Enabled = True
                End If
            Else
                ButtonUnderEdit = 13
                FrmEdit.Show()
            End If
        ElseIf My.Computer.Keyboard.ShiftKeyDown Then
            ButtonUnderEdit = 13
            FrmReplace.Show()
        ElseIf My.Computer.Keyboard.AltKeyDown Then
            My.Computer.Clipboard.SetText(Button13_Target)
        Else
            Try
                Process.Start(Button13_Target)
            Catch
            End Try
            StartClosing()
        End If

    End Sub


    Private Sub Button13_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Button13.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            Dim Starget As String = ""
            Dim lastpart As String = ""
            '   MsgBox(path)
            Dim shell = CreateObject("WScript.Shell")
            If path.EndsWith(".lnk") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                lastpart = Starget.Substring(Starget.LastIndexOf("\") + 1)
            ElseIf path.EndsWith(".url") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                lastpart = Starget.Substring(Starget.LastIndexOf("/") + 1)
            End If

            If Starget = "" Then
                Button13_Target = path
                lastpart = path.Substring(path.LastIndexOf("/") + 1)
            Else
                Button13_Target = Starget
                If lastpart <> "" Then
                    lastpart = Replace(lastpart, ".exe", "")
                    lastpart = Replace(lastpart, ".bat", "")

                End If
            End If
            INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button13_Target", Button13_Target)
            toolTip1.SetToolTip(Me.Button13, Button13_Target)
            Button13_Text = lastpart
            Button13.Text = Button13_Text
            INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button13_Text", Button13_Text)
        Next

    End Sub

    Private Sub Button13_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Button13.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub



    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            If My.Computer.Keyboard.ShiftKeyDown Then
                Dim ans = MsgBox("Do you want to clear button's 14 data?", vbQuestion + vbYesNo, "Launcher")
                If ans = vbYes Then
                    'deleted
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button14_Text", "")
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button14_Target", "")
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button14_Image", "")
                    Button14_Text = ""
                    Button14_Target = ""
                    image14 = ""
                    Button14.Text = Button14.Text
                    toolTip1.SetToolTip(Me.Button14, Button14_Target)
                    TextUpdate()
                    Button14.BackgroundImage = Nothing
                    TmrVerifyPaths.Enabled = True
                End If
            Else
                ButtonUnderEdit = 14
                FrmEdit.Show()
            End If
        ElseIf My.Computer.Keyboard.ShiftKeyDown Then
            ButtonUnderEdit = 14
            FrmReplace.Show()
        ElseIf My.Computer.Keyboard.AltKeyDown Then
            My.Computer.Clipboard.SetText(Button14_Target)
        Else
            Try
                Process.Start(Button14_Target)
            Catch
            End Try
            StartClosing()
        End If

    End Sub


    Private Sub Button14_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Button14.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            Dim Starget As String = ""
            Dim lastpart As String = ""
            '   MsgBox(path)
            Dim shell = CreateObject("WScript.Shell")
            If path.EndsWith(".lnk") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                lastpart = Starget.Substring(Starget.LastIndexOf("\") + 1)
            ElseIf path.EndsWith(".url") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                lastpart = Starget.Substring(Starget.LastIndexOf("/") + 1)
            End If

            If Starget = "" Then
                Button14_Target = path
                lastpart = path.Substring(path.LastIndexOf("/") + 1)
            Else
                Button14_Target = Starget
                If lastpart <> "" Then
                    lastpart = Replace(lastpart, ".exe", "")
                    lastpart = Replace(lastpart, ".bat", "")

                End If
            End If
            INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button14_Target", Button14_Target)
            toolTip1.SetToolTip(Me.Button14, Button14_Target)
            Button14_Text = lastpart
            Button14.Text = Button14_Text
            INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button14_Text", Button14_Text)
        Next

    End Sub

    Private Sub Button14_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Button14.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            If My.Computer.Keyboard.ShiftKeyDown Then
                Dim ans = MsgBox("Do you want to clear button's 15 data?", vbQuestion + vbYesNo, "Launcher")
                If ans = vbYes Then
                    'deleted
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button15_Text", "")
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button15_Target", "")
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button15_Image", "")
                    Button15_Text = ""
                    Button15_Target = ""
                    image15 = ""
                    Button15.Text = Button15.Text
                    toolTip1.SetToolTip(Me.Button15, Button15_Target)
                    TextUpdate()
                    Button15.BackgroundImage = Nothing
                    TmrVerifyPaths.Enabled = True
                End If
            Else
                ButtonUnderEdit = 15
                FrmEdit.Show()
            End If
        ElseIf My.Computer.Keyboard.ShiftKeyDown Then
            ButtonUnderEdit = 15
            FrmReplace.Show()
        ElseIf My.Computer.Keyboard.AltKeyDown Then
            My.Computer.Clipboard.SetText(Button15_Target)
        Else
            Try
                Process.Start(Button15_Target)
            Catch
            End Try
            StartClosing()
        End If

    End Sub


    Private Sub Button15_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Button15.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            Dim Starget As String = ""
            Dim lastpart As String = ""
            '   MsgBox(path)
            Dim shell = CreateObject("WScript.Shell")
            If path.EndsWith(".lnk") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                lastpart = Starget.Substring(Starget.LastIndexOf("\") + 1)
            ElseIf path.EndsWith(".url") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                lastpart = Starget.Substring(Starget.LastIndexOf("/") + 1)
            End If

            If Starget = "" Then
                Button15_Target = path
                lastpart = path.Substring(path.LastIndexOf("/") + 1)
            Else
                Button15_Target = Starget
                If lastpart <> "" Then
                    lastpart = Replace(lastpart, ".exe", "")
                    lastpart = Replace(lastpart, ".bat", "")

                End If
            End If
            INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button15_Target", Button15_Target)
            toolTip1.SetToolTip(Me.Button15, Button15_Target)
            Button15_Text = lastpart
            Button15.Text = Button15_Text
            INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button15_Text", Button15_Text)
        Next

    End Sub

    Private Sub Button15_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Button15.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub


    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            If My.Computer.Keyboard.ShiftKeyDown Then
                Dim ans = MsgBox("Do you want to clear button's 16 data?", vbQuestion + vbYesNo, "Launcher")
                If ans = vbYes Then
                    'deleted
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button16_Text", "")
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button16_Target", "")
                    INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button16_Image", "")
                    Button16_Text = ""
                    Button16_Target = ""
                    image16 = ""
                    Button16.Text = Button16.Text
                    toolTip1.SetToolTip(Me.Button16, Button16_Target)
                    TextUpdate()
                    Button16.BackgroundImage = Nothing
                    TmrVerifyPaths.Enabled = True
                End If
            Else
                ButtonUnderEdit = 16
                FrmEdit.Show()
            End If
        ElseIf My.Computer.Keyboard.ShiftKeyDown Then
            ButtonUnderEdit = 16
            FrmReplace.Show()
        ElseIf My.Computer.Keyboard.AltKeyDown Then
            My.Computer.Clipboard.SetText(Button16_Target)
        Else
            Try
                Process.Start(Button16_Target)
            Catch
            End Try
            StartClosing()
        End If

    End Sub


    Private Sub Button16_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Button16.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            Dim Starget As String = ""
            Dim lastpart As String = ""
            '   MsgBox(path)
            Dim shell = CreateObject("WScript.Shell")
            If path.EndsWith(".lnk") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                lastpart = Starget.Substring(Starget.LastIndexOf("\") + 1)
            ElseIf path.EndsWith(".url") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                lastpart = Starget.Substring(Starget.LastIndexOf("/") + 1)
            End If

            If Starget = "" Then
                Button16_Target = path
                lastpart = path.Substring(path.LastIndexOf("/") + 1)
            Else
                Button16_Target = Starget
                If lastpart <> "" Then
                    lastpart = Replace(lastpart, ".exe", "")
                    lastpart = Replace(lastpart, ".bat", "")

                End If
            End If
            INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button16_Target", Button16_Target)
            toolTip1.SetToolTip(Me.Button16, Button16_Target)
            Button16_Text = lastpart
            Button16.Text = Button16_Text
            INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button16_Text", Button16_Text)
        Next

    End Sub

    Private Sub Button16_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Button16.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub



    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        '     Me.BackColor = Color.Blue
        '    Me.TransparencyKey = Nothing
        If Me.Height = 128 Then
            Timer1.Enabled = True
            Me.BackColor = Color.LightGray


        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyData.ToString = "Left" Then
            Me.Left -= 10
        ElseIf e.KeyData.ToString = "Right" Then
            Me.Left += 10
        ElseIf e.KeyData.ToString = "Up" Then
            Me.Top -= 10
        ElseIf e.KeyData.ToString = "Down" Then
            Me.Top += 10
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SaveSetting("Launcher", "Settings", "Top", Me.Top)
        SaveSetting("Launcher", "Settings", "Left", Me.Left)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        FrmAbout.ShowDialog()
    End Sub
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        Me.BackColor = Color.GhostWhite
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        mousepresent = True
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
        '  label1.Text = "X :  " & Control.MousePosition.X.ToString()
        '     Label2.Text = "Y : " & Control.MousePosition.Y.ToString()
        '     Me.Refresh()
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        drag = False
        Me.BackColor = Color.DimGray

    End Sub

    Private Sub Form1_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        mousepresent = False
        CloseVerify = 10
    End Sub

    Private Sub TmrDiagnostic_Tick(sender As Object, e As EventArgs) Handles TmrDiagnostic.Tick
        Label1.Text = mousepresent
    End Sub

    Private Sub ButtonsHover(sender As Object, e As EventArgs) Handles Button1.MouseHover, Button2.MouseHover,
        Button3.MouseHover, Button4.MouseHover, Button5.MouseHover,
        Button6.MouseHover, Button7.MouseHover, Button8.MouseHover, Button9.MouseHover,
        Button10.MouseHover, Button11.MouseHover, Button12.MouseHover, Button13.MouseHover,
       Button14.MouseHover, Button15.MouseHover, Button16.MouseHover
        mousepresent = True

    End Sub
    Private Sub Buttonsmove(sender As Object, e As EventArgs) Handles Button1.MouseMove, Button2.MouseMove,
        Button3.MouseMove, Button4.MouseMove, Button5.MouseMove,
        Button6.MouseMove, Button7.MouseMove, Button8.MouseMove, Button9.MouseMove,
        Button10.MouseMove, Button11.MouseMove, Button12.MouseMove, Button13.MouseMove,
        Button14.MouseMove, Button15.MouseMove, Button16.MouseMove
        mousepresent = True
    End Sub

    Private Sub ButtonsLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave, Button2.MouseLeave, Button3.MouseLeave,
        Button4.MouseLeave, Button5.MouseLeave,
        Button6.MouseLeave, Button6.MouseLeave, Button8.MouseLeave, Button9.MouseLeave,
        Button10.MouseLeave, Button11.MouseLeave, Button12.MouseLeave, Button13.MouseLeave,
        Button14.MouseLeave, Button15.MouseLeave, Button16.MouseLeave
        mousepresent = False

    End Sub

    Private Sub TmrDectMouse_Tick(sender As Object, e As EventArgs) Handles TmrDectMouse.Tick
        If mousepresent = False Then
            If CloseVerify = 0 Then
                If Me.Height = MaxHeight Then
                    TmrDectMouse.Enabled = False
                    StartClosing()
                    CloseVerify = 10
                End If
            Else
                CloseVerify = CloseVerify - 1
            End If
        End If
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        FrmHelp.Show()
    End Sub

    Sub TmrImgEffect_Tick(sender As Object, e As EventArgs) Handles TmrImgEffect.Tick
        LoadImages(WhichImage)
        WhichImage = WhichImage + 1
    End Sub

    Private Sub KeepMaxSizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeepMaxSizeToolStripMenuItem.Click
        If LockToMax = False Then
            LockToMax = True
            KeepMaxSizeToolStripMenuItem.Checked = True
            Me.Opacity = 1
            Me.BackColor = Color.BlanchedAlmond
            Me.Height = MaxHeight
            Me.Width = MaxWidth
            ButtonsVisible()
            Timer2.Enabled = False
            Me.Opacity = 1
            TmrDectMouse.Enabled = True
            TmrImgEffect.Enabled = True
            TmrVerifyPaths.Enabled = True
            Me.BackColor = Color.DimGray

        Else
            LockToMax = False
            KeepMaxSizeToolStripMenuItem.Checked = False
            StartClosing()
            Me.BackColor = Color.DimGray
        End If

        SaveSetting("Launcher", "Settings", "LockToMax", LockToMax)

    End Sub



    Sub verifpaths()

        'verify all paths
        If Trim(Button1_Target) <> "" Then

            If CheckExistence(Button1_Target) = True Then
                Button1.FlatAppearance.BorderColor = System.Drawing.Color.Green
            Else
                Button1.FlatAppearance.BorderColor = System.Drawing.Color.Red
            End If
        Else
            Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        End If

        If Trim(Button2_Target) <> "" Then
            If CheckExistence(Button2_Target) = True Then
                Button2.FlatAppearance.BorderColor = System.Drawing.Color.Green
            Else
                Button2.FlatAppearance.BorderColor = System.Drawing.Color.Red
            End If
        Else
            Button2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        End If


        If Trim(Button3_Target) <> "" Then

            If CheckExistence(Button3_Target) = True Then
                Button3.FlatAppearance.BorderColor = System.Drawing.Color.Green
            Else
                Button3.FlatAppearance.BorderColor = System.Drawing.Color.Red
            End If

        Else
            Button3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        End If


        If Trim(Button4_Target) <> "" Then

            If CheckExistence(Button4_Target) = True Then
                Button4.FlatAppearance.BorderColor = System.Drawing.Color.Green
            Else
                Button4.FlatAppearance.BorderColor = System.Drawing.Color.Red
            End If
        Else
            Button4.FlatAppearance.BorderColor = System.Drawing.Color.Black
        End If

        If Trim(Button5_Target) <> "" Then

            If CheckExistence(Button5_Target) = True Then
                Button5.FlatAppearance.BorderColor = System.Drawing.Color.Green
            Else
                Button5.FlatAppearance.BorderColor = System.Drawing.Color.Red
            End If


        Else
            Button5.FlatAppearance.BorderColor = System.Drawing.Color.Black
        End If

        If Trim(Button6_Target) <> "" Then
            If CheckExistence(Button6_Target) = True Then
                Button6.FlatAppearance.BorderColor = System.Drawing.Color.Green
            Else
                Button6.FlatAppearance.BorderColor = System.Drawing.Color.Red
            End If

        Else
            Button6.FlatAppearance.BorderColor = System.Drawing.Color.Black
        End If

        If Trim(Button7_Target) <> "" Then
            If CheckExistence(Button7_Target) = True Then
                Button7.FlatAppearance.BorderColor = System.Drawing.Color.Green
            Else
                Button7.FlatAppearance.BorderColor = System.Drawing.Color.Red
            End If
        Else
            Button7.FlatAppearance.BorderColor = System.Drawing.Color.Black
        End If

        If Trim(Button8_Target) <> "" Then
            If CheckExistence(Button8_Target) = True Then
                Button8.FlatAppearance.BorderColor = System.Drawing.Color.Green
            Else
                Button8.FlatAppearance.BorderColor = System.Drawing.Color.Red
            End If
        Else
            Button8.FlatAppearance.BorderColor = System.Drawing.Color.Black
        End If

        If Trim(Button9_Target) <> "" Then
            If CheckExistence(Button9_Target) = True Then
                Button9.FlatAppearance.BorderColor = System.Drawing.Color.Green
            Else
                Button9.FlatAppearance.BorderColor = System.Drawing.Color.Red
            End If
        Else
            Button9.FlatAppearance.BorderColor = System.Drawing.Color.Black
        End If

        If Trim(Button10_Target) <> "" Then
            If CheckExistence(Button10_Target) = True Then
                Button10.FlatAppearance.BorderColor = System.Drawing.Color.Green
            Else
                Button10.FlatAppearance.BorderColor = System.Drawing.Color.Red
            End If
        Else
            Button10.FlatAppearance.BorderColor = System.Drawing.Color.Black
        End If

        If Trim(Button11_Target) <> "" Then
            If CheckExistence(Button11_Target) = True Then
                Button11.FlatAppearance.BorderColor = System.Drawing.Color.Green
            Else
                Button11.FlatAppearance.BorderColor = System.Drawing.Color.Red
            End If
        Else
            Button11.FlatAppearance.BorderColor = System.Drawing.Color.Black
        End If

        If Trim(Button12_Target) <> "" Then
            If CheckExistence(Button12_Target) = True Then
                Button12.FlatAppearance.BorderColor = System.Drawing.Color.Green
            Else
                Button12.FlatAppearance.BorderColor = System.Drawing.Color.Red
            End If
        Else
            Button12.FlatAppearance.BorderColor = System.Drawing.Color.Black
        End If
        If Trim(Button13_Target) <> "" Then
            If CheckExistence(Button13_Target) = True Then
                Button13.FlatAppearance.BorderColor = System.Drawing.Color.Green
            Else
                Button13.FlatAppearance.BorderColor = System.Drawing.Color.Red
            End If
        Else
            Button13.FlatAppearance.BorderColor = System.Drawing.Color.Black
        End If


        If Trim(Button14_Target) <> "" Then
            If CheckExistence(Button14_Target) = True Then
                Button14.FlatAppearance.BorderColor = System.Drawing.Color.Green
            Else
                Button14.FlatAppearance.BorderColor = System.Drawing.Color.Red
            End If
        Else
            Button14.FlatAppearance.BorderColor = System.Drawing.Color.Black
        End If
        If Trim(Button15_Target) <> "" Then
            If CheckExistence(Button15_Target) = True Then
                Button15.FlatAppearance.BorderColor = System.Drawing.Color.Green
            Else
                Button15.FlatAppearance.BorderColor = System.Drawing.Color.Red
            End If
        Else
            Button15.FlatAppearance.BorderColor = System.Drawing.Color.Black

        End If
        If Trim(Button16_Target) <> "" Then
            If CheckExistence(Button16_Target) = True Then
                Button16.FlatAppearance.BorderColor = System.Drawing.Color.Green
            Else
                Button16.FlatAppearance.BorderColor = System.Drawing.Color.Red
            End If
        Else
            Button16.FlatAppearance.BorderColor = System.Drawing.Color.Black
        End If

    End Sub
    Sub TmrVerifyPaths_Tick(sender As Object, e As EventArgs) Handles TmrVerifyPaths.Tick

        Dim task = New Task(AddressOf verifpaths)
        ' Start and wait for task to end.
        task.Start()
        '   task.Wait()

        TmrVerifyPaths.Enabled = False
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs)
        MsgBox("2 " & Button2_Target)
        FrmDiag.Label1.Text = Button2_Target
    End Sub



    Private Sub PictureBox1_DragEnter(sender As Object, e As DragEventArgs) Handles PictureBox1.DragEnter
        mousepresent = True

        DraggedObject = True

        Me.Opacity = 1
        Me.BackColor = Color.BlanchedAlmond
        Me.Height = MaxHeight
        Me.Width = MaxWidth
        ButtonsVisible()
        Timer2.Enabled = False
        Me.Opacity = 1
        TmrDectMouse.Enabled = True
        TmrImgEffect.Enabled = True
        '  TmrVerifyPaths.Enabled = True
        Me.BackColor = Color.DimGray
    End Sub

    Private Sub Form1_DragOver(sender As Object, e As DragEventArgs) Handles Me.DragOver
        mousepresent = True
    End Sub

    Private Sub Form1_DragLeave(sender As Object, e As EventArgs) Handles Me.DragLeave
        ' mousepresent = False ' if enabled should add handle to all buttons to control drag over button

    End Sub

    Private Sub CntxMnu1_Opening(sender As Object, e As CancelEventArgs) Handles CntxMnu1.Opening

    End Sub
End Class
