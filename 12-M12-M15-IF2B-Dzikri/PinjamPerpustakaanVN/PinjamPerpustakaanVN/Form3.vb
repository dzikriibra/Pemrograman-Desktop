Imports MySql.Data.MySqlClient
Public Class Form3
    Sub TampilDataGrid()
        DA = New MySqlDataAdapter("select * from tbanggota", CONN)
        DS = New DataSet
        DA.Fill(DS, "tbanggota")
        DGVAnggota.DataSource = (DS.Tables("tbanggota"))
    End Sub

    Sub Aktif()
        txtIDAnggota.Enabled = True
        txtNamaAnggota.Enabled = True
        txtAlamat.Enabled = True
        txtNoTelp.Enabled = True
        btnSimpan.Enabled = True
        btnTambah.Text = "BATAL"
        txtIDAnggota.Focus()
    End Sub

    Sub Bersih()
        txtIDAnggota.Text = ""
        txtNamaAnggota.Text = ""
        txtAlamat.Text = ""
        txtNoTelp.Text = ""
        txtCari.Text = ""
    End Sub

    Sub NonAktif()
        txtIDAnggota.Enabled = False
        txtNamaAnggota.Enabled = False
        txtAlamat.Enabled = False
        txtNoTelp.Enabled = False
        btnHapus.Enabled = False
        btnSimpan.Enabled = False
        btnUbah.Enabled = False
        btnTambah.Text = "TAMBAH"
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call TampilDataGrid()
        Call NonAktif()
        DGVAnggota.ReadOnly = True
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If txtIDAnggota.Text = "" Or txtNamaAnggota.Text = "" Or txtAlamat.Text = "" Or txtNoTelp.Text = "" Then
            MessageBox.Show("Data Harus Diisi!",
            "Informasi", MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation)
        Else
            Dim SQLSimpan As String = "insert into tbanggota(IDAnggota,NamaAnggota,Alamat,Telepon) values('" & txtIDAnggota.Text & "','" & txtNamaAnggota.Text & "','" & txtAlamat.Text & "','" & txtNoTelp.Text & "')"
            CMD = New MySqlCommand(SQLSimpan, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Sudah Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call TampilDataGrid()
            Call NonAktif()
            Call Bersih()
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

    Private Sub DGVAnggota_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVAnggota.CellContentClick
        Dim baris As Integer
        With DGVAnggota
            baris = .CurrentRow.Index
            txtIDAnggota.Text = .Item(0, baris).Value
            txtNamaAnggota.Text = .Item(1, baris).Value
            txtAlamat.Text = .Item(2, baris).Value
            txtNoTelp.Text = .Item(3, baris).Value
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
        If txtIDAnggota.Text = "" Then
            MessageBox.Show("Pilih Kode Barang dengan Benar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            If DialogDelete = DialogResult.Yes Then
                CMD = New MySqlCommand("Delete from tbanggota where IDAnggota = '" & txtIDAnggota.Text & "'", CONN)
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
        If txtIDAnggota.Text = "" Or txtNamaAnggota.Text = "" Or txtAlamat.Text = "" Or txtNoTelp.Text = "" Then
            MessageBox.Show("Data Harus Diisi!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim SQLUpdate As String = "update tbanggota set IDAnggota = '" & txtIDAnggota.Text & "', NamaAnggota = '" & txtNamaAnggota.Text & "', Alamat = '" & txtAlamat.Text & "', Telepon = '" & txtNoTelp.Text & "' where IDAnggota = '" & txtIDAnggota.Text & "'"
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
        DA = New MySqlDataAdapter("select * from tbanggota where IDAnggota like '%" & txtCari.Text & "%'", CONN)
        DS = New DataSet
        DA.Fill(DS, "tbanggota")

        DGVAnggota.DataSource = DS.Tables("tbanggota")
    End Sub

End Class