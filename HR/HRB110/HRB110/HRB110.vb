Imports Frame7
Imports Base7
Imports Base7.Shared

Imports System.Data
Imports DevExpress.XtraCharts
Imports DevExpress.XtraTab
Imports DevExpress.XtraGrid

Public Class HRB110

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    'Dim chartDataRows As Data.DataRowCollection
    Dim isLoad As Boolean = False
    Dim isHap As Boolean = False

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Init_Title()
        Me.Disp_Data()

        Me.FormOpen()
        isLoad = True
        isHap = False

        'MyBase.Open("hrb110_tab1_g30")
        sbchart()

    End Sub
    Private Sub Init_Title()

        '1. 컬럼배열을 만든다
        Dim P As New OpenParameters
        P.Add("@o_co_cd", o_co_cd.Text)
        P.Add("@o_bs_cd", o_bs_cd.Text)
        P.Add("@fr_date", fr_date.Text)
        P.Add("@o_date", o_date.Text)

        Dim dSet As DataSet = Me.OpenDataSet("hrb110_title", P)
        If IsEmpty(dSet) Then
            MessageInfo("조회 할 Data가 없습니다")
            'g10.Init()
            Exit Sub
        End If

        Dim arr(1, 0) As String, inx As Integer = 0
        For Each dRow In dSet.Tables(0).Rows
            ReDim Preserve arr(1, inx)      'Array를 증가시킨다

            arr(0, inx) = dRow(0)            'FieldName으로 사용된다
            arr(1, inx) = dRow(1)            'Title로 사용된다 (막대그래프 옆에 색상정보 나타내는 제목)

            inx += 1

        Next

        g30.InsertArrayColumns(Nothing, arr, "qty")

    End Sub
    Private Sub Disp_Data()    ' g30 그리드의 내용을 나타낸다.
        Try
            'g30.GridColumn("sq_no").IsMasterKey = True  '1
            'g30.GridColumn("ty").IsMasterKey = True    '사무관리직                            
            'g30.GridColumn("title").IsMasterData = True  '사무관리직
            'g30.GridColumn("grp_bc").IsDetailKey = True   '3개월미만
            ''g30.GridColumn("qty").IsMasterData = True    ' 8.00



            'g30.GridColumn("work_bc").IsDetailKey = True  'HR160100
            'g30.GridColumn("qty").IsDetailData = True


            ''g30.GridColumn("sq_no").IsMasterKey = True  '1
            'g30.GridColumn("sp_no").IsMasterKey = True    '사무관리직                            
            'g30.GridColumn("title").IsMasterData = True  '사무관리직
            ''g30.GridColumn("grp_bc").IsMasterKey = True   '3개월미만
            ''g30.GridColumn("qty").IsMasterData = True    ' 8.00



            'g30.GridColumn("work_bc").IsDetailKey = True  'HR160100
            '' g30.GridColumn("grp_bc").IsDetailData = True  'HR160100
            'g30.GridColumn("qty").IsDetailData = True
            '';g30.GridColumn("qty").IsDetailData = True
            ' Master 부분  SMK 
            g30.GridColumn("sq_no").IsMasterData = True  '1
            g30.GridColumn("ty").IsMasterData = True    '사무관리직                             ''g30.GridColumn("bs_cd").IsMasterData = True   '원래 주석처리 
            g30.GridColumn("title").IsMasterData = True  '사무관리직
            g30.GridColumn("work_bc").IsMasterKey = True  'HR160100


            'Detail(부분)
            g30.GridColumn("work_bc").IsDetailKey = True   '3개월미만
            g30.GridColumn("qty").IsDetailData = True    ' 8.00



            'Master 부분  SMK 
            'g30.GridColumn("sq_no").IsMasterData = True  '1
            'g30.GridColumn("ty").IsMasterData = True    '사무관리직                             ''g30.GridColumn("bs_cd").IsMasterData = True   '원래 주석처리 
            'g30.GridColumn("title").IsMasterData = True  '사무관리직
            'g30.GridColumn("work_bc").IsMasterKey = True  'HR160100


            'Detail 부분
            'g30.GridColumn("grp_bc").IsDetailKey = True   '3개월미만
            'g30.GridColumn("qty").IsDetailData = True    ' 8.00

            ' 원래 주석처리
            'MyBase.Open("hrb110_tab1_g30")
            '화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다
            'g10.GridColumn("work_mon").DefaultText = work_mon.Text

        Catch ex As Exception

            MessageInfo(ex, "Disp_Data()")

        End Try
    End Sub


