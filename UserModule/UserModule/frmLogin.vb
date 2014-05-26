Imports MySql.Data.MySqlClient
Public Class frmLogin
    Dim currbillno As Integer
    Dim lbl() As Integer = {0, 0, 0, 0, 0}

    Dim UID As Integer
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Try
            Dim dbTable As New DataTable

            If Afterlogin = 3 Then
                Dim strng As String
                Dim dbSet As New DataSet

                dbSet.Tables.Add(dbTable)
                connect()
                Dim dbAdapter As New Mysql.data.mysqlclient.mysqldataadapter("select CustomerPwd,CustomerName,CustomerID from tblCustomer", dbConnection)
                dbAdapter.Fill(dbTable)
                dbConnection.Close()
                For Each dbRow In dbTable.Rows
                    strng = XOREncryption("$herl0ck", dbRow.item(0))
                    If txtCustName.Text = "" & dbRow.item(1) And txtCustPass.Text = "" & strng Then
                        dbConnection.Close()

                        loginflag = True
                        frmMain.lblMyAccount.Text = "My Account"
                        frmMain.lblLogout.Visible = True
                        cusname = dbRow.item(1)
                        frmMain.Show()
                        Me.Close()


                        MsgBox("Its absolutely vital for you to print the bill or save a pdf")

                        tot = Val(frmCart.lblTotalNo.Text)
                        UID = dbTable.Rows(0).Item(2)
                        Dim dTable As New DataTable, dbCommand As MySql.Data.MySqlClient.MySqlCommand

                        connect()
                        dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("select max(billID) from tblBill", dbConnection)
                        dbAdapter.Fill(dTable)
                        currbillno = dTable.Rows(0).Item(0) + 1
                        dbCommand = New MySql.Data.MySqlClient.MySqlCommand("Insert into tblBill(CustomerID,DateofBill,Total) values (" & UID & ",'" & FormatDateTime(Now.Date, DateFormat.ShortDate) & "',0);", dbConnection)
                        dbCommand.ExecuteNonQuery()
                        dbConnection.Close()

                        dbTable.Reset()
                        dbTable.Clear()


                        If frmCart.lblItem1.Text <> "Item" And lbl(0) <> 1 Then
                            checkifcdn(frmCart.lblItem1.Text, frmCart.txtQuantity1.Text)
                            lbl(0) = 1
                            ' MsgBox(frmCart.lblItem1.Text)
                            'dbAdapter = New Mysql.data.mysqlclient.mysqldataadapter("Select ProductID from tblProductDetails where ProdName = '" & frmCart.lblItem1.Text & "';", dbConnection)
                            'dbAdapter.Fill(dbTable)

                            'dbCommand = New Mysql.data.mysqlclient.mysqlcommand("insert into tblBillDetails values(" & currbillno & "," & dbTable.Rows(0).Item("ProductID") & "," & 1 & ");", dbConnection)
                            'dbCommand.ExecuteNonQuery()
                            'dbConnection.Close()
                        End If
                        If frmCart.lblItem2.Text <> "Item" And lbl(1) <> 1 Then
                            checkifcdn(frmCart.lblItem2.Text, frmCart.txtQuantity2.Text)
                            lbl(1) = 1
                        End If
                        If frmCart.lblItem3.Text <> "Item" And lbl(2) <> 1 Then
                            checkifcdn(frmCart.lblItem3.Text, frmCart.txtQuantity3.Text)
                            lbl(2) = 1
                        End If
                        If frmCart.lblItem4.Text <> "Item" And lbl(3) <> 1 Then
                            checkifcdn(frmCart.lblItem4.Text, frmCart.txtQuantity4.Text)
                            lbl(3) = 1
                        End If
                        If frmCart.lblItem5.Text <> "Item" And lbl(4) <> 1 Then
                            checkifcdn(frmCart.lblItem5.Text, frmCart.txtQuantity5.Text)
                            lbl(4) = 1
                        End If

                        connect()
                        dbCommand = New MySql.Data.MySqlClient.MySqlCommand("Update tblBill SET Total = " & tot & " Where BillID = " & currbillno & ";", dbConnection)
                        dbCommand.ExecuteNonQuery()


                        dbCommand = New MySql.Data.MySqlClient.MySqlCommand("Update tblBill SET Delivered = 0 Where BillID = " & currbillno & ";", dbConnection)
                        dbCommand.ExecuteNonQuery()

                        Dim dsBill As New DataSet1()
                        dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select DISTINCT ProdName,ProdQty,MRP,Rate,Total,tblBill.BillID" & _
                                                         " from tblProductDetails,tblBillDetails,tblBill where tblBillDetails.BillID =" & currbillno & " AND tblProductDetails.ProductID = tblBillDetails.ProductID AND tblBill.BillID = tblBillDetails.BillID;", dbConnection)
                        dbAdapter.Fill(dsBill, "bill")
                        dbConnection.Close()


                        Dim cr As New crBill()
                        cr.SetDataSource(dsBill)
                        cr.Refresh()
                        frmReport.CrystalReportViewer1.ReportSource = cr
                        frmReport.CrystalReportViewer1.Update()

                        frmReport.WindowState = FormWindowState.Maximized
                        frmReport.ShowDialog()
                        Me.Close()

                        cr.Close()
                        'frmReport.CrystalReportViewer1.Dispose()


                        frmBuy.ShowDialog()
                        lbl = {0, 0, 0, 0, 0}
                        GoTo ter
                    End If

                Next

                MsgBox("Incorrect user name or password", MsgBoxStyle.Critical)
            ElseIf Afterlogin = 1 Then
                Dim strng As String
                Dim dbSet As New DataSet
                dbSet.Tables.Add(dbTable)
                connect()
                Dim dbAdapter As New Mysql.data.mysqlclient.mysqldataadapter("select CustomerPwd,CustomerName from tblCustomer;", dbConnection)
                dbAdapter.Fill(dbTable)
                For Each dbRow In dbTable.Rows
                    strng = XOREncryption("$herl0ck", dbRow.item(0))
                    MsgBox(strng)
                    If txtCustName.Text = "" & dbRow.item(1) And txtCustPass.Text = "" & strng Then
                        dbConnection.Close()
                        cusname = dbRow.item(1)
                        loginflag = True
                        frmMain.lblMyAccount.Text = "My Account"
                        frmMain.lblLogout.Visible = True
                        frmMain.Show()
                        frmMyAccount.ShowDialog()
                        Me.Close()
                        GoTo ter
                    End If
                Next
                MsgBox("Incorrect user name or password", MsgBoxStyle.Critical)
            ElseIf Afterlogin = 2 Then

                Dim strng As String
                Dim dbSet As New DataSet
                dbSet.Tables.Add(dbTable)
                connect()
                Dim dbAdapter As New Mysql.data.mysqlclient.mysqldataadapter("select CustomerPwd,CustomerName from tblCustomer", dbConnection)
                dbAdapter.Fill(dbTable)
                For Each dbRow In dbTable.Rows
                    strng = XOREncryption("$herl0ck", dbRow.item(0))
                    If txtCustName.Text = "" & dbRow.item(1) And txtCustPass.Text = "" & strng Then
                        dbConnection.Close()
                        cusname = dbRow.item(1)
                        loginflag = True
                        frmMain.lblMyAccount.Text = "My Account"
                        frmMain.lblLogout.Visible = True
                        Me.Close()
                        GoTo ter
                    End If
                Next
                MsgBox("Incorrect user name or password", MsgBoxStyle.Critical)
            End If
