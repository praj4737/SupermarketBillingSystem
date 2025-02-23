<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminHomePageV2
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
        Panel3 = New Panel()
        Button7 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel2 = New Panel()
        username = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel4 = New Panel()
        Heading = New Label()
        FormsPannel = New Panel()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Navy
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(250, 564)
        Panel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Button7)
        Panel3.Controls.Add(Button6)
        Panel3.Controls.Add(Button5)
        Panel3.Controls.Add(Button4)
        Panel3.Controls.Add(Button3)
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(Button1)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 205)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(250, 359)
        Panel3.TabIndex = 2
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Navy
        Button7.Dock = DockStyle.Top
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Location = New Point(0, 306)
        Button7.Name = "Button7"
        Button7.Size = New Size(250, 51)
        Button7.TabIndex = 7
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Navy
        Button6.Dock = DockStyle.Top
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Location = New Point(0, 255)
        Button6.Name = "Button6"
        Button6.Size = New Size(250, 51)
        Button6.TabIndex = 6
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Navy
        Button5.Dock = DockStyle.Top
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Location = New Point(0, 204)
        Button5.Name = "Button5"
        Button5.Size = New Size(250, 51)
        Button5.TabIndex = 5
        Button5.Text = "Add Users"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Navy
        Button4.Dock = DockStyle.Top
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Location = New Point(0, 153)
        Button4.Name = "Button4"
        Button4.Size = New Size(250, 51)
        Button4.TabIndex = 4
        Button4.Text = "Search Product"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Navy
        Button3.Dock = DockStyle.Top
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(0, 102)
        Button3.Name = "Button3"
        Button3.Size = New Size(250, 51)
        Button3.TabIndex = 3
        Button3.Text = "Delete Inventory"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Navy
        Button2.Dock = DockStyle.Top
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(0, 51)
        Button2.Name = "Button2"
        Button2.Size = New Size(250, 51)
        Button2.TabIndex = 2
        Button2.Text = "Update Inventor"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Navy
        Button1.Dock = DockStyle.Top
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(0, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(250, 51)
        Button1.TabIndex = 1
        Button1.Text = "Add Inventory"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(username)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(250, 205)
        Panel2.TabIndex = 1
        ' 
        ' username
        ' 
        username.AutoSize = True
        username.ForeColor = Color.White
        username.Location = New Point(52, 171)
        username.Name = "username"
        username.Size = New Size(82, 20)
        username.TabIndex = 1
        username.Text = "User Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Lime
        Label1.Location = New Point(33, 171)
        Label1.Name = "Label1"
        Label1.Size = New Size(13, 20)
        Label1.TabIndex = 1
        Label1.Text = " "
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.logo1
        PictureBox1.Location = New Point(33, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(174, 157)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Navy
        Panel4.Controls.Add(Heading)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(250, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(550, 65)
        Panel4.TabIndex = 1
        ' 
        ' Heading
        ' 
        Heading.AutoSize = True
        Heading.Location = New Point(39, 21)
        Heading.Name = "Heading"
        Heading.Size = New Size(53, 20)
        Heading.TabIndex = 0
        Heading.Text = "Label2"
        ' 
        ' FormsPannel
        ' 
        FormsPannel.BackColor = Color.White
        FormsPannel.Dock = DockStyle.Fill
        FormsPannel.Location = New Point(250, 65)
        FormsPannel.Name = "FormsPannel"
        FormsPannel.Size = New Size(550, 499)
        FormsPannel.TabIndex = 2
        ' 
        ' AdminHomePageV2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 564)
        Controls.Add(FormsPannel)
        Controls.Add(Panel4)
        Controls.Add(Panel1)
        ForeColor = Color.White
        Name = "AdminHomePageV2"
        Text = "Add Product"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents username As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Heading As Label
    Friend WithEvents FormsPannel As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
End Class
