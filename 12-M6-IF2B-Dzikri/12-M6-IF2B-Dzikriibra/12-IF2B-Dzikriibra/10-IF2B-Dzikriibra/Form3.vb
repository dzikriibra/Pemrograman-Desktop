Public Class Form3
    Private Sub BtnHari_Click(sender As Object, e As EventArgs) Handles BtnHari.Click
        Dim i As Integer
        For i = 1 To 7
            ListHari.Items.Add(WeekdayName(i))
        Next i
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        End
    End Sub
End Class