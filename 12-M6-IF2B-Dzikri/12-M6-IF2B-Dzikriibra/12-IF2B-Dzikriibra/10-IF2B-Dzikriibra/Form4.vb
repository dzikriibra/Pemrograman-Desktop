Public Class Form4
    Private Sub BtnBulan_Click(sender As Object, e As EventArgs) Handles BtnBulan.Click
        Dim i As Integer
        For i = 1 To 12
            ListBulan.Items.Add(MonthName(i))
        Next i
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        End
    End Sub
End Class