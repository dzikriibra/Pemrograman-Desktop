Imports MySql.Data.MySqlClient

Public Class Form4

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtPassword.Text.Trim() = "" Then
            MessageBox.Show("Password belum diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Call koneksi()

            CMD = New MySqlCommand("SELECT * FROM tb_users WHERE password = @pw AND role = 'admin' LIMIT 1", CONN)
            CMD.Parameters.AddWithValue("@pw", txtPassword.Text.Trim())

            RD = CMD.ExecuteReader()

            If RD.HasRows Then
                RD.Read()
                MessageBox.Show("Selamat datang Admin " & RD("full_name"), "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RD.Close()
                Me.Hide()
                Form1.Show() 'Ganti dengan form utama admin kamu
            Else
                MessageBox.Show("Password salah atau bukan admin!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword.Clear()
                txtPassword.Focus()
                RD.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If CONN.State = ConnectionState.Open Then CONN.Close()
        End Try
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
