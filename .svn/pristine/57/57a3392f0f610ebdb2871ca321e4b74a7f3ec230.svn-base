
Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data


Public Class FAB100_CSI

    Private m_Sample = "FA300900"   '유형전표
    Private m_Approved = "FA350500"   '승인상태
    Private m_DefaultValues() As DefaultValue

    Private Structure DefaultValue
        Dim Code As String
        Dim Value As String
        Dim Dscrp As String
    End Structure

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        doc_no.CodeNo = "FAB100"
        doc_no.CodeDateField = doc_dt

        g20.AllowInsertRows = False
        g20.AllowFilter = False
        g20.AllowGroup = False
        g20.AllowSort = False

        Me.New_Form()

        AddHandler Me.WorkSet("fab100_csi_f10").AfterOpen, AddressOf AfterOpen


    End Sub

    Private Sub AfterOpen(ByVal wSet As WorkSet)
        '유형전표는 Red로 표시
        doc_bc.TextForeColor = IIf(doc_bc.Text = m_Sample, Color.DeepPink, Color.Black)
        stat_bc.TextForeColor = IIf(stat_bc.Text = m_Approved, Color.DeepPink, Color.Black)
    End Sub


    'Private Sub EPanel3_ClickClose(ByVal sender As Object, ByRef handled As Boolean) Handles EPanel3.ClickClose
    '    Me.SplitContainer1.Panel1Collapsed = False

    'End Sub

    'Private Sub EPanel3_ClickOpen(ByVal sender As Object, ByRef handled As Boolean) Handles EPanel3.ClickOpen
    '    Me.SplitContainer1.Panel1Collapsed = True
    'End Sub


    Public Overrides Sub MenuButton_Click(ByVal ty As MenuType)

        Select Case ty

            Case MenuType.Save

                If Me.CheckBeforeSave() Then

                    If Me.Save_Form() Then
                        Me.Open()
                    End If

                End If

            Case MenuType.Delete

                Me.Delete_Form()

            Case MenuType.New

                If Me.DataChanged Then
                    Select Case MessageYesNoCancel("작업중인 전표를 저장하시겠습니까 ?")
                        Case MsgBoxResult.Yes
                            If Not Me.CheckBeforeSave() Then
                                Exit Sub
                            End If
                            If Not Me.Save_Form() Then
                                Exit Sub
                            End If
                        Case MsgBoxResult.Cancel
                            Exit Sub
                    End Select
                End If

                Me.New_Form()

            Case MenuType.Print
                Me.Print()

            Case Else

                MyBase.MenuButton_Click(ty)

        End Select

    End Sub

    Private Sub New_Form()

        doc_no.Text = ""
        MyBase.Open()

        '기본적요 초기화
        m_DocDesc = ""
        'g20.GridColumn("dsc").DefaultText = ""

        '기본부서 초기화
        m_DeptCd = "" 'dept_cd.Text
        m_DeptNm = "" 'dept_nm.Text

        'Grid에 신규행을 추가
        g20.AddNewRow()

    End Sub

    Private Function Save_Form() As Boolean

        Return MyBase.Save()

    End Function

    Public Sub Open2(ByVal docNo As String, Optional ByVal docSq As String = "")

        doc_no.Text = docNo
        MyBase.Open()

        If docSq <> "" Then
            g20.Find("doc_sq=" + docSq)
        End If
    End Sub

    Private Function Delete_Form() As Boolean
        If doc_no.Text = "" Then
            Return False
        End If

        '일반전표,유형전표 만 삭제
        If Not (doc_bc.Text = "FA300100" Or _
                doc_bc.Text = "FA300900") Then
            MessageInfo("타시스템에서 발행된 전표는 삭제할 수 없습니다.")
            Return False
        End If

        '발행상태 만 삭제
        If stat_bc.Text <> "FA350100" Then
            MessageInfo("[승인] 된 전표는 삭제할 수 없습니다.")
            Return False
        End If

        If Not (Me.IsManager Or doc_rid.Text = Parameter.Login.RegId) Then
            MessageInfo("관리자 또는 작성자 만 삭제할 수 있습니다.")
            Return False
        End If

        If Me.ClosedDate() Then
            MessageInfo("이미 [마감] 되어 삭제할 수 없습니다.")
            Return False
        End If

        If Me.Delete("fab100_csi_f10") = ExcuteResult.Succeeded Then
            Me.Open()
        End If

    End Function

