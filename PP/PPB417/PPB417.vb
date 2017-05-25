Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class PPB417

    Private Sub PPB417_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Open()

    End Sub

    'Private Sub g10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'End Sub
    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.DoubleClick

        Dim menuName As String = "PPB416"
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)

        ctr.Open3(g10.Text("outr_no"), g10.Text("outr_dt"), g10.Text("fac_cd"), g10.Text("wh_cd"))

    End Sub

End Class
