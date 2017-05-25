Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class PPD210

    Private Sub _Save()
        Save(g10.WorkSet)

        Dim itmCd As String = g10.Text("itm_cd")
        g10.Open()
        g10.Find("itm_cd=" + itmCd)
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        ty.Text = "1"
        Me._Save()
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        ty.Text = "0"
        Me._Save()
    End Sub

    'Private Sub g10_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging
    '    With g10
    '        If ColumnName = "chk" Then
    '            If Value = "1" Then
    '                .Text("wo_qty") = .ToDec("plan_qty") + .ToDec("need_qty")
    '            Else
    '                .Text("wo_qty") = ""
    '            End If
    '        End If
    '    End With
    'End Sub

End Class
