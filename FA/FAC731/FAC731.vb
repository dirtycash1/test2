Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAC731
    Private v_OriginDir As String
    Private j As Integer
    Dim str사업자번호 As String, 사업자번호chk As Integer, str거래기간 As String
    Dim sFdt As String, sTdt As String

    Dim 수출번호_chk As Integer
    Dim orTy As Integer

    '********수출실적정보
    Dim str총건수 As String, str총외화금액 As String, str총원화금액 As String
    Dim str수출건수 As String, str수출외화금액 As String, str수출원화금액 As String
    Dim str영세율건수 As String, str영세율외화금액 As String, str영세율원화금액 As String
    Dim iCnt As Integer
    Dim v_TermDt As String, v_WorkDt As String
    Dim v_Month As String
    Dim bc_전산매체_수출 As String, bc_전산매체_영세 As String
    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Init_Form()
    End Sub

    Public Sub Init_Form()
        bc_전산매체_수출 = ""
        bc_전산매체_영세 = ""
    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    '    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

    '        Select Case mty

    '            Case MenuType.New

    '            Case MenuType.Save

    '            Case MenuType.Delete

    '            Case Else

    '                MyBase.MenuButton_Click(mty)

    '        End Select

    '    End Sub

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

    Private Sub bs_cd_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bs_cd.TextChanged
        Try
            Dim p As Object = Nothing
            p.Add("@bs_cd", bs_cd.Text)
            Dim dSet As DataSet = OpenDataSet("get_tax_no", p)

            If IsEmpty(dSet) Then
                taxoff_cd.Text = ""
                MessageInfo("[사업장 등록]에서 [관활세무서]를 등록하세요")
                Exit Sub
            End If

            taxoff_cd.Text = DataValue(dSet, "tax_no")
            If taxoff_cd.Text = "" Then
                MessageInfo("[거래처 등록]에서 관활세무서의 [세무서코드]를 등록하세요")
                Exit Sub
            End If
            'If IsValid(dSet) Then
            '    taxoff_cd.Text = datavalue(dSet, "tax_no")
            'End If
        Catch ex As Exception
            MessageError(ex, "bs_cd_Change")
        End Try
    End Sub

    Private Sub std_year_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles std_year.TextChanged
        SetTerm()
    End Sub

    Private Sub term_ty_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles term_ty.TextChanged
        SetTerm()
    End Sub

    Private Sub btn_file_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_file.Click
        Try
            Dim 사업자1 As String, 사업자2 As String

            If g10.RowCount <= 0 Then Exit Sub

            If DataChk() = False Then Exit Sub

            Dim i As Integer, j As Integer
            '---------------------------------------------------
            '파일명 : "A" + 사업자등록번호 앞자리 7자리
            '확장자 : 사업자등록번호 뒷자리 3자리
            '---------------------------------------------------
            사업자1 = ""
            사업자2 = ""

            사업자1 = Microsoft.VisualBasic.Right(str사업자번호, 3)
            사업자2 = filenm.Text + Microsoft.VisualBasic.Left(str사업자번호, 7)

            Dim SaveDialog As New SaveFileDialog

            SaveDialog.CreatePrompt = True
            SaveDialog.OverwritePrompt = True
            SaveDialog.Title = "부가가치세 전산매체 파일 저장하기"
            SaveDialog.Filter = "텍스트 파일(*.*)|*." + 사업자1

            SaveDialog.FileName = 사업자2

            '   SaveFileDialog1.ShowDialog()
            '수정20040427
            If SaveDialog.ShowDialog <> System.Windows.Forms.DialogResult.OK Then
                SaveDialog.Dispose()
                Return
            End If

            btn_file.Enabled = False

            If Err.Number = 1 Then Exit Sub '???

            If SaveDialog.FileName <> "" Then

                Me.Cursor = Cursors.WaitCursor

                Dim Korean As System.Text.Encoding

                '2바이트완성형코드 (ksc-5601)
                Korean = System.Text.Encoding.GetEncoding(949)
                Dim sw As IO.StreamWriter = New IO.StreamWriter(SaveDialog.FileName, False, Korean)

                With g10
                    For j = 0 To .RowCount - 1

                        i += 1
                        .RowIndex = i - 1

                        '마지막행에도 한row를 생성해야만,, 마지막데이타를 읽는다
                        sw.Write(.Text(4, j) + .Text(5, j).Replace("P", "") + vbNewLine)

                        'sw.Write(epdc570f_g1.Text(2, j) + epdc570f_g1.Text(3, j) + epdc570f_g1.Value(4) + _
                        '                   epdc570f_g1.Value(5) + vbNewLine)
                    Next j
                End With


                sw.Close()

                btn_file.Enabled = True
                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            MessageError(ex, "File생성")
            Me.Cursor = Cursors.Default
            btn_file.Enabled = True
        End Try
    End Sub

    '[데이타부]
    Private Function InOutData(ByVal BizCd As String) As String
        Try
            Dim k As Integer
            Dim 일련번호 As String ', 수출신고번호 As String
            Dim 환율 As String
            Dim 항목A As String, 환율Int As Integer, 환율Dec As Decimal, 환율dLen As Integer
            Dim str환율Int As String, str환율Dec As String
            Dim strErr As String = ""

            '수출하는 재화의 외화금액, 원화금액
            Dim 수출TOT As Decimal, 수출wTOT As Decimal

            '기타영세율 적용분의 외화금액, 원화금액
            Dim 영세율TOT As Decimal, 영세율wTOT As Decimal


            '********수출실적정보변수 초기화
            str총건수 = "" : str총외화금액 = "" : str총원화금액 = ""
            str수출건수 = "" : str수출외화금액 = "" : str수출원화금액 = ""
            str영세율건수 = "" : str영세율외화금액 = "" : str영세율원화금액 = ""

            Dim dataRecordTy As String

            'Dim sTerm As String
            'sTerm = "  [ AND	a.term_ty = '" & term_ty.Text & "' ]"
            'If term_ty.Text < "D640300" Then
            '    sTerm = "[ AND  A.term_ty  in 	" & _
            '                " (SELECT base_in_cd FROM EPZZ300T WHERE GROUP_CD = 'D640' AND ISNULL(mana7,'') = '" & term_ty.Text & "' ) ]"
            'End If

            Dim p As New OpenParameters
            p.Add("@std_year", std_year.Text)
            p.Add("@bs_cd", bs_cd.Text)
            p.Add("@term_ty", term_ty.Text)
            'AddParam(sqlParams, "@term_ty", sTerm)

            '--------------------------------------------------------------------
            ' 해당 사업장의 수출실적자료를 가지고 온다
            ' 해당 사업장의 영세율자료를 가지고 온다
            '--------------------------------------------------------------------
            '            AddParam(sqlParams2, "@term_ty", term_ty.Text)
            Dim dSetExp As DataSet = OpenDataSet("get_export_data", p)
            Dim dSetZero As DataSet = OpenDataSet("get_taxzero_data", p)

            '--------------------------------------------------------------------
            '데이타체크
            '--------------------------------------------------------------------
            Dim digChk As String

            digChk = Mid(str사업자번호, 1, 3)
            If digChk < "101" Or digChk > "622" Then strErr += "[사업자번호 오류 앞자리 101이하이거나 622 초과]" ' strErr += Msg("CV800_2")
            If HLen(v_Month) <> 6 Then strErr += "[귀속년월길이오류 :" & v_Month & "]" 'strErr += Msg("CV800_12") & " :" & v_Month
            If Not IsNumeric(v_Month) Then strErr += "[귀속년월타입오류 :" & v_Month & "]" 'strErr += Msg("CV800_15") & " :" & v_Month

            InOutData = ""
            '--------------------------------------------------------------------
            '1. 합계자료 : DataRecordTy - 2, Space(51)
            '--------------------------------------------------------------------
            Dim ItemExp As String, ItemZero As String, ItemSum As String

            Dim expRow As DataRow, expRows As DataRowCollection
            Dim zeroRow As DataRow, zeroRows As DataRowCollection

            expRows = DataSetRows(dSetExp)
            zeroRows = DataSetRows(dSetZero)

            For Each expRow In expRows
                수출TOT += ToDec(expRow("amt"))
                수출wTOT += ToDec(expRow("wamt"))
            Next

            For Each zeroRow In zeroRows
                영세율TOT += ToDec(zeroRow("amt"))
                영세율wTOT += ToDec(zeroRow("wamt"))
            Next

            ' 총합계
            str총건수 = MultiKey(7, ToDec(dSetExp.Tables(0).Rows.Count) + ToDec(dSetZero.Tables(0).Rows.Count))
            str총외화금액 = MultiKey(15, ToDec(DigitChg(수출TOT + 영세율TOT)))
            str총원화금액 = MultiKey(15, ToDec(DigitChg(수출wTOT + 영세율wTOT, 15, 0)))

            ' 수출 자료
            str수출건수 = MultiKey(7, ToDec(dSetExp.Tables(0).Rows.Count))
            str수출외화금액 = MultiKey(15, ToDec(DigitChg(수출TOT)))
            str수출원화금액 = MultiKey(15, ToDec(DigitChg(수출wTOT, 15, 0)))

            ' 영세율 자료
            str영세율건수 = MultiKey(7, ToDec(dSetZero.Tables(0).Rows.Count))
            str영세율외화금액 = MultiKey(15, ToDec(DigitChg(영세율TOT)))
            str영세율원화금액 = MultiKey(15, ToDec(영세율wTOT))

            ' 수출실적 자료구성
            ItemSum = str총건수 & str총외화금액 & str총원화금액
            ItemExp = str수출건수 & str수출외화금액 & str수출원화금액
            ItemZero = str영세율건수 & str영세율외화금액 & str영세율원화금액

            'ItemSum = ItemSum & ItemExp
            'ItemZero = ItemZero


            '******************************************************
            ' B레코드 생성 START
            '******************************************************
            dataRecordTy = tot.ToDec


            '[기본항목 : 자료구분 + 귀속년월 + 신고구분 + 사업자등록번호]
            Dim BastItem As String
            Dim fullItem As String

            BastItem = dataRecordTy & v_Month & ToDec(orTy) & str사업자번호
            fullItem = BastItem & ItemSum & ItemExp & ItemZero & Space(51)

            If HLen(fullItem) <> leng.ToDec Then strErr += "[B레코드총길이오류 :" & HLen(fullItem) & "]" 'strErr += Msg("CV800_17") & " :" & HLen(fullItem)

            iCnt = 0
            With g10
                iCnt = .RowCount - 1

                .AllowAddRows = True

                iCnt += 1
                .RowIndex = iCnt - 1

                .Text("no") = "0"

                If HLen(fullItem) = leng.ToDec Then
                    .Text("chk") = "!OK!"
                Else
                    .Text("chk") = "!BAD!"
                End If

                .Text("data_ty") = dataRecordTy
                .Text("cust_info") = BastItem
                .Text("biz_no") = str사업자번호
                .Text("itemA") = ItemSum & ItemExp & ItemZero + Space(51) + "P"
            End With



            iCnt = 0
            If strErr <> "" Then
                With g20
                    iCnt = .RowCount - 1
                    .AllowAddRows = True

                    iCnt += 1
                    .RowIndex = iCnt - 1

                    .Text("no") = "0"
                    .Text("chk") = "!BAD!"
                    .Text("biz_no") = str사업자번호
                    .Text("data_ty") = dataRecordTy
                    .Text("rmk") = "B레코드 :" & strErr
                End With
            End If

            '******************************************************
            ' B레코드 생성 END
            '******************************************************

            ' Exit Function

            '******************************************************
            ' C레코드 생성 START
            '******************************************************

            dataRecordTy = data.Text
            strErr = ""

            Dim cntWhile As Integer
            Dim ErrRow As Integer
            cntWhile = 1
            Dim dRow As DataRow, objRows As DataRowCollection
            '----------------------------------------------
            '2. cntWhile =1 (수출재화), 2(영세율)
            '----------------------------------------------
            Dim appTy As Integer
            appTy = 2


            If prt_ty.Text = bc_전산매체_수출 Then
                appTy = 1
                cntWhile = 1
            End If

            If prt_ty.Text = bc_전산매체_영세 Then
                appTy = 2
                cntWhile = 2
            End If

            With g10
                j = 0

                Do While cntWhile <= appTy '2

                    If cntWhile = 1 Then
                        objRows = expRows
                    Else
                        objRows = zeroRows
                    End If

                    Dim sOrderNo As String, sShipDt As String, sCury As String

                    iCnt = .RowCount - 1
                    ErrRow = 0
                    If g20.RowCount > 0 Then ErrRow = g20.RowCount - 1



                    For Each dRow In objRows
                        수출번호_chk = True
                        '       iCnt = .RowCount - 1

                        .AllowAddRows = True
                        j = j + 1
                        iCnt += 1
                        .RowIndex = iCnt - 1


                        'If j = 180 Then
                        '    MsgBox("aa")
                        'End If

                        일련번호 = Format(j, "0######")

                        'If j = 401 Then
                        '    MsgBox("aa")

                        'End If
                        '------------------------------------------------------------------------------------
                        '2-1. 수출신고번호 체크(자리수 "-" 빼고 15자리 체크한다), 선적일자, 통화코드, 환율
                        '------------------------------------------------------------------------------------
                        sOrderNo = Replace(Trim(dRow("approv_no")), "-", "")
                        sShipDt = Replace(Trim(dRow("ship_dt")), "-", "") 'Format(dRow("ship_dt"), "yyyyMMdd")
                        sCury = dRow("cury_nm")

                        If HLen(sOrderNo) <> 15 Or sOrderNo = "" Then strErr += "[수출신고번호오류 :" & HLen(sOrderNo) & "]" 'strErr += Msg("CV800_18") & ": " & HLen(sOrderNo)
                        If HLen(sShipDt) <> 8 Then strErr += "[선적일자길이오류 :" & HLen(sOrderNo) & "]" 'strErr += Msg("CV800_19") & ": " & HLen(sShipDt)
                        If Not IsNumeric(sShipDt) Then strErr += "[선적일자타입오류 :" & sShipDt & "]" 'strErr += Msg("CV800_20") & ": " & sShipDt
                        If HLen(sCury) <> 3 Then strErr += "[통화길이오류 :" & HLen(sCury) & "]" 'strErr += Msg("CV800_21") & ": " & HLen(sCury)

                        '-------------------------------------------
                        ' 환율소수점 처리(9(05) V9(4)로 셋팅
                        '-------------------------------------------
                        If ToDec(dRow("exch_rt")) <> 0 Then
                            str환율Int = Replace(ToDec(dRow("exch_rt")), ".", "")
                            환율 = "0" + str환율Int

                            ''OO' Start 2009-08-25 김종우: 1807.06이 1807.60으로 표시되는 문제.
                            ''환율Int = Int(Dec(dRow("exch_rt")))
                            ''str환율Int = ToDec(환율Int)
                            ''환율dLen = Len(Replace(Dec(dRow("exch_rt")), ".", "")) - Len(str환율Int)
                            ''For k = 1 To 5 - Len(str환율Int)
                            ''    str환율Int = "0" & str환율Int
                            ''Next

                            ''If 환율dLen <> 0 Then
                            ''    환율Dec = Microsoft.VisualBasic.Right(Replace(Dec(dRow("exch_rt")), ".", ""), 환율dLen)
                            ''    str환율Dec = ToDec(환율Dec)
                            ''    For k = 1 To 4 - Len(str환율Dec)
                            ''        str환율Dec = str환율Dec & "0"
                            ''    Next
                            ''Else
                            ''    str환율Dec = "0000"
                            ''End If
                            ''환율 = str환율Int & str환율Dec
                            'OO' End 2009-08-25 김종우: 1807.06이 1807.60으로 표시되는 문제.
                        Else
                            환율 = "000000000"
                        End If

                        수출TOT = 수출TOT + ToDec(dRow("amt"))
                        수출wTOT = 수출wTOT + ToDec(dRow("wamt"))

                        '--------------------------------
                        ' 2-2. 외화금액, 원화금액
                        '--------------------------------
                        Dim 외화금액 As Decimal, Str외화금액 As String
                        Dim 원화금액 As Decimal, Str원화금액 As String

                        외화금액 = 0
                        원화금액 = 0
                        Str외화금액 = ""
                        Str원화금액 = ""

                        외화금액 = ToDec(dRow("amt"))
                        원화금액 = ToDec(dRow("wamt"))

                        Str외화금액 = MultiKey(15, DigitChg(외화금액))
                        Str원화금액 = MultiKey(15, DigitChg(원화금액, 15, 0))

                        '--------------------------------
                        '2-3.수출정보를 항목A에 나열
                        '--------------------------------
                        BastItem = dataRecordTy & v_Month & ToDec(orTy) & str사업자번호
                        항목A = 일련번호 & sOrderNo & sShipDt & sCury & 환율 & Str외화금액 & Str원화금액
                        fullItem = BastItem + 항목A & Space(90)

                        '--------------------------------
                        '총길이확인
                        '--------------------------------
                        If HLen(fullItem) <> leng.ToDec Then strErr += "[C 레코드총길이오류 :" & HLen(fullItem) & "]" 'strErr += Msg("CV800_22") & ": " & HLen(fullItem)

                        '--------------------------------
                        '항목입력시킴
                        '--------------------------------
                        .Text("no") = j

                        If HLen(fullItem) = leng.ToDec And 수출번호_chk = True Then
                            .Text("CHK") = "!OK!"
                        Else
                            .Text("CHK") = "!BAD!"
                        End If
                        .Text("data_ty") = dataRecordTy
                        .Text("cust_info") = BastItem
                        .Text("biz_no") = str사업자번호
                        .Text("itemA") = 항목A & Space(90) + "P"


                        ' iCnt = 0
                        If strErr <> "" Then
                            With g20

                                ErrRow += 1
                                .AllowAddRows = True
                                .RowIndex = ErrRow - 1

                                .Text("no") = j
                                .Text("chk") = "!BAD!"

                                .Text("data_ty") = dataRecordTy
                                .Text("rmk") = "C 레코드 :" & strErr

                            End With
                        End If
                        strErr = ""
                    Next

                    cntWhile += 1

                Loop
            End With
            '******************************************************
            ' C레코드 생성 END
            '******************************************************


        Catch ex As Exception
            InOutData = ""
            InOutData = InOutData + vbLf + Err.Description
            MessageError(ex, "InOutData" & j)
        End Try
    End Function

    '연산 : input value (총자리수, 입력값) 숫자형식은 앞자리 빈공간에 0으로 채운다
    Private Function MultiKey(ByVal TotLen As Integer, ByVal DouNum As Double) As String
        Dim sMultiKey As String = Nothing
        Try
            Dim aLen As String, LastChk As String
            Dim sLen As Double, i As Double

            sMultiKey = ""

            '1. 음수인 경우는 MultiKey에 의해서 끝자리수를 변환해 준다.
            If DouNum < 0 Then
                '마지막 자리수 한자리를 연산한다. (데이타자체가 소수점 데이타가 없으므로 그냥 right 한자리만 체크한다)
                LastChk = CStr(Microsoft.VisualBasic.Right(DouNum, 1))

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

    Private Function DigitChg(ByVal sNum As Decimal, Optional ByVal dInt As Integer = 13, _
                                Optional ByVal dDec As Integer = 2) As String
        Dim sInt As String
        Dim sDec As String
        Dim maxLen As Integer
        Dim sDel As String

        '[정수만 가지고 온다]
        '[음수인경우 (-)를 제거한다]
        sInt = Fix(sNum)

        If sNum < 0 Then sInt = sInt * -1

        '소수점제외한 숫자
        sDel = Replace(sNum, ".", "")

        '[최대자리수]
        maxLen = Len(sDel)

        '[소수자리]
        sDec = Mid(sDel, Len(sInt) + 1, maxLen)

        '정수자리 13, 소수 2자리

        Dim sIntZero As String
        Dim sDecZero As String

        sIntZero = "000000000000000"
        sDecZero = "00000"


        If sNum > 0 Then
            DigitChg = Microsoft.VisualBasic.Right(sIntZero & sInt, dInt) & Microsoft.VisualBasic.Left(sDec & sDecZero, dDec)
        Else
            DigitChg = "-" & Microsoft.VisualBasic.Right(sIntZero & sInt, dInt) & Microsoft.VisualBasic.Left(sDec & sDecZero, dDec)
        End If


        'sInt = Microsoft.VisualBasic.Right(sIntZero & Str(sInt), 13)
        'sDel = Microsoft.VisualBasic.Left(sDecZero & Str(sInt), 2)

        Return DigitChg
    End Function

    Private Sub SetTerm()

        Dim p As New OpenParameters

        p.Add("@std_year", std_year.Text)
        p.Add("@term_ty", term_ty.Text)
        Dim dSet As DataSet = OpenDataSet("get_tax_term", p)

        If IsEmpty(dSet) Then
            MessageWarning("신고분기 정보오류")
            'PutNote("DC500_1")
            Exit Sub
        End If

        Dim sFdt As String, sTdt As String
        sFdt = DataValue(dSet, "fr_dt")
        sTdt = DataValue(dSet, "to_dt")

        If Not IsDate(sFdt) Or Not IsDate(sTdt) Then
            MessageInfo("기초코드(D640)에서 분기설정기간을 확인하세요")
            Exit Sub
        End If

        'str거래기간 = 거래기간 & 작성일자
        str거래기간 = Mid(Replace(sFdt, "-", ""), 3, 6) & _
                      Mid(Replace(sTdt, "-", ""), 3, 6) & _
                      Mid(Replace(sTdt, "-", ""), 3, 6)
        desc.Text = "☞ 신고기간 : " & sFdt & " ~ " & sTdt
        'label13.Text = "☞ " + sFdt + " ~ " + sTdt

        ''[거래기간, 작성일자, 귀속년월]       
        v_TermDt = Replace(Trim(sFdt), "-", "") & Replace(Trim(sTdt), "-", "")
        v_WorkDt = Replace(Trim(sTdt), "-", "")
        v_Month = Mid(Replace(Trim(sTdt), "-", ""), 1, 6)

        Dim sTerm As String = DateDiff(DateInterval.Month, CDate(sFdt), DateAdd(DateInterval.Day, 1, CDate(sTdt)))
        Select Case sTerm
            Case "1"
                orTy = "1"
            Case "2"
                orTy = "2"
            Case "3"
                orTy = "3"
            Case Else
                orTy = "4"
        End Select

    End Sub

    Private Function DataChk() As Boolean
        Try
            Dim Irow As Integer

            DataChk = True
            With g10
                For Irow = 0 To .RowCount - 1
                    If .Text("chk", Irow) = "!BAD!" Then
                        MessageWarning("오류 데이타가 존재합니다.")
                        'PutError("CV800_23")
                        DataChk = False
                        Exit Function
                    End If
                Next Irow
            End With

        Catch ex As Exception
            MessageError(ex, "DataChk")
        End Try
    End Function

    Private Function HLen(ByVal fldVal As Object) As Long
        HLen = 0
        Dim Korean As System.Text.Encoding
        Korean = System.Text.Encoding.GetEncoding(949)

        HLen = Korean.GetByteCount(fldVal)

    End Function

    Private Function LeftB(ByVal Str As String, ByVal Len As Integer) As String
        LeftB = ""

        Dim i As Integer, j As Integer, strTemp As String

        i = 1
        For j = 1 To Len

            strTemp = Mid(Str, i, 1)

            '1바이트일때
            If Microsoft.VisualBasic.Len(strTemp) = HLen(strTemp) Then
                LeftB = LeftB & strTemp
                i += 1
                'j += 1
            Else
                '2바이트인데 Len = 1이면 " "
                If Len = 1 Then
                    LeftB = " "
                Else
                    '2바이트인데 남은 자리가 1바이트일때
                    If j = Len Then
                        LeftB = LeftB & " "
                    Else
                        ''
                        'If Len - j = 1 Then
                        '    LeftB = LeftB & " "
                        'Else
                        '2바이트일때
                        LeftB = LeftB & strTemp
                        i += 1
                        j += 1
                        'End If
                    End If
                End If
            End If
        Next

        ' Str = ".권경숙", Len = 4이면 
        ' LeftB = ".권"되면서 j += 1되기때문에 For문 빠져나오므로 LeftB = ".권 "
        If HLen(LeftB) < Len Then
            LeftB = LeftB & " "
        End If

        Return ""
    End Function

End Class
