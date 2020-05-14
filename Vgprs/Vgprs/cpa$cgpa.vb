Public Class form3

    Private Sub Label1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
       
    End Sub

    Private Sub form3_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox2.Parent = PictureBox1
        PictureBox3.Parent = PictureBox1
        PictureBox4.Parent = PictureBox1
        PictureBox5.Parent = PictureBox1
    End Sub


    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form46.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class