Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox1
        Label2.Parent = PictureBox1
        Label3.Parent = PictureBox1
        Label4.Parent = PictureBox1
        PictureBox2.Parent = PictureBox1
        PictureBox3.Parent = PictureBox1
        PictureBox4.Parent = PictureBox1
        PictureBox5.Parent = PictureBox1
        PictureBox6.Parent = PictureBox1
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Hide()

        form3.Show()

    End Sub

    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim frmLogin As New Form43()
        frmLogin.ShowDialog()
    End Sub

    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim frmLogin As New Form44()
        frmLogin.ShowDialog()
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim frmLogin As New Form45()
        frmLogin.ShowDialog()
    End Sub
End Class