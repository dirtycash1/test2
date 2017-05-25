Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAB120

    Private Sub FAB120_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        apr_dt.TitleBackColor = Color.Transparent
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open


                MyBase.Open()
                chk_all.Checked = False

                'If stat_bc.Text = "FA350100" Then
                '    btn_apply.Text = "승인 처리"
                'Else
                '    btn_apply.Text = "승인 취소"
                'End If

                'Case MenuType.Save
                '    MyBase.Save()
                '    MyBase.Open()

                'Case MenuType.Delete
                '    Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

            Case MenuType.Print
                Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub chk_all_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_all.CheckedChanged
        g10.StopOpenEvent = True
        g10.CheckRows("chk", chk_all.Checked)
        g10.StopOpenEvent = False

        If g10.RowCount > 0 Then
            g10.RowIndex = 0
        End If
    End Sub

    Private Sub chk_prt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_prt.CheckedChanged
        g10.StopOpenEvent = True
        g10.CheckRows("prt", chk_prt.Checked)
        g10.StopOpenEvent = False

        If g10.RowCount > 0 Then
            g10.RowIndex = 0
        End If
    End Sub

    '[승인처리/취소]

    '승인일 지정 승인 처리
    Private Sub btn_apply_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_apply.Click
        If Not CheckRequired(apr_dt) Then
            Exit Sub
        End If
        Me._Work(apr_dt.Text)
    End Sub

    '발의일로 승인 처리
    Private Sub btn_apply2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_apply2.Click
        Me._Work("")
    End Sub

    Private Sub _Work(aprDate As String)
        If g10.CheckedRows("chk") = 0 Then
            MessageInfo("선택된 행이 없습니다.")
            Exit Sub
        End If
        If MessageYesNo("승인처리 하시겠습니까 ?") = MsgBoxResult.Yes Then
            For i = 0 To g10.RowCount - 1
                If g10.Text("chk", i) = "1" Then
                    If g10.Text("apr_dt", i) <> "" Then
                        MessageInfo("이미 승인된 건이 있습니다.")
                        Exit Sub
                    End If

                    If aprDate <> "" Then
                        If g10.Text("doc_dt", i).Substring(0, 4) <> aprDate.Substring(0, 4) Then
                            MessageInfo("전표일과 승인일의 년도가 틀립니다.")
                            Exit Sub
                        End If
                        g10.Text("apr_dt", i) = aprDate
                    Else
                        g10.Text("apr_dt", i) = g10.Text("doc_dt", i)
                    End If

                    If g10.Text("amt1", i) <> g10.Text("amt2", i) Then
                        MessageInfo("차/대변이 틀린 전표가 존재합니다.")
                        Exit Sub
                    End If
                End If
            Next

            Me._Save("1")
        End If
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        If MessageYesNo("승인취소 하시겠습니까 ?") = MsgBoxResult.Yes Then
            Me._Save("0")
        End If
    End Sub

    Private Sub _Save(ByVal ty As String)
        For i = 0 To g10.RowCount - 1
            If g10.Text("chk", i) = "1" Then
                g10.Text("ty", i) = ty '승인
            End If
        Next
        If Me.Save() Then
            Me.Open()
            chk_all.Checked = False
        End If
    End Sub

    Private Sub Print()

        Dim cnt As Integer = g10.CheckedRows("prt")     'Check된 행의 갯수
        If cnt = 0 Then
            Exit Sub
        End If

        Dim preview As Boolean
        If cnt = 1 Then             'Check된 행이 하나이면 리포트 미리보기를 하고 아니면 바로 출력한다
            preview = True
        End If

        For i As Integer = 0 To g10.RowCount - 1
            If g10.ToBool("prt", i) Then
                Dim p As OpenParameters = New OpenParameters

                p.Add("@co_cd", g10.Text("co_cd", i))
                p.Add("@div_cd", g10.Text("div_cd", i))
                p.Add("@doc_no", g10.Text("doc_no", i))

                System7.ReportView.LoadView("FAB101", "", "fab100_print", p, , preview)     '전표출력
            End If
        Next

    End Sub

    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.DoubleClick
        Dim menuName As String
        menuName = "FAB100"

        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
        If ctr IsNot Nothing Then
            ctr.Open2(g10.Text("doc_no"))
        End If
    End Sub

End Class
