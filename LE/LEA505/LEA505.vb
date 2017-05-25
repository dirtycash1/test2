Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Functions
Imports System.Math

Public Class LEA505

    'Private Sub MMC100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    '    'Form Load되면서 바로 입력할 수 있게 신규상태로 만든다
    '    Me.New_Form()

    'End Sub

    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.DoubleClick

        If g10.Text("pur_no") <> "" Then
            Dim menuName As String = "MMD100"
            Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)

            ctr.Open4(g10.Text("pur_no"))
        End If
    End Sub

End Class
