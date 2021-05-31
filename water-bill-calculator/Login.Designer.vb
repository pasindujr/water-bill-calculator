<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_loginPassword = New System.Windows.Forms.TextBox()
        Me.txt_loginUsername = New System.Windows.Forms.TextBox()
        Me.lbl_loginUsername = New System.Windows.Forms.Label()
        Me.lbl_loginPassword = New System.Windows.Forms.Label()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_loginPassword
        '
        Me.txt_loginPassword.Location = New System.Drawing.Point(226, 174)
        Me.txt_loginPassword.Name = "txt_loginPassword"
        Me.txt_loginPassword.Size = New System.Drawing.Size(100, 20)
        Me.txt_loginPassword.TabIndex = 0
        Me.txt_loginPassword.UseSystemPasswordChar = True
        '
        'txt_loginUsername
        '
        Me.txt_loginUsername.Location = New System.Drawing.Point(226, 105)
        Me.txt_loginUsername.Name = "txt_loginUsername"
        Me.txt_loginUsername.Size = New System.Drawing.Size(100, 20)
        Me.txt_loginUsername.TabIndex = 0
        '
        'lbl_loginUsername
        '
        Me.lbl_loginUsername.AutoSize = True
        Me.lbl_loginUsername.Location = New System.Drawing.Point(120, 108)
        Me.lbl_loginUsername.Name = "lbl_loginUsername"
        Me.lbl_loginUsername.Size = New System.Drawing.Size(55, 13)
        Me.lbl_loginUsername.TabIndex = 1
        Me.lbl_loginUsername.Text = "Username"
        '
        'lbl_loginPassword
        '
        Me.lbl_loginPassword.AutoSize = True
        Me.lbl_loginPassword.Location = New System.Drawing.Point(120, 177)
        Me.lbl_loginPassword.Name = "lbl_loginPassword"
        Me.lbl_loginPassword.Size = New System.Drawing.Size(53, 13)
        Me.lbl_loginPassword.TabIndex = 1
        Me.lbl_loginPassword.Text = "Password"
        '
        'btn_login
        '
        Me.btn_login.Location = New System.Drawing.Point(187, 242)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(75, 23)
        Me.btn_login.TabIndex = 2
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.lbl_loginPassword)
        Me.Controls.Add(Me.lbl_loginUsername)
        Me.Controls.Add(Me.txt_loginUsername)
        Me.Controls.Add(Me.txt_loginPassword)
        Me.Name = "Login"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_loginPassword As TextBox
    Friend WithEvents txt_loginUsername As TextBox
    Friend WithEvents lbl_loginUsername As Label
    Friend WithEvents lbl_loginPassword As Label
    Friend WithEvents btn_login As Button
End Class
