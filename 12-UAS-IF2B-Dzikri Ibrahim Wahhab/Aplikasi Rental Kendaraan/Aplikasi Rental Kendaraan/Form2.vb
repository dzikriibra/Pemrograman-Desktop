Imports MySql.Data.MySqlClient

Public Class Form2

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If e.KeyChar = Chr(13) Then txtPassword.Focus()
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then btnLogin.PerformClick()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text.Trim = "" Or txtPassword.Text.Trim = "" Then
            MessageBox.Show("Username dan Password wajib diisi.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Call koneksi()

            Dim sql As String = "
              SELECT * FROM tb_users 
              WHERE username=@user AND password=@pass AND role='customer' "
            CMD = New MySqlCommand(sql, CONN)
            CMD.Parameters.AddWithValue("@user", txtUsername.Text.Trim)
            CMD.Parameters.AddWithValue("@pass", txtPassword.Text.Trim)

            RD = CMD.ExecuteReader()

            If RD.HasRows Then
                RD.Read()

                Module2.LoggedInUsername = RD("username").ToString()
                Module2.LoggedInRole = RD("role").ToString()

                RD.Close()
                MessageBox.Show("Login berhasil!", "Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Hide()
                Form1.Show()
            Else
                RD.Close()
                MessageBox.Show("Username atau password salah!",
                                "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUsername.Clear()
                txtPassword.Clear()
                txtUsername.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If CONN.State = ConnectionState.Open Then CONN.Close()
        End Try
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Application.Exit()
    End Sub


End Class
