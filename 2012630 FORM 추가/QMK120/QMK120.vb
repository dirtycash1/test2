Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class QMK120


    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Open()

        g10.RecordNavigator = True
        g20.RecordNavigator = True
     
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Open

                MyBase.Open()

            Case MenuType.Save

                If MyBase.Save() Then
                    Dim saveID As String = g10.Text("mng_no")
                    MyBase.Open()
                    g10.Find("mng_no=" + saveID)
                End If

            Case MenuType.New

                MyBase.Open()



            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub


 


End Class
