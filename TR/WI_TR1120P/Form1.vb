Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class Form1
    Private popup As WI_TR1120P
    Dim popGrid As eGrid

    Public Sub InitPopup()

        popup = New WI_TR1120P      'Form1 안에 불려지는 폼을 여기서 호출한다. 
        ' 참조부분에 추가되어 있어야 한다
        ' 불려지는 폼은 다른 일반 메뉴와 동일하게 구현하면 된다

        If popup IsNot Nothing Then
            popup.Dock = System.Windows.Forms.DockStyle.Fill

            'popup 화면에 버턴이 있다면 popup내에서 제어해도 되고 여기서도 제어 가능하다

            AddHandler popup.btn_exit.Click, AddressOf btn_exit_click
            AddHandler popup.btn_ok.Click, AddressOf btn_ok_click
            AddHandler popup.btn_save.Click, AddressOf btn_save_click

            Me.Controls.Add(popup)

            popup.Show()
        End If
    End Sub

    Public Sub InitPopup(ByVal arrParam As String, ByVal nmParam As String, ByVal arrParam1 As String, ByVal qtyParam As String, ByVal odParam As String)

        popup = New WI_TR1120P      'Form1 안에 불려지는 폼을 여기서 호출한다. 
        ' 참조부분에 추가되어 있어야 한다
        ' 불려지는 폼은 다른 일반 메뉴와 동일하게 구현하면 된다

        If popup IsNot Nothing Then
            popup.Dock = System.Windows.Forms.DockStyle.Fill

            'popup 화면에 버턴이 있다면 popup내에서 제어해도 되고 여기서도 제어 가능하다

            AddHandler popup.btn_exit.Click, AddressOf btn_exit_click
            AddHandler popup.btn_ok.Click, AddressOf btn_ok_click
            AddHandler popup.btn_save.Click, AddressOf btn_save_click

            Me.Controls.Add(popup)

            popup.Show()


            popup.itm_cd.Text = arrParam
            popup.itm_nm.Text = nmParam
            popup.seq.Text = arrParam1
            popup.qty.Text = qtyParam
            popup.od_no.text = odParam

            'If popup.g_multi.RowCount = 1 Then
            '    popup.g_multi.Text("CHK") = "1"
            '    Try
            '        popGrid = popup.g_multi

            '        popup.Tag = popGrid
            '        Me.DialogResult = Windows.Forms.DialogResult.OK

            '    Catch ex As Exception
            '        MessageInfo(ex)
            '    End Try
            'End If
        End If
    End Sub

    Private Sub btn_save_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim wSet As Frame7.WorkSet
            wSet = popup.WorkSets("wi_tr1120p_g20")

            For o = 0 To popup.g10.RowCount - 1
                Select Case popup.g10.Text("SPEC_CD", o)
                    Case "10"
                        wSet.SaveValue("spec10", popup.g10.Text("DT_CD", o))
                    Case "20"
                        wSet.SaveValue("spec20", popup.g10.Text("DT_CD", o))
                    Case "30"
                        wSet.SaveValue("spec30", popup.g10.Text("DT_CD", o))
                    Case "40"
                        wSet.SaveValue("spec40", popup.g10.Text("DT_CD", o))
                    Case "50"
                        wSet.SaveValue("spec50", popup.g10.Text("DT_CD", o))
                    Case "60"
                        wSet.SaveValue("spec60", popup.g10.Text("DT_CD", o))
                    Case "70"
                        wSet.SaveValue("spec70", popup.g10.Text("DT_CD", o))
                    Case "80"
                        wSet.SaveValue("spec80", popup.g10.Text("DT_CD", o))
                    Case "90"
                        wSet.SaveValue("spec90", popup.g10.Text("DT_CD", o))
                End Select

            Next


        Catch ex As Exception
            MessageInfo(ex)
        End Try

        popup.Save("wi_tr1120p_g20")

        Dim p As New OpenParameters
        p.Add("@itm_cd", popup.itm_cd.Text)
        p.Add("@value", popup.value.Text)
        p.Add("@x_spec", popup.x_spec.Text)
        p.Add("@y_spec", popup.y_spec.Text)
        p.Add("@ty", "2")
        p.Add("@od_no", popup.od_no.Text)
        p.Add("@seq", popup.seq.Text)

        Dim pa1(9, 0) As String
        For h = 1 To 9
            For o = 0 To popup.g10.RowCount - 1
                If popup.g10.Text("SPEC_CD", o) = (h * 10).ToString() Then
                    pa1(h, 0) = popup.g10.Text("VALUE", o)
                ElseIf pa1(h, 0) = "" Or pa1(h, 0) Is Nothing Then
                    pa1(h, 0) = ""
                End If
            Next
        Next

        For t = 1 To 9
            p.Add("@spec" & (t * 10).ToString(), pa1(t, 0))
        Next


        popup.OpenDataSet("wi_tr1120_body02p", p)

    End Sub

    Private Sub btn_exit_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

            Dim p As New OpenParameters
            p.Add("@itm_cd", popup.itm_cd.Text)
            p.Add("@value", popup.value.Text)
            p.Add("@x_spec", popup.x_spec.Text)
            p.Add("@y_spec", popup.y_spec.Text)
            p.Add("@ty", "1")
            p.Add("@od_no", popup.od_no.Text)
            p.Add("@seq", popup.seq.Text)

            Dim pa1(9, 0) As String
            For h = 1 To 9
                For o = 0 To popup.g10.RowCount - 1
                    If popup.g10.Text("SPEC_CD", o) = (h * 10).ToString() Then
                        pa1(h, 0) = popup.g10.Text("VALUE", o)
                    ElseIf pa1(h, 0) = "" Or pa1(h, 0) Is Nothing Then
                        pa1(h, 0) = ""
                    End If
                    'p.Add("@spec" & popup.g10.Text("SPEC_CD", o), popup.g10.Text("VALUE", o))
                Next  
            Next

            For t = 1 To 9
                p.Add("@spec" & (t * 10).ToString(), pa1(t, 0))
            Next

            Dim dSet As DataSet
            dSet = popup.OpenDataSet("wi_tr1120_body02p", p)   'test_workset이 WorkSet에 등록되어있어야 한다
            If dSet Is Nothing Then
                Exit Sub
            End If

            popup.Tag = dSet
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MessageInfo(ex)
        End Try

        '상황에 맞는 코딩을 한다
        'Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btn_ok_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For k = 0 To popup.g10.RowCount - 1
            If popup.g10.Text("VALUE", k) = "" And popup.g10.Text("XY", k) = "" Then
                MessageInfo("VALUE나 X/Y축 값이 없는 행이 있습니다.")
                Exit Sub
            End If
        Next

        'Dim wSet As Frame7.WorkSet
        'wSet = popup.WorkSets("wi_tr1120p_g20")
        'wSet.SetValue("x_spec", popup.x_spec.Text)
        'wSet.SetValue("y_spec", popup.y_spec.Text)

        popup.Save()

        Dim x As Integer
        Dim y As Integer
        Dim v As Integer
        Dim p As New OpenParameters
        For i = 0 To popup.g10.RowCount - 1
            If popup.g10.Text("XY", i) = "XY01" Then    'X축
                x = i
            ElseIf popup.g10.Text("XY", i) = "XY02" Then    'Y축
                y = i
            ElseIf popup.g10.Text("VALUE", i) <> "" Then
                v = i
            End If
        Next

        popup.value.Text = popup.g10.Text("VALUE", v)
        popup.x_spec.Text = popup.g10.Text("SPEC_CD", x)
        popup.y_spec.Text = popup.g10.Text("SPEC_CD", y)
        p.Add("@itm_cd", popup.itm_cd.Text)
        p.Add("@x_spec", popup.x_spec.Text)         'x축으로 지정
        'p.Add("@itm_cd", popup.itm_cd.Text)

        Dim pa1(9, 0) As String
        For h = 1 To 9
            For o = 0 To popup.g10.RowCount - 1
                If popup.g10.Text("SPEC_CD", o) = (h * 10).ToString() And popup.g10.Text("VALUE", o) <> "" Then
                    pa1(h, 0) = popup.g10.Text("VALUE", o)
                ElseIf (pa1(h, 0) = "" Or pa1(h, 0) Is Nothing) And popup.g10.Text("VALUE", o) <> "" Then
                    pa1(h, 0) = ""
                End If
                'p.Add("@spec" & popup.g10.Text("SPEC_CD", o), popup.g10.Text("VALUE", o))
            Next
        Next

        popup.spec10.Text = pa1(1, 0)
        popup.spec20.Text = pa1(2, 0)
        popup.spec30.Text = pa1(3, 0)
        popup.spec40.Text = pa1(4, 0)
        popup.spec50.Text = pa1(5, 0)
        popup.spec60.Text = pa1(6, 0)
        popup.spec70.Text = pa1(7, 0)
        popup.spec80.Text = pa1(8, 0)
        popup.spec90.Text = pa1(9, 0)

        Me.Init_Title(p)
        Me.Disp_Data()
        popup.g20.ColumnReadOnly("dt_nm") = True

    End Sub

    Private Sub Init_Title(ByVal p As OpenParameters)


        '1. 컬럼배열을 만든다
        Dim dSet As DataSet = popup.OpenDataSet("wi_tr1120p_title", p)
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

        popup.g20.InsertArrayColumns(Nothing, arr, "dt_nm")

    End Sub


    '첫번째 Display 방법: 기본기능을 이용
    Private Sub Disp_Data()
        Try
            'Master 부분

            popup.g20.GridColumn("dt_cd").IsMasterKey = True
            popup.g20.GridColumn("dt_nm").IsMasterData = True
            popup.g20.GridColumn("dt_nm2").IsMasterData = False
            popup.g20.GridColumn("spec10").IsMasterData = True
            popup.g20.GridColumn("spec20").IsMasterData = True
            popup.g20.GridColumn("spec30").IsMasterData = True
            popup.g20.GridColumn("spec40").IsMasterData = True
            popup.g20.GridColumn("spec50").IsMasterData = True
            popup.g20.GridColumn("spec60").IsMasterData = True
            popup.g20.GridColumn("spec70").IsMasterData = True
            popup.g20.GridColumn("spec80").IsMasterData = True
            popup.g20.GridColumn("spec90").IsMasterData = True
            popup.g20.GridColumn("od_no").IsMasterData = True
            popup.g20.GridColumn("seq").IsMasterData = True
            popup.g20.GridColumn("gd_cd").IsMasterData = True

            'Detail 부분
            popup.g20.GridColumn("dt_cd2").IsDetailKey = True
            popup.g20.GridColumn("value").IsDetailData = True

            popup.Open("wi_tr1120p_g20")

            '화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다
            'g10.GridColumn("work_mon").DefaultText = work_mon.Text

        Catch ex As Exception

            MessageInfo(ex, "Disp_Data()")

        End Try
    End Sub

End Class