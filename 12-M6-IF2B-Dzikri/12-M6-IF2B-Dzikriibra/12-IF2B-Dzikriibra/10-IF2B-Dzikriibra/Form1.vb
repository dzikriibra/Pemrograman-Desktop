Public Class Form1
    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Dim pesan As String
        pesan = MsgBox("Apakah Anda yakin ingin keluar?", vbYesNo, "Konfirmasi")
        If pesan = vbYes Then
            Close()
        End If
    End Sub

    Private Sub BtnProses_Click(sender As Object, e As EventArgs) Handles BtnProses.Click
        Dim i As Integer
        For i = 1 To 15
            ListLooping.Items.Add(i)
        Next i
    End Sub
End Class
