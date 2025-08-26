Public Class Form1

    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        Dim NilaiAkhir, Tugas, Kuis, UTS, UAS As Double
        Dim Grade, Ket As String

        Tugas = Val(BoxTugas.Text)
        Kuis = Val(BoxKuis.Text)
        UTS = Val(BoxUTS.Text)
        UAS = Val(BoxUAS.Text)

        NilaiAkhir = 0.1 * Tugas + 0.1 * Kuis + 0.3 * UTS + 0.5 * UAS
        BoxNilaiAkhir.Text = NilaiAkhir

        If NilaiAkhir >= 80 And NilaiAkhir <= 100 Then
            Grade = "A"
            Ket = "Lulus"
        ElseIf NilaiAkhir >= 65 And NilaiAkhir < 80 Then
            Grade = "B"
            Ket = "Lulus"
        ElseIf NilaiAkhir >= 50 And NilaiAkhir < 65 Then
            Grade = "C"
            Ket = "Lulus"
        ElseIf NilaiAkhir >= 35 And NilaiAkhir < 50 Then
            Grade = "D"
            Ket = "Tidak Lulus"
        ElseIf NilaiAkhir >= 0 And NilaiAkhir < 35 Then
            Grade = "E"
            Ket = "Tidak Lulus"
        Else
            Grade = "I"
            Ket = "Tidak Valid"
        End If

        BoxGrade.Text = Grade
        BoxKet.Text = Ket
    End Sub
End Class
