<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangePassword))
        Me.lblCurrentPwd = New System.Windows.Forms.Label()
        Me.lblNewPwd = New System.Windows.Forms.Label()
        Me.lblConfirmPwd = New System.Windows.Forms.Label()
        Me.txtCurrentPwd = New System.Windows.Forms.TextBox()
        Me.txtNewPwd = New System.Windows.Forms.TextBox()
        Me.txtConfirmPwd = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCurrentPwd
        '
        Me.lblCurrentPwd.AutoSize = True
        Me.lblCurrentPwd.Location = New System.Drawing.Point(23, 27)
        Me.lblCurrentPwd.Name = "lblCurrentPwd"
        Me.lblCurrentPwd.Size = New System.Drawing.Size(112, 16)
        Me.lblCurrentPwd.TabIndex = 0
        Me.lblCurrentPwd.Text = "Current password:"
        '
        'lblNewPwd
        '
        Me.lblNewPwd.AutoSize = True
        Me.lblNewPwd.Location = New System.Drawing.Point(23, 64)
        Me.lblNewPwd.Name = "lblNewPwd"
        Me.lblNewPwd.Size = New System.Drawing.Size(92, 16)
        Me.lblNewPwd.TabIndex = 1
        Me.lblNewPwd.Text = "New password:"
        '
        'lblConfirmPwd
        '
        Me.lblConfirmPwd.AutoSize = True
        Me.lblConfirmPwd.Location = New System.Drawing.Point(23, 104)
        Me.lblConfirmPwd.Name = "lblConfirmPwd"
        Me.lblConfirmPwd.Size = New System.Drawing.Size(113, 16)
        Me.lblConfirmPwd.TabIndex = 2
        Me.lblConfirmPwd.Text = "Confirm password:"
        '
        'txtCurrentPwd
        '
        Me.txtCurrentPwd.Location = New System.Drawing.Point(178, 24)
        Me.txtCurrentPwd.Name = "txtCurrentPwd"
        Me.txtCurrentPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCurrentPwd.Size = New System.Drawing.Size(173, 21)
        Me.txtCurrentPwd.TabIndex = 3
        '
        'txtNewPwd
        '
        Me.txtNewPwd.Location = New System.Drawing.Point(178, 61)
        Me.txtNewPwd.Name = "txtNewPwd"
        Me.txtNewPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPwd.Size = New System.Drawing.Size(173, 21)
        Me.txtNewPwd.TabIndex = 4
        '
        'txtConfirmPwd
        '
        Me.txtConfirmPwd.Location = New System.Drawing.Point(178, 101)
        Me.txtConfirmPwd.Name = "txtConfirmPwd"
        Me.txtConfirmPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPwd.Size = New System.Drawing.Size(173, 21)
        Me.txtConfirmPwd.TabIndex = 5
        '
        'btnOK
        '
        Me.btnOK.BackgroundImage = CType(resources.GetObject("btnOK.BackgroundImage"), System.Drawing.Image)
        Me.btnOK.Location = New System.Drawing.Point(100, 159)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(87, 40)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = CType(resources.GetObject("btnCancel.BackgroundImage"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(215, 159)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 40)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(421, 211)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtConfirmPwd)
        Me.Controls.Add(Me.txtNewPwd)
        Me.Controls.Add(Me.txtCurrentPwd)
        Me.Controls.Add(Me.lblConfirmPwd)
        Me.Controls.Add(Me.lblNewPwd)
        Me.Controls.Add(Me.lblCurrentPwd)
        Me.Font = New System.Drawing.Font("Ubuntu", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChangePassword"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCurrentPwd As System.Windows.Forms.Label
    Friend WithEvents lblNewPwd As System.Windows.Forms.Label
    Friend WithEvents lblConfirmPwd As System.Windows.Forms.Label
    Friend WithEvents txtCurrentPwd As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPwd As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirmPwd As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
