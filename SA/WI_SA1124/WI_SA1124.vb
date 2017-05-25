Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_SA1124
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Clear()
    End Sub
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Clear()
                Me.Preview()

            Case MenuType.Cancel
                Me.Clear()

                confirm_gu.Text = "N"

            Case MenuType.Confirm
                If Not ConFrim() Then Exit Sub

            Case MenuType.Deconfirm
            Case MenuType.Find
            Case MenuType.Delete
            Case MenuType.Save

                If Not ConFrim() Then Exit Sub

            Case MenuType.New
            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub Clear()
        p.Clear()
        p.Add("@from_dt", from_dt.Text)
        p.Add("@to_dt", to_dt.Text)
        p.Add("@confirm_gu", "N")

        Me.Open("wi_sa1124_multi", p)

    End Sub

    Private Sub Preview()
        p.Clear()

        p.Add("@from_dt", from_dt.Text)
        p.Add("@to_dt", to_dt.Text)
        p.Add("@confirm_gu", confirm_gu.Text)

        Me.Open("wi_sa1124_multi", p)

    End Sub

    'Private Sub Max_no()

    '    p.Clear()
    '    p.Add("@pgid", "WI_SA1121")
    '    p.Add("@date", confirm_dt.Text)

    '    Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1124_maxno", p)

    '    If Not IsEmpty(dSet) Then
    '        Dim iRow As Integer = 0
    '        Dim dRow As DataRow, dRows As DataRowCollection
    '        dRows = dSet.Tables(0).Rows

    '        For Each dRow In dRows
    '            confirm_no.Text = ToStr(dRow("CONFIRM_NO"))
    '        Next
    '    End If
    'End Sub

    Private Function ConFrim() As Boolean

        If wf_check() = 1 Then
            Return False
        End If

        If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            'Max_no()  '전표채번..

            If MyBase.Save() Then
                Return False
            End If
        End If

    End Function


    Private Function wf_check() As Integer
        Dim ls_pscd As String

        ls_pscd = confirm_pscd.Text

        If ls_pscd = Nothing Then
            MsgBox("접수자를 확인하세요.!")
            Return 1
        End If

        Return 0
    End Function

    Private Sub chk_all_CheckedChanged(sender As Object, e As System.EventArgs) Handles chk_all.CheckedChanged
        If chk_all.Checked = True Then
            If g_list.RowCount() > 0 Then
                g_list.RowIndex = 0

                For i As Integer = 0 To g_list.RowCount + 1
                    g_list.Text("CHK", i) = "1"
                Next
            End If
        Else
            If g_list.RowCount() > 0 Then
                g_list.RowIndex = 0

                For i As Integer = 0 To g_list.RowCount + 1
                    g_list.Text("CHK", i) = "0"
                Next
            End If
        End If
    End Sub
End Class
