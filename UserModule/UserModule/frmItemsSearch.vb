Imports MySql.Data.MySqlClient
Public Class frmItemsSearch

    Dim loc As Point

    Private Sub frmItemsSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        frmItems.Dispose()
        frmCatBrowse.Dispose()
        frmSubCat.Dispose()

        Me.Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)

        Me.MdiParent = frmMain


        Dim dbAdapter As Mysql.data.mysqlclient.mysqldataadapter, srcTable As New DataTable
        Dim srcTxt As Integer

        If frmMain.rbBrands.Checked = True And frmMain.cbCriteria.Text <> "All Categories" Then
            connect()
            srcTable.Clear()
            'dbAdapter = New Mysql.data.mysqlclient.mysqldataadapter("Select all * from tblProductDetails where ProdName LIKE '%" & frmMain.txtSearchMain.Text & "%'", dbConnection)
            'dbAdapter = New Mysql.data.mysqlclient.mysqldataadapter("Select all ProdName from tblProductDetails where ProdName LIKE '%" & frmMain.txtSearchMain.Text & "%' and all ProductID = (select ProductID from tblProducts where BrandID = (select BrandID from tblBrands where BrandName LIKE '%" & frmMain.cbCriteria.Text & "%'))", dbConnection)
            dbAdapter = New Mysql.data.mysqlclient.mysqldataadapter("Select all * from tblProductDetails where ProductID in (Select ProductID from tblProducts where BrandID in (Select BrandID from tblBrands where BrandName LIKE '%" & frmMain.cbCriteria.Text & "%'));", dbConnection)
            dbAdapter.Fill(srcTable)
            dbConnection.Close()


            If srcTable.Rows.Count = 0 Then
                MsgBox("Sorry! No results found!")
            End If
            srcTxt = srcTable.Rows.Count

            Dim i As Integer = 50, j As Integer = 50



            For Each dRow In srcTable.Rows
                If LCase(dRow.item("Prodname").ToString).Contains(LCase(frmMain.txtSearchMain.Text)) = True Then
                    Dim pbProduct As New PictureBox
                    With pbProduct
                        .Name = ("pic")
                        On Error Resume Next
                        .Image = Image.FromFile(dRow.item("Photos"))
                        .Location = New System.Drawing.Point(i, j)
                        .Size = New Size(90, 90)
                        .Enabled = True
                        .SizeMode = PictureBoxSizeMode.Zoom
                        '  Note you can set more of the PicBox's Properties here
                    End With
                    '  This is the line that sometimes catches people out!
                    Me.Controls.Add(pbProduct)

                    Dim btnProduct As New Button
                    With btnProduct
                        .Name = (dRow.item(1))
                        .Location = New System.Drawing.Point(i + 10, j + 95)
                        .Text = (dRow.item("ProdName"))
                        .Enabled = True
                        .BackColor = Color.Transparent
                        '.TextAlign = System.Drawing.ContentAlignment.TopLeft
                        ToolTip1.SetToolTip(btnProduct, dRow.item(1))
                        '.Font = New System.Drawing.Font("Microsoft Sans Serif", 6)
                        '  Note you can set more of the PicBox's Properties here
                    End With
                    '  This is the line that sometimes catches people out!
                    AddHandler btnProduct.Click, AddressOf btn_Click
                    AddHandler btnProduct.MouseEnter, AddressOf btn_MouseEnter
                    AddHandler btnProduct.MouseLeave, AddressOf btn_MouseLeave
                    Me.Controls.Add(btnProduct)
                    '  Wire this control up to an appropriate event handler
                    'AddHandler PB.Click, AddressOf MyPicClicked
                    'Dim btn As Button = Nothing



                    i += 100
                    If i > 1250 Then
                        j += 130
                        i = 50
                    End If
                    If sender.loc.Y > 500 Then
                        Me.Size = New Size(Me.Size.Width, Me.Size.Height + 100)
                    End If
                End If
            Next


        ElseIf frmMain.rbCat.Checked = True And frmMain.cbCriteria.Text <> "All Categories" Then
            connect()
            srcTable.Clear()
            dbAdapter = New Mysql.data.mysqlclient.mysqldataadapter("Select all * from tblProductDetails where ProductID in (Select ProductID from tblProducts where SubCatID in (Select SubCatID from tblSubCat where CatID in (Select CatID from tblCategory where CatName LIKE '%" & frmMain.cbCriteria.Text & "%')));", dbConnection)
            dbAdapter.Fill(srcTable)
            dbConnection.Close()


            If srcTable.Rows.Count = 0 Then
                MsgBox("Sorry! No results found!")
            End If
            srcTxt = srcTable.Rows.Count

            Dim i As Integer = 50, j As Integer = 50



            For Each dRow In srcTable.Rows

                If LCase(dRow.item("Prodname").ToString).Contains(LCase(frmMain.txtSearchMain.Text)) = True Then
                    Dim pbProduct As New PictureBox
                    With pbProduct
                        .Name = ("pic")
                        On Error Resume Next
                        .Image = Image.FromFile(dRow.item("Photos"))
                        .Location = New System.Drawing.Point(i, j)
                        .Size = New Size(90, 90)
                        .Enabled = True
                        .SizeMode = PictureBoxSizeMode.Zoom
                        '  Note you can set more of the PicBox's Properties here
                    End With
                    '  This is the line that sometimes catches people out!
                    Me.Controls.Add(pbProduct)

                    Dim btnProduct As New Button
                    With btnProduct
                        .Name = (dRow.item(1))
                        .Location = New System.Drawing.Point(i + 10, j + 95)
                        .Text = (dRow.item("ProdName"))
                        .Enabled = True
                        '.TextAlign = System.Drawing.ContentAlignment.TopLeft
                        ToolTip1.SetToolTip(btnProduct, dRow.item(1))
                        '.Font = New System.Drawing.Font("Microsoft Sans Serif", 6)
                        '  Note you can set more of the PicBox's Properties here
                    End With
                    '  This is the line that sometimes catches people out!
                    AddHandler btnProduct.Click, AddressOf btn_Click
                    AddHandler btnProduct.MouseEnter, AddressOf btn_MouseEnter
                    AddHandler btnProduct.MouseLeave, AddressOf btn_MouseLeave
                    Me.Controls.Add(btnProduct)
                    '  Wire this control up to an appropriate event handler
                    'AddHandler PB.Click, AddressOf MyPicClicked
                    'Dim btn As Button = Nothing



                    i += 100
                    If i > 1000 Then
                        j += 130
                        i = 50
                    End If
                End If
            Next

        ElseIf frmMain.rbSubCat.Checked = True And frmMain.cbCriteria.Text <> "All Categories" Then

            connect()
            srcTable.Clear()
            dbAdapter = New Mysql.data.mysqlclient.mysqldataadapter("Select all * from tblProductDetails where ProductID in (Select ProductID from tblProducts where SubCatID = (Select SubCatID from tblSubCat where SubCatName LIKE '%" & frmMain.cbCriteria.Text & "%'));", dbConnection)
            dbAdapter.Fill(srcTable)
            dbConnection.Close()


            If srcTable.Rows.Count = 0 Then
                MsgBox("Sorry! No results found!")
            End If
            srcTxt = srcTable.Rows.Count

            Dim i As Integer = 50, j As Integer = 50



            For Each dRow In srcTable.Rows
                If LCase(dRow.item("Prodname").ToString).Contains(LCase(frmMain.txtSearchMain.Text)) = True Then
                    Dim pbProduct As New PictureBox
                    With pbProduct
                        .Name = ("pic")
                        On Error Resume Next
                        .Image = Image.FromFile(dRow.item("Photos"))
                        .Location = New System.Drawing.Point(i, j)
                        .Size = New Size(90, 90)
                        .Enabled = True
                        .SizeMode = PictureBoxSizeMode.Zoom
                        '  Note you can set more of the PicBox's Properties here
                    End With
                    '  This is the line that sometimes catches people out!
                    Me.Controls.Add(pbProduct)

                    Dim btnProduct As New Button
                    With btnProduct
                        .Name = (dRow.item(1))
                        .Location = New System.Drawing.Point(i + 10, j + 95)
                        .Text = (dRow.item("ProdName"))
                        .Enabled = True
                        '.TextAlign = System.Drawing.ContentAlignment.TopLeft
                        ToolTip1.SetToolTip(btnProduct, dRow.item(1))
                        '.Font = New System.Drawing.Font("Microsoft Sans Serif", 6)
                        '  Note you can set more of the PicBox's Properties here
                    End With
                    '  This is the line that sometimes catches people out!
                    AddHandler btnProduct.Click, AddressOf btn_Click
                    AddHandler btnProduct.MouseEnter, AddressOf btn_MouseEnter
                    AddHandler btnProduct.MouseLeave, AddressOf btn_MouseLeave
                    Me.Controls.Add(btnProduct)
                    '  Wire this control up to an appropriate event handler
                    'AddHandler PB.Click, AddressOf MyPicClicked
                    'Dim btn As Button = Nothing
                    i += 100
                    If i > 1000 Then
                        j += 130
                        i = 50
                    End If
                End If
            Next

        Else
            connect()
            srcTable.Clear()
            dbAdapter = New Mysql.data.mysqlclient.mysqldataadapter("Select * from tblProductDetails where ProdName LIKE '%" & frmMain.txtSearchMain.Text & "%';", dbConnection)
            dbAdapter.Fill(srcTable)
            dbConnection.Close()
            If srcTable.Rows.Count = 0 Then
                MsgBox("Sorry! No results found!")
            End If
            srcTxt = srcTable.Rows.Count

            Dim i As Integer = 50, j As Integer = 50

            For Each dRow In srcTable.Rows
                Dim pbProduct As New PictureBox
                With pbProduct
                    .Name = ("pic")
                    On Error Resume Next
                    .Image = Image.FromFile(dRow.item(7))
                    .Location = New System.Drawing.Point(i, j)
                    .Size = New Size(90, 90)
                    .Enabled = True
                    .SizeMode = PictureBoxSizeMode.Zoom
                    '  Note you can set more of the PicBox's Properties here
                End With
                '  This is the line that sometimes catches people out!
                Me.Controls.Add(pbProduct)

                Dim btnProduct As New Button
                With btnProduct
                    .Name = (dRow.item(1))
                    .Location = New System.Drawing.Point(i + 10, j + 95)
                    .Text = (dRow.item(1))
                    .Enabled = True
                    '.TextAlign = System.Drawing.ContentAlignment.TopLeft
                    ToolTip1.SetToolTip(btnProduct, dRow.item(1))
                    '.Font = New System.Drawing.Font("Microsoft Sans Serif", 6)
                    '  Note you can set more of the PicBox's Properties here
                End With
                '  This is the line that sometimes catches people out!
                AddHandler btnProduct.Click, AddressOf btn_Click
                AddHandler btnProduct.MouseEnter, AddressOf btn_MouseEnter
                AddHandler btnProduct.MouseLeave, AddressOf btn_MouseLeave
                Me.Controls.Add(btnProduct)
                '  Wire this control up to an appropriate event handler
                'AddHandler PB.Click, AddressOf MyPicClicked
                'Dim btn As Button = Nothing



                i += 200
                If i > 1700 Then
                    j += 130
                    i = 50
                End If
                If sender.loc.Y > 500 Then
                    Me.Size = New Size(Me.Size.Width, Me.Size.Height + 100)
                End If
            Next
        End If
        If dbConnection.State = ConnectionState.Open Then
            dbConnection.Close()
        End If
    End Sub

    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim btnname As String
        Dim dbadapter As Mysql.data.mysqlclient.mysqldataadapter, dbtable As New DataTable
        If TypeOf sender Is Button Then
            btnname = CType(sender, Button).Name
            connect()
            dbadapter = New Mysql.data.mysqlclient.mysqldataadapter("Select all * from tblProductDetails where prodname  = '" & btnname & "';", dbConnection)
            dbadapter.Fill(dbtable)
            product = btnname
            dbConnection.Close()
            frmProductInfo.ShowDialog()

        End If
    End Sub

    Private Sub btn_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        loc = sender.location
        If TypeOf sender Is Button Then
            sender.location = New Point(loc.X - 20, loc.Y)
            sender.AutoSize = True
        End If
    End Sub

    Private Sub btn_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)

        If TypeOf sender Is Button Then
            sender.AutoSize = False
            sender.location = New Point(loc)
        End If
    End Sub

    Private Sub frmItemsSearch_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LocationChanged
        ' Me.Location = New Point(0, 143)
    End Sub

    Private Sub frmItemsSearch_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel
        Me.Location = New Point(XCor, YCOR)
    End Sub
End Class