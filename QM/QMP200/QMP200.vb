Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class QMP200

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.New_Form()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                Me.Open_Form()

            Case MenuType.Save

                Me.Save_Form()

                If Me.Save() Then
                    Me.Open_Form()
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

    Public Sub Save_Form()

        If g10.RowCount - 1 < 0 Then
            Exit Sub
        End If

        For i = 0 To g10.RowCount - 1

            If g10.Text("work_dt", i) = "" Then
                g10.Text("work_dt", i) = work_dt.Text
            End If

            If g10.Text("fac_cd", i) = "" Then
                g10.Text("fac_cd", i) = fac_cd.Text
            End If

            If g10.Text("wc_cd", i) = "" Then
                g10.Text("wc_cd", i) = wc_cd.Text
            End If

            If g10.Text("mc_cd", i) = "" Then
                g10.Text("mc_cd", i) = mc_cd.Text
            End If
        Next

        g10.UpdateCurrentRow()


    End Sub

    Public Sub Open_Form()

        Me.Init_Title()

        Me.Disp_Data()

    End Sub

    Private Sub Init_Title()

        '1. 컬럼배열을 만든다
        Dim dSet As DataSet = Me.OpenDataSet("qmp200_get_title")
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

        g10.InsertArrayColumns("tot_qty", arr, "out_qty")

    End Sub

    Private Sub Disp_Data()

        Dim dSet As DataSet = Me.OpenDataSet("qmp200_get_title")
        If IsEmpty(dSet) Then
            'MessageInfo("조회 할 Data가 없습니다")
            'g10.Init()
            Exit Sub
        End If

        Try
            'Master 부분

            g10.GridColumn("itm_id").IsMasterKey = True
            g10.GridColumn("work_dt").IsMasterKey = True
            g10.GridColumn("fac_cd").IsMasterKey = True
            g10.GridColumn("wc_cd").IsMasterKey = True
            g10.GridColumn("mc_cd").IsMasterKey = True

            g10.GridColumn("itm_cd").IsMasterData = True
            g10.GridColumn("itm_nm").IsMasterData = True
            g10.GridColumn("model_cd").IsMasterData = True
            g10.GridColumn("spec1").IsMasterData = True
            g10.GridColumn("spec5").IsMasterData = True
            g10.GridColumn("tot_qty").IsMasterData = True
           

            'Detail 부분
            g10.GridColumn("bad_cd").IsDetailKey = True
            g10.GridColumn("out_qty").IsDetailData = True

            '화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다
            'g10.GridColumn("work_mon").DefaultText = work_mon.Text

            Me.Open()

        Catch ex As Exception

            MessageInfo(ex, "Disp_Data()")

        End Try

    End Sub


End Class
