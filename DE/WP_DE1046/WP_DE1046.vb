Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WP_DE1046
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.NewForm()
    End Sub
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Preview()
            Case MenuType.Cancel
                Me.Clear()

            Case MenuType.Confirm
            Case MenuType.Deconfirm
            Case MenuType.Find
            Case MenuType.Delete
            Case MenuType.Save
            Case MenuType.New
        End Select

    End Sub

    Private Sub Clear()
        p.Clear()
        p.Add("@gd_cd", "xxx")

        Me.Open("wp_de1046_retrieve", p)
    End Sub

    Private Sub Preview()
        p.Clear()

        p.Add("@gd_cd", gd_cd.Text)

        Me.Open("wp_de1046_retrieve", p)
    End Sub
End Class
