Public Class AdminLoginService
    Public Function adminLoginService(id As String, pass As String) As Boolean
        Dim resp = New LoginDao().adminLoginDao(id, pass)
        Return resp
    End Function
End Class
