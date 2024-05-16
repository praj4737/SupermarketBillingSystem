Imports Org.BouncyCastle.Asn1.Cms

Public Class Bill
    Dim table As New DataTable
    Private Sub Bill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TotalBill.DataSource = GlobalConstants.table

        Label2.Text = GlobalConstants.total
        Label10.Text = GlobalConstants.paymentType
        customerName.Text = "Mr." + GlobalConstants.customerName
        datelabel.Text = Date.Now().ToString("d")
        timeLabel.Text = DateTime.Now().ToString("hh:mm:ss")

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub search_Click(sender As Object, e As EventArgs) Handles print.Click
        Dim p As New PointOfSale()
        p.createBill()

    End Sub
End Class