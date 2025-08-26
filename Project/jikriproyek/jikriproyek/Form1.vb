Public Class Form1


    Private Sub txtAngka_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAngka.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
           e.KeyChar = vbBack) Then
            e.Handled() = True
        End If

        If (e.KeyChar = Chr(13)) Then
            btnHitung.Focus()
        End If

    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click

        If txtAngka.Text = "" Then
            MessageBox.Show("Silahkan masukkan angka", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAngka.Focus()
            Return
        End If

        Dim inputAngka As Integer = txtAngka.Text
        ListHasil.Items.Clear()

        For i As Integer = 1 To 10
            ListHasil.Items.Add(inputAngka & " x " & i & " = " & (inputAngka * i))
        Next

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Membersihkan textbox
        txtAngka.Text = ""
        ListHasil.Items.Clear()
        txtAngka.Focus()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        End
    End Sub


End Class
