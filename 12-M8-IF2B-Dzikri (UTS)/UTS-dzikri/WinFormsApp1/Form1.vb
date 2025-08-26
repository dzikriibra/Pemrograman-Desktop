Imports System.ComponentModel
Imports System.Globalization

Public Class Form1
    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click

        Dim uangSaku As Decimal

        If RadioButton1.Checked Then
            LabelStat.Text = "Aktif"
            uangSaku = 200000
        ElseIf RadioButton2.Checked Then
            LabelStat.Text = "Cuti"
            uangSaku = 50000
        End If

        LabelRupiah.Text = uangSaku.ToString("C0", New CultureInfo("id-ID"))

        LabelNIM.Text = TxtNIM.Text
        LabelNama.Text = TxtNama.Text
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        TxtNIM.Text = ""
        TxtNama.Text = ""
        ComboBoxJurusan.Text = ""

        LabelNIM.Text = ""
        LabelNama.Text = ""
        LabelJur.Text = ""
        LabelStat.Text = ""
        LabelRupiah.Text = ""
    End Sub

    Private Sub TxtNIM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNIM.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
           e.KeyChar = vbBack) Then
            e.Handled() = True
        End If

        If (e.KeyChar = Chr(13)) Then
            TxtNama.Focus()
        End If
    End Sub

    Private Sub ComboBoxJurusan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxJurusan.SelectedIndexChanged
        LabelJur.Text = ComboBoxJurusan.SelectedItem
    End Sub

    Private Sub TxtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNama.KeyPress
        If (e.KeyChar >= "0" And e.KeyChar <= "9") Then
            e.Handled() = True
        End If

        If (e.KeyChar = Chr(13)) Then
            BtnSimpan.Focus()
        End If
    End Sub
End Class
