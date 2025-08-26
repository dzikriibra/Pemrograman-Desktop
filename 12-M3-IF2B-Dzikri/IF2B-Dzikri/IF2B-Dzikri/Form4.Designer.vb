<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSegitiga
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
        Label5 = New Label()
        Kel1 = New TextBox()
        Kel2 = New TextBox()
        Kel3 = New TextBox()
        ButtonKel = New Button()
        HslKel = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        alasSeg = New TextBox()
        tinggiSeg = New TextBox()
        ButtonLuas = New Button()
        HslLuas = New TextBox()
        Label9 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(52, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(267, 28)
        Label1.TabIndex = 0
        Label1.Text = "Menghitung Keliling Segitiga"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(474, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(240, 28)
        Label2.TabIndex = 1
        Label2.Text = "Menghitung Luas Segitiga"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(17, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 28)
        Label3.TabIndex = 2
        Label3.Text = "Sisi A"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(19, 176)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 28)
        Label4.TabIndex = 3
        Label4.Text = "Sisi B"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(17, 225)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 28)
        Label5.TabIndex = 4
        Label5.Text = "Sisi C"
        ' 
        ' Kel1
        ' 
        Kel1.Location = New Point(109, 131)
        Kel1.Name = "Kel1"
        Kel1.Size = New Size(210, 27)
        Kel1.TabIndex = 5
        ' 
        ' Kel2
        ' 
        Kel2.Location = New Point(109, 177)
        Kel2.Name = "Kel2"
        Kel2.Size = New Size(210, 27)
        Kel2.TabIndex = 6
        ' 
        ' Kel3
        ' 
        Kel3.Location = New Point(109, 229)
        Kel3.Name = "Kel3"
        Kel3.Size = New Size(210, 27)
        Kel3.TabIndex = 7
        ' 
        ' ButtonKel
        ' 
        ButtonKel.Location = New Point(128, 284)
        ButtonKel.Name = "ButtonKel"
        ButtonKel.Size = New Size(191, 35)
        ButtonKel.TabIndex = 8
        ButtonKel.Text = "Hitung"
        ButtonKel.UseVisualStyleBackColor = True
        ' 
        ' HslKel
        ' 
        HslKel.Enabled = False
        HslKel.Location = New Point(109, 341)
        HslKel.Name = "HslKel"
        HslKel.Size = New Size(210, 27)
        HslKel.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(22, 337)
        Label6.Name = "Label6"
        Label6.Size = New Size(54, 28)
        Label6.TabIndex = 10
        Label6.Text = "Hasil"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(389, 127)
        Label7.Name = "Label7"
        Label7.Size = New Size(96, 28)
        Label7.TabIndex = 11
        Label7.Text = "Input alas"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(370, 177)
        Label8.Name = "Label8"
        Label8.Size = New Size(115, 28)
        Label8.TabIndex = 12
        Label8.Text = "Input tinggi"
        ' 
        ' alasSeg
        ' 
        alasSeg.Location = New Point(529, 131)
        alasSeg.Name = "alasSeg"
        alasSeg.Size = New Size(210, 27)
        alasSeg.TabIndex = 13
        ' 
        ' tinggiSeg
        ' 
        tinggiSeg.Location = New Point(529, 181)
        tinggiSeg.Name = "tinggiSeg"
        tinggiSeg.Size = New Size(210, 27)
        tinggiSeg.TabIndex = 14
        ' 
        ' ButtonLuas
        ' 
        ButtonLuas.Location = New Point(548, 240)
        ButtonLuas.Name = "ButtonLuas"
        ButtonLuas.Size = New Size(191, 35)
        ButtonLuas.TabIndex = 15
        ButtonLuas.Text = "Hitung"
        ButtonLuas.UseVisualStyleBackColor = True
        ' 
        ' HslLuas
        ' 
        HslLuas.Enabled = False
        HslLuas.Location = New Point(529, 309)
        HslLuas.Name = "HslLuas"
        HslLuas.Size = New Size(210, 27)
        HslLuas.TabIndex = 16
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(431, 309)
        Label9.Name = "Label9"
        Label9.Size = New Size(54, 28)
        Label9.TabIndex = 17
        Label9.Text = "Hasil"
        ' 
        ' FrmSegitiga
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Label9)
        Controls.Add(HslLuas)
        Controls.Add(ButtonLuas)
        Controls.Add(tinggiSeg)
        Controls.Add(alasSeg)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(HslKel)
        Controls.Add(ButtonKel)
        Controls.Add(Kel3)
        Controls.Add(Kel2)
        Controls.Add(Kel1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "FrmSegitiga"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Perhitungan Segitiga"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Kel1 As TextBox
    Friend WithEvents Kel2 As TextBox
    Friend WithEvents Kel3 As TextBox
    Friend WithEvents ButtonKel As Button
    Friend WithEvents HslKel As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents alasSeg As TextBox
    Friend WithEvents tinggiSeg As TextBox
    Friend WithEvents ButtonLuas As Button
    Friend WithEvents HslLuas As TextBox
    Friend WithEvents Label9 As Label
End Class
