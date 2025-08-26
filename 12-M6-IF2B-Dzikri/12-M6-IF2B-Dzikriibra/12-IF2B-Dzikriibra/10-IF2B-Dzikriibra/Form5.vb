Public Class Form5
    Private Sub BtnProses_Click(sender As Object, e As EventArgs) Handles BtnProses.Click
        Dim x, y, i As Integer
        x = Val(TxtAwal.Text)
        y = Val(TxtAkhir.Text)
        For i = x To y
            If i Mod 2 = 0 Then
                ListGenap.Items.Add(i)
            ElseIf i Mod 2 = 1 Then
                ListGanjil.Items.Add(i)
            End If
        Next
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        End
    End Sub
End Class