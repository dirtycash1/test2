Imports Base7
Imports Base7.Shared
Imports DevExpress.XtraCharts
Imports System.Data
Imports System.Windows.Forms
Imports System.Drawing
Imports Frame7


Public Class WI_PR1155
    Dim p As New OpenParameters
    Dim isLoad As Boolean = False
    Dim isHap As Boolean = False

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormOpen()
        isLoad = True
        isHap = False

    End Sub

    Private Sub XtraTabControl2_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl2.SelectedPageChanged
        If XtraTabControl2.SelectedTabPageIndex = "1" Then  '공정별

            SetColumnVisible(g20, True)
            Me.OpenGrid2()
            Me.OpenChart2()
            SetColumnVisible(g20, False)
        ElseIf XtraTabControl2.SelectedTabPageIndex = "2" Then  '사출(불량)

            SetColumnVisible(g30, True)
            Me.OpenGrid3()
            Me.OpenChart3()
            SetColumnVisible(g30, False)
        ElseIf XtraTabControl2.SelectedTabPageIndex = "3" Then  '분리(불량)

            SetColumnVisible(g40, True)
            Me.OpenGrid4()
            Me.OpenChart4()
            SetColumnVisible(g40, False)
        ElseIf XtraTabControl2.SelectedTabPageIndex = "4" Then  '전면(불량)

            SetColumnVisible(g50, True)
            Me.OpenGrid5()
            Me.OpenChart5()
            SetColumnVisible(g50, False)
        ElseIf XtraTabControl2.SelectedTabPageIndex = "5" Then  '규격(불량)

            SetColumnVisible(g60, True)
            Me.OpenGrid6()
            Me.OpenChart6()
            SetColumnVisible(g60, False)

        End If
    End Sub

    '################################# ToolBar Function #####################################################
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open      '조회버튼 클릭하면, 
                Me.FormOpen() '전체탭을 조회

                '시작 (이 부분 보기)
                If XtraTabControl2.SelectedTabPageIndex = "1" Then  '공정별

                    SetColumnVisible(g20, True)
                    Me.OpenGrid2()
                    Me.OpenChart2()
                    SetColumnVisible(g20, False)
                ElseIf XtraTabControl2.SelectedTabPageIndex = "2" Then  '사출(불량)

                    SetColumnVisible(g30, True)
                    Me.OpenGrid3()
                    Me.OpenChart3()
                    SetColumnVisible(g30, False)
                ElseIf XtraTabControl2.SelectedTabPageIndex = "3" Then  '분리(불량)

                    SetColumnVisible(g40, True)
                    Me.OpenGrid4()
                    Me.OpenChart4()
                    SetColumnVisible(g40, False)
                ElseIf XtraTabControl2.SelectedTabPageIndex = "4" Then  '전면(불량)

                    SetColumnVisible(g50, True)
                    Me.OpenGrid5()
                    Me.OpenChart5()
                    SetColumnVisible(g50, False)
                ElseIf XtraTabControl2.SelectedTabPageIndex = "5" Then  '규격(불량)

                    SetColumnVisible(g60, True)
                    Me.OpenGrid6()
                    Me.OpenChart6()
                    SetColumnVisible(g60, False)

                End If
                '끝
            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub


    '############################## CHART ########################################################

    Private Sub FormOpen()

        If CheckRequired(std_dt) Then

            SetColumnVisible(g10, True)   ' 값이 NULL인 경우에 보이지 않게 해주는 기능 
            Me.OpenGrid1()
            Me.OpenChart1()
            SetColumnVisible(g10, False)

        End If

        isLoad = True
        isHap = False

    End Sub
    Private Sub OpenGrid6()
        Dim param6 As OpenParameters = New OpenParameters
        param6.Add("@std_dt", std_dt.Text)
        param6.Add("@gong_cd", "80") '규격(불량)
        param6.Add("@kijong_cd", kijong_cd.Text)
        Me.Open("wi_pr1155_g60", param6)

        ' 규격(불량)(g60) - 기타
        'Dim tot_ng, m01_ng1, m02_ng1, m03_ng1, m04_ng1, m05_ng1, m06_ng1, m07_ng1, m08_ng1, m09_ng1, m10_ng1, m11_ng1, m12_ng1, m13_ng1, m14_ng1, m15_ng1 As Integer
        'Dim m16_ng1, m17_ng1, m18_ng1, m19_ng1, m20_ng1, m21_ng1, m22_ng1, m23_ng1, m24_ng1, m25_ng1, m26_ng1, m27_ng1, m28_ng1, m29_ng1, m30_ng1, m31_ng1 As Integer

        'For i = 0 To g60.RowCount - 2
        '    tot_ng = (g60.ToDec("tot_ng", i)) + tot_ng
        '    m01_ng1 = (g60.ToDec("m01_ng", i)) + m01_ng1
        '    m02_ng1 = (g60.ToDec("m02_ng", i)) + m02_ng1
        '    m03_ng1 = (g60.ToDec("m03_ng", i)) + m03_ng1
        '    m04_ng1 = (g60.ToDec("m04_ng", i)) + m04_ng1
        '    m05_ng1 = (g60.ToDec("m05_ng", i)) + m05_ng1
        '    m06_ng1 = (g60.ToDec("m06_ng", i)) + m06_ng1
        '    m07_ng1 = (g60.ToDec("m07_ng", i)) + m07_ng1
        '    m08_ng1 = (g60.ToDec("m08_ng", i)) + m08_ng1
        '    m09_ng1 = (g60.ToDec("m09_ng", i)) + m09_ng1
        '    m10_ng1 = (g60.ToDec("m10_ng", i)) + m10_ng1
        '    m11_ng1 = (g60.ToDec("m11_ng", i)) + m11_ng1
        '    m12_ng1 = (g60.ToDec("m12_ng", i)) + m12_ng1
        '    m13_ng1 = (g60.ToDec("m13_ng", i)) + m13_ng1
        '    m14_ng1 = (g60.ToDec("m14_ng", i)) + m14_ng1
        '    m15_ng1 = (g60.ToDec("m15_ng", i)) + m15_ng1
        '    m16_ng1 = (g60.ToDec("m16_ng", i)) + m16_ng1
        '    m17_ng1 = (g60.ToDec("m17_ng", i)) + m17_ng1
        '    m18_ng1 = (g60.ToDec("m18_ng", i)) + m18_ng1
        '    m19_ng1 = (g60.ToDec("m19_ng", i)) + m19_ng1
        '    m20_ng1 = (g60.ToDec("m20_ng", i)) + m20_ng1
        '    m21_ng1 = (g60.ToDec("m21_ng", i)) + m21_ng1
        '    m22_ng1 = (g60.ToDec("m22_ng", i)) + m22_ng1
        '    m23_ng1 = (g60.ToDec("m23_ng", i)) + m23_ng1
        '    m24_ng1 = (g60.ToDec("m24_ng", i)) + m24_ng1
        '    m25_ng1 = (g60.ToDec("m25_ng", i)) + m25_ng1
        '    m26_ng1 = (g60.ToDec("m26_ng", i)) + m26_ng1
        '    m27_ng1 = (g60.ToDec("m27_ng", i)) + m27_ng1
        '    m28_ng1 = (g60.ToDec("m28_ng", i)) + m28_ng1
        '    m29_ng1 = (g60.ToDec("m29_ng", i)) + m29_ng1
        '    m30_ng1 = (g60.ToDec("m30_ng", i)) + m30_ng1
        '    m31_ng1 = (g60.ToDec("m31_ng", i)) + m31_ng1
        'Next

        '' 전체 합계 - 그리드의 5개 빼면 = 기타 
        'g60.InsertNewRow(5)
        'g60.Text("ng_nm", 5) = "기타"
        'g60.Text("tot_ng", 5) = g60.ToDec("tot_ng", 6) - tot_ng
        'g60.Text("m01_ng", 5) = g60.ToDec("m01_ng", 6) - m01_ng1
        'g60.Text("m02_ng", 5) = g60.ToDec("m02_ng", 6) - m02_ng1
        'g60.Text("m03_ng", 5) = g60.ToDec("m03_ng", 6) - m03_ng1
        'g60.Text("m04_ng", 5) = g60.ToDec("m04_ng", 6) - m04_ng1
        'g60.Text("m05_ng", 5) = g60.ToDec("m05_ng", 6) - m05_ng1
        'g60.Text("m06_ng", 5) = g60.ToDec("m06_ng", 6) - m06_ng1
        'g60.Text("m07_ng", 5) = g60.ToDec("m07_ng", 6) - m07_ng1
        'g60.Text("m08_ng", 5) = g60.ToDec("m08_ng", 6) - m08_ng1
        'g60.Text("m09_ng", 5) = g60.ToDec("m09_ng", 6) - m09_ng1
        'g60.Text("m10_ng", 5) = g60.ToDec("m10_ng", 6) - m10_ng1
        'g60.Text("m11_ng", 5) = g60.ToDec("m11_ng", 6) - m11_ng1
        'g60.Text("m12_ng", 5) = g60.ToDec("m12_ng", 6) - m12_ng1
        'g60.Text("m13_ng", 5) = g60.ToDec("m13_ng", 6) - m13_ng1
        'g60.Text("m14_ng", 5) = g60.ToDec("m14_ng", 6) - m14_ng1
        'g60.Text("m15_ng", 5) = g60.ToDec("m15_ng", 6) - m15_ng1
        'g60.Text("m16_ng", 5) = g60.ToDec("m16_ng", 6) - m16_ng1
        'g60.Text("m17_ng", 5) = g60.ToDec("m17_ng", 6) - m17_ng1
        'g60.Text("m18_ng", 5) = g60.ToDec("m18_ng", 6) - m18_ng1
        'g60.Text("m19_ng", 5) = g60.ToDec("m19_ng", 6) - m19_ng1
        'g60.Text("m20_ng", 5) = g60.ToDec("m20_ng", 6) - m20_ng1
        'g60.Text("m21_ng", 5) = g60.ToDec("m21_ng", 6) - m21_ng1
        'g60.Text("m22_ng", 5) = g60.ToDec("m22_ng", 6) - m22_ng1
        'g60.Text("m23_ng", 5) = g60.ToDec("m23_ng", 6) - m23_ng1
        'g60.Text("m24_ng", 5) = g60.ToDec("m24_ng", 6) - m24_ng1
        'g60.Text("m25_ng", 5) = g60.ToDec("m25_ng", 6) - m25_ng1
        'g60.Text("m26_ng", 5) = g60.ToDec("m26_ng", 6) - m26_ng1
        'g60.Text("m27_ng", 5) = g60.ToDec("m27_ng", 6) - m27_ng1
        'g60.Text("m28_ng", 5) = g60.ToDec("m28_ng", 6) - m28_ng1
        'g60.Text("m29_ng", 5) = g60.ToDec("m29_ng", 6) - m29_ng1
        'g60.Text("m30_ng", 5) = g60.ToDec("m30_ng", 6) - m30_ng1
        'g60.Text("m31_ng", 5) = g60.ToDec("m31_ng", 6) - m31_ng1

    End Sub

    Private Sub OpenGrid5()
        Dim param5 As OpenParameters = New OpenParameters
        param5.Add("@std_dt", std_dt.Text)
        param5.Add("@gong_cd", "50") '전면검사
        param5.Add("@kijong_cd", kijong_cd.Text)
        Me.Open("wi_pr1155_g50", param5)

    End Sub

    Private Sub OpenGrid4()
        Dim param4 As OpenParameters = New OpenParameters
        param4.Add("@std_dt", std_dt.Text)
        param4.Add("@gong_cd", "20") '분리
        param4.Add("@kijong_cd", kijong_cd.Text)
        Me.Open("wi_pr1155_g40", param4)

    End Sub

    Private Sub OpenGrid3()
        Dim param3 As OpenParameters = New OpenParameters
        param3.Add("@std_dt", std_dt.Text)
        param3.Add("@gong_cd", "10") '사출
        param3.Add("@kijong_cd", kijong_cd.Text)
        Me.Open("wi_pr1155_g30", param3)
    End Sub

    Private Sub OpenGrid2()
        Dim param2 As OpenParameters = New OpenParameters
        param2.Add("@std_dt", std_dt.Text)
        param2.Add("@kijong_cd", kijong_cd.Text)
        Me.Open("wi_pr1155_g20", param2)

        '누적합계(g20공정별)
        Dim tot_su As Decimal = 1
        Dim m01_su As Decimal = 1
        Dim m02_su As Decimal = 1
        Dim m03_su As Decimal = 1
        Dim m04_su As Decimal = 1
        Dim m05_su As Decimal = 1
        Dim m06_su As Decimal = 1
        Dim m07_su As Decimal = 1
        Dim m08_su As Decimal = 1
        Dim m09_su As Decimal = 1
        Dim m10_su As Decimal = 1
        Dim m11_su As Decimal = 1
        Dim m12_su As Decimal = 1
        Dim m13_su As Decimal = 1
        Dim m14_su As Decimal = 1
        Dim m15_su As Decimal = 1
        Dim m16_su As Decimal = 1
        Dim m17_su As Decimal = 1
        Dim m18_su As Decimal = 1
        Dim m19_su As Decimal = 1
        Dim m20_su As Decimal = 1
        Dim m21_su As Decimal = 1
        Dim m22_su As Decimal = 1
        Dim m23_su As Decimal = 1
        Dim m24_su As Decimal = 1
        Dim m25_su As Decimal = 1
        Dim m26_su As Decimal = 1
        Dim m27_su As Decimal = 1
        Dim m28_su As Decimal = 1
        Dim m29_su As Decimal = 1
        Dim m30_su As Decimal = 1
        Dim m31_su As Decimal = 1

        For i = 0 To g20.RowCount - 1
            tot_su = (g20.ToDec("tot_su", i) / 100) * tot_su
            m01_su = (g20.ToDec("m01_su", i) / 100) * m01_su
            m02_su = (g20.ToDec("m02_su", i) / 100) * m02_su
            m03_su = (g20.ToDec("m03_su", i) / 100) * m03_su
            m04_su = (g20.ToDec("m04_su", i) / 100) * m04_su
            m05_su = (g20.ToDec("m05_su", i) / 100) * m05_su
            m06_su = (g20.ToDec("m06_su", i) / 100) * m06_su
            m07_su = (g20.ToDec("m07_su", i) / 100) * m07_su
            m08_su = (g20.ToDec("m08_su", i) / 100) * m08_su
            m09_su = (g20.ToDec("m09_su", i) / 100) * m09_su
            m10_su = (g20.ToDec("m10_su", i) / 100) * m10_su
            m11_su = (g20.ToDec("m11_su", i) / 100) * m11_su
            m12_su = (g20.ToDec("m12_su", i) / 100) * m12_su
            m13_su = (g20.ToDec("m13_su", i) / 100) * m13_su
            m14_su = (g20.ToDec("m14_su", i) / 100) * m14_su
            m15_su = (g20.ToDec("m15_su", i) / 100) * m15_su
            m16_su = (g20.ToDec("m16_su", i) / 100) * m16_su
            m17_su = (g20.ToDec("m17_su", i) / 100) * m17_su
            m18_su = (g20.ToDec("m18_su", i) / 100) * m18_su
            m19_su = (g20.ToDec("m19_su", i) / 100) * m19_su
            m20_su = (g20.ToDec("m20_su", i) / 100) * m20_su
            m21_su = (g20.ToDec("m21_su", i) / 100) * m21_su
            m22_su = (g20.ToDec("m22_su", i) / 100) * m22_su
            m23_su = (g20.ToDec("m23_su", i) / 100) * m23_su
            m24_su = (g20.ToDec("m24_su", i) / 100) * m24_su
            m25_su = (g20.ToDec("m25_su", i) / 100) * m25_su
            m26_su = (g20.ToDec("m26_su", i) / 100) * m26_su
            m27_su = (g20.ToDec("m27_su", i) / 100) * m27_su
            m28_su = (g20.ToDec("m28_su", i) / 100) * m28_su
            m29_su = (g20.ToDec("m29_su", i) / 100) * m29_su
            m30_su = (g20.ToDec("m30_su", i) / 100) * m30_su
            m31_su = (g20.ToDec("m31_su", i) / 100) * m31_su
        Next

        g20.AddNewRow()
        g20.Text("gong_nm", g20.RowIndex) = "누적수율"
        g20.Text("tot_su", g20.RowIndex) = tot_su * 100
        g20.Text("m01_su", g20.RowIndex) = m01_su * 100
        g20.Text("m02_su", g20.RowIndex) = m02_su * 100
        g20.Text("m03_su", g20.RowIndex) = m03_su * 100
        g20.Text("m04_su", g20.RowIndex) = m04_su * 100
        g20.Text("m05_su", g20.RowIndex) = m05_su * 100
        g20.Text("m06_su", g20.RowIndex) = m06_su * 100
        g20.Text("m07_su", g20.RowIndex) = m07_su * 100
        g20.Text("m08_su", g20.RowIndex) = m08_su * 100
        g20.Text("m09_su", g20.RowIndex) = m09_su * 100
        g20.Text("m10_su", g20.RowIndex) = m10_su * 100
        g20.Text("m11_su", g20.RowIndex) = m11_su * 100
        g20.Text("m12_su", g20.RowIndex) = m12_su * 100
        g20.Text("m13_su", g20.RowIndex) = m13_su * 100
        g20.Text("m14_su", g20.RowIndex) = m14_su * 100
        g20.Text("m15_su", g20.RowIndex) = m15_su * 100
        g20.Text("m16_su", g20.RowIndex) = m16_su * 100
        g20.Text("m17_su", g20.RowIndex) = m17_su * 100
        g20.Text("m18_su", g20.RowIndex) = m18_su * 100
        g20.Text("m19_su", g20.RowIndex) = m19_su * 100
        g20.Text("m20_su", g20.RowIndex) = m20_su * 100
        g20.Text("m21_su", g20.RowIndex) = m21_su * 100
        g20.Text("m22_su", g20.RowIndex) = m22_su * 100
        g20.Text("m23_su", g20.RowIndex) = m23_su * 100
        g20.Text("m24_su", g20.RowIndex) = m24_su * 100
        g20.Text("m25_su", g20.RowIndex) = m25_su * 100
        g20.Text("m26_su", g20.RowIndex) = m26_su * 100
        g20.Text("m27_su", g20.RowIndex) = m27_su * 100
        g20.Text("m28_su", g20.RowIndex) = m28_su * 100
        g20.Text("m29_su", g20.RowIndex) = m29_su * 100
        g20.Text("m30_su", g20.RowIndex) = m30_su * 100
        g20.Text("m31_su", g20.RowIndex) = m31_su * 100

    End Sub



    Private Sub OpenGrid1()
        Dim param As OpenParameters = New OpenParameters
        param.Add("@std_dt", std_dt.Text)
        param.Add("@kijong_cd", kijong_cd.Text)
        Me.Open("wi_pr1155_g10", param)

        'Dim param2 As OpenParameters = New OpenParameters
        'param2.Add("@std_dt", std_dt.Text)
        'Me.Open("wi_pr1155_g20", param2)

        'Dim param3 As OpenParameters = New OpenParameters
        'param3.Add("@std_dt", std_dt.Text)
        'param3.Add("@gong_cd", "10") '사출
        'Me.Open("wi_pr1155_g30", param3)

        'Dim param4 As OpenParameters = New OpenParameters
        'param4.Add("@std_dt", std_dt.Text)
        'param4.Add("@gong_cd", "20") '분리
        'Me.Open("wi_pr1155_g40", param4)

        'Dim param5 As OpenParameters = New OpenParameters
        'param5.Add("@std_dt", std_dt.Text)
        'param5.Add("@gong_cd", "50") '전면검사(불량)
        'Me.Open("wi_pr1155_g50", param5)

        'Dim param6 As OpenParameters = New OpenParameters
        'param6.Add("@std_dt", std_dt.Text)
        'param6.Add("@gong_cd", "80") '규격(불량)
        'Me.Open("wi_pr1155_g60", param6)


    End Sub


    Private Sub OpenChart1()
        Try
            LoadedGridDataDrawChart1(g10, ChartControl1, "일") '수율 (꺽은선 그래프)
            LoadedGridDataDrawChart2(g10, ChartControl2, "일")

            'isHap = True

            'sbchart()

            'LoadedGridDataDrawChart4(g30, Chart3, "일") '사출 (꺽은선 그래프)
            'LoadedGridDataDrawChart4(g40, Chart_b, "일") '분리 (꺽은선 그래프)
            'LoadedGridDataDrawChart4(g50, Chart_j, "일") '전면 (꺽은선 그래프)
            'LoadedGridDataDrawChart4(g60, Chart_g, "일") '규격 (꺽은선 그래프)

        Catch
            'ChartControl1.Series.Clear()
        End Try
    End Sub

    Private Sub OpenChart2()
        Try
            sbchart()
        Catch
        End Try
    End Sub

    Private Sub OpenChart3()
        Try
            LoadedGridDataDrawChart4(g30, Chart3, "일") '사출 (꺽은선 그래프)
        Catch
        End Try
    End Sub

    Private Sub OpenChart4()
        Try
            LoadedGridDataDrawChart4(g40, Chart_b, "일") '분리 (꺽은선 그래프)
        Catch
        End Try
    End Sub

    Private Sub OpenChart5()
        Try
            LoadedGridDataDrawChart4(g50, Chart_j, "일") '전면 (꺽은선 그래프)
        Catch
        End Try
    End Sub
    Private Sub OpenChart6()
        Try
            LoadedGridDataDrawChart4(g60, Chart_g, "일") '규격 (꺽은선 그래프)
        Catch
        End Try
    End Sub


