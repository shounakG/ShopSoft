Imports System.Data.OleDb
Public Class frmViewRecords
    Dim Index As Integer, Index2 As Integer
    Dim dbTable As DataTable, dbTable2 As New DataTable
    Private Sub updatedb()
        Try
            connect()
            Dim dbComm As New MySql.Data.MySqlClient.MySqlDataAdapter("select * from UserDetails", dbConnection)
            dbTable = New DataTable
            dbTable.Clear()
            dbComm.Fill(dbTable)
            dbConnection.Close()
        Catch exc As Exception
            MsgBox("An error occured while fetching the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub frmViewRecords_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim dbRow As DataRow
            Index = 0
            updatedb()
            Dim dbComm As New MySql.Data.MySqlClient.MySqlDataAdapter("select * from UserDetails", dbConnection)
            dbComm.Fill(dbTable)
            If Index < dbTable.Rows.Count Then
                dbRow = dbTable.Rows(Index)
                filldetails(dbRow)
                Index = Index + 1
                UserName = txtUser.Text
            Else
                MsgBox("End of records", MsgBoxStyle.Information)
                Index = 0
            End If
        Catch exc As Exception
            MsgBox("An error occured while fetching the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Dim dbRow As DataRow
        updatedb()
        If Index < dbTable.Rows.Count Then
            dbRow = dbTable.Rows(Index)
            filldetails(dbRow)
            Index = Index + 1
            UserName = txtUser.Text
        Else
            MsgBox("End of records", MsgBoxStyle.Information)
            Index = 0
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If txtUser.Text <> "" Then
            If txtUser.Text <> "Administrator" Then
                frmEditUser.ShowDialog()
                Me.Close()
            Else
                MsgBox("Cannot make changes to Administrator account", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Select a user account first", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            Dim dt As New DataTable, da As MySql.Data.MySqlClient.MySqlDataAdapter
            If txtUser.Text <> "Administrator" Then
                Dim YesNo As String
                connect()
                YesNo = InputBox("Enter the password for the user")
                da = New MySql.Data.MySqlClient.MySqlDataAdapter("select Password from UserDetails where UserDetails.UserName = '" & txtUser.Text & "';", dbConnection)
                da.Fill(dt)
                dbConnection.Close()
                YesNo = XOREncryption("$herl0ck", YesNo)
                If YesNo = dt.Rows(0).Item(0) Then
                    connect()
                    Dim dbCommand As New MySql.Data.MySqlClient.MySqlCommand("delete from UserDetails where UserName='" & txtUser.Text & "';", dbConnection)
                    dbCommand.ExecuteNonQuery()
                    dbConnection.Close()
                    MsgBox("Record deleted successfully", MsgBoxStyle.Information)
                    Me.Close()
                    For Each ctrl As Control In Me.Controls
                        If TypeOf ctrl Is TextBox Then ctrl.Text = ""
                    Next
                Else
                    MsgBox("Invalid password", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Cannot delete the Administrator record", MsgBoxStyle.Critical)
            End If
        Catch exc As Exception
            MsgBox("An error occured while fetching the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnChangePwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangePwd.Click
        frmChangePassword.txtConfirmPwd.Text = ""
        frmChangePassword.txtCurrentPwd.Text = ""
        frmChangePassword.txtNewPwd.Text = ""
        frmChangePassword.ShowDialog()
        Me.Close()
    End Sub

    Private Sub txtSearchUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearchUser.KeyPress
        Select Case Asc(e.KeyChar)
            Case 39, 34
                e.Handled = True
        End Select
    End Sub

    Private Sub txtSearchUser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchUser.TextChanged
        Try
            Dim dbRow As DataRow
            connect()
            Dim dbComm As New MySql.Data.MySqlClient.MySqlDataAdapter("select all * from UserDetails where UserName LIKE '" & txtSearchUser.Text & "%';", dbConnection)
            dbTable2.Clear()
            dbComm.Fill(dbTable2)
            Index2 = 0
            If dbTable2.Rows.Count = 0 Then
                MsgBox("No results found for your query", MsgBoxStyle.Information)
            ElseIf dbTable2.Rows.Count > 1 Then
                btnNext2.Enabled = True
                btnNext2.Visible = True
                btnNext.Enabled = False
                dbRow = dbTable2.Rows(0)
                filldetails(dbRow)
                picStopSearch.Visible = True
                Index2 = 1
            Else
                dbRow = dbTable2.Rows(0)
                filldetails(dbRow)
                picStopSearch.Visible = True
            End If
            dbConnection.Close()
        Catch exc As Exception
            MsgBox("An error occured while fetching the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnNext2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext2.Click
        Dim dbRow As DataRow
        If Index2 < dbTable2.Rows.Count Then
            dbRow = dbTable2.Rows(Index2)
            filldetails(dbRow)
            Index2 = Index2 + 1
            UserName = txtUser.Text
        Else
            MsgBox("End of records", MsgBoxStyle.Information)
            Index2 = 0
        End If
    End Sub

    Private Sub picStopSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picStopSearch.Click
        txtSearchUser.Text = ""
        btnNext.Enabled = True
        btnNext2.Enabled = False
        btnNext2.Visible = False
        picStopSearch.Visible = False
        updatedb()
    End Sub
    Private Sub filldetails(ByVal dbRow As DataRow)
        txtUser.Text = dbRow.Item(0)
        txtAddress.Text = dbRow.Item(2)
        txtContact.Text = dbRow.Item(3)
        txtCounter.Text = dbRow.Item(4)
        picUser.ImageLocation = dbRow.Item(5)
        UserName = txtUser.Text
    End Sub

    Private Sub btnChangePwd_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnChangePwd.MouseEnter
        With btnChangePwd
            .Location = New Point(16, 327)
            .Size = New Size(144, 37)
            .BackgroundImage = My.Resources.back2
        End With
    End Sub

    Private Sub btnChangePwd_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnChangePwd.MouseLeave
        With btnChangePwd
            .Location = New Point(20, 327)
            .Size = New Size(136, 37)
            .BackgroundImage = My.Resources.back1
        End With
    End Sub

    Private Sub btnNext2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext2.MouseEnter
        With btnNext2
            .Location = New Point(276, 327)
            .Size = New Size(93, 37)
            .BackgroundImage = My.Resources.back2
        End With
    End Sub

    Private Sub btnNext2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext2.MouseLeave
        With btnNext2
            .Location = New Point(279, 327)
            .Size = New Size(86, 37)
            .BackgroundImage = My.Resources.back1
        End With
    End Sub

    Private Sub btnNext_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext.MouseEnter
        With btnNext
            .Location = New Point(276, 327)
            .Size = New Size(93, 37)
            .BackgroundImage = My.Resources.back2
        End With
    End Sub

    Private Sub btnNext_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext.MouseLeave
        With btnNext
            .Location = New Point(279, 327)
            .Size = New Size(86, 37)
            .BackgroundImage = My.Resources.back1
        End With
    End Sub

    Private Sub btnEdit_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.MouseEnter
        With btnEdit
            .Location = New Point(369, 327)
            .Size = New Size(93, 37)
            .BackgroundImage = My.Resources.back2
        End With
    End Sub

    Private Sub btnEdit_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.MouseLeave
        With btnEdit
            .Location = New Point(372, 327)
            .Size = New Size(86, 37)
            .BackgroundImage = My.Resources.back1
        End With
    End Sub

    Private Sub btnDelete_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.MouseEnter
        With btnDelete
            .Location = New Point(462, 327)
            .Size = New Size(93, 37)
            .BackgroundImage = My.Resources.back2
        End With
    End Sub

    Private Sub btnDelete_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.MouseLeave
        With btnDelete
            .Location = New Point(465, 327)
            .Size = New Size(86, 37)
            .BackgroundImage = My.Resources.back1
        End With
    End Sub
End Class