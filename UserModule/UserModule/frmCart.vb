Imports MySql.Data.MySqlClient

Public Class frmCart
    Dim quantity As Integer, qty As String
    Dim totalupdateflag As Boolean = False
    Dim arrname(100) As String




    Private Sub frmCart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If resetflag = True Then
            For i = 0 To 99
                arrname(i) = ""
            Next


            Me.lblcartSrNo.Text = "SrNo"
            lblcartSrNo.Visible = True
            Me.lblcartItem.Text = "Item"
            lblcartItem.Visible = True
            Me.lblcartSubCat.Text = "Category"
            lblcartSubCat.Visible = True
            Me.lblcartiteminfo.Text = "Information"
            lblcartiteminfo.Visible = True
            Me.lblcartPrice.Text = "Price"
            lblcartPrice.Visible = True
            Me.lblcartQuantity.Text = "Quantity"
            lblcartQuantity.Visible = True
            Me.lblcartSubtotal.Text = "Sub-Total"
            lblcartSubtotal.Visible = True
            Me.btnBack.Text = "Save and Continue Shopping"
            btnBack.Visible = True
            Me.btnCancel.Text = "Cancel"
            btnCancel.Visible = True
            Me.lblTotal.Text = "Total"

            Me.lbltotalnorupee.Text = "र"
            Me.lbltotalnorupee.Visible = False
            'Me.lblSr1.Text = "1"
            'Me.lblSr1.Visible = False
            Me.lblSr2.Text = "2"
            Me.lblSr2.Visible = False
            Me.lblSr3.Text = "3"
            Me.lblSr3.Visible = False
            Me.lblSr4.Text = "4"
            Me.lblSr4.Visible = False
            Me.lblSr5.Text = "5"
            Me.lblSr5.Visible = False
            Me.txtQuantity1.Visible = True
            txtQuantity1.Text = ""
            Me.txtQuantity2.Visible = False
            txtQuantity2.Text = ""
            Me.txtQuantity3.Visible = False
            txtQuantity3.Text = ""
            Me.txtQuantity4.Visible = False
            txtQuantity4.Text = ""
            Me.txtQuantity5.Visible = False
            txtQuantity5.Text = ""
            lblItem1.Text = "Item"
            lblItem1.Visible = False
            lblItem2.Text = "Item"
            lblItem2.Visible = False
            lblItem3.Text = "Item"
            lblItem3.Visible = False
            lblItem4.Text = "Item"
            lblItem4.Visible = False
            lblItem5.Text = "Item"
            lblItem5.Visible = False
            'Me.lbltotalnorupee.Font = New Font("र", 12, FontStyle.Regular)
            Me.btnProceed.Text = "Proceed"
            btnProceed.Visible = True
            btnBack.Text = "Save and Continue Shopping"
            btnBack.Visible = True
            btnCancel.Text = "Cancel"
            btnCancel.Visible = True
            Me.btnProceed.Enabled = False
            resetflag = False

        End If

        If (srno >= 5) Then
            MsgBox("Cart is full, can't add more")
        Else
            Dim m As Integer
            For m = 0 To srno
                If arrname(m) = frmProductInfo.lblProdName.Text Then
                    MsgBox("Product has already been added")
                    GoTo Exitlbl
                End If
            Next

            totalupdateflag = False

            srno += 1
            If srno < 6 Then
                frmMain.lblsrno.Text = srno.ToString
                frmMyAccount.lblsrno.Text = srno.ToString
            End If

            arrname(srno - 1) = frmProductInfo.lblProdName.Text
            Select Case srno
                Case 1
                    lblSr1.Visible = True

                    lblItem1.Text = product
                    lblItem1.Visible = True


                    lblCat1.Visible = True
                    catnameproc(lblCat1)


                    lblInfo1.Visible = True
                    infoproc(lblInfo1)

                    lblPrice1.Visible = True
                    priceproc(lblPrice1)


                    txtQuantity1.Visible = True
                    stockproc(txtQuantity1)

                Case 2
                    lblSr2.Visible = True

                    lblItem2.Text = product
                    lblItem2.Visible = True


                    lblCat2.Visible = True
                    catnameproc(lblCat2)


                    lblInfo2.Visible = True
                    infoproc(lblInfo2)

                    lblPrice2.Visible = True
                    priceproc(lblPrice2)


                    txtQuantity2.Visible = True
                    stockproc(txtQuantity2)

                Case 3
                    lblSr3.Visible = True

                    lblItem3.Text = product
                    lblItem3.Visible = True


                    lblCat3.Visible = True
                    catnameproc(lblCat3)


                    lblInfo3.Visible = True
                    infoproc(lblInfo3)

                    lblPrice3.Visible = True
                    priceproc(lblPrice3)


                    txtQuantity3.Visible = True
                    stockproc(txtQuantity3)

                Case 4
                    lblSr4.Visible = True

                    lblItem4.Text = product
                    lblItem4.Visible = True


                    lblCat4.Visible = True
                    catnameproc(lblCat4)


                    lblInfo4.Visible = True
                    infoproc(lblInfo4)

                    lblPrice4.Visible = True
                    priceproc(lblPrice4)


                    txtQuantity4.Visible = True
                    stockproc(txtQuantity4)
                Case 5
                    lblSr5.Visible = True

                    lblItem5.Text = product
                    lblItem5.Visible = True


                    lblCat5.Visible = True
                    catnameproc(lblCat5)


                    lblInfo5.Visible = True
                    infoproc(lblInfo5)

                    lblPrice5.Visible = True
                    priceproc(lblPrice5)


                    txtQuantity5.Visible = True
                    stockproc(txtQuantity5)


            End Select
        End If
