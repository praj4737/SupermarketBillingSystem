Imports System.Reflection
Imports MySql.Data.MySqlClient

Public Class LoginDao
    Public Function adminLoginDao(id As String, pass As String) As Boolean
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        Dim dr1 As MySqlDataReader

        Dim q = "select role_name from users where user_id = '" + id + "';"
        con = New DBConnection().getConnection()
        cmd = New MySqlCommand(q, con)
        dr = cmd.ExecuteReader

        If (dr.Read) Then
            If dr.GetString(0) = "admin" Then
                dr.Close()
                q = "select * from user_creds where user_id = '" + id + "'and password ='" + pass + "';"
                cmd = New MySqlCommand(q, con)
                dr1 = cmd.ExecuteReader()

                If dr1.Read Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If


        End If

        Return False
    End Function
    Public Function salesLogin(user As String, pass As String) As Boolean
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        Dim dr1 As MySqlDataReader
        Dim q = "select role_name from users where user_id = '" + user + "';"
        con = New DBConnection().getConnection()
        cmd = New MySqlCommand(q, con)
        dr = cmd.ExecuteReader

        If dr.Read Then
            If dr.GetString(0) = "sales" Then
                dr.Close()
                q = "select * from user_creds where user_id = '" + user + "'and password ='" + pass + "';"
                cmd = New MySqlCommand(q, con)
                dr1 = cmd.ExecuteReader()
                If dr1.Read Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If

        End If

        Return False
    End Function
End Class
