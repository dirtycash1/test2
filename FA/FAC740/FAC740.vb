Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class FAC740
    Private Sub FAC740_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.Open()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.New
                Me.WorkSets("fac740_g10").AddNew()
            Case MenuType.Open
                Dim dSet As DataSet
                Dim P As New OpenParameters
                P.Add("@bs_cd", bs_cd.Text)
                P.Add("@mon_bc", mon_bc.Text)
                P.Add("@tax_year", tax_year.Text)
                'Command 생성
                dSet = Me.OpenDataSet("fac740_query", P)
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
        System7.ReportView.LoadView("FAC740", "", "fac740_Print", p) '매출처별세금계산서합계표
    End Sub
#End Region
End Class
