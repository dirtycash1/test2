Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class FAC710
    Private Sub FAC710_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Open()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.New
                Me.WorkSets("fac710_g10").AddNew()
            Case MenuType.Open
                Dim dSet As DataSet
                Dim P As New OpenParameters
                P.Add("@bs_cd", bs_cd.Text)
                P.Add("@tax_year", tax_year.Text)
                P.Add("@mon_bc", mon_bc.Text)
                'Command 생성
                dSet = Me.OpenDataSet("fac710_query", P)
                Me.Open()
                Me.Print()
            Case MenuType.Save
                If Me.Save() Then
                    Me.Open()
                    Me.Print()
                End If
            Case MenuType.Print
            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

#Region " Print "
    Private Sub Print()
        Dim p As OpenParameters = New OpenParameters
        p.Add("@bs_cd", bs_cd.Text)
        p.Add("@tax_year", tax_year.Text)
        p.Add("@mon_bc", mon_bc.Text)
        System7.ReportView.LoadView("fac710", "", "fac710_Print", p, CrystalReportViewer1) '매입불공제
    End Sub

    Private Sub mon_bc_TextChanging(ByVal sender As Object, ByVal e As System.EventArgs) Handles mon_bc.TextChanging
        Dim dSet As DataSet, dRows As DataRowCollection, dRow As DataRow
        Dim mng_val As String = Nothing
        Dim work_dtf As String = Nothing
        Dim P As New OpenParameters
        P.Add("@mon_bc", mon_bc.Text)
        'Command 생성
        dSet = Me.OpenDataSet("fac710_sql", P)
        dRows = dSet.Tables(0).Rows
        For Each dRow In dRows
            If Len(ToStr(dRow("mng_val"))) = 1 Then
                mng_val = "0" & ToStr(dRow("mng_val"))
            ElseIf Len(ToStr(dRow("mng_val"))) = 2 Then
                mng_val = ToStr(dRow("mng_val"))
            End If
            If ToStr(dRow("mng_sq")) = "1" Then
                work_dtf = Format(Now, "yyyy-") & mng_val & ToStr("-01")
            ElseIf ToStr(dRow("mng_sq")) = "2" Then
                Dim sdate As Date
                sdate = Format(Now, "yyyy-") & mng_val & ToStr("-01")
                work_dtft.Text = work_dtf & " ~ " & CStr(DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 1, sdate)))
            End If
        Next
    End Sub
#End Region
End Class
