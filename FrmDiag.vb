Public Class FrmDiag
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ListView1.Items.Clear()
        ListView1.Items.Add(Button1_Text)
        ListView1.Items.Add(Button1_Target)
        ListView1.Items.Add(image1)
        ListView1.Items.Add(Button2_Text)
        ListView1.Items.Add(Button2_Target)
        ListView1.Items.Add(image2)
        ListView1.Items.Add(Button3_Text)
        ListView1.Items.Add(Button3_Target)
        ListView1.Items.Add(image3)
        Label1.Text = Now
    End Sub

    Private Sub FrmDiag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
End Class