#Region " 공정별 생산현황 CHART (g20)"
    '각그래프 별로 그리기
    Public Sub sbchart()
        chart2_2.Series.Clear()
        Dim Col As Integer
        '사출 막대그래프
        Dim Series As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.StackedBar)
        Series.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        Series.PointOptions.ValueNumericOptions.Precision = 0
        Series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        'Series.PointOptions.PointView = DevExpress.XtraCharts.PointView.Values
        Series.Label.ResolveOverlappingMinIndent = 5
        Series.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        Series.PointOptions.Pattern = ""

        Series.Name = "사출"
        chart2_2.Titles(0).Text = "공정별 생산현황"
        chart2_2.Series.Add(Series)
        chart2_2.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default

        For Row = 0 To g20.RowCount - 1
            If ToStr(g20.Text("gong_cd", Row)) = "10" Then   '사출
                For Col = 3 To g20.ColumnCount - 1    'title = col 몇번째부터 그래프화 하겠다.
                    If ToStr(g20.ColumnTitle(Col)) = "수율" Then
                        Dim value As Double = 0
                        'MsgBox("ToStr(g20.Text(Col, Row)) " & ToStr(ToStr(g20.Text(Col, Row))))   '데이터
                        'MsgBox("ToStr(g20.ColumnTitle(Col) " & ToStr(ToStr(g20.BandTitle(Col)))) '공정명 (1일, 2일,3일 아래제목)

                        If ToStr(g20.Text(Col, Row)) = "" Then
                            value = 0
                        Else
                            value = (g20.Text(Col, Row))
                        End If

                        If value <> 0 Then
                            Dim point As New SeriesPoint(ToStr(g20.BandTitle(Col)), Math.Round(value, 1))
                            Series.Points.Add(point)
                        End If
                    End If
                Next
            End If
        Next


        '분리 막대그래프
        Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.StackedBar)
        'Series3.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        'Series3.PointOptions.ValueNumericOptions.Precision = 0
        Series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series3.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        'Series3.PointOptions.PointView = DevExpress.XtraCharts.PointView.Values
        Series3.Label.ResolveOverlappingMinIndent = 5
        Series3.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        'Series3.PointOptions.Pattern = "{S}:{V}"

        Series3.Name = "분리"
        chart2_2.Titles(0).Text = "공정별 생산현황"
        chart2_2.Series.Add(Series3)
        chart2_2.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default

        For Row = 0 To g20.RowCount - 1

            If ToStr(g20.Text("gong_cd", Row)) = "20" Then   '분리
                For Col = 3 To g20.ColumnCount - 1    'title = col 몇번째부터 그래프화 하겠다.
                    If ToStr(g20.ColumnTitle(Col)) = "수율" Then

                        Dim value As Double = 0
                        If ToStr(g20.Text(Col, Row)) = "" Then
                            value = 0
                        Else
                            value = g20.Text(Col, Row)
                        End If

                        If value <> 0 Then
                            Dim point As New SeriesPoint(ToStr(g20.BandTitle(Col)), Math.Round(value, 1))
                            Series3.Points.Add(point)
                        End If
                    End If
                Next
            End If
        Next

        '전면검사 막대그래프
        Dim Series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.StackedBar)
        Series4.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        Series4.PointOptions.ValueNumericOptions.Precision = 0
        Series4.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series4.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        Series4.PointOptions.PointView = DevExpress.XtraCharts.PointView.Values
        Series4.Label.ResolveOverlappingMinIndent = 5
        Series4.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        Series4.PointOptions.Pattern = ""

        Series4.Name = "전면검사"
        chart2_2.Titles(0).Text = "공정별 생산현황"
        chart2_2.Series.Add(Series4)
        chart2_2.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default

        For Row = 0 To g20.RowCount - 1

            If ToStr(g20.Text("gong_cd", Row)) = "50" Then   '전면검사
                For Col = 3 To g20.ColumnCount - 1    'title = col 몇번째부터 그래프화 하겠다.
                    If ToStr(g20.ColumnTitle(Col)) = "수율" Then

                        Dim value As Double = 0
                        If ToStr(g20.Text(Col, Row)) = "" Then
                            value = 0
                        Else
                            value = g20.Text(Col, Row)
                        End If

                        If value <> 0 Then
                            Dim point As New SeriesPoint(ToStr(g20.BandTitle(Col)), Math.Round(value, 1))
                            Series4.Points.Add(point)
                        End If
                    End If
                Next
            End If
        Next

        '포장 / 멸균 막대그래프
        Dim Series5 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.StackedBar)
        Series5.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        Series5.PointOptions.ValueNumericOptions.Precision = 0
        Series5.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series5.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        Series5.PointOptions.PointView = DevExpress.XtraCharts.PointView.Values
        Series5.Label.ResolveOverlappingMinIndent = 5
        Series5.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        Series5.PointOptions.Pattern = ""

        Series5.Name = "포장/멸균"
        chart2_2.Titles(0).Text = "공정별 생산현황"
        chart2_2.Series.Add(Series5)
        chart2_2.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default

        For Row = 0 To g20.RowCount - 1

            If ToStr(g20.Text("gong_cd", Row)) = "55" Then   '전면검사
                For Col = 3 To g20.ColumnCount - 1    'title = col 몇번째부터 그래프화 하겠다.
                    If ToStr(g20.ColumnTitle(Col)) = "수율" Then

                        Dim value As Double = 0
                        If ToStr(g20.Text(Col, Row)) = "" Then
                            value = 0
                        Else
                            value = g20.Text(Col, Row)
                        End If

                        If value <> 0 Then
                            Dim point As New SeriesPoint(ToStr(g20.BandTitle(Col)), Math.Round(value, 1))
                            Series5.Points.Add(point)
                        End If
                    End If
                Next
            End If
        Next

        '누수검사 막대그래프
        Dim Series6 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.StackedBar)
        Series6.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        Series6.PointOptions.ValueNumericOptions.Precision = 0
        Series6.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series6.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        Series6.PointOptions.PointView = DevExpress.XtraCharts.PointView.Values
        Series6.Label.ResolveOverlappingMinIndent = 5
        Series6.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        Series6.PointOptions.Pattern = ""

        Series6.Name = "누수검사"
        chart2_2.Titles(0).Text = "공정별 생산현황"
        chart2_2.Series.Add(Series6)
        chart2_2.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default

        For Row = 0 To g20.RowCount - 1

            If ToStr(g20.Text("gong_cd", Row)) = "70" Then   '누수검사
                For Col = 3 To g20.ColumnCount - 1    'title = col 몇번째부터 그래프화 하겠다.
                    If ToStr(g20.ColumnTitle(Col)) = "수율" Then

                        Dim value As Double = 0
                        If ToStr(g20.Text(Col, Row)) = "" Then
                            value = 0
                        Else
                            value = g20.Text(Col, Row)
                        End If

                        If value <> 0 Then
                            Dim point As New SeriesPoint(ToStr(g20.BandTitle(Col)), Math.Round(value, 1))
                            Series6.Points.Add(point)
                        End If
                    End If
                Next
            End If
        Next

        '규격검사 막대그래프
        Dim Series7 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.StackedBar)
        Series7.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        Series7.PointOptions.ValueNumericOptions.Precision = 0
        Series7.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series7.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        Series7.PointOptions.PointView = DevExpress.XtraCharts.PointView.Values
        Series7.Label.ResolveOverlappingMinIndent = 5
        Series7.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        Series7.PointOptions.Pattern = ""

        Series7.Name = "규격검사"
        chart2_2.Titles(0).Text = "공정별 생산현황"
        chart2_2.Series.Add(Series7)
        chart2_2.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default

        For Row = 0 To g20.RowCount - 1

            If ToStr(g20.Text("gong_cd", Row)) = "80" Then   '규격검사
                For Col = 3 To g20.ColumnCount - 1    'title = col 몇번째부터 그래프화 하겠다.
                    If ToStr(g20.ColumnTitle(Col)) = "수율" Then

                        Dim value As Double = 0
                        If ToStr(g20.Text(Col, Row)) = "" Then
                            value = 0
                        Else
                            value = g20.Text(Col, Row)
                        End If

                        If value <> 0 Then
                            Dim point As New SeriesPoint(ToStr(g20.BandTitle(Col)), Math.Round(value, 1))
                            Series7.Points.Add(point)
                        End If
                    End If
                Next
            End If
        Next

        '합계
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.Line) '수율의 총합계는 꺽은선그래프
        Series2.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        Series2.PointOptions.ValueNumericOptions.Precision = 0
        Series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series2.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        Series2.PointOptions.PointView = DevExpress.XtraCharts.PointView.Values
        Series2.Label.ResolveOverlappingMinIndent = 5
        Series2.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        Series2.PointOptions.Pattern = ""

        Series2.Name = "누적수율"

        chart2_2.Series.Add(Series2)
        chart2_2.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default

        For Row = 0 To g20.RowCount - 1

            If ToStr(g20.Text("gong_nm", Row)) = "누적수율" Then   '사출
                For Col = 3 To g20.ColumnCount - 1

                    If ToStr(g20.ColumnTitle(Col)) = "수율" Then '수율 데이터만 그래프화
                        Dim value As Double = 0
                        If ToStr(g20.Text(Col, Row)) = "" Then
                            value = 0
                        Else
                            value = g20.Text(Col, Row)
                        End If

                        If value <> 0 Then   '데이터가 null인 일자는 보여주지 않기.
                            Dim point As New SeriesPoint(ToStr(g20.BandTitle(Col)), Math.Round(value, 1))
                            Series2.Points.Add(point)
                        End If

                    End If
                Next
            End If
        Next

    End Sub
