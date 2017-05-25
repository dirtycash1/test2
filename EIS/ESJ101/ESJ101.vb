Imports Frame7
Imports Base7
Imports Base7.Shared
Imports DevExpress.XtraCharts

Public Class ESJ101

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        g10.SelectRow = True
        Select Case open_ty.DefaultText
            Case "", "1"
                r1.Checked = True
                open_ty.Text = "1"
            Case "2"
                r2.Checked = True
        End Select

        Init_Title()
        Disp_Data()
        sbchart()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Open

                Init_Title()
                Disp_Data()
                sbchart()
            Case MenuType.Print
                If Chart1.Series.Count < 0 Then Exit Sub
                Chart1.OptionsPrint.SizeMode = DevExpress.XtraCharts.Printing.PrintSizeMode.Zoom
                Chart1.ShowPrintPreview()

            Case Else

                MyBase.MenuButton_Click(mty)

        End Select

    End Sub


    Private Sub Init_Title()

        '1. 컬럼배열을 만든다
        Dim frDt As Date = std_year.Text + "-01-01"
        Dim toDt As Date = std_year.Text + "-12-31"

        Dim cnt As Integer = DateDiff(DateInterval.Month, frDt, toDt) + 1
        Dim arr(1, 0) As String, yyyymm As String, title As String
        g10.ColumnVisible("ty") = (open_ty.Text = "1")
        For i = 0 To cnt - 1
            ReDim Preserve arr(1, i)     'Array를 증가시킨다 

            yyyymm = Format(DateAdd(DateInterval.Month, i, frDt), "yyyy-MM")
            title = (i + 1).ToString

            arr(0, i) = yyyymm                      'FieldName
            arr(1, i) = title + "월"                'Title
        Next

        '2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
        ' Ex) g10.InsertColumn("A", arr, "B")
        '     "A" 컬럼이후에 삽입된다
        '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
        '     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다

        g10.InsertArrayColumns(Nothing, arr, "val")

    End Sub


    '첫번째 Display 방법: 기본기능을 이용
    Private Sub Disp_Data()
        Try
            'Master 부분
            g10.GridColumn("grp_nm").IsMasterKey = True
            g10.GridColumn("cust_nm").IsMasterKey = True
            g10.GridColumn("ty").IsMasterKey = True
            g10.GridColumn("tot").IsMasterData = True

            'Detail 부분
            g10.GridColumn("std_mon").IsDetailKey = True
            g10.GridColumn("amt").IsDetailData = True

            MyBase.Open()

        Catch ex As Exception

            MessageInfo(ex, "Disp_Data()")

        End Try
    End Sub


