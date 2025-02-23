Public Class AdminLoginController
    Public Function adminLoginController(id As String, pass As String) As Boolean
        Dim resp = New AdminLoginService().adminLoginService(id, pass)
        Return resp
    End Function
End Class
