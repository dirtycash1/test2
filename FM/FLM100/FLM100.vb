Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Functions

Public Class FLM100

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Open()
        'New_Form()
    End Sub
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Save

                If Me.Save() Then
                    Me.Open()

                End If

            Case MenuType.New
                emp_no.Text = ""
                emp_nm.Text = ""
                New_Form()


            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Private Sub New_Form()
        '검색필드에 “” 를  설정(검색되지않는 조건)하고 Open()
        'MyBase.Open("gat100_g10")

        'Grid에 신규행을 추가 -> Group 컬럼이 있는 상태에서 추가는 의미없음(어떤그룹 밑에 추가행이 생길지 모름)
        g10.AddNewRow()
        'g10.Find("")
    End Sub


    '그룹웨어 연동
    Private Sub go_gw_Click(sender As System.Object, e As System.EventArgs) Handles go_gw.Click
        Dim chkct As Integer = 0
        For i = 0 To g10.RowCount - 1
            If g10.Text("chk", i) = "1" Then
                chkct = chkct + 1
                If g10.Text("DOC_NO", i) = "" Then
                    MessageInfo("저장 후 결재상신을 해주세요.")
                    Exit Sub
                End If
                If g10.Text("result_status", i) = "기안" Then
                    MessageInfo("이미 결재 진행중인 문서입니다.")
                    Exit Sub
                ElseIf g10.Text("result_status", i) = "승인" Then
                    MessageInfo("결재 완료된 문서입니다.")
                    Exit Sub
                ElseIf g10.Text("result_status", i) = "반려" Then
                    MessageInfo("반려된 문서입니다. 새로 작성해 주세요.")
                    Exit Sub
                End If

                Me.make_html(i)
                Dim strUserid As String = ""

                Dim parameter As New Base7.Parameter
                strUserid = parameter.Login.EmpNo

                Dim Popup As New MMB100P

                Dim StdURL As String = "http://gw.interojo.com/ekp/user.do?cmd=goEappWrite&EMP_CODE=" + strUserid + "&LINK_ID=IFBUY06&APP_CODE=" + g10.Text("DOC_NO", i) + "&APP_KIND=1"

                Popup.WebBrowser1.Navigate(New System.Uri(StdURL), True)

                Exit Sub
            End If
        Next

        If chkct < 1 Then
            MessageInfo("선택된 행이 없습니다.")
        End If

    End Sub

    Private Sub make_html(row As Integer)

        Dim p As OpenParameters = New OpenParameters
        p.Add("@doc_no", g10.Text("DOC_NO", row))
        p.Add("@re_dt", g10.Text("RE_DT", row))
        p.Add("@re_emp", g10.Text("RE_EMP", row))
        'p.Add("@fr_dt", g10.Text("fr_dt", row))

        Dim dSet As DataSet = Link.ReadDataSet("flm100_print", p)
        Dim dRow As DataRow

        If dSet Is Nothing Then
            MessageInfo("데이터가 없습니다.")
            Exit Sub
        End If

        dRow = dSet.Tables(0).Rows(0)

        Dim header As String = ""
        Dim body As String = ""
        Dim footer As String = ""

        Dim tot_amt As Integer = 0
        ' header = "" &
        header = "" &
        "<HTML>" &
