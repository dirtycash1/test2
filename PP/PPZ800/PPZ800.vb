Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class PPZ800

    Private m_StopEvent As Boolean

    Private Sub g10_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged

        If m_StopEvent Then
            Exit Sub
        End If
        m_StopEvent = True

        With g10
            .Text("net_mh_m") = div(60, .ToDec("net_uph")) * .ToDec("std_men")
            .Text("net_mh_s") = .ToDec("net_mh_m") * 60.0
            .Text("net_ct_m") = div(.ToDec("net_mh_m"), .ToDec("std_men"))
            .Text("net_ct_s") = div(.ToDec("net_mh_s"), .ToDec("std_men"))

            .Text("act_mh_m") = .ToDec("net_mh_m") * (1 + div(.ToDec("act_up_rt"), 100.0)) + div(.ToDec("act_set_m"), .ToDec("fit_lot"))
            .Text("act_mh_s") = .ToDec("act_mh_m") * 60.0

            .Text("act_ct_m") = div(.ToDec("act_mh_m"), .ToDec("std_men"))
            .Text("act_ct_s") = div(.ToDec("act_mh_s"), .ToDec("std_men"))

            .Text("act_uph") = div(60.0, .ToDec("act_mh_m")) * .ToDec("std_men")
            .Text("act_uphm") = div(.ToDec("act_uph"), .ToDec("std_men"))
        End With

        m_StopEvent = False
    End Sub

    Private Function div(a As Decimal, b As Decimal) As Decimal
        If b = 0 Then
            Return 0
        End If

        Return a / b
    End Function



End Class
