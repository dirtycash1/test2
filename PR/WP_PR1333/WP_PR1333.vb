Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WP_PR1333

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        With g10
            'Master 부분(왼쪽꺼)
            .GridColumn("OD_NO").IsMasterKey = True
            .GridColumn("SEQ").IsMasterKey = True
            .GridColumn("GD_CD").IsMasterKey = True

            '.GridColumn("NM_NM").IsMasterKey = True
            .GridColumn("PART").IsMasterData = True
            .GridColumn("itm_nm").IsMasterData = True
            '.GridColumn("t_test").IsMasterData = True
            '.GridColumn("t_pr").IsMasterData = True
            '.GridColumn("rt").IsMasterData = True
            '.GridColumn("rmks").IsMasterData = True
            '.GridColumn("bad_rt").IsMasterData = True

            ''Detail 부분
            .GridColumn("PART").IsDetailKey = True

            ''Multi Column 으로 정의 시 2개이상의 컬럼이 DetailData 로 정의되어야 한다
            '.GridColumn("PART").IsDetailData = True
            .GridColumn("itm_nm").IsDetailData = True

        End With
    End Sub

    Public Overrides Sub Open()

        'Me.Init_Title()
        MyBase.Open()

    End Sub


    'Private Sub Init_Title()

    '1. 컬럼배열을 만든다

    'Dim frDt As Date = Mid(fr_mon.Text, 1, 7) + "-01"
    'Dim toDt As Date = Mid(to_mon.Text, 1, 7) + "-01"

    '    Dim cnt As Integer = DateDiff(DateInterval.Month, frDt, toDt) + 1
    '    Dim arr(1, 0) As String, colNm As String
    '    For i = 0 To cnt - 1
    '        ReDim Preserve arr(1, i)     'Array를 증가시킨다

    '        colNm = Format(DateAdd(DateInterval.Month, i, frDt), "yyyy-MM")
    '        arr(0, i) = colNm            'FieldName
    '        arr(1, i) = colNm.Substring(0, 4) + "년 " + colNm.Substring(5, 2) + "월" 'Title
    '    Next

    '    g10.InsertMultiColumns(arr)

    'End Sub

End Class
