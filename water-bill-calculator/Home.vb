Imports MySql.Data.MySqlClient

Public Class Home
    Dim mySqlConnection As MySqlConnection
    Dim command As MySqlCommand
    Dim dbDataSet As New DataTable

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Function calBill(units As Double) As Double
        Dim charge As Double
        If (units <= 5) Then
            charge = units * 12
        ElseIf (units <= 10) Then
            charge = 5 * 12 + (units - 5) * 16
        ElseIf (units <= 15) Then
            charge = 5 * 12 + 5 * 16 + (units - 10) * 20
        ElseIf (units <= 20) Then
            charge = 5 * 12 + 5 * 16 + 5 * 20 + (units - 15) * 40
        ElseIf (units <= 25) Then
            charge = 5 * 12 + 5 * 16 + 5 * 20 + 5 * 40 + (units - 20) * 58
        ElseIf (units <= 30) Then
            charge = 5 * 12 + 5 * 16 + 5 * 20 + 5 * 40 + 5 * 58 + (units - 25) * 88
        ElseIf (units <= 40) Then
            charge = 5 * 12 + 5 * 16 + 5 * 20 + 5 * 40 + 5 * 58 + 5 * 88 + (units - 30) * 105
        ElseIf (units <= 50) Then
            charge = 5 * 12 + 5 * 16 + 5 * 20 + 5 * 40 + 5 * 58 + 5 * 88 + 10 * 105 + (units - 40) * 120
        ElseIf (units <= 75) Then
            charge = 5 * 12 + 5 * 16 + 5 * 20 + 5 * 40 + 5 * 58 + 5 * 88 + 10 * 105 + 10 * 120 + (units - 50) * 130
        Else
            charge = 5 * 12 + 5 * 16 + 5 * 20 + 5 * 40 + 5 * 58 + 5 * 88 + 10 * 105 + 10 * 120 + 130 * 25 + (units - 75) * 140

        End If

        Return charge
    End Function

    Private Sub btn_registerSubmit_Click(sender As Object, e As EventArgs) Handles btn_registerSubmit.Click
        mySqlConnection = New MySqlConnection
        mySqlConnection.ConnectionString = "server=localhost;userid=root;password=1234;database=waterbill"
        Dim reader As MySqlDataReader


        Try
            mySqlConnection.Open()
            Dim query As String
            Dim units As Double = txt_units.Text
            query = "insert into waterbill.customers (customer_name, customer_address, customer_email, water_bill_number, month, no_of_units, charge) values ('" & txt_customerName.Text & "', '" & txt_address.Text & "', '" & txt_email.Text & "', '" & txt_billNumber.Text & "', '" & select_month.Text & "', '" & txt_units.Text & "', '" & calBill(units) & "')"
            command = New MySqlCommand(query, mySqlConnection)
            reader = command.ExecuteReader()
            MessageBox.Show("New customer and details added")
            mySqlConnection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            mySqlConnection.Dispose()
        End Try
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lbl_units.Click, lbl_month.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_registerAdmin_Click(sender As Object, e As EventArgs) Handles btn_registerAdmin.Click
        mySqlConnection = New MySqlConnection
        mySqlConnection.ConnectionString = "server=localhost;userid=root;password=1234;database=waterbill"
        Dim reader As MySqlDataReader

        Try
            mySqlConnection.Open()
            Dim query As String
            query = "insert into waterbill.login (username, password) values ('" & txt_adminUsername.Text & "', '" & txt_adminPassword.Text & "')"
            command = New MySqlCommand(query, mySqlConnection)
            reader = command.ExecuteReader()
            MessageBox.Show("Welcome '" & txt_adminUsername.Text & "'")
            mySqlConnection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            mySqlConnection.Dispose()
        End Try
    End Sub

    Private Sub btn_registerClear_Click(sender As Object, e As EventArgs) Handles btn_registerClear.Click
        txt_customerName.Clear()
        txt_address.Clear()
        txt_email.Clear()
        txt_billNumber.Clear()
        txt_units.Clear()
    End Sub

    Private Sub btn_adminClear_Click(sender As Object, e As EventArgs) Handles btn_adminClear.Click
        txt_adminUsername.Clear()
        txt_adminPassword.Clear()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_table.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dg_table.Rows(e.RowIndex)

            lbl_updateBill.Text = row.Cells("water_bill_number").Value
            txt_updateName.Text = row.Cells("customer_name").Value.ToString
            txt_updateAddress.Text = row.Cells("customer_address").Value.ToString
            txt_updateEmail.Text = row.Cells("customer_email").Value.ToString
        End If
    End Sub

    Private Sub btn_loadTable_Click(sender As Object, e As EventArgs) Handles btn_loadTable.Click
        mySqlConnection = New MySqlConnection
        mySqlConnection.ConnectionString = "server=localhost;userid=root;password=1234;database=waterbill"

        Dim sda As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            mySqlConnection.Open()
            Dim query As String
            query = "select * from waterbill.customers"
            command = New MySqlCommand(query, mySqlConnection)
            sda.SelectCommand = command
            sda.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            dg_table.DataSource = bSource
            sda.Update(dbDataSet)

            mySqlConnection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            mySqlConnection.Dispose()
        End Try
    End Sub

    Private Sub btn_deleteRow_Click(sender As Object, e As EventArgs)
        Dim index As Integer
        index = dg_table.CurrentCell.RowIndex
        dg_table.Rows.RemoveAt(index)
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged


    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        mySqlConnection.ConnectionString = "server=localhost;userid=root;password=1234;database=waterbill"
        Dim reader As MySqlDataReader


        Try
            mySqlConnection.Open()
            Dim query As String
            query = "update waterbill.customers set customer_name ='" & txt_updateName.Text & "',customer_address='" & txt_updateAddress.Text & "',customer_email='" & txt_updateEmail.Text & "' where water_bill_number ='" & lbl_updateBill.Text & "'"
            command = New MySqlCommand(query, mySqlConnection)
            reader = command.ExecuteReader
            MessageBox.Show("Details Updated")
            mySqlConnection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            mySqlConnection.Dispose()
        End Try

    End Sub
End Class