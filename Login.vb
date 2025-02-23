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
            If loginType.SelectedIndex = 1 Then
                If user = "" Or pass = "" Then
                    showMessage("pls enter user name or password", Color.Orange, Color.White)
                Else
                    If New LoginDao().adminLoginDao(user, pass) Then
                        AdminHomePageV2.Visible = True
                        Me.Visible = False
                    Else
                        showMessage("wrong username or password", Color.Red, Color.White)
                    End If
                End If
            ElseIf loginType.SelectedIndex = 2 Then
                If user = "" Or pass = "" Then
                    showMessage("pls enter user name or password", Color.Orange, Color.White)
                Else
                    If New LoginDao().salesLogin(user, pass) Then
                        SalesHomePage.Visible = True
                        Me.Visible = False
                    Else
                        showMessage("wrong username or password", Color.Red, Color.White)
                    End If
                End If
            End If

        Else
            showMessage("pls select User type first", Color.Orange, Color.White)
        End If


    End Sub
    Private Sub showMessage(msg As String, backColor As Color, foreColor As Color)
        message.Text = msg
        message.BackColor = backColor
        message.ForeColor = foreColor
        message.Visible = True
    End Sub
End Class
