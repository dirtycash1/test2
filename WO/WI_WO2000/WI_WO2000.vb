Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_WO2000
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

    Private Sub btn_button_Click(sender As System.Object, e As System.EventArgs) Handles btn_button.Click
        If MessageYesNo("원가계산을 하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        Else
            p.Clear()
            p.Add("@YM", ym.Text)

            Me.Open("wi_wo2000_multi", p)
        End If
    End Sub
End Class
