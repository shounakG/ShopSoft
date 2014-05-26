<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShopSelect
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
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.cbShopSelect = New System.Windows.Forms.ComboBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblManu = New System.Windows.Forms.Label()
        Me.lblChoose = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnProceed
        '
        Me.btnProceed.Enabled = False
        Me.btnProceed.Location = New System.Drawing.Point(46, 254)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(75, 23)
        Me.btnProceed.TabIndex = 0
        Me.btnProceed.Text = "Proceed"
        Me.btnProceed.UseVisualStyleBackColor = True
        Me.btnProceed.Visible = False
        '
        'cbShopSelect
        '
        Me.cbShopSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbShopSelect.FormattingEnabled = True
        Me.cbShopSelect.Items.AddRange(New Object() {"Eternity Mall", "Zansaar", "Happy Gift Shop"})
        Me.cbShopSelect.Location = New System.Drawing.Point(18, 156)
        Me.cbShopSelect.Name = "cbShopSelect"
        Me.cbShopSelect.Size = New System.Drawing.Size(121, 21)
        Me.cbShopSelect.TabIndex = 1
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(12, 228)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(140, 20)
        Me.txtAddress.TabIndex = 3
        Me.txtAddress.Text = "Enter Server Address"
        Me.txtAddress.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ShopSoft.My.Resources.Resources.splash
        Me.PictureBox1.Location = New System.Drawing.Point(164, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(375, 375)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'lblManu
        '
        Me.lblManu.AutoSize = True
        Me.lblManu.ForeColor = System.Drawing.Color.White
        Me.lblManu.Location = New System.Drawing.Point(43, 199)
        Me.lblManu.Name = "lblManu"
        Me.lblManu.Size = New System.Drawing.Size(118, 13)
        Me.lblManu.TabIndex = 5
        Me.lblManu.Text = "Enter Address Manually"
        '
        'lblChoose
        '
        Me.lblChoose.AutoSize = True
        Me.lblChoose.ForeColor = System.Drawing.Color.White
        Me.lblChoose.Location = New System.Drawing.Point(37, 121)
        Me.lblChoose.Name = "lblChoose"
        Me.lblChoose.Size = New System.Drawing.Size(84, 13)
        Me.lblChoose.TabIndex = 6
        Me.lblChoose.Text = "Choose A Shop!"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(46, 338)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmShopSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(525, 373)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblChoose)
        Me.Controls.Add(Me.lblManu)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.cbShopSelect)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmShopSelect"
        Me.Text = "ShopSoft"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnProceed As System.Windows.Forms.Button
    Friend WithEvents cbShopSelect As System.Windows.Forms.ComboBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblManu As System.Windows.Forms.Label
    Friend WithEvents lblChoose As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
