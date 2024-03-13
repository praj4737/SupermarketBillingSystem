Imports MySql.Data.MySqlClient

Public Class viewProducts
    Private Sub viewProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As MySqlConnection
        Dim ad As MySqlDataAdapter
        Dim dr As MySqlDataReader
        Dim table As New DataTable()
        Dim q = "select * from products;"
        con = New DBConnection().getConnection()

        ad = New MySqlDataAdapter(q, con)
        ad.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        'AdminHomepage.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class