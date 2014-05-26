Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Public Class frmMyAccount
    Dim AllOK As Boolean = False
    Private Sub frmMyAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dbadapter As Mysql.data.mysqlclient.mysqldataadapter
        Dim dbtable As New DataTable
        dbtable.Clear()
        connect()
        dbadapter = New Mysql.data.mysqlclient.mysqldataadapter("Select * from tblcustomer where CustomerName = '" & cusname & "';", dbConnection)
        dbadapter.Fill(dbtable)
        dbConnection.Close()
        lblUName.Text = cusname
        txtUsername.Text = cusname
        txtAddress.Text = dbtable.Rows(0).Item("CustomerAddress")
        txtMail.Text = dbtable.Rows(0).Item("email")
        txtPhone.Text = dbtable.Rows(0).Item("MobileNo").ToString

    End Sub

    Private Sub lblChangePassword_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblChangePassword.MouseEnter
        lblPassword.Visible = True
        txtPassword.Visible = True
        lblNewPass.Visible = True
        lblRepNew.Visible = True
        txtNewPass.Visible = True
        txtRepPass.Visible = True
        btnApply.Visible = True
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        Dim strng As String = String.Empty
        Dim dbadapter As Mysql.data.mysqlclient.mysqldataadapter
        Dim dbtable As New DataTable
        Dim dbCommand As Mysql.data.mysqlclient.mysqlcommand
        dbtable.Clear()
        connect()
        dbadapter = New Mysql.data.mysqlclient.mysqldataadapter("Select CustomerPwd from tblCustomer where CustomerName = '" & cusname & "';", dbConnection)
        dbadapter.Fill(dbtable)
        dbConnection.Close()

        strng = XOREncryption("$herl0ck", dbtable.Rows(0).Item("CustomerPwd"))

        If txtPassword.Text = strng Then
            If txtNewPass.Text = txtRepPass.Text Then
                strng = XOREncryption("$herl0ck", txtNewPass.Text)
                connect()

                dbCommand = New Mysql.data.mysqlclient.mysqlcommand("Update tblCustomer set CustomerPwd = '" & strng & "' where CustomerName = '" & cusname & "';", dbConnection)
                dbCommand.ExecuteNonQuery()
                dbConnection.Close()
                MsgBox("Password Changed Successfuly")
            Else
                MsgBox("Repeated Password doesn't match")
            End If
        Else
            MsgBox("Wrong Password")
        End If
    End Sub

    Private Sub lblSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSave.Click

        Dim dbCommand As Mysql.data.mysqlclient.mysqlcommand, email As String
        Dim ctrl As Control

        email = txtMail.Text

        'Code to send the mail to the registered user
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is TextBox And ctrl.Text <> "" Then AllOk = True
        Next

        If AllOK = True Then
            connect()



            dbCommand = New Mysql.data.mysqlclient.mysqlcommand("update tblCustomer set CustomerAddress = '" & txtAddress.Text & "' where CustomerName = '" & cusname & "';", dbConnection)
            dbCommand.ExecuteNonQuery()
            dbCommand = New Mysql.data.mysqlclient.mysqlcommand("update tblCustomer set MobileNo = '" & Val(txtPhone.Text) & "' where CustomerName = '" & cusname & "';", dbConnection)
            dbCommand.ExecuteNonQuery()
            dbCommand = New Mysql.data.mysqlclient.mysqlcommand("update tblCustomer set email = '" & txtMail.Text & "' where CustomerName = '" & cusname & "';", dbConnection)
            dbCommand.ExecuteNonQuery()
            dbCommand = New Mysql.data.mysqlclient.mysqlcommand("update tblCustomer set CustomerName = '" & txtUsername.Text & "' where CustomerName = '" & cusname & "';", dbConnection)
            dbCommand.ExecuteNonQuery()

            dbConnection.Close()
            MsgBox("Information Updated!")
            Try
                Dim mail As New MailMessage
                mail.Subject = "Information Changed"

                mail.To.Add(email)
                mail.From = New MailAddress("sas.shopsoft@gmail.com")
                mail.Body = "Dear " & txtUsername.Text & "," & vbCrLf & "Thank you for registering " & vbCrLf & "Enjoy shopping with ShopSoft" & vbCrLf & "-Administrator"
                Dim smtp As New SmtpClient("smtp.gmail.com")
                smtp.EnableSsl = True
                smtp.Credentials = New System.Net.NetworkCredential("sas.shopsoft@gmail.com", "half-tooth92")
                smtp.Port = "587"
                smtp.Send(mail)
                MsgBox("Updated Information has been saved", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                frmLogin.Close()
                Me.Close()
            Catch ex As Exception
            End Try
        Else
            MsgBox("Some fields are blank or incorrect", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
        frmMain.Show()
        frmCatBrowse.Show()
    End Sub

    Private Sub btnSignUpCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignUpCancel.Click
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If atcflag = True Then
            frmCart.Show()
        Else
            MsgBox("You haven't added an item to the cart yet")
        End If
    End Sub

    Private Sub txtPhone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhone.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8
                ErrorProvider1.Clear()
            Case Else
                ErrorProvider1.SetError(txtPhone, "Only Numbers are allowed")
                e.Handled = True
        End Select
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

    Private Sub txtPhone_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPhone.Leave
        If txtPhone.Text.Length < 10 Or txtPhone.Text.Length > 11 Then
            ErrorProvider1.SetError(txtPhone, "Are you sure this is the right phone number?")
        End If
    End Sub


    Private Sub txtRepPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRepPass.KeyPress
        If Asc(e.KeyChar) = 39 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNewPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNewPass.KeyPress
        If Asc(e.KeyChar) = 39 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If Asc(e.KeyChar) = 39 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAddress_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAddress.KeyPress
        If Asc(e.KeyChar) = 39 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtMail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMail.KeyPress
        If Asc(e.KeyChar) = 39 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtUsername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsername.KeyPress
        If Asc(e.KeyChar) = 39 Then
            e.Handled = True
        End If
    End Sub

End Class