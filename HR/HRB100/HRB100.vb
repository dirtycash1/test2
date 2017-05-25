Imports Frame7
Imports Base7
Imports Base7.Shared

Imports System.Data
Imports DevExpress.XtraCharts
Imports DevExpress.XtraTab
Imports DevExpress.XtraGrid

Public Class HRB100

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    'Dim chartDataRows As Data.DataRowCollection
    Dim isLoad As Boolean = False
    Dim isHap As Boolean = False

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.FormOpen()
        isLoad = True
        isHap = False

    End Sub

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
                'g20.ColumnVisible(i) = True

            Next
            SetColumnVisible(g20, True)
            SetColumnVisible(g30, True)


            Me.OpenGrid()
            Me.OpenChart()

            For i = to_dt + 2 To g10.ColumnCount - 1
                g10.ColumnVisible(i) = False
                'g20.ColumnVisible(i) = False
            Next
            SetColumnVisible(g20, False)
            SetColumnVisible(g30, False)


        End If

    End Sub


    Private Sub OpenGrid()
        Dim param As OpenParameters = New OpenParameters
        param.Add("@o_co_cd", o_co_cd.Text)
        param.Add("@o_bs_cd", o_bs_cd.Text)
        param.Add("@fr_date", fr_date.Text)
        param.Add("@o_date", o_date.Text)
        'param.Add("@amt_chk", amt_chk.Text)

        'If title.Text = "" Then
        '    param.Add("@title", title.Text)
        'Else
        '    param.Add("@title", Replace(title.Text, "','", "_"))
        'End If


        Me.Open("hrb100_tab1_g10", param)
        Me.Open("hrb100_tab1_g20", param)
        Me.Open("hrb100_tab1_g30", param)


    End Sub


    Private Sub OpenChart()
        Try
            Dim param As OpenParameters = New OpenParameters
            param.Add("@o_co_cd", o_co_cd.Text)
            param.Add("@o_bs_cd", o_bs_cd.Text)
            param.Add("@fr_date", fr_date.Text)
            param.Add("@o_date", o_date.Text)
            'param.Add("@amt_chk", amt_chk.Text)


            'If title.Text = "" Then
            '    param.Add("@title", title.Text)
            'Else
            '    param.Add("@title", Replace(title.Text, "','", "_"))
            'End If


            Dim dSet1 As DataSet = Me.OpenDataSet("hrb100_tab3_chart", param)

            Me.Chart1(chart1_3, dSet1.Tables(0))


            'LoadedGridDataDrawChart2(g10, Chart1_1, "월")
            'LoadedGridDataDrawChart2(g20, Chart1_2, "월")
            'LoadedGridDataDrawChart2(g30, chart1_3, "월")
            'isHap = True

            LoadedGridDataDrawChart2(g10, Chart1_1, "월")
            LoadedGridDataDrawChart2(g20, Chart1_2, "월")
            'LoadedGridDataDrawChart2(g30, chart1_3, "월")
            isHap = False


        Catch
            'ChartControl1.Series.Clear()
        End Try
    End Sub

    'Private Sub FindColumn()
    '    Dim finder(3) As String
    '    finder(0) = "grp1_nm=" + g50.Text("grp1_nm")
    '    finder(1) = "grp3_nm=" + g50.Text("grp3_nm")
    '    finder(2) = "tot=합계"


    '    g50.Find(finder)    '여러가지 조건으로 행을 찾을 수 있다
    'End Sub

    Private Sub Chart1(ByVal ChartControls As DevExpress.XtraCharts.ChartControl, dTable As DataTable)

        Dim cnt_srs As Integer

        If ChartControls.Name = "chart1_3" Then
            cnt_srs = 3
        Else
            cnt_srs = 1
        End If

        If dTable.Rows.Count = 0 Then
        Else

            For s = 0 To cnt_srs - 1
                Dim table As New DataTable

                table.Columns.Add("workyear", GetType(String))
                table.Columns.Add("Value", GetType(Decimal))

                For i = 0 To dTable.Rows.Count - 1
                    If dTable.Rows(i)("seq") = s + 1 Then

                        Dim row As DataRow = table.NewRow()
                        If dTable.Rows(i)("bc") = "1Y" Then
                            row(0) = dTable.Rows(i)("day_name").ToString + "1년 미만"
                        ElseIf dTable.Rows(i)("bc") = "2Y" Then
                            row(0) = dTable.Rows(i)("day_name").ToString + "1년 이상"
                        ElseIf dTable.Rows(i)("bc") = "3Y" Then
                            row(0) = dTable.Rows(i)("day_name").ToString + "2년 이상"
                        ElseIf dTable.Rows(i)("bc") = "4Y" Then
                            row(0) = dTable.Rows(i)("day_name").ToString + "3년 이상"
                        ElseIf dTable.Rows(i)("bc") = "5Y" Then
                            row(0) = dTable.Rows(i)("day_name").ToString + "4년 이상"
                        ElseIf dTable.Rows(i)("bc") = "6Y" Then
                            row(0) = dTable.Rows(i)("day_name").ToString + "5년 이상"
                        End If

                        If IsDBNull(dTable.Rows(i)("workyear")) Then
                            row(1) = 0
                        Else
                            row(1) = dTable.Rows(i)("workyear")
                        End If

                        table.Rows.Add(row)

                    End If
                Next

                ChartControls.Series(s).DataSource = table
                ChartControls.Series(s).ArgumentDataMember = "workyear"
                ChartControls.Series(s).ValueDataMembers.AddRange(New String() {"Value"})

            Next

        End If
    End Sub



    'Private Sub Chart2(ByVal ChartControls As DevExpress.XtraCharts.ChartControl, dTable As DataTable)

    '    Dim cnt_srs As Integer

    '    If ChartControls.Name = "chart2_1" Then
    '        cnt_srs = 3
    '    Else
    '        cnt_srs = 1
    '    End If

    '    If dTable.Rows.Count = 0 Then
    '    Else

    '        For s = 0 To cnt_srs - 1
    '            Dim table As New DataTable

    '            table.Columns.Add("workyear", GetType(String))
    '            table.Columns.Add("Value", GetType(Decimal))

    '            For i = 0 To dTable.Rows.Count - 1
    '                If dTable.Rows(i)("seq") = s + 1 Then

    '                    Dim row As DataRow = table.NewRow()
    '                    If dTable.Rows(i)("bc") = "1Y" Then
    '                        row(0) = dTable.Rows(i)("day_name").ToString + "HMC"
    '                    ElseIf dTable.Rows(i)("bc") = "2Y" Then
    '                        row(0) = dTable.Rows(i)("day_name").ToString + "KMC"
    '                    ElseIf dTable.Rows(i)("bc") = "3Y" Then
    '                        row(0) = dTable.Rows(i)("day_name").ToString + "SYMC"
    '                    ElseIf dTable.Rows(i)("bc") = "4Y" Then
    '                        row(0) = dTable.Rows(i)("day_name").ToString + "GM"
    '                    ElseIf dTable.Rows(i)("bc") = "5Y" Then
    '                        row(0) = dTable.Rows(i)("day_name").ToString + "기타"
    '                    End If

    '                    If IsDBNull(dTable.Rows(i)("workyear")) Then
    '                        row(1) = 0
    '                    Else
    '                        row(1) = dTable.Rows(i)("workyear")
    '                    End If

    '                    table.Rows.Add(row)

    '                End If
    '            Next

    '            ChartControls.Series(s).DataSource = table
    '            ChartControls.Series(s).ArgumentDataMember = "workyear"
    '            ChartControls.Series(s).ValueDataMembers.AddRange(New String() {"Value"})

    '        Next

    '    End If
    'End Sub

    'Private Sub Chart3(ByVal ChartControls As DevExpress.XtraCharts.ChartControl, dTable As DataTable)

    '    Dim cnt_srs As Integer

    '    If ChartControls.Name = "chart1_3" Then
    '        cnt_srs = 2
    '    Else
    '        cnt_srs = 1
    '    End If

    '    If dTable.Rows.Count = 0 Then
    '    Else

    '        For s = 0 To cnt_srs - 1
    '            Dim table As New DataTable

    '            table.Columns.Add("workyear", GetType(String))
    '            table.Columns.Add("Value", GetType(Decimal))

    '            For i = 0 To dTable.Rows.Count - 1
    '                If dTable.Rows(i)("seq") = s + 1 Then

    '                    Dim row As DataRow = table.NewRow()
    '                    If dTable.Rows(i)("bc") = "1Y" Then
    '                        row(0) = dTable.Rows(i)("day_name").ToString + "1년 미만"
    '                    ElseIf dTable.Rows(i)("bc") = "2Y" Then
    '                        row(0) = dTable.Rows(i)("day_name").ToString + "1년 이상"
    '                        'ElseIf dTable.Rows(i)("bc") = "3Y" Then
    '                        '    row(0) = dTable.Rows(i)("day_name").ToString + "DAB"
    '                        'ElseIf dTable.Rows(i)("bc") = "4Y" Then
    '                        '    row(0) = dTable.Rows(i)("day_name").ToString + "BADGE"
    '                        'ElseIf dTable.Rows(i)("bc") = "5Y" Then
    '                        '    row(0) = dTable.Rows(i)("day_name").ToString + "W/COVER"
    '                        'ElseIf dTable.Rows(i)("bc") = "6Y" Then
    '                        '    row(0) = dTable.Rows(i)("day_name").ToString + "D/S"
    '                        'ElseIf dTable.Rows(i)("bc") = "7Y" Then
    '                        '    row(0) = dTable.Rows(i)("day_name").ToString + "일체형 CAP"
    '                        'ElseIf dTable.Rows(i)("bc") = "8Y" Then
    '                        '    row(0) = dTable.Rows(i)("day_name").ToString + "기타"
    '                    End If

    '                    If IsDBNull(dTable.Rows(i)("workyear")) Then
    '                        row(1) = 0
    '                    Else
    '                        row(1) = dTable.Rows(i)("workyear")
    '                    End If

    '                    table.Rows.Add(row)

    '                End If
    '            Next

    '            ChartControls.Series(s).DataSource = table
    '            ChartControls.Series(s).ArgumentDataMember = "workyear"
    '            ChartControls.Series(s).ValueDataMembers.AddRange(New String() {"Value"})

    '        Next

    '    End If
    'End Sub

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
        PointOptions1.ValueNumericOptions.Precision = 0

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


    'Private Sub o_cust_cd_TextChanged(sender As System.Object, e As System.EventArgs) Handles o_grp1_cd.TextChanged
    '    If isLoad = True Then
    '        FormOpen()
    '    End If
    'End Sub


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
        ClickCreateChart2(g10, chart1_1, "월")
    End Sub

    Private Sub g20_Click(sender As System.Object, e As System.EventArgs) Handles g20.Click
        ClickCreateChart2(g20, chart1_2, "월")
    End Sub

    'Private Sub g30_Click(sender As System.Object, e As System.EventArgs) Handles g30.Click
    '    ClickCreateChart2(g30, chart1_3, "월")
    'End Sub



#Region "챠트2"

    Private Sub LoadedGridDataDrawChart2(grid As eGrid, ChartControl As DevExpress.XtraCharts.ChartControl, Day_Month_Unit As String, Optional MouseEvent As Boolean = False)

        ChartControl.Series.Clear()
        If isHap = False Then
            For RowCount = 0 To grid.RowCount - 1
                Dim row As DataRow = grid.DataSet.Tables(0).Rows(RowCount)
                If MouseEvent = False Then
                    If row(0) = "총인원" Then
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
        PointOptions1.ValueNumericOptions.Precision = 0

        PointSeriesLabel1.Visible = True
        PointSeriesLabel1.Border.Visible = False
        PointSeriesLabel1.BackColor = Color.Transparent

        Dim Series1 As New DevExpress.XtraCharts.Series(row(0), ViewType.Line)
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
