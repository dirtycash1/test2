Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class LEJ400

    ''체크와웃테스트
    Private Sub LEJ300_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.Open()

        ''자재 출고 번호 채번
        'out_no.CodeNo = "LEB100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        'out_no.CodeDateField = out_dt
    End Sub


    Private Sub _Work()
        If MessageYesNo("재고조정 하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        End If

        If Me._Save() Then
            Dim dSet2 As DataSet = Me.OpenDataSet("lej400_work")
            If Not IsEmpty(dSet2) Then
                Me.Open()
            End If
        End If
    End Sub

    Private Sub _Delete()
        If MessageYesNo("재고조정 삭제하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        End If

        If Me._Save() Then
            Dim dSet2 As DataSet = Me.OpenDataSet("lej400_delete")
            If Not IsEmpty(dSet2) Then
                Me.Open()
            End If
        End If
    End Sub

    Private Function _Save() As Boolean
        Dim dTbl As DataTable, dRow As DataRow
        Dim dSet As DataSet = Me.OpenDataSet("lej400_save_data")

        dTbl = dSet.Tables(0)
        With g10
            .UpdateRow()

            dTbl.BeginLoadData()
            For i As Integer = 0 To .RowCount - 1
                If .ToBool("chk", i) Then
                    dRow = dTbl.NewRow()

                    dRow("out_mon") = std_month.Text
                    dRow("fac_cd") = fac_cd.Text
                    dRow("wh_cd") = wh_cd.Text
                    dRow("itm_id") = .Text("itm_id", i)
                    dRow("out_qty") = .ToDec("adj_qty", i)
                    dRow("um_bc") = .Text("um_bc", i)

                    dTbl.Rows.Add(dRow)
                End If
            Next
            dTbl.EndLoadData()
        End With

        Return Me.Save()

    End Function


    Private s As Boolean
    Private Sub g10_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging
        Dim adjQty As Double

        If s Then
            Exit Sub
        End If

        s = True

        If ColumnName = "chk" Then
            If Value = "1" Then

                If g10.ToDec("itm_cnt") = 0 Then
                    MessageInfo("생산품이 없으면 재고조정 할 수 없습니다.")
                    g10.UpdateRow()
                    Exit Sub
                End If

                If g10.ToDec("real_qty") = 0 Then
                    g10.Text("real_qty") = "0"
                    g10.Text("adj_qty") = g10.ToDec("end_qty")
                End If
                'adjQty = g10.ToDec("end_qty") - g10.ToDec("real_qty")
                'If adjQty <> 0 And g10.ToDec("real_qty") <> 0 Then
                '    g10.Text("adj_qty") = adjQty

                'Else
                '    g10.Text("chk") = "0"
                '    g10.Text("real_qty") = "0"
                '    g10.Text("adj_qty") = "0"
                'End If
            Else
                g10.Text("real_qty") = "0"
                g10.Text("adj_qty") = "0"

            End If
        End If

        If ColumnName = "real_qty" Then
            If Value <> "" Then
                g10.Text("chk") = "1"
                adjQty = g10.ToDec("end_qty") - ToDec(Value) 'g10.ToDec("real_qty")
                g10.Text("adj_qty") = adjQty
            End If
        End If

        s = False

    End Sub


    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        With g10
            If ColumnName = "real_qty" Then
                If .ToBool("chk") Then
                    .Text("adj_qty") = .ToDec("end_qty") - .ToDec("real_qty")
                Else
                    's = True
                    '.Text("chk") = "1"
                    's = False
                End If
            End If
        End With

    End Sub



    Private Sub btn_work_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_work.Click
        If Not CheckRequired(std_month, fac_cd, wh_cd) Then
            Exit Sub
        End If

        If g10.CheckedRows("chk") = 0 Then
            Exit Sub
        End If

        '작업전 체크
        With g10
            For i As Integer = 0 To .RowCount - 1
                If .ToBool("chk", i) Then

                    If .ToDec("itm_cnt", i) = 0 Then
                        MessageInfo("생산품이 없는 자재가 있습니다")
                        Exit Sub
                    End If

                End If
            Next
        End With

        '작업시작
        Me._Work()
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        If Not CheckRequired(std_month, fac_cd, wh_cd) Then
            Exit Sub
        End If

        If g10.CheckedRows("chk") = 0 Then
            Exit Sub
        End If

        '작업시작
        Me._Delete()
    End Sub

End Class
