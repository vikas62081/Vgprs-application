Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Parent = PictureBox1
        Label2.Parent = PictureBox1
        Label3.Parent = PictureBox1
        PictureBox2.Parent = PictureBox1

        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick_3(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value >= 100 Then
            Me.Hide()
            Form2.Show()
            Timer1.Stop()
            Exit Sub
        Else
            ProgressBar1.Value += 1
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_LoadCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles PictureBox1.LoadCompleted

    End Sub

    Private Sub ProgressBar1_progressChanged(sender As Object, e As EventArgs) Handles ProgressBar1.progressChanged

    End Sub
End Class