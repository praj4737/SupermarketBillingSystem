<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewUsers
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
        Label2 = New Label()
        SearchBox = New TextBox()
        search = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(2, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(127, 31)
        Label2.TabIndex = 6
        Label2.Text = "User Name"
        ' 
        ' SearchBox
        ' 
        SearchBox.Location = New Point(135, 6)
        SearchBox.Multiline = True
        SearchBox.Name = "SearchBox"
        SearchBox.Size = New Size(247, 34)
        SearchBox.TabIndex = 7
        ' 
        ' search
        ' 
        search.BackColor = Color.Navy
        search.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        search.ForeColor = Color.White
        search.Location = New Point(398, 6)
        search.Name = "search"
        search.Size = New Size(94, 34)
        search.TabIndex = 8
        search.Text = "Search"
        search.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(2, 57)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(1261, 660)
        DataGridView1.TabIndex = 9
        ' 
        ' ViewUsers
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1267, 729)
        Controls.Add(DataGridView1)
        Controls.Add(search)
        Controls.Add(SearchBox)
        Controls.Add(Label2)
        Name = "ViewUsers"
        Text = "ViewUsers"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents search As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
