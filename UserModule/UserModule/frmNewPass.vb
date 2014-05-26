Public Class frmNewPass

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        Me.Close()
    End Sub

    Private Sub txtRepPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRepPass.KeyPress
        If Asc(e.KeyChar) = 39 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtRepPass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRepPass.TextChanged
        If txtRepPass.Text <> "" And txtPassword.Text = txtRepPass.Text Then
            btnDone.Enabled = True
        End If
    End Sub

    Private Sub frmNewPass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnDone.Enabled = False
        txtRepPass.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If Asc(e.KeyChar) = 39 Then
            e.Handled = True
        End If
    End Sub


End Class