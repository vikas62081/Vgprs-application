Public Class Form42
    Dim A, B, C, D, E, U As String
    Dim aa, bb, cc, dd, ee, ff, gg, hh, ii, jj, kk, ll, mm, nn, oo, pp, qq, rr, ss, tt, vv, uu, result As Integer
    Dim credit1, credit2, credit3, credit4, credit5, credit6, credit7, credit8, credit9, credit10, credit11, credit12, credit13, credit14, credit15, credit16, credit17, credit18, credit19, credit20, credittot As Integer
    Private Sub sum()
        If ComboBox1.Text = "U" Then
            aa = CInt("0")
            credit1 = 0
        ElseIf ComboBox21.Text = "1" Then
            credit1 = 1
        ElseIf ComboBox21.Text = "2" Then
            credit1 = 2
        ElseIf ComboBox21.Text = "3" Then
            credit1 = 3
        ElseIf ComboBox21.Text = "4" Then
            credit1 = 4
        End If
        If ComboBox1.Text = "" Then
            aa = 0
            credit1 = 0
        ElseIf (ComboBox1.Text = "A") Then
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
        If ComboBox2.Text = "U" Then
            bb = CInt("0")
            credit2 = 0
        ElseIf ComboBox22.Text = "1" Then
            credit2 = 1
        ElseIf ComboBox22.Text = "2" Then
            credit2 = 2
        ElseIf ComboBox22.Text = "3" Then
            credit2 = 3
        ElseIf ComboBox22.Text = "4" Then
            credit2 = 4
        End If
        If ComboBox2.Text = "" Then
            bb = 0
            credit2 = 0
        ElseIf (ComboBox2.Text = "A") Then
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
        If ComboBox3.Text = "U" Then
            cc = CInt("0")
            credit3 = 0
        ElseIf ComboBox23.Text = "1" Then
            credit3 = 1
        ElseIf ComboBox23.Text = "2" Then
            credit3 = 2
        ElseIf ComboBox23.Text = "3" Then
            credit3 = 3
        ElseIf ComboBox23.Text = "4" Then
            credit3 = 4
        End If
        If ComboBox3.Text = "" Then
            cc = 0
            credit3 = 0
        ElseIf (ComboBox3.Text = "A") Then
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
        If ComboBox4.Text = "U" Then
            dd = CInt("0")
            credit4 = 0
        ElseIf ComboBox24.Text = "1" Then
            credit4 = 1
        ElseIf ComboBox24.Text = "2" Then
            credit4 = 2
        ElseIf ComboBox24.Text = "3" Then
            credit4 = 3
        ElseIf ComboBox24.Text = "4" Then
            credit4 = 4
        End If
        If ComboBox4.Text = "" Then
            dd = 0
            credit4 = 0
        ElseIf (ComboBox4.Text = "A") Then
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
        If ComboBox5.Text = "U" Then
            ee = CInt("0")
            credit5 = 0
        ElseIf ComboBox25.Text = "1" Then
            credit5 = 1
        ElseIf ComboBox25.Text = "2" Then
            credit5 = 2
        ElseIf ComboBox25.Text = "3" Then
            credit5 = 3
        ElseIf ComboBox25.Text = "4" Then
            credit5 = 4
        End If
        If ComboBox5.Text = "" Then
            ee = 0
            credit5 = 0
        ElseIf (ComboBox5.Text = "A") Then
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
        If ComboBox6.Text = "U" Then
            ff = CInt("0")
            credit6 = 0
        ElseIf ComboBox26.Text = "1" Then
            credit6 = 1
        ElseIf ComboBox26.Text = "2" Then
            credit6 = 2
        ElseIf ComboBox26.Text = "3" Then
            credit6 = 3
        ElseIf ComboBox26.Text = "4" Then
            credit6 = 4
        End If
        If ComboBox6.Text = "" Then
            ff = 0
            credit6 = 0
        ElseIf (ComboBox6.Text = "A") Then
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
        If ComboBox7.Text = "U" Then
            gg = CInt("0")
            credit7 = 0
        ElseIf ComboBox27.Text = "1" Then
            credit7 = 1
        ElseIf ComboBox27.Text = "2" Then
            credit7 = 2
        ElseIf ComboBox27.Text = "3" Then
            credit7 = 3
        ElseIf ComboBox27.Text = "4" Then
            credit7 = 4
        End If
        If ComboBox7.Text = "" Then
            gg = 0
            credit7 = 0
        ElseIf (ComboBox7.Text = "A") Then
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
        If ComboBox8.Text = "U" Then
            hh = CInt("0")
            credit8 = 0
        ElseIf ComboBox28.Text = "1" Then
            credit8 = 1
        ElseIf ComboBox28.Text = "2" Then
            credit8 = 2
        ElseIf ComboBox28.Text = "3" Then
            credit8 = 3
        ElseIf ComboBox28.Text = "4" Then
            credit8 = 4
        End If
        If ComboBox8.Text = "" Then
            hh = 0
            credit8 = 0
        ElseIf (ComboBox8.Text = "A") Then
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
        If ComboBox9.Text = "U" Then
            ii = CInt("0")
            credit9 = 0
        ElseIf ComboBox29.Text = "1" Then
            credit9 = 1
        ElseIf ComboBox29.Text = "2" Then
            credit9 = 2
        ElseIf ComboBox29.Text = "3" Then
            credit9 = 3
        ElseIf ComboBox29.Text = "4" Then
            credit9 = 4
        End If
        If ComboBox9.Text = "" Then
            ii = 0
            credit9 = 0
        ElseIf (ComboBox9.Text = "A") Then
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
        If ComboBox10.Text = "U" Then
            jj = CInt("0")
            credit10 = 0
        ElseIf ComboBox30.Text = "1" Then
            credit10 = 1
        ElseIf ComboBox30.Text = "2" Then
            credit10 = 2
        ElseIf ComboBox30.Text = "3" Then
            credit10 = 3
        ElseIf ComboBox30.Text = "4" Then
            credit10 = 4
        End If
        If ComboBox10.Text = "" Then
            jj = 0
            credit10 = 0
        ElseIf (ComboBox10.Text = "A") Then
            jj = CInt("9")
        ElseIf ComboBox10.Text = "B" Then
            jj = CInt("8")
        ElseIf ComboBox10.Text = "C" Then
            jj = CInt("7")
        ElseIf ComboBox10.Text = "D" Then
            jj = CInt("6")
        ElseIf ComboBox10.Text = "E" Then
            jj = CInt("5")
        ElseIf ComboBox10.Text = "S" Then
            jj = CInt("10")
        End If
        If ComboBox11.Text = "U" Then
            kk = CInt("0")
            credit11 = 0
        ElseIf ComboBox31.Text = "1" Then
            credit11 = 1
        ElseIf ComboBox31.Text = "2" Then
            credit11 = 2
        ElseIf ComboBox31.Text = "3" Then
            credit11 = 3
        ElseIf ComboBox31.Text = "4" Then
            credit11 = 4
        End If
        If ComboBox11.Text = "" Then
            kk = 0
            credit11 = 0
        ElseIf (ComboBox11.Text = "A") Then
            kk = CInt("9")
        ElseIf ComboBox11.Text = "B" Then
            kk = CInt("8")
        ElseIf ComboBox11.Text = "C" Then
            kk = CInt("7")
        ElseIf ComboBox11.Text = "D" Then
            kk = CInt("6")
        ElseIf ComboBox11.Text = "E" Then
            kk = CInt("5")
        ElseIf ComboBox11.Text = "S" Then
            kk = CInt("10")
        End If
        If ComboBox12.Text = "U" Then
            ll = CInt("0")
            credit12 = 0
        ElseIf ComboBox32.Text = "1" Then
            credit12 = 1
        ElseIf ComboBox32.Text = "2" Then
            credit12 = 2
        ElseIf ComboBox32.Text = "3" Then
            credit12 = 3
        ElseIf ComboBox32.Text = "4" Then
            credit12 = 4
        End If
        If ComboBox12.Text = "" Then
            ll = 0
            credit12 = 0
        ElseIf (ComboBox12.Text = "A") Then
            ll = CInt("9")
        ElseIf ComboBox12.Text = "B" Then
            ll = CInt("8")
        ElseIf ComboBox12.Text = "C" Then
            ll = CInt("7")
        ElseIf ComboBox12.Text = "D" Then
            ll = CInt("6")
        ElseIf ComboBox12.Text = "E" Then
            ll = CInt("5")
        ElseIf ComboBox12.Text = "S" Then
            ll = CInt("10")
        End If
        If ComboBox13.Text = "U" Then
            mm = CInt("0")
            credit13 = 0
        ElseIf ComboBox33.Text = "1" Then
            credit13 = 1
        ElseIf ComboBox33.Text = "2" Then
            credit13 = 2
        ElseIf ComboBox33.Text = "3" Then
            credit13 = 3
        ElseIf ComboBox33.Text = "4" Then
            credit13 = 4
        End If
        If ComboBox13.Text = "" Then
            mm = 0
            credit13 = 0
        ElseIf (ComboBox13.Text = "A") Then
            mm = CInt("9")
        ElseIf ComboBox13.Text = "B" Then
            mm = CInt("8")
        ElseIf ComboBox13.Text = "C" Then
            mm = CInt("7")
        ElseIf ComboBox13.Text = "D" Then
            mm = CInt("6")
        ElseIf ComboBox13.Text = "E" Then
            mm = CInt("5")
        ElseIf ComboBox13.Text = "S" Then
            mm = CInt("10")
        End If
        If ComboBox14.Text = "U" Then
            nn = CInt("0")
            credit14 = 0
        ElseIf ComboBox34.Text = "1" Then
            credit14 = 1
        ElseIf ComboBox34.Text = "2" Then
            credit14 = 2
        ElseIf ComboBox34.Text = "3" Then
            credit14 = 3
        ElseIf ComboBox34.Text = "4" Then
            credit14 = 4
        End If
        If ComboBox14.Text = "" Then
            nn = 0
            credit14 = 0
        ElseIf (ComboBox14.Text = "A") Then
            nn = CInt("9")
        ElseIf ComboBox14.Text = "B" Then
            nn = CInt("8")
        ElseIf ComboBox14.Text = "C" Then
            nn = CInt("7")
        ElseIf ComboBox14.Text = "D" Then
            nn = CInt("6")
        ElseIf ComboBox14.Text = "E" Then
            nn = CInt("5")
        ElseIf ComboBox14.Text = "S" Then
            nn = CInt("10")
        End If
        If ComboBox15.Text = "U" Then
            oo = CInt("0")
            credit15 = 0
        ElseIf ComboBox35.Text = "1" Then
            credit15 = 1
        ElseIf ComboBox35.Text = "2" Then
            credit15 = 2
        ElseIf ComboBox35.Text = "3" Then
            credit15 = 3
        ElseIf ComboBox35.Text = "4" Then
            credit15 = 4
        End If
        If ComboBox15.Text = "" Then
            oo = 0
            credit15 = 0
        ElseIf (ComboBox15.Text = "A") Then
            oo = CInt("9")
        ElseIf ComboBox15.Text = "B" Then
            oo = CInt("8")
        ElseIf ComboBox15.Text = "C" Then
            oo = CInt("7")
        ElseIf ComboBox15.Text = "D" Then
            oo = CInt("6")
        ElseIf ComboBox15.Text = "E" Then
            oo = CInt("5")
        ElseIf ComboBox15.Text = "S" Then
            oo = CInt("10")
        End If
        If ComboBox16.Text = "U" Then
            pp = CInt("0")
            credit16 = 0
        ElseIf ComboBox36.Text = "1" Then
            credit16 = 1
        ElseIf ComboBox36.Text = "2" Then
            credit16 = 2
        ElseIf ComboBox36.Text = "3" Then
            credit16 = 3
        ElseIf ComboBox36.Text = "4" Then
            credit16 = 4
        End If
        If ComboBox16.Text = "" Then
            pp = 0
            credit16 = 0
        ElseIf (ComboBox16.Text = "A") Then
            pp = CInt("9")
        ElseIf ComboBox16.Text = "B" Then
            pp = CInt("8")
        ElseIf ComboBox16.Text = "C" Then
            pp = CInt("7")
        ElseIf ComboBox16.Text = "D" Then
            pp = CInt("6")
        ElseIf ComboBox16.Text = "E" Then
            pp = CInt("5")
        ElseIf ComboBox16.Text = "S" Then
            pp = CInt("10")
        End If
        If ComboBox17.Text = "U" Then
            qq = CInt("0")
            credit17 = 0
        ElseIf ComboBox37.Text = "1" Then
            credit17 = 1
        ElseIf ComboBox37.Text = "2" Then
            credit17 = 2
        ElseIf ComboBox37.Text = "3" Then
            credit17 = 3
        ElseIf ComboBox37.Text = "4" Then
            credit17 = 4
        End If
        If ComboBox17.Text = "" Then
            qq = 0
            credit17 = 0
        ElseIf (ComboBox17.Text = "A") Then
            qq = CInt("9")
        ElseIf ComboBox17.Text = "B" Then
            qq = CInt("8")
        ElseIf ComboBox17.Text = "C" Then
            qq = CInt("7")
        ElseIf ComboBox17.Text = "D" Then
            qq = CInt("6")
        ElseIf ComboBox17.Text = "E" Then
            qq = CInt("5")
        ElseIf ComboBox17.Text = "S" Then
            qq = CInt("10")
        End If
        If ComboBox18.Text = "U" Then
            rr = CInt("0")
            credit18 = 0
        ElseIf ComboBox38.Text = "1" Then
            credit18 = 1
        ElseIf ComboBox38.Text = "2" Then
            credit18 = 2
        ElseIf ComboBox38.Text = "3" Then
            credit18 = 3
        ElseIf ComboBox38.Text = "4" Then
            credit18 = 4
        End If
        If ComboBox18.Text = "" Then
            rr = 0
            credit18 = 0
        ElseIf (ComboBox18.Text = "A") Then
            rr = CInt("9")
        ElseIf ComboBox18.Text = "B" Then
            rr = CInt("8")
        ElseIf ComboBox18.Text = "C" Then
            rr = CInt("7")
        ElseIf ComboBox18.Text = "D" Then
            rr = CInt("6")
        ElseIf ComboBox18.Text = "E" Then
            rr = CInt("5")
        ElseIf ComboBox18.Text = "S" Then
            rr = CInt("10")
        End If
        If ComboBox19.Text = "U" Then
            ss = CInt("0")
            credit19 = 0
        ElseIf ComboBox39.Text = "1" Then
            credit19 = 1
        ElseIf ComboBox39.Text = "2" Then
            credit19 = 2
        ElseIf ComboBox39.Text = "3" Then
            credit19 = 3
        ElseIf ComboBox39.Text = "4" Then
            credit19 = 4
        End If
        If ComboBox19.Text = "" Then
            ss = 0
            credit19 = 0
        ElseIf (ComboBox19.Text = "A") Then
            ss = CInt("9")
        ElseIf ComboBox19.Text = "B" Then
            ss = CInt("8")
        ElseIf ComboBox19.Text = "C" Then
            ss = CInt("7")
        ElseIf ComboBox19.Text = "D" Then
            ss = CInt("6")
        ElseIf ComboBox19.Text = "E" Then
            ss = CInt("5")
        ElseIf ComboBox19.Text = "S" Then
            ss = CInt("10")
        End If
        If ComboBox20.Text = "U" Then
            tt = CInt("0")
            credit20 = 0
        ElseIf ComboBox40.Text = "1" Then
            credit20 = 1
        ElseIf ComboBox40.Text = "2" Then
            credit20 = 2
        ElseIf ComboBox40.Text = "3" Then
            credit20 = 3
        ElseIf ComboBox40.Text = "4" Then
            credit20 = 4
        End If
        If ComboBox20.Text = "" Then
            tt = 0
            credit20 = 0
        ElseIf (ComboBox20.Text = "A") Then
            tt = CInt("9")
        ElseIf ComboBox20.Text = "B" Then
            tt = CInt("8")
        ElseIf ComboBox20.Text = "C" Then
            tt = CInt("7")
        ElseIf ComboBox20.Text = "D" Then
            tt = CInt("6")
        ElseIf ComboBox20.Text = "E" Then
            tt = CInt("5")
        ElseIf ComboBox20.Text = "S" Then
            tt = CInt("10")
        End If
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Call sum()

        result = credit1 * Val(aa) + credit2 * Val(bb) + credit3 * Val(cc) + credit4 * Val(dd) + credit5 * Val(ee) + credit6 * Val(ff) + credit7 * Val(gg) + credit8 * Val(hh) + credit9 * Val(ii) + credit10 * Val(jj) + credit11 * Val(kk) + credit12 * Val(ll) + credit13 * Val(mm) + credit14 * Val(nn) + credit15 * Val(oo) + credit16 * Val(pp) + credit17 * Val(qq) + credit18 * Val(rr) + credit19 * Val(ss) + credit20 * Val(tt)
        credittot = credit1 + credit2 + credit3 + credit4 + credit5 + credit6 + credit7 + credit8 + credit9 + credit10 + credit11 + credit12 + credit13 + credit14 + credit15 + credit16 + credit17 + credit18 + credit19 + credit20
        If credittot = 0 Then
            Label21.Text = 0
        Else
            Label21.Text = result / credittot
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("C:/Program Files/Vgprs/all.pdf")
    End Sub

    Private Sub Form42_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class