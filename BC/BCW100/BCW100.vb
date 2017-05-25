Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class BCW100

    Private Sub Form_Disposing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Disposing

        Me.SetColsingSave()

    End Sub

    'Private Overloads Function Save() As Boolean

    '    .......

    'End Function

    'Private Function ccc() As Boolean
    '    Return False
    'End Function

    '    If Me.DataChanged() Then
    '    Select Case MessageYesNoCancel("저장 하시겠습니까?")
    '        Case MsgBoxResult.Cancel
    '            e.Cancel = True
    '        Case MsgBoxResult.Yes
    '            If Not Me.Save() Then
    '                e.Cancel = True
    '            End If
    '    End Select
    'End If
    '    Me.SetColsingSave()
    ''Me.SetColsingSave(AddressOf ccc)

End Class
