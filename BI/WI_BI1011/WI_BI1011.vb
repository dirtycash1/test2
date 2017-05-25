Imports Base7
Imports Base7.Shared
Imports DevExpress.XtraCharts
Imports System.Data
Imports System.Windows.Forms
Imports System.Drawing
Imports Frame7


Public Class WI_BI1011
    Dim p As New OpenParameters
    Dim isLoad As Boolean = False
    Dim isHap As Boolean = False

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormOpen()
        isLoad = True
        isHap = False
    End Sub

    'Private Sub XtraTabControl2_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl2.SelectedPageChanged
    '    If XtraTabControl2.SelectedTabPageIndex = "1" Then  '공정별

    '        SetColumnVisible(g20, True)
    '        Me.OpenGrid2()
    '        Me.OpenChart2()
    '        SetColumnVisible(g20, False)
    '    ElseIf XtraTabControl2.SelectedTabPageIndex = "2" Then  '사출(불량)

    '        SetColumnVisible(g30, True)
    '        Me.OpenGrid3()
    '        Me.OpenChart3()
    '        SetColumnVisible(g30, False)
    '    ElseIf XtraTabControl2.SelectedTabPageIndex = "3" Then  '분리(불량)

    '        SetColumnVisible(g40, True)
    '        Me.OpenGrid4()
    '        Me.OpenChart4()
    '        SetColumnVisible(g40, False)
    '    ElseIf XtraTabControl2.SelectedTabPageIndex = "4" Then  '전면(불량)

    '        SetColumnVisible(g50, True)
    '        Me.OpenGrid5()
    '        Me.OpenChart5()
    '        SetColumnVisible(g50, False)
    '    ElseIf XtraTabControl2.SelectedTabPageIndex = "5" Then  '규격(불량)

    '        SetColumnVisible(g60, True)
    '        Me.OpenGrid6()
    '        Me.OpenChart6()
    '        SetColumnVisible(g60, False)

    '    End If
    'End Sub

    '################################# ToolBar Function #####################################################
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.FormOpen()
            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub


    '############################## CHART ########################################################

    Private Sub FormOpen()

        If CheckRequired(std_dt) Then

            SetColumnVisible(g10, True)   ' 값이 NULL인 경우에 보이지 않게 해주는 기능
            SetColumnVisible(g20, True)

            '매출액 국내
            Me.OpenGrid1()      '그리드 나타내기
            Me.OpenChart1()     '차트 만들기

            '매출액 해외
            Me.OpenGrid2()      '그리드 나타내기
            Me.OpenChart2()     '차트 만들기

            SetColumnVisible(g10, False)
            SetColumnVisible(g20, False)

        End If

        isLoad = True
        isHap = False

    End Sub

  
    Private Sub OpenGrid1()
        Dim param As OpenParameters = New OpenParameters
        param.Add("@std_dt", std_dt.Text)
        Me.Open("wi_bi1011_g10", param)

        '매출액(g10국내) = 출하액 - 반품액

        g10.InsertNewRow(3)
        g10.Text("GU_NM", 3) = "매출액"
        g10.Text("tot_amt", 3) = g10.ToDec("tot_amt", 0) - g10.ToDec("tot_amt", 1)
        g10.Text("m01_amt", 3) = g10.ToDec("m01_amt", 0) - g10.ToDec("m01_amt", 1)
        g10.Text("m02_amt", 3) = g10.ToDec("m02_amt", 0) - g10.ToDec("m02_amt", 1)
        g10.Text("m03_amt", 3) = g10.ToDec("m03_amt", 0) - g10.ToDec("m03_amt", 1)
        g10.Text("m04_amt", 3) = g10.ToDec("m04_amt", 0) - g10.ToDec("m04_amt", 1)
        g10.Text("m05_amt", 3) = g10.ToDec("m05_amt", 0) - g10.ToDec("m05_amt", 1)
        g10.Text("m06_amt", 3) = g10.ToDec("m06_amt", 0) - g10.ToDec("m06_amt", 1)
        g10.Text("m07_amt", 3) = g10.ToDec("m07_amt", 0) - g10.ToDec("m07_amt", 1)
        g10.Text("m08_amt", 3) = g10.ToDec("m08_amt", 0) - g10.ToDec("m08_amt", 1)
        g10.Text("m09_amt", 3) = g10.ToDec("m09_amt", 0) - g10.ToDec("m09_amt", 1)
        g10.Text("m10_amt", 3) = g10.ToDec("m10_amt", 0) - g10.ToDec("m10_amt", 1)
        g10.Text("m11_amt", 3) = g10.ToDec("m11_amt", 0) - g10.ToDec("m11_amt", 1)
        g10.Text("m12_amt", 3) = g10.ToDec("m12_amt", 0) - g10.ToDec("m12_amt", 1)
        g10.Text("m13_amt", 3) = g10.ToDec("m13_amt", 0) - g10.ToDec("m13_amt", 1)
        g10.Text("m14_amt", 3) = g10.ToDec("m14_amt", 0) - g10.ToDec("m14_amt", 1)
        g10.Text("m15_amt", 3) = g10.ToDec("m15_amt", 0) - g10.ToDec("m15_amt", 1)
        g10.Text("m16_amt", 3) = g10.ToDec("m16_amt", 0) - g10.ToDec("m16_amt", 1)
        g10.Text("m17_amt", 3) = g10.ToDec("m17_amt", 0) - g10.ToDec("m17_amt", 1)
        g10.Text("m18_amt", 3) = g10.ToDec("m18_amt", 0) - g10.ToDec("m18_amt", 1)
        g10.Text("m19_amt", 3) = g10.ToDec("m19_amt", 0) - g10.ToDec("m19_amt", 1)
        g10.Text("m20_amt", 3) = g10.ToDec("m20_amt", 0) - g10.ToDec("m20_amt", 1)
        g10.Text("m21_amt", 3) = g10.ToDec("m21_amt", 0) - g10.ToDec("m21_amt", 1)
        g10.Text("m22_amt", 3) = g10.ToDec("m22_amt", 0) - g10.ToDec("m22_amt", 1)
        g10.Text("m23_amt", 3) = g10.ToDec("m23_amt", 0) - g10.ToDec("m23_amt", 1)
        g10.Text("m24_amt", 3) = g10.ToDec("m24_amt", 0) - g10.ToDec("m24_amt", 1)
        g10.Text("m25_amt", 3) = g10.ToDec("m25_amt", 0) - g10.ToDec("m25_amt", 1)
        g10.Text("m26_amt", 3) = g10.ToDec("m26_amt", 0) - g10.ToDec("m26_amt", 1)
        g10.Text("m27_amt", 3) = g10.ToDec("m27_amt", 0) - g10.ToDec("m27_amt", 1)
        g10.Text("m28_amt", 3) = g10.ToDec("m28_amt", 0) - g10.ToDec("m28_amt", 1)
        g10.Text("m29_amt", 3) = g10.ToDec("m29_amt", 0) - g10.ToDec("m29_amt", 1)
        g10.Text("m30_amt", 3) = g10.ToDec("m30_amt", 0) - g10.ToDec("m30_amt", 1)
        g10.Text("m31_amt", 3) = g10.ToDec("m31_amt", 0) - g10.ToDec("m31_amt", 1)

        'g10.InsertNewRow(2)
        'g10.Text("GU_NM", 2) = "매출액"
        'g10.Text("tot_amt", 2) = g10.ToDec("tot_amt", 0) - g10.ToDec("tot_amt", 1)
        'g10.Text("m01_amt", 2) = g10.ToDec("m01_amt", 0) - g10.ToDec("m01_amt", 1)
        'g10.Text("m02_amt", 2) = g10.ToDec("m02_amt", 0) - g10.ToDec("m02_amt", 1)
        'g10.Text("m03_amt", 2) = g10.ToDec("m03_amt", 0) - g10.ToDec("m03_amt", 1)
        'g10.Text("m04_amt", 2) = g10.ToDec("m04_amt", 0) - g10.ToDec("m04_amt", 1)
        'g10.Text("m05_amt", 2) = g10.ToDec("m05_amt", 0) - g10.ToDec("m05_amt", 1)
        'g10.Text("m06_amt", 2) = g10.ToDec("m06_amt", 0) - g10.ToDec("m06_amt", 1)
        'g10.Text("m07_amt", 2) = g10.ToDec("m07_amt", 0) - g10.ToDec("m07_amt", 1)
        'g10.Text("m08_amt", 2) = g10.ToDec("m08_amt", 0) - g10.ToDec("m08_amt", 1)
        'g10.Text("m09_amt", 2) = g10.ToDec("m09_amt", 0) - g10.ToDec("m09_amt", 1)
        'g10.Text("m10_amt", 2) = g10.ToDec("m10_amt", 0) - g10.ToDec("m10_amt", 1)
        'g10.Text("m11_amt", 2) = g10.ToDec("m11_amt", 0) - g10.ToDec("m11_amt", 1)
        'g10.Text("m12_amt", 2) = g10.ToDec("m12_amt", 0) - g10.ToDec("m12_amt", 1)
        'g10.Text("m13_amt", 2) = g10.ToDec("m13_amt", 0) - g10.ToDec("m13_amt", 1)
        'g10.Text("m14_amt", 2) = g10.ToDec("m14_amt", 0) - g10.ToDec("m14_amt", 1)
        'g10.Text("m15_amt", 2) = g10.ToDec("m15_amt", 0) - g10.ToDec("m15_amt", 1)
        'g10.Text("m16_amt", 2) = g10.ToDec("m16_amt", 0) - g10.ToDec("m16_amt", 1)
        'g10.Text("m17_amt", 2) = g10.ToDec("m17_amt", 0) - g10.ToDec("m17_amt", 1)
        'g10.Text("m18_amt", 2) = g10.ToDec("m18_amt", 0) - g10.ToDec("m18_amt", 1)
        'g10.Text("m19_amt", 2) = g10.ToDec("m19_amt", 0) - g10.ToDec("m19_amt", 1)
        'g10.Text("m20_amt", 2) = g10.ToDec("m20_amt", 0) - g10.ToDec("m20_amt", 1)
        'g10.Text("m21_amt", 2) = g10.ToDec("m21_amt", 0) - g10.ToDec("m21_amt", 1)
        'g10.Text("m22_amt", 2) = g10.ToDec("m22_amt", 0) - g10.ToDec("m22_amt", 1)
        'g10.Text("m23_amt", 2) = g10.ToDec("m23_amt", 0) - g10.ToDec("m23_amt", 1)
        'g10.Text("m24_amt", 2) = g10.ToDec("m24_amt", 0) - g10.ToDec("m24_amt", 1)
        'g10.Text("m25_amt", 2) = g10.ToDec("m25_amt", 0) - g10.ToDec("m25_amt", 1)
        'g10.Text("m26_amt", 2) = g10.ToDec("m26_amt", 0) - g10.ToDec("m26_amt", 1)
        'g10.Text("m27_amt", 2) = g10.ToDec("m27_amt", 0) - g10.ToDec("m27_amt", 1)
        'g10.Text("m28_amt", 2) = g10.ToDec("m28_amt", 0) - g10.ToDec("m28_amt", 1)
        'g10.Text("m29_amt", 2) = g10.ToDec("m29_amt", 0) - g10.ToDec("m29_amt", 1)
        'g10.Text("m30_amt", 2) = g10.ToDec("m30_amt", 0) - g10.ToDec("m30_amt", 1)
        'g10.Text("m31_amt", 2) = g10.ToDec("m31_amt", 0) - g10.ToDec("m31_amt", 1)

    End Sub

    Private Sub OpenGrid2()
        Dim param2 As OpenParameters = New OpenParameters
        param2.Add("@std_dt", std_dt.Text)
        Me.Open("wi_bi1012_g20", param2)

        If g20.RowCount = 1 Then
            g20.InsertNewRow(1)
            g20.Text("GU_NM", 1) = "반품액"
            g20.Text("tot_amt", 1) = 0
            g20.Text("m01_amt", 1) = 0
            g20.Text("m02_amt", 1) = 0
            g20.Text("m03_amt", 1) = 0
            g20.Text("m04_amt", 1) = 0
            g20.Text("m05_amt", 1) = 0
            g20.Text("m06_amt", 1) = 0
            g20.Text("m07_amt", 1) = 0
            g20.Text("m08_amt", 1) = 0
            g20.Text("m09_amt", 1) = 0
            g20.Text("m10_amt", 1) = 0
            g20.Text("m11_amt", 1) = 0
            g20.Text("m12_amt", 1) = 0
            g20.Text("m13_amt", 1) = 0
            g20.Text("m14_amt", 1) = 0
            g20.Text("m15_amt", 1) = 0
            g20.Text("m16_amt", 1) = 0
            g20.Text("m17_amt", 1) = 0
            g20.Text("m18_amt", 1) = 0
            g20.Text("m19_amt", 1) = 0
            g20.Text("m20_amt", 1) = 0
            g20.Text("m21_amt", 1) = 0
            g20.Text("m22_amt", 1) = 0
            g20.Text("m23_amt", 1) = 0
            g20.Text("m24_amt", 1) = 0
            g20.Text("m25_amt", 1) = 0
            g20.Text("m26_amt", 1) = 0
            g20.Text("m27_amt", 1) = 0
            g20.Text("m28_amt", 1) = 0
            g20.Text("m29_amt", 1) = 0
            g20.Text("m30_amt", 1) = 0
            g20.Text("m31_amt", 1) = 0
        End If

        '매출액(g20 해외) = 출하액 - 반품액
        g20.InsertNewRow(2)
        g20.Text("GU_NM", 2) = "매출액"
        g20.Text("tot_amt", 2) = g20.ToDec("tot_amt", 0) - g20.ToDec("tot_amt", 1)
        g20.Text("m01_amt", 2) = g20.ToDec("m01_amt", 0) - g20.ToDec("m01_amt", 1)
        g20.Text("m02_amt", 2) = g20.ToDec("m02_amt", 0) - g20.ToDec("m02_amt", 1)
        g20.Text("m03_amt", 2) = g20.ToDec("m03_amt", 0) - g20.ToDec("m03_amt", 1)
        g20.Text("m04_amt", 2) = g20.ToDec("m04_amt", 0) - g20.ToDec("m04_amt", 1)
        g20.Text("m05_amt", 2) = g20.ToDec("m05_amt", 0) - g20.ToDec("m05_amt", 1)
        g20.Text("m06_amt", 2) = g20.ToDec("m06_amt", 0) - g20.ToDec("m06_amt", 1)
        g20.Text("m07_amt", 2) = g20.ToDec("m07_amt", 0) - g20.ToDec("m07_amt", 1)
        g20.Text("m08_amt", 2) = g20.ToDec("m08_amt", 0) - g20.ToDec("m08_amt", 1)
        g20.Text("m09_amt", 2) = g20.ToDec("m09_amt", 0) - g20.ToDec("m09_amt", 1)
        g20.Text("m10_amt", 2) = g20.ToDec("m10_amt", 0) - g20.ToDec("m10_amt", 1)
        g20.Text("m11_amt", 2) = g20.ToDec("m11_amt", 0) - g20.ToDec("m11_amt", 1)
        g20.Text("m12_amt", 2) = g20.ToDec("m12_amt", 0) - g20.ToDec("m12_amt", 1)
        g20.Text("m13_amt", 2) = g20.ToDec("m13_amt", 0) - g20.ToDec("m13_amt", 1)
        g20.Text("m14_amt", 2) = g20.ToDec("m14_amt", 0) - g20.ToDec("m14_amt", 1)
        g20.Text("m15_amt", 2) = g20.ToDec("m15_amt", 0) - g20.ToDec("m15_amt", 1)
        g20.Text("m16_amt", 2) = g20.ToDec("m16_amt", 0) - g20.ToDec("m16_amt", 1)
        g20.Text("m17_amt", 2) = g20.ToDec("m17_amt", 0) - g20.ToDec("m17_amt", 1)
        g20.Text("m18_amt", 2) = g20.ToDec("m18_amt", 0) - g20.ToDec("m18_amt", 1)
        g20.Text("m19_amt", 2) = g20.ToDec("m19_amt", 0) - g20.ToDec("m19_amt", 1)
        g20.Text("m20_amt", 2) = g20.ToDec("m20_amt", 0) - g20.ToDec("m20_amt", 1)
        g20.Text("m21_amt", 2) = g20.ToDec("m21_amt", 0) - g20.ToDec("m21_amt", 1)
        g20.Text("m22_amt", 2) = g20.ToDec("m22_amt", 0) - g20.ToDec("m22_amt", 1)
        g20.Text("m23_amt", 2) = g20.ToDec("m23_amt", 0) - g20.ToDec("m23_amt", 1)
        g20.Text("m24_amt", 2) = g20.ToDec("m24_amt", 0) - g20.ToDec("m24_amt", 1)
        g20.Text("m25_amt", 2) = g20.ToDec("m25_amt", 0) - g20.ToDec("m25_amt", 1)
        g20.Text("m26_amt", 2) = g20.ToDec("m26_amt", 0) - g20.ToDec("m26_amt", 1)
        g20.Text("m27_amt", 2) = g20.ToDec("m27_amt", 0) - g20.ToDec("m27_amt", 1)
        g20.Text("m28_amt", 2) = g20.ToDec("m28_amt", 0) - g20.ToDec("m28_amt", 1)
        g20.Text("m29_amt", 2) = g20.ToDec("m29_amt", 0) - g20.ToDec("m29_amt", 1)
        g20.Text("m30_amt", 2) = g20.ToDec("m30_amt", 0) - g20.ToDec("m30_amt", 1)
        g20.Text("m31_amt", 2) = g20.ToDec("m31_amt", 0) - g20.ToDec("m31_amt", 1)

    End Sub

    Private Sub OpenChart1()   '국내 매출액의 차트 만들기 
        Try
            sbchart1()
        Catch
        End Try
    End Sub

    Private Sub OpenChart2()   '국내 매출액의 차트 만들기 
        Try
            sbchart2()
        Catch
        End Try
    End Sub


