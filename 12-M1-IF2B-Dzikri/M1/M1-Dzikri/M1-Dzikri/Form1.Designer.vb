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
        LblJudul = New Label()
        btnPesan = New Button()
        BtnQuit = New Button()
        SuspendLayout()
        ' 
        ' LblJudul
        ' 
        LblJudul.AutoSize = True
        LblJudul.Font = New Font("Sitka Banner", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblJudul.ForeColor = SystemColors.ActiveCaptionText
        LblJudul.Location = New Point(233, 99)
        LblJudul.Name = "LblJudul"
        LblJudul.Size = New Size(343, 116)
        LblJudul.TabIndex = 0
        LblJudul.Text = "Welcome"
        ' 
        ' btnPesan
        ' 
        btnPesan.FlatStyle = FlatStyle.Flat
        btnPesan.Location = New Point(161, 240)
        btnPesan.Name = "btnPesan"
        btnPesan.Size = New Size(209, 74)
        btnPesan.TabIndex = 1
        btnPesan.Text = "Pesan"
        btnPesan.UseVisualStyleBackColor = True
        ' 
        ' BtnQuit
        ' 
        BtnQuit.FlatStyle = FlatStyle.Flat
        BtnQuit.Location = New Point(424, 240)
        BtnQuit.Name = "BtnQuit"
        BtnQuit.Size = New Size(209, 74)
        BtnQuit.TabIndex = 2
        BtnQuit.Text = "Quit"
        BtnQuit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Pink
        ClientSize = New Size(800, 450)
        Controls.Add(BtnQuit)
        Controls.Add(btnPesan)
        Controls.Add(LblJudul)
        Cursor = Cursors.No
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmUtama"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblJudul As Label
    Friend WithEvents btnPesan As Button
    Friend WithEvents BtnQuit As Button

End Class
