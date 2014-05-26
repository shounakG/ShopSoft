<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemInventory
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
        Me.txtCategories = New System.Windows.Forms.ComboBox()
        Me.txtSubCat = New System.Windows.Forms.ComboBox()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.tbProducts = New System.Windows.Forms.TabControl()
        Me.pgIDInfo = New System.Windows.Forms.TabPage()
        Me.txtFeatures = New System.Windows.Forms.TextBox()
        Me.lblFeatures = New System.Windows.Forms.Label()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.lblProdName = New System.Windows.Forms.Label()
        Me.txtProdBrand = New System.Windows.Forms.TextBox()
        Me.txtProdName = New System.Windows.Forms.TextBox()
        Me.pgPriceInfo = New System.Windows.Forms.TabPage()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblMRP = New System.Windows.Forms.Label()
        Me.txtProdMRP = New System.Windows.Forms.TextBox()
        Me.txtProdRate = New System.Windows.Forms.TextBox()
        Me.pgStockInfo = New System.Windows.Forms.TabPage()
        Me.txtCriticalStock = New System.Windows.Forms.TextBox()
        Me.lblCriticalStock = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.pgPhoto = New System.Windows.Forms.TabPage()
        Me.picProdPhoto = New System.Windows.Forms.PictureBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.openPic = New System.Windows.Forms.OpenFileDialog()
        Me.grpIndividual = New System.Windows.Forms.GroupBox()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnNext2 = New System.Windows.Forms.Button()
        Me.errSearch = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.btnCancelChange = New System.Windows.Forms.Button()
        Me.chkViews = New System.Windows.Forms.CheckBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.tbProducts.SuspendLayout()
        Me.pgIDInfo.SuspendLayout()
        Me.pgPriceInfo.SuspendLayout()
        Me.pgStockInfo.SuspendLayout()
        Me.pgPhoto.SuspendLayout()
        CType(Me.picProdPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpIndividual.SuspendLayout()
        Me.grpSearch.SuspendLayout()
        CType(Me.errSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCategories
        '
        Me.txtCategories.BackColor = System.Drawing.Color.LightSalmon
        Me.txtCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtCategories.FormattingEnabled = True
        Me.txtCategories.Location = New System.Drawing.Point(25, 19)
        Me.txtCategories.Name = "txtCategories"
        Me.txtCategories.Size = New System.Drawing.Size(152, 21)
        Me.txtCategories.TabIndex = 0
        '
        'txtSubCat
        '
        Me.txtSubCat.BackColor = System.Drawing.Color.LightSalmon
        Me.txtSubCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtSubCat.FormattingEnabled = True
        Me.txtSubCat.Location = New System.Drawing.Point(183, 19)
        Me.txtSubCat.Name = "txtSubCat"
        Me.txtSubCat.Size = New System.Drawing.Size(152, 21)
        Me.txtSubCat.Sorted = True
        Me.txtSubCat.TabIndex = 1
        Me.txtSubCat.Visible = False
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(356, 418)
        Me.btnAddItem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(100, 31)
        Me.btnAddItem.TabIndex = 5
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'tbProducts
        '
        Me.tbProducts.Controls.Add(Me.pgIDInfo)
        Me.tbProducts.Controls.Add(Me.pgPriceInfo)
        Me.tbProducts.Controls.Add(Me.pgStockInfo)
        Me.tbProducts.Controls.Add(Me.pgPhoto)
        Me.tbProducts.Location = New System.Drawing.Point(76, 158)
        Me.tbProducts.Name = "tbProducts"
        Me.tbProducts.SelectedIndex = 0
        Me.tbProducts.Size = New System.Drawing.Size(423, 244)
        Me.tbProducts.TabIndex = 6
        Me.tbProducts.Visible = False
        '
        'pgIDInfo
        '
        Me.pgIDInfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.pgIDInfo.Controls.Add(Me.txtFeatures)
        Me.pgIDInfo.Controls.Add(Me.lblFeatures)
        Me.pgIDInfo.Controls.Add(Me.lblBrand)
        Me.pgIDInfo.Controls.Add(Me.lblProdName)
        Me.pgIDInfo.Controls.Add(Me.txtProdBrand)
        Me.pgIDInfo.Controls.Add(Me.txtProdName)
        Me.pgIDInfo.Location = New System.Drawing.Point(4, 22)
        Me.pgIDInfo.Name = "pgIDInfo"
        Me.pgIDInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.pgIDInfo.Size = New System.Drawing.Size(415, 218)
        Me.pgIDInfo.TabIndex = 0
        Me.pgIDInfo.Text = "Identification Information"
        '
        'txtFeatures
        '
        Me.txtFeatures.Location = New System.Drawing.Point(158, 131)
        Me.txtFeatures.Multiline = True
        Me.txtFeatures.Name = "txtFeatures"
        Me.txtFeatures.ReadOnly = True
        Me.txtFeatures.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtFeatures.Size = New System.Drawing.Size(208, 65)
        Me.txtFeatures.TabIndex = 17
        '
        'lblFeatures
        '
        Me.lblFeatures.AutoSize = True
        Me.lblFeatures.Location = New System.Drawing.Point(37, 134)
        Me.lblFeatures.Name = "lblFeatures"
        Me.lblFeatures.Size = New System.Drawing.Size(88, 13)
        Me.lblFeatures.TabIndex = 16
        Me.lblFeatures.Text = "Product features:"
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Location = New System.Drawing.Point(37, 85)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(78, 13)
        Me.lblBrand.TabIndex = 15
        Me.lblBrand.Text = "Product Brand:"
        '
        'lblProdName
        '
        Me.lblProdName.AutoSize = True
        Me.lblProdName.Location = New System.Drawing.Point(37, 33)
        Me.lblProdName.Name = "lblProdName"
        Me.lblProdName.Size = New System.Drawing.Size(89, 13)
        Me.lblProdName.TabIndex = 14
        Me.lblProdName.Text = "Name of product:"
        '
        'txtProdBrand
        '
        Me.txtProdBrand.Location = New System.Drawing.Point(158, 82)
        Me.txtProdBrand.Name = "txtProdBrand"
        Me.txtProdBrand.ReadOnly = True
        Me.txtProdBrand.Size = New System.Drawing.Size(208, 20)
        Me.txtProdBrand.TabIndex = 13
        '
        'txtProdName
        '
        Me.txtProdName.Location = New System.Drawing.Point(158, 30)
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.ReadOnly = True
        Me.txtProdName.Size = New System.Drawing.Size(208, 20)
        Me.txtProdName.TabIndex = 10
        '
        'pgPriceInfo
        '
        Me.pgPriceInfo.Controls.Add(Me.lblRate)
        Me.pgPriceInfo.Controls.Add(Me.lblMRP)
        Me.pgPriceInfo.Controls.Add(Me.txtProdMRP)
        Me.pgPriceInfo.Controls.Add(Me.txtProdRate)
        Me.pgPriceInfo.Location = New System.Drawing.Point(4, 22)
        Me.pgPriceInfo.Name = "pgPriceInfo"
        Me.pgPriceInfo.Size = New System.Drawing.Size(415, 218)
        Me.pgPriceInfo.TabIndex = 2
        Me.pgPriceInfo.Text = "Price Information"
        Me.pgPriceInfo.UseVisualStyleBackColor = True
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(100, 115)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(33, 13)
        Me.lblRate.TabIndex = 14
        Me.lblRate.Text = "Rate:"
        '
        'lblMRP
        '
        Me.lblMRP.AutoSize = True
        Me.lblMRP.Location = New System.Drawing.Point(100, 65)
        Me.lblMRP.Name = "lblMRP"
        Me.lblMRP.Size = New System.Drawing.Size(34, 13)
        Me.lblMRP.TabIndex = 13
        Me.lblMRP.Text = "MRP:"
        '
        'txtProdMRP
        '
        Me.txtProdMRP.Location = New System.Drawing.Point(204, 62)
        Me.txtProdMRP.Name = "txtProdMRP"
        Me.txtProdMRP.ReadOnly = True
        Me.txtProdMRP.Size = New System.Drawing.Size(100, 20)
        Me.txtProdMRP.TabIndex = 11
        '
        'txtProdRate
        '
        Me.txtProdRate.Location = New System.Drawing.Point(204, 112)
        Me.txtProdRate.Name = "txtProdRate"
        Me.txtProdRate.ReadOnly = True
        Me.txtProdRate.Size = New System.Drawing.Size(100, 20)
        Me.txtProdRate.TabIndex = 12
        '
        'pgStockInfo
        '
        Me.pgStockInfo.Controls.Add(Me.txtCriticalStock)
        Me.pgStockInfo.Controls.Add(Me.lblCriticalStock)
        Me.pgStockInfo.Controls.Add(Me.txtStock)
        Me.pgStockInfo.Controls.Add(Me.lblStock)
        Me.pgStockInfo.Location = New System.Drawing.Point(4, 22)
        Me.pgStockInfo.Name = "pgStockInfo"
        Me.pgStockInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.pgStockInfo.Size = New System.Drawing.Size(415, 218)
        Me.pgStockInfo.TabIndex = 1
        Me.pgStockInfo.Text = "Stock Information"
        Me.pgStockInfo.UseVisualStyleBackColor = True
        '
        'txtCriticalStock
        '
        Me.txtCriticalStock.Location = New System.Drawing.Point(216, 114)
        Me.txtCriticalStock.Name = "txtCriticalStock"
        Me.txtCriticalStock.ReadOnly = True
        Me.txtCriticalStock.Size = New System.Drawing.Size(100, 20)
        Me.txtCriticalStock.TabIndex = 17
        '
        'lblCriticalStock
        '
        Me.lblCriticalStock.AutoSize = True
        Me.lblCriticalStock.Location = New System.Drawing.Point(88, 117)
        Me.lblCriticalStock.Name = "lblCriticalStock"
        Me.lblCriticalStock.Size = New System.Drawing.Size(70, 13)
        Me.lblCriticalStock.TabIndex = 16
        Me.lblCriticalStock.Text = "Critical stock:"
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(216, 57)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.ReadOnly = True
        Me.txtStock.Size = New System.Drawing.Size(100, 20)
        Me.txtStock.TabIndex = 15
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(88, 60)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(82, 13)
        Me.lblStock.TabIndex = 14
        Me.lblStock.Text = "Available stock:"
        '
        'pgPhoto
        '
        Me.pgPhoto.Controls.Add(Me.picProdPhoto)
        Me.pgPhoto.Location = New System.Drawing.Point(4, 22)
        Me.pgPhoto.Name = "pgPhoto"
        Me.pgPhoto.Size = New System.Drawing.Size(415, 218)
        Me.pgPhoto.TabIndex = 3
        Me.pgPhoto.Text = "Photo"
        Me.pgPhoto.UseVisualStyleBackColor = True
        '
        'picProdPhoto
        '
        Me.picProdPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picProdPhoto.Location = New System.Drawing.Point(106, 31)
        Me.picProdPhoto.Name = "picProdPhoto"
        Me.picProdPhoto.Size = New System.Drawing.Size(189, 135)
        Me.picProdPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProdPhoto.TabIndex = 0
        Me.picProdPhoto.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(250, 418)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(100, 31)
        Me.btnNext.TabIndex = 7
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        Me.btnNext.Visible = False
        '
        'grpIndividual
        '
        Me.grpIndividual.Controls.Add(Me.txtSubCat)
        Me.grpIndividual.Controls.Add(Me.txtCategories)
        Me.grpIndividual.Location = New System.Drawing.Point(76, 12)
        Me.grpIndividual.Name = "grpIndividual"
        Me.grpIndividual.Size = New System.Drawing.Size(366, 54)
        Me.grpIndividual.TabIndex = 9
        Me.grpIndividual.TabStop = False
        Me.grpIndividual.Text = "View individual products"
        '
        'grpSearch
        '
        Me.grpSearch.Controls.Add(Me.txtSearch)
        Me.grpSearch.Location = New System.Drawing.Point(76, 72)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(366, 65)
        Me.grpSearch.TabIndex = 10
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search for a product"
        Me.grpSearch.Visible = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(25, 30)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(222, 20)
        Me.txtSearch.TabIndex = 11
        '
        'btnNext2
        '
        Me.btnNext2.Enabled = False
        Me.btnNext2.Location = New System.Drawing.Point(250, 418)
        Me.btnNext2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNext2.Name = "btnNext2"
        Me.btnNext2.Size = New System.Drawing.Size(100, 31)
        Me.btnNext2.TabIndex = 11
        Me.btnNext2.Text = "Next"
        Me.btnNext2.UseVisualStyleBackColor = True
        Me.btnNext2.Visible = False
        '
        'errSearch
        '
        Me.errSearch.ContainerControl = Me
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(37, 418)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(100, 31)
        Me.btnEdit.TabIndex = 12
        Me.btnEdit.Text = "Edit Item"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnCommit
        '
        Me.btnCommit.Location = New System.Drawing.Point(143, 418)
        Me.btnCommit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(100, 31)
        Me.btnCommit.TabIndex = 13
        Me.btnCommit.Text = "Commit Changes"
        Me.btnCommit.UseVisualStyleBackColor = True
        Me.btnCommit.Visible = False
        '
        'btnCancelChange
        '
        Me.btnCancelChange.Location = New System.Drawing.Point(249, 418)
        Me.btnCancelChange.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancelChange.Name = "btnCancelChange"
        Me.btnCancelChange.Size = New System.Drawing.Size(100, 31)
        Me.btnCancelChange.TabIndex = 14
        Me.btnCancelChange.Text = "Cancel Changes"
        Me.btnCancelChange.UseVisualStyleBackColor = True
        Me.btnCancelChange.Visible = False
        '
        'chkViews
        '
        Me.chkViews.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkViews.Location = New System.Drawing.Point(489, 46)
        Me.chkViews.Name = "chkViews"
        Me.chkViews.Size = New System.Drawing.Size(54, 43)
        Me.chkViews.TabIndex = 15
        Me.chkViews.Text = "Tree View"
        Me.chkViews.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkViews.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(462, 418)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 31)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete Product"
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'frmItemInventory
        '
        Me.AcceptButton = Me.btnNext
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(576, 460)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.chkViews)
        Me.Controls.Add(Me.btnCancelChange)
        Me.Controls.Add(Me.btnCommit)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnNext2)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.grpIndividual)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.tbProducts)
        Me.Controls.Add(Me.btnAddItem)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmItemInventory"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Items Inventory"
        Me.tbProducts.ResumeLayout(False)
        Me.pgIDInfo.ResumeLayout(False)
        Me.pgIDInfo.PerformLayout()
        Me.pgPriceInfo.ResumeLayout(False)
        Me.pgPriceInfo.PerformLayout()
        Me.pgStockInfo.ResumeLayout(False)
        Me.pgStockInfo.PerformLayout()
        Me.pgPhoto.ResumeLayout(False)
        CType(Me.picProdPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpIndividual.ResumeLayout(False)
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        CType(Me.errSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtCategories As System.Windows.Forms.ComboBox
    Friend WithEvents txtSubCat As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents tbProducts As System.Windows.Forms.TabControl
    Friend WithEvents pgIDInfo As System.Windows.Forms.TabPage
    Friend WithEvents pgStockInfo As System.Windows.Forms.TabPage
    Friend WithEvents lblProdName As System.Windows.Forms.Label
    Friend WithEvents txtProdBrand As System.Windows.Forms.TextBox
    Friend WithEvents txtProdName As System.Windows.Forms.TextBox
    Friend WithEvents pgPriceInfo As System.Windows.Forms.TabPage
    Friend WithEvents pgPhoto As System.Windows.Forms.TabPage
    Friend WithEvents txtProdRate As System.Windows.Forms.TextBox
    Friend WithEvents txtProdMRP As System.Windows.Forms.TextBox
    Friend WithEvents txtFeatures As System.Windows.Forms.TextBox
    Friend WithEvents lblFeatures As System.Windows.Forms.Label
    Friend WithEvents lblBrand As System.Windows.Forms.Label
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents lblMRP As System.Windows.Forms.Label
    Friend WithEvents txtCriticalStock As System.Windows.Forms.TextBox
    Friend WithEvents lblCriticalStock As System.Windows.Forms.Label
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents lblStock As System.Windows.Forms.Label
    Friend WithEvents picProdPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents openPic As System.Windows.Forms.OpenFileDialog
    Friend WithEvents grpIndividual As System.Windows.Forms.GroupBox
    Friend WithEvents grpSearch As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnNext2 As System.Windows.Forms.Button
    Friend WithEvents errSearch As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnCancelChange As System.Windows.Forms.Button
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents chkViews As System.Windows.Forms.CheckBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