#Region " 국내 매출액 차트 만들기"      '그래프 별로 각각 그리기 

    Public Sub sbchart1()
        chart1.Series.Clear()
        Dim Col As Integer
        '출하액 꺽은선
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.Line)
        Series1.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        Series1.PointOptions.ValueNumericOptions.Precision = 0
        Series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series1.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        'Series1.Label.ResolveOverlappingMinIndent = 5
        'Series1.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        Series1.Label.Visible = False
        Series1.PointOptions.Pattern = ""

        Series1.Name = "출하액"
        chart1.Titles(0).Text = "매출현황 (국내)"
        chart1.Series.Add(Series1)
        chart1.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default

        For Row = 0 To g10.RowCount - 1
            If ToStr(g10.Text("GU_CD", Row)) = "1" Then
                Dim value As Double = 0 '
                For Col = 3 To g10.ColumnCount - 1    'title = col 몇번째부터 그래프화 하겠다.

                    'Dim value As Double = 0
                    If ToStr(g10.Text(Col, Row)) = "" Then
                        value = 0
                    Else
                        value = (g10.Text(Col, Row)) + value
                    End If

                    If value <> 0 Then
                        Dim point As New SeriesPoint(ToStr(g10.ColumnTitle(Col)), Math.Round(value, 1))
                        Series1.Points.Add(point)
                    End If

                Next
            End If
        Next

        '반품액 꺽은선
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.Line)
        Series2.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        Series2.PointOptions.ValueNumericOptions.Precision = 0
        Series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series2.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        Series2.Label.ResolveOverlappingMinIndent = 5
        Series2.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        Series2.PointOptions.Pattern = ""
        'Series2.Label.Visible = False

        Series2.Name = "반품액"
        chart1.Titles(0).Text = "매출현황 (국내)"
        chart1.Series.Add(Series2)
        chart1.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default

        For Row = 0 To g10.RowCount - 1
            If ToStr(g10.Text("GU_CD", Row)) = "2" Then
                Dim value As Double = 0
                For Col = 3 To g10.ColumnCount - 1    'title = col 몇번째부터 그래프화 하겠다.
                    If ToStr(g10.Text(Col, Row)) = "" Then
                        value = 0
                    Else
                        value = (g10.Text(Col, Row)) + value
                    End If

                    If value <> 0 Then
                        Dim point As New SeriesPoint(ToStr(g10.ColumnTitle(Col)), Math.Round(value, 1))
                        Series2.Points.Add(point)
                    End If

                Next
            End If
        Next

        '매출액 꺽은선
        Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.Line)
        Series3.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        Series3.PointOptions.ValueNumericOptions.Precision = 0
        Series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series3.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        Series3.Label.ResolveOverlappingMinIndent = 5
        Series3.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        Series3.PointOptions.Pattern = ""
        Series3.Label.Visible = False

        Series3.Name = "매출액"
        chart1.Titles(0).Text = "매출현황 (국내)"
        chart1.Series.Add(Series3)
        chart1.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default

        For Row = 0 To g10.RowCount - 1
            If ToStr(g10.Text("GU_NM", Row)) = "매출액" Then   '
                Dim value As Double = 0
                For Col = 3 To g10.ColumnCount - 1    'title = col 몇번째부터 그래프화 하겠다.
                    If ToStr(g10.Text(Col, Row)) = "" Then
                        value = 0
                    Else
                        value = (g10.Text(Col, Row)) + value
                    End If

                    If value <> 0 Then
                        Dim point As New SeriesPoint(ToStr(g10.ColumnTitle(Col)), Math.Round(value, 1))
                        Series3.Points.Add(point)
                    End If

                Next
            End If
        Next

    End Sub
