<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddItemToBill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddItemToBill))
        Me.grpSearchCriteria = New System.Windows.Forms.GroupBox()
        Me.txtString = New System.Windows.Forms.TextBox()
        Me.rbProdId = New System.Windows.Forms.RadioButton()
        Me.rbSrcName = New System.Windows.Forms.RadioButton()
        Me.errSearch = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.dgridSrcResults = New System.Windows.Forms.DataGridView()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.grpSearchCriteria.SuspendLayout()
        CType(Me.errSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgridSrcResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpSearchCriteria
        '
        Me.grpSearchCriteria.Controls.Add(Me.txtString)
        Me.grpSearchCriteria.Controls.Add(Me.rbProdId)
        Me.grpSearchCriteria.Controls.Add(Me.rbSrcName)
        Me.grpSearchCriteria.Location = New System.Drawing.Point(37, 12)
        Me.grpSearchCriteria.Name = "grpSearchCriteria"
        Me.grpSearchCriteria.Size = New System.Drawing.Size(355, 121)
        Me.grpSearchCriteria.TabIndex = 1
        Me.grpSearchCriteria.TabStop = False
        Me.grpSearchCriteria.Text = "Search Criteria"
        '
        'txtString
        '
        Me.txtString.Location = New System.Drawing.Point(28, 33)
        Me.txtString.Name = "txtString"
        Me.txtString.Size = New System.Drawing.Size(269, 20)
        Me.txtString.TabIndex = 0
        '
        'rbProdId
        '
        Me.rbProdId.AutoSize = True
        Me.rbProdId.Location = New System.Drawing.Point(175, 68)
        Me.rbProdId.Name = "rbProdId"
        Me.rbProdId.Size = New System.Drawing.Size(69, 17)
        Me.rbProdId.TabIndex = 3
        Me.rbProdId.Text = "Bar Code"
        Me.rbProdId.UseVisualStyleBackColor = True
        '
        'rbSrcName
        '
        Me.rbSrcName.AutoSize = True
        Me.rbSrcName.Checked = True
        Me.rbSrcName.Location = New System.Drawing.Point(53, 68)
        Me.rbSrcName.Name = "rbSrcName"
        Me.rbSrcName.Size = New System.Drawing.Size(53, 17)
        Me.rbSrcName.TabIndex = 2
        Me.rbSrcName.TabStop = True
        Me.rbSrcName.Text = "Name"
        Me.rbSrcName.UseVisualStyleBackColor = True
        '
        'errSearch
        '
        Me.errSearch.BlinkRate = 200
        Me.errSearch.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.errSearch.ContainerControl = Me
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = CType(resources.GetObject("btnCancel.BackgroundImage"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(455, 332)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(79, 31)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'dgridSrcResults
        '
        Me.dgridSrcResults.AllowUserToAddRows = False
        Me.dgridSrcResults.AllowUserToDeleteRows = False
        Me.dgridSrcResults.AllowUserToResizeColumns = False
        Me.dgridSrcResults.AllowUserToResizeRows = False
        Me.dgridSrcResults.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.dgridSrcResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridSrcResults.Location = New System.Drawing.Point(37, 150)
        Me.dgridSrcResults.MultiSelect = False
        Me.dgridSrcResults.Name = "dgridSrcResults"
        Me.dgridSrcResults.ReadOnly = True
        Me.dgridSrcResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgridSrcResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgridSrcResults.Size = New System.Drawing.Size(446, 138)
        Me.dgridSrcResults.TabIndex = 5
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.Location = New System.Drawing.Point(141, 350)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(204, 13)
        Me.lblNote.TabIndex = 7
        Me.lblNote.Text = "Double click on an item to add it to the bill"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(34, 310)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(49, 13)
        Me.lblQuantity.TabIndex = 8
        Me.lblQuantity.Text = "Quantity:"
        Me.lblQuantity.Visible = False
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(89, 307)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(53, 20)
        Me.txtQuantity.TabIndex = 9
        Me.txtQuantity.Visible = False
        '
        'btnOK
        '
        Me.btnOK.BackgroundImage = CType(resources.GetObject("btnOK.BackgroundImage"), System.Drawing.Image)
        Me.btnOK.Location = New System.Drawing.Point(370, 332)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(79, 31)
        Me.btnOK.TabIndex = 10
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmAddItemToBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(552, 378)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.dgridSrcResults)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.grpSearchCriteria)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddItemToBill"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add item to bill"
        Me.grpSearchCriteria.ResumeLayout(False)
        Me.grpSearchCriteria.PerformLayout()
        CType(Me.errSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgridSrcResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpSearchCriteria As System.Windows.Forms.GroupBox
    Friend WithEvents rbSrcName As System.Windows.Forms.RadioButton
    Friend WithEvents rbProdId As System.Windows.Forms.RadioButton
    Friend WithEvents errSearch As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtString As System.Windows.Forms.TextBox
    Friend WithEvents dgridSrcResults As System.Windows.Forms.DataGridView
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
End Class
