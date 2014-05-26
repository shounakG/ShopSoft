<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCat
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
        Me.lblEnterName = New System.Windows.Forms.Label()
        Me.txtCatName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.errAddCat = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.selPic = New System.Windows.Forms.OpenFileDialog()
        CType(Me.errAddCat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEnterName
        '
        Me.lblEnterName.AutoSize = True
        Me.lblEnterName.Location = New System.Drawing.Point(87, 41)
        Me.lblEnterName.Name = "lblEnterName"
        Me.lblEnterName.Size = New System.Drawing.Size(105, 13)
        Me.lblEnterName.TabIndex = 0
        Me.lblEnterName.Text = "Enter category name"
        '
        'txtCatName
        '
        Me.txtCatName.Location = New System.Drawing.Point(28, 66)
        Me.txtCatName.Name = "txtCatName"
        Me.txtCatName.Size = New System.Drawing.Size(223, 20)
        Me.txtCatName.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImage = Global.ShopSoft.My.Resources.Resources.back1
        Me.btnAdd.Location = New System.Drawing.Point(48, 122)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = Global.ShopSoft.My.Resources.Resources.back1
        Me.btnCancel.Location = New System.Drawing.Point(165, 122)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'errAddCat
        '
        Me.errAddCat.ContainerControl = Me
        '
        'selPic
        '
        Me.selPic.Filter = "Picture files(*.jpg)|*.jpg"
        Me.selPic.InitialDirectory = "C:\"
        '
        'frmAddCat
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(273, 154)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtCatName)
        Me.Controls.Add(Me.lblEnterName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddCat"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add a new category"
        CType(Me.errAddCat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEnterName As System.Windows.Forms.Label
    Friend WithEvents txtCatName As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents errAddCat As System.Windows.Forms.ErrorProvider
    Friend WithEvents selPic As System.Windows.Forms.OpenFileDialog
End Class
