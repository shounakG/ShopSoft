Imports System.Data.OleDb
Public Class frmAddAccount
    Dim incr1 As Boolean = False, incr2 As Boolean = False
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try
            Dim dbCommand As MySql.Data.MySqlClient.MySqlCommand, EncPwd As String
            EncPwd = XOREncryption("$herl0ck", txtPass.Text)
            If txtNewUser.Text <> "" And txtPass.Text <> "" And txtConfirmPass.Text <> "" Then
                connect()
                If txtPass.Text = txtConfirmPass.Text Then
                    dbCommand = New MySql.Data.MySqlClient.MySqlCommand("insert into UserDetails values('" & txtNewUser.Text & "','" & EncPwd & "','a',1,1,'My.Resources.Students');", dbConnection)
                    dbCommand.ExecuteNonQuery()
                    MsgBox("Successfully created a new account", MsgBoxStyle.Information)
                    Me.Close()
                Else
                    MsgBox("Passwords donot match", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("One of the fields cannot be blank", MsgBoxStyle.Critical)
            End If
            dbConnection.Close()
        Catch exc As Exception
            MsgBox("Unable to update the database" & vbCrLf & "Errormsg: " & exc.Message, vbCritical)
            Me.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Dim YesNo As Integer
        YesNo = MsgBox("Exit without creating a new account", vbQuestion + vbYesNo)
        If YesNo = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub txtPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPass.KeyPress
        If prgbarPwdStrength.Value < 100 Then
            Dim KeyAsc As Integer
            KeyAsc = Asc(e.KeyChar)
            Select Case KeyAsc
                Case 48 To 57
                    If incr1 = False Then
                        prgbarPwdStrength.Value += 30
                        incr1 = True
                    End If
                Case Else
                    If incr2 = False Then
                        prgbarPwdStrength.Value += 20
                        incr2 = True
                    End If
            End Select
        End If
        Select Case Asc(e.KeyChar)
            Case 34, 39
                e.Handled = True
        End Select
    End Sub

    Private Sub txtPass_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPass.Leave
        prgbarPwdStrength.Visible = False
        lblPwdStrength.Visible = False
        If prgbarPwdStrength.Value < 70 Then
            MsgBox("Password strength is low, consider redeciding it", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub txtPass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPass.TextChanged
        prgbarPwdStrength.Visible = True
        lblPwdStrength.Visible = True
        Select Case txtPass.Text.Length
            Case 0
                prgbarPwdStrength.Value = 0
            Case 1 To 3
                prgbarPwdStrength.Value = 10
            Case 4 To 6
                prgbarPwdStrength.Value = 50
        End Select
    End Sub

    Private Sub btnOK_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.MouseEnter
        With btnOK
            .Image = My.Resources.back2
            .Size = New Size(91, 34)
            .Location = New Point(68, 172)
        End With
    End Sub

    Private Sub btnOK_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.MouseLeave
        With btnOK
            .Image = My.Resources.back1
            .Size = New Size(85, 34)
            .Location = New Point(71, 172)
        End With
    End Sub

    Private Sub btnCancel_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.MouseEnter
        With btnCancel
            .Image = My.Resources.back2
            .Size = New Size(91, 34)
            .Location = New Point(167, 172)
        End With
    End Sub

    Private Sub btnCancel_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.MouseLeave
        With btnCancel
            .Image = My.Resources.back1
            .Size = New Size(85, 34)
            .Location = New Point(170, 172)
        End With
    End Sub

    Private Sub txtNewUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNewUser.KeyPress
        Select Case Asc(e.KeyChar)
            Case 34, 39
                e.Handled = True
        End Select
    End Sub

    Private Sub txtConfirmPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConfirmPass.KeyPress
        Select Case Asc(e.KeyChar)
            Case 34, 39
                e.Handled = True
        End Select
    End Sub
End Class