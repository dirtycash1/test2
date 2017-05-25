Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class MMR400

    Public Overrides Sub Open()

        '화면 컬럼의 생성
        Me.Init_Title()

        'Data Display
        Me.Open_Data()

    End Sub

    Public Overrides Function save() As Boolean

        g10.SaveValue("fac_cd", fac_cd.Text)
        g10.SaveValue("plan_rev", plan_rev.Text)

        MyBase.Save()

    End Function

    'Case 2. 년월 기간의 Title 배열
    Private Sub Init_Title()

        '1. 컬럼배열을 만든다
        Dim frDt As Date = plan_year.Text + "-01" + "-01" 'fr_mon.Text + "-01"
        Dim toDt As Date = plan_year.Text + "-12" + "-01" 'to_mon.Text + "-01"

        Dim cnt As Integer = DateDiff(DateInterval.Month, frDt, toDt) + 1
        Dim arr(1, 0) As String, colNm As String

        For i = 0 To cnt - 1
            ReDim Preserve arr(1, i)     'Array를 증가시킨다
            colNm = Format(DateAdd(DateInterval.Month, i, frDt), "yyyy-MM")
            arr(0, i) = colNm                       'FieldName -> { 2011-01, 2011-02, 2011-03,,,,, }
            arr(1, i) = (i + 1).ToString + "월"     'Title     -> { 1월, 2월, 3월,,,, }
        Next

        g10.InsertMultiColumns("itm_nm", arr, "qty", "amt")
        '-------+------------+-------------+-------
        '       |    1월     |    2월      |   3월     <- Array
        '       +------+-----+------+------+---- 
        '       | 수량 | 금액 | 수량 | 금액 |           <- 컬럼1("qty"), 컬럼2("amt")
        '-------+------+-----+------+------+-------
        'g10.InsertMultiColumns("itm_nm", arr, "컬럼1", "컬럼2", ["컬럼2"])
        'Array를 화면에 Unbound 컬럼으로 Insert 또는 Add 한다
        ' Ex) g10.InsertMultiColumns("A", arr)
        '     "A" 컬럼이후에 삽입된다
        '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
        '     "컬럼1", "컬럼2", "컬럼3" Band 컬럼으로 설정된다

    End Sub

    '첫번째 Display 방법: 기본기능을 이용
    Private Sub Open_Data()
        Try
            With g10
                'Master 부분
                .GridColumn("plan_rev").IsMasterKey = True
                .GridColumn("fac_cd").IsMasterKey = True
                .GridColumn("itm_id").IsMasterKey = True
                .GridColumn("itm_cd").IsMasterData = True
                .GridColumn("itm_nm").IsMasterData = True
                .GridColumn("itm_bc").IsMasterData = True
                .GridColumn("grp1_cd").IsMasterData = True

                'Detail 부분
                .GridColumn("plan_mon").IsDetailKey = True
                .GridColumn("qty").IsDetailData = True
                .GridColumn("amt").IsDetailData = True
            End With

            MyBase.Open()

        Catch ex As Exception

            MessageInfo(ex, "Open_Data()")

        End Try
    End Sub



    'Private Sub Init_Title()

    '    '1. 컬럼배열을 만든다
    '    Dim frDt As Date = plan_year.Text + "-01" + "-01" 'fr_mon.Text + "-01"
    '    Dim toDt As Date = plan_year.Text + "-12" + "-01" 'to_mon.Text + "-01"

    '    Dim cnt As Integer = DateDiff(DateInterval.Month, frDt, toDt) + 1
    '    'Dim arr(1, 0) As String, 
    '    Dim colNm As String

    '    Dim columns As New Collection, col As eGridColumn

    '    For i = 0 To cnt - 1
    '        colNm = Format(DateAdd(DateInterval.Month, i, frDt), "yyyy-MM")

    '        col = g10.ClonGridColumn("qty", colNm + "_qty", , (i + 1).ToString + "월") ', colNm + "_qty")
    '        columns.Add(col)

    '        col = g10.ClonGridColumn("amt", colNm + "_amt", , (i + 1).ToString + "월") ', colNm + "_amt")
    '        columns.Add(col)

    '        '특정 기준컬럼을 복제하여 새로운 컬럼 생성
    '        'ClonGridColumn(originColumnName, newColumnName, Title, BandTitle1, BandTitle2)
    '        '               originColumnName: 복제 기준컬럼명
    '        '               newColumnName:    새로운 컬럼명
    '        '               Title             새로운 컬럼 Title, 생략하면 복제컬럼 Title이 사용됨
    '        '               BandTitle1,2      Band1,2 컬럼 Title

    '    Next

    '    g10.InsertArrayColumns("itm_nm", columns)
    '    '화면에 Columnem들을 Unbound로 Insert 또는 Add 한다
    '    ' Ex) g10.InsertColumn("A", arr)
    '    '     "A" 컬럼이후에 삽입된다
    '    '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다

    'End Sub




End Class