exitlbl:

    End Sub

    Private Sub txtQuantity1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantity1.KeyPress

        If Asc(e.KeyChar) > 48 And Asc(e.KeyChar) <= 57 Then

        ElseIf Asc(e.KeyChar) = 13 Then
            atcflag = True
            lblTotalNo.Text = Val(lblTotalNo.Text) + Val(lblSubTot1.Text)
            lblTotalNo.Visible = True
            lbltotalnorupee.Visible = True
            btnProceed.Enabled = True
            If txtQuantity1.Text = "" Then
                MsgBox("You haven't entered a quantity")
            Else
                txtQuantity1.Enabled = False
            End If
        ElseIf Asc(e.KeyChar) = 8 Then

        Else
            MsgBox("You can only enter numbers")
            e.Handled = True
        End If

    End Sub

    Private Sub txtQuantity2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantity2.KeyPress
        If Asc(e.KeyChar) > 48 And Asc(e.KeyChar) <= 57 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 8 Then
        ElseIf Asc(e.KeyChar) = 13 Then
            atcflag = True
            lblTotalNo.Text = Val(lblTotalNo.Text) + Val(lblSubTot2.Text)
            lblTotalNo.Visible = True
            lbltotalnorupee.Visible = True
            btnProceed.Enabled = True
            If txtQuantity2.Text = "" Then
                MsgBox("You haven't entered a quantity")
            Else
                txtQuantity2.Enabled = False
            End If
        ElseIf Asc(e.KeyChar) = 8 Then
        Else
            MsgBox("You can only enter numbers")
            e.Handled = True
        End If
    End Sub

    Private Sub txtQuantity3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantity3.KeyPress
        If Asc(e.KeyChar) > 48 And Asc(e.KeyChar) <= 57 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 8 Then
        ElseIf Asc(e.KeyChar) = 13 Then
            atcflag = True
            lblTotalNo.Text = Val(lblTotalNo.Text) + Val(lblSubTot3.Text)
            lblTotalNo.Visible = True
            lbltotalnorupee.Visible = True
            btnProceed.Enabled = True
            If txtQuantity3.Text = "" Then
                MsgBox("You haven't entered a quantity")
            Else
                txtQuantity3.Enabled = False
            End If
        ElseIf Asc(e.KeyChar) = 8 Then
        Else
            MsgBox("You can only enter numbers")
            e.Handled = True
        End If

    End Sub

    Private Sub txtQuantity4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantity4.KeyPress
        If Asc(e.KeyChar) > 48 And Asc(e.KeyChar) <= 57 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 8 Then
        ElseIf Asc(e.KeyChar) = 13 Then
            atcflag = True
            lblTotalNo.Text = Val(lblTotalNo.Text) + Val(lblSubTot4.Text)
            lblTotalNo.Visible = True
            lbltotalnorupee.Visible = True
            btnProceed.Enabled = True
            If txtQuantity4.Text = "" Then
                MsgBox("You haven't entered a quantity")
            Else
                txtQuantity4.Enabled = False
            End If
        ElseIf Asc(e.KeyChar) = 8 Then
        Else
            MsgBox("You can only enter numbers")
            e.Handled = True
        End If


    End Sub

    Private Sub txtQuantity5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantity5.KeyPress
        If Asc(e.KeyChar) > 48 And Asc(e.KeyChar) <= 57 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 8 Then
        ElseIf Asc(e.KeyChar) = 13 Then
            atcflag = True
            lblTotalNo.Text = Val(lblTotalNo.Text) + Val(lblSubTot5.Text)
            lblTotalNo.Visible = True
            lbltotalnorupee.Visible = True
            btnProceed.Enabled = True
            If txtQuantity5.Text = "" Then
                MsgBox("You haven't entered a quantity")
            Else
                txtQuantity5.Enabled = False
            End If
        ElseIf Asc(e.KeyChar) = 8 Then
        Else
            MsgBox("You can only enter numbers")
            e.Handled = True
        End If

    End Sub

    Private Sub txtQuantity1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQuantity1.TextChanged
        textproc(txtQuantity1, lblSubTot1, lblPrice1)
    End Sub

    Private Sub txtQuantity2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQuantity2.TextChanged
        textproc(txtQuantity2, lblSubTot2, lblPrice2)
    End Sub

    Private Sub txtQuantity3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQuantity3.TextChanged
        textproc(txtQuantity3, lblSubTot3, lblPrice3)
    End Sub

    Private Sub txtQuantity4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQuantity4.TextChanged
        textproc(txtQuantity4, lblSubTot4, lblPrice4)

    End Sub

    Private Sub txtQuantity5_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQuantity5.TextChanged
        textproc(txtQuantity5, lblSubTot5, lblPrice5)
    End Sub

    Private Sub textproc(ByVal txtbox As TextBox, ByVal lblsubtot As Label, ByVal lblprce As Label)
        If quantity <> 0 Then
            If txtbox.Text <> "" Then
                If Asc(txtbox.Text) >= 48 And Asc(txtbox.Text) <= 57 Then
                    If Val(txtbox.Text) > quantity Then
                        MsgBox("Only " & quantity & " items are in stock")
                        If (qty.Length - 1) <> 0 Then
                            txtbox.Text = txtbox.Text.Substring(qty.Length - 1, 1)
                        Else
                            txtbox.Text = ""
                        End If

                    ElseIf Val(txtbox.Text) = 0 Then
                        MsgBox("Please enter a value greater than 0")
                        txtbox.Text = txtbox.Text.Substring(qty.Length - 1, 1)
                    Else
                        lblsubtot.Text = Val(txtbox.Text) * Val(lblprce.Text)
                        lblsubtot.Visible = True
                        totalupdateflag = True
                    End If
                Else
                End If
            Else
                lblsubtot.Visible = False
                totalupdateflag = False
            End If
        Else
            MsgBox("This item is out of stock")
        End If
    End Sub

    Private Sub catnameproc(ByVal catname As Label)
        Dim dbAdapter As MySql.Data.MySqlClient.MySqlDataAdapter, dbtable As New DataTable
        connect()
        dbAdapter = New Mysql.data.mysqlclient.mysqldataadapter("select SubCatName from tblSubCat where SubCatID = (Select SubCatId from tblProducts where ProductID = (select ProductID from tblProductDetails where ProdName = '" & frmProductInfo.lblProdName.Text & "'));", dbConnection)
        dbAdapter.Fill(dbtable)
        dbConnection.Close()
        catname.Text = dbtable.Rows(0).Item(0)
        dbConnection.Close()
    End Sub

    Private Sub infoproc(ByVal info As Label)
        Dim dbAdapter As MySql.Data.MySqlClient.MySqlDataAdapter, dbtable As New DataTable
        connect()
        dbtable = New DataTable
        dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("select Information from tblProductDetails where ProdName = '" & frmProductInfo.lblProdName.Text & "';", dbConnection)
        dbAdapter.Fill(dbtable)
        dbConnection.Close()
        info.Text = dbtable.Rows(0).Item(0)
        dbConnection.Close()
    End Sub

    Private Sub priceproc(ByVal price As Label)
        Dim dbAdapter As MySql.Data.MySqlClient.MySqlDataAdapter, dbtable As New DataTable
        connect()
        dbtable = New DataTable
        dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("select Rate from tblProductDetails where ProdName = '" & frmProductInfo.lblProdName.Text & "';", dbConnection)
        dbAdapter.Fill(dbtable)
        price.Text = dbtable.Rows(0).Item(0)
        dbConnection.Close()
    End Sub

    Private Sub stockproc(ByVal stock As TextBox)
        Dim dbAdapter As MySql.Data.MySqlClient.MySqlDataAdapter, dbtable As New DataTable
        dbtable = New DataTable
        connect()
        dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("select Stock from tblProductDetails where ProdName = '" & frmProductInfo.lblProdName.Text & "';", dbConnection)
        dbAdapter.Fill(dbtable)
        dbConnection.Close()
        If dbtable.Rows(0).Item(0) <> 0 Then
            quantity = dbtable.Rows(0).Item(0)
            qty = ToString(quantity)
        Else
            quantity = 0
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        If totalupdateflag = True Then
            Me.Close()
            frmProductInfo.Close()
        Else
            MsgBox("You haven't entered the quantity")
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnProceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProceed.Click
        ErrorProvider1.Clear()
        For Each c As Control In Me.Controls
            If TypeOf c Is TextBox Then
                If CType(c, Control).Text = String.Empty And CType(c, Control).Visible = True Then
                        ErrorProvider1.SetError(CType(c, Control), "Confirm a value")
                    GoTo termn
                ElseIf CType(c, Control).Text <> String.Empty And CType(c, Control).Visible = True And CType(c, Control).Enabled = True Then
                        ErrorProvider1.SetError(CType(c, Control), "Confirm a value")
                        GoTo termn
                End If
            End If
        Next
        Afterlogin = 3
        frmLogin.ShowDialog()
termn:
    End Sub

End Class