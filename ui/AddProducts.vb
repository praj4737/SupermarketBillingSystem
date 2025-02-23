Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class AddProducts
    Public pid As Integer
    Private dt As New DataTable
    Private sno As Integer
    Public serial As Integer = 0
    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub





    Private Sub AddProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pid = getProductId()
        ProductsGrid.ForeColor = Color.Black
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader

        Dim q = "select category from products;"
        Dim q1 = "select manufacturer from products;"
        con = New DBConnection().getConnection()

        cmd = New MySqlCommand(q, con)
        dr = cmd.ExecuteReader
        While dr.Read
            category.Items.Add(dr("category"))
        End While
        dr.Close()
        cmd = New MySqlCommand(q1, con)
        dr = cmd.ExecuteReader
        While (dr.Read)
            manufacturer.Items.Add(dr("manufacturer"))
        End While


        dt.Columns.Add("S.N.")
        dt.Columns.Add("Product_Id")
        dt.Columns.Add("P_Name")
        dt.Columns.Add("Category")
        dt.Columns.Add("Manufac.")
        dt.Columns.Add("MFG_Dt")
        dt.Columns.Add("EXP_Dt")
        dt.Columns.Add("QTY")
        dt.Columns.Add("Price")
        dt.Columns.Add("Batch No")
        dt.Columns.Add("Status")
        ProductsGrid.DataSource = dt
    End Sub

    Private Function getProductId() As Integer

        Dim count As Integer
        Dim product_id As Integer
        Dim con As MySqlConnection
        con = New DBConnection().getConnection()
        Dim ad As MySqlDataReader
        Dim command As MySqlCommand
        Dim q = "select count(*) from products;"
        con = New DBConnection().getConnection()
        command = New MySqlCommand(q, con)
        count = Convert.ToInt16(command.ExecuteScalar) + Rnd() * 100 + Rnd()
        product_id = count + 1

        Return product_id


    End Function

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        For i As Integer = 0 To sno
            Dim p As New Products()
            'p.product_id=ProductsGrid.Rows(i).Cells(0).Value.ToString()

            ProductsGrid.Rows(i).Cells(10).Value = "Saved"


        Next

    End Sub

    Private Sub AddProductsToList_Click(sender As Object, e As EventArgs) Handles AddProductsToList.Click
        Dim newRow As DataRow = ProductsGrid.DataSource.Rows.Add()

        sno = sno + 1
        newRow(0) = sno



        newRow(1) = "P" + CStr(pid)
        pid += 1
        newRow(2) = TextBox3.Text
        If category.SelectedItem = "" Then
            newRow(3) = category.Text
        Else
            newRow(3) = category.SelectedItem
        End If


        If manufacturer.SelectedItem = "" Then
            newRow(4) = manufacturer.Text
        Else
            newRow(4) = manufacturer.SelectedItem
        End If

        newRow(8) = TextBox6.Text

        newRow(5) = (DateTimePicker1.Value)
        newRow(6) = (DateTimePicker2.Value)
        newRow(7) = TextBox5.Text
        newRow(9) = TextBox1.Text

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'x = dgvName.Rows(yourRowIndex).Cells(yourColumnIndex).Value
        Dim p, p1 As New Products()

        p.product_id = ProductsGrid.Rows(serial).Cells(1).Value
        p.product_name = ProductsGrid.Rows(serial).Cells(2).Value
        p.category = ProductsGrid.Rows(serial).Cells(3).Value
        p.manufacturer = ProductsGrid.Rows(serial).Cells(4).Value
        p.mfg_date = ProductsGrid.Rows(serial).Cells(5).Value
        p.exp_date = ProductsGrid.Rows(serial).Cells(6).Value
        p.quantity = ProductsGrid.Rows(serial).Cells(7).Value
        p.price = ProductsGrid.Rows(serial).Cells(8).Value

        p.batch_id = ProductsGrid.Rows(serial).Cells(9).Value
        Dim dao As New ProductDao()
        Dim res = dao.addProductsDao(p)
        If res = True Then
            ProductsGrid.Rows(serial).Cells(10).Value = "saved"
            serial += 1
        Else
            ProductsGrid.Rows(serial).Cells(10).Value = "not saved"

        End If



    End Sub
End Class