Imports MySql.Data.MySqlClient


Public Class Login
    Private Property moveform As Boolean
    Private Property moveform_mouseposition As Point

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
                MessageBox.Show("Duplicate username or password", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            Else
                MessageBox.Show("Incorrect username or password", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            End If

            mySqlConnection.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            mySqlConnection.Dispose()
        End Try
    End Sub



    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timer_datetime.Enabled = True
    End Sub

    Private Sub timer_datetime_Tick(sender As Object, e As EventArgs) Handles timer_datetime.Tick
        lbl_datatime.Text = Date.Now.ToString("dd MMM yyy hh:mm:ss")
        Home.lbl_datetime.Text = Date.Now.ToString("dd MMM yyy hh:mm:ss")
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

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        If e.Button = MouseButtons.Left Then
            moveform = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            moveform = True
            Me.Cursor = Cursors.Default
            moveform_mouseposition = e.Location
        End If
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If moveform Then
            Me.Location = Me.Location + (e.Location - moveform_mouseposition)
        End If
    End Sub
End Class
