Imports Base7
Imports Base7.Shared
Imports DevExpress.XtraCharts
Imports System.Data
Imports System.Windows.Forms
Imports System.Drawing


Public Class PRTR2120_DAY
    Dim p As New OpenParameters
    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Open()
        ng_g10.Visible = False
        g20.Visible = True

        p.Add("@base_dt", base_dt.Text)
        p.Add("@gong_cd", gong_cd.Text)
        p.Add("@fac_cd", fac_cd.Text)

        sbchart(ChartControl1.Series(0), "PRTR2120_DAY_g10", p, "일 생산량")
        sbchart2(ChartControl2.Series(0), "PRTR2120_DAY_g10", p, "일 수율")

        sbchart3(ChartControl3.Series(0), "PRTR2120_MONTH", p, "월 생산량")
        sbchart4(ChartControl4.Series(0), "PRTR2120_MONTH", p, "월 수율")

        If fac_cd.Text = "1공장" Then
            fac_cd.TextForeColor = Color.Red
            fac_cd.TextBackColor = Color.Red
        End If

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                
                Me.Open()
                ng_g10.Visible = False
                g20.Visible = True

                p.Add("@base_dt", base_dt.Text)
                p.Add("@gong_cd", gong_cd.Text)
                p.Add("@fac_cd", fac_cd.Text)

                sbchart(ChartControl1.Series(0), "PRTR2120_DAY_g10", p, "일 생산량")
                sbchart2(ChartControl2.Series(0), "PRTR2120_DAY_g10", p, "일 수율")

                sbchart3(ChartControl3.Series(0), "PRTR2120_MONTH", p, "월 생산량")
                sbchart4(ChartControl4.Series(0), "PRTR2120_MONTH", p, "월 수율")
            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Public Sub sbchart(ByVal Series As Series, ByVal WorkSetCode As String, ByVal P As OpenParameters, ByVal series_Name As String)  '일 생산량
        Dim dSet As DataSet, dRows As DataRowCollection, dRow As DataRow   ' SMK
        dSet = Me.OpenDataSet(WorkSetCode, P)
        dRows = dSet.Tables(0).Rows
        Series.Points.Clear()
        Series.Name = series_Name
        For Each dRow In dRows
            Dim value As Double = 0
            If ToStr(dRow("PR_QTY")) = "" Then    ' 양품수량
                value = 0
            Else
                value = dRow("PR_QTY")
            End If
            Dim point As New SeriesPoint(ToStr(dRow("MC_NM")), value)   '하단제목
            Series.Points.Add(point)
        Next

    End Sub

    Public Sub sbchart2(ByVal Series As Series, ByVal WorkSetCode As String, ByVal P As OpenParameters, ByVal series_Name As String) '일 수율 
        Dim dSet As DataSet, dRows As DataRowCollection, dRow As DataRow   ' SMK
        dSet = Me.OpenDataSet(WorkSetCode, P)
        dRows = dSet.Tables(0).Rows
        Series.Points.Clear()
        Series.Name = series_Name
        For Each dRow In dRows
            Dim value As Double = 0
            If ToStr(dRow("SU_RATE")) = "" Then    ' 수율 수치(%)
                value = 0
            Else
                value = dRow("SU_RATE")
            End If
            Dim point As New SeriesPoint(ToStr(dRow("MC_NM")), value)   '하단제목
            Series.Points.Add(point)
        Next
    End Sub

    Public Sub sbchart3(ByVal Series As Series, ByVal WorkSetCode As String, ByVal P As OpenParameters, ByVal series_Name As String) '월 생산량
        Dim dSet As DataSet, dRows As DataRowCollection, dRow As DataRow
        dSet = Me.OpenDataSet(WorkSetCode, P)
        dRows = dSet.Tables(0).Rows
        Series.Points.Clear()
        Series.Name = series_Name
        Series.Label.Visible = False   '151027 레이블 삭제 

        For Each dRow In dRows
            Dim value As Double = 0
            If ToStr(dRow("PR_QTY")) = "" Then    ' 양품수량
                value = 0
            Else
                value = dRow("PR_QTY")
            End If
            Dim point As New SeriesPoint(ToStr(dRow("PR_DT")), value)   '하단제목
            Series.Points.Add(point)
        Next

    End Sub

    Public Sub sbchart4(ByVal Series As Series, ByVal WorkSetCode As String, ByVal P As OpenParameters, ByVal series_Name As String) '월 수율 
        Dim dSet As DataSet, dRows As DataRowCollection, dRow As DataRow
        dSet = Me.OpenDataSet(WorkSetCode, P)
        dRows = dSet.Tables(0).Rows
        Series.Points.Clear()
        Series.Name = series_Name
        Series.Label.Visible = False   '151027 레이블 삭제 

        For Each dRow In dRows
            Dim value As Double = 0
            If ToStr(dRow("SU_RATE")) = "" Then    ' 수율
                value = 0
            Else
                value = dRow("SU_RATE")
            End If
            Dim point As New SeriesPoint(ToStr(dRow("PR_DT")), value)   '하단제목
            Series.Points.Add(point)
        Next
    End Sub


    Private Sub img_save1_Click_1(sender As System.Object, e As System.EventArgs) Handles img_save1.Click
        Dim savefile As SaveFileDialog = New SaveFileDialog

        savefile.InitialDirectory = "C:\"
        savefile.Title = "Save Chart Image"
        savefile.DefaultExt = "jpg"
        savefile.Filter = "JPEG(*.jpg)|*.jpg|Bitmap (*.bmp)|*.bmp|GIF (*.gif)|*.gif|All Files (*.*)|*.*"
        savefile.FilterIndex = 0
        savefile.RestoreDirectory = True

        If savefile.ShowDialog() = DialogResult.OK Then
            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.RichText)

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

    Private Sub img_save2_Click(sender As System.Object, e As System.EventArgs) Handles img_save2.Click
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

    Private Sub img_save3_Click(sender As System.Object, e As System.EventArgs) Handles img_save3.Click
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

    Private Sub img_save4_Click(sender As System.Object, e As System.EventArgs) Handles img_save4.Click
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

    '151130smk 김명환 추가요청 : 더블클릭했을때, 상세 불량유형 확인
    Private Sub g10_DoubleClick(sender As Object, e As System.EventArgs) Handles g10.DoubleClick

        ng_g10.Visible = True
        g20.Visible = False

        Dim p As New OpenParameters

        p.Add("@base_dt", base_dt.Text)
        p.Add("@gong_cd", gong_cd.Text)
        p.Add("@fac_cd", fac_cd.Text)
        p.Add("@mc_cd", g10.Text("MC_CD", g10.RowIndex))

        Me.Open("prtr1120_g10_ng", p)

    End Sub
End Class
