<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemWhatToDo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemWhatToDo))
        Me.btnIndividual = New System.Windows.Forms.Button()
        Me.btnShowTree = New System.Windows.Forms.Button()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.btnManageCategory = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnIndividual
        '
        Me.btnIndividual.AutoSize = True
        Me.btnIndividual.BackgroundImage = CType(resources.GetObject("btnIndividual.BackgroundImage"), System.Drawing.Image)
        Me.btnIndividual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnIndividual.Location = New System.Drawing.Point(63, 38)
        Me.btnIndividual.Name = "btnIndividual"
        Me.btnIndividual.Size = New System.Drawing.Size(147, 47)
        Me.btnIndividual.TabIndex = 0
        Me.btnIndividual.Text = "View individual products"
        Me.btnIndividual.UseVisualStyleBackColor = True
        '
        'btnShowTree
        '
        Me.btnShowTree.AutoSize = True
        Me.btnShowTree.BackgroundImage = CType(resources.GetObject("btnShowTree.BackgroundImage"), System.Drawing.Image)
        Me.btnShowTree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnShowTree.Location = New System.Drawing.Point(63, 91)
        Me.btnShowTree.Name = "btnShowTree"
        Me.btnShowTree.Size = New System.Drawing.Size(146, 47)
        Me.btnShowTree.TabIndex = 1
        Me.btnShowTree.Text = "Show tree view of products"
        Me.btnShowTree.UseVisualStyleBackColor = True
        '
        'btnAddProduct
        '
        Me.btnAddProduct.AutoSize = True
        Me.btnAddProduct.BackgroundImage = CType(resources.GetObject("btnAddProduct.BackgroundImage"), System.Drawing.Image)
        Me.btnAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAddProduct.Location = New System.Drawing.Point(63, 144)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(146, 47)
        Me.btnAddProduct.TabIndex = 2
        Me.btnAddProduct.Text = "Add a new product"
        Me.btnAddProduct.UseVisualStyleBackColor = True
        '
        'btnManageCategory
        '
        Me.btnManageCategory.AutoSize = True
        Me.btnManageCategory.BackgroundImage = CType(resources.GetObject("btnManageCategory.BackgroundImage"), System.Drawing.Image)
        Me.btnManageCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnManageCategory.Location = New System.Drawing.Point(64, 197)
        Me.btnManageCategory.Name = "btnManageCategory"
        Me.btnManageCategory.Size = New System.Drawing.Size(146, 47)
        Me.btnManageCategory.TabIndex = 3
        Me.btnManageCategory.Text = "Category and brands"
        Me.btnManageCategory.UseVisualStyleBackColor = True
        '
        'frmItemWhatToDo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(277, 291)
        Me.Controls.Add(Me.btnManageCategory)
        Me.Controls.Add(Me.btnAddProduct)
        Me.Controls.Add(Me.btnShowTree)
        Me.Controls.Add(Me.btnIndividual)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmItemWhatToDo"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select what to do"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnIndividual As System.Windows.Forms.Button
    Friend WithEvents btnShowTree As System.Windows.Forms.Button
    Friend WithEvents btnAddProduct As System.Windows.Forms.Button
    Friend WithEvents btnManageCategory As System.Windows.Forms.Button
End Class
