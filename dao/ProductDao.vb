Imports MySql.Data.MySqlClient
Imports ZstdSharp.Unsafe

Public Class ProductDao
    Public Function addProductsDao(p As Products) As Boolean
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim r As Integer
        Dim q = "insert into products values('" + p.product_id + "','" + p.batch_id + "','" + p.product_name + "','" + p.category + "','" + p.quantity + "','" + p.price + "','" + p.manufacturer + "','" + p.description + "','" + (p.mfg_date).ToString("yyyyMMdd") + "','" + (p.exp_date).ToString("yyyyMMdd") + "');"
        con = New DBConnection().getConnection()
        cmd = New MySqlCommand(q, con)
        r = cmd.ExecuteNonQuery

        If r > -1 Then
            Return True
        End If

        Return False
    End Function

    Public Function addProductStock(s As Stock) As Boolean
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        Dim q = "insert into stock values('" + s.stock_id + "','" + s.batch_id + "'," + s.quantity + ",'" + (s.stock_date).ToString("yyyyMMdd") + "');"
        con = New DBConnection().getConnection()
        cmd = New MySqlCommand(q, con)
        Dim r = cmd.ExecuteNonQuery
        If (r > -1 And UpdateProductQuantityInProductstable(s.batch_id, s.quantity) = True) Then
            Return True
        End If
        Return False
    End Function


    Public Function UpdateProductQuantityInProductstable(batch As String, quant As String) As Boolean
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        Dim q = "update products set quantity = quantity+" + quant + " where batch_id = '" + batch + "';"
        con = New DBConnection().getConnection()
        cmd = New MySqlCommand(q, con)
        Dim r = cmd.ExecuteNonQuery
        If (r > -1) Then
            Return True
        End If
        Return False
    End Function

    Public Function viewProducts() As DataTable
        Dim con As MySqlConnection
        Dim ad As MySqlDataAdapter
        Dim table As New DataTable
        Dim q = "select * from products;"
        con = New DBConnection().getConnection()
        ad = New MySqlDataAdapter(q, con)
        ad.Fill(table)

        Return table

    End Function

    Public Function searchProduct(productName As String) As MySqlDataAdapter
        Dim con As MySqlConnection
        Dim ad As MySqlDataAdapter
        ' Dim table As New DataTable
        Dim q = "select * from products where product_name like '%" + productName + "%';"
        con = New DBConnection().getConnection()
        ad = New MySqlDataAdapter(q, con)


        Return ad

    End Function

    Public Function deleteProduct(pid As String) As Boolean
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim r As Integer
        Dim q = "delete from products where product_id = '" + pid + "';"
        con = New DBConnection().getConnection()
        cmd = New MySqlCommand(q, con)
        r = cmd.ExecuteNonQuery

        If r > 0 Then
            Return True
        End If

        Return False
    End Function

    Public Function updateProduct(p As Products) As Boolean
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim r As Integer
        Dim q = "update products set batch_id = '" + p.batch_id + "',product_name = '" + p.product_name + "',category = '" + p.category + "',quantity = '" + p.quantity + "',price = '" + p.price + "',manufacturer = '" + p.manufacturer + "',description = '" + p.description + "',mfg_date = '" + p.mfg_date.ToString("yyyyMMdd") + "',exp_date = '" + p.exp_date.ToString("yyyyMMdd") + "' where product_id = '" + p.product_id + "';"
        con = New DBConnection().getConnection()
        MessageBox.Show("reached here below con")
        cmd = New MySqlCommand(q, con)
        MessageBox.Show("reached here below cmd")

        r = cmd.ExecuteNonQuery
        MessageBox.Show("reached here below row")
        MessageBox.Show(r)

        If r > 0 Then
            Return True
        End If

        Return False
    End Function

End Class
