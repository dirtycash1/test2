Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_JA3000

    Private Sub but_work_Click(sender As System.Object, e As System.EventArgs) Handles but_work.Click
        If MessageYesNo("재고월마감을 실행하시겠습니까?", "주의!!") = MsgBoxResult.No Then
            Exit Sub
        End If

        'If Not Me.Save() Then
        '    Exit Sub
        'End If

        Me.Open("WI_JA3000_work")

    End Sub
End Class
