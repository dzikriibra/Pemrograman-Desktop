Public Class FrmVolTabung
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r, t, Hasil As Double
        r = Val(intJariJari.Text)
        t = Val(intTinggi.Text)
        Hasil = 3.14 * r * r * t
        HslVolTbg.Text = Hasil
    End Sub

    Private Sub BoxValidasi1(sender As Object, e As KeyPressEventArgs) Handles intJariJari.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
            e.KeyChar = vbBack) Then
            e.Handled() = True
        End If

        If (e.KeyChar = Chr(13)) Then
            intTinggi.Focus()
        End If
    End Sub

    Private Sub BoxValidasi2(sender As Object, e As KeyPressEventArgs) Handles intTinggi.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
            e.KeyChar = vbBack) Then
            e.Handled() = True
        End If

        If (e.KeyChar = Chr(13)) Then
            Button1.Focus()
        End If
    End Sub

End Class