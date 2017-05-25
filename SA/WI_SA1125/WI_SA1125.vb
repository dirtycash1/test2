Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_SA1125
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
        p.Add("@cs_nm", "XXX")
        p.Add("@ship_nm", "XXX")

        Me.Open("wi_sa1125_multi", p)

        cs_nm.Text = ""
        ship_nm.Text = ""
    End Sub

    Private Sub Preview()
        p.Clear()

        p.Add("@from_dt", from_dt.Text)
        p.Add("@to_dt", to_dt.Text)
        p.Add("@cs_nm", cs_nm.Text)
        p.Add("@ship_nm", ship_nm.Text)

        Me.Open("wi_sa1125_multi", p)
    End Sub

    Private Function ConFrim() As Boolean
        If wf_check() = 1 Then
            Return False
        End If

        If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else

            If MyBase.Save() Then
                If confirm() = 0 Then
                    cs_nm.Text = ""
                    ship_nm.Text = ""

                    p.Clear()
                    p.Add("@from_dt", from_dt.Text)
                    p.Add("@to_dt", to_dt.Text)
                    p.Add("@cs_nm", cs_nm.Text)
                    p.Add("@ship_nm", ship_nm.Text)

                    Me.Open("wi_sa1125_multi", p)

                    Me.Preview()
                End If
            End If
        End If

    End Function

    Private Function confirm() As Integer
        Dim ls_chk, ls_odno As String
        Dim ls_delidt As String

        g_list.UpdateRow()

        With g_list
            For i As Integer = 0 To .RowCount - 1
                ls_chk = .Text("CHK", i)
                ls_odno = .Text("OD_NO", i)
                ls_delidt = .Text("CH_DELIDT", i)

                If ls_chk = "1" Then

                    p.Clear()
                    p.Add("@od_no", ls_odno)
                    p.Add("@deli_date", ls_delidt)

                    Me.Open("wi_sa1125_confirm", p)
                End If
            Next
        End With

        Return 0
    End Function

    Private Function wf_check() As Integer
        Dim ls_chk As String
        Dim ls_delidt As String

        g_list.UpdateRow()

        For i As Integer = 0 To g_list.RowCount - 1
            ls_chk = g_list.Text("CHK", i)
            ls_delidt = g_list.Text("CH_DELIDT", i)

            If ls_chk = "1" Then
                If ls_delidt = "" Then
                    MsgBox("변경일자를 입력하십시요.")
                    g_list.Focus()
                    g_list.FocusedFieldName = "CH_DELIDT"
                    g_list.RowIndex = i
                    g_list.EditMode()
                    Return 1
                End If
            End If
        Next

        Return 0
    End Function

    'Private Sub g_list_CellValueChanging(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g_list.CellValueChanging
    '    If ColumnName = "CHK" Then
    '        If Value = 1 Then
    '            g_list.Text("CH_DELIDT", RowIndex) = Today
    '        Else
    '            g_list.Text("CH_DELIDT", RowIndex) = ""
    '        End If
    '    End If
    'End Sub
End Class