#End Region

#Region " 해외 매출액 차트 만들기"      '그래프 별로 각각 그리기 
    Public Sub sbchart2()
        chart2.Series.Clear()
        Dim Col As Integer
        '출하액 꺽은선
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.Line)
        Series1.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        Series1.PointOptions.ValueNumericOptions.Precision = 0
        Series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series1.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        'Series1.Label.ResolveOverlappingMinIndent = 5
        'Series1.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        Series1.Label.Visible = False
        Series1.PointOptions.Pattern = ""

        Series1.Name = "출하액"
        chart2.Titles(0).Text = "매출현황 (해외)"
        chart2.Series.Add(Series1)
        chart2.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default

        For Row = 0 To g20.RowCount - 1
            If ToStr(g20.Text("GU_CD", Row)) = "1" Then
                Dim value As Double = 0 '
                For Col = 3 To g20.ColumnCount - 1    'title = col 몇번째부터 그래프화 하겠다.

                    'Dim value As Double = 0
                    If ToStr(g20.Text(Col, Row)) = "" Then
                        value = 0
                    Else
                        value = (g20.Text(Col, Row)) + value
                    End If

                    If value <> 0 Then
                        Dim point As New SeriesPoint(ToStr(g20.ColumnTitle(Col)), Math.Round(value, 1))
                        Series1.Points.Add(point)
                    End If

                Next
            End If
        Next

        '반품액 꺽은선
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.Line)
        Series2.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        Series2.PointOptions.ValueNumericOptions.Precision = 0
        Series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series2.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        Series2.Label.ResolveOverlappingMinIndent = 5
        Series2.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        Series2.PointOptions.Pattern = ""
        'Series2.Label.Visible = False

        Series2.Name = "반품액"
        chart2.Titles(0).Text = "매출현황 (해외)"
        chart2.Series.Add(Series2)
        chart2.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default

        For Row = 0 To g20.RowCount - 1
            If ToStr(g20.Text("GU_CD", Row)) = "2" Then
                Dim value As Double = 0
                For Col = 3 To g20.ColumnCount - 1    'title = col 몇번째부터 그래프화 하겠다.
                    If ToStr(g20.Text(Col, Row)) = "" Then
                        value = 0
                    Else
                        value = (g20.Text(Col, Row)) + value
                    End If

                    If value <> 0 Then
                        Dim point As New SeriesPoint(ToStr(g20.ColumnTitle(Col)), Math.Round(value, 1))
                        Series2.Points.Add(point)
                    End If

                Next
            End If
        Next

        '매출액 꺽은선
        Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.Line)
        Series3.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        Series3.PointOptions.ValueNumericOptions.Precision = 0
        Series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series3.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        Series3.Label.ResolveOverlappingMinIndent = 5
        Series3.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        Series3.PointOptions.Pattern = ""
        Series3.Label.Visible = False

        Series3.Name = "매출액"
        chart2.Titles(0).Text = "매출현황 (해외)"
        chart2.Series.Add(Series3)
        chart2.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default

        For Row = 0 To g20.RowCount - 1
            If ToStr(g20.Text("GU_NM", Row)) = "매출액" Then   '
                Dim value As Double = 0
                For Col = 3 To g20.ColumnCount - 1    'title = col 몇번째부터 그래프화 하겠다.
                    If ToStr(g20.Text(Col, Row)) = "" Then
                        value = 0
                    Else
                        value = (g20.Text(Col, Row)) + value
                    End If

                    If value <> 0 Then
                        Dim point As New SeriesPoint(ToStr(g20.ColumnTitle(Col)), Math.Round(value, 1))
                        Series3.Points.Add(point)
                    End If

                Next
            End If
        Next

    End Sub
