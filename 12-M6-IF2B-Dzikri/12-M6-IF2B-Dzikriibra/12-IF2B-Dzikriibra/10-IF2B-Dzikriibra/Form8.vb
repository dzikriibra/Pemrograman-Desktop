Public Class Form8
    Private Sub BtnProses_Click(sender As Object, e As EventArgs) Handles BtnProses.Click
        Dim i As Integer
        i = 1
        ListLooping.Items.Clear()
        Do Until i > 10
            ListLooping.Items.Add(i)
            i += 1
        Loop
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        End
    End Sub
End Class