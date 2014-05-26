<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnMainHome = New System.Windows.Forms.PictureBox()
        Me.picMainTopBand = New System.Windows.Forms.PictureBox()
        Me.lblMainTop = New System.Windows.Forms.Label()
        Me.txtSearchMain = New System.Windows.Forms.TextBox()
        Me.btnMainSearch = New System.Windows.Forms.Button()
        Me.tvMain = New System.Windows.Forms.TreeView()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.btnMainHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMainTopBand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMainHome
        '
        Me.btnMainHome.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnMainHome.ErrorImage = CType(resources.GetObject("btnMainHome.ErrorImage"), System.Drawing.Image)
        Me.btnMainHome.Image = CType(resources.GetObject("btnMainHome.Image"), System.Drawing.Image)
        Me.btnMainHome.Location = New System.Drawing.Point(12, 12)
        Me.btnMainHome.Name = "btnMainHome"
        Me.btnMainHome.Size = New System.Drawing.Size(53, 45)
        Me.btnMainHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMainHome.TabIndex = 1
        Me.btnMainHome.TabStop = False
        '
        'picMainTopBand
        '
        Me.picMainTopBand.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.picMainTopBand.Enabled = False
        Me.picMainTopBand.Location = New System.Drawing.Point(1, 0)
        Me.picMainTopBand.Name = "picMainTopBand"
        Me.picMainTopBand.Size = New System.Drawing.Size(908, 63)
        Me.picMainTopBand.TabIndex = 2
        Me.picMainTopBand.TabStop = False
        '
        'lblMainTop
        '
        Me.lblMainTop.AutoSize = True
        Me.lblMainTop.Location = New System.Drawing.Point(83, 29)
        Me.lblMainTop.Name = "lblMainTop"
        Me.lblMainTop.Size = New System.Drawing.Size(58, 13)
        Me.lblMainTop.TabIndex = 3
        Me.lblMainTop.Text = "Easy Shop"
        '
        'txtSearchMain
        '
        Me.txtSearchMain.Location = New System.Drawing.Point(238, 77)
        Me.txtSearchMain.Name = "txtSearchMain"
        Me.txtSearchMain.Size = New System.Drawing.Size(225, 20)
        Me.txtSearchMain.TabIndex = 4
        Me.txtSearchMain.Text = "Search for Products"
        '
        'btnMainSearch
        '
        Me.btnMainSearch.Location = New System.Drawing.Point(499, 77)
        Me.btnMainSearch.Name = "btnMainSearch"
        Me.btnMainSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnMainSearch.TabIndex = 5
        Me.btnMainSearch.Text = "Search"
        Me.btnMainSearch.UseVisualStyleBackColor = True
        '
        'tvMain
        '
        Me.tvMain.Location = New System.Drawing.Point(1, 63)
        Me.tvMain.Name = "tvMain"
        Me.tvMain.Size = New System.Drawing.Size(185, 438)
        Me.tvMain.TabIndex = 6
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 499)
        Me.Controls.Add(Me.btnMainSearch)
        Me.Controls.Add(Me.txtSearchMain)
        Me.Controls.Add(Me.lblMainTop)
        Me.Controls.Add(Me.btnMainHome)
        Me.Controls.Add(Me.picMainTopBand)
        Me.Controls.Add(Me.tvMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Home"
        CType(Me.btnMainHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMainTopBand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMainHome As System.Windows.Forms.PictureBox
    Friend WithEvents picMainTopBand As System.Windows.Forms.PictureBox
    Friend WithEvents lblMainTop As System.Windows.Forms.Label
    Friend WithEvents txtSearchMain As System.Windows.Forms.TextBox
    Friend WithEvents btnMainSearch As System.Windows.Forms.Button
    Friend WithEvents tvMain As System.Windows.Forms.TreeView
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
