Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

'
'WorkSet : fac560(get_tax_biz, get_biz_info, get_mbiz_info, g30_sum, get_tax_term, get_ele_g10_sum, get_tax_no)
'          fac560_g10, 
'          fac560_g30
'
'

Public Class FAC610
    Private v_OriginDir As String
    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################
    Dim str사업자번호 As String, 사업자번호chk As Integer, v_거래기간 As String, v_수출거래기간 As String, v_신고시작년월 As String, v_신고끝년월 As String, TaxNo As String
    Dim str법인번호 As String
    Dim vPrtdt As String, v_작성일자 As String, vBizCnt As Integer
    Dim v기수 As String, v신고구분 As String, v신고범위 As String, v반기내월순번 As String

    '********매출정보
    Dim strA거래처수 As String, strA세금계산서매수 As String, strA공급가액합계 As String, strA세액합계 As String
    Dim strA주민거래처수 As String, strA주민세금계산서매수 As String, strA주민공급가액합계 As String, strA주민세액합계 As String
    Dim strA총거래처수 As String, strA총세금계산서매수 As String, strA총공급가액 As String, strA총세액 As String

    '********매입정보
    Dim strB거래처수 As String, strB세금계산서매수 As String, strB공급가액합계 As String, strB세액합계 As String
    Dim strB주민거래처수 As String, strB주민세금계산서매수 As String, strB주민공급가액합계 As String, strB주민세액합계 As String
    Dim strB총거래처수 As String, strB총세금계산서매수 As String, strB총공급가액 As String, strB총세액 As String

    Dim iCnt As Integer
    Dim 사업자1 As String, 사업자2 As String

    Dim sFdt As String, sTdt As String

    Dim bc_계산서구분_매입 As String, bc_계산서구분_매출 As String, bc_거래형태_개인 As String

    Private Property 일련번호 As String
    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Init_Form()
    End Sub

    Public Sub Init_Form()
        Me.Get_TaxBc()

        v_OriginDir = System.IO.Directory.GetCurrentDirectory()
        bc_계산서구분_매입 = "FA600100"
        bc_계산서구분_매출 = "FA600200"

        Init_Grid()
    End Sub

    Public Sub Init_Grid()

        With g10
            '    .Clear()
            '    .SetUnboundData()   '내부에 새로운 Unbound Table배열을 만든다
            '    .Add("NO.", "no", InputType.Edit, , AlignType.Center, , , 30)
            '    .Add("CHK", "chk", InputType.Edit, , AlignType.Center, , , 50)
            '    .Add("구분", "data_ty", InputType.Combo, , AlignType.Center, , , 70)
            '    .Add("제출자정보", "tax_off", InputType.Edit, , AlignType.Left, , , 100)
            .AddCombo("data_ty", "A", "표지")
            .AddCombo("data_ty", "B", "내역")
            '    .Add("사업자번호", "biz_no", InputType.Edit, , AlignType.Center, , , 80)
            '    .Add("상호/성명/소재지/업태/업종", "cust_info", InputType.Edit, , , , , 400)
            '    .Add("항목A", "itm_a", InputType.Edit, , , , , 500)
            '    .Sortable = False
            '    .AddFormat("no", ConditionType.Equal, " ", , , , , , Color.Blue)
            '    .AddFormat("chk", ConditionType.Equal, "!BAD!", , , , , , Color.Red)
        End With

        With g20
            '    .Clear()
            '    .SetUnboundData()   '내부에 새로운 Unbound Table배열을 만든다

            '    .Add("NO.", "no", InputType.Edit, , AlignType.Center, , , 30)
            '    .Add("CHK", "chk", InputType.Edit, , AlignType.Center, , , 50)
            '    .Add("구분", "data_ty", InputType.Combo, , AlignType.Center, , , 70)
            .AddCombo("data_ty", "1", "매출자료")
            .AddCombo("data_ty", "2", "매입자료")
            .AddCombo("data_ty", "3", "매출합계")
            .AddCombo("data_ty", "4", "매입합계")
            .AddCombo("data_ty", "5", "전자매출합계")    ' 2010.02.24 김종우 전자매입,매출부분 양식변경
            .AddCombo("data_ty", "6", "전자매입합계")    ' 2010.02.24 김종우 전자매입,매출부분 양식변경
            .AddCombo("data_ty", "7", "표지")
            '    .Add("사업자번호", "biz_no", InputType.Edit, , AlignType.Center, , , 80)
            '    .Add("상호/성명/소재지/업태/업종", "cust_info", InputType.Edit, , , , , 750)
            '    .Add("항목A", "itm_a", InputType.Edit, , , , , 500)
            '    .Sortable = False
            '    .AddFormat("no", ConditionType.Equal, " ", , , , , , Color.Blue)
            '    .AddFormat("chk", ConditionType.Equal, "!BAD!", , , , , , Color.Red)
        End With

        With g30
            '    .Clear()
            '    .SetUnboundData()   '내부에 새로운 Unbound Table배열을 만든다
            '    .Add("NO.", "no", InputType.Edit, , AlignType.Center, , , 30)
            '    .Add("CHK", "chk", InputType.Edit, , AlignType.Center, , , 50)
            '    .Add("구분", "data_ty", InputType.Combo, , AlignType.Center, , , 70)
            '    .Add("제출자정보", "tax_off", InputType.Edit, , AlignType.Left, , , 100)
            .AddCombo("data_ty", "A", "표      지")
            .AddCombo("data_ty", "B", "제출의무자")
            .AddCombo("data_ty", "C", "집계레코드")
            .AddCombo("data_ty", "D", "거래명세서")
            '    .Add("사업자번호", "biz_no", InputType.Edit, , AlignType.Center, , , 80)
            '    .Add("상호/성명/소재지/업태/업종", "cust_info", InputType.Edit, , , , , 400)
            '    .Add("항목A", "itm_a", InputType.Edit, , , , , 500)
            '    .Sortable = False
            '    .AddFormat("no", ConditionType.Equal, " ", , , , , , Color.Blue)
            '    .AddFormat("chk", ConditionType.Equal, "!BAD!", , , , , , Color.Red)
        End With

        With g40
            '    .Clear()
            '    .SetUnboundData()   '내부에 새로운 Unbound Table배열을 만든다

            '    .Add("NO.", "no", InputType.Edit, , AlignType.Center, , , 30)
            '    .Add("CHK", "chk", InputType.Edit, StyleType.Hidden, AlignType.Center, , , 50)
            '    .Add("구분", "data_ty", InputType.Combo, , AlignType.Center, , , 70)
            .AddCombo("data_ty", "ZH", "표지")
            .AddCombo("data_ty", "ZD", "내역")
            .AddCombo("data_ty", "ZT", "집계")
            '    .Add("비고", "rmk", InputType.Edit, , , , , 500)
            '    .Sortable = False
            '    .AddFormat("chk", ConditionType.Equal, "!BAD!", , , , , , Color.Red)
        End With

        With g50
            '    .Clear()
            '    .SetUnboundData()   '내부에 새로운 Unbound Table배열을 만든다

            '    .Add("NO.", "no", InputType.Edit, , AlignType.Center, , , 30)
            '    .Add("CHK", "chk", InputType.Edit, StyleType.Hidden, AlignType.Center, , , 50)
            '    .Add("구분", "data_ty", InputType.Combo, , AlignType.Center, , , 70)
            .AddCombo("data_ty", "HL", "표지")
            .AddCombo("data_ty", "DL", "매출내역")
            .AddCombo("data_ty", "TL", "매입내역")
            '    .Add("비고", "rmk", InputType.Edit, , , , , 500)
            '    .Sortable = False
            '    .AddFormat("chk", ConditionType.Equal, "!BAD!", , , , , , Color.Red)
        End With

        With g60
            '    .Clear()
            '    .SetUnboundData()   '내부에 새로운 Unbound Table배열을 만든다

            '    .Add("NO.", "no", InputType.Edit, , AlignType.Center, , , 30)
            '    .Add("CHK", "chk", InputType.Edit, StyleType.Hidden, AlignType.Center, , , 50)
            '    .Add("구분", "data_ty", InputType.Combo, , AlignType.Center, , , 70)
            .AddCombo("data_ty", "A", "표지")
            .AddCombo("data_ty", "B", "집계")
            .AddCombo("data_ty", "C", "내역")
            '    .Add("비고", "rmk", InputType.Edit, , , , , 500)
            '    .Sortable = False
            '    .AddFormat("chk", ConditionType.Equal, "!BAD!", , , , , , Color.Red)
        End With

        With g70
            '    .Clear()
            '    .SetUnboundData()   '내부에 새로운 Unbound Table배열을 만든다

            '    .Add("NO.", "no", InputType.Edit, , AlignType.Center, , , 30)
            '    .Add("CHK", "chk", InputType.Edit, StyleType.Hidden, AlignType.Center, , , 50)
            '    .Add("구분", "data_ty", InputType.Combo, , AlignType.Center, , , 70)

            .AddCombo("data_ty", "B", "인적사항")
            .AddCombo("data_ty", "C", "집계")
            .AddCombo("data_ty", "D", "내역")
            .AddCombo("data_ty", "A", "표지")
            '    .Add("비고", "rmk", InputType.Edit, , , , , 500)
            '    .Sortable = False
            '    .AddFormat("chk", ConditionType.Equal, "!BAD!", , , , , , Color.Red)
        End With

        With g80
            '    .Clear()
            '    .SetUnboundData()   '내부에 새로운 Unbound Table배열을 만든다

            '    .Add("NO.", "no", InputType.Edit, , AlignType.Center, , , 30)
            '    .Add("CHK", "chk", InputType.Edit, StyleType.Hidden, AlignType.Center, , , 50)
            '    .Add("구분", "data_ty", InputType.Combo, , AlignType.Center, , , 70)

            .AddCombo("data_ty", "17", "집계")
            .AddCombo("data_ty", "18", "공제받지못할매입세액명세서_명세 ")
            .AddCombo("data_ty", "19", "공제받지못할매입세액명세서_공통매입세액안분계산내역")
            .AddCombo("data_ty", "20", "공제받지못할매입세액명세서_공통매입세액정산내역")
            .AddCombo("data_ty", "21", "공제받지못할매입세액명세서_납부세액_환급세액재계산내역")
            '    .Add("비고", "rmk", InputType.Edit, , , , , 500)
            '    .Sortable = False
            '    .AddFormat("chk", ConditionType.Equal, "!BAD!", , , , , , Color.Red)
        End With



    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.New

            Case MenuType.Open
                Open_Form()

            Case MenuType.Save

            Case MenuType.Delete

            Case Else

                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    '######################################################################################
    '##            Open                                                                  ##
    '######################################################################################

    Private Sub New_Form()
        Try

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Sub Open_Form()
        Try

            사업자번호chk = 0

            If Not CheckRequired(bs_cd, tax_year, mon_bc, taxoff_cd, prt_dt) Then Exit Sub
            'If Not epdc560f_f1.CheckBeforeOpen Then Exit Sub

            Me.Open()
            'g10.Editable = False
            'g20.Editable = False
            'g30.Editable = False

            vBizCnt = 0
            'vPrtdt = Replace(Trim(prt_dt.Text), "-", "")
            'vPrtdt = Strn(Replace(Trim(Strn(prt_dt.Text, "")), "-", ""))

            Dim rtn As String = Me.SumData()
            If rtn <> "" Then
                'Me.Cursor = Cursors.Default
                Exit Sub
            End If

            If 사업자번호chk > 0 Then MessageWarning("[사업자번호]가 누락된 거래처가 " & CStr(사업자번호chk) & "건 있습니다.", MsgBoxStyle.Exclamation, "확인")

            'g10.ReadOnlyData = True
            g10.AllowAddRows = False
            g10.Editable = False
            'g20.ReadOnlyData = True
            g20.AllowAddRows = False
            g20.Editable = False
            'g30.ReadOnlyData = False
            g30.AllowAddRows = True
            g30.Editable = False
            g40.AllowAddRows = False
            g40.Editable = False
            g50.AllowAddRows = False
            g50.Editable = False
            g60.AllowAddRows = False
            g60.Editable = False
            g70.AllowAddRows = False
            g70.Editable = False
            g80.AllowAddRows = False
            g80.Editable = False
            g90.AllowAddRows = False
            g90.Editable = False
        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    '######################################################################################
    '##            Save                                                                  ##
    '######################################################################################

    Private Function Save_Form() As Boolean

        '        Dim ID As String = asset_id.Text
        Try

            '            If MyBase.Save() Then
            '                If ID = "" Then
            '                    f_asset_id.Text = asset_id.Text
            '                    Me.Open()
            '                Else
            '                    Form_Open()
            '                End If
            '            Else
            '                If ID = "" Then asset_id.Text = ""
            '            End If

        Catch ex As Exception
            '            If ID = "" Then asset_id.Text = ""
            '저장에 실패했으면 코드 채번을 반드시 취소한다
            MessageError(ex)
        End Try
    End Function


    '######################################################################################
    '##            사용자정의                                                            ##
    '######################################################################################

    '######################################################################################
    '##             Procedure                                                            ##
    '######################################################################################
    Private Function SumData() As String
        Try

            Dim sErr As String

            Dim dSet As DataSet = Rtn_dSet("get_tax_bc", bs_cd.Text, tax_kd.Text)

            'Dim oParams As Object = Nothing
            'AddParam(oParams, "@std_year", std_year.Text)
            'AddParam(oParams, "@term_ty", term_ty.Text)
            'AddParam(oParams, "@bs_cd", bs_cd.Text)
            'AddParam(oParams, "@bill_ty", bill_ty.Text)

            'Dim dSet As DataSet = Open(Me.Name, "get_tax_biz", oParams) '1. 

            If IsEmpty(dSet) Then
                '부가세집계 자료가 없습니다.
                MessageWarning("부가세집계 자료가 없습니다.")
                Return ""
            End If

            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = DataSetRows(dSet)

            If dRows.Count = 0 Then
                MessageWarning("부가세집계 자료가 없습니다.")
                Return ""
            End If

            g10.AllowAddRows = True
            g10.Editable = True
            g20.AllowAddRows = True
            g20.Editable = True
            g30.AllowAddRows = True
            g30.Editable = True
            g40.AllowAddRows = True
            g40.Editable = True
            g50.AllowAddRows = True
            g50.Editable = True
            g60.AllowAddRows = True
            g60.Editable = True
            g70.AllowAddRows = True
            g70.Editable = True
            g80.AllowAddRows = True
            g80.Editable = True
            g90.AllowAddRows = True
            g90.Editable = True
            '---------------
            '계산서표지
            '---------------
            Me.dTaxRecA()       '2. 본사정보
            '     Exit Function
            iCnt = 0
            vBizCnt = 0
            Dim BsCd As String = ""
            For Each dRow In dRows

                '---------------------------------
                '사업장별 세금계산서표지
                '사업장별 계산서B레코드
                ' ME.CONVER에서 처리됨
                '---------------------------------
                BsCd = dRow("bs_cd")
                vBizCnt += 1
                sErr = Me.Cover(BsCd)     '3. 사업장정보..표지


                If sErr <> "" Then
                    Return sErr
                End If

                If tax_kd.Text = "" Or tax_kd.Text = bc_계산서구분_매출 Then
                    '매출자료생성
                    sErr = Me.InOutData(bc_계산서구분_매출, BsCd)     '' 4. 매출자료생성
                    If sErr <> "" Then
                        Return sErr
                    End If
                End If

                If tax_kd.Text = "" Or tax_kd.Text = bc_계산서구분_매입 Then
                    '매입자료생성
                    sErr = Me.InOutData(bc_계산서구분_매입, BsCd)     '' 5. 매입자료생성
                    If sErr <> "" Then
                        Return sErr
                    End If
                End If

                'Me.dTaxRecC(bill_ty.Text, dRow("bs_cd"))
                'Me.dTaxRecD(bill_ty.Text, dRow("bs_cd"))

                ''---------------------------------
                ''계산서 C/D 레코드
                ''---------------------------------
                If tax_kd.Text = "" Or tax_kd.Text = bc_계산서구분_매출 Then
                    Me.dTaxRecC(bc_계산서구분_매출, BsCd)
                    Me.dTaxRecD(bc_계산서구분_매출, BsCd)
                End If

                If tax_kd.Text = "" Or tax_kd.Text = bc_계산서구분_매입 Then
                    Me.dTaxRecC(bc_계산서구분_매입, BsCd)
                    Me.dTaxRecD(bc_계산서구분_매입, BsCd)
                End If

                '수출명세서
                Me.수출명세서dTaxRecB(tax_kd.Text, BsCd)
                Me.수출명세서dTaxRecC(tax_kd.Text, BsCd)

                Me.매입세액불공제dTaxRec17(tax_kd.Text, BsCd)
                Me.매입세액불공제dTaxRec18(tax_kd.Text, BsCd)

                '영세율첨부서류dTaxRecZD()
                'Me.영세율첨부서류dTaxRecZD(tax_kd.Text, BsCd)
                'Me.영세율첨부서류dTaxRecZT(tax_kd.Text, BsCd)

                '신용카드매출수취명세서
                'Me.신용카드매출수취명세서dTaxRecDL(tax_kd.Text, BsCd) '매출
                Me.신용카드매출수취명세서dTaxRecTL(tax_kd.Text, BsCd)  '매입

                '건물등감가상각취득명세서
                Me.건물등감가상각취득명세서dTaxRec17(tax_kd.Text, BsCd)
            Next

        Catch ex As Exception
            MessageError(ex, "SumData()")
        End Try
        Return ""
    End Function

    Private Function GetText(ByVal dSet As DataSet, ByVal colNm As String, ByVal len As Integer) As String
        Dim val As String = DataValue(dSet, colNm)
        Return GetLenText(val, len)
    End Function

    Private Function GetText(ByVal dRow As DataRow, ByVal colNm As String, ByVal len As Integer) As String
        Dim val As String = dRow(colNm)
        Return GetLenText(val, len)
    End Function

    Private Function GetLenText(ByVal val As String, ByVal len As Integer) As String
        If len <= 0 Then
            Return ""
        End If
        Dim i As Integer, tmp As String = val
        If len < HLen(val) Then
            For i = val.Length To 0 Step -1
                tmp = val.Substring(0, i)
                If HLen(tmp) <= len Then
                    Exit For
                End If
            Next
        End If
        'Return tmp & Space(len - HLen(tmp))
        Dim strtmp As String = Nothing
        strtmp = tmp ' & Space(len - HLen(tmp))
        For i = HLen(tmp) To len
            If len = HLen(strtmp) Then
                Exit For
            Else
                strtmp = strtmp & " "
            End If
        Next
        HLen(strtmp)
        Return strtmp
    End Function

    '세금계산서 CONVER , 계산서B레코드
    Private Function Cover(ByVal bizCd As String) As String
        Dim sCover As String = ""
        Try
            Dim str상호성명 As String = "", str사업장 As String = ""
            Dim str상호성명2 As String = "", str상호성명3 As String = "", str사업장2 As String = "", str사업장3 As String = ""
            Dim strItemA As String = ""
            Dim strErr As String = ""

            Dim dSet As DataSet = Rtn_dSet("get_biz_info", bizCd)
            'Dim oParams As Object = Nothing
            'AddParam(oParams, "@bs_cd", bizCd)
            'Dim dSet As DataSet = Open(Me.Name, "get_biz_info", oParams)    ' 3. 사업장정보..표지

            If IsEmpty(dSet) Then
                Return "사업장정보테이블(BCC200)에 접속할 수 없습니다." 'Msg("DC560_3") ' "사업장정보테이블(EPDZ200T)에 접속할 수 없습니다."
                'Exit Function
            End If

            str사업자번호 = ""
            Dim BsNo As String = Replace(Trim(DataValue(dSet, "biz_no")), "-", "")

            '사업자번호 길이 체크(데이타에 '-'가 입력될 수 있으므로 REPLACE 시킨다.)
            If HLen(BsNo) = 10 Then
                str사업자번호 = BsNo
            Else
                str사업자번호 = BsNo
                sCover = "[사업자번호]에 오류가 발생하였습니다." 'Msg("DC560_4")
                ' 
                strErr &= "[사업장 사업자번호 길이 :" & HLen(BsNo) & "]"
                'strErr &= Msg("DC560_5") & HLen(Replace(Trim(dSet.Tables(0).Rows(0)("bs_cd")), "-", ""))
            End If

            If DataValue(dSet, "bs_nm") = "" Then strErr &= "[상호명 공란]" 'strErr &= Msg("DC560_6")
            If DataValue(dSet, "ceo_nm") = "" Then strErr &= "[대표자성명 공란]" 'strErr &= Msg("DC560_7")
            If DataValue(dSet, "addr_prt") = "" Then strErr &= "[사업장소재지 공란]" 'strErr &= Msg("DC560_8")
            If DataValue(dSet, "biz_type") = "" Then strErr &= "[업태 공란]" 'strErr &= Msg("DC560_9")
            If DataValue(dSet, "biz_kind") = "" Then strErr &= "[업종 공란]" 'strErr &= Msg("DC560_10")

            '--------------------------------------------------------------------------------------
            '셰금게산서
            '9 - 숫자, X - 문자 / biz_ty = 업태, biz_kd = 업종
            '  구분  사업자등록번호  상호    성명   소재지 업태   업종  거래기간 작성일자 공란
            '--------------------------------------------------------------------------------------
            '  9(1)-"7"  9(10)      X(30)   X(15)   X(45)  X(17)  X(25)   9(12)    9(6)   X(9)
            str상호성명 = GetText(dSet, "bs_nm", 30) & GetText(dSet, "ceo_nm", 15) & _
                          GetText(dSet, "addr_prt", 45) & GetText(dSet, "biz_type", 17) & _
                          GetText(dSet, "biz_kind", 25)



            '--------------------------------------------------------------------------------------
            '계산서 - 법인명(상호), 대표자, 우편번호, 주소
            '--------------------------------------------------------------------------------------
            '  9(1)-"7"  9(10)      X(30)   X(15)   X(45)  X(17)  X(25)   9(12)    9(6)   X(9)
            str상호성명2 = GetText(dSet, "bs_nm", 40) & _
                            GetText(dSet, "ceo_nm", 30) & GetText(dSet, "zip_cd", 10) & _
                            GetText(dSet, "addr_prt", 70)

            Dim strTaxoff As String

            '[자료관리번호] - 세무서, 일련번호(6)
            strTaxoff = GetLenText(TaxNo, 3) + Format(vBizCnt, "0#####")

            '[전체]
            str사업장 = "7" + str사업자번호 + str상호성명 + v_거래기간 + Space(9)

            '[ 세금계산서전산매체자료생성 ]
            iCnt = 0

            With g20
                iCnt = .RowCount
                .AddNewRow()

                .Text("no", iCnt) = " "

                If HLen(str사업장) = 170 Then
                    .Text("chk", iCnt) = "!OK!"
                Else
                    .Text("chk", iCnt) = "!BAD!"
                End If

                .Text("data_ty", iCnt) = "7"
                .Text("bs_no", iCnt) = str사업자번호
                .Text("cust_info", iCnt) = str상호성명
                .Text("itm_a", iCnt) = str사업장 & "@" 'v_거래기간 + Space(9) + "P"
                '.AllowAddRows = False
            End With
            '                                   1: 세무대리인, 2: 법인, 3:개인

            '[ 계산서전산매체자료생성 ]
            strItemA = "B" + strTaxoff & str사업자번호 & _
                        GetText(dSet, "bs_nm", 40) & GetText(dSet, "ceo_nm", 30) & _
                        GetText(dSet, "zip_cd", 10) & GetText(dSet, "addr_prt", 70) & Space(60)

            With g30
                iCnt = .RowCount
                .AddNewRow()

                .Text("no", iCnt) = " "

                If HLen(strItemA) = 230 Then
                    .Text("chk", iCnt) = "!OK!"
                Else
                    .Text("chk", iCnt) = "!BAD!"
                End If

                .Text("data_ty", iCnt) = "B"
                .Text("tax_off", iCnt) = strTaxoff
                .Text("bs_no", iCnt) = str사업자번호
                .Text("cust_info", iCnt) = str상호성명
                .Text("itm_a", iCnt) = strItemA & "@"
                '.AllowAddRows = False
            End With

            str상호성명2 = GetText(dSet, "bs_nm", 30) & GetText(dSet, "ceo_nm", 30) & GetText(dSet, "zip_cd", 10) & GetText(dSet, "addr_prt", 70)

            '[자료관리번호] - 세무서, 일련번호(6)
            strTaxoff = GetLenText(TaxNo, 3) + Format(vBizCnt, "0#####")


            strItemA = "ZH" & tax_year.Text & v신고구분 & v반기내월순번 & GetLenText(str사업자번호, 10) & GetText(dSet, "bs_nm", 60) & _
                       GetText(dSet, "ceo_nm", 30) & GetLenText(Replace(Trim(DataValue(dSet, "biz_no")), "-", ""), 13) & _
                       GetLenText(v_작성일자, 8) & GetLenText(Replace(Trim(DataValue(dSet, "tel")), "-", ""), 12) & Space(59)
            '영세율첨부서류
            iCnt = 0
            With g40
                iCnt = .RowCount
                .AddNewRow()

                .Text("no", iCnt) = " "

                If HLen(strItemA) = 200 Then
                    .Text("chk", iCnt) = "!OK!"
                Else
                    .Text("chk", iCnt) = "!BAD!"
                End If

                .Text("data_ty", iCnt) = "ZH"
                .Text("tax_off", iCnt) = strTaxoff
                .Text("bs_no", iCnt) = str사업자번호
                .Text("cust_info", iCnt) = str상호성명2
                .Text("itm_a", iCnt) = strItemA & "@"
                '.AllowAddRows = False
            End With

            strItemA = "HL" & tax_year.Text & v신고구분 & v반기내월순번 & GetLenText(str사업자번호, 10) & GetText(dSet, "bs_nm", 60) & _
                      GetText(dSet, "ceo_nm", 30) & GetLenText(Replace(Trim(DataValue(dSet, "biz_no")), "-", ""), 13) & _
                      GetLenText(v_작성일자, 8) & Space(11)
            '신용카드매출
            iCnt = 0
            With g50
                iCnt = .RowCount
                .AddNewRow()

                .Text("no", iCnt) = " "

                If HLen(strItemA) = 140 Then
                    .Text("chk", iCnt) = "!OK!"
                Else
                    .Text("chk", iCnt) = "!BAD!"
                End If

                .Text("data_ty", iCnt) = "HL"
                .Text("tax_off", iCnt) = strTaxoff
                .Text("bs_no", iCnt) = str사업자번호
                .Text("cust_info", iCnt) = str상호성명2
                .Text("itm_a", iCnt) = strItemA
                '.AllowAddRows = False
            End With

            '[ 수출명세서 ]
            Me.수출명세서dTaxRecA()

            If HLen(str사업장) <> 230 Then strErr &= "[A레코드 총길이 오류 :" & HLen(str사업장) & "]" 'strErr &= Msg("CV800_16") & " :" & HLen(str사업장)

            '[ 오류자료 ]
            iCnt = 0

            If strErr <> "" Then
                With g70
                    iCnt = .RowCount
                    .AddNewRow()

                    .Text("no", iCnt) = " "
                    .Text("chk", iCnt) = "!BAD!"
                    .Text("data_ty", iCnt) = "7"
                    .Text("rmk", iCnt) = "표지 :" & strErr
                    '.AllowAddRows = False
                End With
            End If

            '사업장 별부가가치세 과세표준및 납부세액(환급세액)신고명세서 세부
            '  상호(법인명)X(60)   성명(대표자명)X(30)  사업장소재지 X(70)
            str상호성명3 = GetText(dSet, "bs_nm", 60) & GetText(dSet, "ceo_nm", 30) & GetText(dSet, "addr_prt", 70)
            '시작부분"11", 서식코드"V150" , 사업자등록번호X(10), 상호(법인명)X(60)   성명(대표자명)X(30)  사업장소재지 X(70)

            Dim str자료구분 As String = "", str서식코드 As String = "", str납세자ID As String = "", str세목구분코드 As String = ""
            Dim str신고구분 As String = "", str납세자구분 As String = "", str과세기간 As String = "", str신고차수 As String = ""
            Dim str순차번호 As String = "1", str사용자ID As String = "", str납세자번호 As String = "", str세무대리인성명 As String = ""
            Dim str세무대리인관리번호 As String = "", str세무대리인전화번호 As String = "", str상호 As String = "", str성명 As String = ""
            Dim str사업장소재지 As String = "", str사업장전화번호 As String = "", str사업자주소 As String = "", str사업자전화번호 As String = ""
            Dim str업태명 As String = "", str종목명 As String = "", str업종코드 As String = "", str과세시작일 As String = ""
            Dim str과세종료일 As String = "", str작성일자 As String = "", str개업년월일 As String = "", str보정신고구분 As String = ""
            Dim str사업자휴대전호 As String = "", str세무프로그램코드 As String = "", str세무대리인사업자번호 As String = "", str전자메일주소 As String = "", str신고종류구분코드 As String = ""

            dSet = Rtn_dSet("g10_sum", bizCd)

            str자료구분 = GetText(dSet, "자료구분", 2)
            str서식코드 = GetText(dSet, "서식코드", 4)
            str납세자ID = Replace(GetText(dSet, "납세자ID", 20), "-", "")
            str세목구분코드 = GetText(dSet, "세목구분코드", 2)
            str신고구분 = GetText(dSet, "신고구분", 1)
            str납세자구분 = GetText(dSet, "납세자구분", 1)
            str과세기간 = Replace(GetText(dSet, "과세기간", 10), "-", "")
            str신고차수 = GetText(dSet, "신고차수", 4)
            str순차번호 = MultiKey(4, ToDec(GetText(dSet, "순차번호", 4)))
            str사용자ID = GetText(dSet, "사용자ID", 20)
            str납세자번호 = Replace(GetText(dSet, "납세자번호", 20), "-", "")
            str세무대리인성명 = GetText(dSet, "세무대리인성명", 30)
            str세무대리인관리번호 = GetText(dSet, "세무대리인관리번호", 6)
            str세무대리인전화번호 = Replace(GetText(dSet, "세무대리인전화번호", 20), "-", "")
            str상호 = GetText(dSet, "상호", 30)
            str성명 = GetText(dSet, "성명", 30)
            str사업장소재지 = GetText(dSet, "사업장소재지", 70)
            str사업장전화번호 = Replace(GetText(dSet, "사업장전화번호", 20), "-", "")
            str사업자주소 = GetText(dSet, "사업자주소", 70)
            str사업자전화번호 = Replace(GetText(dSet, "사업자전화번호", 20), "-", "")
            str업태명 = GetText(dSet, "업태명", 30)
            str종목명 = GetText(dSet, "종목명", 50)
            str업종코드 = GetText(dSet, "업종코드", 7)
            str과세시작일 = Replace(GetText(dSet, "과세시작일", 10), "-", "")
            str과세종료일 = Replace(GetText(dSet, "과세종료일", 10), "-", "")
            str작성일자 = Replace(GetText(dSet, "작성일자", 10), "-", "")
            str개업년월일 = Replace(GetText(dSet, "개업년월일", 10), "-", "")
            str보정신고구분 = GetText(dSet, "보정신고구분", 1)
            str사업자휴대전호 = Replace(GetText(dSet, "사업자휴대전호", 20), "-", "")
            str세무프로그램코드 = GetText(dSet, "세무프로그램코드", 4)
            str세무대리인사업자번호 = Replace(GetText(dSet, "세무대리인사업자번호", 20), "-", "")
            str전자메일주소 = GetText(dSet, "전자메일주소", 50)
            str신고종류구분코드 = GetText(dSet, "신고종류구분코드", 50)
            '총길이 (600)
            strItemA = GetLenText(str자료구분, 2) & _
                       GetLenText(str서식코드, 4) & _
                       GetLenText(str납세자ID, 13) & _
                       GetLenText(str세목구분코드, 2) & _
                       GetLenText(str신고구분, 1) & _
                       GetLenText(str납세자구분, 1) & _
                       GetLenText(str과세기간, 6) & _
                       GetLenText(str신고차수, 4) & _
                       GetLenText(str순차번호, 4) & _
                       GetLenText(str사용자ID, 20) & _
                       GetLenText(str납세자번호, 13) & _
                       GetLenText(str세무대리인성명, 30) & _
                       GetLenText(str세무대리인관리번호, 6) & _
                       GetLenText(str세무대리인전화번호, 14) & _
                       GetLenText(str상호, 30) & _
                       GetLenText(str성명, 30) & _
                       GetLenText(str사업장소재지, 70) & _
                       GetLenText(str사업장전화번호, 14) & _
                       GetLenText(str사업장소재지, 70) & _
                       GetLenText(str사업장전화번호, 14) & _
                       GetLenText(str업태명, 30) & _
                       GetLenText(str종목명, 50) & _
                       GetLenText(str업종코드, 7) & _
                       GetLenText(str과세시작일, 8) & _
                       GetLenText(str과세종료일, 8) & _
                       GetLenText(str작성일자, 8) & _
                       GetLenText(str개업년월일, 8) & _
                       GetLenText(str보정신고구분, 1) & _
                       GetLenText(str사업자휴대전호, 14) & _
                       GetLenText(str세무프로그램코드, 4) & _
                       GetLenText(str세무대리인사업자번호, 10) & _
                       GetLenText(str전자메일주소, 50) & _
                       GetLenText(str신고종류구분코드, 3) & _
                       Space(51)

            With g10
                iCnt = .RowCount
                .AddNewRow()

                .Text("no", iCnt) = " "
                If HLen(strItemA) = 600 Then
                    .Text("chk", iCnt) = "!OK!"
                Else
                    .Text("chk", iCnt) = "!BAD!"
                End If
                .Text("data_ty", iCnt) = "A"
                .Text("biz_no", iCnt) = str사업자번호
                .Text("cust_info", iCnt) = str상호성명3
                .Text("itm_a", iCnt) = strItemA & "@"
                '.AllowAddRows = False
            End With

            Dim g10_자료구분 As String = "", g10_서식코드 As String = "", g10_amt3 As String = "", g10_amt4 As String = "", g10_amt5 As String = "", g10_amt6 As String = "", g10_amt7 As String = "", g10_amt8 As String = "", g10_amt9 As String = "", g10_amt10 As String = ""
            Dim g10_amt11 As String = "", g10_amt12 As String = "", g10_amt13 As String = "", g10_amt14 As String = "", g10_amt15 As String = "", g10_amt16 As String = "", g10_amt17 As String = "", g10_amt18 As String = "", g10_amt19 As String = "", g10_amt20 As String = ""
            Dim g10_amt21 As String = "", g10_amt22 As String = "", g10_amt23 As String = "", g10_amt24 As String = "", g10_amt25 As String = "", g10_amt26 As String = "", g10_amt27 As String = "", g10_amt28 As String = "", g10_amt29 As String = "", g10_amt30 As String = ""
            Dim g10_amt31 As String = "", g10_amt32 As String = "", g10_amt33 As String = "", g10_amt34 As String = "", g10_amt35 As String = "", g10_amt36 As String = "", g10_amt37 As String = "", g10_amt38 As String = "", g10_amt39 As String = "", g10_amt40 As String = ""
            Dim g10_amt41 As String = "", g10_amt42 As String = "", g10_amt43 As String = "", g10_amt44 As String = "", g10_amt45 As String = "", g10_amt46 As String = "", g10_amt47 As String = "", g10_amt48 As String = "", g10_amt49 As String = "", g10_amt50 As String = ""
            Dim g10_amt51 As String = "", g10_amt52 As String = "", g10_환급구분 As String = "", g10_amt54 As String = "", g10_amt55 As String = "", g10_amt56 As String = "", g10_amt57 As String = "", g10_amt58 As String = "", g10_amt59 As String = "", g10_amt60 As String = ""
            Dim g10_amt61 As String = "", g10_amt62 As String = "", g10_amt63 As String = "", g10_amt64 As String = "", g10_amt65 As String = "", g10_amt66 As String = "", g10_amt67 As String = "", g10_amt68 As String = "", g10_amt69 As String = "", g10_amt70 As String = ""
            Dim g10_amt71 As String = "", g10_amt72 As String = "", g10_amt73 As String = "", g10_amt74 As String = "", g10_amt75 As String = "", g10_amt76 As String = "", g10_amt77 As String = "", g10_amt78 As String = "", g10_amt79 As String = "", g10_은행코드 As String = ""
            Dim g10_계좌번호 As String = "", g10_총괄납부승인번호 As String = "", g10_은행지점명 As String = "", g10_amt84 As String = "", g10_폐업일자 As String = "", g10_폐업사유 As String = "", g10_기한부여부 As String = "", g10_amt88 As String = "", g10_amt89 As String = "", g10_amt90 As String = ""
            Dim g10_amt91 As String = "", g10_amt92 As String = "", g10_amt93 As String = "", g10_amt94 As String = "", g10_amt95 As String = "", g10_amt96 As String = "", g10_amt97 As String = "", g10_amt98 As String = "", g10_amt99 As String = "", g10_amt100 As String = ""
            Dim g10_amt101 As String = "", g10_일반과세자구분 As String = "", g10_조기환급취소구분 As String = "", g10_amt104 As String = "", g10_amt105 As String = "", g10_amt106 As String = "", g10_amt107 As String = "", g10_amt108 As String = "", g10_amt109 As String = "", g10_amt110 As String = ""
            Dim g10_amt111 As String = "", g10_amt112 As String = "", g10_amt113 As String = "", g10_amt114 As String = "", g10_amt115 As String = "", g10_amt116 As String = "", g10_amt117 As String = "", g10_amt118 As String = ""
            Dim g10_amt119 As String = "", g10_amt120 As String = "", g10_amt121 As String = "", g10_amt122 As String = "", g10_amt123 As String = "", g10_amt124 As String = "", g10_amt125 As String = "", g10_공란 As String = ""

            dSet = Rtn_dSet("fac610_g10", bizCd)

            g10_자료구분 = GetText(dSet, "g10_자료구분", 2)
            g10_서식코드 = GetText(dSet, "g10_서식코드", 4)

            g10_amt3 = MultiKey(15, ToDec(DataValue(dSet, "g10_amt3")))
            g10_amt4 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt4")))
            g10_amt5 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt5")))
            g10_amt6 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt6")))
            g10_amt7 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt7")))
            g10_amt8 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt8")))
            g10_amt9 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt9")))
            g10_amt10 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt10")))
            g10_amt11 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt11")))
            g10_amt12 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt12")))
            g10_amt13 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt13")))
            g10_amt14 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt14")))
            g10_amt15 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt15")))
            g10_amt16 = MultiKey(15, ToDec(DataValue(dSet, "g10_amt16")))
            g10_amt17 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt17")))
            g10_amt18 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt18")))
            g10_amt19 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt19")))
            g10_amt20 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt20")))
            g10_amt21 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt21")))
            g10_amt22 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt22")))
            g10_amt23 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt23")))
            g10_amt24 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt24")))
            g10_amt25 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt25")))
            g10_amt26 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt26")))
            g10_amt27 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt27")))
            g10_amt28 = MultiKey(15, ToDec(DataValue(dSet, "g10_amt28")))
            g10_amt29 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt29")))
            g10_amt30 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt30")))
            g10_amt31 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt31")))
            g10_amt32 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt32")))
            g10_amt33 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt33")))
            g10_amt34 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt34")))
            g10_amt35 = MultiKey(15, ToDec(DataValue(dSet, "g10_amt35")))
            g10_amt36 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt36")))
            g10_amt37 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt37")))
            g10_amt38 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt38")))
            g10_amt39 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt39")))
            g10_amt40 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt40")))
            g10_amt41 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt41")))
            g10_amt42 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt42")))
            g10_amt43 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt43")))
            g10_amt44 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt44")))
            g10_amt45 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt45")))
            g10_amt46 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt46")))
            g10_amt47 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt47")))
            g10_amt48 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt48")))
            g10_amt49 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt49")))
            g10_amt50 = MultiKey(15, ToDec(DataValue(dSet, "g10_amt50")))
            g10_amt51 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt51")))
            g10_amt52 = MultiKey(15, ToDec(DataValue(dSet, "g10_amt52")))
            g10_환급구분 = GetText(dSet, "g10_환급구분", 1)
            g10_amt54 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt54")))
            g10_amt55 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt55")))
            g10_amt56 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt56")))
            g10_amt57 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt57")))
            g10_amt58 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt58")))
            g10_amt59 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt59")))
            g10_amt60 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt60")))
            g10_amt61 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt61")))
            g10_amt62 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt62")))
            g10_amt63 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt63")))
            g10_amt64 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt64")))
            g10_amt65 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt65")))
            g10_amt66 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt66")))
            g10_amt67 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt67")))
            g10_amt68 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt68")))
            g10_amt69 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt69")))
            g10_amt70 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt70")))
            g10_amt71 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt71")))
            g10_amt72 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt72")))
            g10_amt73 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt73")))
            g10_amt74 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt74")))
            g10_amt75 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt75")))
            g10_amt76 = MultiKey(15, ToDec(DataValue(dSet, "g10_amt76")))
            g10_amt77 = MultiKey(15, ToDec(DataValue(dSet, "g10_amt77")))
            g10_amt78 = MultiKey(15, ToDec(DataValue(dSet, "g10_amt78")))
            g10_amt79 = MultiKey(15, ToDec(DataValue(dSet, "g10_amt79")))
            g10_은행코드 = GetText(dSet, "g10_은행코드", 3)
            g10_계좌번호 = GetText(dSet, "g10_계좌번호", 20)
            g10_총괄납부승인번호 = GetText(dSet, "g10_총괄납부승인번호", 7)
            g10_은행지점명 = GetText(dSet, "g10_은행지점명", 30)
            g10_amt84 = MultiKey(15, ToDec(DataValue(dSet, "g10_amt84")))
            g10_폐업일자 = GetText(dSet, "g10_폐업일자", 8)
            g10_폐업사유 = GetText(dSet, "g10_폐업사유", 3)
            g10_기한부여부 = GetText(dSet, "g10_기한부여부", 1)
            g10_amt88 = MultiKey(15, ToDec(DataValue(dSet, "g10_amt88")))
            g10_amt89 = MultiKey(15, ToDec(DataValue(dSet, "g10_amt89")))
            g10_amt90 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt90")))
            g10_amt91 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt91")))
            g10_amt92 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt92")))
            g10_amt93 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt93")))
            g10_amt94 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt94")))
            g10_amt95 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt95")))
            g10_amt96 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt96")))
            g10_amt97 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt97")))
            g10_amt98 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt98")))
            g10_amt99 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt99")))
            g10_amt100 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt100")))
            g10_amt101 = MultiKey(15, ToDec(DataValue(dSet, "g10_amt101")))
            g10_일반과세자구분 = GetText(dSet, "g10_일반과세자구분", 1)
            g10_조기환급취소구분 = GetText(dSet, "g10_조기환급취소구분", 1)
            g10_amt104 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt104")))
            g10_amt105 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt105")))
            g10_amt106 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt106")))
            g10_amt107 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt107")))
            g10_amt108 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt108")))
            g10_amt109 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt109")))
            g10_amt110 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt110")))
            g10_amt111 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt111")))
            g10_amt112 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt112")))
            g10_amt113 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt113")))
            g10_amt114 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt114")))
            g10_amt115 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt115")))
            g10_amt116 = MultiKey(15, ToDec(DataValue(dSet, "g10_amt116")))
            g10_amt117 = MultiKey(15, ToDec(DataValue(dSet, "g10_amt117")))
            g10_amt118 = MultiKey(15, ToDec(DataValue(dSet, "g10_amt118")))
            g10_amt119 = MultiKey(15, ToDec(DataValue(dSet, "g10_amt119")))
            g10_amt120 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt120")))
            g10_amt121 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt121")))
            g10_amt122 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt122")))
            g10_amt123 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt123")))
            g10_amt124 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt124")))
            g10_amt125 = MultiKey(13, ToDec(DataValue(dSet, "g10_amt125")))
            g10_공란 = GetText(dSet, "g10_공란", 14)

            '총길이 (1600)
            strItemA = GetLenText(g10_자료구분, 2) & _
                       GetLenText(g10_서식코드, 4) & _
                       GetLenText(g10_amt3, 15) & _
                       GetLenText(g10_amt4, 13) & _
                       GetLenText(g10_amt5, 13) & _
                       GetLenText(g10_amt6, 13) & _
                       GetLenText(g10_amt7, 13) & _
                       GetLenText(g10_amt8, 13) & _
                       GetLenText(g10_amt9, 13) & _
                       GetLenText(g10_amt10, 13) & _
                       GetLenText(g10_amt11, 13) & _
                       GetLenText(g10_amt12, 13) & _
                       GetLenText(g10_amt13, 13) & _
                       GetLenText(g10_amt14, 13) & _
                       GetLenText(g10_amt15, 13) & _
                       GetLenText(g10_amt16, 15) & _
                       GetLenText(g10_amt17, 13) & _
                       GetLenText(g10_amt18, 13) & _
                       GetLenText(g10_amt19, 13) & _
                       GetLenText(g10_amt20, 13) & _
                       GetLenText(g10_amt21, 13) & _
                       GetLenText(g10_amt22, 13) & _
                       GetLenText(g10_amt23, 13) & _
                       GetLenText(g10_amt24, 13) & _
                       GetLenText(g10_amt25, 13) & _
                       GetLenText(g10_amt26, 13) & _
                       GetLenText(g10_amt27, 13) & _
                       GetLenText(g10_amt28, 15) & _
                       GetLenText(g10_amt29, 13) & _
                       GetLenText(g10_amt30, 13) & _
                       GetLenText(g10_amt31, 13) & _
                       GetLenText(g10_amt32, 13) & _
                       GetLenText(g10_amt33, 13) & _
                       GetLenText(g10_amt34, 13) & _
                       GetLenText(g10_amt35, 15) & _
                       GetLenText(g10_amt36, 13) & _
                       GetLenText(g10_amt37, 13) & _
                       GetLenText(g10_amt38, 13) & _
                       GetLenText(g10_amt39, 13) & _
                       GetLenText(g10_amt40, 13) & _
                       GetLenText(g10_amt41, 13) & _
                       GetLenText(g10_amt42, 13) & _
                       GetLenText(g10_amt43, 13) & _
                       GetLenText(g10_amt44, 13) & _
                       GetLenText(g10_amt45, 13) & _
                       GetLenText(g10_amt46, 13) & _
                       GetLenText(g10_amt47, 13) & _
                       GetLenText(g10_amt48, 13) & _
                       GetLenText(g10_amt49, 13) & _
                       GetLenText(g10_amt50, 15) & _
                       GetLenText(g10_amt51, 13) & _
                       GetLenText(g10_amt52, 15) & _
                       GetLenText(g10_환급구분, 1) & _
                       GetLenText(g10_amt54, 13) & _
                       GetLenText(g10_amt55, 13) & _
                       GetLenText(g10_amt56, 13) & _
                       GetLenText(g10_amt57, 13) & _
                       GetLenText(g10_amt58, 13) & _
                       GetLenText(g10_amt59, 13) & _
                       GetLenText(g10_amt60, 13) & _
                       GetLenText(g10_amt61, 13) & _
                       GetLenText(g10_amt62, 13) & _
                       GetLenText(g10_amt63, 13) & _
                       GetLenText(g10_amt64, 13) & _
                       GetLenText(g10_amt65, 13) & _
                       GetLenText(g10_amt66, 13) & _
                       GetLenText(g10_amt67, 13) & _
                       GetLenText(g10_amt68, 13) & _
                       GetLenText(g10_amt69, 13) & _
                       GetLenText(g10_amt70, 13) & _
                       GetLenText(g10_amt71, 13) & _
                       GetLenText(g10_amt72, 13) & _
                       GetLenText(g10_amt73, 13) & _
                       GetLenText(g10_amt74, 13) & _
                       GetLenText(g10_amt75, 13) & _
                       GetLenText(g10_amt76, 15) & _
                       GetLenText(g10_amt77, 15) & _
                       GetLenText(g10_amt78, 15) & _
                       GetLenText(g10_amt79, 15) & _
                       GetLenText(g10_은행코드, 3) & _
                       GetLenText(g10_계좌번호, 20) & _
                       GetLenText(g10_총괄납부승인번호, 7) & _
                       GetLenText(g10_은행지점명, 30) & _
                       GetLenText(g10_amt84, 15) & _
                       GetLenText(g10_폐업일자, 8) & _
                       GetLenText(g10_폐업사유, 3) & _
                       GetLenText(g10_기한부여부, 1) & _
                       GetLenText(g10_amt88, 15) & _
                       GetLenText(g10_amt89, 15) & _
                       GetLenText(g10_amt90, 13) & _
                       GetLenText(g10_amt91, 13) & _
                       GetLenText(g10_amt92, 13) & _
                       GetLenText(g10_amt93, 13) & _
                       GetLenText(g10_amt94, 13) & _
                       GetLenText(g10_amt95, 13) & _
                       GetLenText(g10_amt96, 13) & _
                       GetLenText(g10_amt97, 13) & _
                       GetLenText(g10_amt98, 13) & _
                       GetLenText(g10_amt99, 13) & _
                       GetLenText(g10_amt100, 13) & _
                       GetLenText(g10_amt101, 15) & _
                       GetLenText(g10_일반과세자구분, 1) & _
                       GetLenText(g10_조기환급취소구분, 1) & _
                       GetLenText(g10_amt104, 13) & _
                       GetLenText(g10_amt105, 13) & _
                       GetLenText(g10_amt106, 13) & _
                       GetLenText(g10_amt107, 13) & _
                       GetLenText(g10_amt108, 13) & _
                       GetLenText(g10_amt109, 13) & _
                       GetLenText(g10_amt110, 13) & _
                       GetLenText(g10_amt111, 13) & _
                       GetLenText(g10_amt112, 13) & _
                       GetLenText(g10_amt113, 13) & _
                       GetLenText(g10_amt114, 13) & _
                       GetLenText(g10_amt115, 13) & _
                       GetLenText(g10_amt116, 15) & _
                       GetLenText(g10_amt117, 15) & _
                       GetLenText(g10_amt118, 15) & _
                       GetLenText(g10_amt119, 15) & _
                       GetLenText(g10_amt120, 13) & _
                       GetLenText(g10_amt121, 13) & _
                       GetLenText(g10_amt122, 13) & _
                       GetLenText(g10_amt123, 13) & _
                       GetLenText(g10_amt124, 13) & _
                       GetLenText(g10_amt125, 13) & _
                       GetLenText(g10_공란, 14)

            With g10
                iCnt = .RowCount
                .AddNewRow()

                .Text("no", iCnt) = " "
                If HLen(strItemA) = 1600 Then
                    .Text("chk", iCnt) = "!OK!"
                Else
                    .Text("chk", iCnt) = "!BAD!"
                End If
                .Text("data_ty", iCnt) = "B"
                .Text("biz_no", iCnt) = str사업자번호
                .Text("cust_info", iCnt) = str상호성명3
                .Text("itm_a", iCnt) = strItemA & "@"
                '.AllowAddRows = False
            End With
        Catch ex As Exception
            MessageError(ex, "Cover")
        End Try
        Return sCover
    End Function

