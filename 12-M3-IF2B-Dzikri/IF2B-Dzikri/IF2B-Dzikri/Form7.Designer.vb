<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBelanja
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtNamaBrg = New Label()
        txtHarga = New Label()
        txtJmlBarang = New Label()
        txtTotalHrg = New Label()
        txtDiskon = New Label()
        txtTotalBayar = New Label()
        txtBonus = New Label()
        BtnHitung = New Button()
        BtnUlang = New Button()
        BtnKeluar = New Button()
        BoxNama = New TextBox()
        BoxHarga = New TextBox()
        BoxJumlah = New TextBox()
        BoxTotal = New TextBox()
        BoxDiskon = New TextBox()
        BoxBayar = New TextBox()
        BoxBonus = New TextBox()
        SuspendLayout()
        ' 
        ' txtNamaBrg
        ' 
        txtNamaBrg.AutoSize = True
        txtNamaBrg.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNamaBrg.Location = New Point(67, 87)
        txtNamaBrg.Name = "txtNamaBrg"
        txtNamaBrg.Size = New Size(119, 25)
        txtNamaBrg.TabIndex = 0
        txtNamaBrg.Text = "Nama Barang"
        ' 
        ' txtHarga
        ' 
        txtHarga.AutoSize = True
        txtHarga.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtHarga.Location = New Point(67, 131)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(119, 25)
        txtHarga.TabIndex = 1
        txtHarga.Text = "Harga Satuan"
        ' 
        ' txtJmlBarang
        ' 
        txtJmlBarang.AutoSize = True
        txtJmlBarang.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtJmlBarang.Location = New Point(59, 175)
        txtJmlBarang.Name = "txtJmlBarang"
        txtJmlBarang.Size = New Size(127, 25)
        txtJmlBarang.TabIndex = 2
        txtJmlBarang.Text = "Jumlah Barang"
        ' 
        ' txtTotalHrg
        ' 
        txtTotalHrg.AutoSize = True
        txtTotalHrg.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTotalHrg.Location = New Point(84, 266)
        txtTotalHrg.Name = "txtTotalHrg"
        txtTotalHrg.Size = New Size(102, 25)
        txtTotalHrg.TabIndex = 3
        txtTotalHrg.Text = "Total Harga"
        ' 
        ' txtDiskon
        ' 
        txtDiskon.AutoSize = True
        txtDiskon.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDiskon.Location = New Point(119, 312)
        txtDiskon.Name = "txtDiskon"
        txtDiskon.Size = New Size(67, 25)
        txtDiskon.TabIndex = 4
        txtDiskon.Text = "Diskon"
        ' 
        ' txtTotalBayar
        ' 
        txtTotalBayar.AutoSize = True
        txtTotalBayar.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTotalBayar.Location = New Point(89, 357)
        txtTotalBayar.Name = "txtTotalBayar"
        txtTotalBayar.Size = New Size(97, 25)
        txtTotalBayar.TabIndex = 5
        txtTotalBayar.Text = "Total Bayar"
        ' 
        ' txtBonus
        ' 
        txtBonus.AutoSize = True
        txtBonus.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBonus.Location = New Point(125, 406)
        txtBonus.Name = "txtBonus"
        txtBonus.Size = New Size(61, 25)
        txtBonus.TabIndex = 6
        txtBonus.Text = "Bonus"
        ' 
        ' BtnHitung
        ' 
        BtnHitung.Location = New Point(203, 219)
        BtnHitung.Name = "BtnHitung"
        BtnHitung.Size = New Size(113, 33)
        BtnHitung.TabIndex = 7
        BtnHitung.Text = "Hitung"
        BtnHitung.UseVisualStyleBackColor = True
        ' 
        ' BtnUlang
        ' 
        BtnUlang.Location = New Point(330, 219)
        BtnUlang.Name = "BtnUlang"
        BtnUlang.Size = New Size(113, 33)
        BtnUlang.TabIndex = 8
        BtnUlang.Text = "Ulang"
        BtnUlang.UseVisualStyleBackColor = True
        ' 
        ' BtnKeluar
        ' 
        BtnKeluar.Location = New Point(192, 454)
        BtnKeluar.Name = "BtnKeluar"
        BtnKeluar.Size = New Size(113, 31)
        BtnKeluar.TabIndex = 9
        BtnKeluar.Text = "Keluar"
        BtnKeluar.UseVisualStyleBackColor = True
        ' 
        ' BoxNama
        ' 
        BoxNama.Location = New Point(203, 90)
        BoxNama.Name = "BoxNama"
        BoxNama.Size = New Size(240, 27)
        BoxNama.TabIndex = 10
        ' 
        ' BoxHarga
        ' 
        BoxHarga.Location = New Point(203, 131)
        BoxHarga.Name = "BoxHarga"
        BoxHarga.Size = New Size(120, 27)
        BoxHarga.TabIndex = 11
        ' 
        ' BoxJumlah
        ' 
        BoxJumlah.Location = New Point(203, 176)
        BoxJumlah.Name = "BoxJumlah"
        BoxJumlah.Size = New Size(120, 27)
        BoxJumlah.TabIndex = 12
        ' 
        ' BoxTotal
        ' 
        BoxTotal.Enabled = False
        BoxTotal.Location = New Point(203, 267)
        BoxTotal.Name = "BoxTotal"
        BoxTotal.Size = New Size(155, 27)
        BoxTotal.TabIndex = 13
        ' 
        ' BoxDiskon
        ' 
        BoxDiskon.Enabled = False
        BoxDiskon.Location = New Point(203, 313)
        BoxDiskon.Name = "BoxDiskon"
        BoxDiskon.Size = New Size(155, 27)
        BoxDiskon.TabIndex = 14
        ' 
        ' BoxBayar
        ' 
        BoxBayar.Enabled = False
        BoxBayar.Location = New Point(203, 358)
        BoxBayar.Name = "BoxBayar"
        BoxBayar.Size = New Size(155, 27)
        BoxBayar.TabIndex = 15
        ' 
        ' BoxBonus
        ' 
        BoxBonus.Enabled = False
        BoxBonus.Location = New Point(203, 407)
        BoxBonus.Name = "BoxBonus"
        BoxBonus.Size = New Size(240, 27)
        BoxBonus.TabIndex = 16
        ' 
        ' FrmBelanja
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(592, 532)
        Controls.Add(BoxBonus)
        Controls.Add(BoxBayar)
        Controls.Add(BoxDiskon)
        Controls.Add(BoxTotal)
        Controls.Add(BoxJumlah)
        Controls.Add(BoxHarga)
        Controls.Add(BoxNama)
        Controls.Add(BtnKeluar)
        Controls.Add(BtnUlang)
        Controls.Add(BtnHitung)
        Controls.Add(txtBonus)
        Controls.Add(txtTotalBayar)
        Controls.Add(txtDiskon)
        Controls.Add(txtTotalHrg)
        Controls.Add(txtJmlBarang)
        Controls.Add(txtHarga)
        Controls.Add(txtNamaBrg)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "FrmBelanja"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Program Belanja Sederhana"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNamaBrg As Label
    Friend WithEvents txtHarga As Label
    Friend WithEvents txtJmlBarang As Label
    Friend WithEvents txtTotalHrg As Label
    Friend WithEvents txtDiskon As Label
    Friend WithEvents txtTotalBayar As Label
    Friend WithEvents txtBonus As Label
    Friend WithEvents BtnHitung As Button
    Friend WithEvents BtnUlang As Button
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents BoxNama As TextBox
    Friend WithEvents BoxHarga As TextBox
    Friend WithEvents BoxJumlah As TextBox
    Friend WithEvents BoxTotal As TextBox
    Friend WithEvents BoxDiskon As TextBox
    Friend WithEvents BoxBayar As TextBox
    Friend WithEvents BoxBonus As TextBox
End Class
