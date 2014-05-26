Public Class frmItemWhatToDo

    Private Sub btnIndividual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIndividual.Click
        Dim frmItem As New frmItemInventory
        frmItem.Show()
    End Sub

    Private Sub btnShowTree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowTree.Click
        Dim frmItem As New frmBrowseProducts
        frmItem.Show()
    End Sub

    Private Sub btnAddProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddProduct.Click
        Dim frmAdd As New frmAddItem
        frmAdd.ShowDialog()
    End Sub

    Private Sub frmItemWhatToDo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmMain
        Me.BringToFront()
    End Sub

    Private Sub btnManageCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManageCategory.Click
        Dim frmAdd As New frmCategory
        Me.Hide()
        frmAdd.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnIndividual_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnIndividual.MouseEnter
        With btnIndividual
            .Location = New Point(56, 38)
            .Size = New Size(161, 47)
            .BackgroundImage = My.Resources.back2
        End With
    End Sub

    Private Sub btnIndividual_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnIndividual.MouseLeave
        With btnIndividual
            .Location = New Point(63, 38)
            .Size = New Size(147, 47)
            .BackgroundImage = My.Resources.back1
        End With
    End Sub

    Private Sub btnShowTree_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnShowTree.MouseEnter
        With btnShowTree
            .Location = New Point(56, 91)
            .Size = New Size(161, 47)
            .BackgroundImage = My.Resources.back2
        End With
    End Sub

    Private Sub btnShowTree_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnShowTree.MouseLeave
        With btnShowTree
            .Location = New Point(63, 91)
            .Size = New Size(147, 47)
            .BackgroundImage = My.Resources.back1
        End With
    End Sub

    Private Sub btnAddProduct_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddProduct.MouseEnter
        With btnAddProduct
            .Location = New Point(56, 144)
            .Size = New Size(161, 47)
            .BackgroundImage = My.Resources.back2
        End With
    End Sub

    Private Sub btnAddProduct_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddProduct.MouseLeave
        With btnAddProduct
            .Location = New Point(63, 144)
            .Size = New Size(147, 47)
            .BackgroundImage = My.Resources.back1
        End With
    End Sub

    Private Sub btnManageCategory_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnManageCategory.MouseEnter
        With btnManageCategory
            .Location = New Point(56, 197)
            .Size = New Size(161, 47)
            .BackgroundImage = My.Resources.back2
        End With
    End Sub

    Private Sub btnManageCategory_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnManageCategory.MouseLeave
        With btnManageCategory
            .Location = New Point(63, 197)
            .Size = New Size(147, 47)
            .BackgroundImage = My.Resources.back1
        End With
    End Sub
End Class