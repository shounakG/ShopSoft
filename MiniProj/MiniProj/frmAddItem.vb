Imports System.Data.OleDb
Public Class frmAddItem
    Dim PicLocation As String = String.Empty

    Private Sub frmAddItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim dbAdapter As MySql.Data.MySqlClient.MySqlDataAdapter, dbTable As New DataTable
            Me.BringToFront()
            connect()
            dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select CatName from tblCategory", dbConnection)
            dbAdapter.Fill(dbTable)
            dbConnection.Close()
            For Each nRow In dbTable.Rows
                txtNewItemCat.Items.Add(nRow.item(0))
            Next
        Catch exc As Exception
            MsgBox("Unable to fetch data from the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtNewItemCat_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNewItemCat.SelectionChangeCommitted
        Try
            Dim dbAdapter As MySql.Data.MySqlClient.MySqlDataAdapter, dbTable As New DataTable
            connect()
            dbTable.Clear()
            dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select SubCatName from tblSubCat where CatID =(Select CatID from tblCategory where CatName = '" & txtNewItemCat.SelectedItem & "')", dbConnection)
            dbAdapter.Fill(dbTable)
            dbConnection.Close()
            For Each nRow In dbTable.Rows
                txtNewItemSubCat.Items.Add(nRow.item(0))
            Next
            txtNewItemSubCat.Visible = True
            txtNewItemCat.Enabled = False
            lblNewItemSubCat.Visible = True
        Catch exc As Exception
            MsgBox("Unable to fetch data from the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtNewItemSubCat_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNewItemSubCat.SelectionChangeCommitted
        Try
            Dim dbAdapter As MySql.Data.MySqlClient.MySqlDataAdapter, dbTable As New DataTable
            connect()
            dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select BrandName from tblBrands;", dbConnection)
            dbTable.Clone()
            dbAdapter.Fill(dbTable)
            dbConnection.Close()
            For Each nRow In dbTable.Rows
                txtNewItemBrand.Items.Add(nRow.item(0))
            Next
            txtNewItemSubCat.Enabled = False
            txtNewItemBrand.Visible = True
            lblNewItemBrand.Visible = True
        Catch exc As Exception
            MsgBox("Unable to fetch data from the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtNewItemBrand_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNewItemBrand.SelectionChangeCommitted
        txtNewItemName.Visible = True
        lblNewItemName.Visible = True
        txtInfo.Visible = True
        lblItemInfo.Visible = True
        txtMRP.Visible = True
        lblMRP.Visible = True
        txtRate.Visible = True
        lblRate.Visible = True
        txtOpeningStock.Visible = True
        lblStock.Visible = True
        txtCriticalStock.Visible = True
        lblCritical.Visible = True
        txtWarranty.Visible = True
        lblWarranty.Visible = True
        txtBarcode.Visible = True
        lblBarcode.Visible = True
        btnAddPhoto.Visible = True
        txtNewItemBrand.Enabled = False
    End Sub

    Private Sub txtMRP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMRP.KeyPress
        Dim KeyAsc As Integer
        KeyAsc = Asc(e.KeyChar)
        Select Case KeyAsc
            Case 48 To 57, 8, 46
            Case Else
                KeyAsc = 0
        End Select
        If KeyAsc = 0 Then
            errInput.SetError(txtMRP, "MRP can be a number only")
            e.Handled = True
        Else
            errInput.Clear()
        End If
    End Sub

    Private Sub txtRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRate.KeyPress
        Dim KeyAsc As Integer
        KeyAsc = Asc(e.KeyChar)
        Select Case KeyAsc
            Case 48 To 57, 8, 46
            Case Else
                KeyAsc = 0
        End Select
        If KeyAsc = 0 Then
            errInput.SetError(txtRate, "Rate can be a number only")
            e.Handled = True
        Else
            errInput.Clear()
        End If
    End Sub

    Private Sub txtOpeningStock_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOpeningStock.KeyPress
        Dim KeyAsc As Integer
        KeyAsc = Asc(e.KeyChar)
        Select Case KeyAsc
            Case 48 To 57, 8
            Case Else
                KeyAsc = 0
        End Select
        If KeyAsc = 0 Then
            errInput.SetError(txtOpeningStock, "Stock can be a number only")
            e.Handled = True
        Else
            errInput.Clear()
        End If
    End Sub

    Private Sub txtCriticalStock_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCriticalStock.KeyPress
        Dim KeyAsc As Integer
        KeyAsc = Asc(e.KeyChar)
        Select Case KeyAsc
            Case 48 To 57, 8
            Case Else
                KeyAsc = 0
        End Select
        If KeyAsc = 0 Then
            errInput.SetError(txtCriticalStock, "Stock can be a number only")
            e.Handled = True
        Else
            errInput.Clear()
        End If
    End Sub

    Private Sub txtWarranty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWarranty.KeyPress
        Dim KeyAsc As Integer
        KeyAsc = Asc(e.KeyChar)
        Select Case KeyAsc
            Case 48 To 57, 8
            Case Else
                KeyAsc = 0
        End Select
        If KeyAsc = 0 Then
            errInput.SetError(txtWarranty, "Warranty can be a number only")
            e.Handled = True
        Else
            errInput.Clear()
        End If
    End Sub

    Private Sub txtBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        Dim KeyAsc As Integer
        KeyAsc = Asc(e.KeyChar)
        Select Case KeyAsc
            Case 48 To 57, 8
            Case Else
                KeyAsc = 0
        End Select
        If KeyAsc = 0 Then
            errInput.SetError(txtBarcode, "Barcode can be a number only")
            e.Handled = True
        Else
            errInput.Clear()
        End If
    End Sub

    Private Sub txtNewItemName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNewItemName.KeyPress
        Select Case Asc(e.KeyChar)
            Case 34, 39
                e.Handled = True
        End Select
    End Sub

    Private Sub txtNewItemName_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNewItemName.Leave
        Try
            Dim dbAdapter As MySql.Data.MySqlClient.MySqlDataAdapter, dbTable As New DataTable
            connect()
            dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select ProductID from tblProductDetails where ProdName = '" & txtNewItemName.Text & "';", dbConnection)
            dbAdapter.Fill(dbTable)
            dbConnection.Close()
            If dbTable.Rows.Count <> 0 Then
                MsgBox("Product already exists. The window will now close", vbCritical + vbOKOnly)
                Me.Close()
            End If
        Catch exc As Exception
            MsgBox("Unable to fetch data from the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnAddPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPhoto.Click
        With openPicture
            .Multiselect = False
            .Title = "Browse for file"
            .ShowDialog()
        End With
        PicLocation = openPicture.FileName
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim OK As Boolean
        OK = Validation()
        If OK = False Then
            MsgBox("One of the fields cannot be blank" & vbCrLf & _
                   "Check whether you have selected a photo or not", vbInformation + vbOKOnly)
        ElseIf txtBarcode.Text.Length <> 13 Then
            MsgBox("Length of the barcode must be 13 numbers long", vbInformation + MsgBoxStyle.OkOnly)
        Else
            AddItemToDB()
            Me.Close()
        End If
    End Sub

    Private Function Validation() As Boolean
        If txtBarcode.Text = "" Then
            Return False
        ElseIf txtCriticalStock.Text = "" Then
            Return False
        ElseIf txtInfo.Text = "" Then
            Return False
        ElseIf txtMRP.Text = "" Then
            Return False
        ElseIf txtNewItemName.Text = "" Then
            Return False
        ElseIf txtOpeningStock.Text = "" Then
            Return False
        ElseIf txtRate.Text = "" Then
            Return False
        ElseIf txtWarranty.Text = "" Then
            Return False
        End If
        Return True
    End Function

    Private Sub AddItemToDB()
        Try
            Dim dbCommand As MySql.Data.MySqlClient.MySqlCommand, SubCatID As Integer, BrandID As Integer, dtSubCat As New DataTable, dtBrand As New DataTable
            Dim dtProdID As New DataTable, ProdID As Integer, PhotoPath As String
            connect()
            Dim da As New MySql.Data.MySqlClient.MySqlDataAdapter("Select SubCatID from tblSubCat where SubCatName = '" & txtNewItemSubCat.SelectedItem & "';", dbConnection)
            dtSubCat.Clear()
            da.Fill(dtSubCat)
            SubCatID = dtSubCat.Rows(0).Item(0)
            da = New MySql.Data.MySqlClient.MySqlDataAdapter("Select BrandID from tblBrands where BrandName = '" & txtNewItemBrand.SelectedItem & "';", dbConnection)
            dtBrand.Clear()
            da.Fill(dtBrand)
            BrandID = dtBrand.Rows(0).Item(0)
            dbCommand = New MySql.Data.MySqlClient.MySqlCommand("Insert into tblProducts(SubcatID,BrandID,ThumbsUp,ThumbsDown) values (" & _
                                         SubCatID & "," & BrandID & ",0,0);", dbConnection)
            dbCommand.ExecuteNonQuery()
            da = New MySql.Data.MySqlClient.MySqlDataAdapter("Select Max(ProductID) from tblProducts", dbConnection)
            da.Fill(dtProdID)
            ProdID = dtProdID.Rows(0).Item(0)
            PhotoPath = "noimage.jpg"
            IO.File.Copy(PicLocation, PhotoPath)
            dbCommand = New MySql.Data.MySqlClient.MySqlCommand("Insert into tblProductDetails values(" & _
                                       ProdID & ",'" & txtNewItemName.Text & "'," & Val(txtMRP.Text) & "," & _
                                       Val(txtRate.Text) & ",'" & txtInfo.Text & "'," & Val(txtOpeningStock.Text) & "," & _
                                       Val(txtCriticalStock.Text) & ",'" & PhotoPath & "'," & Val(txtWarranty.Text) & "," & _
                                       Val(txtBarcode.Text) & ");", dbConnection)
            dbCommand.ExecuteNonQuery()
            dbConnection.Close()
            MsgBox("New item inserted", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        Catch exc As Exception
            MsgBox("Unable to update the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Dim YesNo As Integer
        YesNo = MsgBox("Cancel adding item", vbQuestion + vbYesNo)
        If YesNo = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub txtInfo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInfo.KeyPress
        Select Case Asc(e.KeyChar)
            Case 34, 39
                e.Handled = True
        End Select
    End Sub
End Class