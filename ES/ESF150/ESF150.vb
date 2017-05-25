Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class ESF150

    Private Sub FAA500_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'SetKeyField()
    End Sub

    Private Sub SetKeyField()
        'sys_cd.Visible = (XtraTabControl1.SelectedTabPageIndex = 0)
        'co_cd.Visible = Not sys_cd.Visible
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs)
        'SetKeyField()
    End Sub

End Class
