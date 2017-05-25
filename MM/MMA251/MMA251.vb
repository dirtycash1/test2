Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class MMA251


    Private Sub MMA251_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '구매발주번호 자동채번 설정
        po_no.CodeNo = "MMA250"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        po_no.CodeDateField = po_dt

        SplitContainer2.Panel1Collapsed = True

        Me.New_Form()

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
                'Me.WorkSets("MMA251_g10").AddNew()  '특정Workset 신규처리

            Case MenuType.Print
                Me.Print()

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

        g10.AddNewRow()
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

        'Me.Open("MMA251_itm", p)
        ''Me.OpenDataSet("MMA251_itm", p)
        ''g10.AddNewRow()
        ''MyBase.Open("MMA251_itm", p)
    End Sub


    Private Sub btn_price_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_price.Click
        Dim p As New OpenParameters
        Dim R As Integer

        g10.UpdateRow()

        For R = 0 To g10.RowCount - 1
            p.Add("@part_cd", g10.Text("part_cd", R))
            p.Add("@cust_cd", cust_cd.Text)
            'p.Add("@cury_bc", cury_bc.Text)
            'p.Add("@po_fac", po_fac.Text)
            p.Add("@po_dt", po_dt.Text)
            Dim Dset As DataSet = OpenDataSet("MMA251_cost", p)

            If Not IsEmpty(Dset) Then
                g10.RowIndex = R
                g10.Text("po_up") = DataValue(Dset, "in_up")

                Dset = Nothing

            End If

        Next

        'Me.OpenDataSet("MMA251_itm", p)
        'g10.AddNewRow()
        'MyBase.Open("MMA251_itm", p)
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


    Public Sub Open3(ByVal dSet As DataSet, ByVal fac_cd As String)
        Me.New_Form()
        g10.DeleteBlankRow()

        Dim i As Integer = 0
        For Each dRow As DataRow In dSet.Tables(0).Rows
            If ToStr(dRow("chk")) Then

                If i = 0 Then
                    cust_cd.Text = ToStr(dRow("cust_cd"))
                    po_fac.Text = fac_cd

                End If

                g10.AddNewRow()
                g10.Text("req_no", i) = ToStr(dRow("req_no"))
                g10.Text("req_sq", i) = ToStr(dRow("req_sq"))
                g10.Text("part_cd", i) = ToStr(dRow("part_cd"))
                g10.Text("part_nm", i) = ToStr(dRow("part_nm"))
                g10.Text("part_spec", i) = ToStr(dRow("part_spec"))
                g10.Text("use_bc", i) = ToStr(dRow("use_bc"))
                g10.Text("dlv_um", i) = ToStr(dRow("um_bc"))
                g10.Text("po_fac", i) = ToStr(dRow("fr_fac"))
                g10.Text("in_fac", i) = ToStr(dRow("in_fac"))
                g10.Text("rmks", i) = ToStr(dRow("rmks"))
                g10.Text("dept_cd", i) = ToStr(dRow("fr_dept"))
                'g10.Text("cury_bc", i) = ToStr(dRow("cury_bc"))
                g10.Text("po_qty", i) = ToStr(dRow("qty"))
                'g10.Text("out_up", i) = ToStr(dRow("so_sq"))


                i += 1
            End If


        Next

    End Sub


    'Public Sub Open3(ByVal Repno As String, ByVal ReqSeq As String, ByVal Itmid As String, ByVal Itmcd As String, ByVal Itmnm As String, ByVal Spec As String, ByVal Poqty As String, _
    '                     ByVal Umbc As String, ByVal Std_Umbc As String, ByVal Custcd As String, ByVal Custnm As String)

    '    SimpleButton1.Enabled = False

    '    cust_cd.Text = Custcd
    '    cust_nm.Text = Custnm
    '    urg_bc.Text = "MM105100"

    '    With g10
    '        Dim jRow As Integer = 0
    '        g10.AddNewRow()
    '        jRow = g10.RowIndex
    '        g10.Text("req_no", jRow) = Repno
    '        g10.Text("req_sq", jRow) = ReqSeq
    '        g10.Text("itm_id", jRow) = Itmid
    '        g10.Text("itm_cd", jRow) = Itmcd
    '        g10.Text("itm_nm", jRow) = Itmnm
    '        g10.Text("spec", jRow) = Spec
    '        g10.Text("dlv_um", jRow) = Umbc
    '        g10.Text("um_bc", jRow) = Std_Umbc
    '        g10.Text("po_qty", jRow) = Poqty
    '    End With


    'End Sub

    Private Sub po_fac_TextChanged(sender As System.Object, e As System.EventArgs) Handles po_fac.TextChanged
        For i = 0 To g10.RowCount - 1
            g10.Text("po_fac", i) = po_fac.Text
        Next
    End Sub

    Private Sub in_fac_TextChanged(sender As System.Object, e As System.EventArgs) Handles in_fac.TextChanged
        For i = 0 To g10.RowCount - 1
            g10.Text("in_fac", i) = in_fac.Text
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
        'strUserid = po_emp.Text

        Dim Popup As New MMB100P

        Dim StdURL As String = "http://gw.interojo.com/ekp/user.do?cmd=goEappWrite&EMP_CODE=" + strUserid + "&LINK_ID=IFBUY02&APP_CODE=" + po_no.Text + "&APP_KIND=1"

        Popup.WebBrowser1.Navigate(New System.Uri(StdURL), True)

        Me.Open_Form()   '170412smk 결재상신버튼 클릭시 -> '작성' 자동조회

    End Sub

    Private Sub make_html()

        Dim p As OpenParameters = New OpenParameters
        p.Add("@po_no", po_no.Text)
        'p.Add("@cust_cd", cust_cd.Text)
        p.Add("@po_fac", po_fac.Text)
        p.Add("@in_fac", in_fac.Text)
        'p.Add("@in_wh", in_wh.Text)

        Dim formCd As String = ""
        'Dim document As ReportDocument = Nothing
        Dim dSet As DataSet = Link.ReadDataSet("mma251_Print", p)
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
            "<p align = 'left'>&nbsp;&nbsp;&nbsp;결재방법 :   " & pset_bc.EditText & "</p>" &
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
"    <td width='12%' align='center' height = '18'>품명</td>" &
"    <td width='13%' align='center' height = '18'>규격</td>" &
"    <td width='5%' align='center' height = '18'>단위</td>" &
"    <td width='9%' align='center' height = '18'>요청수량</td>" &
"    <td width='13%' align='center' height = '18'>현재고</td>" &
"    <td width='13%' align='center' height = '18'>발주수량</td>" &
"    <td width='7%' align='center' height = '18'>단가</td>" &
"    <td width='8%' align='center' height = '18'>금액</td>" &
"  </tr>"
        For i = 0 To dSet.Tables(0).Rows.Count - 1
            dRow = dSet.Tables(0).Rows(i)
            body = body &
      "<tr>" &
    "      <td align='center' height = '18'>" & dRow("po_sq") & "</td>" &
    "      <td align='center' height = '18'>" & dRow("part_cd") & "</td>" &
    "      <td align='left' height = '18'>&nbsp;&nbsp;" & dRow("part_nm") & "</td>" &
    "      <td align='left' height = '18'>&nbsp;&nbsp;" & dRow("part_spec") & "</td>" &
    "      <td align='center' height = '18'>" & dRow("um_nm") & "</td>" &
    "      <td align='right' height = '18'>" & dRow("po_qty") & "&nbsp;&nbsp;</td>" &
    "      <td align='right' height = '18'>" & dRow("pr_qty") & " <br />" & "</td>" &  '"      <td align='right' height = '18'>" & dRow("pr_qty") & " <br />" & "</td>" & 
    "      <td align='right' height = '18'>" & dRow("po_qty") & " <br />" & "</td>" &    '"      <td align='right' height = '18'>" & dRow("po_qty") & " <br />" & "</td>" &    '기존 pu_qty(구매수량)으로 되어있었음. 이재란요청->발주수량
    "      <td align='right' height = '18'>" & dRow("po_up") & "&nbsp;&nbsp;</td>" &
    "      <td align='right' height = '18'>" & dRow("po_amt1") & "&nbsp;&nbsp;</td>" &
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
"          <p>" & "(" & Mid(cury_bc.Text, 6, 3) & ") 총 금액 : " & tot_amt2 & "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>" &
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
        dSet2 = Me.OpenDataSet("mma251_html", p2)
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



        Me.Save("mma251_html")
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

        Dim dSet As DataSet = OpenDataSet("mma251_get_url", p)

        If Not IsEmpty(dSet) Then
            StdURL = CStr(DataValue(dSet)) & "&EMP_CODE=" + po_emp.Text
            Popup.WebBrowser1.Navigate(New System.Uri(StdURL), True)
        End If


    End Sub

    Private Sub Print()
        Dim pp As OpenParameters = New OpenParameters
        pp.Add("@po_no", po_no.Text)
        'p.Add("@cust_cd", cust_cd.Text)
        pp.Add("@po_fac", po_fac.Text)
        pp.Add("@in_fac", in_fac.Text)

        System7.ReportView.LoadView("MMA251", "", "mma251_Print", pp)

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

    Private Sub chk_show_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_show.CheckedChanged

        If chk_show.Checked Then
            SplitContainer2.Panel1Collapsed = Not chk_show.Checked
        End If

        If Not chk_show.Checked Then
            SplitContainer2.Panel1Collapsed = Not chk_show.Checked
        End If

    End Sub

    Private Sub btn_srh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_srh.Click
        g20.Open()
    End Sub

    Private Sub btn_mov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mov.Click

        g10.DeleteBlankRow()

        With g20

            Dim isSame As Boolean = False

            For i As Integer = 0 To .RowCount - 1
                If .Text("chk", i) = "1" Then

                    g10.AddNewRow()
                    g10.Text("use_bc") = .Text("use_bc", i)
                    g10.Text("part_cd") = .Text("part_cd", i)
                    g10.Text("part_nm") = .Text("part_nm", i)
                    g10.Text("part_spec") = .Text("part_spec", i)
                    g10.Text("um_bc") = .Text("um_bc", i)
                    g10.Text("rmks") = .Text("rmks", i)
                    'g10.Text("cust_cd") = .Text("cust_cd", i)
                End If

            Next

        End With

        chk_show.Text = "0"

        Me.Open(g20.WorkSet)


    End Sub

    '161110 smk 납기일자변경시, g10의 납기일자 자동변경
    Private Sub dlv_dt_TextChanged(sender As Object, e As EventArgs) Handles dlv_dt.TextChanged
        With g10
            Dim isSame As Boolean = False

            For i As Integer = 0 To .RowCount - 1
                g10.Text("dlv_dt", i) = dlv_dt.Text
            Next

        End With
    End Sub

    Private Sub g10_AddedRow(sender As Object, RowIndex As Integer) Handles g10.AddedRow
        g10.Text("dlv_dt", RowIndex) = dlv_dt.Text
    End Sub


End Class
