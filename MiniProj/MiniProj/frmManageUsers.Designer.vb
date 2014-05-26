<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageUsers
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
        Me.txtstatMainMDI = New System.Windows.Forms.ToolStripStatusLabel()
        Me.prgbarMainMDI = New System.Windows.Forms.ToolStripProgressBar()
        Me.mnuFileMDI = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpenRec = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpenInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewAccounts = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCreateUser = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtstatMainMDI
        '
        Me.txtstatMainMDI.BackColor = System.Drawing.SystemColors.Control
        Me.txtstatMainMDI.Name = "txtstatMainMDI"
        Me.txtstatMainMDI.Size = New System.Drawing.Size(134, 17)
        Me.txtstatMainMDI.Text = "Welcome-Shop @home"
        '
        'prgbarMainMDI
        '
        Me.prgbarMainMDI.Name = "prgbarMainMDI"
        Me.prgbarMainMDI.Size = New System.Drawing.Size(100, 16)
        Me.prgbarMainMDI.Style = System.Windows.Forms.ProgressBarStyle.Continuous
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
        'btnCreateUser
        '
        Me.btnCreateUser.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateUser.Image = Global.ShopSoft.My.Resources.Resources.back1
        Me.btnCreateUser.Location = New System.Drawing.Point(111, 61)
        Me.btnCreateUser.Name = "btnCreateUser"
        Me.btnCreateUser.Size = New System.Drawing.Size(132, 34)
        Me.btnCreateUser.TabIndex = 6
        Me.btnCreateUser.Text = "Create user"
        Me.btnCreateUser.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Image = Global.ShopSoft.My.Resources.Resources.back1
        Me.btnView.Location = New System.Drawing.Point(111, 117)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(132, 34)
        Me.btnView.TabIndex = 7
        Me.btnView.Text = "View and edit users"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'frmManageUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(360, 210)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnCreateUser)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmManageUsers"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ShopSoft - Manage Users"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtstatMainMDI As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents prgbarMainMDI As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents mnuFileMDI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOpenRec As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOpenInventory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuViewAccounts As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCreateUser As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
End Class
