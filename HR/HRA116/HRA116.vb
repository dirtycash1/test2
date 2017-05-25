Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class HRA116

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                'If MessageYesNo("[급여기준] 자료가 없으면 해당 사원은 조회되지 않습니다." + vbLf +
                '                "계속 진행하시겠습니까?.") <> MsgBoxResult.Yes Then
                '    Exit Sub
                'End If

                Me.Open()
                '        Case MenuType.Save

                '            'If Me.Save() Then
                '            '    Me.Open()
                '            'End If

                '        Case MenuType.New
                '            Me.Open()

                '        Case MenuType.Print
                '            'Me.Print()
                '        Case Else
                '            MyBase.MenuButton_Click(mty)
        End Select

    End Sub


End Class
