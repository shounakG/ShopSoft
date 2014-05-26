Imports System.Data.OleDb
Public Class frmUpdateStock
    Dim dbTable As New DataTable, SelProd As String = String.Empty, NewStock As String

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            Dim dbadapter As MySql.Data.MySqlClient.MySqlDataAdapter
            dbTable.Rows.Clear()
            connect()
            dbadapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select ProdName,Stock from tblProductDetails where ProdName like '%" & txtSearch.Text & "%';", dbConnection)
            dbadapter.Fill(dbTable)
            dbConnection.Close()
            If dbTable.Rows.Count <> 0 Then
                errSearch.Clear()
                dgridSearch.DataSource = dbTable
                dgridSearch.Update()
            Else
                errSearch.SetError(txtSearch, "Product name not found")
                btnEditStock.Visible = False
            End If
        Catch exc As Exception
            MsgBox("An error occured while connecting to the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub frmUpdateStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BringToFront()
        txtSearch.Select()
    End Sub

    Private Sub dgridSearch_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgridSearch.CellClick
        btnEditStock.Visible = True
        SelProd = dgridSearch.SelectedRows.Item(0).Cells.Item("ProdName").Value
        
    End Sub

    Private Sub btnEditStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditStock.Click
        Try
            NewStock = InputBox("Enter the new stock", "Update stock details")
            If NewStock <> String.Empty Then
                connect()
                Dim dbCommand As New MySql.Data.MySqlClient.MySqlCommand("Update tblProductDetails Set Stock = " & Val(NewStock) & " Where ProdName = '" & SelProd & "';", dbConnection)
                dbCommand.ExecuteNonQuery()
                dbConnection.Close()
                MsgBox("Stock details updated", vbInformation + MsgBoxStyle.OkOnly)
                dgridSearch.SelectedRows.Item(0).Cells.Item("Stock").Value = NewStock
            End If
        Catch exc As Exception
            MsgBox("An error occured while updating the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnEditStock_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditStock.MouseEnter
        With btnEditStock
            .Location = New Point(174, 377)
            .Size = New Size(89, 30)
            .BackgroundImage = My.Resources.back2
        End With
    End Sub

    Private Sub btnEditStock_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditStock.MouseLeave
        With btnEditStock
            .Location = New Point(177, 377)
            .Size = New Size(83, 30)
            .BackgroundImage = My.Resources.back1
        End With
    End Sub

    Private Sub btnClose_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.MouseEnter
        With btnClose
            .Location = New Point(263, 377)
            .Size = New Size(89, 30)
            .BackgroundImage = My.Resources.back2
        End With
    End Sub

    Private Sub btnClose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.MouseLeave
        With btnClose
            .Location = New Point(266, 377)
            .Size = New Size(83, 30)
            .BackgroundImage = My.Resources.back1
        End With
    End Sub
End Class