#Region "수출명세서"


    '표지부 : A 레코드
    '         사업장의 본사거래처 (MAIN_CHK = '1') 로 구성한다.
    Private Function 수출명세서dTaxRecA() As String
        Dim sCover As String = ""
        Try
            Dim str상호성명 As String = "", str사업장 As String = ""
            Dim strItemA As String = "", strTaxoff As String = ""
            Dim strErr As String = ""

            Dim dSet As DataSet = Rtn_dSet("get_biz_info") 'Open(Me.Name, "get_mbiz_info")    '2. 본사정보

            If IsEmpty(dSet) Then
                Return "본사 사업장정보 테이블(BCC200)에 접속할 수 없습니다." 'Msg("DC560_31")
            End If

            str사업자번호 = ""
            Dim BsNo As String = Replace(Trim(DataValue(dSet, "biz_no")), "-", "")

            '사업자번호 길이 체크(데이타에 '-'가 입력될 수 있으므로 REPLACE 시킨다.)
            If HLen(BsNo) = 10 Then
                str사업자번호 = BsNo
            Else
                str사업자번호 = BsNo
                sCover = "[사업자번호]에 오류가 발생하였습니다." ' Msg("DC560_4")
                ' "[사업자번호]에 오류가 발생하였습니다."& GetLenText(v_거래기간, 16)
                strErr &= "[사업장 사업자번호 길이]" & HLen(BsNo)
                'strErr &= Msg("DC560_5") & HLen(Replace(Trim(dSet.Tables(0).Rows(0)("bs_cd")), "-", ""))
            End If

            If DataValue(dSet, "bs_nm") = "" Then strErr &= "[상호명 공란]" 'strErr &= Msg("DC560_6")
            If DataValue(dSet, "ceo_nm") = "" Then strErr &= "[대표자성명 공란]" 'strErr &= Msg("DC560_7")
            If DataValue(dSet, "addr_prt") = "" Then strErr &= "[사업장소재지 공란]" 'strErr &= Msg("DC560_8")
            If DataValue(dSet, "biz_type") = "" Then strErr &= "[업태 공란]" 'strErr &= Msg("DC560_9")
            If DataValue(dSet, "biz_kind") = "" Then strErr &= "[업종 공란]" 'strErr &= Msg("DC560_10")


            '[자료관리번호] - 세무서, 제출연월일, 제출자-1:세무대리인 , 2:법인, 3:개인, 세무대리관리번호
            strTaxoff = GetLenText(TaxNo, 3) + vPrtdt + "2" + Space(6)

            '[제출자(대리인)] - 법인명 ~ 전화번호
            str상호성명 = GetText(dSet, "bs_nm", 30) & GetText(dSet, "ceo_nm", 15) & GetText(dSet, "addr_prt", 45) & _
                          GetText(dSet, "biz_type", 17) & GetText(dSet, "biz_kind", 25)
            '[제출내역] - 자료구분, 귀속년월, 신고구분(범위), 사업장정보
            strItemA = "A" & GetLenText(v_신고끝년월, 6) & v신고범위 & GetLenText(BsNo, 10) & GetText(dSet, "bs_nm", 30) & GetText(dSet, "ceo_nm", 15) & GetText(dSet, "addr_prt", 45) & _
                          GetText(dSet, "biz_type", 17) & GetText(dSet, "biz_kind", 25) & GetLenText(v_수출거래기간, 16) & GetLenText(v_작성일자, 8) & Space(6)
            '[전체]
            str사업장 = "A" & GetLenText(v_신고끝년월, 6) & v신고범위 & GetLenText(BsNo, 10) & GetText(dSet, "bs_nm", 30) & GetText(dSet, "ceo_nm", 15) & GetText(dSet, "addr_prt", 45) & _
                          GetText(dSet, "biz_type", 17) & GetText(dSet, "biz_kind", 25) & GetLenText(v_수출거래기간, 16) & GetLenText(v_작성일자, 8) & Space(6)

            '[ 계산서전산매체자료생성 ]
            iCnt = 0
            With g60
                .AddNewRow()
                .Text("no", iCnt) = " "

                If HLen(str사업장) = 180 Then
                    .Text("chk") = "!OK!"
                Else
                    .Text("chk") = "!BAD!"
                End If

                .Text("data_ty", iCnt) = "A"
                .Text("tax_off", iCnt) = strTaxoff
                .Text("biz_no", iCnt) = str사업자번호
                .Text("cust_info", iCnt) = str상호성명
                .Text("itm_a", iCnt) = strItemA & "@" '"제출건수" + "101" + Space(15) + "P"
                '.AllowAddRows = False

            End With

            If HLen(str사업장) <> 180 Then strErr &= "[A레코드 총길이 오류 :" & HLen(str사업장) & "]" 'strErr &= Msg("CV800_16") & " :" & HLen(str사업장)

            If strErr <> "" Then

            End If
        Catch ex As Exception
            MessageError(ex, "수출명세서dTaxRecA")
        End Try
        Return sCover
    End Function


    '계산서매출계산서 합계
    Private Sub 수출명세서dTaxRecB(ByVal TaxKd As String, ByVal BizCd As String)
        Dim sInOutData As String = ""
        Try

            Dim str합계건수 As String = "", str합계외화금액 As String = "", str합계원화금액 As String = ""
            Dim str수출건수 As String = "", str수출외화금액 As String = "", str수출원화금액 As String = ""
            Dim str기타건수 As String = "", str기타외화금액 As String = "", str기타원화금액 As String = ""

            '--------------------------------------------------------------------
            '매출 : DataRecordTy - 17 (매출), OutNo - 9001 (프로피디스켓)
            '매입 : DataRecordTy - 18 (매입), OutNo - 9501 (프로피디스켓)
            '--------------------------------------------------------------------

            '--------------------------------------------------------------------
            ' 해당 사업장의 매입 또는 매출자료를 가지고 온다(매입 : D600100, 매출 : D600200)
            ' 레코드 자체를 해당 일자에 거래처별, 사업장별로 가지고 온다
            '--------------------------------------------------------------------
            Dim dRow As DataRow, dRows As DataRowCollection

            Dim dSet As DataSet = Rtn_dSet("g60_sum", bs_cd.Text, TaxKd)
            sInOutData = ""

            dRows = DataSetRows(dSet)

            If dRows.Count = 0 Then
                Me.Cursor = Cursors.Default
                Exit Sub
                'Return ""
            End If

            Dim Amt As Int64 = 0
            For Each dRow In dRows
                'strErr = ""

                '사업자chk = True
                'Amt = ToDec(dRow("p_cnt"))
                str합계건수 = MultiKey(7, ToDec(dRow("p_cnt")))
                'Amt = ToDec(dRow("p_amt"))
                str합계외화금액 = MultiKey(15, ToDec(dRow("p_amt")))
                Amt = ToDec(dRow("p_wamt"))
                str합계원화금액 = MultiKey(15, Amt)

                Amt = ToDec(dRow("cnt"))
                str수출건수 = MultiKey(7, Amt)
                'Amt = ToDec(dRow("amt"))
                str수출외화금액 = MultiKey(15, ToDec(dRow("amt")))
                Amt = ToDec(dRow("wamt"))
                str수출원화금액 = MultiKey(15, Amt)

                'Amt = ToDec(dRow("etc_cnt"))
                str기타건수 = MultiKey(7, ToDec(dRow("etc_cnt")))
                'Amt = ToDec(dRow("etc_amt"))
                str기타외화금액 = MultiKey(15, ToDec(dRow("etc_amt")))
                Amt = ToDec(dRow("etc_wamt"))
                str기타원화금액 = MultiKey(15, Amt)

                'str합계건수 = MultiKey(7, ToDec(dRow("p_cnt")))
                'str합계외화금액 = MultiKey(15, CStr(dRow("p_amt")))
                'str합계원화금액 = MultiKey(15, ToDec(dRow("p_wamt")))

                'str수출건수 = MultiKey(7, ToDec(dRow("cnt")))
                'str수출외화금액 = MultiKey(15, CStr(dRow("amt")))
                'str수출원화금액 = MultiKey(15, ToDec(dRow("wamt")))

                'str기타건수 = MultiKey(7, ToDec(dRow("etc_cnt")))
                'str기타외화금액 = MultiKey(15, CStr(dRow("etc_amt")))
                'str기타원화금액 = MultiKey(15, ToDec(dRow("etc_wamt")))
            Next

            Dim strTaxoff As String
            Dim strItemA As String
            Dim Fullstr As String

            '----------------------------------------
            '자료구분, 기, 신고,세무서,일련번호
            '----------------------------------------
            strTaxoff = "B" + GetLenText(v기수, 1) + GetLenText(v신고구분, 1) + _
                        GetLenText(TaxNo, 3) + Format(vBizCnt, "0#####")

            '----------------------------------------
            '귀속년도, 거래시작, 거래종료, 작성일자
            '----------------------------------------

            If Not IsDate(sFdt) Or Not IsDate(sTdt) Then
                MessageInfo("기초코드(FA680)에서 부가세신고기간을 확인하세요")
                Exit Sub
            End If

            strItemA = "B" & GetLenText(v_신고끝년월, 6) & v신고범위 & GetLenText(str사업자번호, 10) & _
                           GetLenText(str합계건수, 7) & GetLenText(str합계외화금액, 15) & GetLenText(str합계원화금액, 15) & _
                            GetLenText(str수출건수, 7) & GetLenText(str수출외화금액, 15) & GetLenText(str수출원화금액, 15) & _
                              GetLenText(str기타건수, 7) & GetLenText(str기타외화금액, 15) & GetLenText(str기타원화금액, 15) & Space(51)
            Fullstr = strItemA

            '[ 부가세전산매체자료생성 ]
            With g60
                iCnt = .RowCount
                .AddNewRow()

                .Text("no", iCnt) = " "
                '-----------------------------------------------------------------------
                '1-4. 길이가 170이고 사업자등록번호 유무 또는 자리수 10자리 검사
                '-----------------------------------------------------------------------
                If HLen(Fullstr) = 180 Then
                    .Text("chk", iCnt) = "!OK!"
                Else
                    .Text("chk", iCnt) = "!BAD!"
                End If
                .Text("data_ty", iCnt) = "B"
                .Text("tax_off", iCnt) = strTaxoff
                .Text("bs_cd", iCnt) = str사업자번호
                .Text("cust_info", iCnt) = v_거래기간
                .Text("itm_a", iCnt) = strItemA & "@"
            End With

        Catch ex As Exception
            sInOutData = sInOutData + vbLf + Err.Description
            MessageError(ex, "수출명세서B레코드")
        End Try
        'Return sInOutData
    End Sub

    '수출명세서
    Private Sub 수출명세서dTaxRecC(ByVal TaxKd As String, ByVal BizCd As String)
        Try
            Dim 계산서매수T As Double = 0, 금액T As Double = 0, sRmk As String = ""

            Dim seq As Integer = 0
            Dim tseq As String = ""
            Dim str기간 As String = ""
            '--------------------------------------------------------------------
            ' 해당 사업장의 매입 또는 매출자료를 가지고 온다(매입 : D600100, 매출 : D600200)
            ' 레코드 자체를 해당 일자에 거래처별, 사업장별로 가지고 온다
            '--------------------------------------------------------------------
            Dim dSet As DataSet = Rtn_dSet("fac610_g60", bs_cd.Text, TaxKd)
            If IsEmpty(dSet) Then
                Me.Cursor = Cursors.Default
                Exit Sub
            End If


            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = DataSetRows(dSet)
            Dim strTaxoff As String
            '----------------------------------------
            '자료구분, 기, 신고,세무서,일련번호
            '----------------------------------------
            strTaxoff = "C" + GetLenText(v기수, 1) + GetLenText(v신고구분, 1) + _
                         GetLenText(TaxNo, 3)

            Dim strC수출신고번호 As String, strC선적일자 As String, str통화코드 As String, str환율 As String, str외화금액 As String
            Dim str원화금액 As String
            Dim strItemA As String, Fullstr As String = ""

            Dim K As Integer = 0
            Dim 일련번호 As String = ""

            '=====================
            For Each dRow In dRows

                K += 1
                일련번호 = Format(K, "0######")

                strC수출신고번호 = GetLenText(Replace(dRow("note_no"), "-", ""), 15)
                strC선적일자 = GetLenText(Replace(dRow("ship_dt"), "-", ""), 8)
                str통화코드 = GetLenText(dRow("cury_bc"), 3)

                str환율 = MultiKey(9, CStr(dRow("ex_rt")))
                str외화금액 = MultiKey(15, CStr(dRow("amt")))
                str원화금액 = MultiKey(15, ToDec(dRow("wamt")))

                strItemA = "C" & GetLenText(v_신고끝년월, 6) & v신고범위 & GetLenText(str사업자번호, 10) & 일련번호 & _
                            GetLenText(strC수출신고번호, 15) & GetLenText(strC선적일자, 8) & GetLenText(str통화코드, 3) & _
                            GetLenText(str환율, 9) & GetLenText(str외화금액, 15) & GetLenText(str원화금액, 15) & Space(90)

                With g60
                    iCnt = .RowCount
                    .AddNewRow()

                    .Text("no", iCnt) = K
                    Fullstr = strItemA

                    '-----------------------------------------------------------------------
                    '1-4. 길이가 170이고 사업자등록번호 유무 또는 자리수 10자리 검사
                    '-----------------------------------------------------------------------
                    If HLen(Fullstr) = 180 Then
                        .Text("chk", iCnt) = "!OK!"
                    Else
                        .Text("chk", iCnt) = "!BAD!"
                    End If

                    .Text("data_ty", iCnt) = "C"
                    .Text("tax_off", iCnt) = strTaxoff + 일련번호
                    .Text("bs_cd", iCnt) = str사업자번호
                    .Text("itm_a", iCnt) = strItemA & "@"
                End With
            Next

        Catch ex As Exception
            MessageError(ex, "수출명세서C레코드")
        End Try
    End Sub
