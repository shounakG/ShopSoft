Imports System.Data.OleDb
Public Class frmMain
    Dim frmLoc As Point, TipIndex As Integer
    Dim fmChat As frmChat

    Private Sub contextExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contextExit.Click
        Dim YesNo As Integer
        YesNo = MsgBox("Do you really want to exit", vbQuestion + vbYesNo)
        If YesNo = vbYes Then
            Me.Close()
            End
        End If
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MsgBox("Thank you for using", MsgBoxStyle.Exclamation)
        connectShop()
        Dim dbCmd As New MySql.Data.MySqlClient.MySqlCommand("Update tblShop SET Status = 0 Where ShopName = '" & MyShopName & "';", dbConnection2)
        dbCmd.ExecuteNonQuery()
        dbConnection2.Close()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim MsgRes As Integer, YesNo As Integer
            ElapsedTimer.Start()
            IsNew = CheckDatabase()
            If IsNew = False Then
                MsgRes = MsgBox("Welcome to ShopSoft, a product by SAS group" & vbCrLf & _
                                "You seem to be a new shopkeeper, start by filling your product details", _
                                vbInformation + MsgBoxStyle.OkOnly)
                Select Case MsgRes
                    Case vbOK
                        MsgBox("Add some categories, sub-categories and some brands" & _
                               vbCrLf & "Failing to add even one of these will cause severe damage to the software", vbInformation + vbOKOnly)
                        Dim frmAddNew As New frmCategory
                        frmAddNew.ShowDialog()
                End Select
                YesNo = MsgBox("Congratulations, you can now use the software without any problems" & vbCrLf & _
                "Do you want to see the tutorial", vbQuestion + vbYesNo)
                If YesNo = vbYes Then frmVideoTutorial.ShowDialog()
            End If
            Dim dbAdapter As MySql.Data.MySqlClient.MySqlDataAdapter, dbTable As New DataTable
            connect()
            dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select Count(BillID) as cnt from tblBill where Delivered = -1", dbConnection)
            dbAdapter.Fill(dbTable)
            dbConnection.Close()
            If dbTable.Rows(0).Item("cnt") <> 0 Then
                frmNotify.lblNote.Text = "You have " & dbTable.Rows(0).Item(0) & " deliveries pending"
            Else
                frmNotify.lblNote.Text = "Congratulations, NO deliveries pending"
            End If
        Catch exc As Exception
            MsgBox("Error in fetching data from main server" & vbCrLf & "Errormsg: " & exc.Message, MsgBoxStyle.Critical)
        End Try
        frmNotify.Location = New Point(1100, 652)
        frmLoc = frmNotify.Location
        frmNotify.Show()
        AnimateTimer.Start()
    End Sub

    Private Sub mnuViewUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuViewUsers.Click
        Dim frmAccounts As New frmManageUsers
        frmAccounts.Show()
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Dim YesNo As Integer
        YesNo = MsgBox("Do you really want to exit", vbQuestion + vbYesNo)
        If YesNo = vbYes Then
            End
        End If
    End Sub

    Private Sub mnuCreateBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCreateBill.Click
        Try
            Dim dbAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter("Select MAX(BillID) from tblBill", dbConnection), dbTable As New DataTable
            connect()
            dbAdapter.Fill(dbTable)
            dbConnection.Close()
            CurrBillNo = dbTable.Rows(0).Item(0) + 1
            Dim BillForm As New Form
            BillForm = frmBillRegistered
            BillForm.Show()
        Catch exc As Exception
            MsgBox("Unable to fetch data from server" & vbCrLf & "Errorcode: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub mnuViewBills_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuViewBills.Click
        Dim frmBill As New frmReportBill
        frmBill.Show()
    End Sub

    Private Sub mnuViewIndividual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuViewIndividual.Click
        Dim frmItem As New frmItemInventory
        frmItem.Show()
    End Sub

    Private Sub mnuViewTree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuViewTree.Click
        Dim frmItem As New frmBrowseProducts
        frmItem.Show()
    End Sub

    Private Sub mnuAddEditItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAddEditItem.Click
        Dim frmAdd As New frmAddItem
        frmAdd.ShowDialog()
    End Sub

    Private Sub mnuViewCatSubCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuViewCatSubCat.Click
        Dim frmAdd As New frmCategory
        frmAdd.ShowDialog()
    End Sub

    Private Sub mnuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub mnuDBBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDBBack.Click
        frmBkpDB.ShowDialog()
    End Sub

    Private Sub mnuRestoreDB_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuRestoreDB.Click
        frmRestoreDB.ShowDialog()
    End Sub

    Private Sub ElapsedTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElapsedTimer.Tick
        txtTime.Text = FormatDateTime(Now, DateFormat.LongTime)
        txtDate.Text = FormatDateTime(Now, DateFormat.LongDate)
        txtElapsedTimer.Text = ""
        If ElapsedSec < 60 Then
            ElapsedSec += 1
        Else
            ElapsedSec = 0
            If ElapsedMin < 60 Then
                ElapsedMin += 1
            Else
                ElapsedHr += 1
                ElapsedMin = 0
            End If
        End If
        txtElapsedTimer.Text = "Runtime: " & ElapsedHr & ":" & ElapsedMin & ":" & ElapsedSec
    End Sub

    Private Function CheckDatabase() As Boolean
        Try
            Dim dbAdapter As MySql.Data.MySqlClient.MySqlDataAdapter, dbTable As New DataTable
            connect()
            dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select * from tblCategory", dbConnection)
            dbAdapter.Fill(dbTable)
            dbConnection.Close()
            If dbTable.Rows.Count = 0 Then
                Return False
            End If
            dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select * from tblSubCat", dbConnection)
            dbTable = New DataTable
            dbAdapter.Fill(dbTable)
            If dbTable.Rows.Count = 0 Then
                Return False
            End If
            dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select * from tblBrands", dbConnection)
            dbAdapter.Fill(dbTable)
            If dbTable.Rows.Count = 0 Then
                Return False
            End If
            dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("Select * from tblProducts", dbConnection)
            dbAdapter.Fill(dbTable)
            If dbTable.Rows.Count = 0 Then
                Return False
            End If
            Return True
        Catch ex As Exception
            MsgBox("Unable to fetch data from server" & vbCrLf & "Errorcode: " & ex.Message, MsgBoxStyle.Critical)
        End Try
        Return True
    End Function

    Private Sub btnAccountSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccountSetting.Click
        AnimateTimer.Start()
        Dim frmAccounts As New frmManageUsers
        frmAccounts.Show()
    End Sub

    Private Sub btnAccountSetting_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAccountSetting.MouseEnter
        With btnAccountSetting
            .Location = New Point(110, 103)
            .Size = New Size(219, 42)
            .BackgroundImage = My.Resources.back2
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        ToolTip.SetToolTip(btnAccountSetting, "View and manage store accounts")
    End Sub

    Private Sub btnAccountSetting_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAccountSetting.MouseLeave
        With btnAccountSetting
            .Location = New Point(129, 103)
            .Size = New Size(181, 42)
            .BackgroundImage = My.Resources.back1
            .BackgroundImageLayout = ImageLayout.Zoom
        End With
    End Sub

    Private Sub btnManageItemInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManageItemInventory.Click
        Dim frmWhattoDo As New frmItemWhatToDo
        frmWhattoDo.Show()
    End Sub

    Private Sub btnManageItemInventory_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnManageItemInventory.MouseEnter
        With btnManageItemInventory
            .Location = New Point(110, 163)
            .Size = New Size(219, 42)
            .BackgroundImage = My.Resources.back2
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        ToolTip.SetToolTip(btnManageItemInventory, "View all the products in your shop according to their category" & vbCrLf & "Also change their details if required")
    End Sub

    Private Sub btnManageItemInventory_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnManageItemInventory.MouseLeave
        With btnManageItemInventory
            .Location = New Point(129, 163)
            .Size = New Size(181, 42)
            .BackgroundImage = My.Resources.back1
            .BackgroundImageLayout = ImageLayout.Zoom
        End With
    End Sub

    Private Sub btnCreateBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateBill.Click
        Try
            Dim dbAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter("Select MAX(BillID) from tblBill", dbConnection), dbTable As New DataTable
            connect()
            dbAdapter.Fill(dbTable)
            dbConnection.Close()
            CurrBillNo = dbTable.Rows(0).Item(0) + 1
            Dim BillForm As New Form
            BillForm = frmBillRegistered
            BillForm.Show()
        Catch exc As Exception
            MsgBox("Unable to fetch data from server" & vbCrLf & "Errorcode: " & exc.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnCreateBill_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCreateBill.MouseEnter
        With btnCreateBill
            .Location = New Point(110, 222)
            .Size = New Size(219, 42)
            .BackgroundImage = My.Resources.back2
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        ToolTip.SetToolTip(btnCreateBill, "Perform billing and print bills")
    End Sub

    Private Sub btnCreateBill_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCreateBill.MouseLeave
        With btnCreateBill
            .Location = New Point(129, 222)
            .Size = New Size(181, 42)
            .BackgroundImage = My.Resources.back1
            .BackgroundImageLayout = ImageLayout.Zoom
        End With
    End Sub

    Private Sub btnUpdateStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateStock.Click
        Dim frmStock As New frmUpdateStock
        frmStock.ShowDialog()
    End Sub

    Private Sub btnUpdateStock_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpdateStock.MouseEnter
        With btnUpdateStock
            .Location = New Point(110, 281)
            .Size = New Size(219, 42)
            .BackgroundImage = My.Resources.back2
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        ToolTip.SetToolTip(btnUpdateStock, "Update the stock details of particular items")
    End Sub

    Private Sub btnUpdateStock_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpdateStock.MouseLeave
        With btnUpdateStock
            .Location = New Point(129, 281)
            .Size = New Size(181, 42)
            .BackgroundImage = My.Resources.back1
            .BackgroundImageLayout = ImageLayout.Zoom
        End With
    End Sub

    Private Sub btnReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports.Click
        Dim frmReports As New frmReportsMain
        frmReports.Show()
    End Sub

    Private Sub btnReports_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReports.MouseEnter
        With btnReports
            .Location = New Point(110, 336)
            .Size = New Size(219, 42)
            .BackgroundImage = My.Resources.back2
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        ToolTip.SetToolTip(btnReports, "View and print the reports for bills, customer details and stock items")
    End Sub

    Private Sub btnReports_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReports.MouseLeave
        With btnReports
            .Location = New Point(129, 336)
            .Size = New Size(181, 42)
            .BackgroundImage = My.Resources.back1
            .BackgroundImageLayout = ImageLayout.Zoom
        End With
    End Sub

    Private Sub btnRegisteredCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegisteredCustomer.Click
        Dim frmAddCus As New frmAddRegisteredCustomer
        frmAddCus.Show()
    End Sub

    Private Sub btnRegisteredCustomer_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRegisteredCustomer.MouseEnter
        With btnRegisteredCustomer
            .Location = New Point(110, 393)
            .Size = New Size(219, 42)
            .BackgroundImage = My.Resources.back2
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        ToolTip.SetToolTip(btnRegisteredCustomer, "Register a customer and send him a mail")
    End Sub

    Private Sub btnRegisteredCustomer_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRegisteredCustomer.MouseLeave
        With btnRegisteredCustomer
            .Location = New Point(129, 393)
            .Size = New Size(181, 42)
            .BackgroundImage = My.Resources.back1
            .BackgroundImageLayout = ImageLayout.Zoom
        End With
    End Sub

    Private Sub btnDeliveryStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeliveryStatus.Click
        Dim frmUpdateDelivery As New frmDeliveryStats
        frmUpdateDelivery.ShowDialog()
    End Sub

    Private Sub btnDeliveryStatus_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDeliveryStatus.MouseEnter
        With btnDeliveryStatus
            .Location = New Point(110, 450)
            .Size = New Size(219, 42)
            .BackgroundImage = My.Resources.back2
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        ToolTip.SetToolTip(btnDeliveryStatus, "Update the delivery status of the online ordered bills")
    End Sub

    Private Sub btnDeliveryStatus_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDeliveryStatus.MouseLeave
        With btnDeliveryStatus
            .Location = New Point(129, 450)
            .Size = New Size(181, 42)
            .BackgroundImage = My.Resources.back1
            .BackgroundImageLayout = ImageLayout.Zoom
        End With
    End Sub

    Private Sub btnNewsletter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewsletter.Click
        Dim frmLetter As New frmNewsLetter
        frmLetter.ShowDialog()
    End Sub

    Private Sub btnNewsletter_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNewsletter.MouseEnter
        With btnNewsletter
            .Location = New Point(110, 507)
            .Size = New Size(219, 42)
            .BackgroundImage = My.Resources.back2
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        ToolTip.SetToolTip(btnNewsletter, "Send a newsletter to all the customers")
    End Sub

    Private Sub btnNewsletter_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNewsletter.MouseLeave
        With btnNewsletter
            .Location = New Point(129, 507)
            .Size = New Size(181, 42)
            .BackgroundImage = My.Resources.back1
            .BackgroundImageLayout = ImageLayout.Zoom
        End With
    End Sub

    Private Sub mnuLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLogOut.Click
        Dim Activefrms As Form()
        Activefrms = Me.MdiChildren
        For i As Integer = 0 To Activefrms.Length - 1
            Activefrms(i).Close()
        Next
        Me.Hide()
        frmSplashLogin.Show()
    End Sub

    Private Sub AnimateTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnimateTimer.Tick
        Select Case frmLoc.Y
            Case Is > 600
                frmNotify.Location = New Point(frmLoc.X, frmLoc.Y - 4)
                frmNotify.BringToFront()
                frmLoc.Y -= 4
            Case Else
                If frmNotify.Opacity = 0 Then
                    frmNotify.Close()
                    AnimateTimer.Stop()
                ElseIf frmNotify.Opacity = 1 Then
                    Threading.Thread.Sleep(2000)
                End If
                frmNotify.Opacity = frmNotify.Opacity - 0.05
        End Select
    End Sub

    Private Sub ChatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChatToolStripMenuItem.Click
        fmChat = New frmChat
        fmChat.Show()
    End Sub
End Class