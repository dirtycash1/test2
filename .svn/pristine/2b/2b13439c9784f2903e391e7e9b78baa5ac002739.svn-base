Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class PPD100

    Private Sub PPD100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        With g10
            'master 부분
            .GridColumn("preq_no").IsMasterKey = True
            .GridColumn("preq_year").IsMasterKey = True
            .GridColumn("week").IsMasterKey = True

            .GridColumn("itm_id").IsMasterKey = True
            .GridColumn("itm_cd").IsMasterData = True
            .GridColumn("itm_nm").IsMasterData = True
            .GridColumn("list").IsMasterData = True
            .GridColumn("cust_cd").IsMasterData = True
            .GridColumn("cust_nm").IsMasterData = True
            .GridColumn("fld_cd").IsMasterData = True
            .GridColumn("fld_nm").IsMasterData = True

            .GridColumn("spec").IsMasterData = True
            .GridColumn("preq_bs").IsMasterData = True
            .GridColumn("preq_rid").IsMasterData = True
            .GridColumn("preq_nm").IsMasterData = True
            .GridColumn("so_no").IsMasterData = True
            .GridColumn("so_sq").IsMasterData = True
            .GridColumn("em_yn").IsMasterData = True

            .GridColumn("so_qty").IsMasterData = True
            .GridColumn("out_qty").IsMasterData = True
            .GridColumn("miout").IsMasterData = True
            .GridColumn("dlv_dt").IsMasterData = True
            .GridColumn("need_tot_qty").IsMasterData = True
            .GridColumn("adj_tot_qty").IsMasterData = True
            .GridColumn("preq_nm").IsMasterData = True

            'Detail Key 부분
            .GridColumn("p_week").IsDetailKey = True

            'Detail Data 부분
            ' Multi Column 으로 정의 시 2개이상의 컬럼이 DetailData 로 정의되어야 한다
            .GridColumn("need_qty").IsDetailData = True
            .GridColumn("adj_qty").IsDetailData = True
        End With
    End Sub

    Private Sub Init_Title()
        '1. 컬럼배열을 만든다
        Dim p As New OpenParameters
        p.Add("@std_year", preq_year.Text)
        p.Add("@week", week.Text)
        Dim dSet As DataSet = Me.OpenDataSet("ppd100_week", p)
        If IsEmpty(dSet) Then
            MessageInfo("조회 할 Data가 없습니다")
            'g10.Init()
            Exit Sub
        End If
        Dim bandArray(1, 0) As String, inx As Integer = 0
        For Each dRow In dSet.Tables(0).Rows
            ReDim Preserve bandArray(1, inx)                'Band Array를 증가시킨다
            bandArray(0, inx) = dRow(0)                       'Key     -> { 2011-01, 2011-02, 2011-03,,,,, }
            bandArray(1, inx) = dRow(1)     'Title   -> { 1월, 2월, 3월,,,, }

            inx += 1
            If inx = 8 Then Exit For
        Next
        '2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
        ' Ex) g10.InsertColumn("A", arr, "B")
        '     "A" 컬럼이후에 삽입된다
        '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
        '     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다
        g10.InsertMultiColumns(bandArray)
    End Sub

    Public Overrides Sub Open()
        '화면 컬럼의 생성
        Me.Init_Title()
        MyBase.Open()   '절대로 Me.Open를 쓰지 말것 쓰지 말것 무한루프로 빠짐
    End Sub

    'Public Overrides Function Save() As Boolean
    '     'g10.SaveValue("biz_area", biz_area.Text)
    '     'g10.SaveValue("bs_cd", bs_cd.Text)
    '     'g10.SaveValue("emp_no", emp_no.Text)
    '     'g10.SaveValue("plan_rev", plan_rev.Text)
    '     'g10.SaveValue("plan_year", plan_year.Text)
    '     'g10.SaveValue("sal_uh", sal_uh.Text)

    '     MyBase.Save()   '절대로 Me.Save를 쓰지 말것 무한루프로 빠짐
    '     Return True
    ' End Function

    Private Sub SumRowData()
        Dim s1 As Decimal, s2 As Decimal
        For j As Integer = 0 To g10.ColumnCount - 1
            If g10.FieldName(j).EndsWith("&&need_qty") Then s1 += g10.ToDec(j)
            If g10.FieldName(j).EndsWith("&&adj_qty") Then s2 += g10.ToDec(j)
        Next
        g10.Text("need_tot_qty") = s1
        g10.Text("adj_tot_qty") = s2
    End Sub

    Private m_StopEvent As Boolean

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        If m_StopEvent Then
            Exit Sub
        End If

        If ColumnName = "need_tot_qty" Or ColumnName = "adj_tot_qty" Then
            Exit Sub
        End If

        Me.SumRowData()
    End Sub

   
End Class
