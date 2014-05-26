Public Class frmReportsMain

    Private Sub btnBillReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBillReports.Click
        Dim frmBill As New frmReportBill
        frmBill.ShowDialog()
        'Me.Close()
    End Sub

    Private Sub btnStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStock.Click
        Dim frmStock As New frmPerformStock
        frmStock.ShowDialog()
        'Me.Close()
    End Sub

    Private Sub btnCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomer.Click
        Dim frmCustomer As New frmPrintCustomer
        frmCustomer.ShowDialog()
        'Me.Close()
    End Sub

    Private Sub btnBillReports_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBillReports.MouseEnter
        With btnBillReports
            .Location = New Point(40, 48)
            .Size = New Size(193, 52)
            .BackgroundImage = My.Resources.back2
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
    End Sub

    Private Sub btnBillReports_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBillReports.MouseLeave
        With btnBillReports
            .Location = New Point(45, 48)
            .Size = New Size(183, 52)
            .BackgroundImage = My.Resources.back1
            .BackgroundImageLayout = ImageLayout.Zoom
        End With
    End Sub

    Private Sub btnStock_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStock.MouseEnter
        With btnStock
            .Location = New Point(40, 106)
            .Size = New Size(193, 52)
            .BackgroundImage = My.Resources.back2
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
    End Sub

    Private Sub btnStock_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStock.MouseLeave
        With btnStock
            .Location = New Point(45, 106)
            .Size = New Size(183, 52)
            .BackgroundImage = My.Resources.back1
            .BackgroundImageLayout = ImageLayout.Zoom
        End With
    End Sub

    Private Sub btnCustomer_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCustomer.MouseEnter
        With btnCustomer
            .Location = New Point(40, 164)
            .Size = New Size(193, 52)
            .BackgroundImage = My.Resources.back2
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
    End Sub

    Private Sub btnCustomer_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCustomer.MouseLeave
        With btnCustomer
            .Location = New Point(45, 164)
            .Size = New Size(183, 52)
            .BackgroundImage = My.Resources.back1
            .BackgroundImageLayout = ImageLayout.Zoom
        End With
    End Sub

    Private Sub frmReportsMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.MdiParent = frmMain
        Me.BringToFront()
    End Sub
End Class