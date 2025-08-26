<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.cbPelanggan = New System.Windows.Forms.ComboBox()
        Me.DGVSewaKendaraan = New System.Windows.Forms.DataGridView()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbMobil = New System.Windows.Forms.ComboBox()
        Me.dtpSewa = New System.Windows.Forms.DateTimePicker()
        Me.txtLamaSewa = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpKembali = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPlat = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        CType(Me.DGVSewaKendaraan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbPelanggan
        '
        Me.cbPelanggan.FormattingEnabled = True
        Me.cbPelanggan.Location = New System.Drawing.Point(100, 171)
        Me.cbPelanggan.Name = "cbPelanggan"
        Me.cbPelanggan.Size = New System.Drawing.Size(297, 24)
        Me.cbPelanggan.TabIndex = 64
        '
        'DGVSewaKendaraan
        '
        Me.DGVSewaKendaraan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSewaKendaraan.Location = New System.Drawing.Point(100, 548)
        Me.DGVSewaKendaraan.Name = "DGVSewaKendaraan"
        Me.DGVSewaKendaraan.RowHeadersWidth = 51
        Me.DGVSewaKendaraan.RowTemplate.Height = 24
        Me.DGVSewaKendaraan.Size = New System.Drawing.Size(611, 255)
        Me.DGVSewaKendaraan.TabIndex = 63
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(616, 472)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(95, 46)
        Me.btnKeluar.TabIndex = 60
        Me.btnKeluar.Text = "KELUAR"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(227, 472)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(95, 46)
        Me.btnSimpan.TabIndex = 59
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(100, 472)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(95, 46)
        Me.btnTambah.TabIndex = 58
        Me.btnTambah.Text = "TAMBAH"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(447, 372)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 23)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "TOTAL HARGA :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(447, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 23)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "TANGGAL SEWA :"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(451, 398)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(260, 22)
        Me.txtTotal.TabIndex = 55
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(96, 371)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 23)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "HARGA SEWA/HARI :"
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(100, 397)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.ReadOnly = True
        Me.txtHarga.Size = New System.Drawing.Size(299, 22)
        Me.txtHarga.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(96, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 23)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "NAMA MOBIL :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(96, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 23)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "NAMA PELANGGAN :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(280, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 41)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "SEWA KENDARAAN"
        '
        'cbMobil
        '
        Me.cbMobil.FormattingEnabled = True
        Me.cbMobil.Location = New System.Drawing.Point(100, 243)
        Me.cbMobil.Name = "cbMobil"
        Me.cbMobil.Size = New System.Drawing.Size(297, 24)
        Me.cbMobil.TabIndex = 65
        '
        'dtpSewa
        '
        Me.dtpSewa.Location = New System.Drawing.Point(451, 171)
        Me.dtpSewa.Name = "dtpSewa"
        Me.dtpSewa.Size = New System.Drawing.Size(260, 22)
        Me.dtpSewa.TabIndex = 66
        '
        'txtLamaSewa
        '
        Me.txtLamaSewa.Location = New System.Drawing.Point(100, 319)
        Me.txtLamaSewa.Name = "txtLamaSewa"
        Me.txtLamaSewa.Size = New System.Drawing.Size(299, 22)
        Me.txtLamaSewa.TabIndex = 67
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(96, 295)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(164, 23)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "LAMA SEWA (HARI) :"
        '
        'dtpKembali
        '
        Me.dtpKembali.Location = New System.Drawing.Point(451, 245)
        Me.dtpKembali.Name = "dtpKembali"
        Me.dtpKembali.Size = New System.Drawing.Size(260, 22)
        Me.dtpKembali.TabIndex = 70
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(447, 221)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(166, 23)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "TANGGAL KEMBALI :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(447, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 23)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "PLAT NOMOR :"
        '
        'txtPlat
        '
        Me.txtPlat.Location = New System.Drawing.Point(451, 319)
        Me.txtPlat.Name = "txtPlat"
        Me.txtPlat.ReadOnly = True
        Me.txtPlat.Size = New System.Drawing.Size(260, 22)
        Me.txtPlat.TabIndex = 71
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(295, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(260, 23)
        Me.Label10.TabIndex = 86
        Me.Label10.Text = "Car Rental Management System"
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(355, 472)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(95, 46)
        Me.btnUbah.TabIndex = 62
        Me.btnUbah.Text = "UBAH" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(486, 472)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(95, 46)
        Me.btnHapus.TabIndex = 61
        Me.btnHapus.Text = "HAPUS"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(820, 838)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPlat)
        Me.Controls.Add(Me.dtpKembali)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtLamaSewa)
        Me.Controls.Add(Me.dtpSewa)
        Me.Controls.Add(Me.cbMobil)
        Me.Controls.Add(Me.cbPelanggan)
        Me.Controls.Add(Me.DGVSewaKendaraan)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form7"
        CType(Me.DGVSewaKendaraan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbPelanggan As ComboBox
    Friend WithEvents DGVSewaKendaraan As DataGridView
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbMobil As ComboBox
    Friend WithEvents dtpSewa As DateTimePicker
    Friend WithEvents txtLamaSewa As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpKembali As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPlat As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
End Class
