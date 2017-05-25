Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_SA1121_2
    Dim p As New OpenParameters

    Private Sub OD_TO_TextChanged(sender As System.Object, e As System.EventArgs) Handles OD_TO.TextChanged

    End Sub

    Private Sub btn_chk_Click(sender As System.Object, e As System.EventArgs)
        'Dim s As String = "0"
        'If btn_chk.Text = "전체선택" Then
        '    s = "1"
        '    btn_chk.Text = "전체해제"
        'Else
        '    btn_chk.Text = "전체선택"
        'End If

        'With g10
        '    For i As Integer = 0 To .RowCount - 1
        '        .Text("CHK", i) = s
        '    Next
        'End With
    End Sub

    Private Sub btn_all_ok_Click(sender As System.Object, e As System.EventArgs) Handles btn_all_ok.Click
        Dim s As String = "0"
        If btn_all_ok.Text = "전체선택" Then
            s = "1"
            btn_all_ok.Text = "전체해제"
        Else
            btn_all_ok.Text = "전체선택"
        End If

        With g10
            For i As Integer = 0 To .RowCount - 1
                .Text("CHK", i) = s
            Next
        End With
    End Sub
End Class