#End Region

#Region "건물등감가상각취득명세서"
    Private Sub 건물등감가상각취득명세서dTaxRec17(ByVal TaxKd As String, ByVal BizCd As String)
        Try
            Dim 계산서매수T As Double = 0, 금액T As Double = 0, sRmk As String = ""

            Dim seq As Integer = 0
            Dim tseq As String = ""
            Dim str기간 As String = ""
            '--------------------------------------------------------------------
            ' 해당 사업장의 매입 또는 매출자료를 가지고 온다(매입 : D600100, 매출 : D600200)
            ' 레코드 자체를 해당 일자에 거래처별, 사업장별로 가지고 온다
            '--------------------------------------------------------------------
            Dim dSet As DataSet = Rtn_dSet("g90_sum", bs_cd.Text, TaxKd)
            If IsEmpty(dSet) Then
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = DataSetRows(dSet)
            Dim strTaxoff As String
            '----------------------------------------
            '자료구분, 기, 신고,세무서,일련번호
            '----------------------------------------
            strTaxoff = "17" + "V149"

            Dim str건수_합계_고정자산 As String, str공급가액_합계_고정자산 As String, str세액_합계_고정자산 As String
            Dim str건수_건물_구축물 As String, str공급가액_건물_구축물 As String, str세액_건물_구축물 As String
            Dim str건수_기계장치 As String, str공급가액_기계장치 As String, str세액_기계장치 As String
            Dim str건수_차량운반구 As String, str공급가액_차량운반구 As String, str세액_차량운반구 As String
            Dim str건수_기타감가상각 As String, str공급가액_기타감가상각 As String, str세액_기타감가상각 As String
            Dim strItemA As String, Fullstr As String = ""

            '=====================
            For Each dRow In dRows


                str건수_합계_고정자산 = MultiKey(11, ToDec(dRow("sum_cnt")))
                str공급가액_합계_고정자산 = MultiKey(13, ToDec(dRow("sum_amt")))
                str세액_합계_고정자산 = MultiKey(13, ToDec(dRow("sum_vat")))

                str건수_건물_구축물 = MultiKey(11, ToDec(dRow("cnt2")))
                str공급가액_건물_구축물 = MultiKey(13, ToDec(dRow("amt2")))
                str세액_건물_구축물 = MultiKey(13, ToDec(dRow("vat2")))

                str건수_기계장치 = MultiKey(11, ToDec(dRow("cnt4")))
                str공급가액_기계장치 = MultiKey(13, ToDec(dRow("amt4")))
                str세액_기계장치 = MultiKey(13, ToDec(dRow("vat4")))

                str건수_차량운반구 = MultiKey(11, ToDec(dRow("cnt5")))
                str공급가액_차량운반구 = MultiKey(13, ToDec(dRow("amt5")))
                str세액_차량운반구 = MultiKey(13, ToDec(dRow("vat5")))

                str건수_기타감가상각 = MultiKey(11, ToDec(dRow("cnt_rmk")))
                str공급가액_기타감가상각 = MultiKey(13, ToDec(dRow("amt_rmk")))
                str세액_기타감가상각 = MultiKey(13, ToDec(dRow("vat_rmk")))

                strItemA = strTaxoff & GetLenText(str건수_합계_고정자산, 11) & GetLenText(str공급가액_합계_고정자산, 13) & GetLenText(str세액_합계_고정자산, 13) & _
                            GetLenText(str건수_건물_구축물, 11) & GetLenText(str공급가액_건물_구축물, 13) & GetLenText(str세액_건물_구축물, 13) & _
                            GetLenText(str건수_기계장치, 11) & GetLenText(str공급가액_기계장치, 13) & GetLenText(str세액_기계장치, 13) & _
                            GetLenText(str건수_차량운반구, 11) & GetLenText(str공급가액_차량운반구, 13) & GetLenText(str세액_차량운반구, 13) & _
                             GetLenText(str건수_기타감가상각, 11) & GetLenText(str공급가액_기타감가상각, 13) & GetLenText(str세액_기타감가상각, 13) & Space(9)

                With g90

                    iCnt = .RowCount
                    .AddNewRow()

                    .Text("no", iCnt) = " "
                    Fullstr = strItemA

                    '-----------------------------------------------------------------------
                    '1-4. 길이가 170이고 사업자등록번호 유무 또는 자리수 10자리 검사
                    '-----------------------------------------------------------------------
                    If HLen(Fullstr) = 200 Then
                        .Text("chk", iCnt) = "!OK!"
                    Else
                        .Text("chk", iCnt) = "!BAD!"
                    End If
                    .Text("data_ty", iCnt) = "17"
                    .Text("tax_off", iCnt) = " "
                    .Text("bs_cd", iCnt) = str사업자번호
                    .Text("itm_a", iCnt) = strItemA & "@"
                End With
            Next

        Catch ex As Exception
            MessageError(ex, "건물등감가상각취득명세서레코드")
        End Try
    End Sub
