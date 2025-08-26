<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FIleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiSewaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiPengembalianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CetakToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataMobilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataTransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AKUNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KELUARToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FIleToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.CetakToolStripMenuItem, Me.AKUNToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1317, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FIleToolStripMenuItem
        '
        Me.FIleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.FIleToolStripMenuItem.Name = "FIleToolStripMenuItem"
        Me.FIleToolStripMenuItem.Size = New System.Drawing.Size(145, 24)
        Me.FIleToolStripMenuItem.Text = "🗂️ MASTER DATA"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.LoginToolStripMenuItem.Text = "🛻 DATA MOBIL"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.KeluarToolStripMenuItem.Text = "🧑‍🔧 DATA PELANGGAN"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransaksiSewaToolStripMenuItem, Me.TransaksiPengembalianToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(125, 24)
        Me.TransaksiToolStripMenuItem.Text = "🔁 TRANSAKSI"
        '
        'TransaksiSewaToolStripMenuItem
        '
        Me.TransaksiSewaToolStripMenuItem.Name = "TransaksiSewaToolStripMenuItem"
        Me.TransaksiSewaToolStripMenuItem.Size = New System.Drawing.Size(249, 26)
        Me.TransaksiSewaToolStripMenuItem.Text = "🛻 SEWA KENDARAAN"
        '
        'TransaksiPengembalianToolStripMenuItem
        '
        Me.TransaksiPengembalianToolStripMenuItem.Name = "TransaksiPengembalianToolStripMenuItem"
        Me.TransaksiPengembalianToolStripMenuItem.Size = New System.Drawing.Size(249, 26)
        Me.TransaksiPengembalianToolStripMenuItem.Text = "🧾 PENGEMBALIAN"
        '
        'CetakToolStripMenuItem
        '
        Me.CetakToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataMobilToolStripMenuItem, Me.DataPelangganToolStripMenuItem, Me.DataTransaksiToolStripMenuItem})
        Me.CetakToolStripMenuItem.Name = "CetakToolStripMenuItem"
        Me.CetakToolStripMenuItem.Size = New System.Drawing.Size(114, 24)
        Me.CetakToolStripMenuItem.Text = "📄 LAPORAN"
        '
        'DataMobilToolStripMenuItem
        '
        Me.DataMobilToolStripMenuItem.Name = "DataMobilToolStripMenuItem"
        Me.DataMobilToolStripMenuItem.Size = New System.Drawing.Size(272, 26)
        Me.DataMobilToolStripMenuItem.Text = "🛻 LAPORAN MOBIL"
        '
        'DataPelangganToolStripMenuItem
        '
        Me.DataPelangganToolStripMenuItem.Name = "DataPelangganToolStripMenuItem"
        Me.DataPelangganToolStripMenuItem.Size = New System.Drawing.Size(272, 26)
        Me.DataPelangganToolStripMenuItem.Text = "🧑‍🔧 LAPORAN PELANGGAN"
        '
        'DataTransaksiToolStripMenuItem
        '
        Me.DataTransaksiToolStripMenuItem.Name = "DataTransaksiToolStripMenuItem"
        Me.DataTransaksiToolStripMenuItem.Size = New System.Drawing.Size(272, 26)
        Me.DataTransaksiToolStripMenuItem.Text = "📊 LAPORAN TRANSAKSI"
        '
        'AKUNToolStripMenuItem
        '
        Me.AKUNToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LOGOUTToolStripMenuItem, Me.KELUARToolStripMenuItem1})
        Me.AKUNToolStripMenuItem.Name = "AKUNToolStripMenuItem"
        Me.AKUNToolStripMenuItem.Size = New System.Drawing.Size(88, 24)
        Me.AKUNToolStripMenuItem.Text = "👤 AKUN"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(173, 26)
        Me.LOGOUTToolStripMenuItem.Text = "🔒 LOGOUT"
        '
        'KELUARToolStripMenuItem1
        '
        Me.KELUARToolStripMenuItem1.Name = "KELUARToolStripMenuItem1"
        Me.KELUARToolStripMenuItem1.Size = New System.Drawing.Size(173, 26)
        Me.KELUARToolStripMenuItem1.Text = "↩️ KELUAR"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(162, 146)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1031, 286)
        Me.Panel1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Algerian", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1004, 95)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "WHEATSTONE GARAGE"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Font = New System.Drawing.Font("Algerian", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(132, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(691, 31)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Your Trusted Car Rental System"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 67)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = " 🏎️ "
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Algerian", 28.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(406, 48)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "WELCOME TO"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1317, 693)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FIleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiSewaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiPengembalianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CetakToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataMobilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataPelangganToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataTransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AKUNToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KELUARToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
End Class
