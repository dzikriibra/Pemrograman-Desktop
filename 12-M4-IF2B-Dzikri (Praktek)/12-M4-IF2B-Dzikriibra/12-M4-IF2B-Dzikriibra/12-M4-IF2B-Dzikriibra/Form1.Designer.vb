<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBelanja
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        BoxBonus = New TextBox()
        BoxBayar = New TextBox()
        BoxDiskon = New TextBox()
        BoxTotal = New TextBox()
        BoxJumlah = New TextBox()
        BoxHarga = New TextBox()
        BoxNama = New TextBox()
        BtnKeluar = New Button()
        BtnUlang = New Button()
        BtnHitung = New Button()
        txtBonus = New Label()
        txtTotalBayar = New Label()
        txtDiskon = New Label()
        txtTotalHrg = New Label()
        txtJmlBarang = New Label()
        txtHarga = New Label()
        txtNamaBrg = New Label()
        SuspendLayout()
        ' 
        ' BoxBonus
        ' 
        BoxBonus.Enabled = False
        BoxBonus.Location = New Point(248, 462)
        BoxBonus.Name = "BoxBonus"
        BoxBonus.Size = New Size(240, 27)
        BoxBonus.TabIndex = 33
        ' 
        ' BoxBayar
        ' 
        BoxBayar.Enabled = False
        BoxBayar.Location = New Point(248, 410)
        BoxBayar.Name = "BoxBayar"
        BoxBayar.Size = New Size(155, 27)
        BoxBayar.TabIndex = 32
        ' 
        ' BoxDiskon
        ' 
        BoxDiskon.Enabled = False
        BoxDiskon.Location = New Point(248, 358)
        BoxDiskon.Name = "BoxDiskon"
        BoxDiskon.Size = New Size(155, 27)
        BoxDiskon.TabIndex = 31
        ' 
        ' BoxTotal
        ' 
        BoxTotal.Enabled = False
        BoxTotal.Location = New Point(248, 311)
        BoxTotal.Name = "BoxTotal"
        BoxTotal.Size = New Size(155, 27)
        BoxTotal.TabIndex = 30
        ' 
        ' BoxJumlah
        ' 
        BoxJumlah.Location = New Point(248, 203)
        BoxJumlah.Name = "BoxJumlah"
        BoxJumlah.Size = New Size(120, 27)
        BoxJumlah.TabIndex = 29
        ' 
        ' BoxHarga
        ' 
        BoxHarga.Location = New Point(248, 144)
        BoxHarga.Name = "BoxHarga"
        BoxHarga.Size = New Size(120, 27)
        BoxHarga.TabIndex = 28
        ' 
        ' BoxNama
        ' 
        BoxNama.Location = New Point(248, 89)
        BoxNama.Name = "BoxNama"
        BoxNama.Size = New Size(240, 27)
        BoxNama.TabIndex = 27
        ' 
        ' BtnKeluar
        ' 
        BtnKeluar.Location = New Point(248, 515)
        BtnKeluar.Name = "BtnKeluar"
        BtnKeluar.Size = New Size(113, 31)
        BtnKeluar.TabIndex = 26
        BtnKeluar.Text = "Keluar"
        BtnKeluar.UseVisualStyleBackColor = True
        ' 
        ' BtnUlang
        ' 
        BtnUlang.Location = New Point(375, 252)
        BtnUlang.Name = "BtnUlang"
        BtnUlang.Size = New Size(113, 33)
        BtnUlang.TabIndex = 25
        BtnUlang.Text = "Ulang"
        BtnUlang.UseVisualStyleBackColor = True
        ' 
        ' BtnHitung
        ' 
        BtnHitung.Location = New Point(248, 252)
        BtnHitung.Name = "BtnHitung"
        BtnHitung.Size = New Size(113, 33)
        BtnHitung.TabIndex = 24
        BtnHitung.Text = "Hitung"
        BtnHitung.UseVisualStyleBackColor = True
        ' 
        ' txtBonus
        ' 
        txtBonus.AutoSize = True
        txtBonus.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBonus.Location = New Point(114, 464)
        txtBonus.Name = "txtBonus"
        txtBonus.Size = New Size(61, 25)
        txtBonus.TabIndex = 23
        txtBonus.Text = "Bonus"
        ' 
        ' txtTotalBayar
        ' 
        txtTotalBayar.AutoSize = True
        txtTotalBayar.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTotalBayar.Location = New Point(84, 410)
        txtTotalBayar.Name = "txtTotalBayar"
        txtTotalBayar.Size = New Size(97, 25)
        txtTotalBayar.TabIndex = 22
        txtTotalBayar.Text = "Total Bayar"
        ' 
        ' txtDiskon
        ' 
        txtDiskon.AutoSize = True
        txtDiskon.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDiskon.Location = New Point(114, 360)
        txtDiskon.Name = "txtDiskon"
        txtDiskon.Size = New Size(67, 25)
        txtDiskon.TabIndex = 21
        txtDiskon.Text = "Diskon"
        ' 
        ' txtTotalHrg
        ' 
        txtTotalHrg.AutoSize = True
        txtTotalHrg.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTotalHrg.Location = New Point(79, 310)
        txtTotalHrg.Name = "txtTotalHrg"
        txtTotalHrg.Size = New Size(102, 25)
        txtTotalHrg.TabIndex = 20
        txtTotalHrg.Text = "Total Harga"
        ' 
        ' txtJmlBarang
        ' 
        txtJmlBarang.AutoSize = True
        txtJmlBarang.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtJmlBarang.Location = New Point(54, 202)
        txtJmlBarang.Name = "txtJmlBarang"
        txtJmlBarang.Size = New Size(127, 25)
        txtJmlBarang.TabIndex = 19
        txtJmlBarang.Text = "Jumlah Barang"
        ' 
        ' txtHarga
        ' 
        txtHarga.AutoSize = True
        txtHarga.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtHarga.Location = New Point(62, 146)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(119, 25)
        txtHarga.TabIndex = 18
        txtHarga.Text = "Harga Satuan"
        ' 
        ' txtNamaBrg
        ' 
        txtNamaBrg.AutoSize = True
        txtNamaBrg.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNamaBrg.Location = New Point(62, 88)
        txtNamaBrg.Name = "txtNamaBrg"
        txtNamaBrg.Size = New Size(119, 25)
        txtNamaBrg.TabIndex = 17
        txtNamaBrg.Text = "Nama Barang"
        ' 
        ' FrmBelanja
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        ClientSize = New Size(673, 656)
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
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "FrmBelanja"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Program Belanja Sederhana"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BoxBonus As TextBox
    Friend WithEvents BoxBayar As TextBox
    Friend WithEvents BoxDiskon As TextBox
    Friend WithEvents BoxTotal As TextBox
    Friend WithEvents BoxJumlah As TextBox
    Friend WithEvents BoxHarga As TextBox
    Friend WithEvents BoxNama As TextBox
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents BtnUlang As Button
    Friend WithEvents BtnHitung As Button
    Friend WithEvents txtBonus As Label
    Friend WithEvents txtTotalBayar As Label
    Friend WithEvents txtDiskon As Label
    Friend WithEvents txtTotalHrg As Label
    Friend WithEvents txtJmlBarang As Label
    Friend WithEvents txtHarga As Label
    Friend WithEvents txtNamaBrg As Label

End Class
