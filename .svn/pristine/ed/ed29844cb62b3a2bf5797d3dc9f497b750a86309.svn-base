Imports Frame7
Imports Base7
Imports Base7.Shared
Imports DevExpress.XtraCharts

Public Class ESP101
    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        g10.SelectRow = True
        pay_yn.Text = "1"
        bns_yn.Text = "1"
        Me.Init_Title()
        Me.Disp_Data()
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

        Dim dSet As DataSet = Me.OpenDataSet("ESP101_Title", P)
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


        g10.InsertArrayColumns(Nothing, arr, "pay_amt")

    End Sub

#End Region

#Region " 2. Display "

    '첫번째 Display 방법: 기본기능을 이용
    Private Sub Disp_Data()
        Try
            'b.grp_cd, grp_nm, dept_nm,  sq, e.pay_mon,  pay_amt
            'g10.GridColumn("grp_cd").IsMasterKey = True
            g10.GridColumn("grp_nm").IsMasterKey = True
            g10.GridColumn("dept_nm").IsMasterKey = True
            g10.GridColumn("sq").IsMasterKey = True


            'Detail 부분
            g10.GridColumn("pay_mon").IsDetailKey = True
            g10.GridColumn("pay_amt").IsDetailData = True

            MyBase.Open("esp101_g10")

        Catch ex As Exception

            MessageInfo(ex, "Disp_Data()")

        End Try
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

        Dim Row As Integer = 0

        Row = g10.RowIndex
        Dim Title As String = ToStr(g10.Text("grp_nm", Row))
        Select Case ToStr(g10.Text("dept_nm", Row))
            Case "총계"
                Title = "총계"
            Case Else
                Title &= "(" & ToStr(g10.Text("dept_nm", Row)) & ")"
        End Select

        Chart1.Series.Clear()
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
        Series.Name = "월별지급금액"
        Chart1.Series.Add(Series)
        Chart1.Titles(0).Text = Title
        'Chart1.Titles(0).Text = ToStr(g10.Text("grp_nm", Row)) & "(" & ToStr(g10.Text("dept_nm", Row)) & ")"
        Chart1.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default

        For Col = 4 To g10.ColumnCount - 1
            If g10.ColumnTitle(Col).EndsWith("월") Then
                Dim value As Double = 0
                If ToStr(g10.Text(Col, Row)) = "" Then
                    value = 0
                Else
                    Select Case unit_bc.Text
                        Case "ES900500"
                            value = g10.Text(Col, Row) / 1000000
                        Case "ES900550"
                            value = g10.Text(Col, Row) / 10000000
                        Case "ES900600"
                            value = g10.Text(Col, Row) / 100000000
                        Case Else
                            value = g10.Text(Col, Row)

                    End Select

                End If
                Dim point As New SeriesPoint(ToStr(g10.ColumnTitle(Col)), value)
                Series.Points.Add(point)
            End If

        Next



    End Sub


    Public Sub sbchart()

        Dim Row As Integer = 0

        Row = g10.RowIndex

        Chart1.Series.Clear()
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
        Series.Name = "월별지급금액"
        Chart1.Series.Add(Series)
        Chart1.Titles(0).Text = ToStr(g10.Text("grp_nm", Row)) & "(" & ToStr(g10.Text("dept_nm", Row)) & ")"
        Chart1.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default

        For Col = 4 To g10.ColumnCount - 1
            If g10.ColumnTitle(Col).EndsWith("월") Then
                Dim value As Double = 0
                If ToStr(g10.Text(Col, Row)) = "" Then
                    value = 0
                Else
                    Select Case unit_bc.Text
                        Case "ES900500"
                            value = g10.Text(Col, Row) / 1000000
                        Case "ES900550"
                            value = g10.Text(Col, Row) / 10000000
                        Case "ES900600"
                            value = g10.Text(Col, Row) / 100000000
                        Case Else
                            value = g10.Text(Col, Row)

                    End Select

                End If
                Dim point As New SeriesPoint(ToStr(g10.ColumnTitle(Col)), value)
                Series.Points.Add(point)
            End If

        Next

    End Sub

    Private Sub pay_yn_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles pay_yn.CheckedChanged

        If pay_yn.Text = "0" And bns_yn.Text = "0" Then
            pay_yn.Text = "1"
        End If

    End Sub

    Private Sub bns_yn_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bns_yn.CheckedChanged
        If bns_yn.Text = "0" And pay_yn.Text = "0" Then
            bns_yn.Text = "1"
        End If
    End Sub



End Class
