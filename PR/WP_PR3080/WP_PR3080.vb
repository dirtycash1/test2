Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class WP_PR3080
    Private Sub Me_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        'With g10
        '    'Master 부분
        '    .GridColumn("kijong_cd").IsMasterKey = True
        '    .GridColumn("kijong_nm").IsMasterKey = True
        '    .GridColumn("MODEL_NM").IsMasterKey = True
        '    .GridColumn("tot_sum").IsMasterKey = True

        '    'Detail 부분
        '    .GridColumn("gong_cd").IsDetailKey = True

        '    'Multi Column 으로 정의 시 2개이상의 컬럼이 DetailData 로 정의되어야 한다
        '    .GridColumn("job_sum").IsDetailData = True
        '    .GridColumn("pr_sum").IsDetailData = True

        'End With

    End Sub

    Public Overrides Sub Open()

        Me.Init_Title()
        Me.Disp_Data()

    End Sub

#Region " 1. Grid 컬럼 초기화 "

    'Case 1. DataSet을 이용한 Title 배열
    Private Sub Init_Title()


        Dim dSet As DataSet = Me.OpenDataSet("wp_pr3080_title")
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

        g10.InsertMultiColumns(arr)


    End Sub

    Private Sub Disp_Data()

        With g10
            'Master 부분
            .GridColumn("LOT_NO").IsMasterKey = True
            .GridColumn("PR_DT").IsMasterKey = True
            .GridColumn("GD_NM").IsMasterData = True
            .GridColumn("NEW_GDCD").IsMasterData = True
            .GridColumn("SPEC").IsMasterData = True

            'Detail 부분
            .GridColumn("GONG_CD").IsDetailKey = True

            'Multi Column 으로 정의 시 2개이상의 컬럼이 DetailData 로 정의되어야 한다
            .GridColumn("PR_sum").IsDetailData = True
            .GridColumn("NG_sum").IsDetailData = True
            .GridColumn("TOT_SUM").IsDetailData = True
            .GridColumn("SAM_SUM").IsDetailData = True

            Me.Open("wp_pr3080_g10")
        End With
    End Sub
#End Region

End Class
