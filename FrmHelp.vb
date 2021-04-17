Imports System.IO

Public Class FrmHelp
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start(Application.StartupPath)
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start(Application.StartupPath & "\Launcher.ini")
    End Sub


    Private Sub FrmHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = Form1.Top + Form1.Height
        Me.Left = Form1.Left


    End Sub

    Private Sub frmhelp_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        Me.BackColor = Color.GhostWhite
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub frmhelp_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Try
            Dim bArr As Byte() = System.Text.Encoding.Default.GetBytes(My.Resources.Launcher_blank)
            File.WriteAllBytes(Application.StartupPath & "\Launcher.ini", bArr)
        Catch ex As Exception

        End Try

        Dim ans = MsgBox("Do you want o restart the program?", vbYesNo)
        If ans = vbYes Then
            Application.Restart()
        End If

    End Sub

    Private Sub frmhelp_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        drag = False
        Me.BackColor = Color.SlateGray
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Dim hrs As String = Now.Hour
        Dim mins As String = Now.Minute
        Dim secs As String = Now.Second
        Try
            My.Computer.FileSystem.CopyFile(Application.StartupPath & "\Launcher.ini", Application.StartupPath & "\Launcher.ini." & hrs & mins & secs & ".bak", overwrite:=False)
        Catch ex As Exception

        End Try
    End Sub
End Class