Public Class FrmAbout
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub FrmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = Form1.Top - ((Me.Height - Form1.Height) / 2)
        Me.Left = Form1.Left - ((Me.Width - Form1.Width) / 2)

        LblVer.Text = Application.ProductVersion
    End Sub
End Class