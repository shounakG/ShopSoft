Imports System.Data.OleDb
Public Class frmDeliveryStats

    Dim myDA As MySql.Data.MySqlClient.MySqlDataAdapter, myDataSet As DataSet
    Dim BillID As Integer

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.myDA.Update(Me.myDataSet.Tables("MyTable"))
        Me.myDataSet.AcceptChanges()
        Me.Close()
    End Sub

    Sub fill()
        Dim dbTable As New DataTable, dbQuery As MySql.Data.MySqlClient.MySqlDataAdapter, cmd As MySql.Data.MySqlClient.MySqlCommand
        connect()
        dbQuery = New MySql.Data.MySqlClient.MySqlDataAdapter("select * from tblBill where Delivered = -1;", dbConnection)
        dbQuery.Fill(dbTable)
        cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM tblBill where Delivered = -1;", dbConnection)
        myDA = New MySql.Data.MySqlClient.MySqlDataAdapter(cmd)
        Dim builder As MySql.Data.MySqlClient.MySqlCommandBuilder = New MySql.Data.MySqlClient.MySqlCommandBuilder(myDA)
        myDataSet = New DataSet()
        myDA.Fill(myDataSet, "MyTable")
        dgridDelivery.DataSource = myDataSet.Tables("MyTable").DefaultView
        dbConnection.Close()
        dbConnection = Nothing
        dgridDelivery.Visible = True
        btnSave.Visible = True
    End Sub

    Private Sub frmDeliveryStats_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.BringToFront()
            Dim dbAdapter As MySql.Data.MySqlClient.MySqlDataAdapter, dbTable As New DataTable
            dgridDelivery.Select()
            connect()
            dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select * from tblBill", dbConnection)
            dbAdapter.Fill(dbTable)
            dbConnection.Close()
            dgridDelivery.DataSource = dbTable
            dgridDelivery.Visible = True
            btnCancel.Visible = True
        Catch exc As Exception
            MsgBox("An error occured while fetching the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim PrintDel As New frmPrintDelivery
        PrintDel.ShowDialog()
    End Sub

    Private Sub btnShowOnlyUndelivered_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowOnlyUndelivered.CheckedChanged
        btnPrint.Visible = False
        btnShowOnlyUndelivered.Enabled = False
        btnSpecificBill.Visible = False
        fill()
    End Sub

    Private Sub btnPrint_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.MouseEnter
        With btnPrint
            .Location = New Point(267, 432)
            .Size = New Size(92, 36)
            .BackgroundImage = My.Resources.back2
        End With
    End Sub

    Private Sub btnPrint_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.MouseLeave
        With btnPrint
            .Location = New Point(271, 432)
            .Size = New Size(84, 36)
            .BackgroundImage = My.Resources.back1
        End With
    End Sub

    Private Sub btnSave_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.MouseEnter
        With btnSave
            .Location = New Point(369, 432)
            .Size = New Size(86, 36)
            .BackgroundImage = My.Resources.back2
        End With
    End Sub

    Private Sub btnSave_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.MouseLeave
        With btnSave
            .Location = New Point(373, 432)
            .Size = New Size(78, 36)
            .BackgroundImage = My.Resources.back1
        End With
    End Sub

    Private Sub btnCancel_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.MouseEnter
        With btnCancel
            .Location = New Point(466, 432)
            .Size = New Size(86, 36)
            .BackgroundImage = My.Resources.back2
        End With
    End Sub

    Private Sub btnCancel_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.MouseLeave
        With btnCancel
            .Location = New Point(470, 432)
            .Size = New Size(78, 36)
            .BackgroundImage = My.Resources.back1
        End With
    End Sub

    Private Sub dgridDelivery_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgridDelivery.CellClick
        BillID = dgridDelivery.SelectedRows.Item(0).Cells.Item("BillID").Value
        btnSpecificBill.Visible = True
    End Sub

    Private Sub btnSpecificBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpecificBill.Click
        Try
            Dim dbSet As New DataSet1(), cr As New crSpecific()
            Dim dbAdapter As MySql.Data.MySqlClient.MySqlDataAdapter
            connect()
            dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select DISTINCT ProdName,ProdQty,MRP,Rate,Total,tblBill.BillID" & _
                                             " from tblProductDetails,tblBillDetails,tblBill where tblBillDetails.BillID =" & BillID & " AND tblProductDetails.ProductID = tblBillDetails.ProductID AND tblBill.BillID = tblBillDetails.BillID;", dbConnection)
            dbAdapter.Fill(dbSet, "bill")
            dbConnection.Close()
            cr.SetDataSource(dbSet)
            cr.Refresh()
            frmReport.CrystalReportViewer1.ReportSource = cr
            frmReport.CrystalReportViewer1.Refresh()
            frmReport.WindowState = FormWindowState.Maximized
            frmReport.ShowDialog()
            cr.Close()
            'frmReport.CrystalReportViewer1.Dispose()
            Me.Close()
        Catch exc As Exception
            MsgBox("An error occured while fetching the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnSpecificBill_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSpecificBill.MouseEnter
        With btnSpecificBill
            .Location = New Point(9, 432)
            .Size = New Size(90, 36)
            .BackgroundImage = My.Resources.back2
        End With
    End Sub

    Private Sub btnSpecificBill_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSpecificBill.MouseLeave
        With btnSpecificBill
            .Location = New Point(12, 432)
            .Size = New Size(84, 36)
            .BackgroundImage = My.Resources.back1
        End With
    End Sub
End Class