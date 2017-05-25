Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class GAM300

    Public Overrides Function Save() As Boolean
        If MyBase.Save() Then
            Me.Open()
        End If
    End Function

End Class
