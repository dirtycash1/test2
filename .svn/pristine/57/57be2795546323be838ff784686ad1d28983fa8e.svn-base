Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Parameter

Public Class PAB101B

    Private m_Init As Boolean

    Private Sub PAB101B_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        m_Init = True
        but1.Text = but.Properties.Items(but.SelectedIndex).Value
        chk1.Text = "0"
        chk2.Text = "0"
        nat_chk.Text = "0"
        g10.BringToFront()
        If Me.IsManager = True Then
            emp_no.Enabled = True
            dept_cd.Text = True

        Else
            emp_no.Enabled = False
            dept_cd.Text = False
        End If

        If Parameter.Login.LangNo = "1" Then
            but.Properties.Items(0).Description = "월별상세"
            but.Properties.Items(1).Description = "기간별(합계)"
        Else
            but.Properties.Items(0).Description = "Detail"
            but.Properties.Items(1).Description = "Summary"
        End If
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Open

                Me.Open_Form()

            Case MenuType.Save

                'Me.save_Form()

                'Case MenuType.New
            Case MenuType.New

                fr_mon.Text = Now().Date
                to_mon.Text = Now().Date
                dept_cd.Text = ""
                emp_no.Text = ""
                emp_nm.Text = ""
                pay_bc.Text = ""
                pay_kd.Text = ""

                but1.Text = but.Properties.Items(but.SelectedIndex).Value

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Public Sub Open_Form()

        If but1.Text = "0" Then
            '월별 상세
            Me.Init_Title()
            Me.Disp_Data()
        End If

        If but1.Text = "1" Then
            '기간별 급여 합계
            Me.Init1_Title()
            Me.Disp1_Data()
        End If

    End Sub

#Region " 1. Grid 컬럼 초기화 "

    'Case 1. DataSet을 이용한 Title 배열
    Private Sub Init_Title()

        '1. 컬럼배열을 만든다
        Dim dSet As DataSet = Me.OpenDataSet("pab101b_title")
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

        g10.InsertArrayColumns(Nothing, arr, "pay_amt")

    End Sub
#End Region
#Region " 2. Display "

    '첫번째 Display 방법: 기본기능을 이용
    Private Sub Disp_Data()
        Try
            'Master 부분

            g10.GridColumn("pay_mon").IsMasterKey = True
            g10.GridColumn("pay_bc").IsMasterKey = True
            g10.GridColumn("pay_kd").IsMasterData = True
            g10.GridColumn("emp_no").IsMasterKey = True
            g10.GridColumn("emp_nm").IsMasterData = True
            g10.GridColumn("bs_cd").IsMasterData = True
            g10.GridColumn("dept_nm").IsMasterData = True
            g10.GridColumn("nat_cd").IsMasterData = True
            g10.GridColumn("gen_ty").IsMasterData = True
            g10.GridColumn("duty_bc").IsMasterData = True
            g10.GridColumn("rank_bc").IsMasterData = True
            g10.GridColumn("step_bc").IsMasterData = True
            g10.GridColumn("send_bc").IsMasterData = True

            g10.GridColumn("std_amt").IsMasterData = True
            g10.GridColumn("tot_pay_amt").IsMasterData = True
            g10.GridColumn("tot_de").IsMasterData = True
            g10.GridColumn("tot_pay").IsMasterData = True
            g10.GridColumn("ot_amt").IsMasterData = True
            g10.GridColumn("eat_amt").IsMasterData = True
            g10.GridColumn("drv_amt").IsMasterData = True
            g10.GridColumn("tax_amt").IsMasterData = True
            g10.GridColumn("tot_tax_amt").IsMasterData = True

            'b.gen_ty, b.duty_bc, b.rank_bc, b.step_bc,  
            'ot_amt, eat_amt, drv_amt, tax_amt,tot_tax_amt,
            'Detail 부분
            g10.GridColumn("pay_cd").IsDetailKey = True
            g10.GridColumn("pay_amt").IsDetailData = True

            MyBase.Open("pab101b_g10")

            '화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다
            'g10.GridColumn("work_mon").DefaultText = work_mon.Text

        Catch ex As Exception

            MessageInfo(ex, "Disp_Data()")

        End Try
    End Sub

