Imports MySql.Data.MySqlClient
Public Class frmShopSelect


    Private Sub lblManu_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblManu.Enter
        btnProceed.Visible = True
        txtAddress.Visible = True
    End Sub

    Private Sub lblManu_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblManu.Leave
        btnProceed.Visible = False
        txtAddress.Visible = False
    End Sub

    Private Sub btnProceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProceed.Click
        Try
            If txtAddress.Text <> "" Then
                SelectedShop = txtAddress.Text
                frmMain.Show()
            Else
                ErrorProvider1.SetError(txtAddress, "Please enter a value")
            End If
        Catch ex As Exception
            If Me.Visible = False Then
                Me.Show()
            Else
                cbShopSelect.Focus()
            End If
        End Try
        
    End Sub

    Private Sub cbShopSelect_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbShopSelect.SelectionChangeCommitted
        Try

            Dim dbadapter As Mysql.data.mysqlclient.mysqldataadapter
            Dim dbtable As New DataTable
            Dim cmd As New MySqlCommand
            SelectedShopAdd = "syntaxso_server"
            dbtable.Clear()
            cmd.CommandText = " Select all * from tblShop where ShopName= '" & cbShopSelect.Text & "';"
            cmd.CommandType = CommandType.Text
            cmd.Connection = dbConnection2
            connectshop()
            dbadapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select all * from tblShop where ShopName= '" & cbShopSelect.Text & "';", dbConnection2)

            dbadapter.Fill(dbtable)

            dbConnection2.Close()

            If dbtable.Rows(0).Item("Status") = 0 Then
                MsgBox("Sorry This Shop is Offline!" & vbCrLf & "Please try one of the others")
            Else
                SelectedShop = dbtable.Rows(0).Item("ShopName")
                SelectedShopAdd = dbtable.Rows(0).Item(4)
                frmMain.Show()
            End If
        Catch ex As Exception
            If Me.Visible = False Then
                Me.Show()
            Else
                MsgBox(ex.ToString)
            End If
        End Try

        
    End Sub

    Private Sub txtAddress_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAddress.Enter
        If txtAddress.Text = "Enter Server Address" Then
            txtAddress.Text = ""
            btnProceed.Enabled = True
        End If
    End Sub

    Private Sub txtAddress_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAddress.KeyPress
        If Asc(e.KeyChar) = 39 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAddress_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAddress.Leave
        If txtAddress.Text = "" Then
            txtAddress.Text = "Enter Server Address"
            btnProceed.Enabled = False
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub lblManu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblManu.Click
        txtAddress.Visible = True
        btnProceed.Visible = True
    End Sub

    Private Sub txtAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddress.TextChanged

    End Sub


    Private Sub frmShopSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        strCommand = "Select all * from tblShop"
        strServer = "syntaxso_server"
        Dim dbtable As New DataTable
        If dbConnection.State = ConnectionState.Open Then
            dbConnection.Close()
        End If
        Dim SQLConnection As MySqlConnection = New MySqlConnection
        Dim ServerString As String = "Server=syntaxsofts.com; User Id =syntaxso;Password=i<3ManUtd;Database=" + strServer
        SQLConnection.ConnectionString = ServerString
        Dim cmd As MySqlCommand = New MySqlCommand
        Try
            If SQLConnection.State = ConnectionState.Closed Then
                SQLConnection.Open()
                With cmd
                    .CommandText = strCommand
                    .CommandType = CommandType.Text
                    .Connection = SQLConnection
                End With

                Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                adapter.Fill(dbtable)


            Else
                SQLConnection.Close()
                MsgBox("Connection is Closed.")
            End If

            '   For Each dRow In dbtable.Rows
            ' cbShopSelect.Items.Add((dRow.item(1)).ToString)
            ' Next

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class