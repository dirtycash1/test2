Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_CO1200
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.NewForm()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles color_btn.Click
        '170314smk 색상Dialog 선택.
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            gd_cd.BackColor = ColorDialog1.Color
            color_r.Text = ColorDialog1.Color.R
            color_g.Text = ColorDialog1.Color.G
            color_b.Text = ColorDialog1.Color.B
        End If

        'jagu_cd.BackColor = Color.FromArgb(125, 255, 210)
    End Sub


    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Cancel  '취소버튼 클릭시->신규버튼과 같은 기능.
                Me.NewForm()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다
        End Select
    End Sub
    Public Overrides Sub NewForm()  '신규 버튼, 취소버튼 

        find_gd_cd.Text = ""
        gd_cd.Text = ""
        gd_cd.BackColor = Color.Transparent

        Me.OpenTrigger("WI_CO1200_list")    'g_list을 기점으로 OpenTrigger로 작동하는 모든 Control들 조회

        If help_gu.Text = "02" Then  '170314smk 약품코드일때만, 색상선택.
            color_btn.Visible = True

        Else
            color_btn.Visible = False
        End If

        gd_cd.Focus()


    End Sub


    Private Sub find_Clear()
        p.Clear()
        p.Add("@find_gd_cd", find_gd_cd.Text)
        p.Add("@find_gd_nm", find_gd_nm.Text)
        p.Add("@find_jagu_cd", "XXX")
        p.Add("@find_stts", "XXX")
        p.Add("@find_help_gu", "XXX")
        gd_cd.BackColor = Color.Transparent

        Me.Open("WI_CO1200_list", p)
    End Sub


    Private Sub btn_find_Click(sender As Object, e As System.EventArgs) Handles btn_find.Click
        '찾기 리스트 조회
        g_list.Open()

        '170314smk 색상 미저장된 경우는 투명색 설정.
        If color_r.Text = "" Then
            gd_cd.BackColor = Color.Transparent
        Else
            gd_cd.BackColor = Color.FromArgb(ToDec(color_r.Text), ToDec(color_g.Text), ToDec(color_b.Text))
        End If

        If help_gu.Text = "02" Then  '170314smk 약품코드일때만, 색상선택.
            color_btn.Visible = True
        Else
            color_btn.Visible = False
        End If

    End Sub


    Private Sub btn_cancel_Click(sender As Object, e As System.EventArgs) Handles btn_cancel.Click
        Me.find_Clear()
    End Sub


    Private Sub g_list_Click(sender As Object, e As EventArgs) Handles g_list.Click
        '170314smk 색상 미저장된 경우는 투명색 설정.
        If color_r.Text = "" Then
            gd_cd.BackColor = Color.Transparent
        Else
            gd_cd.BackColor = Color.FromArgb(ToDec(color_r.Text), ToDec(color_g.Text), ToDec(color_b.Text))
        End If

        If help_gu.Text = "02" Then  '170314smk 약품코드일때만, 색상선택.
            color_btn.Visible = True
        Else
            color_btn.Visible = False
        End If

    End Sub



    'Private Sub btn_pic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If img.Visible Then
    '        img.Visible = False
    '        Me.SplitContainer3.SplitterDistance = 35
    '    Else
    '        img.Visible = True
    '        Me.SplitContainer3.SplitterDistance = 220
    '    End If
    'End Sub


End Class
