<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateProduct
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
        Label2 = New Label()
        SearchBox = New TextBox()
        search = New Button()
        productsViewTable = New DataGridView()
        Button1 = New Button()
        CType(productsViewTable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(12, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(161, 31)
        Label2.TabIndex = 4
        Label2.Text = "Product Name"
        ' 
        ' SearchBox
        ' 
        SearchBox.Location = New Point(197, 20)
        SearchBox.Multiline = True
        SearchBox.Name = "SearchBox"
        SearchBox.Size = New Size(247, 34)
        SearchBox.TabIndex = 5
        ' 
        ' search
        ' 
        search.BackColor = Color.Navy
        search.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        search.ForeColor = Color.White
        search.Location = New Point(468, 20)
        search.Name = "search"
        search.Size = New Size(94, 34)
        search.TabIndex = 6
        search.Text = "Search"
        search.UseVisualStyleBackColor = False
        ' 
        ' productsViewTable
        ' 
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.DodgerBlue
        productsViewTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        productsViewTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        productsViewTable.Location = New Point(1, 89)
        productsViewTable.Name = "productsViewTable"
        productsViewTable.RowHeadersWidth = 51
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.DodgerBlue
        productsViewTable.RowsDefaultCellStyle = DataGridViewCellStyle2
        productsViewTable.RowTemplate.Height = 29
        productsViewTable.Size = New Size(1400, 632)
        productsViewTable.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Navy
        Button1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(580, 20)
        Button1.Name = "Button1"
        Button1.Size = New Size(223, 34)
        Button1.TabIndex = 8
        Button1.Text = "Update Selected Item"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' UpdateProduct
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1405, 721)
        Controls.Add(Button1)
        Controls.Add(productsViewTable)
        Controls.Add(search)
        Controls.Add(SearchBox)
        Controls.Add(Label2)
        Name = "UpdateProduct"
        Text = "UpdateProduct"
        CType(productsViewTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents search As Button
    Friend WithEvents productsViewTable As DataGridView
    Friend WithEvents Button1 As Button
End Class
