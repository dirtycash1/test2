Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Net
Imports System.Text



Public Class MMB100P

    Dim strUserid As String = ""
    Dim po_no As String = ""
    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Me.Tag IsNot Nothing Then
                Dim pData() As String = Me.Tag

                If pData(1) IsNot Nothing Then
                    strUserid = pData(1)
                End If

                If pData(0) IsNot Nothing Then
                    po_no = pData(0)
                End If

                ' pData : 부모창에서 넘겨받은 파라미터변수, 기본자료셋팅

            End If

        Catch ex As Exception
            MessageInfo(ex)
        End Try

        'Me.open_Form()
    End Sub


    Public Sub open_Form()
        Dim url As String = "http://gw.interojo.com/ekp/user.do?cmd=goEappWrite&EMP_CODE=" & strUserid & "&LINK_CD=IFBUY02&APP_CODE=" & po_no & "&APP_KIND=1"

        'StartURL(url)

        'Dim StdURL As String = "http://gw.interojo.com/ekp/user.do?cmd=goEappWrite&EMP_CODE=" + strUserid + "&LINK_CD=MMB100&APP_CODE=" + po_no.Text + "&APP_KIND=1&HTML_URL"
        'Dim WC As WebClient = New WebClient()
        'Dim Buffer As String = ""
        'Dim uri As Uri = New Uri(url)
        'WC.Encoding = Encoding.UTF8
        'Dim str As String = WC.DownloadString(uri)

        'WC.Dispose()

        WebBrowser1.Navigate(New System.Uri(url), True)
    End Sub
End Class
