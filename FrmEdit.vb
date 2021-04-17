

Public Class FrmEdit
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Sub SaveChange()

        Select Case ButtonUnderEdit
            Case 1
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button1_Text", TextBox1.Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button1_Target", TextBox2.Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button1_Image", TextBox3.Text)
                Button1_Text = TextBox1.Text
                Button1_Target = TextBox2.Text
                image1 = TextBox3.Text

            Case 2
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button2_Text", TextBox1.Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button2_Target", TextBox2.Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button2_Image", TextBox3.Text)
                Button2_Text = TextBox1.Text
                Button2_Target = TextBox2.Text
                image2 = TextBox3.Text
            Case 3
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button3_Text", TextBox1.Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button3_Target", TextBox2.Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button3_Image", TextBox3.Text)
                Button3_Text = TextBox1.Text
                Button3_Target = TextBox2.Text
                image3 = TextBox3.Text
            Case 4
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button4_Text", TextBox1.Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button4_Target", TextBox2.Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button4_Image", TextBox3.Text)
                Button4_Text = TextBox1.Text
                Button4_Target = TextBox2.Text
                image4 = TextBox3.Text
            Case 5
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button5_Text", TextBox1.Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button5_Target", TextBox2.Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button5_Image", TextBox3.Text)
                Button5_Text = TextBox1.Text
                Button5_Target = TextBox2.Text
                image5 = TextBox3.Text
            Case 6
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button6_Text", TextBox1.Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button6_Target", TextBox2.Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button6_Image", TextBox3.Text)
                Button6_Text = TextBox1.Text
                Button6_Target = TextBox2.Text
                image6 = TextBox3.Text
            Case 7
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button7_Text", TextBox1.Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button7_Target", TextBox2.Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button7_Image", TextBox3.Text)
                Button7_Text = TextBox1.Text
                Button7_Target = TextBox2.Text
                image7 = TextBox3.Text
            Case 8
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button8_Text", TextBox1.Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button8_Target", TextBox2.Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button8_Image", TextBox3.Text)
                Button8_Text = TextBox1.Text
                Button8_Target = TextBox2.Text
                image8 = TextBox3.Text
            Case 9
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button9_Text", TextBox1.Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button9_Target", TextBox2.Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button9_Image", TextBox3.Text)
                Button9_Text = TextBox1.Text
                Button9_Target = TextBox2.Text
                image1 = TextBox3.Text
            Case 10
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button10_Text", TextBox1.Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button10_Target", TextBox2.Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button10_Image", TextBox3.Text)
                Button10_Text = TextBox1.Text
                Button10_Target = TextBox2.Text
                image10 = TextBox3.Text
            Case 11
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button11_Text", TextBox1.Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button11_Target", TextBox2.Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button11_Image", TextBox3.Text)
                Button11_Text = TextBox1.Text
                Button11_Target = TextBox2.Text
                image11 = TextBox3.Text
            Case 12
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button12_Text", TextBox1.Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button12_Target", TextBox2.Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button12_Image", TextBox3.Text)
                Button12_Text = TextBox1.Text
                Button12_Target = TextBox2.Text
                image12 = TextBox3.Text
            Case 13
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button13_Text", TextBox1.Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button13_Target", TextBox2.Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button13_Image", TextBox3.Text)
                Button13_Text = TextBox1.Text
                Button13_Target = TextBox2.Text
                image13 = TextBox3.Text
            Case 14
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button14_Text", TextBox1.Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button14_Target", TextBox2.Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button14_Image", TextBox3.Text)
                Button14_Text = TextBox1.Text
                Button14_Target = TextBox2.Text
                image14 = TextBox3.Text
            Case 15
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button15_Text", TextBox1.Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button15_Target", TextBox2.Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button15_Image", TextBox3.Text)
                Button15_Text = TextBox1.Text
                Button15_Target = TextBox2.Text
                image15 = TextBox3.Text
            Case 16
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button16_Text", TextBox1.Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button16_Target", TextBox2.Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button16_Image", TextBox3.Text)
                Button16_Text = TextBox1.Text
                Button16_Target = TextBox2.Text
                image16 = TextBox3.Text
            Case Else
        End Select

        Form1.TextUpdate()
        Form1.SetTooltips()

        Form1.TmrVerifyPaths_Tick(Nothing, Nothing)
        ' WhichImage = 0
        ' Form1.TmrImgEffect.Enabled = True
        Form1.ClearButtonImages()
        For i As Integer = 0 To 16
            Try
                Form1.LoadImages(i)
            Catch ex As Exception

            End Try
        Next


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveChange()

        ButtonUnderEdit = 0
        Me.Close()
        'save

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ButtonUnderEdit = 0
        Me.Close()
        'cancel
    End Sub

    Private Sub FrmEdit_Click(sender As Object, e As EventArgs) Handles Me.Click
        ' TextBox1.Text = Button1_Text
        '    TextBox2.Text = Button1_Target
        '  TextBox3.Text = image1
        '  MsgBox(ButtonUnderEdit & " - " & Button2_Target)
    End Sub

    Private Sub FrmEdit_ContextMenuStripChanged(sender As Object, e As EventArgs) Handles Me.ContextMenuStripChanged

    End Sub

    Private Sub FrmEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = Form1.Top
        Me.Left = Form1.Left + Form1.Width
        Label4.Text = ButtonUnderEdit

        Select Case ButtonUnderEdit

            Case 0

            Case 1
                TextBox1.Text = Button1_Text
                TextBox2.Text = Button1_Target
                TextBox3.Text = image1
            Case 2
                TextBox1.Text = Button2_Text
                TextBox2.Text = Button2_Target
                TextBox3.Text = image2
            Case 3
                TextBox1.Text = Button3_Text
                TextBox2.Text = Button3_Target
                TextBox3.Text = image3
            Case 4
                TextBox1.Text = Button4_Text
                TextBox2.Text = Button4_Target
                TextBox3.Text = image4
            Case 5
                TextBox1.Text = Button5_Text
                TextBox2.Text = Button5_Target
                TextBox3.Text = image5
            Case 6
                TextBox1.Text = Button6_Text
                TextBox2.Text = Button6_Target
                TextBox3.Text = image6
            Case 7
                TextBox1.Text = Button7_Text
                TextBox2.Text = Button7_Target
                TextBox3.Text = image7
            Case 8
                TextBox1.Text = Button8_Text
                TextBox2.Text = Button8_Target
                TextBox3.Text = image8
            Case 9
                TextBox1.Text = Button9_Text
                TextBox2.Text = Button9_Target
                TextBox3.Text = image9
            Case 10
                TextBox1.Text = Button10_Text
                TextBox2.Text = Button10_Target
                TextBox3.Text = image10
            Case 11
                TextBox1.Text = Button11_Text
                TextBox2.Text = Button11_Target
                TextBox3.Text = image11
            Case 12
                TextBox1.Text = Button12_Text
                TextBox2.Text = Button12_Target
                TextBox3.Text = image12
            Case 13
                TextBox1.Text = Button13_Text
                TextBox2.Text = Button13_Target
                TextBox3.Text = image13
            Case 14
                TextBox1.Text = Button14_Text
                TextBox2.Text = Button14_Target
                TextBox3.Text = image14
            Case 15
                TextBox1.Text = Button15_Text
                TextBox2.Text = Button15_Target
                TextBox3.Text = image15
            Case 16
                TextBox1.Text = Button16_Text
                TextBox2.Text = Button16_Target
                TextBox3.Text = image16
            Case Else

        End Select








    End Sub

    Private Sub FrmEdit_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        Me.BackColor = Color.GhostWhite
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub FrmEdit_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub FrmEdit_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        drag = False
        Me.BackColor = Color.SlateGray
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick



        Timer1.Enabled = False


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            TextBox2.Text = strFileName

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim directoryName As String = ""
        Try
            directoryName = System.IO.Path.GetDirectoryName(TextBox2.Text)
        Catch ex As Exception

        End Try


        Dim fd As FolderBrowserDialog = New FolderBrowserDialog()
        Dim strfolderName As String

        If directoryName <> "" Then
            Try

                fd.RootFolder = directoryName
            Catch ex As Exception

            End Try
        End If

        If fd.ShowDialog() = DialogResult.OK Then
            strfolderName = fd.SelectedPath
            TextBox2.Text = strfolderName
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_DragDrop(sender As Object, e As DragEventArgs) Handles TextBox2.DragDrop
        Dim Starget As String = ""
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files

            Dim lastpart As String = ""
            '   MsgBox(path)
            Dim shell = CreateObject("WScript.Shell")
            If path.EndsWith(".lnk") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                '    lastpart = Starget.Substring(Starget.LastIndexOf("\") + 1)
            ElseIf path.EndsWith(".url") = True Then
                Starget = shell.CreateShortcut(path).TargetPath
                '    lastpart = Starget.Substring(Starget.LastIndexOf("/") + 1)
            End If
        Next
        TextBox2.Text = starget


    End Sub

    Private Sub TextBox2_DragEnter(sender As Object, e As DragEventArgs) Handles TextBox2.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        FrmReplace.Show()
        Me.Close()

    End Sub
End Class