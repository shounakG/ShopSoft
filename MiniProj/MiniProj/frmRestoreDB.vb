Imports System.IO
Public Class frmRestoreDB

    Private Sub frmRestoreDB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BringToFront()
        dbPath.ShowDialog()
        txtFilename.Text = dbPath.FileName
    End Sub

    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        Try
            Dim YesNo As Integer
            YesNo = MsgBox("Sure to restore to selected file", vbQuestion + vbYesNo)
            If YesNo = vbYes Then
                MsgBox(shopstring)
                File.Delete(shopstring)
                File.Copy(txtFilename.Text, shopstring)
                MsgBox("Database restore completed", vbInformation + vbOKOnly)
            End If
        Catch exc As Exception
            MsgBox("An error occured while restoring the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
        Me.Close()
    End Sub

    Private Sub btnCopy_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCopy.MouseEnter
        With btnCopy
            .BackgroundImage = My.Resources.back2
            .Location = New Point(107, 105)
            .Size = New Size(83, 23)
        End With
    End Sub

    Private Sub btnCopy_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCopy.MouseLeave
        With btnCopy
            .BackgroundImage = My.Resources.back1
            .Location = New Point(111, 105)
            .Size = New Size(75, 23)
        End With
    End Sub
End Class