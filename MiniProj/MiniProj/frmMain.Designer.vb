<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.contextExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtElapsedTimer = New System.Windows.Forms.ToolStripTextBox()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuAccount = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMain = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewUsers = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDBBack = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRestoreDB = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBilling = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCreateBill = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewBills = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewIndividual = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewTree = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAddEditItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewCatSubCat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ElapsedTimer = New System.Windows.Forms.Timer(Me.components)
        Me.statBarMain = New System.Windows.Forms.StatusStrip()
        Me.statlblMain = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.AnimateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnDeliveryStatus = New System.Windows.Forms.Button()
        Me.btnRegisteredCustomer = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnUpdateStock = New System.Windows.Forms.Button()
        Me.btnCreateBill = New System.Windows.Forms.Button()
        Me.btnManageItemInventory = New System.Windows.Forms.Button()
        Me.btnAccountSetting = New System.Windows.Forms.Button()
        Me.btnNewsletter = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ChatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.statBarMain.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.contextExit, Me.ToolStripSeparator2, Me.txtElapsedTimer})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(161, 57)
        '
        'contextExit
        '
        Me.contextExit.Name = "contextExit"
        Me.contextExit.Size = New System.Drawing.Size(160, 22)
        Me.contextExit.Text = "Exit"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(157, 6)
        '
        'txtElapsedTimer
        '
        Me.txtElapsedTimer.Enabled = False
        Me.txtElapsedTimer.Name = "txtElapsedTimer"
        Me.txtElapsedTimer.Size = New System.Drawing.Size(100, 23)
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAccount, Me.mnuMain, Me.mnuBilling, Me.mnuItemInventory, Me.mnuHelp, Me.ChatToolStripMenuItem})
        Me.MenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1352, 24)
        Me.MenuStrip.TabIndex = 8
        '
        'mnuAccount
        '
        Me.mnuAccount.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLogOut})
        Me.mnuAccount.Name = "mnuAccount"
        Me.mnuAccount.Size = New System.Drawing.Size(64, 20)
        Me.mnuAccount.Text = "Account"
        '
        'mnuLogOut
        '
        Me.mnuLogOut.Name = "mnuLogOut"
        Me.mnuLogOut.Size = New System.Drawing.Size(115, 22)
        Me.mnuLogOut.Text = "Log out"
        '
        'mnuMain
        '
        Me.mnuMain.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuViewUsers, Me.ToolStripSeparator1, Me.mnuDBBack, Me.mnuRestoreDB, Me.mnuExit})
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(46, 20)
        Me.mnuMain.Text = "Main"
        '
        'mnuViewUsers
        '
        Me.mnuViewUsers.Name = "mnuViewUsers"
        Me.mnuViewUsers.Size = New System.Drawing.Size(191, 22)
        Me.mnuViewUsers.Text = "Manage users"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(188, 6)
        '
        'mnuDBBack
        '
        Me.mnuDBBack.Name = "mnuDBBack"
        Me.mnuDBBack.Size = New System.Drawing.Size(191, 22)
        Me.mnuDBBack.Text = "Take database backup"
        '
        'mnuRestoreDB
        '
        Me.mnuRestoreDB.Name = "mnuRestoreDB"
        Me.mnuRestoreDB.Size = New System.Drawing.Size(191, 22)
        Me.mnuRestoreDB.Text = "Restore database"
        '
        'mnuExit
        '
        Me.mnuExit.Enabled = False
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(191, 22)
        Me.mnuExit.Text = "Exit"
        Me.mnuExit.Visible = False
        '
        'mnuBilling
        '
        Me.mnuBilling.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCreateBill, Me.mnuViewBills})
        Me.mnuBilling.Name = "mnuBilling"
        Me.mnuBilling.Size = New System.Drawing.Size(52, 20)
        Me.mnuBilling.Text = "Billing"
        '
        'mnuCreateBill
        '
        Me.mnuCreateBill.Name = "mnuCreateBill"
        Me.mnuCreateBill.Size = New System.Drawing.Size(152, 22)
        Me.mnuCreateBill.Text = "Create new bill"
        '
        'mnuViewBills
        '
        Me.mnuViewBills.Name = "mnuViewBills"
        Me.mnuViewBills.Size = New System.Drawing.Size(152, 22)
        Me.mnuViewBills.Text = "View Bills"
        '
        'mnuItemInventory
        '
        Me.mnuItemInventory.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuViewIndividual, Me.mnuViewTree, Me.mnuAddEditItem, Me.mnuViewCatSubCat})
        Me.mnuItemInventory.Name = "mnuItemInventory"
        Me.mnuItemInventory.Size = New System.Drawing.Size(96, 20)
        Me.mnuItemInventory.Text = "Item Inventory"
        '
        'mnuViewIndividual
        '
        Me.mnuViewIndividual.Name = "mnuViewIndividual"
        Me.mnuViewIndividual.Size = New System.Drawing.Size(260, 22)
        Me.mnuViewIndividual.Text = "View individual items"
        '
        'mnuViewTree
        '
        Me.mnuViewTree.Name = "mnuViewTree"
        Me.mnuViewTree.Size = New System.Drawing.Size(260, 22)
        Me.mnuViewTree.Text = "View item tree"
        '
        'mnuAddEditItem
        '
        Me.mnuAddEditItem.Name = "mnuAddEditItem"
        Me.mnuAddEditItem.Size = New System.Drawing.Size(260, 22)
        Me.mnuAddEditItem.Text = "Add new item"
        '
        'mnuViewCatSubCat
        '
        Me.mnuViewCatSubCat.Name = "mnuViewCatSubCat"
        Me.mnuViewCatSubCat.Size = New System.Drawing.Size(260, 22)
        Me.mnuViewCatSubCat.Text = "View categories and sub-categories"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(107, 22)
        Me.mnuAbout.Text = "About"
        '
        'ElapsedTimer
        '
        Me.ElapsedTimer.Interval = 1000
        '
        'statBarMain
        '
        Me.statBarMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statlblMain, Me.txtDate, Me.txtTime})
        Me.statBarMain.Location = New System.Drawing.Point(0, 676)
        Me.statBarMain.Name = "statBarMain"
        Me.statBarMain.Size = New System.Drawing.Size(1352, 22)
        Me.statBarMain.TabIndex = 16
        Me.statBarMain.Text = "StatusStrip1"
        '
        'statlblMain
        '
        Me.statlblMain.Margin = New System.Windows.Forms.Padding(300, 3, 0, 2)
        Me.statlblMain.Name = "statlblMain"
        Me.statlblMain.Size = New System.Drawing.Size(137, 17)
        Me.statlblMain.Text = "ShopSoft - By SAS group"
        '
        'txtDate
        '
        Me.txtDate.Margin = New System.Windows.Forms.Padding(500, 3, 0, 2)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(31, 17)
        Me.txtDate.Text = "Date"
        '
        'txtTime
        '
        Me.txtTime.Margin = New System.Windows.Forms.Padding(3, 3, 0, 2)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(34, 17)
        Me.txtTime.Text = "Time"
        '
        'ToolTip
        '
        Me.ToolTip.IsBalloon = True
        '
        'AnimateTimer
        '
        Me.AnimateTimer.Interval = 30
        '
        'btnDeliveryStatus
        '
        Me.btnDeliveryStatus.BackgroundImage = Global.ShopSoft.My.Resources.Resources.btnBackAdmin
        Me.btnDeliveryStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDeliveryStatus.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeliveryStatus.Location = New System.Drawing.Point(129, 450)
        Me.btnDeliveryStatus.Name = "btnDeliveryStatus"
        Me.btnDeliveryStatus.Size = New System.Drawing.Size(181, 42)
        Me.btnDeliveryStatus.TabIndex = 30
        Me.btnDeliveryStatus.Text = "Update delivery status"
        Me.btnDeliveryStatus.UseVisualStyleBackColor = False
        '
        'btnRegisteredCustomer
        '
        Me.btnRegisteredCustomer.BackgroundImage = Global.ShopSoft.My.Resources.Resources.btnBackAdmin
        Me.btnRegisteredCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRegisteredCustomer.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegisteredCustomer.Location = New System.Drawing.Point(129, 393)
        Me.btnRegisteredCustomer.Name = "btnRegisteredCustomer"
        Me.btnRegisteredCustomer.Size = New System.Drawing.Size(181, 42)
        Me.btnRegisteredCustomer.TabIndex = 28
        Me.btnRegisteredCustomer.Text = "Register a customer"
        Me.btnRegisteredCustomer.UseVisualStyleBackColor = False
        '
        'btnReports
        '
        Me.btnReports.BackgroundImage = Global.ShopSoft.My.Resources.Resources.btnBackAdmin
        Me.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnReports.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.Location = New System.Drawing.Point(129, 336)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(181, 42)
        Me.btnReports.TabIndex = 26
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'btnUpdateStock
        '
        Me.btnUpdateStock.BackgroundImage = Global.ShopSoft.My.Resources.Resources.btnBackAdmin
        Me.btnUpdateStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnUpdateStock.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateStock.Location = New System.Drawing.Point(129, 281)
        Me.btnUpdateStock.Name = "btnUpdateStock"
        Me.btnUpdateStock.Size = New System.Drawing.Size(181, 42)
        Me.btnUpdateStock.TabIndex = 24
        Me.btnUpdateStock.Text = "Update stock"
        Me.btnUpdateStock.UseVisualStyleBackColor = False
        '
        'btnCreateBill
        '
        Me.btnCreateBill.BackgroundImage = Global.ShopSoft.My.Resources.Resources.btnBackAdmin
        Me.btnCreateBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCreateBill.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateBill.Location = New System.Drawing.Point(129, 222)
        Me.btnCreateBill.Name = "btnCreateBill"
        Me.btnCreateBill.Size = New System.Drawing.Size(181, 42)
        Me.btnCreateBill.TabIndex = 22
        Me.btnCreateBill.Text = "Create bill"
        Me.btnCreateBill.UseVisualStyleBackColor = False
        '
        'btnManageItemInventory
        '
        Me.btnManageItemInventory.BackgroundImage = Global.ShopSoft.My.Resources.Resources.btnBackAdmin
        Me.btnManageItemInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnManageItemInventory.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageItemInventory.Location = New System.Drawing.Point(129, 163)
        Me.btnManageItemInventory.Name = "btnManageItemInventory"
        Me.btnManageItemInventory.Size = New System.Drawing.Size(181, 42)
        Me.btnManageItemInventory.TabIndex = 20
        Me.btnManageItemInventory.Text = "Manage item inventory"
        Me.btnManageItemInventory.UseVisualStyleBackColor = False
        '
        'btnAccountSetting
        '
        Me.btnAccountSetting.BackgroundImage = Global.ShopSoft.My.Resources.Resources.btnBackAdmin
        Me.btnAccountSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAccountSetting.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccountSetting.Location = New System.Drawing.Point(129, 103)
        Me.btnAccountSetting.Name = "btnAccountSetting"
        Me.btnAccountSetting.Size = New System.Drawing.Size(181, 42)
        Me.btnAccountSetting.TabIndex = 18
        Me.btnAccountSetting.Text = "Account Settings"
        Me.btnAccountSetting.UseVisualStyleBackColor = False
        '
        'btnNewsletter
        '
        Me.btnNewsletter.BackgroundImage = Global.ShopSoft.My.Resources.Resources.btnBackAdmin
        Me.btnNewsletter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNewsletter.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewsletter.Location = New System.Drawing.Point(129, 507)
        Me.btnNewsletter.Name = "btnNewsletter"
        Me.btnNewsletter.Size = New System.Drawing.Size(181, 42)
        Me.btnNewsletter.TabIndex = 33
        Me.btnNewsletter.Text = "Send a newsletter"
        Me.btnNewsletter.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.ShopSoft.My.Resources.Resources._247x129xsecure_footer_jpg_pagespeed_ic_jxTdQtcvNU
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(1069, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(270, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.ShopSoft.My.Resources.Resources.COD
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(1059, 251)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(270, 104)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'ChatToolStripMenuItem
        '
        Me.ChatToolStripMenuItem.Name = "ChatToolStripMenuItem"
        Me.ChatToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ChatToolStripMenuItem.Text = "Chat"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.ShopSoft.My.Resources.Resources.splash2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1352, 698)
        Me.Controls.Add(Me.btnDeliveryStatus)
        Me.Controls.Add(Me.btnRegisteredCustomer)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnUpdateStock)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCreateBill)
        Me.Controls.Add(Me.btnManageItemInventory)
        Me.Controls.Add(Me.btnAccountSetting)
        Me.Controls.Add(Me.btnNewsletter)
        Me.Controls.Add(Me.statBarMain)
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Welcome to ShopSoft - By SAS group"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.ContextMenuStrip.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.statBarMain.ResumeLayout(False)
        Me.statBarMain.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents contextExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuMain As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuViewUsers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBilling As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCreateBill As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuViewBills As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemInventory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuViewIndividual As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuViewTree As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAddEditItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuViewCatSubCat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuDBBack As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRestoreDB As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ElapsedTimer As System.Windows.Forms.Timer
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtElapsedTimer As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents statBarMain As System.Windows.Forms.StatusStrip
    Friend WithEvents statlblMain As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnAccountSetting As System.Windows.Forms.Button
    Friend WithEvents btnManageItemInventory As System.Windows.Forms.Button
    Friend WithEvents btnCreateBill As System.Windows.Forms.Button
    Friend WithEvents btnUpdateStock As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnRegisteredCustomer As System.Windows.Forms.Button
    Friend WithEvents btnDeliveryStatus As System.Windows.Forms.Button
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents btnNewsletter As System.Windows.Forms.Button
    Friend WithEvents mnuAccount As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLogOut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnimateTimer As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ChatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
