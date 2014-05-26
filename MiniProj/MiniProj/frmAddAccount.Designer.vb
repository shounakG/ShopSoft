<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddAccount
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
        Me.lblNewUser = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblConfirmPass = New System.Windows.Forms.Label()
        Me.txtNewUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtConfirmPass = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.prgbarPwdStrength = New System.Windows.Forms.ProgressBar()
        Me.lblPwdStrength = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNewUser
        '
        Me.lblNewUser.AutoSize = True
        Me.lblNewUser.Location = New System.Drawing.Point(43, 47)
        Me.lblNewUser.Name = "lblNewUser"
        Me.lblNewUser.Size = New System.Drawing.Size(66, 16)
        Me.lblNewUser.TabIndex = 0
        Me.lblNewUser.Text = "User Name:"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(43, 82)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(61, 16)
        Me.lblPass.TabIndex = 1
        Me.lblPass.Text = "Password:"
        '
        'lblConfirmPass
        '
        Me.lblConfirmPass.AutoSize = True
        Me.lblConfirmPass.Location = New System.Drawing.Point(43, 114)
        Me.lblConfirmPass.Name = "lblConfirmPass"
        Me.lblConfirmPass.Size = New System.Drawing.Size(104, 16)
        Me.lblConfirmPass.TabIndex = 2
        Me.lblConfirmPass.Text = "Confirm Password:"
        '
        'txtNewUser
        '
        Me.txtNewUser.Location = New System.Drawing.Point(161, 43)
        Me.txtNewUser.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNewUser.Name = "txtNewUser"
        Me.txtNewUser.Size = New System.Drawing.Size(140, 20)
        Me.txtNewUser.TabIndex = 3
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(161, 79)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(3, 4, 50, 4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(140, 20)
        Me.txtPass.TabIndex = 4
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.Location = New System.Drawing.Point(161, 111)
        Me.txtConfirmPass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPass.Size = New System.Drawing.Size(140, 20)
        Me.txtConfirmPass.TabIndex = 5
        '
        'btnOK
        '
        Me.btnOK.BackgroundImage = Global.ShopSoft.My.Resources.Resources.back1
        Me.btnOK.Location = New System.Drawing.Point(71, 172)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 10)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(85, 34)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = Global.ShopSoft.My.Resources.Resources.back1
        Me.btnCancel.Location = New System.Drawing.Point(170, 172)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 10)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(82, 34)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'prgbarPwdStrength
        '
        Me.prgbarPwdStrength.Location = New System.Drawing.Point(317, 76)
        Me.prgbarPwdStrength.Margin = New System.Windows.Forms.Padding(3, 3, 8, 3)
        Me.prgbarPwdStrength.Name = "prgbarPwdStrength"
        Me.prgbarPwdStrength.Size = New System.Drawing.Size(128, 23)
        Me.prgbarPwdStrength.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgbarPwdStrength.TabIndex = 8
        Me.prgbarPwdStrength.Visible = False
        '
        'lblPwdStrength
        '
        Me.lblPwdStrength.AutoSize = True
        Me.lblPwdStrength.Location = New System.Drawing.Point(332, 102)
        Me.lblPwdStrength.Name = "lblPwdStrength"
        Me.lblPwdStrength.Size = New System.Drawing.Size(105, 16)
        Me.lblPwdStrength.TabIndex = 9
        Me.lblPwdStrength.Text = "Password strength"
        Me.lblPwdStrength.Visible = False
        '
        'frmAddAccount
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(454, 215)
        Me.Controls.Add(Me.lblPwdStrength)
        Me.Controls.Add(Me.prgbarPwdStrength)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtConfirmPass)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtNewUser)
        Me.Controls.Add(Me.lblConfirmPass)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblNewUser)
        Me.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddAccount"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ShopSoft - Add a shop account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNewUser As System.Windows.Forms.Label
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents lblConfirmPass As System.Windows.Forms.Label
    Friend WithEvents txtNewUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirmPass As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents prgbarPwdStrength As System.Windows.Forms.ProgressBar
    Friend WithEvents lblPwdStrength As System.Windows.Forms.Label
End Class
