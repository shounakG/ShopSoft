<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaps
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
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.lblStreet = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblZipCode = New System.Windows.Forms.Label()
        Me.btnSearchMaps = New System.Windows.Forms.Button()
        Me.lblLat = New System.Windows.Forms.Label()
        Me.lblLon = New System.Windows.Forms.Label()
        Me.txtlat = New System.Windows.Forms.TextBox()
        Me.txtlong = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 223)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(952, 635)
        Me.WebBrowser1.TabIndex = 0
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(125, 33)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(100, 20)
        Me.txtStreet.TabIndex = 5
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(125, 62)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(100, 20)
        Me.txtCity.TabIndex = 6
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(125, 91)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(100, 20)
        Me.txtState.TabIndex = 7
        '
        'txtZipCode
        '
        Me.txtZipCode.Location = New System.Drawing.Point(125, 120)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(100, 20)
        Me.txtZipCode.TabIndex = 8
        '
        'lblStreet
        '
        Me.lblStreet.AutoSize = True
        Me.lblStreet.Location = New System.Drawing.Point(264, 33)
        Me.lblStreet.Name = "lblStreet"
        Me.lblStreet.Size = New System.Drawing.Size(35, 13)
        Me.lblStreet.TabIndex = 9
        Me.lblStreet.Text = "Street"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(264, 62)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(24, 13)
        Me.lblCity.TabIndex = 10
        Me.lblCity.Text = "City"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(264, 91)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(32, 13)
        Me.lblState.TabIndex = 11
        Me.lblState.Text = "State"
        '
        'lblZipCode
        '
        Me.lblZipCode.AutoSize = True
        Me.lblZipCode.Location = New System.Drawing.Point(264, 120)
        Me.lblZipCode.Name = "lblZipCode"
        Me.lblZipCode.Size = New System.Drawing.Size(47, 13)
        Me.lblZipCode.TabIndex = 12
        Me.lblZipCode.Text = "ZipCode"
        '
        'btnSearchMaps
        '
        Me.btnSearchMaps.Location = New System.Drawing.Point(463, 28)
        Me.btnSearchMaps.Name = "btnSearchMaps"
        Me.btnSearchMaps.Size = New System.Drawing.Size(123, 23)
        Me.btnSearchMaps.TabIndex = 13
        Me.btnSearchMaps.Text = "Search Maps"
        Me.btnSearchMaps.UseVisualStyleBackColor = True
        '
        'lblLat
        '
        Me.lblLat.AutoSize = True
        Me.lblLat.Location = New System.Drawing.Point(264, 158)
        Me.lblLat.Name = "lblLat"
        Me.lblLat.Size = New System.Drawing.Size(39, 13)
        Me.lblLat.TabIndex = 14
        Me.lblLat.Text = "Label1"
        '
        'lblLon
        '
        Me.lblLon.AutoSize = True
        Me.lblLon.Location = New System.Drawing.Point(264, 187)
        Me.lblLon.Name = "lblLon"
        Me.lblLon.Size = New System.Drawing.Size(39, 13)
        Me.lblLon.TabIndex = 15
        Me.lblLon.Text = "Label2"
        '
        'txtlat
        '
        Me.txtlat.Location = New System.Drawing.Point(125, 158)
        Me.txtlat.Name = "txtlat"
        Me.txtlat.Size = New System.Drawing.Size(100, 20)
        Me.txtlat.TabIndex = 16
        '
        'txtlong
        '
        Me.txtlong.Location = New System.Drawing.Point(125, 187)
        Me.txtlong.Name = "txtlong"
        Me.txtlong.Size = New System.Drawing.Size(100, 20)
        Me.txtlong.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(447, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmMaps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(816, 750)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtlong)
        Me.Controls.Add(Me.txtlat)
        Me.Controls.Add(Me.lblLon)
        Me.Controls.Add(Me.lblLat)
        Me.Controls.Add(Me.btnSearchMaps)
        Me.Controls.Add(Me.lblZipCode)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblStreet)
        Me.Controls.Add(Me.txtZipCode)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtStreet)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Name = "frmMaps"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents txtStreet As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtZipCode As System.Windows.Forms.TextBox
    Friend WithEvents lblStreet As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblZipCode As System.Windows.Forms.Label
    Friend WithEvents btnSearchMaps As System.Windows.Forms.Button
    Friend WithEvents lblLat As System.Windows.Forms.Label
    Friend WithEvents lblLon As System.Windows.Forms.Label
    Friend WithEvents txtlat As System.Windows.Forms.TextBox
    Friend WithEvents txtlong As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
