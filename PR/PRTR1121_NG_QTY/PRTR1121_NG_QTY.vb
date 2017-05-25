Imports Base7
Imports Base7.Shared
Imports DevExpress.XtraCharts
Imports System.Data
Imports System.Windows.Forms


Public Class PRTR1121_NG_QTY
    Dim p As New OpenParameters
    'Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    Me.Open()
    '    p.Add("@base_dt", fr_dt.Text)
    '    p.Add("@fac_cd", fac_cd.Text)
    '    sbchart(ChartControl1.Series(0), "PRTR2120_DAY_g10", p, "일 수율")
    '    sbchart2(ChartControl2.Series(0), "PRTR2120_DAY_g10", p, "일 생산량")
    'End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open()
                p.Add("@fr_dt", fr_dt.Text)
                p.Add("@to_dt", to_dt.Text)

                sbchart1(ChartControl3.Series(0), "PRTR1121_NG_QTY_g10", p, "투명 렌즈")
                sbchart1(ChartControl3.Series(1), "PRTR1121_NG_QTY_g20", p, "컬러 렌즈")

                sbchart2(ChartControl1.Series(0), "투명", "01")
                sbchart2(ChartControl1.Series(1), "투명", "02")
                sbchart2(ChartControl1.Series(2), "투명", "03")

                'For Each dRow In dRows
                '    sbchart4(ChartControl1.Series(0), ToStr(dRow("COLOR_GU")), ToStr(dRow("NG_CD")))
                'next

                For i As Integer = 0 To g10.RowCount - 1
                    sbchart2(ChartControl1.Series(i), g10.Text("COLOR_GU", i), g10.Text("NG_CD", i))
                Next

                For i As Integer = 0 To g20.RowCount - 1
                    sbchart2(ChartControl2.Series(i), g20.Text("COLOR_GU", i), g20.Text("NG_CD", i))
                Next

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다
        End Select

    End Sub

    Public Sub sbchart1(ByVal Series As Series, ByVal WorkSetCode As String, ByVal P As OpenParameters, ByVal series_Name As String)  '막대그래프
        Dim dSet As DataSet, dRows As DataRowCollection, dRow As DataRow
        dSet = Me.OpenDataSet(WorkSetCode, P)
        dRows = dSet.Tables(0).Rows
        Series.Points.Clear()
        Series.Name = series_Name
        For Each dRow In dRows
            Dim value As Double = 0
            If ToStr(dRow("NG_RATE")) = "" Then    ' 불량률(투명렌즈) 실DATA
                value = 0
            Else
                value = dRow("NG_RATE")
            End If
            Dim point As New SeriesPoint(ToStr(dRow("NG_NM")), value)   '하단제목
            Series.Points.Add(point)
        Next
    End Sub

    Public Sub sbchart2(ByVal Series As Series, ByVal COLOR_GU As String, ByVal NG_CD As String)  '꺾은선 그래프 
        p.Add("@color_gu", COLOR_GU)
        p.Add("@ng_cd", NG_CD)

        Dim dSet As DataSet, dRows As DataRowCollection, dRow As DataRow
        dSet = Me.OpenDataSet("PRTR1121_NG_DAY", p)
        dRows = dSet.Tables(0).Rows
        Series.Points.Clear()

        For Each dRow In dRows
            Dim value As Double = 0
            If ToStr(dRow("NG_RATE")) = "" Then    ' 불량률(컬러렌즈) 실DATA
                value = 0
            Else
                value = dRow("NG_RATE")
            End If

            Series.Name = dRow("NG_NM")
            Dim point As New SeriesPoint(ToStr(dRow("PR_DT")), value)   '하단제목
            Series.Points.Add(point)

        Next
    End Sub

    Private Sub save_chart1_Click(sender As System.Object, e As System.EventArgs) Handles save_chart1.Click
        Dim savefile As SaveFileDialog = New SaveFileDialog

        savefile.InitialDirectory = "C:\"
        savefile.Title = "Save Chart Image"
        savefile.DefaultExt = "jpg"
        savefile.Filter = "JPEG(*.jpg)|*.jpg|Bitmap (*.bmp)|*.bmp|GIF (*.gif)|*.gif|All Files (*.*)|*.*"
        savefile.FilterIndex = 0
        savefile.RestoreDirectory = True

        If savefile.ShowDialog() = DialogResult.OK Then
            Select Case savefile.FileName.Substring(savefile.FileName.IndexOf("."))
                Case ".jpg"
                    ChartControl1.ExportToImage(savefile.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                Case ".gif"
                    ChartControl1.ExportToImage(savefile.FileName, System.Drawing.Imaging.ImageFormat.Gif)
                Case ".bmp"
                    ChartControl1.ExportToImage(savefile.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
                Case Else
                    MsgBox("지정된 그림파일 형식이 아니거나 잘못된 형식입니다.")
            End Select
            MsgBox(savefile.FileName + "에 저장되었습니다.")
        End If
    End Sub

    Private Sub save_chart2_Click(sender As System.Object, e As System.EventArgs) Handles save_chart2.Click
        Dim savefile As SaveFileDialog = New SaveFileDialog

        savefile.InitialDirectory = "C:\"
        savefile.Title = "Save Chart Image"
        savefile.DefaultExt = "jpg"
        savefile.Filter = "JPEG(*.jpg)|*.jpg|Bitmap (*.bmp)|*.bmp|GIF (*.gif)|*.gif|All Files (*.*)|*.*"
        savefile.FilterIndex = 0
        savefile.RestoreDirectory = True

        If savefile.ShowDialog() = DialogResult.OK Then
            Select Case savefile.FileName.Substring(savefile.FileName.IndexOf("."))
                Case ".jpg"
                    ChartControl2.ExportToImage(savefile.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                Case ".gif"
                    ChartControl2.ExportToImage(savefile.FileName, System.Drawing.Imaging.ImageFormat.Gif)
                Case ".bmp"
                    ChartControl2.ExportToImage(savefile.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
                Case Else
                    MsgBox("지정된 그림파일 형식이 아니거나 잘못된 형식입니다.")
            End Select
            MsgBox(savefile.FileName + "에 저장되었습니다.")
        End If
    End Sub

    Private Sub save_chart3_Click(sender As System.Object, e As System.EventArgs) Handles save_chart3.Click
        Dim savefile As SaveFileDialog = New SaveFileDialog

        savefile.InitialDirectory = "C:\"
        savefile.Title = "Save Chart Image"
        savefile.DefaultExt = "jpg"
        savefile.Filter = "JPEG(*.jpg)|*.jpg|Bitmap (*.bmp)|*.bmp|GIF (*.gif)|*.gif|All Files (*.*)|*.*"
        savefile.FilterIndex = 0
        savefile.RestoreDirectory = True

        If savefile.ShowDialog() = DialogResult.OK Then
            Select Case savefile.FileName.Substring(savefile.FileName.IndexOf("."))
                Case ".jpg"
                    ChartControl3.ExportToImage(savefile.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                Case ".gif"
                    ChartControl3.ExportToImage(savefile.FileName, System.Drawing.Imaging.ImageFormat.Gif)
                Case ".bmp"
                    ChartControl3.ExportToImage(savefile.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
                Case Else
                    MsgBox("지정된 그림파일 형식이 아니거나 잘못된 형식입니다.")
            End Select
            MsgBox(savefile.FileName + "에 저장되었습니다.")
        End If
    End Sub

    


    'Public Sub sbchart3(ByVal Series As Series, ByVal WorkSetCode As String, ByVal P As OpenParameters)
    '    Dim dSet As DataSet, dRows As DataRowCollection, dRow As DataRow   ' SMK
    '    dSet = Me.OpenDataSet(WorkSetCode, P)
    '    dRows = dSet.Tables(0).Rows
    '    Series.Points.Clear()
    '    'Series.Name = series_Name
    '    For Each dRow In dRows
    '        Dim value As Double = 0
    '        If ToStr(dRow("NG_RATE")) = "" Then    ' 불량률(컬러렌즈)
    '            value = 0
    '        Else
    '            value = dRow("NG_RATE")
    '        End If
    '        Series.Name = dRow("NG_NM")
    '        Dim point As New SeriesPoint(ToStr(dRow("PR_DT")), value)   '하단제목
    '        Series.Points.Add(point)

    '    Next
    'End Sub


    'Private Sub img_save2_Click(sender As System.Object, e As System.EventArgs) Handles img_save2.Click
    '    Dim savefile As SaveFileDialog = New SaveFileDialog

    '    savefile.InitialDirectory = "C:\"
    '    savefile.Title = "Save Chart Image"
    '    savefile.DefaultExt = "jpg"
    '    savefile.Filter = "JPEG(*.jpg)|*.jpg|Bitmap (*.bmp)|*.bmp|GIF (*.gif)|*.gif|All Files (*.*)|*.*"
    '    savefile.FilterIndex = 0
    '    savefile.RestoreDirectory = True

    '    If savefile.ShowDialog() = DialogResult.OK Then
    '        Select Case savefile.FileName.Substring(savefile.FileName.IndexOf("."))
    '            Case ".jpg"
    '                ChartControl2.ExportToImage(savefile.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
    '            Case ".gif"
    '                ChartControl2.ExportToImage(savefile.FileName, System.Drawing.Imaging.ImageFormat.Gif)
    '            Case ".bmp"
    '                ChartControl2.ExportToImage(savefile.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
    '            Case Else
    '                MsgBox("지정된 그림파일 형식이 아니거나 잘못된 형식입니다.")
    '        End Select
    '        MsgBox(savefile.FileName + "에 저장되었습니다.")
    '    End If
    'End Sub






End Class
