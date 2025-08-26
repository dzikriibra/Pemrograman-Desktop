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
        ListLooping = New ListBox()
        BtnProses = New Button()
        BtnKeluar = New Button()
        SuspendLayout()
        ' 
        ' ListLooping
        ' 
        ListLooping.FormattingEnabled = True
        ListLooping.Location = New Point(94, 62)
        ListLooping.Name = "ListLooping"
        ListLooping.Size = New Size(427, 244)
        ListLooping.TabIndex = 0
        ' 
        ' BtnProses
        ' 
        BtnProses.Location = New Point(120, 349)
        BtnProses.Name = "BtnProses"
        BtnProses.Size = New Size(144, 42)
        BtnProses.TabIndex = 1
        BtnProses.Text = "Proses"
        BtnProses.UseVisualStyleBackColor = True
        ' 
        ' BtnKeluar
        ' 
        BtnKeluar.Location = New Point(349, 349)
        BtnKeluar.Name = "BtnKeluar"
        BtnKeluar.Size = New Size(142, 42)
        BtnKeluar.TabIndex = 2
        BtnKeluar.Text = "Keluar"
        BtnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(626, 450)
        Controls.Add(BtnKeluar)
        Controls.Add(BtnProses)
        Controls.Add(ListLooping)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "For ...Next"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ListLooping As ListBox
    Friend WithEvents BtnProses As Button
    Friend WithEvents BtnKeluar As Button

End Class
