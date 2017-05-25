Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class PPC110

    Private Sub PPC110_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Me.Open()

    End Sub
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                If Not CheckRequired(fac_f_cd, wc_f_cd) Then
                    Exit Sub
                End If
                MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 

            Case MenuType.Save
                If MyBase.Save() Then
                    MyBase.Open()
                End If

            Case MenuType.Delete
                'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

            Case MenuType.New
                Me.Open()
                'Me.WorkSets("ppc110_g20").AddNew()  '특정Workset 신규처리

            Case MenuType.Print
                ' Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

End Class
