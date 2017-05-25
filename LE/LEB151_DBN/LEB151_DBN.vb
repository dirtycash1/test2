Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class LEB151_DBN

    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.DoubleClick

        Dim menuName As String = "LEB160DBN"
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)

        ctr.Open2(g10.Text("out_no"))

    End Sub

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

    Private Sub g10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g10.Load

    End Sub


End Class
