Imports MySql.Data.MySqlClient
Public Class frmSubCat
    Dim locn As Point
    Dim sizeee As Size
    Private Sub frmSubCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmItems.Dispose()
        frmItemsSearch.Dispose()
        frmCatBrowse.Dispose()

        Me.MdiParent = frmMain
        Me.Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
        Dim i As Integer = 100
        Dim j As Integer = 160
        Dim index As Integer = 0


        Dim dbadapter As Mysql.data.mysqlclient.mysqldataadapter, dbtable As New DataTable
        dbadapter = New Mysql.data.mysqlclient.mysqldataadapter("Select all * from tblSubCat where CatID  = (Select CatID from tblCategory where CatName = '" & CatName & "');", dbConnection)
        dbadapter.Fill(dbtable)
        dbConnection.Close()

        For Each dRow In dbtable.Rows
            Dim picSubCat As New PictureBox
            With picSubCat
                .Name = (dRow.item("SubCatName")).ToString
                On Error Resume Next
                .Image = getPicture(dRow.item("Photos"))
                .Location = New System.Drawing.Point(i, j)
                .Size = New Size(150, 150)
                .Enabled = True
                .SizeMode = PictureBoxSizeMode.Zoom
                .BackColor = Color.Transparent
            End With
            AddHandler picSubCat.MouseClick, AddressOf picCat_Click
            AddHandler picSubCat.MouseEnter, AddressOf Cat_Hover
            AddHandler picSubCat.MouseLeave, AddressOf Cat_MouseLeave
            Me.Controls.Add(picSubCat)


            Dim btnProduct As New Button
            With btnProduct
                .Name = ("btn")
                .Location = New System.Drawing.Point(i + 35, j + 160)
                .Text = (dRow.item("SubCatName")).ToString
                .Enabled = True
                .TextAlign = ContentAlignment.MiddleCenter
                .BackColor = Color.Transparent
                ToolTip1.SetToolTip(btnProduct, (dRow.item("SubCatName")).ToString)
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
            sender.location = New System.Drawing.Point(locn)
        End If
    End Sub

    'Button Click Event
    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim buttontext As String
        frmItemsSearch.Close()
        If TypeOf sender Is Button Then
            buttontext = CType(sender, Button).Text
            subcat = buttontext
            frmItems.Show()
        End If
    End Sub

    Private Sub Cat_Hover(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim picname As String
        Dim loc As Point
        Dim sze As Size
        Dim dbadapter As Mysql.data.mysqlclient.mysqldataadapter, dbtable As New DataTable
        Dim ii As Integer, jj As Integer
        frmItemsSearch.Close()


        If TypeOf sender Is PictureBox Then
            picname = CType(sender, PictureBox).Name
            connect()
            dbadapter = New Mysql.data.mysqlclient.mysqldataadapter("Select all * from tblProductDetails where ProductID in (Select ProductID from tblProducts where SubCatID in (Select SubCatID from tblSubCat where SubCatName = '" & picname & "'));", dbConnection)
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
                    .Name = (dRow.item("ProdName")).ToString
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

        If sender.loc.Y > 500 Then
            Me.Size = New Size(Me.Size.Width, Me.Size.Height + 100)
        End If

    End Sub


    Private Sub Cat_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ind As Integer = 0
ret:
        Try
            Dim picname As String
            Dim dbadapter As Mysql.data.mysqlclient.mysqldataadapter, dbtable As New DataTable
            If TypeOf sender Is PictureBox Then
                picname = CType(sender, PictureBox).Name
                connect()
                dbadapter = New Mysql.data.mysqlclient.mysqldataadapter("Select all * from tblProductDetails where ProductID in (Select ProductID from tblProducts where SubCatID in (Select SubCatID from tblSubCat where SubCatName = '" & picname & "'));", dbConnection)
                dbadapter.Fill(dbtable)
                dbConnection.Close()

                For Each dRow In dbtable.Rows
                    For Each cntrl As Control In Me.Controls
                        If TypeOf (cntrl) Is PictureBox And cntrl.Name = dRow.item("ProdName") Then
                            cntrl.Dispose()
                        End If
                    Next
                Next
            End If
        Catch ex As Exception
            ind += 1
            If ind > 0 Then
                GoTo term
            Else
                GoTo ret
            End If
        End Try
term:
    End Sub

    Private Sub picCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim pictext As String

        If TypeOf sender Is PictureBox Then
            pictext = CType(sender, PictureBox).Name
            subcat = pictext
            frmItems.Show()
        End If
    End Sub


    Private Sub picCat2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pictext As String
        frmItemsSearch.Close()

        If TypeOf sender Is PictureBox Then
            pictext = CType(sender, PictureBox).Name
            product = pictext
            frmProductInfo.Show()
        End If
    End Sub

    Private Sub frmSubCat_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LocationChanged

    End Sub

    Private Sub frmSubCat_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel
        Me.Location = New Point(XCor, YCOR)
    End Sub
End Class
