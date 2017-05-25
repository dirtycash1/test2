Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAY110

    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.DoubleClick
        Dim menuName As String
        'If Parameter.System.Code = "CSI" Then
        '    menuName = "FAB100_CSI"
        'Else
        menuName = "FAB100"
        'End If
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName) 'New FormAttribute(menuName, menuText))
        If ctr IsNot Nothing Then
            ctr.Open2(g10.Text("doc_no"), g10.Text("doc_sq"))
        End If
    End Sub

End Class
