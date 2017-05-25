Imports Frame7
Imports Base7
Imports Base7.Shared

Imports System.Data
Imports DevExpress.XtraCharts
Imports DevExpress.XtraTab
Imports DevExpress.XtraGrid

Public Class WP_PR3091

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

        If CheckRequired(fr_dt, fr_to) Then

            

            Me.OpenGrid()
            Me.OpenChart()



        End If

        isLoad = True
        isHap = False


    End Sub


    Private Sub OpenGrid()



        Me.Init_Title()

        Me.Disp_Data()



    End Sub
    Private Sub Init_Title()


        Dim dSet As DataSet = Me.OpenDataSet("wp_pr3091_f10")
        If IsEmpty(dSet) Then
            MessageInfo("조회 할 Data가 없습니다")
            Exit Sub
        End If

        Dim arr(1, 0) As String, inx As Integer = 0
        For Each dRow In dSet.Tables(0).Rows
            ReDim Preserve arr(1, inx)      'Array를 증가시킨다

            arr(0, inx) = dRow(0)           'FieldName 으로 사용된다
            arr(1, inx) = dRow(1)           'Title로 사용된다

            inx += 1
        Next

        g10.InsertArrayColumns(Nothing, arr, "gd_nm")
        g10.InsertArrayColumns(Nothing, arr, "a")
        '  g10.InsertMultiColumns(arr)


    End Sub
    Private Sub Disp_Data()
        With g10
            'Master 부분
            .GridColumn("IP_QTY").TextAlign = Right
            .GridColumn("GD_NM").IsMasterKey = True
            .GridColumn("a").IsMasterKey = True

            ''Detail 부분
            .GridColumn("NG_CD").IsDetailKey = True

            ''Multi Column 으로 정의 시 2개이상의 컬럼이 DetailData 로 정의되어야 한다
            .GridColumn("IP_QTY").TextAlign = Alignment.Right
            .GridColumn("IP_QTY").IsDetailData = True

            Dim param As OpenParameters = New OpenParameters
            param.Add("@fr_dt", fr_dt.Text)

            Me.Open("wp_pr3091_g10", param)
            ' .GridColumn("IP_QTY").TextAlign = Right

        End With
    End Sub


    Private Sub OpenChart()
        Try
            Dim param As OpenParameters = New OpenParameters
            param.Add("@fr_dt", fr_dt.Text)


            Dim dSet1 As DataSet = Me.OpenDataSet("wp_pr3091_chart1", param)


            Me.Chart1(chart1_1, dSet1.Tables(0))


            'LoadedGridDataDrawChart2(g10, Chart1_2, "일")


            Chart1_2.Series.Clear()

            Dim dSet2 As DataSet = Me.OpenDataSet("wp_pr3091_f10", param)

            Dim i, c As Integer
            For i = 0 To dSet2.Tables(0).Rows.Count
                CreateChartSeriesKJI(i + 4, dSet2.Tables(0).Rows(i)("NG_NM").ToString)
            Next

            isHap = True


        Catch
            '    Chart1_2.Series.Clear()
        End Try



       

    End Sub
    Private Function CreateChartSeriesKJI(ByVal ColIndex As Integer, ByVal Title As String) As DevExpress.XtraCharts.Series

        
        Dim Series As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.Bar)

        Series.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        Series.PointOptions.ValueNumericOptions.Precision = 0
        Series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        Series.PointOptions.PointView = DevExpress.XtraCharts.PointView.Values
        Series.Label.ResolveOverlappingMinIndent = 5
        Series.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        Series.Name = Title
        Chart1_2.Series.Add(Series)

        CType(Series, System.ComponentModel.ISupportInitialize).BeginInit()

        Dim Row As Integer

        For Row = 0 To g10.RowCount - 1
            Dim value As Double = 0
            If ToStr(g10.Text(ColIndex, Row)) = "" Then
                value = 0
            Else
                value = g10.Text(ColIndex, Row)
            End If
            Dim point As New SeriesPoint(ToStr(g10.Text(0, Row)), value)
            Series.Points.Add(point)
        Next

        CType(Series, System.ComponentModel.ISupportInitialize).EndInit()
 
        Return Series

    End Function



    Private Sub Chart1(ByVal ChartControls As DevExpress.XtraCharts.ChartControl, dTable As DataTable)

        Dim cnt_srs As Integer

        If ChartControls.Name = "chart1_1" Or ChartControls.Name = "chart2_1" Then
            cnt_srs = 1
        End If

        If dTable.Rows.Count = 0 Then
        Else

            For s = 0 To cnt_srs - 1
                Dim table As New DataTable

                table.Columns.Add("NG_RT", GetType(String))
                table.Columns.Add("Value", GetType(Decimal))
                For i = 0 To dTable.Rows.Count - 1
                    Dim row As DataRow = table.NewRow()
                    row(0) = dTable.Rows(i)("NG_NM").ToString
                    row(1) = dTable.Rows(i)("NG_RT")
                    table.Rows.Add(row)
                Next

                ChartControls.Series(s).DataSource = table
                ChartControls.Series(s).ArgumentDataMember = "NG_RT"
                ChartControls.Series(s).ValueDataMembers.AddRange(New String() {"Value"})

            Next

        End If
    End Sub


    

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




End Class
