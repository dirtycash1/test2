Imports Frame7
Imports Base7
Imports Base7.Shared
Imports DevExpress.XtraCharts

Public Class ESJ201

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        g10.SelectRow = True
        Init_Title()
        Disp_Data()
        sbchart()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Open

                Me.Init_Title()
                Me.Disp_Data()
                sbchart()
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

        Dim dSet As DataSet = Me.OpenDataSet("esj201_title", P)
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

        '2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
        ' Ex) g10.InsertColumn("A", arr, "B")
        '     "A" 컬럼이후에 삽입된다
        '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
        '     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다

        g10.InsertArrayColumns(Nothing, arr, "amt")

    End Sub
#End Region

#Region " 2. Display "

    '첫번째 Display 방법: 기본기능을 이용
    Private Sub Disp_Data()
        Try
            'Master 부분

            g10.GridColumn("grp_nm").IsMasterKey = True
            g10.GridColumn("cust_nm").IsMasterKey = True
            g10.GridColumn("tot").IsMasterData = True

            'Detail 부분
            g10.GridColumn("dt").IsDetailKey = True
            g10.GridColumn("amt").IsDetailData = True

            MyBase.Open("esj201_g10")

            '화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다
            'g10.GridColumn("work_mon").DefaultText = work_mon.Text

        Catch ex As Exception

            MessageInfo(ex, "Disp_Data()")

        End Try
    End Sub

#End Region

#Region " 2. char "
    Public Sub sbchart()
        Chart1.Series.Clear()
        Dim Col As Integer
        For Row = 0 To g10.RowCount - 1
            If ToStr(g10.Text("cust_nm", Row)) = "소계" Then
                Dim Series As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.Bar)
                Series.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
                Series.PointOptions.ValueNumericOptions.Precision = 0
                Series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
                Series.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
                'Series.ArgumentDataMember = "Name"
                'sr.ValueDataMembers[0] = "CurrentDose"
                Series.PointOptions.PointView = DevExpress.XtraCharts.PointView.Values
                Series.Label.ResolveOverlappingMinIndent = 5
                Series.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
                Series.Name = ToStr(g10.Text("grp_nm", Row))
                Chart1.Series.Add(Series)
                Chart1.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
                For Col = 6 To g10.ColumnCount - 1
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
    End Sub
#End Region

    Private Sub FindColumn()
        Dim finder(1) As String
        finder(0) = "grp_nm=" + g10.Text("grp_nm")
        finder(1) = "cust_nm=소계"

        g10.Find(finder)    '여러가지 조건으로 행을 찾을 수 있다
    End Sub

    Private Sub g10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.Click
        If XtraTabControl1.SelectedTabPageIndex = 0 Then Exit Sub
        If ToStr(g10.Text("cust_nm")) <> "총계" And g10.FocusedFieldName = "grp_nm" Then FindColumn()

        'If ToStr(g10.Text("cust_nm")) <> "소계" Then
        Chart2.Series.Clear()
        Dim Col As Integer
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
        Series.Name = ToStr(g10.Text("cust_nm"))
        Dim Title As String = ToStr(g10.Text("grp_nm")) & "  (" & ToStr(g10.Text("cust_nm")) & ")"
        Chart2.Series.Add(Series)
        Chart2.Titles(0).Text = Title
        Chart2.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        For Col = 6 To g10.ColumnCount - 1
            Dim value As Double = 0
            If ToStr(g10.Text(Col)) = "" Then
                value = 0
            Else
                value = g10.Text(Col) / unit_bc.Text
            End If
            Dim point As New SeriesPoint(ToStr(g10.ColumnTitle(Col)), value)
            Series.Points.Add(point)
        Next
        'End If
    End Sub
End Class
