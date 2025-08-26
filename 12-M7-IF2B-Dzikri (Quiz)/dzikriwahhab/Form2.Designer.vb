<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        ButtonHitung = New Button()
        ComboBox1 = New ComboBox()
        Label2 = New Label()
        Label3 = New Label()
        TextBoxGaji = New TextBox()
        Label4 = New Label()
        TextBoxIstri = New TextBox()
        TextBoxTunAnak = New TextBox()
        TextBoxTotal = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        ComboBox2 = New ComboBox()
        CheckBox1 = New CheckBox()
        SuspendLayout()
        ' 
        ' ButtonHitung
        ' 
        ButtonHitung.Location = New Point(24, 179)
        ButtonHitung.Name = "ButtonHitung"
        ButtonHitung.Size = New Size(564, 38)
        ButtonHitung.TabIndex = 1
        ButtonHitung.Text = "Hitung"
        ButtonHitung.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(143, 84)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(33, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 20)
        Label2.TabIndex = 4
        Label2.Text = "Golongan"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(323, 262)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 20)
        Label3.TabIndex = 6
        Label3.Text = "Gaji Pokok"
        ' 
        ' TextBoxGaji
        ' 
        TextBoxGaji.Enabled = False
        TextBoxGaji.Location = New Point(437, 259)
        TextBoxGaji.Name = "TextBoxGaji"
        TextBoxGaji.Size = New Size(151, 27)
        TextBoxGaji.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(321, 87)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 20)
        Label4.TabIndex = 9
        Label4.Text = "Input Anak"
        ' 
        ' TextBoxIstri
        ' 
        TextBoxIstri.Enabled = False
        TextBoxIstri.Location = New Point(152, 329)
        TextBoxIstri.Name = "TextBoxIstri"
        TextBoxIstri.Size = New Size(142, 27)
        TextBoxIstri.TabIndex = 10
        ' 
        ' TextBoxTunAnak
        ' 
        TextBoxTunAnak.Enabled = False
        TextBoxTunAnak.Location = New Point(152, 271)
        TextBoxTunAnak.Name = "TextBoxTunAnak"
        TextBoxTunAnak.Size = New Size(142, 27)
        TextBoxTunAnak.TabIndex = 11
        ' 
        ' TextBoxTotal
        ' 
        TextBoxTotal.Enabled = False
        TextBoxTotal.Location = New Point(437, 332)
        TextBoxTotal.Name = "TextBoxTotal"
        TextBoxTotal.Size = New Size(151, 27)
        TextBoxTotal.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(24, 336)
        Label5.Name = "Label5"
        Label5.Size = New Size(106, 20)
        Label5.TabIndex = 13
        Label5.Text = "Tunjangan Istri"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(329, 332)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 20)
        Label6.TabIndex = 14
        Label6.Text = "Total Gaji"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(15, 278)
        Label7.Name = "Label7"
        Label7.Size = New Size(115, 20)
        Label7.TabIndex = 15
        Label7.Text = "Tunjangan Anak"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(437, 84)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(151, 28)
        ComboBox2.TabIndex = 16
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(456, 136)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(132, 24)
        CheckBox1.TabIndex = 17
        CheckBox1.Text = "Sudah Menikah"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(630, 437)
        Controls.Add(CheckBox1)
        Controls.Add(ComboBox2)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(TextBoxTotal)
        Controls.Add(TextBoxTunAnak)
        Controls.Add(TextBoxIstri)
        Controls.Add(Label4)
        Controls.Add(TextBoxGaji)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(ComboBox1)
        Controls.Add(ButtonHitung)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ButtonHitung As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxGaji As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxIstri As TextBox
    Friend WithEvents TextBoxTunAnak As TextBox
    Friend WithEvents TextBoxTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
