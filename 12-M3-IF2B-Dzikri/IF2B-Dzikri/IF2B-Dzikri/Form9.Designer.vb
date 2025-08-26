<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDataPegawai
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
        Label1 = New Label()
        TextNIP = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        TextNama = New TextBox()
        Label4 = New Label()
        TextTmptLahir = New TextBox()
        TextJabatan = New ComboBox()
        TextTglLahir = New DateTimePicker()
        Label5 = New Label()
        Label6 = New Label()
        btnHitung = New Button()
        TextGajiPokok = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        TextTunjangan = New TextBox()
        TextPotongan = New TextBox()
        Label10 = New Label()
        TextBulan = New ComboBox()
        Label11 = New Label()
        TextPajak = New TextBox()
        TextHariKerja = New TextBox()
        TextGajiBersih = New TextBox()
        TextSakit = New TextBox()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        TextTnpaKet = New TextBox()
        TextIzin = New TextBox()
        Label16 = New Label()
        Label17 = New Label()
        btnTambah = New Button()
        btnHapus = New Button()
        btnKeluar = New Button()
        groupKalkulasiGaji = New GroupBox()
        groupKalkulasiGaji.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(285, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(225, 23)
        Label1.TabIndex = 0
        Label1.Text = "FORM DATA KEPEGAWAIAN"
        ' 
        ' TextNIP
        ' 
        TextNIP.Location = New Point(146, 90)
        TextNIP.Name = "TextNIP"
        TextNIP.Size = New Size(179, 27)
        TextNIP.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(71, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 23)
        Label2.TabIndex = 2
        Label2.Text = "NIP"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(49, 141)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 23)
        Label3.TabIndex = 3
        Label3.Text = "NAMA"
        ' 
        ' TextNama
        ' 
        TextNama.Location = New Point(146, 137)
        TextNama.Name = "TextNama"
        TextNama.Size = New Size(179, 27)
        TextNama.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(30, 194)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 23)
        Label4.TabIndex = 5
        Label4.Text = "JABATAN"
        ' 
        ' TextTmptLahir
        ' 
        TextTmptLahir.Location = New Point(531, 141)
        TextTmptLahir.Name = "TextTmptLahir"
        TextTmptLahir.Size = New Size(210, 27)
        TextTmptLahir.TabIndex = 6
        ' 
        ' TextJabatan
        ' 
        TextJabatan.FormattingEnabled = True
        TextJabatan.Location = New Point(146, 189)
        TextJabatan.Name = "TextJabatan"
        TextJabatan.Size = New Size(232, 28)
        TextJabatan.TabIndex = 7
        ' 
        ' TextTglLahir
        ' 
        TextTglLahir.Location = New Point(531, 90)
        TextTglLahir.Name = "TextTglLahir"
        TextTglLahir.Size = New Size(210, 27)
        TextTglLahir.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(361, 94)
        Label5.Name = "Label5"
        Label5.Size = New Size(136, 23)
        Label5.TabIndex = 9
        Label5.Text = "TANGGAL LAHIR"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(375, 141)
        Label6.Name = "Label6"
        Label6.Size = New Size(122, 23)
        Label6.TabIndex = 10
        Label6.Text = "TEMPAT LAHIR"
        ' 
        ' btnHitung
        ' 
        btnHitung.FlatStyle = FlatStyle.Flat
        btnHitung.Location = New Point(531, 178)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(210, 39)
        btnHitung.TabIndex = 11
        btnHitung.Text = "HITUNG GAJI"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' TextGajiPokok
        ' 
        TextGajiPokok.Enabled = False
        TextGajiPokok.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextGajiPokok.Location = New Point(160, 47)
        TextGajiPokok.Name = "TextGajiPokok"
        TextGajiPokok.Size = New Size(179, 27)
        TextGajiPokok.TabIndex = 14
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(37, 47)
        Label8.Name = "Label8"
        Label8.Size = New Size(90, 20)
        Label8.TabIndex = 15
        Label8.Text = "GAJI POKOK"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(412, 55)
        Label9.Name = "Label9"
        Label9.Size = New Size(95, 20)
        Label9.TabIndex = 16
        Label9.Text = "TUNJANGAN"
        ' 
        ' TextTunjangan
        ' 
        TextTunjangan.Enabled = False
        TextTunjangan.Location = New Point(550, 47)
        TextTunjangan.Name = "TextTunjangan"
        TextTunjangan.Size = New Size(179, 30)
        TextTunjangan.TabIndex = 17
        ' 
        ' TextPotongan
        ' 
        TextPotongan.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextPotongan.Location = New Point(550, 100)
        TextPotongan.Name = "TextPotongan"
        TextPotongan.Size = New Size(179, 30)
        TextPotongan.TabIndex = 18
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(421, 103)
        Label10.Name = "Label10"
        Label10.Size = New Size(91, 20)
        Label10.TabIndex = 19
        Label10.Text = " POTONGAN"
        ' 
        ' TextBulan
        ' 
        TextBulan.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBulan.FormattingEnabled = True
        TextBulan.Location = New Point(160, 97)
        TextBulan.Name = "TextBulan"
        TextBulan.Size = New Size(179, 31)
        TextBulan.TabIndex = 20
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(67, 100)
        Label11.Name = "Label11"
        Label11.Size = New Size(60, 20)
        Label11.TabIndex = 21
        Label11.Text = " BULAN"
        ' 
        ' TextPajak
        ' 
        TextPajak.Enabled = False
        TextPajak.Location = New Point(550, 154)
        TextPajak.Name = "TextPajak"
        TextPajak.Size = New Size(179, 30)
        TextPajak.TabIndex = 22
        ' 
        ' TextHariKerja
        ' 
        TextHariKerja.Enabled = False
        TextHariKerja.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextHariKerja.Location = New Point(160, 151)
        TextHariKerja.Name = "TextHariKerja"
        TextHariKerja.Size = New Size(179, 27)
        TextHariKerja.TabIndex = 23
        ' 
        ' TextGajiBersih
        ' 
        TextGajiBersih.Enabled = False
        TextGajiBersih.Location = New Point(550, 209)
        TextGajiBersih.Name = "TextGajiBersih"
        TextGajiBersih.Size = New Size(179, 30)
        TextGajiBersih.TabIndex = 24
        ' 
        ' TextSakit
        ' 
        TextSakit.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextSakit.Location = New Point(160, 203)
        TextSakit.Name = "TextSakit"
        TextSakit.Size = New Size(179, 30)
        TextSakit.TabIndex = 25
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(75, 209)
        Label12.Name = "Label12"
        Label12.Size = New Size(52, 20)
        Label12.TabIndex = 26
        Label12.Text = " SAKIT"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(461, 157)
        Label13.Name = "Label13"
        Label13.Size = New Size(51, 20)
        Label13.TabIndex = 27
        Label13.Text = "PAJAK"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(416, 212)
        Label14.Name = "Label14"
        Label14.Size = New Size(96, 20)
        Label14.TabIndex = 28
        Label14.Text = " GAJI BERSIH"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(35, 154)
        Label15.Name = "Label15"
        Label15.Size = New Size(92, 20)
        Label15.TabIndex = 29
        Label15.Text = " HARI KERJA"
        ' 
        ' TextTnpaKet
        ' 
        TextTnpaKet.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextTnpaKet.Location = New Point(160, 255)
        TextTnpaKet.Name = "TextTnpaKet"
        TextTnpaKet.Size = New Size(179, 30)
        TextTnpaKet.TabIndex = 30
        ' 
        ' TextIzin
        ' 
        TextIzin.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextIzin.Location = New Point(160, 309)
        TextIzin.Name = "TextIzin"
        TextIzin.Size = New Size(179, 30)
        TextIzin.TabIndex = 31
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(37, 258)
        Label16.Name = "Label16"
        Label16.Size = New Size(90, 20)
        Label16.TabIndex = 32
        Label16.Text = " TANPA KET."
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(75, 312)
        Label17.Name = "Label17"
        Label17.Size = New Size(41, 20)
        Label17.TabIndex = 33
        Label17.Text = " IZIN"
        ' 
        ' btnTambah
        ' 
        btnTambah.FlatStyle = FlatStyle.Flat
        btnTambah.Location = New Point(79, 626)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(151, 51)
        btnTambah.TabIndex = 34
        btnTambah.Text = " TAMBAH DATA / BATAL"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Location = New Point(310, 626)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(165, 51)
        btnHapus.TabIndex = 35
        btnHapus.Text = "HAPUS"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.FlatStyle = FlatStyle.Flat
        btnKeluar.Location = New Point(562, 626)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(159, 51)
        btnKeluar.TabIndex = 36
        btnKeluar.Text = " KELUAR"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' groupKalkulasiGaji
        ' 
        groupKalkulasiGaji.Controls.Add(Label8)
        groupKalkulasiGaji.Controls.Add(TextGajiPokok)
        groupKalkulasiGaji.Controls.Add(Label9)
        groupKalkulasiGaji.Controls.Add(TextTunjangan)
        groupKalkulasiGaji.Controls.Add(Label11)
        groupKalkulasiGaji.Controls.Add(Label17)
        groupKalkulasiGaji.Controls.Add(TextBulan)
        groupKalkulasiGaji.Controls.Add(TextIzin)
        groupKalkulasiGaji.Controls.Add(Label16)
        groupKalkulasiGaji.Controls.Add(Label10)
        groupKalkulasiGaji.Controls.Add(TextPotongan)
        groupKalkulasiGaji.Controls.Add(TextTnpaKet)
        groupKalkulasiGaji.Controls.Add(TextHariKerja)
        groupKalkulasiGaji.Controls.Add(TextGajiBersih)
        groupKalkulasiGaji.Controls.Add(Label14)
        groupKalkulasiGaji.Controls.Add(Label15)
        groupKalkulasiGaji.Controls.Add(TextSakit)
        groupKalkulasiGaji.Controls.Add(Label12)
        groupKalkulasiGaji.Controls.Add(Label13)
        groupKalkulasiGaji.Controls.Add(TextPajak)
        groupKalkulasiGaji.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        groupKalkulasiGaji.Location = New Point(12, 249)
        groupKalkulasiGaji.Name = "groupKalkulasiGaji"
        groupKalkulasiGaji.Size = New Size(776, 361)
        groupKalkulasiGaji.TabIndex = 38
        groupKalkulasiGaji.TabStop = False
        groupKalkulasiGaji.Text = "KALKULASI GAJI"
        ' 
        ' FrmDataPegawai
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = SystemColors.ScrollBar
        ClientSize = New Size(800, 689)
        Controls.Add(groupKalkulasiGaji)
        Controls.Add(btnKeluar)
        Controls.Add(btnHapus)
        Controls.Add(btnTambah)
        Controls.Add(btnHitung)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(TextTglLahir)
        Controls.Add(TextJabatan)
        Controls.Add(TextTmptLahir)
        Controls.Add(Label4)
        Controls.Add(TextNama)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextNIP)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "FrmDataPegawai"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Data Pegawai"
        groupKalkulasiGaji.ResumeLayout(False)
        groupKalkulasiGaji.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextNIP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextNama As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextTmptLahir As TextBox
    Friend WithEvents TextJabatan As ComboBox
    Friend WithEvents TextTglLahir As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents TextGajiPokok As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextTunjangan As TextBox
    Friend WithEvents TextPotongan As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBulan As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextPajak As TextBox
    Friend WithEvents TextHariKerja As TextBox
    Friend WithEvents TextGajiBersih As TextBox
    Friend WithEvents TextSakit As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TextTnpaKet As TextBox
    Friend WithEvents TextIzin As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents groupKalkulasiGaji As GroupBox
End Class
