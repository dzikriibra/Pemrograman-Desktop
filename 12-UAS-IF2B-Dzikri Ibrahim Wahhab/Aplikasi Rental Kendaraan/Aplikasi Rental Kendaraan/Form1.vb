Imports Google.Protobuf.WellKnownTypes

Public Class Form1
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Form5.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Form6.Show()
    End Sub

    Private Sub TransaksiSewaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiSewaToolStripMenuItem.Click
        Form7.Show()
    End Sub

    Private Sub TransaksiPengembalianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiPengembalianToolStripMenuItem.Click
        Form8.Show()
    End Sub

    Private Sub KELUARToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KELUARToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        ' Tombol Logout

        Dim confirm As DialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then
            ' Logout langsung, karena transaksi sudah terekam saat sewa
            Me.Hide()
            Form2.Show()
            Form2.txtUsername.Clear()
            Form2.txtPassword.Clear()
            Form2.txtUsername.Focus()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Module2.LoggedInRole = "customer" Then
            ' Sembunyikan fitur admin
            DataMobilToolStripMenuItem.Visible = False
            DataPelangganToolStripMenuItem.Visible = False
            CetakToolStripMenuItem.Visible = False
            TransaksiPengembalianToolStripMenuItem.Visible = False
        End If

        CenterPanel()
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        CenterPanel()
    End Sub

    Private Sub DataMobilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataMobilToolStripMenuItem.Click
        Form9.Show()
    End Sub

    Private Sub DataPelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPelangganToolStripMenuItem.Click
        Form10.Show()
    End Sub

    Private Sub DataTransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataTransaksiToolStripMenuItem.Click
        Form11.Show()
    End Sub

    Private Sub CenterPanel()
        Panel1.Left = (Me.ClientSize.Width - Panel1.Width) \ 2
        Panel1.Top = (Me.ClientSize.Height - Panel1.Height) \ 2
    End Sub
End Class
