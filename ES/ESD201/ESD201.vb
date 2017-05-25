Imports Frame7
Imports Base7
Imports Base7.Shared
Imports DevExpress.XtraCharts

Public Class ESD201

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        g10.SelectRow = True
        g20.SelectRow = True

        Select Case open_ty.DefaultText
            Case "", "1"
                r1.Checked = True
                open_ty.Text = "1"
            Case "2"
                r2.Checked = True
        End Select
        Me.Init_Title()
        Me.Disp_Data()
        sbchart()

        Me.Init_Title1()
        Me.Disp_Data1()
        sbchart1()

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty
            Case MenuType.Open
                Me.Init_Title()
                Me.Disp_Data()
                sbchart()

                Me.Init_Title1()
                Me.Disp_Data1()
                sbchart1()

            Case MenuType.Save

                'Me.save_Form()
                'Case MenuType.New

            Case MenuType.New

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub


#Region " 1. Grid 컬럼 초기화 "

    'Case 1. DataSet을 이용한 Title 배열
    Private Sub Init_Title()

        '1. 컬럼배열을 만든다
        Dim P As New OpenParameters
        P.Add("@std_mon", std_mon.Text)
        g10.ColumnVisible("ty") = (open_ty.Text = "1")

        Dim dSet As DataSet = Me.OpenDataSet("ESD201_Title", P)
        If IsEmpty(dSet) Then
            MessageInfo("조회 할 Data가 없습니다")
            'g10.Init()
            Exit Sub
        End If

        Dim arr(1, 0) As String, inx As Integer = 0
        For Each dRow In dSet.Tables(0).Rows
            ReDim Preserve arr(1, inx)      'Array를 증가시킨다

            arr(0, inx) = dRow(0)           'FieldName 으로 사용된다
            arr(1, inx) = dRow(1)           'Title로 사용된다

            inx += 1
        Next


        g10.InsertArrayColumns(Nothing, arr, "amt")

    End Sub

    Private Sub Init_Title1()

        '1. 컬럼배열을 만든다
        Dim P As New OpenParameters
        P.Add("@std_mon", std_mon.Text)
        g20.ColumnVisible("ty") = (open_ty.Text = "1")
        Dim dSet As DataSet = Me.OpenDataSet("ESD201_Title", P)
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


        g20.InsertArrayColumns(Nothing, arr, "tot")

    End Sub
#End Region

#Region " 2. Display "

    '첫번째 Display 방법: 기본기능을 이용
    Private Sub Disp_Data()
        Try
            'grp_nm = z.title, model_nm, sq, ty, std_mon, amt, tot, val = 0.0  
            'fac_cd, grp_nm ,sq, ty, std_mon, week_sq, amt, tot, Val() = 0.0
            g10.GridColumn("fac_nm").IsMasterKey = True
            g10.GridColumn("grp_nm").IsMasterKey = True
            g10.GridColumn("sq").IsMasterKey = True
            g10.GridColumn("ty").IsMasterKey = True
            g10.GridColumn("std_mon").IsDetailKey = True
            g10.GridColumn("tot").IsMasterData = True

            'Detail 부분
            g10.GridColumn("week_sq").IsDetailKey = True
            g10.GridColumn("amt").IsDetailData = True

            MyBase.Open("esd201_g10")

        Catch ex As Exception

            MessageInfo(ex, "Disp_Data()")

        End Try
    End Sub

    Private Sub Disp_Data1()
        Try
            'grp_nm = z.title, model_nm, sq, ty, std_mon, amt, tot, val = 0.0  
            'fac_cd, grp_nm ,sq, ty, std_mon, week_sq, amt, tot, Val() = 0.0
            g20.GridColumn("fac_nm").IsMasterKey = True
            g20.GridColumn("grp_nm").IsMasterKey = True
            g20.GridColumn("sq").IsMasterKey = True
            g20.GridColumn("ty").IsMasterKey = True
            g20.GridColumn("std_mon").IsDetailKey = True
            g20.GridColumn("tot").IsMasterData = True

            'Detail 부분
            g20.GridColumn("week_sq").IsDetailKey = True
            g20.GridColumn("amt").IsDetailData = True

            MyBase.Open("esd201_g20")

        Catch ex As Exception

            MessageInfo(ex, "Disp_Data1()")

        End Try
    End Sub

