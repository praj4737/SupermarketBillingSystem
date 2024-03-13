Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Login
    Private Sub Login(sender As Object, e As EventArgs) Handles MyBase.Load
        ' PointOfSale.Visible = True
        ' AddProducts.Visible = True
        loginType.SelectedIndex = 0
        message.Visible = False


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user = userId.Text
        Dim pass = password.Text
        If loginType.SelectedIndex > 0 Then

            If userId.Text.Length > 0 And password.Text.Length > 0 Then
                If New AdminLoginController().adminLoginController(user, pass) = True Then
                    If loginType.SelectedIndex = 1 Then
                        GlobalConstants.userId = user
                        AdminHomePageV2.Visible = True

                    End If
                    If loginType.SelectedIndex = 2 Then
                        GlobalConstants.userId = user
                        PointOfSale.Visible = True

                    End If
                    Me.Visible = False
                Else
                    showMessage("Wrong User ID and Pass", Color.Red, Color.White)

                End If
            Else
                showMessage("Please Enter UID and Password", Color.Orange, Color.White)
                MessageBox.Show("Please Enter UID and Password")
            End If

        Else
            showMessage("Please Select a login type", Color.Red, Color.White)
            MessageBox.Show("Please Select Login Type")
        End If
    End Sub
    Private Sub showMessage(msg As String, backColor As Color, foreColor As Color)
        message.Text = msg
        message.BackColor = backColor
        message.ForeColor = foreColor
        message.Visible = True
    End Sub
End Class
