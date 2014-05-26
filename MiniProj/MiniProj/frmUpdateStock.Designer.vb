<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdateStock))
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.errSearch = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dgridSearch = New System.Windows.Forms.DataGridView()
        Me.btnEditStock = New System.Windows.Forms.Button()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.errSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgridSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(71, 31)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(245, 20)
        Me.txtSearch.TabIndex = 0
        '
        'errSearch
        '
        Me.errSearch.ContainerControl = Me
        '
        'dgridSearch
        '
        Me.dgridSearch.AllowUserToAddRows = False
        Me.dgridSearch.AllowUserToDeleteRows = False
        Me.dgridSearch.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dgridSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridSearch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgridSearch.Location = New System.Drawing.Point(40, 72)
        Me.dgridSearch.Name = "dgridSearch"
        Me.dgridSearch.ReadOnly = True
        Me.dgridSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgridSearch.Size = New System.Drawing.Size(309, 284)
        Me.dgridSearch.TabIndex = 1
        '
        'btnEditStock
        '
        Me.btnEditStock.BackgroundImage = CType(resources.GetObject("btnEditStock.BackgroundImage"), System.Drawing.Image)
        Me.btnEditStock.Location = New System.Drawing.Point(177, 377)
        Me.btnEditStock.Name = "btnEditStock"
        Me.btnEditStock.Size = New System.Drawing.Size(83, 30)
        Me.btnEditStock.TabIndex = 2
        Me.btnEditStock.Text = "Edit stock"
        Me.btnEditStock.UseVisualStyleBackColor = True
        Me.btnEditStock.Visible = False
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(142, 9)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(96, 13)
        Me.lblSearch.TabIndex = 3
        Me.lblSearch.Text = "Search for the item"
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(266, 377)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(83, 30)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmUpdateStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(392, 419)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.btnEditStock)
        Me.Controls.Add(Me.dgridSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUpdateStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update stock details"
        CType(Me.errSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgridSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents errSearch As System.Windows.Forms.ErrorProvider
    Friend WithEvents dgridSearch As System.Windows.Forms.DataGridView
    Friend WithEvents btnEditStock As System.Windows.Forms.Button
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
