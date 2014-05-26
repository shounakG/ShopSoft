<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductInfo))
        Me.lblProdName = New System.Windows.Forms.Label()
        Me.lblPosRat = New System.Windows.Forms.Label()
        Me.lblNegRat = New System.Windows.Forms.Label()
        Me.lblprodinfo = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.btnAtc = New System.Windows.Forms.Button()
        Me.lblMRP = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblMRPno = New System.Windows.Forms.Label()
        Me.lblRateno = New System.Windows.Forms.Label()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblDiscountno = New System.Windows.Forms.Label()
        Me.PicRatingsNeg = New System.Windows.Forms.PictureBox()
        Me.picproduct = New System.Windows.Forms.PictureBox()
        Me.PicRatingsPos = New System.Windows.Forms.PictureBox()
        Me.lblRateRs = New System.Windows.Forms.Label()
        Me.lblMRPrs = New System.Windows.Forms.Label()
        Me.lblWarranty = New System.Windows.Forms.Label()
        CType(Me.PicRatingsNeg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picproduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRatingsPos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProdName
        '
        Me.lblProdName.AutoSize = True
        Me.lblProdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdName.Location = New System.Drawing.Point(66, 34)
        Me.lblProdName.Name = "lblProdName"
        Me.lblProdName.Size = New System.Drawing.Size(82, 29)
        Me.lblProdName.TabIndex = 1
        Me.lblProdName.Text = "Name"
        '
        'lblPosRat
        '
        Me.lblPosRat.AutoSize = True
        Me.lblPosRat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosRat.Location = New System.Drawing.Point(68, 299)
        Me.lblPosRat.Name = "lblPosRat"
        Me.lblPosRat.Size = New System.Drawing.Size(21, 13)
        Me.lblPosRat.TabIndex = 3
        Me.lblPosRat.Text = "00"
        '
        'lblNegRat
        '
        Me.lblNegRat.AutoSize = True
        Me.lblNegRat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNegRat.Location = New System.Drawing.Point(108, 299)
        Me.lblNegRat.Name = "lblNegRat"
        Me.lblNegRat.Size = New System.Drawing.Size(21, 13)
        Me.lblNegRat.TabIndex = 4
        Me.lblNegRat.Text = "00"
        '
        'lblprodinfo
        '
        Me.lblprodinfo.AutoSize = True
        Me.lblprodinfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprodinfo.Location = New System.Drawing.Point(241, 79)
        Me.lblprodinfo.MaximumSize = New System.Drawing.Size(196, 134)
        Me.lblprodinfo.Name = "lblprodinfo"
        Me.lblprodinfo.Size = New System.Drawing.Size(25, 13)
        Me.lblprodinfo.TabIndex = 5
        Me.lblprodinfo.Text = "Info"
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(239, 217)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(56, 13)
        Me.lblStock.TabIndex = 6
        Me.lblStock.Text = "Availability"
        '
        'btnAtc
        '
        Me.btnAtc.Location = New System.Drawing.Point(338, 328)
        Me.btnAtc.Name = "btnAtc"
        Me.btnAtc.Size = New System.Drawing.Size(75, 23)
        Me.btnAtc.TabIndex = 7
        Me.btnAtc.Text = "Add To Cart"
        Me.btnAtc.UseVisualStyleBackColor = True
        '
        'lblMRP
        '
        Me.lblMRP.AutoSize = True
        Me.lblMRP.Location = New System.Drawing.Point(241, 275)
        Me.lblMRP.Name = "lblMRP"
        Me.lblMRP.Size = New System.Drawing.Size(31, 13)
        Me.lblMRP.TabIndex = 8
        Me.lblMRP.Text = "MRP"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(241, 286)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(0, 13)
        Me.lblRate.TabIndex = 9
        '
        'lblMRPno
        '
        Me.lblMRPno.AutoSize = True
        Me.lblMRPno.Location = New System.Drawing.Point(306, 274)
        Me.lblMRPno.Name = "lblMRPno"
        Me.lblMRPno.Size = New System.Drawing.Size(31, 13)
        Me.lblMRPno.TabIndex = 10
        Me.lblMRPno.Text = "Price"
        '
        'lblRateno
        '
        Me.lblRateno.AutoSize = True
        Me.lblRateno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRateno.Location = New System.Drawing.Point(335, 260)
        Me.lblRateno.Name = "lblRateno"
        Me.lblRateno.Size = New System.Drawing.Size(34, 13)
        Me.lblRateno.TabIndex = 11
        Me.lblRateno.Text = "Rate"
        Me.lblRateno.Visible = False
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrand.Location = New System.Drawing.Point(38, 21)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(40, 13)
        Me.lblBrand.TabIndex = 12
        Me.lblBrand.Text = "Brand"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Location = New System.Drawing.Point(241, 299)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(49, 13)
        Me.lblDiscount.TabIndex = 13
        Me.lblDiscount.Text = "Discount"
        '
        'lblDiscountno
        '
        Me.lblDiscountno.AutoSize = True
        Me.lblDiscountno.Location = New System.Drawing.Point(296, 299)
        Me.lblDiscountno.Name = "lblDiscountno"
        Me.lblDiscountno.Size = New System.Drawing.Size(0, 13)
        Me.lblDiscountno.TabIndex = 14
        '
        'PicRatingsNeg
        '
        Me.PicRatingsNeg.Image = Global.ShopSoft.My.Resources.Resources.picRatingsNeg
        Me.PicRatingsNeg.Location = New System.Drawing.Point(102, 252)
        Me.PicRatingsNeg.Name = "PicRatingsNeg"
        Me.PicRatingsNeg.Size = New System.Drawing.Size(36, 35)
        Me.PicRatingsNeg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicRatingsNeg.TabIndex = 16
        Me.PicRatingsNeg.TabStop = False
        '
        'picproduct
        '
        Me.picproduct.ErrorImage = CType(resources.GetObject("picproduct.ErrorImage"), System.Drawing.Image)
        Me.picproduct.Location = New System.Drawing.Point(26, 79)
        Me.picproduct.Name = "picproduct"
        Me.picproduct.Size = New System.Drawing.Size(161, 134)
        Me.picproduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picproduct.TabIndex = 0
        Me.picproduct.TabStop = False
        '
        'PicRatingsPos
        '
        Me.PicRatingsPos.Image = Global.ShopSoft.My.Resources.Resources.picRatingsPos
        Me.PicRatingsPos.Location = New System.Drawing.Point(62, 252)
        Me.PicRatingsPos.Name = "PicRatingsPos"
        Me.PicRatingsPos.Size = New System.Drawing.Size(34, 35)
        Me.PicRatingsPos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicRatingsPos.TabIndex = 17
        Me.PicRatingsPos.TabStop = False
        '
        'lblRateRs
        '
        Me.lblRateRs.AutoSize = True
        Me.lblRateRs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRateRs.Location = New System.Drawing.Point(324, 255)
        Me.lblRateRs.Name = "lblRateRs"
        Me.lblRateRs.Size = New System.Drawing.Size(15, 20)
        Me.lblRateRs.TabIndex = 18
        Me.lblRateRs.Text = "र"
        Me.lblRateRs.Visible = False
        '
        'lblMRPrs
        '
        Me.lblMRPrs.AutoSize = True
        Me.lblMRPrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMRPrs.Location = New System.Drawing.Point(293, 270)
        Me.lblMRPrs.Name = "lblMRPrs"
        Me.lblMRPrs.Size = New System.Drawing.Size(15, 20)
        Me.lblMRPrs.TabIndex = 19
        Me.lblMRPrs.Text = "र"
        '
        'lblWarranty
        '
        Me.lblWarranty.AutoSize = True
        Me.lblWarranty.Location = New System.Drawing.Point(240, 239)
        Me.lblWarranty.Name = "lblWarranty"
        Me.lblWarranty.Size = New System.Drawing.Size(50, 13)
        Me.lblWarranty.TabIndex = 21
        Me.lblWarranty.Text = "Warranty"
        Me.lblWarranty.Visible = False
        '
        'frmProductInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(458, 372)
        Me.Controls.Add(Me.lblWarranty)
        Me.Controls.Add(Me.lblRateno)
        Me.Controls.Add(Me.lblMRPno)
        Me.Controls.Add(Me.lblMRPrs)
        Me.Controls.Add(Me.lblRateRs)
        Me.Controls.Add(Me.PicRatingsPos)
        Me.Controls.Add(Me.PicRatingsNeg)
        Me.Controls.Add(Me.lblDiscountno)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblBrand)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.lblMRP)
        Me.Controls.Add(Me.btnAtc)
        Me.Controls.Add(Me.lblStock)
        Me.Controls.Add(Me.lblprodinfo)
        Me.Controls.Add(Me.lblNegRat)
        Me.Controls.Add(Me.lblPosRat)
        Me.Controls.Add(Me.lblProdName)
        Me.Controls.Add(Me.picproduct)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmProductInfo"
        Me.Text = "Product Information"
        CType(Me.PicRatingsNeg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picproduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRatingsPos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picproduct As System.Windows.Forms.PictureBox
    Friend WithEvents lblProdName As System.Windows.Forms.Label
    Friend WithEvents lblPosRat As System.Windows.Forms.Label
    Friend WithEvents lblNegRat As System.Windows.Forms.Label
    Friend WithEvents lblprodinfo As System.Windows.Forms.Label
    Friend WithEvents lblStock As System.Windows.Forms.Label
    Friend WithEvents btnAtc As System.Windows.Forms.Button
    Friend WithEvents lblMRP As System.Windows.Forms.Label
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents lblMRPno As System.Windows.Forms.Label
    Friend WithEvents lblRateno As System.Windows.Forms.Label
    Friend WithEvents lblBrand As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents lblDiscountno As System.Windows.Forms.Label
    Friend WithEvents PicRatingsNeg As System.Windows.Forms.PictureBox
    Friend WithEvents PicRatingsPos As System.Windows.Forms.PictureBox
    Friend WithEvents lblRateRs As System.Windows.Forms.Label
    Friend WithEvents lblMRPrs As System.Windows.Forms.Label
    Friend WithEvents lblWarranty As System.Windows.Forms.Label
End Class
