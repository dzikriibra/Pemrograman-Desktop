<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        TxtTeks = New TextBox()
        ListLooping = New ListBox()
        BtnProses = New Button()
        Label2 = New Label()
        TxtJumlah = New TextBox()
        BtnHapus = New Button()
        BtnKeluar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(88, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 25)
        Label1.TabIndex = 0
        Label1.Text = "Inputkan Text"
        ' 
        ' TxtTeks
        ' 
        TxtTeks.Location = New Point(283, 65)
        TxtTeks.Name = "TxtTeks"
        TxtTeks.Size = New Size(183, 27)
        TxtTeks.TabIndex = 1
        ' 
        ' ListLooping
        ' 
        ListLooping.FormattingEnabled = True
        ListLooping.Location = New Point(88, 179)
        ListLooping.Name = "ListLooping"
        ListLooping.Size = New Size(378, 204)
        ListLooping.TabIndex = 2
        ' 
        ' BtnProses
        ' 
        BtnProses.Location = New Point(88, 402)
        BtnProses.Name = "BtnProses"
        BtnProses.Size = New Size(94, 29)
        BtnProses.TabIndex = 3
        BtnProses.Text = "Proses"
        BtnProses.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(88, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(159, 25)
        Label2.TabIndex = 4
        Label2.Text = "Jumlah Perulangan"
        ' 
        ' TxtJumlah
        ' 
        TxtJumlah.Location = New Point(283, 121)
        TxtJumlah.Name = "TxtJumlah"
        TxtJumlah.Size = New Size(183, 27)
        TxtJumlah.TabIndex = 5
        ' 
        ' BtnHapus
        ' 
        BtnHapus.Location = New Point(232, 402)
        BtnHapus.Name = "BtnHapus"
        BtnHapus.Size = New Size(94, 29)
        BtnHapus.TabIndex = 6
        BtnHapus.Text = "Hapus"
        BtnHapus.UseVisualStyleBackColor = True
        ' 
        ' BtnKeluar
        ' 
        BtnKeluar.Location = New Point(372, 402)
        BtnKeluar.Name = "BtnKeluar"
        BtnKeluar.Size = New Size(94, 29)
        BtnKeluar.TabIndex = 7
        BtnKeluar.Text = "Keluar"
        BtnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(577, 526)
        Controls.Add(BtnKeluar)
        Controls.Add(BtnHapus)
        Controls.Add(TxtJumlah)
        Controls.Add(Label2)
        Controls.Add(BtnProses)
        Controls.Add(ListLooping)
        Controls.Add(TxtTeks)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "ForNext2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtTeks As TextBox
    Friend WithEvents ListLooping As ListBox
    Friend WithEvents BtnProses As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtJumlah As TextBox
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnKeluar As Button
End Class
