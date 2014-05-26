Imports System.Data.OleDb
Public Class frmItems

    Private Sub frmItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmMain
        Me.Location = New Point(178, 58)
        Dim dbadapter As OleDbDataAdapter, dbtable As New DataTable
        connect()

        dbConnection.Close()
    End Sub