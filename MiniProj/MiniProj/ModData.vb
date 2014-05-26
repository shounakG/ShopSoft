Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Net

Module ModData
    Public dbConnection As New MySqlConnection, conProvider As String, conSource As String
    Public UserName As String, CurrBillNo As Integer = 1, ItemAdded As String, ItemQuantity As Integer
    Public OKtoAdd As Boolean = False
    Public tblBill As New DataTable, NewCat As String
    Public ElapsedSec As Integer, ElapsedMin As Integer, ElapsedHr As Integer
    Public IsNew As Boolean
    Public MyShopName As String = "Eternity Mall"
    Public dbConnection2 As New MySqlConnection
    Private connStr As String = "Server=syntaxsofts.com; User Id =syntaxso;Password=i<3ManUtd;Database="
    Public shopstring As String = ""
    Public serverString As String = "Server=syntaxsofts.com; User Id =syntaxso;Password=i<3ManUtd;Database=syntaxso_server"
    Public picString As String = "http://shopsoft.syntaxsofts.com/images/"
    Public prevID As Integer = 0

    Public Sub connect()
        Try
            dbConnection = New MySqlConnection
            dbConnection.ConnectionString = connStr + shopstring
            dbConnection.Open()
        Catch ex As Exception
            MsgBox("Unable to connect to the database" & vbCrLf & ex.Message, vbCritical)
            End
        End Try
    End Sub

    Public Sub connectShop()
        Try
            If dbConnection2.State = ConnectionState.Open Then dbConnection2.Close()
            dbConnection2.ConnectionString = serverString
            dbConnection2.Open()
        Catch ex As Exception
            MsgBox("Unable to connect to the Main Server" & vbCrLf & ex.Message, vbCritical)
            End
        End Try
    End Sub

    Public Sub AddtoBill()
        Dim dbAdapter As MySql.Data.MySqlClient.MySqlDataAdapter, dbTable As New DataTable, NewDataRow As DataRow
        If OKtoAdd = True And ItemQuantity <> 0 Then
            connect()
            dbAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("select ProdName,MRP,Rate from tblProductDetails where ProdName = '" & ItemAdded & "';", dbConnection)
            dbAdapter.Fill(dbTable)
            NewDataRow = dbTable.Rows(0)
            tblBill.ImportRow(NewDataRow)
            frmBillRegistered.dgridBillDetails.DataSource = tblBill
            frmBillRegistered.dgridBillDetails.Update()
            frmBillRegistered.dgridBillDetails.Visible = True
            dbConnection.Close()
        End If
    End Sub


    Public Function XOREncryption(ByVal CodeKey As String, ByVal DataIn As String) As String
        Dim lonDataPtr As Long
        Dim strDataOut As String
        Dim intXOrValue1 As Integer, intXOrValue2 As Integer


        For lonDataPtr = 1 To Len(DataIn)
            'The first value to be XOr-ed comes from
            '     the data to be encrypted
            intXOrValue1 = Asc(Mid$(DataIn, lonDataPtr, 1))
            'The second value comes from the code ke
            '     y
            intXOrValue2 = Asc(Mid$(CodeKey, ((lonDataPtr Mod Len(CodeKey)) + 1), 1))
            strDataOut = strDataOut + Chr(intXOrValue1 Xor intXOrValue2)
        Next lonDataPtr
        XOREncryption = strDataOut
    End Function

    Public Function getPicture(ByVal imgName As String) As Image
        Dim imgRet As Image

        Dim imgUri As Uri
        Uri.TryCreate(picString + imgName, UriKind.RelativeOrAbsolute, imgUri)
        imgRet = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(imgUri)))
        Return imgRet
    End Function

    Public Function getResponse(ByVal reqStr As String) As String

        Dim response As String
        Dim webstream As Stream
        Dim req As HttpWebRequest
        Dim res As HttpWebResponse

        req = WebRequest.Create(reqStr)
        req.Method = "GET"
        res = req.GetResponse()
        webstream = res.GetResponseStream()
        Dim webread As New StreamReader(webstream)
        While webread.Peek >= 0
            response = webread.ReadToEnd()
        End While

        Return response

    End Function
End Module