#End Region

#Region " 2. char "
    Public Sub sbchart()
        Chart1.Series.Clear()
        Dim Col As Integer
        If r1.Checked Then
            Dim Series As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.Bar)
            Series.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
            Series.PointOptions.ValueNumericOptions.Precision = 0
            Series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
            Series.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
            Series.PointOptions.PointView = DevExpress.XtraCharts.PointView.Values
            Series.Label.ResolveOverlappingMinIndent = 5
            Series.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
            Series.Name = "계획"
            Chart1.Titles(0).Text = "총계"
            Chart1.Series.Add(Series)
            Chart1.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
            For Row = 0 To g10.RowCount - 1
                If ToStr(g10.Text("grp_nm", Row)) = "총계" And ToStr(g10.Text("ty", Row)) = "계획" Then
                    For Col = 8 To g10.ColumnCount - 1
                        Dim value As Double = 0
                        If ToStr(g10.Text(Col, Row)) = "" Then
                            value = 0
                        Else
                            value = g10.Text(Col, Row)
                        End If
                        Dim point As New SeriesPoint(ToStr(g10.ColumnTitle(Col)), value)
                        Series.Points.Add(point)
                    Next
                End If
            Next
        End If


        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.Bar)
        Series1.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        Series1.PointOptions.ValueNumericOptions.Precision = 0
        Series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series1.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        Series1.PointOptions.PointView = DevExpress.XtraCharts.PointView.Values
        Series1.Label.ResolveOverlappingMinIndent = 5
        Series1.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        Series1.Name = "실적"
        Chart1.Series.Add(Series1)
        Chart1.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        For Row = 0 To g10.RowCount - 1
            If ToStr(g10.Text("grp_nm", Row)) = "총계" And ToStr(g10.Text("ty", Row)) = "실적" Then
                For Col = 8 To g10.ColumnCount - 1
                    Dim value As Double = 0
                    If ToStr(g10.Text(Col, Row)) = "" Then
                        value = 0
                    Else
                        value = g10.Text(Col, Row)
                    End If
                    Dim point As New SeriesPoint(ToStr(g10.ColumnTitle(Col)), value)
                    Series1.Points.Add(point)
                Next
            End If
        Next
    End Sub

    Public Sub sbchart1()
        Chart3.Series.Clear()
        Dim Col As Integer
        If r1.Checked Then
            Dim Series As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.Bar)
            Series.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
            Series.PointOptions.ValueNumericOptions.Precision = 0
            Series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
            Series.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
            Series.PointOptions.PointView = DevExpress.XtraCharts.PointView.Values
            Series.Label.ResolveOverlappingMinIndent = 5
            Series.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
            Series.Name = "계획"
            Chart3.Titles(0).Text = "총계"
            Chart3.Series.Add(Series)
            Chart3.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
            For Row = 0 To g20.RowCount - 1
                If ToStr(g20.Text("grp_nm", Row)) = "총계" And ToStr(g20.Text("ty", Row)) = "계획" Then
                    For Col = 8 To g20.ColumnCount - 1
                        Dim value As Double = 0
                        If ToStr(g20.Text(Col, Row)) = "" Then
                            value = 0
                        Else
                            value = g20.Text(Col, Row)
                        End If
                        Dim point As New SeriesPoint(ToStr(g20.ColumnTitle(Col)), value)
                        Series.Points.Add(point)
                    Next
                End If
            Next
        End If

        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.Bar)
        Series1.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        Series1.PointOptions.ValueNumericOptions.Precision = 0
        Series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series1.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        Series1.PointOptions.PointView = DevExpress.XtraCharts.PointView.Values
        Series1.Label.ResolveOverlappingMinIndent = 5
        Series1.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        Series1.Name = "실적"
        Chart3.Series.Add(Series1)
        Chart3.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        For Row = 0 To g20.RowCount - 1
            If ToStr(g20.Text("grp_nm", Row)) = "총계" And ToStr(g20.Text("ty", Row)) = "실적" Then
                For Col = 8 To g20.ColumnCount - 1
                    Dim value As Double = 0
                    If ToStr(g20.Text(Col, Row)) = "" Then
                        value = 0
                    Else
                        value = g20.Text(Col, Row)
                    End If
                    Dim point As New SeriesPoint(ToStr(g20.ColumnTitle(Col)), value)
                    Series1.Points.Add(point)
                Next
            End If
        Next
    End Sub