#End Region

#Region "매입세액불공제"
    Private Sub 매입세액불공제dTaxRec17(ByVal TaxKd As String, ByVal BizCd As String)
        Try
            Dim 계산서매수T As Double = 0, 금액T As Double = 0, sRmk As String = ""

            Dim seq As Integer = 0
            Dim tseq As String = ""
            Dim str기간 As String = ""
            '--------------------------------------------------------------------
            ' 해당 사업장의 매입 또는 매출자료를 가지고 온다(매입 : D600100, 매출 : D600200)
            ' 레코드 자체를 해당 일자에 거래처별, 사업장별로 가지고 온다
            '--------------------------------------------------------------------
            Dim dSet As DataSet = Rtn_dSet("g80_sum", bs_cd.Text, TaxKd)
            If IsEmpty(dSet) Then
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = DataSetRows(dSet)
            Dim strTaxoff As String
            '----------------------------------------
            '자료구분, 기, 신고,세무서,일련번호
            '----------------------------------------
            strTaxoff = "17" + "V153"

            Dim str건수 As String, str원화금액 As String, str부가세 As String
            Dim str공통매입공급가액합계_안분계산 As String, str공통매입세액합계_안분계산 As String, str불공제매입세액합계_안분계산 As String
            Dim str불공제매입세액총액합계_정산내역 As String, str기불공제매입세액합계_정산내역 As String, str가산공제매입세액합계_정산내역 As String, str가산공제매입세액합계_납부재계산 As String
            Dim strItemA As String, Fullstr As String = ""

            '=====================
            For Each dRow In dRows


                str건수 = MultiKey(11, ToDec(dRow("cnt")))
                str원화금액 = MultiKey(15, ToDec(dRow("amt")))
                str부가세 = MultiKey(15, ToDec(dRow("vat")))
                str공통매입공급가액합계_안분계산 = MultiKey(15, 0)
                str공통매입세액합계_안분계산 = MultiKey(15, 0)
                str불공제매입세액합계_안분계산 = MultiKey(15, 0)
                str불공제매입세액총액합계_정산내역 = MultiKey(15, 0)
                str기불공제매입세액합계_정산내역 = MultiKey(15, 0)
                str가산공제매입세액합계_정산내역 = MultiKey(15, 0)
                str가산공제매입세액합계_납부재계산 = MultiKey(15, 0)

                strItemA = strTaxoff & GetLenText(str건수, 11) & GetLenText(str원화금액, 15) & GetLenText(str부가세, 15) & GetLenText(str공통매입공급가액합계_안분계산, 15) & _
                            GetLenText(str공통매입세액합계_안분계산, 15) & GetLenText(str불공제매입세액합계_안분계산, 15) & GetLenText(str불공제매입세액총액합계_정산내역, 15) & _
                            GetLenText(str기불공제매입세액합계_정산내역, 15) & GetLenText(str가산공제매입세액합계_정산내역, 15) & _
                            GetLenText(str가산공제매입세액합계_납부재계산, 15) & Space(48)

                With g80

                    iCnt = .RowCount
                    .AddNewRow()

                    .Text("no", iCnt) = " "
                    Fullstr = strItemA

                    '-----------------------------------------------------------------------
                    '1-4. 길이가 170이고 사업자등록번호 유무 또는 자리수 10자리 검사
                    '-----------------------------------------------------------------------
                    If HLen(Fullstr) = 200 Then
                        .Text("chk", iCnt) = "!OK!"
                    Else
                        .Text("chk", iCnt) = "!BAD!"
                    End If
                    .Text("data_ty", iCnt) = "17"
                    .Text("tax_off", iCnt) = " "
                    .Text("bs_cd", iCnt) = str사업자번호
                    .Text("itm_a", iCnt) = strItemA & "@"
                End With
            Next

        Catch ex As Exception
            MessageError(ex, "매입세액불공제17레코드")
        End Try
    End Sub

    '	공제받지못할매입세액명세서_명세 
    Private Sub 매입세액불공제dTaxRec18(ByVal TaxKd As String, ByVal BizCd As String)
        Try
            Dim 계산서매수T As Double = 0, 금액T As Double = 0, sRmk As String = ""

            Dim seq As Integer = 0
            Dim tseq As String = ""
            Dim str기간 As String = ""
            '--------------------------------------------------------------------
            ' 해당 사업장의 매입 또는 매출자료를 가지고 온다(매입 : D600100, 매출 : D600200)
            ' 레코드 자체를 해당 일자에 거래처별, 사업장별로 가지고 온다
            '--------------------------------------------------------------------
            Dim dSet As DataSet = Rtn_dSet("fac610_g80", bs_cd.Text, TaxKd)
            If IsEmpty(dSet) Then
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = DataSetRows(dSet)
            Dim strTaxoff As String
            '----------------------------------------
            '자료구분, 기, 신고,세무서,일련번호
            '----------------------------------------
            strTaxoff = "18" + "V153"
            Dim strc불공제사유구분 As String
            Dim str건수 As String, str원화금액 As String, str부가세 As String
            Dim strItemA As String, Fullstr As String = ""

            '=====================
            For Each dRow In dRows

                strc불공제사유구분 = GetLenText(dRow("non_bc"), 2)
                str건수 = MultiKey(11, ToDec(dRow("cnt")))
                str원화금액 = MultiKey(13, ToDec(dRow("amt")))
                str부가세 = MultiKey(13, ToDec(dRow("vat")))

                strItemA = strTaxoff & GetLenText(strc불공제사유구분, 2) & GetLenText(str건수, 11) & GetLenText(str원화금액, 13) & GetLenText(str부가세, 13) & Space(55)

                With g80

                    iCnt = .RowCount
                    .AddNewRow()

                    .Text("no", iCnt) = " "
                    Fullstr = strItemA

                    '-----------------------------------------------------------------------
                    '1-4. 길이가 170이고 사업자등록번호 유무 또는 자리수 10자리 검사
                    '-----------------------------------------------------------------------
                    If HLen(Fullstr) = 100 Then
                        .Text("chk", iCnt) = "!OK!"
                    Else
                        .Text("chk", iCnt) = "!BAD!"
                    End If
                    .Text("data_ty", iCnt) = "18"
                    .Text("tax_off", iCnt) = " "
                    .Text("bs_cd", iCnt) = str사업자번호
                    .Text("itm_a", iCnt) = strItemA & "@"
                End With
            Next

        Catch ex As Exception
            MessageError(ex, "매입세액불공제18레코드")
        End Try
    End Sub
