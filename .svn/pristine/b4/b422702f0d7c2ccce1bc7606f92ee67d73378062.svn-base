Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Imports System.Xml
Imports System.Net
Imports System.IO
Imports System.Drawing
Imports System.Data

Class CurrencyReader
    Public Function Reading(ByVal Tbl As DataTable, ByVal CurryTbl As DataTable, ByVal FrCurry As String, Optional ByVal GetCurry As String = "") As DataRowCollection
        Try
            Dim StdURL As String = "http://community.fxkeb.com/fxportal/jsp/RS/DEPLOY_EXRATE/fxrate_all.html" '외환은행환율정보
            Dim WC As WebClient = New WebClient()
            Dim Buffer As String = WC.DownloadString(StdURL)
            WC.Dispose()
            Dim SR As StringReader = New StringReader(Buffer)
            Dim StdTime As String = "" '기준시간
            Dim CuryNm As String = "" '통화명
            Dim CashBuy As Double = 0 '현금살때
            Dim CashSell As Double = 0 '현금팔때
            Dim SendOut As Double = 0 '송금보낼때
            Dim SendIn As Double = 0 '송금받을때
            Dim CheckSell As Double = 0 '수표팔때
            Dim StdSales As Double = 0 '매매기준율
            Dim USD_Rt As Double = 0 '미화환산율
            Dim FindLine As Boolean = False, FindValCnt As Integer = 0, dRow As DataRow
            Dim dRows As DataRowCollection = CurryTbl.Rows, dRow2 As DataRow

            Tbl.BeginLoadData()    '일괄 Update처리를 하기 때문에 속도가 빠르다

            'curry_nm

            If Not (SR Is Nothing) Then
                Dim Val As String = "", Line As Integer = 0
                While True
                    Line += 1
                    Val = SR.ReadLine()
                    If Val Is Nothing Then Exit While

                    '기준시간가져오기
                    If Line = 39 Then
                        Val = Val.Substring(Val.IndexOf("[") + 1, Val.IndexOf("]") - Val.IndexOf("[") - 1)
                        Val = Val.Replace("&nbsp;", " ")
                        Val = Val.Replace("기준", "")
                        StdTime = Val
                    End If

                    If InStr(Val, "table_05") > 0 Then '통화정보가 있는 라인
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

                    If InStr(Val, "table_04") > 0 And FindLine Then '각종 값 정보가 있는 라인
                        FindValCnt += 1

                        Select Case FindValCnt
                            Case 1
                                CashBuy = GetValue(Val)
                            Case 2
                                CashSell = GetValue(Val)
                            Case 3
                                SendOut = GetValue(Val)
                            Case 4
                                SendIn = GetValue(Val)
                            Case 5
                                CheckSell = GetValue(Val)
                            Case 6
                                StdSales = GetValue(Val)
                            Case 7
                                USD_Rt = GetValue(Val)

                        End Select



                        If FindValCnt = 7 Then
                            FindValCnt = 0
                            If GetCurry <> "" Then FindLine = False
                            'select	a.std_dt, a.fr_cury_bc, a.ttm_rt, a.ttb_rt, a.tts_rt, 
                            'a.cashb_rt, a.cases_rt, a.usd_rt, a.ex_rt, a.ex2_rt, a.prev_avg, 
                            'a.curr_avg, a.prev_rt, a.rmks, a.cuid, a.cdt, a.muid, a.mdt, curry_nm = b.title

                            For Each dRow2 In dRows
                                If InStr(CuryNm, dRow2("sub_cd")) Then
                                    dRow = Tbl.NewRow()
                                    dRow("std_dt") = StdTime.Substring(0, 10)
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

    'HTML에서 선택 값을 추출한다.
    Private Function GetValue2(ByVal HtmlLine As String) As String
        Try
            Dim Val As String = ""
            If HtmlLine.IndexOf("</td>") = -1 Then
                Val = HtmlLine.Substring(HtmlLine.IndexOf(">") + 1, HtmlLine.Length - HtmlLine.IndexOf(">") - 1)
                Val = Val.Replace("&nbsp;", "")
            Else
                Val = HtmlLine.Substring(HtmlLine.IndexOf(">") + 1, HtmlLine.IndexOf("</td>") - HtmlLine.IndexOf(">") - 1)
            End If

            Return Val
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class

'Class CurrencyData
'    Public Curry As String
'    Public CurryNm As String
'    Public StdTime As String '기준시간
'    Public CashBuy As Double '현금살때
'    Public CashSell As Double '현금팔때
'    Public SendOut As Double '송금보낼때
'    Public SendIn As Double '송금받을때
'    Public CheckSell As Double '수표팔때
'    Public StdSales As Double '매매기준율
'    Public USD_Rt As Double '미화환산율

'    Public Sub New(ByVal GetCurry As String, ByVal GetCurryNm As String, ByVal GetStdTime As String, _
'                            ByVal GetCashBuy As Double, ByVal GetCashSell As Double, _
'                            ByVal GetSendOut As Double, ByVal GetSendIn As Double, _
'                            ByVal GetCheckSell As Double, ByVal GetStdSales As Double, ByVal GetUSD_Rt As Double)
'        Curry = GetCurry
'        CurryNm = GetCurryNm
'        StdTime = GetStdTime
'        CashBuy = GetCashBuy
'        CashSell = GetCashSell
'        SendOut = GetSendOut
'        SendIn = GetSendIn
'        CheckSell = GetCheckSell
'        StdSales = GetStdSales
'        USD_Rt = GetUSD_Rt
'    End Sub

'    Public Overrides Function ToString() As String
'        Return "통화 정보   : " & CurryNm & vbLf & "현금 살때   : " & CashBuy & vbLf & "현금 팔때   : " & CashSell & vbLf & "송금보낼때 : " & SendOut & vbLf & "송금받을때 : " & SendIn & _
'        vbLf & "수표 팔때   : " & CheckSell & vbLf & "매매기준율 : " & StdSales & vbLf & "미화환산율 : " & USD_Rt
'    End Function

'    Public Function TodRows() As DataRowCollection

'    End Function
'End Class
