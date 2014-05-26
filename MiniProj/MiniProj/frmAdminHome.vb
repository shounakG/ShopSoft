Public Class frmAdminHome

    Private Sub frmAdminHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmMainMdi
    End Sub

    Private Sub picCreateUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCreateUser.Click
        frmAddAccount.Show()
    End Sub

    Private Sub mnuViewAccounts_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuViewAccounts.Click
        frmViewRecords.Show()
    End Sub

    Private Sub picCreateUser_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles picCreateUser.MouseEnter
        With picCreateUser
            .Location = New Drawing.Point(60, 34)
            .Size = New Drawing.Size(201, 49)
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
    End Sub

    Private Sub picCreateUser_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picCreateUser.MouseLeave
        With picCreateUser
            .Location = New Drawing.Point(65, 34)
            .Size = New Drawing.Size(191, 49)
            .SizeMode = PictureBoxSizeMode.CenterImage
        End With
    End Sub

    Private Sub picViewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picViewUser.Click
        frmViewRecords.Show()
    End Sub

    Private Sub picViewUser_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles picViewUser.MouseEnter
        With picViewUser
            .Location = New Drawing.Point(60, 89)
            .Size = New Drawing.Size(204, 51)
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
    End Sub

    Private Sub picViewUser_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picViewUser.MouseLeave
        With picViewUser
            .Location = New Drawing.Point(68, 89)
            .Size = New Drawing.Size(188, 51)
            .SizeMode = PictureBoxSizeMode.CenterImage
        End With
    End Sub

    Private Sub picChangePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picChangePassword.Click
        frmChangePassword.Show()
    End Sub

    Private Sub picChangePassword_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles picChangePassword.MouseEnter
        With picChangePassword
            .Location = New Drawing.Point(60, 146)
            .Size = New Drawing.Size(204, 51)
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
    End Sub

    Private Sub picChangePassword_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picChangePassword.MouseLeave
        With picChangePassword
            .Location = New Drawing.Point(68, 146)
            .Size = New Drawing.Size(188, 51)
            .SizeMode = PictureBoxSizeMode.CenterImage
        End With
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Dim YesNo As Integer
        YesNo = MsgBox("Do you want to exit?", MsgBoxStyle.YesNo)
        If YesNo = vbYes Then
            End
        End If
    End Sub

    Private Sub picManageCategories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picManageCategories.Click
        frmManageCategories.Show()
    End Sub

    Private Sub picManageCategories_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles picManageCategories.MouseEnter
        With picManageCategories
            .Location = New Drawing.Point(60, 203)
            .Size = New Drawing.Size(204, 51)
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
    End Sub

    Private Sub picManageCategories_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picManageCategories.MouseLeave
        With picManageCategories
            .Location = New Drawing.Point(68, 203)
            .Size = New Drawing.Size(188, 51)
            .SizeMode = PictureBoxSizeMode.CenterImage
        End With
    End Sub
End Class