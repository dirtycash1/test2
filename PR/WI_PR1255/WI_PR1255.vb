Imports Base7
Imports Base7.Shared
Imports DevExpress.XtraCharts
Imports System.Data
Imports System.Windows.Forms
Imports System.Drawing

Public Class WI_PR1255
    Dim isHap As Boolean = False
    Dim p As New OpenParameters
    Dim p2 As New OpenParameters
    Dim slt_model As String = ""

    Private Sub kijong_cd_TextChanged(sender As Object, e As System.EventArgs) Handles kijong_cd.TextChanged

        If kijong_cd.Text <> "" Then
            modify()
        End If

    End Sub

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load    '메뉴 로드

        'chartcontrol2.Visible = True
        'Chart3.Visible = False

        'tabcontrol.Visible = False
        'g20.Visible = True
        'EPanel3.Text = "제품별 일별 수율 현황"

        p.Clear()

        p.Add("@fr_dt", "9999-01-01")
        p.Add("@to_dt", "9999-01-01")
        p.Add("@fac_cd", fac_cd.Text)
        p.Add("@kijong_cd", "XXX")
        p.Add("@nm_nm", "XXXX")

        Me.Open("wi_pr1255_1", p)
        'sbchart(chart1.Series(0), "wi_pr1255_1", p, "수율")

        'g20_select()

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                chartcontrol2.Visible = True
                Chart3.Visible = False

                tabcontrol.Visible = False
                g20.Visible = True

                'If kijong_cd.Text <> "" Then
                '    modify()
                'End If

                p.Clear()
                p.Add("@fr_dt", fr_dt.Text)
                p.Add("@to_dt", to_dt.Text)
                p.Add("@fac_cd", fac_cd.Text)
                p.Add("@kijong_cd", slt_model)
                p.Add("@nm_nm", nm_nm.Text)

                Me.Open("wi_pr1255_1", p)
                sbchart(chart1.Series(0), "wi_pr1255_1", p, "수율")

                g20_select()

                EPanel3.Text = "제품별 일별 수율 현황"

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub


    Public Sub g20_select()  '제품별 일별 수율
        p.Clear()

        p.Add("@fr_dt", fr_dt.Text)
        p.Add("@to_dt", to_dt.Text)
        p.Add("@fac_cd", fac_cd.Text)
        p.Add("@kijong_cd", slt_model)
        p.Add("@nm_nm", nm_nm.Text)

        Me.Open("wi_pr1255_2", p)       'g20 그리드 
        Me.OpenChart1()                 'g20 그래프 

        '기타요청사항: 데이터 없는 일은 화면에서 나타내지 않기
        For i = 1 To 9
            Dim su As String = "m0" + i.ToString + "_su"
            If g20.Text(su, g20.RowCount - 1) = "" Then
                g20.ColumnVisible(su) = False
            Else
                g20.ColumnVisible(su) = True
            End If
        Next

        For i = 10 To 31
            Dim su As String = "m" + i.ToString + "_su"
            If g20.Text(su, g20.RowCount - 1) = "" Then
                g20.ColumnVisible(su) = False
            Else
                g20.ColumnVisible(su) = True
            End If
        Next

    End Sub

    Public Sub modify()  '제품군변경시, 해당 제품명만 나타내기 
        slt_model = ""
        nm_nm.ClearItems()

        If kijong_cd.Text <> "" Then
            'slt_model = ""
            'nm_nm.ClearItems()
            p.Clear()
            p.Add("@kijong_cd", kijong_cd.Text)

            Dim dSet As DataSet = Me.OpenDataSet("wi_pr1255_model", p)

            If IsEmpty(dSet) Then
                MessageInfo("조회 할 Data가 없습니다")
                Exit Sub
            End If

            Dim arr(1, 0) As String, inx As Integer = 0
            For Each dRow In dSet.Tables(0).Rows
                ReDim Preserve arr(1, inx)      'Array를 증가시킨다

                arr(0, inx) = dRow(0)           '각 제품군 model_cd를 조회
                'arr(1, inx) = dRow(1)           'Title로 사용된다

                slt_model = arr(0, inx) + slt_model  '제품군을 한줄로 이음
                inx += 1

            Next

            '제품군 선택시, 선택된 제품군에 해당하는 제품명만 나타내기.AddItem
            p2.Clear()
            p2.Add("@kijong_cd", kijong_cd.Text)

            Dim dSet2 As DataSet = Me.OpenDataSet("wi_pr1255_nm", p2)

            If IsEmpty(dSet2) Then
                MessageInfo("조회 할 Data가 없습니다")
                Exit Sub
            End If

            For Each dRow2 In dSet2.Tables(0).Rows
                'nm_nm.AddItem(ToStr(dRow2("NM_CD")), ToStr(dRow2("NM_NM")))
                nm_nm.AddItem(ToStr(dRow2("NM_NM")), ToStr(dRow2("NM_NM")))    '조회시, 첫번째값을 @nm_nm에 넣기
            Next

        End If

    End Sub


    Public Sub sbchart(ByVal Series As Series, ByVal WorkSetCode As String, ByVal P As OpenParameters, ByVal series_Name As String)  '제품별 수율 (막대 그래프)
        Dim dSet As DataSet, dRows As DataRowCollection, dRow As DataRow   ' SMK
        dSet = Me.OpenDataSet(WorkSetCode, P)
        dRows = dSet.Tables(0).Rows
        Series.Points.Clear()
        Series.Name = series_Name
        For Each dRow In dRows
            Dim value As Double = 0
            If ToStr(dRow("tot_su")) = "" Then    ' 누적 수율
                value = 0
            Else
                value = dRow("tot_su")
            End If
            Dim point As New SeriesPoint(ToStr(dRow("NM_NM")), Math.Round(value, 1))   '하단제목 (제품명)
            Series.Points.Add(point)
        Next

    End Sub

    Private Sub OpenChart1()
        Try
            LoadedGridDataDrawChart2(g20, chartcontrol2, "일")
        Catch
        End Try
    End Sub

    '제품별 일별 수율 현황 (g20) 그래프
    Private Sub LoadedGridDataDrawChart2(grid As Frame7.eGrid, ChartControl As DevExpress.XtraCharts.ChartControl, Day_Month_Unit As String, Optional MouseEvent As Boolean = False)

        ChartControl.Series.Clear()
        If isHap = False Then
            For RowCount = 0 To grid.RowCount - 1
                Dim row As DataRow = grid.DataSet.Tables(0).Rows(RowCount)
                If MouseEvent = False Then
                    If row(0) = "합계" Then
                        Return
                    End If
                End If

                ChartControl.Series.Add(CreateChart2Series2(MakeDataTable2(row, Day_Month_Unit), row, Day_Month_Unit))  '제품별 일별 수율 그래프
            Next
        Else
            For RowCount = grid.RowCount - 1 To grid.RowCount - 1
                Dim row As DataRow = grid.DataSet.Tables(0).Rows(RowCount)

                ChartControl.Series.Add(CreateChart2Series2(MakeDataTable2(row, Day_Month_Unit), row, Day_Month_Unit))  '제품별 일별 수율 그래프
            Next
        End If
    End Sub

    '제품별 일별 수율 그래프
    Private Function CreateChart2Series2(table As DataTable, row As DataRow, Day_Month_Unit As String) As DevExpress.XtraCharts.Series   '제품별 일별 수율 그래프
        Dim PointOptions1 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
        Dim LineSeriesView2 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim PointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()

        Dim ChartTitle As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()

        CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()

        LineSeriesView2.LineMarkerOptions.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        LineSeriesView2.LineMarkerOptions.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        LineSeriesView2.LineMarkerOptions.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid
        LineSeriesView2.LineMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Hexagon
        LineSeriesView2.LineMarkerOptions.Size = 13

        PointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number '숫자시 사용
        PointOptions1.ValueNumericOptions.Precision = 2

        PointSeriesLabel1.Visible = False
        PointSeriesLabel1.Border.Visible = False
        PointSeriesLabel1.BackColor = Color.Transparent
        PointOptions1.Pattern = "{S}:{V}"  ' 그래프에 값표시 [제목:값]

        'chartcontrol2.charttitle = ""

        Dim Series1 As New DevExpress.XtraCharts.Series(row(0), ViewType.Line)   '꺽은선 그래프
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()

        Series1.DataSource = MakeDataTable2(row, Day_Month_Unit) ' table
        Series1.ArgumentDataMember = "col_day"
        Series1.ValueDataMembers.AddRange(New String() {"Value"})
        Series1.Label = PointSeriesLabel1
        Series1.PointOptions = PointOptions1

        If row(0) = "인터로조" Then
            Series1.View = LineSeriesView2
        End If

        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()

        Return Series1
    End Function

    ''제품별 일별 수율 그래프 위한 makedatatable, colnm 
    Private Function MakeDataTable2(row As DataRow, Day_Month_Unit As String) As DataTable
        Dim table As New DataTable

        table.Columns.Add("col_day", GetType(String))
        table.Columns.Add("Value", GetType(Decimal))

        Dim d_to_dt = Convert.ToInt32(to_dt.Text.Substring(8, 2))
        Dim d_to_mon = Convert.ToInt32(to_dt.Text.Substring(5, 2))

        If Day_Month_Unit = "일" Then
            For i = 1 To d_to_dt
                Dim dr As DataRow = table.NewRow()
                dr(0) = i.ToString + Day_Month_Unit
                dr(1) = ToDec(row(ColNm2(i)))       ' /100 --백분율 표시때 사용

                If dr(1) <> 0 Then                  '데이터 NULL값이면 표시하지 않기 
                    table.Rows.Add(dr)
                End If

            Next
        End If

        Return table
    End Function

    Private Function ColNm2(ByVal num As Integer) As String
        If num.ToString.Length = 1 Then
            Return "m0" + num.ToString + "_su"
        Else
            Return "m" + num.ToString() + "_su"
        End If

    End Function

    'g10 더블클릭시, 상세 불량현황 
    Private Sub g10_DoubleClick(sender As Object, e As System.EventArgs) Handles g10.DoubleClick

        chartcontrol2.Visible = False
        Chart3.Visible = True

        tabcontrol.Visible = True
        g20.Visible = False

        EPanel3.Text = "공정별 불량 현황"

        'Me.OpenGrid_gg1()
        'Me.OpenChart_gg1()

        If tabcontrol.SelectedTabPageIndex = "0" Then
            Me.OpenGrid_gg1() '사출
            Me.OpenChart_gg1()

        ElseIf tabcontrol.SelectedTabPageIndex = "1" Then
            Me.OpenGrid_gg2() '분리
            Me.OpenChart_gg2()

        ElseIf tabcontrol.SelectedTabPageIndex = "2" Then
            Me.OpenGrid_gg3() '전면
            Me.OpenChart_gg3()

        ElseIf tabcontrol.SelectedTabPageIndex = "3" Then
            Me.OpenGrid_gg4() '누수
            Me.OpenChart_gg4()

        ElseIf tabcontrol.SelectedTabPageIndex = "4" Then
            Me.OpenGrid_gg5() '규격
            Me.OpenChart_gg5()

        End If


    End Sub


    Private Sub tabcontrol_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles tabcontrol.SelectedPageChanged

        If tabcontrol.SelectedTabPageIndex = "0" Then
            Me.OpenGrid_gg1() '사출
            Me.OpenChart_gg1()

        ElseIf tabcontrol.SelectedTabPageIndex = "1" Then
            Me.OpenGrid_gg2() '분리
            Me.OpenChart_gg2()

        ElseIf tabcontrol.SelectedTabPageIndex = "2" Then
            Me.OpenGrid_gg3() '전면
            Me.OpenChart_gg3()

        ElseIf tabcontrol.SelectedTabPageIndex = "3" Then
            Me.OpenGrid_gg4() '누수
            Me.OpenChart_gg4()

        ElseIf tabcontrol.SelectedTabPageIndex = "4" Then
            Me.OpenGrid_gg5() '규격
            Me.OpenChart_gg5()

        End If

    End Sub

    Private Sub OpenGrid_gg1()
        Dim p1 As OpenParameters = New OpenParameters
        p1.Clear()
        p1.Add("@fr_dt", fr_dt.Text)
        p1.Add("@to_dt", to_dt.Text)
        p1.Add("@fac_cd", fac_cd.Text)
        p1.Add("@nm_nm", g10.Text("NM_NM", g10.RowIndex))
        p1.Add("@gong_cd", "10") '사출

        Me.Open("wi_pr1255_gg1", p1)

        '기타요청사항: 데이터 없는 일은 화면에서 나타내지 않기
        For i = 1 To 9
            Dim ng As String = "m0" + i.ToString + "_ng"
            Dim rt As String = "m0" + i.ToString + "_rt"
            If gg1.Text(ng, gg1.RowCount - 1) = "" Then
                gg1.ColumnVisible(ng) = False
                gg1.ColumnVisible(rt) = False
            Else
                gg1.ColumnVisible(ng) = True
                gg1.ColumnVisible(rt) = True
            End If
        Next

        For i = 10 To 31
            Dim ng As String = "m" + i.ToString + "_ng"
            Dim rt As String = "m" + i.ToString + "_rt"
            If gg1.Text(ng, gg1.RowCount - 1) = "" Then
                gg1.ColumnVisible(ng) = False
                gg1.ColumnVisible(rt) = False
            Else
                gg1.ColumnVisible(ng) = True
                gg1.ColumnVisible(rt) = True
            End If
        Next

    End Sub

    Private Sub OpenGrid_gg2()
        Dim p1 As OpenParameters = New OpenParameters
        p1.Clear()
        p1.Add("@fr_dt", fr_dt.Text)
        p1.Add("@to_dt", to_dt.Text)
        p1.Add("@fac_cd", fac_cd.Text)
        p1.Add("@nm_nm", g10.Text("NM_NM", g10.RowIndex))
        p1.Add("@gong_cd", "20") '분리

        Me.Open("wi_pr1255_gg2", p1)

        '기타요청사항: 데이터 없는 일은 화면에서 나타내지 않기
        For i = 1 To 9
            Dim ng As String = "m0" + i.ToString + "_ng"
            Dim rt As String = "m0" + i.ToString + "_rt"
            If gg2.Text(ng, gg2.RowCount - 1) = "" Then
                gg2.ColumnVisible(ng) = False
                gg2.ColumnVisible(rt) = False
            Else
                gg2.ColumnVisible(ng) = True
                gg2.ColumnVisible(rt) = True
            End If
        Next

        For i = 10 To 31
            Dim ng As String = "m" + i.ToString + "_ng"
            Dim rt As String = "m" + i.ToString + "_rt"
            If gg2.Text(ng, gg2.RowCount - 1) = "" Then
                gg2.ColumnVisible(ng) = False
                gg2.ColumnVisible(rt) = False
            Else
                gg2.ColumnVisible(ng) = True
                gg2.ColumnVisible(rt) = True
            End If
        Next
    End Sub

    Private Sub OpenGrid_gg3()
        Dim p1 As OpenParameters = New OpenParameters
        p1.Clear()
        p1.Add("@fr_dt", fr_dt.Text)
        p1.Add("@to_dt", to_dt.Text)
        p1.Add("@fac_cd", fac_cd.Text)
        p1.Add("@nm_nm", g10.Text("NM_NM", g10.RowIndex))
        p1.Add("@gong_cd", "50") '전면

        Me.Open("wi_pr1255_gg3", p1)

        '기타요청사항: 데이터 없는 일은 화면에서 나타내지 않기
        For i = 1 To 9
            Dim ng As String = "m0" + i.ToString + "_ng"
            Dim rt As String = "m0" + i.ToString + "_rt"
            If gg3.Text(ng, gg3.RowCount - 1) = "" Then
                gg3.ColumnVisible(ng) = False
                gg3.ColumnVisible(rt) = False
            Else
                gg3.ColumnVisible(ng) = True
                gg3.ColumnVisible(rt) = True
            End If
        Next

        For i = 10 To 31
            Dim ng As String = "m" + i.ToString + "_ng"
            Dim rt As String = "m" + i.ToString + "_rt"
            If gg3.Text(ng, gg3.RowCount - 1) = "" Then
                gg3.ColumnVisible(ng) = False
                gg3.ColumnVisible(rt) = False
            Else
                gg3.ColumnVisible(ng) = True
                gg3.ColumnVisible(rt) = True
            End If
        Next

    End Sub

    Private Sub OpenGrid_gg4()
        Dim p1 As OpenParameters = New OpenParameters
        p1.Clear()
        p1.Add("@fr_dt", fr_dt.Text)
        p1.Add("@to_dt", to_dt.Text)
        p1.Add("@fac_cd", fac_cd.Text)
        p1.Add("@nm_nm", g10.Text("NM_NM", g10.RowIndex))
        p1.Add("@gong_cd", "70") '누수

        Me.Open("wi_pr1255_gg4", p1)

        '기타요청사항: 데이터 없는 일은 화면에서 나타내지 않기
        For i = 1 To 9
            Dim ng As String = "m0" + i.ToString + "_ng"
            Dim rt As String = "m0" + i.ToString + "_rt"
            If gg4.Text(ng, gg4.RowCount - 1) = "" Then
                gg4.ColumnVisible(ng) = False
                gg4.ColumnVisible(rt) = False
            Else
                gg4.ColumnVisible(ng) = True
                gg4.ColumnVisible(rt) = True
            End If
        Next

        For i = 10 To 31
            Dim ng As String = "m" + i.ToString + "_ng"
            Dim rt As String = "m" + i.ToString + "_rt"
            If gg4.Text(ng, gg4.RowCount - 1) = "" Then
                gg4.ColumnVisible(ng) = False
                gg4.ColumnVisible(rt) = False
            Else
                gg4.ColumnVisible(ng) = True
                gg4.ColumnVisible(rt) = True
            End If
        Next
    End Sub

    Private Sub OpenGrid_gg5()
        Dim p1 As OpenParameters = New OpenParameters
        p1.Clear()
        p1.Add("@fr_dt", fr_dt.Text)
        p1.Add("@to_dt", to_dt.Text)
        p1.Add("@fac_cd", fac_cd.Text)
        p1.Add("@nm_nm", g10.Text("NM_NM", g10.RowIndex))
        p1.Add("@gong_cd", "80") '규격

        Me.Open("wi_pr1255_gg5", p1)

        '기타요청사항: 데이터 없는 일은 화면에서 나타내지 않기
        For i = 1 To 9
            Dim ng As String = "m0" + i.ToString + "_ng"
            Dim rt As String = "m0" + i.ToString + "_rt"
            If gg5.Text(ng, gg5.RowCount - 1) = "" Then
                gg5.ColumnVisible(ng) = False
                gg5.ColumnVisible(rt) = False
            Else
                gg5.ColumnVisible(ng) = True
                gg5.ColumnVisible(rt) = True
            End If
        Next

        For i = 10 To 31
            Dim ng As String = "m" + i.ToString + "_ng"
            Dim rt As String = "m" + i.ToString + "_rt"
            If gg5.Text(ng, gg5.RowCount - 1) = "" Then
                gg5.ColumnVisible(ng) = False
                gg5.ColumnVisible(rt) = False
            Else
                gg5.ColumnVisible(ng) = True
                gg5.ColumnVisible(rt) = True
            End If
        Next
    End Sub


    Private Sub OpenChart_gg1()
        Try
            LoadedGridDataDrawChart3(gg1, Chart3, "일") '사출 (꺽은선 그래프)
        Catch
        End Try
    End Sub

    Private Sub OpenChart_gg2()
        Try
            LoadedGridDataDrawChart3(gg2, Chart3, "일") '사출 (꺽은선 그래프)
        Catch
        End Try
    End Sub
    Private Sub OpenChart_gg3()
        Try
            LoadedGridDataDrawChart3(gg3, Chart3, "일") '사출 (꺽은선 그래프)
        Catch
        End Try
    End Sub

    Private Sub OpenChart_gg4()
        Try
            LoadedGridDataDrawChart3(gg4, Chart3, "일") '사출 (꺽은선 그래프)
        Catch
        End Try
    End Sub

    Private Sub OpenChart_gg5()
        Try
            LoadedGridDataDrawChart3(gg5, Chart3, "일") '사출 (꺽은선 그래프)
        Catch
        End Try
    End Sub

    '클릭했을때, 하나씩 나오게끔
    Private Sub gg1_Click(sender As System.Object, e As System.EventArgs) Handles gg1.Click  '클릭했을때 하나씩 나오게끔
        If gg1.RowCount <> 0 Then
            ClickCreateChart1(gg1, Chart3, "일")
        End If
    End Sub
    Private Sub gg2_Click(sender As System.Object, e As System.EventArgs) Handles gg2.Click  '클릭했을때 하나씩 나오게끔
        If gg2.RowCount <> 0 Then
            ClickCreateChart1(gg2, Chart3, "일")
        End If
    End Sub
    Private Sub gg3_Click(sender As System.Object, e As System.EventArgs) Handles gg3.Click  '클릭했을때 하나씩 나오게끔
        If gg3.RowCount <> 0 Then
            ClickCreateChart1(gg3, Chart3, "일")
        End If
    End Sub
    Private Sub gg4_Click(sender As System.Object, e As System.EventArgs) Handles gg4.Click  '클릭했을때 하나씩 나오게끔
        If gg4.RowCount <> 0 Then
            ClickCreateChart1(gg4, Chart3, "일")
        End If
    End Sub
    Private Sub gg5_Click(sender As System.Object, e As System.EventArgs) Handles gg5.Click  '클릭했을때 하나씩 나오게끔
        If gg5.RowCount <> 0 Then
            ClickCreateChart1(gg5, Chart3, "일")
        End If
    End Sub

    Private Sub ClickCreateChart1(grid As Frame7.eGrid, ChartControl As DevExpress.XtraCharts.ChartControl, Day_Month_Unit As String)
        ChartControl.Series.Clear()
        Dim row As DataRow = grid.DataSet.Tables(0).Rows(grid.RowIndex)
        ChartControl.Series.Add(CreateChart2Series3(MakeDataTable3(row, Day_Month_Unit), row, Day_Month_Unit))
    End Sub

    '불량현황
    Private Sub LoadedGridDataDrawChart3(grid As Frame7.eGrid, ChartControl As DevExpress.XtraCharts.ChartControl, Day_Month_Unit As String, Optional MouseEvent As Boolean = False)

        ChartControl.Series.Clear()
        If isHap = False Then
            For RowCount = 0 To grid.RowCount - 1
                Dim row As DataRow = grid.DataSet.Tables(0).Rows(RowCount)
                If MouseEvent = False Then
                    If row(0) = "합계" Then
                        Return
                    End If
                End If

                ChartControl.Series.Add(CreateChart2Series3(MakeDataTable3(row, Day_Month_Unit), row, Day_Month_Unit))  '수율 그래프
            Next
        Else
            'For RowCount = grid.RowCount - 1 To grid.RowCount - 1 'smk 전체 다 보여주기 
            For RowCount = 0 To grid.RowCount - 1
                Dim row As DataRow = grid.DataSet.Tables(0).Rows(RowCount)

                ChartControl.Series.Add(CreateChart2Series3(MakeDataTable3(row, Day_Month_Unit), row, Day_Month_Unit))
            Next
        End If
    End Sub

    '불량현황
    Private Function CreateChart2Series3(table As DataTable, row As DataRow, Day_Month_Unit As String) As DevExpress.XtraCharts.Series   '불량율, 불량율 그래프 만들기
        Dim PointOptions1 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
        Dim LineSeriesView2 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim PointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()

        Dim ChartTitle As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()

        CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()

        LineSeriesView2.LineMarkerOptions.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        LineSeriesView2.LineMarkerOptions.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        LineSeriesView2.LineMarkerOptions.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid
        LineSeriesView2.LineMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Hexagon
        LineSeriesView2.LineMarkerOptions.Size = 13

        PointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number '숫자시 사용
        PointOptions1.ValueNumericOptions.Precision = 2

        ChartTitle.Text = "공정별 제품 불량 Trend"
        PointSeriesLabel1.Visible = False
        PointSeriesLabel1.Border.Visible = False
        PointSeriesLabel1.BackColor = Color.Transparent
        PointOptions1.Pattern = "{S}:{V}"  ' 그래프에 값표시 [제목:값]

        Dim Series1 As New DevExpress.XtraCharts.Series(row(0), ViewType.Line) '꺽은선 그래프
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()

        Series1.DataSource = MakeDataTable3(row, Day_Month_Unit) ' table
        Series1.ArgumentDataMember = "col_day"
        Series1.ValueDataMembers.AddRange(New String() {"Value"})
        Series1.Label = PointSeriesLabel1

        Series1.PointOptions = PointOptions1
        If row(0) = "인터로조" Then
            Series1.View = LineSeriesView2
        End If

        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()

        Return Series1
    End Function

    '불량현황
    Private Function MakeDataTable3(row As DataRow, Day_Month_Unit As String) As DataTable
        Dim table As New DataTable

        table.Columns.Add("col_day", GetType(String))
        table.Columns.Add("Value", GetType(Decimal))

        Dim d_to_dt = Convert.ToInt32(to_dt.Text.Substring(8, 2))
        Dim d_to_mon = Convert.ToInt32(to_dt.Text.Substring(5, 2))


        If Day_Month_Unit = "일" Then
            For i = 1 To d_to_dt
                Dim dr As DataRow = table.NewRow()
                dr(0) = i.ToString + Day_Month_Unit
                dr(1) = ToDec(row(ColNm3(i)))               ' / 100 --백분율 표시때 사용
                'table.Rows.Add(dr)
                If dr(1) <> 0 Then                  '데이터 NULL값이면 표시하지 않기 
                    table.Rows.Add(dr)
                End If
            Next
        End If

        Return table
    End Function

    Private Function ColNm3(ByVal num As Integer) As String
        If num.ToString.Length = 1 Then
            Return "m0" + num.ToString + "_rt"
        Else
            Return "m" + num.ToString() + "_rt"
        End If
    End Function


    'Private Sub img_save1_Click_1(sender As System.Object, e As System.EventArgs) Handles img_save1.Click
    '    Dim savefile As SaveFileDialog = New SaveFileDialog

    '    savefile.InitialDirectory = "C:\"
    '    savefile.Title = "Save Chart Image"
    '    savefile.DefaultExt = "jpg"
    '    savefile.Filter = "JPEG(*.jpg)|*.jpg|Bitmap (*.bmp)|*.bmp|GIF (*.gif)|*.gif|All Files (*.*)|*.*"
    '    savefile.FilterIndex = 0
    '    savefile.RestoreDirectory = True

    '    If savefile.ShowDialog() = DialogResult.OK Then
    '        Select Case savefile.FileName.Substring(savefile.FileName.IndexOf("."))
    '            Case ".jpg"
    '                ChartControl1.ExportToImage(savefile.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
    '            Case ".gif"
    '                ChartControl1.ExportToImage(savefile.FileName, System.Drawing.Imaging.ImageFormat.Gif)
    '            Case ".bmp"
    '                ChartControl1.ExportToImage(savefile.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
    '            Case Else
    '                MsgBox("지정된 그림파일 형식이 아니거나 잘못된 형식입니다.")
    '        End Select
    '        MsgBox(savefile.FileName + "에 저장되었습니다.")
    '    End If
    'End Sub



End Class
