Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Parameter

Public Class MMR100_KRS2

    Private Sub MMR100_KRS2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Parameter.Login.UserKd = "SC700300" Then cust_cd.Enabled = False '외주사용자
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                '화면 컬럼의 생성
                Me.Init_Title()
                'Data Display
                Me.Disp_Data()

                'MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                '사용하려면 재정의 가능하다
            Case MenuType.Save
                'If MyBase.Save() Then
                ' MyBase.Open()
                'End If

            Case MenuType.Delete
                'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

            Case MenuType.New
                ' Me.WorkSets("mma100_g10").AddNew()  '특정Workset 신규처리

            Case MenuType.Print
                ' Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private startWHColumn As Integer

    Private Sub Init_Title()

        '1. 컬럼배열을 만든다
        Dim frDt As Date = std_dt.Text
        Dim toDt As Date = Format(DateAdd(DateInterval.Day, CInt(day_cnt.Text), frDt), "yyyy-MM-dd")

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

        g10.InsertArrayColumns("tot_qty", arr, "plan_qty")

    End Sub

    Private Sub Disp_Data()
        Try

            '/*************** 소요량 현황
            'Master 부분
            g10.GridColumn("itm_id").IsMasterKey = True
            g10.GridColumn("base_cd").IsMasterKey = True
            g10.GridColumn("itm_bc").IsMasterKey = True

            g10.GridColumn("itm_cd").IsMasterData = True
            g10.GridColumn("itm_nm").IsMasterData = True
            g10.GridColumn("model_cd").IsMasterData = True

            g10.GridColumn("stock_qty").IsMasterData = True
            g10.GridColumn("stock_qty2").IsMasterData = True
            g10.GridColumn("safe_qty").IsMasterData = True

            g10.GridColumn("tot_qty").IsMasterData = True

            'Detail 부분
            g10.GridColumn("plan_dt").IsDetailKey = True
            g10.GridColumn("plan_qty").IsDetailData = True

            MyBase.Open()
            g10.AllowSort = False
            g10.BestFitColumns()
            '화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다
            ' g10.GridColumn("std_dt").DefaultText = std_dt.Text

        Catch ex As Exception
            MessageInfo(ex, "Disp_Data()")
        End Try
    End Sub
End Class
