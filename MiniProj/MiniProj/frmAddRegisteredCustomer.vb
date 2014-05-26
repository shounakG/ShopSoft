Imports System.Data.OleDb
Imports System.Net.Mail
Public Class frmAddRegisteredCustomer
    Dim AllOk As Boolean = False

    Private Sub frmAddRegisteredCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BringToFront()
    End Sub

    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        Select Case Asc(e.KeyChar)
            Case 65 To 90, 97 To 122, 32, 8
                errCustomer.Clear()
            Case Else
                errCustomer.SetError(txtName, "Invalid character entered")
                e.Handled = True
        End Select
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMobile.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8
                errCustomer.Clear()
            Case Else
                errCustomer.SetError(txtName, "Invalid character entered")
                e.Handled = True
        End Select
    End Sub

    Private Sub txtPassword_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.Enter
        ToolTipPwd.SetToolTip(txtPassword, "Insert a password here" & vbCrLf & "You should change your password from your home")
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            Dim dbCommand As MySql.Data.MySqlClient.MySqlCommand, email As String, EncPwd As String
            Dim ctrl As Control
            For Each ctrl In Me.Controls
                If TypeOf ctrl Is TextBox And ctrl.Text <> "" Then AllOk = True
            Next
            If txtMobile.Text.Length <> 10 Then AllOk = False
            If AllOk = True Then
                If txtProvider.Text <> "Other" And txtProvider.Text <> "" Then
                    email = txtMail.Text & "@" & txtProvider.Text
                ElseIf txtProvider.Text = "" Then
                    email = txtMail.Text
                End If
                EncPwd = XOREncryption("$herl0ck", txtPassword.Text)
                connect()
                dbCommand = New MySql.Data.MySqlClient.MySqlCommand("Insert into tblCustomer(CustomerPwd,CustomerName,CustomerAddress,MobileNo,email,DOB)" & _
                                           " values('" & EncPwd & "','" & txtName.Text & "','" & txtAddress.Text & "'," & Val(txtMobile.Text) & ",'" & email & "','" & FormatDateTime(DOBCustomer.Value, DateFormat.ShortDate) & "');", dbConnection)
                dbCommand.ExecuteNonQuery()
                dbConnection.Close()
                'Code to send the mail to the registered user
                Dim mail As New MailMessage
                mail.Subject = "Thank you for registering"
                mail.To.Add(email)
                mail.From = New MailAddress("sas.shopsoft@gmail.com")
                mail.Body = "Dear " & txtName.Text & "," & vbCrLf & "UserName: " & txtName.Text & "Password: " & txtPassword.Text & vbCrLf & "Enjoy shopping with ShopSoft" & vbCrLf & "-Administrator"
                Dim smtp As New SmtpClient("smtp.gmail.com")
                smtp.EnableSsl = True
                smtp.Credentials = New System.Net.NetworkCredential("sas.shopsoft@gmail.com", "half-tooth92")
                smtp.Port = "587"
                Try
                    smtp.Send(mail)
                Catch
                    MsgBox("Unable to send the mail", vbInformation + MsgBoxStyle.OkOnly)
                End Try
                MsgBox("Customer registered", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                Me.Close()
            Else
                MsgBox("Some fields are blank", MsgBoxStyle.Critical)
            End If
        Catch exc As Exception
            MsgBox("Unable to update the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Dim YesNo As Integer
        YesNo = MsgBox("Exit without saving changes", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If YesNo = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnAdd_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.MouseEnter
        With btnAdd
            .Size = New Size(87, 37)
            .Location = New Point(171, 387)
            .BackgroundImage = My.Resources.back2
        End With
    End Sub

    Private Sub btnAdd_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.MouseLeave
        With btnAdd
            .Size = New Size(77, 37)
            .Location = New Point(176, 387)
            .BackgroundImage = My.Resources.back1
        End With
    End Sub

    Private Sub btnCancel_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.MouseEnter
        With btnCancel
            .Size = New Size(87, 37)
            .Location = New Point(287, 387)
            .BackgroundImage = My.Resources.back2
        End With
    End Sub

    Private Sub btnCancel_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.MouseLeave
        With btnCancel
            .Size = New Size(77, 37)
            .Location = New Point(292, 387)
            .BackgroundImage = My.Resources.back1
        End With
    End Sub

    Private Sub txtAddress_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAddress.KeyPress
        Select Case Asc(e.KeyChar)
            Case 34, 39
                e.Handled = True
        End Select
    End Sub

    Private Sub txtPassword_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        Select Case Asc(e.KeyChar)
            Case 34, 39
                e.Handled = True
        End Select
    End Sub

    Private Sub txtMail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMail.KeyPress
        Select Case Asc(e.KeyChar)
            Case 34, 39
                e.Handled = True
        End Select
    End Sub
End Class