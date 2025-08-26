Public Class FrmDataPegawai
    Dim enable As Boolean = False
    Dim GajiPokokManager, GajiPokokStaff, GajiPokokOB As Double

    Private Sub FrmDataPegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        groupKalkulasiGaji.Enabled = False

        TextNIP.Enabled = False
        TextNama.Enabled = False
        TextJabatan.Enabled = False
        TextTglLahir.Enabled = False
        TextTmptLahir.Enabled = False

        btnHitung.Enabled = False
        btnHapus.Enabled = False

        TextJabatan.DropDownStyle = ComboBoxStyle.DropDownList
        TextBulan.DropDownStyle = ComboBoxStyle.DropDownList

        TextJabatan.Items.Add("Manager")
        TextJabatan.Items.Add("Staff")
        TextJabatan.Items.Add("OB")

        TextBulan.Items.Add("Januari")
        TextBulan.Items.Add("Februari")
        TextBulan.Items.Add("Maret")
        TextBulan.Items.Add("April")
        TextBulan.Items.Add("Mei")
        TextBulan.Items.Add("Juni")
        TextBulan.Items.Add("Juli")
        TextBulan.Items.Add("Agustus")
        TextBulan.Items.Add("September")
        TextBulan.Items.Add("Oktober")
        TextBulan.Items.Add("November")
        TextBulan.Items.Add("Desember")
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If enable = False Then
            enable = True

            btnTambah.Text = "BATAL"
            btnTambah.BackColor = Color.Red
            btnHapus.Enabled = True
            btnHitung.Enabled = True

            TextNIP.Enabled = True
            TextNama.Enabled = True
            TextJabatan.Enabled = True
            TextTglLahir.Enabled = True
            TextTmptLahir.Enabled = True

            TextNIP.Focus()
        ElseIf enable = True Then
            enable = False

            groupKalkulasiGaji.Enabled = False

            btnTambah.Text = "TAMBAH DATA"
            btnTambah.BackColor = Color.SkyBlue
            btnHitung.Enabled = False
            btnHapus.Enabled = False

            TextNIP.Enabled = False
            TextNama.Enabled = False
            TextJabatan.Enabled = False
            TextTglLahir.Enabled = False
            TextTmptLahir.Enabled = False

            TextNIP.Text = ""
            TextNama.Text = ""
            TextJabatan.Text = ""
            TextTmptLahir.Text = ""

            TextGajiPokok.Text = 0
            TextBulan.Text = 0
            TextHariKerja.Text = 0
            TextSakit.Text = 0
            TextTnpaKet.Text = 0
            TextIzin.Text = 0
            TextTunjangan.Text = 0
            TextPotongan.Text = 0
            TextPajak.Text = 0
            TextGajiBersih.Text = 0

        End If
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim Tunjangan, Ketidakhadiran, GajiBersih As Double
        Dim HariKerja As Integer

        GajiPokokManager = 30000000
        GajiPokokStaff = 20000000
        GajiPokokOB = 10000000

        If TextNIP.Text = "" Or TextNama.Text = "" Or TextTmptLahir.Text = "" Or TextJabatan.Text = "" Then
            MsgBox(“SILAHKAN DIISI DENGAN BENAR!!”)
            Exit Sub
        End If

        Select Case TextJabatan.SelectedItem
            Case "Manager"
                TextGajiPokok.Text = GajiPokokManager
                TextPajak.Text = 0.0975 * GajiPokokManager
            Case "Staff"
                TextGajiPokok.Text = GajiPokokStaff
                TextPajak.Text = 0.075 * GajiPokokStaff
            Case "OB"
                TextGajiPokok.Text = GajiPokokOB
                TextPajak.Text = 0.05 * GajiPokokOB
        End Select


        Select Case TextBulan.SelectedItem
            Case "Januari", "Maret", "Mei", "Juli", "Agustus", "Oktober", "Desember"
                HariKerja = 27
            Case "April", "Juni", "September", "November"
                HariKerja = 26
            Case "Februari"
                HariKerja = 24
        End Select

        TextHariKerja.Text = HariKerja & " hari"

        groupKalkulasiGaji.Enabled = True

        Ketidakhadiran = (Val(TextSakit.Text) * 20000) + (Val(TextIzin.Text) * 30000) + (Val(TextTnpaKet.Text) * 50000)
        Tunjangan = (HariKerja * 50000) - Ketidakhadiran
        GajiBersih = Val(TextGajiPokok.Text) + Tunjangan - Val(TextPotongan.Text) - Val(TextPajak.Text)

        TextTunjangan.Text = Tunjangan
        TextGajiBersih.Text = GajiBersih
    End Sub

    Private Sub TextJabatan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TextJabatan.SelectedIndexChanged
        Select Case TextJabatan.Text
            Case "Manager"
                TextGajiPokok.Text = "Rp.30.000.000"
                GajiPokokManager = 30000000
            Case "Staff"
                TextGajiPokok.Text = "Rp.20.000.000"
                GajiPokokStaff = 20000000
            Case "OB"
                TextGajiPokok.Text = "Rp.10.000.000"
                GajiPokokOB = 10000000
        End Select
    End Sub

    Private Sub TextBulan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TextBulan.SelectedIndexChanged
        Select Case TextBulan.Text
            Case "Januari", "Maret", "Mei", "Juli", "Agustus", "Oktober", "Desember"
                TextHariKerja.Text = "27 hari"

            Case "April", "Juni", "September", "November"
                TextHariKerja.Text = "26 hari"

            Case "Februari"
                TextHariKerja.Text = "24 hari"

        End Select
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        groupKalkulasiGaji.Enabled = False

        TextNIP.Text = ""
        TextNama.Text = ""
        TextTmptLahir.Text = ""
        TextJabatan.Text = ""
        TextTglLahir.Text = ""

        TextGajiPokok.Text = 0
        TextBulan.Text = 0
        TextHariKerja.Text = 0
        TextSakit.Text = 0
        TextTnpaKet.Text = 0
        TextIzin.Text = 0
        TextTunjangan.Text = 0
        TextPotongan.Text = 0
        TextPajak.Text = 0
        TextGajiBersih.Text = 0

        TextNIP.Focus()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        End
    End Sub

    Private Sub TextNIP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextNIP.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
           e.KeyChar = vbBack) Then
            e.Handled() = True
        End If

        If (e.KeyChar = Chr(13)) Then
            TextNama.Focus()
        End If
    End Sub

    Private Sub TextNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextNama.KeyPress
        If ((e.KeyChar >= "0" And e.KeyChar <= "9")) Then
            e.Handled() = True
        End If

        If (e.KeyChar = Chr(13)) Then
            TextTmptLahir.Focus()
        End If
    End Sub

    Private Sub TextTmptLahir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextTmptLahir.KeyPress
        If ((e.KeyChar >= "0" And e.KeyChar <= "9")) Then
            e.Handled() = True
        End If

        If (e.KeyChar = Chr(13)) Then
            btnHitung.Focus()
        End If
    End Sub

    Private Sub TextSakit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextSakit.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
           e.KeyChar = vbBack) Then
            e.Handled() = True
        End If

        If (e.KeyChar = Chr(13)) Then
            TextTnpaKet.Focus()
        End If
    End Sub

    Private Sub TextTnpaKet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextTnpaKet.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
           e.KeyChar = vbBack) Then
            e.Handled() = True
        End If

        If (e.KeyChar = Chr(13)) Then
            TextIzin.Focus()
        End If
    End Sub

    Private Sub TextIzin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextIzin.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
           e.KeyChar = vbBack) Then
            e.Handled() = True
        End If

        If (e.KeyChar = Chr(13)) Then
            TextPotongan.Focus()
        End If
    End Sub

    Private Sub TextPotongan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextPotongan.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
           e.KeyChar = vbBack) Then
            e.Handled() = True
        End If

        If (e.KeyChar = Chr(13)) Then
            btnHitung.Focus()
        End If
    End Sub

End Class