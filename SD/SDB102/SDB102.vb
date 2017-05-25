Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class SDB102


    Private Sub SDB102_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        chk_all.Checked = False

    End Sub

    'Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
    '    Select Case mty
    '        Case MenuType.Open
    '            MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
    '            '사용하려면 재정의 가능하다
    '        Case MenuType.Save
    '            'If MyBase.Save() Then

    '            ' MyBase.Open()
    '            'End If

    '        Case MenuType.Delete
    '            'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

    '        Case MenuType.New
    '            ' Me.WorkSets("mma100_g10").AddNew()  '특정Workset 신규처리

    '        Case MenuType.Print
    '            ' Me.Print()

    '        Case Else
    '            MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

    '    End Select

    'End Sub


    Private Sub btn_jump_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_jump.Click

        Dim menuName As String = "SDB100"
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)

        ctr.Open2(g10.Text("so_no"))

    End Sub

    Private Sub btn_stop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_stop.Click

        With g20
            For i = 0 To .RowCount - 1
                If .ToBool("chk", i) AndAlso (.Text("stat_bc", i).EndsWith("500") Or .Text("stat_bc", i).EndsWith("700")) Then
                    MessageInfo("이미 완결된 행이 있습니다.")
                    Exit Sub
                End If
            Next
            For i = 0 To .RowCount - 1
                If .ToBool("chk", i) Then
                    .Text("stat", i) = "700"
                End If
            Next
        End With

        If Me.Save() Then
            g20.Open()
        End If
    End Sub

    Private Sub btn_undo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_undo.Click
        With g20
            For i = 0 To .RowCount - 1
                If .ToBool("chk", i) AndAlso Not .Text("stat_bc", i).EndsWith("700") Then
                    MessageInfo("강제완결된 행만 취소가능합니다.")
                    Exit Sub
                End If
            Next
            For i = 0 To .RowCount - 1
                If .ToBool("chk", i) Then
                    .Text("stat", i) = "100"
                End If
            Next
        End With

        If Me.Save() Then
            g20.Open()
        End If

    End Sub

    Private Sub chk_all_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_all.CheckedChanged

        g20.CheckRows("chk", chk_all.Checked)

    End Sub
End Class
