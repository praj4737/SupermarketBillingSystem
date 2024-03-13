Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class PointOfSale
    Dim table As New DataTable
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
        table = dao.searchProduct(TextBox2.Text)
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
        newRow("Product_id") = selectedRow.Cells(0).Value
        newRow("batch_id") = selectedRow.Cells(1).Value
        newRow("product_name") = selectedRow.Cells(2).Value
        newRow("category") = selectedRow.Cells(3).Value
        newRow("quantity") = quantity.Text
        newRow("price") = selectedRow.Cells(5).Value
        newRow("mfg_date") = selectedRow.Cells(8).Value
        newRow("exp_date") = selectedRow.Cells(9).Value

        table.Rows.Add(newRow)

        totalVar = totalVar + CDbl(selectedRow.Cells(5).Value)
        totalValue.Text = CStr(totalVar)







    End Sub

    Private Sub PointOfSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        table.Columns.Add("Product_id")
        table.Columns.Add("batch_id")
        table.Columns.Add("product_name")
        table.Columns.Add("category")
        table.Columns.Add("quantity")
        table.Columns.Add("price")
        table.Columns.Add("mfg_date")
        table.Columns.Add("exp_date")

        BillList.DataSource = table

        paymentType.Items.Add("Cash")
        paymentType.Items.Add("UPI")

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        GlobalConstants.table = table
        GlobalConstants.total = CDbl(totalValue.Text)
        GlobalConstants.paymentType = paymentType.SelectedItem
        Bill.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim phoneNo As String
        Dim name As String
        Dim pid As String
        pid = New CustomerDAO().getCustomerId()
        phoneNo = TextBox2.Text
        name = TextBox1.Text

        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        Dim q = "insert into customer values('" + pid + "','" + name + "','" + phoneNo + "');"

        con = New DBConnection().getConnection()
        cmd = New MySqlCommand(q, con)
        Dim row = cmd.ExecuteNonQuery()


    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class