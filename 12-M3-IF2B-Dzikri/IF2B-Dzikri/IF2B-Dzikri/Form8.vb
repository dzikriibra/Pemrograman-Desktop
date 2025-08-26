Public Class FrmOrderMkn
    Public hrgmakanan, hrgminuman As Integer

    Private Sub FrmOrderMkn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList

        ComboBox1.Items.Add("Nasi Uduk")
        ComboBox1.Items.Add("Bakso")
        ComboBox1.Items.Add("Mie Ayam")

        ComboBox2.Items.Add("Es Jeruk")
        ComboBox2.Items.Add("Jus Alpukat")
        ComboBox2.Items.Add("Teh Manis")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "Nasi Uduk"
                Label2.Text = "Rp.9000"
                hrgmakanan = 9000
            Case "Bakso"
                Label2.Text = "Rp.10000"
                hrgmakanan = 10000
            Case "Mie Ayam"
                Label2.Text = "Rp.7000"
                hrgmakanan = 7000
        End Select
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.Text
            Case "Es Jeruk"
                Label4.Text = "Rp.5000"
                hrgminuman = 5000
            Case "Jus Alpukat"
                Label4.Text = "Rp.7000"
                hrgminuman = 7000
            Case "Teh Manis"
                Label4.Text = "Rp.4000"
                hrgminuman = 4000
        End Select
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ComboBox2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label7.Visible = False
        TextBox2.Visible = False
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            ComboBox2.Visible = False
            TextBox2.Visible = False
            Label7.Visible = False
        End If

        If CheckBox1.Enabled = True Then
            ComboBox2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label7.Visible = True
            TextBox2.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim porsimkn, porsimnm, jumlah As Integer
        porsimkn = Val(TextBox1.Text)
        porsimnm = Val(TextBox2.Text)
        jumlah = (hrgmakanan * porsimkn) + (hrgminuman * porsimnm)
        Label8.Text = "Rp. " & jumlah.ToString
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
           e.KeyChar = vbBack) Then
            e.Handled() = True
        End If

        If (e.KeyChar = Chr(13)) Then
            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
           e.KeyChar = vbBack) Then
            e.Handled() = True
        End If

        If (e.KeyChar = Chr(13)) Then
            Button1.Focus()
        End If
    End Sub


End Class