Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class PAU100

    Private Sub fma101_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        MyBase.Open()

        g10.RecordNavigator = True
       

    End Sub

    'Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
    '    Select Case mty

    '        Case MenuType.Open

    '            MyBase.Open()

    '            'Case MenuType.Save
    '            '    If Me.Save() Then
    '            '        Me.Open()
    '            '    End If

    '        Case MenuType.New

    '            MyBase.Open()



    '        Case Else
    '            MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

    '    End Select

    'End Sub
   



    Private Sub btn_work_Click(sender As System.Object, e As System.EventArgs) Handles btn_work.Click
        If MessageYesNo("작업하시겠습니까 ?") = MsgBoxResult.No Then
            Exit Sub
        End If

        Me.Open("pau100_work")
        Me.Open()

    End Sub
End Class
