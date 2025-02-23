Imports Google.Protobuf.WellKnownTypes

Public Class AddUsers
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles addL1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fname = firstname.Text
        Dim lname = lastname.Text
        Dim dob = DateTimePicker1.Value
        Dim gen = gender.SelectedItem
        Dim addressLine1 = addL1.Text
        Dim addressLine2 = addL2.Text
        Dim addressLine3 = addL3.Text
        Dim ustate = state.Text
        Dim ucountry = country.Text
        Dim uzipcode = zipcode.Text
        Dim ucity = city.Text
        Dim phone1 = ph1.Text
        Dim phone2 = ph2.Text
        Dim uemail = email.Text
    End Sub
End Class