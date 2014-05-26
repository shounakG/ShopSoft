<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewRecords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewRecords))
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtCounter = New System.Windows.Forms.TextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnChangePwd = New System.Windows.Forms.Button()
        Me.picUser = New System.Windows.Forms.PictureBox()
        Me.txtSearchUser = New System.Windows.Forms.TextBox()
        Me.btnNext2 = New System.Windows.Forms.Button()
        Me.lblSearchUser = New System.Windows.Forms.Label()
        Me.picStopSearch = New System.Windows.Forms.PictureBox()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStopSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(29, 60)
        Me.lblUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(78, 17)
        Me.lblUser.TabIndex = 0
        Me.lblUser.Text = "User Name:"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(168, 57)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.ReadOnly = True
        Me.txtUser.Size = New System.Drawing.Size(160, 22)
        Me.txtUser.TabIndex = 2
        '
        'btnNext
        '
        Me.btnNext.BackgroundImage = Global.ShopSoft.My.Resources.Resources.back1
        Me.btnNext.Location = New System.Drawing.Point(279, 327)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(87, 37)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(168, 96)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtAddress.Size = New System.Drawing.Size(160, 69)
        Me.txtAddress.TabIndex = 6
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(29, 101)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(61, 17)
        Me.lblAddress.TabIndex = 7
        Me.lblAddress.Text = "Address:"
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Location = New System.Drawing.Point(29, 205)
        Me.lblContact.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(86, 17)
        Me.lblContact.TabIndex = 8
        Me.lblContact.Text = "Contact No.:"
        '
        'lblCounter
        '
        Me.lblCounter.AutoSize = True
        Me.lblCounter.Location = New System.Drawing.Point(29, 249)
        Me.lblCounter.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(87, 17)
        Me.lblCounter.TabIndex = 9
        Me.lblCounter.Text = "Counter No.:"
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(168, 200)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.ReadOnly = True
        Me.txtContact.Size = New System.Drawing.Size(160, 22)
        Me.txtContact.TabIndex = 10
        '
        'txtCounter
        '
        Me.txtCounter.Location = New System.Drawing.Point(168, 244)
        Me.txtCounter.Name = "txtCounter"
        Me.txtCounter.ReadOnly = True
        Me.txtCounter.Size = New System.Drawing.Size(160, 22)
        Me.txtCounter.TabIndex = 11
        '
        'btnEdit
        '
        Me.btnEdit.BackgroundImage = CType(resources.GetObject("btnEdit.BackgroundImage"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(372, 327)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(87, 37)
        Me.btnEdit.TabIndex = 13
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackgroundImage = CType(resources.GetObject("btnDelete.BackgroundImage"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(465, 327)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(87, 37)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnChangePwd
        '
        Me.btnChangePwd.BackgroundImage = CType(resources.GetObject("btnChangePwd.BackgroundImage"), System.Drawing.Image)
        Me.btnChangePwd.Location = New System.Drawing.Point(20, 327)
        Me.btnChangePwd.Name = "btnChangePwd"
        Me.btnChangePwd.Size = New System.Drawing.Size(136, 37)
        Me.btnChangePwd.TabIndex = 16
        Me.btnChangePwd.Text = "Change Password"
        Me.btnChangePwd.UseVisualStyleBackColor = True
        '
        'picUser
        '
        Me.picUser.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.picUser.ErrorImage = Nothing
        Me.picUser.Location = New System.Drawing.Point(383, 60)
        Me.picUser.Name = "picUser"
        Me.picUser.Size = New System.Drawing.Size(169, 206)
        Me.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUser.TabIndex = 15
        Me.picUser.TabStop = False
        '
        'txtSearchUser
        '
        Me.txtSearchUser.ForeColor = System.Drawing.Color.Black
        Me.txtSearchUser.Location = New System.Drawing.Point(168, 12)
        Me.txtSearchUser.Name = "txtSearchUser"
        Me.txtSearchUser.Size = New System.Drawing.Size(160, 22)
        Me.txtSearchUser.TabIndex = 17
        Me.txtSearchUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnNext2
        '
        Me.btnNext2.BackgroundImage = CType(resources.GetObject("btnNext2.BackgroundImage"), System.Drawing.Image)
        Me.btnNext2.Location = New System.Drawing.Point(279, 327)
        Me.btnNext2.Name = "btnNext2"
        Me.btnNext2.Size = New System.Drawing.Size(87, 37)
        Me.btnNext2.TabIndex = 18
        Me.btnNext2.Text = "Next"
        Me.btnNext2.UseVisualStyleBackColor = True
        Me.btnNext2.Visible = False
        '
        'lblSearchUser
        '
        Me.lblSearchUser.AutoSize = True
        Me.lblSearchUser.Location = New System.Drawing.Point(29, 17)
        Me.lblSearchUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSearchUser.Name = "lblSearchUser"
        Me.lblSearchUser.Size = New System.Drawing.Size(53, 17)
        Me.lblSearchUser.TabIndex = 19
        Me.lblSearchUser.Text = "Search:"
        '
        'picStopSearch
        '
        Me.picStopSearch.Image = CType(resources.GetObject("picStopSearch.Image"), System.Drawing.Image)
        Me.picStopSearch.Location = New System.Drawing.Point(334, 12)
        Me.picStopSearch.Name = "picStopSearch"
        Me.picStopSearch.Size = New System.Drawing.Size(34, 22)
        Me.picStopSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picStopSearch.TabIndex = 20
        Me.picStopSearch.TabStop = False
        Me.picStopSearch.Visible = False
        '
        'frmViewRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(570, 384)
        Me.Controls.Add(Me.picStopSearch)
        Me.Controls.Add(Me.lblSearchUser)
        Me.Controls.Add(Me.btnNext2)
        Me.Controls.Add(Me.txtSearchUser)
        Me.Controls.Add(Me.btnChangePwd)
        Me.Controls.Add(Me.picUser)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.txtCounter)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.lblCounter)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblUser)
        Me.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViewRecords"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "View User Records"
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStopSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblContact As System.Windows.Forms.Label
    Friend WithEvents lblCounter As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents txtCounter As System.Windows.Forms.TextBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents picUser As System.Windows.Forms.PictureBox
    Friend WithEvents btnChangePwd As System.Windows.Forms.Button
    Friend WithEvents txtSearchUser As System.Windows.Forms.TextBox
    Friend WithEvents btnNext2 As System.Windows.Forms.Button
    Friend WithEvents lblSearchUser As System.Windows.Forms.Label
    Friend WithEvents picStopSearch As System.Windows.Forms.PictureBox
End Class
