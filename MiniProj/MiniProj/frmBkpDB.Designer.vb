<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBkpDB
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
        Me.dbPath = New System.Windows.Forms.SaveFileDialog()
        Me.txtFilename = New System.Windows.Forms.TextBox()
        Me.lblFilename = New System.Windows.Forms.Label()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dbPath
        '
        Me.dbPath.Filter = "Database files(*.mdb)|*.mdb"
        '
        'txtFilename
        '
        Me.txtFilename.Location = New System.Drawing.Point(92, 49)
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.ReadOnly = True
        Me.txtFilename.Size = New System.Drawing.Size(173, 20)
        Me.txtFilename.TabIndex = 1
        '
        'lblFilename
        '
        Me.lblFilename.AutoSize = True
        Me.lblFilename.Location = New System.Drawing.Point(19, 52)
        Me.lblFilename.Name = "lblFilename"
        Me.lblFilename.Size = New System.Drawing.Size(52, 13)
        Me.lblFilename.TabIndex = 3
        Me.lblFilename.Text = "Filename:"
        '
        'btnCopy
        '
        Me.btnCopy.BackgroundImage = Global.ShopSoft.My.Resources.Resources.back1
        Me.btnCopy.Location = New System.Drawing.Point(105, 111)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(75, 23)
        Me.btnCopy.TabIndex = 4
        Me.btnCopy.Text = "OK"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'frmBkpDB
        '
        Me.AcceptButton = Me.btnCopy
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(284, 175)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.lblFilename)
        Me.Controls.Add(Me.txtFilename)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBkpDB"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Perform database backup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dbPath As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txtFilename As System.Windows.Forms.TextBox
    Friend WithEvents lblFilename As System.Windows.Forms.Label
    Friend WithEvents btnCopy As System.Windows.Forms.Button
End Class
