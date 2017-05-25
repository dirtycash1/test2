Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class PPD200

    Private Sub PPB100_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ty.AddItem("1", "생산")
        ty.AddItem("2", "납품")
        ty.AddItem("3", "재고")

        m_OpenStop = True
        ty.Text = "1,2,3"
        m_OpenStop = False

        g10.AddCombo("ty", "1", "생산")
        g10.AddCombo("ty", "2", "납품")
        g10.AddCombo("ty", "3", "재고")

        g10.AllowSort = False

        Me.Disp_Data2()

        'Me.Open()

        'g10.AddNewRow()

        '생산지시번호 자동채번 설정
        'out_no.CodeNo = "LEB100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        'out_no.CodeDateField = out_dt

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                Me._Open()

            Case MenuType.Save

                Me.Save_g10()


                'If MyBase.Save() Then
                '    MyBase.Open()
                'End If

                'Case MenuType.New
                '    g10.AddNewRow()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select
    End Sub

    Private m_line As Integer

    Private Sub _Open()
        m_line = 0
        If ty.Text.Contains("1") Then m_line += 1
        If ty.Text.Contains("2") Then m_line += 1
        If ty.Text.Contains("3") Then m_line += 1


        m_DataSet = Me.OpenDataSet("ppd200_g10")

        m_StopOpen = True
        g10.StopPopup = True

        Me.Init_Title()
        Me.Disp_Data(m_DataSet)

        m_StopOpen = False
        g10.StopPopup = False

        If 0 < g10.RowCount Then
            g10.RowIndex = 0
        End If
    End Sub

    Private Sub _Open_Deteil()
        If m_StopOpen Then
            Exit Sub
        End If

        Me.Init_Title2()
        Me.Disp_Data2()
    End Sub


