Imports Frame7
Imports Base7
Imports Base7.Shared

    Public Class FAB140

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                MyBase.Open()
                chk_all.Checked = False

            Case MenuType.Print
                Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Public Overrides Function Save() As Boolean
        Return MyBase.Save()
    End Function

    Private Sub chk_prt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        g10.CheckRows("prt", chk_all.Checked)

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
