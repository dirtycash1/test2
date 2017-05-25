Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class PAR100

    Private Sub PAR100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'XtraTabPage3.PageVisible = False

    End Sub


    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            'Case MenuType.Open

            'Me.New_Form()

            Case MenuType.Save

                If Me.Save() Then
                    Me.Open()
                End If

            Case MenuType.New

                'Me.New_Form()

            Case Else

                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    Private Sub Open_g80()
        Me.Init_Title()
        Me.Disp_Data()
    End Sub


    '출력
    Private Sub but5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but5.Click
        Dim p As OpenParameters = New OpenParameters
        p.Add("@pay_mon", g10.Text("pay_mon"))
        p.Add("@pay_bc", g10.Text("pay_bc"))
        p.Add("@bs_cd", g10.Text("bs_cd"))
        p.Add("@dept_cd", g10.Text("dept_cd"))
        p.Add("@emp_no", g10.Text("emp_no"))
        p.Add("@prt_dt", Date.Today)

        'EXEC PAR102_Print  @pay_mon, @pay_bc, @bs_cd, @dept_cd, @emp_no, @prt_dt
        System7.ReportView.LoadView("PAR100", "", "par100_print", p) '퇴직계산서

    End Sub

    '급상여가져오기
    Private Sub but3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but3.Click
        If emp_no.Text = "" Then
            Exit Sub
        End If
        g10.Text("chk1") = "1"
        If Me.Save Then
            If MessageYesNo("급여내역 가져오기 하시겠습니까?") = MsgBoxResult.No Then
                Exit Sub
            End If
            Me.Open("par100_pay")

            g50.Open()
            g60.Open()
            g70.Open()
            Me.Open_g80()

            XtraTabControl1.SelectedTabPageIndex = 1

        End If
    End Sub

    '계산
    Private Sub but4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but4.Click
        If emp_no.Text = "" Then
            Exit Sub
        End If
        g10.Text("chk1") = "1"

        If Me.Save Then
            If MessageYesNo("퇴직금을 계산하시겠습니까?") = MsgBoxResult.No Then
                Exit Sub
            End If
            Me.Open("par100_work")

            Dim empNo As String
            empNo = g10.Text("emp_no")

            Me.Open()

            g10.Find("emp_no=" + empNo)

            XtraTabControl1.SelectedTabPageIndex = 0

        End If
    End Sub


    'Case 2
    Private Sub Init_Title()

        '1. 컬럼배열을 만든다
        Dim dSet As DataSet = Me.OpenDataSet("par100_g80_title")
        If IsEmpty(dSet) Then
            'MessageInfo("조회 할 Data가 없습니다")
            'g10.Init()
            Exit Sub
        End If

        Dim arr(1, 0) As String, inx As Integer = 0, fldNm As String, title As String, frDt As Date, toDt As Date, days As Integer
        For Each dRow As DataRow In dSet.Tables(0).Rows
            ReDim Preserve arr(1, inx)      'Array를 증가시킨다

            frDt = Nothing
            toDt = Nothing

            fldNm = dRow("app_mon")
            If IsDate(dRow("dfr_dt")) Then frDt = ToDateStr(dRow("dfr_dt"))
            If IsDate(dRow("dto_dt")) Then toDt = ToDateStr(dRow("dto_dt"))

            If frDt <> Nothing And toDt <> Nothing Then
                days = DateDiff(DateInterval.Day, frDt, toDt) + 1
                title = Format(frDt, "MM-dd") + " ~ " + Format(toDt, "MM-dd") + " (" & days.ToString & ")"
                'title = FormatDateTime(frDt, DateFormat.ShortDate) + " ~ " + FormatDateTime(toDt, DateFormat.ShortDate) + " (" & days.ToString & ")"

                arr(0, inx) = fldNm           'FieldName 으로 사용된다
                arr(1, inx) = title           'Title로 사용된다
            End If

            inx += 1
        Next

        g80.InsertArrayColumns(Nothing, arr, "com_amt")

    End Sub


    Private Sub Disp_Data()
        Try
            'Master 부분
            With g80
                .GridColumn("pay_mon").IsMasterKey = True
                .GridColumn("emp_no").IsMasterKey = True
                .GridColumn("grp_bc").IsMasterKey = True
                .GridColumn("pay_cd").IsMasterKey = True
                .GridColumn("pay_nm").IsMasterData = True
                .GridColumn("tot_amt").IsMasterData = True


                'Detail 부분
                .GridColumn("app_mon").IsDetailKey = True
                .GridColumn("com_amt").IsDetailData = True

            End With

            g80.Open()

        Catch ex As Exception

            MessageInfo(ex, "Disp_Data()")

        End Try
    End Sub


    Private Sub g10_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g10.AfterMoveRow

        Me.Open_g80()

    End Sub

End Class
