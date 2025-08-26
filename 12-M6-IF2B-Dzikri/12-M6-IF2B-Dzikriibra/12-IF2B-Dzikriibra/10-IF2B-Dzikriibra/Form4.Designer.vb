<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        BtnKeluar = New Button()
        BtnBulan = New Button()
        ListBulan = New ListBox()
        SuspendLayout()
        ' 
        ' BtnKeluar
        ' 
        BtnKeluar.Location = New Point(341, 427)
        BtnKeluar.Name = "BtnKeluar"
        BtnKeluar.Size = New Size(123, 29)
        BtnKeluar.TabIndex = 5
        BtnKeluar.Text = "Keluar"
        BtnKeluar.UseVisualStyleBackColor = True
        ' 
        ' BtnBulan
        ' 
        BtnBulan.Location = New Point(341, 92)
        BtnBulan.Name = "BtnBulan"
        BtnBulan.Size = New Size(123, 29)
        BtnBulan.TabIndex = 4
        BtnBulan.Text = "For Next"
        BtnBulan.UseVisualStyleBackColor = True
        ' 
        ' ListBulan
        ' 
        ListBulan.FormattingEnabled = True
        ListBulan.Location = New Point(63, 92)
        ListBulan.Name = "ListBulan"
        ListBulan.Size = New Size(220, 364)
        ListBulan.TabIndex = 3
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(526, 549)
        Controls.Add(BtnKeluar)
        Controls.Add(BtnBulan)
        Controls.Add(ListBulan)
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnKeluar As Button
    Friend WithEvents BtnBulan As Button
    Friend WithEvents ListBulan As ListBox
End Class
