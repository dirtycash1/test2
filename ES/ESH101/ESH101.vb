Imports Frame7
Imports Base7
Imports Base7.Shared
Imports DevExpress.XtraCharts

Public Class ESH101

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        g10.SelectRow = True
        Form_Open()
    End Sub


    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Open
                Form_Open()


            Case Else

                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    Private Sub Form_Open()
        Me.Open()

        g10.Find("dept_nm=총계")    '여러가지 조건으로 행을 찾을 수 있다

        sbchart()
    End Sub

#Region " 2. char "
    Public Sub sbchart()

        'If g10.RowCount = 0 Then Exit Sub
        'Dim Row As Integer = 0
        'Dim Row1 As Integer = 0
        'If ToStr(g10.Text("gen_nm")) = "남" Then
        '    Row = g10.RowIndex
        '    Row1 = g10.RowIndex + 1
        'ElseIf ToStr(g10.Text("gen_nm")) = "여" Then
        '    Row = g10.RowIndex - 1
        '    Row1 = g10.RowIndex
        'Else
        '    Row = g10.RowIndex - 2
        '    Row1 = g10.RowIndex - 1
        'End If


        If g10.RowCount = 0 Then Exit Sub
        Dim Row As Integer = 0
        Dim Row1 As Integer = 0
        If ToStr(g10.Text("gen_nm")) = "남" Then
            Row = g10.RowIndex
            Row1 = g10.RowIndex + 1
        ElseIf ToStr(g10.Text("gen_nm")) = "여" Then
            Row = g10.RowIndex - 1
            Row1 = g10.RowIndex
        Else
            Row = g10.RowIndex - 2
            Row1 = g10.RowIndex - 1
        End If
        Chart2.Series.Clear()
        Dim Col As Integer
        Dim Series As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.StackedBar)
        Series.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        Series.PointOptions.ValueNumericOptions.Precision = 0
        Series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        'Series.ArgumentDataMember = "Name"
        'sr.ValueDataMembers[0] = "CurrentDose"
        Series.PointOptions.PointView = DevExpress.XtraCharts.PointView.Values
        Series.Label.ResolveOverlappingMinIndent = 5
        Series.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        Series.Name = "남"
        Chart2.Series.Add(Series)
        Chart2.Titles(0).Text = ToStr(g10.Text("grp_nm", Row)) & "(" & ToStr(g10.Text("dept_nm", Row)) & ")"
        Chart2.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        For Col = 5 To g10.ColumnCount - 1
            Dim value As Double = 0
            If ToStr(g10.Text(Col, Row)) = "" Then
                value = 0
            Else
                value = g10.Text(Col, Row)
            End If
            Dim point As New SeriesPoint(ToStr(g10.ColumnTitle(Col)), value)
            Series.Points.Add(point)
        Next

        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.StackedBar)
        Series1.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        Series1.PointOptions.ValueNumericOptions.Precision = 0
        Series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series1.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        'Series.ArgumentDataMember = "Name"
        'sr.ValueDataMembers[0] = "CurrentDose"
        Series1.PointOptions.PointView = DevExpress.XtraCharts.PointView.Values
        Series1.Label.ResolveOverlappingMinIndent = 5
        Series1.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        Series1.Name = "여"
        Chart2.Series.Add(Series1)
        Chart2.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        For Col = 5 To g10.ColumnCount - 1
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
#End Region

    Private Sub FindColumn()
        Dim finder(1) As String
        finder(0) = "grp_nm=" + g10.Text("grp_nm")
        finder(1) = "dept_nm=소계"

        g10.Find(finder)    '여러가지 조건으로 행을 찾을 수 있다
    End Sub

    Private Sub g10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.Click

        If ToStr(g10.Text("dept_nm")) <> "총계" And g10.FocusedFieldName = "grp_nm" Then FindColumn()
        sbchart()

    End Sub

End Class
