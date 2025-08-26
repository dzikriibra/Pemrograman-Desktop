<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        ListLooping = New ListBox()
        BtnForNext = New Button()
        BtnDoWhile = New Button()
        BtnDoUntil = New Button()
        SuspendLayout()
        ' 
        ' ListLooping
        ' 
        ListLooping.FormattingEnabled = True
        ListLooping.Location = New Point(40, 47)
        ListLooping.Name = "ListLooping"
        ListLooping.Size = New Size(150, 364)
        ListLooping.TabIndex = 0
        ' 
        ' BtnForNext
        ' 
        BtnForNext.Location = New Point(243, 47)
        BtnForNext.Name = "BtnForNext"
        BtnForNext.Size = New Size(118, 103)
        BtnForNext.TabIndex = 1
        BtnForNext.Text = "FOR NEXT"
        BtnForNext.UseVisualStyleBackColor = True
        ' 
        ' BtnDoWhile
        ' 
        BtnDoWhile.Location = New Point(243, 179)
        BtnDoWhile.Name = "BtnDoWhile"
        BtnDoWhile.Size = New Size(118, 103)
        BtnDoWhile.TabIndex = 2
        BtnDoWhile.Text = "DO WHILE"
        BtnDoWhile.UseVisualStyleBackColor = True
        ' 
        ' BtnDoUntil
        ' 
        BtnDoUntil.Location = New Point(243, 308)
        BtnDoUntil.Name = "BtnDoUntil"
        BtnDoUntil.Size = New Size(118, 103)
        BtnDoUntil.TabIndex = 3
        BtnDoUntil.Text = "DO UNTIL"
        BtnDoUntil.UseVisualStyleBackColor = True
        ' 
        ' Form9
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(415, 450)
        Controls.Add(BtnDoUntil)
        Controls.Add(BtnDoWhile)
        Controls.Add(BtnForNext)
        Controls.Add(ListLooping)
        Name = "Form9"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kombinasi Looping"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ListLooping As ListBox
    Friend WithEvents BtnForNext As Button
    Friend WithEvents BtnDoWhile As Button
    Friend WithEvents BtnDoUntil As Button
End Class
