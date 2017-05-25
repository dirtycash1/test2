Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class LEB152

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

    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.DoubleClick

        Dim menuName As String = "", keyNo As String = ""

        Select Case g10.Text("ent_bc")
            Case "LE910100", "LE910500"     '수주출하, 긴급출하
                menuName = "LEB160"
                keyNo = g10.Text("out_no")
            Case "LE910810"                 '이동출하
                menuName = "LEM120"
                keyNo = g10.Text("mov_no")
            Case "LE910820"                 '출하반품
                menuName = "LEM130"

                Dim f As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
                If f IsNot Nothing Then
                    f.Open2(g10.Text("out_dt"), g10.Text("cust_cd"), g10.Text("fac_cd"), g10.Text("wh_cd"))
                End If
                Exit Sub
            Case Else
                Exit Select
        End Select

        '화면을 띄운다
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName) 'New FormAttribute(menuName, menuText))
        If ctr IsNot Nothing Then
            ctr.Open2(keyNo)
        End If

    End Sub


End Class
