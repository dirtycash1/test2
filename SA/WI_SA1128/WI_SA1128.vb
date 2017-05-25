Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_SA1128
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
        p.Add("@find_cs_cd", "xxxx")
       
        Me.Open("WI_SA1128_multi", p)


    End Sub

    Private Sub Preview()
        p.Clear()

        p.Add("@from_dt", from_dt.Text)
        p.Add("@to_dt", to_dt.Text)
        p.Add("@find_cs_cd", find_cs_cd.Text)
       
        Me.Open("WI_SA1128_multi", p)

    End Sub

    Private Function ConFrim() As Boolean

        'If wf_check() = 1 Then Return False

        If MessageYesNo("수주접수 취소 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            If MyBase.Save() Then

            Else
                Return False
            End If
        End If

        Me.Preview()

        Return True

    End Function

    'Private Sub g_list_CellValueChanging(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g_list.CellValueChanging
    '    If Value = "1" Then
    '        If g_list.Text("STTS", RowIndex) = "C" Then
    '            MsgBox("출하 확인된 자료는 취소할 수 없습니다.!")

    '            Return
    '        End If
    '    End If
    'End Sub


    Private Sub g_list_AfterMoveRow(sender As System.Object, PrevRowIndex As System.Int32, RowIndex As System.Int32) Handles g_list.AfterMoveRow
        Try
            If g_list.Text("STTS") = "C" Then
                g_list.ColumnReadOnly("CHK") = True
            Else
                g_list.ColumnReadOnly("CHK") = False
            End If
        Catch ex As Exception
            MessageInfo(ex.Message & "[g_list_AfterMoveRow]")
        End Try
    End Sub


End Class
