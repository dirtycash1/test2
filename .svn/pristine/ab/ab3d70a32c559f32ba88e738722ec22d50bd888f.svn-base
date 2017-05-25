Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class FAC620
    Private Sub FAC620_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.Open()
        gubn.Text = optgubn.EditValue
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.New
                Me.WorkSets("fac620_f10").AddNew()
            Case MenuType.Open
                Me.Open()
            Case MenuType.Save
                If Me.Save() Then
                    Me.Open()
                End If
            Case MenuType.Print
                Me.Print()
            Case Else
                MyBase.MenuButton_Click(mty)
        End Select
    End Sub

#Region " Print "
    Private Sub Print()

        Dim p As OpenParameters = New OpenParameters
        p.Add("@bs_cd", bs_cd.Text)
        p.Add("@mon_bc", mon_bc.Text)
        p.Add("@tax_year", tax_year.Text)
        p.Add("@Tax_kd", "FA600200")
        p.Add("@gubn", gubn.Text)
        System7.ReportView.LoadView("fac620", "", "fac620_Print", p) '매출처별세금계산서합계표
    End Sub
#End Region

    Private Sub optgubn_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optgubn.SelectedIndexChanged
        gubn.Text = optgubn.EditValue
    End Sub
End Class
