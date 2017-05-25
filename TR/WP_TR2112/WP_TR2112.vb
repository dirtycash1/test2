Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WP_TR2112


    Public Overrides Sub Open()

        '화면 컬럼의 생성
        Me.Init_Title()
        MyBase.Open()

        'Data Display
        'Me.Disp_Data()

    End Sub


    Private Sub Init_Title()

        ''1. 컬럼배열을 만든다
        'Dim frDt As String = "1110402"
        'Dim toDt As String = "2100410"

        ''Dim cnt As Integer = DateDiff(DateInterval.Month, frDt, toDt) + 1
        'Dim CNT As Integer = 1
        'Dim arr(1, 0) As String, colNm As String
        'For i = 0 To cnt - 1
        '    ReDim Preserve arr(1, i)     'Array를 증가시킨다

        '    colNm = "1110402"
        '    arr(0, i) = colNm            'FieldName
        '    arr(1, i) = "외화외상매출금"
        'Next
        'g10.InsertMultiColumns(arr)


        Dim dSet As DataSet = Me.OpenDataSet("wp_tr2112_title")
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

            'MsgBox(ToStr(dRow(0)))
            'MsgBox(ToStr(dRow(1)))

        Next

        'g10.InsertArrayColumns(Nothing, arr, "SPEC")
        g10.InsertMultiColumns(arr)
        'g10.InsertArrayColumns(Nothing, arr, "SPEC")


    End Sub



    Private Sub WP_TR2112_Load(sender As Object, e As EventArgs) Handles Me.Load



        Try
            'Master 부분
            g10.GridColumn("co_nm").IsMasterKey = True
            g10.GridColumn("div_nm").IsMasterKey = True
            g10.GridColumn("fr_dt").IsMasterKey = True
            g10.GridColumn("mng_val").IsMasterKey = True
            g10.GridColumn("mng_dsc").IsMasterKey = True
            g10.GridColumn("sale_emp_nm").IsMasterKey = True

            'g10.GridColumn("acc_nm").IsMasterData = True
            g10.GridColumn("acc_nm").IsMasterKey = True
            g10.GridColumn("to_dt").IsMasterData = True

            'Detail 부분
            g10.GridColumn("cury_nm").IsDetailKey = True
            'g10.GridColumn("acc_cd").IsDetailData = True

            g10.GridColumn("end_amt").IsDetailData = True    '원화잔액
            g10.GridColumn("bend_amt").IsDetailData = True   '잔액


            'MyBase.Open()
            '화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다
            'g10.GridColumn("fr_dt").DefaultText = fr_dt.Text

        Catch ex As Exception

            MessageInfo(ex, "Disp_Data()")

        End Try
    End Sub



End Class
