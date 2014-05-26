<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplash))
        Me.pbWelcome = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbWelcome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbWelcome
        '
        Me.pbWelcome.BackColor = System.Drawing.Color.Transparent
        Me.pbWelcome.Image = CType(resources.GetObject("pbWelcome.Image"), System.Drawing.Image)
        Me.pbWelcome.Location = New System.Drawing.Point(-4, -1)
        Me.pbWelcome.Margin = New System.Windows.Forms.Padding(0)
        Me.pbWelcome.Name = "pbWelcome"
        Me.pbWelcome.Size = New System.Drawing.Size(507, 498)
        Me.pbWelcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbWelcome.TabIndex = 0
        Me.pbWelcome.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 496)
        Me.Controls.Add(Me.pbWelcome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.pbWelcome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbWelcome As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
