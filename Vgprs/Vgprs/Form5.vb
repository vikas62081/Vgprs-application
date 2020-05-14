Public Class Form5
    Dim num1 As String
    Dim num2 As String
    Dim num3 As String


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
        form3.Show()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        TextBox1.Text = ""
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Process.Start(("http://aucoe.annauniv.edu/cgi-bin/result/cgrade.pl?regno=") + (num1))


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        num1 = Val(TextBox1.Text)
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        TextBox2.Text = ""
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        TextBox3.Text = ""

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Process.Start(("http://aucoe.annauniv.edu/cgi-bin/result/cograde.pl?regno=") + (num2))
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Process.Start(("http://aucoe.annauniv.edu/cgi-bin/result/tgrade.pl?regno=") + (num3))
    End Sub

    Private Sub TextBox1_OnValueChanged(sender As Object, e As EventArgs) Handles TextBox1.OnValueChanged
        num1 = Val(TextBox1.Text)
    End Sub

    Private Sub TextBox2_OnValueChanged(sender As Object, e As EventArgs) Handles TextBox2.OnValueChanged
        num2 = Val(TextBox2.Text)
    End Sub

    Private Sub TextBox3_OnValueChanged(sender As Object, e As EventArgs) Handles TextBox3.OnValueChanged
        num3 = Val(TextBox3.Text)
    End Sub
End Class