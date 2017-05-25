Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class MMR101_KRS
    Private m_OpenDset As DataSet

    Private Sub MMR101_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  Me.Open()
        Select Case work_ty.DefaultText
            Case "", "0"
                work_ty.Text = "0"
                r1.Checked = True
            Case "1"
                r2.Checked = True
        End Select
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                If Not CheckRequired(co_cd, plan_f_mon, plan_t_mon, plan_rev) Then
                    Exit Sub
                End If

                Open_Form()

                'MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                '사용하려면 재정의 가능하다
            Case MenuType.Save
                Me.Save_DataSet()

            Case MenuType.Delete
                'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

            Case MenuType.New
                ' Me.WorkSets("mma100_g10").AddNew()  '특정Workset 신규처리

            Case MenuType.Print
                ' Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private startWHColumn As Integer
    Public Sub Open_Form()

        '화면 컬럼의 생성
        Me.Init_Title()
        Me.Disp_Data()

        m_OpenDset = Me.OpenDataSet("mmr101_g10")
        If IsEmpty(m_OpenDset) Then
            Exit Sub
        End If

        Me.Disp_Data10(m_OpenDset)

    End Sub

    Private Sub Init_Title()

        '1. 컬럼배열을 만든다
        Dim frDt As Date = plan_f_mon.Text
        Dim toDt As Date = plan_t_mon.Text

        Dim cnt As Integer = DateDiff(DateInterval.Month, frDt, toDt)
        Dim arr(1, 0) As String, colNm As String, colFNm As String, yyyymm As String
        Dim arr10(1, 0) As String

        For i = 0 To cnt
            ReDim Preserve arr10(1, i * 2 + 1)     'Array를 증가시킨다 (수량,금액) 2개씩 생성

            yyyymm = Format(DateAdd(DateInterval.Month, i, frDt), "yyyy-MM")
            ' title = (i + 1).ToString

            arr10(0, i * 2) = yyyymm + "_1"              'FieldName
            arr10(1, i * 2) = yyyymm + "(수량)"         'Title

            arr10(0, i * 2 + 1) = yyyymm + "_2"          'FieldName
            arr10(1, i * 2 + 1) = yyyymm + "(금액)"     'Title
        Next


        For i = 0 To cnt
            ReDim Preserve arr(1, i)     'Array를 증가시킨다

            colNm = Format(DateAdd(DateInterval.Month, i, frDt), "yyyy-MM")
            colFNm = Format(DateAdd(DateInterval.Month, i, frDt), "yyyy-MM")

            arr(0, i) = colFNm            'FieldName
            arr(1, i) = colNm             'Title
        Next

        '2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
        ' Ex) g10.InsertColumn("A", arr, "B")
        '     "A" 컬럼이후에 삽입된다
        '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
        '     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다

        g10.InsertArrayColumns(Nothing, arr10, "val")
        g20.InsertArrayColumns("tot_qty", arr, "plan_qty")

    End Sub

    Private Sub Disp_Data()
        Try

            'With g10
            '    'Master 부분
            '    .GridColumn("itm_id").IsMasterKey = True

            '    .GridColumn("itm_cd").IsMasterData = True
            '    .GridColumn("itm_nm").IsMasterData = True
            '    .GridColumn("fac_cd").IsMasterData = True
            '    .GridColumn("plan_rev").IsMasterData = True

            '    .GridColumn("cust_nm").IsMasterData = True
            '    .GridColumn("stock_qty").IsMasterData = True
            '    .GridColumn("tot_qty").IsMasterData = True
            '    .GridColumn("tot_amt").IsMasterData = True

            '    'Detail 부분
            '    .GridColumn("plan_mon").IsDetailKey = True
            '    .GridColumn("plan_qty").IsDetailData = True
            '    .GridColumn("plan_amt").IsDetailData = True

            '    MyBase.Open("mmr101_g10")
            '    .BestFitColumns()
            'End With

            '/*************** 생산계획 품목 현황
            With g20
                'Master 부분
                .GridColumn("itm_id").IsMasterKey = True
                .GridColumn("itm_bc").IsMasterKey = True
                .GridColumn("fac_cd").IsMasterKey = True

                .GridColumn("itm_cd").IsMasterData = True
                .GridColumn("itm_nm").IsMasterData = True
                .GridColumn("tot_qty").IsMasterData = True

                'Detail 부분
                .GridColumn("plan_mon").IsDetailKey = True
                .GridColumn("plan_qty").IsDetailData = True

                MyBase.Open("mmr101_g20")

                .BestFitColumns()
            End With

            '  g10.ColumnVisible("mng_no") = chk_lot.Checked

            '화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다
            ' g10.GridColumn("std_dt").DefaultText = std_dt.Text

        Catch ex As Exception
            MessageInfo(ex, "Disp_Data()")
        End Try
    End Sub

    Private Sub Disp_Data10(ByVal dSet As DataSet)

        If IsEmpty(dSet) Then
            Exit Sub
        End If

        'Parameter.MainFrame.ProgBar.Visible = True
        'Parameter.MainFrame.ProgBar.Minimum = 1
        'Parameter.MainFrame.ProgBar.Maximum = dSet.Tables(0).Rows.Count
        'Parameter.MainFrame.ProgBar.Value = 1
        'Parameter.MainFrame.ProgBar.Step = 1

        Try
            Windows.Forms.Cursor.Current = Cursors.WaitCursor

            Dim dRow As DataRow, colNm As String, s1 As String = ""
            Dim iRow As Integer, iCnt As Integer

            With g10

                '추가와 쓰기가 가능해야 행이 추가 된다
                g10.AllowAddRows = True
                g10.Editable = True
                ' m_StopEvent = True  '쓸데없는 Event방지

                iRow = -1

                For Each dRow In dSet.Tables(0).Rows
                    If s1 <> ToStr(dRow("itm_id")) Then

                        ' Me.SumRowData() 'Row 합계구하기

                        g10.AddNewRow()

                        iRow += 1
                        '.Row = iRow


                        .Text("itm_id", iRow) = ToStr(dRow("itm_id"))
                        .Text("itm_cd", iRow) = ToStr(dRow("itm_cd"))
                        .Text("itm_nm", iRow) = ToStr(dRow("itm_nm"))
                        .Text("itm_bc", iRow) = ToStr(dRow("itm_bc"))
                        .Text("fac_cd", iRow) = ToStr(dRow("fac_cd"))
                        .Text("plan_rev", iRow) = ToStr(dRow("plan_rev"))

                        .Text("cust_nm", iRow) = ToStr(dRow("cust_nm"))
                        .Text("stock_qty", iRow) = ToDec(dRow("stock_qty"))

                        .Text("tot_qty", iRow) = ToStr(dRow("tot_qty"))
                        .Text("tot_amt", iRow) = ToStr(dRow("tot_amt"))


                        s1 = ToStr(dRow("itm_id"))

                    End If

                    colNm = ToStr(dRow("plan_mon"))

                    .Text(colNm + "_1", iRow) = ToStr(dRow("plan_qty"))
                    .Text(colNm + "_2", iRow) = ToStr(dRow("plan_amt"))



                    iCnt += 1

                    'Parameter.MainFrame.ProgBar.Value = iCnt

                Next

                .UpdateRow()

                '이것을 쓰야 수정없이 종료해도 저장질의를 하지 않는다
                ' 반드시 .UpdateRow() 를 먼저 쓰야 한다 그렇지 않으면 Row가 사라진다
                .DataChanged = False

                ' m_StopEvent = False
            End With



        Catch ex As Exception
            MessageError(ex, , "Display()")

        Finally
            'Parameter.MainFrame.ProgBar.Visible = False
            g10.BestFitColumns()

            Me.Cursor = Cursors.Default

        End Try
    End Sub

    Private Function Save_DataSet() As Boolean
        'If epff500f_g1.RowCount <= 1 Then Exit Function

        Dim iRow As Integer, yyyymm As String
        Dim dTbl As DataTable, dRow As DataRow, dRows As DataRowCollection
        Try

            '저장을 위한 전역변수 DataSet
            If Not IsEmpty(m_OpenDset) Then
                'DataSet을 모두 지운다
                dRows = m_OpenDset.Tables(0).Rows
                For Each dRow In dRows
                    dRow.Delete()
                Next
                'Exit Function
            End If

            dTbl = m_OpenDset.Tables(0)

            '빈 DataSet에 추가한다
            With g10
                .UpdateCurrentRow()

                dTbl.BeginLoadData()    '일괄 Update처리를 하기 때문에 속도가 빠르다

                For iRow = 0 To .RowCount - 1

                    For j As Integer = 0 To .ColumnCount - 1
                        If .FieldName(j).EndsWith("_1") Then

                            yyyymm = .FieldName(j).Substring(0, 7)

                            '해당월에 수량또는 금액에 수치가 있으면
                            If .ToDec(yyyymm + "_1", iRow) <> 0 Or _
                               .ToDec(yyyymm + "_2", iRow) <> 0 Then

                                dRow = dTbl.NewRow()


                                dRow("fac_cd") = .Text("fac_cd", iRow)
                                dRow("plan_rev") = .Text("plan_rev", iRow)
                                dRow("plan_mon") = yyyymm
                                dRow("itm_id") = .Text("itm_id", iRow)
                                dRow("plan_qty") = .ToDec(yyyymm + "_1", iRow)
                                dRow("plan_amt") = .ToDec(yyyymm + "_2", iRow)

                                dTbl.Rows.Add(dRow)
                            End If


                        End If
                    Next

                Next

                dTbl.EndLoadData()
            End With

            '트랜젝션 저장한다
            If Me.Save("mmr101_g10") Then
                Return True
            End If
            Return False

        Catch ex As Exception
            MessageInfo(ex, "Save_DataSet()")
        End Try

    End Function

    Private Sub btn_mrp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mrp.Click

        If Not CheckRequired(co_cd, plan_f_mon, plan_t_mon, plan_rev) Then
            Exit Sub
        End If

        Dim Dset As DataSet = OpenDataSet("mmr101_krs_batch")

        If Not IsEmpty(Dset) Then
            If DataValue(Dset) = "OK" Then
                Open_Form()
                MessageInfo("[자재 소요량 산출 작업]이 완료 되었습니다")

                Dset = Nothing
            End If
        End If


    End Sub

    Private Sub chk_amt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_amt.CheckedChanged, chk_stk.CheckedChanged
        For j As Integer = 0 To g10.ColumnCount - 1
            If g10.FieldName(j).EndsWith("_2") Then
                g10.ColumnVisible(j) = chk_amt.Checked
            End If
        Next
    End Sub
    '단가가져오기
    Private Sub btn_amt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_amt.Click
        Me.GetAmt()
    End Sub

    Private Sub GetAmt()

        '필수 입력항목 누락여부 체크
        If Not CheckRequired(co_cd) Then
            Exit Sub
        End If

        Dim oParams As Object = Nothing
        Dim dSet As DataSet
        With g10

            Dim p As New OpenParameters, up As Decimal
            For i As Integer = 0 To .RowCount - 1
                If .Text("itm_id", i) <> "" Then

                    p.Add("@fac_cd", .Text("fac_cd", i))
                    p.Add("@itm_id", .Text("itm_id", i))
                    dSet = OpenDataSet("mmr101_price", p)

                    .RowIndex = i

                    up = dSet.Tables(0).Rows(0).Item("up")
                    .Text("plan_amt", i) = up

                    '각월의 금액계산
                    For j As Integer = 0 To .ColumnCount - 1
                        If g10.FieldName(j).EndsWith("_2") Then
                            .Text(j) = .ToDec(j - 1) * up
                        End If
                    Next



                End If
            Next

            .UpdateCurrentRow()

            If 0 < .RowCount Then
                .RowIndex = 0
            End If

        End With

    End Sub

    Private Sub SumRowData()
        Dim s1 As Decimal = 0, s2 As Decimal = 0
        For j As Integer = 0 To g10.ColumnCount - 1
            If g10.FieldName(j).EndsWith("_1") Then s1 += g10.ToDec(j)
            If g10.FieldName(j).EndsWith("_2") Then s2 += g10.ToDec(j)
        Next
        g10.Text("tot_qty") = s1
        g10.Text("tot_amt") = s2
    End Sub

    Private m_StopEvent As Boolean

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        If m_StopEvent Then
            Exit Sub
        End If

        If ColumnName = "tot_qty" Or ColumnName = "tot_amt" Then
            Exit Sub
        End If

        Me.SumRowData()
    End Sub

    Private Sub r_Click(sender As Object, e As System.EventArgs) Handles r1.Click, r2.Click
        If r1.Checked Then work_ty.Text = "0"
        If r2.Checked Then work_ty.Text = "1"
    End Sub
End Class
