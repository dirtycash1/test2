Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class LEJ500

    ''체크와웃테스트
    Private Sub LEJ300_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.Open()

        ''자재 출고 번호 채번
        'out_no.CodeNo = "LEB100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        'out_no.CodeDateField = out_dt
    End Sub


    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                MyBase.Open()

                chk_all.Checked = False

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub _Work()
        If MessageYesNo("재출고 하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        End If

        If Me._Save() Then
            Dim dSet2 As DataSet = Me.OpenDataSet("lej500_work")
            If Not IsEmpty(dSet2) Then
                'Dim s1 As String, s2 As String, s3 As String
                's1 = g10.Text("fac_cd")
                's2 = g10.Text("wc_cd")
                's3 = g10.Text("itm_cd")
                Dim i As Integer = g10.RowIndex

                Me.Open()

                g10.RowIndex = i
                'g10.Find("fac_cd=" + s1 + ",wc_cd=" + s2 + ",itm_cd=" + s3)

            End If
        End If
    End Sub

    Private Sub _Delete()
        If MessageYesNo("자재출고를 삭제하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        End If

        If Me._Save() Then
            Dim dSet2 As DataSet = Me.OpenDataSet("lej500_delete")
            If Not IsEmpty(dSet2) Then
                Me.Open()
            End If
        End If
    End Sub

    Private Function _Save() As Boolean
        Dim dTbl As DataTable, dRow As DataRow
        Dim dSet As DataSet = Me.OpenDataSet("lej500_save_data")

        dTbl = dSet.Tables(0)
        With g10
            .UpdateRow()

            dTbl.BeginLoadData()
            For i As Integer = 0 To .RowCount - 1
                If .ToBool("chk", i) Then
                    dRow = dTbl.NewRow()

                    'dRow("out_mon") = std_month.Text
                    dRow("fac_cd") = fac_cd.Text
                    dRow("wc_cd") = .Text("wc_cd", i)
                    dRow("itm_id") = .Text("itm_id", i)
                    'dRow("work_qty") = .Text("work_qty", i)
                    'dRow("um_bc") = .Text("um_bc", i)

                    dTbl.Rows.Add(dRow)
                End If
            Next
            dTbl.EndLoadData()
        End With

        Return Me.Save()

    End Function


    'Private s As Boolean
    'Private Sub g10_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging
    '    Dim adjQty As Double

    '    If s Then
    '        Exit Sub
    '    End If

    '    s = True

    '    If ColumnName = "chk" Then
    '        If Value = "1" Then

    '            If g10.ToDec("itm_cnt") = 0 Then
    '                MessageInfo("생산품이 없으면 재고조정 할 수 없습니다.")
    '                g10.UpdateRow()
    '                Exit Sub
    '            End If

    '            If g10.ToDec("real_qty") = 0 Then
    '                g10.Text("real_qty") = "0"
    '                g10.Text("adj_qty") = g10.ToDec("end_qty")
    '            End If
    '            'adjQty = g10.ToDec("end_qty") - g10.ToDec("real_qty")
    '            'If adjQty <> 0 And g10.ToDec("real_qty") <> 0 Then
    '            '    g10.Text("adj_qty") = adjQty

    '            'Else
    '            '    g10.Text("chk") = "0"
    '            '    g10.Text("real_qty") = "0"
    '            '    g10.Text("adj_qty") = "0"
    '            'End If
    '        Else
    '            g10.Text("real_qty") = "0"
    '            g10.Text("adj_qty") = "0"

    '        End If
    '    End If

    '    If ColumnName = "real_qty" Then
    '        If Value <> "" Then
    '            g10.Text("chk") = "1"
    '            adjQty = g10.ToDec("end_qty") - ToDec(Value) 'g10.ToDec("real_qty")
    '            g10.Text("adj_qty") = adjQty
    '        End If
    '    End If

    '    s = False

    'End Sub


    'Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
    '    With g10
    '        If ColumnName = "real_qty" Then
    '            If .ToBool("chk") Then
    '                .Text("adj_qty") = .ToDec("end_qty") - .ToDec("real_qty")
    '            End If
    '        End If
    '    End With
    'End Sub

    '재출고
    Private Sub btn_work_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_work.Click
        If Not CheckRequired(std_month, fac_cd) Then
            Exit Sub
        End If

        If g10.CheckedRows("chk") = 0 Then
            Exit Sub
        End If

        ''작업전 체크
        'With g10
        '    For i As Integer = 0 To .RowCount - 1
        '        If .ToBool("chk", i) Then

        '            If .ToDec("itm_cnt", i) = 0 Then
        '                MessageInfo("생산품이 없는 자재가 있습니다")
        '                Exit Sub
        '            End If

        '        End If
        '    Next
        'End With

        '작업시작
        Me._Work()
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not CheckRequired(std_month, fac_cd) Then
            Exit Sub
        End If

        If g10.CheckedRows("chk") = 0 Then
            Exit Sub
        End If

        '작업시작
        Me._Delete()
    End Sub

    Private Sub chk_all_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_all.CheckedChanged
        g10.CheckRows("chk", chk_all.Checked)
    End Sub

    Private s As Boolean
    Private Sub g20_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g20.CellValueChanged
        With g20
            If s Then
                Exit Sub
            End If
            s = True

            If ColumnName = "add_qty" Then
                If .Text("add_qty") = "" Then
                    .Text("end_qty") = ""
                Else
                    .Text("end_qty") = .ToDec("out_qty") + .ToDec("add_qty")
                End If
            End If
                If ColumnName = "end_qty" Then
                If .Text("end_qty") = "" Then
                    .Text("add_qty") = ""
                Else
                    .Text("add_qty") = .ToDec("end_qty") - .ToDec("out_qty")
                End If
                End If

                s = False
        End With
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If Me.Save(g20.WorkSet) Then
            g20.Open()
        End If
    End Sub
End Class
