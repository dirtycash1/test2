Imports Frame7
Imports Base7
Imports Base7.Shared
'Imports Base7.Functions

Public Class FAY600

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        g10.SelectRow = True
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Print
                Me.Print()
            Case Else
                MyBase.MenuButton_Click(mty)
        End Select
    End Sub

    Private Sub Print()
        Dim p As OpenParameters = New OpenParameters
        p.Add("@doc_bc", doc_bc.Text)
        p.Add("@co_cd", co_cd.Text)
        p.Add("@div_cd", div_cd.Text)
        p.Add("@fr_dt", fr_dt.Text)
        p.Add("@to_dt", to_dt.Text)
        System7.ReportView.LoadView("FAY600", "", "fay600_g10", p) '합잔출력
    End Sub

    Private Sub bas_yn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bas_yn.CheckedChanged
        g10.ColumnVisible("bas_amt1") = bas_yn.Checked
        g10.ColumnVisible("bas_amt2") = bas_yn.Checked
    End Sub

    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.DoubleClick
        Dim menuName As String = "FAY100"
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)

        ctr.Open2(co_cd.Text, div_cd.Text, fr_dt.Text, to_dt.Text, g10.Text("acc_cd"), g10.Text("acc_cd"))

        
    End Sub

End Class
