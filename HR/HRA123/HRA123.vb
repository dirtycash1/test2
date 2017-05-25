Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class HRA123
    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        With g10
            'Master 부분
            .GridColumn("bs_cd").IsMasterKey = True

            .GridColumn("dept_cd").IsMasterKey = True
            .GridColumn("dept_nm").IsMasterData = True

            .GridColumn("avg_work").IsMasterData = True
            .GridColumn("avg_retr").IsMasterData = True

            'Detail 부분
            .GridColumn("work_mon").IsDetailKey = True

            'Multi Column 으로 정의 시 2개이상의 컬럼이 DetailData 로 정의되어야 한다
            .GridColumn("work_cnt").IsDetailData = True
            .GridColumn("hire_cnt").IsDetailData = True
            .GridColumn("retr_cnt").IsDetailData = True

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
            bandArray(1, i) = colNm.Substring(0, 4) + "년 " + colNm.Substring(5, 2) + "월" 'Title   -> { 1월, 2월, 3월,,,, }
        Next

        g10.InsertMultiColumns(bandArray)

     

    End Sub


End Class
