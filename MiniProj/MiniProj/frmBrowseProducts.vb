Imports System.Data.OleDb
Public Class frmBrowseProducts
    Dim ReadyToDisplay As Boolean = False
    Dim SelectedProd As String

    Private Sub frmBrowseProducts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim dbAdapter As MySql.Data.MySqlClient.MySqlDataAdapter, dbTable As New DataTable, Index As Integer = 0
            Dim SubCatTable As New DataTable
            Me.MdiParent = frmMain
            Me.BringToFront()
            connect()
            dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select CatName from tblCategory", dbConnection)
            dbAdapter.Fill(dbTable)
            For Each nRow In dbTable.Rows
                tvProducts.Nodes.Add(Index.ToString, nRow.item(0))
                dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select SubCatName from tblSubCat where CatID = " & _
                                                  "(Select CatID from tblCategory where CatName = '" & nRow.item(0) & "')", dbConnection)
                SubCatTable.Clear()
                dbAdapter.Fill(SubCatTable)
                For Each dRow In SubCatTable.Rows
                    tvProducts.Nodes(Index).Nodes.Add(dRow.item(0))
                Next
                Index += 1
            Next
            dbConnection.Close()
        Catch exc As Exception
            MsgBox("An error occured while connecting to the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub tvProducts_AfterCollapse(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvProducts.AfterCollapse
        ReadyToDisplay = False
    End Sub

    Private Sub tvProducts_AfterExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvProducts.AfterExpand
        ReadyToDisplay = True
    End Sub

    Private Sub tvProducts_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvProducts.AfterSelect
        Try
            Dim dbAdapter As MySql.Data.MySqlClient.MySqlDataAdapter, dbTable As New DataTable
            If ReadyToDisplay = True Then
                dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select ProdName,Information,MRP,Rate,Stock from tblProductDetails where ProductID IN " & _
                                                  "(Select ProductID from tblProducts where SubCatID IN " & _
                                                   "(Select SubCatID from tblSubCat where SubCatName = '" & tvProducts.SelectedNode.Text & "'));", dbConnection)
                dbAdapter.Fill(dbTable)
                dbConnection.Close()
                dgridFilteredProducts.Visible = True
                dgridFilteredProducts.DataSource = dbTable
                dgridFilteredProducts.Update()
            End If
        Catch exc As Exception
            MsgBox("An error occured while connecting to the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub dgridFilteredProducts_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgridFilteredProducts.CellDoubleClick
        Try
            SelectedProd = dgridFilteredProducts.SelectedRows.Item(0).Cells.Item(0).Value
            Dim dbAdapter As MySql.Data.MySqlClient.MySqlDataAdapter, dbTable As New DataTable
            connect()
            dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select * from tblProductDetails where ProdName = '" & SelectedProd & "';", dbConnection)
            dbAdapter.Fill(dbTable)
            dbConnection.Close()
            FillDetails(dbTable.Rows(0))
            Me.Close()
            frmItemInventory.Show()
            frmItemInventory.tbProducts.Visible = True
            frmItemInventory.txtFeatures.ReadOnly = False
            frmItemInventory.txtProdMRP.ReadOnly = False
            frmItemInventory.txtProdRate.ReadOnly = False
            frmItemInventory.txtCriticalStock.ReadOnly = False
            frmItemInventory.btnNext.Visible = False
            frmItemInventory.btnNext2.Visible = False
            frmItemInventory.btnAddItem.Visible = False
            frmItemInventory.btnCommit.Visible = True
            frmItemInventory.btnCancelChange.Visible = True
            frmItemInventory.btnEdit.Visible = False
            frmItemInventory.grpIndividual.Visible = False
            frmItemInventory.chkViews.Visible = False
        Catch exc As Exception
            MsgBox("An error occured while connecting to the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub FillDetails(ByVal dbRow As DataRow)
        Try
            Dim dbAdapter As MySql.Data.MySqlClient.MySqlDataAdapter, tblBrand As New DataTable
            frmItemInventory.txtProdName.Text = dbRow.Item("ProdName")
            frmItemInventory.txtFeatures.Text = dbRow.Item("Information")
            frmItemInventory.txtProdMRP.Text = dbRow.Item("MRP")
            frmItemInventory.txtProdRate.Text = dbRow.Item("Rate")
            frmItemInventory.txtStock.Text = dbRow.Item("Stock")
            frmItemInventory.txtCriticalStock.Text = dbRow.Item("CriticalStock")
            frmItemInventory.picProdPhoto.Image = getPicture(dbRow.Item("Photos"))
            connect()
            dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select BrandName from tblBrands where BrandID = (Select BrandID from tblProducts where ProductID = (Select ProductID from tblProductDetails where ProdName = '" & SelectedProd & "'));", dbConnection)
            dbAdapter.Fill(tblBrand)
            dbConnection.Close()
            frmItemInventory.txtProdBrand.Text = tblBrand.Rows(0).Item(0)
        Catch exc As Exception
            MsgBox("An error occured while connecting to the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class