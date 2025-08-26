Public Class Form9
    Private Sub BtnForNext_Click(sender As Object, e As EventArgs) Handles BtnForNext.Click
        ListLooping.Items.Clear()
        For i = 0 To 10
            ListLooping.Items.Add("For Next ke " & i)
        Next
    End Sub

    Private Sub BtnDoWhile_Click(sender As Object, e As EventArgs) Handles BtnDoWhile.Click
        ListLooping.Items.Clear()
        Dim i As Integer = 0
        Do While i <= 10
            ListLooping.Items.Add("Do While ke " & i)
            i += 1
        Loop
    End Sub

    Private Sub BtnDoUntil_Click(sender As Object, e As EventArgs) Handles BtnDoUntil.Click
        ListLooping.Items.Clear()
        Dim i As Integer = 0
        Do Until i > 10
            ListLooping.Items.Add("Do Until ke " & i)
            i += 1
        Loop
    End Sub
End Class