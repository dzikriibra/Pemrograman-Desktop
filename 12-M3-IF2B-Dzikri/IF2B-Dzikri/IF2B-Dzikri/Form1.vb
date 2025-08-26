Public Class frmUtama
    Private Sub btnPesan_Click(sender As Object, e As EventArgs) Handles btnPesan.Click
        MsgBox("Hello World...!" & vbCrLf &
"My Name is Dzikri Ibrahim Wahhab...", MsgBoxStyle.Information,
"Message")
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub
End Class
