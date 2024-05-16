<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bill
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
        Label10 = New Label()
        Label9 = New Label()
        timeLabel = New Label()
        datelabel = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        TotalBill = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        customerName = New Label()
        print = New Button()
        Panel1.SuspendLayout()
        CType(TotalBill, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(timeLabel)
        Panel1.Controls.Add(datelabel)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(595, 87)
        Panel1.TabIndex = 0
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(193, 48)
        Label10.Name = "Label10"
        Label10.Size = New Size(61, 20)
        Label10.TabIndex = 11
        Label10.Text = "method"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(111, 48)
        Label9.Name = "Label9"
        Label9.Size = New Size(87, 20)
        Label9.TabIndex = 10
        Label9.Text = "Pay Method"
        ' 
        ' timeLabel
        ' 
        timeLabel.AutoSize = True
        timeLabel.Location = New Point(453, 54)
        timeLabel.Name = "timeLabel"
        timeLabel.Size = New Size(53, 20)
        timeLabel.TabIndex = 9
        timeLabel.Text = "Label8"
        ' 
        ' datelabel
        ' 
        datelabel.AutoSize = True
        datelabel.Location = New Point(452, 9)
        datelabel.Name = "datelabel"
        datelabel.Size = New Size(53, 20)
        datelabel.TabIndex = 8
        datelabel.Text = "Label7"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(402, 54)
        Label6.Name = "Label6"
        Label6.Size = New Size(45, 20)
        Label6.TabIndex = 7
        Label6.Text = "Time:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(402, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(44, 20)
        Label5.TabIndex = 6
        Label5.Text = "Date:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(12, 28)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 46)
        Label4.TabIndex = 5
        Label4.Text = "BILL"
        ' 
        ' TotalBill
        ' 
        TotalBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        TotalBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        TotalBill.Location = New Point(0, 93)
        TotalBill.Name = "TotalBill"
        TotalBill.RowHeadersWidth = 51
        TotalBill.RowTemplate.Height = 29
        TotalBill.Size = New Size(592, 472)
        TotalBill.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(392, 601)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 31)
        Label1.TabIndex = 2
        Label1.Text = "Total: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(472, 601)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 31)
        Label2.TabIndex = 3
        Label2.Text = "value"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(-10, 594)
        Label3.Name = "Label3"
        Label3.Size = New Size(300, 38)
        Label3.TabIndex = 4
        Label3.Text = "Thank You ! Visit Again"
        ' 
        ' customerName
        ' 
        customerName.AutoSize = True
        customerName.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        customerName.Location = New Point(41, 644)
        customerName.Name = "customerName"
        customerName.Size = New Size(91, 23)
        customerName.TabIndex = 9
        customerName.Text = "MR. name"
        ' 
        ' print
        ' 
        print.BackColor = Color.Navy
        print.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        print.ForeColor = Color.White
        print.Location = New Point(453, 635)
        print.Name = "print"
        print.Size = New Size(139, 37)
        print.TabIndex = 12
        print.Text = "Print"
        print.UseVisualStyleBackColor = False
        ' 
        ' Bill
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(595, 676)
        Controls.Add(print)
        Controls.Add(customerName)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TotalBill)
        Controls.Add(Panel1)
        Name = "Bill"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(TotalBill, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents timeLabel As Label
    Friend WithEvents datelabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TotalBill As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents customerName As Label
    Friend WithEvents print As Button
End Class
