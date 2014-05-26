<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewPass
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
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtRepPass = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblRep = New System.Windows.Forms.Label()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(121, 65)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 0
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtRepPass
        '
        Me.txtRepPass.Location = New System.Drawing.Point(121, 106)
        Me.txtRepPass.Name = "txtRepPass"
        Me.txtRepPass.Size = New System.Drawing.Size(100, 20)
        Me.txtRepPass.TabIndex = 1
        Me.txtRepPass.UseSystemPasswordChar = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(12, 68)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(78, 13)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "New Password"
        '
        'lblRep
        '
        Me.lblRep.AutoSize = True
        Me.lblRep.Location = New System.Drawing.Point(14, 109)
        Me.lblRep.Name = "lblRep"
        Me.lblRep.Size = New System.Drawing.Size(91, 13)
        Me.lblRep.TabIndex = 3
        Me.lblRep.Text = "Repeat Password"
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(81, 149)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 23)
        Me.btnDone.TabIndex = 4
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'frmNewPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(248, 202)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.lblRep)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtRepPass)
        Me.Controls.Add(Me.txtPassword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(100, 300)
        Me.Name = "frmNewPass"
        Me.Text = "Password Change"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtRepPass As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblRep As System.Windows.Forms.Label
    Friend WithEvents btnDone As System.Windows.Forms.Button
End Class
