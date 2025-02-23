Imports System.Windows

Public Class SalesHomePage
    Private currentForm As Form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        openChildForm(New PointOfSale)
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
        'Heading.Text = childForm.Text

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub FormsPannel_Paint(sender As Object, e As PaintEventArgs) Handles FormsPannel.Paint

    End Sub
End Class