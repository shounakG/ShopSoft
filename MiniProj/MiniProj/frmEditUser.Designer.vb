<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditUser))
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtCounter = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.picUser = New System.Windows.Forms.PictureBox()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.selPicUser = New System.Windows.Forms.OpenFileDialog()
        Me.errContact = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errContact, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(173, 34)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(241, 22)
        Me.txtUserName.TabIndex = 0
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(30, 37)
        Me.lblUserName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(78, 17)
        Me.lblUserName.TabIndex = 1
        Me.lblUserName.Text = "User Name:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(30, 77)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(61, 17)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "Address:"
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Location = New System.Drawing.Point(25, 179)
        Me.lblContact.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(83, 17)
        Me.lblContact.TabIndex = 3
        Me.lblContact.Text = "Contact No:"
        '
        'lblCounter
        '
        Me.lblCounter.AutoSize = True
        Me.lblCounter.Location = New System.Drawing.Point(25, 243)
        Me.lblCounter.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(63, 17)
        Me.lblCounter.TabIndex = 4
        Me.lblCounter.Text = "Counter:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(173, 74)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAddress.Size = New System.Drawing.Size(241, 79)
        Me.txtAddress.TabIndex = 5
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(173, 176)
        Me.txtContact.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(241, 22)
        Me.txtContact.TabIndex = 6
        '
        'txtCounter
        '
        Me.txtCounter.Location = New System.Drawing.Point(173, 240)
        Me.txtCounter.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCounter.Name = "txtCounter"
        Me.txtCounter.Size = New System.Drawing.Size(241, 22)
        Me.txtCounter.TabIndex = 7
        '
        'btnOK
        '
        Me.btnOK.BackgroundImage = CType(resources.GetObject("btnOK.BackgroundImage"), System.Drawing.Image)
        Me.btnOK.Location = New System.Drawing.Point(80, 318)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(94, 39)
        Me.btnOK.TabIndex = 8
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = CType(resources.GetObject("btnCancel.BackgroundImage"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(225, 318)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(94, 39)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'picUser
        '
        Me.picUser.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.picUser.ErrorImage = Nothing
        Me.picUser.Location = New System.Drawing.Point(443, 34)
        Me.picUser.Name = "picUser"
        Me.picUser.Size = New System.Drawing.Size(169, 206)
        Me.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUser.TabIndex = 16
        Me.picUser.TabStop = False
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.Font = New System.Drawing.Font("Ubuntu", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote.Location = New System.Drawing.Point(440, 245)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(172, 16)
        Me.lblNote.TabIndex = 17
        Me.lblNote.Text = "Click on the image to change"
        '
        'errContact
        '
        Me.errContact.ContainerControl = Me
        '
        'frmEditUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(624, 391)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.picUser)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtCounter)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblCounter)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.txtUserName)
        Me.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditUser"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit User"
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errContact, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblContact As System.Windows.Forms.Label
    Friend WithEvents lblCounter As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents txtCounter As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents picUser As System.Windows.Forms.PictureBox
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents selPicUser As System.Windows.Forms.OpenFileDialog
    Friend WithEvents errContact As System.Windows.Forms.ErrorProvider
End Class
