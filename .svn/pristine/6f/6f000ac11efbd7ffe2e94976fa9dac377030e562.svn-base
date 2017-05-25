Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class PAC104

    Private Sub btn_pay_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_pay.Click

        For i = 0 To g10.RowCount - 1
            If g10.Text("pay_yn", i) = "1" Then
                g10.Text("ty", i) = "1" '승인
            End If
        Next


        If MessageYesNo("급여에 반영 하시겠습니까?", "경고!!") = MsgBoxResult.No Then
            Exit Sub
        End If

        If Me.Save() Then
            Me.Open()
        End If

    End Sub
    Private Sub btn_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del.Click

        For i = 0 To g10.RowCount - 1
            If g10.Text("pay_yn", i) = "1" Then
                g10.Text("ty", i) = "2" '승인
            End If
        Next

        If MessageYesNo("급여에 반영 을 삭제 하시겠습니까?", "경고!!") = MsgBoxResult.No Then
            Exit Sub
        End If

        If Me.Save() Then
            Me.Open()
        End If
    End Sub

    Private Sub chk_yn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_yn.CheckedChanged
        g10.CheckRows("pay_yn", chk_yn.Checked)
    End Sub

    Private Sub detail_yn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles detail_yn.CheckedChanged

        If detail_yn.Text = "0" Then
            g10.ColumnVisible("pay_mon") = False
            g10.ColumnVisible("pay_yn") = True
            GB1.Visible = True
        Else
            g10.ColumnVisible("pay_mon") = True
            g10.ColumnVisible("pay_yn") = False
            GB1.Visible = False
        End If


        Me.Open()

        
    End Sub


End Class
