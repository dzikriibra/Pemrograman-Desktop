<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHitungNilai
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
        TxtAngka1 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        TxtAngka2 = New TextBox()
        TxtAngka3 = New TextBox()
        Label5 = New Label()
        nilaiAkhir = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Historic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(251, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(279, 38)
        Label1.TabIndex = 0
        Label1.Text = "Program Hitung Nilai"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(181, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 31)
        Label2.TabIndex = 1
        Label2.Text = "Tatap Muka"
        ' 
        ' TxtAngka1
        ' 
        TxtAngka1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtAngka1.Location = New Point(378, 113)
        TxtAngka1.Name = "TxtAngka1"
        TxtAngka1.Size = New Size(199, 38)
        TxtAngka1.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(212, 177)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 31)
        Label3.TabIndex = 3
        Label3.Text = "Mid Test"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(205, 239)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 31)
        Label4.TabIndex = 4
        Label4.Text = "Final Test"
        ' 
        ' TxtAngka2
        ' 
        TxtAngka2.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtAngka2.Location = New Point(378, 174)
        TxtAngka2.Name = "TxtAngka2"
        TxtAngka2.Size = New Size(199, 38)
        TxtAngka2.TabIndex = 5
        ' 
        ' TxtAngka3
        ' 
        TxtAngka3.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtAngka3.Location = New Point(378, 236)
        TxtAngka3.Name = "TxtAngka3"
        TxtAngka3.Size = New Size(199, 38)
        TxtAngka3.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(193, 381)
        Label5.Name = "Label5"
        Label5.Size = New Size(120, 31)
        Label5.TabIndex = 7
        Label5.Text = "Nilai Akhir"
        ' 
        ' nilaiAkhir
        ' 
        nilaiAkhir.Enabled = False
        nilaiAkhir.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nilaiAkhir.Location = New Point(378, 378)
        nilaiAkhir.Name = "nilaiAkhir"
        nilaiAkhir.Size = New Size(199, 38)
        nilaiAkhir.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.AutoSize = True
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.InactiveCaptionText
        Button1.Location = New Point(346, 307)
        Button1.Name = "Button1"
        Button1.Size = New Size(184, 40)
        Button1.TabIndex = 9
        Button1.Text = "Hitung"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' frmHitungNilai
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(nilaiAkhir)
        Controls.Add(Label5)
        Controls.Add(TxtAngka3)
        Controls.Add(TxtAngka2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TxtAngka1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "frmHitungNilai"
        StartPosition = FormStartPosition.CenterScreen
        Text = " Program Hitung Nilai"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtAngka1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtAngka2 As TextBox
    Friend WithEvents TxtAngka3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents nilaiAkhir As TextBox
    Friend WithEvents Button1 As Button
End Class
