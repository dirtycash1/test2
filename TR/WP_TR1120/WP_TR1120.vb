Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class WP_TR1120

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

#Region " Jump "
    Private Sub g_retrieve_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g_retrieve.DoubleClick
        Me.Jump("1034")
        'Dim menuName As String = "WI_TR1120"

        'Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
        'If ctr IsNot Nothing Then
        '    ctr.Open2(g_retrieve.Text("od_no"))
        'End If
    End Sub

    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.DoubleClick
        Me.Jump("1034")
        'Dim menuName As String

        'menuName = "WI_TR1120"

        'Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName) 'New FormAttribute(menuName, menuText))
        'If ctr IsNot Nothing Then
        '    ctr.Open2(g10.Text("od_no"))
        'End If
    End Sub
#End Region

    Private Sub btn_prt_Click(sender As System.Object, e As System.EventArgs) Handles btn_prt.Click
        Dim pt As OpenParameters = New OpenParameters

        pt.Add("@FIND_FROM", find_from.Text)
        pt.Add("@FIND_TO", find_to.Text)


        System7.ReportView.LoadView("WP_TR1120", "", "wp_tr1120_print", pt)

        'pt1.Add("@od_no", od_no.Text)
        'System7.ReportView.LoadView("WI_TR1120", "", "wi_tr1120_print1", pt, Nothing, True, 1, "sub", "wi_tr1120_print2", pt1)

    End Sub

End Class
