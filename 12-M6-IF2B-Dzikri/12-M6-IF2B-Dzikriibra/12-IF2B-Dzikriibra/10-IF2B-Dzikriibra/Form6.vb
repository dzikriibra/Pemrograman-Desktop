Public Class Form6
    Private Sub BtnProses_Click(sender As Object, e As EventArgs) Handles BtnProses.Click
        Dim i As Integer
        Do While i <= 10
            ListLooping.Items.Add("Perulangan dengan Do While ke " & i)
            i += 1
        Loop
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        End
    End Sub
End Class