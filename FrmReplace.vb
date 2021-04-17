Public Class FrmReplace
    Dim aTarget As String
    Dim aText As String
    Dim aImage As String
    Dim bTarget As String
    Dim bText As String
    Dim bImage As String
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub FrmReplace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = Form1.Top
        Me.Left = Form1.Left + Form1.Width
        Label4.Text = ButtonUnderEdit
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
    Private Sub frmReplace_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        Me.BackColor = Color.GhostWhite
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub frmReplace_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub frmReplace_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        drag = False
        Me.BackColor = Color.SlateGray
    End Sub
    Sub CopySource()
        Select Case ButtonUnderEdit
            Case 1
                aText = Button1_Text
                aTarget = Button1_Target
                aImage = image1

            Case 2
                aText = Button2_Text
                aTarget = Button2_Target
                aImage = image2
            Case 3
                aText = Button3_Text
                aTarget = Button3_Target
                aImage = image3
            Case 4
                aText = Button4_Text
                aTarget = Button4_Target
                aImage = image4
            Case 5
                aText = Button5_Text
                aTarget = Button5_Target
                aImage = image5
            Case 6
                aText = Button6_Text
                aTarget = Button6_Target
                aImage = image6
            Case 7
                aText = Button7_Text
                aTarget = Button7_Target
                aImage = image7
            Case 8
                aText = Button8_Text
                aTarget = Button8_Target
                aImage = image8
            Case 9
                aText = Button9_Text
                aTarget = Button9_Target
                aImage = image9
            Case 10
                aText = Button10_Text
                aTarget = Button10_Target
                aImage = image10
            Case 11
                aText = Button11_Text
                aTarget = Button11_Target
                aImage = image11
            Case 12
                aText = Button12_Text
                aTarget = Button12_Target
                aImage = image12
            Case 13
                aText = Button13_Text
                aTarget = Button13_Target
                aImage = image13
            Case 14
                aText = Button14_Text
                aTarget = Button14_Target
                aImage = image14
            Case 15
                aText = Button15_Text
                aTarget = Button15_Target
                aImage = image15
            Case 16
                aText = Button16_Text
                aTarget = Button16_Target
                aImage = image16

        End Select
    End Sub
    Sub CopyTarget()
        Select Case ButtonUnderUpdate
            Case 1
                bText = Button1_Text
                bTarget = Button1_Target
                bImage = image1

            Case 2
                bText = Button2_Text
                bTarget = Button2_Target
                bImage = image2
            Case 3
                bText = Button3_Text
                bTarget = Button3_Target
                bImage = image3
            Case 4
                bText = Button4_Text
                bTarget = Button4_Target
                bImage = image4
            Case 5
                bText = Button5_Text
                bTarget = Button5_Target
                bImage = image5
            Case 6
                bText = Button6_Text
                bTarget = Button6_Target
                bImage = image6
            Case 7
                bText = Button7_Text
                bTarget = Button7_Target
                bImage = image7
            Case 8
                bText = Button8_Text
                bTarget = Button8_Target
                bImage = image8
            Case 9
                bText = Button9_Text
                bTarget = Button9_Target
                bImage = image9
            Case 10
                bText = Button10_Text
                bTarget = Button10_Target
                bImage = image10
            Case 11
                bText = Button11_Text
                bTarget = Button11_Target
                bImage = image11
            Case 12
                bText = Button12_Text
                bTarget = Button12_Target
                bImage = image12
            Case 13
                bText = Button13_Text
                bTarget = Button13_Target
                bImage = image13
            Case 14
                bText = Button14_Text
                bTarget = Button14_Target
                bImage = image14
            Case 15
                bText = Button15_Text
                bTarget = Button15_Target
                bImage = image15
            Case 16
                bText = Button16_Text
                bTarget = Button16_Target
                bImage = image16

        End Select
    End Sub
    Sub ReplaceTarget()
        Select Case ButtonUnderUpdate
            Case 1
                Button1_Text = aText
                Button1_Target = aTarget
                image1 = aImage
            Case 2
                Button2_Text = aText
                Button2_Target = aTarget
                image2 = aImage
            Case 3
                Button3_Text = aText
                Button3_Target = aTarget
                image3 = aImage
            Case 4
                Button4_Text = aText
                Button4_Target = aTarget
                image4 = aImage
            Case 5
                Button5_Text = aText
                Button5_Target = aTarget
                image5 = aImage
            Case 6
                Button6_Text = aText
                Button6_Target = aTarget
                image6 = aImage
            Case 7
                Button7_Text = aText
                Button7_Target = aTarget
                image7 = aImage
            Case 8
                Button8_Text = aText
                Button8_Target = aTarget
                image8 = aImage
            Case 9
                Button9_Text = aText
                Button9_Target = aTarget
                image9 = aImage
            Case 10
                Button10_Text = aText
                Button10_Target = aTarget
                image10 = aImage
            Case 11
                Button11_Text = aText
                Button11_Target = aTarget
                image11 = aImage
            Case 12
                Button12_Text = aText
                Button12_Target = aTarget
                image12 = aImage
            Case 13
                Button13_Text = aText
                Button13_Target = aTarget
                image13 = aImage
            Case 14
                Button14_Text = aText
                Button14_Target = aTarget
                image14 = aImage
            Case 15
                Button15_Text = aText
                Button15_Target = aTarget
                image15 = aImage
            Case 16
                Button16_Text = aText
                Button16_Target = aTarget
                image16 = aImage

        End Select
    End Sub
    Sub ReplaceSource()
        Select Case ButtonUnderEdit
            Case 1
                Button1_Text = bText
                Button1_Target = bTarget
                image1 = bImage
            Case 2
                Button2_Text = bText
                Button2_Target = bTarget
                image2 = bImage
            Case 3
                Button3_Text = bText
                Button3_Target = bTarget
                image3 = bImage
            Case 4
                Button4_Text = bText
                Button4_Target = bTarget
                image4 = bImage
            Case 5
                Button5_Text = bText
                Button5_Target = bTarget
                image5 = bImage
            Case 6
                Button6_Text = bText
                Button6_Target = bTarget
                image6 = bImage
            Case 7
                Button7_Text = bText
                Button7_Target = bTarget
                image7 = bImage
            Case 8
                Button8_Text = bText
                Button8_Target = bTarget
                image8 = bImage
            Case 9
                Button9_Text = bText
                Button9_Target = bTarget
                image9 = bImage
            Case 10
                Button10_Text = bText
                Button10_Target = bTarget
                image10 = bImage
            Case 11
                Button11_Text = bText
                Button11_Target = bTarget
                image11 = bImage
            Case 12
                Button12_Text = bText
                Button12_Target = bTarget
                image12 = bImage
            Case 13
                Button13_Text = bText
                Button13_Target = bTarget
                image13 = bImage
            Case 14
                Button14_Text = bText
                Button14_Target = bTarget
                image14 = bImage
            Case 15
                Button15_Text = bText
                Button15_Target = bTarget
                image15 = bImage
            Case 16
                Button16_Text = bText
                Button16_Target = bTarget
                image16 = bImage



        End Select
    End Sub


    Sub SaveChanges()

        Select Case ButtonUnderEdit
            Case 1
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button1_Text", Button1_Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button1_Target", Button1_Target)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button1_Image", image1)
            Case 2
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button2_Text", Button2_Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button2_Target", Button2_Target)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button2_Image", image2)
            Case 3
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button3_Text", Button3_Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button3_Target", Button3_Target)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button3_Image", image3)
            Case 4
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button4_Text", Button4_Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button4_Target", Button4_Target)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button4_Image", image4)
            Case 5
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button5_Text", Button5_Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button5_Target", Button5_Target)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button5_Image", image5)

            Case 6
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button6_Text", Button6_Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button6_Target", Button6_Target)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button6_Image", image6)

            Case 7
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button7_Text", Button7_Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button7_Target", Button7_Target)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button7_Image", image7)

            Case 8
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button8_Text", Button8_Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button8_Target", Button8_Target)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button8_Image", image8)

            Case 9
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button9_Text", Button9_Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button9_Target", Button9_Target)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button9_Image", image9)

            Case 10
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button10_Text", Button10_Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button10_Target", Button10_Target)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button10_Image", image10)

            Case 11
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button11_Text", Button11_Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button11_Target", Button11_Target)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button11_Image", image11)

            Case 12
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button12_Text", Button12_Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button12_Target", Button12_Target)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button12_Image", image12)

            Case 13
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button13_Text", Button13_Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button13_Target", Button13_Target)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button13_Image", image13)

            Case 14
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button14_Text", Button14_Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button14_Target", Button14_Target)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button14_Image", image14)

            Case 15
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button15_Text", Button15_Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button15_Target", Button15_Target)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button15_Image", image15)

            Case 16
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button16_Text", Button16_Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button16_Target", Button16_Target)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button16_Image", image16)

            Case Else
        End Select


        Select Case ButtonUnderUpdate
            Case 1
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button1_Text", Button1_Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button1_Target", Button1_Target)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button1_Image", image1)
            Case 2
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button2_Text", Button2_Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button2_Target", Button2_Target)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button2_Image", image2)
            Case 3
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button3_Text", Button3_Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button3_Target", Button3_Target)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button3_Image", image3)
            Case 4
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button4_Text", Button4_Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button4_Target", Button4_Target)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button4_Image", image4)
            Case 5
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button5_Text", Button5_Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button5_Target", Button5_Target)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button5_Image", image5)

            Case 6
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button6_Text", Button6_Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button6_Target", Button6_Target)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button6_Image", image6)

            Case 7
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button7_Text", Button7_Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button7_Target", Button7_Target)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button7_Image", image7)

            Case 8
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button8_Text", Button8_Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button8_Target", Button8_Target)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button8_Image", image8)

            Case 9
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button9_Text", Button9_Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button9_Target", Button9_Target)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button9_Image", image9)

            Case 10
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button10_Text", Button10_Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button10_Target", Button10_Target)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button10_Image", image10)

            Case 11
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button11_Text", Button11_Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button11_Target", Button11_Target)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button11_Image", image11)

            Case 12
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button12_Text", Button12_Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button12_Target", Button12_Target)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button12_Image", image12)

            Case 13
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button13_Text", Button13_Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button13_Target", Button13_Target)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button13_Image", image13)

            Case 14
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button14_Text", Button14_Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button14_Target", Button14_Target)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button14_Image", image14)

            Case 15
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button15_Text", Button15_Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button15_Target", Button15_Target)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button15_Image", image15)

            Case 16
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button16_Text", Button16_Text)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button16_Target", Button16_Target)
                INIWrite(Application.StartupPath & "\Launcher.ini", "Settings", "Button16_Image", image16)

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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CopySource()
        CopyTarget()
        ReplaceTarget()
        ReplaceSource()
        SaveChanges()
        'save
        ButtonUnderEdit = 0
        ButtonUnderUpdate = 0
        Label3.Visible = True
        Timer1.Enabled = True
        Form1.TmrImgEffect.Enabled = True
        Form1.TextUpdate()

        Form1.SetTooltips()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ButtonUnderEdit = 0
        Me.Close()
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If NumericUpDown1.Value = ButtonUnderEdit Then
            NumericUpDown1.BackColor = Color.Red
            NumericUpDown1.ForeColor = Color.White
        Else
            NumericUpDown1.BackColor = Color.White
            NumericUpDown1.ForeColor = Color.Black
        End If

        ButtonUnderUpdate = NumericUpDown1.Value
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Me.Close()
        Label3.Visible = False
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        FrmEdit.Show()
        Me.Close()

    End Sub
End Class