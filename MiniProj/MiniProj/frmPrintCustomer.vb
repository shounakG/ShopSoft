﻿Imports System.Data.OleDb
Public Class frmPrintCustomer

    Private Sub frmPrintCustomer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        For Each ctrl As Control In Me.Controls
            ctrl.Dispose()
        Next
    End Sub

    Private Sub frmPrintCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim crStock As New PrintCustomerDetails(), dbStock As New DataTable
            Dim dbAdapter As MySql.Data.MySqlClient.MySqlDataAdapter
            connect()
            dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT CustomerID,CustomerName,CustomerAddress,MobileNo,email from tblCustomer;", dbConnection)
            dbAdapter.Fill(dbStock)
            dbConnection.Close()
            crStock.SetDataSource(dbStock)
            crStock.Refresh()
            CrystalReportViewer1.ReportSource = crStock
            CrystalReportViewer1.Refresh()
        Catch exc As Exception
            MsgBox("An error occured while fetching the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class