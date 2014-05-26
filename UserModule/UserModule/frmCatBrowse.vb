Imports MySql.Data.MySqlClient
Public Class frmCatBrowse
    Dim loc As Point
    Dim locn As Point
    Dim sizeee As New Size
    Dim indexi As Double
    Private Sub frmCatBrowse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmItems.Dispose()
        frmItemsSearch.Dispose()
        frmSubCat.Dispose()
        Me.Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
        Me.MdiParent = frmMain

        Dim dbadapter As Mysql.data.mysqlclient.mysqldataadapter
        Dim dbtable As New DataTable
        dbtable.Clear()
        connect()
        dbadapter = New Mysql.data.mysqlclient.mysqldataadapter("select CatName,Photos from tblCategory", dbConnection)
        dbadapter.Fill(dbtable)
        dbConnection.Close()
        Dim i As Integer = 100
        Dim j As Integer = 160
        Dim index As Integer = 0

        For Each dRow In dbtable.Rows
            Dim picCat As New PictureBox
            With picCat
                .Name = (dRow.item(0)).ToString
                On Error Resume Next
                .Image = getPicture((dRow.item("Photos")).ToString)
                .Location = New System.Drawing.Point(i, j)
                .Size = New Size(150, 150)
                .Enabled = True
                .SizeMode = PictureBoxSizeMode.Zoom
                .BackColor = Color.Transparent
            End With
            AddHandler picCat.MouseClick, AddressOf picCat_Click
            AddHandler picCat.MouseEnter, AddressOf Cat_Hover
            AddHandler picCat.MouseLeave, AddressOf Cat_MouseLeave
            Me.Controls.Add(picCat)


            Dim btnProduct As New Button
            With btnProduct
                .Name = ("btn")
                .Location = New System.Drawing.Point(i + 35, j + 160)
                .Text = (dRow.item(0)).ToString
                .Enabled = True
                .TextAlign = ContentAlignment.MiddleCenter
                .BackColor = Color.Transparent
                ToolTip1.SetToolTip(btnProduct, (dRow.item(0)).ToString)
                AddHandler btnProduct.Click, AddressOf btn_Click
                AddHandler btnProduct.MouseEnter, AddressOf btn_MouseEnter
                AddHandler btnProduct.MouseLeave, AddressOf btn_MouseLeave
                Me.Controls.Add(btnProduct)

            End With

            i += 333
            If i >= 1250 Then
                j += 333
                i = 90
            End If
            index += 1
            If sender.loc.Y > 500 Then
                Me.Size = New Size(Me.Size.Width, Me.Size.Height + 100)
            End If
        Next


    End Sub

    Private Sub Cat_Hover(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim picname As String
        Dim loc As Point
        Dim sze As Size
        Dim dbadapter As Mysql.data.mysqlclient.mysqldataadapter, dbtable As New DataTable
        Dim ii As Integer, jj As Integer
        Dim kk As Integer, ll As Integer
        frmItemsSearch.Close()


        If TypeOf sender Is PictureBox Then
            picname = CType(sender, PictureBox).Name
            connect()
            dbadapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select all * from tblSubCat where CatID = (select CatID from tblCategory where CatName  = '" & picname & "');", dbConnection)

            dbadapter.Fill(dbtable)
            dbConnection.Close()
            loc = CType(sender, PictureBox).Location
            sze = CType(sender, PictureBox).Size

            ii = Val(loc.X) - 90
            jj = Val(loc.Y) + Val(sze.Height) + 20

            Dim index As Integer = 1
            For Each dRow In dbtable.Rows

                Dim picCat As New PictureBox
                With picCat
                    .Name = (dRow.item("SubCatName")).ToString
                    On Error Resume Next
                    .Image = getPicture(dRow.item("Photos"))
                    .Location = New System.Drawing.Point(ii, jj)
                    .Size = New Size(75, 75)
                    .Enabled = True
                    .SizeMode = PictureBoxSizeMode.Zoom
                    .BackColor = Color.Transparent
                End With
                AddHandler picCat.Click, AddressOf picCat2_Click
                Me.Controls.Add(picCat)

                Select Case index
                    Case 1, 2, 3
                        jj -= 90
                    Case 4, 5, 6
                        ii += 90
                    Case 7, 8
                        jj += 90

                    Case 9
                        jj += 105

                    Case 10, 11, 12
                        ii -= 90
                    Case 13
                        GoTo conti
                End Select
                index += 1
            Next
        End If
conti:
        ii += 333
        If ii > 1000 Then
            jj += 333
            ii = 90
        End If
        On Error Resume Next
        If sender.loc.Y > 500 Then
            Me.Size = New Size(Me.Size.Width, Me.Size.Height + 100)
        End If
    End Sub


    Private Sub Cat_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim picname As String
        Dim dbadapter As Mysql.data.mysqlclient.mysqldataadapter, dbtable As New DataTable
        If TypeOf sender Is PictureBox Then
            picname = CType(sender, PictureBox).Name

            connect()
            dbadapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select all * from tblSubCat where CatID = (select CatID from tblCategory where CatName  = '" & picname & "');", dbConnection)
            dbadapter.Fill(dbtable)
            dbConnection.Close()

            For Each dRow In dbtable.Rows
                For Each cntrl As Control In Me.Controls
                    If TypeOf (cntrl) Is PictureBox And cntrl.Name = dRow.item("SubCatName") Then
                        cntrl.Dispose()
                    End If
                Next
            Next
        End If
    End Sub


    'Button Click Event
    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim buttontext As String

        If TypeOf sender Is Button Then
            buttontext = CType(sender, Button).Text
            CatName = buttontext
            frmSubCat.Show()
        End If


    End Sub




    ' Private Sub btn_Click2(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ' Dim buttontext As String
    ' Dim dbadapter As Mysql.data.mysqlclient.mysqldataadapter, dbtable As New DataTable
    '
    '
    '        If TypeOf sender Is Button Then
    '            buttontext = CType(sender, Button).Text
    '            connect()
    '            dbadapter = New Mysql.data.mysqlclient.mysqldataadapter("Select all * from tblProductDetails where ProdID =(Select ProdID from tblProducts where SubCatID  = (Select SubCatID from tblSubCat where SubCatName = '" & buttontext & "');", dbConnection)
    '            dbadapter.Fill(dbtable)
    '            dbConnection.Close()
    '    ' frmProductInfo.ShowDialog()
    '        End If
    '
    '
    '  End Sub

    Private Sub btn_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        locn = CType(sender, Button).Location
        sizeee = CType(sender, Button).Size

        If TypeOf sender Is Button Then
            sender.size = New Size(Val(sizeee.Width + 20), Val(sizeee.Height))
            sender.Location = New System.Drawing.Point(locn.X - 10, locn.Y)
        End If
    End Sub

    Private Sub btn_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        If TypeOf sender Is Button Then
            sender.size = New Size(Val(sizeee.Width), Val(sizeee.Height))
            sender.location = New Point(locn)
        End If
    End Sub



    Private Sub picCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim pictext As String
        frmItemsSearch.Close()

        If TypeOf sender Is PictureBox Then
            pictext = CType(sender, PictureBox).Name
            CatName = pictext
            frmSubCat.Show()
        End If
        ' frmProductInfo.ShowDialog()

    End Sub


    Private Sub picCat2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pictext As String
        frmItemsSearch.Close()

        If TypeOf sender Is PictureBox Then
            pictext = CType(sender, PictureBox).Name
            subcat = pictext
            frmItems.Show()
            ' frmProductInfo.ShowDialog()
        End If
    End Sub

    Private Sub frmCatBrowse_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LocationChanged
        ' Me.Location = New Point(0, 143)
    End Sub

    Private Sub frmCatBrowse_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel
        Me.Location = New Point(XCor, YCOR)
    End Sub
End Class