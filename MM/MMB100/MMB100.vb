Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data
Imports System.Net
Imports System.IO
Imports System.Xml.Serialization
Imports System7.Reports
Imports System7.ReportView
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports System.Runtime.CompilerServices
Imports System.Text


Public Class MMB100
    Private Sub MMB100_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '구매발주번호 자동채번 설정
        po_no.CodeNo = "MMB100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        po_no.CodeDateField = po_dt

        Me.New_Form()

        SplitContainer2.Panel2Collapsed = True

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open_Form()

            Case MenuType.Save
                If MyBase.Save() Then
                    Me.Open_Form()
                End If

            Case MenuType.Delete
                'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

            Case MenuType.New
                Me.New_Form()
                go_gw.Enabled = True
                sh_gw.Enabled = True
                'Me.WorkSets("mmb100_g10").AddNew()  '특정Workset 신규처리

            Case MenuType.Print
                Me.Print()

                'Case MenuType.Find  'smk 160613
                '    Me.Find()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub


    Public Sub Open_Form()
        union_yn.Text = "0"
        Me.Open()

        'g10.AddNewRow()
    End Sub

    Public Sub Open2(ByVal poNo As String)
        po_no.Text = poNo
        Me.Open_Form()

        If po_bc.Text = "MM100500" Then
            go_gw.Enabled = False
            sh_gw.Enabled = False
        Else
            go_gw.Enabled = True
            sh_gw.Enabled = True
        End If

    End Sub

    Public Sub New_Form()
        po_no.Text = ""
        Me.Open_Form()

        'g10.AddNewRow()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        union_yn.Text = "1"
        g10.Open()

        'Dim p As New OpenParameters

        'p.Add("@po_no", po_no.Text)
        'p.Add("@po_fac", po_fac.Text)
        'p.Add("@po_dt", po_dt.Text)
        'p.Add("@cury_bc", cury_bc.Text)
        'p.Add("@po_cust", cust_cd.Text)

        'Me.Open("mmb100_itm", p)
        ''Me.OpenDataSet("mmb100_itm", p)
        ''g10.AddNewRow()
        ''MyBase.Open("mmb100_itm", p)
    End Sub


    Private Sub btn_price_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_price.Click
        Dim p As New OpenParameters
        Dim R As Integer

        g10.UpdateRow()

        For R = 0 To g10.RowCount - 1
            p.Add("@itm_id", g10.Text("itm_id", R))
            p.Add("@cust_cd", cust_cd.Text)
            'p.Add("@cury_bc", cury_bc.Text)
            p.Add("@po_fac", po_fac.Text)
            p.Add("@po_dt", po_dt.Text)
            Dim Dset As DataSet = OpenDataSet("mmb100_cost", p)

            If Not IsEmpty(Dset) Then
                g10.RowIndex = R
                g10.Text("po_up") = DataValue(Dset, "up")

                Dset = Nothing

            End If

        Next

        'Me.OpenDataSet("mmb100_itm", p)
        'g10.AddNewRow()
        'MyBase.Open("mmb100_itm", p)
    End Sub

    Private Sub g10_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object)

        If ColumnName = "po_qty" Then
            If Value > "0" And g10.ToDec("po_sq") = 0 Then
                Set_maxSq()
            ElseIf Value = "0" Then
                g10.Text("po_sq") = ""
            End If

        End If

        '수량변경 -> 자동 순번증가
        ' If ColumnName = "so_qty" Then
        'If g10.ToDec("so_qty") = 0 Then
        ' g10.Text("so_sq") = ""
        ' Else
        ' If g10.Text("so_sq") = "" Then
        ' g10.Text("so_sq") = GetSeqNo(sdb100_g10, "so_sq")

        ' End If
        ' End If
        ' End If
    End Sub
    Public Sub Set_maxSq()

        Dim iRow As Integer, maxNo As Double

        For iRow = 0 To g10.RowCount - 1
            If maxNo < g10.ToDec("po_sq", iRow) Then
                maxNo = g10.ToDec("po_sq", iRow)
            End If
        Next
        g10.Text("po_sq") = maxNo + 1
    End Sub


    Public Sub Open3(ByVal dSet As DataSet)
        Me.New_Form()
        g10.DeleteBlankRow()

        Dim i As Integer = 0
        For Each dRow As DataRow In dSet.Tables(0).Rows
            If ToStr(dRow("chk")) Then


                If i = 0 Then
                    cust_cd.Text = ToStr(dRow("cust_cd"))
                End If

                g10.AddNewRow()
                g10.Text("req_no", i) = ToStr(dRow("req_no"))
                g10.Text("req_sq", i) = ToStr(dRow("req_sq"))
                'g10.Text("itm_id", i) = ToStr(dRow("itm_id"))
                g10.Text("itm_cd", i) = ToStr(dRow("itm_cd"))
                'g10.Text("itm_nm", i) = ToStr(dRow("itm_nm"))
                'g10.Text("itm_bc", i) = ToStr(dRow("itm_bc"))
                'g10.Text("spec", i) = ToStr(dRow("spec"))
                'g10.Text("model_cd", i) = ToStr(dRow("model_cd"))
                'g10.Text("spec1", i) = ToStr(dRow("spec1"))
                g10.Text("dept_cd", i) = ToStr(dRow("fr_dept"))
                g10.Text("rmks", i) = ToStr(dRow("rmks"))
                g10.Text("dlv_um", i) = ToStr(dRow("um_bc"))
                g10.Text("use_bc", i) = ToStr(dRow("use_bc"))
                'g10.Text("cury_bc", i) = ToStr(dRow("cury_bc"))
                g10.Text("po_qty", i) = ToStr(dRow("qty"))
                g10.Text("dlv_dt", i) = ToStr(dRow("dlv_dt"))   '20160711 smk 변경
                'g10.Text("out_up", i) = ToStr(dRow("so_sq"))
                'g10.Text("out_amt", i) = Outtot * Soup

                i += 1
            End If


        Next

    End Sub

    'Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object)

    '    If ColumnName = "po_qty" Or ColumnName = "cust_cd" Then

    '        Dim r As DataSet = Me.OpenDataSet("mmb100_up")
    '        Dim up As String = DataValue(r)

    '        g10.Text("po_up") = up

    '    ElseIf ColumnName = "echeck" Then  'smk 160613 
    '        MsgBox("1")
    '        Dim i As Integer
    '        For i = 0 To g10.RowCount - 1

    '            If g10.Text("echeck", i) = "1" Then
    '                MsgBox("1")
    '                MenuButton_Click(MenuType.Find)
    '            Else
    '            End If

    '        Next

    '    End If

    'End Sub




    Private Sub g10_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        If ColumnName = "po_qty" Or ColumnName = "cust_cd" Then

            Dim r As DataSet = Me.OpenDataSet("mmb100_up")
            Dim up As String = DataValue(r)

            g10.Text("po_up") = up

            'ElseIf ColumnName = "echeck" Then
            '    Panel2_collapsed(RowIndex)
            '    g20_open(RowIndex)
        End If
    End Sub

    '20160613 smk 단가선택 기능
    Private m_StopEvent As Boolean

    Private Sub g10_CellValueChanging1(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging
        Dim cc As String
        Dim row_i As Integer

        If m_StopEvent Then
            Return
        End If

        m_StopEvent = True

        Try
            If ColumnName = "echeck" Then
                If Value = "1" Then
                    cc = "1"
                    g10.Text("echeck") = cc
                    row_i = RowIndex
                Else
                    cc = "0"
                    g10.Text("echeck") = cc
                End If
                Panel2_collapsed(RowIndex, cc)
                g20_open(RowIndex)

            End If

        Catch ex As Exception
        Finally
            m_StopEvent = False
        End Try

    End Sub

    Private Sub Panel2_collapsed(RowIndex As Integer, cc As String)   'smk 160613
        If cc = "1" Then
            SplitContainer2.Panel2Collapsed = False '나타내기 
        Else
            SplitContainer2.Panel2Collapsed = True  '숨기기 
        End If

    End Sub

    Public Sub g20_open(RowIndex As Integer)
        Dim p20 As OpenParameters = New OpenParameters

        p20.Clear()
        p20.Add("@itm_cd", g10.Text("itm_cd", RowIndex))
        p20.Add("@cust_cd", cust_cd.Text)

        Me.Open("mmb100_g20", p20)
    End Sub


    Private Sub g20_ButtonPressed(sender As System.Object, columnName As System.String) Handles g20.ButtonPressed
        If columnName = "up_save" Then
            g10.Text("po_up") = g20.Text("up")
        End If

    End Sub

    '20160613 smk 단가선택 기능 END 

 


    '선언부에
    Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" _
       (ByVal hWnd As Long, ByVal lpOperation As String, ByVal lpFile As String, _
        ByVal lpParameters As String, ByVal lpDirectory As String, _
        ByVal nShowCmd As Long) As Long
    Private Declare Function GetDesktopWindow Lib "user32" () As Long
    Const SW_SHOWNORMAL = 1

    '폼 소스안에
    Public Function StartURL(URL As String) As Long
        Dim Scr_hDC As Long
        '바탕화면의 핸들을 구함.
        Scr_hDC = GetDesktopWindow()
        '쉘명령을 이용하여 기본 브라우저를 실행함.
        'StartURL = ShellExecute(Nothing, "open", URL, Nothing, Nothing, SW_SHOWNORMAL)
        StartURL = ShellExecute(Scr_hDC, "open", "iexplore", URL, Nothing, SW_SHOWNORMAL)
    End Function

    Private Sub go_gw_Click(sender As System.Object, e As System.EventArgs) Handles go_gw.Click
        If g10.Text("result_status", 0) = "기안" Then
            MessageInfo("이미 결재 진행중인 문서입니다.")
            Exit Sub
        ElseIf g10.Text("result_status", 0) = "승인" Then
            MessageInfo("결재 완료된 문서입니다.")
            Exit Sub
        ElseIf g10.Text("result_status", 0) = "반려" Then
            MessageInfo("반려된 문서입니다. 새로 작성해 주세요.")
            Exit Sub
        End If

        Me.make_html()
        Dim strUserid As String = ""

        strUserid = Parameter.Login.EmpNo
        strUserid = po_emp.Text
        If strUserid = "" Then
            strUserid = "admin"
        End If

        Dim Popup As New MMB100P

        Dim StdURL As String = "http://gw.interojo.com/ekp/user.do?cmd=goEappWrite&EMP_CODE=" + strUserid + "&LINK_ID=IFBUY02&APP_CODE=" + po_no.Text + "&APP_KIND=1"

        Popup.WebBrowser1.Navigate(New System.Uri(StdURL), True)
    End Sub

    'html 문서를 만들어서 DB에 저장한다.
    Private Sub make_html()

        Dim p As OpenParameters = New OpenParameters
        p.Add("@po_no", po_no.Text)
        p.Add("@cust_cd", cust_cd.Text)
        p.Add("@po_fac", po_fac.Text)
        p.Add("@in_fac", in_fac.Text)
        p.Add("@in_wh", in_wh.Text)

        Dim formCd As String = ""
        Dim document As ReportDocument = Nothing
        Dim dSet As DataSet = Link.ReadDataSet("mmb100_Print", p)
        Dim dRow As DataRow

        Dim header As String = ""
        Dim body As String = ""
        Dim footer As String = ""

        Dim tot_amt As Integer = 0
        Dim tot_amt2 As String = 0
        header = "" &
        "<HTML>" &
"<TITLE></TITLE>" &
"<BODY BGCOLOR='FFFFFF' LEFTMARGIN=31 TOPMARGIN=31>" &
"<table width='100%' height='' border='0'>" &
    "<tr>" &
        "<td width='35%' height = '18' align = 'left'>&nbsp;&nbsp;&nbsp;발 주 일 자 : " & po_dt.Text & "</td>" &
        "<td width='20%' height = '18'>&nbsp;</td>" &
        "<td width='20%' height = '18' align = 'left'>발 주 번 호 :</td>" &
        "<td width='25%' height = '18' align = 'left'>&nbsp;&nbsp;&nbsp;" & po_no.Text & "</td>" &
    "</tr>" &
    "<tr>" &
        "<td height = '18' align = 'left'>&nbsp;&nbsp;&nbsp;구 매 담 당 : " & po_nm.Text & "</td>" &
        "<td height = '18'>&nbsp;</td>" &
        "<td height = '18' align = 'left'>관 리 번 호 :</td>" &
        "<td height = '18'>&nbsp;</td>" &
    "</tr>" &
    "<tr>" &
        "<td height='160'><p align='right'>" & cust_nm.Text & " &nbsp;&nbsp;&nbsp;귀하&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>" &
            "<p>다음과 같이 발주합니다.</p>" &
            "<br />" &
            "<p align = 'left'>&nbsp;&nbsp;&nbsp;결제방법 :   " & pset_bc.EditText & "</p>" &
            "<br />" &
            "<p align = 'left'>&nbsp;&nbsp;&nbsp;TEL&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " & tel.Text & "</p>" &
            "<br />" &
            "<p align = 'left'>&nbsp;&nbsp;&nbsp;FAX&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " & fax.Text & "</p></td>" &
        "<td colspan='3' align='center'><table width='100%' height='100%' border='1'>" &
            "<tr>" &
                "<td width='8%' rowspan='4' align='center'><p>발</p>" &
                "<br />" &
                    "<p>주</p>" &
                 "<br />" &
                    "<p>자</p></td>" &
                "<td width='12%' height='20'>상&nbsp;&nbsp;호</td>" &
                "<td colspan='3'>" & bs_nm.Text & "</td>" &
            "</tr>" &
            "<tr>" &
                "<td height='20'>주&nbsp;&nbsp;소</td>" &
                "<td colspan='3'>" & addr.Text & "</td>" &
            "</tr>" &
            "<tr>" &
                "<td height='20'>대표자</td>" &
                "<td colspan='3'>" & ceo_nm.Text & "</td>" &
            "</tr>" &
            "<tr>" &
                "<td height='20'>전&nbsp;&nbsp;화</td>" &
                "<td width='30%'>" & bs_tel.Text & "</td>" &
                "<td width='12%'>F A X</td>" &
                "<td width=''>" & bs_fax.Text & "</td>" &
            "</tr>" &
            "</table></td>" &
    "</tr>" &
"</table>" &
"<p>&nbsp;</p>" &
"<table width='100%' border='1'>" &
"  <tr>" &
"    <td width='4%' align='center' height = '18'>NO</td>" &
"    <td width='10%' align='center' height = '18'>품목코드</td>" &
"    <td width='13%' align='center' height = '18'>품명</td>" &
"    <td width='13%' align='center' height = '18'>규격</td>" &
"    <td width='8%' align='center' height = '18'>현재고</td>" &
"    <td width='9%' align='center' height = '18'>발주수량</td>" &
"    <td width='5%' align='center' height = '18'>단위</td>" &
"    <td width='9%' align='center' height = '18'>발주단가</td>" &
"    <td width='15%' align='center' height = '18'>발주금액</td>" &
"    <td width='14%' align='center' height = '18'>용도구분</td>" &
"  </tr>"
        For i = 0 To dSet.Tables(0).Rows.Count - 1
            dRow = dSet.Tables(0).Rows(i)
            body = body &
      "<tr>" &
    "      <td align='center' height = '18'>" & dRow("po_sq") & "</td>" &
    "      <td align='center' height = '18'>" & dRow("itm_cd") & "</td>" &
    "      <td height = '18' align = 'left'>&nbsp;&nbsp;&nbsp;" & dRow("itm_nm") & "</td>" &
    "      <td height = '18' align = 'left'>&nbsp;&nbsp;&nbsp;" & dRow("spec") & "</td>" &
    "      <td height = '18' align = 'right'>" & dRow("stock_qty") & "&nbsp;&nbsp;</td>" &
    "      <td align='center' height = '18'>" & dRow("po_qty") & "</td>" &
    "      <td height = '18' align = 'right'>" & dRow("title") & "&nbsp;&nbsp;</td>" &
    "      <td height = '18' align = 'right'>" & dRow("po_up") & "&nbsp;&nbsp;</td>" &
    "      <td align='center' height = '18'>" & dRow("po_amt1") & "</td>" &
    "      <td align='center' height = '18'>" & dRow("use_nm") & "</td>" &
    "  </tr>"
            If dRow("rmks") Is DBNull.Value Then

            Else
                body = String.Format("{0}  <tr>      <td colspan='10' align='left' height = '20'>          <p>용도(상세) :           &nbsp;{1}&nbsp; / &nbsp; 예정일 :&nbsp;{2} </p>          </td>  </tr>", body, dRow("rmks"), dRow("dlv_dt"))
            End If
            tot_amt = tot_amt + CDec(dRow("po_amt1"))
        Next
        If (dSet.Tables(0).Rows.Count - 1) < 0 Then Exit Sub
        dRow = dSet.Tables(0).Rows(dSet.Tables(0).Rows.Count - 1)

        tot_amt2 = String.Format("{0:#,0,###}", tot_amt)
        footer = "" &
"  <tr>" &
"      <td colspan='10' align='right' height = '18'>" &
"          <p>총 금액 : " & dRow("cury_nm") & "&nbsp;&nbsp;" & tot_amt2 & "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>" &
"          </td>" &
"  </tr>" &
"  <tr>" &
"      <td colspan='10' align='left' height = '40'>" &
"          <p>비고(Remark) : </p>" &
"          <p>&nbsp;" & dRow("rmks") & "</p>" &
"          </td>" &
"  </tr>" &
"</table>" &
"</BODY>" &
"</HTML>"
        'If po_emp.Text = "" Then Exit Sub

        Dim p2 As OpenParameters = New OpenParameters
        p2.Add("@app_code", po_no.Text)
        p2.Add("@emp_code", po_emp.Text)
        p2.Add("@form_id", "")

        Dim dSet2 As DataSet
        dSet2 = Me.OpenDataSet("mmb100_html", p2)
        'If dSet2 Is Nothing Then
        '    Exit Sub
        'End If

        Dim dRow1 As DataRow
        'If g10.IsDataRow(i) Then        'Data Row 만 작업한다 합계Row등은 제외
        dRow1 = dSet2.Tables(0).NewRow
        dRow1("emp_code") = po_emp.Text
        dRow1("form_id") = ""
        dRow1("app_code") = po_no.Text
        dRow1("seq") = dSet2.Tables(0).Rows.Count
        dRow1("result_status") = "C"
        dRow1("app_kind") = "1"
        dRow1("form_html") = header & body & footer
        dSet2.Tables(0).Rows.Add(dRow1)
        'End If


        Me.Save("mmb100_html")
    End Sub

#Region "HTML FILE 저장(크리스탈레포트)"

    Private Sub make_file()
        Dim body As New ReportDocument

        Dim p As OpenParameters = New OpenParameters
        p.Add("@po_no", po_no.Text)
        p.Add("@cust_cd", cust_cd.Text)
        p.Add("@po_fac", po_fac.Text)
        p.Add("@in_fac", in_fac.Text)
        p.Add("@in_wh", in_wh.Text)

        Dim formCd As String = ""
        Dim document As ReportDocument = Nothing
        Dim dSet As DataSet = Link.ReadDataSet("mmb100_Print", p)

        If (document Is Nothing) Then
            formCd = MMB100._GetFileName("MMB100F")
            If (formCd = "") Then
                Exit Sub
            End If
            Dim expression As ReportDocument = DirectCast(MMB100._LoadAssembly(formCd, "System7"), ReportDocument)
            If Information.IsNothing(expression) Then
                MessageInfo((formCd & ".dll Instance " & ChrW(47484) & " " & ChrW(49373) & ChrW(49457) & ChrW(54624) & " " & ChrW(49688) & " " & ChrW(50630) & ChrW(49845) & ChrW(45768) & ChrW(45796) & "."), Nothing, Nothing)
                Exit Sub
            End If
            document = expression
        End If

        If IsEmpty(dSet) Then
            MessageInfo(ChrW(52636) & ChrW(47141) & ChrW(54624) & " " & ChrW(51088) & ChrW(47308) & ChrW(44032) & " " & ChrW(50630) & ChrW(49845) & ChrW(45768) & ChrW(45796), Nothing, Nothing)
            Exit Sub
        End If
        document.SetDataSource(dSet.Tables.Item(0))

        'Dim crReportDocument As New ReportDocument()
        '' 다음 코드 행은 
        '' 예제 보고서 'Chart.rpt'를 로드합니다.
        'crReportDocument.Load("C:\Program Files\Microsoft Visual Studio .NET 2003\Crystal Reports\Samples\Reports\Feature Examples\Chart.rpt")

        Dim CrExportOptions As ExportOptions
        Dim CrDiskFileDestinationOptions As New  _
        DiskFileDestinationOptions()
        Dim CrFormatTypeOptions As New HTMLFormatOptions()

        CrDiskFileDestinationOptions.DiskFileName = _
                                    "ftp://14.34.136.155/erp/" & po_no.Text & "aa.html"
        CrExportOptions = document.ExportOptions
        With CrExportOptions
            .ExportDestinationType = ExportDestinationType.DiskFile
            .ExportFormatType = ExportFormatType.HTML40
            .DestinationOptions = CrDiskFileDestinationOptions
            .FormatOptions = CrFormatTypeOptions
        End With
        document.Export()

        'document.Dispose()

        'FtpWebRequest.Create("ftp://14.34.136.155/erp/")

        ' 디스크에서 내보낸 파일을 삭제합니다.
        System.IO.File.Delete("ftp://14.34.136.155/erp/" & po_no.Text & "aa.html")

        document.Close()
        'document = Nothing

        'File.Delete("c:\" & po_no.Text & ".html")
    End Sub


    Private Shared Function _GetFileName(ByVal reportCode As String) As String
        Dim str As String
        Dim str2 As String = ""
        Try
            Dim openParams As New OpenParameters
            openParams.Add("@rpt_cd", reportCode, QueryParameterType.Text, QueryParameterKind.Parameter)
            Dim dtSet As DataSet = Link.ReadDataSet("common_get_report_file", openParams)
            If Not IsEmpty(dtSet) Then
                str2 = DataValue(dtSet, "file_nm", 0, False)
            End If
            If (str2 = "") Then
                MessageInfo("Report " & ChrW(51221) & ChrW(48372) & ChrW(44032) & " " & ChrW(46321) & ChrW(47197) & ChrW(46104) & ChrW(50612) & " " & ChrW(51080) & ChrW(51648) & " " & ChrW(50506) & ChrW(49845) & ChrW(45768) & ChrW(45796) & ".", Nothing, Nothing)
                Return ""
            End If
            str = str2
        Catch exception1 As Exception
            Dim excp As Exception = exception1
            MessageError(excp, Nothing, "Main.Report.GetReportFile()")
            str = ""
            Return str
        End Try
        Return str
    End Function

    Private Shared Function _LoadAssembly(ByVal formCd As String, Optional ByVal rootNameSpace As String = "MMB100") As Object
        Dim obj2 As Object
        Dim assembly As Reflection.Assembly
        Try
            [assembly] = Reflection.Assembly.Load(formCd)
            If ([assembly] Is Nothing) Then
                Return Nothing
            End If
        Catch exception1 As FileNotFoundException
            Dim exception As FileNotFoundException = exception1
            MessageInfo((ChrW(54532) & ChrW(47196) & ChrW(44536) & ChrW(47016) & ChrW(51012) & " " & ChrW(52286) & ChrW(51012) & " " & ChrW(49688) & " " & ChrW(50630) & ChrW(49845) & ChrW(45768) & ChrW(45796) & ": " & formCd), Nothing, Nothing)
            obj2 = Nothing
            Return obj2
        Catch exception4 As Exception
            Dim excp As Exception = exception4
            MessageError(excp, Nothing, Nothing)
            obj2 = Nothing
            Return obj2
        End Try
        Dim type As Type = Nothing
        Dim objectValue As Object = Nothing
        Try
            Dim name As String = formCd
            If Not name.StartsWith(rootNameSpace) Then
                name = (rootNameSpace & "." & formCd)
            End If
            type = [assembly].GetType(name)
            If (type Is Nothing) Then
                Return Nothing
            End If
            objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(type))
        Catch exception5 As Exception
            Dim exception3 As Exception = exception5
            MessageError(exception3, Nothing, Nothing)
        End Try
        Return objectValue
    End Function



