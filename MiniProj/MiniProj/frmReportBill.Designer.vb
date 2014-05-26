<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportBill
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
        Me.grpByDate = New System.Windows.Forms.GroupBox()
        Me.grpByNumber = New System.Windows.Forms.GroupBox()
        Me.txtToNumber = New System.Windows.Forms.TextBox()
        Me.txtFromNumber = New System.Windows.Forms.TextBox()
        Me.lblToNumber = New System.Windows.Forms.Label()
        Me.lblFromNo = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.grpByDate.SuspendLayout()
        Me.grpByNumber.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpByDate
        '
        Me.grpByDate.Controls.Add(Me.cmbMonth)
        Me.grpByDate.Enabled = False
        Me.grpByDate.Location = New System.Drawing.Point(18, 144)
        Me.grpByDate.Name = "grpByDate"
        Me.grpByDate.Size = New System.Drawing.Size(288, 89)
        Me.grpByDate.TabIndex = 0
        Me.grpByDate.TabStop = False
        Me.grpByDate.Text = "Monthly"
        '
        'grpByNumber
        '
        Me.grpByNumber.Controls.Add(Me.txtToNumber)
        Me.grpByNumber.Controls.Add(Me.txtFromNumber)
        Me.grpByNumber.Controls.Add(Me.lblToNumber)
        Me.grpByNumber.Controls.Add(Me.lblFromNo)
        Me.grpByNumber.Location = New System.Drawing.Point(18, 25)
        Me.grpByNumber.Name = "grpByNumber"
        Me.grpByNumber.Size = New System.Drawing.Size(288, 100)
        Me.grpByNumber.TabIndex = 1
        Me.grpByNumber.TabStop = False
        Me.grpByNumber.Text = "By Bill Number"
        '
        'txtToNumber
        '
        Me.txtToNumber.Location = New System.Drawing.Point(142, 58)
        Me.txtToNumber.Name = "txtToNumber"
        Me.txtToNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtToNumber.TabIndex = 10
        '
        'txtFromNumber
        '
        Me.txtFromNumber.Location = New System.Drawing.Point(142, 25)
        Me.txtFromNumber.Name = "txtFromNumber"
        Me.txtFromNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtFromNumber.TabIndex = 9
        '
        'lblToNumber
        '
        Me.lblToNumber.AutoSize = True
        Me.lblToNumber.Location = New System.Drawing.Point(36, 65)
        Me.lblToNumber.Name = "lblToNumber"
        Me.lblToNumber.Size = New System.Drawing.Size(61, 13)
        Me.lblToNumber.TabIndex = 8
        Me.lblToNumber.Text = "To number:"
        '
        'lblFromNo
        '
        Me.lblFromNo.AutoSize = True
        Me.lblFromNo.Location = New System.Drawing.Point(36, 32)
        Me.lblFromNo.Name = "lblFromNo"
        Me.lblFromNo.Size = New System.Drawing.Size(71, 13)
        Me.lblFromNo.TabIndex = 7
        Me.lblFromNo.Text = "From number:"
        '
        'btnGo
        '
        Me.btnGo.BackgroundImage = Global.ShopSoft.My.Resources.Resources.back1
        Me.btnGo.Location = New System.Drawing.Point(230, 280)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(76, 38)
        Me.btnGo.TabIndex = 2
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'cmbMonth
        '
        Me.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbMonth.Location = New System.Drawing.Point(84, 34)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(121, 21)
        Me.cmbMonth.TabIndex = 0
        '
        'frmReportBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(328, 330)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.grpByNumber)
        Me.Controls.Add(Me.grpByDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReportBill"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print bill report"
        Me.grpByDate.ResumeLayout(False)
        Me.grpByNumber.ResumeLayout(False)
        Me.grpByNumber.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpByDate As System.Windows.Forms.GroupBox
    Friend WithEvents grpByNumber As System.Windows.Forms.GroupBox
    Friend WithEvents lblToNumber As System.Windows.Forms.Label
    Friend WithEvents lblFromNo As System.Windows.Forms.Label
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents txtToNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtFromNumber As System.Windows.Forms.TextBox
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
End Class
