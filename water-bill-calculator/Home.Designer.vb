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
        Me.tab_regsiter = New System.Windows.Forms.TabPage()
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.btn_loadTable = New System.Windows.Forms.Button()
        Me.dg_table = New System.Windows.Forms.DataGridView()
        Me.tab_registerAdmins = New System.Windows.Forms.TabPage()
        Me.btn_adminClear = New System.Windows.Forms.Button()
        Me.btn_registerAdmin = New System.Windows.Forms.Button()
        Me.txt_adminPassword = New System.Windows.Forms.TextBox()
        Me.txt_adminUsername = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tab_regsiter.SuspendLayout()
        Me.tab_viewDetails.SuspendLayout()
        CType(Me.dg_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_registerAdmins.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab_regsiter)
        Me.TabControl1.Controls.Add(Me.tab_viewDetails)
        Me.TabControl1.Controls.Add(Me.tab_registerAdmins)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(690, 514)
        Me.TabControl1.TabIndex = 0
        '
        'tab_regsiter
        '
        Me.tab_regsiter.Controls.Add(Me.select_month)
        Me.tab_regsiter.Controls.Add(Me.Label5)
        Me.tab_regsiter.Controls.Add(Me.btn_registerClear)
        Me.tab_regsiter.Controls.Add(Me.btn_registerSubmit)
        Me.tab_regsiter.Controls.Add(Me.txt_units)
        Me.tab_regsiter.Controls.Add(Me.txt_billNumber)
        Me.tab_regsiter.Controls.Add(Me.txt_email)
        Me.tab_regsiter.Controls.Add(Me.txt_address)
        Me.tab_regsiter.Controls.Add(Me.txt_customerName)
        Me.tab_regsiter.Controls.Add(Me.lbl_month)
        Me.tab_regsiter.Controls.Add(Me.lbl_units)
        Me.tab_regsiter.Controls.Add(Me.Label4)
        Me.tab_regsiter.Controls.Add(Me.Label3)
        Me.tab_regsiter.Controls.Add(Me.Label2)
        Me.tab_regsiter.Controls.Add(Me.Label1)
        Me.tab_regsiter.Location = New System.Drawing.Point(4, 22)
        Me.tab_regsiter.Name = "tab_regsiter"
        Me.tab_regsiter.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_regsiter.Size = New System.Drawing.Size(682, 488)
        Me.tab_regsiter.TabIndex = 0
        Me.tab_regsiter.Text = "Register Customer"
        Me.tab_regsiter.UseVisualStyleBackColor = True
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
        Me.tab_viewDetails.Controls.Add(Me.Label9)
        Me.tab_viewDetails.Controls.Add(Me.txt_search)
        Me.tab_viewDetails.Controls.Add(Me.btn_loadTable)
        Me.tab_viewDetails.Controls.Add(Me.dg_table)
        Me.tab_viewDetails.Location = New System.Drawing.Point(4, 22)
        Me.tab_viewDetails.Name = "tab_viewDetails"
        Me.tab_viewDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_viewDetails.Size = New System.Drawing.Size(682, 488)
        Me.tab_viewDetails.TabIndex = 1
        Me.tab_viewDetails.Text = "View Details"
        Me.tab_viewDetails.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(163, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Search by Name"
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(280, 88)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(209, 20)
        Me.txt_search.TabIndex = 1
        '
        'btn_loadTable
        '
        Me.btn_loadTable.Location = New System.Drawing.Point(320, 36)
        Me.btn_loadTable.Name = "btn_loadTable"
        Me.btn_loadTable.Size = New System.Drawing.Size(94, 23)
        Me.btn_loadTable.TabIndex = 0
        Me.btn_loadTable.Text = "View Full List"
        Me.btn_loadTable.UseVisualStyleBackColor = True
        '
        'dg_table
        '
        Me.dg_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_table.Location = New System.Drawing.Point(118, 195)
        Me.dg_table.Name = "dg_table"
        Me.dg_table.Size = New System.Drawing.Size(527, 249)
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
        Me.tab_registerAdmins.Size = New System.Drawing.Size(682, 488)
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
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 514)
        Me.Controls.Add(Me.TabControl1)
        Me.IsMdiContainer = True
        Me.Name = "Home"
        Me.Text = "Home"
        Me.TabControl1.ResumeLayout(False)
        Me.tab_regsiter.ResumeLayout(False)
        Me.tab_regsiter.PerformLayout()
        Me.tab_viewDetails.ResumeLayout(False)
        Me.tab_viewDetails.PerformLayout()
        CType(Me.dg_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_registerAdmins.ResumeLayout(False)
        Me.tab_registerAdmins.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tab_regsiter As TabPage
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
    Friend WithEvents btn_loadTable As Button
End Class
