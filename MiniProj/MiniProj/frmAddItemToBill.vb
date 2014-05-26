Imports System.Data.OleDb
Public Class frmAddItemToBill
    Dim dbTable As New DataTable, SearchBy As String, Cancelled As Boolean = False

    Private Function GetProduct(ByVal query As String) As Integer
        Dim dbadapter As MySql.Data.MySqlClient.MySqlDataAdapter
        dbTable.Rows.Clear()
        connect()
        dbadapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select ProdName,MRP,Stock,Bar_Code from tblProductDetails where " & query & " like '%" & txtString.Text & "%';", dbConnection)
        dbadapter.Fill(dbTable)
        dbConnection.Close()
        Return dbTable.Rows.Count
    End Function

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        OKtoAdd = False
        Cancelled = True
        Me.Close()
    End Sub

    Private Sub txtString_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtString.KeyPress
        Select Case Asc(e.KeyChar)
            Case 34, 39
                e.Handled = True
        End Select
    End Sub

    Private Sub txtString_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtString.TextChanged
        Dim srcNo As Integer
        If txtString.Text <> "" Then
            Select Case SearchBy
                Case "ProdName"
                    srcNo = GetProduct(SearchBy)
                Case "Bar_Code"
                    srcNo = GetProduct(SearchBy)
            End Select
            If srcNo > 0 Then
                dgridSrcResults.Enabled = True
                errSearch.Clear()
            Else
                dgridSrcResults.Enabled = False
                errSearch.SetError(txtString, "No search results found")
            End If
        Else
            dbTable.Clear()
            errSearch.Clear()
        End If
        dgridSrcResults.Update()
    End Sub

    Private Sub frmAddItemToBill_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If Cancelled = False Then
                If dgridSrcResults.Rows.Count <> 0 Then
                    Dim dbAdapter As MySql.Data.MySqlClient.MySqlDataAdapter, dbTable As New DataTable, Response As Integer
                    connect()
                    dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select Stock,CriticalStock from tblProductDetails where ProdName = '" & ItemAdded & "';", dbConnection)
                    dbAdapter.Fill(dbTable)
                    If Val(txtQuantity.Text) > dbTable.Rows(0).Item(0) Then
                        Response = MsgBox("The product stock present is less than quantity you've added" & (Chr(10) & Chr(13)) & "Continue adding", MsgBoxStyle.YesNo)
                        If Response = vbNo Then
                            OKtoAdd = False
                        End If
                    ElseIf dbTable.Rows(0).Item(0) < dbTable.Rows(0).Item(1) Then
                        MsgBox("The product has reached its critical value" & (Chr(10) & Chr(13)) & "Consider re-ordering it", MsgBoxStyle.Critical)
                    End If
                    dbConnection.Close()
                    AddtoBill()
                End If
            End If
        Catch exc As Exception
            MsgBox("Unable to fetch data from the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub frmAddItemToBill_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.BringToFront()
        Me.txtString.Focus()
        dgridSrcResults.DataSource = dbTable
        ItemQuantity = 0
        OKtoAdd = False
    End Sub

    Private Sub rbSrcName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSrcName.CheckedChanged
        If rbSrcName.Checked = True Then
            SearchBy = "ProdName"
        ElseIf rbProdId.Checked = True Then
            SearchBy = "Bar_Code"
        End If
    End Sub

    Private Sub dgridSrcResults_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgridSrcResults.CellDoubleClick
        ItemAdded = dgridSrcResults.SelectedRows.Item(0).Cells.Item(0).Value
        OKtoAdd = True
        lblQuantity.Visible = True
        txtQuantity.Visible = True
        txtQuantity.Select()
    End Sub

    Private Sub txtQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantity.KeyPress
        Dim KeyAsc As Integer
        KeyAsc = Asc(e.KeyChar)
        Select Case KeyAsc
            Case 48 To 57, 8
                errSearch.Clear()
            Case 13
                ItemQuantity = Val(txtQuantity.Text)
                frmBillRegistered.btnSave.Visible = True
                Me.Close()
            Case Else
                KeyAsc = 0
        End Select
        If KeyAsc = 0 Then
            e.Handled = True
            errSearch.SetError(txtQuantity, "Invalid quantity")
        Else
            e.Handled = False
            errSearch.Clear()
        End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        ItemQuantity = Val(txtQuantity.Text)
        frmBillRegistered.btnSave.Visible = True
        Me.Close()
    End Sub

    Private Sub btnOK_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.MouseEnter
        With btnOK
            .BackgroundImage = My.Resources.back2
            .Size = New Size(87, 31)
            .Location = New Point(366, 332)
        End With
    End Sub

    Private Sub btnOK_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.MouseLeave
        With btnOK
            .BackgroundImage = My.Resources.back1
            .Size = New Size(79, 31)
            .Location = New Point(370, 332)
        End With
    End Sub

    Private Sub btnCancel_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.MouseEnter
        With btnCancel
            .BackgroundImage = My.Resources.back2
            .Size = New Size(87, 31)
            .Location = New Point(451, 332)
        End With
    End Sub

    Private Sub btnCancel_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.MouseLeave
        With btnCancel
            .BackgroundImage = My.Resources.back1
            .Size = New Size(79, 31)
            .Location = New Point(455, 332)
        End With
    End Sub
End Class