#End Region

    Private Sub in_fac_TextChanged(sender As System.Object, e As System.EventArgs) Handles in_fac.TextChanged
        For i = 0 To g10.RowCount - 1
            g10.Text("in_fac", i) = in_fac.Text
            g10.Text("in_wh", i) = in_wh.Text
        Next
    End Sub

    Private Sub in_wh_TextChanged(sender As System.Object, e As System.EventArgs) Handles in_wh.TextChanged
        For i = 0 To g10.RowCount - 1
            g10.Text("in_wh", i) = in_wh.Text
        Next
    End Sub

    Private Sub sh_gw_Click(sender As System.Object, e As System.EventArgs) Handles sh_gw.Click
        Dim strUserid As String = ""

        strUserid = Parameter.Login.EmpNo
        strUserid = po_emp.Text

        Dim p As New OpenParameters
        p.Add("@emp_no", po_emp.Text)
        p.Add("@app_code", po_no.Text)

        Dim Popup As New MMB100P

        Dim StdURL As String

        Dim dSet As DataSet = OpenDataSet("mmb100_get_url", p)

        If Not IsEmpty(dSet) Then
            StdURL = CStr(DataValue(dSet)) & "&EMP_CODE=" + po_emp.Text
            Popup.WebBrowser1.Navigate(New System.Uri(StdURL), True)
        End If


    End Sub

    Private Sub Print()
        Dim pp As OpenParameters = New OpenParameters
        pp.Add("@po_no", po_no.Text)
        pp.Add("@cust_cd", cust_cd.Text)
        pp.Add("@po_fac", po_fac.Text)
        pp.Add("@in_fac", in_fac.Text)
        pp.Add("@in_wh", in_wh.Text)

        System7.ReportView.LoadView("MMB100", "", "mmb100_Print", pp)

    End Sub

    Private Sub po_bc_TextChanged(sender As Object, e As System.EventArgs) Handles po_bc.TextChanged
        If po_bc.Text = "MM100500" Then
            go_gw.Enabled = False
            sh_gw.Enabled = False
        Else
            go_gw.Enabled = True
            sh_gw.Enabled = True
        End If
    End Sub

    Private Sub dlv_dt_TextChanged(sender As System.Object, e As System.EventArgs) Handles dlv_dt.TextChanged
        For i = 0 To g10.RowCount - 1
            g10.Text("dlv_dt", i) = dlv_dt.Text
        Next
    End Sub

    Private Sub mmv_btn_Click(sender As System.Object, e As System.EventArgs) Handles mmv_btn.Click
        With g10
            If .RowCount - 1 >= 0 Then

                If .CheckedRows("chk") = 0 Then
                    MessageInfo("선택된 품목이 없습니다")
                    Exit Sub
                Else

                    If MessageYesNo("품목 기준단가로 저장하시겠습니까?") = MsgBoxResult.No Then
                        Exit Sub
                    Else

                        For i As Integer = 0 To .RowCount - 1
                            If .ToBool("chk", i) Then

                                Dim p As OpenParameters = New OpenParameters
                                p.Add("@po_no", po_no.Text)
                                p.Add("@itm_id", .Text("itm_id", i))

                                Me.Open("mmb100_mmv", p)

                            End If
                        Next

                    End If
                End If
            Else
                Exit Sub
            End If


        End With
    End Sub


    Private Sub chk_all_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_all.CheckedChanged
        g10.CheckRows("chk", chk_all.Checked)
    End Sub

    'Private Sub ECheck1_CheckedChanged(sender As System.Object, e As System.EventArgs)
    '    'EPanel2.Visible = True
    '    'EPanel4.Visible = True

    '    'If ECheck1.Checked Then MenuButton_Click(MenuType.Find)

    '    Dim i As Integer

    '    For i = 0 To g10.RowCount - 1
    '        If g10.Text("echeck", i) = "1" Then
    '            MsgBox("1")
    '            MenuButton_Click(MenuType.Find)

    '        Else

    '        End If
    '    Next


    'End Sub

End Class
