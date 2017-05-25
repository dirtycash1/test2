Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WP_SA1400
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.Open()
        p.Clear()

        p.Add("@find_chk", "XXX")
        p.Add("@find_model_no", "XXX")
        p.Add("@find_nm_cd", "XXX")
        p.Add("@find_sa_cd", "XXX")
        p.Add("@find_wh_cd", "XXX")

        Me.Open("wp_sa1400", p)
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

End Class
