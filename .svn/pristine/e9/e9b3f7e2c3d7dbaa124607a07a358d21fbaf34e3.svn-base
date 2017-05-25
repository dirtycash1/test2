Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class DMM600

    Public Overrides Function Save() As Boolean
        If MyBase.Save() Then
            g20.Open()
        End If
    End Function

    Private Sub get_yn_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles get_yn.CheckedChanged
        If g10.Text("mdl_cd") = "" Then
            MessageInfo("먼저 모델을 선택하세요")
            Exit Sub
        End If
        g20.Open()
    End Sub

End Class
