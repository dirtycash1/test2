Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class GAD500

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pnlshow.Visible = False

    End Sub

    Public Overrides Sub Open()

        '화면 컬럼의 생성
        Me.Init_Title()

        'Data Display
        Me.Disp_Data()

    End Sub

    Public Overrides Function Save() As Boolean

        Return MyBase.Save()

    End Function

#Region " 1. Grid 컬럼 초기화 "

    'Case 1. DataSet을 이용한 Title 배열
    Private Sub Init_Title()

        '1. 컬럼배열을 만든다
        Dim dSet As DataSet = Me.OpenDataSet("gad500_title")
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
            'arr(2, inx) = "근태항목"

            MsgBox(ToStr(dRow(1)))

            inx += 1
        Next

        '2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
        ' Ex) g10.InsertColumn("A", arr, "B")
        '     "A" 컬럼이후에 삽입된다
        '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
        '     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다

        g10.InsertArrayColumns(Nothing, arr, "qty")

    End Sub


#End Region

#Region " 2. Display "

    '첫번째 Display 방법: 기본기능을 이용
    Private Sub Disp_Data()
        Try
            'Master 부분
            g10.GridColumn("work_mon").IsMasterKey = True
            g10.GridColumn("emp_no").IsMasterKey = True
            g10.GridColumn("emp_nm").IsMasterData = True
            g10.GridColumn("dept_nm").IsMasterData = True

            'Detail 부분
            g10.GridColumn("sum_cd").IsDetailKey = True
            g10.GridColumn("qty").IsDetailData = True

            MyBase.Open()

            '화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다
            g10.GridColumn("work_mon").DefaultText = work_mon.Text

        Catch ex As Exception

            MessageInfo(ex, "Disp_Data()")

        End Try
    End Sub

#End Region

    Private Sub work_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_work.Click

        If MessageYesNo("[" + work_mon.Text + "] " + vbLf + _
                        "해당월 데이터를 삭제 후 집계 합니다." + vbLf + _
                        "계속 진행 하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        End If

        Me.Open("GAD500_Work")

        fr_mon.Text = work_mon.Text
        to_mon.Text = work_mon.Text

        Me.Open()

    End Sub

    Public Overrides Sub PrintForm()
        'MyBase.PrintForm()

        Dim p As OpenParameters = New OpenParameters

        p.Add("@co_cd", co_cd.Text)
        p.Add("@bs_cd", bs_cd.Text)
        p.Add("@work_bc", work_bc.Text)
        p.Add("@work_kd", work_kd.Text)
        p.Add("@work_mon", work_mon.Text)
        p.Add("@dept_cd", dept_cd.Text)
        p.Add("@emp_no", emp_no.Text)
        p.Add("@emp_nm", emp_nm.Text)

        System7.ReportView.LoadView("GAD500", "", "GAD500_Print", p) '출근대장

    End Sub

    Private Sub btn_show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_show.Click
        pnlshow.Visible = Not pnlshow.Visible
    End Sub


End Class
