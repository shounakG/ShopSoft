Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Public Class frmForgotPass
    Dim AllOk As Boolean = False
    Private Sub picMainLogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMainLogo.Click
        Me.Close()
        frmLogin.Close()
        frmMain.Show()
        frmCatBrowse.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEmail.CheckedChanged
        txtUsername.Visible = False
        txtDate.Visible = False
        txtEmail.Visible = True
    End Sub

    Private Sub rbDOB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDOB.CheckedChanged
        txtUsername.Visible = True
        txtDate.Visible = True
        txtEmail.Visible = False
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim dbCommand As Mysql.data.mysqlclient.mysqlcommand, email As String, EncPwd As String
        Dim dbadapter As Mysql.data.mysqlclient.mysqldataadapter, dbtable As New DataTable

        If rbEmail.Checked = True Then
            Dim pass As Integer = Rnd()


            Dim Gen As System.Random
            Gen = New System.Random(My.Computer.Clock.TickCount)
            pass = Gen.Next(1, 101).ToString
            Dim cname As String

            If txtEmail.Text <> "Enter Your Email" Then
                If AllOk = True Then
                    Try
                        email = txtEmail.Text
                        Dim mail As New MailMessage
                        mail.Subject = "New Password"
                        mail.To.Add(email)
                        mail.From = New MailAddress("sas.shopsoft@gmail.com")
                        Try
                            connect()
                            dbadapter = New Mysql.data.mysqlclient.mysqldataadapter("Select CustomerName from tblCustomer where email =  '" & email & "';", dbConnection)
                            dbadapter.Fill(dbtable)
                            dbConnection.Close()
                            cname = dbtable.Rows(0).Item(0)
                        Catch ex As Exception
                            MsgBox("Wrong Username or Password")
                        End Try
                        mail.Body = "Dear " & dbtable.Rows(0).Item(0) & "," & vbCrLf & "Hello!, " & vbCrLf & "Your New Password is :" & pass & "" & vbCrLf & "-Administrator"
                        Dim smtp As New SmtpClient("smtp.gmail.com")
                        smtp.EnableSsl = True
                        smtp.Credentials = New System.Net.NetworkCredential("sas.shopsoft@gmail.com", "half-tooth92")
                        smtp.Port = "587"
                        smtp.Send(mail)
                        pass = XOREncryption("$herl0ck", pass)
                        connect()

                        dbCommand = New Mysql.data.mysqlclient.mysqlcommand("Update tblCustomer set CustomerPwd = '" & pass & "' where CustomerName = '" & cname & "';", dbConnection)
                        dbCommand.ExecuteNonQuery()
                        dbConnection.Close()
                        MsgBox("New Password Sent", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                        Me.Close()
                        For Each c As Control In Me.Controls
                            If TypeOf c Is TextBox Then
                                CType(c, Control).Text = String.Empty
                            End If
                        Next
                    Catch ex As Exception
                        MsgBox("No Internet Access", MsgBoxStyle.Critical)
                    End Try
                End If
            End If


        ElseIf rbDOB.Checked Then
            Try
                Dim pass As String
                dbadapter = New Mysql.data.mysqlclient.mysqldataadapter("Select CustomerName from tblCustomer where DOB =  '" & txtDate.Text & "';", dbConnection)
                dbadapter.Fill(dbtable)
                dbConnection.Close()
                For Each c As Control In frmNewPass.Controls
                    If TypeOf c Is TextBox Then
                        CType(c, Control).Text = String.Empty
                    End If
                Next
                Dim cname As String = dbtable.Rows(0).Item(0)
                frmNewPass.ShowDialog()
                pass = frmNewPass.txtPassword.Text
                pass = XOREncryption("$herl0ck", pass)
                connect()
                dbCommand = New Mysql.data.mysqlclient.mysqlcommand("Update tblCustomer set CustomerPwd = '" & pass & "' where CustomerName = '" & cname & "';", dbConnection)
                dbCommand.ExecuteNonQuery()
                Me.Close()
                For Each c As Control In Me.Controls
                    If TypeOf c Is TextBox Then
                        CType(c, Control).Text = String.Empty
                    End If
                Next
            Catch ex As Exception
                MsgBox("Wrong Username or DOB")
            End Try
        Else
            MsgBox("Please select a field")
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        rbDOB.Checked = False
        rbEmail.Checked = False
        txtEmail.Text = "Enter Your Email"
        txtUsername.Text = "Username"
        Me.Close()
    End Sub

    Private Sub txtEmail_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmail.Enter
        If txtEmail.Text = "Enter Your Email" Then
            txtEmail.Text = ""
        End If
    End Sub

    Private Sub txtEmail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmail.KeyPress
        If Asc(e.KeyChar) = 39 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtEmail_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmail.Leave
        If txtEmail.Text = "" Then
            txtEmail.Text = "Enter Your Email"
        Else
            If txtEmail.Text.Contains("@") = True And txtEmail.Text.Contains(".") = True Then
                AllOk = True
                ErrorProvider1.Clear()
            Else
                ErrorProvider1.SetError(txtEmail, "Entered Email doesn't seem right")
                AllOk = False
            End If
        End If
    End Sub

    Private Sub txtUsername_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsername.Enter
        If txtUsername.Text = "Username" Then
            txtUsername.Text = ""
        End If
    End Sub

    Private Sub txtUsername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsername.KeyPress
        If Asc(e.KeyChar) = 39 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtUsername_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsername.Leave
        If txtUsername.Text = "" Then
            txtUsername.Text = "Username"
        End If
    End Sub

    Private Sub TextBox1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.Enter
        If txtDate.Text = "DOB" Then
            txtDate.Text = ""
        End If
    End Sub

    Private Sub txtDate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDate.KeyPress
        If Asc(e.KeyChar) = 39 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.Leave
        If txtDate.Text = "" Then
            txtDate.Text = "DOB"
        End If
    End Sub

    Private Sub frmForgotPass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rbDOB.Checked = False
        rbEmail.Checked = False
    End Sub

    Private Sub txtEmail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub txtUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub txtDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDate.TextChanged

    End Sub
End Class