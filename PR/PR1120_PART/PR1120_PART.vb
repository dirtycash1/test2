Imports Base7
Imports Base7.Shared
Imports DevExpress.XtraCharts
Imports System.Data
Imports System.Windows.Forms


Public Class PR1120_PART
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load 
        EOptionBox1.Text = "1"
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                
                p.Add("@fr_dt", fr_dt.Text)
                p.Add("@to_dt", to_dt.Text)
                p.Add("@gong_cd", gong_cd.Text)

                If EOptionBox1.Text = "1" Then     ' 1. 조별 생산실적
                    ChartControl1.Visible = True
                    ChartControl2.Visible = True
                    ChartControl3.Visible = False
                    ChartControl4.Visible = False

                    XtraTabPage1.Text = "조별 생산량"
                    XtraTabPage2.Text = "조별 수율"
                    g10.Visible = True
                    g20.Visible = True
                    g30.Visible = False
                    g40.Visible = False
                    save_chart1.Visible = True
                    save_chart2.Visible = True
                    save_chart3.Visible = False
                    save_chart4.Visible = False

                    sbchart1(ChartControl1.Series(0), "GA122100", "생산량")
                    sbchart1(ChartControl1.Series(1), "GA122200", "생산량")
                    sbchart1(ChartControl1.Series(2), "GA122300", "생산량")
                    sbchart1(ChartControl2.Series(0), "GA122100", "수율")
                    sbchart1(ChartControl2.Series(1), "GA122200", "수율")
                    sbchart1(ChartControl2.Series(2), "GA122300", "수율")
                    Me.Open("PR1120_PART_g10")
                    Me.Open("PR1120_PART_g20")

                ElseIf EOptionBox1.Text = "2" Then    ' 2. 조별 불량현황

                    ChartControl1.Visible = False
                    ChartControl2.Visible = False
                    ChartControl3.Visible = True
                    ChartControl4.Visible = True
                    save_chart1.Visible = False
                    save_chart2.Visible = False
                    save_chart3.Visible = True
                    save_chart4.Visible = True

                    XtraTabPage1.Text = "조별 컬러렌즈 불량율"
                    XtraTabPage2.Text = "조별 투명렌즈 불량율"

                    g10.Visible = False
                    g20.Visible = False
                    g30.Visible = True
                    g40.Visible = True

                    sbchart2(ChartControl3.Series(0), "GA122100", "컬러")
                    sbchart2(ChartControl3.Series(1), "GA122200", "컬러")
                    sbchart2(ChartControl3.Series(2), "GA122300", "컬러")

                    sbchart2(ChartControl4.Series(0), "GA122100", "투명")
                    sbchart2(ChartControl4.Series(1), "GA122200", "투명")
                    sbchart2(ChartControl4.Series(2), "GA122300", "투명")

                    Me.Init_Title()
                    Me.disp()

                End If

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다
        End Select

    End Sub

    '조별 생산량, 수율 차트 [꺽은선 그래프]
    Public Sub sbchart1(ByVal Series As Series, ByVal PART_BC As String, ByVal CHART As String)  '꺾은선 그래프 
        p.Add("@fr_dt", fr_dt.Text)
        p.Add("@to_dt", to_dt.Text)
        p.Add("@gong_cd", gong_cd.Text)
        p.Add("@part_bc", PART_BC)

        Dim dSet As DataSet, dRows As DataRowCollection, dRow As DataRow
        dSet = Me.OpenDataSet("PR1120_PART_chart1", p)
        dRows = dSet.Tables(0).Rows
        Series.Points.Clear()

        For Each dRow In dRows
            Dim value As Double = 0
            If CHART = "생산량" Then
                If ToStr(dRow("TOT_QTY")) = "" Then
                    value = 0
                Else
                    value = dRow("TOT_QTY")
                End If
            ElseIf CHART = "수율" Then
                If ToStr(dRow("SU_RATE")) = "" Then
                    value = 0
                Else
                    value = dRow("SU_RATE")
                End If
            End If

            If dRow("PART_BC") = "GA122100" Then
                Series.Name = "A조(3교대)"
            ElseIf dRow("PART_BC") = "GA122200" Then
                Series.Name = "B조(3교대)"
            ElseIf dRow("PART_BC") = "GA122300" Then
                Series.Name = "C조(3교대)"
            End If

            Dim point As New SeriesPoint(ToStr(dRow("PR_DT")), value)   '하단제목
            Series.Points.Add(point)
        Next
    End Sub


    '조별 컬러,투명렌즈 불량율 [막대 그래프]
    Public Sub sbchart2(ByVal Series As Series, ByVal PART_BC As String, ByVal COLOR As String)  '막대 그래프 
        p.Add("@fr_dt", fr_dt.Text)
        p.Add("@to_dt", to_dt.Text)
        p.Add("@gong_cd", gong_cd.Text)
        p.Add("@color", COLOR)
        p.Add("@title", "불량율")
        p.Add("@part_bc", PART_BC)

        Dim dSet As DataSet, dRows As DataRowCollection, dRow As DataRow
        dSet = Me.OpenDataSet("PR1120_PART_chart2", p)
        dRows = dSet.Tables(0).Rows
        Series.Points.Clear()

        For Each dRow In dRows
            Dim value As Double = 0
            If ToStr(dRow("ng_qty")) = "" Then
                value = 0
            Else
                value = dRow("ng_qty")
            End If
            Dim point As New SeriesPoint(ToStr(dRow("NG_NM")), value)   '하단제목
            Series.Points.Add(point)
        Next

        If PART_BC = "GA122100" Then
            Series.Name = "A조(3교대)"
        ElseIf PART_BC = "GA122200" Then
            Series.Name = "B조(3교대)"
        ElseIf PART_BC = "GA122300" Then
            Series.Name = "C조(3교대)"
        End If

    End Sub

    Private Sub Init_Title()

        '위의 타이틀(엣지, 기스, 기포, 알떨어짐... 동적 타이틀 만들어주기)
        Dim dSet As DataSet = Me.OpenDataSet("PR1120_NG_Title")
        If IsEmpty(dSet) Then
            MessageInfo("조회 할 Data가 없습니다")
            Exit Sub
        End If

        Dim arr(1, 0) As String, inx As Integer = 0
        For Each dRow In dSet.Tables(0).Rows
            ReDim Preserve arr(1, inx)      'Array를 증가시킨다

            arr(0, inx) = dRow(0)           'FieldName 으로 사용된다 (NG_CD)
            arr(1, inx) = dRow(1)           'Title로 사용된다        (NG_NM)
            inx += 1
        Next

        g30.InsertArrayColumns(Nothing, arr, "ng_qty")
        g40.InsertArrayColumns(Nothing, arr, "ng_qty")

    End Sub

    Private Sub disp()
        p.Add("@title", "")
        p.Add("@part_bc", "")

        With g30
            p.Add("@color", "컬러")

            'Master 부분
            .GridColumn("PART_BC").IsMasterKey = True
            .GridColumn("TITLE").IsMasterKey = True

            'Detail 부분
            .GridColumn("NG_CD").IsDetailKey = True
            .GridColumn("ng_qty").IsDetailData = True     'Multi Column 으로 정의 시 2개이상의 컬럼이 DetailData 로 정의되어야 한다 

            Me.Open("PR1120_NG_g30", p)

        End With

        With g40
            p.Add("@color", "투명")
            'Master 부분
            .GridColumn("PART_BC").IsMasterKey = True
            .GridColumn("TITLE").IsMasterKey = True

            'Detail 부분
            .GridColumn("NG_CD").IsDetailKey = True
            .GridColumn("ng_qty").IsDetailData = True     'Multi Column 으로 정의 시 2개이상의 컬럼이 DetailData 로 정의되어야 한다

            Me.Open("PR1120_NG_g40", p)
        End With

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

    Private Sub save_chart4_Click(sender As System.Object, e As System.EventArgs) Handles save_chart4.Click
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
                    ChartControl4.ExportToImage(savefile.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                Case ".gif"
                    ChartControl4.ExportToImage(savefile.FileName, System.Drawing.Imaging.ImageFormat.Gif)
                Case ".bmp"
                    ChartControl4.ExportToImage(savefile.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
                Case Else
                    MsgBox("지정된 그림파일 형식이 아니거나 잘못된 형식입니다.")
            End Select
            MsgBox(savefile.FileName + "에 저장되었습니다.")
        End If
    End Sub



End Class
