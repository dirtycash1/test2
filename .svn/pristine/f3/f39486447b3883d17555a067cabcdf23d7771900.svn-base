Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class MMB101

    Private Sub g10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g10.Load

    End Sub

    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.DoubleClick


        If g10.Text("ent_bc") = "MM120300" Then
            Dim menuName As String = "MMB120"
            Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)

            ctr.Open3(g10.Text("po_dt"), g10.Text("po_fac"), g10.Text("ent_bc"))
        Else
            Dim menuName As String = "MMB100"
            Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
            ctr.Open2(g10.Text("po_no"))

        End If

    End Sub
  
End Class

