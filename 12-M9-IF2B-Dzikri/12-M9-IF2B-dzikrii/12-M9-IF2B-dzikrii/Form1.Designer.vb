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
        btnCreate = New Button()
        txtNIM = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtKelas = New TextBox()
        txtNama = New TextBox()
        btnDelete = New Button()
        btnUpdate = New Button()
        DataGridView1 = New DataGridView()
        Label4 = New Label()
        txtCari = New TextBox()
        Label5 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnCreate
        ' 
        btnCreate.Location = New Point(20, 264)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(94, 30)
        btnCreate.TabIndex = 0
        btnCreate.Text = "Create"
        btnCreate.UseVisualStyleBackColor = True
        ' 
        ' txtNIM
        ' 
        txtNIM.Location = New Point(118, 102)
        txtNIM.Name = "txtNIM"
        txtNIM.Size = New Size(196, 27)
        txtNIM.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(56, 106)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 23)
        Label1.TabIndex = 2
        Label1.Text = "NIM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(42, 198)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 23)
        Label2.TabIndex = 3
        Label2.Text = "KELAS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(42, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 23)
        Label3.TabIndex = 4
        Label3.Text = "NAMA"
        ' 
        ' txtKelas
        ' 
        txtKelas.Location = New Point(118, 197)
        txtKelas.Name = "txtKelas"
        txtKelas.Size = New Size(196, 27)
        txtKelas.TabIndex = 5
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(118, 149)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(196, 27)
        txtNama.TabIndex = 6
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(220, 264)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 30)
        btnDelete.TabIndex = 7
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(120, 264)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 30)
        btnUpdate.TabIndex = 8
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(354, 80)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(388, 277)
        DataGridView1.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(354, 391)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 23)
        Label4.TabIndex = 10
        Label4.Text = "CARI"
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(421, 390)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(321, 27)
        txtCari.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(296, 25)
        Label5.Name = "Label5"
        Label5.Size = New Size(207, 23)
        Label5.TabIndex = 12
        Label5.Text = "CRUD DATA MAHASISWA"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumAquamarine
        ClientSize = New Size(784, 450)
        Controls.Add(Label5)
        Controls.Add(txtCari)
        Controls.Add(Label4)
        Controls.Add(DataGridView1)
        Controls.Add(btnUpdate)
        Controls.Add(btnDelete)
        Controls.Add(txtNama)
        Controls.Add(txtKelas)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtNIM)
        Controls.Add(btnCreate)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCreate As Button
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKelas As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents Label5 As Label

End Class
