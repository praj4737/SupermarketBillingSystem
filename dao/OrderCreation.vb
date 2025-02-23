Imports MySql.Data.MySqlClient

Public Class OrderCreation
    Public Function createOrder(order_id As String, customer_id As String, order_date As Date, total_amt As String) As Boolean
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim r As Integer
        Dim q = "insert into orders values('" + order_id + "','" + customer_id + "','" + order_date.ToString("yyyyMMdd") + "','" + total_amt + "');"
        con = New DBConnection().getConnection()
        cmd = New MySqlCommand(q, con)
        r = cmd.ExecuteNonQuery

        If r > -1 Then
            Return True
        End If

        Return False
    End Function
    Public Function createOrderItems(order_item_id As String, order_id As String, product_id As String, quantity As String, item_total As String) As Boolean
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim r As Integer
        Dim q = "insert into orderitems values('" + order_item_id + "','" + order_id + "','" + product_id + "','" + quantity + "','" + item_total + "');"
        con = New DBConnection().getConnection()
        cmd = New MySqlCommand(q, con)

        Try
            r = cmd.ExecuteNonQuery
        Catch ex As Exception
            MessageBox.Show("exception was occured here.")
        End Try

        If r > -1 Then
            Return True
        End If

        Return False
    End Function
    Public Function getOrderId() As String
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        Dim q = "select count(*) from orders;"
        con = New DBConnection().getConnection()
        cmd = New MySqlCommand(q, con)
        Dim count = CInt(cmd.ExecuteScalar())
        count += 1
        Return "ordr" + CStr(count)

    End Function
    Public Function getOrder_item_id() As String
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        Dim q = "select count(*) from orderitems;"
        con = New DBConnection().getConnection()
        cmd = New MySqlCommand(q, con)
        Dim count = CInt(cmd.ExecuteScalar())
        count += 1
        Return "order_item_id" + CStr(count)

    End Function
End Class
