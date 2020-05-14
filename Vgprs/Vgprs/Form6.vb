Public Class Form6

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox2.Parent = PictureBox1
        PictureBox3.Parent = PictureBox1
        PictureBox4.Parent = PictureBox1
        Label1.Parent = PictureBox1
        Label2.Parent = PictureBox1
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        End
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class