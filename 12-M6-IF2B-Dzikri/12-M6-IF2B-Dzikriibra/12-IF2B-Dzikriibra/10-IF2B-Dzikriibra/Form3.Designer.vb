<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        ListHari = New ListBox()
        BtnHari = New Button()
        BtnKeluar = New Button()
        SuspendLayout()
        ' 
        ' ListHari
        ' 
        ListHari.FormattingEnabled = True
        ListHari.Location = New Point(45, 49)
        ListHari.Name = "ListHari"
        ListHari.Size = New Size(220, 364)
        ListHari.TabIndex = 0
        ' 
        ' BtnHari
        ' 
        BtnHari.Location = New Point(323, 49)
        BtnHari.Name = "BtnHari"
        BtnHari.Size = New Size(123, 29)
        BtnHari.TabIndex = 1
        BtnHari.Text = "For Next"
        BtnHari.UseVisualStyleBackColor = True
        ' 
        ' BtnKeluar
        ' 
        BtnKeluar.Location = New Point(323, 384)
        BtnKeluar.Name = "BtnKeluar"
        BtnKeluar.Size = New Size(123, 29)
        BtnKeluar.TabIndex = 2
        BtnKeluar.Text = "Keluar"
        BtnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(507, 450)
        Controls.Add(BtnKeluar)
        Controls.Add(BtnHari)
        Controls.Add(ListHari)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ListHari As ListBox
    Friend WithEvents BtnHari As Button
    Friend WithEvents BtnKeluar As Button
End Class
