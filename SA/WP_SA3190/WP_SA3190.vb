Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class WP_SA3190
     Private Sub Me_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        With g10
            'Master 부분
            .GridColumn("ps_cd").IsMasterKey = True
            .GridColumn("ps_nm").IsMasterKey = True


            .GridColumn("ot_sum").IsMasterData = True
            .GridColumn("rt_sum").IsMasterData = True
            .GridColumn("act_sum").IsMasterData = True


            'Detail 부분
            .GridColumn("od_gu").IsDetailKey = True

            'Multi Column 으로 정의 시 2개이상의 컬럼이 DetailData 로 정의되어야 한다

            .GridColumn("ot_amt").IsDetailData = True
            .GridColumn("rt_amt").IsDetailData = True
            .GridColumn("act_amt").IsDetailData = True

        End With
    End Sub

    Public Overrides Sub Open()
        '화면 컬럼의 생성
        Me.Init_Title()
        MyBase.Open()
    End Sub

    '년월 기간의 Title 배열

    Private Sub Init_Title()

        ''1. 컬럼배열을 만든다
       

        ''1. 컬럼배열을 만든다
        Dim dSet As DataSet = Me.OpenDataSet("wp_sa3190_title")
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
End Class
