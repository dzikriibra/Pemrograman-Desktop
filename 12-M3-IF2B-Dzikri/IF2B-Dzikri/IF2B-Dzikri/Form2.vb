Public Class frmKalkulator

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim Angka1, Angka2, Hasil As Double
        Angka1 = Val(txtAngka1.Text)
        Angka2 = Val(txtAngka2.Text)
        Hasil = Angka1 + Angka2
        txtHasil.Text = Hasil
    End Sub

    Private Sub btnKurang_Click(sender As Object, e As EventArgs) Handles btnKurang.Click
        Dim Angka1, Angka2, Hasil As Double
        Angka1 = Val(txtAngka1.Text)
        Angka2 = Val(txtAngka2.Text)
        Hasil = Angka1 - Angka2
        txtHasil.Text = Hasil
    End Sub

    Private Sub btnBagi_Click(sender As Object, e As EventArgs) Handles btnBagi.Click
        Dim Angka1, Angka2, Hasil As Double
        Angka1 = Val(txtAngka1.Text)
        Angka2 = Val(txtAngka2.Text)
        Hasil = Angka1 / Angka2
        txtHasil.Text = Hasil
    End Sub

    Private Sub btnKali_Click(sender As Object, e As EventArgs) Handles btnKali.Click
        Dim Angka1, Angka2, Hasil As Double
        Angka1 = Val(txtAngka1.Text)
        Angka2 = Val(txtAngka2.Text)
        Hasil = Angka1 * Angka2
        txtHasil.Text = Hasil
    End Sub

    Private Sub ValidationNumberBox1(sender As Object, e As KeyPressEventArgs) Handles txtAngka1.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
            e.KeyChar = vbBack) Then
            e.Handled() = True
        End If

        If (e.KeyChar = Chr(13)) Then
            txtAngka2.Focus()
        End If
    End Sub

    Private Sub ValidationNumberBox2(sender As Object, e As KeyPressEventArgs) Handles txtAngka2.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
            e.KeyChar = vbBack) Then
            e.Handled() = True
        End If

        If (e.KeyChar = Chr(13)) Then
            btnTambah.Focus()
            btnKurang.Focus()
            btnBagi.Focus()
            btnKali.Focus()
        End If
    End Sub

End Class