<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChat
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
        Me.lstMsgs = New System.Windows.Forms.ListBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMsg = New System.Windows.Forms.TextBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.cmbCus = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lstMsgs
        '
        Me.lstMsgs.FormattingEnabled = True
        Me.lstMsgs.Location = New System.Drawing.Point(12, 12)
        Me.lstMsgs.Name = "lstMsgs"
        Me.lstMsgs.Size = New System.Drawing.Size(311, 329)
        Me.lstMsgs.TabIndex = 0
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(248, 374)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 1
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 379)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Message:"
        '
        'txtMsg
        '
        Me.txtMsg.Location = New System.Drawing.Point(68, 376)
        Me.txtMsg.Multiline = True
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.Size = New System.Drawing.Size(125, 44)
        Me.txtMsg.TabIndex = 3
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(248, 403)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnCheck.TabIndex = 4
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'cmbCus
        '
        Me.cmbCus.FormattingEnabled = True
        Me.cmbCus.Location = New System.Drawing.Point(199, 379)
        Me.cmbCus.Name = "cmbCus"
        Me.cmbCus.Size = New System.Drawing.Size(43, 21)
        Me.cmbCus.TabIndex = 5
        '
        'frmChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 432)
        Me.Controls.Add(Me.cmbCus)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.txtMsg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.lstMsgs)
        Me.MaximizeBox = False
        Me.Name = "frmChat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmChat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstMsgs As System.Windows.Forms.ListBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMsg As System.Windows.Forms.TextBox
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents cmbCus As System.Windows.Forms.ComboBox
End Class
