Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class COB500

    'Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
    '    Select Case mty
    '        Case MenuType.Open
    '            Me.Open()

    '            'Case MenuType.Save

    '            'Case MenuType.Delete

    '            'Case MenuType.New

    '        Case Else
    '            MyBase.MenuButton_Click(mty)
    '    End Select

    'End Sub

    Private Sub btn_copy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_copy.Click
        If MessageYesNo("복사 하시겠습니까 ? 이전정보는 삭제됩니다.") = MsgBoxResult.No Then
            Exit Sub
        End If
        Me.Open("cob500_copy")
    End Sub

End Class
