<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCart
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
        Me.lblcartSrNo = New System.Windows.Forms.Label()
        Me.lblcartSubtotal = New System.Windows.Forms.Label()
        Me.lblcartQuantity = New System.Windows.Forms.Label()
        Me.lblcartPrice = New System.Windows.Forms.Label()
        Me.lblcartiteminfo = New System.Windows.Forms.Label()
        Me.lblcartSubCat = New System.Windows.Forms.Label()
        Me.lblcartItem = New System.Windows.Forms.Label()
        Me.lblSr1 = New System.Windows.Forms.Label()
        Me.lblSr2 = New System.Windows.Forms.Label()
        Me.lblSr3 = New System.Windows.Forms.Label()
        Me.lblSr4 = New System.Windows.Forms.Label()
        Me.lblSr5 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotalNo = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblItem1 = New System.Windows.Forms.Label()
        Me.lblItem2 = New System.Windows.Forms.Label()
        Me.lblItem3 = New System.Windows.Forms.Label()
        Me.lblItem4 = New System.Windows.Forms.Label()
        Me.lblItem5 = New System.Windows.Forms.Label()
        Me.lblCat1 = New System.Windows.Forms.Label()
        Me.lblCat2 = New System.Windows.Forms.Label()
        Me.lblCat3 = New System.Windows.Forms.Label()
        Me.lblCat4 = New System.Windows.Forms.Label()
        Me.lblCat5 = New System.Windows.Forms.Label()
        Me.lblInfo1 = New System.Windows.Forms.Label()
        Me.lblInfo2 = New System.Windows.Forms.Label()
        Me.lblInfo3 = New System.Windows.Forms.Label()
        Me.lblInfo4 = New System.Windows.Forms.Label()
        Me.lblInfo5 = New System.Windows.Forms.Label()
        Me.lblPrice1 = New System.Windows.Forms.Label()
        Me.lblPrice2 = New System.Windows.Forms.Label()
        Me.lblPrice3 = New System.Windows.Forms.Label()
        Me.lblPrice4 = New System.Windows.Forms.Label()
        Me.lblPrice5 = New System.Windows.Forms.Label()
        Me.lblSubTot1 = New System.Windows.Forms.Label()
        Me.lblSubTot2 = New System.Windows.Forms.Label()
        Me.lblSubTot3 = New System.Windows.Forms.Label()
        Me.lblSubTot4 = New System.Windows.Forms.Label()
        Me.lblSubTot5 = New System.Windows.Forms.Label()
        Me.txtQuantity1 = New System.Windows.Forms.TextBox()
        Me.txtQuantity2 = New System.Windows.Forms.TextBox()
        Me.txtQuantity3 = New System.Windows.Forms.TextBox()
        Me.txtQuantity4 = New System.Windows.Forms.TextBox()
        Me.txtQuantity5 = New System.Windows.Forms.TextBox()
        Me.lbltotalnorupee = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblcartSrNo
        '
        Me.lblcartSrNo.AutoSize = True
        Me.lblcartSrNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcartSrNo.Location = New System.Drawing.Point(41, 77)
        Me.lblcartSrNo.Name = "lblcartSrNo"
        Me.lblcartSrNo.Size = New System.Drawing.Size(35, 13)
        Me.lblcartSrNo.TabIndex = 14
        Me.lblcartSrNo.Text = "SrNo"
        '
        'lblcartSubtotal
        '
        Me.lblcartSubtotal.AutoSize = True
        Me.lblcartSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcartSubtotal.Location = New System.Drawing.Point(775, 77)
        Me.lblcartSubtotal.Name = "lblcartSubtotal"
        Me.lblcartSubtotal.Size = New System.Drawing.Size(62, 13)
        Me.lblcartSubtotal.TabIndex = 13
        Me.lblcartSubtotal.Text = "Sub-Total"
        '
        'lblcartQuantity
        '
        Me.lblcartQuantity.AutoSize = True
        Me.lblcartQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcartQuantity.Location = New System.Drawing.Point(665, 77)
        Me.lblcartQuantity.Name = "lblcartQuantity"
        Me.lblcartQuantity.Size = New System.Drawing.Size(54, 13)
        Me.lblcartQuantity.TabIndex = 12
        Me.lblcartQuantity.Text = "Quantity"
        '
        'lblcartPrice
        '
        Me.lblcartPrice.AutoSize = True
        Me.lblcartPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcartPrice.Location = New System.Drawing.Point(561, 77)
        Me.lblcartPrice.Name = "lblcartPrice"
        Me.lblcartPrice.Size = New System.Drawing.Size(36, 13)
        Me.lblcartPrice.TabIndex = 11
        Me.lblcartPrice.Text = "Price"
        '
        'lblcartiteminfo
        '
        Me.lblcartiteminfo.AutoSize = True
        Me.lblcartiteminfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcartiteminfo.Location = New System.Drawing.Point(401, 77)
        Me.lblcartiteminfo.Name = "lblcartiteminfo"
        Me.lblcartiteminfo.Size = New System.Drawing.Size(70, 13)
        Me.lblcartiteminfo.TabIndex = 10
        Me.lblcartiteminfo.Text = "Information"
        '
        'lblcartSubCat
        '
        Me.lblcartSubCat.AutoSize = True
        Me.lblcartSubCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcartSubCat.Location = New System.Drawing.Point(248, 77)
        Me.lblcartSubCat.Name = "lblcartSubCat"
        Me.lblcartSubCat.Size = New System.Drawing.Size(57, 13)
        Me.lblcartSubCat.TabIndex = 9
        Me.lblcartSubCat.Text = "Category"
        '
        'lblcartItem
        '
        Me.lblcartItem.AutoSize = True
        Me.lblcartItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcartItem.Location = New System.Drawing.Point(138, 77)
        Me.lblcartItem.Name = "lblcartItem"
        Me.lblcartItem.Size = New System.Drawing.Size(31, 13)
        Me.lblcartItem.TabIndex = 8
        Me.lblcartItem.Text = "Item"
        '
        'lblSr1
        '
        Me.lblSr1.AutoSize = True
        Me.lblSr1.Location = New System.Drawing.Point(41, 120)
        Me.lblSr1.Name = "lblSr1"
        Me.lblSr1.Size = New System.Drawing.Size(13, 13)
        Me.lblSr1.TabIndex = 15
        Me.lblSr1.Text = "1"
        Me.lblSr1.Visible = False
        '
        'lblSr2
        '
        Me.lblSr2.AutoSize = True
        Me.lblSr2.Location = New System.Drawing.Point(41, 185)
        Me.lblSr2.Name = "lblSr2"
        Me.lblSr2.Size = New System.Drawing.Size(13, 13)
        Me.lblSr2.TabIndex = 16
        Me.lblSr2.Text = "2"
        Me.lblSr2.Visible = False
        '
        'lblSr3
        '
        Me.lblSr3.AutoSize = True
        Me.lblSr3.Location = New System.Drawing.Point(41, 255)
        Me.lblSr3.Name = "lblSr3"
        Me.lblSr3.Size = New System.Drawing.Size(13, 13)
        Me.lblSr3.TabIndex = 17
        Me.lblSr3.Text = "3"
        Me.lblSr3.Visible = False
        '
        'lblSr4
        '
        Me.lblSr4.AutoSize = True
        Me.lblSr4.Location = New System.Drawing.Point(41, 320)
        Me.lblSr4.Name = "lblSr4"
        Me.lblSr4.Size = New System.Drawing.Size(13, 13)
        Me.lblSr4.TabIndex = 18
        Me.lblSr4.Text = "4"
        Me.lblSr4.Visible = False
        '
        'lblSr5
        '
        Me.lblSr5.AutoSize = True
        Me.lblSr5.Location = New System.Drawing.Point(41, 388)
        Me.lblSr5.Name = "lblSr5"
        Me.lblSr5.Size = New System.Drawing.Size(13, 13)
        Me.lblSr5.TabIndex = 19
        Me.lblSr5.Text = "5"
        Me.lblSr5.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(290, 451)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(36, 13)
        Me.lblTotal.TabIndex = 21
        Me.lblTotal.Text = "Total"
        '
        'lblTotalNo
        '
        Me.lblTotalNo.AutoSize = True
        Me.lblTotalNo.Location = New System.Drawing.Point(401, 451)
        Me.lblTotalNo.Name = "lblTotalNo"
        Me.lblTotalNo.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalNo.TabIndex = 22
        Me.lblTotalNo.Text = "0"
        Me.lblTotalNo.Visible = False
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(179, 498)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(174, 23)
        Me.btnBack.TabIndex = 23
        Me.btnBack.Text = "Save and Continue Shopping"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnProceed
        '
        Me.btnProceed.Enabled = False
        Me.btnProceed.Location = New System.Drawing.Point(404, 498)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(75, 23)
        Me.btnProceed.TabIndex = 24
        Me.btnProceed.Text = "Proceed"
        Me.btnProceed.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(564, 498)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 25
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblItem1
        '
        Me.lblItem1.Location = New System.Drawing.Point(112, 120)
        Me.lblItem1.Name = "lblItem1"
        Me.lblItem1.Size = New System.Drawing.Size(96, 54)
        Me.lblItem1.TabIndex = 26
        Me.lblItem1.Text = "Item"
        Me.lblItem1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblItem1.Visible = False
        '
        'lblItem2
        '
        Me.lblItem2.Location = New System.Drawing.Point(112, 185)
        Me.lblItem2.Name = "lblItem2"
        Me.lblItem2.Size = New System.Drawing.Size(96, 51)
        Me.lblItem2.TabIndex = 27
        Me.lblItem2.Text = "Item"
        Me.lblItem2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblItem2.Visible = False
        '
        'lblItem3
        '
        Me.lblItem3.Location = New System.Drawing.Point(112, 255)
        Me.lblItem3.Name = "lblItem3"
        Me.lblItem3.Size = New System.Drawing.Size(96, 51)
        Me.lblItem3.TabIndex = 28
        Me.lblItem3.Text = "Item"
        Me.lblItem3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblItem3.Visible = False
        '
        'lblItem4
        '
        Me.lblItem4.Location = New System.Drawing.Point(112, 320)
        Me.lblItem4.Name = "lblItem4"
        Me.lblItem4.Size = New System.Drawing.Size(96, 54)
        Me.lblItem4.TabIndex = 29
        Me.lblItem4.Text = "Item"
        Me.lblItem4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblItem4.Visible = False
        '
        'lblItem5
        '
        Me.lblItem5.Location = New System.Drawing.Point(112, 388)
        Me.lblItem5.Name = "lblItem5"
        Me.lblItem5.Size = New System.Drawing.Size(96, 53)
        Me.lblItem5.TabIndex = 30
        Me.lblItem5.Text = "Item"
        Me.lblItem5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblItem5.Visible = False
        '
        'lblCat1
        '
        Me.lblCat1.AutoSize = True
        Me.lblCat1.Location = New System.Drawing.Point(248, 120)
        Me.lblCat1.Name = "lblCat1"
        Me.lblCat1.Size = New System.Drawing.Size(29, 13)
        Me.lblCat1.TabIndex = 31
        Me.lblCat1.Text = "Cat1"
        Me.lblCat1.Visible = False
        '
        'lblCat2
        '
        Me.lblCat2.AutoSize = True
        Me.lblCat2.Location = New System.Drawing.Point(248, 185)
        Me.lblCat2.Name = "lblCat2"
        Me.lblCat2.Size = New System.Drawing.Size(29, 13)
        Me.lblCat2.TabIndex = 32
        Me.lblCat2.Text = "Cat2"
        Me.lblCat2.Visible = False
        '
        'lblCat3
        '
        Me.lblCat3.AutoSize = True
        Me.lblCat3.Location = New System.Drawing.Point(248, 255)
        Me.lblCat3.Name = "lblCat3"
        Me.lblCat3.Size = New System.Drawing.Size(29, 13)
        Me.lblCat3.TabIndex = 33
        Me.lblCat3.Text = "Cat3"
        Me.lblCat3.Visible = False
        '
        'lblCat4
        '
        Me.lblCat4.AutoSize = True
        Me.lblCat4.Location = New System.Drawing.Point(248, 320)
        Me.lblCat4.Name = "lblCat4"
        Me.lblCat4.Size = New System.Drawing.Size(29, 13)
        Me.lblCat4.TabIndex = 34
        Me.lblCat4.Text = "Cat4"
        Me.lblCat4.Visible = False
        '
        'lblCat5
        '
        Me.lblCat5.AutoSize = True
        Me.lblCat5.Location = New System.Drawing.Point(248, 388)
        Me.lblCat5.Name = "lblCat5"
        Me.lblCat5.Size = New System.Drawing.Size(29, 13)
        Me.lblCat5.TabIndex = 35
        Me.lblCat5.Text = "Cat5"
        Me.lblCat5.Visible = False
        '
        'lblInfo1
        '
        Me.lblInfo1.Location = New System.Drawing.Point(341, 120)
        Me.lblInfo1.Name = "lblInfo1"
        Me.lblInfo1.Size = New System.Drawing.Size(203, 56)
        Me.lblInfo1.TabIndex = 36
        Me.lblInfo1.Text = "Info1"
        Me.lblInfo1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblInfo1.Visible = False
        '
        'lblInfo2
        '
        Me.lblInfo2.Location = New System.Drawing.Point(341, 185)
        Me.lblInfo2.Name = "lblInfo2"
        Me.lblInfo2.Size = New System.Drawing.Size(203, 55)
        Me.lblInfo2.TabIndex = 37
        Me.lblInfo2.Text = "Info2"
        Me.lblInfo2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblInfo2.Visible = False
        '
        'lblInfo3
        '
        Me.lblInfo3.Location = New System.Drawing.Point(341, 251)
        Me.lblInfo3.Name = "lblInfo3"
        Me.lblInfo3.Size = New System.Drawing.Size(203, 55)
        Me.lblInfo3.TabIndex = 38
        Me.lblInfo3.Text = "Info3"
        Me.lblInfo3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblInfo3.Visible = False
        '
        'lblInfo4
        '
        Me.lblInfo4.Location = New System.Drawing.Point(341, 320)
        Me.lblInfo4.Name = "lblInfo4"
        Me.lblInfo4.Size = New System.Drawing.Size(203, 54)
        Me.lblInfo4.TabIndex = 39
        Me.lblInfo4.Text = "Info4"
        Me.lblInfo4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblInfo4.Visible = False
        '
        'lblInfo5
        '
        Me.lblInfo5.Location = New System.Drawing.Point(341, 388)
        Me.lblInfo5.Name = "lblInfo5"
        Me.lblInfo5.Size = New System.Drawing.Size(203, 53)
        Me.lblInfo5.TabIndex = 40
        Me.lblInfo5.Text = "Info5"
        Me.lblInfo5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblInfo5.Visible = False
        '
        'lblPrice1
        '
        Me.lblPrice1.AutoSize = True
        Me.lblPrice1.Location = New System.Drawing.Point(561, 120)
        Me.lblPrice1.Name = "lblPrice1"
        Me.lblPrice1.Size = New System.Drawing.Size(37, 13)
        Me.lblPrice1.TabIndex = 41
        Me.lblPrice1.Text = "Price1"
        Me.lblPrice1.Visible = False
        '
        'lblPrice2
        '
        Me.lblPrice2.AutoSize = True
        Me.lblPrice2.Location = New System.Drawing.Point(561, 182)
        Me.lblPrice2.Name = "lblPrice2"
        Me.lblPrice2.Size = New System.Drawing.Size(37, 13)
        Me.lblPrice2.TabIndex = 42
        Me.lblPrice2.Text = "Price2"
        Me.lblPrice2.Visible = False
        '
        'lblPrice3
        '
        Me.lblPrice3.AutoSize = True
        Me.lblPrice3.Location = New System.Drawing.Point(561, 251)
        Me.lblPrice3.Name = "lblPrice3"
        Me.lblPrice3.Size = New System.Drawing.Size(37, 13)
        Me.lblPrice3.TabIndex = 43
        Me.lblPrice3.Text = "Price3"
        Me.lblPrice3.Visible = False
        '
        'lblPrice4
        '
        Me.lblPrice4.AutoSize = True
        Me.lblPrice4.Location = New System.Drawing.Point(561, 320)
        Me.lblPrice4.Name = "lblPrice4"
        Me.lblPrice4.Size = New System.Drawing.Size(37, 13)
        Me.lblPrice4.TabIndex = 44
        Me.lblPrice4.Text = "Price4"
        Me.lblPrice4.Visible = False
        '
        'lblPrice5
        '
        Me.lblPrice5.AutoSize = True
        Me.lblPrice5.Location = New System.Drawing.Point(561, 388)
        Me.lblPrice5.Name = "lblPrice5"
        Me.lblPrice5.Size = New System.Drawing.Size(37, 13)
        Me.lblPrice5.TabIndex = 45
        Me.lblPrice5.Text = "Price5"
        Me.lblPrice5.Visible = False
        '
        'lblSubTot1
        '
        Me.lblSubTot1.AutoSize = True
        Me.lblSubTot1.Location = New System.Drawing.Point(775, 120)
        Me.lblSubTot1.Name = "lblSubTot1"
        Me.lblSubTot1.Size = New System.Drawing.Size(48, 13)
        Me.lblSubTot1.TabIndex = 51
        Me.lblSubTot1.Text = "SubTot1"
        Me.lblSubTot1.Visible = False
        '
        'lblSubTot2
        '
        Me.lblSubTot2.AutoSize = True
        Me.lblSubTot2.Location = New System.Drawing.Point(775, 189)
        Me.lblSubTot2.Name = "lblSubTot2"
        Me.lblSubTot2.Size = New System.Drawing.Size(48, 13)
        Me.lblSubTot2.TabIndex = 52
        Me.lblSubTot2.Text = "SubTot2"
        Me.lblSubTot2.Visible = False
        '
        'lblSubTot3
        '
        Me.lblSubTot3.AutoSize = True
        Me.lblSubTot3.Location = New System.Drawing.Point(775, 251)
        Me.lblSubTot3.Name = "lblSubTot3"
        Me.lblSubTot3.Size = New System.Drawing.Size(48, 13)
        Me.lblSubTot3.TabIndex = 53
        Me.lblSubTot3.Text = "SubTot3"
        Me.lblSubTot3.Visible = False
        '
        'lblSubTot4
        '
        Me.lblSubTot4.AutoSize = True
        Me.lblSubTot4.Location = New System.Drawing.Point(775, 320)
        Me.lblSubTot4.Name = "lblSubTot4"
        Me.lblSubTot4.Size = New System.Drawing.Size(48, 13)
        Me.lblSubTot4.TabIndex = 54
        Me.lblSubTot4.Text = "SubTot4"
        Me.lblSubTot4.Visible = False
        '
        'lblSubTot5
        '
        Me.lblSubTot5.AutoSize = True
        Me.lblSubTot5.Location = New System.Drawing.Point(775, 388)
        Me.lblSubTot5.Name = "lblSubTot5"
        Me.lblSubTot5.Size = New System.Drawing.Size(48, 13)
        Me.lblSubTot5.TabIndex = 55
        Me.lblSubTot5.Text = "SubTot5"
        Me.lblSubTot5.Visible = False
        '
        'txtQuantity1
        '
        Me.txtQuantity1.Location = New System.Drawing.Point(668, 113)
        Me.txtQuantity1.Name = "txtQuantity1"
        Me.txtQuantity1.Size = New System.Drawing.Size(51, 20)
        Me.txtQuantity1.TabIndex = 56
        Me.txtQuantity1.Visible = False
        '
        'txtQuantity2
        '
        Me.txtQuantity2.Location = New System.Drawing.Point(668, 182)
        Me.txtQuantity2.Name = "txtQuantity2"
        Me.txtQuantity2.Size = New System.Drawing.Size(51, 20)
        Me.txtQuantity2.TabIndex = 57
        Me.txtQuantity2.Visible = False
        '
        'txtQuantity3
        '
        Me.txtQuantity3.Location = New System.Drawing.Point(668, 244)
        Me.txtQuantity3.Name = "txtQuantity3"
        Me.txtQuantity3.Size = New System.Drawing.Size(51, 20)
        Me.txtQuantity3.TabIndex = 58
        Me.txtQuantity3.Visible = False
        '
        'txtQuantity4
        '
        Me.txtQuantity4.Location = New System.Drawing.Point(668, 313)
        Me.txtQuantity4.Name = "txtQuantity4"
        Me.txtQuantity4.Size = New System.Drawing.Size(51, 20)
        Me.txtQuantity4.TabIndex = 59
        Me.txtQuantity4.Visible = False
        '
        'txtQuantity5
        '
        Me.txtQuantity5.Location = New System.Drawing.Point(668, 385)
        Me.txtQuantity5.Name = "txtQuantity5"
        Me.txtQuantity5.Size = New System.Drawing.Size(51, 20)
        Me.txtQuantity5.TabIndex = 60
        Me.txtQuantity5.Visible = False
        '
        'lbltotalnorupee
        '
        Me.lbltotalnorupee.AutoSize = True
        Me.lbltotalnorupee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalnorupee.Location = New System.Drawing.Point(379, 446)
        Me.lbltotalnorupee.Name = "lbltotalnorupee"
        Me.lbltotalnorupee.Size = New System.Drawing.Size(15, 20)
        Me.lbltotalnorupee.TabIndex = 61
        Me.lbltotalnorupee.Text = "र"
        Me.lbltotalnorupee.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmCart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(890, 533)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbltotalnorupee)
        Me.Controls.Add(Me.txtQuantity5)
        Me.Controls.Add(Me.txtQuantity4)
        Me.Controls.Add(Me.txtQuantity3)
        Me.Controls.Add(Me.txtQuantity2)
        Me.Controls.Add(Me.txtQuantity1)
        Me.Controls.Add(Me.lblSubTot5)
        Me.Controls.Add(Me.lblSubTot4)
        Me.Controls.Add(Me.lblSubTot3)
        Me.Controls.Add(Me.lblSubTot2)
        Me.Controls.Add(Me.lblSubTot1)
        Me.Controls.Add(Me.lblPrice5)
        Me.Controls.Add(Me.lblPrice4)
        Me.Controls.Add(Me.lblPrice3)
        Me.Controls.Add(Me.lblPrice2)
        Me.Controls.Add(Me.lblPrice1)
        Me.Controls.Add(Me.lblInfo5)
        Me.Controls.Add(Me.lblInfo4)
        Me.Controls.Add(Me.lblInfo3)
        Me.Controls.Add(Me.lblInfo2)
        Me.Controls.Add(Me.lblInfo1)
        Me.Controls.Add(Me.lblCat5)
        Me.Controls.Add(Me.lblCat4)
        Me.Controls.Add(Me.lblCat3)
        Me.Controls.Add(Me.lblCat2)
        Me.Controls.Add(Me.lblCat1)
        Me.Controls.Add(Me.lblItem5)
        Me.Controls.Add(Me.lblItem4)
        Me.Controls.Add(Me.lblItem3)
        Me.Controls.Add(Me.lblItem2)
        Me.Controls.Add(Me.lblItem1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblTotalNo)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblSr5)
        Me.Controls.Add(Me.lblSr4)
        Me.Controls.Add(Me.lblSr3)
        Me.Controls.Add(Me.lblSr2)
        Me.Controls.Add(Me.lblSr1)
        Me.Controls.Add(Me.lblcartSrNo)
        Me.Controls.Add(Me.lblcartSubtotal)
        Me.Controls.Add(Me.lblcartQuantity)
        Me.Controls.Add(Me.lblcartPrice)
        Me.Controls.Add(Me.lblcartiteminfo)
        Me.Controls.Add(Me.lblcartSubCat)
        Me.Controls.Add(Me.lblcartItem)
        Me.Name = "frmCart"
        Me.Text = "Shopping Cart"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblcartSrNo As System.Windows.Forms.Label
    Friend WithEvents lblcartSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblcartQuantity As System.Windows.Forms.Label
    Friend WithEvents lblcartPrice As System.Windows.Forms.Label
    Friend WithEvents lblcartiteminfo As System.Windows.Forms.Label
    Friend WithEvents lblcartSubCat As System.Windows.Forms.Label
    Friend WithEvents lblcartItem As System.Windows.Forms.Label
    Friend WithEvents lblSr1 As System.Windows.Forms.Label
    Friend WithEvents lblSr2 As System.Windows.Forms.Label
    Friend WithEvents lblSr3 As System.Windows.Forms.Label
    Friend WithEvents lblSr4 As System.Windows.Forms.Label
    Friend WithEvents lblSr5 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblTotalNo As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnProceed As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblItem1 As System.Windows.Forms.Label
    Friend WithEvents lblItem2 As System.Windows.Forms.Label
    Friend WithEvents lblItem3 As System.Windows.Forms.Label
    Friend WithEvents lblItem4 As System.Windows.Forms.Label
    Friend WithEvents lblItem5 As System.Windows.Forms.Label
    Friend WithEvents lblCat1 As System.Windows.Forms.Label
    Friend WithEvents lblCat2 As System.Windows.Forms.Label
    Friend WithEvents lblCat3 As System.Windows.Forms.Label
    Friend WithEvents lblCat4 As System.Windows.Forms.Label
    Friend WithEvents lblCat5 As System.Windows.Forms.Label
    Friend WithEvents lblInfo1 As System.Windows.Forms.Label
    Friend WithEvents lblInfo2 As System.Windows.Forms.Label
    Friend WithEvents lblInfo3 As System.Windows.Forms.Label
    Friend WithEvents lblInfo4 As System.Windows.Forms.Label
    Friend WithEvents lblInfo5 As System.Windows.Forms.Label
    Friend WithEvents lblPrice1 As System.Windows.Forms.Label
    Friend WithEvents lblPrice2 As System.Windows.Forms.Label
    Friend WithEvents lblPrice3 As System.Windows.Forms.Label
    Friend WithEvents lblPrice4 As System.Windows.Forms.Label
    Friend WithEvents lblPrice5 As System.Windows.Forms.Label
    Friend WithEvents lblSubTot1 As System.Windows.Forms.Label
    Friend WithEvents lblSubTot2 As System.Windows.Forms.Label
    Friend WithEvents lblSubTot3 As System.Windows.Forms.Label
    Friend WithEvents lblSubTot4 As System.Windows.Forms.Label
    Friend WithEvents lblSubTot5 As System.Windows.Forms.Label
    Friend WithEvents txtQuantity1 As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity2 As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity3 As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity4 As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity5 As System.Windows.Forms.TextBox
    Friend WithEvents lbltotalnorupee As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
