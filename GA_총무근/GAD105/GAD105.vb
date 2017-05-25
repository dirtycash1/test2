Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class GAD105
    Dim arr(1, 0) As String, colNm As String

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'pnlshow.Visible = False

    End Sub

    Public Overrides Sub Open()

        '화면 컬럼의 생성
        Me.Init_Title()

        'Data Display
        Me.Disp_Data()

    End Sub


#Region " 1. Grid 컬럼 초기화 "

    'Case 1. DataSet을 이용한 Title 배열
    'Private Sub Init_Title()

    '    '1. 컬럼배열을 만든다
    '    Dim dSet As DataSet = Me.OpenDataSet("gad500_title")
    '    If IsEmpty(dSet) Then
    '        MessageInfo("조회 할 Data가 없습니다")
    '        'g10.Init()
    '        Exit Sub
    '    End If

    '    Dim arr(1, 0) As String, inx As Integer = 0
    '    For Each dRow In dSet.Tables(0).Rows
    '        ReDim Preserve arr(1, inx)      'Array를 증가시킨다

    '        arr(0, inx) = dRow(0)           'FieldName 으로 사용된다
    '        arr(1, inx) = dRow(1)           'Title로 사용된다
    '        'arr(2, inx) = "근태항목"

    '        MsgBox(ToStr(dRow(1)))

    '        inx += 1
    '    Next

    '    '2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
    '    ' Ex) g10.InsertColumn("A", arr, "B")
    '    '     "A" 컬럼이후에 삽입된다
    '    '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
    '    '     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다

    '    g10.InsertArrayColumns(Nothing, arr, "qty")

    'End Sub


    Private Sub Init_Title()

        '1. 컬럼배열을 만든다

        Dim frDt As Date = fr_dt.Text   'Mid(fr_mon.Text, 1, 7) + "-01"
        Dim toDt As Date = to_dt.Text 'Mid(to_mon.Text, 1, 7) + "-01"

        Dim cnt As Integer = DateDiff(DateInterval.Day, frDt, toDt) + 1

        'MsgBox(ToStr(cnt))

        'Dim arr(1, 0) As String, colNm As String
        For i = 0 To cnt - 1
            ReDim Preserve arr(1, i)     'Array를 증가시킨다

            colNm = Format(DateAdd(DateInterval.Day, i, frDt), "yyyy-MM-dd")
            arr(0, i) = colNm            'FieldName
            'arr(1, i) = colNm.Substring(0, 4) + "년 " + colNm.Substring(5, 2) + "월" 'Title
            arr(1, i) = colNm

        Next

        'g10.InsertMultiColumns(arr)
        g10.InsertArrayColumns(Nothing, arr, "work_yn")

    End Sub




#End Region

#Region " 2. Display "

    '첫번째 Display 방법: 기본기능을 이용
    Private Sub Disp_Data()
        Try
            'Master 부분
            g10.GridColumn("emp_no").IsMasterKey = True
            g10.GridColumn("emp_nm").IsMasterKey = True
            g10.GridColumn("bs_cd").IsMasterKey = True
            g10.GridColumn("dept_cd").IsMasterData = True
            g10.GridColumn("dept_nm").IsMasterData = True
            g10.GridColumn("work_bc").IsMasterData = True
            g10.GridColumn("part_bc").IsMasterData = True


            'Detail 부분
            g10.GridColumn("work_dt").IsDetailKey = True
            g10.GridColumn("work_yn").IsDetailData = True


            MyBase.Open()


            Dim frDt As Date = fr_dt.Text
            Dim toDt As Date = to_dt.Text
            Dim cnt As Integer '= DateDiff(DateInterval.Day, frDt, toDt) + 1
            Dim total_day As Integer


            For j As Integer = 0 To g10.RowCount - 1   '아래로(열)

                total_day = 0
                cnt = DateDiff(DateInterval.Day, frDt, toDt) + 1

                For i As Integer = cnt - 1 To 0 Step -1  '옆으로(행)

                    'MsgBox("arr(1, i) : " & arr(1, i) & ", i : " & i & ", g10.Text(arr(1, i),j) : " & g10.Text(arr(1, i), j) & ", total_day : " & total_day)

                    If g10.Text(arr(1, i), j) = "1" Then
                        total_day = total_day + 1
                    Else
                        If total_day = 0 Then

                        Else
                            Exit For
                        End If

                    End If
                    g10.Text("total_day", j) = total_day

                Next

            Next




            '화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다
            'g10.GridColumn("work_dt").DefaultText = work_dt.Text

        Catch ex As Exception

            MessageInfo(ex, "Disp_Data()")

        End Try
    End Sub

#End Region


    'Private Function total_day(j As Integer) As Integer
    '    Dim frDt As Date = fr_dt.Text
    '    Dim toDt As Date = to_dt.Text
    '    Dim cnt As Integer = DateDiff(DateInterval.Day, frDt, toDt) + 1
    '    Dim str_total_day As Integer = 0



    '    For i As Integer = cnt - 1 To 0 Step -1  '옆으로(행)

    '            If g10.Text(arr(1, i)) = "1" Then
    '                str_total_day = str_total_day + 1
    '            Else
    '                Exit For
    '            End If

    '            Return str_total_day

    '        Next



    'End Function



    'Public Overrides Sub PrintForm()
    '    'MyBase.PrintForm()

    '    Dim p As OpenParameters = New OpenParameters

    '    p.Add("@co_cd", co_cd.Text)
    '    p.Add("@bs_cd", bs_cd.Text)
    '    p.Add("@work_bc", work_bc.Text)
    '    p.Add("@work_kd", work_kd.Text)
    '    p.Add("@work_mon", work_mon.Text)
    '    p.Add("@dept_cd", dept_cd.Text)
    '    p.Add("@emp_no", emp_no.Text)
    '    p.Add("@emp_nm", emp_nm.Text)

    '    GAD105.ReportView.LoadView("GAD105", "", "GAD500_Print", p) '출근대장

    'End Sub

    Private Sub btn_show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_show.Click
        pnlshow.Visible = Not pnlshow.Visible
    End Sub


End Class
