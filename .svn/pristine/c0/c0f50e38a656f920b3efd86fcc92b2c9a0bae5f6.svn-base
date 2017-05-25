Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data
Imports DevExpress.XtraCharts


Public Class EPS102

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.open_Form()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                Me.open_Form()

                '    MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                '    '사용하려면 재정의 가능하다
                'Case MenuType.Save

            Case MenuType.New
                'cust_cd.Text = ""
                'itm_cd.Text = ""
                'itm_nm.Text = ""
                'emp_id.Text = ""
                'emp_nm.Text = ""

                'Me.New_Form()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Public Sub open_Form()

        'Dim P As New OpenParameters
        'P.Add("@div_cd", div_cd.Text)
        'P.Add("@std_mon", std_mon.Text)
        sbchart(ChartControl4.Series(0), "EPS102_Query3", "공장별")
        sbchart(ChartControl5.Series(0), "EPS102_Query2", "구분별")
        Me.Open()

    End Sub


    Public Sub sbchart(ByVal Series As Series, ByVal WorkSet As String, ByVal series_Name As String)
        Dim dSet As DataSet, dRows As DataRowCollection, dRow As DataRow
        dSet = Me.OpenDataSet(WorkSet)
        dRows = dSet.Tables(0).Rows
        Series.Points.Clear()
        Series.Name = Series.Name
        'Series.PointOptions.ValueNumericOptions.Format = NumericFormat.Number
        'Series.PointOptions.ValueNumericOptions.Precision = 0
        For Each dRow In dRows
            Dim value As Double = 0
            If ToStr(dRow("Amt")) = "" Then
                value = 0
            Else
                value = dRow("Amt") / unit_bc.Text
            End If
            Dim point As New SeriesPoint(ToStr(dRow("code")), value)
            Series.Points.Add(point)

        Next

    End Sub

End Class
