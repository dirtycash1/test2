Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class PAB109

    Private Sub chk_doc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_doc.Click
        If doc_no.Text <> "" Then
            MessageInfo("먼저 전표를 삭제 하세요")
            Exit Sub
        End If

        If MessageYesNo("전표를 생성하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        End If

        Me.Open("pab109_work")
        Me.Open("pab109_f10")

    End Sub

    Private Sub chk_del_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_del.Click
        If doc_no.Text = "" Then
            MessageInfo("먼저 전표를 선택하세요")
            Exit Sub
        End If

        If MessageYesNo("전표를 삭제하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        End If

        Me.Open("pab109_delete")
        Me.Open("pab109_f10")

    End Sub

    Private Sub btn_jump_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_jump.Click
        If doc_no.Text = "" Then
            Exit Sub
        End If

        Dim menuName As String
        menuName = "FAB100"

        '화면을 띄운다
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
        If ctr IsNot Nothing Then
            ctr.Open2(doc_no.Text)
        End If
    End Sub

    'Private Function _Work(ByVal ty As String) As Boolean

    '    Dim dTbl As DataTable, dRow As DataRow
    '    Dim dSet As DataSet = Me.OpenDataSet("pab100_get_data")

    '    dTbl = dSet.Tables(0)
    '    With g10
    '        .UpdateRow()

    '        dTbl.BeginLoadData()
    '        For i As Integer = 0 To .RowCount - 1
    '            If .ToBool("chk1", i) Then
    '                dRow = dTbl.NewRow()

    '                dRow("emp_no") = .Text("emp_no", i)

    '                dTbl.Rows.Add(dRow)
    '            End If
    '        Next
    '        dTbl.EndLoadData()
    '    End With

    '    If Me.Save() Then
    '        If ty = "work" Then
    '            Me.Open("pab100_work")
    '        End If
    '        If ty = "delete" Then
    '            Me.Open("pab100_delete")
    '        End If
    '    End If

    'End Function



    Private Sub pay_sq_TextChanging(ByVal sender As Object, ByVal e As System.EventArgs) Handles pay_sq.TextChanging

        If pay_sq.Text = "" Then
            doc_no.Text = ""
        Else
            Open("pab109_f10")
        End If

    End Sub


End Class
