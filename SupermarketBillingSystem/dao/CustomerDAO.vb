Imports MySql.Data.MySqlClient

Public Class CustomerDAO

    Public Function searchCustomer(phone As String) As DataTable
        Dim con As MySqlConnection
        Dim ad As MySqlDataAdapter
        Dim table As New DataTable
        ' Dim table As New DataTable
        Dim q = "select * from customer where mobile_number like '%" + phone + "%';"
        con = New DBConnection().getConnection()
        ad = New MySqlDataAdapter(q, con)
        ad.Fill(table)

        Return table

    End Function
    Public Function getCustomerId() As String
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        Dim q = "select count(*) from customer;"
        con = New DBConnection().getConnection()
        cmd = New MySqlCommand(q, con)
        Dim count = CInt(cmd.ExecuteScalar())
        count += 1
        Return "cus" + CStr(count)

    End Function
    Public Function displayCustomer(pid As String) As DataTable
        Dim con As MySqlConnection
        Dim ad As MySqlDataAdapter
        Dim table As New DataTable
        Dim row As Integer

        Dim q = "select * from customer where customer_id = '" + pid + "';"
        con = New DBConnection().getConnection()
        ad = New MySqlDataAdapter(q, con)
        ad.Fill(table)

        Return table
    End Function
End Class