#End Region


#Region "영세율첨부서류"

    Private Sub 영세율첨부서류dTaxRecZT(ByVal TaxKd As String, ByVal BizCd As String)
        Try
            Dim 계산서매수T As Double = 0, 금액T As Double = 0, sRmk As String = ""

            Dim seq As Integer = 0
            Dim tseq As String = ""
            Dim str기간 As String = ""
            '--------------------------------------------------------------------
            ' 해당 사업장의 매입 또는 매출자료를 가지고 온다(매입 : D600100, 매출 : D600200)
            ' 레코드 자체를 해당 일자에 거래처별, 사업장별로 가지고 온다
            '--------------------------------------------------------------------
            Dim dSet As DataSet = Rtn_dSet("g40_sum", bs_cd.Text, TaxKd)
            If IsEmpty(dSet) Then
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = DataSetRows(dSet)
            Dim strTaxoff As String
            '----------------------------------------
            '자료구분, 기, 신고,세무서,일련번호
            '----------------------------------------
            strTaxoff = "ZT" + tax_year.Text & GetLenText(v신고구분, 1) + GetLenText(v반기내월순번, 1)

            Dim str건수 As String, str원화금액 As String, str신고원화금액 As String
            Dim strItemA As String, Fullstr As String = ""

            '=====================
            For Each dRow In dRows


                str건수 = GetLenText(dRow("cnt"), 40)
                str원화금액 = MultiKey(15, ToDec(dRow("amt2")))

                str신고원화금액 = MultiKey(15, ToDec(dRow("iss_amt")))

                strItemA = "ZT" & tax_year.Text & GetLenText(v신고구분, 1) + GetLenText(v반기내월순번, 1) & GetLenText(str사업자번호, 10) & _
                            GetLenText(str건수, 7) & GetLenText(str원화금액, 15) & GetLenText(str신고원화금액, 15) & Space(145)

                With g60

                    iCnt = .RowCount
                    .AddNewRow()

                    .Text("no", iCnt) = " "
                    Fullstr = strItemA

                    '-----------------------------------------------------------------------
                    '1-4. 길이가 170이고 사업자등록번호 유무 또는 자리수 10자리 검사
                    '-----------------------------------------------------------------------
                    If HLen(Fullstr) = 200 Then
                        .Text("chk", iCnt) = "!OK!"
                    Else
                        .Text("chk", iCnt) = "!BAD!"
                    End If

                    .Text("data_ty", iCnt) = "ZT"
                    .Text("tax_off", iCnt) = " "
                    .Text("bs_cd", iCnt) = str사업자번호
                    .Text("itm_a", iCnt) = strItemA & "@"
                End With
            Next

        Catch ex As Exception
            MessageError(ex, "영세율첨부서류ZT레코드")
        End Try
    End Sub

    Private Sub 영세율첨부서류dTaxRecZD(ByVal TaxKd As String, ByVal BizCd As String)
        Try
            Dim 계산서매수T As Double = 0, 금액T As Double = 0, sRmk As String = ""

            Dim seq As Integer = 0
            Dim tseq As String = ""
            Dim str기간 As String = ""
            '--------------------------------------------------------------------
            ' 해당 사업장의 매입 또는 매출자료를 가지고 온다(매입 : D600100, 매출 : D600200)
            ' 레코드 자체를 해당 일자에 거래처별, 사업장별로 가지고 온다
            '--------------------------------------------------------------------
            Dim dSet As DataSet = Rtn_dSet("fac610_g40", bs_cd.Text, TaxKd)
            If IsEmpty(dSet) Then
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = DataSetRows(dSet)
            Dim strTaxoff As String
            '----------------------------------------
            '자료구분, 기, 신고,세무서,일련번호
            '----------------------------------------
            strTaxoff = "ZD" + tax_year.Text & GetLenText(v신고구분, 1) + GetLenText(v반기내월순번, 1)

            Dim str서류명 As String, str발급자 As String, str발급일자 As String, strC선적일자 As String, str통화코드 As String
            Dim str환율 As String, str원화금액 As String, str외화금액 As String, str신고원화금액 As String, str신고외화금액 As String
            Dim strItemA As String, Fullstr As String = ""

            Dim K As Integer = 0
            Dim 일련번호 As String = ""

            '=====================
            For Each dRow In dRows

                K += 1
                일련번호 = Format(K, "0#####")

                str서류명 = GetLenText(dRow("doc_nm"), 40)
                str발급자 = GetLenText(dRow("iss_bc"), 20)
                str발급일자 = GetLenText(Replace(dRow("iss_dt"), "-", ""), 8)
                strC선적일자 = GetLenText(Replace(dRow("ship_dt"), "-", ""), 8)
                str통화코드 = GetLenText(dRow("cury_bc"), 3)

                str환율 = MultiKey(9, ToDec(dRow("ex_rt")))
                str외화금액 = MultiKey(15, ToDec(dRow("amt")))
                str원화금액 = MultiKey(15, ToDec(dRow("amt2")))

                str신고원화금액 = MultiKey(15, ToDec(dRow("iss_amt")))
                str신고외화금액 = MultiKey(15, ToDec(dRow("iss_amt2")))


                strItemA = "ZD" & tax_year.Text & GetLenText(v신고구분, 1) + GetLenText(v반기내월순번, 1) & GetLenText(str사업자번호, 10) & 일련번호 & _
                            GetLenText(str서류명, 40) & GetLenText(str발급자, 20) & GetLenText(str발급일자, 8) & _
                            GetLenText(strC선적일자, 8) & GetLenText(str통화코드, 3) & _
                            GetLenText(str환율, 9) & GetLenText(str외화금액, 15) & GetLenText(str원화금액, 15) & _
                            GetLenText(str신고원화금액, 15) & GetLenText(str신고외화금액, 15) & Space(26)

                With g60

                    iCnt = .RowCount
                    .AddNewRow()

                    .Text("no", iCnt) = K
                    Fullstr = strItemA

                    '-----------------------------------------------------------------------
                    '1-4. 길이가 170이고 사업자등록번호 유무 또는 자리수 10자리 검사
                    '-----------------------------------------------------------------------
                    If HLen(Fullstr) = 200 Then
                        .Text("chk", iCnt) = "!OK!"
                    Else
                        .Text("chk", iCnt) = "!BAD!"
                    End If

                    .Text("data_ty", iCnt) = "ZD"
                    .Text("tax_off", iCnt) = 일련번호
                    .Text("bs_cd", iCnt) = str사업자번호
                    .Text("itm_a", iCnt) = strItemA & "@"
                End With
            Next

        Catch ex As Exception
            MessageError(ex, "영세율첨부서류ZD레코드")
        End Try
    End Sub
#End Region

#Region "신용카드매출수취명세서"

    Private Sub 신용카드매출수취명세서dTaxRecDL(ByVal TaxKd As String, ByVal BizCd As String)
        Try
            Dim 계산서매수T As Double = 0, 금액T As Double = 0, sRmk As String = ""

            Dim seq As Integer = 0
            Dim tseq As String = ""
            Dim str기간 As String = ""
            '--------------------------------------------------------------------
            ' 해당 사업장의 매입 또는 매출자료를 가지고 온다(매입 : D600100, 매출 : D600200)
            ' 레코드 자체를 해당 일자에 거래처별, 사업장별로 가지고 온다
            '--------------------------------------------------------------------
            Dim dSet As DataSet = Rtn_dSet("fac610_g50", bs_cd.Text, TaxKd)
            If IsEmpty(dSet) Then
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = DataSetRows(dSet)
            Dim strTaxoff As String
            '----------------------------------------
            '자료구분, 기, 신고,세무서,일련번호
            '----------------------------------------
            strTaxoff = "DL" + tax_year.Text & GetLenText(v신고구분, 1) + GetLenText(v반기내월순번, 1)

            Dim str카드번호 As String = "", str카드사업자번호 As String = "", str건수 As String, str원화금액 As String, str세액 As String
            Dim str금액음수표시 As String = " ", str세액음수표시 As String = " ", str카드구분 As String = "1"
            Dim strItemA As String, Fullstr As String = ""

            '=====================
            For Each dRow In dRows

                str카드번호 = GetLenText(dRow("card_no"), 20)
                str카드사업자번호 = GetLenText(Replace(Trim(DataValue(dSet, "iss_no")), "-", ""), 10)
                str건수 = GetLenText(dRow("cnt"), 9)
                str원화금액 = MultiKey(15, ToDec(dRow("amt")))

                str세액 = MultiKey(15, ToDec(dRow("vat")))

                If str원화금액 < 0 Then
                    str금액음수표시 = "-"
                End If
                If str세액 < 0 Then
                    str세액음수표시 = "-"
                End If

                strItemA = "DL" & tax_year.Text & GetLenText(v신고구분, 1) + GetLenText(v반기내월순번, 1) & GetLenText(str사업자번호, 10) & _
                           GetLenText(str카드구분, 1) & GetLenText(str카드번호, 20) & GetLenText(str카드사업자번호, 10) & _
                           GetLenText(str건수, 9) & GetLenText(str금액음수표시, 1) & GetLenText(str원화금액, 13) & GetLenText(str세액음수표시, 1) & GetLenText(str세액, 13) & Space(54)

                With g50

                    iCnt = .RowCount
                    .AddNewRow()

                    .Text("no", iCnt) = " "
                    Fullstr = strItemA

                    '-----------------------------------------------------------------------
                    '1-4. 길이가 170이고 사업자등록번호 유무 또는 자리수 10자리 검사
                    '-----------------------------------------------------------------------
                    If HLen(Fullstr) = 140 Then
                        .Text("chk", iCnt) = "!OK!"
                    Else
                        .Text("chk", iCnt) = "!BAD!"
                    End If

                    .Text("data_ty", iCnt) = "DL"
                    .Text("tax_off", iCnt) = " "
                    .Text("bs_cd", iCnt) = str사업자번호
                    .Text("itm_a", iCnt) = strItemA & "@"
                End With
            Next

        Catch ex As Exception
            MessageError(ex, "신용카드매출수취명세서DL레코드")
        End Try
    End Sub

    Private Sub 신용카드매출수취명세서dTaxRecTL(ByVal TaxKd As String, ByVal BizCd As String)
        Try
            Dim 계산서매수T As Double = 0, 금액T As Double = 0, sRmk As String = ""

            Dim seq As Integer = 0
            Dim tseq As String = ""
            Dim str기간 As String = ""
            '--------------------------------------------------------------------
            ' 해당 사업장의 매입 또는 매출자료를 가지고 온다(매입 : D600100, 매출 : D600200)
            ' 레코드 자체를 해당 일자에 거래처별, 사업장별로 가지고 온다
            '--------------------------------------------------------------------
            Dim dSet As DataSet = Rtn_dSet("fac610_g50", bs_cd.Text, TaxKd)
            If IsEmpty(dSet) Then
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = DataSetRows(dSet)
            Dim strTaxoff As String
            '----------------------------------------
            '자료구분, 기, 신고,세무서,일련번호
            '----------------------------------------
            strTaxoff = "DL" + tax_year.Text & GetLenText(v신고구분, 1) + GetLenText(v반기내월순번, 1)

            Dim str카드번호 As String = "", str카드사업자번호 As String = "", str건수 As String, str원화금액 As String, str세액 As String
            Dim str금액음수표시 As String = " ", str세액음수표시 As String = " ", str카드구분 As String = "1"
            Dim strItemA As String, Fullstr As String = ""

            '=====================
            For Each dRow In dRows

                str카드번호 = GetLenText(dRow("card_no"), 20)
                str카드사업자번호 = GetLenText(Replace(Trim(DataValue(dSet, "iss_no")), "-", ""), 10)
                str건수 = GetLenText(dRow("cnt"), 9)
                str원화금액 = MultiKey(15, ToDec(dRow("amt")))

                str세액 = MultiKey(15, ToDec(dRow("vat")))

                If str원화금액 < 0 Then
                    str금액음수표시 = "-"
                End If
                If str세액 < 0 Then
                    str세액음수표시 = "-"
                End If

                strItemA = "TL" & tax_year.Text & GetLenText(v신고구분, 1) + GetLenText(v반기내월순번, 1) & GetLenText(str사업자번호, 10) & _
                           GetLenText(str카드구분, 1) & GetLenText(str카드번호, 20) & GetLenText(str카드사업자번호, 10) & _
                           GetLenText(str건수, 9) & GetLenText(str금액음수표시, 1) & GetLenText(str원화금액, 13) & GetLenText(str세액음수표시, 1) & GetLenText(str세액, 13) & Space(54)

                With g50

                    iCnt = .RowCount
                    .AddNewRow()

                    .Text("no", iCnt) = " "
                    Fullstr = strItemA

                    '-----------------------------------------------------------------------
                    '1-4. 길이가 170이고 사업자등록번호 유무 또는 자리수 10자리 검사
                    '-----------------------------------------------------------------------
                    If HLen(Fullstr) = 140 Then
                        .Text("chk", iCnt) = "!OK!"
                    Else
                        .Text("chk", iCnt) = "!BAD!"
                    End If

                    .Text("data_ty", iCnt) = "TL"
                    .Text("tax_off", iCnt) = " "
                    .Text("bs_cd", iCnt) = str사업자번호
                    .Text("itm_a", iCnt) = strItemA & "@"
                End With
            Next

        Catch ex As Exception
            MessageError(ex, "신용카드매출수취명세서TL레코드")
        End Try
    End Sub
#End Region