#End Region
#Region " 3. Grid 컬럼 초기화 "

    'Case 1. DataSet을 이용한 Title 배열
    Private Sub Init1_Title()

        '1. 컬럼배열을 만든다
        Dim dSet As DataSet = Me.OpenDataSet("pab101b_title")
        If IsEmpty(dSet) Then
            MessageInfo("조회 할 Data가 없습니다")

            Exit Sub
        End If

        Dim arr(1, 0) As String, inx As Integer = 0
        For Each dRow In dSet.Tables(0).Rows
            ReDim Preserve arr(1, inx)      'Array를 증가시킨다

            arr(0, inx) = dRow(0)           'FieldName 으로 사용된다
            arr(1, inx) = dRow(1)           'Title로 사용된다

            inx += 1
        Next

        g20.InsertArrayColumns(Nothing, arr, "pay_amt")

    End Sub


#End Region
#Region " 4. Display1 "

    '첫번째 Display 방법: 기본기능을 이용
    Private Sub Disp1_Data()
        Try

            g20.GridColumn("emp_no").IsMasterKey = True
            g20.GridColumn("emp_nm").IsMasterData = True
            g20.GridColumn("bs_cd").IsMasterData = True
            g20.GridColumn("dept_nm").IsMasterData = True
            g20.GridColumn("nat_cd").IsMasterData = True
            g20.GridColumn("pay_kd").IsMasterData = True
            g20.GridColumn("pay_bc").IsMasterData = True

            g20.GridColumn("gen_ty").IsMasterData = True
            g20.GridColumn("duty_bc").IsMasterData = True
            g20.GridColumn("rank_bc").IsMasterData = True
            g20.GridColumn("step_bc").IsMasterData = True
            g20.GridColumn("send_bc").IsMasterData = True

            g20.GridColumn("tot_pay_amt").IsMasterData = True
            g20.GridColumn("tot_de").IsMasterData = True
            g20.GridColumn("tot_pay").IsMasterData = True
            g20.GridColumn("ot_amt").IsMasterData = True
            g20.GridColumn("eat_amt").IsMasterData = True
            g20.GridColumn("drv_amt").IsMasterData = True
            g20.GridColumn("tax_amt").IsMasterData = True
            g20.GridColumn("tot_tax_amt").IsMasterData = True


            'Detail 부분
            g20.GridColumn("pay_cd").IsDetailKey = True
            g20.GridColumn("pay_amt").IsDetailData = True

            MyBase.Open("pab101b_g20")

        Catch ex As Exception

            MessageInfo(ex, "Disp_Data()")

        End Try
    End Sub

#End Region

#Region " 3. Save "

    ''첫번째 Save 방법: 기본기능을 이용
    'Public Function Save_Form() As Boolean

    '    MyBase.Save()

    'End Function

#End Region

    Private Sub but_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but.SelectedIndexChanged
        but1.Text = but.Properties.Items(but.SelectedIndex).Value

        If but1.Text = "0" Then
            g10.BringToFront()
            Open_Form()
        End If

        If but1.Text = "1" Then
            g20.BringToFront()
            Open_Form()
        End If

    End Sub

    Private Sub chk1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk1.CheckedChanged
        If Not m_Init Then
            Exit Sub
        End If


        g10.ColumnVisible("bs_cd") = chk1.Checked
        g10.ColumnVisible("dept_nm") = chk1.Checked
        g10.ColumnVisible("nat_cd") = chk1.Checked
        g10.ColumnVisible("gen_ty") = chk1.Checked
        g10.ColumnVisible("duty_bc") = chk1.Checked
        g10.ColumnVisible("rank_bc") = chk1.Checked
        g10.ColumnVisible("step_bc") = chk1.Checked

        g20.ColumnVisible("bs_cd") = chk1.Checked
        g20.ColumnVisible("dept_nm") = chk1.Checked
        g20.ColumnVisible("nat_cd") = chk1.Checked
        g20.ColumnVisible("gen_ty") = chk1.Checked
        g20.ColumnVisible("duty_bc") = chk1.Checked
        g20.ColumnVisible("rank_bc") = chk1.Checked
        g20.ColumnVisible("step_bc") = chk1.Checked


    End Sub

    Private Sub chk2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk2.CheckedChanged
        If Not m_Init Then
            Exit Sub
        End If

        g10.ColumnVisible("ot_amt") = chk2.Checked
        g10.ColumnVisible("eat_amt") = chk2.Checked
        g10.ColumnVisible("drv_amt") = chk2.Checked

        g20.ColumnVisible("ot_amt") = chk2.Checked
        g20.ColumnVisible("eat_amt") = chk2.Checked
        g20.ColumnVisible("drv_amt") = chk2.Checked

    End Sub


End Class
