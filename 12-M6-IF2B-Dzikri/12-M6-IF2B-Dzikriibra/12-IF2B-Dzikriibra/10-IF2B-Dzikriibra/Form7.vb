Public Class Form7
    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        End
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        TxtAngka.Text = ""
    End Sub

    Private Sub BtnProses_Click(sender As Object, e As EventArgs) Handles BtnProses.Click
        Dim x As Integer
        x = Val(TxtAngka.Text)
        Do
            x = x Mod 2
            If x = 1 Then
                MsgBox("Angka Ganjil", vbOKOnly, "Do While Ganjil Genap")
                Exit Do
            Else
                MsgBox("Angka Genap", vbOKOnly, "Do While Genap Ganjil")
                Exit Do
            End If
        Loop While Not x
    End Sub
End Class