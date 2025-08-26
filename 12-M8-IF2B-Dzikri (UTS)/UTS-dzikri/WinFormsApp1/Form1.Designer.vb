<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        TxtNIM = New TextBox()
        ComboBoxJurusan = New ComboBox()
        BtnSimpan = New Button()
        RadioButton1 = New RadioButton()
        TxtNama = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        BtnHapus = New Button()
        Label5 = New Label()
        RadioButton2 = New RadioButton()
        LabelNIM = New Label()
        LabelRupiah = New Label()
        LabelStat = New Label()
        LabelJur = New Label()
        LabelNama = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(94, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(296, 38)
        Label1.TabIndex = 0
        Label1.Text = "BIODATA MAHASISWA"
        ' 
        ' TxtNIM
        ' 
        TxtNIM.Location = New Point(226, 107)
        TxtNIM.Name = "TxtNIM"
        TxtNIM.Size = New Size(151, 27)
        TxtNIM.TabIndex = 1
        ' 
        ' ComboBoxJurusan
        ' 
        ComboBoxJurusan.FormattingEnabled = True
        ComboBoxJurusan.Items.AddRange(New Object() {"Teknik Informatika", "Teknik Elektro", "Teknik Sipil", "Teknik Mesin", "Teknik Dirgantara", "Teknik Kimia", "Teknik Lingkungan", "Teknik Industri"})
        ComboBoxJurusan.Location = New Point(226, 214)
        ComboBoxJurusan.Name = "ComboBoxJurusan"
        ComboBoxJurusan.Size = New Size(151, 28)
        ComboBoxJurusan.TabIndex = 2
        ' 
        ' BtnSimpan
        ' 
        BtnSimpan.Location = New Point(94, 343)
        BtnSimpan.Name = "BtnSimpan"
        BtnSimpan.Size = New Size(94, 29)
        BtnSimpan.TabIndex = 3
        BtnSimpan.Text = "Simpan"
        BtnSimpan.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(228, 266)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(61, 24)
        RadioButton1.TabIndex = 4
        RadioButton1.TabStop = True
        RadioButton1.Text = "Aktif"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' TxtNama
        ' 
        TxtNama.Location = New Point(226, 158)
        TxtNama.Name = "TxtNama"
        TxtNama.Size = New Size(151, 27)
        TxtNama.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(93, 162)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 23)
        Label2.TabIndex = 6
        Label2.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(106, 107)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 23)
        Label3.TabIndex = 7
        Label3.Text = "NIM"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(81, 219)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 23)
        Label4.TabIndex = 8
        Label4.Text = "Jurusan"
        ' 
        ' BtnHapus
        ' 
        BtnHapus.Location = New Point(255, 343)
        BtnHapus.Name = "BtnHapus"
        BtnHapus.Size = New Size(94, 29)
        BtnHapus.TabIndex = 9
        BtnHapus.Text = "Hapus"
        BtnHapus.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(93, 267)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 23)
        Label5.TabIndex = 10
        Label5.Text = "Status"
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(226, 296)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(56, 24)
        RadioButton2.TabIndex = 11
        RadioButton2.TabStop = True
        RadioButton2.Text = "Cuti"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' LabelNIM
        ' 
        LabelNIM.AutoSize = True
        LabelNIM.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelNIM.Location = New Point(106, 432)
        LabelNIM.Name = "LabelNIM"
        LabelNIM.Size = New Size(43, 23)
        LabelNIM.TabIndex = 12
        LabelNIM.Text = "NIM"
        ' 
        ' LabelRupiah
        ' 
        LabelRupiah.AutoSize = True
        LabelRupiah.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelRupiah.Location = New Point(106, 569)
        LabelRupiah.Name = "LabelRupiah"
        LabelRupiah.Size = New Size(34, 23)
        LabelRupiah.TabIndex = 13
        LabelRupiah.Text = "Rp."
        ' 
        ' LabelStat
        ' 
        LabelStat.AutoSize = True
        LabelStat.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelStat.Location = New Point(106, 535)
        LabelStat.Name = "LabelStat"
        LabelStat.Size = New Size(56, 23)
        LabelStat.TabIndex = 14
        LabelStat.Text = "Status"
        ' 
        ' LabelJur
        ' 
        LabelJur.AutoSize = True
        LabelJur.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelJur.Location = New Point(106, 501)
        LabelJur.Name = "LabelJur"
        LabelJur.Size = New Size(68, 23)
        LabelJur.TabIndex = 15
        LabelJur.Text = "Jurusan"
        ' 
        ' LabelNama
        ' 
        LabelNama.AutoSize = True
        LabelNama.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelNama.Location = New Point(106, 466)
        LabelNama.Name = "LabelNama"
        LabelNama.Size = New Size(56, 23)
        LabelNama.TabIndex = 16
        LabelNama.Text = "Nama"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(493, 636)
        Controls.Add(LabelNama)
        Controls.Add(LabelJur)
        Controls.Add(LabelStat)
        Controls.Add(LabelRupiah)
        Controls.Add(LabelNIM)
        Controls.Add(RadioButton2)
        Controls.Add(Label5)
        Controls.Add(BtnHapus)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TxtNama)
        Controls.Add(RadioButton1)
        Controls.Add(BtnSimpan)
        Controls.Add(ComboBoxJurusan)
        Controls.Add(TxtNIM)
        Controls.Add(Label1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Biodata Mahasiswa"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNIM As TextBox
    Friend WithEvents ComboBoxJurusan As ComboBox
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnHapus As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents LabelNIM As Label
    Friend WithEvents LabelRupiah As Label
    Friend WithEvents LabelStat As Label
    Friend WithEvents LabelJur As Label
    Friend WithEvents LabelNama As Label

End Class
