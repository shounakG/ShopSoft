<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddRegisteredCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddRegisteredCustomer))
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblMobileNo = New System.Windows.Forms.Label()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.errCustomer = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtProvider = New System.Windows.Forms.ComboBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.ToolTipPwd = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblDatefBirth = New System.Windows.Forms.Label()
        Me.DOBCustomer = New System.Windows.Forms.DateTimePicker()
        CType(Me.errCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(35, 55)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(35, 114)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress.TabIndex = 1
        Me.lblAddress.Text = "Address:"
        '
        'lblMobileNo
        '
        Me.lblMobileNo.AutoSize = True
        Me.lblMobileNo.Location = New System.Drawing.Point(35, 291)
        Me.lblMobileNo.Name = "lblMobileNo"
        Me.lblMobileNo.Size = New System.Drawing.Size(81, 13)
        Me.lblMobileNo.TabIndex = 2
        Me.lblMobileNo.Text = "Mobile Number:"
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Location = New System.Drawing.Point(35, 346)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(38, 13)
        Me.lblMail.TabIndex = 3
        Me.lblMail.Text = "e-Mail:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(171, 48)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(205, 20)
        Me.txtName.TabIndex = 0
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(171, 107)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAddress.Size = New System.Drawing.Size(205, 64)
        Me.txtAddress.TabIndex = 1
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(171, 284)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(205, 20)
        Me.txtMobile.TabIndex = 4
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(171, 339)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtMail.Size = New System.Drawing.Size(105, 20)
        Me.txtMail.TabIndex = 5
        '
        'errCustomer
        '
        Me.errCustomer.ContainerControl = Me
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(176, 387)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(77, 37)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = CType(resources.GetObject("btnCancel.BackgroundImage"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(292, 387)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(84, 37)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtProvider
        '
        Me.txtProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtProvider.FormattingEnabled = True
        Me.txtProvider.Items.AddRange(New Object() {"Other", "gmail.com", "yahoo.com", "rediffmail.com", "hotmail.com", "msn.com"})
        Me.txtProvider.Location = New System.Drawing.Point(282, 338)
        Me.txtProvider.Name = "txtProvider"
        Me.txtProvider.Size = New System.Drawing.Size(94, 21)
        Me.txtProvider.TabIndex = 6
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(35, 197)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblPassword.TabIndex = 11
        Me.lblPassword.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(171, 190)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(205, 20)
        Me.txtPassword.TabIndex = 2
        '
        'ToolTipPwd
        '
        Me.ToolTipPwd.IsBalloon = True
        Me.ToolTipPwd.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTipPwd.ToolTipTitle = "Inserting your password"
        '
        'lblDatefBirth
        '
        Me.lblDatefBirth.AutoSize = True
        Me.lblDatefBirth.Location = New System.Drawing.Point(35, 246)
        Me.lblDatefBirth.Name = "lblDatefBirth"
        Me.lblDatefBirth.Size = New System.Drawing.Size(68, 13)
        Me.lblDatefBirth.TabIndex = 12
        Me.lblDatefBirth.Text = "Date of birth:"
        '
        'DOBCustomer
        '
        Me.DOBCustomer.Location = New System.Drawing.Point(176, 240)
        Me.DOBCustomer.Name = "DOBCustomer"
        Me.DOBCustomer.Size = New System.Drawing.Size(200, 20)
        Me.DOBCustomer.TabIndex = 3
        Me.DOBCustomer.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'frmAddRegisteredCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(439, 439)
        Me.Controls.Add(Me.DOBCustomer)
        Me.Controls.Add(Me.lblDatefBirth)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtProvider)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.txtMobile)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.lblMobileNo)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblName)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddRegisteredCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add registered customer"
        CType(Me.errCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblMobileNo As System.Windows.Forms.Label
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents errCustomer As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtProvider As System.Windows.Forms.ComboBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents ToolTipPwd As System.Windows.Forms.ToolTip
    Friend WithEvents lblDatefBirth As System.Windows.Forms.Label
    Friend WithEvents DOBCustomer As System.Windows.Forms.DateTimePicker
End Class
