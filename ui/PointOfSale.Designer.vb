<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PointOfSale
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
        GroupBox2 = New GroupBox()
        quantity = New TextBox()
        Label1 = New Label()
        productlist = New DataGridView()
        productName = New TextBox()
        Label7 = New Label()
        Button1 = New Button()
        DateTimePicker1 = New DateTimePicker()
        Label5 = New Label()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Button2 = New Button()
        GroupBox5 = New GroupBox()
        Label2 = New Label()
        paymentType = New ComboBox()
        Button5 = New Button()
        Panel1 = New Panel()
        Button6 = New Button()
        customerdetail = New DataGridView()
        TextBox2 = New TextBox()
        customerNameTxtbox = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        BillList = New DataGridView()
        total = New Label()
        totalValue = New TextBox()
        Button3 = New Button()
        GroupBox2.SuspendLayout()
        CType(productlist, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox5.SuspendLayout()
        Panel1.SuspendLayout()
        CType(customerdetail, ComponentModel.ISupportInitialize).BeginInit()
        CType(BillList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(quantity)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(productlist)
        GroupBox2.Controls.Add(productName)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Controls.Add(DateTimePicker1)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Location = New Point(549, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(832, 250)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox2"
        ' 
        ' quantity
        ' 
        quantity.Location = New Point(233, 63)
        quantity.Name = "quantity"
        quantity.Size = New Size(288, 27)
        quantity.TabIndex = 20
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(121, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 20)
        Label1.TabIndex = 19
        Label1.Text = "Quantity"
        ' 
        ' productlist
        ' 
        productlist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        productlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        productlist.Location = New Point(0, 104)
        productlist.Name = "productlist"
        productlist.RowHeadersWidth = 51
        productlist.RowTemplate.Height = 29
        productlist.Size = New Size(814, 140)
        productlist.TabIndex = 18
        ' 
        ' productName
        ' 
        productName.Location = New Point(235, 29)
        productName.Name = "productName"
        productName.Size = New Size(286, 27)
        productName.TabIndex = 16
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(107, 32)
        Label7.Name = "Label7"
        Label7.Size = New Size(114, 20)
        Label7.TabIndex = 15
        Label7.Text = "Search Product"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(946, 151)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 34)
        Button1.TabIndex = 11
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(1079, 27)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 27)
        DateTimePicker1.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(931, 32)
        Label5.Name = "Label5"
        Label5.Size = New Size(123, 20)
        Label5.TabIndex = 3
        Label5.Text = "Date Of Purchase"
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Navy
        Button2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(16, 51)
        Button2.Name = "Button2"
        Button2.Size = New Size(185, 44)
        Button2.TabIndex = 4
        Button2.Text = "New Bill"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(Label2)
        GroupBox5.Controls.Add(paymentType)
        GroupBox5.Controls.Add(Button2)
        GroupBox5.Location = New Point(12, 608)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(839, 125)
        GroupBox5.TabIndex = 5
        GroupBox5.TabStop = False
        GroupBox5.Text = "GroupBox5"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(547, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 20)
        Label2.TabIndex = 7
        Label2.Text = "Payment Type"
        ' 
        ' paymentType
        ' 
        paymentType.FormattingEnabled = True
        paymentType.Location = New Point(547, 67)
        paymentType.Name = "paymentType"
        paymentType.Size = New Size(214, 28)
        paymentType.TabIndex = 6
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Navy
        Button5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.ForeColor = Color.White
        Button5.Location = New Point(1041, 767)
        Button5.Name = "Button5"
        Button5.Size = New Size(247, 44)
        Button5.TabIndex = 7
        Button5.Text = "Bill"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(customerdetail)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(customerNameTxtbox)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(522, 250)
        Panel1.TabIndex = 13
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Navy
        Button6.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.ForeColor = Color.White
        Button6.Location = New Point(370, 12)
        Button6.Name = "Button6"
        Button6.Size = New Size(127, 78)
        Button6.TabIndex = 17
        Button6.Text = "Add Customer"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' customerdetail
        ' 
        customerdetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        customerdetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        customerdetail.Location = New Point(3, 107)
        customerdetail.Name = "customerdetail"
        customerdetail.RowHeadersWidth = 51
        customerdetail.RowTemplate.Height = 29
        customerdetail.Size = New Size(504, 140)
        customerdetail.TabIndex = 16
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(142, 12)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(222, 27)
        TextBox2.TabIndex = 15
        ' 
        ' customerNameTxtbox
        ' 
        customerNameTxtbox.Location = New Point(142, 56)
        customerNameTxtbox.Multiline = True
        customerNameTxtbox.Name = "customerNameTxtbox"
        customerNameTxtbox.Size = New Size(222, 34)
        customerNameTxtbox.TabIndex = 13
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(6, 13)
        Label4.Name = "Label4"
        Label4.Size = New Size(130, 23)
        Label4.TabIndex = 12
        Label4.Text = "Phone Number"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(13, 66)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 20)
        Label3.TabIndex = 11
        Label3.Text = "Customer Name"
        ' 
        ' BillList
        ' 
        BillList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        BillList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        BillList.Location = New Point(15, 265)
        BillList.Name = "BillList"
        BillList.RowHeadersWidth = 51
        BillList.RowTemplate.Height = 29
        BillList.Size = New Size(1348, 337)
        BillList.TabIndex = 0
        ' 
        ' total
        ' 
        total.AutoSize = True
        total.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        total.Location = New Point(1041, 678)
        total.Name = "total"
        total.Size = New Size(117, 46)
        total.TabIndex = 14
        total.Text = "Total :"
        ' 
        ' totalValue
        ' 
        totalValue.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        totalValue.Location = New Point(1155, 673)
        totalValue.Multiline = True
        totalValue.Name = "totalValue"
        totalValue.ReadOnly = True
        totalValue.Size = New Size(133, 51)
        totalValue.TabIndex = 15
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Navy
        Button3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(1186, 608)
        Button3.Name = "Button3"
        Button3.Size = New Size(179, 44)
        Button3.TabIndex = 16
        Button3.Text = "Calculate"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' PointOfSale
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1377, 923)
        Controls.Add(Button3)
        Controls.Add(totalValue)
        Controls.Add(total)
        Controls.Add(BillList)
        Controls.Add(Panel1)
        Controls.Add(Button5)
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox2)
        Name = "PointOfSale"
        Text = "PointOfSale"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(productlist, ComponentModel.ISupportInitialize).EndInit()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(customerdetail, ComponentModel.ISupportInitialize).EndInit()
        CType(BillList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents customerNameTxtbox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents customerdetail As DataGridView
    Friend WithEvents Button6 As Button
    Friend WithEvents productlist As DataGridView
    Friend WithEvents productName As TextBox
    Friend WithEvents quantity As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BillList As DataGridView
    Friend WithEvents total As Label
    Friend WithEvents totalValue As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents paymentType As ComboBox
    Friend WithEvents Button3 As Button
End Class
