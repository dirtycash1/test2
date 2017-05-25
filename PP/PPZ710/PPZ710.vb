Imports Frame7
Imports Base7
Imports Base7.Shared
Public Class PPZ710

    Private Sub PPZ710_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Open()
        g10.AddNewRow()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                MyBase.Open()
                g10.AddNewRow()

            Case MenuType.Save
                If MyBase.Save() Then
                    MyBase.Open()
                    g10.AddNewRow()
                End If

            Case MenuType.Delete
                'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

            Case MenuType.New
                ' Me.WorkSets("lea200_g10").AddNew()  '특정Workset 신규처리
                'New_Form()
            Case MenuType.Print
                ' Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub
End Class
