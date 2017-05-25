Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Math
'Imports DevExpress.XtraReports.Parameters

Public Class QOA725

    Private Sub QOA725_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        '   chk1.SetValue("1", "")
        '   chk2.SetValue("1", "")

    End Sub




    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.DoubleClick


        '의사소통이 고객대응
        If g10.Text("com_bc") = "QO170200" Then
            Dim menuName As String
            menuName = "QOA700"
            Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName) 'New FormAttribute(menuName, menuText))
            If ctr IsNot Nothing Then
                ctr.Open2(g10.Text("com_no"))
            End If

        End If

        '의사소통이 업체대응
        If g10.Text("com_bc") = "QO170100" Then
            Dim menuName As String
            menuName = "QOA720"
            Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName) 'New FormAttribute(menuName, menuText))
            If ctr IsNot Nothing Then
                ctr.Open2(g10.Text("com_no"))
            End If

        End If




    End Sub

End Class
