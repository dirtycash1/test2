Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Math

Public Class PPD220

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

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        With g10
            If ColumnName = "plan_qty" Then
                If .ToDec("plan_qty") > 0 Then
                    .Text("chk") = "1"
                Else
                    .Text("chk") = "0"
                End If
            End If
        End With
    End Sub

End Class
