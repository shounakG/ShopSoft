Imports MySql.Data.MySqlClient
Public Class frmProductInfo
    Dim orsze As Size
    Dim orloc As Point
    Private Sub ProductInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PicRatingsPos.Enabled = True
        PicRatingsNeg.Enabled = True
        Dim dbAdapter As Mysql.data.mysqlclient.mysqldataadapter, dbTable As New DataTable
        connect()
        dbAdapter = New Mysql.data.mysqlclient.mysqldataadapter("select * from tblProductDetails where ProdName = '" & product & "';", dbConnection)
        dbAdapter.Fill(dbTable)
        dbConnection.Close()
        On Error Resume Next
        picproduct.ErrorImage = My.Resources.ErrorImage
        On Error Resume Next
        picproduct.Image = getPicture(dbTable.Rows(0).Item(7))

        lblProdName.Text = dbTable.Rows(0).Item(1)
        lblprodinfo.Text = dbTable.Rows(0).Item(4)
        lblMRPno.Text = dbTable.Rows(0).Item(2)
        lblRateno.Text = dbTable.Rows(0).Item(3)
        lblRateno.Visible = False
        lblDiscount.Visible = False
        lblDiscountno.Visible = False
        lblRateRs.Visible = False

        If dbTable.Rows(0).Item("Warranty") <> 0 Then
            lblWarranty.Text = "Warranty " & dbTable.Rows(0).Item("Warranty") & " Yr(s)"
        Else
            lblWarranty.Text = "No Warranty"
        End If
        lblWarranty.Visible = True
        If lblMRPno.Text <> lblRateno.Text Then

            lblMRPno.Font = New System.Drawing.Font(lblMRPno.Font, FontStyle.Strikeout)
            lblRateRs.Visible = True
            lblRateno.Visible = True
            lblDiscount.Visible = True
            Dim temp As Double
            temp = ((Val(lblMRPno.Text) - Val(lblRateno.Text)) / Val(lblMRPno.Text)) * 100
            lblDiscountno.Text = FormatNumber(temp, -1, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault) & "%"
            lblDiscountno.Visible = True
        End If


        dbTable.Clear()
        connect()
        dbAdapter = New Mysql.data.mysqlclient.mysqldataadapter("Select BrandName from tblBrands where BrandID = (Select BrandID from tblProducts where ProductID = (Select ProductID from tblProductDetails where ProdName = '" & product & "'));", dbConnection)
        dbAdapter.Fill(dbTable)
        dbConnection.Close()
        lblBrand.Text = dbTable.Rows(0).Item("brandname")

        dbTable.Clear()
        connect()
        dbAdapter = New Mysql.data.mysqlclient.mysqldataadapter("select * from tblProductDetails where ProdName = '" & product & "';", dbConnection)
        dbAdapter.Fill(dbTable)
        dbConnection.Close()
        If Val(dbTable.Rows(0).Item("Stock")) = 0 Or ToString(dbTable.Rows(0).Item("Stock")) = "" Then
            lblStock.Text = "Out Of Stock"
        Else
            lblStock.Text = "Available"
        End If


        dbTable.Clear()
        Dim temp1 As Integer
        connect()
        dbAdapter = New Mysql.data.mysqlclient.mysqldataadapter("select ThumbsUp from tblProducts where ProductID = (Select ProductID from tblProductDetails where ProdName = '" & product & "');", dbConnection)
        dbAdapter.Fill(dbTable)
        dbConnection.Close()
        temp1 = dbTable.Rows(0).Item("ThumbsUp")
        lblPosRat.Text = temp1

        dbTable.Clear()
        Dim temp2 As Integer
        connect()
        dbAdapter = New Mysql.data.mysqlclient.mysqldataadapter("Select ThumbsDown from tblProducts where ProductID = (Select ProductID from tblProductDetails where ProdName = '" & product & "');", dbConnection)
        dbAdapter.Fill(dbTable)
        dbConnection.Close()
        'temp2 = dbTable.Rows(0).Item("ThumbsDown")
        lblNegRat.Text = temp2
        dbTable.Clear()
    End Sub

    Private Sub btnAtc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtc.Click

        If lblStock.Text = "Out Of Stock" Then
            MsgBox("This product is out of stock, you can order it once its available")
        Else
            frmCart.ShowDialog()
        End If
    End Sub

    Private Sub PicRatingsPos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicRatingsPos.Click
        If loginflag = True Then
            Dim a As Integer
            Dim dbAdapter As Mysql.data.mysqlclient.mysqldataadapter, dbTable As New DataTable
            connect()
            dbAdapter = New Mysql.data.mysqlclient.mysqldataadapter("select ThumbsUp from tblProducts where ProductID = (Select ProductID from tblProductDetails where ProdName = '" & product & "');", dbConnection)
            dbAdapter.Fill(dbTable)
            a = dbTable.Rows(0).Item("ThumbsUp")
            dbConnection.Close()
            dbTable.Clear()
            connect()
            Dim dbcommand As New Mysql.data.mysqlclient.mysqlcommand("Update tblProducts set Thumbsup = " & a + 1 & " where ProductID = (Select ProductID from tblProductDetails where ProdName = '" & product & "');", dbConnection)
            dbcommand.ExecuteNonQuery()
            lblPosRat.Text = a + 1
            dbConnection.Close()
            PicRatingsPos.Enabled = False
            PicRatingsNeg.Enabled = False
        Else
            Afterlogin = 2
            frmLogin.ShowDialog()
        End If
    End Sub

    Private Sub PicRatingsNeg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicRatingsNeg.Click
        If loginflag = True Then
            Dim a As Integer
            Dim dbAdapter As Mysql.data.mysqlclient.mysqldataadapter, dbTable As New DataTable
            connect()
            dbAdapter = New Mysql.data.mysqlclient.mysqldataadapter("select ThumbsDown from tblProducts where ProductID = (Select ProductID from tblProductDetails where ProdName = '" & product & "');", dbConnection)
            dbAdapter.Fill(dbTable)
            a = dbTable.Rows(0).Item("ThumbsDown")
            dbConnection.Close()
            dbTable.Clear()
            connect()
            Dim dbcommand As New Mysql.data.mysqlclient.mysqlcommand("Update tblProducts set ThumbsDown = " & a + 1 & " where ProductID = (Select ProductID from tblProductDetails where ProdName = '" & product & "');", dbConnection)
            dbcommand.ExecuteNonQuery()
            lblNegRat.Text = a + 1
            dbConnection.Close()
            PicRatingsPos.Enabled = False
            PicRatingsNeg.Enabled = False
        Else
            Afterlogin = 2
            frmLogin.ShowDialog()
        End If
    End Sub

   
    Private Sub picproduct_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles picproduct.MouseEnter

        orsze = Me.picproduct.Size
        orloc = picproduct.Location
        picproduct.Location = New Point(orloc.X - 20, orloc.Y - 10)
        picproduct.Size = New Size(orsze.Width + 40, orsze.Height + 40)
    End Sub

    Private Sub picproduct_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picproduct.MouseLeave
        picproduct.Location = New Point(orloc)
        picproduct.Size = New Size(orsze)
    End Sub

    Private Sub picproduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picproduct.Click

    End Sub
End Class