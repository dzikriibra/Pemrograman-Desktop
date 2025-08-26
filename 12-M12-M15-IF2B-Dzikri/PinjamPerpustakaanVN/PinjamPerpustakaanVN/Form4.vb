Imports MySql.Data.MySqlClient

Public Class Form4
    Sub TampilDataGrid()
        DA = New MySqlDataAdapter("select * from tbbuku", CONN)
        DS = New DataSet
        DA.Fill(DS, "tbbuku")
        DGVBuku.DataSource = (DS.Tables("tbbuku"))
    End Sub

    Sub Aktif()
        txtKodeBuku.Enabled = True
        txtJudulBuku.Enabled = True
        txtPengarang.Enabled = True
        txtPenerbit.Enabled = True
        btnSimpan.Enabled = True
        btnTambah.Text = "BATAL"
        txtKodeBuku.Focus()
    End Sub

    Sub Bersih()
        txtKodeBuku.Text = ""
        txtJudulBuku.Text = ""
        txtPengarang.Text = ""
        txtPenerbit.Text = ""
        txtCari.Text = ""
    End Sub

    Sub NonAktif()
        txtKodeBuku.Enabled = False
        txtJudulBuku.Enabled = False
        txtPengarang.Enabled = False
        txtPenerbit.Enabled = False
        btnHapus.Enabled = False
        btnSimpan.Enabled = False
        btnUbah.Enabled = False
        btnTambah.Text = "TAMBAH"
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call TampilDataGrid()
        Call NonAktif()
        DGVBuku.ReadOnly = True
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If txtKodeBuku.Text = "" Or txtJudulBuku.Text = "" Or txtPengarang.Text = "" Or txtPenerbit.Text = "" Then
            MessageBox.Show("Data Harus Diisi!",
            "Informasi", MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation)
        Else
            Dim SQLSimpan As String = "insert into tbbuku(KodeBuku,JudulBuku,Pengarang,Penerbit) values('" & txtKodeBuku.Text & "','" & txtJudulBuku.Text & "','" & txtPengarang.Text & "','" & txtPenerbit.Text & "')"
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

    Private Sub DGVBuku_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVBuku.CellContentClick
        Dim baris As Integer
        With DGVBuku
            baris = .CurrentRow.Index
            txtKodeBuku.Text = .Item(0, baris).Value
            txtJudulBuku.Text = .Item(1, baris).Value
            txtPengarang.Text = .Item(2, baris).Value
            txtPenerbit.Text = .Item(3, baris).Value
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
        If txtKodeBuku.Text = "" Then
            MessageBox.Show("Pilih Kode Barang dengan Benar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            If DialogDelete = DialogResult.Yes Then
                CMD = New MySqlCommand("Delete from tbbuku where KodeBuku = '" & txtKodeBuku.Text & "'", CONN)
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
        If txtKodeBuku.Text = "" Or txtJudulBuku.Text = "" Or txtPengarang.Text = "" Or txtPenerbit.Text = "" Then
            MessageBox.Show("Data Harus Diisi!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim SQLUpdate As String = "update tbbuku set KodeBuku = '" & txtKodeBuku.Text & "', JudulBuku = '" & txtJudulBuku.Text & "', Pengarang = '" & txtPengarang.Text & "', Penerbit = '" & txtPenerbit.Text & "' where KodeBuku = '" & txtKodeBuku.Text & "'"
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
        DA = New MySqlDataAdapter("select * from tbbuku where KodeBuku like '%" & txtCari.Text & "%'", CONN)
        DS = New DataSet
        DA.Fill(DS, "tbbuku")

        DGVBuku.DataSource = DS.Tables("tbbuku")
    End Sub

End Class