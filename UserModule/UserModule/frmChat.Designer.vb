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
        Me.cmbCus = New System.Windows.Forms.ComboBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.txtMsg = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.lstMsgs = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'cmbCus
        '
        Me.cmbCus.FormattingEnabled = True
        Me.cmbCus.Location = New System.Drawing.Point(222, 380)
        Me.cmbCus.Name = "cmbCus"
        Me.cmbCus.Size = New System.Drawing.Size(43, 21)
        Me.cmbCus.TabIndex = 11
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(271, 404)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnCheck.TabIndex = 10
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'txtMsg
        '
        Me.txtMsg.Location = New System.Drawing.Point(91, 377)
        Me.txtMsg.Multiline = True
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.Size = New System.Drawing.Size(125, 44)
        Me.txtMsg.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 380)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Message:"
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(271, 375)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 7
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'lstMsgs
        '
        Me.lstMsgs.FormattingEnabled = True
        Me.lstMsgs.Location = New System.Drawing.Point(35, 13)
        Me.lstMsgs.Name = "lstMsgs"
        Me.lstMsgs.Size = New System.Drawing.Size(311, 329)
        Me.lstMsgs.TabIndex = 6
        '
        'frmChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 441)
        Me.Controls.Add(Me.cmbCus)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.txtMsg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.lstMsgs)
        Me.Name = "frmChat"
        Me.Text = "frmChat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbCus As System.Windows.Forms.ComboBox
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents txtMsg As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents lstMsgs As System.Windows.Forms.ListBox
End Class
