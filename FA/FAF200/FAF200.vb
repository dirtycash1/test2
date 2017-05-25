Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data
Imports DevExpress.XtraScheduler

Public Class FAF200

    Private t1 As Decimal, t2 As Decimal


    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'sc_open()
        SchedulerControl1.LimitInterval.Start = Microsoft.VisualBasic.Left(std_mon.Text, 7) & "-01"
        Dim IntervalType As DateInterval
        IntervalType = DateInterval.Month   ' Specifies months as interval.
        Dim SecondDate As Date = Microsoft.VisualBasic.Left(std_mon.Text, 7) & "-01"
        SecondDate = Microsoft.VisualBasic.Left(std_mon.Text, 7) & "-01"
        SchedulerControl1.LimitInterval.End = DateAdd(DateInterval.Day, -1, DateAdd(IntervalType, 1, SecondDate))
        SchedulerControl1.Start = Microsoft.VisualBasic.Left(std_mon.Text, 7) & "-01"
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                tot1.Text = 0
                tot2.Text = 0
                gap.Text = 0

                sc_open()
                Me.Open()

            Case MenuType.Save

                If Me.Save() Then
                    sc_open()
                    Me.Open()
                End If
            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub sc_open()

        SchedulerControl1.LimitInterval.Start = Microsoft.VisualBasic.Left(std_mon.Text, 7) & "-01"
        Dim IntervalType As DateInterval
        IntervalType = DateInterval.Month   ' Specifies months as interval.
        Dim SecondDate As Date = Microsoft.VisualBasic.Left(std_mon.Text, 7) & "-01"
        SecondDate = Microsoft.VisualBasic.Left(std_mon.Text, 7) & "-01"
        SchedulerControl1.LimitInterval.End = DateAdd(DateInterval.Day, -1, DateAdd(IntervalType, 1, SecondDate))
        SchedulerControl1.Start = Microsoft.VisualBasic.Left(std_mon.Text, 7) & "-01"

        Dim dRows As DataRowCollection, dRow As DataRow
        Dim dset As DataSet = Me.OpenDataSet("faf200_open")
        If IsEmpty(dset) Then
            MessageInfo("조회 할 Data가 없습니다")
            'g10.Init()
            Exit Sub
        End If
        SchedulerControl1.Storage.EnableReminders = False
        schedulerStorage.Resources.Clear()
        schedulerStorage.Appointments.Clear()
        Dim r As Resource = schedulerStorage.CreateResource(0)
        r.Caption = "자금계획"
        schedulerStorage.Resources.Add(r)
        dRows = dset.Tables(0).Rows

        t1 = 0
        t2 = 0

        For Each dRow In dRows
            Dim apt As Appointment = schedulerStorage.CreateAppointment(AppointmentType.Normal)
            apt.Start = ToStr(dRow("plan_dt"))
            apt.Subject = ToStr(dRow("title"))
            apt.AllDay = True
            If ToStr(dRow("fund_bc")) = "FA250500" Then '"지출" Then
                apt.LabelId = 1
                t2 += ToDec(dRow("amt"))
            Else
                apt.LabelId = 2
                t1 += ToDec(dRow("amt"))
            End If
            'apt.LabelId = CInt(Fix(view.GetRowCellValue(rowIndex, "Severity")))
            'apt.StatusId = CInt(Fix(view.GetRowCellValue(rowIndex, "Priority")))
            'apt.Duration = TimeSpan.FromHours(CInt(Fix(view.GetRowCellValue(rowIndex, "Duration"))))
            'apt.Description = CStr(view.GetRowCellValue(rowIndex, "Description"))
            schedulerStorage.Appointments.Add(apt)
        Next

        tot1.Text = t1
        tot2.Text = t2
        gap.Text = t1 - t2

    End Sub

    Private Sub SchedulerControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SchedulerControl1.Click
        std_dt.Text = SchedulerControl1.ActiveView.SelectedInterval.Start

        'SchedulerControl1.ActiveView.ShowMoreButtons

        Me.Open()
    End Sub


    'Private Sub std_mon_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles std_mon.TextChanged

    '    std_dt.Text = std_mon.Text + "-01"
    '    sc_open()
    '    Me.Open()
    '    'SchedulerControl1.LimitInterval.Start = Microsoft.VisualBasic.Left(std_mon.Text, 7) & "-01"
    '    'Dim IntervalType As DateInterval
    '    'IntervalType = DateInterval.Month   ' Specifies months as interval.
    '    'Dim SecondDate As Date = Microsoft.VisualBasic.Left(std_mon.Text, 7) & "-01"
    '    'SecondDate = Microsoft.VisualBasic.Left(std_mon.Text, 7) & "-01"
    '    'SchedulerControl1.LimitInterval.End = DateAdd(DateInterval.Day, -1, DateAdd(IntervalType, 1, SecondDate))
    '    'SchedulerControl1.Start = Microsoft.VisualBasic.Left(std_mon.Text, 7) & "-01"
    'End Sub

End Class
