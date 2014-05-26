Imports System.Text
Public Class frmMaps

    Private Sub btnSearchMaps_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchMaps.Click
        Try
            Dim street As String = String.Empty
            Dim city As String = String.Empty
            Dim state As String = String.Empty
            Dim zip As String = String.Empty
            Dim lat As String = String.Empty
            Dim lon As String = String.Empty
            Dim queryaddress As New StringBuilder()

            queryaddress.Append("http://maps.google.com/maps?q=")

            'build street part query
            If txtStreet.Text <> String.Empty Then
                street = txtStreet.Text.Replace(" ", "+")
                queryaddress.Append(street + "," & "+")
            End If

            'build City part query
            If txtCity.Text <> String.Empty Then
                city = txtCity.Text.Replace(" ", "+")
                queryaddress.Append(city + "," & "+")
            End If

            'build State part query
            If txtState.Text <> String.Empty Then
                state = txtState.Text.Replace(" ", "+")
                queryaddress.Append(state + "," & "+")
            End If

            'build Zip part query
            If txtZipCode.Text <> String.Empty Then
                zip = txtZipCode.Text.Replace(" ", "+")
                queryaddress.Append(zip + "," & "+")
            End If

            WebBrowser1.Navigate(queryaddress.ToString())



            '  queryaddress.Append("http://maps.google.com/maps?q=")
            '  lat = txtlat.Text
            '  If lat <> String.Empty Then
            ' queryaddress.Append(lat + "%2C")
            ' End If
            '
            '            lon = txtlong.Text
            '            If lon <> String.Empty Then
            ' queryaddress.Append(lon)
            ' End If
            '
            '            WebBrowser1.Navigate(queryaddress.ToString())
            '
        Catch ex As Exception
            MsgBox("Error")
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        WebBrowser1.Navigate("https://maps.google.co.in/")
    End Sub

    Private Sub frmMaps_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtStreet_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStreet.TextChanged

    End Sub
End Class