Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class Unbound

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Open

                Me.Open_Form()

            Case MenuType.Save

                Me.save_Form()

                'Case MenuType.New

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Public Sub Open_Form()

        'MsgBox(Calculator("  (22,000*3  /3*(4+ 55.0 *6+(2/1+2)) / 2 -  2   )  "))   '3717998

        '화면 컬럼의 생성
        Me.Init_Title()

        'Data Display
        Me.Disp_Data()

        '두번째 방법
        'Dim dSet As DataSet = Me.OpenDataSet("unbound_g10")
        'Me.Disp_Data2(dSet)

    End Sub


#Region " 1. Grid 컬럼 초기화 "

    'Case 1. DataSet을 이용한 Title 배열
    Private Sub Init_Title()

        '1. 컬럼배열을 만든다
        Dim dSet As DataSet = Me.OpenDataSet("unbound_get_title")
        If IsEmpty(dSet) Then
            MessageInfo("조회 할 Data가 없습니다")
            'g10.Init()
            Exit Sub
        End If

        Dim arr(1, 0) As String, inx As Integer = 0
        For Each dRow In dSet.Tables(0).Rows
            ReDim Preserve arr(1, inx)      'Array를 증가시킨다

            arr(0, inx) = dRow(0)           'FieldName 으로 사용된다
            arr(1, inx) = dRow(1)           'Title로 사용된다

            inx += 1
        Next

        '2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
        ' Ex) g10.InsertColumn("A", arr, "B")
        '     "A" 컬럼이후에 삽입된다
        '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
        '     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다

        g10.InsertArrayColumns("dept_nm", arr, "qty")

    End Sub

    'Case 2. 년월 기간의 Title 배열
    Private Sub Init_Title2()

        '1. 컬럼배열을 만든다
        Dim frDt As Date = "2010-08" + "-01" 'fr_mon.Text + "-01"
        Dim toDt As Date = "2011-09" + "-01" 'to_mon.Text + "-01"

        Dim cnt As Integer = DateDiff(DateInterval.Month, frDt, toDt) + 1
        Dim arr(1, 0) As String, colNm As String
        For i = 0 To cnt - 1
            ReDim Preserve arr(1, i)     'Array를 증가시킨다

            colNm = Format(DateAdd(DateInterval.Month, i, frDt), "yy-MM")
            arr(0, i) = colNm            'FieldName
            arr(1, i) = colNm            'Title
        Next

        '2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
        ' Ex) g10.InsertColumn("A", arr, "B")
        '     "A" 컬럼이후에 삽입된다
        '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
        '     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다

        g10.InsertArrayColumns("dept_nm", arr, "val")

    End Sub

    'Case 3. 일자 기간의 Title 배열
    Private Sub Init_Title3()

        '1. 컬럼배열을 만든다
        Dim frDt As Date = "2010-08-01" 'fr_dt.Text
        Dim toDt As Date = "2010-09-30" 'to_dt.Text

        Dim cnt As Integer = DateDiff(DateInterval.Day, frDt, toDt) + 1
        Dim arr(1, 0) As String, colNm As String
        For i = 0 To cnt
            ReDim Preserve arr(1, i)     'Array를 증가시킨다

            colNm = Format(DateAdd(DateInterval.Day, i, frDt), "MM-dd")
            arr(0, i) = colNm            'FieldName
            arr(1, i) = colNm            'Title
        Next

        '2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
        ' Ex) g10.InsertColumn("A", arr, "B")
        '     "A" 컬럼이후에 삽입된다
        '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
        '     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다

        g10.InsertArrayColumns("dept_nm", arr, "val")

    End Sub


#End Region

#Region " 2. Display "

    '첫번째 Display 방법: 기본기능을 이용
    Private Sub Disp_Data()
        Try
            'Master 부분
            g10.GridColumn("work_mon").IsMasterKey = True
            g10.GridColumn("emp_no").IsMasterKey = True
            g10.GridColumn("emp_nm").IsMasterData = True
            g10.GridColumn("dept_nm").IsMasterData = True

            'Detail 부분
            g10.GridColumn("sum_cd").IsDetailKey = True
            g10.GridColumn("qty").IsDetailData = True

            MyBase.Open()

            '화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다
            g10.GridColumn("work_mon").DefaultText = work_mon.Text

        Catch ex As Exception

            MessageInfo(ex, "Disp_Data()")

        End Try
    End Sub

    '두번째 Display 방법: 수동 Coding
    Private Sub Disp_Data2(ByVal dSet As DataSet)

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
            Dim iRow As Integer, iCnt As Integer

            With g10

                '추가와 쓰기가 가능해야 행이 추가 된다
                g10.AllowAddRows = True
                g10.Editable = True

                iRow = -1

                For Each dRow In dSet.Tables(0).Rows
                    If s1 <> dRow("emp_no") Then

                        g10.AddNewRow()

                        iRow += 1
                        '.Row = iRow

                        .Text("emp_no", iRow) = ToStr(dRow("emp_no"))
                        .Text("emp_nm", iRow) = ToStr(dRow("emp_nm"))
                        .Text("dept_nm", iRow) = ToStr(dRow("dept_nm"))

                        s1 = ToStr(dRow("emp_no"))

                    End If

                    colNm = ToStr(dRow("sum_cd"))

                    If colNm <> "" Then
                        .Text(colNm, iRow) = ToStr(dRow("qty"))
                    End If

                    iCnt += 1

                    Parameter.MainFrame.ProgBar.Value = iCnt

                Next

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

#End Region

#Region " 3. Save "

    '첫번째 Save 방법: 기본기능을 이용
    Public Function Save_Form() As Boolean

        MyBase.Save()

    End Function

#End Region





End Class
