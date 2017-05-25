Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Math
Imports System.Data

Public Class PPW200

    Private Sub MMC100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Form Load되면서 바로 입력할 수 있게 신규상태로 만든다
        Me._Open_Form()
        'Me.Open()

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                Me._Open_Form()

                'Me.Open()

            Case MenuType.Save

                'If _Save_Master() Then

                'End If

                Me._Save_Master()

                If Me.Save() Then
                    Me._Open_Form()
                    'Me.Open()
                End If

                'Case MenuType.Delete

                'Case MenuType.New

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select
    End Sub

    Private Function _Save_Master() As Boolean
        Dim dTbl As DataTable, dRow As DataRow
        Dim dSet As DataSet = Me.OpenDataSet("ppw200_save_data")

        dTbl = dSet.Tables(0)
        With g10
            .UpdateRow()

            dTbl.BeginLoadData()
            For i As Integer = 0 To .RowCount - 1

                dRow = dTbl.NewRow()

                dRow("work_dt") = .Text("work_dt", i)
                dRow("fac_cd") = fac_cd.Text
                dRow("wc_cd") = wc_cd.Text
                dRow("mc_cd") = mc_cd.Text
                dRow("work_cd") = .Text("work_cd", i)
                dRow("work_cnt") = .ToDec("work_cnt", i)
                dRow("work_tm") = .ToDec("work_tm", i)
                dRow("stop_tm") = .ToDec("stop_tm", i)
                dRow("work_rt") = .ToDec("work_rt", i)

                dTbl.Rows.Add(dRow)
            Next
            dTbl.EndLoadData()
        End With

        'Return Me.Save("ppw200_save_data")

    End Function

    Private Sub _Open_Form()

        Me.Init_Title()

        Me.Disp_Data()

    End Sub

    Private Sub g20_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g20.CellValueChanged
        With g20
            If ColumnName = "fr_tm" Or ColumnName = "to_tm" Then

                Dim frTm As String = .Text("fr_tm")
                Dim toTm As String = .Text("to_tm")

                .Text("stop_tm") = [Shared].DiffHour(frTm, toTm, 1)

            End If

            If ColumnName = "stop_tm" Or ColumnName = "loss_man" Then

                .Text("loss_tm") = .ToDec("stop_tm") * .ToDec("loss_man")

            End If
        End With

    End Sub

    Private Sub Init_Title()

        '1. 컬럼배열을 만든다
        Dim dSet As dataset = Me.OpenDataSet("ppw200_title")
        If IsEmpty(dSet) Then
            'MessageInfo("조회 할 Data가 없습니다")
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

        g10.InsertArrayColumns("work_rt", arr, "stop_tm1")

    End Sub


    Private Sub Disp_Data()

        'Dim dSet As DataSet = Me.OpenDataSet("ppw200_title")
        'If IsEmpty(dSet) Then
        '    'MessageInfo("조회 할 Data가 없습니다")
        '    'g10.Init()
        '    Exit Sub
        'End If

        Try
            'Master 부분
            g10.GridColumn("work_dt").IsMasterKey = True
            g10.GridColumn("fac_cd").IsMasterKey = True
            g10.GridColumn("wc_cd").IsMasterKey = True

            g10.GridColumn("work_cd").IsMasterData = True
            g10.GridColumn("work_nm").IsMasterData = True
            g10.GridColumn("work_cnt").IsMasterData = True
            g10.GridColumn("work_tm").IsMasterData = True
            g10.GridColumn("stop_tm").IsMasterData = True
            g10.GridColumn("work_rt").IsMasterData = True

            'Detail 부분
            g10.GridColumn("stop_cd").IsDetailKey = True
            g10.GridColumn("stop_tm1").IsDetailData = True

            '화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다
            'g10.GridColumn("work_mon").DefaultText = work_mon.Text

            Me.Open()

        Catch ex As Exception

            MessageInfo(ex, "Disp_Data()")

        End Try

    End Sub

    Private Sub g10_AddedRow(ByVal sender As Object, ByVal RowIndex As Integer) Handles g10.AddedRow

        If g10.Text("fac_cd", g10.RowIndex) = "" Then
            g10.Text("fac_cd", g10.RowIndex) = fac_cd.Text
        End If
        If g10.Text("wc_cd", g10.RowIndex) = "" Then
            g10.Text("wc_cd", g10.RowIndex) = wc_cd.Text
        End If

    End Sub

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        With g10
            If ColumnName = "work_cnt" Or ColumnName = "work_tm" Or ColumnName = "stop_tm" Then

                Dim ia As Integer
                Dim ib As Integer
                Dim ic As Decimal
                If .ToDec("work_cnt") > 0 And .ToDec("work_tm") > 0 And .ToDec("stop_tm") > 0 Then

                    ia = .ToDec("work_tm") * .ToDec("work_cnt")
                    ib = .ToDec("stop_tm") * .ToDec("work_cnt")
                    ic = 1.0 - ib / ia
                    .Text("work_rt") = ic * 100

                End If
            End If
        End With
    End Sub

    Private Sub g10_InsertedRow(ByVal sender As Object, ByVal RowIndex As Integer) Handles g10.InsertedRow

        If g10.Text("fac_cd", g10.RowIndex) = "" Then
            g10.Text("fac_cd", g10.RowIndex) = fac_cd.Text
        End If
        If g10.Text("wc_cd", g10.RowIndex) = "" Then
            g10.Text("wc_cd", g10.RowIndex) = wc_cd.Text
        End If

    End Sub

End Class
