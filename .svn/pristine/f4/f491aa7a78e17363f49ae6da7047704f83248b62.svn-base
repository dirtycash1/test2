Imports Base7
Imports Base7.Shared
Imports DevExpress.XtraCharts

Public Class ESP100
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Try
                    Dim P As New OpenParameters
                    P.Add("@div_cd", div_cd.Text)
                    P.Add("@base_month", base_month.Text)
                    sbchart(ChartControl1.Series(0), "ESP100_Query", P, "인원수")
                    sbchart(ChartControl2.Series(0), "ESP100_Query1", P, "인건비")
                    sbchart(ChartControl3.Series(0), "ESP100_Query2", P, "부서별 분포")
                    sbchart(ChartControl4.Series(0), "ESP100_Query3", P, "직위별 분포")
                Catch ex As Exception
                End Try
        End Select

    End Sub

    Private Sub ESP100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim P As New OpenParameters
            P.Add("@div_cd", div_cd.Text)
            P.Add("@base_month", base_month.Text)
            sbchart(ChartControl1.Series(0), "ESP100_Query", P, "인원수")
            sbchart(ChartControl2.Series(0), "ESP100_Query1", P, "인건비")
            sbchart(ChartControl3.Series(0), "ESP100_Query2", P, "부서별 분포")
            sbchart(ChartControl4.Series(0), "ESP100_Query3", P, "직위별 분포")
        Catch ex As Exception
        End Try
    End Sub

    Public Sub sbchart(ByVal Series As Series, ByVal WorkSetCode As String, ByVal P As OpenParameters, ByVal series_Name As String)
        Dim dSet As DataSet, dRows As DataRowCollection, dRow As DataRow
        dSet = Me.OpenDataSet(WorkSetCode, P)
        dRows = dSet.Tables(0).Rows
        Series.Points.Clear()
        Series.Name = series_Name
        For Each dRow In dRows
            Dim value As Double = 0
            If ToStr(dRow("vales")) = "" Then
                value = 0
            Else
                value = dRow("vales")
            End If
            Dim point As New SeriesPoint(ToStr(dRow("code")), value)
            Series.Points.Add(point)
        Next
    End Sub


End Class
