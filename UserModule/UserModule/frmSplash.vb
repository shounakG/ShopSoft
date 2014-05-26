Public Class frmSplash
    Dim index As Integer = 0
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If index < 4 Then
            index += 1
            If index = 2 Then
                Me.TopMost = True
                frmShopSelect.Show()
            End If
        Else
            Me.Close()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub frmSplash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
End Class