#Region " Function "

    Private Sub _Set_Total()
        Dim i As Integer, tot1 As Double, tot2 As Double
        With g20
            If 0 < .RowCount Then
                For i = 0 To .RowCount - 1
                    'If .IsDataRow(iRow) Then
                    tot1 += .ToDec("amt1", i)
                    tot2 += .ToDec("amt2", i)
                    'End If
                Next
            End If
        End With
        amt1.InitText = tot1
        amt2.InitText = tot2
        diff.InitText = CDec(tot1 - tot2)
    End Sub

    Private Function ClosedDate() As Boolean

        Dim p As New OpenParameters
        Dim dSet As DataSet

        If doc_no.Text <> "" Then
            '전표번호가 있을때는 번호로 Origin 전표일자(Old) 체크
            p.Add("@doc_no", doc_no.Text)
            dSet = Me.OpenDataSet("fab100_check_docno", p)
            If CBool(DataValue(dSet)) Then
                Return True '마감이면 True
            End If
        End If

        '전표일자(New)로도 체크
        p.Add("@co_cd", co_cd.Text)
        p.Add("@doc_dt", doc_dt.Text)
        dSet = Me.OpenDataSet("fab100_check_docdt", p)

        Return CBool(DataValue(dSet))

    End Function

    Private Function CheckBeforeSave() As Boolean

        g20.DeleteBlankRow()
        If g20.RowCount = 0 Then
            MessageInfo("전표 행이 없습니다.")
            Return False
        End If

        If stat_bc.Text = m_Approved Then
            MessageInfo("이미 [승인] 되어 저장할 수 없습니다.")
            Return False
        End If

        If Not (Me.IsManager Or doc_rid.ToDec = Parameter.Login.RegId) Then
            MessageInfo("관리자 또는 작성자 만 저장할 수 있습니다.")
            Return False
        End If

        If Not CheckRequired(doc_dt) Then
            Return False
        End If

        If Me.ClosedDate() Then
            MessageInfo("이미 [마감] 되어 저장할 수 없습니다.")
            Return False
        End If

        Me._Set_Total()

        If doc_bc.Text <> m_Sample Then     '유형전표가 아니면
            If diff.ToDec <> 0 Then
                MessageInfo("차대변이 일치 하지 않습니다.")
                Return False
            End If

            Dim msg As String = Me._Chk_Blank_Mng()
            If msg <> "" Then
                MessageInfo("행 필수입력 [관리항목] 중 누락된 것이 있습니다." + vbLf + vbLf + msg)
                Return False
            End If

            Dim iRow As Integer = Me._Chk_Blank_RmkCd()
            If 0 <= iRow Then
                MessageInfo("행 필수입력 [표준적요] 중 누락된 것이 있습니다.")
                Return False
            End If

            iRow = Me._Chk_Dept_Cd()
            If 0 <= iRow Then
                MessageInfo("[예산부서]가 누락된 행이 있습니다.")
                Return False
            End If

            iRow = Me._Chk_Budget()
            If 0 <= iRow Then
                MessageInfo("예산이 초과된 행이 있습니다")
                Return False
            End If

        End If

        If Not Me.WorkSet("fab100_csi_f10").CheckCodeFields Then    '전표번호 채번
            Return False
        End If

        Me._Set_Mng_DataSet()

        Return True

    End Function

    '관리항목 누락 체크

    Private Function _Chk_Blank_Mng() As String
        Dim iRow As Integer, iTot As Integer, i As Integer
        Dim gAdm As String, sAdms() As String = Nothing, sAdm() As String
        Dim msg As String = ""
        '모든 행
        For iRow = 0 To g20.RowCount - 1
            '관리항목 문자열을 차례로 읽어
            gAdm = g20.Text("mngs", iRow)
            If gAdm = "" Then
                iTot = 0
            Else
                sAdms = Split(gAdm, "<CR>")
                iTot = sAdms.Length
            End If

            '항목을 분리하여
            For i = 0 To iTot - 1
                '관리항목 구성요소를 읽어
                sAdm = Split(sAdms(i), "<T>")
                '누락여부를 체크한다.
                If sAdm(m_MngRmkYn).Substring(0, 1) = "1" And sAdm(m_MngVal) = "" Then

                    msg += "   [" + sAdm(m_MngNm) + "]" + vbLf

                    'Dim ctr As Control = Me.__Get_Mng_Field(i + 1)
                    'If ctr IsNot Nothing Then
                    '    ctr.Focus()
                    'End If
                    'Return iRow
                End If
            Next
        Next

        Return msg
        'Return -1
    End Function

    '표준적요 누락 체크

    Private Function _Chk_Blank_RmkCd() As Integer
        Dim iRow As Integer
        '모든 행
        For iRow = 0 To g20.RowCount - 1
            If g20.ToBool("rmk_yn", iRow) And g20.Text("rmk_cd", iRow) = "" Then
                Return iRow
            End If
        Next

        Return -1
    End Function

    '예산초과 체크

    Private Function _Chk_Budget() As Integer
        'With g20
        '    Dim iRow As Integer, j As Integer, accBc As String, accCd As String, remAmt As Decimal, totAmt As Decimal
        '    For iRow = 0 To .RowCount - 1
        '        If .ToBool("ctrl_yn", iRow) And 0 < (.ToDec("amt1", iRow) + .ToDec("amt2", iRow)) Then
        '            accCd = .Text("acc_cd", iRow)
        '            accBc = .Text("acc_bc", iRow)
        '            remAmt = .Text("rem_amt", iRow)
        '            totAmt = 0
        '            For j = 0 To .RowCount - 1
        '                If .Text("acc_cd", j) = accCd Then
        '                    If accBc = "FA200100" Then
        '                        totAmt += .ToDec("amt1", j)
        '                        remAmt += .ToDec("amt1_old", j)
        '                    Else
        '                        totAmt += .ToDec("amt2", j)
        '                        remAmt += .ToDec("amt2_old", j)
        '                    End If
        '                End If
        '            Next
        '            If totAmt > remAmt Then
        '                Return iRow
        '            End If
        '        End If
        '    Next
        'End With
        Return -1

    End Function


    Private Function _Chk_Dept_Cd() As Integer
        Dim iRow As Integer
        '모든 행
        For iRow = 0 To g20.RowCount - 1
            If g20.ToBool("budg_yn", iRow) And g20.Text("dept_cd", iRow) = "" Then
                Return iRow
            End If
        Next

        Return -1
    End Function

    Private Function _Get_Budget_Balance(ByVal coCd As String, ByVal accCd As String, ByVal deptCd As String, ByVal docDt As String) As Decimal
        Dim dSet As DataSet

        Dim p As New OpenParameters
        p.Add("@co_cd", coCd)
        p.Add("@acc_cd", accCd)
        p.Add("@dept_cd", deptCd)
        p.Add("@std_dt", docDt)

        dSet = Me.OpenDataSet("fab100_budget", p)

        Return ToDec(DataValue(dSet))
    End Function

#End Region

