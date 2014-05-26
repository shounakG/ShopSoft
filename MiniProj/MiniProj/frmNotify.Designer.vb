<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotify
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
        Me.lblNote = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.SuspendLayout()
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblNote.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote.Location = New System.Drawing.Point(41, 56)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(47, 20)
        Me.lblNote.TabIndex = 0
        Me.lblNote.Text = "Label1"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(309, 128)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'OvalShape1
        '
        Me.OvalShape1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.OvalShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.OvalShape1.FillColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.OvalShape1.FillGradientColor = System.Drawing.Color.DimGray
        Me.OvalShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape1.Location = New System.Drawing.Point(-66, 0)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(435, 147)
        '
        'frmNotify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(309, 128)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNotify"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmNotify"
        Me.TransparencyKey = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents OvalShape1 As Microsoft.VisualBasic.PowerPacks.OvalShape
End Class