#End Region
    Private Sub FindColumn()
        Dim finder(1) As String
        finder(0) = "fac_nm=" + g10.Text("fac_nm")
        finder(1) = "grp_nm=소계"
        'finder(2) = "ty=실적"

        g10.Find(finder)    '여러가지 조건으로 행을 찾을 수 있다
    End Sub

    Private Sub g10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.Click
        If g10.RowCount = 0 Then Exit Sub

        If XtraTabControl1.SelectedTabPageIndex = 0 Then Exit Sub
        'MsgBox(g10.FocusedFieldName)
        If ToStr(g10.Text("grp_nm")) <> "총계" And g10.FocusedFieldName = "fac_nm" Then FindColumn()

        Dim ModelNm As String = ""

        Dim Row As Integer = 0
        Dim Row1 As Integer = 0
        Dim Col As Integer
        Chart2.Series.Clear()

        If r1.Checked Then
            If ToStr(g10.Text("ty")) = "계획" Then
                Row = g10.RowIndex
                Row1 = g10.RowIndex + 1
            ElseIf ToStr(g10.Text("ty")) = "실적" Then
                Row = g10.RowIndex - 1
                Row1 = g10.RowIndex
            Else
                Row = g10.RowIndex - 2
                Row1 = g10.RowIndex - 1
            End If

            ModelNm = ToStr(g10.Text("grp_nm", Row))
            ModelNm = ToStr(g10.Text("fac_nm", Row)) & "  (" & ModelNm & ")"

            Dim Series As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.Line)
            Series.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
            Series.PointOptions.ValueNumericOptions.Precision = 0
            Series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
            Series.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
            'Series.ArgumentDataMember = "Name"
            'sr.ValueDataMembers[0] = "CurrentDose"
            Series.PointOptions.PointView = DevExpress.XtraCharts.PointView.Values
            Series.Label.ResolveOverlappingMinIndent = 5
            Series.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
            Series.Name = "계획"
            Chart2.Series.Add(Series)
            Chart2.Titles(0).Text = ModelNm
            'Chart2.Titles(0).Text = ToStr(g10.Text("fac_nm", Row)) & "(" & ToStr(g10.Text("grp_nm", Row)) & ")"
            Chart2.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
            For Col = 8 To g10.ColumnCount - 1
                Dim value As Double = 0
                If ToStr(g10.Text(Col, Row)) = "" Then
                    value = 0
                Else
                    value = g10.Text(Col, Row)
                End If
                Dim point As New SeriesPoint(ToStr(g10.ColumnTitle(Col)), value)
                Series.Points.Add(point)
            Next
        Else
            Row1 = g10.RowIndex
            ModelNm = ToStr(g10.Text("fac_nm", Row1)) & "  (" & ToStr(g10.Text("grp_nm", Row1)) & ")"
            Chart2.Titles(0).Text = ModelNm
        End If


        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.Line)
        Series1.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        Series1.PointOptions.ValueNumericOptions.Precision = 0
        Series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series1.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        'Series.ArgumentDataMember = "Name"
        'sr.ValueDataMembers[0] = "CurrentDose"
        Series1.PointOptions.PointView = DevExpress.XtraCharts.PointView.Values
        Series1.Label.ResolveOverlappingMinIndent = 5
        Series1.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        Series1.Name = "실적"
        Chart2.Series.Add(Series1)
        Chart2.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        For Col = 8 To g10.ColumnCount - 1
            Dim value As Double = 0
            If ToStr(g10.Text(Col, Row1)) = "" Then
                value = 0
            Else
                value = g10.Text(Col, Row1)
            End If
            Dim point As New SeriesPoint(ToStr(g10.ColumnTitle(Col)), value)
            Series1.Points.Add(point)
        Next
    End Sub

    Private Sub FindColumn2()
        Dim finder(1) As String
        finder(0) = "fac_nm=" + g20.Text("fac_nm")
        finder(1) = "grp_nm=소계"
        'finder(2) = "ty=실적"

        g20.Find(finder)    '여러가지 조건으로 행을 찾을 수 있다

    End Sub

    Private Sub g20_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles g20.Click
        If g20.RowCount = 0 Then Exit Sub
        If XtraTabControl2.SelectedTabPageIndex = 0 Then Exit Sub
        'MsgBox(g10.FocusedFieldName)
        If ToStr(g20.Text("grp_nm")) <> "총계" And g20.FocusedFieldName = "fac_nm" Then FindColumn2()
        Chart4.Series.Clear()
        Dim Col As Integer
        Dim Row As Integer = 0
        Dim Row1 As Integer = 0
        Dim ModelNm As String = ""

        If r1.Checked Then
            If ToStr(g20.Text("ty")) = "계획" Then
                Row = g20.RowIndex
                Row1 = g20.RowIndex + 1
            ElseIf ToStr(g20.Text("ty")) = "실적" Then
                Row = g20.RowIndex - 1
                Row1 = g20.RowIndex
            Else
                Row = g20.RowIndex - 2
                Row1 = g20.RowIndex - 1
            End If

            ModelNm = ToStr(g10.Text("grp_nm", Row))
            ModelNm = ToStr(g10.Text("fac_nm", Row)) & "  (" & ModelNm & ")"

            Dim Series As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.Line)
            Series.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
            Series.PointOptions.ValueNumericOptions.Precision = 0
            Series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
            Series.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
            'Series.ArgumentDataMember = "Name"
            'sr.ValueDataMembers[0] = "CurrentDose"
            Series.PointOptions.PointView = DevExpress.XtraCharts.PointView.Values
            Series.Label.ResolveOverlappingMinIndent = 5
            Series.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
            Series.Name = "계획"
            Chart4.Series.Add(Series)
            Chart4.Titles(0).Text = ModelNm
            Chart4.Titles(0).Text = ToStr(g20.Text("fac_nm", Row)) & "(" & ToStr(g20.Text("grp_nm", Row)) & ")"
            Chart4.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
            For Col = 8 To g20.ColumnCount - 1
                Dim value As Double = 0
                If ToStr(g20.Text(Col, Row)) = "" Then
                    value = 0
                Else
                    value = g20.Text(Col, Row)
                End If
                Dim point As New SeriesPoint(ToStr(g20.ColumnTitle(Col)), value)
                Series.Points.Add(point)
            Next
        Else
            Row1 = g20.RowIndex
            ModelNm = ToStr(g20.Text("fac_nm", Row1)) & "  (" & ToStr(g20.Text("grp_nm", Row1)) & ")"
            Chart4.Titles(0).Text = ModelNm
        End If


        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.Line)
        Series1.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        Series1.PointOptions.ValueNumericOptions.Precision = 0
        Series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series1.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        'Series.ArgumentDataMember = "Name"
        'sr.ValueDataMembers[0] = "CurrentDose"
        Series1.PointOptions.PointView = DevExpress.XtraCharts.PointView.Values
        Series1.Label.ResolveOverlappingMinIndent = 5
        Series1.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        Series1.Name = "실적"
        Chart4.Series.Add(Series1)
        Chart4.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        For Col = 8 To g20.ColumnCount - 1
            Dim value As Double = 0
            If ToStr(g20.Text(Col, Row1)) = "" Then
                value = 0
            Else
                value = g20.Text(Col, Row1)
            End If
            Dim point As New SeriesPoint(ToStr(g20.ColumnTitle(Col)), value)
            Series1.Points.Add(point)
        Next
    End Sub

    Private Sub r_Click(sender As Object, e As System.EventArgs) Handles r1.Click, r2.Click
        If r1.Checked Then
            open_ty.Text = "1"
        Else
            open_ty.Text = "2"
        End If
    End Sub
End Class
