Imports System.Data.OleDb
Public Class frmChangePassword

    Dim CurrentPwd As String

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try
            Dim EncNewPwd As String
            If CurrentPwd = txtCurrentPwd.Text Then
                If txtNewPwd.Text = txtConfirmPwd.Text Then
                    connect()
                    EncNewPwd = XOREncryption("$herl0ck", txtNewPwd.Text)
                    Dim dbCommand As New MySql.Data.MySqlClient.MySqlCommand("UPDATE UserDetails SET Password = '" & EncNewPwd & "' WHERE UserName='" & UserName & "';", dbConnection)
                    dbCommand.ExecuteNonQuery()
                    dbConnection.Close()
                    MsgBox("Password changed successfully", MsgBoxStyle.Information)
                    Me.Close()
                Else
                    MsgBox("New passwords donot match", MsgBoxStyle.Critical)
                    GoTo EndProc
                End If
            Else
                MsgBox("Invalid account password", MsgBoxStyle.Critical)
            End If
EndProc:
            Me.Close()
        Catch exc As Exception
            MsgBox("An error occured while updating the database" & vbCrLf & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub GetCurrentPwd()
        Try
            Dim dbTable As New DataTable, dbSet As New DataSet
            Dim dbRow As DataRow
            dbSet.Tables.Add(dbTable)
            connect()
            Dim dbAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter("select Password from UserDetails where UserName='" & UserName & "';", dbConnection)
            dbAdapter.Fill(dbTable)
            dbRow = dbTable.Rows(0)
            CurrentPwd = dbRow.Item(0)
            dbConnection.Close()
        Catch exc As Exception
            MsgBox("An error occured while fetching the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub frmChangePassword_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GetCurrentPwd()
        CurrentPwd = XOREncryption("$herl0ck", CurrentPwd)
    End Sub

    Private Sub btnOK_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.MouseEnter
        With btnOK
            .BackgroundImage = My.Resources.back2
            .Size = New Size(87, 40)
            .Location = New Point(97, 159)
        End With
    End Sub

    Private Sub btnOK_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.MouseLeave
        With btnOK
            .BackgroundImage = My.Resources.back1
            .Size = New Size(81, 40)
            .Location = New Point(100, 159)
        End With
    End Sub

    Private Sub btnCancel_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.MouseEnter
        With btnCancel
            .BackgroundImage = My.Resources.back2
            .Size = New Size(87, 40)
            .Location = New Point(212, 159)
        End With
    End Sub

    Private Sub btnCancel_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.MouseLeave
        With btnCancel
            .BackgroundImage = My.Resources.back1
            .Size = New Size(81, 40)
            .Location = New Point(215, 159)
        End With
    End Sub

    Private Sub txtCurrentPwd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCurrentPwd.KeyPress
        Select Case Asc(e.KeyChar)
            Case 34, 39
                e.Handled = True
        End Select
    End Sub

    Private Sub txtNewPwd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNewPwd.KeyPress
        Select Case Asc(e.KeyChar)
            Case 34, 39
                e.Handled = True
        End Select
    End Sub

    Private Sub txtConfirmPwd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConfirmPwd.KeyPress
        Select Case Asc(e.KeyChar)
            Case 34, 39
                e.Handled = True
        End Select
    End Sub
End Class