#Region "Open g10"

    'Case 3. 일자 기간의 Title 배열
    Private Sub Init_Title()

        '1. 컬럼배열을 만든다
        Dim frDt As Date = fr_dt.Text
        Dim toDt As Date = to_dt.Text

        'Dim cnt As Integer = DateDiff(DateInterval.Day, frDt, toDt) + 1
        Dim arr(1, 0) As String, colNm As String, capNm As String
        For i = 0 To days.ToDec - 1
            ReDim Preserve arr(1, i)     'Array를 증가시킨다

            colNm = Format(DateAdd(DateInterval.Day, i, frDt), "yyyy-MM-dd")
            capNm = Format(DateAdd(DateInterval.Day, i, frDt), "MM-dd")
            arr(0, i) = colNm            'FieldName
            arr(1, i) = capNm            'Title
        Next

        '2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
        ' Ex) g10.InsertColumn("A", arr, "B")
        '     "A" 컬럼이후에 삽입된다
        '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
        '     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다

        g10.InsertArrayColumns(Nothing, arr, "val")

    End Sub


    '두번째 Display 방법: 수동 Coding
    Private Sub Disp_Data(ByVal dSet As DataSet)

        If IsEmpty(dSet) Then
            Exit Sub
        End If

        Parameter.MainFrame.ProgBar.Visible = True
        Parameter.MainFrame.ProgBar.Minimum = 1
        Parameter.MainFrame.ProgBar.Maximum = dSet.Tables(0).Rows.Count
        Parameter.MainFrame.ProgBar.Value = 1
        Parameter.MainFrame.ProgBar.Step = 1

        Try
            Windows.Forms.Cursor.Current = Cursors.WaitCursor

            Dim dRow As DataRow, colNm As String, s1 As String = ""
            Dim iRow As Integer, iCnt As Integer ', kd As String = "" ', itmCnt As Integer
            Dim tot1 As Decimal, tot2 As Decimal, m As Integer, gTot1 As Integer, gTot2 As Integer
            Dim t1 As Boolean, t2 As Boolean, t3 As Boolean
            t1 = ty.Text.Contains("1")
            t2 = ty.Text.Contains("2")
            t3 = ty.Text.Contains("3")

            With g10

                '추가와 쓰기가 가능해야 행이 추가 된다
                g10.AllowAddRows = True
                g10.Editable = True

                iRow = -m_line
                'itmCnt = 0

                For Each dRow In dSet.Tables(0).Rows
                    If s1 <> dRow("itm_cd") Then

                        g10.AddNewRow()

                        tot1 = 0
                        tot2 = 0

                        'itmCnt += 1
                        iRow += m_line

                        .Text("itm_id", iRow) = ToStr(dRow("itm_id"))
                        .Text("itm_cd", iRow) = ToStr(dRow("itm_cd"))
                        .Text("itm_nm", iRow) = ToStr(dRow("itm_nm"))
                        .Text("itm_bc", iRow) = ToStr(dRow("itm_bc"))
                        .Text("grp1_cd", iRow) = ToStr(dRow("grp1_cd"))
                        .Text("model_cd", iRow) = ToStr(dRow("model_cd"))
                        .Text("spec1", iRow) = ToStr(dRow("spec1"))

                        s1 = ToStr(dRow("itm_cd"))

                        m = 0
                        If t1 Then       '생산
                            .Text("ty", iRow + m) = "1"
                            m += 1
                        End If
                        If t2 Then       '납품
                            If 0 < m Then
                                g10.AddNewRow()
                                .Text("itm_id", iRow + m) = ToStr(dRow("itm_id"))
                            End If
                            .Text("ty", iRow + m) = "2"
                            m += 1
                        End If
                        If t3 Then       '재고
                            If 0 < m Then
                                g10.AddNewRow()
                                .Text("itm_id", iRow + m) = ToStr(dRow("itm_id"))
                            End If
                            .Text("ty", iRow + m) = "3"
                            .Text("bas_qty", iRow + m) = ToDec(dRow("bas_qty"))
                        End If
                    End If

                    colNm = ToDateStr(dRow("plan_dt"))

                    If colNm <> "" Then
                        m = 0
                        If t1 Then
                            .Text(colNm, iRow + m) = ToDec(dRow("plan_qty"))  '생산
                            tot1 += ToDec(dRow("plan_qty"))
                            .Text("tot_qty", iRow + m) = tot1
                        End If
                        If t2 Then
                            m += 1
                            .Text(colNm, iRow + m) = ToDec(dRow("dlv_qty"))   '납품
                            tot2 += ToDec(dRow("dlv_qty"))
                            .Text("tot_qty", iRow + m) = tot2
                        End If
                        If t3 Then
                            m += 1
                            .Text(colNm, iRow + m) = ToDec(dRow("end_qty"))   '재고
                        End If
                    End If

                    iCnt += 1

                    Parameter.MainFrame.ProgBar.Value = iCnt

                Next

                If .RowCount = 0 Then
                    .UpdateRow()
                    Exit Sub
                End If

                '
                '   합계 Row
                '

                Dim frDt As Date = fr_dt.Text, k As Integer

                iRow += m_line

                If ty.Text.Contains("1") Then g10.AddNewRow()
                If ty.Text.Contains("2") Then g10.AddNewRow()

                .Text("itm_nm", iRow) = "Total"
                m = 0
                If t1 Then
                    .Text("ty", iRow) = "1"
                    m += 1
                End If
                If t2 Then
                    .Text("ty", iRow + m) = "2"
                End If

                For i = 0 To days.ToDec - 1
                    colNm = Format(DateAdd(DateInterval.Day, i, frDt), "yyyy-MM-dd")

                    tot1 = 0
                    tot2 = 0

                    For j = 0 To .RowCount - 1 / m_line        '품목계
                        k = j * m_line
                        m = 0
                        If t1 Then
                            tot1 += .ToDec(colNm, k)
                            m += 1
                        End If
                        If t2 Then
                            tot2 += .ToDec(colNm, k + m)
                        End If
                    Next
                    m = 0
                    If t1 Then           '생산계
                        .Text(colNm, iRow) = tot1
                        gTot1 += tot1
                        m += 1
                    End If
                    If t2 Then           '납품계
                        .Text(colNm, iRow + m) = tot2
                        gTot2 += tot2
                    End If
                Next

                m = 0
                If 1 Then               '생산 총계
                    .Text("tot_qty", iRow) = gTot1
                    m += 1
                End If
                If t2 Then               '납품 총계
                    .Text("tot_qty", iRow + m) = gTot2
                End If

                .UpdateRow()

                '이것을 쓰야 수정없이 종료해도 저장질의를 하지 않는다
                ' 반드시 .UpdateRow() 를 먼저 쓰야 한다 그렇지 않으면 Row가 사라진다
                .DataChanged = False
            End With

        Catch ex As Exception
            MessageError(ex, , "Display()")

        Finally
            Parameter.MainFrame.ProgBar.Visible = False

            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private m_DataSet As DataSet

    Private Function Save_g10() As Boolean
        If g10.RowCount < 1 Then Exit Function

        Dim iRow As Integer
        Dim dTbl As DataTable, dRow As DataRow
        Dim colNm As String
        Try

            If Not ty.Text.Contains("1") Then
                Return True
            End If

            If m_DataSet Is Nothing Then
                Return False
            End If

            'If IsEmpty(m_DataSet) Then
            '    Return False
            'End If

            'DataSet을 모두 지운다
            For Each dRow In m_DataSet.Tables(0).Rows
                dRow.Delete()
            Next
            g10.DataChanged = True

            dTbl = m_DataSet.Tables(0)

            With g10
                dTbl.BeginLoadData()

                .UpdateRow()

                Dim frDt As Date = fr_dt.Text
                For iRow = 0 To .RowCount - 1 Step m_line
                    For i = 0 To days.ToDec - 1
                        colNm = Format(DateAdd(DateInterval.Day, i, frDt), "yyyy-MM-dd")
                        If .Text("itm_id", iRow) <> "" And .ToDec(colNm, iRow) <> 0 Then
                            dRow = dTbl.NewRow()
                            dRow("co_cd") = co_cd.Text
                            dRow("plan_dt") = colNm
                            dRow("fac_cd") = fac_cd.Text
                            dRow("itm_id") = .Text("itm_id", iRow)
                            dRow("plan_qty") = .ToDec(colNm, iRow)
                            dTbl.Rows.Add(dRow)
                        End If
                    Next
                Next

                dTbl.EndLoadData()
            End With

            '트랜젝션 저장한다
            If Me.Save() Then
                Return True
            End If

            Return False

        Catch ex As Exception
            'MsgError(ex, "GetParams()")
        End Try

    End Function