#Region "세금계산서합계표,계산서합계표"


    '표지부 : A 레코드
    '         사업장의 본사거래처 (MAIN_CHK = '1') 로 구성한다.
    Private Function dTaxRecA() As String
        Dim sCover As String = ""
        Try
            Dim str상호성명 As String = "", str사업장 As String = ""
            Dim strItemA As String = "", strTaxoff As String = ""
            Dim strErr As String = ""

            Dim dSet As DataSet = Rtn_dSet("get_mbiz_info") 'Open(Me.Name, "get_mbiz_info")    '2. 본사정보

            If IsEmpty(dSet) Then
                Return "본사 사업장정보 테이블(BCC200)에 접속할 수 없습니다." 'Msg("DC560_31")
            End If

            str사업자번호 = ""
            Dim BsNo As String = Replace(Trim(DataValue(dSet, "biz_no")), "-", "")
            Dim CoNo As String = Replace(Trim(DataValue(dSet, "co_no")), "-", "")
            '사업자번호 길이 체크(데이타에 '-'가 입력될 수 있으므로 REPLACE 시킨다.)
            If HLen(BsNo) = 10 Then
                str사업자번호 = BsNo
            Else
                str사업자번호 = BsNo
                sCover = "[사업자번호]에 오류가 발생하였습니다." ' Msg("DC560_4")
                ' "[사업자번호]에 오류가 발생하였습니다."
                strErr &= "[사업장 사업자번호 길이]" & HLen(BsNo)
                'strErr &= Msg("DC560_5") & HLen(Replace(Trim(dSet.Tables(0).Rows(0)("bs_cd")), "-", ""))
            End If

            If DataValue(dSet, "bs_nm") = "" Then strErr &= "[상호명 공란]" 'strErr &= Msg("DC560_6")
            If DataValue(dSet, "ceo_nm") = "" Then strErr &= "[대표자성명 공란]" 'strErr &= Msg("DC560_7")
            If DataValue(dSet, "addr_prt") = "" Then strErr &= "[사업장소재지 공란]" 'strErr &= Msg("DC560_8")
            If DataValue(dSet, "biz_type") = "" Then strErr &= "[업태 공란]" 'strErr &= Msg("DC560_9")
            If DataValue(dSet, "biz_kind") = "" Then strErr &= "[업종 공란]" 'strErr &= Msg("DC560_10")


            '[자료관리번호] - 세무서, 제출연월일, 제출자-1:세무대리인 , 2:법인, 3:개인, 세무대리관리번호
            strTaxoff = GetLenText(TaxNo, 3) + vPrtdt + "2" + Space(6)

            '[제출자(대리인)] - 법인명 ~ 전화번호
            str상호성명 = GetText(dSet, "bs_nm", 40) & GetLenText(BsNo, 13) & _
                            GetText(dSet, "ceo_nm", 30) & GetText(dSet, "zip_cd", 10) & _
                          GetText(dSet, "addr_prt", 70) & GetText(dSet, "tel", 15)

            '[제출내역] - 제출의무자사업자수, 사용한글코드, 공란(13)
            strItemA = "A" + GetLenText(TaxNo, 3) + v_작성일자 + "2" + Space(6) + str사업자번호 + GetText(dSet, "bs_nm", 40) + GetLenText(CoNo, 13) & _
                       GetText(dSet, "ceo_nm", 30) & GetText(dSet, "zip_cd", 10) & GetText(dSet, "addr_prt", 70) & GetLenText(Replace(Trim(DataValue(dSet, "tel")), "-", ""), 15) & _
                      MultiKey(5, ToDec(DataValue(dSet, "bs_cnt"))) & "101" & Space(15)

            'strItemA = MultiKey(5, ToDec(DataValue(dSet, "bs_cnt"))) + "101" + Space(13) + "P"

            '[전체]
            str사업장 = "A" + strTaxoff + str사업자번호 + str상호성명 + strItemA

            '[ 계산서전산매체자료생성 ]
            iCnt = 0
            With g30
                .AddNewRow()
                .Text("no", iCnt) = " "

                If HLen(strItemA) = 230 Then
                    .Value("chk") = "!OK!"
                Else
                    .Value("chk") = "!BAD!"
                End If

                .Text("data_ty", iCnt) = "A"
                .Text("tax_off", iCnt) = strTaxoff
                .Text("bs_cd", iCnt) = str사업자번호
                .Text("cust_info", iCnt) = str상호성명
                .Text("itm_a", iCnt) = strItemA & "@" '"제출건수" + "101" + Space(15) + "P"
                '.AllowAddRows = False

            End With

            If HLen(str사업장) <> 230 Then strErr &= "[A레코드 총길이 오류 :" & HLen(str사업장) & "]" 'strErr &= Msg("CV800_16") & " :" & HLen(str사업장)

            If strErr <> "" Then

            End If
        Catch ex As Exception
            MessageError(ex, "dTaxRecA")
        End Try
        Return sCover
    End Function


    '4.매출자료, 5.매입자료
    Private Function InOutData(ByVal BillTy As String, ByVal BizCd As String) As String
        Dim sInOutData As String = ""
        Try
            Dim j As Integer
            Dim str일련번호 As String, str거래자등록번호 As String
            Dim str상호 As String = Nothing, str업태 As String = Nothing, str업종 As String = Nothing
            Dim str매수 As String, str공란수 As String
            Dim str상호성명 As String, str항목A As String
            Dim 사업자chk As Boolean
            Dim DataChk As String
            Dim Length As Integer
            Dim DataTy As String, OutNo As String
            Dim strErr As String

            Dim 공급가 As Double, str공급가 As String
            Dim 세액 As Double, str세액 As String

            '사업자등록분 세금계산서 매수, 공급가, 세액 Total
            Dim 사업자세금계산서매수Tot As Double, 사업자세금계산서공급가Tot As Double, 사업자세금계산서세액Tot As Double
            '주민기재분 세금계산서 매수, 공급가, 세액 Total
            Dim 주민세금계산서매수Tot As Double, 주민세금계산서공급가Tot As Double, 주민세금계산서세액Tot As Double

            '--------------------------------------------------------------------
            '매출 : DataRecordTy - 1 (매출), OutNo - 9001 (프로피디스켓)
            '매입 : DataRecordTy - 2 (매입), OutNo - 9501 (프로피디스켓)
            '--------------------------------------------------------------------
            If BillTy = bc_계산서구분_매출 Then

                '********매출정보 변수 초기화
                strA거래처수 = "" : strA세금계산서매수 = "" : strA공급가액합계 = "" : strA세액합계 = ""
                strA주민거래처수 = "" : strA주민세금계산서매수 = "" : strA주민공급가액합계 = "" : strA주민세액합계 = ""
                strA총거래처수 = "" : strA총세금계산서매수 = "" : strA총공급가액 = "" : strA총세액 = ""

                DataTy = "1"
                OutNo = "7501"
                'OutNo = "9001"
            Else

                '********매입정보 변수 초기화
                strB거래처수 = "" : strB세금계산서매수 = "" : strB공급가액합계 = "" : strB세액합계 = ""
                strB주민거래처수 = "" : strB주민세금계산서매수 = "" : strB주민공급가액합계 = "" : strB주민세액합계 = ""
                strB총거래처수 = "" : strB총세금계산서매수 = "" : strB총공급가액 = "" : strB총세액 = ""

                DataTy = "2"
                OutNo = "8501"
                'OutNo = "9501"
            End If

            '--------------------------------------------------------------------
            ' 해당 사업장의 매입 또는 매출자료를 가지고 온다(매입 : D600100, 매출 : D600200)
            ' 레코드 자체를 해당 일자에 거래처별, 사업장별로 가지고 온다
            '--------------------------------------------------------------------


            'Dim sTerm As String
            'sTerm = " [ AND	a.term_ty = '" & term_ty.Text & "' ]"
            'If term_ty.Text < "FA680250" Then
            '    sTerm = "[ AND  A.term_ty  in 	" & _
            '                " (SELECT base_in_cd FROM EPZZ300T WHERE GROUP_CD = 'D640' AND ISNULL(mana7,'') = '" & term_ty.Text & "' ) ]"
            'End If

            'Dim p As New OpenParameters
            'p.Add("@bs_cd", BizCd)
            'p.Add("@std_year", tax_year.Text)
            'p.Add("@term_ty", mon_bc.Text)
            'p.Add("@sterm_ty", mon_bc.Text)
            'p.Add("@bill_ty", BillTy)
            'Dim dSet As DataSet = OpenDataSet("fac610_g10", p) '4.매출자료, 5.매입자료 ''2010.02.24 김종우 변경없음..

            Dim dSet As DataSet = Rtn_dSet("fac610_g20", bs_cd.Text, BillTy) '4.매출자료, 5.매입자료 ''2010.02.24 김종우 변경없음..

            'Dim oParams As Object = Nothing
            'AddParam(oParams, "@bs_cd", BizCd)
            'AddParam(oParams, "@std_year", std_year.Text)
            'AddParam(oParams, "@term_ty", term_ty.Text)
            'AddParam(oParams, "@sterm_ty", term_ty.Text)
            'AddParam(oParams, "@bill_ty", BillTy)
            'epdc560f_g1.OpenParams = oParams

            'Dim dSet As DataSet = Open(epdc560f_g1)
            'Dim dSet As DataSet = Open(Me.Name, "epdc560f_g1", oParams) '4.매출자료, 5.매입자료 ''2010.02.24 김종우 변경없음..

            sInOutData = ""
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = DataSetRows(dSet)

            'If dRows.Count = 0 Then
            '    Me.Cursor = Cursors.Default

            '    ''---------------------------------------------------
            '    '' 5.전산매출합계, 6.전산매입합계 2010.02.24 김종우
            '    ''---------------------------------------------------
            '    Dim ds_str1 As String = Sum_Ele_Data(BillTy)

            '    ''-- END --------------------------------------------

            '    Return ""
            'End If

            Dim BizNo As String = ""
            For Each dRow In dRows
                strErr = ""

                사업자chk = True

                '******* 매입/매출자료 생성
                '--------------------------------
                '1. 사업자등록분
                '--------------------------------
                If dRow("cust_kd") <> bc_거래형태_개인 Then

                    j = j + 1
                    Length = 0

                    str일련번호 = Format(j, "0###")
                    str거래자등록번호 = ""
                    BizNo = Trim(Replace(dRow("biz_no"), "-", ""))
                    '-----------------------------------------------------------------------
                    '1-1. 거래자등록번호 체크 ( 자리수 "-" 빼고 10자리 체크한다. )
                    '-----------------------------------------------------------------------
                    If HLen(BizNo) = 10 Then
                        str거래자등록번호 = BizNo
                    Else
                        str거래자등록번호 = BizNo
                        사업자chk = False
                        사업자번호chk = 사업자번호chk + 1
                        strErr = "[거래처 사업자번호 길이 : " & HLen(BizNo) & "]"
                    End If

                    사업자세금계산서매수Tot = 사업자세금계산서매수Tot + ToDec(dRow("bill_cnt"))
                    사업자세금계산서공급가Tot = 사업자세금계산서공급가Tot + ToDec(dRow("add_amt")) + ToDec(dRow("mis_amt"))
                    사업자세금계산서세액Tot = 사업자세금계산서세액Tot + ToDec(dRow("add_vat")) + ToDec(dRow("mis_vat"))

                    공급가 = 0 : str공급가 = ""
                    세액 = 0 : str세액 = ""

                    Length = Len(CStr(ToDec(dRow("add_amt")) + ToDec(dRow("mis_amt"))))
                    공급가 = ToDec(dRow("add_amt")) + ToDec(dRow("mis_amt"))
                    세액 = ToDec(dRow("add_vat")) + ToDec(dRow("mis_vat"))

                    str매수 = MultiKey(7, ToDec(dRow("bill_cnt")))
                    str공란수 = MultiKey(2, 14 - Length)

                    '공급가, 세액 각각 총 자리수에 맞도록 string값으로 변환
                    str공급가 = MultiKey(14, 공급가)
                    str세액 = MultiKey(13, 세액)

                    str상호성명 = str일련번호 + str거래자등록번호 + _
                                    GetLenText(dRow("cust_nm"), 30) + _
                                    GetLenText(dRow("biz_type"), 17) + _
                                    GetLenText(dRow("biz_kind"), 25)

                    '-----------------------------------------------------------------------
                    '1-3. "00"  : 주류외 제조업이 아닌 경우는 무조건 "00"으로 처리한다.
                    '-----------------------------------------------------------------------
                    str항목A = str매수 & str공란수 & str공급가 & str세액 & "00" & OutNo & TaxNo & Space(28)

                    'DataTy : 매입, 매출 구분
                    DataChk = DataTy & str사업자번호 & GetLenText(str상호성명, 86) + str항목A
                    HLen(str상호성명)
                    '[ 부가세전산매체자료생성 ]
                    iCnt = 0
                    With g20

                        iCnt = .RowCount
                        .AddNewRow()

                        .Text("no", iCnt) = j

                        '-----------------------------------------------------------------------
                        '1-4. 길이가 170이고 사업자등록번호 유무 또는 자리수 10자리 검사
                        '-----------------------------------------------------------------------
                        If HLen(DataChk) = 170 And 사업자chk = True Then
                            .Text("chk", iCnt) = "!OK!"
                        Else
                            .Text("chk", iCnt) = "!BAD!"
                        End If
                        .Text("data_ty", iCnt) = DataTy
                        .Text("bs_cd", iCnt) = str사업자번호
                        .Text("cust_info", iCnt) = str상호성명
                        .Text("itm_a", iCnt) = DataChk & "@" 'str항목A + "P"
                        HLen(.Text("itm_a", iCnt))
                    End With

                    If HLen(str사업자번호) <> 10 Then strErr &= "[사업장 사업자번호 길이 :" & HLen(str사업자번호) & "]" 'strErr &= Msg("CV800_4") & " :" & HLen(str사업자번호)
                    If HLen(DataChk) <> 170 Then strErr &= "[B레코드 총길이 오류 :" & HLen(DataChk) & "]" 'strErr &= Msg("CV800_17") & " :" & HLen(DataChk)


                    iCnt = 0
                    If strErr <> "" Then
                        '[ 오류자료 ]
                        With g70
                            iCnt = .RowCount
                            .AddNewRow()

                            .Text("no", iCnt) = j
                            .Text("chk", iCnt) = "!BAD!"
                            .Text("data_ty", iCnt) = DataTy
                            .Text("rmk") = "B레코드 :" & strErr
                        End With
                    End If

                Else
                    '--------------------------------
                    '2. 주민기재분
                    '--------------------------------
                    주민세금계산서매수Tot = 주민세금계산서매수Tot + ToDec(dRow("bill_cnt"))
                    주민세금계산서공급가Tot = 주민세금계산서공급가Tot + ToDec(dRow("add_amt")) + ToDec(dRow("mis_amt"))
                    주민세금계산서세액Tot = 주민세금계산서세액Tot + ToDec(dRow("add_vat")) + ToDec(dRow("mis_vat"))
                End If
            Next

            Dim str항목B As String = "", str항목C As String = "", str항목Tot As String = ""
            Dim Amt As Int64 = 0, CustCnt As Integer = 0
            If BillTy = bc_계산서구분_매출 Then
                dSet = Rtn_dSet("g20_sum_매출", bs_cd.Text, BillTy) '4.매출자료, 5.매입자료 ''2010.02.24 김종우 변경없음..
                dRows = DataSetRows(dSet)
                dRow = Nothing
                '-------------------------------------------------------------------------------------------------

                strErr = "" : DataChk = ""

                '******* 매입/매출 합계자료 형성
                '--------------------------------------------------------------------
                '매출합계 : DataTy - 3 (매출), Space(30)
                '매입합계 : DataTy - 4 (매입), Space(116)
                '--------------------------------------------------------------------
                For Each dRow In dRows
                    '------------------------------------------
                    '2-1. 매출 합계 : 사업자등록분 + 주민기재분
                    '------------------------------------------
                    CustCnt = ToDec(dRow("cust_cnt4")) + ToDec(dRow("cust_cnt5"))
                    If CustCnt > 0 Then
                        strA총거래처수 = MultiKey(7, ToDec(dRow("cust_cnt4")) + ToDec(dRow("cust_cnt5")))
                        strA총세금계산서매수 = MultiKey(7, ToDec(dRow("add_cnt4")) + ToDec(dRow("add_cnt5")))
                        Amt = ToDec(dRow("add_amt4")) + ToDec(dRow("add_amt5"))
                        strA총공급가액 = MultiKey(15, Amt)
                        Amt = ToDec(dRow("add_vat4")) + ToDec(dRow("add_vat5"))
                        strA총세액 = MultiKey(14, Amt)

                        '------------------------------------------
                        '2-2. 매출 자료 : 사업자등록분
                        '------------------------------------------
                        strA거래처수 = MultiKey(7, ToDec(dRow("cust_cnt4")))
                        strA세금계산서매수 = MultiKey(7, ToDec(dRow("add_cnt4")))
                        Amt = ToDec(dRow("add_amt4"))
                        strA공급가액합계 = MultiKey(15, Amt)
                        Amt = ToDec(dRow("add_vat4"))
                        strA세액합계 = MultiKey(14, Amt)

                        '------------------------------------------
                        '2-3. 매출 자료 : 주민기재분
                        '------------------------------------------
                        strA주민거래처수 = MultiKey(7, ToDec(dRow("cust_cnt5")))
                        strA주민세금계산서매수 = MultiKey(7, ToDec(dRow("add_cnt5")))
                        Amt = ToDec(dRow("add_amt5"))
                        strA주민공급가액합계 = MultiKey(15, Amt)
                        Amt = ToDec(dRow("add_vat5"))
                        strA주민세액합계 = MultiKey(14, Amt)

                        '------------------------------------------
                        '2-4. 매출 자료 구성
                        '------------------------------------------
                        str항목Tot = strA총거래처수 + strA총세금계산서매수 + strA총공급가액 + strA총세액
                        str항목B = strA거래처수 + strA세금계산서매수 + strA공급가액합계 + strA세액합계
                        str항목C = strA주민거래처수 + strA주민세금계산서매수 + strA주민공급가액합계 + strA주민세액합계

                        str항목Tot = str항목Tot + str항목B
                        str항목C = str항목C + Space(30)
                        DataTy = "3"

                        DataChk = DataTy & str사업자번호 & str항목Tot & str항목C

                        If HLen(str사업자번호) <> 10 Then strErr &= "[사업장 사업자번호 길이 :" & HLen(str사업자번호) & "]" 'strErr &= Msg("CV800_4") & " :" & HLen(str사업자번호)
                        If HLen(DataChk) <> 170 Then strErr &= "[C레코드 총길이 오류 :" & HLen(DataChk) & "]" 'strErr &= Msg("CV800_22") & " :" & HLen(DataChk)
                        With g20
                            iCnt = .RowCount
                            .AddNewRow()

                            .Text("no", iCnt) = " "

                            If HLen(DataChk) = 170 Then
                                .Text("chk", iCnt) = "!OK!"
                            Else
                                .Text("chk", iCnt) = "!BAD!"
                            End If

                            .Text("data_ty", iCnt) = DataTy
                            .Text("bs_cd", iCnt) = str사업자번호
                            .Text("cust_info", iCnt) = str항목Tot
                            .Text("itm_a", iCnt) = DataChk & "@" 'str항목C + "P"
                        End With
                    End If



                    '------------------------------------------
                    '2-1. 매출 합계 : 사업자등록분 + 주민기재분
                    '------------------------------------------
                    CustCnt = ToDec(dRow("cust_cnt1")) + ToDec(dRow("cust_cnt2"))
                    If CustCnt > 0 Then
                        strA총거래처수 = MultiKey(7, ToDec(dRow("cust_cnt1")) + ToDec(dRow("cust_cnt2")))
                        strA총세금계산서매수 = MultiKey(7, ToDec(dRow("add_cnt1")) + ToDec(dRow("add_cnt2")))
                        Amt = ToDec(dRow("add_amt1")) + ToDec(dRow("add_amt2"))
                        strA총공급가액 = MultiKey(15, Amt)
                        Amt = ToDec(dRow("add_vat1")) + ToDec(dRow("add_vat2"))
                        strA총세액 = MultiKey(14, Amt)

                        '------------------------------------------
                        '2-2. 매출 자료 : 사업자등록분
                        '------------------------------------------
                        strA거래처수 = MultiKey(7, ToDec(dRow("cust_cnt1")))
                        strA세금계산서매수 = MultiKey(7, ToDec(dRow("add_cnt1")))
                        Amt = ToDec(dRow("add_amt1"))
                        strA공급가액합계 = MultiKey(15, Amt)
                        Amt = ToDec(dRow("add_vat1"))
                        strA세액합계 = MultiKey(14, Amt)

                        '------------------------------------------
                        '2-3. 매출 자료 : 주민기재분
                        '------------------------------------------
                        strA주민거래처수 = MultiKey(7, ToDec(dRow("cust_cnt2")))
                        strA주민세금계산서매수 = MultiKey(7, ToDec(dRow("add_cnt2")))
                        Amt = ToDec(dRow("add_amt2"))
                        strA주민공급가액합계 = MultiKey(15, Amt)
                        Amt = ToDec(dRow("add_vat2"))
                        strA주민세액합계 = MultiKey(14, Amt)

                        '------------------------------------------
                        '2-4. 매출 자료 구성
                        '------------------------------------------
                        str항목Tot = strA총거래처수 + strA총세금계산서매수 + strA총공급가액 + strA총세액
                        str항목B = strA거래처수 + strA세금계산서매수 + strA공급가액합계 + strA세액합계
                        str항목C = strA주민거래처수 + strA주민세금계산서매수 + strA주민공급가액합계 + strA주민세액합계

                        str항목Tot = str항목Tot + str항목B
                        str항목C = str항목C + Space(30)
                        DataTy = "5"

                        DataChk = DataTy & str사업자번호 & str항목Tot & str항목C

                        If HLen(str사업자번호) <> 10 Then strErr &= "[사업장 사업자번호 길이 :" & HLen(str사업자번호) & "]" 'strErr &= Msg("CV800_4") & " :" & HLen(str사업자번호)
                        If HLen(DataChk) <> 170 Then strErr &= "[C레코드 총길이 오류 :" & HLen(DataChk) & "]" 'strErr &= Msg("CV800_22") & " :" & HLen(DataChk)
                        With g20
                            iCnt = .RowCount
                            .AddNewRow()

                            .Text("no", iCnt) = " "

                            If HLen(DataChk) = 170 Then
                                .Text("chk", iCnt) = "!OK!"
                            Else
                                .Text("chk", iCnt) = "!BAD!"
                            End If

                            .Text("data_ty", iCnt) = DataTy
                            .Text("bs_cd", iCnt) = str사업자번호
                            .Text("cust_info", iCnt) = str항목Tot
                            .Text("itm_a", iCnt) = DataChk & "@" 'str항목C + "P"
                        End With
                    End If
                Next
            Else
                dSet = Rtn_dSet("g20_sum_매입", bs_cd.Text, BillTy) '4.매출자료, 5.매입자료 ''2010.02.24 김종우 변경없음..
                dRows = DataSetRows(dSet)
                dRow = Nothing
                '-------------------------------------------------------------------------------------------------
                str항목B = "" : str항목C = "" : str항목Tot = ""
                strErr = "" : DataChk = ""

                '******* 매입/매출 합계자료 형성
                '--------------------------------------------------------------------
                '매출합계 : DataTy - 3 (매출), Space(30)
                '매입합계 : DataTy - 4 (매입), Space(116)
                '--------------------------------------------------------------------
                For Each dRow In dRows
                    '------------------------------------------
                    '2-1. 매출 합계 : 사업자등록분 + 주민기재분
                    '------------------------------------------
                    CustCnt = ToDec(dRow("cust_cnt4")) + ToDec(dRow("cust_cnt5"))
                    If CustCnt > 0 Then
                        strA총거래처수 = MultiKey(7, ToDec(dRow("cust_cnt4")) + ToDec(dRow("cust_cnt5")))
                        strA총세금계산서매수 = MultiKey(7, ToDec(dRow("add_cnt4")) + ToDec(dRow("add_cnt5")))
                        Amt = ToDec(dRow("add_amt4")) + ToDec(dRow("add_amt5"))
                        strA총공급가액 = MultiKey(15, Amt)
                        Amt = ToDec(dRow("add_vat4")) + ToDec(dRow("add_vat5"))
                        strA총세액 = MultiKey(14, Amt)

                        '------------------------------------------
                        '2-2. 매출 자료 : 사업자등록분
                        '------------------------------------------
                        strA거래처수 = MultiKey(7, ToDec(dRow("cust_cnt4")))
                        strA세금계산서매수 = MultiKey(7, ToDec(dRow("add_cnt4")))
                        Amt = ToDec(dRow("add_amt4"))
                        strA공급가액합계 = MultiKey(15, Amt)
                        Amt = ToDec(dRow("add_vat4"))
                        strA세액합계 = MultiKey(14, Amt)

                        '------------------------------------------
                        '2-3. 매출 자료 : 주민기재분
                        '------------------------------------------
                        strA주민거래처수 = MultiKey(7, ToDec(dRow("cust_cnt5")))
                        strA주민세금계산서매수 = MultiKey(7, ToDec(dRow("add_cnt5")))
                        Amt = ToDec(dRow("add_amt5"))
                        strA주민공급가액합계 = MultiKey(15, Amt)
                        Amt = ToDec(dRow("add_vat5"))
                        strA주민세액합계 = MultiKey(14, Amt)

                        '------------------------------------------
                        '2-4. 매출 자료 구성
                        '------------------------------------------
                        str항목Tot = strA총거래처수 + strA총세금계산서매수 + strA총공급가액 + strA총세액
                        str항목B = strA거래처수 + strA세금계산서매수 + strA공급가액합계 + strA세액합계
                        str항목C = strA주민거래처수 + strA주민세금계산서매수 + strA주민공급가액합계 + strA주민세액합계

                        str항목Tot = str항목Tot + str항목B
                        str항목C = str항목C + Space(30)
                        DataTy = "4"

                        DataChk = DataTy & str사업자번호 & str항목Tot & str항목C

                        If HLen(str사업자번호) <> 10 Then strErr &= "[사업장 사업자번호 길이 :" & HLen(str사업자번호) & "]" 'strErr &= Msg("CV800_4") & " :" & HLen(str사업자번호)
                        If HLen(DataChk) <> 170 Then strErr &= "[C레코드 총길이 오류 :" & HLen(DataChk) & "]" 'strErr &= Msg("CV800_22") & " :" & HLen(DataChk)
                        With g20
                            iCnt = .RowCount
                            .AddNewRow()

                            .Text("no", iCnt) = " "

                            If HLen(DataChk) = 170 Then
                                .Text("chk", iCnt) = "!OK!"
                            Else
                                .Text("chk", iCnt) = "!BAD!"
                            End If

                            .Text("data_ty", iCnt) = DataTy
                            .Text("bs_cd", iCnt) = str사업자번호
                            .Text("cust_info", iCnt) = str항목Tot
                            .Text("itm_a", iCnt) = DataChk & "@" 'str항목C + "P"
                        End With
                    End If


                    CustCnt = ToDec(dRow("cust_cnt1")) + ToDec(dRow("cust_cnt2"))
                    If CustCnt > 0 Then
                        '------------------------------------------
                        '2-1. 매출 합계 : 사업자등록분 + 주민기재분
                        '------------------------------------------
                        strA총거래처수 = MultiKey(7, ToDec(dRow("cust_cnt1")) + ToDec(dRow("cust_cnt2")))
                        strA총세금계산서매수 = MultiKey(7, ToDec(dRow("add_cnt1")) + ToDec(dRow("add_cnt2")))
                        Amt = ToDec(dRow("add_amt1")) + ToDec(dRow("add_amt2"))
                        strA총공급가액 = MultiKey(15, Amt)
                        Amt = ToDec(dRow("add_vat1")) + ToDec(dRow("add_vat2"))
                        strA총세액 = MultiKey(14, Amt)

                        '------------------------------------------
                        '2-2. 매출 자료 : 사업자등록분
                        '------------------------------------------
                        strA거래처수 = MultiKey(7, ToDec(dRow("cust_cnt1")))
                        strA세금계산서매수 = MultiKey(7, ToDec(dRow("add_cnt1")))
                        Amt = ToDec(dRow("add_amt1"))
                        strA공급가액합계 = MultiKey(15, Amt)
                        Amt = ToDec(dRow("add_vat1"))
                        strA세액합계 = MultiKey(14, Amt)

                        '------------------------------------------
                        '2-3. 매출 자료 : 주민기재분
                        '------------------------------------------
                        strA주민거래처수 = MultiKey(7, ToDec(dRow("cust_cnt2")))
                        strA주민세금계산서매수 = MultiKey(7, ToDec(dRow("add_cnt2")))
                        Amt = ToDec(dRow("add_amt2"))
                        strA주민공급가액합계 = MultiKey(15, Amt)
                        Amt = ToDec(dRow("add_vat2"))
                        strA주민세액합계 = MultiKey(14, Amt)

                        '------------------------------------------
                        '2-4. 매출 자료 구성
                        '------------------------------------------
                        str항목Tot = strA총거래처수 + strA총세금계산서매수 + strA총공급가액 + strA총세액
                        str항목B = strA거래처수 + strA세금계산서매수 + strA공급가액합계 + strA세액합계
                        str항목C = strA주민거래처수 + strA주민세금계산서매수 + strA주민공급가액합계 + strA주민세액합계

                        str항목Tot = str항목Tot + str항목B
                        str항목C = str항목C + Space(30)
                        DataTy = "6"

                        DataChk = DataTy & str사업자번호 & str항목Tot & str항목C

                        If HLen(str사업자번호) <> 10 Then strErr &= "[사업장 사업자번호 길이 :" & HLen(str사업자번호) & "]" 'strErr &= Msg("CV800_4") & " :" & HLen(str사업자번호)
                        If HLen(DataChk) <> 170 Then strErr &= "[C레코드 총길이 오류 :" & HLen(DataChk) & "]" 'strErr &= Msg("CV800_22") & " :" & HLen(DataChk)
                        With g20
                            iCnt = .RowCount
                            .AddNewRow()

                            .Text("no", iCnt) = " "

                            If HLen(DataChk) = 170 Then
                                .Text("chk", iCnt) = "!OK!"
                            Else
                                .Text("chk", iCnt) = "!BAD!"
                            End If

                            .Text("data_ty", iCnt) = DataTy
                            .Text("bs_cd", iCnt) = str사업자번호
                            .Text("cust_info", iCnt) = str항목Tot
                            .Text("itm_a", iCnt) = DataChk & "@" 'str항목C + "P"
                        End With
                    End If

                Next
            End If


            ''-- END --------------------------------------------

            Dim ErrRow As Integer

            'If g20.RowCount > 0 Then ErrRow = g20.RowCount - 1

            If strErr <> "" Then
                With g70
                    ErrRow = .RowCount
                    .AddNewRow()

                    .Text("no", ErrRow) = " "
                    .Text("chk", ErrRow) = "!BAD!"
                    .Text("data_ty", ErrRow) = DataTy
                    .Text("rmk", ErrRow) = "C 레코드 :" & strErr
                End With
            End If

        Catch ex As Exception
            sInOutData = sInOutData + vbLf + Err.Description
            MessageError(ex, "InOutData")
        End Try
        Return sInOutData
    End Function


    '계산서매출계산서 합계
    Private Sub dTaxRecC(ByVal TaxKd As String, ByVal BizCd As String)
        Dim sInOutData As String = ""
        Try

            Dim DataTy As String

            Dim strA매출처수 As String = "", strA매출계산서매수 As String = "", strA매출금액 As String = ""
            Dim strA사업매출처수 As String = "", strA사업매출계산서매수 As String = "", str사업매출금액 As String = ""
            Dim strA개인매출처수 As String = "", strA개인매출계산서매수 As String = "", str개인매출금액 As String = ""
            Dim s사업매출Rmk As String = "", s개인매출Rmk As String = ""

            Dim strA매입처수 As String = "", strA매입계산서매수 As String = "", strA매입금액 As String = ""
            Dim s매입Rmk As String = "", s개인매입Rmk As String = ""

            Dim 거래처수T As Integer = 0, 계산서매수T As Integer = 0, 금액T As Double = 0
            Dim str거래처수T As String = "", str계산서매수T As String = "", str금액T As String = ""
            Dim sTotalRmk As String = ""

            Dim str기간 As String = ""

            '--------------------------------------------------------------------
            '매출 : DataRecordTy - 17 (매출), OutNo - 9001 (프로피디스켓)
            '매입 : DataRecordTy - 18 (매입), OutNo - 9501 (프로피디스켓)
            '--------------------------------------------------------------------
            If TaxKd = bc_계산서구분_매출 Then

                '********매출정보 변수 초기화
                strA매출처수 = "" : strA매출계산서매수 = "" : strA매출금액 = ""
                strA사업매출처수 = "" : strA사업매출계산서매수 = "" : str사업매출금액 = ""
                strA개인매출처수 = "" : strA개인매출계산서매수 = "" : str개인매출금액 = ""

                DataTy = "17"
            Else

                strA매입처수 = "" : strA매입계산서매수 = "" : strA매입금액 = ""
                s매입Rmk = "" : s개인매입Rmk = ""

                DataTy = "18"
            End If

            '--------------------------------------------------------------------
            ' 해당 사업장의 매입 또는 매출자료를 가지고 온다(매입 : D600100, 매출 : D600200)
            ' 레코드 자체를 해당 일자에 거래처별, 사업장별로 가지고 온다
            '--------------------------------------------------------------------
            Dim dRow As DataRow, dRows As DataRowCollection

            'Dim oParams As Object = Nothing
            'AddParam(oParams, "@bs_cd", BizCd)
            'AddParam(oParams, "@std_year", std_year.Text)
            'AddParam(oParams, "@term_ty", term_ty.Text)
            'AddParam(oParams, "@bill_ty", BillTy)

            'Dim dSet As DataSet = Open(Me.Name, "epdc560f_g3_sum", oParams)
            Dim dSet As DataSet = Rtn_dSet("g30_sum", bs_cd.Text, TaxKd)
            sInOutData = ""

            dRows = DataSetRows(dSet)

            If dRows.Count = 0 Then
                Me.Cursor = Cursors.Default
                Exit Sub
                'Return ""
            End If
            Dim Amt As Int64 = 0

            For Each dRow In dRows
                'strErr = ""

                '사업자chk = True
                거래처수T = +ToDec(dRow("P_cust_cnt")) + ToDec(dRow("B_cust_cnt"))
                계산서매수T = +ToDec(dRow("P_bill_cnt")) + ToDec(dRow("B_bill_cnt"))
                금액T = +ToDec(dRow("P_add_amt")) + ToDec(dRow("p_mis_amt"))
                sTotalRmk = IIf(ToDec(금액T) > 0, 0, 1)

                If TaxKd = bc_계산서구분_매출 Then
                    strA매출처수 = MultiKey(6, ToDec(dRow("P_cust_cnt")) + ToDec(dRow("B_cust_cnt")))
                    strA매출계산서매수 = MultiKey(6, ToDec(dRow("P_bill_cnt")) + ToDec(dRow("B_bill_cnt")))
                    Amt = ToDec(dRow("p_add_amt")) + ToDec(dRow("p_mis_amt"))
                    strA매출금액 = MultiKey(14, Amt)

                    ' If dRow("cust_kd") <> bc_거래형태_개인 Then

                    '******* 매입/매출자료 생성
                    '--------------------------------
                    '1. 사업자등록분
                    '--------------------------------
                    strA사업매출처수 = MultiKey(6, ToDec(dRow("B_cust_cnt")))
                    strA사업매출계산서매수 = MultiKey(6, ToDec(dRow("B_bill_cnt")))
                    Amt = ToDec(dRow("p_mis_amt"))
                    str사업매출금액 = MultiKey(14, Amt)
                    s사업매출Rmk = IIf(Amt > 0, 0, 1)
                    ' Else
                    '--------------------------------
                    '2. 주민기재분
                    '--------------------------------
                    strA개인매출처수 = MultiKey(6, ToDec(dRow("P_cust_cnt")))
                    strA개인매출계산서매수 = MultiKey(6, ToDec(dRow("P_bill_cnt")))
                    Amt = ToDec(dRow("p_add_amt"))
                    str개인매출금액 = MultiKey(14, Amt)
                    s개인매출Rmk = IIf(Amt > 0, 0, 1)
                    'End If
                Else

                    strA매입처수 = MultiKey(6, ToDec(dRow("P_cust_cnt")) + ToDec(dRow("B_cust_cnt")))
                    strA매입계산서매수 = MultiKey(6, ToDec(dRow("P_bill_cnt")) + ToDec(dRow("B_bill_cnt")))
                    Amt = ToDec(dRow("p_add_amt")) + ToDec(dRow("p_mis_amt")) + ToDec(dRow("b_add_amt"))
                    strA매입금액 = MultiKey(14, Amt)
                    s매입Rmk = IIf(Amt > 0, 0, 1)
                End If
            Next

            Dim strTaxoff As String
            Dim strItemA As String
            Dim Fullstr As String

            '----------------------------------------
            '자료구분, 기, 신고,세무서,일련번호
            '----------------------------------------
            strTaxoff = DataTy + GetLenText(v기수, 1) + GetLenText(v신고구분, 1) + _
                        GetLenText(TaxNo, 3) + Format(vBizCnt, "0#####")

            '----------------------------------------
            '귀속년도, 거래시작, 거래종료, 작성일자
            '----------------------------------------

            If Not IsDate(sFdt) Or Not IsDate(sTdt) Then
                MessageInfo("기초코드(FA680)에서 부가세신고기간을 확인하세요")
                Exit Sub
            End If

            Dim s_거래기간 As String

            s_거래기간 = Replace(sFdt, "-", "") + Replace(sTdt, "-", "")


            str기간 = tax_year.Text + s_거래기간 + vPrtdt

            '  MultiKey(6, ToDec(dRow("cust_cnt")))

            If TaxKd = bc_계산서구분_매출 Then
                strItemA = strA매출처수 + MultiKey(6, 계산서매수T) + sTotalRmk + MultiKey(14, 금액T) + _
                            strA사업매출처수 + strA사업매출계산서매수 + s사업매출Rmk + str사업매출금액 + _
                            strA개인매출처수 + strA개인매출계산서매수 + s개인매출Rmk + str개인매출금액 + _
                            Space(97)
                Fullstr = "C" + strTaxoff + str사업자번호 + str기간 + strItemA
            Else
                '                strItemA = 거래처수T + 계산서매수T + s매입Rmk + strA매입금액 + Space(151) + "P"
                strItemA = strA매입처수 + strA매입계산서매수 + s매입Rmk + strA매입금액 + Space(151)
                Fullstr = "C" + strTaxoff + str사업자번호 + str기간 + strItemA
            End If


            '[ 부가세전산매체자료생성 ]
            iCnt = 0
            With g30
                iCnt = .RowCount
                .AddNewRow()

                .Text("no", iCnt) = vBizCnt

                '-----------------------------------------------------------------------
                '1-4. 길이가 170이고 사업자등록번호 유무 또는 자리수 10자리 검사
                '-----------------------------------------------------------------------
                If HLen(Fullstr) = 230 Then
                    .Text("chk", iCnt) = "!OK!"
                Else
                    .Text("chk", iCnt) = "!BAD!"
                End If

                .Text("data_ty", iCnt) = "C"
                .Text("tax_off", iCnt) = strTaxoff
                .Text("bs_cd", iCnt) = str사업자번호
                .Text("cust_info", iCnt) = str기간
                .Text("itm_a", iCnt) = Fullstr & "@"
            End With

        Catch ex As Exception
            sInOutData = sInOutData + vbLf + Err.Description
            MessageError(ex, "계산서C레코드")
        End Try
        'Return sInOutData
    End Sub

    '계산서매출계산서 거래명세서
    Private Function dTaxRecD(ByVal TaxKd As String, ByVal BizCd As String) As String
        Dim sInOutData As String = ""
        Try

            Dim DataTy As String
            Dim 계산서매수T As Double = 0, 금액T As Double = 0, sRmk As String = ""

            Dim seq As Integer = 0
            Dim tseq As String = ""
            Dim str기간 As String = ""

            '--------------------------------------------------------------------
            '매출 : DataRecordTy - 17 (매출), OutNo - 9001 (프로피디스켓)
            '매입 : DataRecordTy - 18 (매입), OutNo - 9501 (프로피디스켓)
            '--------------------------------------------------------------------
            If TaxKd = bc_계산서구분_매출 Then
                DataTy = "17"
            Else
                DataTy = "18"
            End If

            '--------------------------------------------------------------------
            ' 해당 사업장의 매입 또는 매출자료를 가지고 온다(매입 : D600100, 매출 : D600200)
            ' 레코드 자체를 해당 일자에 거래처별, 사업장별로 가지고 온다
            '--------------------------------------------------------------------
            Dim dSet As DataSet = Rtn_dSet("fac610_g30", bs_cd.Text, TaxKd)
            'Dim p As New OpenParameters
            'p.Add("@bs_cd", BizCd)
            'p.Add("@std_year", tax_year.Text)
            'p.Add("@term_ty", mon_bc.Text)
            'p.Add("@bill_ty", TaxKd)

            'Dim dSet As DataSet = OpenDataSet("fac610_g30", p)
            If IsEmpty(dSet) Then
                Me.Cursor = Cursors.Default
                Return ""
            End If

            sInOutData = ""

            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = DataSetRows(dSet)
            Dim strTaxoff As String
            '----------------------------------------
            '자료구분, 기, 신고,세무서,일련번호
            '----------------------------------------
            strTaxoff = DataTy + GetLenText(v기수, 1) + GetLenText(v신고구분, 1) + _
                        GetLenText(TaxNo, 3)

            Dim strA매출사업자번호 As String, strA매출법인명 As String, str매출매수 As String, s매출Rmk As String, s매출금액 As String
            Dim strA매입사업자번호 As String, strA매입법인명 As String, str매입매수 As String, s매입Rmk As String, s매입금액 As String
            Dim strItemA As String, Fullstr As String = ""

            Dim K As Integer = 0
            Dim 일련번호 As String = ""
            Dim Amt As Int64 = 0
            '=====================
            For Each dRow In dRows

                K += 1
                일련번호 = Format(K, "0#####")
                Amt = ToDec(dRow("amt"))

                If TaxKd = bc_계산서구분_매출 Then
                    ' str사업자번호 = Replace(Trim(dSet.Tables(0).Rows(0)("bs_cd")), "-", "")

                    '                    strA매출사업자번호 = GetLenText(10, dRow("bs_cd"))
                    strA매출사업자번호 = Replace(Trim(dSet.Tables(0).Rows(0)("biz_no")), "-", "")
                    strA매출법인명 = GetLenText(dRow("cust_nm"), 40)
                    str매출매수 = MultiKey(5, ToDec(dRow("bill_cnt")))
                    s매출Rmk = IIf(Amt > 0, 0, 1)
                    s매출금액 = MultiKey(14, Amt)

                    strItemA = strA매출사업자번호 + strA매출법인명 + str매출매수 + s매출Rmk + s매출금액 + Space(136)
                Else
                    strA매입사업자번호 = Replace(Trim(dSet.Tables(0).Rows(0)("biz_no")), "-", "")
                    'strA매입사업자번호 = GetLenText(10, dRow("bs_cd"))
                    strA매입법인명 = GetLenText(dRow("cust_nm"), 40)
                    str매입매수 = MultiKey(5, ToDec(dRow("bill_cnt")))
                    s매입Rmk = IIf(Amt > 0, 0, 1)
                    s매입금액 = MultiKey(14, Amt)

                    strItemA = strA매입사업자번호 + strA매입법인명 + str매입매수 + s매입Rmk + s매입금액 + Space(136)
                End If

                With g30

                    iCnt = .RowCount
                    .AddNewRow()

                    .Text("no", iCnt) = K
                    Fullstr = "D" & strTaxoff & 일련번호 & str사업자번호 & strItemA

                    '-----------------------------------------------------------------------
                    '1-4. 길이가 170이고 사업자등록번호 유무 또는 자리수 10자리 검사
                    '-----------------------------------------------------------------------
                    If HLen(Fullstr) = 230 Then
                        .Text("chk", iCnt) = "!OK!"
                    Else
                        .Text("chk", iCnt) = "!BAD!"
                    End If

                    .Text("data_ty", iCnt) = "D"
                    .Text("tax_off", iCnt) = strTaxoff + 일련번호
                    .Text("bs_cd", iCnt) = str사업자번호
                    '.text("cust_info",iCnt) = str기간
                    .Text("itm_a", iCnt) = Fullstr & "@" ' strItemA + "P"
                End With
            Next

        Catch ex As Exception
            sInOutData = sInOutData + vbLf + Err.Description
            MessageError(ex, "계산서D레코드")
        End Try
        Return sInOutData
    End Function

