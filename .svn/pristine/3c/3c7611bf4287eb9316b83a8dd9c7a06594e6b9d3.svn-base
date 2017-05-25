Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class FAC600
    Dim chk As String = "0"
    Dim dSet As DataSet, dRows As DataRowCollection

    Private Sub FAC600_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.Open()
        Dim P As New OpenParameters
        P.Add("@bs_cd", bs_cd.Text)
        'Command 생성
        dSet = Me.OpenDataSet("FAC600_bank", P)
        dRows = dSet.Tables(0).Rows
        Dim dRow As DataRow
        For Each dRow In dRows
            bank_cd.Text = ToStr(dRow("rtn_bank"))
            bank_loc.Text = ToStr(dRow("rtn_spot"))
            acct_no.Text = ToStr(dRow("rtn_acct"))
        Next
        doc_bc.Text = "FA681100"
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.New
                Me.WorkSets("fac600_f1").AddNew()
                Dim tax_dt As Date
                If Len(tax_dtt.Text) > 0 Then
                    tax_dt = tax_dtt.Text
                    work_dt.Text = Microsoft.VisualBasic.Left(DateAdd(DateInterval.Month, 1, tax_dt), 7) & "-25"
                Else
                    work_dt.Text = ""
                End If
            Case MenuType.Open
                Dim dSet As DataSet
                Dim P As New OpenParameters
                'exec fac600_query @bs_cd, @mon_bc,@tax_year,@work_dt,@tax_dtf,@tax_dtt,@bank_cd,@bank_loc,@acct_no,@agent_nm,@agent_no,@agent_tel,<$reg_id>
                P.Add("@bs_cd", bs_cd.Text)
                P.Add("@mon_bc", mon_bc.Text)
                P.Add("@tax_year", tax_year.Text)
                P.Add("@work_dt", work_dt.Text)
                P.Add("@tax_dtf", tax_dtf.Text)
                P.Add("@tax_dtt", tax_dtt.Text)
                P.Add("@bank_cd", bank_cd.Text)
                P.Add("@bank_loc", bank_loc.Text)
                P.Add("@acct_no", acct_no.Text)
                P.Add("@agent_nm", agent_nm.Text)
                P.Add("@agent_no", agent_no.Text)
                P.Add("@agent_tel", agent_tel.Text)
                'Command 생성
                dSet = Me.OpenDataSet("fac600_query", P)
                Me.Open()
                fnsum()
            Case MenuType.Save
                If Me.Save() Then
                    Me.Open()
                End If
            Case MenuType.Delete
                Me.Delete("fac600_f1")
                Me.WorkSets("fac600_f1").AddNew()
            Case MenuType.Print
                Me.Print()
            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

#Region " Print "
    Private Sub Print()

        Dim p As OpenParameters = New OpenParameters
        p.Add("@bs_cd", co_cd.Text)
        p.Add("@mon_bc", mon_bc.Text)
        p.Add("@tax_year", tax_year.Text)
        System7.ReportView.LoadView("fac600", "", "fac600_Print", p) '부가세신고서
    End Sub
#End Region

    Private Sub mon_bc_TextChanging(ByVal sender As Object, ByVal e As System.EventArgs) Handles mon_bc.TextChanged
        Dim dSet As DataSet, dRows As DataRowCollection, dRow As DataRow
        Dim mng_val As String = Nothing
        Dim P As New OpenParameters
        P.Add("@mon_bc", mon_bc.Text)
        'Command 생성
        dSet = Me.OpenDataSet("fac600_sql", P)
        dRows = dSet.Tables(0).Rows
        For Each dRow In dRows
            If Len(ToStr(dRow("mng_val"))) = 1 Then
                mng_val = "0" & ToStr(dRow("mng_val"))
            ElseIf Len(ToStr(dRow("mng_val"))) = 2 Then
                mng_val = ToStr(dRow("mng_val"))
            End If
            If ToStr(dRow("mng_sq")) = "1" Then
                tax_dtf.Text = Format(Now, "yyyy-") & mng_val & ToStr("-01")
            ElseIf ToStr(dRow("mng_sq")) = "2" Then
                Dim sdate As Date
                sdate = Format(Now, "yyyy-") & mng_val & ToStr("-01")
                tax_dtt.Text = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 1, sdate))
            End If
        Next
        Dim tax_dt As Date
        tax_dt = tax_dtt.Text
        work_dt.Text = Microsoft.VisualBasic.Left(DateAdd(DateInterval.Month, 1, tax_dt), 7) & "-25"
    End Sub

