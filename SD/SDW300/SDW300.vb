Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class SDW300

    Public Overrides Sub Open()
        MyBase.Open()

        Dim dt As Date = plan_mon.Text + "-01"
        g10.BandTitle("m1_qty") = Format(DateAdd(DateInterval.Month, 0, dt), "yyyy-MM")
        g10.BandTitle("m2_qty") = Format(DateAdd(DateInterval.Month, 1, dt), "yyyy-MM")
        g10.BandTitle("m3_qty") = Format(DateAdd(DateInterval.Month, 2, dt), "yyyy-MM")
    End Sub

    Public Overrides Function Save() As Boolean
        If MyBase.Save() Then
            MyBase.Open()
        End If
    End Function

    Private Sub g10_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        With g10
            If ColumnName = "m1_qty" Or ColumnName = "m2_qty" Or ColumnName = "m3_qty" Then
                .Text("tot_qty") = .ToDec("m1_qty") + .ToDec("m2_qty") + .ToDec("m3_qty")
            End If
            If ColumnName = "m1_amt" Or ColumnName = "m2_amt" Or ColumnName = "m3_amt" Then
                .Text("tot_amt") = .ToDec("m1_amt") + .ToDec("m2_amt") + .ToDec("m3_amt")
            End If
        End With
    End Sub

    Private Sub btn_trans_Click(sender As System.Object, e As System.EventArgs) Handles btn_trans.Click
        '그 외는 가져오기 공용 SP를 사용한다
        If MessageYesNo("기존 계획은 삭제되고 새로 작성됩니다." & vbLf & vbLf & "작성 하시겠습니까 ?") = MsgBoxResult.No Then
            Exit Sub
        End If

        Open("sdw300_trans")

        MessageInfo("작업이 완료되었습니다")

        Me.Open()
    End Sub

End Class
