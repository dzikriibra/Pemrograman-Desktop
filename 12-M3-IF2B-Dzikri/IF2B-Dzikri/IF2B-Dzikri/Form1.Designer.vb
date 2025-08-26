<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUtama
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
        btnPesan = New Button()
        btnQuit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe Script", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(184, 98)
        Label1.Name = "Label1"
        Label1.Size = New Size(422, 133)
        Label1.TabIndex = 0
        Label1.Text = "Welcome"
        ' 
        ' btnPesan
        ' 
        btnPesan.AutoSize = True
        btnPesan.BackColor = Color.Transparent
        btnPesan.FlatStyle = FlatStyle.Flat
        btnPesan.Font = New Font("Segoe UI Symbol", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPesan.Location = New Point(206, 267)
        btnPesan.Name = "btnPesan"
        btnPesan.Size = New Size(147, 50)
        btnPesan.TabIndex = 1
        btnPesan.Text = "Pesan"
        btnPesan.UseVisualStyleBackColor = False
        ' 
        ' btnQuit
        ' 
        btnQuit.AutoSize = True
        btnQuit.BackColor = Color.Transparent
        btnQuit.FlatStyle = FlatStyle.Flat
        btnQuit.Font = New Font("Segoe UI Symbol", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnQuit.Location = New Point(427, 267)
        btnQuit.Name = "btnQuit"
        btnQuit.Size = New Size(147, 50)
        btnQuit.TabIndex = 2
        btnQuit.Text = "Quit"
        btnQuit.UseVisualStyleBackColor = False
        ' 
        ' frmUtama
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(795, 450)
        Controls.Add(btnQuit)
        Controls.Add(btnPesan)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "frmUtama"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form 1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnPesan As Button
    Friend WithEvents btnQuit As Button

End Class
