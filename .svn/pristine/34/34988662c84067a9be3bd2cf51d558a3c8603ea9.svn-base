Imports Frame7
Imports Base7
Imports Base7.Shared
'Imports System.Data

Public Class FAY750
    Private Sub FAY750_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim monthstr As Date
        monthstr = fr_mon.Text & "-01"
        pfr_mon.Text = DateAdd(DateInterval.Year, -1, monthstr)
        monthstr = to_mon.Text & "-01"
        pto_mon.Text = DateAdd(DateInterval.Year, -1, monthstr)
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.New
                Me.WorkSets("fay750_g10").AddNew()
            Case MenuType.Open
                Me.Open()
            Case MenuType.Save
            Case MenuType.Print
                Me.Print()
            Case Else
                MyBase.MenuButton_Click(mty)
        End Select
    End Sub

#Region " Print "
    Private Sub Print()

        Dim p As OpenParameters = New OpenParameters
        p.Add("@doc_bc", doc_bc.Text)
        p.Add("@co_cd", co_cd.Text)
        p.Add("@div_cd", div_cd.Text)
        p.Add("@fr_mon", fr_mon.Text)
        p.Add("@to_mon", to_mon.Text)
        p.Add("@pfr_mon", pfr_mon.Text)
        p.Add("@pto_mon", pto_mon.Text)
        System7.ReportView.LoadView("FAY750", "", "fay750_g10", p) '합계잔액시산표출력
    End Sub
#End Region

    Private Sub fr_mon_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fr_mon.TextChanged
        Dim monthstr As Date
        monthstr = fr_mon.Text & "-01"
        pfr_mon.Text = DateAdd(DateInterval.Year, -1, monthstr)
    End Sub

    Private Sub to_mon_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles to_mon.TextChanged
        Dim monthstr As Date
        monthstr = to_mon.Text & "-01"
        pto_mon.Text = DateAdd(DateInterval.Year, -1, monthstr)
    End Sub


End Class
