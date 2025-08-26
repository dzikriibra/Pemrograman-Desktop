<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.dtpJatuhTempo = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpSewa = New System.Windows.Forms.DateTimePicker()
        Me.DGVPengembalian = New System.Windows.Forms.DataGridView()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDenda = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTotalBayar = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.txtNamaMobil = New System.Windows.Forms.TextBox()
        Me.txtNamaPelanggan = New System.Windows.Forms.TextBox()
        CType(Me.DGVPengembalian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpJatuhTempo
        '
        Me.dtpJatuhTempo.Location = New System.Drawing.Point(435, 569)
        Me.dtpJatuhTempo.Name = "dtpJatuhTempo"
        Me.dtpJatuhTempo.Size = New System.Drawing.Size(260, 22)
        Me.dtpJatuhTempo.TabIndex = 93
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(431, 545)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(273, 23)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "TANGGAL SEHARUSNYA KEMBALI :"
        '
        'dtpSewa
        '
        Me.dtpSewa.Location = New System.Drawing.Point(436, 502)
        Me.dtpSewa.Name = "dtpSewa"
        Me.dtpSewa.Size = New System.Drawing.Size(260, 22)
        Me.dtpSewa.TabIndex = 89
        '
        'DGVPengembalian
        '
        Me.DGVPengembalian.AllowUserToAddRows = False
        Me.DGVPengembalian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPengembalian.Location = New System.Drawing.Point(84, 126)
        Me.DGVPengembalian.Name = "DGVPengembalian"
        Me.DGVPengembalian.ReadOnly = True
        Me.DGVPengembalian.RowHeadersWidth = 51
        Me.DGVPengembalian.RowTemplate.Height = 24
        Me.DGVPengembalian.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVPengembalian.Size = New System.Drawing.Size(611, 255)
        Me.DGVPengembalian.TabIndex = 86
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(587, 695)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(108, 54)
        Me.btnKeluar.TabIndex = 83
        Me.btnKeluar.Text = "KELUAR"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(436, 695)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(105, 52)
        Me.btnSimpan.TabIndex = 82
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(432, 478)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 23)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "TANGGAL SEWA :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(81, 617)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 23)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "NAMA MOBIL :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(81, 543)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 23)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "NAMA PELANGGAN :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(81, 478)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 23)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "ID TRANSAKSI :"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(85, 504)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(297, 22)
        Me.txtID.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(171, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(447, 41)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "PENGEMBALIAN KENDARAAN"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(262, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(260, 23)
        Me.Label10.TabIndex = 94
        Me.Label10.Text = "Car Rental Management System"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(431, 617)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 23)
        Me.Label8.TabIndex = 98
        Me.Label8.Text = "DENDA :"
        '
        'txtDenda
        '
        Me.txtDenda.Location = New System.Drawing.Point(435, 643)
        Me.txtDenda.Name = "txtDenda"
        Me.txtDenda.Size = New System.Drawing.Size(260, 22)
        Me.txtDenda.TabIndex = 97
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(80, 695)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(177, 23)
        Me.Label12.TabIndex = 102
        Me.Label12.Text = "TOTAL SELURUHNYA :"
        '
        'txtTotalBayar
        '
        Me.txtTotalBayar.Location = New System.Drawing.Point(84, 721)
        Me.txtTotalBayar.Name = "txtTotalBayar"
        Me.txtTotalBayar.Size = New System.Drawing.Size(297, 22)
        Me.txtTotalBayar.TabIndex = 101
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(564, 426)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(131, 32)
        Me.btnRefresh.TabIndex = 105
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(81, 408)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(207, 23)
        Me.Label7.TabIndex = 104
        Me.Label7.Text = "CARI DATA PELANGGAN :"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(85, 431)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(455, 22)
        Me.txtCari.TabIndex = 103
        '
        'txtNamaMobil
        '
        Me.txtNamaMobil.Location = New System.Drawing.Point(85, 643)
        Me.txtNamaMobil.Name = "txtNamaMobil"
        Me.txtNamaMobil.Size = New System.Drawing.Size(297, 22)
        Me.txtNamaMobil.TabIndex = 106
        '
        'txtNamaPelanggan
        '
        Me.txtNamaPelanggan.Location = New System.Drawing.Point(84, 569)
        Me.txtNamaPelanggan.Name = "txtNamaPelanggan"
        Me.txtNamaPelanggan.Size = New System.Drawing.Size(297, 22)
        Me.txtNamaPelanggan.TabIndex = 107
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(788, 782)
        Me.Controls.Add(Me.txtNamaPelanggan)
        Me.Controls.Add(Me.txtNamaMobil)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtTotalBayar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDenda)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtpJatuhTempo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtpSewa)
        Me.Controls.Add(Me.DGVPengembalian)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form8"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form8"
        CType(Me.DGVPengembalian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpJatuhTempo As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpSewa As DateTimePicker
    Friend WithEvents DGVPengembalian As DataGridView
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDenda As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTotalBayar As TextBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents txtNamaMobil As TextBox
    Friend WithEvents txtNamaPelanggan As TextBox
End Class
