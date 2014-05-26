<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.lblLoginName = New System.Windows.Forms.Label()
        Me.lblLoginPassword = New System.Windows.Forms.Label()
        Me.txtCustPass = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblNewUser = New System.Windows.Forms.Label()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picLoginLogo = New System.Windows.Forms.PictureBox()
        CType(Me.picLoginLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCustName
        '
        Me.txtCustName.Location = New System.Drawing.Point(158, 135)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(100, 20)
        Me.txtCustName.TabIndex = 0
        '
        'lblLoginName
        '
        Me.lblLoginName.AutoSize = True
        Me.lblLoginName.Location = New System.Drawing.Point(83, 135)
        Me.lblLoginName.Name = "lblLoginName"
        Me.lblLoginName.Size = New System.Drawing.Size(35, 13)
        Me.lblLoginName.TabIndex = 1
        Me.lblLoginName.Text = "Name"
        '
        'lblLoginPassword
        '
        Me.lblLoginPassword.AutoSize = True
        Me.lblLoginPassword.Location = New System.Drawing.Point(83, 178)
        Me.lblLoginPassword.Name = "lblLoginPassword"
        Me.lblLoginPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblLoginPassword.TabIndex = 2
        Me.lblLoginPassword.Text = "Password"
        '
        'txtCustPass
        '
        Me.txtCustPass.Location = New System.Drawing.Point(158, 178)
        Me.txtCustPass.Name = "txtCustPass"
        Me.txtCustPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCustPass.Size = New System.Drawing.Size(100, 20)
        Me.txtCustPass.TabIndex = 3
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(135, 245)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lblNewUser
        '
        Me.lblNewUser.AutoSize = True
        Me.lblNewUser.Location = New System.Drawing.Point(83, 315)
        Me.lblNewUser.Name = "lblNewUser"
        Me.lblNewUser.Size = New System.Drawing.Size(57, 13)
        Me.lblNewUser.TabIndex = 5
        Me.lblNewUser.Text = "NewUser?"
        '
        'btnSignUp
        '
        Me.btnSignUp.Location = New System.Drawing.Point(169, 310)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(75, 23)
        Me.btnSignUp.TabIndex = 6
        Me.btnSignUp.Text = "Sign Up"
        Me.btnSignUp.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(228, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Forgot Password?"
        '
        'picLoginLogo
        '
        Me.picLoginLogo.Image = Global.ShopSoft.My.Resources.Resources.logo
        Me.picLoginLogo.Location = New System.Drawing.Point(77, 41)
        Me.picLoginLogo.Name = "picLoginLogo"
        Me.picLoginLogo.Size = New System.Drawing.Size(188, 57)
        Me.picLoginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLoginLogo.TabIndex = 7
        Me.picLoginLogo.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(322, 372)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picLoginLogo)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.lblNewUser)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtCustPass)
        Me.Controls.Add(Me.lblLoginPassword)
        Me.Controls.Add(Me.lblLoginName)
        Me.Controls.Add(Me.txtCustName)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.Text = "Login"
        CType(Me.picLoginLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCustName As System.Windows.Forms.TextBox
    Friend WithEvents lblLoginName As System.Windows.Forms.Label
    Friend WithEvents lblLoginPassword As System.Windows.Forms.Label
    Friend WithEvents txtCustPass As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents lblNewUser As System.Windows.Forms.Label
    Friend WithEvents btnSignUp As System.Windows.Forms.Button
    Friend WithEvents picLoginLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
