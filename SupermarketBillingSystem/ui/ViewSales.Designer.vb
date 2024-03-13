<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSales
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
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(1, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1411, 125)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(569, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(214, 46)
        Label1.TabIndex = 0
        Label1.Text = " Sales Report"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(DataGridView1)
        GroupBox2.Location = New Point(1, 134)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1411, 526)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox2"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(6, 26)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(1399, 494)
        DataGridView1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(1229, 684)
        Button1.Name = "Button1"
        Button1.Size = New Size(158, 48)
        Button1.TabIndex = 2
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ViewSales
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        ClientSize = New Size(1417, 744)
        Controls.Add(Button1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "ViewSales"
        Text = "ViewSales"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
End Class
