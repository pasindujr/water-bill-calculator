﻿Imports MySql.Data.MySqlClient

Public Class Home
    Dim mySqlConnection As MySqlConnection
    Dim command As MySqlCommand
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
            MessageBox.Show("New customer added")
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
End Class