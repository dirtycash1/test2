Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class MMR110

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open_Form()
                MyBase.Open()
            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub


    Private Sub Disp_Data()
        Try
            'Master 부분
            g10.GridColumn("bs_cd").IsMasterData = True
            g10.GridColumn("itm_id").IsMasterData = True
            g10.GridColumn("itm_cd").IsMasterKey = True
            g10.GridColumn("itm_nm").IsMasterData = True
            g10.GridColumn("itm_bc").IsMasterData = True
            g10.GridColumn("grp1_cd").IsMasterData = True
            g10.GridColumn("grp2_cd").IsMasterData = True
            g10.GridColumn("wgt").IsMasterData = True
            g10.GridColumn("spec").IsMasterData = True
            g10.GridColumn("cust_cd").IsMasterData = True
            g10.GridColumn("cust_nm").IsMasterData = True
            g10.GridColumn("stock_qty1").IsMasterData = True
            g10.GridColumn("stock_qty2").IsMasterData = True
            g10.GridColumn("stock_qty3").IsMasterData = True
            g10.GridColumn("stock_qty4").IsMasterData = True
            g10.GridColumn("stock_qty5").IsMasterData = True
            g10.GridColumn("stock_qty6").IsMasterData = True
            g10.GridColumn("stock_qty7").IsMasterData = True
            g10.GridColumn("stock_tot").IsMasterData = True
            g10.GridColumn("dlv_qty").IsMasterData = True
            g10.GridColumn("avg3_qty").IsMasterData = True
            g10.GridColumn("use_qty").IsMasterData = True
            g10.GridColumn("fore_stock").IsMasterData = True
            g10.GridColumn("ltm").IsMasterData = True


            'Detail 부분
            g10.GridColumn("std_dt").IsDetailKey = True
            g10.GridColumn("qty").IsDetailData = True



        Catch ex As Exception
            MessageInfo(ex, "Disp_Data()")
        End Try
    End Sub


    Private Sub to_dt_TextChanged(sender As Object, e As System.EventArgs) Handles to_dt.TextChanged
        fr_dt.Text = DateAdd(DateInterval.Month, -3, CDate(to_dt.Text))
    End Sub

    Private Sub open_show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles open_show.Click
        Me.Open_Form()
        MyBase.Open()
    End Sub

    Public Sub Open_Form()

        '화면 컬럼의 생성
        Me.Init_Title()
        Me.Disp_Data()

    End Sub
    Private Sub Init_Title()

        '1. 컬럼배열을 만든다
        Dim frDt As Date = to_dt.Text
        Dim toDt As Date = Format(DateAdd(DateInterval.Day, CInt(day.Text), frDt), "yyyy-MM-dd")

        Dim cnt As Integer = DateDiff(DateInterval.Day, frDt, toDt)
        Dim arr(1, 0) As String, colNm As String, colFNm As String, Week_nm As String
        For i = 0 To cnt - 1
            ReDim Preserve arr(1, i)     'Array를 증가시킨다

            Week_nm = Mid(WeekdayName(Weekday(DateAdd(DateInterval.Day, i, frDt))), 1, 1)


            colNm = Format(DateAdd(DateInterval.Day, i, frDt), "MM-dd" + "(" + Week_nm + ")")
            colFNm = Format(DateAdd(DateInterval.Day, i, frDt), "yyyy-MM-dd")

            arr(0, i) = colFNm            'FieldName

            arr(1, i) = colNm             'Title
        Next

        '2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
        ' Ex) g10.InsertColumn("A", arr, "B")
        '     "A" 컬럼이후에 삽입된다
        '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
        '     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다

        g10.InsertArrayColumns("fore_stock", arr, "qty")

    End Sub


End Class
