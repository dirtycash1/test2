Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Math
'Imports DevExpress.XtraReports.Parameters

Public Class QOA260

    Private Sub QOA260_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        '   chk1.SetValue("1", "")
        '   chk2.SetValue("1", "")

    End Sub




    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.DoubleClick


        'reach 등록 허가
        If g10.Text("re_bc") = "QO240500" Then
            Dim menuName As String
            menuName = "QOA200"
            Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName) 'New FormAttribute(menuName, menuText))
            If ctr IsNot Nothing Then
                ctr.Open2(g10.Text("re_no"))
            End If

        End If


    End Sub

End Class
