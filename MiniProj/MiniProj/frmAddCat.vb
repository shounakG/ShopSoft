Imports System.Data.OleDb
Public Class frmAddCat

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            Dim dbCommand As MySql.Data.MySqlClient.MySqlCommand, YesNo As Integer, PhotoPath As String
            If txtCatName.Text <> String.Empty Then
                Dim dbAdapter As MySql.Data.MySqlClient.MySqlDataAdapter, dbTable As New DataTable
                connect()
                dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select CatName from tblCategory Where CatName = '" & txtCatName.Text & "';", dbConnection)
                dbAdapter.Fill(dbTable)
                If dbTable.Rows.Count = 0 Then
                    With selPic
                        .ShowDialog()
                    End With
                    PhotoPath = "noimage.jpg"
                    'IO.File.Copy(selPic.FileName, PhotoPath)
                    dbCommand = New MySql.Data.MySqlClient.MySqlCommand("insert into tblCategory(CatName,Photos) values('" & txtCatName.Text & "','" & PhotoPath & "');", dbConnection)
                    dbCommand.ExecuteNonQuery()
                    YesNo = MsgBox("Category added successfully", vbInformation + MsgBoxStyle.OkOnly)
                    dbConnection.Close()
                    Me.Close()
                Else
                    errAddCat.SetError(txtCatName, "Category name already exists")
                End If
                dbConnection.Close()
            Else
                MsgBox("Enter something as category name", MsgBoxStyle.Critical)
            End If
        Catch
            MsgBox("An error occured while trying to save the category", MsgBoxStyle.Critical)
            Me.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Dim YesNo As Integer
        YesNo = MsgBox("Cancel adding category and close", vbQuestion + vbYesNo)
        If YesNo = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub txtCatName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCatName.TextChanged
        errAddCat.Clear()
    End Sub

    Private Sub btnAdd_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.MouseEnter
        With btnAdd
            .Size = New Size(81, 23)
            .Location = New Point(45, 122)
            .BackgroundImage = My.Resources.back2
        End With
    End Sub

    Private Sub btnAdd_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.MouseLeave
        With btnAdd
            .Size = New Size(75, 23)
            .Location = New Point(48, 122)
            .BackgroundImage = My.Resources.back1
        End With
    End Sub

    Private Sub btnCancel_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.MouseEnter
        With btnCancel
            .Size = New Size(81, 23)
            .Location = New Point(162, 122)
            .BackgroundImage = My.Resources.back2
        End With
    End Sub

    Private Sub btnCancel_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.MouseLeave
        With btnCancel
            .Size = New Size(75, 23)
            .Location = New Point(165, 122)
            .BackgroundImage = My.Resources.back1
        End With
    End Sub

    Private Sub frmAddCat_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.BringToFront()
    End Sub
End Class