Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_SA1127_CN
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
                'Me.Clear_G_ODNO()

                confirm_gu.Text = "N"
                stts.Text = "%"

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
        p.Add("@stts", "%")

        Me.Open("WI_SA1127_multi_CN", p)

        confirm_no.Text = ""
        head_odno.Text = ""
        delete_odno.Text = ""
        select_no.Text = ""

        chk_all.Checked = False

    End Sub

    Private Sub Preview()
        p.Clear()

        p.Add("@from_dt", from_dt.Text)
        p.Add("@to_dt", to_dt.Text)
        p.Add("@confirm_gu", confirm_gu.Text)
        p.Add("@stts", stts.Text)

        Me.Open("WI_SA1127_multi_CN", p)

        'Me.Clear_G_ODNO()
    End Sub

    'Private Sub Max_no()
    '    p.Clear()
    '    p.Add("@pgid", "WI_SA1121_CN")
    '    p.Add("@date", confirm_dt.Text)

    '    Dim dSet As Data.DataSet = Me.OpenDataSet("WI_SA1127_maxno_cn", p)

    '    If Not IsEmpty(dSet) Then
    '        Dim iRow As Integer = 0
    '        Dim dRow As DataRow, dRows As DataRowCollection
    '        dRows = dSet.Tables(0).Rows

    '        For Each dRow In dRows
    '            confirm_no.Text = ToStr(dRow("CONFIRM_NO"))
    '        Next
    '    End If
    'End Sub

    'Private Sub Max_no1()
    '    p.Clear()
    '    p.Add("@pgid", "WI_SA1121_CN")
    '    p.Add("@date", confirm_dt.Text)

    '    Dim dSet As Data.DataSet = Me.OpenDataSet("WI_SA1127_maxno1_cn", p)

    '    If Not IsEmpty(dSet) Then
    '        Dim iRow As Integer = 0
    '        Dim dRow As DataRow, dRows As DataRowCollection
    '        dRows = dSet.Tables(0).Rows

    '        For Each dRow In dRows
    '            select_no.Text = ToStr(dRow("SELECT_NO"))
    '        Next
    '    End If
    'End Sub


    Private Function ConFrim() As Boolean

        If wf_check() = 1 Then Return False

        If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            If MyBase.Save() Then
               
            Else
                Return False
            End If
        End If

        Return True

    End Function

    'Private Sub g_list_CellValueChanging(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g_list.CellValueChanging
    '    If ColumnName = "CHK" Then
    '        If Value = 1 Then
    '            head_odno.Text = g_list.Text("OD_NO")

    '            'Me.find_odno() '/*-이걸 그냥 쓰면 무한루프 돔-*/
    '            delete_odno.Text = "xxx"
    '        Else
    '            Dim ls_odno2 As String = ""

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

    Private Function confirm_chulha() As Integer
        Dim ls_pscd, ls_selectno As String
        Dim ls_confirmno As String = ""

        ls_pscd = confirm_pscd.Text
        ls_confirmno = confirm_no.Text
        ls_selectno = select_no.Text

        p.Clear()
        p.Add("@CONFIRM_NO", ls_confirmno)
        p.Add("@PS_CD", ls_pscd)
        p.Add("@SELECT_NO", ls_selectno)

        Me.Open("WI_SA1127_chulha_cn", p)

        Return 0
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
        If chk_all.Checked Then
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
