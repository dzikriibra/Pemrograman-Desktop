Imports MySql.Data.MySqlClient

Public Class Form7
    Dim selectedMobilId As Integer
    Dim selectedPelangganId As Integer
    Public role As String ' "Admin" or "User"

    Sub TampilDataGrid()
        DA = New MySqlDataAdapter("select * from tb_transaksi", CONN)
        DS = New DataSet
        DA.Fill(DS, "tb_transaksi")
        DGVSewaKendaraan.DataSource = (DS.Tables("tb_transaksi"))
    End Sub

    Sub AturHakAkses()
        If role = "admin" Then
            DGVSewaKendaraan.Enabled = True
            btnUbah.Enabled = True
            btnHapus.Enabled = True
        ElseIf role = "user" Then
            DGVSewaKendaraan.Enabled = False
            btnUbah.Enabled = False
            btnHapus.Enabled = False
        End If
    End Sub

    Sub Aktif()
        cbPelanggan.Enabled = True
        cbMobil.Enabled = True
        txtLamaSewa.Enabled = True
        txtPlat.Enabled = True
        txtHarga.Enabled = True
        txtTotal.Enabled = True
        dtpSewa.Enabled = True
        dtpKembali.Enabled = True
        btnSimpan.Enabled = True
        btnTambah.Text = "BATAL"
        cbPelanggan.Focus()
    End Sub

    Sub Bersih()
        txtLamaSewa.Text = ""
        txtPlat.Text = ""
        txtHarga.Text = ""
        txtTotal.Text = ""
        cbPelanggan.SelectedIndex = -1
        cbMobil.SelectedIndex = -1
    End Sub

    Sub NonAktif()
        cbPelanggan.Enabled = False
        cbMobil.Enabled = False
        txtLamaSewa.Enabled = False
        txtPlat.Enabled = False
        txtHarga.Enabled = False
        txtTotal.Enabled = False
        btnHapus.Enabled = False
        btnSimpan.Enabled = False
        btnUbah.Enabled = False
        btnTambah.Text = "TAMBAH"
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call TampilDataGrid()
        IsiComboPelanggan()
        IsiComboMobil()
        dtpSewa.Value = DateTime.Now
        Call NonAktif()
        'DGVSewaKendaraan.ReadOnly = True

        Call AturHakAkses()
    End Sub

    Sub IsiComboPelanggan()
        cbPelanggan.Items.Clear()
        CMD = New MySqlCommand("SELECT id_pelanggan, nama_pelanggan FROM tb_pelanggan", CONN)
        RD = CMD.ExecuteReader()
        While RD.Read()
            cbPelanggan.Items.Add(RD("nama_pelanggan").ToString())
        End While
        RD.Close()
    End Sub

    Sub IsiComboMobil()
        cbMobil.Items.Clear()
        CMD = New MySqlCommand("SELECT nama_mobil FROM tb_mobil WHERE status = 'Tersedia'", CONN)
        RD = CMD.ExecuteReader()
        While RD.Read()
            cbMobil.Items.Add(RD("nama_mobil").ToString())
        End While
        RD.Close()
    End Sub

    Private Sub cbPelanggan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPelanggan.SelectedIndexChanged
        CMD = New MySqlCommand("SELECT id_pelanggan FROM tb_pelanggan WHERE nama_pelanggan = @nama", CONN)
        CMD.Parameters.AddWithValue("@nama", cbPelanggan.Text)
        RD = CMD.ExecuteReader()
        If RD.Read() Then
            selectedPelangganId = Convert.ToInt32(RD("id_pelanggan"))
        End If
        RD.Close()
    End Sub

    Private Sub cbMobil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMobil.SelectedIndexChanged
        CMD = New MySqlCommand("SELECT * FROM tb_mobil WHERE nama_mobil = @nama", CONN)
        CMD.Parameters.AddWithValue("@nama", cbMobil.Text)
        RD = CMD.ExecuteReader()
        If RD.Read() Then
            selectedMobilId = Convert.ToInt32(RD("id_mobil"))
            txtPlat.Text = RD("plat_nomor").ToString()
            txtHarga.Text = RD("harga_sewa").ToString()

        End If
        RD.Close()
    End Sub

    Private Sub txtLama_TextChanged(sender As Object, e As EventArgs) Handles txtLamaSewa.TextChanged
        If IsNumeric(txtLamaSewa.Text) AndAlso IsNumeric(txtHarga.Text) Then
            Dim harga As Decimal = Decimal.Parse(txtHarga.Text)
            Dim lama As Integer = Integer.Parse(txtLamaSewa.Text)
            txtTotal.Text = (harga * lama).ToString("N0")

            Dim tanggalSewa As Date = dtpSewa.Value
            dtpKembali.Text = tanggalSewa.AddDays(lama).ToShortDateString()
        Else
            txtTotal.Text = ""
            dtpKembali.Text = ""
        End If
    End Sub


    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If btnTambah.Text = "TAMBAH" Then
            Call Bersih()
            Call Aktif()
            Call TampilDataGrid()
        Else
            Call NonAktif()
            Call Bersih()
            Call TampilDataGrid()
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If cbPelanggan.Text = "" Or cbMobil.Text = "" Or txtLamaSewa.Text = "" Then
            MessageBox.Show("Data belum lengkap.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim insertSQL As String = "INSERT INTO tb_transaksi (id_pelanggan, id_mobil, tgl_sewa, tgl_kembali, lama_sewa, harga_per_hari, total_harga, denda, total_bayar, status) " &
                                  "VALUES (@id_pelanggan, @id_mobil, @tgl_sewa, @tgl_kembali, @lama, @harga, @totalharga, 0, @totalbayar, 'Disewa')"

        CMD = New MySqlCommand(insertSQL, CONN)
        CMD.Parameters.AddWithValue("@id_pelanggan", selectedPelangganId)
        CMD.Parameters.AddWithValue("@id_mobil", selectedMobilId)
        CMD.Parameters.AddWithValue("@tgl_sewa", dtpSewa.Value.Date)
        CMD.Parameters.AddWithValue("@tgl_kembali", Date.Parse(dtpKembali.Text))
        CMD.Parameters.AddWithValue("@lama", Integer.Parse(txtLamaSewa.Text))
        CMD.Parameters.AddWithValue("@denda", 0)
        CMD.Parameters.AddWithValue("@totalbayar", Decimal.Parse(txtTotal.Text.Replace(".", "")))
        CMD.Parameters.AddWithValue("@harga", Decimal.Parse(txtHarga.Text.Replace(".", "")))
        CMD.Parameters.AddWithValue("@totalharga", Decimal.Parse(txtTotal.Text.Replace(".", "")))
        CMD.ExecuteNonQuery()

        Dim updateSQL As String = "UPDATE tb_mobil SET status='Disewa' WHERE id_mobil = @idm"
        CMD = New MySqlCommand(updateSQL, CONN)
        CMD.Parameters.AddWithValue("@idm", selectedMobilId)
        CMD.ExecuteNonQuery()

        MessageBox.Show("Transaksi berhasil disimpan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If cbPelanggan.Text = "" Or cbMobil.Text = "" Or txtLamaSewa.Text = "" Then
            MessageBox.Show("Data harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim idTr As Integer = Convert.ToInt32(DGVSewaKendaraan.CurrentRow.Cells("id_transaksi").Value)

        Dim sql As String = "
        UPDATE tb_transaksi
        SET id_pelanggan = @pel,
            id_mobil     = @mob,
            lama_sewa    = @lama,
            harga_per_hari = @harga,
            total_harga  = @total
        WHERE id_transaksi = @idt"

        CMD = New MySqlCommand(sql, CONN)
        CMD.Parameters.AddWithValue("@pel", selectedPelangganId)
        CMD.Parameters.AddWithValue("@mob", selectedMobilId)
        CMD.Parameters.AddWithValue("@lama", Integer.Parse(txtLamaSewa.Text))
        CMD.Parameters.AddWithValue("@harga", Decimal.Parse(txtHarga.Text.Replace(".", "")))
        CMD.Parameters.AddWithValue("@total", Decimal.Parse(txtTotal.Text.Replace(".", "")))
        CMD.Parameters.AddWithValue("@idt", idTr)
        CMD.ExecuteNonQuery()

        MessageBox.Show("Data transaksi di-update.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        TampilDataGrid()
        NonAktif()
        Bersih()

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If DGVSewaKendaraan.CurrentRow Is Nothing Then Exit Sub

        Dim konfirm = MessageBox.Show("Hapus transaksi ini?", "Konfirmasi", MessageBoxButtons.YesNo)
        If konfirm = DialogResult.No Then Exit Sub

        Dim idTr As Integer = DGVSewaKendaraan.CurrentRow.Cells("id_transaksi").Value
        Dim idMob As Integer = DGVSewaKendaraan.CurrentRow.Cells("id_mobil").Value

        '1) delete transaksi
        CMD = New MySqlCommand("DELETE FROM tb_transaksi WHERE id_transaksi=@idt", CONN)
        CMD.Parameters.AddWithValue("@idt", idTr)
        CMD.ExecuteNonQuery()

        '2) mobil jadi tersedia
        CMD = New MySqlCommand("UPDATE tb_mobil SET status='Tersedia' WHERE id_mobil=@idm", CONN)
        CMD.Parameters.AddWithValue("@idm", idMob)
        CMD.ExecuteNonQuery()

        MessageBox.Show("Transaksi dihapus.", "Info")
        TampilDataGrid()
        NonAktif()
        Bersih()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
    End Sub

End Class