#Region " 집계처리 이벤트 "

    Private Sub sale_amt_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles sale_amt.TextChanging
        fn_sale_amt_sum()
    End Sub

    Private Sub sale_vat_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles sale_vat.TextChanging
        fn_sale_vat_sum()
        fnsum()
    End Sub

    Private Sub sale_iss_amt_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles sale_iss_vat.TextChanging
        fn_sale_amt_sum()
    End Sub

    Private Sub sale_iss_vat_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles sale_iss_vat.TextChanging
        fn_sale_vat_sum()
        fnsum()
    End Sub

    Private Sub sale_card_amt_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles sale_card_amt.TextChanging
        fn_sale_amt_sum()
    End Sub

    Private Sub sale_card_vat_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles sale_card_vat.TextChanging
        fn_sale_vat_sum()
        fnsum()
    End Sub

    Private Sub sale_etc_amt_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles sale_etc_amt.TextChanging
        fn_sale_amt_sum()
    End Sub

    Private Sub sale_etc_vat_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles sale_etc_vat.TextChanging
        fn_sale_vat_sum()
        fnsum()
    End Sub

    Private Sub sale_zero_amt_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles sale_zero_amt.TextChanging
        fn_sale_amt_sum()
    End Sub

    Private Sub sale_miss_amt_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles sale_miss_amt.TextChanging
        fn_sale_amt_sum()
    End Sub

    Private Sub sale_miss_vat_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles sale_miss_vat.TextChanging
        fn_sale_vat_sum()
        fnsum()
    End Sub

    Private Sub bad_vat_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles bad_vat.TextChanging
        fn_sale_vat_sum()
        fnsum()
    End Sub

    Private Sub buy_amt_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles buy_amt.TextChanging
        fn_buy_amt_sum()
    End Sub

    Private Sub buy_vat_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles buy_vat.TextChanging
        fn_buy_vat_sum()
        fnsum()
    End Sub

    Private Sub ast_amt_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles ast_amt.TextChanging
        fn_buy_amt_sum()
    End Sub

    Private Sub ast_vat_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles ast_vat.TextChanging
        fn_buy_vat_sum()
        fnsum()
    End Sub

    Private Sub buy_miss_amt_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles buy_miss_amt.TextChanging
        fn_buy_amt_sum()
    End Sub

    Private Sub buy_miss_vat_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles buy_miss_vat.TextChanging
        fn_buy_vat_sum()
        fnsum()
    End Sub

    Private Sub buy_iss_amt_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles buy_iss_amt.TextChanging
        fn_buy_amt_sum()
    End Sub

    Private Sub buy_iss_vat_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles buy_iss_vat.TextChanging
        fn_buy_vat_sum()
        fnsum()
    End Sub

    Private Sub buy_etc_amt_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles buy_etc_amt.TextChanging
        fn_buy_amt_sum()
    End Sub

    Private Sub buy_etc_vat_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles buy_etc_vat.TextChanging
        fn_buy_vat_sum()
        fnsum()
    End Sub

    Private Sub no_dedu_amt_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles no_dedu_amt.TextChanging
        fn_buy_amt_sum()
    End Sub

    Private Sub no_dedu_vat_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles no_dedu_vat.TextChanging
        buy_chakam_vat.Text = CDbl(IIf(buy_tot_vat.Text = "", 0, buy_tot_vat.Text)) - CDbl(IIf(no_dedu_vat.Text = "", 0, no_dedu_vat.Text))
        fnsum()
    End Sub

    Private Sub etc_vat_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles etc_vat.TextChanging
        dedu_vat.Text = CDbl(IIf(etc_vat.Text = "", 0, etc_vat.Text)) + CDbl(IIf(card_vat.Text = "", 0, card_vat.Text))
        fnsum()
    End Sub

    Private Sub card_vat_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles card_vat.TextChanging
        dedu_vat.Text = CDbl(IIf(etc_vat.Text = "", 0, etc_vat.Text)) + CDbl(IIf(card_vat.Text = "", 0, card_vat.Text))
        fnsum()
    End Sub

    Private Sub non_repay_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles non_repay.TextChanging
        fnsum()
    End Sub

    Private Sub plan_amt_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles plan_amt.TextChanging
        fnsum()
    End Sub

    Private Sub spc_vat_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles spc_vat.TextChanging
        fnsum()
    End Sub

    Private Sub add_vat_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles add_vat.TextChanging
        fnsum()
    End Sub

    Private Sub result_vat_TextChanged(ByVal sender As System.Object, ByVal oldValue As System.String) Handles result_vat.TextChanged
        fnsum()
    End Sub

    '매출집계공급가액
    Private Sub fn_sale_amt_sum()
        sale_tot_amt.Text = CDbl(IIf(sale_amt.Text = "", 0, sale_amt.Text)) + CDbl(IIf(sale_iss_amt.Text = "", 0, sale_iss_amt.Text)) + CDbl(IIf(sale_card_amt.Text = "", 0, sale_card_amt.Text)) + CDbl(IIf(sale_etc_amt.Text = "", 0, sale_etc_amt.Text)) + CDbl(IIf(sale_zero_amt.Text = "", 0, sale_zero_amt.Text)) + CDbl(IIf(sale_zero_etc_amt.Text = "", 0, sale_zero_etc_amt.Text)) + CDbl(IIf(sale_miss_amt.Text = "", 0, sale_miss_amt.Text))
    End Sub
    '매출집계부가세
    Private Sub fn_sale_vat_sum()
        sale_tot_vat.Text = CDbl(IIf(sale_vat.Text = "", 0, sale_vat.Text)) + CDbl(IIf(sale_iss_vat.Text = "", 0, sale_iss_vat.Text)) + CDbl(IIf(sale_card_vat.Text = "", 0, sale_card_vat.Text)) + CDbl(IIf(sale_etc_vat.Text = "", 0, sale_etc_vat.Text)) + CDbl(IIf(sale_miss_vat.Text = "", 0, sale_miss_vat.Text)) + CDbl(IIf(bad_vat.Text = "", 0, bad_vat.Text))
    End Sub
    '매입집계공급가
    Private Sub fn_buy_amt_sum()
        buy_tot_amt.Text = CDbl(IIf(buy_amt.Text = "", 0, buy_amt.Text)) + CDbl(IIf(ast_amt.Text = "", 0, ast_amt.Text)) + CDbl(IIf(buy_miss_amt.Text = "", 0, buy_miss_amt.Text)) + CDbl(IIf(buy_iss_amt.Text = "", 0, buy_iss_amt.Text)) + CDbl(IIf(buy_etc_amt.Text = "", 0, buy_etc_amt.Text))
        buy_chakam_amt.Text = CDbl(IIf(buy_tot_amt.Text = "", 0, buy_tot_amt.Text)) - CDbl(IIf(no_dedu_amt.Text = "", 0, no_dedu_amt.Text))
    End Sub

    '매입집계부가세
    Private Sub fn_buy_vat_sum()
        buy_tot_vat.Text = CDbl(IIf(buy_vat.Text = "", 0, buy_vat.Text)) + CDbl(IIf(ast_vat.Text = "", 0, ast_vat.Text)) + CDbl(IIf(buy_miss_vat.Text = "", 0, buy_miss_vat.Text)) + CDbl(IIf(buy_iss_vat.Text = "", 0, buy_iss_vat.Text)) + CDbl(IIf(buy_etc_vat.Text = "", 0, buy_etc_vat.Text))
        buy_chakam_vat.Text = CDbl(IIf(buy_tot_vat.Text = "", 0, buy_tot_vat.Text)) - CDbl(IIf(no_dedu_vat.Text = "", 0, no_dedu_vat.Text))
    End Sub

    '납부할 세액계산
    Private Sub fnsum()
        give_amt.Text = CDbl(IIf(sale_tot_vat.Text = "", 0, sale_tot_vat.Text)) - CDbl(IIf(buy_chakam_vat.Text = "", 0, buy_chakam_vat.Text))
        result_vat.Text = CDbl(IIf(give_amt.Text = "", 0, give_amt.Text)) - CDbl(IIf(dedu_vat.Text = "", 0, dedu_vat.Text)) - CDbl(IIf(non_repay.Text = "", 0, non_repay.Text)) - CDbl(IIf(plan_amt.Text = "", 0, plan_amt.Text)) - CDbl(IIf(spc_vat.Text = "", 0, spc_vat.Text)) - CDbl(IIf(add_vat.Text = "", 0, add_vat.Text))
        vat.Text = CDbl(result_vat.Text)
    End Sub

    Private Sub tax_amt1_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles tax_amt1.TextChanging
        fn_tax_amt_sum()
    End Sub

    Private Sub tax_amt2_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles tax_amt2.TextChanging
        fn_tax_amt_sum()
    End Sub

    Private Sub tax_amt3_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles tax_amt3.TextChanging
        fn_tax_amt_sum()
    End Sub

    Private Sub tax_amt4_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles tax_amt4.TextChanging
        fn_tax_amt_sum()
    End Sub
    '과세집계
    Private Sub fn_tax_amt_sum()
        tax_sum_amt.Text = CDbl(IIf(tax_amt1.Text = "", 0, tax_amt1.Text)) + CDbl(IIf(tax_amt2.Text = "", 0, tax_amt2.Text)) + CDbl(IIf(tax_amt3.Text = "", 0, tax_amt3.Text)) + CDbl(IIf(tax_amt4.Text = "", 0, tax_amt4.Text))
    End Sub

    Private Sub free_amt1_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles free_amt1.TextChanging
        fn_free_amt_sum()
    End Sub

    Private Sub free_amt2_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles free_amt2.TextChanging
        fn_free_amt_sum()
    End Sub

    Private Sub free_amt3_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles free_amt3.TextChanging
        fn_free_amt_sum()
    End Sub
    ' 면세집계
    Private Sub fn_free_amt_sum()
        free_sum_amt.Text = CDbl(IIf(free_amt1.Text = "", 0, free_amt1.Text)) + CDbl(IIf(free_amt2.Text = "", 0, free_amt2.Text)) + CDbl(IIf(free_amt3.Text = "", 0, free_amt3.Text))
    End Sub

