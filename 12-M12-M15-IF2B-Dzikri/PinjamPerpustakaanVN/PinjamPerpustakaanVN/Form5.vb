Imports MySql.Data.MySqlClient

Public Class Form5
    Sub Bersih()
        txtKodePinjam.Text = ""
        txtIDAnggota.Text = ""
        txtNamaAnggota.Text = ""
        txtNoTelp.Text = ""
        DGVPinjam.ClearSelection()
    End Sub

    Sub aktif()
        txtKodePinjam.Enabled = True
        txtIDAnggota.Enabled = True
        txtNamaAnggota.Enabled = True
        txtNoTelp.Enabled = True
        btnTambah.Text = "BATAL"
        btnSimpan.Enabled = True
        DGVPinjam.Enabled = True
        btnKeluar.Enabled = False
    End Sub

    Sub NonAktif()
        txtKodePinjam.Enabled = False
        txtIDAnggota.Enabled = False
        txtNamaAnggota.Enabled = False
        txtNoTelp.Enabled = False
        DGVPinjam.Enabled = False
        btnTambah.Text = "TAMBAH"
        btnSimpan.Enabled = False
        btnKeluar.Enabled = True
    End Sub
    Sub AturLebarGrid()
        DGVPinjam.Columns(0).Width = 50
        DGVPinjam.Columns(1).Width = 200
        DGVPinjam.Columns(2).Width = 100
        DGVPinjam.Columns(3).Width = 100
    End Sub
    Sub BuatKolomBaru()
        DGVPinjam.Columns.Add("Kode", "Kode Buku")
        DGVPinjam.Columns.Add("Judul", "Judul Buku")
        DGVPinjam.Columns.Add("Pengarang", "Pengarang")
        DGVPinjam.Columns.Add("Penerbit", "Penerbit")
        Call AturLebarGrid()
    End Sub

    Private Sub KodePinjamOtomatis()
        Call koneksi()
        CMD = New MySqlCommand("select * from tbpinjam where KodePinjam in (select max(KodePinjam) from tbpinjam) order by KodePinjam desc", CONN)
        Dim urutan As String
        Dim hitung As Long
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            urutan = "PJM" + "0001"
        Else
            hitung = Microsoft.VisualBasic.Right(RD.GetString(0), 4) + 1
            urutan = "PJM" + Microsoft.VisualBasic.Right("0000" & hitung, 4)
        End If
        txtKodePinjam.Text = urutan
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call BuatKolomBaru()
        Call NonAktif()
        DTPinjam.Value = Today
    End Sub

    Private Sub txtIDAnggota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIDAnggota.KeyPress
        Call koneksi()
        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("select * from tbanggota where IDAnggota = '" & txtIDAnggota.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                txtNamaAnggota.Text = RD.GetString(1)
                txtNoTelp.Text = RD.GetString(3)
                DGVPinjam.Focus()
            Else
                MessageBox.Show("Maaf, ID tidak terdaftar", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtIDAnggota.Text = ""
                txtNamaAnggota.Text = ""
                txtNoTelp.Text = ""
                txtIDAnggota.Focus()
            End If
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If btnTambah.Text = "TAMBAH" Then
            Call BuatKolomBaru()
            Call Bersih()
            Call aktif()
            Call KodePinjamOtomatis()
            txtIDAnggota.Focus()
        Else
            Call BuatKolomBaru()
            Call Bersih()
            Call NonAktif()
            DGVPinjam.Columns.Clear()
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call koneksi()
        If txtIDAnggota.Text = "" Or txtNamaAnggota.Text = "" Or txtNoTelp.Text = "" Then
            MessageBox.Show("Data belum lengkap", "PERINGATAN",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            'menyimpan ke tbpinjam
            Dim SimpanPinjam As String = "insert into tbpinjam(Kodepinjam,IDAnggota,TanggalPinjam) values ('" & txtKodePinjam.Text & "', '" & txtIDAnggota.Text & "', '" & Format(DTPinjam.Value, "yyyy-MM-dd") & "')"
            CMD = New MySqlCommand(SimpanPinjam, CONN)
            CMD.ExecuteNonQuery()
            'menyimpan ke tbdetilpinjam
            For baris As Integer = 0 To DGVPinjam.Rows.Count - 2
                Dim SQLSimpan As String = "insert into tbdetailpinjam(KodePinjam,KodeBuku) values('" & txtKodePinjam.Text & "', '" & DGVPinjam.Rows(baris).Cells(0).Value & "')"
                CMD = New MySqlCommand(SQLSimpan, CONN)
                CMD.ExecuteNonQuery()
            Next baris
            MessageBox.Show("Data telah disimpan", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DGVPinjam.Columns.Clear()
            Call BuatKolomBaru()
            Call Bersih()
            Call NonAktif()
        End If
    End Sub

    Private Sub DGVPinjam_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPinjam.CellEndEdit
        Call koneksi()
        CMD = New MySqlCommand("select * from tbbuku where KodeBuku = '" & DGVPinjam.Rows(e.RowIndex).Cells(0).Value & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            DGVPinjam.Rows(e.RowIndex).Cells(1).Value = RD.Item(1)
            DGVPinjam.Rows(e.RowIndex).Cells(2).Value = RD.Item(2)
            DGVPinjam.Rows(e.RowIndex).Cells(3).Value = RD.Item(3)
        Else
            MessageBox.Show("Maaf buku tidak terdaftar", "PERINGATAN !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

End Class