#Region " 2. char "

    Public Sub sbchart()
        chart1_3.Series.Clear()
        Dim Col As Integer
        For Col = 6 To g30.ColumnCount - 1
            Dim Series As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.Bar)
            Series.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
            Series.PointOptions.ValueNumericOptions.Precision = 1
            Series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
            Series.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
            'Series.ArgumentDataMember = "Name"
            'sr.ValueDataMembers[0] = "CurrentDose"
            Series.PointOptions.PointView = DevExpress.XtraCharts.PointView.Values
            Series.Label.ResolveOverlappingMinIndent = 5
            Series.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
            Series.Name = ToStr(g30.ColumnTitle(Col))


            chart1_3.Series.Add(Series)
            chart1_3.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
            For Row = 0 To g30.RowCount - 1
                If ToStr(g30.Text("grp_bc", Row)) <> "소계" Then
                    Dim value As Double = 0
                    If ToStr(g30.Text(Col, Row)) = "" Then
                        value = 0
                    Else
                        value = g30.Text(Col, Row)
                    End If
                    'Dim point As New SeriesPoint(ToStr(g30.Text("grp_bc", Row)), value)    'SMK
                    Dim point As New SeriesPoint(ToStr(g30.Text("title", Row)), value)     ' 막대그래프의 아래 제목(title:사무관리직, 생산직, 생산기술직)
                    Series.Points.Add(point)
                End If
            Next

        Next

    End Sub


