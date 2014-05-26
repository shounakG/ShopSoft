<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddBrand
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtBrandName = New System.Windows.Forms.TextBox()
        Me.lblEnterName = New System.Windows.Forms.Label()
        Me.errBrand = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.errBrand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = Global.ShopSoft.My.Resources.Resources.back1
        Me.btnCancel.Location = New System.Drawing.Point(166, 107)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImage = Global.ShopSoft.My.Resources.Resources.back1
        Me.btnAdd.Location = New System.Drawing.Point(49, 107)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtBrandName
        '
        Me.txtBrandName.Location = New System.Drawing.Point(30, 61)
        Me.txtBrandName.Name = "txtBrandName"
        Me.txtBrandName.Size = New System.Drawing.Size(223, 20)
        Me.txtBrandName.TabIndex = 5
        '
        'lblEnterName
        '
        Me.lblEnterName.AutoSize = True
        Me.lblEnterName.Location = New System.Drawing.Point(96, 36)
        Me.lblEnterName.Name = "lblEnterName"
        Me.lblEnterName.Size = New System.Drawing.Size(91, 13)
        Me.lblEnterName.TabIndex = 4
        Me.lblEnterName.Text = "Enter brand name"
        '
        'errBrand
        '
        Me.errBrand.ContainerControl = Me
        '
        'frmAddBrand
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(283, 140)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtBrandName)
        Me.Controls.Add(Me.lblEnterName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddBrand"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ShopSoft - Add brand"
        CType(Me.errBrand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtBrandName As System.Windows.Forms.TextBox
    Friend WithEvents lblEnterName As System.Windows.Forms.Label
    Friend WithEvents errBrand As System.Windows.Forms.ErrorProvider
End Class
