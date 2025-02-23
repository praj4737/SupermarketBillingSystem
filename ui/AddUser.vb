Imports MySql.Data.MySqlClient

Public Class AddUser
    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub addL3_TextChanged(sender As Object, e As EventArgs) Handles addL3.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim user As New User
        user.id = New UserDao().getUserId()
        user.fname = firstname.Text
        user.lname = lastname.Text
        user.dob = DateTimePicker1.Value
        user.gender = ""
        user.role_name = "sales"
        user.start_date = Date.Now().ToString("d")
        user.end_date = Nothing
        Dim address As New Address
        address.address_id = New UserDao().getAddressId()
        address.addL1 = addL1.Text
        address.addL2 = addL2.Text
        address.addL3 = addL3.Text
        If ComboBox3.SelectedItem = "" Then
            address.country = ComboBox3.Text
        Else
            address.country = ComboBox3.SelectedItem
        End If
        If ComboBox1.SelectedItem = "" Then
            address.country = ComboBox1.Text
        Else
            address.country = ComboBox1.SelectedItem
        End If
        If ComboBox2.SelectedItem = "" Then
            address.country = ComboBox2.Text
        Else
            address.country = ComboBox2.SelectedItem
        End If
        user.address = address
        Dim contact As New Contact
        contact.contact_id = New UserDao().getContactId()
        contact.contact_number = ph1.Text
        contact.email = email.Text
        user.contact = contact

        If New UserDao().createUser(user) Then
            MessageBox.Show("user created sucessfully")
        Else
            MessageBox.Show("cannot create user due to error")
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        Dim con As MySqlConnection
        Dim ad As MySqlDataAdapter
        ' Dim table As New DataTable
        Dim q = "select * from users where fname like '%" + searchBox.Text + "%';"
        con = New DBConnection().getConnection()
        ad = New MySqlDataAdapter(q, con)
        Dim table As New DataTable
        ad.Fill(table)
        DataGridView1.DataSource = table



    End Sub
End Class