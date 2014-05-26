Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Public Class frmSignUp
    Dim AllOk As Boolean = False
    Private Sub btnSignUpSignUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignUpSignUp.Click
        Dim dbCommand As Mysql.data.mysqlclient.mysqlcommand, email As String, EncPwd As String
        Dim ctrl As Control
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is TextBox And ctrl.Text <> "" Then AllOk = True
        Next
        If txtSignUpAddress.Text = "" Then
            AllOk = False
        End If
        If AllOK = True Then
            email = txtMail.Text
            EncPwd = XOREncryption("$herl0ck", Me.txtSignUpPassword.Text)
            connect()
            dbCommand = New Mysql.data.mysqlclient.mysqlcommand("Insert into tblCustomer(CustomerPwd,CustomerName,CustomerAddress,MobileNo,email,DOB)" & _
                                       " values('" & EncPwd & "','" & Me.txtSignUpUsername.Text & "','" & txtSignUpAddress.Text & "'," & Val(txtSignUpPhone.Text) & ",'" & email & "','" & DateTimePicker1.Value & "');", dbConnection)

            dbCommand.ExecuteNonQuery()
            MsgBox("User Created")
            Me.Hide()
            Try
                Dim mail As New MailMessage
                mail.Subject = "Thank you for registering"
                mail.To.Add(email)
                mail.From = New MailAddress("sas.shopsoft@gmail.com")
                mail.Body = "Dear " & txtSignUpUsername.Text & "," & vbCrLf & "Thank you for registering " & vbCrLf & "Enjoy shopping with ShopSoft" & vbCrLf & "-Administrator"
                Dim smtp As New SmtpClient("smtp.gmail.com")
                smtp.EnableSsl = True
                smtp.Credentials = New System.Net.NetworkCredential("sas.shopsoft@gmail.com", "half-tooth92")
                smtp.Port = "587"
                smtp.Send(mail)
                MsgBox("Customer registered and mail sent", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                Me.Close()
                For Each c As Control In Me.Controls
                    If TypeOf c Is TextBox Then
                        CType(c, Control).Text = String.Empty
                    End If
                Next
            Catch ex As Exception
                Me.Close()
                For Each c As Control In Me.Controls
                    If TypeOf c Is TextBox Then
                        CType(c, Control).Text = String.Empty
                    End If
                Next
            End Try
        Else
            MsgBox("Some fields are blank or incorrect", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub txtSignUpPhone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSignUpPhone.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8
                ErrorProvider1.Clear()
            Case Else
                ErrorProvider1.SetError(txtSignUpPhone, "Only Numbers are allowed")
                e.Handled = True
        End Select
    End Sub

    Private Sub txtSignUpPhone_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSignUpPhone.Leave
        If txtSignUpPhone.Text.Length < 10 Or txtSignUpPhone.Text.Length > 11 Then
            ErrorProvider1.SetError(txtSignUpPhone, "Are you sure this is the right phone number?")
        End If
    End Sub

    Private Sub txtMail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMail.KeyPress
        If Asc(e.KeyChar) = 39 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtMail_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMail.Leave
        If txtMail.Text.Contains("@") = True And txtMail.Text.Contains(".") = True Then
            AllOk = True
            ErrorProvider1.Clear()
        Else
            ErrorProvider1.SetError(txtMail, "Entered Email doesn't seem right")
            AllOk = False
        End If
    End Sub

    Private Sub btnSignUpCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignUpCancel.Click
        Me.Close()
        For Each c As Control In Me.Controls
            If TypeOf c Is TextBox Then
                CType(c, Control).Text = String.Empty
            End If
        Next
    End Sub

    Private Sub frmSignUp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtSignUpUsername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSignUpUsername.KeyPress
        If Asc(e.KeyChar) = 39 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSignUpPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSignUpPassword.KeyPress
        If Asc(e.KeyChar) = 39 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSignUpRepeat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSignUpRepeat.KeyPress
        If Asc(e.KeyChar) = 39 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSignUpAddress_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSignUpAddress.KeyPress
        If Asc(e.KeyChar) = 39 Then
            e.Handled = True
        End If
    End Sub
End Class