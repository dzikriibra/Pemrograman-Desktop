<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNamaAnggota = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIDAnggota = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNoTelp = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DGVAnggota = New System.Windows.Forms.DataGridView()
        CType(Me.DGVAnggota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(145, 415)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(95, 47)
        Me.btnSimpan.TabIndex = 13
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Nama Anggota"
        '
        'txtNamaAnggota
        '
        Me.txtNamaAnggota.Location = New System.Drawing.Point(59, 180)
        Me.txtNamaAnggota.Name = "txtNamaAnggota"
        Me.txtNamaAnggota.Size = New System.Drawing.Size(301, 22)
        Me.txtNamaAnggota.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ID Anggota"
        '
        'txtIDAnggota
        '
        Me.txtIDAnggota.Location = New System.Drawing.Point(59, 124)
        Me.txtIDAnggota.Name = "txtIDAnggota"
        Me.txtIDAnggota.Size = New System.Drawing.Size(216, 22)
        Me.txtIDAnggota.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(491, 41)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "DATA ANGGOTA PERPUSTAKAAN"
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(44, 415)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(95, 47)
        Me.btnTambah.TabIndex = 7
        Me.btnTambah.Text = "TAMBAH"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 347)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Telepon"
        '
        'txtNoTelp
        '
        Me.txtNoTelp.Location = New System.Drawing.Point(59, 366)
        Me.txtNoTelp.Name = "txtNoTelp"
        Me.txtNoTelp.Size = New System.Drawing.Size(239, 22)
        Me.txtNoTelp.TabIndex = 14
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(59, 236)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(484, 96)
        Me.txtAlamat.TabIndex = 16
        Me.txtAlamat.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Alamat"
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(448, 415)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(95, 47)
        Me.btnKeluar.TabIndex = 18
        Me.btnKeluar.Text = "KELUAR"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(347, 415)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(95, 47)
        Me.btnHapus.TabIndex = 19
        Me.btnHapus.Text = "HAPUS"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(246, 415)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(95, 47)
        Me.btnUbah.TabIndex = 20
        Me.btnUbah.Text = "UBAH" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(59, 504)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(301, 22)
        Me.txtCari.TabIndex = 21
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(384, 502)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(139, 24)
        Me.btnRefresh.TabIndex = 22
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 485)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Cari ID Anggota"
        '
        'DGVAnggota
        '
        Me.DGVAnggota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAnggota.Location = New System.Drawing.Point(59, 542)
        Me.DGVAnggota.Name = "DGVAnggota"
        Me.DGVAnggota.RowHeadersWidth = 51
        Me.DGVAnggota.RowTemplate.Height = 24
        Me.DGVAnggota.Size = New System.Drawing.Size(484, 200)
        Me.DGVAnggota.TabIndex = 24
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(603, 784)
        Me.Controls.Add(Me.DGVAnggota)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNoTelp)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNamaAnggota)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIDAnggota)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTambah)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmDataAnggota"
        CType(Me.DGVAnggota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSimpan As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNamaAnggota As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIDAnggota As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNoTelp As TextBox
    Friend WithEvents txtAlamat As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents DGVAnggota As DataGridView
End Class
