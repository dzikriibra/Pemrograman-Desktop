<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        BtnProses = New Button()
        ListLooping = New ListBox()
        SuspendLayout()
        ' 
        ' BtnKeluar
        ' 
        BtnKeluar.Location = New Point(351, 348)
        BtnKeluar.Name = "BtnKeluar"
        BtnKeluar.Size = New Size(142, 42)
        BtnKeluar.TabIndex = 5
        BtnKeluar.Text = "Keluar"
        BtnKeluar.UseVisualStyleBackColor = True
        ' 
        ' BtnProses
        ' 
        BtnProses.Location = New Point(122, 348)
        BtnProses.Name = "BtnProses"
        BtnProses.Size = New Size(144, 42)
        BtnProses.TabIndex = 4
        BtnProses.Text = "Proses"
        BtnProses.UseVisualStyleBackColor = True
        ' 
        ' ListLooping
        ' 
        ListLooping.FormattingEnabled = True
        ListLooping.Location = New Point(96, 61)
        ListLooping.Name = "ListLooping"
        ListLooping.Size = New Size(427, 244)
        ListLooping.TabIndex = 3
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(619, 450)
        Controls.Add(BtnKeluar)
        Controls.Add(BtnProses)
        Controls.Add(ListLooping)
        Name = "Form6"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DoWhile"
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnKeluar As Button
    Friend WithEvents BtnProses As Button
    Friend WithEvents ListLooping As ListBox
End Class
