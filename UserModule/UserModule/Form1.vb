Imports System.Data.OleDb
Public Class frmMain

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dbAdapter As OleDbDataAdapter, dbTable As New DataTable, tbl2 As New DataTable, index As Integer = 0
        connect()
        dbAdapter = New OleDbDataAdapter("select CatName from tblCategory", dbConnection)
        dbAdapter.Fill(dbTable)
        For Each nRow In dbTable.Rows
            tbl2.Clear()
            dbAdapter = New OleDbDataAdapter("select SubCatName from tblSubCat where CatID = (Select CatId from tblCategory where CatName = '" & nRow.item(0) & "');", dbConnection)
            dbAdapter.Fill(tbl2)
            tvMain.Nodes.Add(index, nRow.item(0))
            For Each dRow In tbl2.Rows
                tvMain.Nodes(index).Nodes.Add(dRow.item(0))
            Next
            index += 1
        Next
        dbConnection.Close()
    End Sub

    Private Sub tvMain_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvMain.AfterSelect

    End Sub

    Private Sub tvMain_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tvMain.NodeMouseDoubleClick

        subcat = tvMain.SelectedNode.Text
        frmItems.Show()
    End Sub
End Class
