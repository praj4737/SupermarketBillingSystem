Public Class Bill
    Private Sub Bill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TotalBill.DataSource = GlobalConstants.table
        Label2.Text = GlobalConstants.total
        Label10.Text = GlobalConstants.paymentType
    End Sub
End Class