Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAF300

    'Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    Me.New_Form()
    'End Sub

    'Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
    '    Select Case mty
    '        'Case MenuType.Open
    '        '    MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
    '        '    '사용하려면 재정의 가능하다
    '        'Case MenuType.Save

    '        Case MenuType.New
    '            cust_cd.Text = ""
    '            itm_cd.Text = ""
    '            itm_nm.Text = ""
    '            emp_id.Text = ""
    '            emp_nm.Text = ""

    '            Me.New_Form()

    '        Case Else
    '            MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

    '    End Select

    'End Sub

    'Public Sub New_Form()
    '    Me.Open()

    'End Sub

    Private Sub SimpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        If MessageYesNo("계획년월의 정보는 삭제되고 기준년월의 금액을 가져옵니다. 계속하시겠습니까?", "경고!!") = MsgBoxResult.No Then
            Exit Sub
        End If

        MyBase.Open("faf300_copy")
        MyBase.Open("faf300_g10")
    End Sub

End Class
