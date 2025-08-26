Public Class Form2
    Private Sub BtnProses_Click(sender As Object, e As EventArgs) Handles BtnProses.Click
        Dim teks As String
        Dim jumlah As Integer
        teks = TxtTeks.Text
        jumlah = TxtJumlah.Text
        jumlah = Val(TxtJumlah.Text)
        For i = 1 To jumlah
            ListLooping.Items.Add(teks)
        Next i
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        TxtJumlah.Text = ""
        TxtTeks.Text = ""
        ListLooping.Items.Clear()
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        End
    End Sub
End Class