Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class WP_SA3150
     Private Sub Me_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        With g10
            'Master 부분
            .GridColumn("KIJONG_NM").IsMasterKey = True
            .GridColumn("NM_NM").IsMasterKey = True

            .GridColumn("planot_sum").IsMasterData = True
            .GridColumn("ot_sum").IsMasterData = True
            .GridColumn("rt_sum").IsMasterData = True
            .GridColumn("amt_sum").IsMasterData = True
            .GridColumn("goal_avg").IsMasterData = True

            'Detail 부분
            .GridColumn("std_mon").IsDetailKey = True

            'Multi Column 으로 정의 시 2개이상의 컬럼이 DetailData 로 정의되어야 한다
            .GridColumn("planot_amt").IsDetailData = True
            .GridColumn("ot_amt").IsDetailData = True
            .GridColumn("rt_amt").IsDetailData = True
            .GridColumn("amt").IsDetailData = True
            .GridColumn("goal_rt").IsDetailData = True
        End With
        With g20
            'Master 부분
            .GridColumn("KIJONG_NM").IsMasterKey = True
            .GridColumn("NM_NM").IsMasterKey = True

            .GridColumn("planot_sum").IsMasterData = True
            .GridColumn("ot_sum").IsMasterData = True
            .GridColumn("rt_sum").IsMasterData = True
            .GridColumn("qty_sum").IsMasterData = True
            .GridColumn("goal_avg").IsMasterData = True

            'Detail 부분
            .GridColumn("std_mon").IsDetailKey = True

            'Multi Column 으로 정의 시 2개이상의 컬럼이 DetailData 로 정의되어야 한다
            .GridColumn("planot_qty").IsDetailData = True
            .GridColumn("ot_qty").IsDetailData = True
            .GridColumn("rt_qty").IsDetailData = True
            .GridColumn("qty").IsDetailData = True
            .GridColumn("goal_rt").IsDetailData = True
        End With
    End Sub

    Public Overrides Sub Open()
        '화면 컬럼의 생성
        Me.Init_Title()
        MyBase.Open()
    End Sub

    '년월 기간의 Title 배열
    Private Sub Init_Title()

        '1. 컬럼배열을 만든다
        Dim frDt As Date = fr_mon.Text + "-01"
        Dim toDt As Date = to_mon.Text + "-01"

        Dim cnt As Integer = DateDiff(DateInterval.Month, frDt, toDt) + 1
        Dim bandArray(1, 0) As String, colNm As String

        For i = 0 To cnt - 1
            colNm = Format(DateAdd(DateInterval.Month, i, frDt), "yyyy-MM")

            ReDim Preserve bandArray(1, i)                'Band Array를 증가시킨다
            bandArray(0, i) = colNm                       'Key     -> { 2011-01, 2011-02, 2011-03,,,,, }
            bandArray(1, i) = colNm.Substring(5, 2) + "월"     'Title   -> { 1월, 2월, 3월,,,, }
            'bandArray(1, i) = (i + 1).ToString + "월"     'Title   -> { 1월, 2월, 3월,,,, }
        Next

        g10.InsertMultiColumns(bandArray)
        g20.InsertMultiColumns(bandArray)

        '-------+------------+-------------+-------
        '       |    1월     |    2월      |   3월     <- Band Array (Band Key, Band 제목)
        '       +------+-----+------+------+---- 
        '       | 수량 | 금액 | 수량 | 금액 |           <- DetailData 로 정의된 컬럼들이 Multi로 반복
        '-------+------+-----+------+------+-------
        ' ex) g10.InsertMultiColumns(arr)
        ' - Array를 Band 컬럼으로 하고 그 밑에 
        '    DetailData 컬럼들이 Multi로 반복화면에 반복 Display됨
        ' - 마지막 DetailData 로 정의된 컬럼이후에 Arry Band들이 삽입된다, 
        '       마지막 컬럼의 순서를 조정하여 행삽입 위치조정 가능

    End Sub
End Class
