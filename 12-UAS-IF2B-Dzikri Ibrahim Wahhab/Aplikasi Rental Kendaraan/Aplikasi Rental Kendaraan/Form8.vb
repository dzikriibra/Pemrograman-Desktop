Imports MySql.Data.MySqlClient

Public Class Form8
    Dim idTransaksi As Integer = 0
    Dim idMobil As Integer = 0
    Dim hargaHarian As Decimal = 0
    Dim totalSewa As Decimal = 0
    Const FAKTOR_DENDA As Decimal = 1.5D

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call koneksi()
        LoadGrid()
        ClearDetail()
    End Sub

    '================  LOAD GRID  ================
    Sub LoadGrid(Optional filterNama As String = "")
        Dim q As String = "
          SELECT  t.id_transaksi,
                  p.nama_pelanggan,
                  m.nama_mobil,
                  t.tgl_sewa,
                  t.tgl_kembali AS tgl_jatuh_tempo,
                  t.harga_per_hari,
                  t.total_harga,
                  t.id_mobil
          FROM    tb_transaksi t
          JOIN    tb_pelanggan p ON t.id_pelanggan = p.id_pelanggan
          JOIN    tb_mobil m     ON t.id_mobil     = m.id_mobil
          WHERE   t.status = 'Disewa' "

        If filterNama.Trim <> "" Then
            q &= " AND p.nama_pelanggan LIKE @filter "
        End If

        DA = New MySqlDataAdapter(q, CONN)
        If filterNama.Trim <> "" Then
            DA.SelectCommand.Parameters.AddWithValue("@filter", "%" & filterNama & "%")
        End If
        DS = New DataSet
        DA.Fill(DS, "trans")
        DGVPengembalian.DataSource = DS.Tables("trans")
        DGVPengembalian.Columns("id_mobil").Visible = False
    End Sub

    '================  CLEAR DETAIL  ================
    Sub ClearDetail()
        idTransaksi = 0 : idMobil = 0 : hargaHarian = 0 : totalSewa = 0

        txtID.Clear()
        txtNamaPelanggan.Clear()
        txtNamaMobil.Clear()
        dtpSewa.Value = Date.Today
        dtpJatuhTempo.Value = Date.Today

        txtDenda.Clear()
        txtTotalBayar.Clear()
    End Sub

    '================  GRID CLICK  ================

    Private Sub DGVPengembalian_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPengembalian.CellClick
        If e.RowIndex < 0 Then Exit Sub   ' header

        With DGVPengembalian.Rows(e.RowIndex)
            idTransaksi = .Cells("id_transaksi").Value
            idMobil = .Cells("id_mobil").Value
            txtID.Text = idTransaksi.ToString()

            txtNamaPelanggan.Text = .Cells("nama_pelanggan").Value.ToString()
            txtNamaMobil.Text = .Cells("nama_mobil").Value.ToString()

            Dim tglSewa As Date = CDate(.Cells("tgl_sewa").Value)
            Dim tglTempo As Date = CDate(.Cells("tgl_jatuh_tempo").Value)

            dtpSewa.Value = tglSewa
            dtpJatuhTempo.Value = tglTempo

            hargaHarian = CDec(.Cells("harga_per_hari").Value)
            totalSewa = CDec(.Cells("total_harga").Value)

            HitungDenda()   ' tampilkan denda + total
        End With
    End Sub

    '================  HITUNG DENDA  ================
    Sub HitungDenda()
        ' Validasi: Tidak perlu cek string kosong lagi karena sudah pakai dtp
        Dim jatuhTempo As Date = dtpJatuhTempo.Value.Date
        Dim tanggalSewa As Date = dtpSewa.Value.Date

        Dim hariTelat As Integer = DateDiff(DateInterval.Day, jatuhTempo, tanggalSewa)
        If hariTelat < 0 Then hariTelat = 0

        Dim denda As Decimal = hariTelat * hargaHarian * FAKTOR_DENDA
        txtDenda.Text = denda.ToString("N0")

        Dim totalAkhir As Decimal = totalSewa + denda
        txtTotalBayar.Text = totalAkhir.ToString("N0")
    End Sub


    Private Sub dtpKembali_ValueChanged(sender As Object, e As EventArgs)
        HitungDenda()
    End Sub

    '================  PROSES PENGEMBALIAN  ================
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If idTransaksi = 0 Then
            MessageBox.Show("Pilih transaksi terlebih dahulu!", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim ok = MessageBox.Show("Proses pengembalian kendaraan ini?",
                                 "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ok = DialogResult.No Then Exit Sub

        Try
            Call koneksi()
            Dim sqlUpdateTrans As String = "
              UPDATE tb_transaksi
                 SET status          = 'Kembali',
                     tgl_harus_kembali = @tglHarusKembali,
                     denda           = @denda,
                     total_bayar     = @total
               WHERE id_transaksi   = @idt"

            CMD = New MySqlCommand(sqlUpdateTrans, CONN)
            CMD.Parameters.AddWithValue("@tglHarusKembali", dtpJatuhTempo.Value.Date)
            CMD.Parameters.AddWithValue("@denda", Decimal.Parse(txtDenda.Text.Replace(".", "")))
            CMD.Parameters.AddWithValue("@total", Decimal.Parse(txtTotalBayar.Text.Replace(".", "")))
            CMD.Parameters.AddWithValue("@idt", idTransaksi)
            CMD.ExecuteNonQuery()

            CMD = New MySqlCommand("UPDATE tb_mobil SET status='Tersedia' WHERE id_mobil=@idm", CONN)
            CMD.Parameters.AddWithValue("@idm", idMobil)
            CMD.ExecuteNonQuery()

            MessageBox.Show("Pengembalian diproses.", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

            LoadGrid()
            ClearDetail()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Gagal",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '================  REFRESH  ================
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtCari.Clear()
        LoadGrid()
        ClearDetail()
    End Sub

    '================  CARI  ================
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        LoadGrid(txtCari.Text)
    End Sub

    '================  KELUAR  ================
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

End Class