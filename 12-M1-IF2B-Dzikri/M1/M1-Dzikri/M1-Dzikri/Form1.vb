Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPesan_Click(sender As Object, e As EventArgs) Handles btnPesan.Click
        MsgBox("Hello World...!" & vbCrLf &
        "My Name is Dzikri Ibrahim...", MsgBoxStyle.Information,
        "Message")
    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        Me.Close()
    End Sub
End Class