#End Region
    Public Sub Init_Form()

    End Sub



    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Open
                Me.FormOpen()
            Case Else
                MyBase.MenuButton_Click(mty)

        End Select

    End Sub


    '######################################################################################
    '##            Chart                                                                  ##
    '######################################################################################

    Private Sub FormOpen()

        If CheckRequired(o_co_cd, o_bs_cd, o_date) Then

            'Dim fr_dt = Convert.ToInt32(fr_date.Text.Substring(8, 2))
            Dim to_dt = Convert.ToInt32(o_date.Text.Substring(8, 2))

            For i = 2 To g10.ColumnCount - 1
                g10.ColumnVisible(i) = True


            Next
            SetColumnVisible(g20, True)

            'SetColumnVisible(g40, True)


            Me.OpenGrid()
            Me.OpenChart()

            For i = to_dt + 2 To g10.ColumnCount - 1
                g10.ColumnVisible(i) = False
                'g20.ColumnVisible(i) = False
            Next
            SetColumnVisible(g20, False)

            'SetColumnVisible(g40, False)

        End If

    End Sub
    Private Sub OpenGrid()      '그리드 화면을 만든다. (하단 표)
        Dim param As OpenParameters = New OpenParameters
        param.Add("@o_co_cd", o_co_cd.Text)
        param.Add("@o_bs_cd", o_bs_cd.Text)
        param.Add("@fr_date", fr_date.Text)
        param.Add("@o_date", o_date.Text)


        'Me.Open("hrb110_tab1_g10", param)   '20141028 SMK
        If work_kd.Text = "HR161100" Then   '정규직
            g10.Visible = True
            g10_2.Visible = False
            Me.Open("hrb110_tab1_g10", param)
        ElseIf work_kd.Text = "HR161150" Then   '비정규직
            g10.Visible = False
            g10_2.Visible = True
            Me.Open("hrb110_tab1_g10_2", param)
        End If

        Me.Open("hrb110_tab1_g20", param)

        Me.Init_Title()     'g30만을 위함     'smk 막음
        Me.Disp_Data()      'g30만을 위함
        MyBase.Open("hrb110_tab1_g30", param)
        ''Me.Open("hrb110_tab1_g40", param) '원래 막힘


    End Sub


    Private Sub OpenChart()     '그래프차트 화면을 만든다. (상단 그래프)
        Try
            Dim param As OpenParameters = New OpenParameters
            param.Add("@o_co_cd", o_co_cd.Text)
            param.Add("@o_bs_cd", o_bs_cd.Text)
            param.Add("@fr_date", fr_date.Text)
            param.Add("@o_date", o_date.Text)


            'LoadedGridDataDrawChart2(g10, Chart1_1, "월")
            If work_kd.Text = "HR161100" Then   '정규직
                g10.Visible = True
                g10_2.Visible = False
                LoadedGridDataDrawChart2(g10, Chart1_1, "월")
            ElseIf work_kd.Text = "HR161150" Then   '비정규직
                g10.Visible = False
                g10_2.Visible = True
                LoadedGridDataDrawChart2(g10_2, Chart1_1, "월")
            End If

            LoadedGridDataDrawChart2(g20, Chart1_2, "월")

            'LoadedGridDataDrawChart2(g40, Chart1_4, "월")
            isHap = False

        Catch

        End Try
    End Sub

    Private Function CreateChartSeries(ByVal dTable As DataTable, ByVal RowIndex As Integer, ByVal Title As String, ByVal barType As DevExpress.XtraCharts.ViewType, ByVal Day_Month_Unit As String, ByVal MouseEvent As Boolean) As DevExpress.XtraCharts.Series

        Dim PointOptions1 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
        Dim LineSeriesView2 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim PointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()

        CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()

        LineSeriesView2.LineMarkerOptions.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        LineSeriesView2.LineMarkerOptions.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        LineSeriesView2.LineMarkerOptions.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid
        LineSeriesView2.LineMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Hexagon
        LineSeriesView2.LineMarkerOptions.Size = 13

        PointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        PointOptions1.ValueNumericOptions.Precision = 1

        PointSeriesLabel1.Visible = True
        PointSeriesLabel1.Border.Visible = False
        PointSeriesLabel1.BackColor = Color.Transparent

        Dim Series1 As New DevExpress.XtraCharts.Series(Title, barType)
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()

        Series1.DataSource = CreateChartData(dTable, RowIndex, Day_Month_Unit, MouseEvent)
        Series1.ArgumentDataMember = "col_day"
        Series1.ValueDataMembers.AddRange(New String() {"Value"})
        Series1.Label = PointSeriesLabel1

        Series1.PointOptions = PointOptions1
        If Title = "인터로조" Then
            Series1.View = LineSeriesView2
        End If

        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()

        Return (Series1)
    End Function

    Private Function CreateChartData(ByVal dTable As DataTable, ByVal RowIndex As Integer, Day_Month_Unit As String, MouseEvent As Boolean) As DataTable

        Dim table As New DataTable

        table.Columns.Add("col_day", GetType(String))
        table.Columns.Add("Value", GetType(Decimal))

        Dim col_cnt = dTable.Columns.Count

        For i = 1 To col_cnt - 1
            Dim row As DataRow = table.NewRow()
            row(0) = ToDec(dTable.Columns(i).Caption).ToString + Day_Month_Unit

            If IsDBNull(dTable.Rows(RowIndex)(i)) Then
                row(1) = 0
            Else
                row(1) = dTable.Rows(RowIndex)(i)
            End If

            table.Rows.Add(row)
        Next

        Return table
    End Function


    Private Sub SetColumnVisible(grid As Frame7.eGrid, Visible As Boolean)
        Dim to_dt = Convert.ToInt32(o_date.Text.Substring(8, 2))

        If Visible = True Then
            For i = 0 To grid.ColumnCount - 1
                For j = 1 To 31
                    If grid.ColumnTitle(i).EndsWith(j.ToString + "일") Then
                        grid.ColumnVisible(i) = Visible
                    End If
                Next
            Next

        Else
            For i = 0 To grid.ColumnCount - 1
                For j = to_dt + 1 To 31
                    If grid.ColumnTitle(i).EndsWith(j.ToString + "일") Then
                        grid.ColumnVisible(i) = Visible
                    End If
                Next
            Next
        End If

    End Sub

    Private Sub g10_Click(sender As System.Object, e As System.EventArgs) Handles g10.Click
        ClickCreateChart2(g10, Chart1_1, "월")
    End Sub

    Private Sub g10_2_Click(sender As System.Object, e As System.EventArgs) Handles g10_2.Click    '20141028 SMK
        ClickCreateChart2(g10_2, Chart1_1, "월")
    End Sub

    Private Sub g20_Click(sender As System.Object, e As System.EventArgs) Handles g20.Click
        ClickCreateChart2(g20, Chart1_2, "월")
    End Sub


    'Private Sub g40_Click(sender As System.Object, e As System.EventArgs) Handles g40.Click
    '    ClickCreateChart2(g40, chart1_4, "월")
    'End Sub

