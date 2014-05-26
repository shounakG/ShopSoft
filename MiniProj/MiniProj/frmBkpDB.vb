Imports System.IO
Public Class frmBkpDB

    Private Sub frmBkpDB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BringToFront()
        With dbPath
            .Title = "Select a path to store backup"
            .FileName = "bkpDB" & FormatDateTime(Now, DateFormat.ShortDate)
            .InitialDirectory = "C:\"
            .ShowDialog()
        End With
        txtFilename.Text = dbPath.FileName
    End Sub

    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        Try
            FileCopy(shopstring, txtFilename.Text)
            MsgBox("Backup taken successfully", MsgBoxStyle.Information)
            Me.Close()
        Catch exc As Exception
            MsgBox("An error occured while backing up" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnCopy_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCopy.MouseEnter
        With btnCopy
            .Location = New Point(101, 111)
            .Size = New Size(83, 23)
            .BackgroundImage = My.Resources.back2
        End With
    End Sub

    Private Sub btnCopy_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCopy.MouseLeave
        With btnCopy
            .Location = New Point(105, 111)
            .Size = New Size(75, 23)
            .BackgroundImage = My.Resources.back1
        End With
    End Sub
End Class