Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class FAC790
    Private Sub FAC790_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.Open()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.New
                Me.WorkSets("fac790_g10").AddNew()
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
        p.Add("@work_dt", work_dt.Text)
        System7.ReportView.LoadView("FAC790", "", "fac790_Print", p) '매출처별세금계산서합계표
    End Sub
#End Region

    Private Sub proc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proc.Click
        Dim dSet As DataSet
        Dim P As New OpenParameters
        P.Add("@bs_cd", bs_cd.Text)
        P.Add("@mon_bc", mon_bc.Text)
        P.Add("@tax_year", tax_year.Text)
        'Command 생성
        dSet = Me.OpenDataSet("FAC790_Work", P)
    End Sub

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        'If g10.RowIndex < 0 Or g10.RowCount < 1 Then Exit Sub
        '[자동전표발행세금계산서는 품목과 규격만 변경가능하다]
        If ColumnName = "amt" Then
            g10.Text("vat", g10.RowIndex) = Val(g10.Text("amt", g10.RowIndex)) * 0.1
        End If
    End Sub
End Class