#Region "챠트2"
    ' LoadedGridDataDrawChart2(g10, Chart1_1, "월")
    Private Sub LoadedGridDataDrawChart2(grid As eGrid, ChartControl As DevExpress.XtraCharts.ChartControl, Day_Month_Unit As String, Optional MouseEvent As Boolean = False)

        ChartControl.Series.Clear()
        If isHap = False Then
            For RowCount = 0 To grid.RowCount - 1
                Dim row As DataRow = grid.DataSet.Tables(0).Rows(RowCount)      ' Rows(2) : 그리드에서 0,1,2 세번째 로우의 값만 나옴.
                If MouseEvent = False Then
                    If row(0) = "이직률(%)" Then    '기존 If row(0) = "총인원" Then   'SMK 20141028 <이직률(%)까지만, 꺾은선 그래프를 그리자>
                        Return
                    End If
                End If
                ChartControl.Series.Add(CreateChart2Series(MakeDataTable(row, Day_Month_Unit), row, Day_Month_Unit))
            Next
        Else
            For RowCount = grid.RowCount - 1 To grid.RowCount - 1
                Dim row As DataRow = grid.DataSet.Tables(0).Rows(RowCount)

                ChartControl.Series.Add(CreateChart2Series(MakeDataTable(row, Day_Month_Unit), row, Day_Month_Unit))
            Next
        End If
    End Sub


    Private Function CreateChart2Series(table As DataTable, row As DataRow, Day_Month_Unit As String) As DevExpress.XtraCharts.Series
        Dim PointOptions1 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
        Dim LineSeriesView2 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim PointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()

        CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()

        LineSeriesView2.LineMarkerOptions.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        LineSeriesView2.LineMarkerOptions.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        LineSeriesView2.LineMarkerOptions.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid
        LineSeriesView2.LineMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Hexagon
        LineSeriesView2.LineMarkerOptions.Size = 13

        PointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number '숫자시 사용
        PointOptions1.ValueNumericOptions.Precision = 1

        PointSeriesLabel1.Visible = True
        PointSeriesLabel1.Border.Visible = False
        PointSeriesLabel1.BackColor = Color.Transparent

        'Dim Series1 As New DevExpress.XtraCharts.Series(row(0), ViewType.Line)   'SMK 20141028 
        Dim Series1 As New DevExpress.XtraCharts.Series '(row(0), ViewType.Line)

        If row(0) = "정규직 총인원" Or row(0) = "비정규직 총인원" Then
            Series1 = New DevExpress.XtraCharts.Series(row(0), ViewType.Bar)
        Else
            Series1 = New DevExpress.XtraCharts.Series(row(0), ViewType.Line)
        End If

        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()

        Series1.DataSource = MakeDataTable(row, Day_Month_Unit) ' table
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


    Private Sub ClickCreateChart2(grid As eGrid, ChartControl As DevExpress.XtraCharts.ChartControl, Day_Month_Unit As String)

        ChartControl.Series.Clear()
        Dim row As DataRow = grid.DataSet.Tables(0).Rows(grid.RowIndex)

        ChartControl.Series.Add(CreateChart2Series(MakeDataTable(row, Day_Month_Unit), row, Day_Month_Unit))

    End Sub



    Private Function MakeDataTable(row As DataRow, Day_Month_Unit As String) As DataTable
        Dim table As New DataTable

        table.Columns.Add("col_day", GetType(String))
        table.Columns.Add("Value", GetType(Decimal))

        Dim to_dt = Convert.ToInt32(o_date.Text.Substring(8, 2))
        Dim to_mon = Convert.ToInt32(o_date.Text.Substring(5, 2))

        If Day_Month_Unit = "일" Then
            For i = 1 To to_dt
                Dim dr As DataRow = table.NewRow()
                dr(0) = i.ToString + Day_Month_Unit
                dr(1) = ToDec(row(ColNm(i))) ' / 100 --백분율 표시때 사용
                table.Rows.Add(dr)
            Next
        Else
            For i = 1 To 12
                Dim dr As DataRow = table.NewRow()
                dr(0) = i.ToString + Day_Month_Unit
                dr(1) = ToDec(row(ColNm(i))) ' / 100 --백분율 표시때 사용
                table.Rows.Add(dr)
            Next
        End If

        Return table
    End Function


    Private Function ColNm(ByVal num As Integer) As String
        If num.ToString.Length = 1 Then
            Return "r0" + num.ToString
        Else
            Return "r" + num.ToString()
        End If
    End Function

#End Region


End Class
