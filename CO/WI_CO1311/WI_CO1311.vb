Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class WI_CO1311
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select
    End Sub
    Private Sub print_Click(sender As System.Object, e As System.EventArgs) Handles print.Click
        Dim p As OpenParameters = New OpenParameters
        p.Add("@find_from", find_from.Text)
        p.Add("@find_to", find_to.Text)
        System7.ReportView.LoadView("WI_CO1311", "", "WI_CO1311_PRINT", p, )
    End Sub
End Class
