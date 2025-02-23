Imports MySql.Data.MySqlClient

Public Class DBConnection
    Public Function getConnection() As MySqlConnection
        Dim con As New MySqlConnection()
        con.ConnectionString = "server=localhost;user=root;password=Computer@123;database=abcmartv2"
        con.Open()

        Return con


    End Function
End Class
