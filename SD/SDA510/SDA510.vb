Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class SDA510

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Open

                If Not CheckRequired(co_cd, plan_dt, fac_cd, day_cnt) Then
                    Exit Sub
                End If
                Me.Open_Form()

            Case MenuType.Save
                If Not CheckRequired(co_cd, plan_dt, fac_cd, day_cnt) Then
                    Exit Sub
                End If

                If MyBase.Save() Then
                    Me.Open_Form()
                End If

                'Case MenuType.Delete
                'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

                'Case MenuType.New

                '    If g10.RowCount - 1 < 0 Then
                '        Me.Open_Form()
                '    End If
                '    Me.Disp_Data()
                '    g10.AddNewRow()
                'Me.WorkSets("mmb100_g10").AddNew()  '특정Workset 신규처리

                'Case MenuType.Print
                ' Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Public Sub Open_Form()

        '화면 컬럼의 생성
        Me.Init_Title3()
        Me.Disp_Data()

    End Sub

    Private Sub Init_Title3()

        '1. 컬럼배열을 만든다
        Dim frDt As Date = plan_dt.Text
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
            'Master 부분
            g10.GridColumn("co_cd").IsMasterKey = True
            g10.GridColumn("fac_cd").IsMasterKey = True
            g10.GridColumn("cust_cd").IsMasterKey = True
            g10.GridColumn("itm_id").IsMasterKey = True
            g10.GridColumn("cust_nm").IsMasterData = True
            g10.GridColumn("model_cd").IsMasterData = True
            g10.GridColumn("color_cd").IsMasterData = True
            g10.GridColumn("itm_cd").IsMasterData = True
            g10.GridColumn("itm_nm").IsMasterData = True

            g10.GridColumn("tot_qty").IsMasterData = True

            'Detail 부분
            g10.GridColumn("plan_dt").IsDetailKey = True
            g10.GridColumn("plan_qty").IsDetailData = True

            MyBase.Open()

            '화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다
            g10.GridColumn("co_cd").DefaultText = co_cd.Text
            g10.GridColumn("fac_cd").DefaultText = fac_cd.Text
            'g10.GridColumn("cust_cd").DefaultText = cust_cd.Text

        Catch ex As Exception

            MessageInfo(ex, "Disp_Data()")

        End Try
    End Sub

    Private Sub g10_AddedRow(ByVal sender As Object, ByVal RowIndex As Integer) Handles g10.AddedRow
        g10.Text("co_cd", g10.RowIndex) = co_cd.Text
        g10.Text("fac_cd", g10.RowIndex) = fac_cd.Text
    End Sub

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        If ColumnName.StartsWith("2") Then
            Dim sum As Decimal
            For i As Integer = 0 To g10.ColumnCount - 1
                If g10.FieldName(i).StartsWith("2") Then

                    sum += g10.ToDec(g10.FieldName(i))

                End If
            Next
            g10.Text("tot_qty") = sum
        End If
    End Sub

End Class