#End Region


    ' 그리드에서 null인값은 보여주지 않기
    Private Sub SetColumnVisible(grid As Frame7.eGrid, Visible As Boolean)
        Dim to_dt = Convert.ToInt32(std_dt.Text.Substring(8, 2))

        If Visible = True Then
            For i = 0 To grid.ColumnCount - 1
                For j = 1 To 31
                    If grid.BandTitle(i).EndsWith(j.ToString + "일") Then   '기존에는 ColumnTitle -> bandtitle로 변경
                        grid.ColumnVisible(i) = Visible

                    End If
                Next
            Next

        Else
            For i = 0 To grid.ColumnCount - 1
                For j = to_dt + 1 To 31
                    If grid.BandTitle(i).EndsWith(j.ToString + "일") Then    '기존에는 ColumnTitle -> bandtitle로 변경
                        grid.ColumnVisible(i) = Visible
                    End If
                Next
            Next
        End If

    End Sub

    'Private Sub g10_Click(sender As System.Object, e As System.EventArgs) Handles g10.Click  '클릭했을때 하나씩 나오게끔
    '    ClickCreateChart1(g10, ChartControl1, "일")
    '    ClickCreateChart2(g10, ChartControl2, "일")
    'End Sub


    '#Region "챠트2"

    ''수율 그래프 g10
    'Private Sub LoadedGridDataDrawChart1(grid As Frame7.eGrid, ChartControl As DevExpress.XtraCharts.ChartControl, Day_Month_Unit As String, Optional MouseEvent As Boolean = False)

    '    ChartControl.Series.Clear()
    '    If isHap = False Then
    '        For RowCount = 0 To grid.RowCount - 1
    '            Dim row As DataRow = grid.DataSet.Tables(0).Rows(RowCount)
    '            If MouseEvent = False Then
    '                If row(0) = "합계" Then
    '                    Return
    '                End If
    '            End If
    '            ChartControl.Series.Add(CreateChart2Series(MakeDataTable(row, Day_Month_Unit), row, Day_Month_Unit))  '수율 그래프
    '        Next
    '    Else
    '        For RowCount = grid.RowCount - 1 To grid.RowCount - 1
    '            Dim row As DataRow = grid.DataSet.Tables(0).Rows(RowCount)

    '            ChartControl.Series.Add(CreateChart2Series(MakeDataTable(row, Day_Month_Unit), row, Day_Month_Unit))
    '        Next
    '    End If
    'End Sub

    '생산량 그래프 g10
    'Private Sub LoadedGridDataDrawChart2(grid As Frame7.eGrid, ChartControl As DevExpress.XtraCharts.ChartControl, Day_Month_Unit As String, Optional MouseEvent As Boolean = False)

    '    ChartControl.Series.Clear()
    '    If isHap = False Then
    '        For RowCount = 0 To grid.RowCount - 1
    '            Dim row As DataRow = grid.DataSet.Tables(0).Rows(RowCount)
    '            If MouseEvent = False Then
    '                If row(0) = "합계" Then
    '                    Return
    '                End If
    '            End If

    '            ChartControl.Series.Add(CreateChart2Series2(MakeDataTable2(row, Day_Month_Unit), row, Day_Month_Unit))  '생산량 그래프
    '        Next
    '    Else
    '        For RowCount = grid.RowCount - 1 To grid.RowCount - 1
    '            Dim row As DataRow = grid.DataSet.Tables(0).Rows(RowCount)

    '            ChartControl.Series.Add(CreateChart2Series2(MakeDataTable2(row, Day_Month_Unit), row, Day_Month_Unit))  '생산량 그래프
    '        Next
    '    End If
    'End Sub

    ''사출(불량현황)
    'Private Sub LoadedGridDataDrawChart4(grid As Frame7.eGrid, ChartControl As DevExpress.XtraCharts.ChartControl, Day_Month_Unit As String, Optional MouseEvent As Boolean = False)

    '    ChartControl.Series.Clear()
    '    If isHap = False Then
    '        For RowCount = 0 To grid.RowCount - 1
    '            Dim row As DataRow = grid.DataSet.Tables(0).Rows(RowCount)
    '            If MouseEvent = False Then
    '                If row(0) = "합계" Then
    '                    Return
    '                End If
    '            End If

    '            ChartControl.Series.Add(CreateChart2Series4(MakeDataTable4(row, Day_Month_Unit), row, Day_Month_Unit))  '수율 그래프
    '        Next
    '    Else
    '        'For RowCount = grid.RowCount - 1 To grid.RowCount - 1 'smk 전체 다 보여주기 
    '        For RowCount = 0 To grid.RowCount - 1
    '            Dim row As DataRow = grid.DataSet.Tables(0).Rows(RowCount)

    '            ChartControl.Series.Add(CreateChart2Series4(MakeDataTable4(row, Day_Month_Unit), row, Day_Month_Unit))
    '            'ChartControl.Series.Add(CreateChart2Series4(MakeDataTable4(row, "합계"), row, "합계"))
    '        Next
    '    End If
    'End Sub


    ''수율 
    'Private Function CreateChart2Series(table As DataTable, row As DataRow, Day_Month_Unit As String) As DevExpress.XtraCharts.Series   '수율그래프 만들기
    '    Dim PointOptions1 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
    '    Dim LineSeriesView2 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
    '    Dim PointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()

    '    CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
    '    CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()

    '    LineSeriesView2.LineMarkerOptions.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
    '    LineSeriesView2.LineMarkerOptions.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
    '    LineSeriesView2.LineMarkerOptions.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid
    '    LineSeriesView2.LineMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Hexagon
    '    LineSeriesView2.LineMarkerOptions.Size = 13

    '    PointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number '숫자시 사용
    '    PointOptions1.ValueNumericOptions.Precision = 2

    '    PointSeriesLabel1.Visible = False
    '    PointSeriesLabel1.Border.Visible = False
    '    PointSeriesLabel1.BackColor = Color.Transparent
    '    'PointOptions1.Pattern = "{S}:{V}"  ' 그래프에 값표시 [제목:값]

    '    Dim Series1 As New DevExpress.XtraCharts.Series(row(0), ViewType.Line) '꺽은선 그래프
    '    CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()

    '    Series1.DataSource = MakeDataTable(row, Day_Month_Unit) ' table
    '    Series1.ArgumentDataMember = "col_day"
    '    Series1.ValueDataMembers.AddRange(New String() {"Value"})
    '    Series1.Label = PointSeriesLabel1

    '    'Series1.PointOptions = PointOptions1
    '    If row(0) = "인터로조" Then
    '        Series1.View = LineSeriesView2
    '    End If

    '    CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
    '    CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
    '    CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()

    '    Return Series1
    'End Function

    ''생산량
    'Private Function CreateChart2Series2(table As DataTable, row As DataRow, Day_Month_Unit As String) As DevExpress.XtraCharts.Series '생산량 그래프 
    '    Dim PointOptions1 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
    '    Dim LineSeriesView2 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
    '    Dim PointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()

    '    CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
    '    CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()

    '    LineSeriesView2.LineMarkerOptions.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
    '    LineSeriesView2.LineMarkerOptions.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
    '    LineSeriesView2.LineMarkerOptions.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid
    '    LineSeriesView2.LineMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Hexagon
    '    LineSeriesView2.LineMarkerOptions.Size = 13

    '    PointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number '숫자시 사용
    '    PointOptions1.ValueNumericOptions.Precision = 2

    '    PointSeriesLabel1.Visible = False
    '    PointSeriesLabel1.Border.Visible = False
    '    PointSeriesLabel1.BackColor = Color.Transparent
    '    PointOptions1.Pattern = "{S}:{V}"  ' 그래프에 값표시 [제목:값]

    '    Dim Series1 As New DevExpress.XtraCharts.Series(row(0), ViewType.Bar)   '막대그래프
    '    CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()

    '    Series1.DataSource = MakeDataTable2(row, Day_Month_Unit) ' table
    '    Series1.ArgumentDataMember = "col_day"
    '    Series1.ValueDataMembers.AddRange(New String() {"Value"})
    '    Series1.Label = PointSeriesLabel1
    '    Series1.PointOptions = PointOptions1

    '    If row(0) = "인터로조" Then
    '        Series1.View = LineSeriesView2
    '    End If

    '    CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
    '    CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
    '    CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()

    '    Return Series1
    'End Function

    ''사출(불량현황)
    'Private Function CreateChart2Series4(table As DataTable, row As DataRow, Day_Month_Unit As String) As DevExpress.XtraCharts.Series   '수율그래프 만들기
    '    Dim PointOptions1 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
    '    Dim LineSeriesView2 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
    '    Dim PointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()

    '    CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
    '    CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()

    '    LineSeriesView2.LineMarkerOptions.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
    '    LineSeriesView2.LineMarkerOptions.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
    '    LineSeriesView2.LineMarkerOptions.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid
    '    LineSeriesView2.LineMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Hexagon
    '    LineSeriesView2.LineMarkerOptions.Size = 13

    '    PointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number '숫자시 사용
    '    PointOptions1.ValueNumericOptions.Precision = 2

    '    PointSeriesLabel1.Visible = False
    '    PointSeriesLabel1.Border.Visible = False
    '    PointSeriesLabel1.BackColor = Color.Transparent
    '    PointOptions1.Pattern = "{S}:{V}"  ' 그래프에 값표시 [제목:값]

    '    Dim Series1 As New DevExpress.XtraCharts.Series(row(0), ViewType.Line) '꺽은선 그래프
    '    CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()

    '    Series1.DataSource = MakeDataTable4(row, Day_Month_Unit) ' table
    '    Series1.ArgumentDataMember = "col_day"
    '    Series1.ValueDataMembers.AddRange(New String() {"Value"})
    '    Series1.Label = PointSeriesLabel1

    '    Series1.PointOptions = PointOptions1
    '    If row(0) = "인터로조" Then
    '        Series1.View = LineSeriesView2
    '    End If

    '    CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
    '    CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
    '    CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()

    '    Return Series1
    'End Function


    'Private Sub ClickCreateChart1(grid As eGrid, ChartControl As DevExpress.XtraCharts.ChartControl, Day_Month_Unit As String)
    '    ChartControl.Series.Clear()
    '    Dim row As DataRow = grid.DataSet.Tables(0).Rows(grid.RowIndex)
    '    ChartControl.Series.Add(CreateChart2Series(MakeDataTable(row, Day_Month_Unit), row, Day_Month_Unit))
    'End Sub

    'Private Sub ClickCreateChart2(grid As eGrid, ChartControl As DevExpress.XtraCharts.ChartControl, Day_Month_Unit As String)
    '    ChartControl.Series.Clear()
    '    Dim row As DataRow = grid.DataSet.Tables(0).Rows(grid.RowIndex)
    '    ChartControl.Series.Add(CreateChart2Series2(MakeDataTable2(row, Day_Month_Unit), row, Day_Month_Unit))
    'End Sub

    'Private Sub ClickCreateChart4(grid As eGrid, ChartControl As DevExpress.XtraCharts.ChartControl, Day_Month_Unit As String)
    '    ChartControl.Series.Clear()
    '    Dim row As DataRow = grid.DataSet.Tables(0).Rows(grid.RowIndex)
    '    ChartControl.Series.Add(CreateChart2Series4(MakeDataTable4(row, Day_Month_Unit), row, Day_Month_Unit))
    'End Sub

    ''수율g10을 위한 makedatatable, colnm 
    'Private Function MakeDataTable(row As DataRow, Day_Month_Unit As String) As DataTable
    '    Dim table As New DataTable

    '    table.Columns.Add("col_day", GetType(String))
    '    table.Columns.Add("Value", GetType(Decimal))

    '    Dim to_dt = Convert.ToInt32(std_dt.Text.Substring(8, 2))
    '    Dim to_mon = Convert.ToInt32(std_dt.Text.Substring(5, 2))

    '    If Day_Month_Unit = "일" Then
    '        For i = 1 To to_dt
    '            Dim dr As DataRow = table.NewRow()
    '            dr(0) = i.ToString + Day_Month_Unit
    '            dr(1) = ToDec(row(ColNm(i))) ' / 100 --백분율 표시때 사용
    '            table.Rows.Add(dr)
    '        Next

    '    End If

    '    Return table
    'End Function

    'Private Function ColNm(ByVal num As Integer) As String
    '    If num.ToString.Length = 1 Then
    '        Return "m0" + num.ToString + "_su"
    '    Else
    '        Return "m" + num.ToString() + "_su"
    '    End If
    'End Function

    ''생산량g10을 위한 makedatatable, colnm 
    'Private Function MakeDataTable2(row As DataRow, Day_Month_Unit As String) As DataTable
    '    Dim table As New DataTable

    '    table.Columns.Add("col_day", GetType(String))
    '    table.Columns.Add("Value", GetType(Decimal))

    '    Dim to_dt = Convert.ToInt32(std_dt.Text.Substring(8, 2))
    '    Dim to_mon = Convert.ToInt32(std_dt.Text.Substring(5, 2))

    '    If Day_Month_Unit = "일" Then
    '        For i = 1 To to_dt
    '            Dim dr As DataRow = table.NewRow()
    '            dr(0) = i.ToString + Day_Month_Unit
    '            dr(1) = ToDec(row(ColNm2(i))) ' / 100 --백분율 표시때 사용
    '            table.Rows.Add(dr)
    '        Next
    '    End If

    '    Return table
    'End Function

    'Private Function ColNm2(ByVal num As Integer) As String
    '    If num.ToString.Length = 1 Then
    '        Return "m0" + num.ToString + "_pr"
    '    Else
    '        Return "m" + num.ToString() + "_pr"
    '    End If
    'End Function

    ''사출(불량현황)
    'Private Function MakeDataTable4(row As DataRow, Day_Month_Unit As String) As DataTable
    '    Dim table As New DataTable

    '    table.Columns.Add("col_day", GetType(String))
    '    table.Columns.Add("Value", GetType(Decimal))

    '    Dim to_dt = Convert.ToInt32(std_dt.Text.Substring(8, 2))
    '    Dim to_mon = Convert.ToInt32(std_dt.Text.Substring(5, 2))


    '    If Day_Month_Unit = "일" Then
    '        For i = 1 To to_dt
    '            Dim dr As DataRow = table.NewRow()
    '            dr(0) = i.ToString + Day_Month_Unit
    '            dr(1) = ToDec(row(ColNm4(i)))               ' / 100 --백분율 표시때 사용
    '            table.Rows.Add(dr)
    '        Next
    '    End If

    '    Return table
    'End Function

    'Private Function ColNm4(ByVal num As Integer) As String
    '    If num.ToString.Length = 1 Then
    '        Return "m0" + num.ToString + "_rt"
    '    Else
    '        Return "m" + num.ToString() + "_rt"
    '    End If
    'End Function


    '여기서부터 g20 (공정별)에 관한 그래프 
    'Private Sub g10_Click(sender As System.Object, e As System.EventArgs)
    '    ClickCreateChart3(g10, chart1, "일")
    'End Sub

    'Private Function CreateChart2Series3(table As DataTable, row As DataRow, Day_Month_Unit As String) As DevExpress.XtraCharts.Series

    '    Dim PointOptions1 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
    '    Dim LineSeriesView2 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
    '    Dim PointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()

    '    CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
    '    CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()

    '    LineSeriesView2.LineMarkerOptions.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
    '    LineSeriesView2.LineMarkerOptions.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
    '    LineSeriesView2.LineMarkerOptions.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid
    '    LineSeriesView2.LineMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Hexagon
    '    LineSeriesView2.LineMarkerOptions.Size = 13

    '    PointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General '숫자시 사용
    '    PointOptions1.ValueNumericOptions.Precision = 0

    '    PointSeriesLabel1.Visible = False   '그래프에서 숫자 안보이게끔
    '    PointSeriesLabel1.Border.Visible = False
    '    PointSeriesLabel1.BackColor = Color.Transparent

    '    If IsDBNull(row(0)) Then

    '    End If

    '    Dim Series1 As New DevExpress.XtraCharts.Series(row(0), ViewType.Line)
    '    CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()

    '    Series1.DataSource = MakeDataTable3(row, Day_Month_Unit) ' table
    '    Series1.ArgumentDataMember = "col_day"
    '    Series1.ValueDataMembers.AddRange(New String() {"Value"})
    '    Series1.Label = PointSeriesLabel1

    '    Series1.PointOptions = PointOptions1
    '    If row(0) = "인터로조" Then
    '        Series1.View = LineSeriesView2
    '    End If

    '    CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
    '    CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
    '    CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()

    '    Return Series1

    'End Function

    'Private Sub ClickCreateChart3(grid As eGrid, ChartControl As DevExpress.XtraCharts.ChartControl, Day_Month_Unit As String)
    '    'ChartControl.Series.Clear()
    '    'Dim row As DataRow = grid.DataSet.Tables(0).Rows(grid.RowIndex)
    '    'If IsDBNull(row) Then   '151021 smk 누적합계때문에
    '    'Else

    '    '    ChartControl.Series.Add(CreateChart2Series3(MakeDataTable3(row, Day_Month_Unit), row, Day_Month_Unit))
    '    'End If

    'End Sub

    'Private Function MakeDataTable3(row As DataRow, Day_Month_Unit As String) As DataTable
    '    Dim table As New DataTable
    '    table.Columns.Add("col_day", GetType(String))
    '    table.Columns.Add("Value", GetType(Decimal))
    '    Dim to_dt = Convert.ToInt32(std_dt.Text.Substring(8, 2))
    '    Dim to_mon = Convert.ToInt32(std_dt.Text.Substring(5, 2))

    '    If Day_Month_Unit = "일" Then
    '        For i = 1 To to_dt
    '            Dim dr As DataRow = table.NewRow()
    '            dr(0) = i.ToString + Day_Month_Unit
    '            dr(1) = ToDec(Math.Round(row(ColNm3(i)), 1))     ' / 100 --백분율 표시때 사용
    '            table.Rows.Add(dr)
    '        Next
    '    Else
    '        For i = 1 To 12
    '            Dim dr As DataRow = table.NewRow()
    '            dr(0) = i.ToString + Day_Month_Unit
    '            dr(1) = ToDec(Math.Round(row(ColNm3(i)), 1))   ' / 100 --백분율 표시때 사용
    '            table.Rows.Add(dr)
    '        Next
    '    End If

    '    Return table
    'End Function

    'Private Function ColNm3(ByVal num As Integer) As String
    '    If num.ToString.Length = 1 Then
    '        Return "m0" + num.ToString + "_su"
    '    Else
    '        Return "m" + num.ToString() + "_su"
    '    End If
    'End Function

    '#End Region



End Class
