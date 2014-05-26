Imports System.Data.OleDb
Imports System.Net.Mail
Public Class frmNewsLetter

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If txtSubject.Text <> "" And rtfBody.Text <> "" Then
            Dim dbAdapter As MySql.Data.MySqlClient.MySqlDataAdapter, dbTable As New DataTable
            connect()
            dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select email from tblCustomer", dbConnection)
            dbAdapter.Fill(dbTable)
            dbConnection.Close()
            For Each nRow As DataRow In dbTable.Rows
                Dim mail As New MailMessage
                mail.Subject = txtSubject.Text
                mail.To.Add(nRow.Item(0))
                mail.From = New MailAddress("sas.shopsoft@gmail.com")
                mail.Body = rtfBody.Text

                Dim smtp As New SmtpClient("smtp.gmail.com")
                smtp.EnableSsl = True
                smtp.Credentials = New System.Net.NetworkCredential("sas.shopsoft@gmail.com", "half-tooth92")
                smtp.Port = "587"
                Try
                    smtp.Send(mail)
                Catch
                    MsgBox("Unable to send the mail to CustomerMail: " & nRow.Item(0), vbInformation + MsgBoxStyle.OkOnly)
                    Me.Close()
                End Try

            Next
            MsgBox("Newsletter sent", vbInformation + vbOKOnly)
            Me.Close()
        End If
    End Sub

    Private Sub frmNewsLetter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BringToFront()
        txtSubject.Select()
    End Sub

    Private Sub btnOK_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.MouseEnter
        With btnOK
            .Location = New Point(416, 469)
            .Size = New Size(94, 33)
            .BackgroundImage = My.Resources.back2
        End With
    End Sub

    Private Sub btnOK_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.MouseLeave
        With btnOK
            .Location = New Point(421, 469)
            .Size = New Size(84, 33)
            .BackgroundImage = My.Resources.back1
        End With
    End Sub
End Class