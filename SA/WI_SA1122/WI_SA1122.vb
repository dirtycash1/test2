Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_SA1122
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.NewForm()
    End Sub
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Preview()

            Case MenuType.Cancel
                Me.Clear()

            Case MenuType.Confirm
                If Not ConFrim() Then Exit Sub

            Case MenuType.Deconfirm
            Case MenuType.Find
            Case MenuType.Delete
            Case MenuType.Save
                If Not ConFrim() Then Exit Sub

            Case MenuType.New
        End Select

    End Sub

    Private Sub Clear()
        p.Clear()
        p.Add("@cs_cd", "XXX")
        p.Add("@cs_nm", "XXX")
        p.Add("@sale_psnm", "XXX")
        p.Add("@from_dt", from_dt.Text)
        p.Add("@to_dt", to_dt.Text)

        Me.Open("wi_sa1122_multi", p)
    End Sub

    Private Sub Preview()
        p.Clear()

        p.Add("@find_cs_cd", find_cs_cd.Text)
        p.Add("@find_cs_nm", find_cs_nm.Text)
        p.Add("@find_sale_psnm", find_sale_psnm.Text)
        p.Add("@from_dt", from_dt.Text)
        p.Add("@to_dt", to_dt.Text)

        Me.Open("wi_sa1122_multi", p)
    End Sub

    Private Function ConFrim() As Boolean

        If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            'If confirm() = 0 Then
            '    Me.Preview()
            'End If
            If MyBase.Save() Then
                Me.Preview()
            End If
        End If
    End Function

    'Private Sub g_list_CellValueChanging(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g_list.CellValueChanging
    '    If ColumnName = "CHK" Then
    '        If Value = 1 Then
    '            head_odno.Text = g_list.Text("OD_NO")

    '            'Me.find_odno() '/*-이걸 그냥 쓰면 무한루프 돔-*/
    '            delete_odno.Text = "xxx"
    '        Else
    '            delete_odno.Text = g_list.Text("OD_NO")

    '            head_odno.Text = "xxx"
    '        End If
    '    End If
    'End Sub

    Private Sub head_odno_TextChanged(sender As Object, oldValue As String) Handles head_odno.TextChanged
        Me.find_odno()
    End Sub

    Private Sub find_odno()
        Dim ls_odno, ls_odno1 As String

        ls_odno = head_odno.Text

        With g_list
            For i As Integer = 0 To .RowCount - 1
                ls_odno1 = .Text("OD_NO", i)

                If ls_odno = ls_odno1 Then
                    .UpdateRow()
                    .Text("CHK", i) = "1"
                End If
            Next
        End With
    End Sub

    Private Sub delete_odno_TextChanged(sender As Object, oldValue As String) Handles delete_odno.TextChanged
        Me.find_odno1()
    End Sub

    Private Sub find_odno1()
        Dim ls_odno, ls_odno1 As String

        ls_odno = delete_odno.Text

        With g_list
            For i As Integer = 0 To .RowCount - 1
                ls_odno1 = .Text("OD_NO", i)

                If ls_odno = ls_odno1 Then
                    .UpdateRow()
                    .Text("CHK", i) = "0"
                End If
            Next
        End With
    End Sub

    Private Function confirm() As Integer
        Dim ls_chk, ls_odno As String

        With g_list
            For i As Integer = 0 To .RowCount - 1
                ls_chk = .Text("CHK", i)

                If ls_chk = "1" Then
                    ls_odno = .Text("OD_NO", i)

                    p.Clear()
                    p.Add("@od_no", ls_odno)

                    Me.Open("wi_sa1122_confirm", p)
                End If
            Next
        End With

        Return 0
    End Function

End Class
