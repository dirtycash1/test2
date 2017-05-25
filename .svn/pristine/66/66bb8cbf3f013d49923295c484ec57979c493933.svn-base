Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data


Public Class ESD200

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
        Dim dSet As DataSet = Me.OpenDataSet("esd200_title")
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

        g10.InsertArrayColumns(Nothing, arr, "val")

    End Sub


    '첫번째 Display 방법: 기본기능을 이용
    Private Sub Disp_Data()
        Try
            'Master 부분
            'co_cd, fac_cd, grp_cd, grp_nm, ty , sq, tot, std_mon, week_sq, amt, val = 0.0 
            g10.GridColumn("fac_cd").IsMasterKey = True
            g10.GridColumn("grp_cd").IsMasterKey = True
            g10.GridColumn("grp_nm").IsMasterData = True
            g10.GridColumn("ty").IsMasterKey = True
            g10.GridColumn("tot").IsMasterData = True
            g10.GridColumn("sq").IsMasterData = True
            'g10.GridColumn("std_mon").IsMasterData = True

            'Detail 부분
            g10.GridColumn("week_sq").IsDetailKey = True
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
                'g10.Text("std_mon", i) = std_mon.Text
            Next
        End If

        If plan_bc.Text = "ES100300" Then
            For i = 0 To g10.RowCount - 1

                g10.Text("ty", i) = "실적"
                'g10.Text("std_mon", i) = std_mon.Text
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
        If MessageYesNo(std_mon.Text + " ← 해당년월의 공장별 주간 생산 실적을 집계합니다. 기존실적데이터가 있다면 삭제됩니다. 계속 진행 하시겠습니까?", "확인") = MsgBoxResult.No Then
            Exit Sub
        End If

        'Dim p As OpenParameters = New OpenParameters

        'p.Add("@work_mon", work_mon.Text)
        'p.Add("@bs_cd", bs_cd.Text)
        'p.Add("@emp_no", emp_no.Text)
        'p.Add("@emp_nm", emp_nm.Text)
        'p.Add("@dept_cd", dept_cd.Text)
        'p.Add("@work_bc", work_bc.Text)


        Me.OpenDataSet("esd200_actsum")

        Init_Title()
        Disp_Data()
    End Sub
End Class