#Region " Event "


    'Private Sub g20_AfterMoveColumn(ByVal sender As Object, ByVal PrevColumnName As String, ByVal ColumnName As String) Handles g20.AfterMoveColumn

    '    'If PrevColumnName = "dept_nm" Then
    '    '    Me.Mng_Focus()
    '    'End If

    'End Sub


    Private Sub g20_DeletedRow(ByVal sender As Object, ByVal RowIndex As Integer) Handles g20.DeletedRow

        Me._Set_Total()
        Me._Disp_Mng_Fields()

    End Sub


    Private Sub g20_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g20.AfterMoveRow
        Me._Disp_Mng_Fields()
        rem_amt.Text = g20.Text("rem_amt")
    End Sub

    Private Sub g20_BeforeMoveRow(ByVal sender As Object, ByVal RowIndex As Integer, ByRef AllowMove As Boolean) Handles g20.BeforeMoveRow
        'Validation 체크

        If m_StopEvent = True Then Exit Sub

        If doc_bc.Text = m_Sample Then  '유형전표는 Validation 체크 안함
            Exit Sub
        End If

        Dim msg As String = Me._Chk_Blank_Mng()
        If msg <> "" Then
            MessageInfo("행 필수입력 관리항목 중 누락된 것이 있습니다." + vbLf + vbLf + msg)
            AllowMove = False
            Exit Sub
        End If


        'Dim iRow As Integer = Me._Chk_Blank_Mng()
        'If RowIndex = iRow Then
        '    MessageInfo("행 필수입력 관리항목중 입력누락된 것이 있습니다.")
        '    AllowMove = False
        '    Exit Sub
        'End If

        Dim iRow As Integer = _Chk_Blank_RmkCd()
        If RowIndex = iRow Then
            MessageInfo("[표준적요]는 필수입니다.")
            AllowMove = False
            Exit Sub
        End If

        iRow = Me._Chk_Dept_Cd()
        If RowIndex = iRow Then
            MessageInfo("[예산부서]는 필수입니다.")
            AllowMove = False
            Exit Sub
        End If

        iRow = Me._Chk_Budget()
        If 0 <= iRow Then
            MessageInfo("예산이 초과되었습니다")
            AllowMove = False
            Exit Sub
        End If


        'If g20.ToBool("rmk_yn") And g20.Text("rmk_cd") = "" Then
        '    MessageInfo("표준적요는 필수입니다.")
        '    AllowMove = False
        '    Exit Sub
        'End If

    End Sub

    Private Sub g20_ButtonPressed(ByVal sender As Object, ByVal columnName As String) Handles g20.ButtonPressed
        If columnName = "tax_btn" Then
            If g20.Text("tax_no") <> "" Then
                Dim menuName As String = "FAC100"
                Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName) 'New FormAttribute(menuName, menuText))
                If ctr IsNot Nothing Then
                    ctr.Open2(g20.Text("tax_no"))
                End If
            End If
        End If
    End Sub

    '아래로 화살표 관리항목으로 이동
    Private Sub g20_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles g20.KeyDown
        If e.Control And e.KeyCode = Keys.Down Then
            Me.Mng_Focus()
            e.Handled = True
        End If

        If Not e.Control And e.KeyCode = Keys.Enter Then
            If g20.FocusedFieldName = "dept_nm" Then
                If Me.Mng_Focus() Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Function Mng_Focus() As Boolean
        If pnl2.Controls.Count > 0 Then
            For Each c As Control In pnl2.Controls
                'pnl2.Controls(0).Focus()
                If TypeOf (c) Is intField Then
                    c.Focus()
                    Return True
                End If
            Next
        End If
        Return False
    End Function

    '발의내용에서 Enter -> Grid로 
    Private Sub title_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles title.KeyDown
        If Not e.Control And e.KeyCode = Keys.Enter Then
            e.Handled = True

            g20.ColumnIndex = 0
            g20.Focus()
            g20.EditMode()
            g20.Refresh()
        End If
    End Sub


    Private m_StopEvent As Boolean
    Private m_DocDesc As String
    Private m_DeptCd As String
    Private m_DeptNm As String

    '적요 기본값 설정
    Private Sub title_TextChanged(ByVal sender As Object, ByVal oldValue As String) Handles title.TextChanged
        m_DocDesc = title.Text
        'g20.GridColumn("dsc").DefaultText = m_DocDesc
    End Sub

    '부서 기본값 설정
    Private Sub dept_nm_TextChanged(ByVal sender As Object, ByVal oldValue As String) Handles dept_nm.TextChanged
        m_DeptCd = dept_cd.Text
        m_DeptNm = dept_nm.Text

        dept_cd.DefaultText = m_DeptCd
        dept_nm.DefaultText = m_DeptNm
    End Sub

    Private Sub g20_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g20.CellValueChanged

        If m_StopEvent = True Then Exit Sub

        m_StopEvent = True

        With g20
            If ColumnName = "acc_cd" Then

                '관리항목호출 초기화
                .Text("acc_chk") = ""

                Me._Init_Mng_Fields()
                Me._Disp_Mng_Fields()

                '기본적요 적용
                If .Text("dsc") = "" Then .Text("dsc") = m_DocDesc

                '기본부서 적용
                If m_DeptCd = "" Then m_DeptCd = dept_cd.Text
                If m_DeptNm = "" Then m_DeptNm = dept_nm.Text
                If .Text("dept_cd") = "" Then .Text("dept_cd") = m_DeptCd
                If .Text("dept_nm") = "" Then .Text("dept_nm") = m_DeptNm
            End If

            If ColumnName = "acc_nm" Then

                'Me._Init_Mng_Fields()
                'Me._Disp_Mng_Fields()

            End If

            If ColumnName = "dept_nm" Then
                '기본부서 재설정
                If .Text("dept_nm") <> "" Then
                    m_DeptCd = .Text("dept_cd")
                    m_DeptNm = .Text("dept_nm")
                End If
            End If

            If ColumnName = "amt1" Then
                .Text("amt2") = ""
                Me._Init_Mng_Fields()
                Me._Disp_Mng_Fields()
            End If

            If ColumnName = "amt2" Then
                .Text("amt1") = ""
                Me._Init_Mng_Fields()
                Me._Disp_Mng_Fields()
            End If

            If ColumnName = "famt1" Then
                .Text("famt2") = ""
            End If

            If ColumnName = "famt2" Then
                .Text("famt1") = ""
            End If

            '기본 적요를 만든다
            If ColumnName = "dsc" Then
                If .Text("dsc") <> "" Then

                    m_DocDesc = .Text("dsc")

                    If title.Text = "" Then
                        title.Text = m_DocDesc
                    End If
                End If
            End If

            If ColumnName <> "dsc" Then

                ''전표가 진행 중이면 적요만 수정가능하게
                'If stat_bc.Text <> bc_결의서진행상태_전표발행 Then
                '    MessageInfo("결의상태가 [발행] 인 결의 사항만 수정/삭제 할 수 있습니다.")

                '    '.RowChanged = False
                '    m_StopEvent = False
                '    Exit Sub
                'End If
                'If .Text("src_slip_in_no") <> "" Then
                '    MessageInfo("발생전표와 연결되어 수정 할 수 없습니다.")

                '    '.RowChanged = False
                '    m_StopEvent = False
                '    Exit Sub
                'End If
            End If

            '예산 체크
            If ColumnName = "acc_cd" Or ColumnName = "dept_cd" Then
                If .ToBool("budg_yn") Then
                    If .Text("acc_cd") = "" Or .Text("dept_cd") = "" Then
                        rem_amt.Text = ""
                        .Text("rem_amt") = ""
                    Else
                        Dim amt As Decimal = Me._Get_Budget_Balance(co_cd.Text, .Text("acc_cd"), .Text("dept_cd"), doc_dt.Text)
                        rem_amt.Text = amt
                        .Text("rem_amt") = amt
                    End If
                Else
                    rem_amt.Text = ""
                    .Text("rem_amt") = ""
                End If
            End If

            Me._Set_Total()

        End With

        m_StopEvent = False

    End Sub



