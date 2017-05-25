Imports Frame7
Imports Base7
Imports Base7.Shared

Imports System.Math

Public Class PPC100_KRS
    Private MoveCol As Boolean
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me._Open()
                tot_mh.TextAlign = Alignment.Right
                tot_mh.Text = Round(ToDec(have_mh.Text), 2) + Round(ToDec(acc_mh.Text), 2) - Round(ToDec(give_mh.Text), 2)
                loss.Text = Round(ToDec(tot_mh.Text), 2) - Round((RowSum(g20, "in_mh")), 2) - Round(ToDec(RowSum(g30, "down_hr")), 2) - Round(ToDec(RowSum(g40, "down_hr")), 2)
                SetenableEndTimeColumn(g30)
            Case MenuType.Save
                If ToDec(tot_mh.Text) <> Round(ToDec(RowSum(g20, "in_mh")), 2) + Round(ToDec(RowSum(g30, "down_hr")), 2) + Round(ToDec(RowSum(g40, "down_hr")), 2) + Round(ToDec(loss.Text), 2) Then
                    MessageBox.Show("투입공수가 잘못 등록되어 저장이 불가능합니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                Else
                    Me._Save()
                End If
            Case MenuType.Delete
                g20.DeleteAll()
                g30.DeleteAll()
                g40.DeleteAll()
                have_mh.Text = String.Empty
                acc_mh.Text = String.Empty
                give_mh.Text = String.Empty
                tot_mh.Text = String.Empty
                have_wk.Text = String.Empty
                loss.Text = String.Empty

            Case MenuType.Print
                Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select
    End Sub

    Private Sub _Save()
        If Me.Save() Then
            Dim param As OpenParameters = New OpenParameters
            param.Add("@o_co_cd", o_co_cd.Text)
            param.Add("@o_fac_cd", o_fac_cd.Text)
            param.Add("@o_cust_cd", o_cust_cd.Text)
            param.Add("@o_work_dt", o_work_dt.Text)
            param.Add("@o_mc_cd", g10.Text("mc_cd"))
            param.Add("@o_dn_bc", o_dn_bc.Text)
            Me.Open("ppc100_krs_g20", param)
        End If
    End Sub

    Private Sub _Open()

        If CheckRequired(o_co_cd, o_fac_cd, o_work_dt, o_cust_cd, o_dn_bc) = True Then
            Me.Open("ppc100_krs_g10")
        End If
        tot_mh.Text = Round(ToDec(have_mh.Text), 2) + Round(ToDec(acc_mh.Text), 2) - Round(ToDec(give_mh.Text), 2)
        tot_mh.TextAlign = Alignment.Right
    End Sub

    Private Function RowSum(ByVal grid As Frame7.eGrid, ByVal colNm As String) As Decimal
        If grid.RowCount = Nothing Or grid.RowCount = 0 Then
            Return 0.0
        Else
            Dim row_cnt As Integer = grid.RowCount
            Dim sum As Decimal

            For i = 0 To row_cnt - 1
                Dim dr = grid.GetDataRow(i)
                If dr Is Nothing Then
                    Exit For
                End If
                Dim num As Decimal = 0
                If IsDBNull(dr(colNm)) Then
                    num = 0
                Else
                    num = ToDec(dr(colNm))
                End If
                sum += Round(num, 2)

                'sum += Round(ToDec(grid.Text(colNm, i)), 2)
            Next
            Return System.Math.Round(sum, 2)
        End If
    End Function

    Private Sub MH_TextChanging(ByVal sender As System.Object, ByVal newValue As System.String, ByVal oldValue As System.String, ByRef cancel As System.Boolean) Handles have_mh.TextChanging, acc_mh.TextChanging, give_mh.TextChanging, have_wk.TextChanging, tot_mh.TextChanging
        tot_mh.Text = Round(ToDec(have_mh.Text), 2) + Round(ToDec(acc_mh.Text), 2) - Round(ToDec(give_mh.Text), 2)
        tot_mh.TextAlign = Alignment.Right
        loss.Text = Round(ToDec(tot_mh.Text), 2) - Round(RowSum(g20, "in_mh"), 2) - Round(RowSum(g30, "down_hr"), 2) - Round(RowSum(g40, "down_hr"), 2)
    End Sub

    Private Sub g10_AfterMoveRow(sender As System.Object, PrevRowIndex As System.Int32, RowIndex As System.Int32) Handles g10.AfterMoveRow
        Dim row_cnt = g20.RowCount
        'For i = 0 To row_cnt - 1
        '    g20.Text("in_mh", i) = Round(ToDec(g20.Text("std_mh", i)), 2) * Round(ToDec(g20.Text("tot_qty", i)), 2)
        'Next
        loss.Text = Round(ToDec(tot_mh.Text), 2) - Round(RowSum(g20, "in_mh"), 2) - Round(RowSum(g30, "down_hr"), 2) - Round(RowSum(g40, "down_hr"), 2)
        tot_mh.Text = Round(ToDec(have_mh.Text), 2) + Round(ToDec(acc_mh.Text), 2) - Round(ToDec(give_mh.Text), 2)
        tot_mh.TextAlign = Alignment.Right
        'g30.AddNewRow()
        'g40.AddNewRow()
        SetUnOperationDefaulValue()
    End Sub

    Private Sub g20_AfterMoveRow(sender As System.Object, PrevRowIndex As System.Int32, RowIndex As System.Int32) Handles g20.AfterMoveRow
        loss.Text = Round(ToDec(tot_mh.Text), 2) - Round(RowSum(g20, "in_mh"), 2) - Round(RowSum(g30, "down_hr"), 2) - Round(RowSum(g40, "down_hr"), 2)
        tot_mh.Text = Round(ToDec(have_mh.Text), 2) + Round(ToDec(acc_mh.Text), 2) - Round(ToDec(give_mh.Text), 2)
        tot_mh.TextAlign = Alignment.Right
    End Sub

    Private Sub g20_CellValueChanged(sender As System.Object, ColumnName As System.String, RowIndex As System.Int32, ByRef Value As System.Object) Handles g20.CellValueChanged
        If ColumnName = "g_qty" Or ColumnName = "g_qty" Or ColumnName = "ng_qty" Or ColumnName = "ng_qty" Or ColumnName = "wipg_qty" Or ColumnName = "wip_qty" Or ColumnName = "pbad_qty" Or ColumnName = "vbad_qty" Then
            'g20.Text("tot_qty") = Round(ToDec(g20.Text("g_qty")), 2) + Round(ToDec(g20.Text("wipg_qty")), 2) + Round(ToDec(g20.Text("wip_qty")), 2) + Round(ToDec(g20.Text("pbad_qty")), 2) + Round(ToDec(g20.Text("vbad_qty")), 2)
            g20.Text("tot_qty") = Round(ToDec(g20.Text("g_qty")), 2) + Round(ToDec(g20.Text("ng_qty")), 2) '+ Round(ToDec(g20.Text("wipg_qty")), 2) + Round(ToDec(g20.Text("pbad_qty")), 2) + Round(ToDec(g20.Text("vbad_qty")), 2)
            g20.Text("in_mh") = ToDec(g20.Text("std_mh")) * ToDec(g20.Text("tot_qty"))
            loss.Text = Round(ToDec(tot_mh.Text), 2) - Round(RowSum(g20, "in_mh"), 2) - Round(RowSum(g30, "down_hr"), 2) - Round(RowSum(g40, "down_hr"), 2)
        End If
    End Sub

    Private Sub g30_CellValueChanged(ByVal sender As System.Object, ByVal ColumnName As System.String, ByVal RowIndex As System.Int32, ByRef Value As System.Object) Handles g30.CellValueChanged
        SetUnOperateTime(ColumnName, Value, g30)
    End Sub

    Private Sub g40_CellValueChanged(ByVal sender As System.Object, ByVal ColumnName As System.String, ByVal RowIndex As System.Int32, ByRef Value As System.Object) Handles g40.CellValueChanged
        SetUnOperateTime(ColumnName, Value, g40)
    End Sub

    Private Sub SetUnOperateTime(ByVal ColumnName As System.String, ByRef Value As System.Object, ByRef grid As eGrid)
        SetenableEndTimeColumn(grid)

        If ColumnName = "down_cd" Then
            If Value = "PP400140" OrElse Value = "PP400130" Then
                grid.ColumnReadOnly("end_time") = True
            End If
        Else
            SetNormalUnOperateTime(ColumnName, Value, grid)
        End If
    End Sub

    Private Sub SetEquipUnOperateTime(ByVal ColumnName As System.String, ByRef Value As System.Object, ByRef grid As eGrid)
        If MoveCol Then Exit Sub
        With grid
            Try
                Dim temp_start_dt As DateTime

                If .Text("start_time") <> "" Then
                    temp_start_dt = CDate(Date.Today.ToString("yyyy-MM-dd") + .Text("start_time"))
                End If

            Catch ex As Exception
                .Text(ColumnName) = ""
                .Text("down_min") = ""
                .Text("down_hr") = ""
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
            Finally
                MoveCol = False
            End Try

        End With
    End Sub

    Private Sub SetNormalUnOperateTime(ByVal ColumnName As System.String, ByRef Value As System.Object, ByRef grid As eGrid)
        If ColumnName.StartsWith("start") OrElse ColumnName.StartsWith("end") OrElse ColumnName = "staff_count" Then
            If MoveCol Then Exit Sub
            With grid
                Try
                    Dim start_dt As DateTime
                    Dim end_dt As DateTime
                    If ColumnName = "start_time" Or ColumnName = "end_time" Then
                        MoveCol = True
                        Dim Val As String = .Text(ColumnName)
                        .Text(ColumnName) = TimeFormat(Val)
                    End If

                    If .Text("start_dt") <> "" AndAlso .Text("start_time") <> "" Then
                        start_dt = CDate(.Text("start_dt") + " " + .Text("start_time"))
                    End If

                    If .Text("end_dt") <> "" AndAlso .Text("end_time") <> "" Then
                        end_dt = CDate(.Text("end_dt") + " " + .Text("end_time"))
                    End If

                    If .Text("start_time") <> "" AndAlso .Text("end_time") <> "" AndAlso .Text("staff_count") <> "" Then
                        If DateDiff(DateInterval.Minute, start_dt, end_dt) < 0 Then
                            end_dt = end_dt.AddDays(1)
                            .Text("end_dt") = end_dt.Date
                        End If
                        .Text("down_min") = (DateDiff(DateInterval.Minute, start_dt, end_dt) * .Text("staff_count")).ToString()
                        .Text("down_hr") = (.Text("down_min") / 60.0)
                    Else
                        .Text("down_min") = ""
                        .Text("down_hr") = ""
                    End If

                    SetLossData()
                Catch ex As Exception
                    .Text(ColumnName) = ""
                    .Text("down_min") = ""
                    .Text("down_hr") = ""
                    SetLossData()
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
                Finally
                    MoveCol = False
                End Try

            End With
        End If
    End Sub

    Private Sub g20_AutoValidateChanged(sender As System.Object, e As System.EventArgs) Handles g20.AutoValidateChanged
        g20.Text("in_mh") = Round(ToDec(g20.Text("std_mh")), 2) * Round(ToDec(g20.Text("tot_qty")), 2)
        loss.Text = Round(ToDec(tot_mh.Text), 2) - Round(RowSum(g20, "in_mh"), 2) - Round(RowSum(g30, "down_hr"), 2) - Round(RowSum(g40, "down_hr"), 2)
    End Sub

    Private Sub g60_g70_CellValueChanged(sender As System.Object, ColumnName As System.String, RowIndex As System.Int32, ByRef Value As System.Object) Handles g60.CellValueChanged, g70.CellValueChanged
        g20.Text("pbad_qty", g20.RowIndex) = Round(RowSum(g60, "pbad_qty"), 2)
        g20.Text("vbad_qty", g20.RowIndex) = Round(RowSum(g70, "vbad_qty"), 2)
    End Sub

    Private Sub g10_BeforeMoveRow(sender As System.Object, RowIndex As System.Int32, ByRef AllowMove As System.Boolean) Handles g10.BeforeMoveRow
        Me.have_mh.Text = String.Empty
        Me.acc_mh.Text = String.Empty
        Me.give_mh.Text = String.Empty
        Me.tot_mh.Text = String.Empty
        Me.have_wk.Text = String.Empty
        Me.loss.Text = String.Empty
    End Sub


    Private Sub g20_BeforeMoveRow(sender As System.Object, RowIndex As System.Int32, ByRef AllowMove As System.Boolean) Handles g20.BeforeMoveRow

        Dim dt_g20 = g20.DataSet.Tables(0)
        If dt_g20.Rows.Count = 0 Then
            Return
        End If

        If g20.Text("wo_no") = "" Then
            Return
        Else
            If dt_g20.Rows(g20.RowIndex).RowState = Data.DataRowState.Modified Then

                Dim dt_g60 = g60.DataSet.Tables(0)
                Dim isChanged As Boolean = False
                For i = 0 To g60.RowCount - 1
                    If dt_g60.Rows(i).RowState = Data.DataRowState.Modified Or dt_g60.Rows(i).RowState = Data.DataRowState.Added Then
                        isChanged = True
                        Exit For
                    End If
                Next

                If isChanged = True Then
                    Dim dResult As DialogResult = MessageBox.Show("입력한 불량내역을 저장하려면 지금 저장해야 합니다. 저장 하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If dResult = DialogResult.Yes Then
                        Me._Save()
                    Else
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub g30_DeletedRow(ByVal sender As System.Object, ByVal RowIndex As System.Int32) Handles g30.DeletedRow
        SetLossData()
    End Sub


    Private Sub g40_DeletedRow(ByVal sender As System.Object, ByVal RowIndex As System.Int32) Handles g40.DeletedRow
        SetLossData()
    End Sub


    Private Sub SetLossData()
        loss.Text = Round(ToDec(tot_mh.Text), 2) - Round(RowSum(g20, "in_mh"), 2) - Round(RowSum(g30, "down_hr"), 2) - Round(RowSum(g40, "down_hr"), 2)
    End Sub

    Private Sub g30_AddedRow(ByVal sender As System.Object, ByVal RowIndex As System.Int32) Handles g30.AddedRow
        SetDefaultValue(g30)
    End Sub

    Private Sub g40_AddedRow(ByVal sender As System.Object, ByVal RowIndex As System.Int32) Handles g40.AddedRow
        SetDefaultValue(g40)
    End Sub

    Private Sub SetDefaultValue(ByRef grid As eGrid)
        With grid
            .Text("start_dt") = o_work_dt.Text
            .Text("end_dt") = o_work_dt.Text
            .Text("staff_count") = 1
        End With
    End Sub

    '정규휴식시간 hardCoding...함...
    Private Sub SetUnOperationDefaulValue()
        If g40.DataSet.Tables(0).Rows.Count > 0 Then
            Exit Sub
        End If

        '주간
        If o_dn_bc.Text = "PP160100" Then
            g40.AddNewRow()
            g40.Text("down_cd") = "PP400500"
            g40.Text("start_time") = "10:00"
            g40.Text("end_time") = "10:10"

            g40.AddNewRow()
            g40.Text("down_cd") = "PP400500"
            g40.Text("start_time") = "15:00"
            g40.Text("end_time") = "15:10"
        ElseIf o_dn_bc.Text = "PP160150" Then
            g40.AddNewRow()
            g40.Text("down_cd") = "PP400500"
            g40.Text("start_time") = "22:00"
            g40.Text("end_time") = "22:10"

            g40.AddNewRow()
            g40.Text("down_cd") = "PP400500"
            g40.Text("start_time") = "02:00"
            g40.Text("end_time") = "02:10"
        End If

    End Sub

    Private Sub g30_AfterMoveRow(ByVal sender As System.Object, ByVal PrevRowIndex As System.Int32, ByVal RowIndex As System.Int32) Handles g30.AfterMoveRow
        SetenableEndTimeColumn(g30)
    End Sub

    Private Sub g40_AfterMoveRow(ByVal sender As System.Object, ByVal PrevRowIndex As System.Int32, ByVal RowIndex As System.Int32) Handles g40.AfterMoveRow
        SetenableEndTimeColumn(g40)
    End Sub

    Private Sub SetenableEndTimeColumn(ByRef grid As eGrid)

        Dim isReadOnly As Boolean = False

        If grid.Text("down_cd") = "PP400140" OrElse grid.Text("down_cd") = "PP400140" Then
            isReadOnly = True
        End If
        grid.ColumnReadOnly("end_dt") = isReadOnly
        grid.ColumnReadOnly("end_time") = isReadOnly
    End Sub

    Public Sub Open1(ByVal pw_no As String, ByVal work_dt As String, ByVal co_cd As String, ByVal fac_cd As String, ByVal cust_cd As String, ByVal prc_cd As String, ByVal mc_cd As String, ByVal dn_bc As String)

        o_co_cd.Text = co_cd
        o_fac_cd.Text = fac_cd
        o_cust_cd.Text = cust_cd
        o_dn_bc.Text = dn_bc
        o_prc_cd.Text = prc_cd
        o_work_dt.Text = work_dt

        Dim param As OpenParameters = New OpenParameters
        param = New OpenParameters
        param.Add("@o_fac_cd", fac_cd)
        param.Add("@o_cust_cd", cust_cd)
        param.Add("@o_mc_cd", mc_cd)
        Me.Open("ppc100_krs_g10_jump", param)

        tot_mh.Text = Round(ToDec(have_mh.Text), 2) + Round(ToDec(acc_mh.Text), 2) - Round(ToDec(give_mh.Text), 2)
        tot_mh.TextAlign = Alignment.Right

    End Sub

    Private Sub Print()
        If g10.RowCount <= 0 Or g20.RowCount <= 0 Then Exit Sub
        'If g10.RowCount <= 0 Or g10.Text("cust_cd") <> "PD01900" Then Exit Sub '대경의 경우만 사용
        Dim Type As String = "LEB160", Gubn As String = "0"

        'If mov_no.Text = "" Then
        '    MessageInfo("출고 번호가 누락 되었습니다.")
        '    Exit Sub
        'End If
        Dim p As OpenParameters = New OpenParameters
        p.Add("@fac_cd", o_fac_cd.Text) '공장
        p.Add("@cust_cd", g10.Text("cust_cd")) '거래처
        p.Add("@work_dt", o_work_dt.Text)
        p.Add("@mc_cd", g10.Text("mc_cd")) '장비코드
        p.Add("@dn_bc", o_dn_bc.Text) '주야구분

        'p.Add("@gubn", Gubn)
        'p.Add("@is_cost", "0")
        System7.ReportView.LoadView(Type, "", "ppc100_krs_print", p)

    End Sub
End Class
