<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuy
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
        Me.lblThanks = New System.Windows.Forms.Label()
        Me.lblShopMore = New System.Windows.Forms.Button()
        Me.lblExitFinal = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblThanks
        '
        Me.lblThanks.AutoSize = True
        Me.lblThanks.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThanks.Location = New System.Drawing.Point(19, 40)
        Me.lblThanks.Name = "lblThanks"
        Me.lblThanks.Size = New System.Drawing.Size(274, 25)
        Me.lblThanks.TabIndex = 2
        Me.lblThanks.Text = "Thank You for Shopping!"
        '
        'lblShopMore
        '
        Me.lblShopMore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShopMore.Location = New System.Drawing.Point(24, 205)
        Me.lblShopMore.Name = "lblShopMore"
        Me.lblShopMore.Size = New System.Drawing.Size(75, 23)
        Me.lblShopMore.TabIndex = 4
        Me.lblShopMore.Tag = ""
        Me.lblShopMore.Text = "Shop More"
        Me.lblShopMore.UseVisualStyleBackColor = True
        '
        'lblExitFinal
        '
        Me.lblExitFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExitFinal.Location = New System.Drawing.Point(218, 205)
        Me.lblExitFinal.Name = "lblExitFinal"
        Me.lblExitFinal.Size = New System.Drawing.Size(75, 23)
        Me.lblExitFinal.TabIndex = 5
        Me.lblExitFinal.Text = "Exit"
        Me.lblExitFinal.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ShopSoft.My.Resources.Resources.COD
        Me.PictureBox1.Location = New System.Drawing.Point(24, 89)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(269, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'frmBuy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(305, 259)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblExitFinal)
        Me.Controls.Add(Me.lblShopMore)
        Me.Controls.Add(Me.lblThanks)
        Me.Name = "frmBuy"
        Me.Text = "All Done!"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblThanks As System.Windows.Forms.Label
    Friend WithEvents lblShopMore As System.Windows.Forms.Button
    Friend WithEvents lblExitFinal As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