#End Region

    '연산 : input value (총자리수, 입력값) 숫자형식은 앞자리 빈공간에 0으로 채운다
    Private Function MultiKey(ByVal TotLen As Integer, ByVal DouNum As String) As String
        Dim sMultiKey As String = Nothing
        Try
            Dim aLen As String, LastChk As String
            Dim sLen As Double, i As Double

            sMultiKey = ""

            '1. 음수인 경우는 MultiKey에 의해서 끝자리수를 변환해 준다.
            If CDbl(DouNum) < 0 Then
                '마지막 자리수 한자리를 연산한다. (데이타자체가 소수점 데이타가 없으므로 그냥 right 한자리만 체크한다)
                LastChk = CStr(Microsoft.VisualBasic.Right(DouNum, 1))

                DouNum = Replace(CStr(DouNum), ".", "")

                '음수값인 경우 (-) minus가 붙기때문에 자리수 빼기 하기 위해서 (abs 합수 사용해도 됨)
                '마지막자리수를 제외한 숫자
                aLen = Mid$(Replace(CStr(DouNum), "-", ""), 1, Len(Replace(CStr(DouNum), "-", "")) - 1)

                Select Case LastChk
                    Case "0"
                        sMultiKey = "}"
                    Case "1"
                        sMultiKey = "J"
                    Case "2"
                        sMultiKey = "K"
                    Case "3"
                        sMultiKey = "L"
                    Case "4"
                        sMultiKey = "M"
                    Case "5"
                        sMultiKey = "N"
                    Case "6"
                        sMultiKey = "O"
                    Case "7"
                        sMultiKey = "P"
                    Case "8"
                        sMultiKey = "Q"
                    Case "9"
                        sMultiKey = "R"
                End Select
            Else
                DouNum = Replace(CStr(DouNum), ".", "")
                '2. 음수가 아닌 경우는 값을 받아서 처리
                aLen = CStr(DouNum)
            End If

            '음수연산에 의해 자리수만큼 "0"을 입력하기 위해 X 삽입
            sMultiKey = aLen & sMultiKey

            sLen = TotLen - HLen(sMultiKey)

            For i = 1 To sLen
                sMultiKey = "0" + sMultiKey
            Next

        Catch ex As Exception
            MessageError(ex, "MultiKey")
        End Try

        Return sMultiKey

    End Function

    Private Function Rtn_dSet(ByVal GetId As String, Optional ByVal BsCd As String = "", Optional ByVal TaxKd As String = "") As DataSet
        Rtn_dSet = Nothing
        Try
            If BsCd = "" Then BsCd = bs_cd.Text
            Dim p As New OpenParameters
            p.Add("@co_cd", co_cd.Text)
            p.Add("@tax_year", tax_year.Text)
            p.Add("@mon_bc", mon_bc.Text)
            p.Add("@bs_cd", BsCd)
            p.Add("@tax_kd", TaxKd)
            p.Add("@work_id", GetId)
            Return OpenDataSet("fac610_sql", p)

        Catch ex As Exception
            MessageError(ex, "OpenDataSet")
        End Try

    End Function

    Private Sub btn_file0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_file0.Click
        Create_File(g10, " ")
    End Sub

    Private Sub btn_file1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_file1.Click
        Create_File(g20, "K")
    End Sub

    Private Sub btn_file2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_file2.Click
        Create_File(g30, "H")
    End Sub

    Private Sub btn_file3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_file3.Click
        Create_File(g40, "Z")
    End Sub

    Private Sub btn_file4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_file4.Click
        Create_File(g50, "J")
    End Sub

    Private Sub btn_file5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_file5.Click
        Create_File(g60, "A")
    End Sub

    Private Sub btn_file6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_file6.Click
        Create_File(g80, "B")
    End Sub

    Private Sub btn_file7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_file7.Click
        Create_File(g90, "P")
    End Sub

    Private Sub Create_File(ByVal oGrid As eGrid, ByVal sGubun As String)

        Try
            If oGrid.RowCount <= 0 Then Exit Sub


            'If DataChk() = False Then Exit Sub

            Dim j As Integer, i As Integer

            '---------------------------------------------------
            '파일명 : "K"  OR "H" + 사업자등록번호 앞자리 7자리
            '확장자 : 사업자등록번호 뒷자리 3자리
            '---------------------------------------------------
            사업자1 = ""
            사업자2 = ""

            사업자1 = Microsoft.VisualBasic.Right(str사업자번호, 3)
            사업자2 = sGubun + Microsoft.VisualBasic.Left(str사업자번호, 7)

            'SaveFileDialog1.FLAGS = cdlOFNExtensionDifferent
            Dim SaveDialog As New SaveFileDialog

            SaveDialog.CreatePrompt = True
            SaveDialog.OverwritePrompt = True
            SaveDialog.Title = "부가가치세 전산매체 파일 저장하기"
            'SaveDialog.Filter = "텍스트 파일(*.*)|*." + 사업자1

            If sGubun = " " Then
                SaveDialog.Filter = "텍스트 파일(*.*)|*." + "101"
                SaveDialog.FileName = Replace(Format(Now, "yyyy-MM-dd"), "-", "") + "." + "101"
            Else
                SaveDialog.Filter = "텍스트 파일(*.*)|*." + 사업자1
                SaveDialog.FileName = 사업자2 + "." + 사업자1
            End If

            'SaveFileDialog1.ShowDialog()
            '수정20040427
            If SaveDialog.ShowDialog <> System.Windows.Forms.DialogResult.OK Then
                SaveDialog.Dispose()
                Exit Sub
            End If

            btn_file1.Enabled = False

            If Err.Number = 1 Then Exit Sub '???

            If SaveDialog.FileName <> "" Then

                Me.Cursor = Cursors.WaitCursor

                Dim Korean As System.Text.Encoding

                '2바이트 완성형 코드 (ksc-5601)
                Korean = System.Text.Encoding.GetEncoding(949)
                Dim sw As IO.StreamWriter = New IO.StreamWriter(SaveDialog.FileName, False, Korean)
                Dim StrLine As String = ""
                For j = 0 To oGrid.RowCount - 1

                    i += 1
                    oGrid.RowIndex = i - 1
                    StrLine = Replace(oGrid.Text("itm_a"), "@", "") & vbNewLine
                    '[K : 세금계산서, H:계산서]
                    sw.Write(StrLine)

                    'If sGubun = "K" Then
                    '    '마지막행에도 한row를 생성해야만!!! 마지막데이타를 읽는다
                    '    'sw.Write(oGrid.Text(2, j) + g20.Text(3, j) + oGrid.Text(4) +  oGrid.Text(5) + oGrid.Text(6) + vbNewLine)
                    '    'sw.Write(Mid(oGrid.Text(6), 1, 170) + vbNewLine)
                    '    sw.Write(StrLine)
                    '    'HLen(Mid(oGrid.Text(6), 1, 170))
                    'ElseIf sGubun = "H" Then
                    '    sw.Write(StrLine)
                    'Else
                    '    sw.Write(StrLine)
                    'End If
                Next j

                sw.Close()

                btn_file1.Enabled = True
                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            MessageError(ex, "btnFile_Click")
            Me.Cursor = Cursors.Default
            btn_file1.Enabled = True
        End Try
    End Sub

    Private Function HLen(ByVal fldVal As Object) As Long
        HLen = 0

        Dim Korean As System.Text.Encoding
        Korean = System.Text.Encoding.GetEncoding(949)

        HLen = Korean.GetByteCount(fldVal)
    End Function

    Private Function DataChk() As Boolean
        Try
            Dim iRow As Integer

            DataChk = True

            For iRow = 0 To g20.RowCount - 1
                If g20.Text("chk", iRow) = "!BAD!" Then
                    MessageError("오류 데이타가 존재합니다.")
                    'PutError("CV800_23")
                    Return False
                End If
            Next iRow

        Catch ex As Exception
            MessageError(ex, "DataChk")
        End Try
    End Function

    Private Sub SetTerm()

        'Dim params As Object = Nothing
        'AddParam(params, "@std_year", std_year.Text)
        'AddParam(params, "@term_ty", term_ty.Text)
        'Dim dSet As DataSet = Open("epdc500f", "get_tax_term", params)

        If mon_bc.Text = "" Then
            v_거래기간 = ""
            v기수 = ""
            v신고구분 = ""
            v신고범위 = ""
            Exit Sub
        End If

        Dim dSet As DataSet = Rtn_dSet("get_tax_term", bs_cd.Text)
        If IsEmpty(dSet) Then
            MessageError("신고분기 정보오류")
            'PutNote("DC500_1")
            Exit Sub
        End If

        sFdt = DataValue(dSet, "fr_dt")
        sTdt = DataValue(dSet, "to_dt")

        If Not IsDate(sFdt) Or Not IsDate(sTdt) Then
            MessageInfo("기초코드(FA680)에서 분기설정기간을 확인하세요")
            Exit Sub
        End If

        v_거래기간 = Mid(Replace(sFdt, "-", ""), 3, 6) & _
                     Mid(Replace(sTdt, "-", ""), 3, 6) & _
                     Mid(Replace(sTdt, "-", ""), 3, 6)

        v_작성일자 = DataValue(dSet, "pay_dt")
        prt_dt.Text = DataValue(dSet, "pay_dt")
        v_작성일자 = Mid(Replace(v_작성일자, "-", ""), 1, 10)

        v_수출거래기간 = Replace(sFdt, "-", "") & Replace(sTdt, "-", "")
        v_신고시작년월 = Mid(Replace(sFdt, "-", ""), 1, 6)
        v_신고끝년월 = Mid(Replace(sTdt, "-", ""), 1, 6)

        v기수 = DataValue(dSet, "cnt_chk")
        v신고구분 = DataValue(dSet, "fix_chk")
        v신고범위 = DataValue(dSet, "pay_mon")
        v반기내월순번 = DataValue(dSet, "pay_serl")

    End Sub

