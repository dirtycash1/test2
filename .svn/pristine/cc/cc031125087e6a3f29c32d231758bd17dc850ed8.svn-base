Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class GAZ500

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        std_month.Text = Format(CDate(Now.Date), "yyyy") & "-" & Format(CDate(Now.Date), "MM")

        Me.Open()

        DateNavigator1.DateTime = std_month.Text + "-01"

        pnlCopy.Visible = False

        'SchedulerControl1.MonthView.CompressWeekend = False
        'SchedulerControl1.DayView.Enabled = False
        'SchedulerControl1.WeekView.Enabled = False
        'SchedulerControl1.WorkWeekView.Enabled = False
        'SchedulerControl1.TimelineView.Enabled = False
        'SchedulerControl1.OptionsView.NavigationButtons.Visibility = DevExpress.XtraScheduler.NavigationButtonVisibility.Never
        'SchedulerControl1.Start = std_month.Text + "-01"

    End Sub

    Public Overrides Function Save() As Boolean
        If MyBase.Save() Then
            g20.Open()
        End If
    End Function

    Private Sub btn_make_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_make.Click

        If MessageYesNo("해당 데이터가 존재하면 삭제후 생성합니다 계속하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim p As OpenParameters = New OpenParameters
        p.Add("@std_month", std_month.Text)
        p.Add("@bs_cd", bs_cd.Text)

        Me.OpenDataSet("gaz500_Work", p)

        Me.Open()

    End Sub

    'Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
    '    If MessageYesNo("해당 데이터가 삭제됩니다. 계속하시겠습니까?") = MsgBoxResult.No Then
    '        Exit Sub
    '    End If

    '    Dim p As OpenParameters = New OpenParameters
    '    p.Add("@std_month", std_month.Text)
    '    p.Add("@bs_cd", bs_cd.Text)

    '    Me.OpenDataSet("GAZ500_delte", p)

    '    Me.Open()

    'End Sub


    ''######################################################################################
    ''##             Calendar                                                             ##
    ''######################################################################################

    Private Sub std_month_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles std_month.TextChanged

        DateNavigator1.DateTime = std_month.Text + "-01"

    End Sub

    Private Sub g10_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g10.AfterMoveRow
        If g10.Text("work_dt") <> "" Then
            DateNavigator1.HotDate = g10.Text("work_dt")
            DateNavigator1.Refresh()
        End If
    End Sub

    Private Sub btn_copy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_copy.Click
        pnlCopy.Visible = Not pnlCopy.Visible
    End Sub

    Private Sub btn_save2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save2.Click

        If MessageYesNo("To 쪽의 기존 계산식은 삭제되고 복사됩니다." + vbLf + vbLf + "복사 하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        End If

        If Not CheckRequired(bs_cd2, co_cd, bs_cd, std_month) Then
            Exit Sub
        End If
        Me.Open("gaz500_copy")
    End Sub
End Class
