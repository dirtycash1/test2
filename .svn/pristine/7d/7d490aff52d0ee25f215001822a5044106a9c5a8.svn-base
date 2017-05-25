Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Functions



Public Class PPC102

    Private Sub PPC102_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Me.Open()

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                Me.Init_Title()
                Me.Disp_Data()

                'MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                '사용하려면 재정의 가능하다
            Case MenuType.Save
                'If MyBase.Save() Then
                ' MyBase.Open()
                'End If

            Case MenuType.Delete
                'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

            Case MenuType.New
                ' Me.WorkSets("mma100_g10").AddNew()  '특정Workset 신규처리

            Case MenuType.Print
                ' Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub Init_Title()

        '1. 컬럼배열을 만든다
        Dim dSet As DataSet = Me.OpenDataSet("ppc102_month")
        If IsEmpty(dSet) Then
            MessageInfo("조회 할 Data가 없습니다")
            'g10.Init()
            Exit Sub
        End If

        Dim arr(1, 0) As String, inx As Integer = 0
        For Each dRow In dSet.Tables(0).Rows
            ReDim Preserve arr(1, inx)      'Array를 증가시킨다

            arr(0, inx) = dRow(0)           'FieldName 으로 사용된다
            arr(1, inx) = dRow(0)           'Title로 사용된다

            inx += 1
        Next

        '2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
        ' Ex) g10.InsertColumn("A", arr, "B")
        '     "A" 컬럼이후에 삽입된다
        '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
        '     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다

        g10.InsertArrayColumns("sum_qty", arr, "in_qty")

    End Sub

    '첫번째 Display 방법: 기본기능을 이용
    Private Sub Disp_Data()
        Try
            'Master 부분
            g10.GridColumn("fac_cd").IsMasterKey = True
            'g10.GridColumn("prc_cd").IsMasterKey = True
            g10.GridColumn("wc_cd").IsMasterKey = True
            g10.GridColumn("mc_cd").IsMasterKey = True
            g10.GridColumn("itm_id").IsMasterKey = True
            g10.GridColumn("itm_cd").IsMasterData = True
            g10.GridColumn("itm_nm").IsMasterData = True
            g10.GridColumn("itm_bc").IsMasterData = True
            g10.GridColumn("grp1_cd").IsMasterData = True
            g10.GridColumn("grp2_cd").IsMasterData = True
            g10.GridColumn("grp3_cd").IsMasterData = True

            g10.GridColumn("sum_qty").IsMasterData = True

            'Detail 부분

            g10.GridColumn("work_ym").IsDetailKey = True
            g10.GridColumn("in_qty").IsDetailData = True

            MyBase.Open()

            '화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다
            'g10.GridColumn("work_mon").DefaultText = work_mon.Text

        Catch ex As Exception
            MessageInfo(ex, "Disp_Data()")
        End Try
    End Sub

End Class
