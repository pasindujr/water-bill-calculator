<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.txt_loginPassword = New System.Windows.Forms.TextBox()
        Me.txt_loginUsername = New System.Windows.Forms.TextBox()
        Me.lbl_loginUsername = New System.Windows.Forms.Label()
        Me.lbl_loginPassword = New System.Windows.Forms.Label()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_datatime = New System.Windows.Forms.Label()
        Me.timer_datetime = New System.Windows.Forms.Timer(Me.components)
        Me.IconPicture_close = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPicture_minimize = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPicture_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPicture_minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_loginPassword
        '
        Me.txt_loginPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_loginPassword.Location = New System.Drawing.Point(232, 231)
        Me.txt_loginPassword.Name = "txt_loginPassword"
        Me.txt_loginPassword.Size = New System.Drawing.Size(100, 22)
        Me.txt_loginPassword.TabIndex = 1
        Me.txt_loginPassword.UseSystemPasswordChar = True
        '
        'txt_loginUsername
        '
        Me.txt_loginUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_loginUsername.Location = New System.Drawing.Point(232, 162)
        Me.txt_loginUsername.Name = "txt_loginUsername"
        Me.txt_loginUsername.Size = New System.Drawing.Size(100, 22)
        Me.txt_loginUsername.TabIndex = 0
        '
        'lbl_loginUsername
        '
        Me.lbl_loginUsername.AutoSize = True
        Me.lbl_loginUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_loginUsername.Location = New System.Drawing.Point(126, 165)
        Me.lbl_loginUsername.Name = "lbl_loginUsername"
        Me.lbl_loginUsername.Size = New System.Drawing.Size(71, 16)
        Me.lbl_loginUsername.TabIndex = 1
        Me.lbl_loginUsername.Text = "Username"
        '
        'lbl_loginPassword
        '
        Me.lbl_loginPassword.AutoSize = True
        Me.lbl_loginPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_loginPassword.Location = New System.Drawing.Point(126, 234)
        Me.lbl_loginPassword.Name = "lbl_loginPassword"
        Me.lbl_loginPassword.Size = New System.Drawing.Size(68, 16)
        Me.lbl_loginPassword.TabIndex = 1
        Me.lbl_loginPassword.Text = "Password"
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btn_login.FlatAppearance.BorderSize = 0
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_login.Location = New System.Drawing.Point(200, 299)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(75, 27)
        Me.btn_login.TabIndex = 2
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.IconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Faucet
        Me.IconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 69
        Me.IconPictureBox1.Location = New System.Drawing.Point(85, 54)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(73, 69)
        Me.IconPictureBox1.TabIndex = 3
        Me.IconPictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(164, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Water Billing System"
        '
        'lbl_datatime
        '
        Me.lbl_datatime.AutoSize = True
        Me.lbl_datatime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_datatime.Location = New System.Drawing.Point(228, 414)
        Me.lbl_datatime.Name = "lbl_datatime"
        Me.lbl_datatime.Size = New System.Drawing.Size(113, 20)
        Me.lbl_datatime.TabIndex = 5
        Me.lbl_datatime.Text = "Date and Time"
        '
        'timer_datetime
        '
        '
        'IconPicture_close
        '
        Me.IconPicture_close.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.IconPicture_close.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        Me.IconPicture_close.IconColor = System.Drawing.Color.White
        Me.IconPicture_close.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPicture_close.Location = New System.Drawing.Point(450, 1)
        Me.IconPicture_close.Name = "IconPicture_close"
        Me.IconPicture_close.Size = New System.Drawing.Size(32, 32)
        Me.IconPicture_close.TabIndex = 6
        Me.IconPicture_close.TabStop = False
        '
        'IconPicture_minimize
        '
        Me.IconPicture_minimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.IconPicture_minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.IconPicture_minimize.IconColor = System.Drawing.Color.White
        Me.IconPicture_minimize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPicture_minimize.Location = New System.Drawing.Point(421, 1)
        Me.IconPicture_minimize.Name = "IconPicture_minimize"
        Me.IconPicture_minimize.Size = New System.Drawing.Size(32, 32)
        Me.IconPicture_minimize.TabIndex = 6
        Me.IconPicture_minimize.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_login)
        Me.Panel1.Controls.Add(Me.lbl_datatime)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(482, 458)
        Me.Panel1.TabIndex = 4
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.IconPicture_minimize)
        Me.Controls.Add(Me.IconPicture_close)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IconPictureBox1)
        Me.Controls.Add(Me.lbl_loginPassword)
        Me.Controls.Add(Me.lbl_loginUsername)
        Me.Controls.Add(Me.txt_loginUsername)
        Me.Controls.Add(Me.txt_loginPassword)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPicture_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPicture_minimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_loginPassword As TextBox
    Friend WithEvents txt_loginUsername As TextBox
    Friend WithEvents lbl_loginUsername As Label
    Friend WithEvents lbl_loginPassword As Label
    Friend WithEvents btn_login As Button
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_datatime As Label
    Friend WithEvents timer_datetime As Timer
    Friend WithEvents IconPicture_close As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPicture_minimize As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel1 As Panel
End Class
