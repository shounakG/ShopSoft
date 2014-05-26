Imports System.Data.OleDb
Public Class frmReportBill
    Dim dsBill As New DataSet1()


    Private Sub frmReportBill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BringToFront()
        grpByDate.Enabled = True
        grpByNumber.Enabled = True
    End Sub

    Private Sub txtFromNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFromNumber.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8
            Case Else
                e.Handled = True
        End Select
        grpByDate.Enabled = False
    End Sub

    Private Sub txtToNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtToNumber.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        If grpByDate.Enabled = True Then
            dsBill = SearchBills("Date")
        ElseIf grpByNumber.Enabled = True Then
            If txtFromNumber.Text <> "" And txtToNumber.Text <> "" Then
                dsBill = SearchBills("Number")
            Else
                MsgBox("Incomplete information", MsgBoxStyle.Critical)
            End If
        End If
        Dim cr As New ReportBill()
        cr.SetDataSource(dsBill)
        cr.Refresh()
        frmReportSelected.CrystalReportViewer1.ReportSource = cr
        frmReportSelected.CrystalReportViewer1.Refresh()
        frmReportSelected.WindowState = FormWindowState.Maximized
        frmReportSelected.ShowDialog()
        cr.Close()
        Me.Close()
    End Sub

    Private Function SearchBills(ByVal SearchBy As String) As DataSet1
        Dim dtResults As New DataSet1, dbAdapter As MySql.Data.MySqlClient.MySqlDataAdapter
        Try
            connect()
            Select Case SearchBy
                Case "Number"
                    dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select * from tblBill where tblBill.BillID BETWEEN " & Val(txtFromNumber.Text) & " AND " & Val(txtToNumber.Text) & ";", dbConnection)
                    dbAdapter.Fill(dtResults, "BillReportTable")
                Case "Date"
                    MsgBox("Select * from tblBill where Extract(month from tblBill.DateofBill) = '" & cmbMonth.SelectedValue & "';")
                    dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select * from tblBill where Extract(month from tblBill.DateofBill) = '" & cmbMonth.SelectedValue & "';", dbConnection)
                    dbAdapter.Fill(dtResults, "BillReportTable")
            End Select
            dbConnection.Close()
        Catch exc As Exception
            MsgBox("An error occured while fetching the database" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
        Return dtResults
    End Function

    Private Sub btnGo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGo.MouseEnter
        With btnGo
            .Location = New Point(225, 143)
            .Size = New Size(86, 38)
            .BackgroundImage = My.Resources.back2
        End With
    End Sub

    Private Sub btnGo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGo.MouseLeave
        With btnGo
            .Location = New Point(230, 143)
            .Size = New Size(76, 38)
            .BackgroundImage = My.Resources.back1
        End With
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMonth.SelectedIndexChanged
        grpByDate.Enabled = True
        grpByNumber.Enabled = False
    End Sub
End Class