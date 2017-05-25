Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Math

Public Class QOA701

    Private Sub QOA701_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '의사소통번호 채번
        com_no.CodeNo = "QOA700"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        com_no.CodeDateField = com_dt
        MyBase.Open()

    End Sub

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
                g10.AddNewRow()

            Case MenuType.Print


            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

End Class
