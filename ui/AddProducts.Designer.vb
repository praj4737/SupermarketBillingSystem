<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProducts
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
        GroupBox3 = New GroupBox()
        Button1 = New Button()
        AddProductsToList = New Button()
        manufacturer = New ComboBox()
        category = New ComboBox()
        Label9 = New Label()
        RichTextBox1 = New RichTextBox()
        Label11 = New Label()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        Label5 = New Label()
        TextBox3 = New TextBox()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        ProductsGrid = New DataGridView()
        GroupBox3.SuspendLayout()
        CType(ProductsGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.White
        GroupBox3.Controls.Add(Button1)
        GroupBox3.Controls.Add(AddProductsToList)
        GroupBox3.Controls.Add(manufacturer)
        GroupBox3.Controls.Add(category)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(RichTextBox1)
        GroupBox3.Controls.Add(Label11)
        GroupBox3.Controls.Add(DateTimePicker2)
        GroupBox3.Controls.Add(DateTimePicker1)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Controls.Add(TextBox6)
        GroupBox3.Controls.Add(TextBox5)
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Controls.Add(TextBox3)
        GroupBox3.Controls.Add(TextBox1)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Controls.Add(Label3)
        GroupBox3.Controls.Add(Label1)
        GroupBox3.Dock = DockStyle.Top
        GroupBox3.Location = New Point(0, 0)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(1409, 383)
        GroupBox3.TabIndex = 4
        GroupBox3.TabStop = False
        GroupBox3.Text = "GroupBox3"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Navy
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(518, 237)
        Button1.Name = "Button1"
        Button1.Size = New Size(159, 66)
        Button1.TabIndex = 20
        Button1.Text = "Save Producs"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' AddProductsToList
        ' 
        AddProductsToList.BackColor = Color.Navy
        AddProductsToList.FlatStyle = FlatStyle.Popup
        AddProductsToList.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        AddProductsToList.ForeColor = Color.White
        AddProductsToList.Location = New Point(322, 237)
        AddProductsToList.Name = "AddProductsToList"
        AddProductsToList.Size = New Size(141, 66)
        AddProductsToList.TabIndex = 2
        AddProductsToList.Text = "Add Product"
        AddProductsToList.UseVisualStyleBackColor = False
        ' 
        ' manufacturer
        ' 
        manufacturer.FormattingEnabled = True
        manufacturer.Location = New Point(476, 157)
        manufacturer.Name = "manufacturer"
        manufacturer.Size = New Size(151, 28)
        manufacturer.TabIndex = 19
        ' 
        ' category
        ' 
        category.FormattingEnabled = True
        category.Location = New Point(834, 51)
        category.Name = "category"
        category.Size = New Size(194, 28)
        category.TabIndex = 18
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(335, 159)
        Label9.Name = "Label9"
        Label9.Size = New Size(128, 28)
        Label9.TabIndex = 4
        Label9.Text = "manufacturer"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(840, 157)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(301, 76)
        RichTextBox1.TabIndex = 17
        RichTextBox1.Text = ""
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(648, 159)
        Label11.Name = "Label11"
        Label11.Size = New Size(186, 28)
        Label11.TabIndex = 16
        Label11.Text = "Product Description"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(834, 107)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(194, 27)
        DateTimePicker2.TabIndex = 15
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(476, 111)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(217, 27)
        DateTimePicker1.TabIndex = 14
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(731, 108)
        Label8.Name = "Label8"
        Label8.Size = New Size(87, 28)
        Label8.TabIndex = 13
        Label8.Text = "exp date"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(335, 108)
        Label7.Name = "Label7"
        Label7.Size = New Size(91, 28)
        Label7.TabIndex = 12
        Label7.Text = "mfg date"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(12, 101)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 28)
        Label6.TabIndex = 11
        Label6.Text = "price"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(119, 109)
        TextBox6.Multiline = True
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(182, 34)
        TextBox6.TabIndex = 10
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(119, 153)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(182, 34)
        TextBox5.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(12, 153)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 28)
        Label5.TabIndex = 8
        Label5.Text = "quantity"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(476, 41)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(217, 34)
        TextBox3.TabIndex = 6
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(119, 37)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(182, 34)
        TextBox1.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(729, 47)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 28)
        Label4.TabIndex = 3
        Label4.Text = "category"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(335, 37)
        Label3.Name = "Label3"
        Label3.Size = New Size(135, 28)
        Label3.TabIndex = 2
        Label3.Text = "product name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(8, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 28)
        Label1.TabIndex = 0
        Label1.Text = "Batch Id"
        ' 
        ' ProductsGrid
        ' 
        ProductsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ProductsGrid.Dock = DockStyle.Fill
        ProductsGrid.Location = New Point(0, 383)
        ProductsGrid.Name = "ProductsGrid"
        ProductsGrid.RowHeadersWidth = 51
        ProductsGrid.RowTemplate.Height = 29
        ProductsGrid.Size = New Size(1409, 441)
        ProductsGrid.TabIndex = 5
        ' 
        ' AddProducts
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1409, 824)
        Controls.Add(ProductsGrid)
        Controls.Add(GroupBox3)
        Name = "AddProducts"
        Text = "AddProducts"
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(ProductsGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents AddProductsToList As Button
    Friend WithEvents manufacturer As ComboBox
    Friend WithEvents category As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ProductsGrid As DataGridView
End Class
