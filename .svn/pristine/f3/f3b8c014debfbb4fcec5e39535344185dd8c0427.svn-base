Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class GAL102

    Private Sub btn_pay_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_pay.Click

        If MessageYesNo("귀속년월을 확인하세요. 급여에 반영 하시겠습니까?", "경고!!") = MsgBoxResult.No Then
            Exit Sub
        End If

        If Me.Save() Then
            Me.Open()
        End If

        'If g10.RowCount > 0 Then
        '    MyBase.Open("gal102_work_a")
        '    MsgBox("급여반영이 완료 되었습니다.")
        '    MyBase.Open("gal102_g10")
        '    Exit Sub
        'End If

        'MsgBox("적용할 Data가 없습니다.")

    End Sub

    Private Sub chk_yn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_yn.CheckedChanged
        g10.CheckRows("pay_yn", chk_yn.Checked)
    End Sub

    Private Sub detail_yn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles detail_yn.CheckedChanged
        'g10.ColumnVisible("sum_amt") = Not detail_yn.Checked
        g10.ColumnVisible("act_amt") = Not detail_yn.Checked
        g10.ColumnVisible("gap_amt") = Not detail_yn.Checked

        Me.Open()

        'btn_pay.Visible = Not detail_yn.Checked
        'btn_pay.Visible = Not detail_yn.Checked
    End Sub

End Class
