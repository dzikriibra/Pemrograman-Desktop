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
        BoxTugas = New TextBox()
        Label1 = New Label()
        BoxKet = New TextBox()
        Label3 = New Label()
        BoxGrade = New TextBox()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        BoxUAS = New TextBox()
        BoxUTS = New TextBox()
        BoxKuis = New TextBox()
        Label7 = New Label()
        BoxNilaiAkhir = New TextBox()
        BtnHitung = New Button()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' BoxTugas
        ' 
        BoxTugas.Location = New Point(268, 141)
        BoxTugas.Name = "BoxTugas"
        BoxTugas.Size = New Size(123, 27)
        BoxTugas.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(51, 137)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 28)
        Label1.TabIndex = 1
        Label1.Text = "Input Nilai Tugas"
        ' 
        ' BoxKet
        ' 
        BoxKet.Location = New Point(268, 463)
        BoxKet.Name = "BoxKet"
        BoxKet.Size = New Size(123, 27)
        BoxKet.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(94, 462)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 28)
        Label3.TabIndex = 8
        Label3.Text = "Keterangan"
        ' 
        ' BoxGrade
        ' 
        BoxGrade.Location = New Point(268, 423)
        BoxGrade.Name = "BoxGrade"
        BoxGrade.Size = New Size(123, 27)
        BoxGrade.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(141, 423)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 28)
        Label2.TabIndex = 6
        Label2.Text = "Grade"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(64, 261)
        Label4.Name = "Label4"
        Label4.Size = New Size(146, 28)
        Label4.TabIndex = 10
        Label4.Text = "Input Nilai UAS"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(67, 220)
        Label5.Name = "Label5"
        Label5.Size = New Size(143, 28)
        Label5.TabIndex = 11
        Label5.Text = "Input Nilai UTS"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.FlatStyle = FlatStyle.Flat
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(67, 177)
        Label6.Name = "Label6"
        Label6.Size = New Size(144, 28)
        Label6.TabIndex = 12
        Label6.Text = "Input Nilai Kuis"
        ' 
        ' BoxUAS
        ' 
        BoxUAS.Location = New Point(268, 261)
        BoxUAS.Name = "BoxUAS"
        BoxUAS.Size = New Size(123, 27)
        BoxUAS.TabIndex = 13
        ' 
        ' BoxUTS
        ' 
        BoxUTS.Location = New Point(268, 220)
        BoxUTS.Name = "BoxUTS"
        BoxUTS.Size = New Size(123, 27)
        BoxUTS.TabIndex = 14
        ' 
        ' BoxKuis
        ' 
        BoxKuis.Location = New Point(268, 181)
        BoxKuis.Name = "BoxKuis"
        BoxKuis.Size = New Size(123, 27)
        BoxKuis.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(63, 385)
        Label7.Name = "Label7"
        Label7.Size = New Size(146, 28)
        Label7.TabIndex = 16
        Label7.Text = "Input Nilai UAS"
        ' 
        ' BoxNilaiAkhir
        ' 
        BoxNilaiAkhir.Location = New Point(268, 385)
        BoxNilaiAkhir.Name = "BoxNilaiAkhir"
        BoxNilaiAkhir.Size = New Size(123, 27)
        BoxNilaiAkhir.TabIndex = 17
        ' 
        ' BtnHitung
        ' 
        BtnHitung.Location = New Point(268, 322)
        BtnHitung.Name = "BtnHitung"
        BtnHitung.Size = New Size(123, 29)
        BtnHitung.TabIndex = 18
        BtnHitung.Text = "Hitung"
        BtnHitung.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.FlatStyle = FlatStyle.Flat
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(124, 64)
        Label8.Name = "Label8"
        Label8.Size = New Size(225, 28)
        Label8.TabIndex = 19
        Label8.Text = "Form Validasi Nilai Akhir"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(485, 539)
        Controls.Add(Label8)
        Controls.Add(BtnHitung)
        Controls.Add(BoxNilaiAkhir)
        Controls.Add(Label7)
        Controls.Add(BoxKuis)
        Controls.Add(BoxUTS)
        Controls.Add(BoxUAS)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(BoxKet)
        Controls.Add(Label3)
        Controls.Add(BoxGrade)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BoxTugas)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormNilaiAkhir"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BoxTugas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BoxKet As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BoxGrade As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BoxUAS As TextBox
    Friend WithEvents BoxUTS As TextBox
    Friend WithEvents BoxKuis As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BoxNilaiAkhir As TextBox
    Friend WithEvents BtnHitung As Button
    Friend WithEvents Label8 As Label

End Class
