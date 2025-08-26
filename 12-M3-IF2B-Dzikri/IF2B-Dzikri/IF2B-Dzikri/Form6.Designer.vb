<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmJajarGenjang
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        intAlasLuas = New TextBox()
        intTinggiLuas = New TextBox()
        HslLuasJG = New TextBox()
        ButtonLuas = New Button()
        Label5 = New Label()
        intAlasKel = New TextBox()
        intPanjangSisi = New TextBox()
        HslKelJG = New TextBox()
        ButtonKeliling = New Button()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(64, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(285, 28)
        Label1.TabIndex = 0
        Label1.Text = "Menghitung Luas Jajar Genjang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(406, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(312, 28)
        Label2.TabIndex = 1
        Label2.Text = "Menghitung Keliling Jajar Genjang"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(48, 144)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 25)
        Label3.TabIndex = 2
        Label3.Text = "Input Alas"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(48, 209)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 25)
        Label4.TabIndex = 3
        Label4.Text = "Input Tinggi"
        ' 
        ' intAlasLuas
        ' 
        intAlasLuas.Location = New Point(175, 144)
        intAlasLuas.Name = "intAlasLuas"
        intAlasLuas.Size = New Size(164, 27)
        intAlasLuas.TabIndex = 4
        ' 
        ' intTinggiLuas
        ' 
        intTinggiLuas.Location = New Point(175, 210)
        intTinggiLuas.Name = "intTinggiLuas"
        intTinggiLuas.Size = New Size(164, 27)
        intTinggiLuas.TabIndex = 5
        ' 
        ' HslLuasJG
        ' 
        HslLuasJG.Location = New Point(175, 333)
        HslLuasJG.Name = "HslLuasJG"
        HslLuasJG.Size = New Size(164, 27)
        HslLuasJG.TabIndex = 6
        ' 
        ' ButtonLuas
        ' 
        ButtonLuas.Location = New Point(232, 270)
        ButtonLuas.Name = "ButtonLuas"
        ButtonLuas.Size = New Size(107, 36)
        ButtonLuas.TabIndex = 7
        ButtonLuas.Text = "Hitung"
        ButtonLuas.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(90, 332)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 25)
        Label5.TabIndex = 8
        Label5.Text = "Hasil"
        ' 
        ' intAlasKel
        ' 
        intAlasKel.Location = New Point(554, 142)
        intAlasKel.Name = "intAlasKel"
        intAlasKel.Size = New Size(164, 27)
        intAlasKel.TabIndex = 9
        ' 
        ' intPanjangSisi
        ' 
        intPanjangSisi.Location = New Point(554, 207)
        intPanjangSisi.Name = "intPanjangSisi"
        intPanjangSisi.Size = New Size(164, 27)
        intPanjangSisi.TabIndex = 10
        ' 
        ' HslKelJG
        ' 
        HslKelJG.Location = New Point(554, 333)
        HslKelJG.Name = "HslKelJG"
        HslKelJG.Size = New Size(164, 27)
        HslKelJG.TabIndex = 11
        ' 
        ' ButtonKeliling
        ' 
        ButtonKeliling.Location = New Point(611, 270)
        ButtonKeliling.Name = "ButtonKeliling"
        ButtonKeliling.Size = New Size(107, 36)
        ButtonKeliling.TabIndex = 12
        ButtonKeliling.Text = "Hitung"
        ButtonKeliling.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(421, 144)
        Label6.Name = "Label6"
        Label6.Size = New Size(92, 25)
        Label6.TabIndex = 13
        Label6.Text = "Input Alas"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(361, 209)
        Label7.Name = "Label7"
        Label7.Size = New Size(152, 25)
        Label7.TabIndex = 14
        Label7.Text = "Input Panjang Sisi"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(463, 332)
        Label8.Name = "Label8"
        Label8.Size = New Size(50, 25)
        Label8.TabIndex = 15
        Label8.Text = "Hasil"
        ' 
        ' FrmJajarGenjang
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        ClientSize = New Size(800, 450)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(ButtonKeliling)
        Controls.Add(HslKelJG)
        Controls.Add(intPanjangSisi)
        Controls.Add(intAlasKel)
        Controls.Add(Label5)
        Controls.Add(ButtonLuas)
        Controls.Add(HslLuasJG)
        Controls.Add(intTinggiLuas)
        Controls.Add(intAlasLuas)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "FrmJajarGenjang"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Perhitungan Jajar Genjang"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents intAlasLuas As TextBox
    Friend WithEvents intTinggiLuas As TextBox
    Friend WithEvents HslLuasJG As TextBox
    Friend WithEvents ButtonLuas As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents intAlasKel As TextBox
    Friend WithEvents intPanjangSisi As TextBox
    Friend WithEvents HslKelJG As TextBox
    Friend WithEvents ButtonKeliling As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
