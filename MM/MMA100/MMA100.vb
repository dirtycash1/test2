Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data


Public Class MMA100


    Private Sub MMA100_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.IsManager Then
            go_gw2.Visible = True
        Else
            go_gw2.Visible = False
        End If
        '구매의뢰번호 자동채번 설정
        req_no.CodeNo = "MMA100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        req_no.CodeDateField = req_dt


        SplitContainer2.Panel1Collapsed = True

        'Me.New_Form()
        MyBase.Open()

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Save
                If Me.Save = True Then Me.Open()

            Case MenuType.Delete
                'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제
                MyBase.Open()

            Case MenuType.New
                Me.New_Form()

            Case MenuType.Print
                ' Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Public Sub New_Form()
        req_no.Text = ""
        MyBase.Open()

        g10.AddNewRow()
    End Sub

    Public Sub Open2(ByVal BUYRNO As String)

        req_no.Text = BUYRNO

        MyBase.Open()

    End Sub

    Private Sub Form_Disposing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Disposing
        Me.SetColsingSave()
    End Sub

    Public Sub Open3(ByVal BUYRNO As String, ByVal BUYDT As String, ByVal frfac As String, ByVal InFac As String, ByVal InWh As String)

        req_no.Text = BUYRNO
        req_dt.Text = BUYDT

        req_bc.Text = frfac
        in_fac.Text = InFac
        in_wh.Text = InWh

        MyBase.Open()

        'XtraTabControl1.SelectedTabPageIndex = 0
        'MyBase.Open(WorkSets("mma100_g10"))
        'MyBase.Open(WorkSets("fax100_g10"))
        'MyBase.Open(WorkSets("fax100_g20"))

    End Sub

    Private Sub btn_mov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mov.Click

        With g20

            Dim isSame As Boolean = False

            For i As Integer = 0 To .RowCount - 1
                If .Text("chk", i) = "1" Then

                    'With g10
                    '    isSame = False
                    '    For j As Integer = 0 To .RowCount - 1
                    '        If g20.Text("itm_cd", i) = .Text("itm_cd", j) Then
                    '            isSame = True
                    '            Exit For
                    '        End If
                    '    Next
                    'End With
                    'If isSame Then
                    '    Continue For
                    'End If

                    g10.AddNewRow()
                    g10.Text("itm_cd") = .Text("itm_cd", i)
                    g10.Text("use_bc") = .Text("use_bc", i)
                End If

            Next

        End With

        chk_show.Text = "0"

        g20.Text("chk") = "0"

    End Sub

    Private Sub btn_srh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_srh.Click
        g20.Open()
    End Sub

    Private Sub chk_show_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_show.CheckedChanged

        If Not chk_show.Checked Then
            SplitContainer2.Panel1Collapsed = Not chk_show.Checked

        End If

        If chk_show.Checked Then
            SplitContainer2.Panel1Collapsed = Not chk_show.Checked

        End If

    End Sub


    Private Sub dlv_dt_TextChanged(sender As System.Object, e As System.EventArgs) Handles dlv_dt.TextChanged

        For i = 0 To g10.RowCount - 1
            g10.Text("dlv_dt", i) = dlv_dt.Text
        Next
    End Sub

    '그룹웨어 연동
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

        Dim parameter As New Base7.Parameter
        strUserid = parameter.Login.EmpNo
        strUserid = fr_emp.Text()

        Dim Popup As New MMB100P

        Dim StdURL As String = "http://gw.interojo.com/ekp/user.do?cmd=goEappWrite&EMP_CODE=" + strUserid + "&LINK_ID=IFBUY01&APP_CODE=" + req_no.Text + "&APP_KIND=1"

        Popup.WebBrowser1.Navigate(New System.Uri(StdURL), True)
    End Sub

    Private Sub make_html()

        Dim p As OpenParameters = New OpenParameters
        p.Add("@req_no", req_no.Text)
        'p.Add("@cust_cd", cust_cd.Text)
        p.Add("@po_fac", in_fac.Text)
        p.Add("@in_fac", in_fac.Text)
        p.Add("@in_wh", in_wh.Text)

        Dim formCd As String = ""
        'Dim document As ReportDocument = Nothing
        Dim dSet As DataSet = Link.ReadDataSet("mma100_Print", p)
        Dim dRow As DataRow

        Dim header As String = ""
        Dim body As String = ""
        Dim footer As String = ""

        Dim tot_amt As Integer = 0
        header = "" &
        "<HTML>" &
"<TITLE></TITLE>" &
"<BODY BGCOLOR='FFFFFF' LEFTMARGIN=31 TOPMARGIN=31>" &
"<table width='100%' height='' border='0'>" &
    "<tr>" &
        "<td width='31%' height = '18' align = 'left'>결 의 일 자 : " & req_dt.Text & "</td>" &
        "<td height = '18'>&nbsp;</td>" &
   "</tr>" &
    "<tr>" &
        "<td height = '18' align = 'left'>요 청 부 서 : " & fr_dept_nm.Text & "</td>" &
        "<td height = '18' align = 'left'>의 뢰 자 : " & fr_nm.Text & "</td>" &
    "</tr>" &
