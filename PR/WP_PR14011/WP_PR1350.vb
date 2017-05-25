Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data


Public Class WP_PR1350
    Private Sub Me_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'Me.Open()

    End Sub

    Public Overrides Sub Open()


        Me.Init_Title()
        Me.Disp_Data()



    End Sub
#Region " 1. Grid 컬럼 초기화 "
    Private Sub Init_Title()

        Dim dSet As DataSet = Me.OpenDataSet("wi_pr1350_title")
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

        g_result.InsertMultiColumns(arr)

    End Sub

    Private Sub Disp_Data()
        With g_result
            'Master 부분
            g_result.GridColumn("t_lot_no").IsMasterKey = True
            g_result.GridColumn("t_gd_nm").IsMasterKey = True
            'g_result.GridColumn("t_gu").IsMasterKey = True
            g_result.GridColumn("t_date").IsMasterKey = True



            g_result.GridColumn("t_gongqc_cd").IsDetailKey = True
            'g_result.GridColumn("t_gongqc_nm").IsDetailKey = True
            g_result.GridColumn("t_final_re").IsDetailData = True
            g_result.GridColumn("t_gu").IsDetailData = True
            ' g_result.GridColumn("t_date").IsDetailData = True



            Me.Open("wi_pr1350_body")

            '화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다


        End With
    End Sub
#End Region



End Class
