<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrderMkn
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
        GroupBox1 = New GroupBox()
        Label6 = New Label()
        Label8 = New Label()
        TextBox2 = New TextBox()
        Button1 = New Button()
        TextBox3 = New TextBox()
        Label7 = New Label()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        CheckBox1 = New CheckBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(41, 251)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(515, 269)
        GroupBox1.TabIndex = 25
        GroupBox1.TabStop = False
        GroupBox1.Text = "Menu Pesanan"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.FlatStyle = FlatStyle.Flat
        Label6.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(22, 58)
        Label6.Name = "Label6"
        Label6.Size = New Size(188, 25)
        Label6.TabIndex = 9
        Label6.Text = "Berapa porsi makanan"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(308, 184)
        Label8.Name = "Label8"
        Label8.Size = New Size(38, 25)
        Label8.TabIndex = 16
        Label8.Text = "Rp."
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(308, 56)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 30)
        TextBox2.TabIndex = 14
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(52, 182)
        Button1.Name = "Button1"
        Button1.Size = New Size(110, 33)
        Button1.TabIndex = 13
        Button1.Text = "Hitung"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(308, 117)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 30)
        TextBox3.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(19, 117)
        Label7.Name = "Label7"
        Label7.Size = New Size(191, 25)
        Label7.TabIndex = 12
        Label7.Text = "Berapa porsi minuman"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(38, 184)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(213, 28)
        ComboBox2.TabIndex = 24
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(38, 65)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(213, 28)
        ComboBox1.TabIndex = 23
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(426, 187)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 25)
        Label4.TabIndex = 22
        Label4.Text = "Rp.0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(295, 187)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 25)
        Label3.TabIndex = 21
        Label3.Text = "Harga"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(426, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 25)
        Label2.TabIndex = 20
        Label2.Text = "Rp.0"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(295, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 25)
        Label1.TabIndex = 19
        Label1.Text = "Harga"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(51, 127)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(213, 24)
        CheckBox1.TabIndex = 18
        CheckBox1.Text = "Termasuk dengan minuman"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' FrmOrderMkn
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        ClientSize = New Size(595, 585)
        Controls.Add(GroupBox1)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(CheckBox1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "FrmOrderMkn"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Order Makan"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1 As CheckBox
End Class
