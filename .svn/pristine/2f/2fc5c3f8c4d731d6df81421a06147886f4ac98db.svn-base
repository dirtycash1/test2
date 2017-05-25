Imports Frame7
Imports Base7
Imports Base7.Shared




Public Class MMA110


    Private Sub MMA110_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Open()

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                '사용하려면 재정의 가능하다
            Case MenuType.Save
                If MyBase.Save() Then

                    MyBase.Open()
                End If

            Case MenuType.Delete
                'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

            Case MenuType.New
                ' Me.WorkSets("mma100_g10").AddNew()  '특정Workset 신규처리

            Case MenuType.Print
                ' Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub btn_do_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_do.Click

        For i = 0 To g10.RowCount - 1
            If g10.Text("chk", i) = "1" Then
                If g10.Text("stat_bc", i) = "MM040100" Then
                    g10.Text("stat", i) = "7"
                Else
                    MsgBox("의뢰 진행상태가 진행중인 의뢰번호는 강제완결 처리가 불가 합니다")
                    Exit Sub

                End If
            End If
        Next

        If Me.Save() Then
            Me.Open()
        End If


        ' Dim p As New OpenParameters

        ' p.Add("@req_no", g10.Text("req_no", g10.RowIndex))
        ' p.Add("@req_sq", g10.Text("req_sq", g10.RowIndex))
        ' p.Add("@stat", "7")

        ' Me.OpenDataSet("mma110_stat", p)
        ' Me.Open()

    End Sub

    Private Sub btn_undo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_undo.Click

        For i = 0 To g10.RowCount - 1
            If g10.Text("chk", i) = "1" Then

                If g10.Text("stat_bc", i) = "MM040700" Then
                    g10.Text("stat", i) = "1"
                Else
                    MsgBox("의뢰 진행상태가 강제완결만 취소 가능 합니다")
                    Exit Sub
                End If
            End If
        Next

        If Me.Save() Then
            Me.Open()
        End If
    End Sub

    'Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    For i = 0 To g10.RowCount - 1
    '        If g10.Text("chk", i) = "1" Then
    '            If g10.Text("stat_bc", i) = "MM040100" Then
    '                g10.Text("stat", i) = "9"
    '            Else
    '                MsgBox("의뢰 진행상태가 진행중인 의뢰번호는 취소 불가 합니다")
    '                Exit Sub

    '            End If
    '        End If
    '    Next

    '    If Me.Save() Then
    '        Me.Open()
    '    End If
    'End Sub

End Class
