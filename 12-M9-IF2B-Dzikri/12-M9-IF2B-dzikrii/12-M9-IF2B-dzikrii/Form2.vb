Imports System.Data.SQLite
Public Class Form2

    Dim conn As SQLiteConnection
    Dim cmd As SQLiteCommand
    Dim da As SQLiteDataAdapter
    Dim dt As DataTable

    Dim dbPath As String = "Data Source=""C:\Users\ASUS\Perkuliahan\Semester II\Pemrograman Desktop\12-M9-IF2B-Dzikri\db_mhs.db"";Version=3;"

    Sub TampilkanData()
        conn = New SQLiteConnection(dbPath)
        conn.Open()
        da = New SQLiteDataAdapter("SELECT * FROM tbl_matkul", conn)
        dt = New DataTable()
        da.Fill(dt)
        DataGridView1.DataSource = dt
        conn.Close()
    End Sub

    Function DataValidation() As Boolean
        If String.IsNullOrWhiteSpace(txtKodeMK.Text) Then
            MessageBox.Show("Kode Mata kuliah tidak boleh kosong", "Mohon isi terlebih daluhu", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKodeMK.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtNamaMK.Text) Then
            MessageBox.Show("Nama Mata kuliah tidak boleh kosong", "Mohon isi terlebih dahulu", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNamaMK.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtSKS.Text) Then
            MessageBox.Show("SKS tidak boleh kosong", "Mohon isi terlebih dahulu", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSKS.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtSmt.Text) Then
            MessageBox.Show("Semester tidak boleh kosong", "Mohon isi terlebih dahulu", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSmt.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If Not DataValidation() Then Exit Sub

        conn = New SQLiteConnection(dbPath)
        conn.Open()
        Dim insertSql As String = "INSERT INTO tbl_matkul (Kode_Mtk, Nama_Mtk, SKS, Semester) VALUES (@kodeMK, @namaMK, @sks, @smt)"
        cmd = New SQLiteCommand(insertSql, conn)
        cmd.Parameters.AddWithValue("@kodeMK", txtKodeMK.Text)
        cmd.Parameters.AddWithValue("@namaMK", txtNamaMK.Text)
        cmd.Parameters.AddWithValue("@sks", txtSKS.Text)
        cmd.Parameters.AddWithValue("@smt", txtSmt.Text)
        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        TampilkanData()

        txtKodeMK.Clear()
        txtNamaMK.Clear()
        txtSKS.Clear()
        txtSmt.Clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Not DataValidation() Then Exit Sub

        conn = New SQLiteConnection(dbPath)
        conn.Open()
        Dim updateSql As String = "UPDATE tbl_matkul SET Nama_Mtk=@namaMK, SKS=@sks, Semester=@smt WHERE Kode_Mtk=@kodeMK"
        cmd = New SQLiteCommand(updateSql, conn)
        cmd.Parameters.AddWithValue("@kodeMK", txtKodeMK.Text)
        cmd.Parameters.AddWithValue("@namaMK", txtNamaMK.Text)
        cmd.Parameters.AddWithValue("@sks", txtSKS.Text)
        cmd.Parameters.AddWithValue("@smt", txtSmt.Text)
        Dim result As Integer = cmd.ExecuteNonQuery()
        conn.Close()

        If result > 0 Then
            MessageBox.Show("Data berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Data tidak ditemukan.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        txtKodeMK.Clear()
        txtNamaMK.Clear()
        txtSKS.Clear()
        txtSmt.Clear()
        TampilkanData()
    End Sub
    Function deleteValidation() As Boolean
        If String.IsNullOrWhiteSpace(txtKodeMK.Text) Then
            MessageBox.Show("Kode Mata Kuliah tidak boleh kosong untuk menghapus data!", "Mohon isi terlebih dahulu", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKodeMK.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtNamaMK.Text) Then
            MessageBox.Show("Nama Mata Kuliah tidak boleh kosong untuk menghapus data!", "Mohon isi terlebih dahulu", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNamaMK.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Not deleteValidation() Then Exit Sub

        If MessageBox.Show("Yakin ingin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            conn = New SQLiteConnection(dbPath)
            conn.Open()
            Dim deleteSql As String = "DELETE FROM tbl_matkul WHERE Kode_Mtk=@KodeMK"
            cmd = New SQLiteCommand(deleteSql, conn)
            cmd.Parameters.AddWithValue("@KodeMK", txtKodeMK.Text)
            Dim result As Integer = cmd.ExecuteNonQuery()
            conn.Close()

            If result > 0 Then
                MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Data tidak ditemukan.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            txtKodeMK.Clear()
            txtNamaMK.Clear()
            txtSKS.Clear()
            txtSmt.Clear()
            TampilkanData()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer = e.RowIndex
        If index >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(index)
            txtKodeMK.Text = row.Cells("Kode_Mtk").Value.ToString()
            txtNamaMK.Text = row.Cells("Nama_Mtk").Value.ToString()
            txtSKS.Text = row.Cells("SKS").Value.ToString()
            txtSmt.Text = row.Cells("Semester").Value.ToString()
        End If
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        conn = New SQLiteConnection(dbPath)
        conn.Open()
        Dim cariSql As String = "SELECT * FROM tbl_matkul WHERE Kode_Mtk LIKE @cari OR Nama_Mtk LIKE @cari OR SKS LIKE @cari OR Semester LIKE @cari"
        cmd = New SQLiteCommand(cariSql, conn)
        cmd.Parameters.AddWithValue("@cari", "%" & txtCari.Text & "%")
        da = New SQLiteDataAdapter(cmd)
        dt = New DataTable()
        da.Fill(dt)
        DataGridView1.DataSource = dt
        conn.Close()
    End Sub
End Class