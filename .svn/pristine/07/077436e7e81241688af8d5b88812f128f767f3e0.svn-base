Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAR110

     Private Sub btn_work_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_work.Click
        If CheckRequired(co_cd, doc_mon) = False Then Exit Sub
        If MessageYesNo("[계산] 작업을 진행하시겠습니까?") <> MsgBoxResult.Yes Then Exit Sub

        Me.Open("far110_work")
        Me.Open()
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        If CheckRequired(co_cd, doc_mon) = False Then Exit Sub
        If MessageYesNo("[삭제] 작업을 진행하시겠습니까?") <> MsgBoxResult.Yes Then Exit Sub

        Me.Open("far110_delete")
        Me.Open()
    End Sub

    'Private Sub Work(GetWorkSet As String)
    '    Try
    '        Dim dSet As DataSet = OpenDataSet(GetWorkSet)
    '        Dim Msg As String = DataValue(dSet)
    '        If Msg = "OK" Then
    '            Open()
    '        Else
    '            MessageWarning(Msg)
    '        End If

    '    Catch ex As Exception
    '        MessageError(ex)
    '    End Try
    'End Sub

    Private Sub btn_doc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_doc.Click
        If MessageYesNo("전표를 생성하시겠습니까 ?") = MsgBoxResult.No Then
            Exit Sub
        End If

        Me.Open("far110_doc_work")

        Me.Open()
    End Sub

    Private Sub btn_doc_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_doc_del.Click
        If MessageYesNo("전표를 삭제하시겠습니까 ?") = MsgBoxResult.No Then
            Exit Sub
        End If

        Me.Open("far110_doc_delete")

        Me.Open()
    End Sub

    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.DoubleClick
        Dim menuName As String = "FAB100"
        With g10
            If .Text("doc_no2") = "" Then
                MessageInfo("연결된 전표가 없습니다.")
                Exit Sub
            End If

            Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
            If ctr IsNot Nothing Then
                ctr.Open2(.Text("doc_no2"))
            End If
        End With
    End Sub

End Class
