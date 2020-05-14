Public Class Form46
    Dim credit1, credit2, credit3, credit4, credit5, credit6, credit7, credit8, credittot As Integer
    Dim total As Double
    Private Sub condition()
        If TextBox1.Text = "" Then
            credit1 = 0
        Else
            credit1 = 1
        End If
        If TextBox2.Text = "" Then
            credit2 = 0
        Else
            credit2 = 1
        End If
        If TextBox3.Text = "" Then
            credit3 = 0
        Else
            credit3 = 1
        End If
        If TextBox4.Text = "" Then
            credit4 = 0
        Else
            credit4 = 1
        End If
        If TextBox5.Text = "" Then
            credit5 = 0
        Else
            credit5 = 1
        End If
        If TextBox6.Text = "" Then
            credit6 = 0
        Else
            credit6 = 1
        End If
        If TextBox7.Text = "" Then
            credit7 = 0
        Else
            credit7 = 1
        End If
        If TextBox8.Text = "" Then
            credit8 = 0
        Else
            credit8 = 1
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        form3.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        Label12.Text = ""
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Call condition()

        total = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox8.Text)
        credittot = credit1 + credit2 + credit3 + credit4 + credit5 + credit6 + credit7 + credit8
        If credittot = 0 Then
            Label12.Text = 0
        Else
            Label12.Text = total / credittot
        End If
    End Sub
End Class