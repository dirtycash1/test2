Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAG101

    Private Sub g20_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g20.DoubleClick

        Dim menuName As String
        'If Parameter.System.Code = "CSI" Then
        '    menuName = "FAB100_CSI"
        'Else
        menuName = "FAB100"
        'End If
        '화면을 띄운다
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName) 'New FormAttribute(menuName, menuText))
        If ctr IsNot Nothing Then
            ctr.Open2(g20.Text("doc_no"))
        End If

    End Sub

End Class
