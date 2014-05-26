<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddSubCat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddSubCat))
        Me.txtSubCatName = New System.Windows.Forms.TextBox()
        Me.errSubCat = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblSubCatName = New System.Windows.Forms.Label()
        Me.txtCat = New System.Windows.Forms.ComboBox()
        Me.lblSelCat = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.selPic = New System.Windows.Forms.OpenFileDialog()
        CType(Me.errSubCat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSubCatName
        '
        Me.txtSubCatName.Location = New System.Drawing.Point(31, 54)
        Me.txtSubCatName.Name = "txtSubCatName"
        Me.txtSubCatName.Size = New System.Drawing.Size(209, 20)
        Me.txtSubCatName.TabIndex = 0
        '
        'errSubCat
        '
        Me.errSubCat.ContainerControl = Me
        '
        'lblSubCatName
        '
        Me.lblSubCatName.AutoSize = True
        Me.lblSubCatName.Location = New System.Drawing.Point(56, 27)
        Me.lblSubCatName.Name = "lblSubCatName"
        Me.lblSubCatName.Size = New System.Drawing.Size(155, 13)
        Me.lblSubCatName.TabIndex = 1
        Me.lblSubCatName.Text = "Enter the name of sub-category"
        '
        'txtCat
        '
        Me.txtCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtCat.FormattingEnabled = True
        Me.txtCat.Location = New System.Drawing.Point(31, 123)
        Me.txtCat.Name = "txtCat"
        Me.txtCat.Size = New System.Drawing.Size(209, 21)
        Me.txtCat.Sorted = True
        Me.txtCat.TabIndex = 2
        '
        'lblSelCat
        '
        Me.lblSelCat.AutoSize = True
        Me.lblSelCat.Location = New System.Drawing.Point(82, 98)
        Me.lblSelCat.Name = "lblSelCat"
        Me.lblSelCat.Size = New System.Drawing.Size(99, 13)
        Me.lblSelCat.TabIndex = 3
        Me.lblSelCat.Text = "Select the category"
        '
        'btnOK
        '
        Me.btnOK.BackgroundImage = CType(resources.GetObject("btnOK.BackgroundImage"), System.Drawing.Image)
        Me.btnOK.Location = New System.Drawing.Point(46, 192)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 37)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "Add"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = CType(resources.GetObject("btnCancel.BackgroundImage"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(155, 192)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 37)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'selPic
        '
        Me.selPic.Filter = "Picture files(*.jpg)|*.jpg"
        Me.selPic.InitialDirectory = "C:\"
        '
        'frmAddSubCat
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(263, 233)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblSelCat)
        Me.Controls.Add(Me.txtCat)
        Me.Controls.Add(Me.lblSubCatName)
        Me.Controls.Add(Me.txtSubCatName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddSubCat"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add new sub-category"
        CType(Me.errSubCat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSubCatName As System.Windows.Forms.TextBox
    Friend WithEvents errSubCat As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblSubCatName As System.Windows.Forms.Label
    Friend WithEvents txtCat As System.Windows.Forms.ComboBox
    Friend WithEvents lblSelCat As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents selPic As System.Windows.Forms.OpenFileDialog
End Class
