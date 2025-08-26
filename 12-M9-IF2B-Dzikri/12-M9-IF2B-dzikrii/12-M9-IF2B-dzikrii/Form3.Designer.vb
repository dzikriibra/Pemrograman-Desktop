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
        Label5 = New Label()
        DataGridView1 = New DataGridView()
        btnUpdate = New Button()
        btnDelete = New Button()
        txtKodeMK = New TextBox()
        txtGrade = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtNIM = New TextBox()
        btnCreate = New Button()
        txtCari = New TextBox()
        Label4 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(315, 29)
        Label5.Name = "Label5"
        Label5.Size = New Size(154, 23)
        Label5.TabIndex = 25
        Label5.Text = "CRUD TABEL NILAI"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(373, 84)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(388, 277)
        DataGridView1.TabIndex = 22
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(140, 278)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 30)
        btnUpdate.TabIndex = 21
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(240, 278)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 30)
        btnDelete.TabIndex = 20
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' txtKodeMK
        ' 
        txtKodeMK.Location = New Point(138, 163)
        txtKodeMK.Name = "txtKodeMK"
        txtKodeMK.Size = New Size(196, 27)
        txtKodeMK.TabIndex = 19
        ' 
        ' txtGrade
        ' 
        txtGrade.Location = New Point(138, 211)
        txtGrade.Name = "txtGrade"
        txtGrade.Size = New Size(196, 27)
        txtGrade.TabIndex = 18
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(13, 164)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 23)
        Label3.TabIndex = 17
        Label3.Text = "Kode Matkul"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(62, 212)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 23)
        Label2.TabIndex = 16
        Label2.Text = "Grade"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(76, 120)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 23)
        Label1.TabIndex = 15
        Label1.Text = "NIM"
        ' 
        ' txtNIM
        ' 
        txtNIM.Location = New Point(138, 116)
        txtNIM.Name = "txtNIM"
        txtNIM.Size = New Size(196, 27)
        txtNIM.TabIndex = 14
        ' 
        ' btnCreate
        ' 
        btnCreate.Location = New Point(40, 278)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(94, 30)
        btnCreate.TabIndex = 13
        btnCreate.Text = "Create"
        btnCreate.UseVisualStyleBackColor = True
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(440, 395)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(321, 27)
        txtCari.TabIndex = 27
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(373, 396)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 23)
        Label4.TabIndex = 26
        Label4.Text = "CARI"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Wheat
        ClientSize = New Size(800, 450)
        Controls.Add(txtCari)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(DataGridView1)
        Controls.Add(btnUpdate)
        Controls.Add(btnDelete)
        Controls.Add(txtKodeMK)
        Controls.Add(txtGrade)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtNIM)
        Controls.Add(btnCreate)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form3"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtKodeMK As TextBox
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents Label4 As Label
End Class
