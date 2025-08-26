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
        txtAngka = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btnHitung = New Button()
        btnReset = New Button()
        btnKeluar = New Button()
        ListHasil = New ListBox()
        SuspendLayout()
        ' 
        ' txtAngka
        ' 
        txtAngka.Location = New Point(225, 122)
        txtAngka.Name = "txtAngka"
        txtAngka.Size = New Size(171, 27)
        txtAngka.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(134, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(209, 28)
        Label1.TabIndex = 2
        Label1.Text = "Kalkualtor Perkalian "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(56, 121)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 25)
        Label2.TabIndex = 3
        Label2.Text = "Input angka:"
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(59, 178)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(108, 37)
        btnHitung.TabIndex = 4
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(59, 301)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(108, 37)
        btnReset.TabIndex = 5
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(59, 421)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(108, 37)
        btnKeluar.TabIndex = 6
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' ListHasil
        ' 
        ListHasil.BackColor = SystemColors.Menu
        ListHasil.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListHasil.FormattingEnabled = True
        ListHasil.ItemHeight = 23
        ListHasil.Location = New Point(225, 178)
        ListHasil.Name = "ListHasil"
        ListHasil.Size = New Size(171, 280)
        ListHasil.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        ClientSize = New Size(470, 491)
        Controls.Add(ListHasil)
        Controls.Add(btnKeluar)
        Controls.Add(btnReset)
        Controls.Add(btnHitung)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtAngka)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kalkulator Perkalian Otomatis"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtAngka As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents ListHasil As ListBox

End Class
