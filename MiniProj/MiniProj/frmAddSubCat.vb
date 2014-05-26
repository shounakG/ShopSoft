Imports System.Data.OleDb
Public Class frmAddSubCat

    Private Sub txtSubCatName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSubCatName.KeyPress
        Select Case Asc(e.KeyChar)
            Case 34, 39
                e.Handled = True
        End Select
    End Sub

    Private Sub txtSubCatName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubCatName.TextChanged
        errSubCat.Clear()
    End Sub

    Private Sub frmAddSubCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dbAdapter As MySql.Data.MySqlClient.MySqlDataAdapter, dbTable As New DataTable
        Me.BringToFront()
        connect()
        dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select CatName from tblCategory", dbConnection)
        dbAdapter.Fill(dbTable)
        dbConnection.Close()
        For Each nRow In dbTable.Rows
            txtCat.Items.Add(nRow.item(0))
        Next
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try
            Dim dbAdapter As MySql.Data.MySqlClient.MySqlDataAdapter, dbTable As New DataTable, CatID As Integer, tblCat As New DataTable
            Dim PhotoPath As String
            If txtCat.SelectedItem <> String.Empty Then
                If txtSubCatName.Text <> String.Empty Then
                    connect()
                    dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select SubCatName from tblSubCat where SubCatName = '" & txtSubCatName.Text & "';", dbConnection)
                    dbAdapter.Fill(dbTable)
                    If dbTable.Rows.Count = 0 Then
                        With selPic
                            .ShowDialog()
                        End With
                        dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select CatID from tblCategory where CatName = '" & txtCat.SelectedItem & "';", dbConnection)
                        dbAdapter.Fill(tblCat)
                        CatID = tblCat.Rows(0).Item(0)
                        PhotoPath = "noimage.jpg"
                        'IO.File.Copy(selPic.FileName, PhotoPath)
                        Dim dbComm As New MySql.Data.MySqlClient.MySqlCommand("insert into tblSubCat(SubCatName,CatID,Photos) values('" & txtSubCatName.Text & "'," & CatID & ",'" & PhotoPath & "');", dbConnection)
                        dbComm.ExecuteNonQuery()
                        MsgBox("New sub-category added under category " & txtCat.SelectedItem, MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                        dbConnection.Close()
                        Me.Close()
                    Else
                        errSubCat.SetError(txtSubCatName, "Sub category already exists")
                    End If
                Else
                    MsgBox("Enter a name for sub-category", vbCritical)
                End If
            Else
                MsgBox("Select a category first", MsgBoxStyle.Critical)
            End If
            dbConnection.Close()
        Catch
            MsgBox("An error occured while trying to save the sub category", MsgBoxStyle.Critical)
            Me.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Dim YesNo As Integer
        YesNo = MsgBox("Cancel adding sub category and close", vbQuestion + vbYesNo)
        If YesNo = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnOK_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.MouseEnter
        With btnOK
            .Size = New Size(81, 37)
            .Location = New Point(43, 192)
            .BackgroundImage = My.Resources.back2
        End With
    End Sub

    Private Sub btnOK_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.MouseLeave
        With btnOK
            .Size = New Size(75, 37)
            .Location = New Point(46, 192)
            .BackgroundImage = My.Resources.back1
        End With
    End Sub

    Private Sub btnCancel_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.MouseEnter
        With btnCancel
            .Size = New Size(81, 37)
            .Location = New Point(152, 192)
            .BackgroundImage = My.Resources.back2
        End With
    End Sub

    Private Sub btnCancel_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.MouseLeave
        With btnCancel
            .Size = New Size(75, 37)
            .Location = New Point(155, 192)
            .BackgroundImage = My.Resources.back1
        End With
    End Sub
End Class