Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WP_PR1120B
    Dim p As OpenParameters = New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.Open()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty
            'Case MenuType.Open
            '    MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
            '    '사용하려면 재정의 가능하다
            Case MenuType.Save

                If Me.Save() Then
                    Me.Open()
                End If

            Case MenuType.Open
                'Me.Open_Form()

                '160519smk 잠깐 막기 start
                p.Add("@chk1", chk1.Text)
                p.Add("@find_from", find_from.Text)
                p.Add("@find_to", find_to.Text)
                p.Add("@find_model_no", find_model_no.Text)
                p.Add("@find_nm_cd", find_nm_cd.Text)
                p.Add("@kijong_cd", kijong_cd.Text)
                p.Add("@gong_cd", gong_cd.Text)
                p.Add("@fac_cd", fac_cd.Text)
                p.Add("@LOT_NO", LOT_NO.Text)

                If chk2.Checked = True Then  '체크되면(전체조회)
                    p.Add("@chk2", "1")
                Else                          '체크해제(R만조회)
                    p.Add("@chk2", "0")
                End If

                Me.Open("wp_pr1120b_g10", p)
                '160519smk 잠깐 막기 end


            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub


    '20160519smk 불량유형 표시를 위한 설정 
    Public Sub Open_Form()

        Me.Init_Title()
        Me.Disp_Data()

    End Sub

#Region " 1. Grid 컬럼 초기화 "

    'Case 1. DataSet을 이용한 Title 배열
    Private Sub Init_Title()

        '1. 컬럼배열을 만든다
        Dim dSet As DataSet = Me.OpenDataSet("wp_pr1120b_title")
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

        '2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
        ' Ex) g10.InsertColumn("A", arr, "B")
        '     "A" 컬럼이후에 삽입된다
        '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
        '     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다

        g_result.InsertArrayColumns(Nothing, arr, "qty")

    End Sub
#End Region



#Region " 2. Display "

    '첫번째 Display 방법: 기본기능을 이용
    Private Sub Disp_Data()

        p.Add("@chk1", chk1.Text)
        p.Add("@find_from", find_from.Text)
        p.Add("@find_to", find_to.Text)
        p.Add("@find_model_no", find_model_no.Text)
        p.Add("@find_nm_cd", find_nm_cd.Text)
        p.Add("@kijong_cd", kijong_cd.Text)
        p.Add("@gong_cd", gong_cd.Text)
        p.Add("@fac_cd", fac_cd.Text)
        p.Add("@LOT_NO", LOT_NO.Text)

        If chk2.Checked = True Then  '체크되면(전체조회)
            p.Add("@chk2", "1")
        Else                          '체크해제(R만조회)
            p.Add("@chk2", "0")
        End If


        Try

            'Master 부분
            g_result.GridColumn("LOT_NO").IsMasterKey = True
            g_result.GridColumn("PR_NO").IsMasterKey = True
            g_result.GridColumn("PR_DT").IsMasterKey = True

            g_result.GridColumn("GD_CD").IsMasterKey = True
            g_result.GridColumn("GONG_CD").IsMasterKey = True
            g_result.GridColumn("kijong_cd").IsMasterKey = True


            g_result.GridColumn("fac_cd").IsMasterData = True
            g_result.GridColumn("PART_BC").IsMasterData = True

            g_result.GridColumn("GD_NM").IsMasterData = True

            g_result.GridColumn("SPEC30").IsMasterData = True
            g_result.GridColumn("UNIT_CD").IsMasterData = True
            g_result.GridColumn("JOB_QTY").IsMasterData = True
            g_result.GridColumn("PR_QTY").IsMasterData = True
            g_result.GridColumn("NG_QTY").IsMasterData = True
            g_result.GridColumn("SAMPLE_QTY").IsMasterData = True
            g_result.GridColumn("TOT_QTY").IsMasterData = True


            g_result.GridColumn("MATE_NO").IsMasterData = True
            g_result.GridColumn("MC_10").IsMasterData = True
            g_result.GridColumn("MC_CD").IsMasterData = True
            g_result.GridColumn("MC_CD1").IsMasterData = True

            g_result.GridColumn("model_nm").IsMasterData = True
            g_result.GridColumn("STTS").IsMasterData = True

            'g_result.GridColumn("검사결과BC").IsMasterData = True
            'g_result.GridColumn("검사결과DIA").IsMasterData = True
            'g_result.GridColumn("LOSS_CD").IsMasterData = True
            'g_result.GridColumn("LOSS_NM").IsMasterData = True
            'g_result.GridColumn("FROM_DT1").IsMasterData = True
            'g_result.GridColumn("FROM_TIME1").IsMasterData = True
            'g_result.GridColumn("LOSS_TIME").IsMasterData = True
            g_result.GridColumn("LOT_NO1").IsMasterData = True
            g_result.GridColumn("W_POWER").IsMasterData = True

            g_result.GridColumn("PLAN_SEQ").IsMasterData = True
            g_result.GridColumn("emp_nm").IsMasterData = True
            g_result.GridColumn("emp_nm1").IsMasterData = True

            g_result.GridColumn("TO_TIME1").IsMasterData = True

            'Detail 부분
            g_result.GridColumn("ng_cd").IsDetailKey = True
            g_result.GridColumn("qty").IsDetailData = True

            MyBase.Open("wp_pr1120b_g10")
            'Me.Open("wp_pr1120", p)

            '화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다
            'g10.GridColumn("work_mon").DefaultText = work_mon.Text

        Catch ex As Exception

            MessageInfo(ex, "Disp_Data()")

        End Try
    End Sub

#End Region

    Private Sub g_result_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        If g_result.Text("GONG_CD") = "00" Then
            jump_open("WI_PR1121", g_result.Text("PR_NO"))
        ElseIf g_result.Text("GONG_CD") = "10" Then ' 사출
            jump_open("WI_PR1122", g_result.Text("PR_NO"))
        ElseIf g_result.Text("GONG_CD") = "20" Then ' 분리
            jump_open("WI_PR1123", g_result.Text("PR_NO"))
        ElseIf g_result.Text("GONG_CD") = "40" Or "50" Or "55" Or "70" Or "80" Then
            jump_open("WI_PR1124", g_result.Text("PR_NO"))
        End If
    End Sub

    Private Sub jump_open(ByVal lparam As String, ByVal wparam As String)

        Dim menuName As String = lparam
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
        ctr.Open3(wparam)

    End Sub

    Private Sub LOT_NO_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles LOT_NO.KeyDown
        If e.KeyCode = Keys.Enter Then
            MenuButton_Click(MenuType.Open)
        End If
    End Sub



End Class
