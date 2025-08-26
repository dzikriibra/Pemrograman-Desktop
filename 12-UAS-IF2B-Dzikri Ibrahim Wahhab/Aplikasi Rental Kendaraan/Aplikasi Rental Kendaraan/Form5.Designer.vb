<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.DGVDataMobil = New System.Windows.Forms.DataGridView()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMerk = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNamaMobil = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPlat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTahun = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        CType(Me.DGVDataMobil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(76, 348)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(165, 23)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "CARI NAMA MOBIL :"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(80, 374)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(552, 22)
        Me.txtCari.TabIndex = 86
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(302, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 23)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Car Rental Management System"
        '
        'cbStatus
        '
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(560, 223)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(207, 24)
        Me.cbStatus.TabIndex = 84
        '
        'DGVDataMobil
        '
        Me.DGVDataMobil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDataMobil.Location = New System.Drawing.Point(80, 437)
        Me.DGVDataMobil.Name = "DGVDataMobil"
        Me.DGVDataMobil.RowHeadersWidth = 51
        Me.DGVDataMobil.RowTemplate.Height = 24
        Me.DGVDataMobil.Size = New System.Drawing.Size(687, 286)
        Me.DGVDataMobil.TabIndex = 83
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(376, 282)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(95, 40)
        Me.btnUbah.TabIndex = 82
        Me.btnUbah.Text = "UBAH" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(521, 282)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(95, 40)
        Me.btnHapus.TabIndex = 81
        Me.btnHapus.Text = "HAPUS"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(672, 282)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(95, 40)
        Me.btnKeluar.TabIndex = 80
        Me.btnKeluar.Text = "KELUAR"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(230, 282)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(95, 40)
        Me.btnSimpan.TabIndex = 79
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(80, 282)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(95, 40)
        Me.btnTambah.TabIndex = 78
        Me.btnTambah.Text = "TAMBAH"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(330, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(168, 23)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "HARGA SEWA/HARI :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(330, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 23)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "MERK :"
        '
        'txtMerk
        '
        Me.txtMerk.Location = New System.Drawing.Point(334, 160)
        Me.txtMerk.Name = "txtMerk"
        Me.txtMerk.Size = New System.Drawing.Size(195, 22)
        Me.txtMerk.TabIndex = 75
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(76, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 23)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "NAMA MOBIL :"
        '
        'txtNamaMobil
        '
        Me.txtNamaMobil.Location = New System.Drawing.Point(80, 158)
        Me.txtNamaMobil.Name = "txtNamaMobil"
        Me.txtNamaMobil.Size = New System.Drawing.Size(219, 22)
        Me.txtNamaMobil.TabIndex = 71
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(556, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 23)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "PLAT NOMOR :"
        '
        'txtPlat
        '
        Me.txtPlat.Location = New System.Drawing.Point(560, 160)
        Me.txtPlat.Name = "txtPlat"
        Me.txtPlat.Size = New System.Drawing.Size(207, 22)
        Me.txtPlat.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(327, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 41)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "DATA MOBIL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(76, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 23)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "TAHUN :"
        '
        'txtTahun
        '
        Me.txtTahun.Location = New System.Drawing.Point(80, 223)
        Me.txtTahun.Name = "txtTahun"
        Me.txtTahun.Size = New System.Drawing.Size(219, 22)
        Me.txtTahun.TabIndex = 88
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(556, 197)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 23)
        Me.Label9.TabIndex = 91
        Me.Label9.Text = "STATUS :"
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(334, 223)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(195, 22)
        Me.txtHarga.TabIndex = 90
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(656, 371)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(111, 25)
        Me.btnRefresh.TabIndex = 92
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(852, 766)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTahun)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbStatus)
        Me.Controls.Add(Me.DGVDataMobil)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtMerk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNamaMobil)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPlat)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form5"
        CType(Me.DGVDataMobil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents DGVDataMobil As DataGridView
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMerk As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNamaMobil As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPlat As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTahun As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents btnRefresh As Button
End Class
