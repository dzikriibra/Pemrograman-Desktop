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
        Label2 = New Label()
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        btnProses = New Button()
        Button2 = New Button()
        TextBox1 = New TextBox()
        ListHasil = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(294, 38)
        Label1.TabIndex = 0
        Label1.Text = "List Bilangan Kelipatan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(144, 125)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 20)
        Label2.TabIndex = 1
        Label2.Text = "Kelipatan"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(61, 204)
        Label3.Name = "Label3"
        Label3.Size = New Size(155, 20)
        Label3.TabIndex = 2
        Label3.Text = "Dari 1 sampai dengan"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"3", "7"})
        ComboBox1.Location = New Point(228, 122)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(63, 28)
        ComboBox1.TabIndex = 3
        ' 
        ' btnProses
        ' 
        btnProses.Location = New Point(61, 299)
        btnProses.Name = "btnProses"
        btnProses.Size = New Size(94, 29)
        btnProses.TabIndex = 4
        btnProses.Text = "Proses"
        btnProses.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(197, 299)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 5
        Button2.Text = "Hapus"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(228, 204)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(63, 27)
        TextBox1.TabIndex = 6
        ' 
        ' ListHasil
        ' 
        ListHasil.FormattingEnabled = True
        ListHasil.Location = New Point(347, 46)
        ListHasil.Name = "ListHasil"
        ListHasil.Size = New Size(150, 304)
        ListHasil.TabIndex = 7
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(576, 390)
        Controls.Add(ListHasil)
        Controls.Add(TextBox1)
        Controls.Add(Button2)
        Controls.Add(btnProses)
        Controls.Add(ComboBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnProses As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListHasil As ListBox
End Class
