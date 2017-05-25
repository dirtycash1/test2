Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class LEM102
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Print
                '                Me.Print()
            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

#Region " Print "
    'Private Sub Print()
    '    Dim p As OpenParameters = New OpenParameters
    '    p.Add("@mov_no", g10.Text("mov_no"))

    '    LEM102.ReportView.LoadView("LEM102", "", "LEM101_Print", p)
    'End Sub
#End Region

    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.DoubleClick
        Dim menuName As String = g10.Text("frm_cd")

        If menuName = "" Then
            Exit Sub
        End If

        '화면을 띄운다
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
        If ctr IsNot Nothing Then
            ctr.Open2(g10.Text("mov_no"))
        End If

    End Sub

End Class