"</table>" &
"<table width='100%' border='1'>" &
"  <tr>" &
"    <td width='20%' align='center' height = '18'>품명</td>" &
"    <td width='8%' align='center' height = '18'>수량</td>" &
"    <td width='5%' align='center' height = '18'>단위</td>" &
"    <td width='8%' align='center' height = '18'>단가</td>" &
"    <td width='10%' align='center' height = '18'>통화구분</td>" &
"    <td width='8%' align='center' height = '18'>금액</td>" &
"    <td width='10%' align='center' height = '18'>용도구분</td>" &
"    <td width='10%' align='center' height = '18'>납품일자</td>" &
"    <td width='21%' align='center' height = '18'>업체명</td>" &
"  </tr>"
        For i = 0 To dSet.Tables(0).Rows.Count - 1
            dRow = dSet.Tables(0).Rows(i)
            body = body &
      "<tr>" &
    "      <td align='center' height = '18' align = 'left'>&nbsp;&nbsp;&nbsp;" & dRow("itm_nm") & "</td>" &
    "      <td align='center' height = '18' align = 'right'>" & dRow("req_qty") & "&nbsp;&nbsp;</td>" &
    "      <td align='center' height = '18'>" & dRow("um_nm") & "</td>" &
    "      <td align='center' height = '18' align = 'right'>" & dRow("req_up") & "&nbsp;&nbsp;</td>" &
    "      <td align='center' height = '18' align = 'right'>" & dRow("sub_cd") & "&nbsp;&nbsp;</td>" &
    "      <td align='center' height = '18' align = 'right'>" & dRow("tot") & "&nbsp;&nbsp;</td>" &
    "      <td align='center' height = '18'>" & dRow("use_nm") & "</td>" &
    "      <td align='center' height = '18'>" & dRow("dlv_dt") & "</td>" &
    "      <td align='center' height = '18' align = 'left'>&nbsp;&nbsp;" & dRow("cust_nm") & "</td>" &
    "  </tr>"
            tot_amt = tot_amt + CDec(dRow("tot"))
        Next
        If (dSet.Tables(0).Rows.Count - 1) < 0 Then Exit Sub
        dRow = dSet.Tables(0).Rows(dSet.Tables(0).Rows.Count - 1)

        footer = "" &
"  <tr>" &
"      <td colspan='10' align='right' height = '18'>" &
"          <p>총 금액 : " & Format(tot_amt, "#,###") & "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>" &
"          </td>" &
"  </tr>" &
"  <tr>" &
"      <td colspan='10' align='left' height = '18'>" &
"          <p>비고(Remark) : </p>" &
"          <p>&nbsp;" & dRow("rmks") & "</p>" &
"          </td>" &
"  </tr>" &
"</table>" &
"</BODY>" &
"</HTML>"
        'If po_emp.Text = "" Then Exit Sub

        Dim p2 As OpenParameters = New OpenParameters
        p2.Add("@app_code", req_no.Text)
        p2.Add("@emp_code", fr_emp.Text)
        p2.Add("@form_id", "")

        Dim dSet2 As DataSet
        dSet2 = Me.OpenDataSet("mma100_html", p2)
        'If dSet2 Is Nothing Then
        '    Exit Sub
        'End If

        Dim dRow1 As DataRow
        'If g10.IsDataRow(i) Then        'Data Row 만 작업한다 합계Row등은 제외
        dRow1 = dSet2.Tables(0).NewRow
        dRow1("emp_code") = fr_emp.Text
        dRow1("form_id") = ""
        dRow1("app_code") = req_no.Text
        dRow1("seq") = dSet2.Tables(0).Rows.Count
        dRow1("result_status") = "C"
        dRow1("app_kind") = "1"
        dRow1("form_html") = header & body & footer
        dSet2.Tables(0).Rows.Add(dRow1)
        'End If


        Me.Save("mma100_html")
    End Sub

    Private Sub sh_gw_Click(sender As System.Object, e As System.EventArgs) Handles sh_gw.Click
        Dim strUserid As String = ""

        strUserid = Parameter.Login.EmpNo
        strUserid = fr_emp.Text

        Dim p As New OpenParameters
        p.Add("@fr_emp", fr_emp.Text)
        p.Add("@app_code", req_no.Text)

        Dim Popup As New MMB100P

        Dim StdURL As String

        Dim dSet As DataSet = OpenDataSet("mma100_get_url", p)

        If Not IsEmpty(dSet) Then
            StdURL = CStr(DataValue(dSet)) & "&EMP_CODE=" + fr_emp.Text
            Popup.WebBrowser1.Navigate(New System.Uri(StdURL), True)
        End If


    End Sub

    Private Sub go_gw2_Click(sender As System.Object, e As System.EventArgs) Handles go_gw2.Click
        If g10.Text("result_status", 0) = "기안" Then
            MessageInfo("이미 결재 진행중인 문서입니다.")
            Exit Sub
        ElseIf g10.Text("result_status", 0) = "승인" Then
            MessageInfo("결재 완료된 문서입니다.")
            Exit Sub
        End If

        Me.make_html()
        Dim strUserid As String = ""

        Dim parameter As New Base7.Parameter
        strUserid = parameter.Login.EmpNo
        strUserid = fr_emp.Text()

        Dim Popup As New MMB100P

        Dim StdURL As String = "http://gw.interojo.com/ekp/user.do?cmd=goEappWrite&EMP_CODE=" + strUserid + "&LINK_ID=IFBUY04&APP_CODE=" + req_no.Text + "&APP_KIND=1"

        Popup.WebBrowser1.Navigate(New System.Uri(StdURL), True)
    End Sub
End Class
