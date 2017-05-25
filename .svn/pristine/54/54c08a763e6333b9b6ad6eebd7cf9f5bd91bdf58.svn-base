Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class SDY101

    Private Sub Me_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        With g10
            'Master 부분
            .GridColumn("co_cd").IsMasterKey = True
            .GridColumn("plan_year").IsMasterKey = True
            .GridColumn("plan_rev").IsMasterKey = True
            .GridColumn("fac_cd").IsMasterKey = True
            .GridColumn("cust_cd").IsMasterKey = True
            .GridColumn("itm_id").IsMasterKey = True

            .GridColumn("cust_nm").IsMasterData = True
            .GridColumn("model_cd").IsMasterData = True
            '.GridColumn("model_nm").IsMasterData = True
            .GridColumn("itm_cd").IsMasterData = True
            .GridColumn("itm_nm").IsMasterData = True
            .GridColumn("itm_bc").IsMasterData = True
            .GridColumn("grp1_cd").IsMasterData = True
            .GridColumn("grp2_cd").IsMasterData = True
            .GridColumn("grp3_cd").IsMasterData = True
            .GridColumn("plan_up").IsMasterData = True
            .GridColumn("tot_qty").IsMasterData = True
            .GridColumn("tot_amt").IsMasterData = True

            'Detail 부분
            .GridColumn("plan_mon").IsDetailKey = True

            'Multi Column 으로 정의 시 2개이상의 컬럼이 DetailData 로 정의되어야 한다
            .GridColumn("plan_qty").IsDetailData = True
            .GridColumn("plan_amt").IsDetailData = True
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
        Dim frDt As Date = plan_year.Text + "-01" + "-01" 'fr_mon.Text + "-01"
        Dim toDt As Date = plan_year.Text + "-12" + "-01" 'to_mon.Text + "-01"

        Dim cnt As Integer = DateDiff(DateInterval.Month, frDt, toDt) + 1
        Dim bandArray(1, 0) As String, colNm As String

        For i = 0 To cnt - 1
            colNm = Format(DateAdd(DateInterval.Month, i, frDt), "yyyy-MM")

            ReDim Preserve bandArray(1, i)                'Band Array를 증가시킨다
            bandArray(0, i) = colNm                       'Key     -> { 2011-01, 2011-02, 2011-03,,,,, }
            bandArray(1, i) = (i + 1).ToString + "월"     'Title   -> { 1월, 2월, 3월,,,, }
        Next

        g10.InsertMultiColumns(bandArray)

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

    Private Sub show_bc_TextChanged(sender As Object, e As System.EventArgs) Handles show_bc.TextChanged
        Dim all As Boolean = False
        If show_bc.Text = "" Then
            all = True
        End If
        For j As Integer = 0 To g10.ColumnCount - 1
            If g10.FieldName(j).EndsWith("&plan_qty") Then
                g10.ColumnVisible(j) = (all Or show_bc.Text.Contains("qty"))
            End If
            If g10.FieldName(j).EndsWith("&plan_amt") Then
                g10.ColumnVisible(j) = (all Or show_bc.Text.Contains("amt"))
            End If
        Next
    End Sub

End Class
