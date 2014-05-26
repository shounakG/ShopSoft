Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Public Class frmMain

    Dim ReadyToDisplay As Boolean = False
    Dim pos1 As Size
    Dim loc1 As Point
    Dim pos2 As Size
    Dim loc2 As Point
    Dim pos3 As Size
    Dim loc3 As Point
    Dim flag As Boolean = True
    Dim change As Boolean = True
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        Me.Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
        tvMain.Location = New Point(Screen.PrimaryScreen.Bounds.Width - 141, 112)
        tvMain.Size = New Size(Me.Size.Width, Screen.PrimaryScreen.Bounds.Height)
        PictureBox1.Size = New Size(Screen.PrimaryScreen.Bounds.Width, 110)
        Dim i = 0
resu:
        Try
            Me.WindowState = FormWindowState.Maximized
            Dim dbAdapter As Mysql.data.mysqlclient.mysqldataadapter, dbTable As New DataTable, nRow As DataRow
            connect()
            dbAdapter = New Mysql.data.mysqlclient.mysqldataadapter("Select all * from tblCategory", dbConnection)
            dbAdapter.Fill(dbTable)
            dbConnection.Close()
            Try
                For Each nRow In dbTable.Rows
                    stripCategory.Items.Add(nRow.Item("CatName"), getPicture(nRow.Item("Photos")))
                Next
                lblsrno.Text = srno.ToString
lbl:
                frmCatBrowse.Show()
            Catch ex As Exception
                GoTo lbl
            End Try

        Catch ex As Exception
            i = MsgBox("An unanticipated error has occured, what would you like to do?", vbAbortRetryIgnore)
            Select Case i
                Case vbAbort
                    End
                Case vbRetry
                    GoTo resu
                Case vbIgnore
                    Me.Dispose()
                    frmShopSelect.Show()
                    GoTo termi
            End Select
        End Try
