Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data


Public Class MMA200


    Private Sub MMA200_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '구매의뢰번호 자동채번 설정
        req_no.CodeNo = "MMA200"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        req_no.CodeDateField = req_dt

        'SplitContainer2.Panel1Collapsed = True
        SplitContainer4.Panel2Collapsed = Not doc_open.Checked

        'FTP Upload용
        g30.AllowDrop = True

        'Drag & Drop으로 만 신규파일 추가가능
        'Grid의 삭제 버턴으로만 삭제 가능
        g30.AllowAddRows = False    'Drag & Drop으로 만 신규파일 추가가능
        g30.AllowDeleteRows = False '임의로 DB에서만 삭제되면 FTP와의 동기화가 끊어진다

        MyBase.Open()

        g10.AddNewRow()

        'Me.New_Form()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Save
                If Me.Save = True Then Me.Open()

            Case MenuType.Delete
                'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

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

    Private Sub Form_Disposing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Disposing
        Me.SetColsingSave()
    End Sub



    Public Sub Open2(ByVal reqNo As String)

        req_no.Text = reqNo

        MyBase.Open()

    End Sub

    Public Sub Open3(ByVal Repno As String, ByVal Reqdt As String, ByVal frfac As String, ByVal InFac As String)

        req_no.Text = Repno
        req_dt.Text = Reqdt

        req_bc.Text = frfac
        in_fac.Text = InFac
        'in_wh.Text = InWh

        MyBase.Open()

        'XtraTabControl1.SelectedTabPageIndex = 0
        'MyBase.Open(WorkSets("MMA200_g10"))
        'MyBase.Open(WorkSets("fax100_g10"))
        'MyBase.Open(WorkSets("fax100_g20"))

    End Sub

    Public Sub Open4(ByVal Repno As String)

        req_no.Text = Repno

        MyBase.Open()

    
    End Sub

    Private Sub btn_mov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mov.Click

        g10.DeleteBlankRow()

        With g20

            Dim isSame As Boolean = False

            For i As Integer = 0 To .RowCount - 1
                If .Text("chk", i) = "1" Then

                    'With g10
                    '    isSame = False
                    '    For j As Integer = 0 To .RowCount - 1
                    '        If g20.Text("part_cd", i) = .Text("part_cd", j) Then
                    '            isSame = True
                    '            Exit For
                    '        End If
                    '    Next
                    'End With
                    'If isSame Then
                    '    Continue For
                    'End If

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


    Private Sub btn_srh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_srh.Click
        g20.Open()
    End Sub

    Private Sub chk_show_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_show.CheckedChanged

        'If chk_show.Checked Then
        '    SplitContainer2.Panel1Collapsed = Not chk_show.Checked
        'End If

        'If Not chk_show.Checked Then
        SplitContainer2.Panel1Collapsed = Not chk_show.Checked
        'End If

    End Sub

    Private Sub dlv_dt_TextChanged(sender As System.Object, e As System.EventArgs) Handles dlv_dt.TextChanged

        For i = 0 To g10.RowCount - 1
            g10.Text("dlv_dt", i) = dlv_dt.Text
        Next
    End Sub

    '관련문서 첨부
    Private Sub doc_open_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles doc_open.CheckedChanged

        If Not doc_open.Checked Then
            SplitContainer4.Panel2Collapsed = True
        End If

        If doc_open.Checked Then
            SplitContainer4.Panel2Collapsed = False
        End If

    End Sub


