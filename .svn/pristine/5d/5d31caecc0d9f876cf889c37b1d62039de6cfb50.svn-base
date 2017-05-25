Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAC910

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.Open()
    End Sub

#Region " Event "

    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim menuName As String = "FAC100"

        '화면을 띄운다
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)

        ctr.Open2(g10.Text("tax_no"))

    End Sub

#End Region
End Class
