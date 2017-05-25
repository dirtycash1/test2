Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class ESS200

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Init_Title()
        Disp_Data()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                Init_Title()
                Disp_Data()

            Case MenuType.Save

                save_chk()

                If Me.Save() Then
                    Init_Title()
                    Disp_Data()
                End If

                'Case MenuType.New
                '    cust_cd.Text = ""
                '    itm_cd.Text = ""
                '    itm_nm.Text = ""
                '    emp_id.Text = ""
                '    emp_nm.Text = ""

                '    Me.New_Form()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Public Sub save_chk()

        If g10.RowCount >= 0 Then
            Dim i As Integer

            If plan_bc.Text = "ES100100" Then
                For i = 0 To g10.RowCount - 1
                    If g10.Text("co_cd", i) = "" Then
                        g10.Text("co_cd", i) = co_cd.Text
                    End If
                    If g10.Text("ty", i) = "" Then
                        g10.Text("ty", i) = "계획"
                    End If
                Next
            End If

            If plan_bc.Text = "ES100300" Then
                For i = 0 To g10.RowCount - 1
                    If g10.Text("co_cd", i) = "" Then
                        g10.Text("co_cd", i) = co_cd.Text
                    End If
                    If g10.Text("ty", i) = "" Then
                        g10.Text("ty", i) = "실적"
                    End If
                Next
            End If
        End If

    End Sub

    Private Sub Init_Title()
        '1. 컬럼배열을 만든다
        Dim frDt As Date = std_mon.Text + "-01-01"
        Dim toDt As Date = std_mon.Text + "-12-31"

        Dim cnt As Integer = DateDiff(DateInterval.Month, frDt, toDt) + 1
        Dim arr(1, 0) As String, yyyymm As String, title As String
        For i = 0 To cnt - 1
            ReDim Preserve arr(1, i)     'Array를 증가시킨다 

            yyyymm = Format(DateAdd(DateInterval.Month, i, frDt), "yyyy-MM")
            title = (i + 1).ToString

            arr(0, i) = yyyymm                      'FieldName
            arr(1, i) = title + "월"                'Title
        Next

        '2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
        ' Ex) g10.InsertColumn("A", arr, "B")
        '     "A" 컬럼이후에 삽입된다
        '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
        '     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다

        g10.InsertArrayColumns(Nothing, arr, "amt")

    End Sub

    '첫번째 Display 방법: 기본기능을 이용
    Private Sub Disp_Data()
        Try
            'Master 부분
            g10.GridColumn("co_cd").IsMasterKey = True
            g10.GridColumn("fac_cd").IsMasterKey = True
            g10.GridColumn("grp_cd").IsMasterKey = True
            g10.GridColumn("model_cd").IsMasterKey = True
            'g10.GridColumn("cust_cd").IsMasterKey = True
            'g10.GridColumn("cust_nm").IsMasterKey = True
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

    Private Sub g10_AddedRow(ByVal sender As Object, ByVal RowIndex As Integer) Handles g10.AddedRow
        save_chk()

    End Sub

    Private Sub g10_InsertedRow(ByVal sender As Object, ByVal RowIndex As Integer) Handles g10.InsertedRow
        save_chk()
    End Sub

    Private Sub plan_bc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles plan_bc.TextChanged
        Init_Title()
        Disp_Data()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If MessageYesNo(std_mon.Text + " ← 해당년월의 공장별 매출 실적을 집계합니다. 기존실적데이터가 있다면 삭제됩니다. 계속 진행 하시겠습니까?", "확인") = MsgBoxResult.No Then
            Exit Sub
        End If

        'Dim p As OpenParameters = New OpenParameters

        'p.Add("@work_mon", work_mon.Text)
        'p.Add("@bs_cd", bs_cd.Text)
        'p.Add("@emp_no", emp_no.Text)
        'p.Add("@emp_nm", emp_nm.Text)
        'p.Add("@dept_cd", dept_cd.Text)
        'p.Add("@work_bc", work_bc.Text)


        Me.OpenDataSet("ess200_actsum")

        Init_Title()
        Disp_Data()
    End Sub
End Class
