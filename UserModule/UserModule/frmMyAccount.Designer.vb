<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMyAccount
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
        Me.components = New System.ComponentModel.Container()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblChangePassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblSave = New System.Windows.Forms.Button()
        Me.btnSignUpCancel = New System.Windows.Forms.Button()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblHi = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblUName = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblNewPass = New System.Windows.Forms.Label()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.lblRepNew = New System.Windows.Forms.Label()
        Me.txtRepPass = New System.Windows.Forms.TextBox()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblsrno = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(64, 152)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(55, 13)
        Me.lblUsername.TabIndex = 18
        Me.lblUsername.Text = "Username"
        '
        'lblChangePassword
        '
        Me.lblChangePassword.AutoSize = True
        Me.lblChangePassword.Location = New System.Drawing.Point(444, 152)
        Me.lblChangePassword.Name = "lblChangePassword"
        Me.lblChangePassword.Size = New System.Drawing.Size(93, 13)
        Me.lblChangePassword.TabIndex = 19
        Me.lblChangePassword.Text = "Change Password"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(189, 145)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtUsername.TabIndex = 20
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(558, 194)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 21
        Me.txtPassword.UseSystemPasswordChar = True
        Me.txtPassword.Visible = False
        '
        'lblSave
        '
        Me.lblSave.Location = New System.Drawing.Point(189, 484)
        Me.lblSave.Name = "lblSave"
        Me.lblSave.Size = New System.Drawing.Size(75, 23)
        Me.lblSave.TabIndex = 22
        Me.lblSave.Text = "Save"
        Me.lblSave.UseVisualStyleBackColor = True
        '
        'btnSignUpCancel
        '
        Me.btnSignUpCancel.Location = New System.Drawing.Point(305, 484)
        Me.btnSignUpCancel.Name = "btnSignUpCancel"
        Me.btnSignUpCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnSignUpCancel.TabIndex = 23
        Me.btnSignUpCancel.Text = "Cancel"
        Me.btnSignUpCancel.UseVisualStyleBackColor = True
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(189, 194)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 33
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Location = New System.Drawing.Point(64, 233)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(39, 13)
        Me.lblMail.TabIndex = 27
        Me.lblMail.Text = "E-Mail:"
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(189, 233)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtMail.Size = New System.Drawing.Size(100, 20)
        Me.txtMail.TabIndex = 28
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(64, 280)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 30
        Me.lblAddress.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(189, 280)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(161, 100)
        Me.txtAddress.TabIndex = 31
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(64, 194)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(75, 13)
        Me.lblPhoneNumber.TabIndex = 32
        Me.lblPhoneNumber.Text = "PhoneNumber"
        '
        'lblHi
        '
        Me.lblHi.AutoSize = True
        Me.lblHi.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.lblHi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHi.ForeColor = System.Drawing.Color.GhostWhite
        Me.lblHi.Location = New System.Drawing.Point(327, 13)
        Me.lblHi.Name = "lblHi"
        Me.lblHi.Size = New System.Drawing.Size(23, 13)
        Me.lblHi.TabIndex = 35
        Me.lblHi.Text = "Hi!"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ShopSoft.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(288, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(1, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1000, 117)
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.PictureBox3.Image = Global.ShopSoft.My.Resources.Resources.shopping_cart_logo
        Me.PictureBox3.Location = New System.Drawing.Point(558, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(83, 87)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 37
        Me.PictureBox3.TabStop = False
        '
        'lblUName
        '
        Me.lblUName.AutoSize = True
        Me.lblUName.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.lblUName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUName.ForeColor = System.Drawing.Color.GhostWhite
        Me.lblUName.Location = New System.Drawing.Point(351, 35)
        Me.lblUName.Name = "lblUName"
        Me.lblUName.Size = New System.Drawing.Size(0, 13)
        Me.lblUName.TabIndex = 38
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(444, 191)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(72, 13)
        Me.lblPassword.TabIndex = 39
        Me.lblPassword.Text = "Old Password"
        Me.lblPassword.Visible = False
        '
        'lblNewPass
        '
        Me.lblNewPass.AutoSize = True
        Me.lblNewPass.Location = New System.Drawing.Point(444, 230)
        Me.lblNewPass.Name = "lblNewPass"
        Me.lblNewPass.Size = New System.Drawing.Size(78, 13)
        Me.lblNewPass.TabIndex = 40
        Me.lblNewPass.Text = "New Password"
        Me.lblNewPass.Visible = False
        '
        'txtNewPass
        '
        Me.txtNewPass.Location = New System.Drawing.Point(558, 233)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPass.Size = New System.Drawing.Size(100, 20)
        Me.txtNewPass.TabIndex = 41
        Me.txtNewPass.UseSystemPasswordChar = True
        Me.txtNewPass.Visible = False
        '
        'lblRepNew
        '
        Me.lblRepNew.AutoSize = True
        Me.lblRepNew.Location = New System.Drawing.Point(444, 275)
        Me.lblRepNew.Name = "lblRepNew"
        Me.lblRepNew.Size = New System.Drawing.Size(91, 13)
        Me.lblRepNew.TabIndex = 42
        Me.lblRepNew.Text = "Repeat Passwprd"
        Me.lblRepNew.Visible = False
        '
        'txtRepPass
        '
        Me.txtRepPass.Location = New System.Drawing.Point(558, 268)
        Me.txtRepPass.Name = "txtRepPass"
        Me.txtRepPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRepPass.Size = New System.Drawing.Size(100, 20)
        Me.txtRepPass.TabIndex = 43
        Me.txtRepPass.UseSystemPasswordChar = True
        Me.txtRepPass.Visible = False
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(535, 314)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 44
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        Me.btnApply.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'lblsrno
        '
        Me.lblsrno.AutoSize = True
        Me.lblsrno.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.lblsrno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsrno.ForeColor = System.Drawing.Color.Red
        Me.lblsrno.Location = New System.Drawing.Point(621, 86)
        Me.lblsrno.Name = "lblsrno"
        Me.lblsrno.Size = New System.Drawing.Size(14, 13)
        Me.lblsrno.TabIndex = 45
        Me.lblsrno.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(621, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 46
        '
        'frmMyAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(699, 547)
        Me.Controls.Add(Me.lblsrno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.txtRepPass)
        Me.Controls.Add(Me.lblRepNew)
        Me.Controls.Add(Me.txtNewPass)
        Me.Controls.Add(Me.lblNewPass)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUName)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.lblHi)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSignUpCancel)
        Me.Controls.Add(Me.lblSave)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblChangePassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "frmMyAccount"
        Me.Text = "My Account"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblChangePassword As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblSave As System.Windows.Forms.Button
    Friend WithEvents btnSignUpCancel As System.Windows.Forms.Button
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblPhoneNumber As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblHi As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblUName As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblNewPass As System.Windows.Forms.Label
    Friend WithEvents txtNewPass As System.Windows.Forms.TextBox
    Friend WithEvents lblRepNew As System.Windows.Forms.Label
    Friend WithEvents txtRepPass As System.Windows.Forms.TextBox
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblsrno As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
