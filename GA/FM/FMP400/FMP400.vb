Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class FMP400

    'Private dSet As DataSet
    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
       
        Me.Open()
        'GetRt()

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Save
                

                If Me.Save() Then
                    Me.Open()
                End If
             

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Public Overrides Sub Open()
        Dim saveID As String = g10.Text("fac_cd")
        MyBase.Open()
        g10.Find("fac_cd=" + saveID)
    End Sub

    Private Sub but_work_Click(sender As System.Object, e As System.EventArgs) Handles but_work.Click
        If MessageYesNo("작업하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        End If

        Open("fmp400_work")
        g20.Open()

    End Sub


    'Private Sub GetRt()
    '    Try
    '        dSet = OpenDataSet("fmp400_rt")

    '    Catch ex As Exception
    '        MessageError(ex)
    '    End Try
    'End Sub
    'Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
    '    Try

    '        If ColumnName = "amt" Then
    '            If Not IsEmpty(dSet) Then
    '                Dim RtRows As DataRow() = _
    '                     dSet.Tables(0).Select("fac_cd = '" & g10.Text("fac_cd") & "'") '공장
    '                If RtRows.GetLength(0) > 0 Then
    '                    g10.Text("offi_rt") = ToDec(RtRows(0)((RtRows(0).Table.Columns("offi_rt"))))
    '                    g10.Text("util_rt") = ToDec(RtRows(0)((RtRows(0).Table.Columns("util_rt"))))
    '                    g10.Text("fac_rt") = ToDec(RtRows(0)((RtRows(0).Table.Columns("fac_rt"))))
    '                End If
    '            End If
    '        End If

    '        Dim Amt As Double = 0
    '        Dim Amt1 As Double = 0
    '        Dim Amt2 As Double = 0

    '        If ColumnName = "amt" Then


    '            Amt = g10.ToDec("amt") * (g10.ToDec("offi_rt") / 100)
    '            g10.Text("offi_amt") = Amt

    '            Amt1 = g10.ToDec("amt") * (g10.ToDec("util_rt") / 100)
    '            g10.Text("util_amt") = Amt1

    '            Amt2 = g10.ToDec("amt") * (g10.ToDec("fac_rt") / 100)
    '            g10.Text("fac_amt") = Amt2


    '            g10.Text("rate_amt") = Amt1 + Amt2

    '        End If


    '    Catch ex As Exception
    '        MessageError(ex)
    '    End Try
    'End Sub



End Class
