﻿Public Class Form34
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
            credit4 = 6
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Timer1.Start()
        Call sum()
        result = 3 * Val(aa) + 3 * Val(bb) + 3 * Val(cc) + 6 * Val(dd)
        credittot = credit1 + credit2 + credit3 + credit4
        Label32.Text = result / credittot
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Form46.TextBox8.Text = Label32.Text
    End Sub
End Class