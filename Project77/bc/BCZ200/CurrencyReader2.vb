Imports System.Collections.Generic
Imports System.Linq

Imports System.Drawing
Imports System.Data

Imports System
Imports System.Text
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports Microsoft.VisualBasic

Class CurrencyReader2
    Private Const skFirst = 1
    Private Const skLast = 2

    Private Shared Function ConnectSocket(server As String, port As Integer) As Socket
        Dim s As Socket = Nothing
        Dim hostEntry As IPHostEntry = Nothing

        ' Get host related information.
        hostEntry = Dns.GetHostEntry(server)

        ' Loop through the AddressList to obtain the supported AddressFamily. This is to avoid
        ' an exception that occurs when the host host IP Address is not compatible with the address family
        ' (typical in the IPv6 case).
        Dim address As IPAddress

        For Each address In hostEntry.AddressList
            Dim endPoint As New IPEndPoint(address, port)
            Dim tempSocket As New Socket(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp)

            tempSocket.Connect(endPoint)

            If tempSocket.Connected Then
                s = tempSocket
                Exit For
            End If

        Next address

        Return s
    End Function

    Private Shared Function SocketSendReceive(server As String, port As Integer, GeDt As String, _
                                              Optional ByVal FirstOrLast As Integer = 2) As String
        'Set up variables and String to write to the server.
        ' Create a socket connection with the specified server and port.
        Dim s As Socket = ConnectSocket(server, port)

        If s Is Nothing Then
            Return "Connection failed"
        End If

        Dim senddata As String
        Dim postdata As String
        Dim curDate As String = Format(Now, "yyyyMMdd")
        GeDt = GeDt.Replace("-", "")
        If GeDt = curDate Then

            '오늘최초
            If FirstOrLast = skFirst Then
                senddata = "/IBS/servlet/com.etc.NKIB"
                postdata = "o=%2Fb2c%2Fcspecial%2Fcsexchange%2Fcsex001r.jsp&sp=%2Fb2c%2Fcspecial%2Fcsexchange%2Fcsex001r.jsp&ActionNo=0970GGN090B&MG__UserID=GUEST&sGubun=2&sGubun1=2&MG_YGIROCNT=01&sVisable=true&YSTDATE=" + GeDt

                '오늘현재
            Else
                senddata = "/IBS/servlet/com.etc.FXSvl2"
                postdata = "sOutPage=%2Fb2c%2Fcspecial%2Fcsexchange%2Fcsex001r.jsp&cmd=PE060&sGubun=1&sGubun1=1&sVisable=true&YSTDATE=" + GeDt
            End If

        Else

            '과거최초
            If FirstOrLast = skFirst Then
                senddata = "/IBS/servlet/com.etc.NKIB"
                postdata = "o=%2Fb2c%2Fcspecial%2Fcsexchange%2Fcsex001r.jsp&sp=%2Fb2c%2Fcspecial%2Fcsexchange%2Fcsex001r.jsp&ActionNo=0970GGN090B&MG__UserID=GUEST&sGubun=3&sGubun1=3&MG_YGIROCNT=1&sVisable=true&MG_YBASEDT=" + GeDt + "&SelectValue=1"

                '과거최종
            Else
                senddata = "/IBS/servlet/com.etc.NKIB"
                postdata = "o=%2Fb2c%2Fcspecial%2Fcsexchange%2Fcsex001r.jsp&sp=%2Fb2c%2Fcspecial%2Fcsexchange%2Fcsex001r.jsp&ActionNo=0970GGN090B&MG__UserID=GUEST&sGubun=3&sGubun1=3&MG_YGIROCNT=0&sVisable=true&MG_YBASEDT=" + GeDt + "&SelectValue=0"
            End If
        End If

        senddata = "POST " & senddata & " HTTP/1.1" & vbCrLf
        senddata = senddata & "Accept-Language: ko" & vbCrLf
        senddata = senddata & "Content-Type: application/x-www-form-urlencoded" & vbCrLf
        senddata = senddata & "User-Agent: Mozilla/4.0 (compatible; MSIE 4.01; Windows 95" & vbCrLf
        senddata = senddata & "Host: ebank.keb.co.kr" & vbCrLf
        senddata = senddata & "Content-Length: " & CStr(Len(postdata)) & vbCrLf
        senddata = senddata & "Connection: Close" & vbCrLf & vbCrLf

        senddata = senddata & postdata

        Dim ascii As Encoding = Encoding.ASCII
        'Dim request As String = "GET / HTTP/1.1" + ControlChars.Cr + ControlChars.Lf + "Host: " + server + ControlChars.Cr + ControlChars.Lf + "Connection: Close" + ControlChars.Cr + ControlChars.Lf + ControlChars.Cr + ControlChars.Lf
        Dim bytesSent As [Byte]() = ascii.GetBytes(senddata)
        Dim bytesReceived(255) As [Byte]

        ' Send request to the server.
        s.Send(bytesSent, bytesSent.Length, 0)

        ' Receive the server  home page content.
        Dim bytes As Int32

        ' Read the first 256 bytes.
        'Dim page As [String] = "Default HTML page on " + server + ":" + ControlChars.Cr + ControlChars.Lf
        Dim page As String = ""

        ' The following will block until the page is transmitted.
        Do
            bytes = s.Receive(bytesReceived, bytesReceived.Length, 0)
            page = page + Encoding.Default.GetString(bytesReceived, 0, bytes)
        Loop While bytes > 0

        ''###########################################
        ''가져온 Html을 Debug하기위해
        ''    Dim intFileNum As Integer
        ''    intFileNum = FreeFile()
        ''
        ''    Open "C:\GetRate.Htm" For Output As #intFileNum
        ''    Print #intFileNum, ReceiveData
        ''    Close #intFileNum
        ''###########################################

        'If InStr(page, "지금은 서비스 이용가능시간이 아닙니다.") <> 0 Then
        '    'mReceiveState = 2
        'ElseIf InStr(page, "USD") = 0 And InStr(page, "미국") = 0 Then
        '    'mReceiveState = 1
        'Else
        '    'mReceiveState = 0
        'End If

        'Dim intStrData As Integer

        ''머리글 삭제
        'intStrData = InStr(1, page, "fx_tableATitle", vbBinaryCompare)
        'page = Mid(page, intStrData, Len(page))

        ''꼬리글 삭제
        ''intStrData = InStr(1, ReceiveData, "JavaScript:goExcelOpen", vbBinaryCompare)
        'intStrData = InStr(1, page, "</table>", vbBinaryCompare)

        'page = Mid(page, 1, intStrData)

        ''###########################################
        ''바레인과 중화민국의 이상한 데이타 교정
        ''MsgBox "cl" + vbLf + "2000" + vbLf + "ass"
        ''MsgBox "0" + vbLf + "2000" + vbLf + ".00</td>"
        'page = Replace(page, Chr(13) + Chr(10) + "2000" + Chr(13) + Chr(10), "")
        'page = Replace(page, "cl" + Chr(13) + Chr(10) + "2000" + Chr(13) + Chr(10) + "ass", "class")
        'page = Replace(page, "c" + Chr(13) + Chr(10) + "2000" + Chr(13) + Chr(10) + "lass", "class")
        'page = Replace(page, "0" + Chr(13) + Chr(10) + "2000" + Chr(13) + Chr(10) + ".00</td>", "0.00</td>")
        'page = Replace(page, Chr(13) + Chr(10) + "2000" + Chr(13) + Chr(10) + "0.00</td>", "0.00</td>")
        ''###########################################

        Return page
    End Function

    Public Function Reading2(ByVal Tbl As DataTable, ByVal CurryTbl As DataTable, _
                             GetDt As String, ByVal FrCurry As String, _
                             Optional ByVal GetCurry As String = "", _
                             Optional ByVal FirstOrLast As Integer = 2) As DataRowCollection
        Try
            Dim StdURL As String = "ebank.keb.co.kr" '외환은행환율정보
            Dim Buffer As String = SocketSendReceive(StdURL, 80, GetDt, FirstOrLast)
            Dim SR As StringReader = New StringReader(Buffer)
            Dim StdTime As String = "" '기준시간
            Dim CuryNm As String = "" '통화명
            Dim CashBuy As Double = 0 '현금살때
            Dim CashSell As Double = 0 '현금팔때
            Dim SendOut As Double = 0 '송금보낼때
            Dim SendIn As Double = 0 '송금받을때
            Dim CheckBuy As Double = 0 'T/C(외화수표)살때
            Dim CheckSell As Double = 0 '수표팔때
            Dim StdSales As Double = 0 '매매기준율
            Dim Exch_Rt As Double = 0 '환가요율
            Dim USD_Rt As Double = 0 '미화환산율

            Dim FindLine As Boolean = False, FindValCnt As Integer = 0, dRow As DataRow
            Dim dRows As DataRowCollection = CurryTbl.Rows, dRow2 As DataRow
            StdTime = "기준일 : " & GetDt


            Dim CuryNm_old As String = ""


            Tbl.BeginLoadData()    '일괄 Update처리를 하기 때문에 속도가 빠르다

            'curry_nm

            If Not (SR Is Nothing) Then
                Dim Val As String = "", Line As Integer = 0
                While True
                    Line += 1
                    Val = SR.ReadLine()
                    If Val Is Nothing Then Exit While

                    'If InStr(Val, "기준일") > 0 Then
                    '    MessageBox.Show(Line)
                    'End If

                    '기준일자 가져오기
                    'If Line = 272 Then
                    '    Val = Val.Substring(Val.IndexOf("[") + 1, Val.IndexOf("]") - Val.IndexOf("[") - 1)
                    '    Val = Val.Replace("&nbsp;", " ")
                    '    Val = Val.Replace("기준", "")
                    '    StdTime = Val
                    'End If
                    '고시회차 가져오기
                    If Line = 279 Then
                        StdTime &= "   " & GetValue2(Val.Replace("</span></td>", ""))
                    End If

                    If InStr(Val, "fx_tableATitle04") > 0 Then '통화정보가 있는 라인
                        If GetCurry = "" Then
                            FindLine = True
                            CuryNm = GetValue2(Val)
                        Else
                            If InStr(Val, GetCurry) > 0 Then
                                FindLine = True
                                CuryNm = GetValue2(Val)
                            End If
                        End If
                    End If

                    'FindValCnt 값초기화
                    If CuryNm_old <> "" Then
                        If CuryNm_old <> CuryNm Then
                            FindValCnt = 0
                        End If
                    End If
                    CuryNm_old = CuryNm


                    If InStr(Val, "fx_tableAText04R") > 0 And FindLine Then '각종 값 정보가 있는 라인
                        FindValCnt += 1

                        Select Case FindValCnt
                            Case 1 '현금살때
                                CashBuy = GetValue(Val)
                            Case 2 '현금팔때
                                CashSell = GetValue(Val)
                            Case 3 '송금보낼때
                                SendOut = GetValue(Val)
                            Case 4 '송금받을때
                                SendIn = GetValue(Val)
                            Case 5 'T/C(외화수표)살때
                                CheckBuy = GetValue(Val)
                            Case 6 '외화수표팔때
                                CheckSell = GetValue(Val)
                            Case 7 '매매기준율
                                StdSales = GetValue(Val)
                            Case 8 '환가요율
                                Exch_Rt = GetValue(Val)
                            Case 9 '대미환산율
                                USD_Rt = GetValue(Val)
                        End Select



                        If FindValCnt = 9 Then
                            FindValCnt = 0
                            If GetCurry <> "" Then FindLine = False
                            'select	a.std_dt, a.fr_cury_bc, a.ttm_rt, a.ttb_rt, a.tts_rt, 
                            'a.cashb_rt, a.cases_rt, a.usd_rt, a.ex_rt, a.ex2_rt, a.prev_avg, 
                            'a.curr_avg, a.prev_rt, a.rmks, a.cuid, a.cdt, a.muid, a.mdt, curry_nm = b.title

                            For Each dRow2 In dRows
                                If InStr(CuryNm, dRow2("sub_cd")) Then
                                    dRow = Tbl.NewRow()
                                    dRow("std_dt") = GetDt
                                    dRow("fr_cury_bc") = FrCurry
                                    dRow("to_cury_bc") = dRow2("base_cd")
                                    dRow("ttm_rt") = StdSales '매매기준환율
                                    dRow("ttb_rt") = SendIn '전신매입
                                    dRow("tts_rt") = SendOut '전신매도
                                    dRow("cashb_rt") = CashBuy '현금살때
                                    dRow("cases_rt") = CashSell '현금팔때
                                    dRow("usd_rt") = USD_Rt '대미환산율
                                    Tbl.Rows.Add(dRow)
                                    Exit For
                                End If
                            Next
                        End If
                    End If

                End While
            End If

            SR.Close()
            Return Tbl.Rows

            'Return New CurrencyData(GetCurry, CuryNm, StdTime, CashBuy, CashSell, SendOut, SendIn, CheckSell, StdSales, USD_Rt)

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    'HTML에서 선택 값을 추출한다.
    Private Function GetValue(ByVal HtmlLine As String) As Double
        Try
            Dim Val As Double = HtmlLine.Substring(HtmlLine.IndexOf(">") + 1, HtmlLine.IndexOf("</td>") - HtmlLine.IndexOf(">") - 1)
            Return Val
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    'HTML에서 선택 값(통화)을 추출한다.
    Private Function GetValue2(ByVal HtmlLine As String) As String
        Try
            '"    <td class="fx_tableATitle04"><a href="javascript:beforeDatLate('001')">미국 USD</a></td>"
            Dim Val As String = ""
            HtmlLine = HtmlLine.Replace("</a></td>", "")
            Dim Tmp As String() = HtmlLine.Split(">")
            Val = Tmp(Tmp.Length - 1)
            'If HtmlLine.IndexOf("</td>") = -1 Then
            '    Val = HtmlLine.Substring(HtmlLine.IndexOf(">") + 1, HtmlLine.Length - HtmlLine.IndexOf(">") - 1)
            '    Val = Val.Replace("&nbsp;", "")
            'Else
            '    Val = HtmlLine.Substring(HtmlLine.IndexOf(">") + 1, HtmlLine.IndexOf("</td>") - HtmlLine.IndexOf(">") - 1)
            'End If

            Return Val
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
