<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        TxtAwal = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TxtAkhir = New TextBox()
        BtnProses = New Button()
        BtnKeluar = New Button()
        ListGanjil = New ListBox()
        ListGenap = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(125, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(230, 25)
        Label1.TabIndex = 0
        Label1.Text = "Perhitungan Ganjil Genap"
        ' 
        ' TxtAwal
        ' 
        TxtAwal.Location = New Point(234, 108)
        TxtAwal.Name = "TxtAwal"
        TxtAwal.Size = New Size(175, 27)
        TxtAwal.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(65, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 25)
        Label2.TabIndex = 2
        Label2.Text = "Angka Awal"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(62, 167)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 25)
        Label3.TabIndex = 3
        Label3.Text = "Angka Akhir"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(125, 329)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 25)
        Label4.TabIndex = 3
        Label4.Text = "Ganjil"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(292, 329)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 25)
        Label5.TabIndex = 4
        Label5.Text = "Genap"
        ' 
        ' TxtAkhir
        ' 
        TxtAkhir.Location = New Point(234, 167)
        TxtAkhir.Name = "TxtAkhir"
        TxtAkhir.Size = New Size(175, 27)
        TxtAkhir.TabIndex = 5
        ' 
        ' BtnProses
        ' 
        BtnProses.Location = New Point(62, 248)
        BtnProses.Name = "BtnProses"
        BtnProses.Size = New Size(151, 29)
        BtnProses.TabIndex = 6
        BtnProses.Text = "Proses"
        BtnProses.UseVisualStyleBackColor = True
        ' 
        ' BtnKeluar
        ' 
        BtnKeluar.Location = New Point(261, 248)
        BtnKeluar.Name = "BtnKeluar"
        BtnKeluar.Size = New Size(148, 29)
        BtnKeluar.TabIndex = 7
        BtnKeluar.Text = "Keluar"
        BtnKeluar.UseVisualStyleBackColor = True
        ' 
        ' ListGanjil
        ' 
        ListGanjil.FormattingEnabled = True
        ListGanjil.Location = New Point(93, 375)
        ListGanjil.Name = "ListGanjil"
        ListGanjil.Size = New Size(120, 244)
        ListGanjil.TabIndex = 8
        ' 
        ' ListGenap
        ' 
        ListGenap.FormattingEnabled = True
        ListGenap.Location = New Point(261, 375)
        ListGenap.Name = "ListGenap"
        ListGenap.Size = New Size(128, 244)
        ListGenap.TabIndex = 9
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(507, 642)
        Controls.Add(ListGenap)
        Controls.Add(ListGanjil)
        Controls.Add(BtnKeluar)
        Controls.Add(BtnProses)
        Controls.Add(TxtAkhir)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TxtAwal)
        Controls.Add(Label1)
        Name = "Form5"
        Text = "ForNextGanjilGenap"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtAwal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtAkhir As TextBox
    Friend WithEvents BtnProses As Button
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents ListGanjil As ListBox
    Friend WithEvents ListGenap As ListBox
End Class
