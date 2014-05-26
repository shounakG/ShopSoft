Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class frmSplashLogin

    Private Sub picLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picLogin.Click
        clickLogin()
    End Sub

    Private Sub picLogin_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles picLogin.MouseEnter
        With picLogin
            .Size = New Drawing.Size(116, 27)
            .Location = New Drawing.Point(51, 207)
        End With
    End Sub

    Private Sub picLogin_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picLogin.MouseLeave
        With picLogin
            .Size = New Drawing.Size(70, 27)
            .Location = New Drawing.Point(69, 207)
        End With
    End Sub

    Private Sub clickLogin()
        Try
            Dim dbTable As New DataTable, dbSet As New DataSet, EncPwd As String, EncDBPwd As String
            EncPwd = txtPassword.Text
            dbSet.Tables.Add(dbTable)
            connect()
            Dim cmd As MySqlCommand = New MySqlCommand
            cmd.CommandText = "select UserName,Password from UserDetails"
            cmd.CommandType = CommandType.Text
            cmd.Connection = dbConnection
            Dim dbAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter(cmd)
            dbAdapter.Fill(dbTable)
            For Each dbRow In dbTable.Rows
                EncDBPwd = XOREncryption("$herl0ck", dbRow(1))
                If txtUser.Text = dbRow.item(0) Then
                    dbConnection.Close()
                    AnimateTimer.Start()
                    'frmMain.Show()
                    'Me.Close()
                    NotifyIcon.ShowBalloonTip(3000)
                    Return
                End If
            Next
            dbConnection.Close()
            MsgBox("Incorrect user name or password", MsgBoxStyle.Critical)
        Catch exc As Exception
            MsgBox("Unable to fetch values from the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtUser_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUser.Enter
        With txtUser
            .Text = ""
            .ForeColor = Color.Black
        End With
    End Sub

    Private Sub txtUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUser.KeyPress
        If e.KeyChar = Chr(27) Then
            End
        End If
    End Sub

    Private Sub txtUser_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUser.Leave
        If txtUser.Text = "" Then
            With txtUser
                .Text = "User Name"
                .ForeColor = Color.Gray
            End With
        End If
    End Sub

    Private Sub txtPassword_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.Enter
        With txtPassword
            .Text = ""
            .ForeColor = Color.Black
            .PasswordChar = "*"
        End With
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(27) Then
            End
        ElseIf e.KeyChar = Chr(13) Then
            clickLogin()
        End If
    End Sub

    Private Sub txtPassword_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.Leave
        If txtPassword.Text = "" Then
            With txtPassword
                .PasswordChar = ""
                .ForeColor = Color.Gray
                .Text = "Password"
            End With
        End If
    End Sub

    Private Sub frmSplashLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        picLogo.Select()
        'txtUser.Text = "Administrator"
        'txtPassword.Text = "joshi"
    End Sub

    Private Sub AnimateTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnimateTimer.Tick
        If Me.Opacity <> 0 Then
            Me.Opacity = Me.Opacity - 0.05
        Else
            AnimateTimer.Stop()
            frmMain.Show()
            Me.Close()
        End If
    End Sub

    Private Sub cmbShop_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbShop.SelectionChangeCommitted
        MyShopName = cmbShop.SelectedItem
        txtUser.Visible = True
        txtPassword.Visible = True
        picLogin.Visible = True
        connectShop()
        Dim dbCmd As New MySql.Data.MySqlClient.MySqlCommand("Update tblShop SET Status = -1 Where ShopName = '" & MyShopName & "';", dbConnection2)
        dbCmd.ExecuteNonQuery()
        Dim dbAdapter2 As New MySql.Data.MySqlClient.MySqlDataAdapter("Select * from tblShop Where ShopName = '" & MyShopName & "';", dbConnection2), dbTable2 As New DataTable
        dbAdapter2.Fill(dbTable2)
        shopstring = dbTable2.Rows(0).Item("DbAddress")
        dbConnection2.Close()
    End Sub
End Class