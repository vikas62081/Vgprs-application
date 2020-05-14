Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox1
        Label2.Parent = PictureBox1
        Label3.Parent = PictureBox1
        PictureBox2.Parent = PictureBox1
        PictureBox3.Parent = PictureBox1
        PictureBox2.Enabled = False

        If ComboBox1.Text = "" Then
            ComboBox2.Enabled = False
        Else
            ComboBox2.Enabled = True
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Enabled = True
        If ComboBox2.Text = "" Then
            PictureBox2.Enabled = True
        Else
            PictureBox2.Enabled = True
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If ComboBox1.Text = "CSE" Then
            If ComboBox2.Text = "SEM-1" Then
                Form7.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-2" Then
                Form8.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-3" Then
                Form9.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-4" Then
                Form10.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-5" Then
                Form11.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-6" Then
                Form12.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-7" Then
                Form13.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-8" Then
                Form14.Show()
                Me.Close()
            End If

        ElseIf ComboBox1.Text = "MECH" Then
            If ComboBox2.Text = "SEM-1" Then
                Form7.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-2" Then
                Form15.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-3" Then
                Form16.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-4" Then
                Form17.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-5" Then
                Form18.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-6" Then
                Form19.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-7" Then
                Form20.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-8" Then
                Form21.Show()
                Me.Close()
            End If

        ElseIf ComboBox1.Text = "CIVIL" Then
            If ComboBox2.Text = "SEM-1" Then
                Form7.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-2" Then
                Form15.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-3" Then
                Form22.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-4" Then
                Form23.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-5" Then
                Form24.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-6" Then
                Form25.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-7" Then
                Form26.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-8" Then
                Form27.Show()
                Me.Close()
            End If

        ElseIf ComboBox1.Text = "EEE" Then
            If ComboBox2.Text = "SEM-1" Then
                Form7.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-2" Then
                Form28.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-3" Then
                Form29.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-4" Then
                Form30.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-5" Then
                Form31.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-6" Then
                Form32.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-7" Then
                Form33.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-8" Then
                Form34.Show()
                Me.Close()
            End If

        ElseIf ComboBox1.Text = "ECE" Then
            If ComboBox2.Text = "SEM-1" Then
                Form7.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-2" Then
                Form35.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-3" Then
                Form36.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-4" Then
                Form37.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-5" Then
                Form38.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-6" Then
                Form39.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-7" Then
                Form40.Show()
                Me.Close()
            ElseIf ComboBox2.Text = "SEM-8" Then
                Form41.Show()
                Me.Close()
            End If
        End If
        If ComboBox3.Text = "ALL" Then
            Form42.Show()
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
        form3.Show()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.Text = "ALL" Then
            PictureBox2.Enabled = True
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        PictureBox2.Enabled = True
    End Sub
End Class