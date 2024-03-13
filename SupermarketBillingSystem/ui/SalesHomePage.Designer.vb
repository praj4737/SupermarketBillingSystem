<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesHomePage
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
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        username = New Label()
        Label1 = New Label()
        Button4 = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Panel4 = New Panel()
        FormsPannel = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Navy
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button3)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(250, 693)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(username)
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(250, 136)
        Panel2.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.logo1
        PictureBox1.Location = New Point(24, -3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(201, 136)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.Location = New Point(256, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(707, 447)
        Panel3.TabIndex = 9
        ' 
        ' username
        ' 
        username.AutoSize = True
        username.ForeColor = Color.White
        username.Location = New Point(53, 176)
        username.Name = "username"
        username.Size = New Size(82, 20)
        username.TabIndex = 2
        username.Text = "User Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Lime
        Label1.Location = New Point(34, 176)
        Label1.Name = "Label1"
        Label1.Size = New Size(13, 20)
        Label1.TabIndex = 3
        Label1.Text = " "
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Navy
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = Color.White
        Button4.Location = New Point(0, 295)
        Button4.Name = "Button4"
        Button4.Size = New Size(250, 51)
        Button4.TabIndex = 8
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Navy
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(0, 160)
        Button1.Name = "Button1"
        Button1.Size = New Size(250, 51)
        Button1.TabIndex = 5
        Button1.Text = "Point of Sale"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Navy
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(0, 210)
        Button2.Name = "Button2"
        Button2.Size = New Size(250, 40)
        Button2.TabIndex = 6
        Button2.Text = "View Sale"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Navy
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(0, 247)
        Button3.Name = "Button3"
        Button3.Size = New Size(250, 51)
        Button3.TabIndex = 7
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(250, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(717, 59)
        Panel4.TabIndex = 9
        ' 
        ' FormsPannel
        ' 
        FormsPannel.BackColor = Color.White
        FormsPannel.Dock = DockStyle.Fill
        FormsPannel.Location = New Point(250, 59)
        FormsPannel.Name = "FormsPannel"
        FormsPannel.Size = New Size(717, 634)
        FormsPannel.TabIndex = 10
        ' 
        ' SalesHomePage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(967, 693)
        Controls.Add(FormsPannel)
        Controls.Add(Panel4)
        Controls.Add(Panel1)
        Name = "SalesHomePage"
        Text = "SalesHomePage"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents username As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents FormsPannel As Panel
End Class