"<TITLE></TITLE>" &
"<BODY BGCOLOR='FFFFFF' LEFTMARGIN=31 TOPMARGIN=31>" &
"<table width='100%' border='0'>" &
"</table>" &
"<table width='100%' border='1'>" &
    "<tr>" &
        "<td width='20%' height='20' align = 'center'>의뢰 부서</td>" &
        "<td width='30%' align = 'center'>" & dRow("RE_DEPT_NM") & "</td>" &
        "<td width='20%' align = 'center'>실행 부서</td>" &
        "<td width='30%' align = 'center'>" & dRow("ACT_DEPT_NM") & "</td>" &
    "</tr>" &
    "<tr>" &
        "<td height='30' align = 'center'>요 청 자</td>" &
        "<td colspan='3' align = 'center'>&nbsp;" & dRow("EMP_NM") & "</td>" &
    "</tr>" &
    "<tr>" &
        "<td height='30' align = 'center'>요청 일자</td>" &
        "<td colspan='3' align = 'center'>&nbsp;" & dRow("RE_DT") & "</td>" &
    "</tr>" &
    "<tr>" &
        "<td height='30' align = 'center'>제품명</td>" &
        "<td colspan='3' align = 'center'>&nbsp;" & dRow("PR_NM") & "</td>" &
    "</tr>" &
    "<tr>" &
        "<td height='100' align = 'center'>변경 사유<BR>(OUT,IN<BR>구분하여<BR>상세히 기재)</td>" &
        "<td colspan='3'>&nbsp;" & "필름명 : " & dRow("FLM_NM") & "<BR>&nbsp;필름날짜 : " & dRow("FLM_DT") & "<BR>&nbsp;필름스펙 : " & dRow("FLM_SPEC") & "<BR>&nbsp;변경사유 : (현 필름의 문제점 상세히 기재) <BR>" & "&nbsp;" & dRow("CHG_RE") &
"</td>" &
    "</tr>" &
        "<tr>" &
        "<td height='100' align = 'center'>변경 요청<BR>(OUT,IN<BR>구분하여<BR>상세히 기재)</td>" &
        "<td colspan='3'>&nbsp;" & "변경 내용 <BR>&nbsp;" & dRow("CHG_RMK") &
"</td>" &
    "</tr>" &
    "<tr>" &
        "<td colspan='4' height='60'><p align = 'left'>※기타 요청사항</p>" & "<BR>&nbsp;" & dRow("ETC_RMK") &
        "<br />" &
    "</tr>" &
"</table>" &
"</BODY>" &
"</HTML>"

        Dim parameter As New Base7.Parameter
        Dim strUserid As String = ""
        strUserid = parameter.Login.EmpNo

        Dim p2 As OpenParameters = New OpenParameters
        p2.Add("@app_code", g10.Text("DOC_NO", row))
        p2.Add("@emp_code", strUserid)
        p2.Add("@form_id", "")

        Dim dSet2 As DataSet
        dSet2 = Me.OpenDataSet("flm100_html", p2)

        Dim dRow1 As DataRow
        dRow1 = dSet2.Tables(0).NewRow
        dRow1("emp_code") = strUserid
        dRow1("form_id") = ""
        dRow1("app_code") = g10.Text("DOC_NO", row)
        dRow1("seq") = dSet2.Tables(0).Rows.Count
        dRow1("result_status") = "C"
        dRow1("app_kind") = "1"
        dRow1("form_html") = header & body & footer
        dSet2.Tables(0).Rows.Add(dRow1)

        Me.Save("flm100_html")
    End Sub

    Private Sub sh_gw_Click(sender As System.Object, e As System.EventArgs) Handles sh_gw.Click

        Dim strUserid As String = ""
        Dim chkct As Integer = 0
        strUserid = Parameter.Login.EmpNo

        Dim p As New OpenParameters
        For i = 0 To g10.RowCount - 1
            If g10.Text("chk", i) = "1" And g10.Text("DOC_NO", i) <> "" Then
                p.Add("@re_emp", g10.Text("RE_EMP", i))
                p.Add("@app_code", g10.Text("DOC_NO", i))
                chkct = chkct + 1
            Else

            End If
        Next

        If chkct < 1 Then
            MessageInfo("선택된 행이 없습니다.")
            Exit Sub
        End If

        Dim Popup As New MMB100P

        Dim StdURL As String

        Dim dSet As DataSet = OpenDataSet("flm100_get_url", p)

        If Not IsEmpty(dSet) Then
            StdURL = CStr(DataValue(dSet)) & "&EMP_CODE=" + strUserid
            Popup.WebBrowser1.Navigate(New System.Uri(StdURL), True)
        End If

    End Sub

    Private Sub g10_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged

        Dim chk As Integer = 0
        For i = 0 To g10.RowCount - 1
            If g10.Text("chk", i) = "1" Then
                chk = chk + 1
            End If
        Next

        If chk > 1 Then
            MessageInfo("하나만 선택해주세요.")
            g10.Text("chk", RowIndex) = ""
            Exit Sub
        End If
    End Sub

End Class
