Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data
Imports DevExpress.XtraCharts

Public Class ESC500

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'draw_ty.Visible = False
        draw_ty.AddItem("Bar")
        'draw_ty.AddItem("1Bar")
        draw_ty.AddItem("Line")

        draw_ty.Text = "Bar"
        label_yn.Text = "1"

        chart1_ty.AddItem("년간")
        'draw_ty.AddItem("1Bar")
        chart1_ty.AddItem("분기")
        chart1_ty.AddItem("월별")

        m_ViewType = ViewType.Bar

        With g10
            'Master 부분
            .GridColumn("key1_cd").IsMasterKey = True
            .GridColumn("key1_nm").IsMasterData = True
            .GridColumn("co_nm").IsMasterData = True
            .GridColumn("div_nm").IsMasterData = True
            .GridColumn("sq_no").IsMasterData = True
            .GridColumn("ty").IsMasterData = True
            '.GridColumn("kd").IsMasterData = True
            .GridColumn("tot").IsMasterData = True
            '.GridColumn("tot").IsMasterData = True

            'Detail 부분
            .GridColumn("dkey_cd").IsDetailKey = True
            .GridColumn("dkey_val").IsDetailData = True
        End With

        'With g20
        '    'Master 부분
        '    .GridColumn("key1_cd").IsMasterKey = True
        '    .GridColumn("key1_nm").IsMasterData = True
        '    '.GridColumn("co_nm").IsMasterData = True
        '    '.GridColumn("div_nm").IsMasterData = True
        '    '.GridColumn("sq_no").IsMasterData = True
        '    .GridColumn("sal_tot").IsMasterData = True
        '    .GridColumn("bud_tot").IsMasterData = True
        '    .GridColumn("tot_remamt").IsMasterData = True

        '    'Detail 부분
        '    .GridColumn("dkey_cd").IsDetailKey = True
        '    .GridColumn("bud_amt").IsDetailData = True
        '    .GridColumn("sal_amt").IsDetailData = True
        '    .GridColumn("rem_amt").IsDetailData = True
        'End With

        'With g30
        '    'Master(부분)
        '    .GridColumn("acc_cd").IsMasterKey = True
        '    .GridColumn("acc_nm").IsMasterData = True
        '    .GridColumn("q1_bamt").IsMasterData = True
        '    .GridColumn("q1_samt").IsMasterData = True
        '    .GridColumn("q1_rem").IsMasterData = True
        '    .GridColumn("q2_bamt").IsMasterData = True
        '    .GridColumn("q2_samt").IsMasterData = True
        '    .GridColumn("q2_rem").IsMasterData = True
        '    .GridColumn("q3_bamt").IsMasterData = True
        '    .GridColumn("q3_samt").IsMasterData = True
        '    .GridColumn("q3_rem").IsMasterData = True
        '    .GridColumn("q4_bamt").IsMasterData = True
        '    .GridColumn("q4_samt").IsMasterData = True
        '    .GridColumn("q4_rem").IsMasterData = True

        'Detail 부분
        '.GridColumn("dkey_cd").IsDetailKey = True
        '.GridColumn("bud_amt").IsDetailData = True
        '.GridColumn("sal_amt").IsDetailData = True
        'End With

        'g10.SelectRow = True
        'g20.SelectRow = True

        Chart1.PaletteName = "Chameleon" '"Northern Lights"
        Chart2.PaletteName = "Chameleon"
        'Chart3.PaletteName = "Chameleon" '"Northern Lights"
        'Chart4.PaletteName = "Chameleon"

        'Dim t1 As ChartTitle
        't1 = New ChartTitle : t1.Text = "합계 항목별 점유율"
        'Chart4.Titles.Add(t1)

        't1 = New ChartTitle : t1.Text = "월별 항목별 점유율"
        'Chart5.Titles.Add(t1)


        'Dim t2 As ChartTitle = Chart5.Titles.Item(0)
        't2.Font = New Font("굴림", 15)
        't2.Text = ""
        't2.Visible = True


        Me.Init_Title()

        'Chart3.

        'Chart2.BackColor = 'RGB(255, 255, 128)

    End Sub

    Public Overrides Sub Open()

        Me.Init_Title()

        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            Me.Open("esc500_g10")
        End If

        'If XtraTabControl1.SelectedTabPageIndex = 1 Then
        '    Me.Open("esc500_g20")
        'End If

        'If XtraTabControl1.SelectedTabPageIndex = 2 Then
        '    Me.Open("esc500_g30")
        'End If

        Me.Disp_Chart1()
        Me.Disp_Chart2()

        'Me.Disp_Chart3()
        'Me.Disp_Chart4()
    End Sub

    Private Sub Init_Title()
        '1. 컬럼배열을 만든다
        Dim frDt As Date = Mid(fr_mon.Text, 1, 4) + "-01" + "-01" 'fr_mon.Text + "-01"
        Dim toDt As Date = Mid(fr_mon.Text, 1, 4) + "-12" + "-01" 'to_mon.Text + "-01"

        Dim cnt As Integer = DateDiff(DateInterval.Month, frDt, toDt)
        Dim arr(1, 0) As String, colNm As String
        For i = 0 To cnt
            colNm = Format(DateAdd(DateInterval.Month, i, frDt), "yyyy-MM")

            ReDim Preserve arr(1, i)                'Array를 증가시킨다
            arr(0, i) = colNm                       'Key     -> { 2011-01, 2011-02, 2011-03,,,,, }
            arr(1, i) = (i + 1).ToString + "월"     'Title   -> { 1월, 2월, 3월,,,, }

            Dim p As New OpenParameters
            p.Add("@co_cd", co_cd.Text)
            p.Add("@div_cd", div_cd.Text)
            p.Add("@doc_bc", doc_bc.Text)
            p.Add("@fr_mon", colNm)
            p.Add("@to_mon", colNm)

            Me.OpenDataSet("ESC500_s10", p)
        Next

        g10.InsertArrayColumns(arr)
        'g20.InsertArrayColumns(arr)
        'g10.InsertMultiColumns(arr)
        g20.InsertMultiColumns(arr)

        'Me.Open()
    End Sub


    Private Sub Disp_Chart1()
        Try
            With Chart1
                Dim param As OpenParameters = New OpenParameters
                param.Add("@co_cd", co_cd.Text)
                param.Add("@div_cd", div_cd.Text)
                param.Add("@doc_bc", doc_bc.Text)
                param.Add("@fr_mon", fr_mon.Text)
                param.Add("@to_mon", to_mon.Text)
                param.Add("@unit_bc", unit_bc.Text)


                Dim dSet1 As DataSet = Me.OpenDataSet("esc500_g30", param)

                If dSet1.Tables(0).Rows.Count > 0 Then
                    .Series.Clear()
                End If

                '.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
                'Dim s1 As DevExpress.XtraCharts.Series = Nothing
                'Dim dTable As DataTable
                'Dim cnt_srs As Integer

                'cnt_srs = 2
                'dTable = dSet1.Tables(0)

                'For s = 0 To cnt_srs - 1
                '    Dim table As New DataTable

                '    table.Columns.Add("amt", GetType(String))
                '    table.Columns.Add("Value", GetType(Decimal))

                '    For i = 0 To dTable.Rows.Count - 1
                '        If dTable.Rows(i)("seq") = s + 1 Then

                '            Dim row As DataRow = table.NewRow()
                '            If dTable.Rows(i)("bc") = "Y" Then
                '                row(0) = "년"
                '            ElseIf dTable.Rows(i)("bc") = "Q" Then
                '                row(0) = "분기"
                '            ElseIf dTable.Rows(i)("bc") = "M" Then
                '                row(0) = "월"
                '            End If

                '            If IsDBNull(dTable.Rows(i)("amt")) Then
                '                row(1) = 0
                '            Else
                '                row(1) = dTable.Rows(i)("amt")
                '            End If

                '            table.Rows.Add(row)

                '        End If
                '    Next

                '    If table.Rows.Count > 0 Then
                '        '.Series.Add("amt", ViewType.Bar)
                '        .Series(s).DataSource = table
                '        .Series(s).ArgumentDataMember = "amt"
                '        .Series(s).ValueDataMembers.AddRange(New String() {"Value"})
                '    End If
                'Next

                '.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default

                Dim s1 As DevExpress.XtraCharts.Series = Nothing
                Dim p1, p2 As SeriesPoint ', fNm As String, ttl As String


                For i = 0 To dSet1.Tables(0).Rows.Count - 1
                    If dSet1.Tables(0).Rows(i)("bc") = "Y" Then
                        If dSet1.Tables(0).Rows(i)("seq") = "1" Then
                            s1 = Base7.DXChart.NewSeries(dSet1.Tables(0).Rows(i)("acc_nm") & "지시", ViewType.Bar, label_yn.Checked)
                            .Series.Add(s1)
                        Else
                            s1 = Base7.DXChart.NewSeries(dSet1.Tables(0).Rows(i)("acc_nm") & "실적", ViewType.Line, label_yn.Checked)
                            .Series.Add(s1)
                        End If
                    Else
                        If dSet1.Tables(0).Rows(i)("seq") = "1" Then
                            s1 = Base7.DXChart.NewSeries(dSet1.Tables(0).Rows(i)("acc_nm") & "지시", ViewType.Bar, label_yn.Checked)
                            .Series.Contains(s1)
                        Else
                            s1 = Base7.DXChart.NewSeries(dSet1.Tables(0).Rows(i)("acc_nm") & "실적", ViewType.Line, label_yn.Checked)
                            .Series.Contains(s1)
                        End If
                    End If

                    If dSet1.Tables(0).Rows(i)("bc") = "Y" Then
                        If dSet1.Tables(0).Rows(i)("seq") = "1" Then
                            p1 = New SeriesPoint("년간", dSet1.Tables(0).Rows(i)("amt"))
                            s1.Points.Add(p1)
                        Else
                            p2 = New SeriesPoint("년간", dSet1.Tables(0).Rows(i)("amt"))
                            s1.Points.Add(p2)
                        End If
                    ElseIf dSet1.Tables(0).Rows(i)("bc") = "Q" Then
                        If dSet1.Tables(0).Rows(i)("seq") = "1" Then
                            p1 = New SeriesPoint("분기", dSet1.Tables(0).Rows(i)("amt"))
                            s1.Points.Add(p1)
                        Else
                            p2 = New SeriesPoint("분기", dSet1.Tables(0).Rows(i)("amt"))
                            s1.Points.Add(p2)
                        End If
                    Else
                        If dSet1.Tables(0).Rows(i)("seq") = "1" Then
                            p1 = New SeriesPoint("월간", dSet1.Tables(0).Rows(i)("amt"))
                            s1.Points.Add(p1)
                        Else
                            p2 = New SeriesPoint("월간", dSet1.Tables(0).Rows(i)("amt"))
                            s1.Points.Add(p2)
                        End If
                    End If
                Next
            End With
        Catch
            'ChartControl1.Series.Clear()
        End Try
    End Sub


    Private Sub Disp_Chart2()

        With Chart2

            If g10.RowCount > 0 Then
                .Series.Clear()
            End If

            '.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default

            Dim s1 As DevExpress.XtraCharts.Series = Nothing
            Dim p1 As SeriesPoint, fNm As String, ttl As String


            Dim colNm As String = "dkey_val"
            'If c2 And Not c1 Then colNm = "_val2"


            For i = 0 To g10.RowCount - 1

                If g10.Text("key1_cd", i) <> "000" And (g10.Text("key1_cd", i) = "5113000" Or g10.Text("key1_cd", i) = "5115000" Or g10.Text("key1_cd", i) = "5118000") Then

                    s1 = Base7.DXChart.NewSeries(g10.Text("key1_nm", i), m_ViewType, label_yn.Checked)
                    .Series.Add(s1)

                    For j = 1 To g10.ColumnCount - 1

                        fNm = g10.FieldName(j)
                        ttl = g10.ColumnTitle(fNm)
                        'MessageInfo(g10.ToDec(fNm, i))
                        'MessageInfo(fNm.Contains("&"))
                        'MessageInfo(fNm.EndsWith(colNm))
                        'If fNm.EndsWith(colNm) Then
                        'If fNm.Contains("&") AndAlso fNm.EndsWith(colNm) Then
                        If Mid(fr_mon.Text, 1, 4) + "-01" <= fNm And fNm <= Mid(fr_mon.Text, 1, 4) + "-12" Then

                            p1 = New SeriesPoint(ttl, g10.ToDec(fNm, i))
                            s1.Points.Add(p1)

                        End If
                    Next

                End If
            Next
        End With
    End Sub

    'Private Sub Disp_Chart3()
    '    With Chart3

    '        If g20.RowCount > 0 Then
    '            .Series.Clear()
    '        End If

    '        '.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default

    '        Dim s1 As DevExpress.XtraCharts.Series = Nothing
    '        Dim p1 As SeriesPoint ', fNm As String, ttl As String

    '        For i = 0 To g20.RowCount - 1
    '            If g20.Text("key1_cd", i) <> "000" Then
    '                s1 = Base7.DXChart.NewSeries(g20.Text("key1_nm", i), m_ViewType, label_yn.Checked)
    '                .Series.Add(s1)

    '                p1 = New SeriesPoint("합계", g20.ToDec("tot", i))
    '                s1.Points.Add(p1)

    '            End If
    '        Next
    '    End With
    'End Sub


    'Private Sub Disp_Chart4()

    '    With Chart4

    '        If g20.RowCount > 0 Then
    '            .Series.Clear()
    '        End If

    '        '.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default

    '        Dim s1 As DevExpress.XtraCharts.Series = Nothing
    '        Dim p1 As SeriesPoint, fNm As String, ttl As String


    '        Dim colNm As String = "sal_mon"
    '        'If c2 And Not c1 Then colNm = "_val2"


    '        For i = 0 To g20.RowCount - 1

    '            If g20.Text("key1_cd", i) <> "ZZZ" Then

    '                s1 = Base7.DXChart.NewSeries(g20.Text("key1_nm", i), m_ViewType, label_yn.Checked)
    '                .Series.Add(s1)

    '                For j = 0 To g20.ColumnCount - 1
    '                    fNm = g20.FieldName(j)
    '                    ttl = g20.BandTitle(fNm)
    '                    If fNm.Contains("&") AndAlso fNm.EndsWith(colNm) Then
    '                        'If fr_mon.Text <= fNm And fNm <= to_mon.Text Then

    '                        p1 = New SeriesPoint(ttl, g20.ToDec(fNm, i))
    '                        s1.Points.Add(p1)

    '                    End If
    '                Next

    '            End If
    '        Next
    '    End With
    'End Sub

    Private Sub XtraTabControl1_Click(sender As System.Object, e As System.EventArgs) Handles XtraTabControl1.Click
        draw_ty.Visible = (XtraTabControl1.SelectedTabPageIndex < 2)
        label_yn.Visible = (XtraTabControl1.SelectedTabPageIndex < 2)
    End Sub

    Private m_ViewType As ViewType

    Private Sub draw_ty_TextChanged(sender As Object, oldValue As String) Handles draw_ty.TextChanged

        If draw_ty.Text = "Bar" Then
            m_ViewType = ViewType.Bar
        End If
        If draw_ty.Text = "3D Bar" Then
            m_ViewType = ViewType.Bar3D
        End If
        If draw_ty.Text = "1Bar" Then
            m_ViewType = ViewType.StackedBar
        End If
        If draw_ty.Text = "Line" Then
            m_ViewType = ViewType.Line
        End If

        Me.Disp_Chart1()
        Me.Disp_Chart2()
    End Sub

    Private Sub label_yn_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles label_yn.CheckedChanged
        Me.Disp_Chart1()
        Me.Disp_Chart2()
        'Me.Disp_Chart3()
        'Me.Disp_Chart4()
    End Sub

    'Private Sub g10_AfterMoveColumn(sender As Object, PrevColumnName As String, ColumnName As String)
    '    If ColumnName >= fr_mon.Text And ColumnName <= to_mon.Text Then
    '        'Me.Disp_Chart5(ColumnName)
    '    End If
    'End Sub

    'Private Sub g10_Click(sender As Object, e As System.EventArgs) Handles g10.Click

    '    With Chart2

    '        If g10.RowCount > 0 Then
    '            .Series.Clear()
    '        End If

    '        '.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default

    '        Dim s1 As DevExpress.XtraCharts.Series = Nothing
    '        Dim p1 As SeriesPoint, fNm As String, ttl As String


    '        Dim colNm As String = "dkey_val"
    '        'If c2 And Not c1 Then colNm = "_val2"

    '        Dim i As Integer = g10.RowIndex
    '        'For i = 0 To g10.RowCount - 1

    '        If g10.Text("key1_cd", i) <> "000" Then

    '            s1 = Base7.DXChart.NewSeries(g10.Text("key1_nm", i), m_ViewType, label_yn.Checked)
    '            .Series.Add(s1)

    '            For j = 1 To g10.ColumnCount - 1

    '                fNm = g10.FieldName(j)
    '                ttl = g10.ColumnTitle(fNm)
    '                'MessageInfo(g10.ToDec(fNm, i))
    '                'MessageInfo(fNm.Contains("&"))
    '                'MessageInfo(fNm.EndsWith(colNm))
    '                'If fNm.EndsWith(colNm) Then
    '                'If fNm.Contains("&") AndAlso fNm.EndsWith(colNm) Then
    '                If fr_mon.Text <= fNm And fNm <= to_mon.Text Then

    '                    p1 = New SeriesPoint(ttl, g10.ToDec(fNm, i))
    '                    s1.Points.Add(p1)

    '                End If
    '            Next

    '        End If
    '        'Next
    '    End With
    'End Sub

End Class