#End Region

    'g10 (전체) 제품군별 수율, 생산량 
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


    Private Sub SetColumnVisible(grid As Frame7.eGrid, Visible As Boolean)   ' 그리드에서 null인값은 보여주지 않기
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
                If Today = std_dt.Text Then  '오늘날짜 = std_dt 같으면, 
                    For j = to_dt To 31      '그리드에서 전날까지만 보여주기. smk
                        If grid.BandTitle(i).EndsWith(j.ToString + "일") Then    '기존에는 ColumnTitle -> bandtitle로 변경
                            grid.ColumnVisible(i) = Visible
                        End If
                    Next

                Else
                    For j = to_dt + 1 To 31
                        If grid.BandTitle(i).EndsWith(j.ToString + "일") Then    '기존에는 ColumnTitle -> bandtitle로 변경
                            grid.ColumnVisible(i) = Visible
                        End If
                    Next
                End If
                
            Next
        End If

    End Sub

    Private Sub g10_Click(sender As System.Object, e As System.EventArgs) Handles g10.Click  '클릭했을때 하나씩 나오게끔
        ClickCreateChart1(g10, ChartControl1, "일")
        ClickCreateChart2(g10, ChartControl2, "일")
    End Sub

    Private Sub g30_Click(sender As System.Object, e As System.EventArgs) Handles g30.Click  '클릭했을때 하나씩 나오게끔
        ClickCreateChart4(g30, Chart3, "일")
    End Sub

    Private Sub g40_Click(sender As System.Object, e As System.EventArgs) Handles g40.Click  '클릭했을때 하나씩 나오게끔
        ClickCreateChart4(g40, Chart_b, "일")
    End Sub

    Private Sub g50_Click(sender As System.Object, e As System.EventArgs) Handles g50.Click  '클릭했을때 하나씩 나오게끔
        ClickCreateChart4(g50, Chart_j, "일")
    End Sub

    Private Sub g60_Click(sender As System.Object, e As System.EventArgs) Handles g60.Click  '클릭했을때 하나씩 나오게끔
        ClickCreateChart4(g60, Chart_g, "일")
    End Sub


