<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.DGVDataPelanggan = New System.Windows.Forms.DataGridView()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNoHP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKTP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbJenis = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        CType(Me.DGVDataPelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVDataPelanggan
        '
        Me.DGVDataPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDataPelanggan.Location = New System.Drawing.Point(97, 450)
        Me.DGVDataPelanggan.Name = "DGVDataPelanggan"
        Me.DGVDataPelanggan.RowHeadersWidth = 51
        Me.DGVDataPelanggan.RowTemplate.Height = 24
        Me.DGVDataPelanggan.Size = New System.Drawing.Size(687, 286)
        Me.DGVDataPelanggan.TabIndex = 63
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(393, 307)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(95, 40)
        Me.btnUbah.TabIndex = 62
        Me.btnUbah.Text = "UBAH" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(538, 307)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(95, 40)
        Me.btnHapus.TabIndex = 61
        Me.btnHapus.Text = "HAPUS"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(689, 307)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(95, 40)
        Me.btnKeluar.TabIndex = 60
        Me.btnKeluar.Text = "KELUAR"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(247, 307)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(95, 40)
        Me.btnSimpan.TabIndex = 59
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(97, 307)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(95, 40)
        Me.btnTambah.TabIndex = 58
        Me.btnTambah.Text = "TAMBAH"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(295, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 23)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "NO HP :"
        '
        'txtNoHP
        '
        Me.txtNoHP.Location = New System.Drawing.Point(299, 183)
        Me.txtNoHP.Name = "txtNoHP"
        Me.txtNoHP.Size = New System.Drawing.Size(180, 22)
        Me.txtNoHP.TabIndex = 55
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(496, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 23)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "ALAMAT :"
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(500, 183)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAlamat.Size = New System.Drawing.Size(284, 90)
        Me.txtAlamat.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(93, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 23)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "NO KTP :"
        '
        'txtKTP
        '
        Me.txtKTP.Location = New System.Drawing.Point(97, 183)
        Me.txtKTP.Name = "txtKTP"
        Me.txtKTP.Size = New System.Drawing.Size(180, 22)
        Me.txtKTP.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(93, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 23)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "NAMA PELANGGAN :"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(97, 248)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(180, 22)
        Me.txtNama.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(310, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 41)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "DATA PELANGGAN"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(295, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 23)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "JENIS KELAMIN :"
        '
        'cbJenis
        '
        Me.cbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbJenis.FormattingEnabled = True
        Me.cbJenis.Location = New System.Drawing.Point(299, 246)
        Me.cbJenis.Name = "cbJenis"
        Me.cbJenis.Size = New System.Drawing.Size(180, 24)
        Me.cbJenis.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(319, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 23)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Car Rental Management System"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(673, 395)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(111, 25)
        Me.btnRefresh.TabIndex = 95
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(93, 372)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(213, 23)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "CARI NAMA PELANGGAN :"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(97, 398)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(552, 22)
        Me.txtCari.TabIndex = 93
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(880, 783)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbJenis)
        Me.Controls.Add(Me.DGVDataPelanggan)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNoHP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtKTP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Data Pelanggan"
        CType(Me.DGVDataPelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVDataPelanggan As DataGridView
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNoHP As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtKTP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbJenis As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCari As TextBox
End Class
