Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_SA1176
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
        cs_cd.Text = ""

        p.Clear()
        p.Add("@from_dt", from_dt.Text)
        p.Add("@to_dt", to_dt.Text)
        p.Add("@cs_cd", "XXX")

        Me.Open("WI_SA1176_multi", p)
    End Sub

    Private Function Check_Stts() As String
        p.Clear()

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1176_maxno")
        Dim stts As String = ""

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        With g_list
            For i As Integer = 0 To .RowCount - 1
                .Text("sl_no", i) = stts
            Next
        End With

        Return stts

    End Function

    Private Sub Preview()
        If cs_cd.Text = Nothing Then
            MsgBox("거래처를 입력하세요!")
            Return
        End If

        p.Clear()

        p.Add("@from_dt", from_dt.Text)
        p.Add("@to_dt", to_dt.Text)
        p.Add("@cs_cd", cs_cd.Text)

        Me.Open("WI_SA1176_multi", p)

        'With g_list
        '    For i As Integer = 0 To .RowCount - 1
        '        .Text("CHK", i) = "1"
        '    Next
        'End With

    End Sub

    Private Function ConFrim() As Boolean

        If wf_check() = 1 Then
            Return False
        End If

        If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            Dim temp_slno As String = ""

            temp_slno = Check_Stts()

            If MyBase.Save() Then
                'ASSDFGHJ
                p.Clear()
                p.Add("@se_no", temp_slno)

                Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1176_set", p)
                Dim stts As String = ""

                If Not IsEmpty(dSet) Then stts = DataValue(dSet)

                Return True
            End If
        End If
    End Function

    Private Sub g_list_CellValueChanging(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g_list.CellValueChanging
        If ColumnName = "CHK" Then
            If Value = 1 Then
            End If
        End If
    End Sub

    Private Function wf_check() As Integer
        Dim ls_pscd As String

        ls_pscd = ps_cd.Text

        If ls_pscd = Nothing Then
            MsgBox("발행자를 확인하세요.!")
            Return 1
        End If

        Return 0
    End Function

    Private Function confirm() As Integer
        p.Clear()
        p.Add("@se_no", se_no.Text)

        Me.Open("WI_SA1176_confirm", p)

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
