<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddItem))
        Me.txtNewItemCat = New System.Windows.Forms.ComboBox()
        Me.lblNewItemCat = New System.Windows.Forms.Label()
        Me.txtNewItemSubCat = New System.Windows.Forms.ComboBox()
        Me.lblNewItemSubCat = New System.Windows.Forms.Label()
        Me.txtNewItemBrand = New System.Windows.Forms.ComboBox()
        Me.lblNewItemBrand = New System.Windows.Forms.Label()
        Me.lblNewItemName = New System.Windows.Forms.Label()
        Me.txtNewItemName = New System.Windows.Forms.TextBox()
        Me.lblItemInfo = New System.Windows.Forms.Label()
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.lblMRP = New System.Windows.Forms.Label()
        Me.txtMRP = New System.Windows.Forms.TextBox()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.txtOpeningStock = New System.Windows.Forms.TextBox()
        Me.lblCritical = New System.Windows.Forms.Label()
        Me.txtCriticalStock = New System.Windows.Forms.TextBox()
        Me.lblWarranty = New System.Windows.Forms.Label()
        Me.txtWarranty = New System.Windows.Forms.TextBox()
        Me.lblBarcode = New System.Windows.Forms.Label()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.btnAddPhoto = New System.Windows.Forms.Button()
        Me.openPicture = New System.Windows.Forms.OpenFileDialog()
        Me.errInput = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.errInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNewItemCat
        '
        Me.txtNewItemCat.FormattingEnabled = True
        Me.txtNewItemCat.Location = New System.Drawing.Point(240, 25)
        Me.txtNewItemCat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNewItemCat.Name = "txtNewItemCat"
        Me.txtNewItemCat.Size = New System.Drawing.Size(134, 24)
        Me.txtNewItemCat.TabIndex = 0
        '
        'lblNewItemCat
        '
        Me.lblNewItemCat.AutoSize = True
        Me.lblNewItemCat.Location = New System.Drawing.Point(55, 29)
        Me.lblNewItemCat.Name = "lblNewItemCat"
        Me.lblNewItemCat.Size = New System.Drawing.Size(84, 16)
        Me.lblNewItemCat.TabIndex = 20
        Me.lblNewItemCat.Text = "Item Category:"
        '
        'txtNewItemSubCat
        '
        Me.txtNewItemSubCat.FormattingEnabled = True
        Me.txtNewItemSubCat.Location = New System.Drawing.Point(240, 59)
        Me.txtNewItemSubCat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNewItemSubCat.Name = "txtNewItemSubCat"
        Me.txtNewItemSubCat.Size = New System.Drawing.Size(134, 24)
        Me.txtNewItemSubCat.TabIndex = 1
        Me.txtNewItemSubCat.Visible = False
        '
        'lblNewItemSubCat
        '
        Me.lblNewItemSubCat.AutoSize = True
        Me.lblNewItemSubCat.Location = New System.Drawing.Point(55, 62)
        Me.lblNewItemSubCat.Name = "lblNewItemSubCat"
        Me.lblNewItemSubCat.Size = New System.Drawing.Size(108, 16)
        Me.lblNewItemSubCat.TabIndex = 40
        Me.lblNewItemSubCat.Text = "Item Sub-Category:"
        Me.lblNewItemSubCat.Visible = False
        '
        'txtNewItemBrand
        '
        Me.txtNewItemBrand.FormattingEnabled = True
        Me.txtNewItemBrand.Location = New System.Drawing.Point(240, 92)
        Me.txtNewItemBrand.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNewItemBrand.Name = "txtNewItemBrand"
        Me.txtNewItemBrand.Size = New System.Drawing.Size(134, 24)
        Me.txtNewItemBrand.TabIndex = 2
        Me.txtNewItemBrand.Visible = False
        '
        'lblNewItemBrand
        '
        Me.lblNewItemBrand.AutoSize = True
        Me.lblNewItemBrand.Location = New System.Drawing.Point(55, 96)
        Me.lblNewItemBrand.Name = "lblNewItemBrand"
        Me.lblNewItemBrand.Size = New System.Drawing.Size(99, 16)
        Me.lblNewItemBrand.TabIndex = 56
        Me.lblNewItemBrand.Text = "Item Brand Name:"
        Me.lblNewItemBrand.Visible = False
        '
        'lblNewItemName
        '
        Me.lblNewItemName.AutoSize = True
        Me.lblNewItemName.Location = New System.Drawing.Point(55, 130)
        Me.lblNewItemName.Name = "lblNewItemName"
        Me.lblNewItemName.Size = New System.Drawing.Size(66, 16)
        Me.lblNewItemName.TabIndex = 78
        Me.lblNewItemName.Text = "Item Name:"
        Me.lblNewItemName.Visible = False
        '
        'txtNewItemName
        '
        Me.txtNewItemName.Location = New System.Drawing.Point(240, 130)
        Me.txtNewItemName.Name = "txtNewItemName"
        Me.txtNewItemName.Size = New System.Drawing.Size(134, 20)
        Me.txtNewItemName.TabIndex = 3
        Me.txtNewItemName.Visible = False
        '
        'lblItemInfo
        '
        Me.lblItemInfo.AutoSize = True
        Me.lblItemInfo.Location = New System.Drawing.Point(55, 166)
        Me.lblItemInfo.Name = "lblItemInfo"
        Me.lblItemInfo.Size = New System.Drawing.Size(71, 16)
        Me.lblItemInfo.TabIndex = 16
        Me.lblItemInfo.Text = "Information:"
        Me.lblItemInfo.Visible = False
        '
        'txtInfo
        '
        Me.txtInfo.Location = New System.Drawing.Point(240, 166)
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.Size = New System.Drawing.Size(134, 20)
        Me.txtInfo.TabIndex = 4
        Me.txtInfo.Visible = False
        '
        'lblMRP
        '
        Me.lblMRP.AutoSize = True
        Me.lblMRP.Location = New System.Drawing.Point(55, 207)
        Me.lblMRP.Name = "lblMRP"
        Me.lblMRP.Size = New System.Drawing.Size(34, 16)
        Me.lblMRP.TabIndex = 13
        Me.lblMRP.Text = "MRP:"
        Me.lblMRP.Visible = False
        '
        'txtMRP
        '
        Me.txtMRP.Location = New System.Drawing.Point(240, 203)
        Me.txtMRP.Name = "txtMRP"
        Me.txtMRP.Size = New System.Drawing.Size(134, 20)
        Me.txtMRP.TabIndex = 5
        Me.txtMRP.Visible = False
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(55, 242)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(35, 16)
        Me.lblRate.TabIndex = 15
        Me.lblRate.Text = "Rate:"
        Me.lblRate.Visible = False
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(240, 238)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(134, 20)
        Me.txtRate.TabIndex = 6
        Me.txtRate.Visible = False
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(55, 277)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(86, 16)
        Me.lblStock.TabIndex = 17
        Me.lblStock.Text = "Opening stock:"
        Me.lblStock.Visible = False
        '
        'txtOpeningStock
        '
        Me.txtOpeningStock.Location = New System.Drawing.Point(240, 273)
        Me.txtOpeningStock.Name = "txtOpeningStock"
        Me.txtOpeningStock.Size = New System.Drawing.Size(134, 20)
        Me.txtOpeningStock.TabIndex = 7
        Me.txtOpeningStock.Visible = False
        '
        'lblCritical
        '
        Me.lblCritical.AutoSize = True
        Me.lblCritical.Location = New System.Drawing.Point(55, 316)
        Me.lblCritical.Name = "lblCritical"
        Me.lblCritical.Size = New System.Drawing.Size(79, 16)
        Me.lblCritical.TabIndex = 19
        Me.lblCritical.Text = "Critical Stock:"
        Me.lblCritical.Visible = False
        '
        'txtCriticalStock
        '
        Me.txtCriticalStock.Location = New System.Drawing.Point(240, 312)
        Me.txtCriticalStock.Name = "txtCriticalStock"
        Me.txtCriticalStock.Size = New System.Drawing.Size(134, 20)
        Me.txtCriticalStock.TabIndex = 8
        Me.txtCriticalStock.Visible = False
        '
        'lblWarranty
        '
        Me.lblWarranty.AutoSize = True
        Me.lblWarranty.Location = New System.Drawing.Point(55, 354)
        Me.lblWarranty.Name = "lblWarranty"
        Me.lblWarranty.Size = New System.Drawing.Size(97, 16)
        Me.lblWarranty.TabIndex = 21
        Me.lblWarranty.Text = "Warranty in years:"
        Me.lblWarranty.Visible = False
        '
        'txtWarranty
        '
        Me.txtWarranty.Location = New System.Drawing.Point(240, 350)
        Me.txtWarranty.Name = "txtWarranty"
        Me.txtWarranty.Size = New System.Drawing.Size(134, 20)
        Me.txtWarranty.TabIndex = 9
        Me.txtWarranty.Visible = False
        '
        'lblBarcode
        '
        Me.lblBarcode.AutoSize = True
        Me.lblBarcode.Location = New System.Drawing.Point(55, 394)
        Me.lblBarcode.Name = "lblBarcode"
        Me.lblBarcode.Size = New System.Drawing.Size(53, 16)
        Me.lblBarcode.TabIndex = 23
        Me.lblBarcode.Text = "Barcode:"
        Me.lblBarcode.Visible = False
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(240, 391)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(134, 20)
        Me.txtBarcode.TabIndex = 10
        Me.txtBarcode.Visible = False
        '
        'btnAddPhoto
        '
        Me.btnAddPhoto.BackgroundImage = Global.ShopSoft.My.Resources.Resources.back1
        Me.btnAddPhoto.Location = New System.Drawing.Point(52, 440)
        Me.btnAddPhoto.Name = "btnAddPhoto"
        Me.btnAddPhoto.Size = New System.Drawing.Size(74, 27)
        Me.btnAddPhoto.TabIndex = 11
        Me.btnAddPhoto.Text = "Add photo"
        Me.btnAddPhoto.UseVisualStyleBackColor = True
        Me.btnAddPhoto.Visible = False
        '
        'openPicture
        '
        Me.openPicture.Filter = "Image files(*.jpg)|*.jpg"
        '
        'errInput
        '
        Me.errInput.ContainerControl = Me
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(180, 440)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(76, 27)
        Me.btnSave.TabIndex = 81
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = CType(resources.GetObject("btnCancel.BackgroundImage"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(298, 440)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(76, 27)
        Me.btnCancel.TabIndex = 82
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmAddItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(438, 498)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAddPhoto)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.lblBarcode)
        Me.Controls.Add(Me.txtWarranty)
        Me.Controls.Add(Me.lblWarranty)
        Me.Controls.Add(Me.txtCriticalStock)
        Me.Controls.Add(Me.lblCritical)
        Me.Controls.Add(Me.txtOpeningStock)
        Me.Controls.Add(Me.lblStock)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.txtMRP)
        Me.Controls.Add(Me.lblMRP)
        Me.Controls.Add(Me.txtInfo)
        Me.Controls.Add(Me.lblItemInfo)
        Me.Controls.Add(Me.txtNewItemName)
        Me.Controls.Add(Me.lblNewItemName)
        Me.Controls.Add(Me.txtNewItemBrand)
        Me.Controls.Add(Me.lblNewItemBrand)
        Me.Controls.Add(Me.txtNewItemSubCat)
        Me.Controls.Add(Me.lblNewItemSubCat)
        Me.Controls.Add(Me.txtNewItemCat)
        Me.Controls.Add(Me.lblNewItemCat)
        Me.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddItem"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add new item"
        CType(Me.errInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNewItemCat As System.Windows.Forms.ComboBox
    Friend WithEvents lblNewItemCat As System.Windows.Forms.Label
    Friend WithEvents txtNewItemSubCat As System.Windows.Forms.ComboBox
    Friend WithEvents lblNewItemSubCat As System.Windows.Forms.Label
    Friend WithEvents txtNewItemBrand As System.Windows.Forms.ComboBox
    Friend WithEvents lblNewItemBrand As System.Windows.Forms.Label
    Friend WithEvents lblNewItemName As System.Windows.Forms.Label
    Friend WithEvents txtNewItemName As System.Windows.Forms.TextBox
    Friend WithEvents lblItemInfo As System.Windows.Forms.Label
    Friend WithEvents txtInfo As System.Windows.Forms.TextBox
    Friend WithEvents lblMRP As System.Windows.Forms.Label
    Friend WithEvents txtMRP As System.Windows.Forms.TextBox
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents lblStock As System.Windows.Forms.Label
    Friend WithEvents txtOpeningStock As System.Windows.Forms.TextBox
    Friend WithEvents lblCritical As System.Windows.Forms.Label
    Friend WithEvents txtCriticalStock As System.Windows.Forms.TextBox
    Friend WithEvents lblWarranty As System.Windows.Forms.Label
    Friend WithEvents txtWarranty As System.Windows.Forms.TextBox
    Friend WithEvents lblBarcode As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents btnAddPhoto As System.Windows.Forms.Button
    Friend WithEvents openPicture As System.Windows.Forms.OpenFileDialog
    Friend WithEvents errInput As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
