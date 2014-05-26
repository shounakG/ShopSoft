<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForgotPass
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
        Me.lblHow = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.rbEmail = New System.Windows.Forms.RadioButton()
        Me.rbDOB = New System.Windows.Forms.RadioButton()
        Me.picMainLogo = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picMainLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHow
        '
        Me.lblHow.AutoSize = True
        Me.lblHow.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHow.Location = New System.Drawing.Point(79, 87)
        Me.lblHow.Name = "lblHow"
        Me.lblHow.Size = New System.Drawing.Size(169, 24)
        Me.lblHow.TabIndex = 0
        Me.lblHow.Text = "Recovey Options"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(190, 167)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtUsername.TabIndex = 4
        Me.txtUsername.Text = "Username"
        Me.txtUsername.Visible = False
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(31, 165)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 5
        Me.txtEmail.Text = "Enter Your Email"
        Me.txtEmail.Visible = False
        '
        'rbEmail
        '
        Me.rbEmail.AutoSize = True
        Me.rbEmail.Location = New System.Drawing.Point(31, 132)
        Me.rbEmail.Name = "rbEmail"
        Me.rbEmail.Size = New System.Drawing.Size(50, 17)
        Me.rbEmail.TabIndex = 8
        Me.rbEmail.TabStop = True
        Me.rbEmail.Text = "Email"
        Me.rbEmail.UseVisualStyleBackColor = True
        '
        'rbDOB
        '
        Me.rbDOB.AutoSize = True
        Me.rbDOB.Location = New System.Drawing.Point(190, 132)
        Me.rbDOB.Name = "rbDOB"
        Me.rbDOB.Size = New System.Drawing.Size(86, 17)
        Me.rbDOB.TabIndex = 9
        Me.rbDOB.TabStop = True
        Me.rbDOB.Text = "Specify DOB"
        Me.rbDOB.UseVisualStyleBackColor = True
        '
        'picMainLogo
        '
        Me.picMainLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.picMainLogo.Image = Global.ShopSoft.My.Resources.Resources.logo
        Me.picMainLogo.Location = New System.Drawing.Point(12, 12)
        Me.picMainLogo.Name = "picMainLogo"
        Me.picMainLogo.Size = New System.Drawing.Size(119, 48)
        Me.picMainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMainLogo.TabIndex = 25
        Me.picMainLogo.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(345, 72)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(68, 313)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 27
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(173, 313)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 28
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(190, 216)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 20)
        Me.txtDate.TabIndex = 29
        Me.txtDate.Text = "DOB"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(251, 249)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "DD-MM-YY"
        '
        'frmForgotPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(345, 363)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblHow)
        Me.Controls.Add(Me.picMainLogo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.rbDOB)
        Me.Controls.Add(Me.rbEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtUsername)
        Me.Name = "frmForgotPass"
        Me.Tag = "DOB"
        Me.Text = "Password Recovery"
        CType(Me.picMainLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHow As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents rbEmail As System.Windows.Forms.RadioButton
    Friend WithEvents rbDOB As System.Windows.Forms.RadioButton
    Friend WithEvents picMainLogo As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
