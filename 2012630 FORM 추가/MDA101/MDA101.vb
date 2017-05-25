Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class MDA101

    Private Sub pmt100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
 
        g10.RecordNavigator = True
        g20.RecordNavigator = True
        g30.RecordNavigator = True
        g40.RecordNavigator = True

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Open

                Me.Open()


            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub
 


End Class
