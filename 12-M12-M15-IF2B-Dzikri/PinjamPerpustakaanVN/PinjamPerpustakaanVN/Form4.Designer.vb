<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKodeBuku = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtJudulBuku = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.txtPenerbit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGVBuku = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPengarang = New System.Windows.Forms.TextBox()
        CType(Me.DGVBuku, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(49, 337)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(95, 47)
        Me.btnTambah.TabIndex = 25
        Me.btnTambah.Text = "TAMBAH"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(209, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 41)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "DATA BUKU"
        '
        'txtKodeBuku
        '
        Me.txtKodeBuku.Location = New System.Drawing.Point(64, 118)
        Me.txtKodeBuku.Name = "txtKodeBuku"
        Me.txtKodeBuku.Size = New System.Drawing.Size(216, 22)
        Me.txtKodeBuku.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Kode Buku"
        '
        'txtJudulBuku
        '
        Me.txtJudulBuku.Location = New System.Drawing.Point(64, 174)
        Me.txtJudulBuku.Name = "txtJudulBuku"
        Me.txtJudulBuku.Size = New System.Drawing.Size(322, 22)
        Me.txtJudulBuku.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Judul buku"
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(150, 337)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(95, 47)
        Me.btnSimpan.TabIndex = 31
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'txtPenerbit
        '
        Me.txtPenerbit.Location = New System.Drawing.Point(64, 290)
        Me.txtPenerbit.Name = "txtPenerbit"
        Me.txtPenerbit.Size = New System.Drawing.Size(239, 22)
        Me.txtPenerbit.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Penerbit"
        '
        'DGVBuku
        '
        Me.DGVBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVBuku.Location = New System.Drawing.Point(64, 464)
        Me.DGVBuku.Name = "DGVBuku"
        Me.DGVBuku.RowHeadersWidth = 51
        Me.DGVBuku.RowTemplate.Height = 24
        Me.DGVBuku.Size = New System.Drawing.Size(484, 214)
        Me.DGVBuku.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 16)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Pengarang"
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(453, 337)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(95, 47)
        Me.btnKeluar.TabIndex = 36
        Me.btnKeluar.Text = "KELUAR"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(352, 337)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(95, 47)
        Me.btnHapus.TabIndex = 37
        Me.btnHapus.Text = "HAPUS"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(251, 337)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(95, 47)
        Me.btnUbah.TabIndex = 38
        Me.btnUbah.Text = "UBAH" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(64, 426)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(301, 22)
        Me.txtCari.TabIndex = 39
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(389, 424)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(139, 24)
        Me.btnRefresh.TabIndex = 40
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(61, 407)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 16)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Cari Kode Buku"
        '
        'txtPengarang
        '
        Me.txtPengarang.Location = New System.Drawing.Point(64, 230)
        Me.txtPengarang.Name = "txtPengarang"
        Me.txtPengarang.Size = New System.Drawing.Size(282, 22)
        Me.txtPengarang.TabIndex = 43
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(600, 711)
        Me.Controls.Add(Me.txtPengarang)
        Me.Controls.Add(Me.DGVBuku)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPenerbit)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtJudulBuku)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtKodeBuku)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTambah)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        CType(Me.DGVBuku, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTambah As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtKodeBuku As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtJudulBuku As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents txtPenerbit As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DGVBuku As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPengarang As TextBox
End Class
