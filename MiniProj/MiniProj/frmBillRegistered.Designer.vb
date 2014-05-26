<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBillRegistered
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBillRegistered))
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.lblEnterUserID = New System.Windows.Forms.Label()
        Me.dtBillDate = New System.Windows.Forms.DateTimePicker()
        Me.dgridBillDetails = New System.Windows.Forms.DataGridView()
        Me.colItemNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.errTxtUser = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnCancelBill = New System.Windows.Forms.Button()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.btnSelectID = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.dgridBillDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errTxtUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(121, 12)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(100, 20)
        Me.txtUserID.TabIndex = 9
        '
        'lblEnterUserID
        '
        Me.lblEnterUserID.AutoSize = True
        Me.lblEnterUserID.Location = New System.Drawing.Point(28, 15)
        Me.lblEnterUserID.Name = "lblEnterUserID"
        Me.lblEnterUserID.Size = New System.Drawing.Size(71, 26)
        Me.lblEnterUserID.TabIndex = 100
        Me.lblEnterUserID.Text = "Enter User ID" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(1 for guest):"
        '
        'dtBillDate
        '
        Me.dtBillDate.Enabled = False
        Me.dtBillDate.Location = New System.Drawing.Point(393, 15)
        Me.dtBillDate.Name = "dtBillDate"
        Me.dtBillDate.Size = New System.Drawing.Size(133, 20)
        Me.dtBillDate.TabIndex = 2
        '
        'dgridBillDetails
        '
        Me.dgridBillDetails.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dgridBillDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridBillDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colItemNo})
        Me.dgridBillDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgridBillDetails.Location = New System.Drawing.Point(31, 52)
        Me.dgridBillDetails.Name = "dgridBillDetails"
        Me.dgridBillDetails.Size = New System.Drawing.Size(524, 306)
        Me.dgridBillDetails.TabIndex = 3
        Me.dgridBillDetails.Visible = False
        '
        'colItemNo
        '
        Me.colItemNo.HeaderText = "Item No"
        Me.colItemNo.Name = "colItemNo"
        Me.colItemNo.ReadOnly = True
        '
        'btnAddItem
        '
        Me.btnAddItem.BackgroundImage = CType(resources.GetObject("btnAddItem.BackgroundImage"), System.Drawing.Image)
        Me.btnAddItem.Location = New System.Drawing.Point(364, 402)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(86, 32)
        Me.btnAddItem.TabIndex = 0
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        Me.btnAddItem.Visible = False
        '
        'errTxtUser
        '
        Me.errTxtUser.BlinkRate = 200
        Me.errTxtUser.ContainerControl = Me
        '
        'btnCancelBill
        '
        Me.btnCancelBill.BackgroundImage = CType(resources.GetObject("btnCancelBill.BackgroundImage"), System.Drawing.Image)
        Me.btnCancelBill.Location = New System.Drawing.Point(469, 402)
        Me.btnCancelBill.Name = "btnCancelBill"
        Me.btnCancelBill.Size = New System.Drawing.Size(86, 32)
        Me.btnCancelBill.TabIndex = 10
        Me.btnCancelBill.Text = "Cancel Bill"
        Me.btnCancelBill.UseVisualStyleBackColor = True
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.Location = New System.Drawing.Point(151, 412)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(154, 13)
        Me.lblNote.TabIndex = 11
        Me.lblNote.Text = "To add items, press Return key"
        '
        'btnSelectID
        '
        Me.btnSelectID.BackgroundImage = Global.ShopSoft.My.Resources.Resources.back1
        Me.btnSelectID.Location = New System.Drawing.Point(242, 12)
        Me.btnSelectID.Name = "btnSelectID"
        Me.btnSelectID.Size = New System.Drawing.Size(31, 23)
        Me.btnSelectID.TabIndex = 1
        Me.btnSelectID.Text = "OK"
        Me.btnSelectID.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(31, 402)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(82, 32)
        Me.btnSave.TabIndex = 101
        Me.btnSave.Text = "Save Bill"
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'frmBillRegistered
        '
        Me.AcceptButton = Me.btnAddItem
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(575, 446)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnSelectID)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.btnCancelBill)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.dgridBillDetails)
        Me.Controls.Add(Me.dtBillDate)
        Me.Controls.Add(Me.lblEnterUserID)
        Me.Controls.Add(Me.txtUserID)
        Me.Name = "frmBillRegistered"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bill fill-up window"
        CType(Me.dgridBillDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errTxtUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents lblEnterUserID As System.Windows.Forms.Label
    Friend WithEvents dtBillDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgridBillDetails As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents colItemNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents errTxtUser As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnCancelBill As System.Windows.Forms.Button
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents btnSelectID As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
