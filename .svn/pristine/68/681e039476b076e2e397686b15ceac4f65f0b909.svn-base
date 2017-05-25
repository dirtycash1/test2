Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class ESD100

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Init_Title()
        Me.Disp_Data()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Open

                Init_Title()
                Disp_Data()

            Case MenuType.Save

                If Me.Save() Then
                    Me.Init_Title()
                    Me.Disp_Data()
                End If

            Case Else

                MyBase.MenuButton_Click(mty)

        End Select

    End Sub


    Private Sub Init_Title()

        '1. 컬럼배열을 만든다
        Dim frDt As Date = std_year.Text + "-01-01"
        Dim toDt As Date = std_year.Text + "-12-31"

        Dim cnt As Integer = DateDiff(DateInterval.Month, frDt, toDt) + 1
        Dim arr(1, 0) As String, yyyymm As String, title As String
        For i = 0 To cnt - 1
            ReDim Preserve arr(1, i)     'Array를 증가시킨다 

            yyyymm = Format(DateAdd(DateInterval.Month, i, frDt), "yyyy-MM")
            title = (i + 1).ToString

            arr(0, i) = yyyymm                      'FieldName
            arr(1, i) = title + "월"                'Title
        Next


        g10.InsertArrayColumns(Nothing, arr, "val")

    End Sub


    '첫번째 Display 방법: 기본기능을 이용
    Private Sub Disp_Data()
        Try
            'Master 부분

            'g10.GridColumn("co_cd").IsMasterKey = True
            g10.GridColumn("grp_bc").IsMasterKey = True
            g10.GridColumn("grp_nm").IsMasterKey = True
            g10.GridColumn("model_cd").IsMasterKey = True
            g10.GridColumn("model_nm").IsMasterData = True
            g10.GridColumn("ty").IsMasterKey = True
            g10.GridColumn("tot").IsMasterData = True

            'Detail 부분
            g10.GridColumn("std_mon").IsDetailKey = True
            g10.GridColumn("amt").IsDetailData = True

            MyBase.Open()

        Catch ex As Exception

            MessageInfo(ex, "Disp_Data()")

        End Try
    End Sub
    Public Sub save_chk()

        Dim i As Integer

        If plan_bc.Text = "ES100100" Then
            For i = 0 To g10.RowCount - 1

                g10.Text("ty", i) = "계획"
            Next
        End If

        If plan_bc.Text = "ES100300" Then
            For i = 0 To g10.RowCount - 1

                g10.Text("ty", i) = "실적"
            Next
        End If

    End Sub

    Private Sub g10_AddedRow(ByVal sender As Object, ByVal RowIndex As Integer) Handles g10.AddedRow
        Me.save_chk()
    End Sub

    Private Sub g10_InsertedRow(ByVal sender As Object, ByVal RowIndex As Integer) Handles g10.InsertedRow
        Me.save_chk()
    End Sub

    Private Sub plan_bc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles plan_bc.TextChanged
        Init_Title()
        Disp_Data()
    End Sub

    Private Sub but_act_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_act.Click
        If MessageYesNo(std_year.Text + " ← 해당년의 생산 실적을 집계합니다. 기존실적데이터가 있다면 삭제됩니다. 계속 진행 하시겠습니까?", "확인") = MsgBoxResult.No Then
            Exit Sub
        End If

        'Dim p As OpenParameters = New OpenParameters

        'p.Add("@work_mon", work_mon.Text)
        'p.Add("@bs_cd", bs_cd.Text)
        'p.Add("@emp_no", emp_no.Text)
        'p.Add("@emp_nm", emp_nm.Text)
        'p.Add("@dept_cd", dept_cd.Text)
        'p.Add("@work_bc", work_bc.Text)


        Me.OpenDataSet("esd100_actsum")

        Init_Title()
        Disp_Data()
    End Sub
End Class
