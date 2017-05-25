Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class PAY500

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                Me.Open()

            Case MenuType.Save

                Me.Save()
                ' Me.Open()

            Case MenuType.New

            Case Else

                MyBase.MenuButton_Click(mty)

        End Select

    End Sub
    'Public Sub Open_Form()
    '    Me.Init_Title()
    '    Me.Disp_Data()

    'End Sub

    '#Region " 1. Grid 컬럼 초기화 "

    '    'Case 1. DataSet을 이용한 Title 배열
    '    Private Sub Init_Title()

    '        '1. 컬럼배열을 만든다
    '        Dim dSet As DataSet = Me.OpenDataSet("pay500_title")
    '        If IsEmpty(dSet) Then
    '            MessageInfo("조회 할 Data가 없습니다")
    '            'g10.Init()
    '            Exit Sub
    '        End If

    '        Dim arr(1, 0) As String, inx As Integer = 0
    '        For Each dRow In dSet.Tables(0).Rows
    '            ReDim Preserve arr(1, inx)      'Array를 증가시킨다

    '            arr(0, inx) = dRow(0)           'FieldName 으로 사용된다
    '            arr(1, inx) = dRow(1)           'Title로 사용된다

    '            inx += 1
    '        Next

    '        '2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
    '        ' Ex) g10.InsertColumn("A", arr, "B")
    '        '     "A" 컬럼이후에 삽입된다
    '        '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
    '        '     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다

    '        g10.InsertArrayColumns(Nothing, arr, "val")

    '    End Sub
    '#End Region
    '#Region " 2. Display "

    '    '첫번째 Display 방법: 기본기능을 이용
    '    Private Sub Disp_Data()
    '        Try
    '            'Master 부분

    '            g10.GridColumn("app_year").IsMasterKey = True
    '            g10.GridColumn("emp_no").IsMasterKey = True
    '            g10.GridColumn("emp_nm").IsMasterData = True
    '            g10.GridColumn("dept_nm").IsMasterData = True

    '            'Detail 부분
    '            g10.GridColumn("itm_cd").IsDetailKey = True
    '            g10.GridColumn("val").IsDetailData = True

    '            MyBase.Open("pay500_g10")

    '            '화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다
    '            'g10.GridColumn("work_mon").DefaultText = work_mon.Text

    '        Catch ex As Exception

    '            MessageInfo(ex, "Disp_Data()")

    '        End Try
    '    End Sub

    '#End Region


    '#Region " 3. Save "

    '    '첫번째 Save 방법: 기본기능을 이용
    '    Public Function Save_Form() As Boolean

    '        MyBase.Save()

    '    End Function

    '#End Region


    Private Sub btn_work_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_work.Click
        Dim cnt As Integer = g10.CheckedRows("chk")

        If cnt = 0 Then
            MessageInfo("먼저 대상자를 선택하세요")
            Exit Sub
        End If

        If MessageYesNo(cnt.ToString + " 명을 급여에 반영 하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim p As OpenParameters = New OpenParameters

        Dim i As Integer
        ' 체크된 내역을 급여변동수당에 반영한다.

        For i = 0 To g10.RowCount - 1

            If g10.Text("chk", i) = "1" Then

                p.Add("@app_year", std_year.Text)
                p.Add("@pay_bc", pay_bc.Text)
                p.Add("@pay_mon", pay_mon.Text)

                p.Add("@emp_no", g10.Text("emp_no", i))
                p.Add("@sub_incom", ToDec(g10.Text("sub_incom", i)))
                p.Add("@sub_prsn", ToDec(g10.Text("sub_prsn", i)))
                p.Add("@sub_spc", ToDec(g10.Text("sub_spc", i)))

                Me.OpenDataSet("pay500_insert", p)
            End If

        Next
        'p.Add("@app_year", std_year.Text)
        'p.Add("@pay_bc", pay_bc.Text)
        'p.Add("@pay_mon", pay_mon.Text)

        'p.Add("@emp_no", g10.Text("emp_no", i))
        'p.Add("@sub_incom", g10.Text("sub_incom", i))
        'p.Add("@sub_prsn", g10.Text("sub_prsn", i))
        'p.Add("@sub_spc", g10.Text("sub_spc", i))


        'Me.OpenDataSet("pay500_insert", p)
        MessageInfo("저장되었습니다.")
        MyBase.Open()


    End Sub


    Private Sub btn_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del.Click
        Dim cnt As Integer = g10.CheckedRows("chk")

        If cnt = 0 Then
            MessageInfo("먼저 대상자를 선택하세요")
            Exit Sub
        End If

        If MessageYesNo(cnt.ToString + " 명을 반영 취소 하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim p As OpenParameters = New OpenParameters

        Dim i As Integer

        For i = 0 To g10.RowCount - 1

            If g10.Text("chk", i) = "1" Then

                p.Add("@app_year", std_year.Text)
                p.Add("@pay_bc", pay_bc.Text)
                p.Add("@pay_mon", pay_mon.Text)

                p.Add("@emp_no", g10.Text("emp_no", i))

                Me.OpenDataSet("pay500_delete", p)
            End If

        Next

        'Me.OpenDataSet("pay500_insert", p)
        MessageInfo("반영취소 되었습니다.")
        MyBase.Open()

    End Sub

    Private Sub chk_all_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_all.CheckedChanged
        g10.CheckRows("chk", chk_all.Checked)

    End Sub
End Class
