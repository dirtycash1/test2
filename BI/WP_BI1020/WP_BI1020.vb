Imports Frame7
Imports Base7
Imports Base7.Shared
Imports DevExpress.XtraCharts

Public Class WP_BI1020
    Dim p As New OpenParameters
    Dim a As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Preview()

            Case MenuType.Cancel
                Me.Clear()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub Clear()
        p.Clear()
        p.Add("@find_ym", find_ym.Text)
        p.Add("@find_de_gu", "XXX")
        p.Add("@find_gdgu_cd", "XXX")
        p.Add("@find_cs_cd", "XXX")
        p.Add("@find_cs_nm", "XXX")

        find_gdgu_cd.Text = ""
        find_de_gu.Text = ""
        find_cs_cd.Text = ""
        find_cs_nm.Text = ""
    End Sub

    Private Sub Preview()
        p.Add("@find_ym", find_ym.Text)
        p.Add("@find_de_gu", find_de_gu.Text)
        p.Add("@find_gdgu_cd", find_gdgu_cd.Text)
        p.Add("@find_cs_cd", find_cs_cd.Text)
        p.Add("@find_cs_nm", find_cs_nm.Text)

        sbchart(Chart.Series(0), "wp_bi1020_query", p, "금 년")
        sbchart(Chart.Series(1), "wp_bi1020_query1", p, "작 년")

        Me.Open("wp_bi1020_query8", p)

        a.Clear()
        a.Add("@find_ym", find_ym.Text)
        a.Add("@find_de_gu", find_de_gu.Text)
        a.Add("@find_gdgu_cd", find_gdgu_cd.Text)

        sbchart(Chart1.Series(0), "wp_bi1020_query2", a, "해당년도계획")
        sbchart(Chart1.Series(1), "wp_bi1020_query3", a, "해당년도실적")
        sbchart(Chart1.Series(2), "wp_bi1020_query4", a, "해당분기계획")
        sbchart(Chart1.Series(3), "wp_bi1020_query5", a, "해당분기실적")
        sbchart(Chart1.Series(4), "wp_bi1020_query6", a, "해당월계획")
        sbchart(Chart1.Series(5), "wp_bi1020_query7", a, "해당월실적")
    End Sub

    Public Sub sbchart(ByVal Series As Series, ByVal WorkSetCode As String, ByVal P As OpenParameters, ByVal series_Name As String)
        Dim dSet As DataSet, dRows As DataRowCollection, dRow As DataRow
        dSet = Me.OpenDataSet(WorkSetCode, P)
        dRows = dSet.Tables(0).Rows
        Series.Points.Clear()
        Series.Name = series_Name
        Series.PointOptions.ValueNumericOptions.Format = NumericFormat.Number
        Series.PointOptions.ValueNumericOptions.Precision = 0
        For Each dRow In dRows
            Dim value As Double = 0
            If ToStr(dRow("Amt")) = "" Then
                value = 0
            Else
                value = dRow("Amt")
            End If
            Dim point As New SeriesPoint(ToStr(dRow("code")), value)
            Series.Points.Add(point)
        Next
    End Sub
End Class
