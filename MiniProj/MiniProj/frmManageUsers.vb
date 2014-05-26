Public Class frmManageUsers

    Private Sub picCreateUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmAdd As New frmAddAccount
        frmAdd.ShowDialog()
    End Sub

    Private Sub frmManageUsers_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.MdiParent = frmMain
        Me.BringToFront()
    End Sub

    Private Sub btnCreateUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateUser.Click
        Dim frmAdd As New frmAddAccount
        frmAdd.ShowDialog()
    End Sub

    Private Sub btnCreateUser_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCreateUser.MouseEnter
        With btnCreateUser
            .Size = New Size(140, 34)
            .Location = New Point(107, 61)
            .Image = My.Resources.back2
        End With
    End Sub

    Private Sub btnCreateUser_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCreateUser.MouseLeave
        With btnCreateUser
            .Size = New Size(132, 34)
            .Location = New Point(111, 61)
            .Image = My.Resources.back1
        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Dim User As New Form
        User = frmViewRecords
        User.Show()
    End Sub

    Private Sub btnView_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnView.MouseEnter
        With btnView
            .Size = New Size(140, 34)
            .Location = New Point(107, 117)
            .Image = My.Resources.back2
        End With
    End Sub

    Private Sub btnView_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnView.MouseLeave
        With btnView
            .Size = New Size(132, 34)
            .Location = New Point(111, 117)
            .Image = My.Resources.back1
        End With
    End Sub
End Class