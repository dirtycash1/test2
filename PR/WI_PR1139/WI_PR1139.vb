Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_PR1139
    Dim p As New OpenParameters

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
            Case MenuType.Print
                'Me.Print()
                Me.Open()
            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub


    'Private Sub chk_all_CheckedChanged(sender As System.Object, e As System.EventArgs)
    '    If chk_all.Checked Then
    '        For i = 0 To g10.RowCount - 1
    '            g10.Text("chk", i) = "1"
    '        Next
    '    Else
    '        For i = 0 To g10.RowCount - 1
    '            g10.Text("chk", i) = "0"
    '        Next
    '    End If
    'End Sub

    'Private Sub Print()
    '    If Me.Save() Then
    '        Dim p As OpenParameters = New OpenParameters
    '        'p.Add("@pr_no", g10.Text("PR_NO"))
    '        'p.Add("@chk", g10.Text("chk"))
    '        p.Add("@fr_dt", fr_dt.Text)
    '        p.Add("@to_dt", to_dt.Text)
    '        System7.ReportView.LoadView("WI_PR1139", "", "WI_PR1139_print", p)
    '    End If
    'End Sub
End Class
