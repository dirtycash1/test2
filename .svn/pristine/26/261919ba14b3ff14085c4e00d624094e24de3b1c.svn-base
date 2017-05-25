Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class PAR101


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

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Public Sub Open_Form()
            Me.Init_Title()
            Me.Disp_Data()
    End Sub
    Private Sub Doc()

        If work_chk.Text = "1" Then
            g10.ColumnVisible("dept_cd") = True
            g10.ColumnVisible("dept_nm") = True
            g10.ColumnVisible("pay_kd") = True
            g10.ColumnVisible("bank_cd") = True
            g10.ColumnVisible("acnt_no") = True
        Else
            g10.ColumnVisible("dept_cd") = False
            g10.ColumnVisible("dept_nm") = False
            g10.ColumnVisible("pay_kd") = False
            g10.ColumnVisible("bank_cd") = False
            g10.ColumnVisible("acnt_no") = False
        End If

    End Sub
#Region " 1. Grid 컬럼 초기화 "

    'Case 1. DataSet을 이용한 Title 배열
    Private Sub Init_Title()

        '1. 컬럼배열을 만든다
        Dim dSet As DataSet = Me.OpenDataSet("par101_title")
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

        g10.InsertArrayColumns(Nothing, arr, "pay_val")

    End Sub
#End Region
#Region " 2. Display "

    '첫번째 Display 방법: 기본기능을 이용
    Private Sub Disp_Data()
        Try
            'Master 부분

            g10.GridColumn("pay_mon").IsMasterKey = True
            g10.GridColumn("pay_bc").IsMasterKey = True
            g10.GridColumn("emp_no").IsMasterKey = True
            g10.GridColumn("emp_nm").IsMasterData = True
            g10.GridColumn("to_dt").IsMasterData = True
            g10.GridColumn("bs_cd").IsMasterData = True
            g10.GridColumn("dept_cd").IsMasterData = True
            g10.GridColumn("dept_nm").IsMasterData = True
            g10.GridColumn("pay_kd").IsMasterData = True
            g10.GridColumn("bank_cd").IsMasterData = True
            g10.GridColumn("acnt_no").IsMasterData = True
            g10.GridColumn("tot_pay").IsMasterData = True
            g10.GridColumn("tot_de").IsMasterData = True
            g10.GridColumn("pay_amt").IsMasterData = True

            'Detail 부분
            g10.GridColumn("pay_cd").IsDetailKey = True
            g10.GridColumn("pay_val").IsDetailData = True

            Me.Doc()
            MyBase.Open("par101_g10")


            '화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다
            'g10.GridColumn("work_mon").DefaultText = work_mon.Text

        Catch ex As Exception

            MessageInfo(ex, "Disp_Data()")

        End Try
    End Sub

#End Region


End Class
