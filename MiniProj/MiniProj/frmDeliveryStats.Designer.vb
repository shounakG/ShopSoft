<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeliveryStats
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeliveryStats))
        Me.dgridDelivery = New System.Windows.Forms.DataGridView()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnShowOnlyUndelivered = New System.Windows.Forms.CheckBox()
        Me.btnSpecificBill = New System.Windows.Forms.Button()
        CType(Me.dgridDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgridDelivery
        '
        Me.dgridDelivery.AllowUserToAddRows = False
        Me.dgridDelivery.AllowUserToDeleteRows = False
        Me.dgridDelivery.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dgridDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridDelivery.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.dgridDelivery.Location = New System.Drawing.Point(12, 59)
        Me.dgridDelivery.Name = "dgridDelivery"
        Me.dgridDelivery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgridDelivery.Size = New System.Drawing.Size(536, 358)
        Me.dgridDelivery.TabIndex = 0
        Me.dgridDelivery.Visible = False
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(373, 432)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(78, 36)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save status"
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = CType(resources.GetObject("btnCancel.BackgroundImage"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(470, 432)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(78, 36)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Exit"
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'btnPrint
        '
        Me.btnPrint.BackgroundImage = CType(resources.GetObject("btnPrint.BackgroundImage"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(271, 432)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(84, 36)
        Me.btnPrint.TabIndex = 5
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnShowOnlyUndelivered
        '
        Me.btnShowOnlyUndelivered.AutoSize = True
        Me.btnShowOnlyUndelivered.Location = New System.Drawing.Point(192, 25)
        Me.btnShowOnlyUndelivered.Name = "btnShowOnlyUndelivered"
        Me.btnShowOnlyUndelivered.Size = New System.Drawing.Size(153, 17)
        Me.btnShowOnlyUndelivered.TabIndex = 6
        Me.btnShowOnlyUndelivered.Text = "Show only undelivered bills"
        Me.btnShowOnlyUndelivered.UseVisualStyleBackColor = True
        '
        'btnSpecificBill
        '
        Me.btnSpecificBill.BackgroundImage = CType(resources.GetObject("btnSpecificBill.BackgroundImage"), System.Drawing.Image)
        Me.btnSpecificBill.Location = New System.Drawing.Point(12, 432)
        Me.btnSpecificBill.Name = "btnSpecificBill"
        Me.btnSpecificBill.Size = New System.Drawing.Size(84, 36)
        Me.btnSpecificBill.TabIndex = 7
        Me.btnSpecificBill.Text = "Print this bill"
        Me.btnSpecificBill.UseVisualStyleBackColor = True
        Me.btnSpecificBill.Visible = False
        '
        'frmDeliveryStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(560, 480)
        Me.Controls.Add(Me.btnSpecificBill)
        Me.Controls.Add(Me.btnShowOnlyUndelivered)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dgridDelivery)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDeliveryStats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delivery Status"
        CType(Me.dgridDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgridDelivery As System.Windows.Forms.DataGridView
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnShowOnlyUndelivered As System.Windows.Forms.CheckBox
    Friend WithEvents btnSpecificBill As System.Windows.Forms.Button
End Class
