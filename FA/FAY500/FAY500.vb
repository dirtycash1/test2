Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAY500

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                If fr_acc_cd.Text <> "" And to_acc_cd.Text = "" Then
                    to_acc_cd.Text = fr_acc_cd.Text
                End If

                If XtraTabControl1.SelectedTabPageIndex = 0 Then
                    Me.Open("fay500_g10")
                Else
                    Me.Open("fay500_g50")
                End If

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

#Region "Jump"

    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim menuName As String = "FAX100"

        '화면을 띄운다
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
        ctr.Open2(g10.Text("div_cd"), (g10.Text("fr_dt")), (g10.Text("to_dt")), (g10.Text("acc_cd")), (g10.Text("mng_no")), (g10.Text("")))

    End Sub

#End Region
End Class
