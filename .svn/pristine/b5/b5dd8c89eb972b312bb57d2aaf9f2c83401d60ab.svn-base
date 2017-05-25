Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAR300

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Save

                Me.Save("far300_g20")
                Me.Save("far300_g30")
                Me.Save("far300_g40")

            Case Else
                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    Private Sub SetKeyField()
        'sys_cd.Visible = (XtraTabControl1.SelectedTabPageIndex = 0)
        'co_cd.Visible = Not sys_cd.Visible
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        'SetKeyField()
    End Sub

    Private Sub btn_work_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_work.Click
        If MessageYesNo("전표를 생성하시겠습니까 ?") = MsgBoxResult.No Then
            Exit Sub
        End If

        g10.SaveValue("cdt", Now)
        If Me.Save() Then
            Dim p As New OpenParameters

            p.Add("@co_cd", co_cd.Text)
            p.Add("@cury_bc", cury_bc.Text)
            p.Add("@ex_rt", ex_rt.Text)
            p.Add("@std_mon", std_mon.Text)

            Me.Open("far300_work", p)

            g20.Open()
        End If

    End Sub

    Private Sub g20_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g20.DoubleClick
        Dim menuName As String = "FAB100"
        With g20
            If .Text("doc_no") = "" Then
                MessageInfo("연결된 전표가 없습니다.")
                Exit Sub
            End If

            Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
            If ctr IsNot Nothing Then
                ctr.Open2(.Text("doc_no"))
            End If
        End With
    End Sub
End Class
