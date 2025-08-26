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
        Label5 = New Label()
        DataGridView1 = New DataGridView()
        btnUpdate = New Button()
        btnDelete = New Button()
        txtKodeMK = New TextBox()
        txtNamaMK = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtSKS = New TextBox()
        btnCreate = New Button()
        Label6 = New Label()
        txtSmt = New TextBox()
        Label4 = New Label()
        txtCari = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(337, 35)
        Label5.Name = "Label5"
        Label5.Size = New Size(221, 23)
        Label5.TabIndex = 25
        Label5.Text = "CRUD TABEL MATA KULIAH"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(373, 84)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(494, 301)
        DataGridView1.TabIndex = 22
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(140, 355)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 30)
        btnUpdate.TabIndex = 21
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(240, 355)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 30)
        btnDelete.TabIndex = 20
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' txtKodeMK
        ' 
        txtKodeMK.Location = New Point(138, 108)
        txtKodeMK.Name = "txtKodeMK"
        txtKodeMK.Size = New Size(196, 27)
        txtKodeMK.TabIndex = 19
        ' 
        ' txtNamaMK
        ' 
        txtNamaMK.Location = New Point(138, 162)
        txtNamaMK.Name = "txtNamaMK"
        txtNamaMK.Size = New Size(196, 27)
        txtNamaMK.TabIndex = 18
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(13, 108)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 23)
        Label3.TabIndex = 17
        Label3.Text = "Kode Matkul"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(6, 162)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 23)
        Label2.TabIndex = 16
        Label2.Text = "Nama Matkul"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(76, 219)
        Label1.Name = "Label1"
        Label1.Size = New Size(38, 23)
        Label1.TabIndex = 15
        Label1.Text = "SKS"
        ' 
        ' txtSKS
        ' 
        txtSKS.Location = New Point(138, 215)
        txtSKS.Name = "txtSKS"
        txtSKS.Size = New Size(196, 27)
        txtSKS.TabIndex = 14
        ' 
        ' btnCreate
        ' 
        btnCreate.Location = New Point(40, 355)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(94, 30)
        btnCreate.TabIndex = 13
        btnCreate.Text = "Create"
        btnCreate.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(37, 272)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 23)
        Label6.TabIndex = 27
        Label6.Text = "Semester"
        ' 
        ' txtSmt
        ' 
        txtSmt.Location = New Point(138, 268)
        txtSmt.Name = "txtSmt"
        txtSmt.Size = New Size(196, 27)
        txtSmt.TabIndex = 26
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(373, 409)
        Label4.Name = "Label4"
        Label4.Size = New Size(40, 23)
        Label4.TabIndex = 28
        Label4.Text = "Cari"
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(429, 408)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(438, 27)
        txtCari.TabIndex = 29
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(902, 461)
        Controls.Add(txtCari)
        Controls.Add(Label4)
        Controls.Add(Label6)
        Controls.Add(txtSmt)
        Controls.Add(Label5)
        Controls.Add(DataGridView1)
        Controls.Add(btnUpdate)
        Controls.Add(btnDelete)
        Controls.Add(txtKodeMK)
        Controls.Add(txtNamaMK)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtSKS)
        Controls.Add(btnCreate)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtKodeMK As TextBox
    Friend WithEvents txtNamaMK As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSKS As TextBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSmt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCari As TextBox
End Class
