Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_SA1172
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.NewForm()
        Me.Clear_G_SENO()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                'If cs_cd.Text = Nothing Then
                '    MsgBox("발행거래처를 확인하세요.!")
                '    Return
                'End If

                Me.Preview()

            Case MenuType.Cancel
                Me.Clear()
                Me.Clear_G_SENO()

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
        p.Add("@cs_cd", "XXX")

        Me.Open("wi_sa1172_multi", p)

        cs_cd.Text = "   "
        cs_nm.Text = "   "
        ps_cd.Text = ""
        ps_nm.Text = ""
        rate.Text = ""
        se_no.Text = ""
    End Sub

    Private Sub Preview()

        p.Clear()

        p.Add("@from_dt", from_dt.Text)
        p.Add("@to_dt", to_dt.Text)
        p.Add("@cs_cd", cs_cd.Text)

        Me.Open("wi_sa1172_multi", p)

        rate.Text = 1

        With g_list
            For i As Integer = 0 To .RowCount - 1
                .Text("CHK", i) = "1"
            Next
        End With

        Me.Setitem_rate()
        Me.Clear_G_SENO()
    End Sub

    Private Function ConFrim() As Boolean

        If wf_check() = 1 Then
            Return False
        End If

        Me.Setitem_seno()
        Me.Setitem_rate()

        If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            Max_no()  '전표채번..

            If MyBase.Save() Then
                If confirm_seno() = 0 And confirm() = 0 Then
                    se_no.Text = ""

                    Me.Clear()
                    Me.Clear_G_SENO()
                End If
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
        Dim ls_pscd, ls_rate As String

        ls_pscd = ps_cd.Text
        ls_rate = rate.Text

        If ls_pscd = Nothing Then
            MsgBox("발행자를 확인하세요.!")
            ps_cd.Focus()
            Return 1
        End If

        If (ls_rate = "" Or ls_rate = "1") Then
            MsgBox("환율을 확인하세요.!")
            rate.Focus()
            Return 1
        End If

        Return 0
    End Function

    Private Sub cs_cd_TextChanged(sender As Object, oldValue As String) Handles cs_cd.TextChanged
        p.Clear()
        p.Add("@cust_cd", cs_cd.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1172_sale_nm", p)

        If Not IsEmpty(dSet) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            For Each dRow In dRows
                sale_emp.Text = ToStr(dRow("EMP_NM"))
            Next
        End If

        Me.Preview()
    End Sub

    Private Function confirm() As Integer
        p.Clear()
        p.Add("@se_no", se_no.Text)

        Me.Open("wi_sa1172_confirm", p)

        Return 0
    End Function

    'Private Sub rate_TextChanged(sender As Object, oldValue As String) Handles rate.TextChanged
    '    Me.Setitem_rate()
    'End Sub

    Private Sub btn_rate_Click(sender As Object, e As System.EventArgs) Handles btn_rate.Click
        Me.Setitem_rate()
    End Sub

    Private Sub Setitem_rate()
        Dim ld_rate, ld_otamt As Decimal

        ld_rate = ToDec(rate.Text)

        If g_list.RowCount() > 0 Then
            With g_list
                For i As Integer = 0 To .RowCount - 1
                    ld_otamt = .ToDec("OT_AMT1", i)

                    .Text("RATE", i) = ld_rate
                    .Text("OT_AMT", i) = ld_rate * ld_otamt
                    .Text("VAT_AMT", i) = (ld_rate * ld_otamt) / 10
                    .Text("SUM_AMT", i) = (ld_rate * ld_otamt) + ((ld_rate * ld_otamt) / 10)
                Next
            End With
        End If
    End Sub

    Private Sub Max_no()

        p.Clear()
        p.Add("@pgid", "WI_SA1172")
        p.Add("@date", se_dt.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1172_maxno", p)

        If Not IsEmpty(dSet) Then
            Dim iRow As Integer = 0
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            For Each dRow In dRows
                se_no.Text = ToStr(dRow("SE_NO"))
            Next
        End If
    End Sub

    Private Sub Clear_G_SENO()
        p.Clear()
        p.Add("@se_no", "XXX")

        Me.Open("wi_sa1172_seno", p)
    End Sub

    Private Sub Setitem_seno()
        Dim ls_pscd, ls_sedt, ls_sacd, ls_plcd As String
        Dim ls_chk, ls_cscd As String
        Dim ll_row As Integer
        Dim ld_rate As Decimal
        Dim ld_from, ld_to As Date

        Me.Clear_G_SENO()

        ls_pscd = ps_cd.Text
        ls_sedt = se_dt.Text
        ld_rate = ToDec(rate.Text)
        ld_from = ToDateStr(from_dt.Text)
        ld_to = ToDateStr(to_dt.Text)
        ls_sacd = sa_cd.Text
        ls_plcd = pl_cd.Text

        g_list.UpdateRow()

        For i As Integer = 0 To g_list.RowCount - 1
            ls_chk = g_list.Text("CHK", i)
            ls_cscd = g_list.Text("CS_CD", i)

            If ls_chk = "1" Then
                g_seno.InsertNewRow(ll_row)

                g_seno.Text("CS_CD", ll_row) = ls_cscd
                g_seno.Text("SE_DT", ll_row) = ls_sedt
                g_seno.Text("PS_CD", ll_row) = ls_pscd
                g_seno.Text("RATE", ll_row) = ld_rate
                g_seno.Text("FROM_DT", ll_row) = ld_from
                g_seno.Text("TO_DT", ll_row) = ld_to
                g_seno.Text("SA_CD", ll_row) = ls_sacd
                g_seno.Text("PL_CD", ll_row) = ls_plcd
            End If
        Next
    End Sub

    Private Function confirm_seno() As Integer
        Dim ls_seno As String = ""

        ls_seno = se_no.Text

        If g_seno.RowCount() > 0 Then
            For i As Integer = 0 To g_seno.RowCount - 1
                g_seno.Text("SEQ", i) = i + 1
            Next
        End If

        p.Clear()
        p.Add("@se_no", ls_seno)

        Me.Open("wi_sa1172_seno", p)
    End Function
End Class
