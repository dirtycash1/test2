Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class WP_SA1130


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
        gd_model.Text = ""
        gd_cd.Text = ""
        gd_nm.Text = ""
        cs_cd.Text = ""
        cs_nm.Text = ""
        scd_cd.Text = ""
    End Sub
End Class
