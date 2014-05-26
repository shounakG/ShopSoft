Imports System.Data.OleDb
Public Class frmAddBrand

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            Dim dbCommand As MySql.Data.MySqlClient.MySqlCommand, YesNo As Integer
            If txtBrandName.Text <> String.Empty Then
                Dim dbAdapter As MySql.Data.MySqlClient.MySqlDataAdapter, dbTable As New DataTable
                connect()
                dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select BrandName from tblBrands Where BrandName = '" & txtBrandName.Text & "';", dbConnection)
                dbAdapter.Fill(dbTable)
                If dbTable.Rows.Count = 0 Then
                    dbCommand = New MySql.Data.MySqlClient.MySqlCommand("insert into tblBrands(BrandName) values('" & txtBrandName.Text & "');", dbConnection)
                    dbCommand.ExecuteNonQuery()
                    YesNo = MsgBox("Brand added successfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                    dbConnection.Close()
                    Me.Close()
                Else
                    errBrand.SetError(txtBrandName, "Brand name already exists")
                End If
                dbConnection.Close()
            Else
                MsgBox("Enter something as brand name", MsgBoxStyle.Critical)
            End If
        Catch exc As Exception
            MsgBox("Unable to update the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Dim YesNo As Integer
        YesNo = MsgBox("Cancel adding brand and close", vbQuestion + vbYesNo)
        If YesNo = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub txtBrandName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBrandName.KeyPress
        Select Case Asc(e.KeyChar)
            Case 34, 39
                e.Handled = True
        End Select
    End Sub

    Private Sub txtBrandName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBrandName.TextChanged
        errBrand.Clear()
    End Sub

    Private Sub btnAdd_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.MouseEnter
        With btnAdd
            .BackgroundImage = My.Resources.back2
            .Size = New Size(81, 23)
            .Location = New Point(46, 107)
        End With
    End Sub

    Private Sub btnAdd_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.MouseLeave
        With btnAdd
            .BackgroundImage = My.Resources.back1
            .Size = New Size(75, 23)
            .Location = New Point(49, 107)
        End With
    End Sub

    Private Sub btnCancel_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.MouseEnter
        With btnCancel
            .BackgroundImage = My.Resources.back2
            .Size = New Size(78, 23)
            .Location = New Point(163, 107)
        End With
    End Sub

    Private Sub btnCancel_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.MouseLeave
        With btnCancel
            .BackgroundImage = My.Resources.back1
            .Size = New Size(75, 23)
            .Location = New Point(166, 107)
        End With
    End Sub

    Private Sub frmAddBrand_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.BringToFront()
    End Sub
End Class