#Region "FTP 관리"

    Private Sub g30_ButtonPressed(ByVal sender As Object, ByVal columnName As String) Handles g30.ButtonPressed
        Dim fileID As String = g30.Text("file_id")
        Dim fileNm As String = g30.Text("file_nm")
        If fileNm = "" Then
            Exit Sub
        End If

        If columnName = "del" Then
            Try
                'If [Shared].FileDelete(fileID, fileNm) = True Then
                ' 오류수정: fileID 가 없어도 행 삭제되게 해야한다
                If fileID = "" OrElse [Shared].FileDelete(fileID, fileNm) = True Then

                    g30.AllowDeleteRows = True
                    g30.DeleteRow(g30.RowIndex)
                    g30.AllowDeleteRows = False

                    Me.Save(g30.WorkSet)
                End If
            Catch ex As Exception
                MessageInfo(ex)
            End Try

        End If

        If columnName = "show" Then
            [Shared].FileDownLoad(fileID, fileNm, , True)
        End If

        If columnName = "down" Then
            [Shared].FileDownLoad(fileID, fileNm)
        End If
    End Sub


    Private Sub g30_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles g30.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then

            If Not MyBase.Save() Then
                Exit Sub
            End If

            'Grid내 같은 File명 체크
            For Each fileNm As String In e.Data.GetData(DataFormats.FileDrop)
                fileNm = System.IO.Path.GetFileName(fileNm)
                If Me._IsExists(g30, fileNm) Then
                    If MessageYesNo("이미 같은 파일명을 가진 파일이 존재합니다." + vbLf + vbLf + _
                                    "그래도 Upload 하시겠습니까 ?" + vbLf + vbLf + "[" + fileNm + "]") = MsgBoxResult.No Then
                        Exit Sub
                    End If
                End If
            Next

            'Grid에 선택파일 추가
            Dim fullPath As String
            g30.AllowAddRows = True
            For Each fullPath In e.Data.GetData(DataFormats.FileDrop)

                Dim FileID As String = [Shared].FileUpload("", fullPath)
                'If fullPath <> "" Then
                ' 오류수정: fileID 가 없어면 저장 안되게 해야한다
                If FileID <> "" And fullPath <> "" Then

                    '파일명만 분리
                    Dim fileNm As String = System.IO.Path.GetFileName(fullPath)

                    Dim f As New System.IO.FileInfo(fullPath)
                    g30.AddNewRow()
                    g30.Text("file_id") = FileID
                    g30.Text("file_nm") = fileNm
                    g30.Text("file_size") = f.Length.ToString
                End If

            Next
            g30.AllowAddRows = False

            Me.Save(g30.WorkSet)
            g30.Open()
        End If
    End Sub

    Private Function _IsExists(ByVal g As eGrid, ByVal fileNm As String) As Boolean
        With g
            For i As Integer = 0 To .RowCount - 1
                If .Text("file_nm", i) = fileNm Then
                    Return True
                End If
            Next
        End With
        Return False
    End Function

    Private Sub g30_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles g30.DragOver
        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

#End Region



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
        Dim strUserid2 As String = ""
        Dim parameter As New Base7.Parameter
        strUserid = parameter.Login.EmpNo
        strUserid = fr_emp.Text()
        strUserid2 = parameter.Login.EmpNo
        '   strUserid = fr_rid.Text
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
        'p.Add("@in_wh", in_wh.Text)

        Dim formCd As String = ""
        'Dim document As ReportDocument = Nothing
        Dim dSet As DataSet = Link.ReadDataSet("mma200_Print", p)
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
"    <td width='20%' align='center' height = '18'>자재명/규격</td>" &
"    <td width='8%' align='center' height = '18'>수량</td>" &
"    <td width='5%' align='center' height = '18'>단위</td>" &
"    <td width='10%' align='center' height = '18'>용도구분</td>" &
"    <td width='10%' align='center' height = '18'>지불조건</td>" &
"    <td width='10%' align='center' height = '18'>납품일자</td>" &
"    <td width='' align='center' height = '18'>업체명</td>" &
"  </tr>"
        For i = 0 To dSet.Tables(0).Rows.Count - 1
            dRow = dSet.Tables(0).Rows(i)
            body = body &
      "<tr>" &
    "      <td align='center' height = '18' align = 'left'>&nbsp;&nbsp;" & dRow("part_nm") & "/" & dRow("part_spec") & "</td>" &
    "      <td align='center' height = '18' align = 'right'>" & dRow("req_qty") & "&nbsp;&nbsp;</td>" &
    "      <td align='center' height = '18'>" & dRow("um_nm") & "</td>" &
    "      <td align='center' height = '18'>" & dRow("use_nm") & "</td>" &
    "      <td align='center' height = '18'> </td>" &
    "      <td align='center' height = '18'>" & dRow("dlv_dt") & "</td>" &
    "      <td align='center' height = '18'>" & dRow("cust_nm") & "</td>" &
    "  </tr>"
            'tot_amt = tot_amt + CDec(dRow("tot"))
        Next
        If (dSet.Tables(0).Rows.Count - 1) < 0 Then Exit Sub
        dRow = dSet.Tables(0).Rows(dSet.Tables(0).Rows.Count - 1)

        footer = "" &
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
        dSet2 = Me.OpenDataSet("mma200_html", p2)
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


        Me.Save("mma200_html")
    End Sub

    Private Sub sh_gw_Click(sender As System.Object, e As System.EventArgs) Handles sh_gw.Click
        Dim strUserid As String = ""

        strUserid = Parameter.Login.EmpNo
        strUserid = fr_emp.Text

        Dim p As New OpenParameters
        p.Add("@emp_no", fr_emp.Text)
        p.Add("@app_code", req_no.Text)

        Dim Popup As New MMB100P

        Dim StdURL As String

        Dim dSet As DataSet = OpenDataSet("mma200_get_url", p)

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
