Public Class AdminHomePageV2
    Private currentForm As Form
    Private Sub AdminHomePageV2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username.Text = GlobalConstants.userId
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        openChildForm(New AddProducts)
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.DarkBlue

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        openChildForm(New UpdateProduct)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        openChildForm(New DeleteProduct)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        openChildForm(New SearchProduct)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        openChildForm(New AddUser)
    End Sub
    Private Sub openChildForm(childForm As Form)
        Dim selection As DialogResult
        If currentForm IsNot Nothing Then
            selection = MessageBox.Show("Are you sure, you want to close current task", "Confirmation", MessageBoxButtons.OKCancel)
            If selection = DialogResult.OK Then
                currentForm.Close()
            Else
                Exit Sub
            End If
        End If
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        FormsPannel.Controls.Add(childForm)
        FormsPannel.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        Heading.Text = childForm.Text

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        openChildForm(New ViewUsers)
    End Sub

    Private Sub FormsPannel_Paint(sender As Object, e As PaintEventArgs) Handles FormsPannel.Paint

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub
End Class