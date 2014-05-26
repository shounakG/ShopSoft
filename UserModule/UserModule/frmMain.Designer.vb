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
        Me.txtSearchMain = New System.Windows.Forms.TextBox()
        Me.btnMainSearch = New System.Windows.Forms.Button()
        Me.tvMain = New System.Windows.Forms.TreeView()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnMainBrowse = New System.Windows.Forms.Button()
        Me.lblMyAccount = New System.Windows.Forms.Label()
        Me.lblAboutUs = New System.Windows.Forms.Label()
        Me.cbCriteria = New System.Windows.Forms.ComboBox()
        Me.rbCat = New System.Windows.Forms.RadioButton()
        Me.rbSubCat = New System.Windows.Forms.RadioButton()
        Me.rbBrands = New System.Windows.Forms.RadioButton()
        Me.stripCategory = New System.Windows.Forms.ToolStrip()
        Me.picMainLogo = New System.Windows.Forms.PictureBox()
        Me.picShoppingCart = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblsrno = New System.Windows.Forms.Label()
        Me.lblLogout = New System.Windows.Forms.Label()
        Me.lblTheme = New System.Windows.Forms.Label()
        Me.cmbTheme = New System.Windows.Forms.ComboBox()
        Me.lblLite = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.rbAll = New System.Windows.Forms.RadioButton()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.picMainLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShoppingCart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearchMain
        '
        Me.txtSearchMain.Location = New System.Drawing.Point(242, 12)
        Me.txtSearchMain.Name = "txtSearchMain"
        Me.txtSearchMain.Size = New System.Drawing.Size(195, 20)
        Me.txtSearchMain.TabIndex = 4
        Me.txtSearchMain.Text = "Search for Products"
        '
        'btnMainSearch
        '
        Me.btnMainSearch.Location = New System.Drawing.Point(261, 45)
        Me.btnMainSearch.Name = "btnMainSearch"
        Me.btnMainSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnMainSearch.TabIndex = 5
        Me.btnMainSearch.Text = "Search"
        Me.btnMainSearch.UseVisualStyleBackColor = True
        '
        'tvMain
        '
        Me.tvMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.tvMain.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvMain.ForeColor = System.Drawing.Color.White
        Me.tvMain.Location = New System.Drawing.Point(1200, 112)
        Me.tvMain.Name = "tvMain"
        Me.tvMain.Size = New System.Drawing.Size(141, 630)
        Me.tvMain.TabIndex = 6
        Me.tvMain.Visible = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnMainBrowse
        '
        Me.btnMainBrowse.Location = New System.Drawing.Point(342, 45)
        Me.btnMainBrowse.Name = "btnMainBrowse"
        Me.btnMainBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnMainBrowse.TabIndex = 8
        Me.btnMainBrowse.Text = "Browse"
        Me.btnMainBrowse.UseVisualStyleBackColor = True
        Me.btnMainBrowse.Visible = False
        '
        'lblMyAccount
        '
        Me.lblMyAccount.AutoSize = True
        Me.lblMyAccount.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblMyAccount.Location = New System.Drawing.Point(1150, 20)
        Me.lblMyAccount.Name = "lblMyAccount"
        Me.lblMyAccount.Size = New System.Drawing.Size(33, 13)
        Me.lblMyAccount.TabIndex = 11
        Me.lblMyAccount.Text = "Login"
        '
        'lblAboutUs
        '
        Me.lblAboutUs.AutoSize = True
        Me.lblAboutUs.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblAboutUs.Location = New System.Drawing.Point(1150, 50)
        Me.lblAboutUs.Name = "lblAboutUs"
        Me.lblAboutUs.Size = New System.Drawing.Size(51, 13)
        Me.lblAboutUs.TabIndex = 12
        Me.lblAboutUs.Text = "About Us"
        '
        'cbCriteria
        '
        Me.cbCriteria.FormattingEnabled = True
        Me.cbCriteria.Location = New System.Drawing.Point(462, 12)
        Me.cbCriteria.Name = "cbCriteria"
        Me.cbCriteria.Size = New System.Drawing.Size(175, 21)
        Me.cbCriteria.Sorted = True
        Me.cbCriteria.TabIndex = 16
        Me.cbCriteria.Text = "All Categories"
        '
        'rbCat
        '
        Me.rbCat.AutoSize = True
        Me.rbCat.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.rbCat.Location = New System.Drawing.Point(503, 48)
        Me.rbCat.Name = "rbCat"
        Me.rbCat.Size = New System.Drawing.Size(67, 17)
        Me.rbCat.TabIndex = 17
        Me.rbCat.TabStop = True
        Me.rbCat.Text = "Category"
        Me.rbCat.UseVisualStyleBackColor = True
        '
        'rbSubCat
        '
        Me.rbSubCat.AutoSize = True
        Me.rbSubCat.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.rbSubCat.Location = New System.Drawing.Point(576, 49)
        Me.rbSubCat.Name = "rbSubCat"
        Me.rbSubCat.Size = New System.Drawing.Size(89, 17)
        Me.rbSubCat.TabIndex = 18
        Me.rbSubCat.TabStop = True
        Me.rbSubCat.Text = "Sub-Category"
        Me.rbSubCat.UseVisualStyleBackColor = True
        '
        'rbBrands
        '
        Me.rbBrands.AutoSize = True
        Me.rbBrands.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.rbBrands.Location = New System.Drawing.Point(671, 48)
        Me.rbBrands.Name = "rbBrands"
        Me.rbBrands.Size = New System.Drawing.Size(53, 17)
        Me.rbBrands.TabIndex = 19
        Me.rbBrands.TabStop = True
        Me.rbBrands.Text = "Brand"
        Me.rbBrands.UseVisualStyleBackColor = True
        '
        'stripCategory
        '
        Me.stripCategory.Dock = System.Windows.Forms.DockStyle.None
        Me.stripCategory.Location = New System.Drawing.Point(30, 87)
        Me.stripCategory.Name = "stripCategory"
        Me.stripCategory.Size = New System.Drawing.Size(43, 25)
        Me.stripCategory.TabIndex = 22
        Me.stripCategory.Text = "ToolStrip1"
        '
        'picMainLogo
        '
        Me.picMainLogo.Image = Global.ShopSoft.My.Resources.Resources.logo
        Me.picMainLogo.Location = New System.Drawing.Point(30, 12)
        Me.picMainLogo.Name = "picMainLogo"
        Me.picMainLogo.Size = New System.Drawing.Size(175, 54)
        Me.picMainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMainLogo.TabIndex = 14
        Me.picMainLogo.TabStop = False
        '
        'picShoppingCart
        '
        Me.picShoppingCart.Image = Global.ShopSoft.My.Resources.Resources.shopping_cart_logo1
        Me.picShoppingCart.Location = New System.Drawing.Point(1020, 12)
        Me.picShoppingCart.Name = "picShoppingCart"
        Me.picShoppingCart.Size = New System.Drawing.Size(92, 75)
        Me.picShoppingCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picShoppingCart.TabIndex = 10
        Me.picShoppingCart.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(0, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1500, 110)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'lblsrno
        '
        Me.lblsrno.AutoSize = True
        Me.lblsrno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsrno.ForeColor = System.Drawing.Color.Red
        Me.lblsrno.Location = New System.Drawing.Point(1093, 74)
        Me.lblsrno.Name = "lblsrno"
        Me.lblsrno.Size = New System.Drawing.Size(0, 13)
        Me.lblsrno.TabIndex = 32
        '
        'lblLogout
        '
        Me.lblLogout.AutoSize = True
        Me.lblLogout.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblLogout.Location = New System.Drawing.Point(1150, 74)
        Me.lblLogout.Name = "lblLogout"
        Me.lblLogout.Size = New System.Drawing.Size(40, 13)
        Me.lblLogout.TabIndex = 34
        Me.lblLogout.Text = "Logout"
        Me.lblLogout.Visible = False
        '
        'lblTheme
        '
        Me.lblTheme.AutoSize = True
        Me.lblTheme.ForeColor = System.Drawing.Color.White
        Me.lblTheme.Location = New System.Drawing.Point(1229, 43)
        Me.lblTheme.Name = "lblTheme"
        Me.lblTheme.Size = New System.Drawing.Size(72, 13)
        Me.lblTheme.TabIndex = 37
        Me.lblTheme.Text = "Theme picker"
        '
        'cmbTheme
        '
        Me.cmbTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTheme.FormattingEnabled = True
        Me.cmbTheme.Items.AddRange(New Object() {"Blue", "Aqua", "Techno", "Beige"})
        Me.cmbTheme.Location = New System.Drawing.Point(1232, 66)
        Me.cmbTheme.Name = "cmbTheme"
        Me.cmbTheme.Size = New System.Drawing.Size(121, 21)
        Me.cmbTheme.TabIndex = 36
        '
        'lblLite
        '
        Me.lblLite.AutoSize = True
        Me.lblLite.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblLite.Location = New System.Drawing.Point(1229, 20)
        Me.lblLite.Name = "lblLite"
        Me.lblLite.Size = New System.Drawing.Size(98, 13)
        Me.lblLite.TabIndex = 41
        Me.lblLite.Text = "GoTo LITE Version"
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'rbAll
        '
        Me.rbAll.AutoSize = True
        Me.rbAll.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.rbAll.Location = New System.Drawing.Point(462, 48)
        Me.rbAll.Name = "rbAll"
        Me.rbAll.Size = New System.Drawing.Size(36, 17)
        Me.rbAll.TabIndex = 43
        Me.rbAll.TabStop = True
        Me.rbAll.Text = "All"
        Me.rbAll.UseVisualStyleBackColor = True
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblSelect.Location = New System.Drawing.Point(668, 19)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(105, 13)
        Me.lblSelect.TabIndex = 46
        Me.lblSelect.Text = "Select Another Shop"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1366, 499)
        Me.Controls.Add(Me.lblSelect)
        Me.Controls.Add(Me.rbAll)
        Me.Controls.Add(Me.lblLite)
        Me.Controls.Add(Me.lblTheme)
        Me.Controls.Add(Me.cmbTheme)
        Me.Controls.Add(Me.lblLogout)
        Me.Controls.Add(Me.lblsrno)
        Me.Controls.Add(Me.stripCategory)
        Me.Controls.Add(Me.rbBrands)
        Me.Controls.Add(Me.rbSubCat)
        Me.Controls.Add(Me.rbCat)
        Me.Controls.Add(Me.cbCriteria)
        Me.Controls.Add(Me.picMainLogo)
        Me.Controls.Add(Me.lblAboutUs)
        Me.Controls.Add(Me.lblMyAccount)
        Me.Controls.Add(Me.picShoppingCart)
        Me.Controls.Add(Me.btnMainBrowse)
        Me.Controls.Add(Me.btnMainSearch)
        Me.Controls.Add(Me.txtSearchMain)
        Me.Controls.Add(Me.tvMain)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Home"
        CType(Me.picMainLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShoppingCart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearchMain As System.Windows.Forms.TextBox
    Friend WithEvents btnMainSearch As System.Windows.Forms.Button
    Friend WithEvents tvMain As System.Windows.Forms.TreeView
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnMainBrowse As System.Windows.Forms.Button
    Friend WithEvents picShoppingCart As System.Windows.Forms.PictureBox
    Friend WithEvents lblMyAccount As System.Windows.Forms.Label
    Friend WithEvents lblAboutUs As System.Windows.Forms.Label
    Friend WithEvents picMainLogo As System.Windows.Forms.PictureBox
    Friend WithEvents cbCriteria As System.Windows.Forms.ComboBox
    Friend WithEvents rbCat As System.Windows.Forms.RadioButton
    Friend WithEvents rbSubCat As System.Windows.Forms.RadioButton
    Friend WithEvents rbBrands As System.Windows.Forms.RadioButton
    Friend WithEvents stripCategory As System.Windows.Forms.ToolStrip
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblsrno As System.Windows.Forms.Label
    Friend WithEvents lblLogout As System.Windows.Forms.Label
    Friend WithEvents lblTheme As System.Windows.Forms.Label
    Friend WithEvents cmbTheme As System.Windows.Forms.ComboBox
    Friend WithEvents lblLite As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents rbAll As System.Windows.Forms.RadioButton
    Friend WithEvents lblSelect As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
