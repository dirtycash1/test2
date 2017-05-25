Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WP_PR1121
    'Dim p As New OpenParameters

    'Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    Me.Clear()
    'End Sub

    'Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
    '    Select Case mty
    '        'Case MenuType.Open
    '        '    MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
    '        '    '사용하려면 재정의 가능하다
    '        Case MenuType.Save

    '            If Not Saves() Then Exit Sub

    '            'Case MenuType.New
    '            '    cust_cd.Text = ""
    '            '    itm_cd.Text = ""
    '            '    itm_nm.Text = ""
    '            '    emp_id.Text = ""
    '            '    emp_nm.Text = ""

    '            '    Me.New_Form()

    '        Case Else
    '            MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

    '    End Select

    'End Sub

    'Private Sub Clear()
    '    p.Clear()

    '    p.Add("@find_sa_cd", find_sa_cd.Text)
    '    p.Add("@find_wh_cd", find_wh_cd.Text)
    '    p.Add("@find_lot_no", "XXX")
    '    p.Add("@find_nm_cd", find_nm_cd.Text)


    '    Me.Open("wi_pr1117_multi", p)
    'End Sub

    'Private Sub btn_chk_Click(sender As Object, e As System.EventArgs)
    '    'Dim s As String = "0"
    '    'If btn_chk.Text = "전체선택" Then
    '    '    s = "1"
    '    '    btn_chk.Text = "전체해제"
    '    'Else
    '    '    btn_chk.Text = "전체선택"
    '    'End If

    '    'With g_result
    '    '    For i As Integer = 0 To .RowCount - 1
    '    '        .Text("CHK", i) = s
    '    '    Next
    '    'End With

    'End Sub

    'Private Function Saves() As Boolean

    '    If MessageYesNo("분리생산지시를 일괄 생성 하시겠습니까?") = MsgBoxResult.No Then
    '        Exit Function
    '    Else

    '        If MyBase.Save() Then
    '            'MyBase.OpenTrigger("wi_sa1120_list")
    '        End If

    '        Me.Clear()

    '    End If


    '    Return True
    'End Function

End Class
