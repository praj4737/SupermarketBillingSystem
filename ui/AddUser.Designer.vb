<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUser
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
        Panel1 = New Panel()
        ComboBox4 = New ComboBox()
        Label13 = New Label()
        Button5 = New Button()
        Button4 = New Button()
        Button2 = New Button()
        email = New TextBox()
        ComboBox3 = New ComboBox()
        gender = New GroupBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        ComboBox2 = New ComboBox()
        Label14 = New Label()
        firstname = New TextBox()
        Label15 = New Label()
        lastname = New TextBox()
        Label2 = New Label()
        ph1 = New TextBox()
        ComboBox1 = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        Label12 = New Label()
        Label3 = New Label()
        zipcode = New TextBox()
        Label9 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        addL1 = New TextBox()
        addL2 = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        addL3 = New TextBox()
        Label6 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Panel2 = New Panel()
        DataGridView1 = New DataGridView()
        searchBox = New TextBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        gender.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Azure
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(ComboBox4)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(email)
        Panel1.Controls.Add(ComboBox3)
        Panel1.Controls.Add(gender)
        Panel1.Controls.Add(ComboBox2)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(firstname)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(lastname)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(ph1)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(zipcode)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(addL1)
        Panel1.Controls.Add(addL2)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(addL3)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label11)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(488, 958)
        Panel1.TabIndex = 0
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Items.AddRange(New Object() {"Select State", "Andhra Pradesh", "Arunachal Pradesh", "Assam", "Bihar", "Chhattisgarh", "Goa", "Gujarat", "Haryana", "Himachal Pradesh", "Jammu and Kashmir", "Jharkhand", "Karnataka", "Kerala", "Madhya Pradesh", "Maharashtra", "Manipur", "Meghalaya", "Mizoram", "Nagaland", "Odisha", "Punjab", "Rajasthan", "Sikkim", "Tamil Nadu", "Telangana", "Tripura", "Uttar Pradesh", "Uttarakhand", "West Bengal"})
        ComboBox4.Location = New Point(211, 665)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(236, 28)
        ComboBox4.TabIndex = 66
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(52, 661)
        Label13.Name = "Label13"
        Label13.Size = New Size(56, 28)
        Label13.TabIndex = 65
        Label13.Text = "State"
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Red
        Button5.FlatStyle = FlatStyle.Popup
        Button5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.ForeColor = Color.White
        Button5.Location = New Point(334, 723)
        Button5.Name = "Button5"
        Button5.Size = New Size(135, 43)
        Button5.TabIndex = 64
        Button5.Text = "Create"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.DarkGreen
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = Color.White
        Button4.Location = New Point(178, 723)
        Button4.Name = "Button4"
        Button4.Size = New Size(135, 43)
        Button4.TabIndex = 63
        Button4.Text = "Create"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Navy
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(13, 723)
        Button2.Name = "Button2"
        Button2.Size = New Size(135, 43)
        Button2.TabIndex = 58
        Button2.Text = "Create"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' email
        ' 
        email.Location = New Point(210, 622)
        email.Name = "email"
        email.Size = New Size(236, 27)
        email.TabIndex = 56
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"Select Country", "India"})
        ComboBox3.Location = New Point(210, 375)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(236, 28)
        ComboBox3.TabIndex = 62
        ' 
        ' gender
        ' 
        gender.Controls.Add(RadioButton1)
        gender.Controls.Add(RadioButton2)
        gender.FlatStyle = FlatStyle.Flat
        gender.Location = New Point(210, 142)
        gender.Name = "gender"
        gender.Size = New Size(229, 68)
        gender.TabIndex = 60
        gender.TabStop = False
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton1.Location = New Point(27, 26)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(76, 32)
        RadioButton1.TabIndex = 58
        RadioButton1.TabStop = True
        RadioButton1.Text = "Male"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton2.Location = New Point(114, 24)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(95, 32)
        RadioButton2.TabIndex = 59
        RadioButton2.TabStop = True
        RadioButton2.Text = "Female"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Select City", "Patna", "Gaya", "Bhagalpur", "Muzaffarpur", "Bihar Sharif", "Darbhanga", "Purnia", "Sasaram", "Arrah", "Samastipur", "Begusarai", "Katihar", "Bettiah", "Motihari", "Saharsa", "Munger", "Chhapra", "Siwan", "Madhubani", "Rajgir"})
        ComboBox2.Location = New Point(210, 470)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(236, 28)
        ComboBox2.TabIndex = 61
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(52, 621)
        Label14.Name = "Label14"
        Label14.Size = New Size(59, 28)
        Label14.TabIndex = 55
        Label14.Text = "Email"
        ' 
        ' firstname
        ' 
        firstname.Location = New Point(219, 19)
        firstname.Name = "firstname"
        firstname.Size = New Size(220, 27)
        firstname.TabIndex = 32
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label15.Location = New Point(51, 19)
        Label15.Name = "Label15"
        Label15.Size = New Size(102, 28)
        Label15.TabIndex = 29
        Label15.Text = "First name"
        ' 
        ' lastname
        ' 
        lastname.Location = New Point(219, 70)
        lastname.Name = "lastname"
        lastname.Size = New Size(220, 27)
        lastname.TabIndex = 33
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(51, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 28)
        Label2.TabIndex = 30
        Label2.Text = "Last name"
        ' 
        ' ph1
        ' 
        ph1.Location = New Point(210, 562)
        ph1.Name = "ph1"
        ph1.Size = New Size(236, 27)
        ph1.TabIndex = 53
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Select State", "Andhra Pradesh", "Arunachal Pradesh", "Assam", "Bihar", "Chhattisgarh", "Goa", "Gujarat", "Haryana", "Himachal Pradesh", "Jammu and Kashmir", "Jharkhand", "Karnataka", "Kerala", "Madhya Pradesh", "Maharashtra", "Manipur", "Meghalaya", "Mizoram", "Nagaland", "Odisha", "Punjab", "Rajasthan", "Sikkim", "Tamil Nadu", "Telangana", "Tripura", "Uttar Pradesh", "Uttarakhand", "West Bengal"})
        ComboBox1.Location = New Point(210, 424)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(236, 28)
        ComboBox1.TabIndex = 58
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(219, 115)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(220, 27)
        DateTimePicker1.TabIndex = 34
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.ForeColor = Color.Black
        Label12.Location = New Point(52, 558)
        Label12.Name = "Label12"
        Label12.Size = New Size(111, 28)
        Label12.TabIndex = 51
        Label12.Text = "Phone no 1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(51, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 28)
        Label3.TabIndex = 31
        Label3.Text = "Dob"
        ' 
        ' zipcode
        ' 
        zipcode.Location = New Point(210, 516)
        zipcode.Name = "zipcode"
        zipcode.Size = New Size(236, 27)
        zipcode.TabIndex = 44
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(51, 512)
        Label9.Name = "Label9"
        Label9.Size = New Size(83, 28)
        Label9.TabIndex = 45
        Label9.Text = "Zipcode"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(51, 170)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 28)
        Label4.TabIndex = 35
        Label4.Text = "gender"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(51, 216)
        Label5.Name = "Label5"
        Label5.Size = New Size(138, 28)
        Label5.TabIndex = 37
        Label5.Text = "Address Line 1"
        ' 
        ' addL1
        ' 
        addL1.Location = New Point(210, 220)
        addL1.Name = "addL1"
        addL1.Size = New Size(236, 27)
        addL1.TabIndex = 38
        ' 
        ' addL2
        ' 
        addL2.Location = New Point(210, 274)
        addL2.Name = "addL2"
        addL2.Size = New Size(236, 27)
        addL2.TabIndex = 41
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(52, 466)
        Label8.Name = "Label8"
        Label8.Size = New Size(46, 28)
        Label8.TabIndex = 43
        Label8.Text = "City"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(51, 313)
        Label7.Name = "Label7"
        Label7.Size = New Size(138, 28)
        Label7.TabIndex = 40
        Label7.Text = "Address Line 3"
        ' 
        ' addL3
        ' 
        addL3.Location = New Point(210, 314)
        addL3.Name = "addL3"
        addL3.Size = New Size(236, 27)
        addL3.TabIndex = 42
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(51, 270)
        Label6.Name = "Label6"
        Label6.Size = New Size(138, 28)
        Label6.TabIndex = 39
        Label6.Text = "Address Line 2"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(51, 420)
        Label10.Name = "Label10"
        Label10.Size = New Size(56, 28)
        Label10.TabIndex = 47
        Label10.Text = "State"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(51, 371)
        Label11.Name = "Label11"
        Label11.Size = New Size(82, 28)
        Label11.TabIndex = 48
        Label11.Text = "Country"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(DataGridView1)
        Panel2.Controls.Add(searchBox)
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(488, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(783, 958)
        Panel2.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(40, 116)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(731, 672)
        DataGridView1.TabIndex = 67
        ' 
        ' searchBox
        ' 
        searchBox.Location = New Point(148, 30)
        searchBox.Name = "searchBox"
        searchBox.Size = New Size(544, 27)
        searchBox.TabIndex = 66
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(40, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 28)
        Label1.TabIndex = 65
        Label1.Text = "Search"
        ' 
        ' AddUser
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1271, 958)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        ForeColor = Color.Black
        Name = "AddUser"
        Text = "AddUser"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        gender.ResumeLayout(False)
        gender.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents email As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ph1 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents zipcode As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents addL3 As TextBox
    Friend WithEvents addL2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents addL1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lastname As TextBox
    Friend WithEvents firstname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents gender As GroupBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents searchBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label13 As Label
End Class
