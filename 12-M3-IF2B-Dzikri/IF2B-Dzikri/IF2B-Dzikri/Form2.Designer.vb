<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKalkulator
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
        AngkaPertama = New Label()
        AngkaKedua = New Label()
        Hasil = New Label()
        txtAngka1 = New TextBox()
        txtAngka2 = New TextBox()
        txtHasil = New TextBox()
        btnKali = New Button()
        btnBagi = New Button()
        btnKurang = New Button()
        btnTambah = New Button()
        SuspendLayout()
        ' 
        ' AngkaPertama
        ' 
        AngkaPertama.AutoSize = True
        AngkaPertama.Font = New Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AngkaPertama.Location = New Point(105, 109)
        AngkaPertama.Name = "AngkaPertama"
        AngkaPertama.Size = New Size(183, 33)
        AngkaPertama.TabIndex = 0
        AngkaPertama.Text = "Angka Pertama"
        ' 
        ' AngkaKedua
        ' 
        AngkaKedua.AutoSize = True
        AngkaKedua.Font = New Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AngkaKedua.Location = New Point(125, 163)
        AngkaKedua.Name = "AngkaKedua"
        AngkaKedua.Size = New Size(163, 33)
        AngkaKedua.TabIndex = 1
        AngkaKedua.Text = "Angka Kedua"
        ' 
        ' Hasil
        ' 
        Hasil.AutoSize = True
        Hasil.Font = New Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Hasil.Location = New Point(218, 326)
        Hasil.Name = "Hasil"
        Hasil.Size = New Size(70, 33)
        Hasil.TabIndex = 2
        Hasil.Text = "Hasil"
        ' 
        ' txtAngka1
        ' 
        txtAngka1.Location = New Point(340, 115)
        txtAngka1.Name = "txtAngka1"
        txtAngka1.Size = New Size(299, 27)
        txtAngka1.TabIndex = 0
        ' 
        ' txtAngka2
        ' 
        txtAngka2.Location = New Point(340, 169)
        txtAngka2.Name = "txtAngka2"
        txtAngka2.Size = New Size(299, 27)
        txtAngka2.TabIndex = 4
        ' 
        ' txtHasil
        ' 
        txtHasil.Enabled = False
        txtHasil.Location = New Point(340, 326)
        txtHasil.Name = "txtHasil"
        txtHasil.Size = New Size(299, 27)
        txtHasil.TabIndex = 5
        ' 
        ' btnKali
        ' 
        btnKali.AutoSize = True
        btnKali.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnKali.Location = New Point(546, 240)
        btnKali.Name = "btnKali"
        btnKali.Size = New Size(93, 56)
        btnKali.TabIndex = 9
        btnKali.Text = "*"
        btnKali.UseVisualStyleBackColor = True
        ' 
        ' btnBagi
        ' 
        btnBagi.AutoSize = True
        btnBagi.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBagi.Location = New Point(404, 240)
        btnBagi.Name = "btnBagi"
        btnBagi.Size = New Size(93, 56)
        btnBagi.TabIndex = 10
        btnBagi.Text = "/"
        btnBagi.UseVisualStyleBackColor = True
        ' 
        ' btnKurang
        ' 
        btnKurang.AutoSize = True
        btnKurang.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnKurang.Location = New Point(267, 240)
        btnKurang.Name = "btnKurang"
        btnKurang.Size = New Size(93, 56)
        btnKurang.TabIndex = 11
        btnKurang.Text = "-"
        btnKurang.UseVisualStyleBackColor = True
        ' 
        ' btnTambah
        ' 
        btnTambah.AutoSize = True
        btnTambah.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnTambah.Location = New Point(135, 240)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(93, 56)
        btnTambah.TabIndex = 12
        btnTambah.Text = "+"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' frmKalkulator
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.MenuHighlight
        ClientSize = New Size(800, 450)
        Controls.Add(btnTambah)
        Controls.Add(btnKurang)
        Controls.Add(btnBagi)
        Controls.Add(btnKali)
        Controls.Add(txtHasil)
        Controls.Add(txtAngka2)
        Controls.Add(txtAngka1)
        Controls.Add(Hasil)
        Controls.Add(AngkaKedua)
        Controls.Add(AngkaPertama)
        ForeColor = SystemColors.ActiveCaptionText
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "frmKalkulator"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kalkulator Sederhana"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents AngkaPertama As Label
    Friend WithEvents AngkaKedua As Label
    Friend WithEvents Hasil As Label
    Friend WithEvents txtAngka1 As TextBox
    Friend WithEvents txtAngka2 As TextBox
    Friend WithEvents txtHasil As TextBox
    Friend WithEvents btnKali As Button
    Friend WithEvents btnBagi As Button
    Friend WithEvents btnKurang As Button
    Friend WithEvents btnTambah As Button
End Class
