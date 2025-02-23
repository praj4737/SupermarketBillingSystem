Imports MySql.Data.MySqlClient

Public Class UserDao
    Public Function createUser(user As User) As Boolean
        createAddress(user.address)
        createContact(user.contact)
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        Dim q = "insert into users values ('" + user.id + "','" + user.fname + "','" + user.lname + "','" + user.dob.ToString("yyyyMMdd") + "','" + user.role_name + "','" + user.start_date.ToString("yyyyMMdd") + "','" + user.end_date.ToString("yyyyMMdd") + "','" + user.address.address_id + "','" + user.contact.contact_id + "');"
        con = New DBConnection().getConnection()
        cmd = New MySqlCommand(q, con)
        Dim count = cmd.ExecuteNonQuery()
        If count > 0 Then
            Return True
        End If
        Return False
    End Function
    Public Function createAddress(address As Address) As Boolean
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        Dim q = "insert into user_address values ('" + address.address_id + "','" + address.addL1 + "','" + address.addL2 + "','" + address.addL3 + "','" + address.city + "','" + address.pincode + "','" + address.state + "','" + address.country + "');"
        con = New DBConnection().getConnection()
        cmd = New MySqlCommand(q, con)
        Dim count = cmd.ExecuteNonQuery()
        If count > 0 Then
            Return True
        End If
        Return False
    End Function
    Public Function createContact(contact As Contact) As Boolean
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        Dim q = "insert into user_contact values('" + contact.contact_id + "','" + contact.contact_number + "','" + contact.email + "');"
        con = New DBConnection().getConnection()
        cmd = New MySqlCommand(q, con)
        Dim count = cmd.ExecuteNonQuery()
        If count > 0 Then
            Return True
        End If
        Return False
    End Function
    Public Function getAddressId() As String
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        Dim q = "select count(*) from user_address;"
        con = New DBConnection().getConnection()
        cmd = New MySqlCommand(q, con)
        Dim count = CInt(cmd.ExecuteScalar())
        count += 1
        Return "add" + CStr(count)
    End Function
    Public Function getContactId() As String
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        Dim q = "select count(*) from user_contact;"
        con = New DBConnection().getConnection()
        cmd = New MySqlCommand(q, con)
        Dim count = CInt(cmd.ExecuteScalar())
        count += 1
        Return "con" + CStr(count)
    End Function
    Public Function getUserId() As String
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        Dim q = "select count(*) from users;"
        con = New DBConnection().getConnection()
        cmd = New MySqlCommand(q, con)
        Dim count = CInt(cmd.ExecuteScalar())
        count += 1
        Return "usr" + CStr(count)
    End Function
End Class
