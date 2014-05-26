<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplashLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplashLogin))
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.picLogin = New System.Windows.Forms.PictureBox()
        Me.AnimateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.cmbShop = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.ForeColor = System.Drawing.Color.Gray
        Me.txtUser.Location = New System.Drawing.Point(32, 130)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(156, 20)
        Me.txtUser.TabIndex = 14
        Me.txtUser.Text = "User Name"
        Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtUser.Visible = False
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Gray
        Me.txtPassword.Location = New System.Drawing.Point(34, 156)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(155, 20)
        Me.txtPassword.TabIndex = 15
        Me.txtPassword.Text = "Password"
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPassword.Visible = False
        '
        'picLogo
        '
        Me.picLogo.Image = Global.ShopSoft.My.Resources.Resources.splash
        Me.picLogo.Location = New System.Drawing.Point(231, 12)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(310, 333)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 16
        Me.picLogo.TabStop = False
        '
        'picLogin
        '
        Me.picLogin.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.picLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLogin.Image = Global.ShopSoft.My.Resources.Resources.picLogin
        Me.picLogin.Location = New System.Drawing.Point(69, 207)
        Me.picLogin.Name = "picLogin"
        Me.picLogin.Size = New System.Drawing.Size(70, 27)
        Me.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogin.TabIndex = 12
        Me.picLogin.TabStop = False
        Me.picLogin.Visible = False
        '
        'AnimateTimer
        '
        Me.AnimateTimer.Interval = 30
        '
        'cmbShop
        '
        Me.cmbShop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbShop.FormattingEnabled = True
        Me.cmbShop.Items.AddRange(New Object() {"Eternity Mall", "Zansaar", "Happy Gift Shop"})
        Me.cmbShop.Location = New System.Drawing.Point(32, 73)
        Me.cmbShop.Name = "cmbShop"
        Me.cmbShop.Size = New System.Drawing.Size(156, 21)
        Me.cmbShop.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Select your shop"
        '
        'NotifyIcon
        '
        Me.NotifyIcon.BalloonTipText = "ShopSoft - Shop Module started..."
        Me.NotifyIcon.BalloonTipTitle = "ShopSoft"
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Visible = True
        '
        'frmSplashLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(545, 349)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbShop)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.picLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSplashLogin"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome to ShopSoft - Login"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picLogin As System.Windows.Forms.PictureBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents AnimateTimer As System.Windows.Forms.Timer
    Friend WithEvents cmbShop As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NotifyIcon As System.Windows.Forms.NotifyIcon

End Class
