<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVolTabung
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
        intJariJari = New TextBox()
        Label3 = New Label()
        intTinggi = New TextBox()
        Button1 = New Button()
        HslVolTbg = New TextBox()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(271, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(260, 28)
        Label1.TabIndex = 0
        Label1.Text = "Menghitung Volume Tabung"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(191, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 25)
        Label2.TabIndex = 1
        Label2.Text = "Input jari-jari"
        ' 
        ' intJariJari
        ' 
        intJariJari.Location = New Point(380, 140)
        intJariJari.Name = "intJariJari"
        intJariJari.Size = New Size(244, 27)
        intJariJari.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(198, 201)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 25)
        Label3.TabIndex = 3
        Label3.Text = "Input tinggi"
        ' 
        ' intTinggi
        ' 
        intTinggi.Location = New Point(380, 199)
        intTinggi.Name = "intTinggi"
        intTinggi.Size = New Size(244, 27)
        intTinggi.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(419, 262)
        Button1.Name = "Button1"
        Button1.Size = New Size(205, 39)
        Button1.TabIndex = 5
        Button1.Text = "Hitung"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' HslVolTbg
        ' 
        HslVolTbg.Enabled = False
        HslVolTbg.Location = New Point(380, 335)
        HslVolTbg.Name = "HslVolTbg"
        HslVolTbg.Size = New Size(244, 27)
        HslVolTbg.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(253, 334)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 25)
        Label4.TabIndex = 7
        Label4.Text = "Hasil"
        ' 
        ' FrmVolTabung
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(HslVolTbg)
        Controls.Add(Button1)
        Controls.Add(intTinggi)
        Controls.Add(Label3)
        Controls.Add(intJariJari)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "FrmVolTabung"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Perhitungan Volume Tabung"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents intJariJari As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents intTinggi As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents HslVolTbg As TextBox
    Friend WithEvents Label4 As Label
End Class
