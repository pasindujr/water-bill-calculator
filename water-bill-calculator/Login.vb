Imports MySql.Data.MySqlClient


Public Class Login
    Dim mySqlConnection As MySqlConnection
    Dim command As MySqlCommand


    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        mySqlConnection = New MySqlConnection
        mySqlConnection.ConnectionString = "server=localhost;userid=root;password=1234;database=waterbill"
        Dim reader As MySqlDataReader

        Try
            mySqlConnection.Open()
            Dim query As String
            query = "select * from waterbill.login where username = '" & txt_loginUsername.Text & "' and password = '" & txt_loginPassword.Text & "'"
            command = New MySqlCommand(query, mySqlConnection)
            reader = command.ExecuteReader
            Dim count As Int16
            count = 0
            While reader.Read
                count = count + 1

            End While

            If (count = 1) Then
                Home.Show()
                Me.Hide()

            ElseIf count > 1 Then
                MessageBox.Show("Duplicate username or password")

            Else
                MessageBox.Show("Incorrect username or password")

            End If

            mySqlConnection.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            mySqlConnection.Dispose()
        End Try
    End Sub
End Class