termi:
    End Sub

    Private Sub tvMain_AfterCollapse(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvMain.AfterCollapse
        ReadyToDisplay = False
        frmItems.Close()
    End Sub

    Private Sub tvMain_AfterExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvMain.AfterExpand
        ReadyToDisplay = True
    End Sub


    Private Sub tvMain_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvMain.AfterSelect

        frmItems.Close()
        If ReadyToDisplay = True Then
            subcat = tvMain.SelectedNode.Text
            frmItems.Visible = True
        End If
    End Sub

    Private Sub btnMainSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainSearch.Click
        If Me.txtSearchMain.Text = String.Empty Then
            MsgBox("Please Enter a value")
        Else
            frmItemsSearch.Close()
            frmItemsSearch.Show()
        End If
    End Sub

    Private Sub btnMainBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainBrowse.Click
        Timer1.Stop()
        btnMainBrowse.ForeColor = Color.Black
        tvMain.Nodes.Clear()
        Dim dbAdapter As Mysql.data.mysqlclient.mysqldataadapter, dbTable As New DataTable, tbl2 As New DataTable, index As Integer = 0
        connect()
        dbAdapter = New Mysql.data.mysqlclient.mysqldataadapter("select CatName from tblCategory", dbConnection)
        dbAdapter.Fill(dbTable)
        dbConnection.Close()
        For Each nRow In dbTable.Rows
            tbl2.Clear()
            connect()
            dbAdapter = New Mysql.data.mysqlclient.mysqldataadapter("select SubCatName from tblSubCat where CatID = (Select CatId from tblCategory where CatName = '" & nRow.item(0) & "');", dbConnection)
            dbAdapter.Fill(tbl2)
            dbConnection.Close()
            tvMain.Nodes.Add(index, nRow.item(0))
            For Each dRow In tbl2.Rows
                tvMain.Nodes(index).Nodes.Add(dRow.item(0))
            Next
            index += 1
        Next
        If tvMain.Visible = False Then
            tvMain.Show()
        Else
            tvMain.Visible = False
        End If
    End Sub

    Private Sub picShoppingCart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picShoppingCart.Click
        If atcflag = True Then
            frmCart.Show()
        Else
            MsgBox("You haven't added an item to the cart yet")
        End If
    End Sub

    Private Sub lblAboutUs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAboutUs.Click
        frmAboutUs.Show()
    End Sub

    Private Sub lblMyAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMyAccount.Click
        If loginflag = True Then
            frmMyAccount.Show()
        Else
            Afterlogin = 1
            frmLogin.ShowDialog()
        End If
    End Sub



    Private Sub cbCriteria_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCriteria.TextChanged
        If rbBrands.Checked = True Or rbCat.Checked = True Or rbSubCat.Checked = True Then
            cbCriteria.DroppedDown = True
        End If
    End Sub

    Private Sub txtSearchMain_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearchMain.KeyPress
        If Asc(e.KeyChar) = 39 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSearchMain_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtSearchMain.MouseClick
        If txtSearchMain.Text = "Search for Products" Then
            txtSearchMain.Text = String.Empty
        End If
    End Sub

    Private Sub rbCat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCat.CheckedChanged
        cbCriteria.Items.Clear()
        Dim dbAdapter As Mysql.data.mysqlclient.mysqldataadapter, dbTable As New DataTable, i As Integer = 0
        connect()
        dbAdapter = New Mysql.data.mysqlclient.mysqldataadapter("select all CatName from tblCategory", dbConnection)
        dbAdapter.Fill(dbTable)
        dbConnection.Close()
        For Each nrow As DataRow In dbTable.Rows
            cbCriteria.Items.Add(nrow.Item(0))
        Next
    End Sub

    Private Sub rbSubCat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSubCat.CheckedChanged
        cbCriteria.Items.Clear()
        Dim dbAdapter As Mysql.data.mysqlclient.mysqldataadapter, dbTable As New DataTable, i As Integer = 0
        connect()
        dbAdapter = New Mysql.data.mysqlclient.mysqldataadapter("select all SubCatName from tblSubCat", dbConnection)
        dbAdapter.Fill(dbTable)
        dbConnection.Close()
        For Each nrow As DataRow In dbTable.Rows
            cbCriteria.Items.Add(nrow.Item(0))
        Next
    End Sub

    Private Sub rbBrands_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbBrands.CheckedChanged
        cbCriteria.Items.Clear()
        Dim dbAdapter As Mysql.data.mysqlclient.mysqldataadapter, dbTable As New DataTable, i As Integer = 0
        connect()
        dbAdapter = New Mysql.data.mysqlclient.mysqldataadapter("select all BrandName from tblBrands", dbConnection)
        dbAdapter.Fill(dbTable)
        dbConnection.Close()
        For Each nrow As DataRow In dbTable.Rows
            cbCriteria.Items.Add(nrow.Item(0))
        Next
    End Sub

    Private Sub cbCriteria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCriteria.SelectedIndexChanged
        Me.btnMainSearch.Focus()
    End Sub

    Private Sub picMainLogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMainLogo.Click
        frmCatBrowse.Close()
        frmItems.Close()
        frmItemsSearch.Close()
        frmSubCat.Close()
        Me.Show()
        frmCatBrowse.Show()
    End Sub

    Private Sub stripCategory_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles stripCategory.ItemClicked
        Dim Cat As String, dbAdapter As Mysql.data.mysqlclient.mysqldataadapter, dbTable As New DataTable
        Dim cmbBox As ComboBox
        Cat = e.ClickedItem.Text
        connect()
        dbAdapter = New Mysql.data.mysqlclient.mysqldataadapter("Select SubCatName from tblSubCat where CatID = (Select CatID from tblCategory where CatName = '" & Cat & "');", dbConnection)
        dbAdapter.Fill(dbTable)
        dbConnection.Close()
        cmbBox = New ComboBox
        With cmbBox
            .Location = New Point(MousePosition.X, stripCategory.Location.Y)
            .Show()
            .DroppedDown = True
        End With
        AddHandler cmbBox.SelectionChangeCommitted, AddressOf cmbBox_Click
        '  AddHandler cmbBox.Leave, AddressOf cmbbox_leave
        Me.Controls.Add(cmbBox)
        For Each nRow As DataRow In dbTable.Rows
            cmbBox.Items.Add(nRow.Item(0))
        Next
    End Sub

    Private Sub cmbBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TypeOf sender Is ComboBox Then
            frmItems.Close()
            subcat = sender.SelectedItem
            frmItems.Show()
        End If
    End Sub


    ' Private Sub cmbbox_leave(ByVal sender As Object, ByVal e As System.EventArgs)
    '  sender.dispose()
    ' End Sub

    Private Sub lblLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLogout.Click
        Me.lblLogout.Visible = False
        Me.lblMyAccount.Text = "Login"
        loginflag = False
        frmLogin.txtCustName.Text = ""
        frmLogin.txtCustPass.Text = ""
    End Sub

    Private Sub lblMyAccount_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblMyAccount.MouseEnter
        pos1 = lblMyAccount.Size
        loc1 = lblMyAccount.Location
        lblMyAccount.Location = New Point(loc1.X - 10, loc1.Y)
        lblMyAccount.Size = New Size(pos1.Width + 20, pos1.Height)
    End Sub

    Private Sub lblMyAccount_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblMyAccount.MouseLeave
        lblMyAccount.Size = pos1
        lblMyAccount.Location = loc1
    End Sub

    Private Sub lblAboutUs_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblAboutUs.MouseEnter
        pos2 = lblAboutUs.Size
        loc2 = lblAboutUs.Location
        lblAboutUs.Location = New Point(loc2.X - 10, loc2.Y)
        lblAboutUs.Size = New Size(pos2.Width + 20, pos2.Height)
    End Sub

    Private Sub lblAboutUs_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblAboutUs.MouseLeave
        lblAboutUs.Size = pos2
        lblAboutUs.Location = loc2
    End Sub

    Private Sub lblLogout_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblLogout.MouseEnter
        pos3 = lblLogout.Size
        loc3 = lblLogout.Location
        lblLogout.Location = New Point(loc3.X - 10, loc3.Y)
        lblLogout.Size = New Size(pos3.Width + 20, pos3.Height)
    End Sub

    Private Sub lblLogout_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblLogout.MouseLeave
        lblLogout.Size = pos3
        lblLogout.Location = loc3
    End Sub

    Private Sub lblSelect_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblSelect.MouseEnter
        pos3 = lblSelect.Location
        loc3 = lblSelect.Location
        lblSelect.Location = New Point(loc3.X - 10, loc3.Y)
        lblSelect.Size = New Size(pos3.Width + 20, pos3.Height)
    End Sub

    Private Sub lblSelect_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblSelect.MouseLeave
        lblSelect.Size = pos3
        lblSelect.Location = loc3
    End Sub

    Private Sub lblLite_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblLite.MouseEnter
        pos3 = lblLite.Location
        loc3 = lblLite.Location
        lblLite.Location = New Point(loc3.X - 10, loc3.Y)
        lblLite.Size = New Size(pos3.Width + 20, pos3.Height)
    End Sub

    Private Sub lblLite_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblLite.MouseLeave
        lblLite.Size = pos3
        lblLite.Location = loc3
    End Sub

    Private Sub picMainLogo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles picMainLogo.MouseEnter
        pos1 = Me.picMainLogo.Size
        loc1 = picMainLogo.Location
        picMainLogo.Location = New Point(loc1.X - 20, loc1.Y - 10)
        picMainLogo.Size = New Size(pos1.Width + 40, pos1.Height + 40)
    End Sub



    Private Sub picMainLogo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picMainLogo.MouseLeave
        picMainLogo.Location = New Point(loc1)
        picMainLogo.Size = New Size(pos1)
    End Sub

    Private Sub picShoppingCart_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles picShoppingCart.MouseEnter
        pos1 = Me.picShoppingCart.Size
        loc1 = picShoppingCart.Location
        picShoppingCart.Location = New Point(loc1.X - 20, loc1.Y - 10)
        picShoppingCart.Size = New Size(pos1.Width + 10, pos1.Height + 20)
    End Sub

    Private Sub picShoppingCart_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picShoppingCart.MouseLeave
        picShoppingCart.Location = New Point(loc1)
        picShoppingCart.Size = New Size(pos1)
    End Sub


    Private Sub cmbTheme_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTheme.SelectionChangeCommitted
        Select Case cmbTheme.SelectedIndex
            Case 0
                PictureBox1.BackColor = Color.FromArgb(26, 21, 74)
                rbAll.BackColor = Color.FromArgb(26, 21, 74)
                lblLite.BackColor = Color.FromArgb(26, 21, 74)
                tvMain.BackColor = Color.FromArgb(26, 21, 74)
                frmSignUp.BackColor = Color.FromArgb(217, 217, 220)
                frmProductInfo.BackColor = Color.FromArgb(217, 217, 220)
                frmMyAccount.BackColor = Color.FromArgb(217, 217, 220)
                frmCart.BackColor = Color.FromArgb(217, 217, 220)
                frmAboutUs.BackColor = Color.FromArgb(217, 217, 220)
                frmCatBrowse.BackColor = Color.FromArgb(171, 171, 211)
                frmItems.BackColor = Color.FromArgb(171, 171, 211)
                frmItemsSearch.BackColor = Color.FromArgb(171, 171, 211)
                frmLogin.BackColor = Color.FromArgb(171, 171, 211)
                frmSubCat.BackColor = Color.FromArgb(171, 171, 211)
                frmBuy.BackColor = Color.FromArgb(171, 171, 211)
                frmForgotPass.BackColor = Color.FromArgb(171, 171, 211)
                frmNewPass.BackColor = Color.FromArgb(171, 171, 211)
                Me.lblsrno.BackColor = Color.FromArgb(26, 21, 74)
                frmMyAccount.lblsrno.BackColor = Color.FromArgb(26, 21, 74)
                picShoppingCart.Image = My.Resources.shopping_cart_logo0
            Case 1
                PictureBox1.BackColor = Color.FromArgb(0, 71, 107)
                rbAll.BackColor = Color.FromArgb(0, 71, 107)
                lblLite.BackColor = Color.FromArgb(0, 71, 107)
                tvMain.BackColor = Color.FromArgb(0, 71, 107)
                frmSignUp.BackColor = Color.FromArgb(108, 189, 255)
                frmProductInfo.BackColor = Color.FromArgb(108, 189, 255)
                frmMyAccount.BackColor = Color.FromArgb(108, 189, 255)
                frmCart.BackColor = Color.FromArgb(108, 189, 255)
                frmAboutUs.BackColor = Color.FromArgb(108, 189, 255)
                frmCatBrowse.BackColor = Color.FromArgb(199, 234, 255)
                frmItems.BackColor = Color.FromArgb(199, 234, 255)
                frmItemsSearch.BackColor = Color.FromArgb(199, 234, 255)
                frmLogin.BackColor = Color.FromArgb(199, 234, 255)
                frmSubCat.BackColor = Color.FromArgb(199, 234, 255)
                frmBuy.BackColor = Color.FromArgb(199, 234, 255)
                frmForgotPass.BackColor = Color.FromArgb(199, 234, 255)
                frmNewPass.BackColor = Color.FromArgb(199, 234, 255)
                Me.lblsrno.BackColor = Color.FromArgb(0, 71, 107)
                frmMyAccount.lblsrno.BackColor = Color.FromArgb(0, 71, 107)
                picShoppingCart.Image = My.Resources.shopping_cart_logo1
            Case 2
                PictureBox1.BackColor = Color.FromArgb(3, 40, 0)
                rbAll.BackColor = Color.FromArgb(3, 40, 0)
                lblLite.BackColor = Color.FromArgb(3, 40, 0)
                tvMain.BackColor = Color.FromArgb(3, 40, 0)
                frmSignUp.BackColor = Color.FromArgb(247, 241, 139)
                frmProductInfo.BackColor = Color.FromArgb(247, 241, 139)
                frmMyAccount.BackColor = Color.FromArgb(247, 241, 139)
                frmCart.BackColor = Color.FromArgb(247, 241, 139)
                frmAboutUs.BackColor = Color.FromArgb(247, 241, 139)
                frmCatBrowse.BackColor = Color.FromArgb(171, 226, 145)
                frmItems.BackColor = Color.FromArgb(171, 226, 145)
                frmItemsSearch.BackColor = Color.FromArgb(171, 226, 145)
                frmLogin.BackColor = Color.FromArgb(171, 226, 145)
                frmSubCat.BackColor = Color.FromArgb(171, 226, 145)
                frmBuy.BackColor = Color.FromArgb(171, 226, 145)
                frmForgotPass.BackColor = Color.FromArgb(171, 226, 145)
                frmNewPass.BackColor = Color.FromArgb(3, 40, 0)
                Me.lblsrno.BackColor = Color.FromArgb(3, 40, 0)
                frmMyAccount.lblsrno.BackColor = Color.FromArgb(0, 71, 107)
                picShoppingCart.Image = My.Resources.shopping_cart_logo2
            Case 3
                PictureBox1.BackColor = Color.FromArgb(94, 76, 44)
                rbAll.BackColor = Color.FromArgb(94, 76, 44)
                lblLite.BackColor = Color.FromArgb(94, 76, 44)
                tvMain.BackColor = Color.FromArgb(94, 76, 44)
                frmSignUp.BackColor = Color.FromArgb(229, 208, 151)
                frmProductInfo.BackColor = Color.FromArgb(229, 208, 151)
                frmMyAccount.BackColor = Color.FromArgb(229, 208, 151)
                frmCart.BackColor = Color.FromArgb(229, 208, 151)
                frmAboutUs.BackColor = Color.FromArgb(229, 208, 151)
                frmCatBrowse.BackColor = Color.FromArgb(255, 245, 204)
                frmItems.BackColor = Color.FromArgb(255, 245, 204)
                frmItemsSearch.BackColor = Color.FromArgb(255, 245, 204)
                frmLogin.BackColor = Color.FromArgb(255, 245, 204)
                frmSubCat.BackColor = Color.FromArgb(255, 245, 204)
                frmBuy.BackColor = Color.FromArgb(255, 245, 204)
                frmForgotPass.BackColor = Color.FromArgb(255, 245, 204)
                frmNewPass.BackColor = Color.FromArgb(255, 245, 204)
                frmNewPass.BackColor = Color.FromArgb(94, 76, 44)
                Me.lblsrno.BackColor = Color.FromArgb(94, 76, 44)
                picShoppingCart.Image = My.Resources.shopping_cart_logo3

        End Select
        rbCat.BackColor = Me.PictureBox1.BackColor
        rbSubCat.BackColor = Me.PictureBox1.BackColor
        rbBrands.BackColor = Me.PictureBox1.BackColor
        lblMyAccount.BackColor = Me.PictureBox1.BackColor
        lblAboutUs.BackColor = Me.PictureBox1.BackColor
        lblTheme.BackColor = Me.PictureBox1.BackColor
        picShoppingCart.BackColor = Me.PictureBox1.BackColor
    End Sub

    Private Sub rbAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cbCriteria.Items.Clear()
        cbCriteria.Text = "All Categories"
        frmItems.Show()
    End Sub

    Private Sub lblLite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLite.Click
        If flag = True Then
            frmCatBrowse.Dispose()
            frmSubCat.Dispose()
            btnMainBrowse.Visible = True
            cmbTheme.Hide()
            lblTheme.Hide()
            stripCategory.Hide()
            lblLite.Text = "Graphic Theme"
            Timer1.Start()
            flag = False
        Else

            frmCatBrowse.Show()
            tvMain.Hide()
            btnMainBrowse.Visible = False
            cmbTheme.Visible = True
            lblTheme.Visible = True
            stripCategory.Visible = True
            lblLite.Text = "LITE Theme"
            flag = True
        End If
    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If change = True Then
            btnMainBrowse.ForeColor = Color.Crimson
            change = False
        Else
            btnMainBrowse.ForeColor = Color.Black
            change = True
        End If
    End Sub

    Private Sub tvMain_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tvMain.MouseWheel
        frmItems.Focus()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSelect.Click
        loginflag = False
        Me.Close()
        frmShopSelect.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class
