<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        TxtAngka = New TextBox()
        BtnProses = New Button()
        BtnHapus = New Button()
        BtnKeluar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(145, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(298, 25)
        Label1.TabIndex = 0
        Label1.Text = "Ganjil Genap dengan Do ... While "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(114, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 20)
        Label2.TabIndex = 1
        Label2.Text = "Input Angka"
        ' 
        ' TxtAngka
        ' 
        TxtAngka.Location = New Point(241, 144)
        TxtAngka.Name = "TxtAngka"
        TxtAngka.Size = New Size(202, 27)
        TxtAngka.TabIndex = 2
        ' 
        ' BtnProses
        ' 
        BtnProses.Location = New Point(109, 232)
        BtnProses.Name = "BtnProses"
        BtnProses.Size = New Size(94, 29)
        BtnProses.TabIndex = 3
        BtnProses.Text = "Proses"
        BtnProses.UseVisualStyleBackColor = True
        ' 
        ' BtnHapus
        ' 
        BtnHapus.Location = New Point(241, 232)
        BtnHapus.Name = "BtnHapus"
        BtnHapus.Size = New Size(94, 29)
        BtnHapus.TabIndex = 4
        BtnHapus.Text = "Hapus"
        BtnHapus.UseVisualStyleBackColor = True
        ' 
        ' BtnKeluar
        ' 
        BtnKeluar.Location = New Point(372, 232)
        BtnKeluar.Name = "BtnKeluar"
        BtnKeluar.Size = New Size(94, 29)
        BtnKeluar.TabIndex = 5
        BtnKeluar.Text = "Keluar"
        BtnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(607, 353)
        Controls.Add(BtnKeluar)
        Controls.Add(BtnHapus)
        Controls.Add(BtnProses)
        Controls.Add(TxtAngka)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form7"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DoWhileGanjilGenap"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtAngka As TextBox
    Friend WithEvents BtnProses As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnKeluar As Button
End Class
