Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class SDY100

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
        item_yn.Text = "0"  '품목가져오기 여부

        Me._Open()
    End Sub

    Private Sub _Open()
        '화면 컬럼의 생성
        Me.Init_Title()
        MyBase.Open()
    End Sub


    Public Overrides Function Save() As Boolean
        g10.SaveValue("co_cd", co_cd.Text)
        g10.SaveValue("fac_cd", fac_cd.Text)
        g10.SaveValue("plan_year", plan_year.Text)
        g10.SaveValue("plan_rev", plan_rev.Text)

        g10.UpdateCurrentRow()

        MyBase.Save()
    End Function

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


    '단가가져오기
    Private Sub btn_amt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_amt.Click
        Me.GetAmt()
    End Sub

    Private Sub GetAmt()

        '필수 입력항목 누락여부 체크
        If Not CheckRequired(co_cd) Then
            Exit Sub
        End If

        Dim oParams As Object = Nothing
        Dim dSet As DataSet
        With g10

            Dim p As New OpenParameters, up As Decimal
            For i As Integer = 0 To .RowCount - 1
                If .Text("itm_id", i) <> "" And .ToDec("tot_qty", i) <> 0 Then

                    .RowIndex = i   'Open에 Input값(거래처)이 있는 행으로 이동

                    dSet = OpenDataSet("sdy100_price")

                    If IsEmpty(dSet) Then
                        Continue For
                    End If

                    up = ToDec(dSet.Tables(0).Rows(0).Item("up"))
                    .Text("plan_up", i) = up

                    '각월의 금액계산
                    For j As Integer = 0 To .ColumnCount - 1
                        If g10.FieldName(j).EndsWith("plan_amt") Then
                            .Text(j) = .ToDec(j - 1) * up
                        End If
                    Next

                    Me.SumRowData()

                End If
            Next

            .UpdateCurrentRow()

            If 0 < .RowCount Then
                .RowIndex = 0
            End If

        End With

    End Sub

    Private Sub SumRowData()
        Dim s1 As Decimal, s2 As Decimal
        For j As Integer = 0 To g10.ColumnCount - 1
            If g10.FieldName(j).EndsWith("plan_qty") Then s1 += g10.ToDec(j)
            If g10.FieldName(j).EndsWith("plan_amt") Then s2 += g10.ToDec(j)
        Next
        g10.Text("tot_qty") = s1
        g10.Text("tot_amt") = s2
    End Sub

    Private m_StopEvent As Boolean

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        If m_StopEvent Then
            Exit Sub
        End If

        If ColumnName.EndsWith("plan_qty") Or ColumnName.EndsWith("plan_amt") Then
            Me.SumRowData()
        End If
    End Sub

    Private Sub btn_trans_Click(sender As System.Object, e As System.EventArgs) Handles btn_trans.Click

        '품목가져오기 여부
        If trans_bc.Text.EndsWith("SDZ1") Then
            item_yn.Text = "1"  '품목가져오기 여부

            If Not CheckRequired(cust_cd) Then
                Exit Sub
            End If

            If g10.DataChanged Then
                Select Case MessageYesNoCancel("현재 작업중인 정보를 저장하시겠습니까 ?")
                    Case MsgBoxResult.Cancel
                        Exit Sub
                    Case MsgBoxResult.Yes
                        If Not Me.Save() Then
                            Exit Sub
                        End If
                End Select
            End If

            Me._Open()
        Else
            '그 외는 가져오기 공용 SP를 사용한다
            If MessageYesNo("기존 계획은 삭제되고 새로 작성됩니다." & vbLf & vbLf & "작성 하시겠습니까 ?") = MsgBoxResult.No Then
                Exit Sub
            End If

            Open("sdy100_trans")

            MessageInfo("작업이 완료되었습니다")

            Me.Open()
        End If

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
