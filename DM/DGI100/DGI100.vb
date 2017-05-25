Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Functions

Public Class DGI100

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

                Dim StdURL As String = "http://gw.interojo.com/ekp/user.do?cmd=goEappWrite&EMP_CODE=" + strUserid + "&LINK_ID=IFBUY07&APP_CODE=" + g10.Text("DOC_NO", i) + "&APP_KIND=1"

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

        Dim dSet As DataSet = Link.ReadDataSet("dgi100_print", p)
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
        Dim gu As String = ""       '구분(박스,라벨,설명서,봉인라벨)
        Dim po_spec As String = ""  '포장재규격(박스,라벨,설명서)
        Dim bl_spec As String = ""  '블리스터규격(중사각,원형,소사각,원데이,바이알)
        Dim chk_yn1 As String = ""
        Dim chk_yn2 As String = ""
        Dim chk_yn3 As String = ""
        Dim chk_yn4 As String = ""

        If dRow("GU") = "DG_GU01" Then
            gu = "박스"
            chk_yn1 = "checked"
        ElseIf dRow("GU") = "DG_GU02" Then
            gu = "라벨"
            chk_yn2 = "checked"
        ElseIf dRow("GU") = "DG_GU03" Then
            gu = "설명서"
            chk_yn3 = "checked"
        ElseIf dRow("GU") = "DG_GU04" Then
            gu = "봉인라벨"
            chk_yn4 = "checked"
        End If

        If dRow("PO_SPEC") = "DG_SP01" Then
            po_spec = "박스"
        ElseIf dRow("PO_SPEC") = "DG_SP02" Then
            po_spec = "라벨"
        ElseIf dRow("PO_SPEC") = "DG_SP03" Then
            po_spec = "설명서"
        End If

        If dRow("BL_SPEC") = "DG_BL01" Then
            bl_spec = "중사각"
        ElseIf dRow("BL_SPEC") = "DG_BL02" Then
            bl_spec = "원형"
        ElseIf dRow("BL_SPEC") = "DG_BL03" Then
            bl_spec = "소사각"
        ElseIf dRow("BL_SPEC") = "DG_BL04" Then
            bl_spec = "원데이"
        ElseIf dRow("BL_SPEC") = "DG_BL05" Then
            bl_spec = "바이알"
        End If

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
        "<td width='20%' height='20' align = 'center'>요 청 자</td>" &
        "<td width='30%' align = 'center'>" & dRow("EMP_NM") & "</td>" &
        "<td width='20%' align = 'center'>요청 일자</td>" &
        "<td width='30%' align = 'center'>" & dRow("RE_DT") & "</td>" &
    "</tr>" &
        "</tr>" &
        "<tr>" &
        "<td width='20%' height='20' align = 'center'>Buyer</td>" &
        "<td width='30%' align = 'center'>" & dRow("BUY_NM") & "</td>" &
        "<td width='20%' align = 'center'>완료 요청 일자</td>" &
        "<td width='30%' align = 'center'>" & dRow("END_DT") & "</td>" &
    "</tr>" &
    "<tr>" &
        "<td height='30' align = 'center'>구분</td>" &
        "<td colspan='3' align = 'center'>&nbsp;" &
        "<input type=" & """checkbox""" & "name=" & """chk""" & chk_yn1 & " disabled = true" & ">박스" & "&nbsp;&nbsp;&nbsp;&nbsp;" &
        "<input type=" & """checkbox""" & "name=" & """chk""" & chk_yn2 & " disabled = true" & ">라벨" & "&nbsp;&nbsp;&nbsp;&nbsp;" &
        "<input type=" & """checkbox""" & "name=" & """chk""" & chk_yn3 & " disabled = true" & ">설명서" & "&nbsp;&nbsp;&nbsp;&nbsp;" &
        "<input type=" & """checkbox""" & "name=" & """chk""" & chk_yn4 & " disabled = true" & ">봉인라벨" & "</td>" &
    "</tr>" &
        "<tr>" &
        "<td height='100' align = 'center'>세부사항</td>" &
        "<td colspan='3'>&nbsp;" & "1. 포장 제품(렌즈) 스펙<BR>" & "<BR>&nbsp;&nbsp;" & "- 제품명: " & dRow("GD_NM") & "<BR>&nbsp;&nbsp;" & "- DIA: " & dRow("DIA") &
        "<BR>&nbsp;&nbsp;" & "- B.C: " & dRow("BC") & "<BR>&nbsp;&nbsp;" & "- Water: " & dRow("WTR") & "<BR><BR>" & "&nbsp;" & "2.관리번호: " & dRow("DOC_NO") & "<BR><BR>" &
        "&nbsp;" & "3.포장방식(수동, 자동 / O개입) <BR>&nbsp;" & dRow("PO_WAY") & "&nbsp;<BR><BR>&nbsp" & "4.포장재 규격(박스, 라벨, 설명서) <BR>&nbsp;" & po_spec & "<BR><BR>" &
        "&nbsp;" & "5.블리스터 규격(중사각, 원형, 소사각, 원데이, 바이알) <BR>&nbsp;" & bl_spec & "<BR><BR>" & "&nbsp;" & "6.변경사항 및 변경 사유(신규 의뢰는 항목제외) <BR>&nbsp;" & dRow("CHG_NM") &
"</td>" &
    "</tr>" &
    "<tr>" &
        "<td colspan='4' height='60'><p align = 'left'>※기타 요청사항(후가공)</p>" & "<BR>&nbsp;" & dRow("ETC_NM") & "<br>" &
"<br />" &
    "</tr>" &
"</table>" &
"</BODY>" &
"</HTML>"

        '" disabled = true" &
        '"<td colspan='3' align = 'center'>&nbsp;" & gu & "</td>" &
        '"<input type=" & """checkbox""" & "name=" & """chk""" & "checked" & ">선택2" &
        '    "<select><optgroup label=" & "Swedish Cars" & "><option value=" & "volvo" & ">Volvo</option><option value=" & "saab" & ">Saab</option>" &
        '"</optgroup>" & "<optgroup label=" & "German Cars" & "><option value=" & "mercedes" & ">Mercedes</option><option value=" & "audi" & ">Audi</option>" &
        '"</optgroup></select>" &

        Dim parameter As New Base7.Parameter
        Dim strUserid As String = ""
        strUserid = parameter.Login.EmpNo

        Dim p2 As OpenParameters = New OpenParameters
        p2.Add("@app_code", g10.Text("DOC_NO", row))
        p2.Add("@emp_code", strUserid)
        p2.Add("@form_id", "")

        Dim dSet2 As DataSet
        dSet2 = Me.OpenDataSet("dgi100_html", p2)

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

        Me.Save("dgi100_html")
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

        Dim dSet As DataSet = OpenDataSet("dgi100_get_url", p)

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
