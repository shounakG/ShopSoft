<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminHome
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
        Me.grpAdmin = New System.Windows.Forms.GroupBox()
        Me.picManageCategories = New System.Windows.Forms.PictureBox()
        Me.picChangePassword = New System.Windows.Forms.PictureBox()
        Me.picViewUser = New System.Windows.Forms.PictureBox()
        Me.picCreateUser = New System.Windows.Forms.PictureBox()
        Me.mnuStripMDI = New System.Windows.Forms.MenuStrip()
        Me.mnuFileMDI = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpenRec = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpenInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewAccounts = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpAdmin.SuspendLayout()
        CType(Me.picManageCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChangePassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picViewUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCreateUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuStripMDI.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAdmin
        '
        Me.grpAdmin.BackColor = System.Drawing.Color.PeachPuff
        Me.grpAdmin.Controls.Add(Me.picManageCategories)
        Me.grpAdmin.Controls.Add(Me.picChangePassword)
        Me.grpAdmin.Controls.Add(Me.picViewUser)
        Me.grpAdmin.Controls.Add(Me.picCreateUser)
        Me.grpAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAdmin.Location = New System.Drawing.Point(7, 12)
        Me.grpAdmin.Name = "grpAdmin"
        Me.grpAdmin.Size = New System.Drawing.Size(324, 414)
        Me.grpAdmin.TabIndex = 0
        Me.grpAdmin.TabStop = False
        '
        'picManageCategories
        '
        Me.picManageCategories.Image = Global.MiniProj.My.Resources.Resources.btnManageCategories
        Me.picManageCategories.Location = New System.Drawing.Point(68, 203)
        Me.picManageCategories.Name = "picManageCategories"
        Me.picManageCategories.Size = New System.Drawing.Size(188, 51)
        Me.picManageCategories.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picManageCategories.TabIndex = 3
        Me.picManageCategories.TabStop = False
        '
        'picChangePassword
        '
        Me.picChangePassword.Image = Global.MiniProj.My.Resources.Resources.btnChangePasswordAdmin
        Me.picChangePassword.Location = New System.Drawing.Point(68, 146)
        Me.picChangePassword.Name = "picChangePassword"
        Me.picChangePassword.Size = New System.Drawing.Size(188, 51)
        Me.picChangePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picChangePassword.TabIndex = 2
        Me.picChangePassword.TabStop = False
        '
        'picViewUser
        '
        Me.picViewUser.Image = Global.MiniProj.My.Resources.Resources.btnAdminViewUserDetails
        Me.picViewUser.Location = New System.Drawing.Point(68, 89)
        Me.picViewUser.Name = "picViewUser"
        Me.picViewUser.Size = New System.Drawing.Size(188, 51)
        Me.picViewUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picViewUser.TabIndex = 1
        Me.picViewUser.TabStop = False
        '
        'picCreateUser
        '
        Me.picCreateUser.Image = Global.MiniProj.My.Resources.Resources.btnAdminCreateUser
        Me.picCreateUser.Location = New System.Drawing.Point(65, 34)
        Me.picCreateUser.Name = "picCreateUser"
        Me.picCreateUser.Size = New System.Drawing.Size(191, 49)
        Me.picCreateUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picCreateUser.TabIndex = 0
        Me.picCreateUser.TabStop = False
        '
        'mnuStripMDI
        '
        Me.mnuStripMDI.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileMDI})
        Me.mnuStripMDI.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.mnuStripMDI.Location = New System.Drawing.Point(0, 0)
        Me.mnuStripMDI.Name = "mnuStripMDI"
        Me.mnuStripMDI.Size = New System.Drawing.Size(343, 24)
        Me.mnuStripMDI.TabIndex = 2
        '
        'mnuFileMDI
        '
        Me.mnuFileMDI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpenRec, Me.mnuOpenInventory, Me.mnuViewAccounts, Me.ToolStripSeparator1, Me.mnuExit})
        Me.mnuFileMDI.Name = "mnuFileMDI"
        Me.mnuFileMDI.Size = New System.Drawing.Size(37, 20)
        Me.mnuFileMDI.Text = "&File"
        '
        'mnuOpenRec
        '
        Me.mnuOpenRec.Name = "mnuOpenRec"
        Me.mnuOpenRec.Size = New System.Drawing.Size(184, 22)
        Me.mnuOpenRec.Text = "Open Billing Records"
        '
        'mnuOpenInventory
        '
        Me.mnuOpenInventory.Name = "mnuOpenInventory"
        Me.mnuOpenInventory.Size = New System.Drawing.Size(184, 22)
        Me.mnuOpenInventory.Text = "Open Item Inventory"
        '
        'mnuViewAccounts
        '
        Me.mnuViewAccounts.Name = "mnuViewAccounts"
        Me.mnuViewAccounts.Size = New System.Drawing.Size(184, 22)
        Me.mnuViewAccounts.Text = "View User Accounts"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(181, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.ShortcutKeyDisplayString = "Alt + F4"
        Me.mnuExit.Size = New System.Drawing.Size(184, 22)
        Me.mnuExit.Text = "Exit"
        '
        'frmAdminHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(343, 438)
        Me.Controls.Add(Me.mnuStripMDI)
        Me.Controls.Add(Me.grpAdmin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmAdminHome"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Shop @home-Administrator"
        Me.grpAdmin.ResumeLayout(False)
        CType(Me.picManageCategories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChangePassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picViewUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCreateUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuStripMDI.ResumeLayout(False)
        Me.mnuStripMDI.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpAdmin As System.Windows.Forms.GroupBox
    Friend WithEvents picCreateUser As System.Windows.Forms.PictureBox
    Friend WithEvents mnuStripMDI As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFileMDI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOpenRec As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOpenInventory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuViewAccounts As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picViewUser As System.Windows.Forms.PictureBox
    Friend WithEvents picChangePassword As System.Windows.Forms.PictureBox
    Friend WithEvents picManageCategories As System.Windows.Forms.PictureBox
End Class
