Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class PPC104

    Private Sub PPC101_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Me.Open()

    End Sub


    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            'Case MenuType.New

            Case MenuType.Open
                '화면 컬럼의 생성
                Me.Init_Title()

                'Case MenuType.Save

                'Case MenuType.Delete

            Case Else

                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    Private Sub Init_Title()

        '1. 컬럼배열을 만든다
        Dim dSet As DataSet = Me.OpenDataSet("ppc104_title")
        If IsEmpty(dSet) Then
            MessageInfo("조회 할 Data가 없습니다")
            'g10.Init()
            Exit Sub
        End If

        Dim arr(1, 0) As String, inx As Integer = 0
        For Each dRow In dSet.Tables(0).Rows
            ReDim Preserve arr(1, inx)      'Array를 증가시킨다

            arr(0, inx) = dRow(0)           'FieldName 으로 사용된다
            arr(1, inx) = dRow(1)           'Title로 사용된다

            inx += 1
        Next

        '2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
        ' Ex) g10.InsertColumn("A", arr, "B")
        '     "A" 컬럼이후에 삽입된다
        '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
        '     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다

        g10.InsertArrayColumns("itm_bc", arr, "qty")


        If arr(1, 0) = "" Then
            g10.Clear()
            g10.Init()
        Else
            g10.InsertArrayColumns("ty_nm", arr, "qty")
            Disp_Data()

            g10.AllowSort = True
            g10.AllowGroup = True
            g10.AllowFilter = True
        End If


        '''''''날짜 형식 타이틀 만들때 쓰인다.
        'If CheckRequired(fr_dt, to_dt) = False Then Exit Sub

        ''1. 컬럼배열을 만든다
        'Dim frDt As Date = fr_dt.Text
        'Dim toDt As Date = to_dt.Text

        'Dim cnt As Integer = DateDiff(DateInterval.Day, frDt, toDt)
        'Dim arr(1, 0) As String, colNm As String, colFNm As String, Week_nm As String



        'For i = 0 To cnt - 1
        '    ReDim Preserve arr(1, i)     'Array를 증가시킨다

        '    Week_nm = Mid(WeekdayName(Weekday(DateAdd(DateInterval.Day, i, frDt))), 1, 1)

        '    colNm = Format(DateAdd(DateInterval.Day, i, frDt), "MM-dd" + "(" + Week_nm + ")")
        '    colFNm = Format(DateAdd(DateInterval.Day, i, frDt), "yyyy-MM-dd")
        '    arr(0, i) = colFNm            'FieldName
        '    arr(1, i) = colNm             'Title
        'Next

        ''2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
        '' Ex) g10.InsertColumn("A", arr, "B")
        ''     "A" 컬럼이후에 삽입된다
        ''     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
        ''     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다

        'If arr(1, 0) = "" Then
        '    g10.Clear()
        '    g10.Init()
        'Else
        '    g10.InsertArrayColumns("ty_nm", arr, "qty")
        '    Disp_Data()
        'End If

    End Sub



    Private Sub Disp_Data()
        Try

            'Master 부분
            g10.GridColumn("itm_cd").IsMasterKey = True
            g10.GridColumn("itm_nm").IsMasterData = True
            g10.GridColumn("itm_bc").IsMasterData = True
            '' g10.GridColumn("sum_qty").IsMasterData = True


            'Detail 부분
            g10.GridColumn("wc_cd").IsDetailKey = True
            g10.GridColumn("qty").IsDetailData = True

            MyBase.Open()
            g10.AllowSort = False

        Catch ex As Exception
            MessageInfo(ex, "Disp_Data()")
        End Try
    End Sub



End Class
