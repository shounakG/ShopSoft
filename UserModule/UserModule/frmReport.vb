Public Class frmReport
    Dim frmloc As Point
    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub frmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        frmNotify.Location = New Point(900, 652)
        frmloc = frmNotify.Location
        frmNotify.Show()
        AnimateTimer.Start()
    End Sub

    Private Sub AnimateTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnimateTimer.Tick
        Select Case frmloc.Y
            Case Is > 600
                frmNotify.Location = New Point(frmloc.X, frmloc.Y - 4)
                frmNotify.BringToFront()
                frmloc.Y -= 4
            Case Else
                If frmNotify.Opacity = 0 Then
                    frmNotify.Close()
                    AnimateTimer.Stop()
                ElseIf frmNotify.Opacity = 1 Then
                    Threading.Thread.Sleep(2000)
                End If
                frmNotify.Opacity = frmNotify.Opacity - 0.05
        End Select
    End Sub

End Class