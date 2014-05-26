Imports System.Data.OleDb
Public Class frmPrintDelivery

    Private Sub frmPrintDelivery_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        For Each ctrl As Control In Me.Controls
            ctrl.Dispose()
        Next
    End Sub

    Private Sub frmPrintDelivery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim crStock As New crDelivery(), dbStock As New DataSet1()
            Dim dbAdapter As MySql.Data.MySqlClient.MySqlDataAdapter
            connect()
            dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select * from tblBill;", dbConnection)
            dbAdapter.Fill(dbStock, "delivery")
            dbConnection.Close()
            crStock.SetDataSource(dbStock)
            crStock.Refresh()
            CrystalReportViewer1.ReportSource = crStock
            CrystalReportViewer1.Refresh()
            Me.WindowState = FormWindowState.Maximized
        Catch exc As Exception
            MsgBox("An error occured while fetching the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class