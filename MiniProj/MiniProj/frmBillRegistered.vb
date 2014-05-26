Imports System.Data.OleDb
Imports System.IO
Public Class frmBillRegistered

    Dim SrNo As Integer = 0, UID As Integer, clncnt As Integer = 1, CurrRows As Integer
    Dim columnflag As Boolean = True, RowFlag As Boolean = False

    Private Function CheckValidID() As Boolean
        Dim dbTable As New DataTable, dbAdapter As MySql.Data.MySqlClient.MySqlDataAdapter
        connect()
        dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("select CustomerID from tblCustomer where CustomerID = " & Val(txtUserID.Text) & ";", dbConnection)
        dbAdapter.Fill(dbTable)
        UID = dbTable.Rows.Count
        dbConnection.Close()
        If UID <> 0 Then
            If dbTable.Rows(0).Item(0) = Val(txtUserID.Text) Then
                UID = dbTable.Rows.Item(0).Item(0)
                Return True
            End If
        End If
        Return False
    End Function

    Private Sub frmBillRegistered_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetProdTable()
        txtUserID.Select()
        Me.MdiParent = frmMain
        Me.Text = "Shop @home - Bill No.: " & CurrBillNo
        Me.btnSave.Visible = False
        dtBillDate.Value = Today
        OKtoAdd = False
        dgridBillDetails.DataSource = tblBill
        'tblBill = New DataTable
    End Sub

    Private Sub txtUserID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserID.KeyPress
        Dim KeyAsc As Integer
        KeyAsc = Asc(e.KeyChar)
        Select Case KeyAsc
            Case 48 To 57, 8
            Case Else
                KeyAsc = 0
        End Select
        If KeyAsc = 0 Then
            e.Handled = True
            errTxtUser.SetError(txtUserID, "User ID can be a number only")
        Else
            e.Handled = False
            errTxtUser.Clear()
        End If
    End Sub

    Private Sub btnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItem.Click
        Dim frmAdd As New frmAddItemToBill
        CurrRows = dgridBillDetails.Rows.Count
        RowFlag = True
        dgridBillDetails.Visible = True
        btnSave.Visible = True
        frmAdd.ShowDialog()
    End Sub

    Private Sub GetProdTable()
        Dim dbAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter("select ProdName,MRP,Rate from tblProductDetails where ProductID = 1", dbConnection)
        connect()
        dbAdapter.Fill(tblBill)
        tblBill.Clear()
        dbConnection.Close()
    End Sub

    Private Sub dgridBillDetails_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgridBillDetails.RowsAdded
        If CurrRows <> dgridBillDetails.Rows.Count And RowFlag = True Then
            SrNo += 1
            RowFlag = False
        End If
        clncnt += 1
        If columnflag = False Then
            dgridBillDetails.Columns.Add("colQuantity", "Quantity")
            clncnt += 1
        End If
        columnflag = True
        If clncnt = 5 Then
            dgridBillDetails.Columns.Add("colAmount", "Amount")
        End If
        If clncnt = 2 Then
            columnflag = False
        End If
        If SrNo <> 0 Then
            dgridBillDetails.Rows.Item(SrNo - 1).Cells.Item(0).Value = SrNo
            dgridBillDetails.Rows.Item(SrNo - 1).Cells.Item("colQuantity").Value = ItemQuantity
            dgridBillDetails.Rows.Item(SrNo - 1).Cells.Item("colAmount").Value = ItemQuantity * dgridBillDetails.Rows.Item(SrNo - 1).Cells.Item("Rate").Value
        End If
    End Sub

    Private Sub btnCancelBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelBill.Click
        Dim YesNo As Integer
        YesNo = MsgBox("Do you really want to cancel bill", MsgBoxStyle.YesNo)
        If YesNo = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnSelectID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectID.Click
        Dim YesNo As Integer
        If txtUserID.Text <> "" Then
            If CheckValidID() = True Then
                Dim dbTable As New DataTable
                Dim dbAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter("Select CustomerName from tblCustomer where CustomerID = " & UID & ";", dbConnection)
                connect()
                dbAdapter.Fill(dbTable)
                dbConnection.Close()
                lblEnterUserID.Text = "User Name: " & dbTable.Rows.Item(0).Item(0)
                btnSelectID.Visible = False
                txtUserID.Visible = False
                btnAddItem.Visible = True
                btnAddItem.Select()
            Else
                YesNo = MsgBox("Invalid user ID, do you want to register this customer", vbQuestion + vbYesNo)
                If YesNo = vbYes Then
                    Dim frmAddCus As New frmAddRegisteredCustomer
                    frmAddCus.Show()
                Else : Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim nRow As DataGridViewRow, TotalAmt As Integer = 0
        Dim dbAdapter As MySql.Data.MySqlClient.MySqlDataAdapter, dbTable As New DataTable, dbCommand As MySql.Data.MySqlClient.MySqlCommand, ProdID As Integer
        Try
            connect()
            dbCommand = New MySql.Data.MySqlClient.MySqlCommand("Insert into tblBill(CustomerID,DateofBill,Total) values (" & UID & ",'" & FormatDateTime(Now.Date, DateFormat.ShortDate) & "',0);", dbConnection)
            dbCommand.ExecuteNonQuery()
            For Each nRow In dgridBillDetails.Rows
                If nRow.Cells.Item("ProdName").Value <> "" Then
                    dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select ProductID from tblProductDetails where ProdName = '" & nRow.Cells.Item("ProdName").Value & "';", dbConnection)
                    dbTable.Reset()
                    dbAdapter.Fill(dbTable)
                    ProdID = dbTable.Rows(0).Item(0)
                    dbCommand = New MySql.Data.MySqlClient.MySqlCommand("insert into tblBillDetails values(" & CurrBillNo & "," & ProdID & "," & nRow.Cells.Item("colQuantity").Value & ");", dbConnection)
                    dbCommand.ExecuteNonQuery()
                    dbCommand = New MySql.Data.MySqlClient.MySqlCommand("Update tblProductDetails Set Stock = Stock - " & nRow.Cells.Item("colQuantity").Value & " where ProductID = " & ProdID & ";", dbConnection)
                    dbCommand.ExecuteNonQuery()
                    TotalAmt = TotalAmt + nRow.Cells.Item("colAmount").Value
                End If
            Next
            dbCommand = New MySql.Data.MySqlClient.MySqlCommand("Update tblBill SET Total = " & TotalAmt & " Where BillID = " & CurrBillNo & ";", dbConnection)
            dbCommand.ExecuteNonQuery()
            dbCommand = New MySql.Data.MySqlClient.MySqlCommand("Update tblBill SET Delivered = -1 Where BillID = " & CurrBillNo & ";", dbConnection)
            dbCommand.ExecuteNonQuery()
        Catch exc As Exception
            MsgBox("An error occured while saving the bill" & vbCrLf & "Errorcode: " & exc.Message, MsgBoxStyle.Critical)
        End Try

        Dim dsBill As New DataSet1()
        dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select Distinct ProdName,ProdQty,MRP,Rate,Total,tblBill.BillID" & _
                                         " from tblProductDetails,tblBillDetails,tblBill where tblBillDetails.BillID =" & CurrBillNo & " AND tblProductDetails.ProductID = tblBillDetails.ProductID AND tblBill.BillID = tblBillDetails.BillID;", dbConnection)
        dbAdapter.Fill(dsBill, "bill")
        dbConnection.Close()
        Dim cr As New crBill()
        cr.SetDataSource(dsBill)
        cr.Refresh()
        Dim frmRpt As New frmReport
        frmRpt.CrystalReportViewer1.ReportSource = cr
        frmRpt.CrystalReportViewer1.Refresh()
        frmRpt.WindowState = FormWindowState.Maximized
        frmRpt.ShowDialog()
        cr.Close()
        'frmRpt.CrystalReportViewer1.Dispose()
        Me.Close()
    End Sub

    Private Sub btnSelectID_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSelectID.MouseEnter
        With btnSelectID
            .BackgroundImage = My.Resources.back2
            .Location = New Point(239, 12)
            .Size = New Size(37, 23)
        End With
    End Sub

    Private Sub btnSelectID_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSelectID.MouseLeave
        With btnSelectID
            .BackgroundImage = My.Resources.back1
            .Location = New Point(242, 12)
            .Size = New Size(31, 23)
        End With
    End Sub

    Private Sub btnSave_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.MouseEnter
        With btnSave
            .BackgroundImage = My.Resources.back2
            .Location = New Point(27, 402)
            .Size = New Size(90, 32)
        End With
    End Sub

    Private Sub btnSave_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.MouseLeave
        With btnSave
            .BackgroundImage = My.Resources.back1
            .Location = New Point(31, 402)
            .Size = New Size(82, 32)
        End With
    End Sub

    Private Sub btnAddItem_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddItem.MouseEnter
        With btnAddItem
            .BackgroundImage = My.Resources.back2
            .Location = New Point(360, 402)
            .Size = New Size(94, 32)
        End With
    End Sub

    Private Sub btnAddItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddItem.MouseLeave
        With btnAddItem
            .BackgroundImage = My.Resources.back1
            .Location = New Point(364, 402)
            .Size = New Size(86, 32)
        End With
    End Sub

    Private Sub btnCancelBill_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelBill.MouseEnter
        With btnCancelBill
            .BackgroundImage = My.Resources.back2
            .Location = New Point(465, 402)
            .Size = New Size(94, 32)
        End With
    End Sub

    Private Sub btnCancelBill_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelBill.MouseLeave
        With btnCancelBill
            .BackgroundImage = My.Resources.back1
            .Location = New Point(469, 402)
            .Size = New Size(86, 32)
        End With
    End Sub
End Class