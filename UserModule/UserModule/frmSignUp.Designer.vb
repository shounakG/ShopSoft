<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSignUp
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
        Me.lblSignUpName = New System.Windows.Forms.Label()
        Me.lblSignUpPassword = New System.Windows.Forms.Label()
        Me.txtSignUpUsername = New System.Windows.Forms.TextBox()
        Me.txtSignUpPassword = New System.Windows.Forms.TextBox()
        Me.btnSignUpSignUp = New System.Windows.Forms.Button()
        Me.btnSignUpCancel = New System.Windows.Forms.Button()
        Me.lblSignUpRepeat = New System.Windows.Forms.Label()
        Me.txtSignUpRepeat = New System.Windows.Forms.TextBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblSignUpAddress = New System.Windows.Forms.Label()
        Me.txtSignUpAddress = New System.Windows.Forms.TextBox()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.txtSignUpPhone = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSignUpName
        '
        Me.lblSignUpName.AutoSize = True
        Me.lblSignUpName.Location = New System.Drawing.Point(48, 157)
        Me.lblSignUpName.Name = "lblSignUpName"
        Me.lblSignUpName.Size = New System.Drawing.Size(94, 13)
        Me.lblSignUpName.TabIndex = 0
        Me.lblSignUpName.Text = "Desired Username"
        '
        'lblSignUpPassword
        '
        Me.lblSignUpPassword.AutoSize = True
        Me.lblSignUpPassword.Location = New System.Drawing.Point(50, 204)
        Me.lblSignUpPassword.Name = "lblSignUpPassword"
        Me.lblSignUpPassword.Size = New System.Drawing.Size(92, 13)
        Me.lblSignUpPassword.TabIndex = 1
        Me.lblSignUpPassword.Text = "Desired Password"
        '
        'txtSignUpUsername
        '
        Me.txtSignUpUsername.Location = New System.Drawing.Point(171, 157)
        Me.txtSignUpUsername.Name = "txtSignUpUsername"
        Me.txtSignUpUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtSignUpUsername.TabIndex = 2
        '
        'txtSignUpPassword
        '
        Me.txtSignUpPassword.Location = New System.Drawing.Point(171, 197)
        Me.txtSignUpPassword.Name = "txtSignUpPassword"
        Me.txtSignUpPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSignUpPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtSignUpPassword.TabIndex = 3
        '
        'btnSignUpSignUp
        '
        Me.btnSignUpSignUp.Location = New System.Drawing.Point(171, 492)
        Me.btnSignUpSignUp.Name = "btnSignUpSignUp"
        Me.btnSignUpSignUp.Size = New System.Drawing.Size(75, 23)
        Me.btnSignUpSignUp.TabIndex = 4
        Me.btnSignUpSignUp.Text = "Sign Up"
        Me.btnSignUpSignUp.UseVisualStyleBackColor = True
        '
        'btnSignUpCancel
        '
        Me.btnSignUpCancel.Location = New System.Drawing.Point(292, 492)
        Me.btnSignUpCancel.Name = "btnSignUpCancel"
        Me.btnSignUpCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnSignUpCancel.TabIndex = 5
        Me.btnSignUpCancel.Text = "Cancel"
        Me.btnSignUpCancel.UseVisualStyleBackColor = True
        '
        'lblSignUpRepeat
        '
        Me.lblSignUpRepeat.AutoSize = True
        Me.lblSignUpRepeat.Location = New System.Drawing.Point(51, 243)
        Me.lblSignUpRepeat.Name = "lblSignUpRepeat"
        Me.lblSignUpRepeat.Size = New System.Drawing.Size(91, 13)
        Me.lblSignUpRepeat.TabIndex = 6
        Me.lblSignUpRepeat.Text = "Repeat Password"
        '
        'txtSignUpRepeat
        '
        Me.txtSignUpRepeat.Location = New System.Drawing.Point(171, 240)
        Me.txtSignUpRepeat.Name = "txtSignUpRepeat"
        Me.txtSignUpRepeat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSignUpRepeat.Size = New System.Drawing.Size(100, 20)
        Me.txtSignUpRepeat.TabIndex = 7
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(171, 311)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtMail.Size = New System.Drawing.Size(105, 20)
        Me.txtMail.TabIndex = 12
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Location = New System.Drawing.Point(51, 318)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(38, 13)
        Me.lblMail.TabIndex = 11
        Me.lblMail.Text = "e-Mail:"
        '
        'lblSignUpAddress
        '
        Me.lblSignUpAddress.AutoSize = True
        Me.lblSignUpAddress.Location = New System.Drawing.Point(322, 145)
        Me.lblSignUpAddress.Name = "lblSignUpAddress"
        Me.lblSignUpAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblSignUpAddress.TabIndex = 14
        Me.lblSignUpAddress.Text = "Address"
        '
        'txtSignUpAddress
        '
        Me.txtSignUpAddress.Location = New System.Drawing.Point(325, 173)
        Me.txtSignUpAddress.Multiline = True
        Me.txtSignUpAddress.Name = "txtSignUpAddress"
        Me.txtSignUpAddress.Size = New System.Drawing.Size(161, 100)
        Me.txtSignUpAddress.TabIndex = 15
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(51, 277)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(75, 13)
        Me.lblPhoneNumber.TabIndex = 16
        Me.lblPhoneNumber.Text = "PhoneNumber"
        '
        'txtSignUpPhone
        '
        Me.txtSignUpPhone.Location = New System.Drawing.Point(171, 277)
        Me.txtSignUpPhone.Name = "txtSignUpPhone"
        Me.txtSignUpPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtSignUpPhone.TabIndex = 17
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ShopSoft.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(110, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(281, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Location = New System.Drawing.Point(51, 351)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(33, 13)
        Me.lblDOB.TabIndex = 18
        Me.lblDOB.Text = "DOB:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(171, 351)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 19
        Me.DateTimePicker1.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'frmSignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(511, 527)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.txtSignUpPhone)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.txtSignUpAddress)
        Me.Controls.Add(Me.lblSignUpAddress)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtSignUpRepeat)
        Me.Controls.Add(Me.lblSignUpRepeat)
        Me.Controls.Add(Me.btnSignUpCancel)
        Me.Controls.Add(Me.btnSignUpSignUp)
        Me.Controls.Add(Me.txtSignUpPassword)
        Me.Controls.Add(Me.txtSignUpUsername)
        Me.Controls.Add(Me.lblSignUpPassword)
        Me.Controls.Add(Me.lblSignUpName)
        Me.Name = "frmSignUp"
        Me.Text = "Sign Up"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSignUpName As System.Windows.Forms.Label
    Friend WithEvents lblSignUpPassword As System.Windows.Forms.Label
    Friend WithEvents txtSignUpUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtSignUpPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnSignUpSignUp As System.Windows.Forms.Button
    Friend WithEvents btnSignUpCancel As System.Windows.Forms.Button
    Friend WithEvents lblSignUpRepeat As System.Windows.Forms.Label
    Friend WithEvents txtSignUpRepeat As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents lblSignUpAddress As System.Windows.Forms.Label
    Friend WithEvents txtSignUpAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblPhoneNumber As System.Windows.Forms.Label
    Friend WithEvents txtSignUpPhone As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDOB As System.Windows.Forms.Label
End Class
