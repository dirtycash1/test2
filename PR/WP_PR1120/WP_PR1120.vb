Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WP_PR1120
    Dim p As OpenParameters = New OpenParameters

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

            Case MenuType.Open
                'Me.Open_Form()

                p.Add("@chk1", chk1.Text)
                p.Add("@find_from", find_from.Text)
                p.Add("@find_to", find_to.Text)
                p.Add("@find_model_no", find_model_no.Text)
                p.Add("@find_nm_cd", find_nm_cd.Text)
                p.Add("@kijong_cd", kijong_cd.Text)
                p.Add("@gong_cd", gong_cd.Text)
                p.Add("@fac_cd", fac_cd.Text)
                p.Add("@LOT_NO", LOT_NO.Text)

                If chk2.Checked = True Then  '체크되면(전체조회)
                    p.Add("@chk2", "1")
                Else                          '체크해제(R만조회)
                    p.Add("@chk2", "0")
                End If

                Me.Open("wp_pr1120", p)

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub


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

    Private Sub LOT_NO_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles LOT_NO.KeyDown
        If e.KeyCode = Keys.Enter Then
            MenuButton_Click(MenuType.Open)
        End If
    End Sub

End Class