#Region "챠트2"

    '수율 그래프 g10
    Private Sub LoadedGridDataDrawChart1(grid As Frame7.eGrid, ChartControl As DevExpress.XtraCharts.ChartControl, Day_Month_Unit As String, Optional MouseEvent As Boolean = False)

        ChartControl.Series.Clear()
        If isHap = False Then
            For RowCount = 0 To grid.RowCount - 1
                Dim row As DataRow = grid.DataSet.Tables(0).Rows(RowCount)
                If MouseEvent = False Then
                    If row(0) = "합계" Then
                        Return
                    End If
                End If
                ChartControl.Series.Add(CreateChart2Series(MakeDataTable(row, Day_Month_Unit), row, Day_Month_Unit))  '수율 그래프
            Next
        Else
            For RowCount = grid.RowCount - 1 To grid.RowCount - 1
                Dim row As DataRow = grid.DataSet.Tables(0).Rows(RowCount)

                ChartControl.Series.Add(CreateChart2Series(MakeDataTable(row, Day_Month_Unit), row, Day_Month_Unit))
            Next
        End If
    End Sub

    '생산량 그래프 g10
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

                ChartControl.Series.Add(CreateChart2Series2(MakeDataTable2(row, Day_Month_Unit), row, Day_Month_Unit))  '생산량 그래프
            Next
        Else
            For RowCount = grid.RowCount - 1 To grid.RowCount - 1
                Dim row As DataRow = grid.DataSet.Tables(0).Rows(RowCount)

                ChartControl.Series.Add(CreateChart2Series2(MakeDataTable2(row, Day_Month_Unit), row, Day_Month_Unit))  '생산량 그래프
            Next
        End If
    End Sub

    '사출(불량현황)
    Private Sub LoadedGridDataDrawChart4(grid As Frame7.eGrid, ChartControl As DevExpress.XtraCharts.ChartControl, Day_Month_Unit As String, Optional MouseEvent As Boolean = False)

        ChartControl.Series.Clear()
        If isHap = False Then
            For RowCount = 0 To grid.RowCount - 1
                Dim row As DataRow = grid.DataSet.Tables(0).Rows(RowCount)
                If MouseEvent = False Then
                    If row(0) = "합계" Then
                        Return
                    End If
                End If

                ChartControl.Series.Add(CreateChart2Series4(MakeDataTable4(row, Day_Month_Unit), row, Day_Month_Unit))  '수율 그래프
            Next
        Else
            'For RowCount = grid.RowCount - 1 To grid.RowCount - 1 'smk 전체 다 보여주기 
            For RowCount = 0 To grid.RowCount - 1
                Dim row As DataRow = grid.DataSet.Tables(0).Rows(RowCount)

                ChartControl.Series.Add(CreateChart2Series4(MakeDataTable4(row, Day_Month_Unit), row, Day_Month_Unit))
                'ChartControl.Series.Add(CreateChart2Series4(MakeDataTable4(row, "합계"), row, "합계"))
            Next
        End If
    End Sub


    '수율 
    Private Function CreateChart2Series(table As DataTable, row As DataRow, Day_Month_Unit As String) As DevExpress.XtraCharts.Series   '수율그래프 만들기
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
        PointOptions1.ValueNumericOptions.Precision = 2

        PointSeriesLabel1.Visible = False
        PointSeriesLabel1.Border.Visible = False
        PointSeriesLabel1.BackColor = Color.Transparent
        'PointOptions1.Pattern = "{S}:{V}"  ' 그래프에 값표시 [제목:값]

        Dim Series1 As New DevExpress.XtraCharts.Series(row(0), ViewType.Line) '꺽은선 그래프
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()

        Series1.DataSource = MakeDataTable(row, Day_Month_Unit) ' table
        Series1.ArgumentDataMember = "col_day"
        Series1.ValueDataMembers.AddRange(New String() {"Value"})
        Series1.Label = PointSeriesLabel1

        'Series1.PointOptions = PointOptions1
        If row(0) = "인터로조" Then
            Series1.View = LineSeriesView2
        End If

        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()

        Return Series1
    End Function

    '생산량
    Private Function CreateChart2Series2(table As DataTable, row As DataRow, Day_Month_Unit As String) As DevExpress.XtraCharts.Series '생산량 그래프 
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
        PointOptions1.ValueNumericOptions.Precision = 2

        PointSeriesLabel1.Visible = False
        PointSeriesLabel1.Border.Visible = False
        PointSeriesLabel1.BackColor = Color.Transparent
        PointOptions1.Pattern = "{S}:{V}"  ' 그래프에 값표시 [제목:값]

        Dim Series1 As New DevExpress.XtraCharts.Series(row(0), ViewType.Bar)   '막대그래프
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

    '사출(불량현황)
    Private Function CreateChart2Series4(table As DataTable, row As DataRow, Day_Month_Unit As String) As DevExpress.XtraCharts.Series   '수율그래프 만들기
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
        PointOptions1.ValueNumericOptions.Precision = 2

        PointSeriesLabel1.Visible = False
        PointSeriesLabel1.Border.Visible = False
        PointSeriesLabel1.BackColor = Color.Transparent
        PointOptions1.Pattern = "{S}:{V}"  ' 그래프에 값표시 [제목:값]

        Dim Series1 As New DevExpress.XtraCharts.Series(row(0), ViewType.Line) '꺽은선 그래프
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()

        Series1.DataSource = MakeDataTable4(row, Day_Month_Unit) ' table
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


    Private Sub ClickCreateChart1(grid As eGrid, ChartControl As DevExpress.XtraCharts.ChartControl, Day_Month_Unit As String)
        ChartControl.Series.Clear()
        Dim row As DataRow = grid.DataSet.Tables(0).Rows(grid.RowIndex)
        ChartControl.Series.Add(CreateChart2Series(MakeDataTable(row, Day_Month_Unit), row, Day_Month_Unit))
    End Sub

    Private Sub ClickCreateChart2(grid As eGrid, ChartControl As DevExpress.XtraCharts.ChartControl, Day_Month_Unit As String)
        ChartControl.Series.Clear()
        Dim row As DataRow = grid.DataSet.Tables(0).Rows(grid.RowIndex)
        ChartControl.Series.Add(CreateChart2Series2(MakeDataTable2(row, Day_Month_Unit), row, Day_Month_Unit))
    End Sub

    Private Sub ClickCreateChart4(grid As eGrid, ChartControl As DevExpress.XtraCharts.ChartControl, Day_Month_Unit As String)
        ChartControl.Series.Clear()
        Dim row As DataRow = grid.DataSet.Tables(0).Rows(grid.RowIndex)
        ChartControl.Series.Add(CreateChart2Series4(MakeDataTable4(row, Day_Month_Unit), row, Day_Month_Unit))
    End Sub

    '수율g10을 위한 makedatatable, colnm 
    Private Function MakeDataTable(row As DataRow, Day_Month_Unit As String) As DataTable
        Dim table As New DataTable

        table.Columns.Add("col_day", GetType(String))
        table.Columns.Add("Value", GetType(Decimal))

        Dim to_dt = Convert.ToInt32(std_dt.Text.Substring(8, 2))
        Dim to_mon = Convert.ToInt32(std_dt.Text.Substring(5, 2))

        'MsgBox(ToStr(Today))

        If Day_Month_Unit = "일" Then

            If Today = std_dt.Text Then    '오늘날짜 = 기준일자 이면, 
                For i = 1 To to_dt - 1      '그전날꺼만 나타내기
                    Dim dr As DataRow = table.NewRow()
                    dr(0) = i.ToString + Day_Month_Unit
                    dr(1) = ToDec(row(ColNm(i))) ' / 100 --백분율 표시때 사용
                    table.Rows.Add(dr)
                Next
            Else
                For i = 1 To to_dt
                    Dim dr As DataRow = table.NewRow()
                    dr(0) = i.ToString + Day_Month_Unit
                    dr(1) = ToDec(row(ColNm(i))) ' / 100 --백분율 표시때 사용
                    table.Rows.Add(dr)
                Next
            End If
        End If

            Return table
    End Function

    Private Function ColNm(ByVal num As Integer) As String
        If num.ToString.Length = 1 Then
            Return "m0" + num.ToString + "_su"
        Else
            Return "m" + num.ToString() + "_su"
        End If
    End Function

    '생산량g10을 위한 makedatatable, colnm 
    Private Function MakeDataTable2(row As DataRow, Day_Month_Unit As String) As DataTable
        Dim table As New DataTable

        table.Columns.Add("col_day", GetType(String))
        table.Columns.Add("Value", GetType(Decimal))

        Dim to_dt = Convert.ToInt32(std_dt.Text.Substring(8, 2))
        Dim to_mon = Convert.ToInt32(std_dt.Text.Substring(5, 2))

        If Day_Month_Unit = "일" Then
            If Today = std_dt.Text Then    '오늘날짜 = 기준일자 이면, 
                For i = 1 To to_dt - 1      '그전날꺼만 나타내기
                    Dim dr As DataRow = table.NewRow()
                    dr(0) = i.ToString + Day_Month_Unit
                    dr(1) = ToDec(row(ColNm2(i))) ' / 100 --백분율 표시때 사용
                    table.Rows.Add(dr)
                Next
            Else
                For i = 1 To to_dt
                    Dim dr As DataRow = table.NewRow()
                    dr(0) = i.ToString + Day_Month_Unit
                    dr(1) = ToDec(row(ColNm2(i))) ' / 100 --백분율 표시때 사용
                    table.Rows.Add(dr)
                Next
            End If
            
        End If

        Return table
    End Function

    Private Function ColNm2(ByVal num As Integer) As String
        If num.ToString.Length = 1 Then
            Return "m0" + num.ToString + "_pr"
        Else
            Return "m" + num.ToString() + "_pr"
        End If
    End Function

    '사출(불량현황)
    Private Function MakeDataTable4(row As DataRow, Day_Month_Unit As String) As DataTable
        Dim table As New DataTable

        table.Columns.Add("col_day", GetType(String))
        table.Columns.Add("Value", GetType(Decimal))

        Dim to_dt = Convert.ToInt32(std_dt.Text.Substring(8, 2))
        Dim to_mon = Convert.ToInt32(std_dt.Text.Substring(5, 2))


        If Day_Month_Unit = "일" Then
            For i = 1 To to_dt
                Dim dr As DataRow = table.NewRow()
                dr(0) = i.ToString + Day_Month_Unit
                dr(1) = ToDec(row(ColNm4(i)))               ' / 100 --백분율 표시때 사용
                table.Rows.Add(dr)
            Next
        End If

        Return table
    End Function

    Private Function ColNm4(ByVal num As Integer) As String
        If num.ToString.Length = 1 Then
            Return "m0" + num.ToString + "_rt"
        Else
            Return "m" + num.ToString() + "_rt"
        End If
    End Function


    '여기서부터 g20 (공정별)에 관한 그래프 
    Private Sub g20_Click(sender As System.Object, e As System.EventArgs) Handles g20.Click
        ClickCreateChart3(g20, chart2_2, "일")
    End Sub

    Private Function CreateChart2Series3(table As DataTable, row As DataRow, Day_Month_Unit As String) As DevExpress.XtraCharts.Series

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

        PointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General '숫자시 사용
        PointOptions1.ValueNumericOptions.Precision = 0

        PointSeriesLabel1.Visible = False   '그래프에서 숫자 안보이게끔
        PointSeriesLabel1.Border.Visible = False
        PointSeriesLabel1.BackColor = Color.Transparent

        If IsDBNull(row(0)) Then

        End If

        Dim Series1 As New DevExpress.XtraCharts.Series(row(0), ViewType.Line)
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

    Private Sub ClickCreateChart3(grid As eGrid, ChartControl As DevExpress.XtraCharts.ChartControl, Day_Month_Unit As String)
        'ChartControl.Series.Clear()
        'Dim row As DataRow = grid.DataSet.Tables(0).Rows(grid.RowIndex)
        'If IsDBNull(row) Then   '151021 smk 누적합계때문에
        'Else

        '    ChartControl.Series.Add(CreateChart2Series3(MakeDataTable3(row, Day_Month_Unit), row, Day_Month_Unit))
        'End If

    End Sub

    Private Function MakeDataTable3(row As DataRow, Day_Month_Unit As String) As DataTable
        Dim table As New DataTable
        table.Columns.Add("col_day", GetType(String))
        table.Columns.Add("Value", GetType(Decimal))
        Dim to_dt = Convert.ToInt32(std_dt.Text.Substring(8, 2))
        Dim to_mon = Convert.ToInt32(std_dt.Text.Substring(5, 2))

        If Day_Month_Unit = "일" Then
            For i = 1 To to_dt
                Dim dr As DataRow = table.NewRow()
                dr(0) = i.ToString + Day_Month_Unit
                dr(1) = ToDec(Math.Round(row(ColNm3(i)), 1))     ' / 100 --백분율 표시때 사용
                table.Rows.Add(dr)
            Next
        Else
            For i = 1 To 12
                Dim dr As DataRow = table.NewRow()
                dr(0) = i.ToString + Day_Month_Unit
                dr(1) = ToDec(Math.Round(row(ColNm3(i)), 1))   ' / 100 --백분율 표시때 사용
                table.Rows.Add(dr)
            Next
        End If

        Return table
    End Function

    Private Function ColNm3(ByVal num As Integer) As String
        If num.ToString.Length = 1 Then
            Return "m0" + num.ToString + "_su"
        Else
            Return "m" + num.ToString() + "_su"
        End If
    End Function

#End Region




End Class
