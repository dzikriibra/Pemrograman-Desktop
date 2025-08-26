Imports MySql.Data.MySqlClient

Public Class Form2

    Private Sub txtUsername_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If e.KeyChar = Chr(13) Then
            txtPassword.Focus()
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Call koneksi()

            CMD = New MySqlCommand("SELECT * FROM tbpetugas WHERE status = @status AND password = @password", CONN)
            CMD.Parameters.AddWithValue("@status", txtUsername.Text.Trim())
            CMD.Parameters.AddWithValue("@password", txtPassword.Text.Trim())

            RD = CMD.ExecuteReader()

            If RD.HasRows Then
                RD.Read()
                MessageBox.Show("Login berhasil, selamat datang " & RD("status"), "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                Form1.Show()
                RD.Close()
            Else
                MessageBox.Show("Username atau password salah!", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUsername.Clear()
                txtPassword.Clear()
                txtUsername.Focus()
                RD.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If CONN.State = ConnectionState.Open Then
                CONN.Close()
            End If
        End Try
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Application.Exit()
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub
End Class
