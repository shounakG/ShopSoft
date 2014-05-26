Imports MySql.Data.MySqlClient
Public Class frmChat

    Dim cId As Integer

    Private Sub frmChat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim res As String = getResponse("http://shopsoft.syntaxsofts.com/getNewChatMsgSSide.php?sName=" & MyShopName & "&prevID=" & prevID)

        If Not res.Equals("nonewmsgs") Then
            Dim msg As String = res.Split("%")(0)
            cId = Integer.Parse(res.Split("%")(1))
            Dim cName As String = getCustName(cId)
            lstMsgs.Items.Add(cName + ": " + msg)
            cmbCus.Items.Add(cId.ToString + ": " + cName)
            cmbCus.Text = cmbCus.Items(0).ToString
        End If
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        If txtMsg.Text <> String.Empty Then
            Dim send As String = getResponse("http://shopsoft.syntaxsofts.com/sendChatMsgSSide.php?sName=" & MyShopName & "&cID=" & cId & "&msgText=" & txtMsg.Text)
            prevID = Integer.Parse(send.Split("%")(1))
            lstMsgs.Items.Add("You: " + txtMsg.Text)
            txtMsg.Text = ""
        End If
    End Sub

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        Dim res As String = getResponse("http://shopsoft.syntaxsofts.com/getNewChatMsgSSide.php?sName=" & MyShopName & "&prevID=" & prevID)

        If Not res.Equals("nonewmsgs") Then
            Dim msg As String = res.Split("%")(0)
            Dim cName As String = getCustName(res.Split("%")(1))
            lstMsgs.Items.Add(cName + ": " + msg)
            If Not cmbCus.Items.Contains(res.Split("%")(1) + ": " + cName) Then
                cmbCus.Items.Add(res.Split("%")(1) + ": " + cName)
            End If
        End If
    End Sub

    Private Sub cmbCus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCus.SelectedIndexChanged
        cId = Integer.Parse(cmbCus.Text.Split(": ")(0))
    End Sub

    Private Function getCustName(ByVal cId As Integer) As String
        Dim adapter As New MySqlDataAdapter("select cusName from tblCustomer where cusID = " & cId, dbConnection2)
        Dim table As New DataTable

        adapter.Fill(table)
        dbConnection2.Close()
        Return table.Rows(0).Item("cusName")
    End Function
End Class