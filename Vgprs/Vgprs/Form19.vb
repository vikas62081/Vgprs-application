Public Class Form19
    Dim A, B, C, D, E, U As String
    Dim aa, bb, cc, dd, ee, ff, gg, hh, ii, uu, result As Integer
    Dim credit1, credit2, credit3, credit4, credit5, credit6, credit7, credit8, credit9, credittot As Integer
    Private Sub sum()
        If (ComboBox1.Text = "A") Then
            aa = CInt("9")
        ElseIf ComboBox1.Text = "B" Then
            aa = CInt("8")
        ElseIf ComboBox1.Text = "C" Then
            aa = CInt("7")
        ElseIf ComboBox1.Text = "D" Then
            aa = CInt("6")
        ElseIf ComboBox1.Text = "E" Then
            aa = CInt("5")
        ElseIf ComboBox1.Text = "S" Then
            aa = CInt("10")
        End If
        If ComboBox1.Text = "U" Then
            aa = CInt("0")
            credit1 = 0
        Else
            credit1 = 3
        End If
        If (ComboBox2.Text = "A") Then
            bb = CInt("9")
        ElseIf ComboBox2.Text = "B" Then
            bb = CInt("8")
        ElseIf ComboBox2.Text = "C" Then
            bb = CInt("7")
        ElseIf ComboBox2.Text = "D" Then
            bb = CInt("6")
        ElseIf ComboBox2.Text = "E" Then
            bb = CInt("5")
        ElseIf ComboBox2.Text = "S" Then
            bb = CInt("10")
        End If
        If ComboBox2.Text = "U" Then
            bb = CInt("0")
            credit2 = 0
        Else
            credit2 = 3
        End If
        If (ComboBox3.Text = "A") Then
            cc = CInt("9")
        ElseIf ComboBox3.Text = "B" Then
            cc = CInt("8")
        ElseIf ComboBox3.Text = "C" Then
            cc = CInt("7")
        ElseIf ComboBox3.Text = "D" Then
            cc = CInt("6")
        ElseIf ComboBox3.Text = "E" Then
            cc = CInt("5")
        ElseIf ComboBox3.Text = "S" Then
            cc = CInt("10")
        End If
        If ComboBox3.Text = "U" Then
            cc = CInt("0")
            credit3 = 0
        Else
            credit3 = 3
        End If
        If (ComboBox4.Text = "A") Then
            dd = CInt("9")
        ElseIf ComboBox4.Text = "B" Then
            dd = CInt("8")
        ElseIf ComboBox4.Text = "C" Then
            dd = CInt("7")
        ElseIf ComboBox4.Text = "D" Then
            dd = CInt("6")
        ElseIf ComboBox4.Text = "E" Then
            dd = CInt("5")
        ElseIf ComboBox4.Text = "S" Then
            dd = CInt("10")
        End If
        If ComboBox4.Text = "U" Then
            dd = CInt("0")
            credit4 = 0
        Else
            credit4 = 3
        End If
        If (ComboBox5.Text = "A") Then
            ee = CInt("9")
        ElseIf ComboBox5.Text = "B" Then
            ee = CInt("8")
        ElseIf ComboBox5.Text = "C" Then
            ee = CInt("7")
        ElseIf ComboBox5.Text = "D" Then
            ee = CInt("6")
        ElseIf ComboBox5.Text = "E" Then
            ee = CInt("5")
        ElseIf ComboBox5.Text = "S" Then
            ee = CInt("10")
        End If
        If ComboBox5.Text = "U" Then
            ee = CInt("0")
            credit5 = 0
        Else
            credit5 = 3
        End If
        If (ComboBox6.Text = "A") Then
            ff = CInt("9")
        ElseIf ComboBox6.Text = "B" Then
            ff = CInt("8")
        ElseIf ComboBox6.Text = "C" Then
            ff = CInt("7")
        ElseIf ComboBox6.Text = "D" Then
            ff = CInt("6")
        ElseIf ComboBox6.Text = "E" Then
            ff = CInt("5")
        ElseIf ComboBox6.Text = "S" Then
            ff = CInt("10")
        End If
        If ComboBox6.Text = "U" Then
            ff = CInt("0")
            credit6 = 0
        Else
            credit6 = 3
        End If
        If (ComboBox7.Text = "A") Then
            gg = CInt("9")
        ElseIf ComboBox7.Text = "B" Then
            gg = CInt("8")
        ElseIf ComboBox7.Text = "C" Then
            gg = CInt("7")
        ElseIf ComboBox7.Text = "D" Then
            gg = CInt("6")
        ElseIf ComboBox7.Text = "E" Then
            gg = CInt("5")
        ElseIf ComboBox7.Text = "S" Then
            gg = CInt("10")
        End If
        If ComboBox7.Text = "U" Then
            gg = CInt("0")
            credit7 = 0
        Else
            credit7 = 2
        End If
        If (ComboBox8.Text = "A") Then
            hh = CInt("9")
        ElseIf ComboBox8.Text = "B" Then
            hh = CInt("8")
        ElseIf ComboBox8.Text = "C" Then
            hh = CInt("7")
        ElseIf ComboBox8.Text = "D" Then
            hh = CInt("6")
        ElseIf ComboBox8.Text = "E" Then
            hh = CInt("5")
        ElseIf ComboBox8.Text = "S" Then
            hh = CInt("10")
        End If
        If ComboBox8.Text = "U" Then
            hh = CInt("0")
            credit8 = 0
        Else
            credit8 = 2
        End If
        If (ComboBox9.Text = "A") Then
            ii = CInt("9")
        ElseIf ComboBox9.Text = "B" Then
            ii = CInt("8")
        ElseIf ComboBox9.Text = "C" Then
            ii = CInt("7")
        ElseIf ComboBox9.Text = "D" Then
            ii = CInt("6")
        ElseIf ComboBox9.Text = "E" Then
            ii = CInt("5")
        ElseIf ComboBox9.Text = "S" Then
            ii = CInt("10")
        End If
        If ComboBox9.Text = "U" Then
            ii = CInt("0")
            credit9 = 0
        Else
            credit9 = 2
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Timer1.Start()
        Call sum()
        result = 3 * Val(aa) + 3 * Val(bb) + 3 * Val(cc) + 3 * Val(dd) + 3 * Val(ee) + 3 * Val(ff) + 2 * Val(gg) + 2 * Val(hh) + 2 * Val(ii)
        credittot = credit1 + credit2 + credit3 + credit4 + credit5 + credit6 + credit7 + credit8 + credit9
        Label32.Text = result / credittot
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Form46.TextBox6.Text = Label32.Text
    End Sub
End Class