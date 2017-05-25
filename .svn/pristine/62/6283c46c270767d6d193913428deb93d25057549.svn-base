Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class LEA503
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                '사용하려면 재정의 가능하다
            Case MenuType.Save
                'If MyBase.Save() Then

                'MyBase.Open()
                ' End If

            Case MenuType.Delete
                'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

            Case MenuType.New
                'Me.New_Form()

            Case MenuType.Print
                Call print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub print()


        Dim p As OpenParameters = New OpenParameters

        p.Add("@co_cd", co_cd.Text)
        p.Add("@sum_mon", sum_mon.Text)
        p.Add("@itm_bc", itm_bc.Text)
        p.Add("@itm_cd", itm_cd.Text)
        p.Add("@itm_nm", itm_nm.Text)
        p.Add("@cust_cd", cust_cd.Text)

        System7.ReportView.LoadView("LEA503", "", "LEA503_Print", p)


    End Sub

End Class
