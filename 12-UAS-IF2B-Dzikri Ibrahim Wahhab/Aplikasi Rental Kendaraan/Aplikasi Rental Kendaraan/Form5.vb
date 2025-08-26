Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp

Public Class Form5
    Sub TampilDataGrid()
        DA = New MySqlDataAdapter("select * from tb_mobil", CONN)
        DS = New DataSet
        DA.Fill(DS, "tb_mobil")
        DGVDataMobil.DataSource = (DS.Tables("tb_mobil"))
    End Sub

    Sub AturHakAkses()
        If Module2.LoggedInRole = "customer" Then
            btnTambah.Enabled = False
            btnUbah.Enabled = False
            btnHapus.Enabled = False
            DGVDataMobil.ReadOnly = True
        End If
    End Sub

    Sub Aktif()
        txtNamaMobil.Enabled = True
        txtMerk.Enabled = True
        txtTahun.Enabled = True
        txtPlat.Enabled = True
        txtHarga.Enabled = True
        cbStatus.Enabled = True
        btnSimpan.Enabled = True
        btnTambah.Text = "BATAL"
        txtNamaMobil.Focus()
    End Sub

    Sub Bersih()
        txtNamaMobil.Text = ""
        txtMerk.Text = ""
        txtTahun.Text = ""
        txtPlat.Text = ""
        txtHarga.Text = ""
        cbStatus.SelectedIndex = -1
        txtCari.Text = ""
    End Sub

    Sub NonAktif()
        txtNamaMobil.Enabled = False
        txtMerk.Enabled = False
        txtTahun.Enabled = False
        txtPlat.Enabled = False
        txtHarga.Enabled = False
        cbStatus.Enabled = False
        btnHapus.Enabled = False
        btnSimpan.Enabled = False
        btnUbah.Enabled = False
        btnTambah.Text = "TAMBAH"
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call TampilDataGrid()
        Call NonAktif()
        DGVDataMobil.ReadOnly = True

        cbStatus.Items.Clear()
        cbStatus.Items.Add("Tersedia")
        cbStatus.Items.Add("Disewa")

        Call AturHakAkses()
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

        If txtNamaMobil.Text = "" Or txtMerk.Text = "" Or txtTahun.Text = "" Or txtPlat.Text = "" Or txtHarga.Text = "" Then
            MessageBox.Show("Data Harus Diisi!",
        "Informasi", MessageBoxButtons.OK,
        MessageBoxIcon.Exclamation)
        Else
            Dim SQLSimpan As String = "insert into tb_mobil(nama_mobil,merk,tahun,plat_nomor,harga_sewa) values('" & txtNamaMobil.Text & "','" & txtMerk.Text & "','" & txtTahun.Text & "','" & txtPlat.Text & "','" & txtHarga.Text & "')"
            CMD = New MySqlCommand(SQLSimpan, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Sudah Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call TampilDataGrid()
            Call NonAktif()
            Call Bersih()
        End If
    End Sub

    Private Sub DGVDataMobil_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDataMobil.CellContentClick

        If Module2.LoggedInRole = "customer" Then Exit Sub

        Dim baris As Integer
        With DGVDataMobil
            baris = .CurrentRow.Index
            txtNamaMobil.Text = .Item(1, baris).Value
            txtMerk.Text = .Item(2, baris).Value
            txtPlat.Text = .Item(3, baris).Value
            txtTahun.Text = .Item(4, baris).Value
            txtHarga.Text = Val(.Item(5, baris).Value)
            cbStatus.Text = .Item(6, baris).Value
        End With
        btnUbah.Enabled = True
        btnHapus.Enabled = True
        Call Aktif()
        btnSimpan.Enabled = False
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim DialogDelete = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo)
        If txtNamaMobil.Text = "" Then
            MessageBox.Show("Pilih Kode Barang dengan Benar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            If DialogDelete = DialogResult.Yes Then
                CMD = New MySqlCommand("Delete from tb_mobil where nama_mobil = '" & txtNamaMobil.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                Call Bersih()
                Call TampilDataGrid()
                Call NonAktif()
            Else
                Call NonAktif()
                Call Bersih()
                Call TampilDataGrid()
            End If
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If txtNamaMobil.Text = "" Or txtMerk.Text = "" Or txtTahun.Text = "" Or txtPlat.Text = "" Or txtHarga.Text = "" Then
            MessageBox.Show("Data Harus Diisi!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim SQLUpdate As String = "update tb_mobil set nama_mobil = '" & txtNamaMobil.Text & "', merk = '" & txtMerk.Text & "', tahun = '" & txtTahun.Text & "', plat_nomor = '" & txtPlat.Text & "', harga_sewa = '" & txtHarga.Text & "' where nama_mobil = '" & txtNamaMobil.Text & "'"
            CMD = New MySqlCommand(SQLUpdate, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Telah Diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call TampilDataGrid()
            Call NonAktif()
            Call Bersih()
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call TampilDataGrid()
        txtCari.Text = ""
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Dim tables As DataTableCollection = DS.Tables
        Dim source1 As New BindingSource
        DA = New MySqlDataAdapter("select * from tb_mobil where nama_mobil like '%" & txtCari.Text & "%'", CONN)
        DS = New DataSet
        DA.Fill(DS, "tb_mobil")

        DGVDataMobil.DataSource = DS.Tables("tb_mobil")
    End Sub

    Private Sub txtTahun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTahun.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
           e.KeyChar = vbBack) Then
            e.Handled() = True
        End If
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
           e.KeyChar = vbBack) Then
            e.Handled() = True
        End If
    End Sub

End Class