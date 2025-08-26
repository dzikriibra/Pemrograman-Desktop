Public Class FrmJajarGenjang
    Private Sub ButtonLuas_Click(sender As Object, e As EventArgs) Handles ButtonLuas.Click
        Dim a, t, Hasil As Double
        a = Val(intAlasLuas.Text)
        t = Val(intTinggiLuas.Text)
        Hasil = a * t
        HslLuasJG.Text = Hasil
    End Sub

    Private Sub ButtonKeliling_Click(sender As Object, e As EventArgs) Handles ButtonKeliling.Click
        Dim a, b, Hasil As Double
        a = Val(intAlasKel.Text)
        b = Val(intPanjangSisi.Text)
        Hasil = 2 * (a + b)
        HslKelJG.Text = Hasil
    End Sub
End Class