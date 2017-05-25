Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAR100

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Save
                If Me.Save() Then
                    Me.Open()
                End If

            Case Else
                MyBase.MenuButton_Click(mty)

        End Select
    End Sub

    Private Sub g20_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g20.DoubleClick
        Dim menuName As String = "FAB100"
        With g20
            If .Text("doc_no2") = "" Then
                MessageInfo("연결된 전표가 없습니다.")
                Exit Sub
            End If

            Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
            If ctr IsNot Nothing Then
                ctr.Open2(.Text("doc_no2"))
            End If
        End With
    End Sub


End Class
