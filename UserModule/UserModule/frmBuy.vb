Public Class frmBuy

    Private Sub frmBuy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblThanks.Text = "Thank You for Shopping!"
    End Sub

    Private Sub lblShopMore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblShopMore.Click
        For Each c As Control In frmCart.Controls
            CType(c, Control).Text = String.Empty
            CType(c, Control).Enabled = True
        Next
        frmCart.Close()
        atcflag = False
        resetflag = True
        srno = 0
        frmMain.lblsrno.Text = srno.ToString
        frmMyAccount.lblsrno.Text = srno.ToString
        frmProductInfo.Close()
        Me.Close()
    End Sub

    Private Sub lblExitFinal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblExitFinal.Click
        End
    End Sub

End Class