Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class PPB101

    Private Sub PPb101_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Open()

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        '       g10.SaveValue("stat_cd", "PP250700", False)
        ' Dim wSet As Frame7.WorkSet
        ' wSet = Me.WorkSets("ppb101_stat")
        ' wSet.SetValue("@wo_no_old", g10.Text("wo_no", g10.RowIndex))
        ' Me.Save()

        Dim p As New OpenParameters

        p.Add("@wo_no", g10.Text("wo_no", g10.RowIndex))
        p.Add("@chk", "7")

        Me.OpenDataSet("ppb101_stat", p)

    End Sub
End Class
