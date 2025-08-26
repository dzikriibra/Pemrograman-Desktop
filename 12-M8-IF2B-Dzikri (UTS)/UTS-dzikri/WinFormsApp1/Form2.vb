Public Class Form2
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
           e.KeyChar = vbBack) Then
            e.Handled() = True
        End If

        If (e.KeyChar = Chr(13)) Then
            btnProses.Focus()
        End If
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        ListHasil.Items.Clear()
        Dim kelipatan As Integer

        If ComboBox1.SelectedItem IsNot Nothing Then
            kelipatan = Val(ComboBox1.SelectedItem)
        Else
            MsgBox("Pilih Kelipatan")
            Exit Sub
        End If

        For i As Integer = 1 To TextBox1.Text
            If i Mod kelipatan = 0 Then
                ListHasil.Items.Add(i)
            End If
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListHasil.Items.Clear()
        TextBox1.Clear()
        ComboBox1.SelectedIndex = -1
    End Sub
End Class