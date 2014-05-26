<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCategory))
        Me.tbCatSubCat = New System.Windows.Forms.TabControl()
        Me.tbCategories = New System.Windows.Forms.TabPage()
        Me.btnDeleteCat = New System.Windows.Forms.Button()
        Me.dgvCategories = New System.Windows.Forms.DataGridView()
        Me.btnAddCat = New System.Windows.Forms.Button()
        Me.tbSubCat = New System.Windows.Forms.TabPage()
        Me.btnDelSubCat = New System.Windows.Forms.Button()
        Me.dgvSubCat = New System.Windows.Forms.DataGridView()
        Me.btnAddSubCat = New System.Windows.Forms.Button()
        Me.tbBrands = New System.Windows.Forms.TabPage()
        Me.btnAddBrand = New System.Windows.Forms.Button()
        Me.dgvBrands = New System.Windows.Forms.DataGridView()
        Me.tbCatSubCat.SuspendLayout()
        Me.tbCategories.SuspendLayout()
        CType(Me.dgvCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbSubCat.SuspendLayout()
        CType(Me.dgvSubCat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbBrands.SuspendLayout()
        CType(Me.dgvBrands, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbCatSubCat
        '
        Me.tbCatSubCat.Controls.Add(Me.tbCategories)
        Me.tbCatSubCat.Controls.Add(Me.tbSubCat)
        Me.tbCatSubCat.Controls.Add(Me.tbBrands)
        Me.tbCatSubCat.Location = New System.Drawing.Point(12, 12)
        Me.tbCatSubCat.Multiline = True
        Me.tbCatSubCat.Name = "tbCatSubCat"
        Me.tbCatSubCat.SelectedIndex = 0
        Me.tbCatSubCat.Size = New System.Drawing.Size(337, 437)
        Me.tbCatSubCat.TabIndex = 0
        '
        'tbCategories
        '
        Me.tbCategories.Controls.Add(Me.btnDeleteCat)
        Me.tbCategories.Controls.Add(Me.dgvCategories)
        Me.tbCategories.Controls.Add(Me.btnAddCat)
        Me.tbCategories.Location = New System.Drawing.Point(4, 22)
        Me.tbCategories.Name = "tbCategories"
        Me.tbCategories.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCategories.Size = New System.Drawing.Size(329, 411)
        Me.tbCategories.TabIndex = 0
        Me.tbCategories.Text = "Categories"
        Me.tbCategories.UseVisualStyleBackColor = True
        '
        'btnDeleteCat
        '
        Me.btnDeleteCat.BackgroundImage = CType(resources.GetObject("btnDeleteCat.BackgroundImage"), System.Drawing.Image)
        Me.btnDeleteCat.Location = New System.Drawing.Point(205, 360)
        Me.btnDeleteCat.Name = "btnDeleteCat"
        Me.btnDeleteCat.Size = New System.Drawing.Size(94, 31)
        Me.btnDeleteCat.TabIndex = 4
        Me.btnDeleteCat.Text = "Delete category"
        Me.btnDeleteCat.UseVisualStyleBackColor = True
        Me.btnDeleteCat.Visible = False
        '
        'dgvCategories
        '
        Me.dgvCategories.AllowUserToAddRows = False
        Me.dgvCategories.AllowUserToDeleteRows = False
        Me.dgvCategories.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCategories.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvCategories.Location = New System.Drawing.Point(21, 20)
        Me.dgvCategories.Name = "dgvCategories"
        Me.dgvCategories.ReadOnly = True
        Me.dgvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCategories.Size = New System.Drawing.Size(278, 324)
        Me.dgvCategories.TabIndex = 3
        '
        'btnAddCat
        '
        Me.btnAddCat.BackgroundImage = CType(resources.GetObject("btnAddCat.BackgroundImage"), System.Drawing.Image)
        Me.btnAddCat.Location = New System.Drawing.Point(90, 360)
        Me.btnAddCat.Name = "btnAddCat"
        Me.btnAddCat.Size = New System.Drawing.Size(109, 31)
        Me.btnAddCat.TabIndex = 2
        Me.btnAddCat.Text = "Add new category"
        Me.btnAddCat.UseVisualStyleBackColor = True
        '
        'tbSubCat
        '
        Me.tbSubCat.Controls.Add(Me.btnDelSubCat)
        Me.tbSubCat.Controls.Add(Me.dgvSubCat)
        Me.tbSubCat.Controls.Add(Me.btnAddSubCat)
        Me.tbSubCat.Location = New System.Drawing.Point(4, 22)
        Me.tbSubCat.Name = "tbSubCat"
        Me.tbSubCat.Padding = New System.Windows.Forms.Padding(3)
        Me.tbSubCat.Size = New System.Drawing.Size(329, 411)
        Me.tbSubCat.TabIndex = 1
        Me.tbSubCat.Text = "Sub-Categories"
        Me.tbSubCat.UseVisualStyleBackColor = True
        '
        'btnDelSubCat
        '
        Me.btnDelSubCat.Image = CType(resources.GetObject("btnDelSubCat.Image"), System.Drawing.Image)
        Me.btnDelSubCat.Location = New System.Drawing.Point(204, 354)
        Me.btnDelSubCat.Name = "btnDelSubCat"
        Me.btnDelSubCat.Size = New System.Drawing.Size(98, 40)
        Me.btnDelSubCat.TabIndex = 5
        Me.btnDelSubCat.Text = "Delete sub-category"
        Me.btnDelSubCat.UseVisualStyleBackColor = True
        Me.btnDelSubCat.Visible = False
        '
        'dgvSubCat
        '
        Me.dgvSubCat.AllowUserToAddRows = False
        Me.dgvSubCat.AllowUserToDeleteRows = False
        Me.dgvSubCat.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dgvSubCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSubCat.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSubCat.Location = New System.Drawing.Point(19, 22)
        Me.dgvSubCat.Name = "dgvSubCat"
        Me.dgvSubCat.ReadOnly = True
        Me.dgvSubCat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSubCat.Size = New System.Drawing.Size(283, 315)
        Me.dgvSubCat.TabIndex = 4
        '
        'btnAddSubCat
        '
        Me.btnAddSubCat.Image = CType(resources.GetObject("btnAddSubCat.Image"), System.Drawing.Image)
        Me.btnAddSubCat.Location = New System.Drawing.Point(77, 354)
        Me.btnAddSubCat.Name = "btnAddSubCat"
        Me.btnAddSubCat.Size = New System.Drawing.Size(110, 40)
        Me.btnAddSubCat.TabIndex = 3
        Me.btnAddSubCat.Text = "Add new sub category"
        Me.btnAddSubCat.UseVisualStyleBackColor = True
        '
        'tbBrands
        '
        Me.tbBrands.Controls.Add(Me.btnAddBrand)
        Me.tbBrands.Controls.Add(Me.dgvBrands)
        Me.tbBrands.Location = New System.Drawing.Point(4, 22)
        Me.tbBrands.Name = "tbBrands"
        Me.tbBrands.Size = New System.Drawing.Size(329, 411)
        Me.tbBrands.TabIndex = 2
        Me.tbBrands.Text = "Brands"
        Me.tbBrands.UseVisualStyleBackColor = True
        '
        'btnAddBrand
        '
        Me.btnAddBrand.BackgroundImage = Global.ShopSoft.My.Resources.Resources.back1
        Me.btnAddBrand.Location = New System.Drawing.Point(220, 361)
        Me.btnAddBrand.Name = "btnAddBrand"
        Me.btnAddBrand.Size = New System.Drawing.Size(77, 34)
        Me.btnAddBrand.TabIndex = 1
        Me.btnAddBrand.Text = "Add brand"
        Me.btnAddBrand.UseVisualStyleBackColor = True
        '
        'dgvBrands
        '
        Me.dgvBrands.AllowUserToAddRows = False
        Me.dgvBrands.AllowUserToDeleteRows = False
        Me.dgvBrands.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dgvBrands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBrands.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvBrands.Location = New System.Drawing.Point(32, 24)
        Me.dgvBrands.Name = "dgvBrands"
        Me.dgvBrands.ReadOnly = True
        Me.dgvBrands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBrands.Size = New System.Drawing.Size(265, 318)
        Me.dgvBrands.TabIndex = 0
        '
        'frmCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(361, 461)
        Me.Controls.Add(Me.tbCatSubCat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCategory"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage categories, sub-categories and brands"
        Me.tbCatSubCat.ResumeLayout(False)
        Me.tbCategories.ResumeLayout(False)
        CType(Me.dgvCategories, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbSubCat.ResumeLayout(False)
        CType(Me.dgvSubCat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbBrands.ResumeLayout(False)
        CType(Me.dgvBrands, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbCatSubCat As System.Windows.Forms.TabControl
    Friend WithEvents tbCategories As System.Windows.Forms.TabPage
    Friend WithEvents tbSubCat As System.Windows.Forms.TabPage
    Friend WithEvents tbBrands As System.Windows.Forms.TabPage
    Friend WithEvents btnAddCat As System.Windows.Forms.Button
    Friend WithEvents dgvCategories As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddSubCat As System.Windows.Forms.Button
    Friend WithEvents dgvSubCat As System.Windows.Forms.DataGridView
    Friend WithEvents btnDeleteCat As System.Windows.Forms.Button
    Friend WithEvents btnDelSubCat As System.Windows.Forms.Button
    Friend WithEvents dgvBrands As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddBrand As System.Windows.Forms.Button
End Class
