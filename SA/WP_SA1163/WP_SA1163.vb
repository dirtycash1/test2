Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class WP_SA1163

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


    End Sub
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Cancel

                Me.Clear()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub Clear()
        cs_cd.Text = ""
        cs_nm.Text = ""
        scd_cd.Text = ""
        scd_nm.Text = ""
    End Sub


    Private Sub title_change()

    End Sub
End Class
