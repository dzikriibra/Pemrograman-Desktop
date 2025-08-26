
Imports System.Data.SQLite
Imports System.Threading
Public Class Form3

    Dim conn As SQLiteConnection
    Dim cmd As SQLiteCommand
    Dim da As SQLiteDataAdapter
    Dim dt As DataTable

    Dim dbPath As String = "Data Source=""C:\Users\ASUS\Perkuliahan\Semester II\Pemrograman Desktop\12-M9-IF2B-Dzikri\db_mhs.db"";Version=3;"

    Sub TampilkanData()
        conn = New SQLiteConnection(dbPath)
        conn.Open()
        da = New SQLiteDataAdapter("SELECT * FROM tbl_nilai", conn)
        dt = New DataTable()
        da.Fill(dt)
        DataGridView1.DataSource = dt
        conn.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer = e.RowIndex
        If index >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(index)
            txtNIM.Text = row.Cells("NIM").Value.ToString()
            txtKodeMK.Text = row.Cells("Kode_Mtk").Value.ToString()
            txtGrade.Text = row.Cells("Grade_Nilai").Value.ToString()
        End If
    End Sub

    Function DataValidation() As Boolean
        If String.IsNullOrWhiteSpace(txtNIM.Text) Then
            MessageBox.Show("NIM tidak boleh kosong", "Mohon isi terlebih daluhu", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNIM.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtKodeMK.Text) Then
            MessageBox.Show("Kode Mata kuliah tidak boleh kosong", "Mohon isi terlebih dahulu", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKodeMK.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtGrade.Text) Then
            MessageBox.Show("Grade tidak boleh kosong", "Mohon isi terlebih dahulu", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtGrade.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If Not DataValidation() Then Exit Sub

        conn = New SQLiteConnection(dbPath)
        conn.Open()
        Dim insertSql As String = "INSERT INTO tbl_nilai (NIM, Kode_Mtk, Grade_Nilai) VALUES (@nim, @kodeMK, @grade)"
        cmd = New SQLiteCommand(insertSql, conn)
        cmd.Parameters.AddWithValue("@nim", txtNIM.Text)
        cmd.Parameters.AddWithValue("@kodeMK", txtKodeMK.Text)
        cmd.Parameters.AddWithValue("@grade", txtGrade.Text)
        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        TampilkanData()

        txtNIM.Clear()
        txtKodeMK.Clear()
        txtGrade.Clear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Not DataValidation() Then Exit Sub

        If MessageBox.Show("Yakin ingin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            conn = New SQLiteConnection(dbPath)
            conn.Open()
            Dim deleteSql As String = "DELETE FROM tbl_nilai WHERE NIM=@nim"
            cmd = New SQLiteCommand(deleteSql, conn)
            cmd.Parameters.AddWithValue("@nim", txtNIM.Text)
            Dim result As Integer = cmd.ExecuteNonQuery()
            conn.Close()

            If result > 0 Then
                MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Data tidak ditemukan.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            txtNIM.Clear()
            txtKodeMK.Clear()
            txtGrade.Clear()
            TampilkanData()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Not DataValidation() Then Exit Sub

        conn = New SQLiteConnection(dbPath)
        conn.Open()
        Dim updateSql As String = "UPDATE tbl_nilai SET Kode_Mtk=@kodeMK, Grade_Nilai=@grade WHERE NIM=@nim"
        cmd = New SQLiteCommand(updateSql, conn)
        cmd.Parameters.AddWithValue("@kodeMK", txtKodeMK.Text)
        cmd.Parameters.AddWithValue("@grade", txtGrade.Text)
        cmd.Parameters.AddWithValue("@nim", txtNIM.Text)
        Dim result As Integer = cmd.ExecuteNonQuery()
        conn.Close()

        If result > 0 Then
            MessageBox.Show("Data berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Data tidak ditemukan.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        txtNIM.Clear()
        txtKodeMK.Clear()
        txtGrade.Clear()
        TampilkanData()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        conn = New SQLiteConnection(dbPath)
        conn.Open()
        Dim cariSql As String = "SELECT * FROM tbl_nilai WHERE NIM LIKE @cari OR Kode_Mtk LIKE @cari OR Grade_Nilai LIKE @cari"
        cmd = New SQLiteCommand(cariSql, conn)
        cmd.Parameters.AddWithValue("@cari", "%" & txtCari.Text & "%")
        da = New SQLiteDataAdapter(cmd)
        dt = New DataTable()
        da.Fill(dt)
        DataGridView1.DataSource = dt
        conn.Close()
    End Sub
End Class
