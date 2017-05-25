Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class FAC730
    Private Sub FAC730_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.Open()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.New
                Me.WorkSets("fac730_f10").AddNew()
            Case MenuType.Open
                Me.Open()
            Case MenuType.Save
                If Me.Save() Then
                    Me.Open()
                End If
            Case MenuType.Print

                Dim p As OpenParameters = New OpenParameters
                p.Add("@bs_cd", bs_cd.Text)
                p.Add("@mon_bc", mon_bc.Text)
                p.Add("@tax_year", tax_year.Text)
                System7.ReportView.LoadView("fac730", "", "fac730_Print", p) '매출처별세금계산서합계표

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select
    End Sub

    '#Region " Print "
    '    Private Sub Print()



    '    End Sub
    '#End Region
   
End Class
