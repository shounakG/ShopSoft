Public Class frmAboutUs

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        frmCatBrowse.Close()
        frmItems.Close()
        frmItemsSearch.Close()
        frmSubCat.Close()
        Me.Close()
        frmMain.Show()
        frmCatBrowse.Show()
    End Sub

    Private Sub frmAboutUs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class