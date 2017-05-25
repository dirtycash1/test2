Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data
Imports System.Text.RegularExpressions
Imports System.Net
Imports System.Collections

Public Class ESS600

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        _open()

        photo.Visible = False
        signimg.Visible = False
        g20.RecordNavigator = True
        g30.RecordNavigator = True
        g40.RecordNavigator = True
        g50.RecordNavigator = True
        g60.RecordNavigator = True
        g70.RecordNavigator = True
        g80.RecordNavigator = True
        g90.RecordNavigator = True
        g95.RecordNavigator = True
        g100.RecordNavigator = True
        g110.RecordNavigator = True


        photo.Visible = False
        signimg.Visible = False
        Me.SplitContainer4.SplitterDistance = 35

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                _open()
                'Me.OpenTrigger("hra100_g10")

            Case MenuType.Save
                Me.Save()

            Case MenuType.New
                New_Form()

            Case MenuType.Print
                Me.Print()
            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub
    Private Sub _open()
        Me.Open()
        bs_cd.ReadOnly = True
        work_bs.ReadOnly = True
        emp_no.ReadOnly = True
        high_bc.ReadOnly = True
        step_bc.ReadOnly = True
        dept_cd.ReadOnly = True
        pay_kd.ReadOnly = True
        

    End Sub

    Private Sub New_Form()
        emp_no.Text = ""

        'Me.OpenTrigger("hra100_g10")
        hire_dt.ReadOnly = False
        bs_cd.ReadOnly = False
        work_bs.ReadOnly = False
        dept_cd.ReadOnly = False
        work_dept.ReadOnly = False
        grp_bc.ReadOnly = False
        high_bc.ReadOnly = False
        step_bc.ReadOnly = False
        job_bc.ReadOnly = False
        pay_kd.ReadOnly = False

    End Sub


    Private Sub Print()

        Dim p As OpenParameters = New OpenParameters
        p.Add("@emp_no", emp_no.Text)

        ''ESS600.ReportView.LoadView("ESS600", "", "hra100_print", p, )

    End Sub

    Private Sub g40_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object)
        If ColumnName = "fr_dt" Or ColumnName = "to_dt" Then
            With g40
                If .Text("fr_dt") = Nothing Or .Text("to_dt") = Nothing Then
                    .Text("work_year") = 0
                    .Text("work_month") = 0
                Else
                    Dim WorkYear As Integer = DateDiff(DateInterval.Year, CDate(.Text("fr_dt")), CDate(.Text("to_dt"))) - 1
                    Dim WorkMonth As Integer = DateDiff(DateInterval.Month, CDate(.Text("fr_dt")), CDate(.Text("to_dt")))

                    If WorkYear < 0 Then WorkYear = 0

                    .Text("work_year") = WorkYear
                    .Text("work_month") = WorkMonth - (WorkYear * 12)

                    If .Text("work_month") >= 12 Then
                        .Text("work_year") = .Text("work_year") + 1
                        .Text("work_month") = .Text("work_month") - 12
                    End If


                End If

            End With

        End If

    End Sub

    Private Sub hire_dt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        hire2_dt.Text = hire_dt.Text
    End Sub
    Private Sub dept_cd_TextChanged(ByVal sender As Object, ByVal oldValue As String)
        work_dept.Text = dept_cd.Text
    End Sub

    Private Sub reg_no_TextChanged(ByVal sender As Object, ByVal oldValue As String)
        If reg_no.Text.Length > 7 Then

            If reg_no.Text.Substring(0, 2) > 30 Then
                bir_dt.Text = "19" + reg_no.Text.Substring(0, 2) + "-" + reg_no.Text.Substring(2, 2) + "-" + reg_no.Text.Substring(4, 2)
            Else
                bir_dt.Text = "20" + reg_no.Text.Substring(0, 2) + "-" + reg_no.Text.Substring(2, 2) + "-" + reg_no.Text.Substring(4, 2)
            End If
        Else
            MessageYesNo("주민번호를 확인 하시길 바랍니다.")
        End If

    End Sub


    Private Sub btn_pic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pic.Click, PictureBox3.Click
        If photo.Visible Then
            photo.Visible = False
            signimg.Visible = False
            Me.SplitContainer4.SplitterDistance = 35
        Else
            photo.Visible = True
            signimg.Visible = True
            Me.SplitContainer4.SplitterDistance = 192
        End If
    End Sub

    Private Sub g10_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer)
        'Me.OpenTrigger("hra100_g10")
        hire_dt.ReadOnly = True
        bs_cd.ReadOnly = True
        work_bs.ReadOnly = True
        dept_cd.ReadOnly = True
        work_dept.ReadOnly = True
        grp_bc.ReadOnly = True
        high_bc.ReadOnly = True
        step_bc.ReadOnly = True
        job_bc.ReadOnly = True
        pay_kd.ReadOnly = True

    End Sub

    Private Sub g130_AfterMoveRow(sender As System.Object, PrevRowIndex As System.Int32, RowIndex As System.Int32)
        With g130
            If .RowCount > 0 Then
                If .Text("apply_yn") = "1" Then
                    .Editable = False
                Else
                    .Editable = True
                End If
            End If
        End With
    End Sub

    
End Class
