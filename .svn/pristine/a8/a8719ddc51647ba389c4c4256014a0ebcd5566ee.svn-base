Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAS900

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Open()

    End Sub


    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Save

                If Me.Save() Then
                    Dim s1 As String = g10.Text("grp1_cd")
                    Dim s2 As String = g20.Text("grp2_cd")
                    Dim s3 As String = g20.Text("grp2_cd")

                    Me.Open()

                    g10.Find("grp1_cd=" + s1)
                    g20.Find("grp2_cd=" + s2)
                    g30.Find("grp2_cd=" + s3)
                End If

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

End Class
