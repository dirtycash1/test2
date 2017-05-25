Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WP_TR2180
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
        p.Add("@find_from", "xxx")
        p.Add("@find_to", "xxx")
        p.Add("@cs_cd", "xxx")
        p.Add("@cs_nm", "xxx")
        p.Add("@gd_cd", "xxx")
        p.Add("@gd_nm", "xxx")

        Me.Open("wp_tr2180_retrieve", p)
    End Sub

    Private Sub Preview()
        p.Clear()

        p.Add("@find_from", find_from.Text)
        p.Add("@find_to", find_to.Text)
        p.Add("@cs_cd", cs_cd.Text)
        p.Add("@cs_nm", cs_nm.Text)
        p.Add("@gd_cd", gd_cd.Text)
        p.Add("@gd_nm", gd_nm.Text)

        Me.Open("wp_tr2180_retrieve", p)
    End Sub
End Class
