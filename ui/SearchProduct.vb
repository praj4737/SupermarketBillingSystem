Imports MySql.Data.MySqlClient

Public Class SearchProduct
    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        If SearchBox.Text.Length > 0 Then
            Dim con As MySqlConnection
            Dim ad As MySqlDataAdapter
            Dim table As New DataTable
            con = New DBConnection().getConnection()
            ad = New ProductDao().searchProduct(SearchBox.Text)
            ad.Fill(table)
            DataGridView1.DataSource = table
        Else
            Dim table1 As New DataTable
            DataGridView1.DataSource = table1
        End If
    End Sub

    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        Dim con As MySqlConnection
        Dim ad As MySqlDataAdapter
        Dim table As New DataTable
        con = New DBConnection().getConnection()
        ad = New ProductDao().searchProduct(SearchBox.Text)
        ad.Fill(table)
        DataGridView1.DataSource = table

    End Sub

    Private Sub SearchProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class