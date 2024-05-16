<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteProduct
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        GroupBox2 = New GroupBox()
        Button3 = New Button()
        Button2 = New Button()
        search = New Button()
        SearchBox = New TextBox()
        Label2 = New Label()
        productsViewTable = New DataGridView()
        GroupBox2.SuspendLayout()
        CType(productsViewTable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(Button3)
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Controls.Add(search)
        GroupBox2.Controls.Add(SearchBox)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox2.Location = New Point(0, 2)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1264, 100)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox2"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Navy
        Button3.ForeColor = Color.White
        Button3.Location = New Point(608, 60)
        Button3.Name = "Button3"
        Button3.Size = New Size(181, 29)
        Button3.TabIndex = 7
        Button3.Text = "Delete ALL"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Navy
        Button2.ForeColor = Color.White
        Button2.Location = New Point(402, 60)
        Button2.Name = "Button2"
        Button2.Size = New Size(181, 29)
        Button2.TabIndex = 6
        Button2.Text = "Delete Selected"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' search
        ' 
        search.BackColor = Color.Navy
        search.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        search.ForeColor = Color.White
        search.Location = New Point(426, 20)
        search.Name = "search"
        search.Size = New Size(94, 34)
        search.TabIndex = 5
        search.Text = "Search"
        search.UseVisualStyleBackColor = False
        ' 
        ' SearchBox
        ' 
        SearchBox.Location = New Point(173, 20)
        SearchBox.Multiline = True
        SearchBox.Name = "SearchBox"
        SearchBox.Size = New Size(247, 34)
        SearchBox.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveCaption
        Label2.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(6, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(164, 31)
        Label2.TabIndex = 3
        Label2.Text = "Product Name"
        ' 
        ' productsViewTable
        ' 
        productsViewTable.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        productsViewTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        productsViewTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        productsViewTable.DefaultCellStyle = DataGridViewCellStyle2
        productsViewTable.Location = New Point(0, 108)
        productsViewTable.Name = "productsViewTable"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        productsViewTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        productsViewTable.RowHeadersWidth = 51
        DataGridViewCellStyle4.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = Color.Black
        DataGridViewCellStyle4.SelectionBackColor = Color.DodgerBlue
        productsViewTable.RowsDefaultCellStyle = DataGridViewCellStyle4
        productsViewTable.RowTemplate.Height = 29
        productsViewTable.Size = New Size(1264, 617)
        productsViewTable.TabIndex = 2
        ' 
        ' DeleteProduct
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1278, 737)
        Controls.Add(productsViewTable)
        Controls.Add(GroupBox2)
        Name = "DeleteProduct"
        Text = "DeleteProduct"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(productsViewTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents search As Button
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents productsViewTable As DataGridView
End Class
