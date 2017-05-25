Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class PPB200

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open()
                Me.AddNew(g10.WorkSet)  '특정Workset 신규처리

            Case MenuType.Save
                If MyBase.Save() Then
                    MyBase.Open()
                End If

            Case MenuType.New
                g10.AddNewRow()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select
    End Sub

End Class
