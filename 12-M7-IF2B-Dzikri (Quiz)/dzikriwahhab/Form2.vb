Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList

        ComboBox1.Items.Add("IIIA")
        ComboBox1.Items.Add("IIIB")
        ComboBox1.Items.Add("IIIC")

        ComboBox2.Items.Add("0")
        ComboBox2.Items.Add("1")
        ComboBox2.Items.Add("2")
        ComboBox2.Items.Add("3")

        ComboBox2.Enabled = False
        TextBoxTunAnak.Enabled = False
        TextBoxIstri.Enabled = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "IIIA"
                TextBoxGaji.Text = "Rp.1500000"
            Case "IIIB"
                TextBoxGaji.Text = "Rp.2500000"
            Case "IIIC"
                TextBoxGaji.Text = "Rp.3500000"
        End Select
    End Sub

    Private Sub ButtonHitung_Click(sender As Object, e As EventArgs) Handles ButtonHitung.Click
        Dim TotalGaji As Integer
        Dim TunjanganIstri, TunjanganAnak As Double
        Dim GajiPokok As Decimal
        Dim golongan As Integer = ComboBox1.SelectedIndex
        Dim JumlahAnak As Integer = ComboBox2.SelectedIndex

        Select Case golongan
            Case 0
                GajiPokok = 1500000
            Case 1
                GajiPokok = 2500000
            Case 2
                GajiPokok = 3500000
        End Select

        If CheckBox1.Checked Then
            TunjanganIstri = 0.15 * GajiPokok
            TunjanganAnak = 0.1 * GajiPokok * JumlahAnak


        End If


        TotalGaji = GajiPokok + TunjanganIstri + TunjanganAnak

        TextBoxTunAnak.Text = TunjanganAnak
        TextBoxIstri.Text = TunjanganIstri
        TextBoxTotal.Text = TotalGaji


    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            ComboBox2.Enabled = True
        Else
            ComboBox2.Enabled = False
        End If
    End Sub
End Class