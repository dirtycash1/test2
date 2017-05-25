Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class PPP100

    Private Sub PPP100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Init_Title1()

    End Sub


    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Open

                Me.Open_Form()

            Case MenuType.New

                g10.AddNewRow()

            Case MenuType.Save

                If g10.RowCount - 1 < 0 Then
                    MsgBox("저장할 Data 가 없습니다.")
                    Exit Sub
                End If

                'Dim i As Integer
                'For i = 0 To g10.RowCount - 1

                '    g10.Text("co_cd", i) = co_cd.Text
                '    g10.Text("plan_year", i) = plan_year.Text
                '    g10.Text("plan_rev", i) = plan_rev.Text
                '    g10.Text("fac_cd", i) = fac_cd.Text

                'Next

                Me.Save_Form()
                Me.Open_Form()
            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Public Sub Open_Form()

        Me.Init_Title1()
        Me.Disp_Data()

    End Sub

#Region " 1. Grid 컬럼 초기화 "

    'Case 1. DataSet을 이용한 Title 배열
    Private Sub Init_Title1()

        '1. 컬럼배열을 만든다
        Dim dSet As DataSet = Me.OpenDataSet("ppp100_g10_title")

        If IsEmpty(dSet) Then
            'MessageInfo("조회 할 Data가 없습니다")
            'g10.Init()
            Exit Sub
        End If

        Dim arr(1, 0) As String, inx As Integer = 0
        For Each dRow In dSet.Tables(0).Rows
            ReDim Preserve arr(1, inx)      'Array를 증가시킨다

            arr(0, inx) = dRow(0)           'FieldName 으로 사용된다
            arr(1, inx) = dRow(1)           'table
            inx += 1

        Next

        '2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
        ' Ex) g10.InsertColumn("A", arr, "B")
        '     "A" 컬럼이후에 삽입된다
        '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
        '     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다

        g10.InsertArrayColumns("tot_qty", arr, "plan_qty")

    End Sub

#End Region

#Region " 2. Display "

    '첫번째 Display 방법: 기본기능을 이용
    'Private Sub Disp_Data(ByVal dSet As DataSet)
    Private Sub Disp_Data()
        'If IsEmpty(dSet) Then
        '    MessageInfo("조회 할 Data가 없습니다")
        '    Exit Sub
        'End If

        Try
            'Master 부분
            g10.GridColumn("co_cd").IsMasterKey = True
            g10.GridColumn("plan_year").IsMasterKey = True
            g10.GridColumn("plan_rev").IsMasterKey = True
            g10.GridColumn("fac_cd").IsMasterKey = True

            g10.GridColumn("itm_id").IsMasterKey = True

            g10.GridColumn("itm_cd").IsMasterData = True
            g10.GridColumn("itm_nm").IsMasterData = True
            g10.GridColumn("itm_bc").IsMasterData = True
            g10.GridColumn("tot_qty").IsMasterData = True

            'Detail 부분
            g10.GridColumn("plan_mon").IsDetailKey = True
            g10.GridColumn("plan_qty").IsDetailData = True

            Me.Open("ppp100_g10")

            '화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다
            'g10.GridColumn("work_mon").DefaultText = work_mon.Text

        Catch ex As Exception

            MessageInfo(ex, "Disp_Data()")

        End Try

    End Sub

#End Region

#Region " 3. Save "

    '첫번째 Save 방법: 기본기능을 이용
    Public Function Save_Form() As Boolean

        Me.Save()

    End Function

#End Region

    Private Sub g10_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g10.AfterMoveRow

        If g10.Text("co_cd", g10.RowIndex) = "" Then

            g10.Text("co_cd", g10.RowIndex) = co_cd.Text
            g10.Text("plan_year", g10.RowIndex) = plan_year.Text
            g10.Text("plan_rev", g10.RowIndex) = plan_rev.Text
            g10.Text("fac_cd", g10.RowIndex) = fac_cd.Text

        End If

    End Sub


    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged

        'If g10.Text("itm_id", g10.RowIndex) = "" Then
        '    Exit Sub
        'End If

        If ColumnName = "itm_id" Then

            If g10.Text("itm_id", g10.RowIndex) = "" Then
                Exit Sub
            End If

            Dim i As Integer
            Dim j As Integer
            Dim k As Integer

            If g10.RowCount - 1 <= 0 Then
                Exit Sub
            End If

            j = g10.RowIndex
            k = g10.Text("itm_id", g10.RowIndex)

            For i = 0 To g10.RowCount - 1

                If g10.Text("itm_id", i) = "" Then
                    Exit For
                End If

                If k = g10.Text("itm_id", i) And i <> j Then

                    MsgBox("선택하신 품목이 이미 등록되어 있습니다.")
                    g10.Text("itm_cd", j) = ""
                    g10.Text("itm_bc", j) = ""
                    g10.Text("itm_nm", j) = ""

                    Exit Sub

                End If

            Next

        End If

        If Mid(ColumnName, 1, 4) = plan_year.Text Then

            SumRowData()

        End If
    End Sub
    Private Sub SumRowData()
        Dim s1 As Decimal
        For j As Integer = 0 To g10.ColumnCount - 1
            If g10.FieldName(j).StartsWith(plan_year.Text) Then s1 += g10.ToDec(j)
        Next
        g10.Text("tot_qty") = s1
    End Sub
End Class
