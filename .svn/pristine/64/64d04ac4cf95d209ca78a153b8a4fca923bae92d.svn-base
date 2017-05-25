Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Math

Public Class QOA500

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                '사용하려면 재정의 가능하다

            Case MenuType.Save
                If MyBase.Save() Then
                    MyBase.Open()
                End If

            Case MenuType.Delete
                'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

            Case MenuType.New
                g20.AddNewRow()

            Case MenuType.Print


            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

End Class
