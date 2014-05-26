Imports MySql.Data.MySqlClient
Public Class frmItems
    Dim loc As Point


    Private Sub frmItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        frmItemsSearch.Dispose()
        frmCatBrowse.Dispose()
        frmSubCat.Dispose()
        Me.Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)

        Me.MdiParent = frmMain
        Dim dbadapter As Mysql.data.mysqlclient.mysqldataadapter
        Dim dbtable As New DataTable
        dbtable.Clear()
        connect()
        dbadapter = New Mysql.data.mysqlclient.mysqldataadapter("Select all * from tblProductDetails where ProductID in (Select ProductID from tblProducts where SubCatID in (Select SubCatID from tblSubCat where SubCatName = '" & subcat & "'));", dbConnection)
        dbadapter.Fill(dbtable)
        dbConnection.Close()
        Dim i As Integer = 50
        Dim j As Integer = 50

        For Each dRow In dbtable.Rows
            Dim pbProduct As New PictureBox
            With pbProduct
                .Name = ("pic")
                On Error Resume Next
                .Image = getPicture(dRow.item(7))
                .Location = New System.Drawing.Point(i, j)
                .Size = New Size(90, 90)
                .Enabled = True
                .SizeMode = PictureBoxSizeMode.Zoom
                .BackColor = Color.Transparent

            End With

            Me.Controls.Add(pbProduct)
            Dim btnProduct As New Button
            With btnProduct
                .Name = (dRow.item(1))
                .Location = New System.Drawing.Point(i + 10, j + 95)
                .Text = (dRow.item(1))
                .Enabled = True
                .TextAlign = ContentAlignment.MiddleCenter
                .BackColor = Color.Transparent
                ToolTip1.SetToolTip(btnProduct, dRow.item(1))
            End With
            AddHandler btnProduct.Click, AddressOf btn_Click
            AddHandler btnProduct.MouseEnter, AddressOf btn_MouseEnter
            AddHandler btnProduct.MouseLeave, AddressOf btn_MouseLeave
            Me.Controls.Add(btnProduct)
            i += 200
            If i > 1000 Then
                j += 150
                i = 50
            End If
            If sender.loc.Y > 500 Then
                Me.Size = New Size(Me.Size.Width, Me.Size.Height + 100)
            End If
        Next
    End Sub


    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim btnname As String
        Dim dbadapter As Mysql.data.mysqlclient.mysqldataadapter, dbtable As New DataTable
        frmItemsSearch.Close()

        If TypeOf sender Is Button Then
            btnname = CType(sender, Button).Name
            connect()
            dbadapter = New Mysql.data.mysqlclient.mysqldataadapter("Select all * from tblProductDetails where prodname  = '" & btnname & "';", dbConnection)
            dbadapter.Fill(dbtable)
            dbConnection.Close()
            product = btnname
            frmProductInfo.ShowDialog()
        End If


    End Sub
    Private Sub btn_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        loc = sender.location
        If TypeOf sender Is Button Then
            sender.AutoSize = True
        End If
    End Sub

    Private Sub btn_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        If TypeOf sender Is Button Then
            sender.AutoSize = False
            sender.location = New Point(loc)
        End If
    End Sub

    Private Sub frmItems_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LocationChanged
        '  Me.Location = New Point(0, 143)
    End Sub

    Private Sub frmItems_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel
        Me.Location = New Point(XCor, YCOR)
    End Sub
End Class