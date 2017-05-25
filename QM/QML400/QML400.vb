Imports Frame7
Imports Base7
Imports Base7.Shared
Imports DevExpress.XtraCharts
Imports System.Data


Public Class QML400

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim P As New OpenParameters

        P.Add("@fr_dt", fr_dt.Text)
        P.Add("@to_dt", to_dt.Text)

        sbchart(ChartControl1.Series(0), "QML400_Query", P, "건수")
        sbchart(ChartControl2.Series(0), "QML400_Query", P, "건수")
      
        Me.Open()
    End Sub
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Try
                   Dim P As New OpenParameters

                    P.Add("@fr_dt", fr_dt.Text)
                    P.Add("@to_dt", to_dt.Text)

                    sbchart(ChartControl1.Series(0), "QML400_Query", P, "건수")
                    sbchart(ChartControl2.Series(0), "QML400_Query", P, "건수")
                Catch ex As Exception
                End Try

                Me.Open()
            Case MenuType.Print
                Dim P As New OpenParameters

                P.Add("@fr_dt", fr_dt.Text)
                P.Add("@to_dt", to_dt.Text)

                System7.ReportView.LoadView("QML400", "", "qml400_print", P)

        End Select

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
