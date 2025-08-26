Public Class FrmBelanja

    Private Sub BtnUlang_Click(sender As Object, e As EventArgs) Handles BtnUlang.Click
        'Membersihkan isi Textbox
        BoxNama.Text = ""
        BoxHarga.Text = ""
        BoxJumlah.Text = ""
        BoxTotal.Text = ""
        BoxDiskon.Text = ""
        BoxBayar.Text = ""
        BoxBonus.Text = ""
        BoxNama.Focus()
    End Sub
    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        'Deklarasi Variable
        Dim Harga, Jumlah As Integer
        Dim Total, Diskon, Bayar As Double
        Dim Bonus As String
        'Deklarasi Input Harga dan Jumlah
        Harga = BoxHarga.Text
        Jumlah = BoxJumlah.Text
        'Perhitungan Total Harga
        Total = Harga * Jumlah
        'Penentuan Diskon dan Bonus
        If Total >= 500000 Then
            Diskon = 0.2 * Total
            Bonus = "Tas Pinggang"
        ElseIf Total >= 200000 Then
            Diskon = 0.15 * Total
            Bonus = "Payung"
        ElseIf Total >= 100000 Then
            Diskon = 0.1 * Total
            Bonus = "Kaos"
        ElseIf Total >= 50000 Then
            Diskon = 0.05 * Total
            Bonus = "Cangkir"
        Else
            Diskon = 0
            Bonus = "Tidak ada"
        End If
        'Perhitungan Total Bayar
        Bayar = Total - Diskon
        'Deklarasi Keluaran Total Harga, Diskon, Total Bayar, dan Bonus
        BoxTotal.Text = Total
        BoxDiskon.Text = Diskon
        BoxBayar.Text = Bayar
        BoxBonus.Text = Bonus
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        End
    End Sub

    Private Sub BoxNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BoxNama.KeyPress
        If ((e.KeyChar >= "0" And e.KeyChar <= "9")) Then
            e.Handled() = True
        End If

        If (e.KeyChar = Chr(13)) Then
            BoxHarga.Focus()
        End If
    End Sub

    Private Sub BoxHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BoxHarga.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
           e.KeyChar = vbBack) Then
            e.Handled() = True
        End If

        If (e.KeyChar = Chr(13)) Then
            BoxJumlah.Focus()
        End If
    End Sub

    Private Sub BoxJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BoxJumlah.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
           e.KeyChar = vbBack) Then
            e.Handled() = True
        End If

        If (e.KeyChar = Chr(13)) Then
            BtnHitung.Focus()
        End If
    End Sub

End Class
