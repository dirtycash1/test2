Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_SA1500
    Dim p As New OpenParameters

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormOpen()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.FormOpen()
            Case Else
                MyBase.MenuButton_Click(mty)
        End Select
    End Sub

    Private Sub FormOpen()  '조회하기
        'Dim param As OpenParameters = New OpenParameters
        
        If su_gu.Text = "1" Then    '수주
            EPanel2.Text = "개인별 수주 통계"
            EPanel3.Text = "기간별 수주 통계"
            p.Clear()
            p.Add("@fr_dt", fr_dt.Text)
            p.Add("@to_dt", to_dt.Text)
            p.Add("@su_gu", "1")

            g10.Visible = True
            g20.Visible = True
            g10_2.Visible = False
            g20_2.Visible = False
            Me.Open("wi_sa1500_g10", p)
            Me.Open("wi_sa1500_g20", p)

        ElseIf su_gu.Text = "2" Then    '반품
            EPanel2.Text = "개인별 반품 통계"
            EPanel3.Text = "기간별 반품 통계"
            p.Clear()
            p.Add("@fr_dt", fr_dt.Text)
            p.Add("@to_dt", to_dt.Text)
            p.Add("@su_gu", "2")

            g10.Visible = False
            g20.Visible = False
            g10_2.Visible = True
            g20_2.Visible = True

            Me.Open("wi_sa1500_g10_2", p)
            Me.Open("wi_sa1500_g20_2", p)
        End If

    End Sub

End Class