#End Region

#Region " 관리항목 Control "

    Private Const m_Mng_Popup = "FA210100"
    Private Const m_Mng_Combo = "FA210200"
    Private Const m_Mng_비고 = "FA210300"
    Private Const m_Mng_비고Long = "FA210350"
    Private Const m_Mng_비고읽기 = "FA210390"
    Private Const m_Mng_수치 = "FA210400"
    Private Const m_Mng_율 = "FA210450"
    Private Const m_Mng_년월일 = "FA210500"
    Private Const m_Mng_년월 = "FA210550"
    Private Const m_Mng_년 = "FA210600"

    Private Const m_MngSq = 0
    Private Const m_MngNo = 1
    Private Const m_MngNm = 2
    Private Const m_MngVal = 3
    Private Const m_MngDsc = 4
    Private Const m_MngTy = 5       'Popup, Combo,,,
    Private Const m_MngPopup = 6
    Private Const m_MngRmkYn = 7


    Private Sub _Set_Mng_To_Grid()

        Dim iTot As Integer, gAdm As String, sAdms() As String = Nothing, sAdm() As String
        Dim deptCd As String = "", deptNm As String = ""

        gAdm = g20.Text("mngs")
        If gAdm = "" Then
            iTot = 0
        Else
            sAdms = Split(gAdm, "<CR>")
            iTot = sAdms.Length
        End If

        Dim i As Integer, nAdm As String = "", isMarked As Boolean, isRmk1 As Boolean, sVal As String = "", sRmk As String = "", sRmk2 As String = "", sRmks As String = ""
        For i = 1 To iTot

            '관리항목구성요소를 읽는다
            sAdm = Split(sAdms(i - 1), "<T>")

            Dim val As String = Me.__Get_Mng_Val(i)
            Dim dsc As String = Me.__Get_Mng_Dsc(i, sAdm(m_MngTy))

            '구성요소들을 문자열로 만든다
            If nAdm <> "" Then nAdm = nAdm + "<CR>"
            nAdm = nAdm + sAdm(m_MngSq) + "<T>"
            nAdm = nAdm + sAdm(m_MngNo) + "<T>"
            nAdm = nAdm + sAdm(m_MngNm) + "<T>"

            nAdm = nAdm + val + "<T>"
            nAdm = nAdm + dsc + "<T>"
            nAdm = nAdm + sAdm(m_MngTy) + "<T>"
            nAdm = nAdm + sAdm(m_MngPopup) + "<T>"
            nAdm = nAdm + sAdm(m_MngRmkYn)

            isMarked = False    '콤마 마킹여부
            isRmk1 = False

            Dim rmkTitleYn As Boolean = ToBool(sAdm(m_MngRmkYn).Substring(1, 1))
            Dim rmkCodeYn As Boolean = ToBool(sAdm(m_MngRmkYn).Substring(2, 1))
            Dim rmkNameYn As Boolean = ToBool(sAdm(m_MngRmkYn).Substring(3, 1))

            '적요2 -> 제목구성
            If rmkTitleYn AndAlso ((rmkCodeYn And val <> "") Or (rmkNameYn And dsc <> "")) Then
                If sRmks <> "" Then
                    sRmks &= "/ " '", "
                End If
                isMarked = True
                sRmks &= sAdm(m_MngNm) + ":"
            End If

            '적요2 -> 코드부분구성
            If rmkCodeYn AndAlso val <> "" Then
                If Not isMarked And sRmks <> "" Then
                    sRmks &= "/ " '", "
                End If
                isMarked = True
                isRmk1 = True
                sRmks &= val
            End If

            '적요2 -> 명부분구성
            If rmkNameYn AndAlso dsc <> "" Then
                If isRmk1 Then
                    sRmks &= "(" + dsc + ")"
                Else
                    If Not isMarked And sRmks <> "" Then
                        sRmks &= "/ "
                    End If
                    sRmks &= dsc
                End If
            End If

            'If sAdm(v_AdmCd).Trim = "외화" Then
            '    deptCd = admVal.Text
            '    deptNm = admDsc.Text
            'End If

        Next
        'If deptCd = "" Then deptCd = Me.v_ApplyDeptCode
        'If deptNm = "" Then deptNm = Me.v_ApplyDeptName
        ''귀속부서를 설정한다
        'If epdb100F_g1.Text("app_dept") <> deptCd Then epdb100F_g1.Text("app_dept") = deptCd
        'If epdb100F_g1.Text("dept_nm") <> deptNm Then epdb100F_g1.Text("dept_nm") = deptNm

        g20.Text("mngs") = nAdm
        g20.Text("dsc2") = sRmks

    End Sub

    'Private Function __Get_Mng_Field(ByVal i As Integer) As Control
    '    'Dim nm As String = IIf(ty = 1, "f", "n")
    '    Dim nm As String = "f" + (i - 1).ToString
    '    For Each f As Control In pnl2.Controls
    '        If TypeOf f Is intField Then
    '            If f.Name = nm Then
    '                Return f
    '            End If
    '        End If
    '    Next
    '    Return Nothing
    'End Function

    Private Function __Get_Mng_Val(ByVal i As Integer) As String
        'Dim nm As String = IIf(ty = 1, "f", "n")
        Dim nm As String = "f" + (i - 1).ToString
        For Each f As Control In pnl2.Controls
            If TypeOf f Is intField Then
                If f.Name = nm Then
                    Return CType(f, intField).Text
                End If
            End If
        Next
        Return ""
    End Function

    Private Function __Get_Mng_Dsc(ByVal i As Integer, ByVal ty As String) As String
        'Dim nm As String = IIf(ty = 1, "f", "n")
        If ty = m_Mng_Popup Then
            Dim nm As String = "n" + (i - 1).ToString
            For Each f As intField In pnl2.Controls
                If f.Name = nm Then
                    Return f.Text
                End If
            Next
        End If
        If ty = m_Mng_Combo Or ty = m_Mng_수치 Or ty = m_Mng_율 Then
            Dim nm As String = "f" + (i - 1).ToString
            For Each f As intField In pnl2.Controls
                If f.Name = nm Then
                    Return f.EditText
                End If
            Next
        End If
        Return ""
    End Function

    Private Sub _Init_Mng_Fields()
        'epdb100F_g1.Text("admin") = Get_Admin(accCd)

        Dim accCd As String = g20.Text("acc_cd")
        Dim accChk As String = ""

        If g20.Text("amt1") <> "" Then accChk = "1"
        If g20.Text("amt2") <> "" Then accChk = "2"

        If g20.Text("acc_chk") = accChk Then
            Exit Sub
        End If

        '차변 또는 대변 관리항목을 호출한다
        Dim sData As String = ""
        If accChk <> "" Then
            sData = Me.__Get_Mng_String(accCd, accChk)
        End If

        'Default 값을 설정한다
        If sData <> "" Then
            sData = Me.__Set_Mng_DefaultValue(sData)
        End If

        g20.Text("mngs") = sData
        g20.Text("acc_chk") = accChk

    End Sub

    Private Function __Set_Mng_DefaultValue(ByVal sData As String) As String
        Me.AddDefaultValue("651", doc_dt.Text, "")              '부가세발행일
        Me.AddDefaultValue("655", Parameter.Login.BsCd, "")     '신고사업장

        Dim sRows() As String, sRow() As String, sNew As String = Nothing

        sRows = Split(sData, "<CR>")
        For i As Integer = 0 To sRows.Length - 1

            If sNew <> "" Then sNew = sNew + "<CR>"

            sRow = Split(sRows(i), "<T>")

            For m As Integer = 0 To m_DefaultValues.Length - 1
                If sRow(m_MngNo) = m_DefaultValues(m).Code Then
                    sRow(m_MngVal) = m_DefaultValues(m).Value
                    sRow(m_MngDsc) = m_DefaultValues(m).Dscrp
                End If
            Next

            For j As Integer = 0 To sRow.Length - 1
                sNew = sNew + sRow(j) + "<T>"
            Next
        Next

        Return sNew
    End Function

    Public Sub AddDefaultValue(ByVal cd, ByVal val, ByVal dsc)
        If m_DefaultValues IsNot Nothing Then
            For m As Integer = 0 To m_DefaultValues.Length - 1
                If cd = m_DefaultValues(m).Code Then
                    m_DefaultValues(m).Value = val
                    m_DefaultValues(m).Dscrp = dsc
                    Return
                End If
            Next
        End If

        Dim cnt As Integer = 0
        If m_DefaultValues IsNot Nothing Then
            cnt = m_DefaultValues.Length
        End If

        ReDim Preserve m_DefaultValues(cnt)

        m_DefaultValues(cnt).Code = cd
        m_DefaultValues(cnt).Value = val
        m_DefaultValues(cnt).Dscrp = dsc
    End Sub

    Private Function __Get_Mng_String(ByVal accCd As String, ByVal accChk As String) As String
        Dim dSet As DataSet

        Dim p As New OpenParameters
        p.Add("@co_cd", co_cd.Text)
        p.Add("@acc_cd", accCd)
        p.Add("@acc_chk", accChk)

        dSet = Me.OpenDataSet("get_mng_items", p)

        Return DataValue(dSet)
    End Function

    Private Sub _Disp_Mng_Fields()
        Dim iTot As Integer, sData As String, sRows() As String = Nothing

        'Dim saveParam As Boolean = v_LockColUpdate
        'v_LockColUpdate = True 'indicate_LinkChangedText() -> Admin2Grid() 실행을 막는다

        sData = g20.Text("mngs")
        If sData = "" Then
            iTot = 0
        Else
            sRows = Split(sData, "<CR>")
            iTot = sRows.Length
        End If


        'CType(Me.EPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        'Me.pnl2.SuspendLayout()
        'Me.SuspendLayout()

        pnl2.Controls.Clear()

        For i As Integer = 0 To iTot - 1

            Me.__New_Mng_Field(i, sRows(i), (i = iTot - 1))

        Next

        '''Event Catch용 임시 TextBox
        'Dim temp As TextBox = New TextBox
        'temp.Visible = False

        'pnl2.Controls.Add(temp)
        'temp.Location = New Point(28, 900)
        ''AddHandler temp.GotFocus, AddressOf _Temp_KeyDown
        ''AddHandler temp.KeyDown, AddressOf _Temp_KeyDown


        ''CType(Me.EPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        ''Me.pnl2.ResumeLayout(False)
        ''Me.ResumeLayout(False)

    End Sub

    Private Sub __New_Mng_Field(ByVal inx As Integer, ByVal sRow As String, ByVal isLast As Boolean)

        Dim items() As String = Split(sRow, "<T>")

        Dim x1 As Integer, x2 As Integer, y As Integer = 4

        If inx < 6 Then
            x1 = 28
            x2 = 290
            y = y + 24 * inx
            'x1 = 28
            'x2 = 272
            'y = y + 24 * inx
        Else
            x1 = 520
            x2 = 782
            y = y + 24 * (inx - 6)
            'x1 = 500
            'x2 = 744
            'y = y + 24 * (inx - 6)
        End If

        Dim ty As String = items(m_MngTy)
        Dim no As String = items(m_MngNo)
        Dim val As String = items(m_MngVal)
        Dim dsc As String = items(m_MngDsc)
        Dim pid As String = items(m_MngPopup)
        Dim req As Boolean = ToBool(items(m_MngRmkYn).Substring(0, 1))


        Dim t1 As intField = Nothing
        Dim t2 As intField = Nothing

        Select Case ty

            Case m_Mng_Popup

                t1 = New Frame7.eText
                t2 = New Frame7.eText


                'AddHandler CType(t1, Control).KeyDown, AddressOf _mng_KeyDown



                Me.___Set_Field_Property(t1, inx, items(m_MngNm), x1, y, , req)
                Me.___Set_Field_Property2(t2, inx, items(m_MngNm), x2, y)
                Me.___Set_Popup(t1, t2, no, pid, inx)

            Case m_Mng_Combo

                t1 = New Frame7.eCombo
                Me.___Set_Field_Property(t1, inx, items(m_MngNm), x1, y, 300, req)

                Me.___Set_Popup(t1, Nothing, no, pid, inx)  'Dynamic Combo용
                Me.___set_Combo(t1, pid)

            Case m_Mng_비고, m_Mng_비고Long, m_Mng_비고읽기, m_Mng_수치, m_Mng_율

                t1 = New Frame7.eText
                Dim w As Integer = IIf(ty = m_Mng_비고Long, 462, 260)
                Me.___Set_Field_Property(t1, inx, items(m_MngNm), x1, y, w, req)

                If ty = m_Mng_수치 Or ty = m_Mng_율 Then
                    t1.FieldType = FieldType.Decimal
                    t1.RoundDigits = 4
                    t1.RoundType = RoundType.Truncation
                End If
                If ty = m_Mng_비고읽기 Then
                    t1.ReadOnly = True
                End If

            Case m_Mng_년월일, m_Mng_년월, m_Mng_년

                t1 = New Frame7.eDate
                Me.___Set_Field_Property(t1, inx, items(m_MngNm), x1, y, , req)

                If ty = m_Mng_년월일 Then CType(t1, eDate).FormatType = DateFormatType.Day
                If ty = m_Mng_년월 Then CType(t1, eDate).FormatType = DateFormatType.Month
                If ty = m_Mng_년 Then CType(t1, eDate).FormatType = DateFormatType.Year

        End Select

        If t1 IsNot Nothing Then t1.InitText = val
        If t2 IsNot Nothing Then t2.InitText = dsc

        If isLast Then CType(t1, Control).Tag = "Last"

    End Sub

    Private Sub ___Set_Field_Property(ByVal f As Control, ByVal inx As Integer, ByVal title As String, ByVal x As Integer, ByVal y As Integer, Optional ByVal w As Integer = 260, Optional ByVal req As Boolean = False)
        Me.pnl2.Controls.Add(f)

        f.Font = New System.Drawing.Font("Tahoma", 9) '"맑은 고딕", 9)
        f.Location = New System.Drawing.Point(x, y)
        f.Name = "f" + inx.ToString.Trim
        f.Size = New System.Drawing.Size(w, 21)
        f.TabIndex = 100 + inx
        CType(f, intField).Title = title

        If req Then
            CType(f, intField).TitleStyle = TitleStyle.Needed
        End If

        AddHandler f.Leave, AddressOf _mng_Leave

        If TypeOf f Is intControl Then
            AddHandler CType(f, intControl).KeyDownHandler, AddressOf _KeyDownHandler
        End If

        '작동안함
        'AddHandler f.KeyUp, AddressOf _mng_KeyDown

    End Sub

    Private Sub ___Set_Field_Property2(ByVal f As Control, ByVal inx As Integer, ByVal title As String, ByVal x As Integer, ByVal y As Integer, Optional ByVal w As Integer = 200)
        Me.pnl2.Controls.Add(f)

        f.Font = New System.Drawing.Font("Tahoma", 9) '"맑은 고딕", 9)
        f.Location = New System.Drawing.Point(x, y)
        f.Name = "n" + inx.ToString.Trim
        f.Size = New System.Drawing.Size(w, 21)
        f.TabIndex = 100 + inx

        f.TabStop = False
        CType(f, eText).TitleWidth = 0
        CType(f, eText).ReadOnly = True
    End Sub

    Private Sub ___Set_Popup(ByVal t1 As intField, ByVal t2 As intField, ByVal mngNo As String, ByVal popupID As String, ByVal inx As Integer)

        Dim dSet As DataSet

        Dim op As New OpenParameters
        op.Add("@mng_no", mngNo)
        op.Add("@popup_id", popupID)

        dSet = Me.OpenDataSet("get_popup_fields", op)
        If IsEmpty(dSet) Then
            Exit Sub
        End If

        'Dim pid = DataValue(dSet, "popup_id")
        Dim subCd = DataValue(dSet, "sub_cd")
        Dim param = DataValue(dSet, "param")
        Dim params = DataValue(dSet, "params")
        Dim out1 = DataValue(dSet, "out1")
        Dim out2 = DataValue(dSet, "out2")
        Dim mainCd = DataValue(dSet, "main_cd")

        If Not (mainCd = "Popup" Or mainCd = "Dynamic") Then
            'MessageInfo(subCd + ": Popup 유형이 [" + mainCd + "] 입니다. [Popup] 이어야 합니다")
            Exit Sub
        End If

        Dim pup As Popup = New Popup
        t1.Popup = pup

        pup.BaseField = t1
        pup.PopupID = popupID
        pup.SubCode = subCd '"HR210"

        '-----------------------
        'Setting input
        '-----------------------
        If params = "" Then
            pup.AddInput(param, t1) '("@dept_cd", t1)
        Else
            Dim arr() As String, p As String, f As String, iFld As intField = Nothing
            arr = Split(params, ",")
            For Each ps As String In arr

                p = Split(ps, "=")(0)
                f = Split(ps, "=")(1)

                If f = "Me" Then
                    iFld = t1
                ElseIf f = "co_cd" Then
                    iFld = co_cd
                ElseIf f = "div_cd" Then
                    iFld = div_cd
                ElseIf f = "dept_cd" Then
                    iFld = dept_cd
                ElseIf f = "Prev" Then
                    If 0 < inx Then
                        For Each fld As intField In pnl2.Controls
                            If fld.Name = "f" + (inx - 1).ToString.Trim Then
                                iFld = fld
                                Exit For
                            End If
                        Next
                    End If
                End If

                If iFld IsNot Nothing Then
                    pup.AddInput(p, iFld)

                    If mainCd = "Dynamic" Then
                        Dim j = New Join()
                        j.FromControl = iFld
                        j.ToControl = t1
                        j.JoinType = JoinType.Indicate
                        Me.Joins.Add(j)
                    End If
                End If
            Next
        End If

        '-----------------------
        'Setting output
        '-----------------------
        pup.AddOutput(out1, t1)
        If t2 IsNot Nothing Then
            pup.AddOutput(out2, t2)
        End If

        If mainCd = "Dynamic" Then
            t1.GetIndicator(Nothing)
        End If

    End Sub

    Private Sub ___set_Combo(ByVal t1 As intField, ByVal popupID As String)
        Dim p As New OpenParameters
        p.Add("@popup_id", popupID)

        Dim dSet As DataSet = Me.OpenDataSet("get_combo_values", p)
        If IsEmpty(dSet) Then
            Exit Sub
        End If

        CType(t1, eCombo).SetCombo(dSet)
    End Sub

    ' 관리항목을 DataSet으로 만든다

    Private Function _Set_Mng_DataSet() As Boolean

        Dim p As New OpenParameters
        p.Add("@doc_no", doc_no.Text)

        Dim dSet As DataSet = Me.OpenDataSet("save_mng_items", p)
        If dSet Is Nothing Then
            Return True
        End If

        '모두 삭제 후
        For Each dr As DataRow In dSet.Tables(0).Rows
            dr.Delete()
        Next

        Dim dRow As DataRow
        Dim iTot As Integer, mngs As String, sRows() As String = Nothing, sRow() As String

        For iRow As Integer = 0 To g20.RowCount - 1
            '관리항목 문자열을 차례로 읽어
            mngs = g20.Text("mngs", iRow)
            If mngs = "" Then
                iTot = 0
            Else
                sRows = Split(mngs, "<CR>")
                iTot = sRows.Length
            End If

            '항목을 분리하여
            For i As Integer = 0 To iTot - 1

                sRow = Split(sRows(i), "<T>")

                dRow = dSet.Tables(0).NewRow()

                dRow("doc_no") = doc_no.Text
                dRow("doc_sq") = g20.Text("doc_sq", iRow)
                dRow("mng_no") = sRow(m_MngNo)
                dRow("mng_val") = sRow(m_MngVal)
                dRow("mng_dsc") = sRow(m_MngDsc)
                dRow("mng_seq") = sRow(m_MngSq)

                dSet.Tables(0).Rows.Add(dRow)
            Next
        Next

        Return True
    End Function



    Private Sub _mng_Leave(ByVal sender As Object, ByVal e As System.EventArgs)


        'If sender.EditChanged Then
        Me._Set_Mng_To_Grid()
        'End If


        If sender.Tag = "Last" Then

            'g20.Focus()
            'g20.EditMode()
            'g20.FocusedColumn = "ex_rt"
            'g20.EditMode()
            'g20.Focus()

            'g20.GridFocus()
            'g20.EditMode()

            'MsgBox(g20.FocusedFieldName)
        End If

    End Sub

    Private Sub _KeyDownHandler(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If sender.Tag = "Last" Then
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
                g20.Focus()
                'g20.EditMode()
                g20.FocusedFieldName = "dept_nm"
                g20.EditMode()

                e.Handled = True
            End If
        End If

    End Sub

    'Private Sub _mng_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    MsgBox("bb")
    'End Sub

#End Region

#Region " Print "
    Private Sub Print()

        Dim p As OpenParameters = New OpenParameters
        p.Add("@co_cd", co_cd.Text)
        p.Add("@div_cd", div_cd.Text)
        p.Add("@doc_no", doc_no.Text)

        System7.ReportView.LoadView("fab100_csi", "", "fab100_Print", p) '전표

    End Sub
#End Region

#Region " 반제전표 관리 "

    Public Function Set_Origin_Rows(ByVal g As eGrid, Optional ByVal ty As String = "1") As Boolean

        If stat_bc.Text = "FA350500" Then
            MessageInfo("[승인] 처리된 전표에 행을 추가 할 수 없습니다.")
            Return True
        End If

        m_StopEvent = True

        Dim find As Boolean, kd1_amt As Decimal = 0, kd2_amt As Decimal = 0, kd1_acc As String = "", kd2_acc As String = "", acctNo As String = ""
        g20.DeleteBlankRow()
        With g
            '.UpdateRow()

            Dim i As Integer
            For i = 0 To .RowCount - 1
                If .ToBool("chk", i) Then

                    find = False

                    co_cd.Text = .Text("co_cd", i)
                    div_cd.Text = .Text("div_cd", i)

                    For k = 0 To g20.RowCount - 1
                        If g20.Text("org_doc_no", k) = .Text("doc_no", i) And _
                           g20.Text("org_doc_sq", k) = .Text("doc_sq", i) Then
                            '이미 Jump하여 존재하면 금액만 쓴다
                            If .ToBool("isDeb", i) Then
                                g20.Text("amt2", k) = .Text("set_amt", i)
                            Else
                                g20.Text("amt1", k) = .Text("set_amt", i)
                            End If
                            find = True
                        End If
                    Next

                    If Not find Then
                        g20.AddNewRow()

                        g20.Text("acc_cd") = .Text("acc_cd", i)
                        g20.Text("acc_nm") = .Text("acc_nm", i)
                        g20.Text("mngs") = .Text("mngs", i)
                        If .ToBool("isDeb", i) Then
                            g20.Text("amt2") = .Text("set_amt", i)
                        Else
                            g20.Text("amt1") = .Text("set_amt", i)
                        End If
                        g20.Text("dsc") = "(" + .Text("doc_no", i) + ") " + .Text("dsc", i)
                        g20.Text("dsc2") = .Text("dsc2", i)
                        g20.Text("dept_cd") = .Text("dept_cd", i)
                        g20.Text("dept_nm") = .Text("dept_nm", i)
                        g20.Text("org_doc_no") = .Text("doc_no", i)
                        g20.Text("org_doc_sq") = .Text("doc_sq", i)
                    End If

                    '자금집행에서 Jump
                    If ty = "2" Then
                        If .Text("pay_kd", i) = "BC527100" Then '현금
                            kd1_acc = .Text("pay_acc", i)
                            kd1_amt += .ToDec("set_amt", i)
                        End If
                        If .Text("pay_kd", i) = "BC527200" Then '보통예금
                            kd2_acc = .Text("pay_acc", i)
                            kd2_amt += .ToDec("set_amt", i)
                            acctNo = .Text("acct_no", i)
                        End If
                    End If

                End If

                'g20.AddNewRow()

            Next

            If ty = "1" Then

                g20.AddNewRow()

            ElseIf ty = "2" Then

                If kd1_amt <> 0 Then
                    g20.AddNewRow()
                    g20.Text("acc_cd") = kd1_acc
                    g20.Text("amt2") = kd1_amt
                    g20.Text("dsc") = "자금집행"
                End If
                If kd2_amt <> 0 Then

                    g20.AddNewRow()
                    g20.Text("acc_cd") = kd2_acc
                    g20.Text("amt2") = kd2_amt
                    g20.Text("rmk_cd") = "101"
                    g20.Text("dsc") = "자금집행"

                    Me.AddDefaultValue("055", acctNo, "")     '계좌(자금)
                    Me._Init_Mng_Fields()
                    Me._Disp_Mng_Fields()
                End If

                title.Text = "자금집행"
            End If

        End With

        m_StopEvent = False

    End Function

    Private Sub btn_pay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pay.Click
        '미결전표검색 화면 찾기
        Dim menuName As String = "FAB510"
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
    End Sub

#End Region

#Region " 유형전표 관리 "

    Private Sub btn_sample_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sample.Click
        '유형전표검색 화면 찾기
        Dim menuName As String = "FAB105"
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If doc_no.Text <> "" Then
            MessageInfo("신규전표 만 유형전표로 저장 가능합니다")
            Exit Sub
        End If

        'Dim docBc As String = doc_bc.Text   '전표구분 임시보관

        doc_bc.Text = m_Sample

        If Not Me.CheckBeforeSave() Then    '체크에 실패했다면
            'doc_bc.Text = docBc             ' 전표구분을 원상태로 돌린다
            Exit Sub
        End If

        If Me.Save_Form() Then
            Me.Open()
        End If
    End Sub

    Public Function Set_Sample_Master(ByVal coCd As String, ByVal divCd As String, ByVal ttl As String, ByVal deptCd As String, ByVal docId As String) As Boolean
        Me.New_Form()

        co_cd.Text = coCd
        div_cd.Text = divCd
        title.Text = ttl
        dept_nm.Text = deptCd
        doc_nm.Text = docId
    End Function

    Public Function Set_Sample_Rows(ByVal g As eGrid) As Boolean
        m_StopEvent = True

        g20.DeleteBlankRow()
        With g
            Dim accChk As String = ""
            For i As Integer = 0 To .RowCount - 1
                g20.AddNewRow()

                g20.Text("acc_cd") = .Text("acc_cd", i)
                g20.Text("acc_nm") = .Text("acc_nm", i)
                g20.Text("amt1") = .Text("amt1", i)
                g20.Text("amt2") = .Text("amt2", i)
                g20.Text("dsc") = .Text("dsc", i)
                g20.Text("dsc2") = .Text("dsc2", i)
                g20.Text("dept_cd") = .Text("dept_cd", i)
                g20.Text("dept_nm") = .Text("dept_nm", i)
                g20.Text("mngs") = .Text("mngs", i)
                g20.Text("rmk_yn") = .Text("rmk_yn", i)
                g20.Text("rmk_cd") = .Text("rmk_cd", i)
                g20.Text("rmk_nm") = .Text("rmk_nm", i)


                If g20.Text("amt1") <> "" Then accChk = "1"
                If g20.Text("amt2") <> "" Then accChk = "2"

                g20.Text("acc_chk") = accChk
            Next
        End With

        Me._Disp_Mng_Fields()

        m_StopEvent = False
    End Function



#End Region

    Private Sub btn_budg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_budg.Click

    End Sub

End Class