#Region " Printer "
    Private Sub Printer()
        Try

            'If Not epdc560f_f1.CheckBeforeOpen Then Exit Sub

            'If epdc560f_f1.RecordCount < 0 Then
            '    MsgNote("매체신고 대상이 존재하지 않습니다")
            '    Exit Sub
            'End If

            '[출력시작]

            Dim p As New OpenParameters
            p.Add("@tax_year", tax_year.Text)
            p.Add("@mon_bc", mon_bc.Text)
            p.Add("@bs_cd", bs_cd.Text)
            p.Add("@tax_nm", taxoff_cd.EditText)
            p.Add("@prt_dt", prt_dt.Text)
            p.Add("@out_no", "9001")
            p.Add("@out_acnt", ToDec(strA총거래처수))
            p.Add("@out_bcnt", ToDec(strA총세금계산서매수))
            p.Add("@out_amt", ToDec(strA총공급가액))
            p.Add("@out_vat", ToDec(strA총세액))
            p.Add("@in_no", "9501")
            p.Add("@in_acnt", ToDec(strB총거래처수))
            p.Add("@in_bcnt", ToDec(strB총세금계산서매수))
            p.Add("@in_amt", ToDec(strB총공급가액))
            p.Add("@in_vat", ToDec(strB총세액))
            p.Add("@file_nm", 사업자1 & "." & 사업자2)
            p.Add("@log_emp", Parameter.Login.EmpNo)

            'Prime.Report.Report.Load(Me.Name, "fac560_prt", p, Me.Text)
            System7.ReportView.LoadView("FAC610", "", "fac610_print", p, )

        Catch ex As Exception
            MessageError(ex, "Open_Form")
        End Try
    End Sub
#End Region

    ''---------------------------------------------------
    '' 5.전산매출합계, 6.전산매입합계 2010.02.24 김종우
    ''---------------------------------------------------
    Private Function Sum_Ele_Data(ByVal TaxKd As String) As String

        Try

            Dim sErr As String = ""
            Dim dRow As DataRow, dRows As DataRowCollection

            'bill_ty.Text = bc_계산서구분_매출
            'bill_ty.Text = bc_계산서구분_매입

            'Dim oParams As Object = Nothing
            'AddParam(oParams, "@std_year", std_year.Text)
            'AddParam(oParams, "@term_ty", term_ty.Text)
            'AddParam(oParams, "@bs_cd", bs_cd.Text)
            'AddParam(oParams, "@bill_ty", BillTy)

            Dim dsSet As DataSet = Rtn_dSet("get_ele_g10_sum", bs_cd.Text, TaxKd)
            'Dim dsSet As DataSet = Open(Me.Name, "get_ele_g1_sum", oParams) '5.전산매출자료, 6.전산매입자료 2010.02.24 김종우

            If IsEmpty(dsSet) Then
                '부가세집계 자료가 없습니다.
                'PutNote("DC560_2")
                Return ""
            End If

            dRows = DataSetRows(dsSet)

            If dRows.Count = 0 Then
                ' PutNote("DC560_2")
                Return ""
            End If

            Dim dsCnt As Integer = 0

            With g20

                If sErr = "" Then

                    For Each dRow In dRows
                        dsCnt = .RowCount
                        .AddNewRow()
                        .Text("no", dsCnt) = " "
                        .Text("chk", dsCnt) = dRow("chk")
                        .Text("data_ty", dsCnt) = dRow("data_ty")
                        .Text("bs_cd", dsCnt) = dRow("bs_cd")
                        .Text("cust_info", dsCnt) = dRow("cust_info")
                        .Text("itm_a", dsCnt) = dRow("itm_a") & "@"
                    Next
                End If
            End With

        Catch ex As Exception
            MessageError(ex, "SumData()")
        End Try
        Return ""

    End Function

    Private Sub term_ty_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles mon_bc.TextChanged
        Try
            Me.SetTerm()
        Catch ex As Exception
            MessageError(ex, "term_ty_Change")
        End Try
    End Sub

    Private Sub std_year_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tax_year.TextChanged
        Try
            Me.SetTerm()
        Catch ex As Exception
            MessageError(ex, "std_year_Change")
        End Try
    End Sub

    Private Sub bs_cd_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bs_cd.TextChanged
        Me.Get_TaxBc()
    End Sub

    Private Sub Get_TaxBc()
        Try
            If bs_cd.Text = "" Then
                Exit Sub
            End If

            Dim dSet As DataSet = Rtn_dSet("get_tax_no", bs_cd.Text) 'OpenDataSet("fac560", p) 'Open(Me.Name, "get_tax_no", p)

            If IsEmpty(dSet) Then
                taxoff_cd.Text = ""
                MessageInfo("[사업장 등록]에서 [관활세무서]를 등록하세요")
                Exit Sub
            End If

            'taxoff_cd.Text = DataValue(dSet, "tax_no")
            taxoff_cd.Text = DataValue(dSet, "cust_cd")
            TaxNo = DataValue(dSet, "tax_no")
            If TaxNo = "" Then
                MessageInfo("[거래처 등록]에서 관활세무서의 [세무서코드]를 등록하세요")
                Exit Sub
            End If

        Catch ex As Exception
            MessageError(ex, "bs_cd_Change")
        End Try
    End Sub


    Private Sub Messagewaring(ByVal p1 As String)
        Throw New NotImplementedException
    End Sub

    Private Sub prt_dt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles prt_dt.TextChanged
        vPrtdt = ""
        If prt_dt.Text <> "" Then vPrtdt = Replace(Trim(prt_dt.Text), "-", "")
    End Sub

End Class

