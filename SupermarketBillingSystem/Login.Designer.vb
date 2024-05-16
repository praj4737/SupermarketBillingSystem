<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        message = New Label()
        loginLabel = New Label()
        pass = New Label()
        FileSystemWatcher1 = New IO.FileSystemWatcher()
        userId = New TextBox()
        password = New TextBox()
        uid = New Label()
        Button1 = New Button()
        Label1 = New Label()
        loginType = New ComboBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Navy
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(250, 432)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(3, 96)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(247, 220)
        Panel2.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.logo1
        PictureBox1.Location = New Point(25, 23)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(173, 162)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' message
        ' 
        message.AutoSize = True
        message.BackColor = Color.White
        message.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        message.Location = New Point(327, 119)
        message.Name = "message"
        message.Size = New Size(72, 19)
        message.TabIndex = 11
        message.Text = "Message"
        ' 
        ' loginLabel
        ' 
        loginLabel.AutoSize = True
        loginLabel.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        loginLabel.Location = New Point(413, 66)
        loginLabel.Name = "loginLabel"
        loginLabel.Size = New Size(75, 31)
        loginLabel.TabIndex = 1
        loginLabel.Text = "Login"
        ' 
        ' pass
        ' 
        pass.AutoSize = True
        pass.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        pass.Location = New Point(304, 251)
        pass.Name = "pass"
        pass.Size = New Size(82, 23)
        pass.TabIndex = 3
        pass.Text = "Password"
        ' 
        ' FileSystemWatcher1
        ' 
        FileSystemWatcher1.EnableRaisingEvents = True
        FileSystemWatcher1.SynchronizingObject = Me
        ' 
        ' userId
        ' 
        userId.BorderStyle = BorderStyle.FixedSingle
        userId.Location = New Point(413, 203)
        userId.Name = "userId"
        userId.Size = New Size(192, 27)
        userId.TabIndex = 4
        ' 
        ' password
        ' 
        password.BorderStyle = BorderStyle.FixedSingle
        password.Location = New Point(413, 250)
        password.Name = "password"
        password.PasswordChar = "*"c
        password.Size = New Size(192, 27)
        password.TabIndex = 5
        ' 
        ' uid
        ' 
        uid.AutoSize = True
        uid.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        uid.Location = New Point(304, 207)
        uid.Name = "uid"
        uid.Size = New Size(61, 23)
        uid.TabIndex = 6
        uid.Text = "UserID"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Navy
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(413, 297)
        Button1.Name = "Button1"
        Button1.Size = New Size(101, 43)
        Button1.TabIndex = 7
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(304, 163)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 23)
        Label1.TabIndex = 9
        Label1.Text = "User Type"
        ' 
        ' loginType
        ' 
        loginType.FormattingEnabled = True
        loginType.Items.AddRange(New Object() {"Select User Type", "Admin", "Sales"})
        loginType.Location = New Point(413, 158)
        loginType.Name = "loginType"
        loginType.Size = New Size(192, 28)
        loginType.TabIndex = 10
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(717, 432)
        Controls.Add(message)
        Controls.Add(loginType)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(uid)
        Controls.Add(password)
        Controls.Add(userId)
        Controls.Add(pass)
        Controls.Add(loginLabel)
        Controls.Add(Panel1)
        ForeColor = Color.Black
        MaximizeBox = False
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login Page"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents loginLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pass As Label
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents uid As Label
    Friend WithEvents password As TextBox
    Friend WithEvents userId As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents loginType As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents message As Label
End Class
