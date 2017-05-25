Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class MMB110

    Private Sub btn_do_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_do.Click
        With g10
            For i = 0 To .RowCount - 1
                If .ToBool("chk", i) AndAlso (.Text("stat_bc", i).EndsWith("500") Or .Text("stat_bc", i).EndsWith("700")) Then
                    MessageInfo("이미 완결된 행이 있습니다.")
                    Exit Sub
                End If
            Next
            For i = 0 To .RowCount - 1
                If .ToBool("chk", i) Then
                    .Text("stat", i) = "700"
                End If
            Next
        End With

        If Me.Save() Then
            Me.Open()
        End If
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_undo.Click
        With g10
            For i = 0 To .RowCount - 1
                If .ToBool("chk", i) AndAlso Not .Text("stat_bc", i).EndsWith("700") Then
                    MessageInfo("강제완결된 행만 취소가능합니다.")
                    Exit Sub
                End If
            Next
            For i = 0 To .RowCount - 1
                If .ToBool("chk", i) Then
                    .Text("stat", i) = "100"
                End If
            Next
        End With

        If Me.Save() Then
            Me.Open()
        End If
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
