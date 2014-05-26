<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrowseProducts
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
        Me.tvProducts = New System.Windows.Forms.TreeView()
        Me.dgridFilteredProducts = New System.Windows.Forms.DataGridView()
        Me.lblNote = New System.Windows.Forms.Label()
        CType(Me.dgridFilteredProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tvProducts
        '
        Me.tvProducts.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.tvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvProducts.Location = New System.Drawing.Point(12, 12)
        Me.tvProducts.Name = "tvProducts"
        Me.tvProducts.Size = New System.Drawing.Size(168, 407)
        Me.tvProducts.TabIndex = 0
        '
        'dgridFilteredProducts
        '
        Me.dgridFilteredProducts.AllowUserToAddRows = False
        Me.dgridFilteredProducts.AllowUserToDeleteRows = False
        Me.dgridFilteredProducts.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.dgridFilteredProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridFilteredProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.dgridFilteredProducts.Location = New System.Drawing.Point(202, 12)
        Me.dgridFilteredProducts.MultiSelect = False
        Me.dgridFilteredProducts.Name = "dgridFilteredProducts"
        Me.dgridFilteredProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgridFilteredProducts.Size = New System.Drawing.Size(482, 407)
        Me.dgridFilteredProducts.TabIndex = 1
        Me.dgridFilteredProducts.Visible = False
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.Location = New System.Drawing.Point(303, 453)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(155, 13)
        Me.lblNote.TabIndex = 0
        Me.lblNote.Text = "Double click on a record to edit"
        '
        'frmBrowseProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(695, 484)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.dgridFilteredProducts)
        Me.Controls.Add(Me.tvProducts)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBrowseProducts"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Browse Products"
        CType(Me.dgridFilteredProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tvProducts As System.Windows.Forms.TreeView
    Friend WithEvents dgridFilteredProducts As System.Windows.Forms.DataGridView
    Friend WithEvents lblNote As System.Windows.Forms.Label
End Class
