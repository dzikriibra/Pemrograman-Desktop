Public Class FrmSegitiga
    Private Sub ButtonKel_Click(sender As Object, e As EventArgs) Handles ButtonKel.Click
        Dim a, b, c, Hasil As Double
        a = Val(Kel1.Text)
        b = Val(Kel2.Text)
        c = Val(Kel3.Text)
        Hasil = a + b + c
        HslKel.Text = Hasil
        alasSeg.Focus()

    End Sub

    Private Sub ButtonLuas_Click(sender As Object, e As EventArgs) Handles ButtonLuas.Click
        Dim a, t, Hasil As Double
        a = Val(alasSeg.Text)
        t = Val(tinggiSeg.Text)
        Hasil = 0.5 * a * t
        HslLuas.Text = Hasil
    End Sub

    Private Sub Kel1BoxValidasi(sender As Object, e As KeyPressEventArgs) Handles Kel1.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
            e.KeyChar = vbBack) Then
            e.Handled() = True
        End If

        If (e.KeyChar = Chr(13)) Then
            Kel2.Focus()
        End If
    End Sub

    Private Sub Kel2BoxValidasi(sender As Object, e As KeyPressEventArgs) Handles Kel2.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
            e.KeyChar = vbBack) Then
            e.Handled() = True
        End If

        If (e.KeyChar = Chr(13)) Then
            Kel3.Focus()
        End If
    End Sub

    Private Sub Kel3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Kel3.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
            e.KeyChar = vbBack) Then
            e.Handled() = True
        End If

        If (e.KeyChar = Chr(13)) Then
            ButtonKel.Focus()
        End If
    End Sub

    Private Sub alasSeg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles alasSeg.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
            e.KeyChar = vbBack) Then
            e.Handled() = True
        End If

        If (e.KeyChar = Chr(13)) Then
            tinggiSeg.Focus()
        End If
    End Sub

    Private Sub tinggiSeg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tinggiSeg.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
            e.KeyChar = vbBack) Then
            e.Handled() = True
        End If

        If (e.KeyChar = Chr(13)) Then
            ButtonLuas.Focus()
        End If
    End Sub
End Class