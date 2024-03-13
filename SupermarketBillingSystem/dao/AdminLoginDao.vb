Imports MySql.Data.MySqlClient

Public Class AdminLoginDao
    Public Function adminLoginDao(id As String, pass As String) As Boolean
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader

        Dim q = "select * from admin_creds where admin_id = '" + id + "' and password = '" + pass + "';"
        con = New DBConnection().getConnection()
        cmd = New MySqlCommand(q, con)
        dr = cmd.ExecuteReader

        If (dr.Read) Then
            Return True


        End If

        Return False
    End Function
End Class
