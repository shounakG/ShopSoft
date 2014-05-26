Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Imports System.IO
Imports System.Net
Module Mod_Data

    Public subcat As String
    Public product As String
    Public dbConnection As New MySql.Data.MySqlClient.MySqlConnection, conProvider As String, conSource As String
    Public dbConnection2 As New MySql.Data.MySqlClient.MySqlConnection
    Public tot As Double
    Public tottemp As Double = 0
    Public srno As Integer = 0
    Public resetflag As Boolean = False
    Public loginflag As Boolean = False
    Public atcflag As Boolean = False
    Public CatName As String
    Public Afterlogin As Integer = 0
    Public cusname As String = String.Empty
    Public XCor As Integer = 0
    Public YCOR As Integer = 110
    Public SelectedShop As String '= "S:\ShopSoft\ShopSoft-2014-03-06\ShopSoft\ShopSoft - Databases\Shops\dbShop.mdb"
    Public serverstring As String = "Server=syntaxsofts.com;User Id=syntaxso;Password=i<3ManUtd;database="
    Public strCommand As String
    Public strServer As String
    Public SelectedShopAdd As String = "syntaxso_server"
    Public picstring As String = "http://shopsoft.syntaxsofts.com/images/"






    Public Function XOREncryption(ByVal CodeKey As String, ByVal DataIn As String) As String
        Dim lonDataPtr As Long
        Dim strDataOut As String = String.Empty
        Dim intXOrValue1 As Integer, intXOrValue2 As Integer

        For lonDataPtr = 1 To Len(DataIn)
            'The first value to be XOr-ed comes from
            'the data to be encrypted
            intXOrValue1 = Asc(Mid$(DataIn, lonDataPtr, 1))
            'The second value comes from the code ke
            'y
            intXOrValue2 = Asc(Mid$(CodeKey, ((lonDataPtr Mod Len(CodeKey)) + 1), 1))
            strDataOut = strDataOut + Chr(intXOrValue1 Xor intXOrValue2)
        Next lonDataPtr
        XOREncryption = strDataOut
    End Function

    Public Sub connect()
        Try
            dbConnection = New mysqlconnection
            dbConnection.ConnectionString = serverstring + SelectedShopAdd
            dbConnection.Open()
        Catch ex As Exception
            MsgBox(vbCrLf)
        End Try

    End Sub

    Public Sub connectshop()


        Try
            If dbConnection2.State = ConnectionState.Open Then dbConnection2.Close()
            dbConnection2.ConnectionString = serverstring & SelectedShopAdd
            dbConnection2.Open()

        Catch ex As Exception
            MsgBox(vbCrLf)
        End Try
    End Sub

    Public Function getPicture(ByVal imgName As String) As Image
        Dim imgRet As Image

        Dim imgUri As Uri
        Uri.TryCreate(picstring + imgName, UriKind.RelativeOrAbsolute, imgUri)

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
