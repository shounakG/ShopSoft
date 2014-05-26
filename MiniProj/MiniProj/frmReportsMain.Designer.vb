<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportsMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportsMain))
        Me.btnBillReports = New System.Windows.Forms.Button()
        Me.btnStock = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBillReports
        '
        Me.btnBillReports.BackgroundImage = CType(resources.GetObject("btnBillReports.BackgroundImage"), System.Drawing.Image)
        Me.btnBillReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBillReports.Location = New System.Drawing.Point(45, 48)
        Me.btnBillReports.Name = "btnBillReports"
        Me.btnBillReports.Size = New System.Drawing.Size(183, 52)
        Me.btnBillReports.TabIndex = 0
        Me.btnBillReports.Text = "Print bill reports"
        Me.btnBillReports.UseVisualStyleBackColor = True
        '
        'btnStock
        '
        Me.btnStock.BackgroundImage = CType(resources.GetObject("btnStock.BackgroundImage"), System.Drawing.Image)
        Me.btnStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnStock.Location = New System.Drawing.Point(45, 106)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Size = New System.Drawing.Size(183, 52)
        Me.btnStock.TabIndex = 1
        Me.btnStock.Text = "Perform stock"
        Me.btnStock.UseVisualStyleBackColor = True
        '
        'btnCustomer
        '
        Me.btnCustomer.BackgroundImage = CType(resources.GetObject("btnCustomer.BackgroundImage"), System.Drawing.Image)
        Me.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCustomer.Location = New System.Drawing.Point(45, 164)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(183, 52)
        Me.btnCustomer.TabIndex = 2
        Me.btnCustomer.Text = "View and print customer details"
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'frmReportsMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(273, 262)
        Me.Controls.Add(Me.btnCustomer)
        Me.Controls.Add(Me.btnStock)
        Me.Controls.Add(Me.btnBillReports)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReportsMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Reports"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBillReports As System.Windows.Forms.Button
    Friend WithEvents btnStock As System.Windows.Forms.Button
    Friend WithEvents btnCustomer As System.Windows.Forms.Button
End Class
