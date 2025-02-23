Imports MySql.Data.MySqlClient

Public Class UpdateProduct
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selectedRowCount As Integer = productsViewTable.SelectedRows.Count
        Dim dao As New ProductDao
        Dim staus As Boolean = True
        'Dim selectionBox = MessageBox.Show("are you sure!! you want to delete this product??", "Warning !", MessageBoxButtons.YesNo)
        If selectedRowCount > 0 Then
            Dim selectionBox = MessageBox.Show("are you sure!! you want to update this product??", "Warning !", MessageBoxButtons.YesNo)
            If selectionBox = DialogResult.Yes Then
                For Each row As DataGridViewRow In productsViewTable.SelectedRows
                    Dim p As New Products()
                    p.product_id = row.Cells(0).Value
                    p.batch_id = row.Cells(1).Value
                    p.product_name = row.Cells(2).Value
                    p.category = row.Cells(3).Value
                    p.quantity = row.Cells(4).Value
                    p.price = row.Cells(5).Value

                    p.manufacturer = row.Cells(6).Value
                    MessageBox.Show(p.manufacturer)
                    p.description = row.Cells(7).Value
                    p.mfg_date = row.Cells(8).Value
                    p.exp_date = row.Cells(9).Value
                    Dim res As Boolean = dao.updateProduct(p)
                    If res = True Then
                        productsViewTable.Rows.Remove(row)
                    Else
                        staus = False
                    End If

                Next
            End If

        Else
            MessageBox.Show("No Items Selected")
        End If
        If staus = False Then
            MessageBox.Show("Failed! to update some items", "Error")
        Else
            MessageBox.Show("Successfully updated Items")
        End If
    End Sub

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        If SearchBox.Text.Length > 0 Then
            Dim con As MySqlConnection
            Dim ad As MySqlDataAdapter
            Dim table As New DataTable
            con = New DBConnection().getConnection()
            ad = New ProductDao().searchProduct(SearchBox.Text)
            ad.Fill(table)
            productsViewTable.DataSource = table
        Else
            Dim table1 As New DataTable
            productsViewTable.DataSource = table1
        End If
    End Sub

    Private Sub UpdateProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As MySqlConnection
        Dim ad As MySqlDataAdapter
        Dim table As New DataTable
        con = New DBConnection().getConnection()
        table = New ProductDao().viewProducts()
        ' ad.Fill(table)
        productsViewTable.DataSource = table
    End Sub
End Class