Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WP_PR1120

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.Open()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            'Case MenuType.Open
            '    MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
            '    '사용하려면 재정의 가능하다
            Case MenuType.Save

                If Me.Save() Then
                    Me.Open()
                End If
                'Case MenuType.New
                '    cust_cd.Text = ""
                '    itm_cd.Text = ""
                '    itm_nm.Text = ""
                '    emp_id.Text = ""
                '    emp_nm.Text = ""

                '    Me.New_Form()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    'Public Sub New_Form()
    '    Me.Open()

    'End Sub
    Private Sub g_result_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g_result.DoubleClick

        If g_result.Text("GONG_CD") = "00" Then
            jump_open("WI_PR1121", g_result.Text("PR_NO"))
        ElseIf g_result.Text("GONG_CD") = "10" Then ' 사출
            jump_open("WI_PR1122", g_result.Text("PR_NO"))
        ElseIf g_result.Text("GONG_CD") = "20" Then ' 분리
            jump_open("WI_PR1123", g_result.Text("PR_NO"))
        ElseIf g_result.Text("GONG_CD") = "40" Or "50" Or "55" Or "70" Or "80" Then
            jump_open("WI_PR1124", g_result.Text("PR_NO"))
        End If
    End Sub
    Private Sub jump_open(ByVal lparam As String, ByVal wparam As String)

        Dim menuName As String = lparam
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
        ctr.Open3(wparam)
    End Sub

End Class
