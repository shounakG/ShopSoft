Imports System.Data.OleDb
Public Class frmItemInventory
    Dim productNo As Integer = 0, dbTable As New DataTable, srcResults As Integer
    Dim srcTxt As Integer, srcIndex As Integer = 0, srcTable As New DataTable

    Private Sub btnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItem.Click
        Dim frmAdd As New frmAddItem
        frmAdd.ShowDialog()
    End Sub

    Private Sub frmItemInventory_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim dbAdapter As MySql.Data.MySqlClient.MySqlDataAdapter, dbTable As New DataTable
            Me.MdiParent = frmMain
            txtCategories.Items.Clear()
            connect()
            dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select * from tblCategory", dbConnection)
            dbAdapter.Fill(dbTable)
            dbConnection.Close()
            For Each nRow In dbTable.Rows
                txtCategories.Items.Add(nRow.item(1))
            Next
        Catch exc As Exception
            MsgBox("An error occured while fetching the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtCategories_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCategories.SelectionChangeCommitted
        Try
            Dim dbAdapter As MySql.Data.MySqlClient.MySqlDataAdapter, dbTable As New DataTable
            connect()
            txtSubCat.Items.Clear()
            dbTable.Clear()
            dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select SubCatName from tblSubCat where CatID = " & _
                                             "(Select CatID from tblCategory where CatName = '" & txtCategories.SelectedItem & "')", dbConnection)
            dbAdapter.Fill(dbTable)
            dbConnection.Close()
            For Each nRow In dbTable.Rows
                txtSubCat.Items.Add(nRow.item(0))
            Next
            txtSubCat.Visible = True
            'txtCategories.Enabled = False
        Catch exc As Exception
            MsgBox("An error occured while fetching the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtSubCat_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSubCat.SelectionChangeCommitted
        Try
            Dim dbAdapter As MySql.Data.MySqlClient.MySqlDataAdapter, YesNo As Integer
            connect()
            dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select * from tblProductDetails where ProductID IN " & _
                                             "(Select ProductID from tblProducts where SubCatID IN " & _
                                              "(Select SubCatID from tblSubCat where SubCatName = '" & txtSubCat.SelectedItem & "'));", dbConnection)
            dbTable.Clear()
            dbAdapter.Fill(dbTable)
            dbConnection.Close()
            srcResults = dbTable.Rows.Count
            If srcResults = 0 Then
                YesNo = MsgBox("Your selected category doesn't contain any values" & vbCrLf & "Add some now", vbCritical + vbYesNo)
                If YesNo = vbYes Then
                    Dim frmAdd As New frmAddItem
                    frmAdd.ShowDialog()
                    connect()
                    dbAdapter.Fill(dbTable)
                    dbConnection.Close()
                Else
                    Me.Close()
                End If
            End If
            btnNext.Visible = True
            tbProducts.Visible = True
            'txtSubCat.Enabled = False
            grpSearch.Visible = True
            FillDetails(dbTable.Rows(0))
            productNo = 0
        Catch exc As Exception
            MsgBox("An error occured while fetching the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub FillDetails(ByVal dbRow As DataRow)
        Try
            Dim dbAdapter As MySql.Data.MySqlClient.MySqlDataAdapter, tblBrand As New DataTable
            txtProdName.Text = dbRow.Item("ProdName")
            txtFeatures.Text = dbRow.Item("Information")
            txtProdMRP.Text = dbRow.Item("MRP")
            txtProdRate.Text = dbRow.Item("Rate")
            txtStock.Text = dbRow.Item("Stock")
            txtCriticalStock.Text = dbRow.Item("CriticalStock")
            picProdPhoto.Image = getPicture(dbRow.Item("Photos"))
            connect()
            dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select BrandName from tblBrands where BrandID = " & _
                                             "(Select BrandID from tblProducts where ProductID = " & _
                                              "(Select ProductID from tblProductDetails where ProdName = '" & txtProdName.Text & "'));", dbConnection)
            dbAdapter.Fill(tblBrand)
            dbConnection.Close()
            txtProdBrand.Text = tblBrand.Rows(0).Item(0)
        Catch exc As Exception
            MsgBox("An error occured while fetching the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        productNo += 1
        If productNo < srcResults Then
            FillDetails(dbTable.Rows(productNo))
        Else
            FillDetails(dbTable.Rows(0))
            productNo = 0
        End If
    End Sub

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim dbCommand As MySql.Data.MySqlClient.MySqlCommand
            With openPic
                .Filter = "Image files(*.jpg)|*.jpg"
                .Title = "Select new picture"
                .ShowDialog()
            End With
            picProdPhoto.ImageLocation = openPic.FileName
            connect()
            dbCommand = New MySql.Data.MySqlClient.MySqlCommand("UPDATE tblProductDetails SET Photos = '" & openPic.FileName & "' WHERE ProdName = '" & txtProdName.Text & "';", dbConnection)
            dbCommand.ExecuteNonQuery()
            dbConnection.Close()
        Catch exc As Exception
            MsgBox("An error occured while updating the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearch.KeyPress
        Select Case Asc(e.KeyChar)
            Case 34, 39
                e.Handled = True
        End Select
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            Dim dbAdapter As MySql.Data.MySqlClient.MySqlDataAdapter
            connect()
            srcTable.Clear()
            dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select * from tblProductDetails where ProdName LIKE '%" & txtSearch.Text & "%' AND ProductID IN (Select ProductID from tblProducts where SubCatID IN (Select SubCatID from tblSubCat where SubCatName = '" & txtSubCat.SelectedItem & "'));", dbConnection)
            dbAdapter.Fill(srcTable)
            srcTxt = srcTable.Rows.Count
            dbConnection.Close()
            Select Case srcTxt
                Case Is > 1
                    tbProducts.Visible = True
                    FillDetails(srcTable.Rows(0))
                    errSearch.Clear()
                    btnNext.Visible = False
                    btnNext2.Enabled = True
                    btnNext2.Visible = True
                Case Is = 0 Or 1
                    tbProducts.Visible = True
                    FillDetails(srcTable.Rows(0))
                    errSearch.Clear()
                    btnNext.Visible = False
                Case Else
                    errSearch.SetError(txtSearch, "No search results found")
                    'FillDetails(dbTable.Rows(0))
                    tbProducts.Visible = False
                    btnDelete.Visible = False
                    btnEdit.Visible = False
            End Select
        Catch exc As Exception
            MsgBox("An error occured while fetching the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnNext2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext2.Click
        srcIndex += 1
        If srcIndex < srcTxt Then
            FillDetails(srcTable.Rows(srcIndex))
        Else
            FillDetails(srcTable.Rows(0))
            srcIndex = 0
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        txtFeatures.ReadOnly = False
        txtProdMRP.ReadOnly = False
        txtProdRate.ReadOnly = False
        txtCriticalStock.ReadOnly = False
        btnNext.Visible = False
        btnNext2.Visible = False
        btnAddItem.Visible = False
        btnCommit.Visible = True
        btnCancelChange.Visible = True
        btnEdit.Visible = False
    End Sub

    Private Sub btnCancelChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelChange.Click
        Dim YesNo As Integer
        YesNo = MsgBox("Cancel changes and exit", vbQuestion + vbYesNo)
        If YesNo = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        Try
            Dim YesNo As Integer, dbCommand As MySql.Data.MySqlClient.MySqlCommand
            YesNo = MsgBox("Commit changes to the product", vbQuestion + vbYesNo)
            If YesNo = vbYes Then
                connect()
                dbCommand = New MySql.Data.MySqlClient.MySqlCommand("UPDATE tblProductDetails SET " & _
                                             "MRP = " & Val(txtProdMRP.Text) & "," & _
                                             "Rate = " & Val(txtProdRate.Text) & "," & _
                                             "Information = '" & txtFeatures.Text & "'," & _
                                             "CriticalStock = " & Val(txtCriticalStock.Text) & " WHERE " & _
                                             "ProdName = '" & txtProdName.Text & "';", dbConnection)
                dbCommand.ExecuteNonQuery()
                MsgBox("Changes committed successfully", vbInformation + vbOKOnly)
                dbConnection.Close()
                txtFeatures.ReadOnly = True
                txtProdMRP.ReadOnly = True
                txtProdRate.ReadOnly = True
                txtCriticalStock.ReadOnly = True
                btnNext.Visible = True
                btnAddItem.Visible = True
                btnCommit.Visible = False
                btnCancelChange.Visible = False
                btnEdit.Visible = True
            End If
        Catch exc As Exception
            MsgBox("An error occured while updating the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtProdName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProdName.TextChanged
        btnDelete.Visible = True
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            Dim dbCommand As MySql.Data.MySqlClient.MySqlCommand, YesNo As Integer
            YesNo = MsgBox("Do you really want to delete this item", MsgBoxStyle.Question + vbYesNo)
            If YesNo = vbYes Then
                connect()
                dbCommand = New MySql.Data.MySqlClient.MySqlCommand("Delete from tblProducts where ProductID = " & _
                                            "(Select ProductID from tblProductDetails where ProdName = '" & txtProdName.Text & "')", dbConnection)
                dbCommand.ExecuteNonQuery()
                dbCommand = New MySql.Data.MySqlClient.MySqlCommand("Delete from tblProductDetails where ProdName = '" & txtProdName.Text & "';", dbConnection)
                dbCommand.ExecuteNonQuery()
                dbConnection.Close()
                MsgBox("The product has been deleted", vbInformation)
            End If
            Me.Close()
        Catch exc As Exception
            MsgBox("An error occured while updating the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub chkViews_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkViews.CheckedChanged
        If chkViews.Checked = True Then
            frmBrowseProducts.Show()
            chkViews.Checked = False
            Me.Close()
        End If
    End Sub

    Private Sub txtFeatures_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFeatures.KeyPress
        Select Case Asc(e.KeyChar)
            Case 34, 39
                e.Handled = True
        End Select
    End Sub

    Private Sub txtProdMRP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProdMRP.KeyPress
        Select Case Asc(e.KeyChar)
            Case 34, 39
                e.Handled = True
            Case 48 To 57, 8
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtProdRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProdRate.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8
            Case Else
                e.Handled = True
        End Select
    End Sub

End Class