#End Region

#Region "Open g20"

    'Case 3. 일자 기간의 Title 배열
    Private Sub Init_Title2()

        '1. 컬럼배열을 만든다
        Dim frDt As Date = fr_dt.Text
        Dim toDt As Date = to_dt.Text

        'Dim cnt As Integer = DateDiff(DateInterval.Day, frDt, toDt) + 1
        Dim arr(1, 0) As String, colNm As String, capNm As String
        For i = 0 To days.ToDec - 1
            ReDim Preserve arr(1, i)     'Array를 증가시킨다

            colNm = Format(DateAdd(DateInterval.Day, i, frDt), "yyyy-MM-dd")
            capNm = Format(DateAdd(DateInterval.Day, i, frDt), "MM-dd")
            arr(0, i) = colNm            'FieldName
            arr(1, i) = capNm            'Title
        Next

        '2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
        ' Ex) g10.InsertColumn("A", arr, "B")
        '     "A" 컬럼이후에 삽입된다
        '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
        '     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다

        g20.InsertArrayColumns(Nothing, arr, "plan_qty")

    End Sub

    '첫번째 Display 방법: 기본기능을 이용
    Private Sub Disp_Data2()
        Try
            'Master 부분
            With g20
                .GridColumn("itm_cd").IsMasterKey = True
                .GridColumn("fac_cd").IsMasterData = True
                .GridColumn("itm_id").IsMasterData = True
                .GridColumn("itm_nm").IsMasterData = True
                .GridColumn("itm_bc").IsMasterData = True
                .GridColumn("spec").IsMasterData = True
                .GridColumn("grp1_cd").IsMasterData = True
                .GridColumn("model_cd").IsMasterData = True
                .GridColumn("spec1").IsMasterData = True
                .GridColumn("tot_qty").IsMasterData = True

                'Detail 부분
                .GridColumn("plan_dt").IsDetailKey = True
                .GridColumn("plan_qty").IsDetailData = True

                ''화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다
                '.GridColumn("work_mon").DefaultText = work_mon.Text
            End With

            g20.Open()

        Catch ex As Exception

            MessageInfo(ex, "Disp_Data()")

        End Try
    End Sub

#End Region



    Private Sub btn_all_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_all.Click
        Me.OpenDataSet("ppd200_work")
        MessageInfo("Successfully Done")

        Me._Open_Deteil()
    End Sub

    Private Sub btn_row_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_row.Click
        Me.OpenDataSet("ppd200_work2")
        MessageInfo("Successfully Done")

        Me._Open_Deteil()
    End Sub

    Private Sub btn_del_all_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del_all.Click
        Me.OpenDataSet("ppd200_delete")
        MessageInfo("Successfully Done")

        Me._Open_Deteil()
    End Sub

    Private Sub btn_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del.Click
        Me.OpenDataSet("ppd200_delete2")
        MessageInfo("Successfully Done")

        Me._Open_Deteil()
    End Sub


    Private Sub fr_dt_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles fr_dt.TextChanging
        If fr_dt.Text <> "" And days.ToDec > 0 Then
            to_dt.Text = ToDateStr(DateAdd(DateInterval.Day, days.ToDec - 1, CDate(newValue)))
        End If
    End Sub

    Private Sub days_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles days.TextChanging
        If fr_dt.Text <> "" And days.ToDec > 0 Then
            to_dt.Text = ToDateStr(DateAdd(DateInterval.Day, days.ToDec - 1, CDate(fr_dt.Text)))
        End If
    End Sub

    Private m_OpenStop As Boolean = True
    Private Sub ty_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ty.TextChanged
        If m_OpenStop Then
            Exit Sub
        End If
        Me._Open()
    End Sub

    Private m_StopOpen As Boolean

    Private Sub g10_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g10.AfterMoveRow

        Me._Open_Deteil()

    End Sub


    Private Sub SimpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        If Not CheckRequired(fac_cd, fr_dt, to_dt) Then
            Exit Sub
        End If

        Select Case MessageYesNoCancel("주의 : " + fr_dt.Text + " ~ " + to_dt.Text + " 기간에 등록된 기존 생산계획 Data가 삭제됩니다!")
            Case MsgBoxResult.Yes
                Me.OpenDataSet("ppd200_copy")
                Me._Open()
            Case MsgBoxResult.No
                Exit Sub
            Case MsgBoxResult.Cancel
                Exit Sub
        End Select

    End Sub

End Class
