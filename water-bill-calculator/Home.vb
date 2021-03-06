Imports MySql.Data.MySqlClient

Public Class Home
    Private Property moveform As Boolean
    Private Property moveform_mouseposition As Point

    Dim mySqlConnection As MySqlConnection
    Dim command As MySqlCommand
    Dim dbDataSet As New DataTable

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTable()
        Login.timer_datetime.Enabled = True
        Dim ellipseRadius As New Drawing2D.GraphicsPath

    End Sub

    Public Function calBill(units As Double) As Double
        Dim charge As Double
        If (units <= 5) Then
            charge = units * 12
        ElseIf (units <= 10) Then
            charge = 5 * 12 + (units - 5) * 16
        ElseIf (units <= 15) Then
            charge = 5 * 12 + 5 * 16 + (units - 10) * 20
        ElseIf (units <= 10) Then
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
            Try
                Dim units As Double = txt_units.Text
                query = "insert into waterbill.customers (customer_name, customer_address, customer_email, water_bill_number, month, no_of_units, charge) values ('" & txt_customerName.Text & "', '" & txt_address.Text & "', '" & txt_email.Text & "', '" & txt_billNumber.Text & "', '" & select_month.Text & "', '" & txt_units.Text & "', '" & calBill(units) & "')"
                command = New MySqlCommand(query, mySqlConnection)
                reader = command.ExecuteReader()
                MessageBox.Show("New customer and details added", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                mySqlConnection.Close()
            Catch ex As Exception
                MessageBox.Show("Enter valid unit", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End Try
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            mySqlConnection.Dispose()
        End Try
        loadTable()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lbl_units.Click, lbl_month.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_registerAdmin_Click(sender As Object, e As EventArgs) Handles btn_registerAdmin.Click
        mySqlConnection = New MySqlConnection
        mySqlConnection.ConnectionString = "server=localhost;userid=root;password=1234;database=waterbill"
        Dim reader As MySqlDataReader

        If (txt_adminUsername.Text = "" Or txt_adminPassword.Text = "") Then
            MessageBox.Show("Please input valid username or passowrd", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else

            Try
                mySqlConnection.Open()
                Dim query As String
                query = "insert into waterbill.login (username, password) values ('" & txt_adminUsername.Text & "', '" & txt_adminPassword.Text & "')"
                command = New MySqlCommand(query, mySqlConnection)
                reader = command.ExecuteReader()
                MessageBox.Show("Welcome '" & txt_adminUsername.Text & "'", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                mySqlConnection.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)

            Finally
                mySqlConnection.Dispose()
            End Try
        End If
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

    Private Sub loadTable()
        dbDataSet.Clear()
        dg_table.DataSource = dbDataSet
        dg_table.DataSource = Nothing
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

    Private Sub btn_loadTable_Click(sender As Object, e As EventArgs)
        loadTable()

    End Sub

    Private Sub btn_deleteRow_Click(sender As Object, e As EventArgs)
        Dim index As Integer
        index = dg_table.CurrentCell.RowIndex
        dg_table.Rows.RemoveAt(index)
    End Sub


    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        mySqlConnection.ConnectionString = "server=localhost;userid=root;password=1234;database=waterbill"
        Dim reader As MySqlDataReader

        If txt_updateName.Text = "" Or txt_updateAddress.Text = "" Or txt_updateEmail.Text = "" Then
            MessageBox.Show("Empty fields", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Try
                mySqlConnection.Open()
                Dim query As String
                query = "update waterbill.customers set customer_name ='" & txt_updateName.Text & "',customer_address='" & txt_updateAddress.Text & "',customer_email='" & txt_updateEmail.Text & "' where water_bill_number ='" & lbl_updateBill.Text & "'"
                command = New MySqlCommand(query, mySqlConnection)
                reader = command.ExecuteReader
                MessageBox.Show("Details Updated", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                mySqlConnection.Close()
                loadTable()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)

            Finally
                mySqlConnection.Dispose()
            End Try
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        mySqlConnection.ConnectionString = "server=localhost;userid=root;password=1234;database=waterbill"
        Dim reader As MySqlDataReader

        If txt_updateName.Text = "" Or txt_updateAddress.Text = "" Or txt_updateEmail.Text = "" Then
            MessageBox.Show("Empty fields", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Try
                mySqlConnection.Open()
                Dim query As String
                query = "delete from waterbill.customers where water_bill_number ='" & lbl_updateBill.Text & "'"
                command = New MySqlCommand(query, mySqlConnection)
                reader = command.ExecuteReader
                MessageBox.Show("Details Deleted", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                mySqlConnection.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)

            Finally
                mySqlConnection.Dispose()
            End Try
            loadTable()
        End If
    End Sub


    Private Sub txt_billNumber_TextChanged(sender As Object, e As EventArgs) Handles txt_billNumber.TextChanged

    End Sub

    Private Sub txt_billNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_billNumber.KeyPress
        e.Handled = onlyNumeric(Asc(e.KeyChar))
    End Sub


    Private Sub txt_units_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_units.KeyPress
        e.Handled = onlyNumeric(Asc(e.KeyChar))
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Dim dv As New DataView(dbDataSet)
        dv.RowFilter = String.Format("customer_name like '%{0}%'", txt_search.Text)
        dg_table.DataSource = dv
    End Sub

    Private Sub btn_tab1_Click(sender As Object, e As EventArgs) Handles btn_tab1.Click
        TabControl1.SelectTab(0)
        lbl_where.Text = "Register Customers"
    End Sub

    Private Sub btn_tab2_Click(sender As Object, e As EventArgs) Handles btn_tab2.Click
        TabControl1.SelectTab(1)
        lbl_where.Text = "View and Update"
    End Sub

    Private Sub btn_tab3_Click(sender As Object, e As EventArgs) Handles btn_tab3.Click
        TabControl1.SelectTab(2)
        lbl_where.Text = "Register Admins"
    End Sub

    Private Sub btn_signout_Click(sender As Object, e As EventArgs) Handles btn_signout.Click
        Dim response As Integer
        response = MessageBox.Show("Are you sure you want to sign out?", "Sign Out application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = vbYes Then
            Login.Show()
            Me.Hide()
            Login.txt_loginPassword.Clear()
            Login.txt_loginUsername.Clear()
        End If

    End Sub

    Private Sub IconPicture_close_Click(sender As Object, e As EventArgs) Handles IconPicture_close.Click
        Dim response As Integer
        response = MessageBox.Show("Are you sure you want to exit?", "Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = vbYes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub IconPicture_minimize_Click(sender As Object, e As EventArgs) Handles IconPicture_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_tab1_MouseHover(sender As Object, e As EventArgs) Handles btn_tab1.MouseHover
        Dim tooltip As New ToolTip()
        tooltip.UseFading = True
        tooltip.UseAnimation = True
        tooltip.ShowAlways = True
        tooltip.AutoPopDelay = 5000
        tooltip.InitialDelay = 500
        tooltip.ReshowDelay = 100
        tooltip.SetToolTip(btn_tab1, "Regsiter Members")
    End Sub

    Private Sub btn_tab2_MouseHover(sender As Object, e As EventArgs) Handles btn_tab2.MouseHover
        Dim tooltip As New ToolTip()
        tooltip.UseFading = True
        tooltip.UseAnimation = True
        tooltip.ShowAlways = True
        tooltip.AutoPopDelay = 5000
        tooltip.InitialDelay = 500
        tooltip.ReshowDelay = 100
        tooltip.SetToolTip(btn_tab2, "View and Update")
    End Sub

    Private Sub btn_tab3_MouseHover(sender As Object, e As EventArgs) Handles btn_tab3.MouseHover
        Dim tooltip As New ToolTip()
        tooltip.UseFading = True
        tooltip.UseAnimation = True
        tooltip.ShowAlways = True
        tooltip.AutoPopDelay = 5000
        tooltip.InitialDelay = 500
        tooltip.ReshowDelay = 100
        tooltip.SetToolTip(btn_tab3, "Regsiter Admins")
    End Sub

    Private Sub btn_signout_MouseHover(sender As Object, e As EventArgs) Handles btn_signout.MouseHover
        Dim tooltip As New ToolTip()
        tooltip.UseFading = True
        tooltip.UseAnimation = True
        tooltip.ShowAlways = True
        tooltip.AutoPopDelay = 5000
        tooltip.InitialDelay = 500
        tooltip.ReshowDelay = 100
        tooltip.SetToolTip(btn_signout, "Sign Out")
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            moveform = True
            Me.Cursor = Cursors.Default
            moveform_mouseposition = e.Location
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        If e.Button = MouseButtons.Left Then
            moveform = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If moveform Then
            Me.Location = Me.Location + (e.Location - moveform_mouseposition)
        End If
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles btn_about.Click
        TabControl1.SelectTab(3)
        lbl_where.Text = "About"
    End Sub

    Private Sub btn_about_MouseHover(sender As Object, e As EventArgs) Handles btn_about.MouseHover
        Dim tooltip As New ToolTip()
        tooltip.UseFading = True
        tooltip.UseAnimation = True
        tooltip.ShowAlways = True
        tooltip.AutoPopDelay = 5000
        tooltip.InitialDelay = 500
        tooltip.ReshowDelay = 100
        tooltip.SetToolTip(btn_about, "About")
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim imagebmp As New Bitmap(Me.dg_table.Width, Me.dg_table.Height)
        dg_table.DrawToBitmap(imagebmp, New Rectangle(0, 0, Me.dg_table.Width, Me.dg_table.Height))
        e.Graphics.DrawImage(imagebmp, 120, 20)

    End Sub
End Class