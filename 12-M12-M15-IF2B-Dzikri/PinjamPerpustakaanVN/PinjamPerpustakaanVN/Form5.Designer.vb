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
        Me.DGVPinjam = New System.Windows.Forms.DataGridView()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKodePinjam = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIDAnggota = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNamaAnggota = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNoTelp = New System.Windows.Forms.TextBox()
        Me.DTPinjam = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DGVPinjam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVPinjam
        '
        Me.DGVPinjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPinjam.Location = New System.Drawing.Point(56, 300)
        Me.DGVPinjam.Name = "DGVPinjam"
        Me.DGVPinjam.RowHeadersWidth = 51
        Me.DGVPinjam.RowTemplate.Height = 24
        Me.DGVPinjam.Size = New System.Drawing.Size(415, 315)
        Me.DGVPinjam.TabIndex = 60
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(477, 568)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(95, 47)
        Me.btnKeluar.TabIndex = 54
        Me.btnKeluar.Text = "KELUAR"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(477, 442)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(95, 47)
        Me.btnSimpan.TabIndex = 50
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Kode Pinjam"
        '
        'txtKodePinjam
        '
        Me.txtKodePinjam.Location = New System.Drawing.Point(56, 110)
        Me.txtKodePinjam.Name = "txtKodePinjam"
        Me.txtKodePinjam.Size = New System.Drawing.Size(230, 22)
        Me.txtKodePinjam.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(150, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 41)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "PEMINJAMAN BUKU"
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(477, 309)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(95, 47)
        Me.btnTambah.TabIndex = 44
        Me.btnTambah.Text = "TAMBAH"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(306, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "ID Anggota"
        '
        'txtIDAnggota
        '
        Me.txtIDAnggota.Location = New System.Drawing.Point(309, 110)
        Me.txtIDAnggota.Name = "txtIDAnggota"
        Me.txtIDAnggota.Size = New System.Drawing.Size(263, 22)
        Me.txtIDAnggota.TabIndex = 62
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 16)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Nama Anggota"
        '
        'txtNamaAnggota
        '
        Me.txtNamaAnggota.Location = New System.Drawing.Point(56, 237)
        Me.txtNamaAnggota.Name = "txtNamaAnggota"
        Me.txtNamaAnggota.Size = New System.Drawing.Size(516, 22)
        Me.txtNamaAnggota.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(306, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 16)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Telepon"
        '
        'txtNoTelp
        '
        Me.txtNoTelp.Location = New System.Drawing.Point(309, 172)
        Me.txtNoTelp.Name = "txtNoTelp"
        Me.txtNoTelp.Size = New System.Drawing.Size(263, 22)
        Me.txtNoTelp.TabIndex = 66
        '
        'DTPinjam
        '
        Me.DTPinjam.Location = New System.Drawing.Point(56, 170)
        Me.DTPinjam.Name = "DTPinjam"
        Me.DTPinjam.Size = New System.Drawing.Size(230, 22)
        Me.DTPinjam.TabIndex = 68
        Me.DTPinjam.Value = New Date(2025, 6, 5, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(53, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 16)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Tanggal pinjam"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(607, 651)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DTPinjam)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNoTelp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNamaAnggota)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIDAnggota)
        Me.Controls.Add(Me.DGVPinjam)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtKodePinjam)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTambah)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPeminjaman"
        CType(Me.DGVPinjam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVPinjam As DataGridView
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtKodePinjam As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIDAnggota As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNamaAnggota As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNoTelp As TextBox
    Friend WithEvents DTPinjam As DateTimePicker
    Friend WithEvents Label6 As Label
End Class
