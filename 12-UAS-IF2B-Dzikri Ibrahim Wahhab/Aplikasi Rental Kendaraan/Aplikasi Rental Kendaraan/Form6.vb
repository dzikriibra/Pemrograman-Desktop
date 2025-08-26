Imports MySql.Data.MySqlClient

Public Class Form6
    Public role As String

    Sub TampilDataGrid()
        DA = New MySqlDataAdapter("select * from tb_pelanggan", CONN)
        DS = New DataSet
        DA.Fill(DS, "tb_pelanggan")
        DGVDataPelanggan.DataSource = (DS.Tables("tb_pelanggan"))
    End Sub

    Sub AturHakAkses()
        If role = "admin" Then
            DGVDataPelanggan.Enabled = True
            btnTambah.Enabled = True
            btnUbah.Enabled = True
            btnHapus.Enabled = True
        ElseIf role = "user" Then
            DGVDataPelanggan.Enabled = False
            btnTambah.Enabled = False
            btnUbah.Enabled = False
            btnHapus.Enabled = False
        End If
    End Sub


    Sub Aktif()
        txtKTP.Enabled = True
        txtNama.Enabled = True
        txtNoHP.Enabled = True
        txtAlamat.Enabled = True
        cbJenis.Enabled = True
        btnSimpan.Enabled = True
        btnTambah.Text = "BATAL"
        txtKTP.Focus()
    End Sub

    Sub Bersih()
        txtKTP.Text = ""
        txtNama.Text = ""
        txtNoHP.Text = ""
        txtAlamat.Text = ""
        cbJenis.SelectedIndex = -1
        txtCari.Text = ""
    End Sub

    Sub NonAktif()
        txtKTP.Enabled = False
        txtNama.Enabled = False
        txtNoHP.Enabled = False
        txtAlamat.Enabled = False
        cbJenis.Enabled = False
        btnHapus.Enabled = False
        btnSimpan.Enabled = False
        btnUbah.Enabled = False
        btnTambah.Text = "TAMBAH"
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call TampilDataGrid()
        Call NonAktif()
        DGVDataPelanggan.ReadOnly = True

        cbJenis.Items.Clear()
        cbJenis.Items.Add("Laki-laki")
        cbJenis.Items.Add("Perempuan")

        Call AturHakAkses()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        If Module2.LoggedInRole = "customer" Then Exit Sub

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
        If txtKTP.Text = "" Or txtNoHP.Text = "" Or txtNama.Text = "" Or txtAlamat.Text = "" Or cbJenis.Text = "" Then
            MessageBox.Show("Data Harus Diisi!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim SQLSimpan As String = "INSERT INTO tb_pelanggan(no_ktp, no_hp, nama_pelanggan, alamat, jenis_kelamin) " &
                              "VALUES(@ktp, @hp, @nama, @alamat, @jk)"
        CMD = New MySqlCommand(SQLSimpan, CONN)
        CMD.Parameters.AddWithValue("@ktp", txtKTP.Text)
        CMD.Parameters.AddWithValue("@hp", txtNoHP.Text)
        CMD.Parameters.AddWithValue("@nama", txtNama.Text)
        CMD.Parameters.AddWithValue("@alamat", txtAlamat.Text)
        CMD.Parameters.AddWithValue("@jk", cbJenis.Text)
        CMD.ExecuteNonQuery()

        MessageBox.Show("Data Sudah Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call TampilDataGrid()
        Call NonAktif()
        Call Bersih()
    End Sub


    Private Sub DGVDataMobil_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDataPelanggan.CellContentClick

        If Module2.LoggedInRole = "customer" Then Exit Sub

        Dim baris As Integer
        With DGVDataPelanggan
            baris = .CurrentRow.Index
            txtNama.Text = .Item(1, baris).Value
            txtKTP.Text = .Item(2, baris).Value
            txtNoHP.Text = .Item(3, baris).Value
            txtAlamat.Text = .Item(4, baris).Value
            cbJenis.Text = .Item(5, baris).Value
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
        If txtKTP.Text = "" Then
            MessageBox.Show("Pilih Kode Barang dengan Benar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            If DialogDelete = DialogResult.Yes Then
                CMD = New MySqlCommand("Delete from tb_pelanggan where no_ktp = '" & txtKTP.Text & "'", CONN)
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
        If txtKTP.Text = "" Or txtNoHP.Text = "" Or txtNama.Text = "" Or txtAlamat.Text = "" Then
            MessageBox.Show("Data Harus Diisi!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim SQLUpdate As String = "UPDATE tb_pelanggan SET no_ktp = @ktp, no_hp = @hp, nama_pelanggan = @nama, alamat = @alamat, jenis_kelamin = @jk WHERE no_ktp = @ktp"
            CMD = New MySqlCommand(SQLUpdate, CONN)
            CMD.Parameters.AddWithValue("@ktp", txtKTP.Text)
            CMD.Parameters.AddWithValue("@hp", txtNoHP.Text)
            CMD.Parameters.AddWithValue("@nama", txtNama.Text)
            CMD.Parameters.AddWithValue("@alamat", txtAlamat.Text)
            CMD.Parameters.AddWithValue("@jk", cbJenis.Text)
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
        DA = New MySqlDataAdapter("select * from tb_pelanggan where nama_pelanggan like '%" & txtCari.Text & "%'", CONN)
        DS = New DataSet
        DA.Fill(DS, "tb_pelanggan")

        DGVDataPelanggan.DataSource = DS.Tables("tb_pelanggan")
    End Sub

    Private Sub txtKTP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKTP.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
       e.KeyChar = vbBack) Then
            e.Handled() = True
        End If
    End Sub

    Private Sub txtNoHP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoHP.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
       e.KeyChar = vbBack) Then
            e.Handled() = True
        End If
    End Sub

End Class