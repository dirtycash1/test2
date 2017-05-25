Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class WP_PR1230
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Open

                Me.Open_Form()

                'Case MenuType.Save

                'Me.save_Form()

                'Case MenuType.New

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Public Sub Open_Form()

        Me.Init_Title()
        Me.Disp_Data()

    End Sub

#Region " 1. Grid 컬럼 초기화 "

    'Case 1. DataSet을 이용한 Title 배열
    Private Sub Init_Title()

        '1. 컬럼배열을 만든다
        Dim dSet As DataSet = Me.OpenDataSet("wp_pr1230_title")
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

        g10.InsertArrayColumns(Nothing, arr, "qty")

    End Sub
#End Region
#Region " 2. Display "

    '첫번째 Display 방법: 기본기능을 이용
    Private Sub Disp_Data()
        Try
            'Master 부분

            g10.GridColumn("lot_no").IsMasterKey = True
            g10.GridColumn("gd_cd").IsMasterKey = True
            g10.GridColumn("gd_nm").IsMasterData = True
            g10.GridColumn("spec").IsMasterData = True
            g10.GridColumn("unit_cd").IsMasterData = True
            g10.GridColumn("tot_qty").IsMasterData = True
            g10.GridColumn("pr_qty").IsMasterData = True
            g10.GridColumn("ng_qty").IsMasterData = True
            g10.GridColumn("sample_qty").IsMasterData = True
            g10.GridColumn("bad_rt").IsMasterData = True

            'Detail 부분
            g10.GridColumn("ng_cd").IsDetailKey = True
            g10.GridColumn("qty").IsDetailData = True

            MyBase.Open("wp_pr1230_g10")

            '화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다
            'g10.GridColumn("work_mon").DefaultText = work_mon.Text

        Catch ex As Exception

            MessageInfo(ex, "Disp_Data()")

        End Try
    End Sub

#End Region
  
    Private Sub but_prt_Click(sender As System.Object, e As System.EventArgs) Handles but_prt.Click

        Dim p As OpenParameters = New OpenParameters
        p.Add("@fr_dt", fr_dt.Text)
        p.Add("@to_dt", to_dt.Text)
        p.Add("@ps_cd", ps_cd.Text)
        p.Add("@lot_no", lot_no.Text)
        p.Add("@gd_cd", gd_cd.Text)

        System7.ReportView.LoadView("WP_PR1230", "", "wp_pr1230_print", p)
    End Sub
End Class
