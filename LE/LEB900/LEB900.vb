Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class LEB900

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btn_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del.Click
        If MessageYesNo("삭제하시겠습니까.") = MsgBoxResult.Yes Then
            Me.Open("leb900_del")
            Me.Open("leb900_g10")
        End If

    End Sub
End Class
