Imports System.ComponentModel.Design.Serialization
Imports System.Security.Cryptography
Imports System.Xml.Schema
Imports MySql.Data.MySqlClient

Public Class PointOfSale
    Dim count = 0
    Dim table As New DataTable
    Dim billtable As New DataTable
    Public rowCount As Integer = 0
    Public sno As Integer
    Dim totalVar As Double = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim productName = Me.productName.Text

        Dim table As New DataTable
        Dim adptr As MySqlDataAdapter
        adptr = New ProductDao().searchProduct(productName)
        adptr.Fill(table)
        ' table.Clear()
        productlist.DataSource = table


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim dao As New CustomerDAO
        Dim table As DataTable
        table = dao.searchCustomer(TextBox2.Text)
        customerdetail.DataSource = table
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged_1(sender As Object, e As EventArgs) Handles productName.TextChanged
        If productName.Text.Length > 0 Then
            Dim con As MySqlConnection
            Dim ad As MySqlDataAdapter
            Dim table As New DataTable
            con = New DBConnection().getConnection()
            ad = New ProductDao().searchProduct(productName.Text)
            ad.Fill(table)
            productlist.DataSource = table
        Else
            Dim table1 As New DataTable
            productlist.DataSource = table1
        End If
    End Sub

    Private Sub productlist_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles productlist.CellClick


        Dim selectedRow As DataGridViewRow = productlist.CurrentRow
        Dim newRow As DataRow = table.NewRow()
        Dim newRow1 As DataRow = billtable.NewRow()

        newRow("Product_id") = selectedRow.Cells(0).Value
        newRow("batch_id") = selectedRow.Cells(1).Value
        newRow("product_name") = selectedRow.Cells(2).Value
        newRow1("product_name") = selectedRow.Cells(2).Value

        newRow("category") = selectedRow.Cells(3).Value
        newRow("quantity") = "1"
        newRow1("quantity") = quantity.Text

        newRow("price") = selectedRow.Cells(5).Value
        newRow1("price") = selectedRow.Cells(5).Value

        newRow("mfg_date") = selectedRow.Cells(8).Value
        newRow("exp_date") = selectedRow.Cells(9).Value

        table.Rows.Add(newRow)
        billtable.Rows.Add(newRow1)


        ' totalVar = totalVar + CDbl(selectedRow.Cells(5).Value)
        'totalValue.Text = CStr(totalVar)







    End Sub

    Private Sub PointOfSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        table.Columns.Add("Product_id")
        table.Columns.Add("batch_id")
        table.Columns.Add("product_name")
        billtable.Columns.Add("product_name")

        table.Columns.Add("category")
        table.Columns.Add("quantity")
        billtable.Columns.Add("quantity")

        table.Columns.Add("price")
        billtable.Columns.Add("price")

        table.Columns.Add("mfg_date")
        table.Columns.Add("exp_date")

        BillList.DataSource = table

        paymentType.Items.Add("Cash")
        paymentType.Items.Add("UPI")

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        GlobalConstants.table = billtable
        GlobalConstants.total = CDbl(totalValue.Text)
        GlobalConstants.paymentType = paymentType.SelectedItem
        GlobalConstants.customerName = customerNameTxtbox.Text
        Bill.Visible = True
        'database 

        Dim serial As Integer = 0


        Dim order_id As String
        Dim customer_id As String
        Dim order_date As Date
        Dim total_amt As Double

        Dim order_item_id As String
        Dim product_id As String
        Dim quantity As Integer
        Dim item_total As Double
        Dim selectedRow As DataGridViewRow = customerdetail.CurrentRow
        order_id = New OrderCreation().getOrderId()
        customer_id = customerdetail.Rows(0).Cells(0).Value
        order_date = Date.Now().ToString("d")
        total_amt = CDbl(totalVar)



        If New OrderCreation().createOrder(order_id, customer_id, order_date, total_amt) Then
            ' MessageBox.Show("order saved sucessfully")
        Else
            ' MessageBox.Show("cannot save order.")
            Return
        End If


        MessageBox.Show(BillList.RowCount)
        While serial <= BillList.RowCount

            order_item_id = New OrderCreation().getOrder_item_id()
            Try
                product_id = BillList.Rows(serial).Cells(0).Value

                quantity = BillList.Rows(serial).Cells(4).Value
                item_total = CDbl(totalVar)
                serial += 1
                If New OrderCreation().createOrderItems(order_item_id, order_id, product_id, quantity, item_total) Then
                    ' MessageBox.Show("product sold.")

                Else
                    ' MessageBox.Show("cannot sold product.")
                End If
            Catch ex As Exception

            End Try
        End While

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim cus As New Customer()
        cus.customer_id = New CustomerDAO().getCustomerId()
        cus.mobile = TextBox2.Text
        cus.customer_name = customerNameTxtbox.Text

        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        Dim q = "insert into customer values('" + cus.customer_id + "','" + cus.customer_name + "','" + cus.mobile + "');"

        con = New DBConnection().getConnection()
        cmd = New MySqlCommand(q, con)
        Dim row = cmd.ExecuteNonQuery()

        If row > 0 Then
            customerdetail.DataSource = New CustomerDAO().displayCustomer(cus.customer_id)
        Else
            MessageBox.Show("failed to create customer due to technical error.")
        End If


    End Sub


    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        totalValue.Text = 0
        totalVar = 0
        Dim row = 0
        While row < BillList.RowCount
            totalVar = totalVar + CInt((BillList.Rows(row).Cells(4).Value) * CDbl(BillList.Rows(row).Cells(5).Value))
            row += 1
        End While
        totalValue.Text = totalVar

    End Sub

    '  Private Sub BillList_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles BillList.CellValueChanged
    ' If BillList.Rows.Count > 0 Then
    'If e.ColumnIndex = 4 Then
    'Dim quantity As Integer = CInt(BillList.Rows(e.RowIndex).Cells(4).Value)
    '          totalVar = totalVar + CDbl(BillList.Rows(e.RowIndex).Cells(5).Value)
    '        totalValue.Text = CStr(totalVar)
    'End If
    'End If
    ' End Sub

    Public Function createBill()



    End Function

    Private Sub customerdetail_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles customerdetail.CellDoubleClick
        TextBox2.Text = customerdetail.Rows(0).Cells(2).Value
        customerNameTxtbox.Text = customerdetail.Rows(0).Cells(1).Value
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class