#Region " 2. char "
    Public Sub sbchart()
        Chart1.Series.Clear()
        Dim Col As Integer
        Dim Series As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.Bar)
        Series.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        Series.PointOptions.ValueNumericOptions.Precision = 0
        Series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        Series.PointOptions.PointView = DevExpress.XtraCharts.PointView.Values
        Series.Label.ResolveOverlappingMinIndent = 5
        Series.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        Series.Name = "Paint"
        Chart1.Titles(0).Text = "분류"
        Chart1.Series.Add(Series)
        Chart1.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        For Row = 0 To g10.RowCount - 1
            If ToStr(g10.Text("cust_nm", Row)) = "소계" And ToStr(g10.Text("ty", Row)) = "실적" And ToStr(g10.Text("grp_nm", Row)) = "Paint" Then
                For Col = 8 To g10.ColumnCount - 1
                    Dim value As Double = 0
                    If ToStr(g10.Text(Col, Row)) = "" Then
                        value = 0
                    Else
                        value = g10.Text(Col, Row) / unit_bc.Text
                    End If
                    Dim point As New SeriesPoint(ToStr(g10.ColumnTitle(Col)), value)
                    Series.Points.Add(point)
                Next
            End If
        Next

        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.Bar)
        Series1.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        Series1.PointOptions.ValueNumericOptions.Precision = 0
        Series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series1.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        Series1.PointOptions.PointView = DevExpress.XtraCharts.PointView.Values
        Series1.Label.ResolveOverlappingMinIndent = 5
        Series1.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        Series1.Name = "Film"
        Chart1.Series.Add(Series1)
        Chart1.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        For Row = 0 To g10.RowCount - 1
            If ToStr(g10.Text("cust_nm", Row)) = "소계" And ToStr(g10.Text("ty", Row)) = "실적" And ToStr(g10.Text("grp_nm", Row)) = "Film" Then
                For Col = 8 To g10.ColumnCount - 1
                    Dim value As Double = 0
                    If ToStr(g10.Text(Col, Row)) = "" Then
                        value = 0
                    Else
                        value = g10.Text(Col, Row) / unit_bc.Text
                    End If
                    Dim point As New SeriesPoint(ToStr(g10.ColumnTitle(Col)), value)
                    Series1.Points.Add(point)
                Next
            End If
        Next

        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.Bar)
        Series2.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        Series2.PointOptions.ValueNumericOptions.Precision = 0
        Series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series2.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        Series2.PointOptions.PointView = DevExpress.XtraCharts.PointView.Values
        Series2.Label.ResolveOverlappingMinIndent = 5
        Series2.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        Series2.Name = "소재"
        Chart1.Series.Add(Series2)
        Chart1.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        For Row = 0 To g10.RowCount - 1
            If ToStr(g10.Text("cust_nm", Row)) = "소계" And ToStr(g10.Text("ty", Row)) = "실적" And ToStr(g10.Text("grp_nm", Row)) = "소재" Then
                For Col = 8 To g10.ColumnCount - 1
                    Dim value As Double = 0
                    If ToStr(g10.Text(Col, Row)) = "" Then
                        value = 0
                    Else
                        value = g10.Text(Col, Row) / unit_bc.Text
                    End If
                    Dim point As New SeriesPoint(ToStr(g10.ColumnTitle(Col)), value)
                    Series2.Points.Add(point)
                Next
            End If
        Next

        Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.Bar)
        Series3.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        Series3.PointOptions.ValueNumericOptions.Precision = 0
        Series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series3.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        Series3.PointOptions.PointView = DevExpress.XtraCharts.PointView.Values
        Series3.Label.ResolveOverlappingMinIndent = 5
        Series3.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        Series3.Name = "기타"
        Chart1.Series.Add(Series3)
        Chart1.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        For Row = 0 To g10.RowCount - 1
            If ToStr(g10.Text("cust_nm", Row)) = "소계" And ToStr(g10.Text("ty", Row)) = "실적" And ToStr(g10.Text("grp_nm", Row)) = "기타" Then
                For Col = 8 To g10.ColumnCount - 1
                    Dim value As Double = 0
                    If ToStr(g10.Text(Col, Row)) = "" Then
                        value = 0
                    Else
                        value = g10.Text(Col, Row) / unit_bc.Text
                    End If
                    Dim point As New SeriesPoint(ToStr(g10.ColumnTitle(Col)), value)
                    Series3.Points.Add(point)
                Next
            End If
        Next

    End Sub
#End Region

    Private Sub FindColumn()
        Dim finder(1) As String
        finder(0) = "grp_nm=" + g10.Text("grp_nm")
        finder(1) = "cust_nm=소계"

        g10.Find(finder)    '여러가지 조건으로 행을 찾을 수 있다
    End Sub

    Private Sub g10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.Click
        If g10.RowCount = 0 Then Exit Sub
        If ToStr(g10.Text("dept_nm")) <> "총계" And g10.FocusedFieldName = "grp_nm" Then FindColumn()

        Dim Row As Integer = 0
        Dim Row1 As Integer = 0
        Dim Col As Integer
        Chart2.Series.Clear()
        Dim Title As String = ""
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

            Title = ToStr(g10.Text("cust_nm", Row))
            If Title <> "전체" Then
                Title = ToStr(g10.Text("grp_nm", Row)) & "  " & Title
            End If

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
            Chart2.Titles(0).Text = Title
            'Chart2.Titles(0).Text = ToStr(g10.Text("cust_nm", Row)) & "(" & ToStr(g10.Text("grp_nm", Row)) & ")"
            Chart2.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
            For Col = 8 To g10.ColumnCount - 1
                Dim value As Double = 0
                If ToStr(g10.Text(Col, Row)) = "" Then
                    value = 0
                Else
                    value = g10.Text(Col, Row) / unit_bc.Text
                End If
                Dim point As New SeriesPoint(ToStr(g10.ColumnTitle(Col)), value)
                Series.Points.Add(point)
            Next
        Else
            Row1 = g10.RowIndex
            Title = ToStr(g10.Text("cust_nm", Row1))
            If Title <> "전체" Then
                Title = ToStr(g10.Text("grp_nm", Row1)) & "  " & Title
            End If
            Chart2.Titles(0).Text = Title
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
                value = g10.Text(Col, Row1) / unit_bc.Text
            End If
            Dim point As New SeriesPoint(ToStr(g10.ColumnTitle(Col)), value)
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
