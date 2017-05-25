Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_SA1121
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Clear()
        Me.Clear_G_ODNO()
    End Sub
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Clear()
                Me.Preview()

            Case MenuType.Cancel
                Me.Clear()
                Me.Clear_G_ODNO()

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
        p.Add("@from_dt", from_dt.Text)
        p.Add("@to_dt", to_dt.Text)
        p.Add("@confirm_gu", "N")

        Me.Open("wi_sa1121_multi", p)

        confirm_no.Text = ""
        head_odno.Text = ""
        delete_odno.Text = ""

    End Sub

    Private Sub Preview()
        p.Clear()

        p.Add("@from_dt", from_dt.Text)
        p.Add("@to_dt", to_dt.Text)
        p.Add("@confirm_gu", confirm_gu.Text)

        Me.Open("wi_sa1121_multi", p)

        Me.Clear_G_ODNO()
    End Sub

    Private Sub Max_no()
        'confirm_no.CodeNo = "WI_SA1121"
        'confirm_no.CodeDateField = confirm_dt

        p.Clear()
        p.Add("@pgid", "WI_SA1121")
        p.Add("@date", confirm_dt.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1121_maxno", p)

        If Not IsEmpty(dSet) Then
            Dim iRow As Integer = 0
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            For Each dRow In dRows
                confirm_no.Text = ToStr(dRow("CONFIRM_NO"))
            Next
        End If
    End Sub

    Private Function ConFrim() As Boolean

        If wf_check() = 1 Then
            Return False
        End If

        If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            Max_no()  '전표채번..

            If MyBase.Save() Then
                If confirm_chulha() = 0 And confirm() = 0 Then
                    confirm_no.Text = ""
                    head_odno.Text = ""
                    delete_odno.Text = ""
                    confirm_gu.Text = "%"

                    p.Clear()
                    p.Add("@from_dt", from_dt.Text)
                    p.Add("@to_dt", to_dt.Text)
                    p.Add("@confirm_gu", confirm_gu.Text)

                    Me.Open("wi_sa1121_multi", p)

                    Me.Clear_G_ODNO()
                    Me.Preview()
                End If
            End If
        End If

    End Function

    Private Sub g_list_CellValueChanging(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g_list.CellValueChanging
        If ColumnName = "CHK" Then
            If Value = 1 Then
                head_odno.Text = g_list.Text("OD_NO")

                'Me.find_odno() '/*-이걸 그냥 쓰면 무한루프 돔-*/
                delete_odno.Text = "xxx"
            Else
                Dim ls_odno2 As String = ""

                delete_odno.Text = g_list.Text("OD_NO")

                head_odno.Text = "xxx"
            End If
        End If
    End Sub

    Private Sub head_odno_TextChanged(sender As Object, oldValue As String) Handles head_odno.TextChanged
        Me.find_odno()
    End Sub

    Private Sub find_odno()
        Dim ls_odno, ls_odno1 As String
        Dim ll_row As Integer

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

        '/*-출하생성용 grid에 넣기-*/
        If ls_odno <> "xxx" Then
            g_odno.InsertNewRow(ll_row)

            g_odno.Text("OD_NO", ll_row) = ls_odno
        End If
        '/*-----------------------*/
    End Sub

    Private Sub delete_odno_TextChanged(sender As Object, oldValue As String) Handles delete_odno.TextChanged
        Me.find_odno1()
    End Sub

    Private Sub find_odno1()
        Dim ls_odno, ls_odno1, ls_odno2 As String

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

        '/*-출하생성용 grid에서 삭제-*/
        If ls_odno <> "xxx" Then
            For n As Integer = 0 To g_odno.RowCount - 1
                ls_odno2 = g_odno.Text("OD_NO", n)

                If ls_odno = ls_odno2 Then
                    g_odno.DeleteRow(n)
                End If
            Next
        End If
        '/*------------------------*/
    End Sub

    Private Function confirm() As Integer
        Dim ls_chk, ls_odno, ls_pscd As String
        Dim ls_confirmno As String = ""

        ls_pscd = confirm_pscd.Text
        ls_confirmno = confirm_no.Text

        With g_list
            For i As Integer = 0 To .RowCount - 1
                ls_chk = .Text("CHK", i)

                If ls_chk = "1" Then
                    ls_odno = .Text("OD_NO", i)

                    p.Clear()
                    p.Add("@od_no", ls_odno)
                    p.Add("@confirm_pscd", ls_pscd)

                    Me.Open("wi_sa1121_confirm", p) '여기 풀어여함.
                End If
            Next
        End With

        Return 0
    End Function

    Private Function confirm_chulha() As Integer
        Dim ls_pscd As String
        Dim ls_confirmno As String = ""

        ls_pscd = confirm_pscd.Text
        ls_confirmno = confirm_no.Text

        p.Clear()
        p.Add("@CONFIRM_NO", ls_confirmno)
        p.Add("@PS_CD", ls_pscd)

        Me.Open("wi_sa1121_chulha", p)

        Return 0
    End Function

    Private Function wf_check() As Integer
        Dim ls_pscd As String

        ls_pscd = confirm_pscd.Text

        If ls_pscd = Nothing Then
            MsgBox("접수자를 확인하세요.!")
            Return 1
        End If

        If g_odno.RowCount() > 0 Then
            For i As Integer = 0 To g_odno.RowCount - 1
                g_odno.Text("SEQ", i) = i + 1
            Next
        End If

        Return 0
    End Function

    Private Sub Clear_G_ODNO()
        p.Clear()
        p.Add("@od_no", "XXX")

        Me.Open("wi_sa1121_odno", p)
    End Sub
End Class
