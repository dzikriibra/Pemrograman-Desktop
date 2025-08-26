Public Class frmHitungNilai
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, hasil As Double
        a = Val(TxtAngka1.Text)
        b = Val(TxtAngka2.Text)
        c = Val(TxtAngka3.Text)
        hasil = (a + b + c) / 3
        nilaiAkhir.Text = hasil
    End Sub

    Private Sub ValidationsBox1(sender As Object, e As KeyPressEventArgs) Handles TxtAngka1.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
            e.KeyChar = vbBack) Then
            e.Handled() = True
        End If

        If (e.KeyChar = Chr(13)) Then
            TxtAngka2.Focus()
        End If
    End Sub

    Private Sub ValidationsBox2(sender As Object, e As KeyPressEventArgs) Handles TxtAngka2.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
            e.KeyChar = vbBack) Then
            e.Handled() = True
        End If

        If (e.KeyChar = Chr(13)) Then
            TxtAngka3.Focus()
        End If
    End Sub
    Private Sub ValidationsBox3(sender As Object, e As KeyPressEventArgs) Handles TxtAngka3.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
            e.KeyChar = vbBack) Then
            e.Handled() = True
        End If

        If (e.KeyChar = Chr(13)) Then
            Button1.Focus()
        End If
    End Sub

End Class