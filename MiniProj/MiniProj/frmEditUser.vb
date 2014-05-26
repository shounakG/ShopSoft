Imports System.Data.OleDb
Public Class frmEditUser
    Dim ValChanged As Boolean = False

    Private Sub frmEditUser_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmViewRecords.Show()
    End Sub

    Private Sub frmEditUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.BringToFront()
            Dim dbTable As New DataTable, dbSet As New DataSet
            Dim dbRow As DataRow
            dbSet.Tables.Add(dbTable)
            connect()
            Dim dbAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter("select * from UserDetails where UserName='" & frmViewRecords.txtUser.Text & "';", dbConnection)
            dbAdapter.Fill(dbTable)
            dbRow = dbTable.Rows(0)
            txtUserName.Text = dbRow.Item(0)
            txtAddress.Text = dbRow.Item(2)
            txtContact.Text = dbRow.Item(3)
            txtCounter.Text = dbRow.Item(4)
            picUser.Image = getPicture(dbRow.Item(5))
            dbConnection.Close()
        Catch exc As Exception
            MsgBox("An error occured while fetching the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try
            If ValChanged = True Then
                connect()
                Dim dbCommand As New MySql.Data.MySqlClient.MySqlCommand("update UserDetails set UserName='" & txtUserName.Text & "' where UserName='" & frmViewRecords.txtUser.Text & "';", dbConnection)
                dbCommand.ExecuteNonQuery()
                dbCommand = New MySql.Data.MySqlClient.MySqlCommand("update UserDetails set Address='" & txtAddress.Text & "' where UserName='" & txtUserName.Text & "';", dbConnection)
                dbCommand.ExecuteNonQuery()
                dbCommand = New MySql.Data.MySqlClient.MySqlCommand("update UserDetails set Contact='" & txtContact.Text & "' where UserName='" & txtUserName.Text & "';", dbConnection)
                dbCommand.ExecuteNonQuery()
                dbCommand = New MySql.Data.MySqlClient.MySqlCommand("update UserDetails set CounterNo='" & txtCounter.Text & "' where UserName='" & txtUserName.Text & "';", dbConnection)
                dbCommand.ExecuteNonQuery()
                dbCommand = New MySql.Data.MySqlClient.MySqlCommand("update UserDetails set UserPhoto='" & picUser.ImageLocation & "' where UserName='" & txtUserName.Text & "';", dbConnection)
                dbCommand.ExecuteNonQuery()
                MsgBox("User data edited successfully", MsgBoxStyle.Information)
                dbConnection.Close()
                Me.Close()
            End If
        Catch exc As Exception
            MsgBox("An error occured while updating the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Dim YesNo As Integer
        YesNo = MsgBox("Cancel editing and return", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
        If YesNo = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub picUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picUser.Click
        selPicUser.Filter = "All Picture Files|*.jpg"
        selPicUser.ShowDialog()
        picUser.ImageLocation = selPicUser.FileName
    End Sub

    Private Sub txtUserName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserName.KeyPress
        Select Case Asc(e.KeyChar)
            Case 34, 39
                e.Handled = True
        End Select
    End Sub

    Private Sub txtUserName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUserName.TextChanged
        ValChanged = True
    End Sub

    Private Sub txtAddress_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAddress.KeyPress
        Select Case Asc(e.KeyChar)
            Case 34, 39
                e.Handled = True
        End Select
    End Sub

    Private Sub txtAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddress.TextChanged
        ValChanged = True
    End Sub

    Private Sub txtContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact.KeyPress
        Dim KeyAsc As Integer
        KeyAsc = Asc(e.KeyChar)
        Select Case KeyAsc
            Case 48 To 57, 8
                errContact.Clear()
            Case Else
                errContact.SetError(txtContact, "Can contain only numbers")
                e.Handled = True
        End Select
    End Sub

    Private Sub txtContact_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContact.TextChanged
        ValChanged = True
    End Sub

    Private Sub txtCounter_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCounter.KeyPress
        Dim KeyAsc As Integer
        KeyAsc = Asc(e.KeyChar)
        Select Case KeyAsc
            Case 48 To 57, 8
                errContact.Clear()
            Case Else
                errContact.SetError(txtCounter, "Can contain only numbers")
                e.Handled = True
        End Select
    End Sub

    Private Sub txtCounter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCounter.TextChanged
        ValChanged = True
    End Sub

    Private Sub btnOK_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.MouseEnter
        With btnOK
            .Location = New Point(76, 318)
            .Size = New Size(100, 39)
            .BackgroundImage = My.Resources.back2
        End With
    End Sub

    Private Sub btnOK_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.MouseLeave
        With btnOK
            .Location = New Point(80, 318)
            .Size = New Size(94, 39)
            .BackgroundImage = My.Resources.back1
        End With
    End Sub

    Private Sub btnCancel_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.MouseEnter
        With btnCancel
            .Location = New Point(221, 318)
            .Size = New Size(100, 39)
            .BackgroundImage = My.Resources.back2
        End With
    End Sub

    Private Sub btnCancel_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.MouseLeave
        With btnCancel
            .Location = New Point(225, 318)
            .Size = New Size(94, 39)
            .BackgroundImage = My.Resources.back1
        End With
    End Sub
End Class