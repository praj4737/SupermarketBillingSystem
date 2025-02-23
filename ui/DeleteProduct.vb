Imports MySql.Data.MySqlClient

Public Class DeleteProduct
    Private Sub DeleteProduct_Load(sender As Object, e As EventArgs)
        Dim d As New ProductDao
        productsViewTable.DataSource = d.viewProducts()
    End Sub



    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        Dim con As MySqlConnection
        Dim ad As MySqlDataAdapter
        Dim table As New DataTable
        con = New DBConnection().getConnection()
        ad = New ProductDao().searchProduct(SearchBox.Text)
        ad.Fill(table)
        productsViewTable.DataSource = table


    End Sub

    Private Sub productsViewTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub productsViewTable_SelectionChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub productsViewTable_CellClick(sender As Object, e As DataGridViewCellEventArgs)

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

    Private Sub SearchBox_StyleChanged(sender As Object, e As EventArgs) Handles SearchBox.StyleChanged

    End Sub

    Private Sub productsViewTable_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim selectionBox As DialogResult
        selectionBox = MessageBox.Show("are you sure !! you want to delete this product??", "Warning !", MessageBoxButtons.YesNo)
        Dim selectedRow As DataGridViewRow = productsViewTable.CurrentRow
        If selectedRow Is Nothing Then
            MessageBox.Show("Empty Row Can't be deleted", "Error !")
        Else
            If selectionBox = DialogResult.Yes Then
                Dim pid As String = selectedRow.Cells(0).Value
                Dim dao As New ProductDao
                Dim res = dao.deleteProduct(pid)
                If res = True Then
                    MessageBox.Show("Product Deleted Sucessfully.", "Success")
                    Dim d As New ProductDao
                    productsViewTable.DataSource = d.viewProducts()
                Else
                    MessageBox.Show("Error while Deleting product..", "Error !!")
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selectedRowCount As Integer = productsViewTable.SelectedRows.Count
        Dim dao As New ProductDao
        Dim staus As Boolean = True
        'Dim selectionBox = MessageBox.Show("are you sure!! you want to delete this product??", "Warning !", MessageBoxButtons.YesNo)
        If selectedRowCount > 0 Then
            Dim selectionBox = MessageBox.Show("are you sure!! you want to delete this product??", "Warning !", MessageBoxButtons.YesNo)
            If selectionBox = DialogResult.Yes Then
                For Each row As DataGridViewRow In productsViewTable.SelectedRows
                    Dim pid As String = row.Cells(0).Value
                    Dim res As Boolean = dao.deleteProduct(pid)
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
            MessageBox.Show("Failed! to delete some items", "Error")
        Else
            MessageBox.Show("Successfully deleted Items")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub DeleteProduct_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As MySqlConnection
        Dim ad As MySqlDataAdapter
        Dim table As New DataTable
        con = New DBConnection().getConnection()
        table = New ProductDao().viewProducts()
        ' ad.Fill(table)
        productsViewTable.DataSource = table
    End Sub
End Class