#End Region

#Region " 예외사항처리 "

    '예정신고누락분(매출)
    Private Sub cmdsale_miss_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsale_miss.Click
        doc_bc.Text = "FA681100"
        EPanel3.Text = cmdsale_miss.Text
        Dim P As New OpenParameters
        P.Add("@bs_cd", bs_cd.Text)
        P.Add("@mon_bc", mon_bc.Text)
        P.Add("@tax_year", tax_year.Text)
        P.Add("@doc_bc", doc_bc.Text)
        Me.Open("fac600_sql1", P)
        chk = "1"
        'Me.WorkSets("fac600_g10").AddNew()
        EPanel3.Visible = True
    End Sub
    '예정신고누락분(매입)
    Private Sub cmdbuy_miss_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbuy_miss.Click
        doc_bc.Text = "FA681100"
        EPanel3.Text = cmdbuy_miss.Text
        Dim P As New OpenParameters
        P.Add("@bs_cd", bs_cd.Text)
        P.Add("@mon_bc", mon_bc.Text)
        P.Add("@tax_year", tax_year.Text)
        P.Add("@doc_bc", doc_bc.Text)
        Me.Open("fac600_sql2", P)
        chk = "2"
        EPanel3.Visible = True
    End Sub
    '기타공제매입세액
    Private Sub cmdetc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdetc.Click
        doc_bc.Text = "FA681200"
        EPanel3.Text = cmdetc.Text
        Dim P As New OpenParameters
        P.Add("@bs_cd", bs_cd.Text)
        P.Add("@mon_bc", mon_bc.Text)
        P.Add("@tax_year", tax_year.Text)
        P.Add("@doc_bc", doc_bc.Text)
        Me.Open("fac600_sql3", P)
        EPanel3.Visible = True
    End Sub
    '공  제  받  지  못   할  매  입  세  액
    Private Sub cmddedu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddedu.Click
        doc_bc.Text = "FA681300"
        EPanel3.Text = cmddedu.Text
        Dim P As New OpenParameters
        P.Add("@bs_cd", bs_cd.Text)
        P.Add("@mon_bc", mon_bc.Text)
        P.Add("@tax_year", tax_year.Text)
        P.Add("@doc_bc", doc_bc.Text)
        Me.Open("fac600_sql4", P)
        EPanel3.Visible = True
    End Sub
    '기타 경감 . 공제세액 명세
    Private Sub cmdetc_dedu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdetc_dedu.Click
        doc_bc.Text = "FA681400"
        EPanel3.Text = cmdetc_dedu.Text
        Dim P As New OpenParameters
        P.Add("@bs_cd", bs_cd.Text)
        P.Add("@mon_bc", mon_bc.Text)
        P.Add("@tax_year", tax_year.Text)
        P.Add("@doc_bc", doc_bc.Text)
        Me.Open("fac600_sql5", P)
        EPanel3.Visible = True
    End Sub
    '가산세 명세
    Private Sub cmdadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click
        doc_bc.Text = "FA681500"
        EPanel3.Text = cmdadd.Text
        Dim P As New OpenParameters
        P.Add("@bs_cd", bs_cd.Text)
        P.Add("@mon_bc", mon_bc.Text)
        P.Add("@tax_year", tax_year.Text)
        P.Add("@doc_bc", doc_bc.Text)
        Me.Open("fac600_sql6", P)
        EPanel3.Visible = True
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim wamt As Double, wvat As Double
        wamt = 0 : wvat = 0
        With g10
            Dim iRow As Integer = 0
            For iRow = 0 To .RowCount - 1
                wamt = CDbl(wamt) + CDbl(IIf(.Text("amt", iRow) = "", 0, .Text("amt", iRow)))
                wvat = CDbl(wvat) + CDbl(IIf(.Text("vat", iRow) = "", 0, .Text("vat", iRow)))
            Next
        End With
        If doc_bc.Text = "FA681100" And chk = "1" Then
            sale_miss_amt.Text = wamt : sale_miss_vat.Text = wvat
            fn_sale_amt_sum()
            fn_sale_vat_sum()
        ElseIf doc_bc.Text = "FA681100" And chk = "2" Then
            buy_miss_amt.Text = wamt : buy_miss_vat.Text = wvat
            buy_chakam_vat.Text = CDbl(IIf(buy_tot_vat.Text = "", 0, buy_tot_vat.Text)) - CDbl(IIf(no_dedu_vat.Text = "", 0, no_dedu_vat.Text))
            fn_buy_amt_sum()
            fn_buy_vat_sum()
            fnsum()
        ElseIf doc_bc.Text = "FA681200" And chk = "0" Then
            buy_etc_amt.Text = wamt : buy_etc_vat.Text = wvat
            buy_chakam_vat.Text = CDbl(IIf(buy_tot_vat.Text = "", 0, buy_tot_vat.Text)) - CDbl(IIf(no_dedu_vat.Text = "", 0, no_dedu_vat.Text))
            fn_buy_amt_sum()
            fn_buy_vat_sum()
            fnsum()
        ElseIf doc_bc.Text = "FA681300" And chk = "0" Then
            no_dedu_amt.Text = wamt : no_dedu_vat.Text = wvat
            buy_chakam_vat.Text = CDbl(IIf(buy_tot_vat.Text = "", 0, buy_tot_vat.Text)) - CDbl(IIf(no_dedu_vat.Text = "", 0, no_dedu_vat.Text))
            fn_buy_amt_sum()
            fn_buy_vat_sum()
            fnsum()
        ElseIf doc_bc.Text = "FA681400" And chk = "0" Then
            etc_vat.Text = wvat
            buy_chakam_vat.Text = CDbl(IIf(buy_tot_vat.Text = "", 0, buy_tot_vat.Text)) - CDbl(IIf(no_dedu_vat.Text = "", 0, no_dedu_vat.Text))
            fn_buy_amt_sum()
            fn_buy_vat_sum()
            fnsum()
        ElseIf doc_bc.Text = "FA681500" And chk = "0" Then
            add_vat.Text = wvat
            buy_chakam_vat.Text = CDbl(IIf(buy_tot_vat.Text = "", 0, buy_tot_vat.Text)) - CDbl(IIf(no_dedu_vat.Text = "", 0, no_dedu_vat.Text))
            fn_buy_amt_sum()
            fn_buy_vat_sum()
            fnsum()
        End If
        chk = "0"
        If Me.Save() Then
            Me.Open()
        End If
        EPanel3.Visible = False
    End Sub
#End Region

    Private Sub bs_cd_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bs_cd.TextChanged
        Dim P As New OpenParameters
        P.Add("@bs_cd", bs_cd.Text)
        'Command 생성
        dSet = Me.OpenDataSet("FAC600_bank", P)
        dRows = dSet.Tables(0).Rows
        Dim dRow As DataRow
        For Each dRow In dRows
            bank_cd.Text = ToStr(dRow("rtn_bank"))
            bank_loc.Text = ToStr(dRow("rtn_spot"))
            acct_no.Text = ToStr(dRow("rtn_acct"))
        Next
    End Sub

   
End Class
