<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_register = New System.Windows.Forms.TabPage()
        Me.select_month = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_registerClear = New System.Windows.Forms.Button()
        Me.btn_registerSubmit = New System.Windows.Forms.Button()
        Me.txt_units = New System.Windows.Forms.TextBox()
        Me.txt_billNumber = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.txt_customerName = New System.Windows.Forms.TextBox()
        Me.lbl_month = New System.Windows.Forms.Label()
        Me.lbl_units = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tab_viewDetails = New System.Windows.Forms.TabPage()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.lbl_updateEmail = New System.Windows.Forms.Label()
        Me.lbl_updateAddress = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_updateBill = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_updateName = New System.Windows.Forms.Label()
        Me.txt_updateEmail = New System.Windows.Forms.TextBox()
        Me.txt_updateAddress = New System.Windows.Forms.TextBox()
        Me.txt_updateName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.dg_table = New System.Windows.Forms.DataGridView()
        Me.tab_registerAdmins = New System.Windows.Forms.TabPage()
        Me.btn_adminClear = New System.Windows.Forms.Button()
        Me.btn_registerAdmin = New System.Windows.Forms.Button()
        Me.txt_adminPassword = New System.Windows.Forms.TextBox()
        Me.txt_adminUsername = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_where = New System.Windows.Forms.Label()
        Me.btn_tab1 = New FontAwesome.Sharp.IconButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_signout = New FontAwesome.Sharp.IconButton()
        Me.btn_tab3 = New FontAwesome.Sharp.IconButton()
        Me.btn_tab2 = New FontAwesome.Sharp.IconButton()
        Me.TabControl1.SuspendLayout()
        Me.tab_register.SuspendLayout()
        Me.tab_viewDetails.SuspendLayout()
        CType(Me.dg_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_registerAdmins.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab_register)
        Me.TabControl1.Controls.Add(Me.tab_viewDetails)
        Me.TabControl1.Controls.Add(Me.tab_registerAdmins)
        Me.TabControl1.Location = New System.Drawing.Point(78, 51)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(619, 463)
        Me.TabControl1.TabIndex = 0
        '
        'tab_register
        '
        Me.tab_register.Controls.Add(Me.select_month)
        Me.tab_register.Controls.Add(Me.Label5)
        Me.tab_register.Controls.Add(Me.btn_registerClear)
        Me.tab_register.Controls.Add(Me.btn_registerSubmit)
        Me.tab_register.Controls.Add(Me.txt_units)
        Me.tab_register.Controls.Add(Me.txt_billNumber)
        Me.tab_register.Controls.Add(Me.txt_email)
        Me.tab_register.Controls.Add(Me.txt_address)
        Me.tab_register.Controls.Add(Me.txt_customerName)
        Me.tab_register.Controls.Add(Me.lbl_month)
        Me.tab_register.Controls.Add(Me.lbl_units)
        Me.tab_register.Controls.Add(Me.Label4)
        Me.tab_register.Controls.Add(Me.Label3)
        Me.tab_register.Controls.Add(Me.Label2)
        Me.tab_register.Controls.Add(Me.Label1)
        Me.tab_register.Cursor = System.Windows.Forms.Cursors.Default
        Me.tab_register.Location = New System.Drawing.Point(4, 22)
        Me.tab_register.Name = "tab_register"
        Me.tab_register.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_register.Size = New System.Drawing.Size(611, 437)
        Me.tab_register.TabIndex = 0
        Me.tab_register.Text = "Register Customer"
        Me.tab_register.UseVisualStyleBackColor = True
        '
        'select_month
        '
        Me.select_month.FormattingEnabled = True
        Me.select_month.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.select_month.Location = New System.Drawing.Point(282, 311)
        Me.select_month.Name = "select_month"
        Me.select_month.Size = New System.Drawing.Size(121, 21)
        Me.select_month.TabIndex = 5
        Me.select_month.Text = "Select month"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label5.Location = New System.Drawing.Point(200, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(249, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Register New Customers"
        '
        'btn_registerClear
        '
        Me.btn_registerClear.Location = New System.Drawing.Point(389, 401)
        Me.btn_registerClear.Name = "btn_registerClear"
        Me.btn_registerClear.Size = New System.Drawing.Size(75, 23)
        Me.btn_registerClear.TabIndex = 8
        Me.btn_registerClear.Text = "Clear"
        Me.btn_registerClear.UseVisualStyleBackColor = True
        '
        'btn_registerSubmit
        '
        Me.btn_registerSubmit.Location = New System.Drawing.Point(252, 401)
        Me.btn_registerSubmit.Name = "btn_registerSubmit"
        Me.btn_registerSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btn_registerSubmit.TabIndex = 7
        Me.btn_registerSubmit.Text = "Submit"
        Me.btn_registerSubmit.UseVisualStyleBackColor = True
        '
        'txt_units
        '
        Me.txt_units.Location = New System.Drawing.Point(282, 355)
        Me.txt_units.Name = "txt_units"
        Me.txt_units.Size = New System.Drawing.Size(217, 20)
        Me.txt_units.TabIndex = 6
        '
        'txt_billNumber
        '
        Me.txt_billNumber.Location = New System.Drawing.Point(282, 264)
        Me.txt_billNumber.Name = "txt_billNumber"
        Me.txt_billNumber.Size = New System.Drawing.Size(217, 20)
        Me.txt_billNumber.TabIndex = 4
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(282, 221)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(217, 20)
        Me.txt_email.TabIndex = 3
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(282, 131)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(217, 64)
        Me.txt_address.TabIndex = 2
        '
        'txt_customerName
        '
        Me.txt_customerName.Location = New System.Drawing.Point(282, 88)
        Me.txt_customerName.Name = "txt_customerName"
        Me.txt_customerName.Size = New System.Drawing.Size(217, 20)
        Me.txt_customerName.TabIndex = 1
        '
        'lbl_month
        '
        Me.lbl_month.AutoSize = True
        Me.lbl_month.Location = New System.Drawing.Point(176, 314)
        Me.lbl_month.Name = "lbl_month"
        Me.lbl_month.Size = New System.Drawing.Size(37, 13)
        Me.lbl_month.TabIndex = 4
        Me.lbl_month.Text = "Month"
        '
        'lbl_units
        '
        Me.lbl_units.AutoSize = True
        Me.lbl_units.Location = New System.Drawing.Point(176, 358)
        Me.lbl_units.Name = "lbl_units"
        Me.lbl_units.Size = New System.Drawing.Size(63, 13)
        Me.lbl_units.TabIndex = 4
        Me.lbl_units.Text = "No. of Units"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(176, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Water bill Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(176, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(176, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Customer Name"
        '
        'tab_viewDetails
        '
        Me.tab_viewDetails.Controls.Add(Me.btn_delete)
        Me.tab_viewDetails.Controls.Add(Me.btn_update)
        Me.tab_viewDetails.Controls.Add(Me.lbl_updateEmail)
        Me.tab_viewDetails.Controls.Add(Me.lbl_updateAddress)
        Me.tab_viewDetails.Controls.Add(Me.Label12)
        Me.tab_viewDetails.Controls.Add(Me.lbl_updateBill)
        Me.tab_viewDetails.Controls.Add(Me.Label10)
        Me.tab_viewDetails.Controls.Add(Me.lbl_updateName)
        Me.tab_viewDetails.Controls.Add(Me.txt_updateEmail)
        Me.tab_viewDetails.Controls.Add(Me.txt_updateAddress)
        Me.tab_viewDetails.Controls.Add(Me.txt_updateName)
        Me.tab_viewDetails.Controls.Add(Me.Label9)
        Me.tab_viewDetails.Controls.Add(Me.txt_search)
        Me.tab_viewDetails.Controls.Add(Me.dg_table)
        Me.tab_viewDetails.Location = New System.Drawing.Point(4, 22)
        Me.tab_viewDetails.Name = "tab_viewDetails"
        Me.tab_viewDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_viewDetails.Size = New System.Drawing.Size(611, 437)
        Me.tab_viewDetails.TabIndex = 1
        Me.tab_viewDetails.Text = "View and Update"
        Me.tab_viewDetails.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(132, 355)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 6
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(33, 355)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 5
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'lbl_updateEmail
        '
        Me.lbl_updateEmail.AutoSize = True
        Me.lbl_updateEmail.Location = New System.Drawing.Point(27, 289)
        Me.lbl_updateEmail.Name = "lbl_updateEmail"
        Me.lbl_updateEmail.Size = New System.Drawing.Size(32, 13)
        Me.lbl_updateEmail.TabIndex = 5
        Me.lbl_updateEmail.Text = "Email"
        '
        'lbl_updateAddress
        '
        Me.lbl_updateAddress.AutoSize = True
        Me.lbl_updateAddress.Location = New System.Drawing.Point(26, 237)
        Me.lbl_updateAddress.Name = "lbl_updateAddress"
        Me.lbl_updateAddress.Size = New System.Drawing.Size(45, 13)
        Me.lbl_updateAddress.TabIndex = 5
        Me.lbl_updateAddress.Text = "Address"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(116, 149)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 13)
        Me.Label12.TabIndex = 5
        '
        'lbl_updateBill
        '
        Me.lbl_updateBill.AutoSize = True
        Me.lbl_updateBill.Location = New System.Drawing.Point(129, 149)
        Me.lbl_updateBill.Name = "lbl_updateBill"
        Me.lbl_updateBill.Size = New System.Drawing.Size(7, 13)
        Me.lbl_updateBill.TabIndex = 5
        Me.lbl_updateBill.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 149)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Waterbill No."
        '
        'lbl_updateName
        '
        Me.lbl_updateName.AutoSize = True
        Me.lbl_updateName.Location = New System.Drawing.Point(26, 190)
        Me.lbl_updateName.Name = "lbl_updateName"
        Me.lbl_updateName.Size = New System.Drawing.Size(82, 13)
        Me.lbl_updateName.TabIndex = 5
        Me.lbl_updateName.Text = "Customer Name"
        '
        'txt_updateEmail
        '
        Me.txt_updateEmail.Location = New System.Drawing.Point(119, 286)
        Me.txt_updateEmail.Name = "txt_updateEmail"
        Me.txt_updateEmail.Size = New System.Drawing.Size(100, 20)
        Me.txt_updateEmail.TabIndex = 4
        '
        'txt_updateAddress
        '
        Me.txt_updateAddress.Location = New System.Drawing.Point(119, 234)
        Me.txt_updateAddress.Name = "txt_updateAddress"
        Me.txt_updateAddress.Size = New System.Drawing.Size(100, 20)
        Me.txt_updateAddress.TabIndex = 3
        '
        'txt_updateName
        '
        Me.txt_updateName.Location = New System.Drawing.Point(119, 187)
        Me.txt_updateName.Name = "txt_updateName"
        Me.txt_updateName.Size = New System.Drawing.Size(100, 20)
        Me.txt_updateName.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(263, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Search by Name"
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(370, 103)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(164, 20)
        Me.txt_search.TabIndex = 1
        '
        'dg_table
        '
        Me.dg_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_table.Location = New System.Drawing.Point(240, 149)
        Me.dg_table.Name = "dg_table"
        Me.dg_table.Size = New System.Drawing.Size(365, 249)
        Me.dg_table.TabIndex = 0
        '
        'tab_registerAdmins
        '
        Me.tab_registerAdmins.Controls.Add(Me.btn_adminClear)
        Me.tab_registerAdmins.Controls.Add(Me.btn_registerAdmin)
        Me.tab_registerAdmins.Controls.Add(Me.txt_adminPassword)
        Me.tab_registerAdmins.Controls.Add(Me.txt_adminUsername)
        Me.tab_registerAdmins.Controls.Add(Me.Label8)
        Me.tab_registerAdmins.Controls.Add(Me.Label7)
        Me.tab_registerAdmins.Controls.Add(Me.Label6)
        Me.tab_registerAdmins.Location = New System.Drawing.Point(4, 22)
        Me.tab_registerAdmins.Name = "tab_registerAdmins"
        Me.tab_registerAdmins.Size = New System.Drawing.Size(611, 437)
        Me.tab_registerAdmins.TabIndex = 2
        Me.tab_registerAdmins.Text = "Regsiter Admins"
        Me.tab_registerAdmins.UseVisualStyleBackColor = True
        '
        'btn_adminClear
        '
        Me.btn_adminClear.Location = New System.Drawing.Point(349, 282)
        Me.btn_adminClear.Name = "btn_adminClear"
        Me.btn_adminClear.Size = New System.Drawing.Size(75, 23)
        Me.btn_adminClear.TabIndex = 3
        Me.btn_adminClear.Text = "Clear"
        Me.btn_adminClear.UseVisualStyleBackColor = True
        '
        'btn_registerAdmin
        '
        Me.btn_registerAdmin.Location = New System.Drawing.Point(245, 282)
        Me.btn_registerAdmin.Name = "btn_registerAdmin"
        Me.btn_registerAdmin.Size = New System.Drawing.Size(75, 23)
        Me.btn_registerAdmin.TabIndex = 2
        Me.btn_registerAdmin.Text = "Register"
        Me.btn_registerAdmin.UseVisualStyleBackColor = True
        '
        'txt_adminPassword
        '
        Me.txt_adminPassword.Location = New System.Drawing.Point(294, 181)
        Me.txt_adminPassword.Name = "txt_adminPassword"
        Me.txt_adminPassword.Size = New System.Drawing.Size(147, 20)
        Me.txt_adminPassword.TabIndex = 1
        '
        'txt_adminUsername
        '
        Me.txt_adminUsername.Location = New System.Drawing.Point(294, 114)
        Me.txt_adminUsername.Name = "txt_adminUsername"
        Me.txt_adminUsername.Size = New System.Drawing.Size(147, 20)
        Me.txt_adminUsername.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(190, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(190, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Username"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(255, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Register Admins"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_where)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(697, 77)
        Me.Panel1.TabIndex = 2
        '
        'lbl_where
        '
        Me.lbl_where.AutoSize = True
        Me.lbl_where.Location = New System.Drawing.Point(455, 21)
        Me.lbl_where.Name = "lbl_where"
        Me.lbl_where.Size = New System.Drawing.Size(93, 13)
        Me.lbl_where.TabIndex = 0
        Me.lbl_where.Text = "Register Customer"
        '
        'btn_tab1
        '
        Me.btn_tab1.FlatAppearance.BorderSize = 0
        Me.btn_tab1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tab1.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_tab1.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.btn_tab1.IconColor = System.Drawing.Color.White
        Me.btn_tab1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_tab1.IconSize = 40
        Me.btn_tab1.Location = New System.Drawing.Point(4, 73)
        Me.btn_tab1.Name = "btn_tab1"
        Me.btn_tab1.Padding = New System.Windows.Forms.Padding(4, 0, 0, 5)
        Me.btn_tab1.Size = New System.Drawing.Size(66, 60)
        Me.btn_tab1.TabIndex = 0
        Me.btn_tab1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_tab1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btn_signout)
        Me.Panel2.Controls.Add(Me.btn_tab3)
        Me.Panel2.Controls.Add(Me.btn_tab2)
        Me.Panel2.Controls.Add(Me.btn_tab1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(72, 514)
        Me.Panel2.TabIndex = 3
        '
        'btn_signout
        '
        Me.btn_signout.FlatAppearance.BorderSize = 0
        Me.btn_signout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_signout.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_signout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.btn_signout.IconColor = System.Drawing.Color.White
        Me.btn_signout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_signout.IconSize = 40
        Me.btn_signout.Location = New System.Drawing.Point(3, 337)
        Me.btn_signout.Name = "btn_signout"
        Me.btn_signout.Padding = New System.Windows.Forms.Padding(4, 0, 0, 5)
        Me.btn_signout.Size = New System.Drawing.Size(66, 60)
        Me.btn_signout.TabIndex = 0
        Me.btn_signout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_signout.UseVisualStyleBackColor = True
        '
        'btn_tab3
        '
        Me.btn_tab3.FlatAppearance.BorderSize = 0
        Me.btn_tab3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tab3.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_tab3.IconChar = FontAwesome.Sharp.IconChar.UserLock
        Me.btn_tab3.IconColor = System.Drawing.Color.White
        Me.btn_tab3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_tab3.IconSize = 40
        Me.btn_tab3.Location = New System.Drawing.Point(3, 250)
        Me.btn_tab3.Name = "btn_tab3"
        Me.btn_tab3.Padding = New System.Windows.Forms.Padding(4, 0, 0, 5)
        Me.btn_tab3.Size = New System.Drawing.Size(66, 60)
        Me.btn_tab3.TabIndex = 0
        Me.btn_tab3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_tab3.UseVisualStyleBackColor = True
        '
        'btn_tab2
        '
        Me.btn_tab2.FlatAppearance.BorderSize = 0
        Me.btn_tab2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tab2.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_tab2.IconChar = FontAwesome.Sharp.IconChar.UserEdit
        Me.btn_tab2.IconColor = System.Drawing.Color.White
        Me.btn_tab2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_tab2.IconSize = 40
        Me.btn_tab2.Location = New System.Drawing.Point(3, 159)
        Me.btn_tab2.Name = "btn_tab2"
        Me.btn_tab2.Padding = New System.Windows.Forms.Padding(4, 0, 0, 5)
        Me.btn_tab2.Size = New System.Drawing.Size(66, 60)
        Me.btn_tab2.TabIndex = 0
        Me.btn_tab2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_tab2.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 514)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.IsMdiContainer = True
        Me.Name = "Home"
        Me.Text = "Home"
        Me.TabControl1.ResumeLayout(False)
        Me.tab_register.ResumeLayout(False)
        Me.tab_register.PerformLayout()
        Me.tab_viewDetails.ResumeLayout(False)
        Me.tab_viewDetails.PerformLayout()
        CType(Me.dg_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_registerAdmins.ResumeLayout(False)
        Me.tab_registerAdmins.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tab_register As TabPage
    Friend WithEvents tab_viewDetails As TabPage
    Friend WithEvents tab_registerAdmins As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_registerClear As Button
    Friend WithEvents btn_registerSubmit As Button
    Friend WithEvents txt_billNumber As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_address As TextBox
    Friend WithEvents txt_customerName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_units As Label
    Friend WithEvents select_month As ComboBox
    Friend WithEvents txt_units As TextBox
    Friend WithEvents lbl_month As Label
    Friend WithEvents btn_adminClear As Button
    Friend WithEvents btn_registerAdmin As Button
    Friend WithEvents txt_adminPassword As TextBox
    Friend WithEvents txt_adminUsername As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dg_table As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents lbl_updateEmail As Label
    Friend WithEvents lbl_updateAddress As Label
    Friend WithEvents lbl_updateName As Label
    Friend WithEvents txt_updateEmail As TextBox
    Friend WithEvents txt_updateAddress As TextBox
    Friend WithEvents txt_updateName As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_updateBill As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_tab1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_signout As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_tab3 As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_tab2 As FontAwesome.Sharp.IconButton
    Friend WithEvents lbl_where As Label
End Class
