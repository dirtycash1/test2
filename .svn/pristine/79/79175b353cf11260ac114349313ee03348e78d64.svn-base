Imports Frame7
Imports Base7
Imports Base7.Shared
Public Class SDD160
    Private Sub btn_work_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_work.Click
        If MessageYesNo("작업 하시겠습니까.") = MsgBoxResult.Yes Then
            If Me.Save() Then
                g20.Open()
            End If
            'Me.Open("sdd160_insert")
            'Me.Open("sdd160_g10")
        End If
    End Sub
    Private Sub g10_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g10.AfterMoveRow
        If g10.Text("ent_bc") = "SD320150" Then
            g40.BringToFront()
            Me.Open("sdd160_g40")
        Else
            g30.BringToFront()
            Me.Open("sdd160_g30")
        End If
    End Sub

    Private Sub g10_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging
        With g10
            If ColumnName = "chk" Then
                If Value = "1" Then
                    If .ToDec("gap_amt") <> 0 Then
                        .Text("fix_amt") = .ToDec("gap_amt")
                    Else
                        .Text("fix_amt") = ""
                    End If
                Else
                    .Text("fix_amt") = ""
                End If
            End If
        End With
    End Sub



End Class