ter:
            dbConnection.Close()
        Catch ex As Exception
            GoTo term
        End Try
term:
    End Sub

    Private Sub btnSignUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignUp.Click
        frmSignUp.show()
    End Sub

    Private Sub checkifcdn(ByVal itemnme As String, ByVal qty As String)
        Dim dbAdapter As New Mysql.data.mysqlclient.mysqldataadapter, dbCommand As Mysql.data.mysqlclient.mysqlcommand
        Dim dbTable As New DataTable, dbSet As New DataSet

        Dim prodid As Integer
        '  dbAdapter = New Mysql.data.mysqlclient.mysqldataadapter("Select ProductID from tblProductDetails where ProdName = '" & itemnme & "';", dbConnection)
        '  dbAdapter.Fill(dbTable)

        '  dbCommand = New Mysql.data.mysqlclient.mysqlcommand("insert into tblBillDetails values(" & currbillno & "," & prodid & "," & Val(qty) & ");", dbConnection)
        ' dbCommand.ExecuteNonQuery()

        connect()
        dbAdapter = New Mysql.data.mysqlclient.mysqldataadapter("Select * from tblProductDetails where ProdName = '" & itemnme & "';", dbConnection)
        dbAdapter.Fill(dbTable)
        prodid = Val(dbTable.Rows(0).Item("ProductID"))
        dbCommand = New Mysql.data.mysqlclient.mysqlcommand("insert into tblBillDetails values(" & currbillno & "," & prodid & "," & qty & ");", dbConnection)
        dbCommand.ExecuteNonQuery()

        dbCommand = New Mysql.data.mysqlclient.mysqlcommand("Update tblProductDetails Set Stock = Stock - " & qty & " where ProductID = " & prodid & ";", dbConnection)
        dbCommand.ExecuteNonQuery()
        dbConnection.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        frmForgotPass.Show()
    End Sub

    Private Sub txtCustName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCustName.KeyPress
        If Asc(e.KeyChar) = 39 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCustPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCustPass.KeyPress
        If Asc(e.KeyChar) = 39 Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class