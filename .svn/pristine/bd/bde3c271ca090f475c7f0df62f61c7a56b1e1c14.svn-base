Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data
Imports DevExpress.XtraCharts

Public Class ESK360

	Private Property Save_Before As Boolean

	Private Sub ESK360_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


		form_init()

		Me._Open()

    End Sub

	Private Sub form_init()
        tabcontroll6.SelectedTabPageIndex = 0
		 SplitContainer3.SplitterDistance = 160
		 SplitContainer4.SplitterDistance = 160

		 SplitContainer2.SplitterDistance = 160
		 SplitContainer5.SplitterDistance = 160
		 SplitContainer6.SplitterDistance = 160

    End Sub

	Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
		Select Case mty
			Case MenuType.Open

				'Me.union_yn.Text = "0"
				'MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
				Me._Open()


			Case MenuType.Save
				'If Save_Before() Then
				'    ' Me.Save_g10()

				'    If MyBase.Save() Then

				'        ' MyBase.Open()
				'    End If
				'End If
				'Case MenuType.New
				'    g10.AddNewRow()

			Case Else
				MyBase.MenuButton_Click(mty)		'나머지는 기본기능에 맡긴다

		End Select
	End Sub

	Private m_line As Integer


    Private Sub _Open()
        If Not CheckRequired(co_cd, to_mon, week_cnt, fr_dt, to_dt) Then
            Exit Sub
        End If

        Me.OpenChart("ESK360_Query_mon_1", 0, g10, chart1, char1_2)
        Me.OpenChart_M2()
        Me.OpenChart_M3()
        Me.OpenChart("ESK360_Query_w1", ToDec(week_cnt.Text), g40, chart4)
        Me.OpenChart("ESK360_Query_w2", ToDec(week_cnt.Text), g50, chart5)

        Me.tmp_OpenChart("EIT10100", "esk360_tmp_eis_t10_Query", "ESK360_Query_w1", ToDec(week_cnt.Text), tmp_g40, tmp_chart4)
        Me.tmp_OpenChart("EIT10200", "esk360_tmp_eis_t10_Query2", "ESK360_Query_w2", ToDec(week_cnt.Text), tmp_g50, tmp_chart5)

        Me.SaleResultFormOpen()

        '요약손익
        Me.Open("esk360_g60")

    End Sub


    Private Sub tmp_OpenChart(ByVal type As String, ByVal wsnm2 As String, ByVal wsnm As String, ByVal weekcnt As Integer, ByVal grid As eGrid, ByVal chart As ChartControl, Optional ByVal chart2 As ChartControl = Nothing)
        Try
            Dim param As OpenParameters = New OpenParameters
            param.Add("@co_cd", co_cd.Text)
            param.Add("@to_mon", to_mon.Text)
            param.Add("@week_cnt", weekcnt)

            Dim dSet1 As DataSet = Me.OpenDataSet(wsnm, param)
            'Dim dSet2 As DataSet = Me.OpenDataSet("ESK410_tab1_chart2", param)

            If chart2 Is Nothing = False Then
                char1_2.Series(0).Points.Clear()
                sbchart(char1_2.Series(0), dSet1.Tables(3))
                char1_2.Refresh()
            End If

            Me.Chart(chart, dSet1, "ty", "amt")

            param.Add("@schType", type)

            Dim dSet2 As DataSet = Me.OpenDataSet(wsnm2, param)

            'Me.Chart(chart1_2, dSet1.Tables(1),"ty","amt")
            grid.DataSource = dSet2.Tables(0)
        Catch
            'ChartControl1.Series.Clear()
        End Try
    End Sub


	 Private Sub OpenChart(ByVal wsnm As String ,ByVal weekcnt As Integer, ByVal grid as eGrid, ByVal chart As ChartControl , Optional ByVal  chart2 As ChartControl=Nothing )
		Try
			Dim param As OpenParameters = New OpenParameters
			param.Add("@co_cd", co_cd.Text)
			param.Add("@to_mon", to_mon.Text)
			param.Add("@week_cnt", weekcnt)

			Dim dSet1 As DataSet = Me.OpenDataSet(wsnm, param)
			'Dim dSet2 As DataSet = Me.OpenDataSet("ESK410_tab1_chart2", param)
			
            If chart2 Is Nothing = False Then
                char1_2.Series(0).Points.Clear()
                sbchart(char1_2.Series(0), dSet1.Tables(3))
                char1_2.Refresh()
            End If
				
			Me.chart(chart, dSet1, "ty", "amt")

			'Me.Chart(chart1_2, dSet1.Tables(1),"ty","amt")
			grid.DataSource = dSet1.Tables(0)
		Catch
			'ChartControl1.Series.Clear()
		End Try
	End Sub

	Public Sub sbchart(ByVal Series As DevExpress.XtraCharts.Series, ByVal dt As DataTable  )
		dim dRows As DataRowCollection, dRow As DataRow
		dRows = dt.Rows
		Series.Points.Clear()
		Series.Name = "매출비율"
		For Each dRow In dRows
			Dim value As Double = 0
			If dRow("amt")=0 then
				Continue For
			End If
			If ToStr(dRow("amt")) = "" Then
				value = 0
			Else
				value = dRow("amt")
			End If
            Dim point As New SeriesPoint(ToStr(dRow("ty")), value)
			Series.Points.Add(point)
		Next
	End Sub

	 

	 Private Sub OpenChart_M2()
		Try
			Dim param As OpenParameters = New OpenParameters
			param.Add("@co_cd", co_cd.Text)
			param.Add("@to_mon", to_mon.Text)

			Dim dSet1 As DataSet = Me.OpenDataSet("ESK360_Query_mon_2", param)
			  
			Me.chart(chart2, dSet1, "ty", "amt")
 
			g20.DataSource = dSet1.Tables(0)
		Catch
			'ChartControl1.Series.Clear()
		End Try
	End Sub

	 Private Sub OpenChart_M3()
		Try
			Dim param As OpenParameters = New OpenParameters
			param.Add("@co_cd", co_cd.Text)
			param.Add("@to_mon", to_mon.Text)

			Dim dSet1 As DataSet = Me.OpenDataSet("ESK360_Query_mon_3", param)
			  
			Me.chart3Setting(chart3, dSet1)
 
			g30.DataSource = dSet1.Tables(0)
		Catch
			'ChartControl1.Series.Clear()
		End Try
	End Sub

  Private Sub Chart(ByVal ChartControls As DevExpress.XtraCharts.ChartControl, ByVal ds As DataSet, ByVal Argnm As String, ByVal ValNm As String)


			For i As Integer = 0 To 1
				Dim nm As String = ""
				If i = 0 Then
					nm = "계획"
				Else
					nm = "실적"
				End If
			'	Dim dtRtn As New DataTable
				'dtRtn =gSub_LinqToDataTable(dTable,"p_r",ty)
				'ChartControls.Series(i).DataSource=Nothing
				ChartControls.Series(i).Name = nm
				ChartControls.Series(i).DataSource = ds.Tables(i + 1)
				ChartControls.Series(i).ArgumentDataMember = Argnm ' "ty"
				ChartControls.Series(i).ValueDataMembers.AddRange(New String() {ValNm})	'"amt"})
			Next

	End Sub

	Private Sub chart3Setting(ByVal ChartControls As DevExpress.XtraCharts.ChartControl, ByVal ds As DataSet)


			For i As Integer = 0 To 3
				Dim nm As String = ""
				If i = 0 Then
					nm = "재료비"
				Elseif i=1 then
					nm = "제조경비"
				Elseif i=2 then
					nm = "노무비"
				Elseif i=3 then
					nm = "재료비"
				End If
			'	Dim dtRtn As New DataTable
				'dtRtn =gSub_LinqToDataTable(dTable,"p_r",ty)
				'ChartControls.Series(i).DataSource=Nothing
				ChartControls.Series(i).Name = nm
				ChartControls.Series(i).DataSource = ds.Tables(i + 1)
				ChartControls.Series(i).ArgumentDataMember = "type" ' "ty"
				ChartControls.Series(i).ValueDataMembers.AddRange(New String() {"amt"})	'"amt"})
			Next

	End Sub

	Private m_OpenStop As Boolean = True


	Private m_StopOpen As Boolean

	'Private Sub g10_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g10.AfterMoveRow

	'    Me._Open_Deteil()

	'End Sub





	'Private Sub btnbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
	'    For j As Integer = 0 To g20.RowCount - 1
	'        If g20.Text("blno", j) <> "" And g20.Text("blsq", j) <> "" Then
	'            MessageBox.Show("이미 BL이 처리된 건입니다.", "확인", MessageBoxButtons.OK)
	'            Exit Sub
	'        End If
	'    Next
	'    Dim menuName As String = "SEP230"
	'    Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
	'    ctr.Open2(g20.Text("db_no", 0))
	'End Sub

	Private Sub weekcnt_TextChanging( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles week_cnt.TextChanging
		If week_cnt.Text="" then
			Exit Sub
		End If
		Dim p As New OpenParameters
        p.Add("@co_cd", co_cd.Text)
        p.Add("@mon", to_mon.Text)
		p.Add("@weekcnt", week_cnt.Text)
		
        Dim dSet As DataSet = MyBase.OpenDataSet("pna250_weekday", p)
		If dSet.Tables(0).Rows.Count>0 Then
            'If MessageYesNo("실적년월,주차로 등록된 내용이 존재합니다. 삭제하고, 재조회 하시겠습니까?") = MsgBoxResult.No Then
            '    Exit Sub
            'End If
			fr_dt.Text=dSet.Tables(0).Rows(0)(0)
			to_dt.Text=dSet.Tables(0).Rows(0)(1)
			tot_week.Text=dSet.Tables(0).Rows(0)(2)
        End If
End Sub


Private Sub SplitContainer7_SplitterMoved( ByVal sender As System.Object,  ByVal e As System.Windows.Forms.SplitterEventArgs) Handles SplitContainer7.SplitterMoved

End Sub

Private Sub SplitContainer8_SplitterMoved( ByVal sender As System.Object,  ByVal e As System.Windows.Forms.SplitterEventArgs) 
    End Sub

#Region "매출계획대비실적"


    Private Sub SaleResultFormOpen()


        For i = 2 To g50_1.ColumnCount - 1
            g50_1.ColumnVisible(i) = True
        Next

        Me.OpenChart()
        Me.OpenChartItem()
        Me.OpenChartCust()
        Me.OpenChartinout()
        Me.OpenDay()

        Dim tmp_to_dt = Convert.ToInt32(to_dt.Text.Substring(8, 2))

        For i = tmp_to_dt + 2 To g50_1.ColumnCount - 1
            g50_1.ColumnVisible(i) = False
        Next


    End Sub

    Private Sub OpenChart()
        Try
            Dim param As OpenParameters = New OpenParameters
            param.Add("@co_cd", co_cd.Text)
            'param.Add("@o_fac_cd", o_fac_cd.Text)
            param.Add("@mon", to_mon.Text.Substring(0, 7))
            param.Add("@dt", to_dt.Text)

            Dim dSet1 As DataSet = Me.OpenDataSet("esk360_tab1_Query", param)
            'Dim dSet2 As DataSet = Me.OpenDataSet("ESK410_tab1_chart2", param)

            Me.Chart(chart1_1, dSet1.Tables(0), "ty", "amt")
            If dSet1.Tables(0).rows.Count = 0 Then
                chart1_2.Series.Clear()
                Return
            End If

            Me.Chart(chart1_2, dSet1.Tables(1), "ty", "amt")
            g10_1.DataSource = dSet1.Tables(2)
        Catch
            'ChartControl1.Series.Clear()
        End Try
    End Sub

    Private Sub OpenDay()
        Try
            Dim param As OpenParameters = New OpenParameters
            param.Add("@co_cd", co_cd.Text)
            'param.Add("@o_fac_cd", o_fac_cd.Text)
            param.Add("@mon", to_dt.Text.Substring(0, 10))

            Dim dSet1 As DataSet = Me.OpenDataSet("esk360_tab1_query_day", param)
            'Dim dSet2 As DataSet = Me.OpenDataSet("ESK410_tab1_chart2", param)

            Me.Chart(chart5_1, dSet1.Tables(0), "ty", "amt")
            If dSet1.Tables(0).rows.Count = 0 Then
                chart5_2.Series.Clear()
                Return
            End If

            chart5_2.Series(0).DataSource = Nothing
            chart5_2.Series(0).Name = "day"
            chart5_2.Series(0).DataSource = dSet1.Tables(1)
            chart5_2.Series(0).ArgumentDataMember = "day" ' "ty"
            chart5_2.Series(0).ValueDataMembers.AddRange(New String() {"amt"}) '"amt"})

            'Me.Chart(chart5_2, dSet1.Tables(1),"ty","amt")
            g50_1.DataSource = dSet1.Tables(2)
        Catch
            'ChartControl1.Series.Clear()
        End Try
    End Sub
    Private Sub OpenChartItem()
        Try
            'Dim ct As new DevExpress.XtraCharts.ChartTitle()
            'ct.Font = New System.Drawing.Font("맑은 고딕", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
            'ct.Text="품목별 매출계획대비실적"
            'ct.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
            ''char2_1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ct})
            'char2_1.Titles.Clear
            'char2_1.Titles.Add(ct)

            Dim param As OpenParameters = New OpenParameters
            param.Add("@co_cd", co_cd.Text)
            'param.Add("@o_fac_cd", o_fac_cd.Text)
            param.Add("@mon", to_mon.Text.Substring(0, 7))
            param.Add("@dt", to_dt.Text)
            param.Add("@item_ty", item_ty.Text.Replace(",", "_").Replace("'", ""))

            Dim dSet1 As DataSet = Me.OpenDataSet("esk360_tab1_query_item", param)
            'Dim dSet2 As DataSet = Me.OpenDataSet("ESK410_tab1_chart2", param)

            Me.Chart(char2_1, dSet1.Tables(0), "Series", "amt")
            If dSet1.Tables(0).rows.Count = 0 Then
                chart1_2.Series.Clear()
                Return
            End If

            Me.Chart_Item(chart2_2, dSet1.Tables(1), "series", "amt")
            g20_1.DataSource = dSet1.Tables(2)
        Catch
            'ChartControl1.Series.Clear()
        End Try
    End Sub

    Private Sub OpenChartCust()
        Try
            'Dim ct As new DevExpress.XtraCharts.ChartTitle()
            'ct.Font = New System.Drawing.Font("맑은 고딕", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
            'ct.Text="고객사별 매출계획대비실적"
            'ct.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
            'char2_1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ct})
            'chart3_1.Titles.Clear
            'chart3_1.Titles.Add(ct)

            Dim param As OpenParameters = New OpenParameters
            param.Add("@co_cd", co_cd.Text)
            'param.Add("@o_fac_cd", o_fac_cd.Text)
            param.Add("@mon", to_mon.Text.Substring(0, 7))
            param.Add("@dt", to_dt.Text)
            'param.Add("@cust_ty", cust_ty.Text.Replace(",","_/" ) )
            param.Add("@cust_ty", cust_ty.Text.Replace(",", "_").Replace("'", ""))

            Dim dSet1 As DataSet = Me.OpenDataSet("esk360_tab1_Query_cust", param)
            'Dim dSet2 As DataSet = Me.OpenDataSet("ESK410_tab1_chart2", param)

            Me.Chart(chart3_1, dSet1.Tables(0), "Series", "amt")
            If dSet1.Tables(0).rows.Count = 0 Then
                chart1_2.Series.Clear()
                Return
            End If

            Me.Chart_cust(chart3_2, dSet1.Tables(1), "series", "amt")
            g30_1.DataSource = dSet1.Tables(2)
        Catch
            'ChartControl1.Series.Clear()
        End Try
    End Sub

    Private Sub OpenChartinout()
        Try
            'Dim ct As new DevExpress.XtraCharts.ChartTitle()
            'ct.Font = New System.Drawing.Font("맑은 고딕", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
            'ct.Text="내수/수출별 매출계획대비실적"
            'ct.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
            'char2_1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ct})
            ''chart4_1.Titles.Clear
            ''chart4_1.Titles.Add(ct)

            Dim param As OpenParameters = New OpenParameters
            param.Add("@co_cd", co_cd.Text)
            'param.Add("@o_fac_cd", o_fac_cd.Text)
            param.Add("@mon", to_mon.Text.Substring(0, 7))
            param.Add("@dt", to_dt.Text)
            Dim dSet1 As DataSet = Me.OpenDataSet("esk360_tab1_Query_inout", param)
            'Dim dSet2 As DataSet = Me.OpenDataSet("ESK410_tab1_chart2", param)

            Me.Chart(chart4_1, dSet1.Tables(0), "Series", "amt")
            If dSet1.Tables(0).rows.Count = 0 Then
                chart1_2.Series.Clear()
                Return
            End If

            Me.Chart_inout(chart4_2, dSet1.Tables(1), "series", "amt")
            g40_1.DataSource = dSet1.Tables(2)
        Catch
            'ChartControl1.Series.Clear()
        End Try
    End Sub

    ''' <summary>
    ''' 데이터 테이블소스를 넘겨받아서 컬럼과 컬럼조회조건에 해당하는 결과를 데이터테이블로 넘겨준다
    ''' </summary>
    ''' <param name="pSourceDt">원본데이터를 소유한 데이터테이블</param>
    ''' <param name="pColNm">조건컬럼명</param>
    ''' <param name="pParam1">조건에 해당하는 실제값(스트링형)</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function gSub_LinqToDataTable(ByVal pSourceDt As DataTable, ByVal pColNm As String, ByVal pParam1 As String) As DataTable
        Try

            Dim dr = From rtndr In pSourceDt.AsEnumerable _
                     Where rtndr.Field(Of String)(pColNm) = pParam1 _
                     Select rtndr

            Return dr.CopyToDataTable

        Catch ex As Exception
            'MsgBox(ex.ToString)
            Return Nothing
        End Try
    End Function

    Private Sub Chart(ByVal ChartControls As DevExpress.XtraCharts.ChartControl, ByVal dTable As DataTable, ByVal Argnm As String, ByVal ValNm As String)

        If dTable.Rows.Count = 0 Then
        Else
            For i As Integer = 0 To 1
                Dim ty As String = ""
                If i = 0 Then
                    ty = "계획"
                Else
                    ty = "실적"
                End If
                Dim dtRtn As New DataTable
                dtRtn = gSub_LinqToDataTable(dTable, "p_r", ty)
                'ChartControls.Series(i).DataSource=Nothing
                ChartControls.Series(i).Name = ty
                ChartControls.Series(i).DataSource = dtRtn
                ChartControls.Series(i).ArgumentDataMember = Argnm ' "ty"
                ChartControls.Series(i).ValueDataMembers.AddRange(New String() {ValNm}) '"amt"})
            Next

        End If
    End Sub

    Private Sub Chart_Item(ByVal ChartControls As DevExpress.XtraCharts.ChartControl, ByVal dTable As DataTable, ByVal Argnm As String, ByVal ValNm As String)
        Dim ty As String = ""
        If item_ty.Text = "" Then
            item_ty.Text = "EI100EC,EI100OC,EI100EO,EI100OT"
        End If
        Dim tylist() As String = item_ty.Text.Split(",")
        ChartControls.Series(0).Visible = False
        ChartControls.Series(1).Visible = False
        ChartControls.Series(2).Visible = False
        ChartControls.Series(3).Visible = False

        For ii As Integer = 0 To tylist.Length - 1
            If tylist(ii).ToString.Replace("'", "") = "EI100EC" Then
                ty = "EGR"
            ElseIf tylist(ii).ToString.Replace("'", "") = "EI100OC" Then
                ty = "Oil C."

            ElseIf tylist(ii).ToString.Replace("'", "") = "EI100EO" Then
                ty = "EGR Pipe"

            ElseIf tylist(ii).ToString.Replace("'", "") = "EI100OT" Then
                ty = "기타"
            End If
            ChartControls.Series(ii).Visible = True
            ChartControls.Series(ii).Name = ty
            Dim dtRtn As New DataTable
            dtRtn = gSub_LinqToDataTable(dTable, "item", ty)

            ChartControls.Series(ii).DataSource = dtRtn
            ChartControls.Series(ii).ArgumentDataMember = Argnm ' "ty"
            ChartControls.Series(ii).ValueDataMembers.AddRange(New String() {ValNm}) '"amt"})
        Next
    End Sub

    Private Sub Chart_cust(ByVal ChartControls As DevExpress.XtraCharts.ChartControl, ByVal dTable As DataTable, ByVal Argnm As String, ByVal ValNm As String)
        Dim ty As String = ""



        ChartControls.Series(0).Visible = False
        ChartControls.Series(1).Visible = False
        ChartControls.Series(2).Visible = False
        ChartControls.Series(3).Visible = False

        If cust_ty.Text = "" Then
            cust_ty.Text = "EI110HMC,EI110KMC,EI110BMW,EI110OT"
        End If
        Dim tylist() As String = cust_ty.Text.Split(",")
        For ii As Integer = 0 To tylist.Length - 1
            If tylist(ii).ToString.Replace("'", "") = "EI110HMC" Then
                ty = "HMC"
            ElseIf tylist(ii).ToString.Replace("'", "") = "EI110KMC" Then
                ty = "KMC"

            ElseIf tylist(ii).ToString.Replace("'", "") = "EI110BMW" Then
                ty = "BMW"

            ElseIf tylist(ii).ToString.Replace("'", "") = "EI110OT" Then
                ty = "기타"
            End If
            ChartControls.Series(ii).Visible = True
            ChartControls.Series(ii).Name = ty
            Dim dtRtn As New DataTable
            dtRtn = gSub_LinqToDataTable(dTable, "item", ty)
            ChartControls.Series(ii).DataSource = dtRtn
            ChartControls.Series(ii).ArgumentDataMember = Argnm ' "ty"
            ChartControls.Series(ii).ValueDataMembers.AddRange(New String() {ValNm}) '"amt"})
        Next
    End Sub

    Private Sub Chart_inout(ByVal ChartControls As DevExpress.XtraCharts.ChartControl, ByVal dTable As DataTable, ByVal Argnm As String, ByVal ValNm As String)

        If dTable.Rows.Count = 0 Then
        Else
            For i As Integer = 0 To 1
                Dim ty As String = ""
                If i = 0 Then
                    ty = "내수"
                ElseIf i = 1 Then
                    ty = "수출"
                End If
                Dim dtRtn As New DataTable
                dtRtn = gSub_LinqToDataTable(dTable, "item", ty)
                'ChartControls.Series(i).DataSource=Nothing
                ChartControls.Series(i).Name = ty
                ChartControls.Series(i).DataSource = dtRtn
                ChartControls.Series(i).ArgumentDataMember = Argnm ' "ty"
                ChartControls.Series(i).ValueDataMembers.AddRange(New String() {ValNm}) '"amt"})
            Next

        End If
    End Sub
#End Region
End Class
