Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_WO1352
    Dim p As New OpenParameters
    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Open()
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


    Private Sub btn_exec_Click(sender As Object, e As System.EventArgs) Handles btn_exec.Click
        If MessageYesNo("외주실적 계산 하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        Else
            p.Clear()
            p.Add("@ym", find_ym.Text)

            Me.Open("wi_wo1352_exec", p)

            Me.Open()

        End If
    End Sub
End Class
