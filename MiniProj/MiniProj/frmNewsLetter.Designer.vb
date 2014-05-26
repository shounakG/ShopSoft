<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewsLetter
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
        Me.rtfBody = New System.Windows.Forms.RichTextBox()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.lblSub = New System.Windows.Forms.Label()
        Me.lblBody = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rtfBody
        '
        Me.rtfBody.Location = New System.Drawing.Point(12, 91)
        Me.rtfBody.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.rtfBody.Name = "rtfBody"
        Me.rtfBody.Size = New System.Drawing.Size(492, 361)
        Me.rtfBody.TabIndex = 1
        Me.rtfBody.Text = ""
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(86, 35)
        Me.txtSubject.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(272, 20)
        Me.txtSubject.TabIndex = 0
        '
        'lblSub
        '
        Me.lblSub.AutoSize = True
        Me.lblSub.Location = New System.Drawing.Point(12, 42)
        Me.lblSub.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSub.Name = "lblSub"
        Me.lblSub.Size = New System.Drawing.Size(46, 13)
        Me.lblSub.TabIndex = 2
        Me.lblSub.Text = "Subject:"
        '
        'lblBody
        '
        Me.lblBody.AutoSize = True
        Me.lblBody.Location = New System.Drawing.Point(12, 75)
        Me.lblBody.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBody.Name = "lblBody"
        Me.lblBody.Size = New System.Drawing.Size(34, 13)
        Me.lblBody.TabIndex = 3
        Me.lblBody.Text = "Body:"
        '
        'btnOK
        '
        Me.btnOK.BackgroundImage = Global.ShopSoft.My.Resources.Resources.back1
        Me.btnOK.Location = New System.Drawing.Point(421, 469)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(84, 33)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmNewsLetter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(517, 513)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblBody)
        Me.Controls.Add(Me.lblSub)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.rtfBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewsLetter"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Send a newsletter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtfBody As System.Windows.Forms.RichTextBox
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents lblSub As System.Windows.Forms.Label
    Friend WithEvents lblBody As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
End Class
