Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class DCF100

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Open()
    End Sub

    '    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
    '        Select Case mty
    '            Case MenuType.Open
    '                MyBase.Open()

    '            Case MenuType.Save
    '                MyBase.Save()
    '                MyBase.Open()

    '            Case Else
    '                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

    '        End Select
    '    End Sub


    'Private Sub g10_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g10.AfterMoveRow
    '    Me.Open("dcf100_g20")
    'End Sub


End Class
