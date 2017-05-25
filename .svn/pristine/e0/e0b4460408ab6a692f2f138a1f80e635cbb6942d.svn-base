Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class PAC100


    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            'Case MenuType.Open

            '    Me.New_Form()

            Case MenuType.Save

                'Me.Save()
                'Me.Open()

            Case MenuType.New

            Case Else

                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    'Private Sub _Open()
    '    '검색필드에 “” 를  설정(검색되지않는 조건)하고 Open()

    '    Me.Open()

    'End Sub

    Private Sub chk_all_Ch1eckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_all.CheckedChanged
        g10.CheckRows("chk1", chk_all.Checked)
    End Sub


    Private Sub chk_start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_start.Click
        Dim cnt As Integer = g10.CheckedRows("chk1")
        If cnt = 0 Then
            MessageInfo("먼저 대상자를 선택하세요")
            Exit Sub
        End If

        If MessageYesNo(cnt.ToString + " 명의 급여소급계산을 하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        End If

        Me._Work("work")
    End Sub


    Private Sub chk_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_del.Click
        Dim cnt As Integer = g10.CheckedRows("chk1")
        If cnt = 0 Then
            MessageInfo("먼저 대상자를 선택하세요")
            Exit Sub
        End If

        If MessageYesNo(cnt.ToString + " 명의 급여소급내역을 삭제하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        End If
        If MessageYesNo("급여소급내역이 삭제됩니다.") = MsgBoxResult.No Then
            Exit Sub
        End If

        Me._Work("delete")
    End Sub


    Private Function _Work(ByVal ty As String) As Boolean

        Dim dTbl As DataTable, dRow As DataRow
        Dim dSet As DataSet = Me.OpenDataSet("pac100_get_data")

        dTbl = dSet.Tables(0)
        With g10
            .UpdateRow()

            dTbl.BeginLoadData()
            For i As Integer = 0 To .RowCount - 1
                If .ToBool("chk1", i) Then
                    dRow = dTbl.NewRow()

                    dRow("emp_no") = .Text("emp_no", i)

                    dTbl.Rows.Add(dRow)
                End If
            Next
            dTbl.EndLoadData()
        End With

        If Me.Save() Then
            If ty = "work" Then
                Me.Open("pac100_work")
            End If
            If ty = "delete" Then
                Me.Open("pac100_delete")
            End If
        End If

    End Function




End Class
