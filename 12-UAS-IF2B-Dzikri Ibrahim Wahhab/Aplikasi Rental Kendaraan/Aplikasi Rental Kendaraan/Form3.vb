Imports MySql.Data.MySqlClient

Public Class Form3

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        ' Validasi awal
        If txtFullName.Text.Trim() = "" Or txtUsername.Text.Trim() = "" Or txtEmail.Text.Trim() = "" Or txtPassword.Text = "" Or txtConfirm.Text = "" Then
            MessageBox.Show("Semua field wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validasi password cocok
        If txtPassword.Text <> txtConfirm.Text Then
            MessageBox.Show("Password dan Konfirmasi Password tidak cocok!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Clear()
            txtConfirm.Clear()
            txtPassword.Focus()
            Exit Sub
        End If

        Try
            Call koneksi()

            ' Cek apakah username sudah ada
            CMD = New MySqlCommand("SELECT COUNT(*) FROM tb_users WHERE username = @username", CONN)
            CMD.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
            Dim count As Integer = Convert.ToInt32(CMD.ExecuteScalar())
            If count > 0 Then
                MessageBox.Show("Username sudah digunakan. Silakan pilih username lain.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtUsername.Focus()
                Exit Sub
            End If

            ' Simpan ke database
            CMD = New MySqlCommand("INSERT INTO tb_users (full_name, username, password, email, role) VALUES (@full_name, @username, @password, @email, 'customer')", CONN)
            CMD.Parameters.AddWithValue("@full_name", txtFullName.Text.Trim())
            CMD.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
            CMD.Parameters.AddWithValue("@password", txtPassword.Text) ' Bisa kamu hash jika mau
            CMD.Parameters.AddWithValue("@email", txtEmail.Text.Trim())

            CMD.ExecuteNonQuery()
            MessageBox.Show("Registrasi berhasil! Silakan login.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Kosongkan form & tutup
            txtFullName.Clear()
            txtUsername.Clear()
            txtPassword.Clear()
            txtConfirm.Clear()
            txtEmail.Clear()
            Me.Close()
            Form2.Show() ' balik ke login

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If CONN.State = ConnectionState.Open Then
                CONN.Close()
            End If
        End Try
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
        Form2.Show() ' Kembali ke login
    End Sub

End Class
