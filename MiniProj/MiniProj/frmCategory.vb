Imports System.Data.OleDb
Public Class frmCategory
    Dim CatAdd As Boolean = False, SubCatAdd As Boolean = False, BrandAdd As Boolean = False

    Private Sub frmCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillTables()
        If IsNew = False Then
            Me.ControlBox = False
        End If
    End Sub

    Private Sub btnAddCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCat.Click
        Dim frmAdd As New frmAddCat
        If IsNew = False Then
            frmAdd.btnCancel.Enabled = False
        End If
        frmAdd.ShowDialog()
        FillTables()
        CatAdd = True
        If UpdateDone(CatAdd, SubCatAdd, BrandAdd) = True Then Me.ControlBox = True
    End Sub

    Private Sub btnAddSubCat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddSubCat.Click
        Dim frmAdd As New frmAddSubCat
        If IsNew = False Then
            frmAdd.btnCancel.Enabled = False
        End If
        frmAdd.ShowDialog()
        FillTables()
        SubCatAdd = True
        If UpdateDone(CatAdd, SubCatAdd, BrandAdd) = True Then Me.ControlBox = True
    End Sub

    Private Sub btnDeleteCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteCat.Click
        Try
            Dim SelectedCat As String, YesNo As Integer
            SelectedCat = dgvCategories.SelectedRows.Item(0).Cells.Item("CatName").Value
            YesNo = MsgBox("Deleting this category will cause all sub-categories to be unusable" & vbCrLf & "Sure to delete", vbQuestion + vbYesNo)
            If YesNo = vbYes Then
                connect()
                Dim dbCommand As New MySql.Data.MySqlClient.MySqlCommand("Delete from tblCategory where CatName = '" & SelectedCat & "';", dbConnection)
                dbCommand.ExecuteNonQuery()
                MsgBox("Category deleted successfully", MsgBoxStyle.Information)
                dbConnection.Close()
                FillTables()
            End If
        Catch exc As Exception
            MsgBox("An error occured while connecting to the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub dgvCategories_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCategories.CellClick
        btnDeleteCat.Visible = True
    End Sub

    Private Sub btnDelSubCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelSubCat.Click
        Try
            Dim Selected As String, YesNo As Integer
            Selected = dgvSubCat.SelectedRows.Item(0).Cells.Item("SubCatName").Value
            YesNo = MsgBox("Deleting this sub-category will cause all its products to be unusable" & vbCrLf & "Sure to delete", vbQuestion + vbYesNo)
            If YesNo = vbYes Then
                connect()
                Dim dbCommand As New MySql.Data.MySqlClient.MySqlCommand("Delete from tblSubCat where SubCatName = '" & Selected & "';", dbConnection)
                dbCommand.ExecuteNonQuery()
                MsgBox("Sub category deleted successfully", MsgBoxStyle.Information)
                dbConnection.Close()
                FillTables()
            End If
        Catch exc As Exception
            MsgBox("An error occured while connecting to the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub dgvSubCat_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSubCat.CellClick
        btnDelSubCat.Visible = True
    End Sub

    Private Sub btnAddBrand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddBrand.Click
        Dim frmAdd As New frmAddBrand
        If IsNew = False Then
            frmAdd.btnCancel.Enabled = False
        End If
        frmAdd.ShowDialog()
        FillTables()
        BrandAdd = True
        If UpdateDone(CatAdd, SubCatAdd, BrandAdd) = True Then Me.ControlBox = True
    End Sub

    Private Sub FillTables()
        Try
            Dim tblCat As New DataTable, tblSubCat As New DataTable, tblBrands As New DataTable
            connect()
            Dim dbQuery As New MySql.Data.MySqlClient.MySqlDataAdapter("select CatID,CatName from tblCategory;", dbConnection)
            dbQuery.Fill(tblCat)
            dgvCategories.DataSource = tblCat
            dbQuery = New MySql.Data.MySqlClient.MySqlDataAdapter("select SubCatID,SubCatName from tblSubCat;", dbConnection)
            dbQuery.Fill(tblSubCat)
            dgvSubCat.DataSource = tblSubCat
            dbQuery = New MySql.Data.MySqlClient.MySqlDataAdapter("select BrandName from tblBrands;", dbConnection)
            dbQuery.Fill(tblBrands)
            dgvBrands.DataSource = tblBrands
            dbConnection.Close()
        Catch exc As Exception
            MsgBox("An error occured while connecting to the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Function UpdateDone(ByVal Cat As Boolean, ByVal SubCat As Boolean, ByVal Brand As Boolean) As Boolean
        If Cat = True And SubCat = True And Brand = True Then Return True
        Return False
    End Function

    Private Sub btnAddCat_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddCat.MouseEnter
        With btnAddCat
            .Location = New Point(85, 360)
            .Size = New Size(114, 31)
            .BackgroundImage = My.Resources.back2
        End With
    End Sub

    Private Sub btnAddCat_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddCat.MouseLeave
        With btnAddCat
            .Location = New Point(90, 360)
            .Size = New Size(109, 31)
            .BackgroundImage = My.Resources.back1
        End With
    End Sub

    Private Sub btnDeleteCat_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDeleteCat.MouseEnter
        With btnDeleteCat
            .Location = New Point(200, 360)
            .Size = New Size(104, 31)
            .BackgroundImage = My.Resources.back2
        End With
    End Sub

    Private Sub btnDeleteCat_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDeleteCat.MouseLeave
        With btnDeleteCat
            .Location = New Point(205, 360)
            .Size = New Size(94, 31)
            .BackgroundImage = My.Resources.back1
        End With
    End Sub

    Private Sub btnAddSubCat_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddSubCat.MouseEnter
        With btnAddSubCat
            .Location = New Point(72, 354)
            .Size = New Size(120, 40)
            .BackgroundImage = My.Resources.back2
        End With
    End Sub

    Private Sub btnAddSubCat_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddSubCat.MouseLeave
        With btnAddSubCat
            .Location = New Point(77, 354)
            .Size = New Size(110, 40)
            .BackgroundImage = My.Resources.back1
        End With
    End Sub

    Private Sub btnDelSubCat_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelSubCat.MouseEnter
        With btnDelSubCat
            .Location = New Point(200, 354)
            .Size = New Size(103, 40)
            .BackgroundImage = My.Resources.back2
        End With
    End Sub

    Private Sub btnDelSubCat_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelSubCat.MouseLeave
        With btnDelSubCat
            .Location = New Point(204, 354)
            .Size = New Size(98, 40)
            .BackgroundImage = My.Resources.back1
        End With
    End Sub

    Private Sub btnAddBrand_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddBrand.MouseEnter
        With btnAddBrand
            .Location = New Point(215, 361)
            .Size = New Size(87, 34)
            .BackgroundImage = My.Resources.back2
        End With
    End Sub

    Private Sub btnAddBrand_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddBrand.MouseLeave
        With btnAddBrand
            .Location = New Point(220, 361)
            .Size = New Size(77, 34)
            .BackgroundImage = My.Resources.back1
        End With
    End Sub
End Class