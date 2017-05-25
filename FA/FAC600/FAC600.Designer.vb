<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAC600
    Inherits Base7.Form

    'UserControl은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.bs_cd = New Frame7.eCombo()
        Me.co_cd = New Frame7.eCombo()
        Me.tax_dtf = New Frame7.eDate()
        Me.mon_bc = New Frame7.eCombo()
        Me.work_dt = New Frame7.eDate()
        Me.tax_dtt = New Frame7.eDate()
        Me.tax_year = New Frame7.eDate()
        Me.EPanel3 = New Frame7.ePanel()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.doc_bc = New Frame7.eCombo()
        Me.g10 = New Frame7.eGrid()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdadd = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdetc = New DevExpress.XtraEditors.SimpleButton()
        Me.notax_in = New Frame7.eText()
        Me.notax_out = New Frame7.eText()
        Me.cmdbuy_miss = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdetc_dedu = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdsale_miss = New DevExpress.XtraEditors.SimpleButton()
        Me.cmddedu = New DevExpress.XtraEditors.SimpleButton()
        Me.free_sum_amt = New Frame7.eText()
        Me.free_amt3 = New Frame7.eText()
        Me.free_amt2 = New Frame7.eText()
        Me.free_ty2 = New Frame7.eText()
        Me.free_ty1 = New Frame7.eText()
        Me.free_kd2 = New Frame7.eText()
        Me.free_kd1 = New Frame7.eText()
        Me.free_ty3 = New Frame7.eText()
        Me.agent_tel = New Frame7.eText()
        Me.agent_no = New Frame7.eText()
        Me.agent_nm = New Frame7.eText()
        Me.tax_sum_amt = New Frame7.eText()
        Me.tax_amt4 = New Frame7.eText()
        Me.tax_ty4 = New Frame7.eText()
        Me.tax_amt3 = New Frame7.eText()
        Me.tax_ty3 = New Frame7.eText()
        Me.tax_kd3 = New Frame7.eText()
        Me.tax_ty2 = New Frame7.eText()
        Me.tax_amt2 = New Frame7.eText()
        Me.tax_kd2 = New Frame7.eText()
        Me.tax_amt1 = New Frame7.eText()
        Me.tax_ty1 = New Frame7.eText()
        Me.tax_kd1 = New Frame7.eText()
        Me.close_rmk = New Frame7.eText()
        Me.close_dt = New Frame7.eText()
        Me.acct_no = New Frame7.eText()
        Me.bank_loc = New Frame7.eText()
        Me.bank_cd = New Frame7.eText()
        Me.vat = New Frame7.eText()
        Me.result_vat = New Frame7.eText()
        Me.add_vat = New Frame7.eText()
        Me.spc_vat = New Frame7.eText()
        Me.plan_amt = New Frame7.eText()
        Me.non_repay = New Frame7.eText()
        Me.dedu_vat = New Frame7.eText()
        Me.card_vat = New Frame7.eText()
        Me.card_amt = New Frame7.eText()
        Me.etc_vat = New Frame7.eText()
        Me.give_amt = New Frame7.eText()
        Me.buy_chakam_vat = New Frame7.eText()
        Me.no_dedu_vat = New Frame7.eText()
        Me.buy_tot_vat = New Frame7.eText()
        Me.buy_etc_vat = New Frame7.eText()
        Me.buy_iss_vat = New Frame7.eText()
        Me.buy_miss_vat = New Frame7.eText()
        Me.ast_vat = New Frame7.eText()
        Me.buy_vat = New Frame7.eText()
        Me.buy_chakam_amt = New Frame7.eText()
        Me.no_dedu_amt = New Frame7.eText()
        Me.buy_tot_amt = New Frame7.eText()
        Me.buy_etc_amt = New Frame7.eText()
        Me.buy_iss_amt = New Frame7.eText()
        Me.buy_miss_amt = New Frame7.eText()
        Me.ast_amt = New Frame7.eText()
        Me.buy_amt = New Frame7.eText()
        Me.sale_miss_vat = New Frame7.eText()
        Me.bad_vat = New Frame7.eText()
        Me.sale_tot_vat = New Frame7.eText()
        Me.sale_etc_vat = New Frame7.eText()
        Me.sale_card_vat = New Frame7.eText()
        Me.sale_iss_vat = New Frame7.eText()
        Me.sale_vat = New Frame7.eText()
        Me.sale_tot_amt = New Frame7.eText()
        Me.sale_miss_amt = New Frame7.eText()
        Me.sale_zero_etc_amt = New Frame7.eText()
        Me.sale_zero_amt = New Frame7.eText()
        Me.sale_etc_amt = New Frame7.eText()
        Me.sale_card_amt = New Frame7.eText()
        Me.sale_iss_amt = New Frame7.eText()
        Me.sale_amt = New Frame7.eText()
        Me.free_amt1 = New Frame7.eText()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem9 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem10 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem11 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem12 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem13 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem14 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem15 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem16 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem17 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem18 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem19 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem20 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem21 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem22 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem25 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem23 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem26 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem28 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem29 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem30 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem31 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem33 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem27 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem34 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem35 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem32 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem24 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem36 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem37 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem38 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem39 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem40 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem41 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem43 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem45 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem46 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem48 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem49 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem50 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem51 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem52 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem47 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem42 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem53 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem54 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem55 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem57 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem58 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem59 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem60 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem33 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem34 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem35 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem36 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem61 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem64 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem37 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem65 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem66 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem67 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem68 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem69 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem70 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem71 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem72 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem73 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem74 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem75 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem76 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem39 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem77 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem78 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem79 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem80 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem40 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem41 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem81 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem42 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem82 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem83 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem84 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem43 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem85 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem86 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem87 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem44 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem88 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem89 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem90 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem45 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem91 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem92 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem47 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem93 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem48 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem49 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem56 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem99 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem95 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem96 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem97 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem98 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem50 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem53 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem54 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem100 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem101 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem55 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem56 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem103 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem105 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem106 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem107 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem108 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem109 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem57 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem58 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem111 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem104 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem112 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem113 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem114 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem115 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem59 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem110 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem60 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem61 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem118 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem119 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem120 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem117 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem121 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem123 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem122 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem62 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem124 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem116 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem63 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem64 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem125 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem127 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem128 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem126 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem129 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem65 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem130 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem67 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem134 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem132 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem133 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem131 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem136 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem137 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem66 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem138 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem94 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem139 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem140 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem141 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem68 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem102 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem135 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem143 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem144 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem69 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem70 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem71 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem142 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem145 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem147 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem151 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem152 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem153 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem154 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem149 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem155 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem156 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem72 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem73 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem157 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem74 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem76 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem150 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem158 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem160 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem159 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem78 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem161 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem77 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem162 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem163 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem164 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem165 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem166 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem167 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem168 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem169 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem79 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem80 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem148 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem170 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem171 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem81 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem146 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem172 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem173 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem174 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem82 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem83 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem175 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem44 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem38 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem55, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem57, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem58, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem59, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem60, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem64, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem65, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem66, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem67, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem68, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem69, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem70, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem71, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem72, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem73, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem74, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem75, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem76, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem77, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem78, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem79, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem80, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem81, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem82, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem83, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem84, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem85, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem86, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem87, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem88, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem89, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem90, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem91, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem92, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem93, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem99, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem95, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem96, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem97, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem98, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem100, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem101, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem55, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem103, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem105, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem106, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem107, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem108, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem109, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem57, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem58, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem111, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem104, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem112, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem113, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem114, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem115, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem59, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem110, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem60, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem118, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem119, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem120, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem117, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem121, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem123, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem122, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem62, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem124, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem116, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem63, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem64, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem125, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem127, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem128, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem126, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem129, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem65, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem130, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem67, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem134, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem132, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem133, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem131, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem136, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem137, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem66, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem138, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem94, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem139, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem140, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem141, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem68, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem102, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem135, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem143, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem144, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem69, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem70, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem71, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem142, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem145, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem147, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem151, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem152, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem153, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem154, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem149, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem155, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem156, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem72, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem73, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem157, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem74, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem76, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem150, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem158, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem160, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem159, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem78, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem161, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem77, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem162, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem163, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem164, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem165, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem166, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem167, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem168, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem169, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem79, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem80, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem148, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem170, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem171, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem81, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem146, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem172, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem173, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem174, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem82, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem83, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem175, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LayoutControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1166, 795)
        Me.SplitContainer1.SplitterDistance = 73
        Me.SplitContainer1.TabIndex = 4
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.bs_cd)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.tax_dtf)
        Me.EPanel1.Controls.Add(Me.mon_bc)
        Me.EPanel1.Controls.Add(Me.work_dt)
        Me.EPanel1.Controls.Add(Me.tax_dtt)
        Me.EPanel1.Controls.Add(Me.tax_year)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1166, 73)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     일반과세자부가가치세 신고서"
        '
        'bs_cd
        '
        Me.bs_cd.Location = New System.Drawing.Point(12, 48)
        Me.bs_cd.Name = "bs_cd"
        Me.bs_cd.Size = New System.Drawing.Size(240, 21)
        Me.bs_cd.TabIndex = 9
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(12, 24)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 8
        '
        'tax_dtf
        '
        Me.tax_dtf.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tax_dtf.Format = "yyyy-MM-dd"
        Me.tax_dtf.Location = New System.Drawing.Point(272, 48)
        Me.tax_dtf.Name = "tax_dtf"
        Me.tax_dtf.Size = New System.Drawing.Size(216, 21)
        Me.tax_dtf.TabIndex = 6
        '
        'mon_bc
        '
        Me.mon_bc.Location = New System.Drawing.Point(272, 24)
        Me.mon_bc.Name = "mon_bc"
        Me.mon_bc.Size = New System.Drawing.Size(340, 21)
        Me.mon_bc.TabIndex = 4
        '
        'work_dt
        '
        Me.work_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.work_dt.Location = New System.Drawing.Point(628, 48)
        Me.work_dt.Name = "work_dt"
        Me.work_dt.Size = New System.Drawing.Size(240, 21)
        Me.work_dt.TabIndex = 5
        '
        'tax_dtt
        '
        Me.tax_dtt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tax_dtt.Format = "yyyy-MM-dd"
        Me.tax_dtt.Location = New System.Drawing.Point(492, 48)
        Me.tax_dtt.Name = "tax_dtt"
        Me.tax_dtt.Size = New System.Drawing.Size(120, 21)
        Me.tax_dtt.TabIndex = 7
        Me.tax_dtt.Title = "~"
        Me.tax_dtt.TitleWidth = 30
        '
        'tax_year
        '
        Me.tax_year.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tax_year.Format = "yyyy"
        Me.tax_year.Location = New System.Drawing.Point(628, 24)
        Me.tax_year.Name = "tax_year"
        Me.tax_year.Size = New System.Drawing.Size(192, 21)
        Me.tax_year.TabIndex = 3
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.SplitContainer2)
        Me.EPanel3.Location = New System.Drawing.Point(404, 144)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(648, 359)
        Me.EPanel3.TabIndex = 4
        Me.EPanel3.Text = "     EPanel1"
        Me.EPanel3.Visible = False
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(2, 23)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SimpleButton1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.doc_bc)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.g10)
        Me.SplitContainer2.Size = New System.Drawing.Size(644, 334)
        Me.SplitContainer2.SplitterDistance = 28
        Me.SplitContainer2.TabIndex = 2
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(316, 1)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(152, 23)
        Me.SimpleButton1.TabIndex = 8
        Me.SimpleButton1.Text = "저장및종료"
        '
        'doc_bc
        '
        Me.doc_bc.Location = New System.Drawing.Point(4, 4)
        Me.doc_bc.Name = "doc_bc"
        Me.doc_bc.Size = New System.Drawing.Size(304, 21)
        Me.doc_bc.TabIndex = 7
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(644, 302)
        Me.g10.TabIndex = 0
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cmdadd)
        Me.LayoutControl1.Controls.Add(Me.cmdetc)
        Me.LayoutControl1.Controls.Add(Me.notax_in)
        Me.LayoutControl1.Controls.Add(Me.notax_out)
        Me.LayoutControl1.Controls.Add(Me.cmdbuy_miss)
        Me.LayoutControl1.Controls.Add(Me.cmdetc_dedu)
        Me.LayoutControl1.Controls.Add(Me.cmdsale_miss)
        Me.LayoutControl1.Controls.Add(Me.cmddedu)
        Me.LayoutControl1.Controls.Add(Me.free_sum_amt)
        Me.LayoutControl1.Controls.Add(Me.free_amt3)
        Me.LayoutControl1.Controls.Add(Me.free_amt2)
        Me.LayoutControl1.Controls.Add(Me.free_ty2)
        Me.LayoutControl1.Controls.Add(Me.free_ty1)
        Me.LayoutControl1.Controls.Add(Me.free_kd2)
        Me.LayoutControl1.Controls.Add(Me.free_kd1)
        Me.LayoutControl1.Controls.Add(Me.free_ty3)
        Me.LayoutControl1.Controls.Add(Me.agent_tel)
        Me.LayoutControl1.Controls.Add(Me.agent_no)
        Me.LayoutControl1.Controls.Add(Me.agent_nm)
        Me.LayoutControl1.Controls.Add(Me.tax_sum_amt)
        Me.LayoutControl1.Controls.Add(Me.tax_amt4)
        Me.LayoutControl1.Controls.Add(Me.tax_ty4)
        Me.LayoutControl1.Controls.Add(Me.tax_amt3)
        Me.LayoutControl1.Controls.Add(Me.tax_ty3)
        Me.LayoutControl1.Controls.Add(Me.tax_kd3)
        Me.LayoutControl1.Controls.Add(Me.tax_ty2)
        Me.LayoutControl1.Controls.Add(Me.tax_amt2)
        Me.LayoutControl1.Controls.Add(Me.tax_kd2)
        Me.LayoutControl1.Controls.Add(Me.tax_amt1)
        Me.LayoutControl1.Controls.Add(Me.tax_ty1)
        Me.LayoutControl1.Controls.Add(Me.tax_kd1)
        Me.LayoutControl1.Controls.Add(Me.close_rmk)
        Me.LayoutControl1.Controls.Add(Me.close_dt)
        Me.LayoutControl1.Controls.Add(Me.acct_no)
        Me.LayoutControl1.Controls.Add(Me.bank_loc)
        Me.LayoutControl1.Controls.Add(Me.bank_cd)
        Me.LayoutControl1.Controls.Add(Me.vat)
        Me.LayoutControl1.Controls.Add(Me.result_vat)
        Me.LayoutControl1.Controls.Add(Me.add_vat)
        Me.LayoutControl1.Controls.Add(Me.spc_vat)
        Me.LayoutControl1.Controls.Add(Me.plan_amt)
        Me.LayoutControl1.Controls.Add(Me.non_repay)
        Me.LayoutControl1.Controls.Add(Me.dedu_vat)
        Me.LayoutControl1.Controls.Add(Me.card_vat)
        Me.LayoutControl1.Controls.Add(Me.card_amt)
        Me.LayoutControl1.Controls.Add(Me.etc_vat)
        Me.LayoutControl1.Controls.Add(Me.give_amt)
        Me.LayoutControl1.Controls.Add(Me.buy_chakam_vat)
        Me.LayoutControl1.Controls.Add(Me.no_dedu_vat)
        Me.LayoutControl1.Controls.Add(Me.buy_tot_vat)
        Me.LayoutControl1.Controls.Add(Me.buy_etc_vat)
        Me.LayoutControl1.Controls.Add(Me.buy_iss_vat)
        Me.LayoutControl1.Controls.Add(Me.buy_miss_vat)
        Me.LayoutControl1.Controls.Add(Me.ast_vat)
        Me.LayoutControl1.Controls.Add(Me.buy_vat)
        Me.LayoutControl1.Controls.Add(Me.buy_chakam_amt)
        Me.LayoutControl1.Controls.Add(Me.no_dedu_amt)
        Me.LayoutControl1.Controls.Add(Me.buy_tot_amt)
        Me.LayoutControl1.Controls.Add(Me.buy_etc_amt)
        Me.LayoutControl1.Controls.Add(Me.buy_iss_amt)
        Me.LayoutControl1.Controls.Add(Me.buy_miss_amt)
        Me.LayoutControl1.Controls.Add(Me.ast_amt)
        Me.LayoutControl1.Controls.Add(Me.buy_amt)
        Me.LayoutControl1.Controls.Add(Me.sale_miss_vat)
        Me.LayoutControl1.Controls.Add(Me.bad_vat)
        Me.LayoutControl1.Controls.Add(Me.sale_tot_vat)
        Me.LayoutControl1.Controls.Add(Me.sale_etc_vat)
        Me.LayoutControl1.Controls.Add(Me.sale_card_vat)
        Me.LayoutControl1.Controls.Add(Me.sale_iss_vat)
        Me.LayoutControl1.Controls.Add(Me.sale_vat)
        Me.LayoutControl1.Controls.Add(Me.sale_tot_amt)
        Me.LayoutControl1.Controls.Add(Me.sale_miss_amt)
        Me.LayoutControl1.Controls.Add(Me.sale_zero_etc_amt)
        Me.LayoutControl1.Controls.Add(Me.sale_zero_amt)
        Me.LayoutControl1.Controls.Add(Me.sale_etc_amt)
        Me.LayoutControl1.Controls.Add(Me.sale_card_amt)
        Me.LayoutControl1.Controls.Add(Me.sale_iss_amt)
        Me.LayoutControl1.Controls.Add(Me.sale_amt)
        Me.LayoutControl1.Controls.Add(Me.free_amt1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1166, 718)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cmdadd
        '
        Me.cmdadd.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdadd.Appearance.Options.UseForeColor = True
        Me.cmdadd.Location = New System.Drawing.Point(12, 680)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(309, 22)
        Me.cmdadd.StyleController = Me.LayoutControl1
        Me.cmdadd.TabIndex = 14
        Me.cmdadd.Text = "가         산        세         액          계"
        '
        'cmdetc
        '
        Me.cmdetc.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdetc.Appearance.Options.UseForeColor = True
        Me.cmdetc.Location = New System.Drawing.Point(40, 394)
        Me.cmdetc.Name = "cmdetc"
        Me.cmdetc.Size = New System.Drawing.Size(281, 22)
        Me.cmdetc.StyleController = Me.LayoutControl1
        Me.cmdetc.TabIndex = 11
        Me.cmdetc.Text = "기    타    공    제    매    입    세    액"
        '
        'notax_in
        '
        Me.notax_in.Location = New System.Drawing.Point(540, 1270)
        Me.notax_in.Name = "notax_in"
        Me.notax_in.Size = New System.Drawing.Size(346, 21)
        Me.notax_in.TabIndex = 73
        Me.notax_in.TitleWidth = 0
        '
        'notax_out
        '
        Me.notax_out.Location = New System.Drawing.Point(540, 1244)
        Me.notax_out.Name = "notax_out"
        Me.notax_out.Size = New System.Drawing.Size(346, 21)
        Me.notax_out.TabIndex = 72
        Me.notax_out.TitleWidth = 0
        '
        'cmdbuy_miss
        '
        Me.cmdbuy_miss.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdbuy_miss.Appearance.Options.UseForeColor = True
        Me.cmdbuy_miss.Location = New System.Drawing.Point(40, 342)
        Me.cmdbuy_miss.Name = "cmdbuy_miss"
        Me.cmdbuy_miss.Size = New System.Drawing.Size(281, 22)
        Me.cmdbuy_miss.StyleController = Me.LayoutControl1
        Me.cmdbuy_miss.TabIndex = 10
        Me.cmdbuy_miss.Text = "예     정    신     고     누     락     분"
        '
        'cmdetc_dedu
        '
        Me.cmdetc_dedu.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdetc_dedu.Appearance.Options.UseForeColor = True
        Me.cmdetc_dedu.Location = New System.Drawing.Point(116, 524)
        Me.cmdetc_dedu.Name = "cmdetc_dedu"
        Me.cmdetc_dedu.Size = New System.Drawing.Size(205, 22)
        Me.cmdetc_dedu.StyleController = Me.LayoutControl1
        Me.cmdetc_dedu.TabIndex = 13
        Me.cmdetc_dedu.Text = "기  타  경  감  .  공  제  세  액"
        '
        'cmdsale_miss
        '
        Me.cmdsale_miss.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdsale_miss.Appearance.Options.UseForeColor = True
        Me.cmdsale_miss.Location = New System.Drawing.Point(40, 208)
        Me.cmdsale_miss.Name = "cmdsale_miss"
        Me.cmdsale_miss.Size = New System.Drawing.Size(281, 22)
        Me.cmdsale_miss.StyleController = Me.LayoutControl1
        Me.cmdsale_miss.TabIndex = 10
        Me.cmdsale_miss.Text = "예     정     신    고    누    락    분"
        '
        'cmddedu
        '
        Me.cmddedu.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmddedu.Appearance.Options.UseForeColor = True
        Me.cmddedu.Location = New System.Drawing.Point(40, 446)
        Me.cmddedu.Name = "cmddedu"
        Me.cmddedu.Size = New System.Drawing.Size(281, 22)
        Me.cmddedu.StyleController = Me.LayoutControl1
        Me.cmddedu.TabIndex = 12
        Me.cmddedu.Text = "공  제  받  지  못   할  매  입  세  액"
        '
        'free_sum_amt
        '
        Me.free_sum_amt.Location = New System.Drawing.Point(660, 1206)
        Me.free_sum_amt.Name = "free_sum_amt"
        Me.free_sum_amt.Size = New System.Drawing.Size(214, 21)
        Me.free_sum_amt.TabIndex = 71
        Me.free_sum_amt.TitleWidth = 0
        '
        'free_amt3
        '
        Me.free_amt3.Location = New System.Drawing.Point(660, 1180)
        Me.free_amt3.Name = "free_amt3"
        Me.free_amt3.Size = New System.Drawing.Size(214, 21)
        Me.free_amt3.TabIndex = 70
        Me.free_amt3.TitleWidth = 0
        '
        'free_amt2
        '
        Me.free_amt2.Location = New System.Drawing.Point(660, 1154)
        Me.free_amt2.Name = "free_amt2"
        Me.free_amt2.Size = New System.Drawing.Size(214, 21)
        Me.free_amt2.TabIndex = 68
        Me.free_amt2.TitleWidth = 0
        '
        'free_ty2
        '
        Me.free_ty2.Location = New System.Drawing.Point(360, 1154)
        Me.free_ty2.Name = "free_ty2"
        Me.free_ty2.Size = New System.Drawing.Size(196, 21)
        Me.free_ty2.TabIndex = 67
        Me.free_ty2.TitleWidth = 0
        '
        'free_ty1
        '
        Me.free_ty1.Location = New System.Drawing.Point(360, 1128)
        Me.free_ty1.Name = "free_ty1"
        Me.free_ty1.Size = New System.Drawing.Size(196, 21)
        Me.free_ty1.TabIndex = 64
        Me.free_ty1.TitleWidth = 0
        '
        'free_kd2
        '
        Me.free_kd2.Location = New System.Drawing.Point(203, 1154)
        Me.free_kd2.Name = "free_kd2"
        Me.free_kd2.Size = New System.Drawing.Size(153, 21)
        Me.free_kd2.TabIndex = 66
        Me.free_kd2.TitleWidth = 0
        '
        'free_kd1
        '
        Me.free_kd1.Location = New System.Drawing.Point(203, 1128)
        Me.free_kd1.Name = "free_kd1"
        Me.free_kd1.Size = New System.Drawing.Size(153, 21)
        Me.free_kd1.TabIndex = 63
        Me.free_kd1.TitleWidth = 0
        '
        'free_ty3
        '
        Me.free_ty3.Location = New System.Drawing.Point(360, 1180)
        Me.free_ty3.Name = "free_ty3"
        Me.free_ty3.Size = New System.Drawing.Size(196, 21)
        Me.free_ty3.TabIndex = 69
        Me.free_ty3.TitleWidth = 0
        '
        'agent_tel
        '
        Me.agent_tel.Location = New System.Drawing.Point(736, 1052)
        Me.agent_tel.Name = "agent_tel"
        Me.agent_tel.Size = New System.Drawing.Size(138, 21)
        Me.agent_tel.TabIndex = 62
        Me.agent_tel.TitleWidth = 0
        '
        'agent_no
        '
        Me.agent_no.Location = New System.Drawing.Point(455, 1052)
        Me.agent_no.Name = "agent_no"
        Me.agent_no.Size = New System.Drawing.Size(145, 21)
        Me.agent_no.TabIndex = 61
        Me.agent_no.TitleWidth = 0
        '
        'agent_nm
        '
        Me.agent_nm.Location = New System.Drawing.Point(228, 1052)
        Me.agent_nm.Name = "agent_nm"
        Me.agent_nm.Size = New System.Drawing.Size(116, 21)
        Me.agent_nm.TabIndex = 60
        Me.agent_nm.TitleWidth = 0
        '
        'tax_sum_amt
        '
        Me.tax_sum_amt.Location = New System.Drawing.Point(404, 1002)
        Me.tax_sum_amt.Name = "tax_sum_amt"
        Me.tax_sum_amt.Size = New System.Drawing.Size(220, 21)
        Me.tax_sum_amt.TabIndex = 59
        Me.tax_sum_amt.TitleWidth = 0
        '
        'tax_amt4
        '
        Me.tax_amt4.Location = New System.Drawing.Point(404, 976)
        Me.tax_amt4.Name = "tax_amt4"
        Me.tax_amt4.Size = New System.Drawing.Size(220, 21)
        Me.tax_amt4.TabIndex = 58
        Me.tax_amt4.TitleWidth = 0
        '
        'tax_ty4
        '
        Me.tax_ty4.Location = New System.Drawing.Point(202, 976)
        Me.tax_ty4.Name = "tax_ty4"
        Me.tax_ty4.Size = New System.Drawing.Size(138, 21)
        Me.tax_ty4.TabIndex = 57
        Me.tax_ty4.TitleWidth = 0
        '
        'tax_amt3
        '
        Me.tax_amt3.Location = New System.Drawing.Point(404, 950)
        Me.tax_amt3.Name = "tax_amt3"
        Me.tax_amt3.Size = New System.Drawing.Size(220, 21)
        Me.tax_amt3.TabIndex = 56
        Me.tax_amt3.TitleWidth = 0
        '
        'tax_ty3
        '
        Me.tax_ty3.Location = New System.Drawing.Point(202, 950)
        Me.tax_ty3.Name = "tax_ty3"
        Me.tax_ty3.Size = New System.Drawing.Size(138, 21)
        Me.tax_ty3.TabIndex = 55
        Me.tax_ty3.TitleWidth = 0
        '
        'tax_kd3
        '
        Me.tax_kd3.Location = New System.Drawing.Point(52, 950)
        Me.tax_kd3.Name = "tax_kd3"
        Me.tax_kd3.Size = New System.Drawing.Size(146, 21)
        Me.tax_kd3.TabIndex = 54
        Me.tax_kd3.TitleWidth = 0
        '
        'tax_ty2
        '
        Me.tax_ty2.Location = New System.Drawing.Point(202, 924)
        Me.tax_ty2.Name = "tax_ty2"
        Me.tax_ty2.Size = New System.Drawing.Size(138, 21)
        Me.tax_ty2.TabIndex = 52
        Me.tax_ty2.TitleWidth = 0
        '
        'tax_amt2
        '
        Me.tax_amt2.Location = New System.Drawing.Point(404, 924)
        Me.tax_amt2.Name = "tax_amt2"
        Me.tax_amt2.Size = New System.Drawing.Size(220, 21)
        Me.tax_amt2.TabIndex = 53
        Me.tax_amt2.TitleWidth = 0
        '
        'tax_kd2
        '
        Me.tax_kd2.Location = New System.Drawing.Point(52, 924)
        Me.tax_kd2.Name = "tax_kd2"
        Me.tax_kd2.Size = New System.Drawing.Size(146, 21)
        Me.tax_kd2.TabIndex = 51
        Me.tax_kd2.TitleWidth = 0
        '
        'tax_amt1
        '
        Me.tax_amt1.Location = New System.Drawing.Point(404, 898)
        Me.tax_amt1.Name = "tax_amt1"
        Me.tax_amt1.Size = New System.Drawing.Size(220, 21)
        Me.tax_amt1.TabIndex = 50
        Me.tax_amt1.TitleWidth = 0
        '
        'tax_ty1
        '
        Me.tax_ty1.Location = New System.Drawing.Point(202, 898)
        Me.tax_ty1.Name = "tax_ty1"
        Me.tax_ty1.Size = New System.Drawing.Size(138, 21)
        Me.tax_ty1.TabIndex = 49
        Me.tax_ty1.TitleWidth = 0
        '
        'tax_kd1
        '
        Me.tax_kd1.Location = New System.Drawing.Point(52, 898)
        Me.tax_kd1.Name = "tax_kd1"
        Me.tax_kd1.Size = New System.Drawing.Size(146, 21)
        Me.tax_kd1.TabIndex = 48
        Me.tax_kd1.TitleWidth = 0
        '
        'close_rmk
        '
        Me.close_rmk.Location = New System.Drawing.Point(465, 796)
        Me.close_rmk.Name = "close_rmk"
        Me.close_rmk.Size = New System.Drawing.Size(409, 21)
        Me.close_rmk.TabIndex = 47
        Me.close_rmk.TitleWidth = 0
        '
        'close_dt
        '
        Me.close_dt.Location = New System.Drawing.Point(241, 796)
        Me.close_dt.Name = "close_dt"
        Me.close_dt.Size = New System.Drawing.Size(155, 21)
        Me.close_dt.TabIndex = 46
        Me.close_dt.TitleWidth = 0
        '
        'acct_no
        '
        Me.acct_no.Location = New System.Drawing.Point(723, 770)
        Me.acct_no.Name = "acct_no"
        Me.acct_no.Size = New System.Drawing.Size(151, 21)
        Me.acct_no.TabIndex = 45
        Me.acct_no.TitleWidth = 0
        '
        'bank_loc
        '
        Me.bank_loc.Location = New System.Drawing.Point(465, 770)
        Me.bank_loc.Name = "bank_loc"
        Me.bank_loc.Size = New System.Drawing.Size(116, 21)
        Me.bank_loc.TabIndex = 44
        Me.bank_loc.TitleWidth = 0
        '
        'bank_cd
        '
        Me.bank_cd.Location = New System.Drawing.Point(241, 770)
        Me.bank_cd.Name = "bank_cd"
        Me.bank_cd.Size = New System.Drawing.Size(155, 21)
        Me.bank_cd.TabIndex = 43
        Me.bank_cd.TitleWidth = 0
        '
        'vat
        '
        Me.vat.Location = New System.Drawing.Point(666, 732)
        Me.vat.Name = "vat"
        Me.vat.Size = New System.Drawing.Size(220, 21)
        Me.vat.TabIndex = 42
        Me.vat.TabStop = False
        Me.vat.TitleWidth = 0
        '
        'result_vat
        '
        Me.result_vat.Location = New System.Drawing.Point(666, 706)
        Me.result_vat.Name = "result_vat"
        Me.result_vat.Size = New System.Drawing.Size(220, 21)
        Me.result_vat.TabIndex = 41
        Me.result_vat.TabStop = False
        Me.result_vat.TitleWidth = 0
        '
        'add_vat
        '
        Me.add_vat.Location = New System.Drawing.Point(666, 680)
        Me.add_vat.Name = "add_vat"
        Me.add_vat.Size = New System.Drawing.Size(220, 21)
        Me.add_vat.TabIndex = 40
        Me.add_vat.TitleWidth = 0
        '
        'spc_vat
        '
        Me.spc_vat.Location = New System.Drawing.Point(666, 654)
        Me.spc_vat.Name = "spc_vat"
        Me.spc_vat.Size = New System.Drawing.Size(220, 21)
        Me.spc_vat.TabIndex = 39
        Me.spc_vat.TitleWidth = 0
        '
        'plan_amt
        '
        Me.plan_amt.Location = New System.Drawing.Point(666, 628)
        Me.plan_amt.Name = "plan_amt"
        Me.plan_amt.Size = New System.Drawing.Size(220, 21)
        Me.plan_amt.TabIndex = 38
        Me.plan_amt.TitleWidth = 0
        '
        'non_repay
        '
        Me.non_repay.Location = New System.Drawing.Point(666, 602)
        Me.non_repay.Name = "non_repay"
        Me.non_repay.Size = New System.Drawing.Size(220, 21)
        Me.non_repay.TabIndex = 37
        Me.non_repay.TitleWidth = 0
        '
        'dedu_vat
        '
        Me.dedu_vat.Location = New System.Drawing.Point(666, 576)
        Me.dedu_vat.Name = "dedu_vat"
        Me.dedu_vat.Size = New System.Drawing.Size(220, 21)
        Me.dedu_vat.TabIndex = 36
        Me.dedu_vat.TitleWidth = 0
        '
        'card_vat
        '
        Me.card_vat.Location = New System.Drawing.Point(666, 550)
        Me.card_vat.Name = "card_vat"
        Me.card_vat.Size = New System.Drawing.Size(220, 21)
        Me.card_vat.TabIndex = 35
        Me.card_vat.TitleWidth = 0
        '
        'card_amt
        '
        Me.card_amt.Location = New System.Drawing.Point(361, 550)
        Me.card_amt.Name = "card_amt"
        Me.card_amt.Size = New System.Drawing.Size(232, 21)
        Me.card_amt.TabIndex = 34
        Me.card_amt.TitleWidth = 0
        '
        'etc_vat
        '
        Me.etc_vat.Location = New System.Drawing.Point(666, 524)
        Me.etc_vat.Name = "etc_vat"
        Me.etc_vat.Size = New System.Drawing.Size(220, 21)
        Me.etc_vat.TabIndex = 33
        Me.etc_vat.TitleWidth = 0
        '
        'give_amt
        '
        Me.give_amt.Location = New System.Drawing.Point(666, 498)
        Me.give_amt.Name = "give_amt"
        Me.give_amt.Size = New System.Drawing.Size(220, 21)
        Me.give_amt.TabIndex = 32
        Me.give_amt.TabStop = False
        Me.give_amt.TitleWidth = 0
        '
        'buy_chakam_vat
        '
        Me.buy_chakam_vat.Location = New System.Drawing.Point(666, 472)
        Me.buy_chakam_vat.Name = "buy_chakam_vat"
        Me.buy_chakam_vat.Size = New System.Drawing.Size(220, 21)
        Me.buy_chakam_vat.TabIndex = 31
        Me.buy_chakam_vat.TabStop = False
        Me.buy_chakam_vat.TitleWidth = 0
        '
        'no_dedu_vat
        '
        Me.no_dedu_vat.Location = New System.Drawing.Point(666, 446)
        Me.no_dedu_vat.Name = "no_dedu_vat"
        Me.no_dedu_vat.Size = New System.Drawing.Size(220, 21)
        Me.no_dedu_vat.TabIndex = 15
        Me.no_dedu_vat.TitleWidth = 0
        '
        'buy_tot_vat
        '
        Me.buy_tot_vat.Location = New System.Drawing.Point(666, 420)
        Me.buy_tot_vat.Name = "buy_tot_vat"
        Me.buy_tot_vat.Size = New System.Drawing.Size(220, 21)
        Me.buy_tot_vat.TabIndex = 30
        Me.buy_tot_vat.TabStop = False
        Me.buy_tot_vat.TitleWidth = 0
        '
        'buy_etc_vat
        '
        Me.buy_etc_vat.Location = New System.Drawing.Point(666, 394)
        Me.buy_etc_vat.Name = "buy_etc_vat"
        Me.buy_etc_vat.Size = New System.Drawing.Size(220, 21)
        Me.buy_etc_vat.TabIndex = 15
        Me.buy_etc_vat.TitleWidth = 0
        '
        'buy_iss_vat
        '
        Me.buy_iss_vat.Location = New System.Drawing.Point(666, 368)
        Me.buy_iss_vat.Name = "buy_iss_vat"
        Me.buy_iss_vat.Size = New System.Drawing.Size(220, 21)
        Me.buy_iss_vat.TabIndex = 29
        Me.buy_iss_vat.TitleWidth = 0
        '
        'buy_miss_vat
        '
        Me.buy_miss_vat.Location = New System.Drawing.Point(666, 342)
        Me.buy_miss_vat.Name = "buy_miss_vat"
        Me.buy_miss_vat.Size = New System.Drawing.Size(220, 21)
        Me.buy_miss_vat.TabIndex = 15
        Me.buy_miss_vat.TitleWidth = 0
        '
        'ast_vat
        '
        Me.ast_vat.Location = New System.Drawing.Point(666, 316)
        Me.ast_vat.Name = "ast_vat"
        Me.ast_vat.Size = New System.Drawing.Size(220, 21)
        Me.ast_vat.TabIndex = 28
        Me.ast_vat.TitleWidth = 0
        '
        'buy_vat
        '
        Me.buy_vat.Location = New System.Drawing.Point(666, 290)
        Me.buy_vat.Name = "buy_vat"
        Me.buy_vat.Size = New System.Drawing.Size(220, 21)
        Me.buy_vat.TabIndex = 15
        Me.buy_vat.TitleWidth = 0
        '
        'buy_chakam_amt
        '
        Me.buy_chakam_amt.Location = New System.Drawing.Point(361, 472)
        Me.buy_chakam_amt.Name = "buy_chakam_amt"
        Me.buy_chakam_amt.Size = New System.Drawing.Size(232, 21)
        Me.buy_chakam_amt.TabIndex = 27
        Me.buy_chakam_amt.TabStop = False
        Me.buy_chakam_amt.TitleWidth = 0
        '
        'no_dedu_amt
        '
        Me.no_dedu_amt.Location = New System.Drawing.Point(361, 446)
        Me.no_dedu_amt.Name = "no_dedu_amt"
        Me.no_dedu_amt.Size = New System.Drawing.Size(232, 21)
        Me.no_dedu_amt.TabIndex = 14
        Me.no_dedu_amt.TitleWidth = 0
        '
        'buy_tot_amt
        '
        Me.buy_tot_amt.Location = New System.Drawing.Point(361, 420)
        Me.buy_tot_amt.Name = "buy_tot_amt"
        Me.buy_tot_amt.Size = New System.Drawing.Size(232, 21)
        Me.buy_tot_amt.TabIndex = 26
        Me.buy_tot_amt.TabStop = False
        Me.buy_tot_amt.TitleWidth = 0
        '
        'buy_etc_amt
        '
        Me.buy_etc_amt.Location = New System.Drawing.Point(361, 394)
        Me.buy_etc_amt.Name = "buy_etc_amt"
        Me.buy_etc_amt.Size = New System.Drawing.Size(232, 21)
        Me.buy_etc_amt.TabIndex = 14
        Me.buy_etc_amt.TitleWidth = 0
        '
        'buy_iss_amt
        '
        Me.buy_iss_amt.Location = New System.Drawing.Point(361, 368)
        Me.buy_iss_amt.Name = "buy_iss_amt"
        Me.buy_iss_amt.Size = New System.Drawing.Size(232, 21)
        Me.buy_iss_amt.TabIndex = 25
        Me.buy_iss_amt.TitleWidth = 0
        '
        'buy_miss_amt
        '
        Me.buy_miss_amt.Location = New System.Drawing.Point(361, 342)
        Me.buy_miss_amt.Name = "buy_miss_amt"
        Me.buy_miss_amt.Size = New System.Drawing.Size(232, 21)
        Me.buy_miss_amt.TabIndex = 14
        Me.buy_miss_amt.TitleWidth = 0
        '
        'ast_amt
        '
        Me.ast_amt.Location = New System.Drawing.Point(361, 316)
        Me.ast_amt.Name = "ast_amt"
        Me.ast_amt.Size = New System.Drawing.Size(232, 21)
        Me.ast_amt.TabIndex = 24
        Me.ast_amt.TitleWidth = 0
        '
        'buy_amt
        '
        Me.buy_amt.Location = New System.Drawing.Point(361, 290)
        Me.buy_amt.Name = "buy_amt"
        Me.buy_amt.Size = New System.Drawing.Size(232, 21)
        Me.buy_amt.TabIndex = 14
        Me.buy_amt.TitleWidth = 0
        '
        'sale_miss_vat
        '
        Me.sale_miss_vat.Location = New System.Drawing.Point(666, 208)
        Me.sale_miss_vat.Name = "sale_miss_vat"
        Me.sale_miss_vat.Size = New System.Drawing.Size(220, 21)
        Me.sale_miss_vat.TabIndex = 20
        Me.sale_miss_vat.TitleWidth = 0
        '
        'bad_vat
        '
        Me.bad_vat.Location = New System.Drawing.Point(666, 234)
        Me.bad_vat.Name = "bad_vat"
        Me.bad_vat.Size = New System.Drawing.Size(220, 21)
        Me.bad_vat.TabIndex = 19
        Me.bad_vat.TitleWidth = 0
        '
        'sale_tot_vat
        '
        Me.sale_tot_vat.Location = New System.Drawing.Point(666, 262)
        Me.sale_tot_vat.Name = "sale_tot_vat"
        Me.sale_tot_vat.Size = New System.Drawing.Size(220, 21)
        Me.sale_tot_vat.TabIndex = 18
        Me.sale_tot_vat.TabStop = False
        Me.sale_tot_vat.TitleWidth = 0
        '
        'sale_etc_vat
        '
        Me.sale_etc_vat.Location = New System.Drawing.Point(666, 124)
        Me.sale_etc_vat.Name = "sale_etc_vat"
        Me.sale_etc_vat.Size = New System.Drawing.Size(220, 21)
        Me.sale_etc_vat.TabIndex = 17
        Me.sale_etc_vat.TitleWidth = 0
        '
        'sale_card_vat
        '
        Me.sale_card_vat.Location = New System.Drawing.Point(666, 96)
        Me.sale_card_vat.Name = "sale_card_vat"
        Me.sale_card_vat.Size = New System.Drawing.Size(220, 21)
        Me.sale_card_vat.TabIndex = 16
        Me.sale_card_vat.TitleWidth = 0
        '
        'sale_iss_vat
        '
        Me.sale_iss_vat.Location = New System.Drawing.Point(666, 68)
        Me.sale_iss_vat.Name = "sale_iss_vat"
        Me.sale_iss_vat.Size = New System.Drawing.Size(220, 21)
        Me.sale_iss_vat.TabIndex = 15
        Me.sale_iss_vat.TitleWidth = 0
        '
        'sale_vat
        '
        Me.sale_vat.Location = New System.Drawing.Point(666, 40)
        Me.sale_vat.Name = "sale_vat"
        Me.sale_vat.Size = New System.Drawing.Size(220, 21)
        Me.sale_vat.TabIndex = 14
        Me.sale_vat.TitleWidth = 0
        '
        'sale_tot_amt
        '
        Me.sale_tot_amt.Location = New System.Drawing.Point(361, 262)
        Me.sale_tot_amt.Name = "sale_tot_amt"
        Me.sale_tot_amt.Size = New System.Drawing.Size(232, 21)
        Me.sale_tot_amt.TabIndex = 13
        Me.sale_tot_amt.TabStop = False
        Me.sale_tot_amt.TitleWidth = 0
        '
        'sale_miss_amt
        '
        Me.sale_miss_amt.Location = New System.Drawing.Point(361, 208)
        Me.sale_miss_amt.Name = "sale_miss_amt"
        Me.sale_miss_amt.Size = New System.Drawing.Size(232, 21)
        Me.sale_miss_amt.TabIndex = 11
        Me.sale_miss_amt.TitleWidth = 0
        '
        'sale_zero_etc_amt
        '
        Me.sale_zero_etc_amt.Location = New System.Drawing.Point(361, 180)
        Me.sale_zero_etc_amt.Name = "sale_zero_etc_amt"
        Me.sale_zero_etc_amt.Size = New System.Drawing.Size(232, 21)
        Me.sale_zero_etc_amt.TabIndex = 10
        Me.sale_zero_etc_amt.TitleWidth = 0
        '
        'sale_zero_amt
        '
        Me.sale_zero_amt.Location = New System.Drawing.Point(361, 152)
        Me.sale_zero_amt.Name = "sale_zero_amt"
        Me.sale_zero_amt.Size = New System.Drawing.Size(232, 21)
        Me.sale_zero_amt.TabIndex = 9
        Me.sale_zero_amt.TitleWidth = 0
        '
        'sale_etc_amt
        '
        Me.sale_etc_amt.Location = New System.Drawing.Point(361, 124)
        Me.sale_etc_amt.Name = "sale_etc_amt"
        Me.sale_etc_amt.Size = New System.Drawing.Size(232, 21)
        Me.sale_etc_amt.TabIndex = 8
        Me.sale_etc_amt.TitleWidth = 0
        '
        'sale_card_amt
        '
        Me.sale_card_amt.Location = New System.Drawing.Point(361, 96)
        Me.sale_card_amt.Name = "sale_card_amt"
        Me.sale_card_amt.Size = New System.Drawing.Size(232, 21)
        Me.sale_card_amt.TabIndex = 7
        Me.sale_card_amt.TitleWidth = 0
        '
        'sale_iss_amt
        '
        Me.sale_iss_amt.Location = New System.Drawing.Point(361, 68)
        Me.sale_iss_amt.Name = "sale_iss_amt"
        Me.sale_iss_amt.Size = New System.Drawing.Size(232, 21)
        Me.sale_iss_amt.TabIndex = 6
        Me.sale_iss_amt.TitleWidth = 0
        '
        'sale_amt
        '
        Me.sale_amt.Location = New System.Drawing.Point(361, 40)
        Me.sale_amt.Name = "sale_amt"
        Me.sale_amt.Size = New System.Drawing.Size(232, 21)
        Me.sale_amt.TabIndex = 5
        Me.sale_amt.TitleWidth = 0
        '
        'free_amt1
        '
        Me.free_amt1.Location = New System.Drawing.Point(660, 1128)
        Me.free_amt1.Name = "free_amt1"
        Me.free_amt1.Size = New System.Drawing.Size(214, 21)
        Me.free_amt1.TabIndex = 65
        Me.free_amt1.TitleWidth = 0
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.EmptySpaceItem4, Me.EmptySpaceItem7, Me.EmptySpaceItem8, Me.EmptySpaceItem9, Me.EmptySpaceItem10, Me.EmptySpaceItem11, Me.EmptySpaceItem12, Me.EmptySpaceItem13, Me.EmptySpaceItem14, Me.EmptySpaceItem15, Me.EmptySpaceItem16, Me.EmptySpaceItem17, Me.EmptySpaceItem18, Me.EmptySpaceItem19, Me.EmptySpaceItem20, Me.EmptySpaceItem21, Me.EmptySpaceItem22, Me.EmptySpaceItem25, Me.EmptySpaceItem23, Me.EmptySpaceItem26, Me.EmptySpaceItem28, Me.EmptySpaceItem29, Me.EmptySpaceItem30, Me.EmptySpaceItem31, Me.EmptySpaceItem33, Me.EmptySpaceItem27, Me.EmptySpaceItem34, Me.EmptySpaceItem35, Me.EmptySpaceItem32, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem16, Me.LayoutControlItem15, Me.EmptySpaceItem24, Me.EmptySpaceItem36, Me.EmptySpaceItem37, Me.LayoutControlItem17, Me.EmptySpaceItem38, Me.EmptySpaceItem39, Me.EmptySpaceItem40, Me.EmptySpaceItem41, Me.EmptySpaceItem43, Me.EmptySpaceItem45, Me.EmptySpaceItem46, Me.EmptySpaceItem48, Me.EmptySpaceItem49, Me.EmptySpaceItem5, Me.EmptySpaceItem50, Me.EmptySpaceItem51, Me.EmptySpaceItem52, Me.EmptySpaceItem47, Me.EmptySpaceItem42, Me.EmptySpaceItem53, Me.EmptySpaceItem54, Me.EmptySpaceItem55, Me.EmptySpaceItem57, Me.EmptySpaceItem58, Me.EmptySpaceItem59, Me.EmptySpaceItem60, Me.LayoutControlItem21, Me.LayoutControlItem22, Me.LayoutControlItem23, Me.LayoutControlItem24, Me.LayoutControlItem25, Me.LayoutControlItem26, Me.LayoutControlItem27, Me.LayoutControlItem28, Me.LayoutControlItem29, Me.LayoutControlItem30, Me.LayoutControlItem31, Me.LayoutControlItem32, Me.LayoutControlItem33, Me.LayoutControlItem34, Me.LayoutControlItem35, Me.LayoutControlItem36, Me.EmptySpaceItem61, Me.EmptySpaceItem6, Me.EmptySpaceItem64, Me.LayoutControlItem37, Me.EmptySpaceItem65, Me.EmptySpaceItem66, Me.EmptySpaceItem67, Me.EmptySpaceItem68, Me.EmptySpaceItem69, Me.EmptySpaceItem70, Me.EmptySpaceItem71, Me.EmptySpaceItem72, Me.EmptySpaceItem73, Me.EmptySpaceItem74, Me.EmptySpaceItem75, Me.EmptySpaceItem76, Me.LayoutControlItem39, Me.EmptySpaceItem77, Me.EmptySpaceItem78, Me.EmptySpaceItem79, Me.EmptySpaceItem80, Me.LayoutControlItem40, Me.LayoutControlItem41, Me.EmptySpaceItem81, Me.LayoutControlItem42, Me.EmptySpaceItem82, Me.EmptySpaceItem83, Me.EmptySpaceItem84, Me.LayoutControlItem43, Me.EmptySpaceItem85, Me.EmptySpaceItem86, Me.EmptySpaceItem87, Me.LayoutControlItem44, Me.EmptySpaceItem88, Me.EmptySpaceItem89, Me.EmptySpaceItem90, Me.LayoutControlItem45, Me.EmptySpaceItem91, Me.EmptySpaceItem92, Me.LayoutControlItem47, Me.EmptySpaceItem93, Me.LayoutControlItem48, Me.LayoutControlItem49, Me.LayoutControlGroup3, Me.LayoutControlGroup4, Me.LayoutControlGroup5, Me.LayoutControlGroup6, Me.EmptySpaceItem146, Me.EmptySpaceItem172, Me.EmptySpaceItem173, Me.EmptySpaceItem174, Me.LayoutControlItem82, Me.LayoutControlItem83, Me.EmptySpaceItem175, Me.LayoutControlItem1, Me.LayoutControlItem9, Me.LayoutControlItem18, Me.LayoutControlItem19, Me.EmptySpaceItem44, Me.LayoutControlItem20, Me.LayoutControlItem38})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1149, 1314)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmptySpaceItem1.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem1.AppearanceItemCaption.Options.UseFont = True
        Me.EmptySpaceItem1.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem1.CustomizationFormText = "구            분"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(349, 28)
        Me.EmptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
        Me.EmptySpaceItem1.Text = "구            분"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem1.TextVisible = True
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem2.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem2.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem2.CustomizationFormText = "금             액"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(349, 0)
        Me.EmptySpaceItem2.MaxSize = New System.Drawing.Size(236, 28)
        Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(236, 28)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(236, 28)
        Me.EmptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem2.Text = "금             액"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem2.TextVisible = True
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem3.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem3.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem3.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem3.CustomizationFormText = "세율"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(585, 0)
        Me.EmptySpaceItem3.MaxSize = New System.Drawing.Size(69, 28)
        Me.EmptySpaceItem3.MinSize = New System.Drawing.Size(69, 28)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(69, 28)
        Me.EmptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem3.Text = "세율"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem3.TextVisible = True
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem4.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem4.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem4.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem4.CustomizationFormText = "세       액"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(654, 0)
        Me.EmptySpaceItem4.MinSize = New System.Drawing.Size(104, 24)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(224, 28)
        Me.EmptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem4.Text = "세       액"
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem4.TextVisible = True
        '
        'EmptySpaceItem7
        '
        Me.EmptySpaceItem7.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem7.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem7.CustomizationFormText = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Location = New System.Drawing.Point(585, 28)
        Me.EmptySpaceItem7.MaxSize = New System.Drawing.Size(69, 28)
        Me.EmptySpaceItem7.MinSize = New System.Drawing.Size(69, 28)
        Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Size = New System.Drawing.Size(69, 28)
        Me.EmptySpaceItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem7.Text = " "
        Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem7.TextVisible = True
        '
        'EmptySpaceItem8
        '
        Me.EmptySpaceItem8.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem8.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem8.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem8.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem8.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem8.CustomizationFormText = "세  금  계   산  서   교  부  분"
        Me.EmptySpaceItem8.Location = New System.Drawing.Point(56, 28)
        Me.EmptySpaceItem8.MaxSize = New System.Drawing.Size(257, 28)
        Me.EmptySpaceItem8.MinSize = New System.Drawing.Size(257, 26)
        Me.EmptySpaceItem8.Name = "EmptySpaceItem8"
        Me.EmptySpaceItem8.Size = New System.Drawing.Size(257, 28)
        Me.EmptySpaceItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem8.Text = "세  금  계   산  서   교  부  분"
        Me.EmptySpaceItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem8.TextVisible = True
        '
        'EmptySpaceItem9
        '
        Me.EmptySpaceItem9.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem9.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem9.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem9.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem9.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem9.CustomizationFormText = "매 입 자 발 행 세 금 계 산 서"
        Me.EmptySpaceItem9.Location = New System.Drawing.Point(56, 56)
        Me.EmptySpaceItem9.MaxSize = New System.Drawing.Size(257, 28)
        Me.EmptySpaceItem9.MinSize = New System.Drawing.Size(257, 28)
        Me.EmptySpaceItem9.Name = "EmptySpaceItem9"
        Me.EmptySpaceItem9.Size = New System.Drawing.Size(257, 28)
        Me.EmptySpaceItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem9.Text = "매 입 자 발 행 세 금 계 산 서"
        Me.EmptySpaceItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem9.TextVisible = True
        '
        'EmptySpaceItem10
        '
        Me.EmptySpaceItem10.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem10.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem10.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem10.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem10.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem10.CustomizationFormText = "신용카드 . 현금영수증발행분"
        Me.EmptySpaceItem10.Location = New System.Drawing.Point(56, 84)
        Me.EmptySpaceItem10.MaxSize = New System.Drawing.Size(257, 28)
        Me.EmptySpaceItem10.MinSize = New System.Drawing.Size(257, 28)
        Me.EmptySpaceItem10.Name = "EmptySpaceItem10"
        Me.EmptySpaceItem10.Size = New System.Drawing.Size(257, 28)
        Me.EmptySpaceItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem10.Text = "신용카드 . 현금영수증발행분"
        Me.EmptySpaceItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem10.TextVisible = True
        '
        'EmptySpaceItem11
        '
        Me.EmptySpaceItem11.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem11.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem11.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem11.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem11.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem11.CustomizationFormText = "기 타 ( 정규영수증외매출분 )"
        Me.EmptySpaceItem11.Location = New System.Drawing.Point(56, 112)
        Me.EmptySpaceItem11.MaxSize = New System.Drawing.Size(257, 28)
        Me.EmptySpaceItem11.MinSize = New System.Drawing.Size(257, 28)
        Me.EmptySpaceItem11.Name = "EmptySpaceItem11"
        Me.EmptySpaceItem11.Size = New System.Drawing.Size(257, 28)
        Me.EmptySpaceItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem11.Text = "기 타 ( 정규영수증외매출분 )"
        Me.EmptySpaceItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem11.TextVisible = True
        '
        'EmptySpaceItem12
        '
        Me.EmptySpaceItem12.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem12.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem12.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem12.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem12.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem12.CustomizationFormText = "세  금  계  산  서   교  부  분"
        Me.EmptySpaceItem12.Location = New System.Drawing.Point(56, 140)
        Me.EmptySpaceItem12.MaxSize = New System.Drawing.Size(257, 28)
        Me.EmptySpaceItem12.MinSize = New System.Drawing.Size(257, 28)
        Me.EmptySpaceItem12.Name = "EmptySpaceItem12"
        Me.EmptySpaceItem12.Size = New System.Drawing.Size(257, 28)
        Me.EmptySpaceItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem12.Text = "세  금  계  산  서   교  부  분"
        Me.EmptySpaceItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem12.TextVisible = True
        '
        'EmptySpaceItem13
        '
        Me.EmptySpaceItem13.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem13.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem13.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem13.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem13.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem13.CustomizationFormText = "기                                 타"
        Me.EmptySpaceItem13.Location = New System.Drawing.Point(56, 168)
        Me.EmptySpaceItem13.MaxSize = New System.Drawing.Size(257, 28)
        Me.EmptySpaceItem13.MinSize = New System.Drawing.Size(257, 28)
        Me.EmptySpaceItem13.Name = "EmptySpaceItem13"
        Me.EmptySpaceItem13.Size = New System.Drawing.Size(257, 28)
        Me.EmptySpaceItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem13.Text = "기                                 타"
        Me.EmptySpaceItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem13.TextVisible = True
        '
        'EmptySpaceItem14
        '
        Me.EmptySpaceItem14.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem14.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem14.CustomizationFormText = "EmptySpaceItem14"
        Me.EmptySpaceItem14.Location = New System.Drawing.Point(585, 196)
        Me.EmptySpaceItem14.MaxSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem14.MinSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem14.Name = "EmptySpaceItem14"
        Me.EmptySpaceItem14.Size = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem14.Text = " "
        Me.EmptySpaceItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem14.TextVisible = True
        '
        'EmptySpaceItem15
        '
        Me.EmptySpaceItem15.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem15.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem15.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem15.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem15.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem15.CustomizationFormText = "대      손      세       액    가      감"
        Me.EmptySpaceItem15.Location = New System.Drawing.Point(28, 222)
        Me.EmptySpaceItem15.MaxSize = New System.Drawing.Size(285, 28)
        Me.EmptySpaceItem15.MinSize = New System.Drawing.Size(285, 28)
        Me.EmptySpaceItem15.Name = "EmptySpaceItem15"
        Me.EmptySpaceItem15.Size = New System.Drawing.Size(285, 28)
        Me.EmptySpaceItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem15.Text = "대      손      세       액    가      감"
        Me.EmptySpaceItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem15.TextVisible = True
        '
        'EmptySpaceItem16
        '
        Me.EmptySpaceItem16.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem16.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem16.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem16.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem16.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem16.CustomizationFormText = "합                                         계"
        Me.EmptySpaceItem16.Location = New System.Drawing.Point(28, 250)
        Me.EmptySpaceItem16.MaxSize = New System.Drawing.Size(285, 28)
        Me.EmptySpaceItem16.MinSize = New System.Drawing.Size(285, 28)
        Me.EmptySpaceItem16.Name = "EmptySpaceItem16"
        Me.EmptySpaceItem16.Size = New System.Drawing.Size(285, 28)
        Me.EmptySpaceItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem16.Text = "합                                         계"
        Me.EmptySpaceItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem16.TextVisible = True
        '
        'EmptySpaceItem17
        '
        Me.EmptySpaceItem17.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem17.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmptySpaceItem17.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem17.AppearanceItemCaption.Options.UseFont = True
        Me.EmptySpaceItem17.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem17.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem17.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem17.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.EmptySpaceItem17.CustomizationFormText = "과세표준 및 매출세액"
        Me.EmptySpaceItem17.Location = New System.Drawing.Point(0, 28)
        Me.EmptySpaceItem17.MaxSize = New System.Drawing.Size(28, 250)
        Me.EmptySpaceItem17.MinSize = New System.Drawing.Size(28, 250)
        Me.EmptySpaceItem17.Name = "EmptySpaceItem17"
        Me.EmptySpaceItem17.Size = New System.Drawing.Size(28, 250)
        Me.EmptySpaceItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem17.Text = "과세표준 및 매출세액"
        Me.EmptySpaceItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem17.TextVisible = True
        '
        'EmptySpaceItem18
        '
        Me.EmptySpaceItem18.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem18.AppearanceItemCaption.BorderColor = System.Drawing.Color.DimGray
        Me.EmptySpaceItem18.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmptySpaceItem18.AppearanceItemCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.EmptySpaceItem18.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem18.AppearanceItemCaption.Options.UseBorderColor = True
        Me.EmptySpaceItem18.AppearanceItemCaption.Options.UseFont = True
        Me.EmptySpaceItem18.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem18.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem18.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem18.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.EmptySpaceItem18.CustomizationFormText = "과세"
        Me.EmptySpaceItem18.Location = New System.Drawing.Point(28, 28)
        Me.EmptySpaceItem18.MaxSize = New System.Drawing.Size(0, 112)
        Me.EmptySpaceItem18.MinSize = New System.Drawing.Size(10, 112)
        Me.EmptySpaceItem18.Name = "EmptySpaceItem18"
        Me.EmptySpaceItem18.Size = New System.Drawing.Size(28, 112)
        Me.EmptySpaceItem18.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem18.Text = "과세"
        Me.EmptySpaceItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem18.TextVisible = True
        '
        'EmptySpaceItem19
        '
        Me.EmptySpaceItem19.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem19.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmptySpaceItem19.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem19.AppearanceItemCaption.Options.UseFont = True
        Me.EmptySpaceItem19.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem19.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem19.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem19.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.EmptySpaceItem19.CustomizationFormText = "영세율"
        Me.EmptySpaceItem19.Location = New System.Drawing.Point(28, 140)
        Me.EmptySpaceItem19.MaxSize = New System.Drawing.Size(28, 56)
        Me.EmptySpaceItem19.MinSize = New System.Drawing.Size(28, 56)
        Me.EmptySpaceItem19.Name = "EmptySpaceItem19"
        Me.EmptySpaceItem19.Size = New System.Drawing.Size(28, 56)
        Me.EmptySpaceItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem19.Text = "영세율"
        Me.EmptySpaceItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem19.TextVisible = True
        '
        'EmptySpaceItem20
        '
        Me.EmptySpaceItem20.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem20.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem20.CustomizationFormText = "EmptySpaceItem20"
        Me.EmptySpaceItem20.Location = New System.Drawing.Point(585, 56)
        Me.EmptySpaceItem20.MaxSize = New System.Drawing.Size(69, 28)
        Me.EmptySpaceItem20.MinSize = New System.Drawing.Size(69, 28)
        Me.EmptySpaceItem20.Name = "EmptySpaceItem20"
        Me.EmptySpaceItem20.Size = New System.Drawing.Size(69, 28)
        Me.EmptySpaceItem20.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem20.Text = " "
        Me.EmptySpaceItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem20.TextVisible = True
        '
        'EmptySpaceItem21
        '
        Me.EmptySpaceItem21.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem21.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem21.CustomizationFormText = "EmptySpaceItem21"
        Me.EmptySpaceItem21.Location = New System.Drawing.Point(585, 84)
        Me.EmptySpaceItem21.MaxSize = New System.Drawing.Size(69, 28)
        Me.EmptySpaceItem21.MinSize = New System.Drawing.Size(69, 28)
        Me.EmptySpaceItem21.Name = "EmptySpaceItem21"
        Me.EmptySpaceItem21.Size = New System.Drawing.Size(69, 28)
        Me.EmptySpaceItem21.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem21.Text = " "
        Me.EmptySpaceItem21.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem21.TextVisible = True
        '
        'EmptySpaceItem22
        '
        Me.EmptySpaceItem22.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem22.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem22.CustomizationFormText = "EmptySpaceItem22"
        Me.EmptySpaceItem22.Location = New System.Drawing.Point(585, 112)
        Me.EmptySpaceItem22.MaxSize = New System.Drawing.Size(69, 28)
        Me.EmptySpaceItem22.MinSize = New System.Drawing.Size(69, 28)
        Me.EmptySpaceItem22.Name = "EmptySpaceItem22"
        Me.EmptySpaceItem22.Size = New System.Drawing.Size(69, 28)
        Me.EmptySpaceItem22.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem22.Text = " "
        Me.EmptySpaceItem22.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem22.TextVisible = True
        '
        'EmptySpaceItem25
        '
        Me.EmptySpaceItem25.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem25.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem25.CustomizationFormText = "EmptySpaceItem25"
        Me.EmptySpaceItem25.Location = New System.Drawing.Point(585, 168)
        Me.EmptySpaceItem25.MaxSize = New System.Drawing.Size(69, 28)
        Me.EmptySpaceItem25.MinSize = New System.Drawing.Size(69, 28)
        Me.EmptySpaceItem25.Name = "EmptySpaceItem25"
        Me.EmptySpaceItem25.Size = New System.Drawing.Size(69, 28)
        Me.EmptySpaceItem25.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem25.Text = " "
        Me.EmptySpaceItem25.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem25.TextVisible = True
        '
        'EmptySpaceItem23
        '
        Me.EmptySpaceItem23.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem23.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem23.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem23.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem23.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem23.CustomizationFormText = "①"
        Me.EmptySpaceItem23.Location = New System.Drawing.Point(313, 28)
        Me.EmptySpaceItem23.MaxSize = New System.Drawing.Size(36, 28)
        Me.EmptySpaceItem23.MinSize = New System.Drawing.Size(36, 28)
        Me.EmptySpaceItem23.Name = "EmptySpaceItem23"
        Me.EmptySpaceItem23.Size = New System.Drawing.Size(36, 28)
        Me.EmptySpaceItem23.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem23.Text = "①"
        Me.EmptySpaceItem23.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem23.TextVisible = True
        '
        'EmptySpaceItem26
        '
        Me.EmptySpaceItem26.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem26.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem26.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem26.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem26.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem26.CustomizationFormText = "②"
        Me.EmptySpaceItem26.Location = New System.Drawing.Point(313, 56)
        Me.EmptySpaceItem26.MaxSize = New System.Drawing.Size(36, 28)
        Me.EmptySpaceItem26.MinSize = New System.Drawing.Size(36, 28)
        Me.EmptySpaceItem26.Name = "EmptySpaceItem26"
        Me.EmptySpaceItem26.Size = New System.Drawing.Size(36, 28)
        Me.EmptySpaceItem26.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem26.Text = "②"
        Me.EmptySpaceItem26.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem26.TextVisible = True
        '
        'EmptySpaceItem28
        '
        Me.EmptySpaceItem28.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem28.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem28.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem28.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem28.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem28.CustomizationFormText = "③"
        Me.EmptySpaceItem28.Location = New System.Drawing.Point(313, 84)
        Me.EmptySpaceItem28.MaxSize = New System.Drawing.Size(36, 28)
        Me.EmptySpaceItem28.MinSize = New System.Drawing.Size(36, 28)
        Me.EmptySpaceItem28.Name = "EmptySpaceItem28"
        Me.EmptySpaceItem28.Size = New System.Drawing.Size(36, 28)
        Me.EmptySpaceItem28.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem28.Text = "③"
        Me.EmptySpaceItem28.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem28.TextVisible = True
        '
        'EmptySpaceItem29
        '
        Me.EmptySpaceItem29.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem29.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem29.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem29.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem29.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem29.CustomizationFormText = "④"
        Me.EmptySpaceItem29.Location = New System.Drawing.Point(313, 112)
        Me.EmptySpaceItem29.MaxSize = New System.Drawing.Size(36, 28)
        Me.EmptySpaceItem29.MinSize = New System.Drawing.Size(36, 28)
        Me.EmptySpaceItem29.Name = "EmptySpaceItem29"
        Me.EmptySpaceItem29.Size = New System.Drawing.Size(36, 28)
        Me.EmptySpaceItem29.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem29.Text = "④"
        Me.EmptySpaceItem29.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem29.TextVisible = True
        '
        'EmptySpaceItem30
        '
        Me.EmptySpaceItem30.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem30.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem30.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem30.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem30.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem30.CustomizationFormText = "⑤"
        Me.EmptySpaceItem30.Location = New System.Drawing.Point(313, 140)
        Me.EmptySpaceItem30.MaxSize = New System.Drawing.Size(36, 28)
        Me.EmptySpaceItem30.MinSize = New System.Drawing.Size(36, 28)
        Me.EmptySpaceItem30.Name = "EmptySpaceItem30"
        Me.EmptySpaceItem30.Size = New System.Drawing.Size(36, 28)
        Me.EmptySpaceItem30.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem30.Text = "⑤"
        Me.EmptySpaceItem30.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem30.TextVisible = True
        '
        'EmptySpaceItem31
        '
        Me.EmptySpaceItem31.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem31.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem31.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem31.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem31.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem31.CustomizationFormText = "⑥"
        Me.EmptySpaceItem31.Location = New System.Drawing.Point(313, 168)
        Me.EmptySpaceItem31.MaxSize = New System.Drawing.Size(36, 28)
        Me.EmptySpaceItem31.MinSize = New System.Drawing.Size(36, 28)
        Me.EmptySpaceItem31.Name = "EmptySpaceItem31"
        Me.EmptySpaceItem31.Size = New System.Drawing.Size(36, 28)
        Me.EmptySpaceItem31.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem31.Text = "⑥"
        Me.EmptySpaceItem31.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem31.TextVisible = True
        '
        'EmptySpaceItem33
        '
        Me.EmptySpaceItem33.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem33.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem33.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem33.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem33.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem33.CustomizationFormText = "⑦"
        Me.EmptySpaceItem33.Location = New System.Drawing.Point(313, 196)
        Me.EmptySpaceItem33.MaxSize = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem33.MinSize = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem33.Name = "EmptySpaceItem33"
        Me.EmptySpaceItem33.Size = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem33.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem33.Text = "⑦"
        Me.EmptySpaceItem33.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem33.TextVisible = True
        '
        'EmptySpaceItem27
        '
        Me.EmptySpaceItem27.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem27.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem27.CustomizationFormText = "EmptySpaceItem27"
        Me.EmptySpaceItem27.Location = New System.Drawing.Point(585, 222)
        Me.EmptySpaceItem27.MaxSize = New System.Drawing.Size(69, 28)
        Me.EmptySpaceItem27.MinSize = New System.Drawing.Size(69, 28)
        Me.EmptySpaceItem27.Name = "EmptySpaceItem27"
        Me.EmptySpaceItem27.Size = New System.Drawing.Size(69, 28)
        Me.EmptySpaceItem27.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem27.Text = " "
        Me.EmptySpaceItem27.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem27.TextVisible = True
        '
        'EmptySpaceItem34
        '
        Me.EmptySpaceItem34.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem34.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem34.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem34.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem34.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem34.CustomizationFormText = "EmptySpaceItem34"
        Me.EmptySpaceItem34.Location = New System.Drawing.Point(585, 250)
        Me.EmptySpaceItem34.MaxSize = New System.Drawing.Size(69, 28)
        Me.EmptySpaceItem34.MinSize = New System.Drawing.Size(69, 28)
        Me.EmptySpaceItem34.Name = "EmptySpaceItem34"
        Me.EmptySpaceItem34.Size = New System.Drawing.Size(69, 28)
        Me.EmptySpaceItem34.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem34.Text = " ㉮"
        Me.EmptySpaceItem34.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem34.TextVisible = True
        '
        'EmptySpaceItem35
        '
        Me.EmptySpaceItem35.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem35.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem35.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem35.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem35.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem35.CustomizationFormText = "⑧"
        Me.EmptySpaceItem35.Location = New System.Drawing.Point(313, 222)
        Me.EmptySpaceItem35.MaxSize = New System.Drawing.Size(36, 28)
        Me.EmptySpaceItem35.MinSize = New System.Drawing.Size(36, 28)
        Me.EmptySpaceItem35.Name = "EmptySpaceItem35"
        Me.EmptySpaceItem35.Size = New System.Drawing.Size(36, 28)
        Me.EmptySpaceItem35.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem35.Text = "⑧"
        Me.EmptySpaceItem35.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem35.TextVisible = True
        '
        'EmptySpaceItem32
        '
        Me.EmptySpaceItem32.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem32.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem32.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem32.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem32.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem32.CustomizationFormText = "⑨"
        Me.EmptySpaceItem32.Location = New System.Drawing.Point(313, 250)
        Me.EmptySpaceItem32.MaxSize = New System.Drawing.Size(36, 28)
        Me.EmptySpaceItem32.MinSize = New System.Drawing.Size(36, 28)
        Me.EmptySpaceItem32.Name = "EmptySpaceItem32"
        Me.EmptySpaceItem32.Size = New System.Drawing.Size(36, 28)
        Me.EmptySpaceItem32.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem32.Text = "⑨"
        Me.EmptySpaceItem32.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem32.TextVisible = True
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlItem2.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LayoutControlItem2.Control = Me.sale_amt
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(349, 28)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(236, 28)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.sale_iss_amt
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(349, 56)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(236, 28)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.sale_card_amt
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(349, 84)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(236, 28)
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.sale_etc_amt
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(349, 112)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(236, 28)
        Me.LayoutControlItem5.Text = "LayoutControlItem5"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.sale_zero_amt
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(349, 140)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(236, 28)
        Me.LayoutControlItem6.Text = "LayoutControlItem6"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 0
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.sale_zero_etc_amt
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(349, 168)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(236, 28)
        Me.LayoutControlItem7.Text = "LayoutControlItem7"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextToControlDistance = 0
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.sale_miss_amt
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(349, 196)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem8.Text = "LayoutControlItem8"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextToControlDistance = 0
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.sale_tot_amt
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(349, 250)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(236, 28)
        Me.LayoutControlItem10.Text = "LayoutControlItem10"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextToControlDistance = 0
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.sale_vat
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(654, 28)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(224, 28)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(224, 28)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(224, 28)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.Text = "LayoutControlItem11"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextToControlDistance = 0
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.sale_iss_vat
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(654, 56)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(224, 28)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(224, 28)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(224, 28)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.Text = "LayoutControlItem12"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextToControlDistance = 0
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.sale_card_vat
        Me.LayoutControlItem13.CustomizationFormText = "LayoutControlItem13"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(654, 84)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(224, 28)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(224, 28)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(224, 28)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.Text = "LayoutControlItem13"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextToControlDistance = 0
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.sale_etc_vat
        Me.LayoutControlItem14.CustomizationFormText = "LayoutControlItem14"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(654, 112)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(224, 28)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(224, 28)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(224, 28)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.Text = "LayoutControlItem14"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextToControlDistance = 0
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.bad_vat
        Me.LayoutControlItem16.CustomizationFormText = "LayoutControlItem16"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(654, 222)
        Me.LayoutControlItem16.MaxSize = New System.Drawing.Size(224, 28)
        Me.LayoutControlItem16.MinSize = New System.Drawing.Size(224, 28)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(224, 28)
        Me.LayoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem16.Text = "LayoutControlItem16"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextToControlDistance = 0
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.sale_tot_vat
        Me.LayoutControlItem15.CustomizationFormText = "LayoutControlItem15"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(654, 250)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(224, 28)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(224, 28)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(224, 28)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.Text = "LayoutControlItem15"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextToControlDistance = 0
        Me.LayoutControlItem15.TextVisible = False
        '
        'EmptySpaceItem24
        '
        Me.EmptySpaceItem24.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem24.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem24.CustomizationFormText = "EmptySpaceItem24"
        Me.EmptySpaceItem24.Location = New System.Drawing.Point(585, 140)
        Me.EmptySpaceItem24.MaxSize = New System.Drawing.Size(69, 28)
        Me.EmptySpaceItem24.MinSize = New System.Drawing.Size(69, 28)
        Me.EmptySpaceItem24.Name = "EmptySpaceItem24"
        Me.EmptySpaceItem24.Size = New System.Drawing.Size(69, 28)
        Me.EmptySpaceItem24.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem24.Text = " "
        Me.EmptySpaceItem24.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem24.TextVisible = True
        '
        'EmptySpaceItem36
        '
        Me.EmptySpaceItem36.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem36.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem36.CustomizationFormText = " "
        Me.EmptySpaceItem36.Location = New System.Drawing.Point(654, 140)
        Me.EmptySpaceItem36.MaxSize = New System.Drawing.Size(224, 28)
        Me.EmptySpaceItem36.MinSize = New System.Drawing.Size(224, 28)
        Me.EmptySpaceItem36.Name = "EmptySpaceItem36"
        Me.EmptySpaceItem36.Size = New System.Drawing.Size(224, 28)
        Me.EmptySpaceItem36.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem36.Text = " "
        Me.EmptySpaceItem36.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem36.TextVisible = True
        '
        'EmptySpaceItem37
        '
        Me.EmptySpaceItem37.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem37.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem37.CustomizationFormText = " "
        Me.EmptySpaceItem37.Location = New System.Drawing.Point(654, 168)
        Me.EmptySpaceItem37.MaxSize = New System.Drawing.Size(224, 28)
        Me.EmptySpaceItem37.MinSize = New System.Drawing.Size(224, 28)
        Me.EmptySpaceItem37.Name = "EmptySpaceItem37"
        Me.EmptySpaceItem37.Size = New System.Drawing.Size(224, 28)
        Me.EmptySpaceItem37.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem37.Text = " "
        Me.EmptySpaceItem37.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem37.TextVisible = True
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.sale_miss_vat
        Me.LayoutControlItem17.CustomizationFormText = "LayoutControlItem17"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(654, 196)
        Me.LayoutControlItem17.MaxSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem17.MinSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem17.Text = "LayoutControlItem17"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextToControlDistance = 0
        Me.LayoutControlItem17.TextVisible = False
        '
        'EmptySpaceItem38
        '
        Me.EmptySpaceItem38.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem38.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem38.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem38.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem38.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem38.CustomizationFormText = "일     반      매      입"
        Me.EmptySpaceItem38.Location = New System.Drawing.Point(145, 278)
        Me.EmptySpaceItem38.MaxSize = New System.Drawing.Size(168, 26)
        Me.EmptySpaceItem38.MinSize = New System.Drawing.Size(168, 26)
        Me.EmptySpaceItem38.Name = "EmptySpaceItem38"
        Me.EmptySpaceItem38.Size = New System.Drawing.Size(168, 26)
        Me.EmptySpaceItem38.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem38.Text = "일     반      매      입"
        Me.EmptySpaceItem38.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem38.TextVisible = True
        '
        'EmptySpaceItem39
        '
        Me.EmptySpaceItem39.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem39.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem39.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem39.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem39.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem39.CustomizationFormText = "고  정   자  산  매  입"
        Me.EmptySpaceItem39.Location = New System.Drawing.Point(145, 304)
        Me.EmptySpaceItem39.MaxSize = New System.Drawing.Size(168, 26)
        Me.EmptySpaceItem39.MinSize = New System.Drawing.Size(168, 26)
        Me.EmptySpaceItem39.Name = "EmptySpaceItem39"
        Me.EmptySpaceItem39.Size = New System.Drawing.Size(168, 26)
        Me.EmptySpaceItem39.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem39.Text = "고  정   자  산  매  입"
        Me.EmptySpaceItem39.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem39.TextVisible = True
        '
        'EmptySpaceItem40
        '
        Me.EmptySpaceItem40.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem40.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem40.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem40.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem40.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem40.CustomizationFormText = "EmptySpaceItem40"
        Me.EmptySpaceItem40.Location = New System.Drawing.Point(585, 330)
        Me.EmptySpaceItem40.MaxSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem40.MinSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem40.Name = "EmptySpaceItem40"
        Me.EmptySpaceItem40.Size = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem40.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem40.Text = " "
        Me.EmptySpaceItem40.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem40.TextVisible = True
        '
        'EmptySpaceItem41
        '
        Me.EmptySpaceItem41.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem41.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem41.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem41.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem41.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem41.CustomizationFormText = "매   입  자  발  행  세  금  계  산  서"
        Me.EmptySpaceItem41.Location = New System.Drawing.Point(28, 356)
        Me.EmptySpaceItem41.MaxSize = New System.Drawing.Size(285, 26)
        Me.EmptySpaceItem41.MinSize = New System.Drawing.Size(285, 26)
        Me.EmptySpaceItem41.Name = "EmptySpaceItem41"
        Me.EmptySpaceItem41.Size = New System.Drawing.Size(285, 26)
        Me.EmptySpaceItem41.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem41.Text = "매   입  자  발  행  세  금  계  산  서"
        Me.EmptySpaceItem41.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem41.TextVisible = True
        '
        'EmptySpaceItem43
        '
        Me.EmptySpaceItem43.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem43.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem43.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem43.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem43.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem43.CustomizationFormText = "합    계   ( ⑩ + ⑪ + ⑫ + ⑬ + ⑭ )"
        Me.EmptySpaceItem43.Location = New System.Drawing.Point(28, 408)
        Me.EmptySpaceItem43.MaxSize = New System.Drawing.Size(285, 26)
        Me.EmptySpaceItem43.MinSize = New System.Drawing.Size(285, 26)
        Me.EmptySpaceItem43.Name = "EmptySpaceItem43"
        Me.EmptySpaceItem43.Size = New System.Drawing.Size(285, 26)
        Me.EmptySpaceItem43.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem43.Text = "합    계   ( ⑩ + ⑪ + ⑫ + ⑬ + ⑭ )"
        Me.EmptySpaceItem43.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem43.TextVisible = True
        '
        'EmptySpaceItem45
        '
        Me.EmptySpaceItem45.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem45.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem45.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem45.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem45.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem45.CustomizationFormText = "차      감       계    (      ⑮  -  ?      )"
        Me.EmptySpaceItem45.Location = New System.Drawing.Point(28, 460)
        Me.EmptySpaceItem45.MaxSize = New System.Drawing.Size(285, 26)
        Me.EmptySpaceItem45.MinSize = New System.Drawing.Size(285, 26)
        Me.EmptySpaceItem45.Name = "EmptySpaceItem45"
        Me.EmptySpaceItem45.Size = New System.Drawing.Size(285, 26)
        Me.EmptySpaceItem45.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem45.Text = "차      감       계    (      ⑮  -  ?      )"
        Me.EmptySpaceItem45.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem45.TextVisible = True
        '
        'EmptySpaceItem46
        '
        Me.EmptySpaceItem46.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem46.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmptySpaceItem46.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem46.AppearanceItemCaption.Options.UseFont = True
        Me.EmptySpaceItem46.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem46.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem46.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem46.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.EmptySpaceItem46.CustomizationFormText = "매입세액"
        Me.EmptySpaceItem46.Location = New System.Drawing.Point(0, 278)
        Me.EmptySpaceItem46.MaxSize = New System.Drawing.Size(28, 208)
        Me.EmptySpaceItem46.MinSize = New System.Drawing.Size(28, 208)
        Me.EmptySpaceItem46.Name = "EmptySpaceItem46"
        Me.EmptySpaceItem46.Size = New System.Drawing.Size(28, 208)
        Me.EmptySpaceItem46.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem46.Text = "매입세액"
        Me.EmptySpaceItem46.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem46.TextVisible = True
        '
        'EmptySpaceItem48
        '
        Me.EmptySpaceItem48.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem48.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem48.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem48.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem48.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem48.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.EmptySpaceItem48.CustomizationFormText = " 세금계산서        수   취   분"
        Me.EmptySpaceItem48.Location = New System.Drawing.Point(28, 278)
        Me.EmptySpaceItem48.MaxSize = New System.Drawing.Size(117, 52)
        Me.EmptySpaceItem48.MinSize = New System.Drawing.Size(117, 52)
        Me.EmptySpaceItem48.Name = "EmptySpaceItem48"
        Me.EmptySpaceItem48.Size = New System.Drawing.Size(117, 52)
        Me.EmptySpaceItem48.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem48.Text = " 세금계산서          수   취   분"
        Me.EmptySpaceItem48.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem48.TextVisible = True
        '
        'EmptySpaceItem49
        '
        Me.EmptySpaceItem49.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem49.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem49.CustomizationFormText = "EmptySpaceItem49"
        Me.EmptySpaceItem49.Location = New System.Drawing.Point(585, 278)
        Me.EmptySpaceItem49.MaxSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem49.MinSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem49.Name = "EmptySpaceItem49"
        Me.EmptySpaceItem49.Size = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem49.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem49.Text = " "
        Me.EmptySpaceItem49.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem49.TextVisible = True
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem5.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem5.CustomizationFormText = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(585, 304)
        Me.EmptySpaceItem5.MaxSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem5.MinSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem5.Text = " "
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem5.TextVisible = True
        '
        'EmptySpaceItem50
        '
        Me.EmptySpaceItem50.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem50.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem50.CustomizationFormText = "EmptySpaceItem50"
        Me.EmptySpaceItem50.Location = New System.Drawing.Point(585, 356)
        Me.EmptySpaceItem50.MaxSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem50.MinSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem50.Name = "EmptySpaceItem50"
        Me.EmptySpaceItem50.Size = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem50.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem50.Text = " "
        Me.EmptySpaceItem50.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem50.TextVisible = True
        '
        'EmptySpaceItem51
        '
        Me.EmptySpaceItem51.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem51.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem51.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem51.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem51.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem51.CustomizationFormText = "⑭"
        Me.EmptySpaceItem51.Location = New System.Drawing.Point(313, 382)
        Me.EmptySpaceItem51.MaxSize = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem51.MinSize = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem51.Name = "EmptySpaceItem51"
        Me.EmptySpaceItem51.Size = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem51.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem51.Text = "⑭"
        Me.EmptySpaceItem51.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem51.TextVisible = True
        '
        'EmptySpaceItem52
        '
        Me.EmptySpaceItem52.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem52.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem52.CustomizationFormText = "EmptySpaceItem52"
        Me.EmptySpaceItem52.Location = New System.Drawing.Point(585, 408)
        Me.EmptySpaceItem52.MaxSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem52.MinSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem52.Name = "EmptySpaceItem52"
        Me.EmptySpaceItem52.Size = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem52.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem52.Text = " "
        Me.EmptySpaceItem52.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem52.TextVisible = True
        '
        'EmptySpaceItem47
        '
        Me.EmptySpaceItem47.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem47.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem47.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem47.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem47.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem47.CustomizationFormText = "EmptySpaceItem47"
        Me.EmptySpaceItem47.Location = New System.Drawing.Point(585, 460)
        Me.EmptySpaceItem47.MaxSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem47.MinSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem47.Name = "EmptySpaceItem47"
        Me.EmptySpaceItem47.Size = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem47.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem47.Text = "㉯"
        Me.EmptySpaceItem47.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem47.TextVisible = True
        '
        'EmptySpaceItem42
        '
        Me.EmptySpaceItem42.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem42.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem42.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem42.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem42.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem42.CustomizationFormText = "EmptySpaceItem42"
        Me.EmptySpaceItem42.Location = New System.Drawing.Point(585, 382)
        Me.EmptySpaceItem42.MaxSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem42.MinSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem42.Name = "EmptySpaceItem42"
        Me.EmptySpaceItem42.Size = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem42.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem42.Text = " "
        Me.EmptySpaceItem42.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem42.TextVisible = True
        '
        'EmptySpaceItem53
        '
        Me.EmptySpaceItem53.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem53.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem53.CustomizationFormText = "EmptySpaceItem53"
        Me.EmptySpaceItem53.Location = New System.Drawing.Point(585, 434)
        Me.EmptySpaceItem53.MaxSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem53.MinSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem53.Name = "EmptySpaceItem53"
        Me.EmptySpaceItem53.Size = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem53.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem53.Text = " "
        Me.EmptySpaceItem53.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem53.TextVisible = True
        '
        'EmptySpaceItem54
        '
        Me.EmptySpaceItem54.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem54.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem54.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem54.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem54.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem54.CustomizationFormText = "⑩"
        Me.EmptySpaceItem54.Location = New System.Drawing.Point(313, 278)
        Me.EmptySpaceItem54.MaxSize = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem54.MinSize = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem54.Name = "EmptySpaceItem54"
        Me.EmptySpaceItem54.Size = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem54.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem54.Text = "⑩"
        Me.EmptySpaceItem54.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem54.TextVisible = True
        '
        'EmptySpaceItem55
        '
        Me.EmptySpaceItem55.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem55.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem55.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem55.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem55.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem55.CustomizationFormText = "⑪"
        Me.EmptySpaceItem55.Location = New System.Drawing.Point(313, 304)
        Me.EmptySpaceItem55.MaxSize = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem55.MinSize = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem55.Name = "EmptySpaceItem55"
        Me.EmptySpaceItem55.Size = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem55.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem55.Text = "⑪"
        Me.EmptySpaceItem55.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem55.TextVisible = True
        '
        'EmptySpaceItem57
        '
        Me.EmptySpaceItem57.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem57.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem57.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem57.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem57.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem57.CustomizationFormText = "⑫"
        Me.EmptySpaceItem57.Location = New System.Drawing.Point(313, 330)
        Me.EmptySpaceItem57.MaxSize = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem57.MinSize = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem57.Name = "EmptySpaceItem57"
        Me.EmptySpaceItem57.Size = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem57.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem57.Text = "⑫"
        Me.EmptySpaceItem57.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem57.TextVisible = True
        '
        'EmptySpaceItem58
        '
        Me.EmptySpaceItem58.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem58.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem58.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem58.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem58.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem58.CustomizationFormText = "⑮"
        Me.EmptySpaceItem58.Location = New System.Drawing.Point(313, 408)
        Me.EmptySpaceItem58.MaxSize = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem58.MinSize = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem58.Name = "EmptySpaceItem58"
        Me.EmptySpaceItem58.Size = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem58.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem58.Text = "⑮"
        Me.EmptySpaceItem58.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem58.TextVisible = True
        '
        'EmptySpaceItem59
        '
        Me.EmptySpaceItem59.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem59.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem59.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem59.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem59.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem59.CustomizationFormText = "17"
        Me.EmptySpaceItem59.Location = New System.Drawing.Point(313, 460)
        Me.EmptySpaceItem59.MaxSize = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem59.MinSize = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem59.Name = "EmptySpaceItem59"
        Me.EmptySpaceItem59.Size = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem59.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem59.Text = "17"
        Me.EmptySpaceItem59.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem59.TextVisible = True
        '
        'EmptySpaceItem60
        '
        Me.EmptySpaceItem60.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem60.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem60.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem60.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem60.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem60.CustomizationFormText = "⑬"
        Me.EmptySpaceItem60.Location = New System.Drawing.Point(313, 356)
        Me.EmptySpaceItem60.MaxSize = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem60.MinSize = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem60.Name = "EmptySpaceItem60"
        Me.EmptySpaceItem60.Size = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem60.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem60.Text = "⑬"
        Me.EmptySpaceItem60.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem60.TextVisible = True
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.buy_amt
        Me.LayoutControlItem21.CustomizationFormText = "LayoutControlItem21"
        Me.LayoutControlItem21.Location = New System.Drawing.Point(349, 278)
        Me.LayoutControlItem21.MaxSize = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem21.MinSize = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem21.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem21.Text = "LayoutControlItem21"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem21.TextToControlDistance = 0
        Me.LayoutControlItem21.TextVisible = False
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.ast_amt
        Me.LayoutControlItem22.CustomizationFormText = "LayoutControlItem22"
        Me.LayoutControlItem22.Location = New System.Drawing.Point(349, 304)
        Me.LayoutControlItem22.MaxSize = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem22.MinSize = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem22.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem22.Text = "LayoutControlItem22"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem22.TextToControlDistance = 0
        Me.LayoutControlItem22.TextVisible = False
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.buy_miss_amt
        Me.LayoutControlItem23.CustomizationFormText = "LayoutControlItem23"
        Me.LayoutControlItem23.Location = New System.Drawing.Point(349, 330)
        Me.LayoutControlItem23.MaxSize = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem23.MinSize = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem23.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem23.Text = "LayoutControlItem23"
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem23.TextToControlDistance = 0
        Me.LayoutControlItem23.TextVisible = False
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.buy_iss_amt
        Me.LayoutControlItem24.CustomizationFormText = "LayoutControlItem24"
        Me.LayoutControlItem24.Location = New System.Drawing.Point(349, 356)
        Me.LayoutControlItem24.MaxSize = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem24.MinSize = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem24.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem24.Text = "LayoutControlItem24"
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem24.TextToControlDistance = 0
        Me.LayoutControlItem24.TextVisible = False
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.buy_etc_amt
        Me.LayoutControlItem25.CustomizationFormText = "LayoutControlItem25"
        Me.LayoutControlItem25.Location = New System.Drawing.Point(349, 382)
        Me.LayoutControlItem25.MaxSize = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem25.MinSize = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem25.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem25.Text = "LayoutControlItem25"
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem25.TextToControlDistance = 0
        Me.LayoutControlItem25.TextVisible = False
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.buy_tot_amt
        Me.LayoutControlItem26.CustomizationFormText = "LayoutControlItem26"
        Me.LayoutControlItem26.Location = New System.Drawing.Point(349, 408)
        Me.LayoutControlItem26.MaxSize = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem26.MinSize = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem26.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem26.Text = "LayoutControlItem26"
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem26.TextToControlDistance = 0
        Me.LayoutControlItem26.TextVisible = False
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.Control = Me.no_dedu_amt
        Me.LayoutControlItem27.CustomizationFormText = "LayoutControlItem27"
        Me.LayoutControlItem27.Location = New System.Drawing.Point(349, 434)
        Me.LayoutControlItem27.MaxSize = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem27.MinSize = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem27.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem27.Text = "LayoutControlItem27"
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem27.TextToControlDistance = 0
        Me.LayoutControlItem27.TextVisible = False
        '
        'LayoutControlItem28
        '
        Me.LayoutControlItem28.Control = Me.buy_chakam_amt
        Me.LayoutControlItem28.CustomizationFormText = "LayoutControlItem28"
        Me.LayoutControlItem28.Location = New System.Drawing.Point(349, 460)
        Me.LayoutControlItem28.MaxSize = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem28.MinSize = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem28.Name = "LayoutControlItem28"
        Me.LayoutControlItem28.Size = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem28.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem28.Text = "LayoutControlItem28"
        Me.LayoutControlItem28.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem28.TextToControlDistance = 0
        Me.LayoutControlItem28.TextVisible = False
        '
        'LayoutControlItem29
        '
        Me.LayoutControlItem29.Control = Me.buy_vat
        Me.LayoutControlItem29.CustomizationFormText = "LayoutControlItem29"
        Me.LayoutControlItem29.Location = New System.Drawing.Point(654, 278)
        Me.LayoutControlItem29.MaxSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem29.MinSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem29.Name = "LayoutControlItem29"
        Me.LayoutControlItem29.Size = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem29.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem29.Text = "LayoutControlItem29"
        Me.LayoutControlItem29.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem29.TextToControlDistance = 0
        Me.LayoutControlItem29.TextVisible = False
        '
        'LayoutControlItem30
        '
        Me.LayoutControlItem30.Control = Me.ast_vat
        Me.LayoutControlItem30.CustomizationFormText = "LayoutControlItem30"
        Me.LayoutControlItem30.Location = New System.Drawing.Point(654, 304)
        Me.LayoutControlItem30.MaxSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem30.MinSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem30.Name = "LayoutControlItem30"
        Me.LayoutControlItem30.Size = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem30.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem30.Text = "LayoutControlItem30"
        Me.LayoutControlItem30.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem30.TextToControlDistance = 0
        Me.LayoutControlItem30.TextVisible = False
        '
        'LayoutControlItem31
        '
        Me.LayoutControlItem31.Control = Me.buy_miss_vat
        Me.LayoutControlItem31.CustomizationFormText = "LayoutControlItem31"
        Me.LayoutControlItem31.Location = New System.Drawing.Point(654, 330)
        Me.LayoutControlItem31.MaxSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem31.MinSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem31.Name = "LayoutControlItem31"
        Me.LayoutControlItem31.Size = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem31.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem31.Text = "LayoutControlItem31"
        Me.LayoutControlItem31.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem31.TextToControlDistance = 0
        Me.LayoutControlItem31.TextVisible = False
        '
        'LayoutControlItem32
        '
        Me.LayoutControlItem32.Control = Me.buy_iss_vat
        Me.LayoutControlItem32.CustomizationFormText = "LayoutControlItem32"
        Me.LayoutControlItem32.Location = New System.Drawing.Point(654, 356)
        Me.LayoutControlItem32.MaxSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem32.MinSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem32.Name = "LayoutControlItem32"
        Me.LayoutControlItem32.Size = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem32.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem32.Text = "LayoutControlItem32"
        Me.LayoutControlItem32.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem32.TextToControlDistance = 0
        Me.LayoutControlItem32.TextVisible = False
        '
        'LayoutControlItem33
        '
        Me.LayoutControlItem33.Control = Me.buy_etc_vat
        Me.LayoutControlItem33.CustomizationFormText = "LayoutControlItem33"
        Me.LayoutControlItem33.Location = New System.Drawing.Point(654, 382)
        Me.LayoutControlItem33.MaxSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem33.MinSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem33.Name = "LayoutControlItem33"
        Me.LayoutControlItem33.Size = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem33.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem33.Text = "LayoutControlItem33"
        Me.LayoutControlItem33.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem33.TextToControlDistance = 0
        Me.LayoutControlItem33.TextVisible = False
        '
        'LayoutControlItem34
        '
        Me.LayoutControlItem34.Control = Me.buy_tot_vat
        Me.LayoutControlItem34.CustomizationFormText = "LayoutControlItem34"
        Me.LayoutControlItem34.Location = New System.Drawing.Point(654, 408)
        Me.LayoutControlItem34.MaxSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem34.MinSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem34.Name = "LayoutControlItem34"
        Me.LayoutControlItem34.Size = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem34.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem34.Text = "LayoutControlItem34"
        Me.LayoutControlItem34.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem34.TextToControlDistance = 0
        Me.LayoutControlItem34.TextVisible = False
        '
        'LayoutControlItem35
        '
        Me.LayoutControlItem35.Control = Me.no_dedu_vat
        Me.LayoutControlItem35.CustomizationFormText = "LayoutControlItem35"
        Me.LayoutControlItem35.Location = New System.Drawing.Point(654, 434)
        Me.LayoutControlItem35.MaxSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem35.MinSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem35.Name = "LayoutControlItem35"
        Me.LayoutControlItem35.Size = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem35.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem35.Text = "LayoutControlItem35"
        Me.LayoutControlItem35.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem35.TextToControlDistance = 0
        Me.LayoutControlItem35.TextVisible = False
        '
        'LayoutControlItem36
        '
        Me.LayoutControlItem36.Control = Me.buy_chakam_vat
        Me.LayoutControlItem36.CustomizationFormText = "LayoutControlItem36"
        Me.LayoutControlItem36.Location = New System.Drawing.Point(654, 460)
        Me.LayoutControlItem36.MaxSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem36.MinSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem36.Name = "LayoutControlItem36"
        Me.LayoutControlItem36.Size = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem36.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem36.Text = "LayoutControlItem36"
        Me.LayoutControlItem36.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem36.TextToControlDistance = 0
        Me.LayoutControlItem36.TextVisible = False
        '
        'EmptySpaceItem61
        '
        Me.EmptySpaceItem61.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem61.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem61.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem61.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem61.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem61.CustomizationFormText = "EmptySpaceItem61"
        Me.EmptySpaceItem61.Location = New System.Drawing.Point(0, 486)
        Me.EmptySpaceItem61.MaxSize = New System.Drawing.Size(585, 26)
        Me.EmptySpaceItem61.MinSize = New System.Drawing.Size(585, 26)
        Me.EmptySpaceItem61.Name = "EmptySpaceItem61"
        Me.EmptySpaceItem61.Size = New System.Drawing.Size(585, 26)
        Me.EmptySpaceItem61.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem61.Text = "납 부 ( 환 급 ) 세 액     (매 출 세 액 ㉮ - 매 입 세 액 ㉯  )"
        Me.EmptySpaceItem61.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem61.TextVisible = True
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.CustomizationFormText = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(878, 0)
        Me.EmptySpaceItem6.MaxSize = New System.Drawing.Size(251, 1284)
        Me.EmptySpaceItem6.MinSize = New System.Drawing.Size(251, 1284)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(251, 1284)
        Me.EmptySpaceItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem6.Text = "EmptySpaceItem6"
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem64
        '
        Me.EmptySpaceItem64.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem64.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem64.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem64.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem64.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem64.CustomizationFormText = "㉰"
        Me.EmptySpaceItem64.Location = New System.Drawing.Point(585, 486)
        Me.EmptySpaceItem64.MaxSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem64.MinSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem64.Name = "EmptySpaceItem64"
        Me.EmptySpaceItem64.Size = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem64.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem64.Text = "㉰"
        Me.EmptySpaceItem64.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem64.TextVisible = True
        '
        'LayoutControlItem37
        '
        Me.LayoutControlItem37.Control = Me.give_amt
        Me.LayoutControlItem37.CustomizationFormText = "LayoutControlItem37"
        Me.LayoutControlItem37.Location = New System.Drawing.Point(654, 486)
        Me.LayoutControlItem37.Name = "LayoutControlItem37"
        Me.LayoutControlItem37.Size = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem37.Text = "LayoutControlItem37"
        Me.LayoutControlItem37.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem37.TextToControlDistance = 0
        Me.LayoutControlItem37.TextVisible = False
        '
        'EmptySpaceItem65
        '
        Me.EmptySpaceItem65.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem65.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem65.CustomizationFormText = " "
        Me.EmptySpaceItem65.Location = New System.Drawing.Point(585, 512)
        Me.EmptySpaceItem65.MaxSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem65.MinSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem65.Name = "EmptySpaceItem65"
        Me.EmptySpaceItem65.Size = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem65.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem65.Text = " "
        Me.EmptySpaceItem65.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem65.TextVisible = True
        '
        'EmptySpaceItem66
        '
        Me.EmptySpaceItem66.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem66.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem66.CustomizationFormText = " "
        Me.EmptySpaceItem66.Location = New System.Drawing.Point(585, 538)
        Me.EmptySpaceItem66.MaxSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem66.MinSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem66.Name = "EmptySpaceItem66"
        Me.EmptySpaceItem66.Size = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem66.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem66.Text = " "
        Me.EmptySpaceItem66.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem66.TextVisible = True
        '
        'EmptySpaceItem67
        '
        Me.EmptySpaceItem67.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem67.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem67.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem67.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem67.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem67.CustomizationFormText = "㉱"
        Me.EmptySpaceItem67.Location = New System.Drawing.Point(585, 564)
        Me.EmptySpaceItem67.MaxSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem67.MinSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem67.Name = "EmptySpaceItem67"
        Me.EmptySpaceItem67.Size = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem67.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem67.Text = "㉱"
        Me.EmptySpaceItem67.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem67.TextVisible = True
        '
        'EmptySpaceItem68
        '
        Me.EmptySpaceItem68.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem68.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem68.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem68.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem68.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem68.CustomizationFormText = "㉲"
        Me.EmptySpaceItem68.Location = New System.Drawing.Point(585, 590)
        Me.EmptySpaceItem68.MaxSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem68.MinSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem68.Name = "EmptySpaceItem68"
        Me.EmptySpaceItem68.Size = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem68.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem68.Text = "㉲"
        Me.EmptySpaceItem68.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem68.TextVisible = True
        '
        'EmptySpaceItem69
        '
        Me.EmptySpaceItem69.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem69.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem69.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem69.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem69.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem69.CustomizationFormText = "㉳"
        Me.EmptySpaceItem69.Location = New System.Drawing.Point(585, 616)
        Me.EmptySpaceItem69.MaxSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem69.MinSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem69.Name = "EmptySpaceItem69"
        Me.EmptySpaceItem69.Size = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem69.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem69.Text = "㉳"
        Me.EmptySpaceItem69.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem69.TextVisible = True
        '
        'EmptySpaceItem70
        '
        Me.EmptySpaceItem70.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem70.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem70.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem70.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem70.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem70.CustomizationFormText = "㉴"
        Me.EmptySpaceItem70.Location = New System.Drawing.Point(585, 642)
        Me.EmptySpaceItem70.MaxSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem70.MinSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem70.Name = "EmptySpaceItem70"
        Me.EmptySpaceItem70.Size = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem70.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem70.Text = "㉴"
        Me.EmptySpaceItem70.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem70.TextVisible = True
        '
        'EmptySpaceItem71
        '
        Me.EmptySpaceItem71.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem71.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem71.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem71.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem71.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem71.CustomizationFormText = "총괄납부사업자  납부할 세액(환급받을 세액)"
        Me.EmptySpaceItem71.Location = New System.Drawing.Point(0, 720)
        Me.EmptySpaceItem71.MaxSize = New System.Drawing.Size(654, 26)
        Me.EmptySpaceItem71.MinSize = New System.Drawing.Size(654, 26)
        Me.EmptySpaceItem71.Name = "EmptySpaceItem71"
        Me.EmptySpaceItem71.Size = New System.Drawing.Size(654, 26)
        Me.EmptySpaceItem71.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem71.Text = "총괄납부사업자  납부할 세액(환급받을 세액)"
        Me.EmptySpaceItem71.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem71.TextVisible = True
        '
        'EmptySpaceItem72
        '
        Me.EmptySpaceItem72.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem72.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem72.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem72.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem72.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem72.CustomizationFormText = "㉵"
        Me.EmptySpaceItem72.Location = New System.Drawing.Point(585, 668)
        Me.EmptySpaceItem72.MaxSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem72.MinSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem72.Name = "EmptySpaceItem72"
        Me.EmptySpaceItem72.Size = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem72.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem72.Text = "㉵"
        Me.EmptySpaceItem72.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem72.TextVisible = True
        '
        'EmptySpaceItem73
        '
        Me.EmptySpaceItem73.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem73.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem73.CustomizationFormText = "EmptySpaceItem73"
        Me.EmptySpaceItem73.Location = New System.Drawing.Point(585, 694)
        Me.EmptySpaceItem73.MaxSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem73.MinSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem73.Name = "EmptySpaceItem73"
        Me.EmptySpaceItem73.Size = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem73.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem73.Text = " "
        Me.EmptySpaceItem73.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem73.TextVisible = True
        '
        'EmptySpaceItem74
        '
        Me.EmptySpaceItem74.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem74.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem74.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem74.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem74.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem74.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.EmptySpaceItem74.CustomizationFormText = " 경감    .     공제 세액"
        Me.EmptySpaceItem74.Location = New System.Drawing.Point(0, 512)
        Me.EmptySpaceItem74.MaxSize = New System.Drawing.Size(104, 78)
        Me.EmptySpaceItem74.MinSize = New System.Drawing.Size(104, 78)
        Me.EmptySpaceItem74.Name = "EmptySpaceItem74"
        Me.EmptySpaceItem74.Size = New System.Drawing.Size(104, 78)
        Me.EmptySpaceItem74.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem74.Text = " 경감    .           공제 세액  "
        Me.EmptySpaceItem74.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem74.TextVisible = True
        '
        'EmptySpaceItem75
        '
        Me.EmptySpaceItem75.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem75.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem75.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem75.CustomizationFormText = "18"
        Me.EmptySpaceItem75.Location = New System.Drawing.Point(313, 512)
        Me.EmptySpaceItem75.MaxSize = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem75.MinSize = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem75.Name = "EmptySpaceItem75"
        Me.EmptySpaceItem75.Size = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem75.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem75.Text = "18"
        Me.EmptySpaceItem75.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem75.TextVisible = True
        '
        'EmptySpaceItem76
        '
        Me.EmptySpaceItem76.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem76.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem76.CustomizationFormText = " "
        Me.EmptySpaceItem76.Location = New System.Drawing.Point(349, 512)
        Me.EmptySpaceItem76.MaxSize = New System.Drawing.Size(236, 26)
        Me.EmptySpaceItem76.MinSize = New System.Drawing.Size(236, 26)
        Me.EmptySpaceItem76.Name = "EmptySpaceItem76"
        Me.EmptySpaceItem76.Size = New System.Drawing.Size(236, 26)
        Me.EmptySpaceItem76.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem76.Text = " "
        Me.EmptySpaceItem76.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem76.TextVisible = True
        '
        'LayoutControlItem39
        '
        Me.LayoutControlItem39.Control = Me.etc_vat
        Me.LayoutControlItem39.CustomizationFormText = "LayoutControlItem39"
        Me.LayoutControlItem39.Location = New System.Drawing.Point(654, 512)
        Me.LayoutControlItem39.MaxSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem39.MinSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem39.Name = "LayoutControlItem39"
        Me.LayoutControlItem39.Size = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem39.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem39.Text = "LayoutControlItem39"
        Me.LayoutControlItem39.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem39.TextToControlDistance = 0
        Me.LayoutControlItem39.TextVisible = False
        '
        'EmptySpaceItem77
        '
        Me.EmptySpaceItem77.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem77.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem77.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem77.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem77.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem77.CustomizationFormText = "신용카드매출전표등발행공제등"
        Me.EmptySpaceItem77.Location = New System.Drawing.Point(104, 538)
        Me.EmptySpaceItem77.MaxSize = New System.Drawing.Size(209, 26)
        Me.EmptySpaceItem77.MinSize = New System.Drawing.Size(209, 26)
        Me.EmptySpaceItem77.Name = "EmptySpaceItem77"
        Me.EmptySpaceItem77.Size = New System.Drawing.Size(209, 26)
        Me.EmptySpaceItem77.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem77.Text = "신용카드매출전표등발행공제등"
        Me.EmptySpaceItem77.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem77.TextVisible = True
        '
        'EmptySpaceItem78
        '
        Me.EmptySpaceItem78.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem78.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem78.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem78.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem78.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem78.CustomizationFormText = "합                                    계"
        Me.EmptySpaceItem78.Location = New System.Drawing.Point(104, 564)
        Me.EmptySpaceItem78.MaxSize = New System.Drawing.Size(209, 26)
        Me.EmptySpaceItem78.MinSize = New System.Drawing.Size(209, 26)
        Me.EmptySpaceItem78.Name = "EmptySpaceItem78"
        Me.EmptySpaceItem78.Size = New System.Drawing.Size(209, 26)
        Me.EmptySpaceItem78.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem78.Text = "합                                    계"
        Me.EmptySpaceItem78.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem78.TextVisible = True
        '
        'EmptySpaceItem79
        '
        Me.EmptySpaceItem79.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem79.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem79.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem79.CustomizationFormText = "19"
        Me.EmptySpaceItem79.Location = New System.Drawing.Point(313, 538)
        Me.EmptySpaceItem79.MaxSize = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem79.MinSize = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem79.Name = "EmptySpaceItem79"
        Me.EmptySpaceItem79.Size = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem79.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem79.Text = "19"
        Me.EmptySpaceItem79.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem79.TextVisible = True
        '
        'EmptySpaceItem80
        '
        Me.EmptySpaceItem80.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem80.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem80.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem80.CustomizationFormText = "20"
        Me.EmptySpaceItem80.Location = New System.Drawing.Point(313, 564)
        Me.EmptySpaceItem80.MaxSize = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem80.MinSize = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem80.Name = "EmptySpaceItem80"
        Me.EmptySpaceItem80.Size = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem80.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem80.Text = "20"
        Me.EmptySpaceItem80.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem80.TextVisible = True
        '
        'LayoutControlItem40
        '
        Me.LayoutControlItem40.Control = Me.card_amt
        Me.LayoutControlItem40.CustomizationFormText = "LayoutControlItem40"
        Me.LayoutControlItem40.Location = New System.Drawing.Point(349, 538)
        Me.LayoutControlItem40.MaxSize = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem40.MinSize = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem40.Name = "LayoutControlItem40"
        Me.LayoutControlItem40.Size = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem40.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem40.Text = "LayoutControlItem40"
        Me.LayoutControlItem40.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem40.TextToControlDistance = 0
        Me.LayoutControlItem40.TextVisible = False
        '
        'LayoutControlItem41
        '
        Me.LayoutControlItem41.Control = Me.card_vat
        Me.LayoutControlItem41.CustomizationFormText = "LayoutControlItem41"
        Me.LayoutControlItem41.Location = New System.Drawing.Point(654, 538)
        Me.LayoutControlItem41.MaxSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem41.MinSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem41.Name = "LayoutControlItem41"
        Me.LayoutControlItem41.Size = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem41.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem41.Text = "LayoutControlItem41"
        Me.LayoutControlItem41.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem41.TextToControlDistance = 0
        Me.LayoutControlItem41.TextVisible = False
        '
        'EmptySpaceItem81
        '
        Me.EmptySpaceItem81.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem81.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem81.CustomizationFormText = " "
        Me.EmptySpaceItem81.Location = New System.Drawing.Point(349, 564)
        Me.EmptySpaceItem81.MaxSize = New System.Drawing.Size(236, 26)
        Me.EmptySpaceItem81.MinSize = New System.Drawing.Size(236, 26)
        Me.EmptySpaceItem81.Name = "EmptySpaceItem81"
        Me.EmptySpaceItem81.Size = New System.Drawing.Size(236, 26)
        Me.EmptySpaceItem81.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem81.Text = " "
        Me.EmptySpaceItem81.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem81.TextVisible = True
        '
        'LayoutControlItem42
        '
        Me.LayoutControlItem42.Control = Me.dedu_vat
        Me.LayoutControlItem42.CustomizationFormText = "LayoutControlItem42"
        Me.LayoutControlItem42.Location = New System.Drawing.Point(654, 564)
        Me.LayoutControlItem42.MaxSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem42.MinSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem42.Name = "LayoutControlItem42"
        Me.LayoutControlItem42.Size = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem42.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem42.Text = "LayoutControlItem42"
        Me.LayoutControlItem42.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem42.TextToControlDistance = 0
        Me.LayoutControlItem42.TextVisible = False
        '
        'EmptySpaceItem82
        '
        Me.EmptySpaceItem82.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem82.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem82.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem82.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem82.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem82.CustomizationFormText = "예   정   신   고   미   환   급   세   액"
        Me.EmptySpaceItem82.Location = New System.Drawing.Point(0, 590)
        Me.EmptySpaceItem82.MaxSize = New System.Drawing.Size(313, 26)
        Me.EmptySpaceItem82.MinSize = New System.Drawing.Size(313, 26)
        Me.EmptySpaceItem82.Name = "EmptySpaceItem82"
        Me.EmptySpaceItem82.Size = New System.Drawing.Size(313, 26)
        Me.EmptySpaceItem82.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem82.Text = "예   정   신   고   미   환   급   세   액"
        Me.EmptySpaceItem82.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem82.TextVisible = True
        '
        'EmptySpaceItem83
        '
        Me.EmptySpaceItem83.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem83.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem83.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem83.CustomizationFormText = "21"
        Me.EmptySpaceItem83.Location = New System.Drawing.Point(313, 590)
        Me.EmptySpaceItem83.MaxSize = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem83.MinSize = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem83.Name = "EmptySpaceItem83"
        Me.EmptySpaceItem83.Size = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem83.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem83.Text = "21"
        Me.EmptySpaceItem83.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem83.TextVisible = True
        '
        'EmptySpaceItem84
        '
        Me.EmptySpaceItem84.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem84.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem84.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem84.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem84.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem84.CustomizationFormText = " "
        Me.EmptySpaceItem84.Location = New System.Drawing.Point(349, 590)
        Me.EmptySpaceItem84.MaxSize = New System.Drawing.Size(236, 26)
        Me.EmptySpaceItem84.MinSize = New System.Drawing.Size(236, 26)
        Me.EmptySpaceItem84.Name = "EmptySpaceItem84"
        Me.EmptySpaceItem84.Size = New System.Drawing.Size(236, 26)
        Me.EmptySpaceItem84.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem84.Text = " "
        Me.EmptySpaceItem84.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem84.TextVisible = True
        '
        'LayoutControlItem43
        '
        Me.LayoutControlItem43.Control = Me.non_repay
        Me.LayoutControlItem43.CustomizationFormText = "LayoutControlItem43"
        Me.LayoutControlItem43.Location = New System.Drawing.Point(654, 590)
        Me.LayoutControlItem43.MaxSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem43.MinSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem43.Name = "LayoutControlItem43"
        Me.LayoutControlItem43.Size = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem43.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem43.Text = "LayoutControlItem43"
        Me.LayoutControlItem43.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem43.TextToControlDistance = 0
        Me.LayoutControlItem43.TextVisible = False
        '
        'EmptySpaceItem85
        '
        Me.EmptySpaceItem85.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem85.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem85.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem85.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem85.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem85.CustomizationFormText = "예       정      고       지       세      액"
        Me.EmptySpaceItem85.Location = New System.Drawing.Point(0, 616)
        Me.EmptySpaceItem85.MaxSize = New System.Drawing.Size(313, 26)
        Me.EmptySpaceItem85.MinSize = New System.Drawing.Size(313, 26)
        Me.EmptySpaceItem85.Name = "EmptySpaceItem85"
        Me.EmptySpaceItem85.Size = New System.Drawing.Size(313, 26)
        Me.EmptySpaceItem85.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem85.Text = "예       정      고       지       세      액"
        Me.EmptySpaceItem85.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem85.TextVisible = True
        '
        'EmptySpaceItem86
        '
        Me.EmptySpaceItem86.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem86.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem86.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem86.CustomizationFormText = "22"
        Me.EmptySpaceItem86.Location = New System.Drawing.Point(313, 616)
        Me.EmptySpaceItem86.MaxSize = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem86.MinSize = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem86.Name = "EmptySpaceItem86"
        Me.EmptySpaceItem86.Size = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem86.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem86.Text = "22"
        Me.EmptySpaceItem86.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem86.TextVisible = True
        '
        'EmptySpaceItem87
        '
        Me.EmptySpaceItem87.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem87.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem87.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem87.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem87.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem87.CustomizationFormText = " "
        Me.EmptySpaceItem87.Location = New System.Drawing.Point(349, 616)
        Me.EmptySpaceItem87.MaxSize = New System.Drawing.Size(236, 26)
        Me.EmptySpaceItem87.MinSize = New System.Drawing.Size(236, 26)
        Me.EmptySpaceItem87.Name = "EmptySpaceItem87"
        Me.EmptySpaceItem87.Size = New System.Drawing.Size(236, 26)
        Me.EmptySpaceItem87.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem87.Text = " "
        Me.EmptySpaceItem87.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem87.TextVisible = True
        '
        'LayoutControlItem44
        '
        Me.LayoutControlItem44.Control = Me.plan_amt
        Me.LayoutControlItem44.CustomizationFormText = "LayoutControlItem44"
        Me.LayoutControlItem44.Location = New System.Drawing.Point(654, 616)
        Me.LayoutControlItem44.MaxSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem44.MinSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem44.Name = "LayoutControlItem44"
        Me.LayoutControlItem44.Size = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem44.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem44.Text = "LayoutControlItem44"
        Me.LayoutControlItem44.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem44.TextToControlDistance = 0
        Me.LayoutControlItem44.TextVisible = False
        '
        'EmptySpaceItem88
        '
        Me.EmptySpaceItem88.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem88.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem88.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem88.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem88.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem88.CustomizationFormText = "금지금  매입자  납부특례  기납부세액"
        Me.EmptySpaceItem88.Location = New System.Drawing.Point(0, 642)
        Me.EmptySpaceItem88.MaxSize = New System.Drawing.Size(313, 26)
        Me.EmptySpaceItem88.MinSize = New System.Drawing.Size(313, 26)
        Me.EmptySpaceItem88.Name = "EmptySpaceItem88"
        Me.EmptySpaceItem88.Size = New System.Drawing.Size(313, 26)
        Me.EmptySpaceItem88.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem88.Text = "금지금  매입자  납부특례  기납부세액"
        Me.EmptySpaceItem88.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem88.TextVisible = True
        '
        'EmptySpaceItem89
        '
        Me.EmptySpaceItem89.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem89.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem89.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem89.CustomizationFormText = "23"
        Me.EmptySpaceItem89.Location = New System.Drawing.Point(313, 642)
        Me.EmptySpaceItem89.MaxSize = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem89.MinSize = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem89.Name = "EmptySpaceItem89"
        Me.EmptySpaceItem89.Size = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem89.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem89.Text = "23"
        Me.EmptySpaceItem89.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem89.TextVisible = True
        '
        'EmptySpaceItem90
        '
        Me.EmptySpaceItem90.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem90.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem90.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem90.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem90.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem90.CustomizationFormText = " "
        Me.EmptySpaceItem90.Location = New System.Drawing.Point(349, 642)
        Me.EmptySpaceItem90.MaxSize = New System.Drawing.Size(236, 26)
        Me.EmptySpaceItem90.MinSize = New System.Drawing.Size(236, 26)
        Me.EmptySpaceItem90.Name = "EmptySpaceItem90"
        Me.EmptySpaceItem90.Size = New System.Drawing.Size(236, 26)
        Me.EmptySpaceItem90.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem90.Text = " "
        Me.EmptySpaceItem90.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem90.TextVisible = True
        '
        'LayoutControlItem45
        '
        Me.LayoutControlItem45.Control = Me.spc_vat
        Me.LayoutControlItem45.CustomizationFormText = "LayoutControlItem45"
        Me.LayoutControlItem45.Location = New System.Drawing.Point(654, 642)
        Me.LayoutControlItem45.MaxSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem45.MinSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem45.Name = "LayoutControlItem45"
        Me.LayoutControlItem45.Size = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem45.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem45.Text = "LayoutControlItem45"
        Me.LayoutControlItem45.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem45.TextToControlDistance = 0
        Me.LayoutControlItem45.TextVisible = False
        '
        'EmptySpaceItem91
        '
        Me.EmptySpaceItem91.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem91.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem91.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem91.CustomizationFormText = "24"
        Me.EmptySpaceItem91.Location = New System.Drawing.Point(313, 668)
        Me.EmptySpaceItem91.MaxSize = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem91.MinSize = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem91.Name = "EmptySpaceItem91"
        Me.EmptySpaceItem91.Size = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem91.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem91.Text = "24"
        Me.EmptySpaceItem91.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem91.TextVisible = True
        '
        'EmptySpaceItem92
        '
        Me.EmptySpaceItem92.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem92.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem92.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem92.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem92.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem92.CustomizationFormText = " "
        Me.EmptySpaceItem92.Location = New System.Drawing.Point(349, 668)
        Me.EmptySpaceItem92.MaxSize = New System.Drawing.Size(236, 26)
        Me.EmptySpaceItem92.MinSize = New System.Drawing.Size(236, 26)
        Me.EmptySpaceItem92.Name = "EmptySpaceItem92"
        Me.EmptySpaceItem92.Size = New System.Drawing.Size(236, 26)
        Me.EmptySpaceItem92.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem92.Text = " "
        Me.EmptySpaceItem92.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem92.TextVisible = True
        '
        'LayoutControlItem47
        '
        Me.LayoutControlItem47.Control = Me.add_vat
        Me.LayoutControlItem47.CustomizationFormText = "LayoutControlItem47"
        Me.LayoutControlItem47.Location = New System.Drawing.Point(654, 668)
        Me.LayoutControlItem47.MaxSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem47.MinSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem47.Name = "LayoutControlItem47"
        Me.LayoutControlItem47.Size = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem47.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem47.Text = "LayoutControlItem47"
        Me.LayoutControlItem47.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem47.TextToControlDistance = 0
        Me.LayoutControlItem47.TextVisible = False
        '
        'EmptySpaceItem93
        '
        Me.EmptySpaceItem93.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem93.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem93.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem93.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem93.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem93.CustomizationFormText = "차가감하여 납부할 세액(환급받을 세액) ㉰-㉱-㉲-㉳-㉴+㉵)"
        Me.EmptySpaceItem93.Location = New System.Drawing.Point(0, 694)
        Me.EmptySpaceItem93.MaxSize = New System.Drawing.Size(585, 26)
        Me.EmptySpaceItem93.MinSize = New System.Drawing.Size(585, 26)
        Me.EmptySpaceItem93.Name = "EmptySpaceItem93"
        Me.EmptySpaceItem93.Size = New System.Drawing.Size(585, 26)
        Me.EmptySpaceItem93.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem93.Text = "차가감하여 납부할 세액(환급받을 세액) ㉰-㉱-㉲-㉳-㉴+㉵)"
        Me.EmptySpaceItem93.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem93.TextVisible = True
        '
        'LayoutControlItem48
        '
        Me.LayoutControlItem48.Control = Me.result_vat
        Me.LayoutControlItem48.CustomizationFormText = "LayoutControlItem48"
        Me.LayoutControlItem48.Location = New System.Drawing.Point(654, 694)
        Me.LayoutControlItem48.MaxSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem48.MinSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem48.Name = "LayoutControlItem48"
        Me.LayoutControlItem48.Size = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem48.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem48.Text = "LayoutControlItem48"
        Me.LayoutControlItem48.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem48.TextToControlDistance = 0
        Me.LayoutControlItem48.TextVisible = False
        '
        'LayoutControlItem49
        '
        Me.LayoutControlItem49.Control = Me.vat
        Me.LayoutControlItem49.CustomizationFormText = "LayoutControlItem49"
        Me.LayoutControlItem49.Location = New System.Drawing.Point(654, 720)
        Me.LayoutControlItem49.MaxSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem49.MinSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem49.Name = "LayoutControlItem49"
        Me.LayoutControlItem49.Size = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem49.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem49.Text = "LayoutControlItem49"
        Me.LayoutControlItem49.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem49.TextToControlDistance = 0
        Me.LayoutControlItem49.TextVisible = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem56, Me.EmptySpaceItem99, Me.EmptySpaceItem95, Me.EmptySpaceItem96, Me.EmptySpaceItem97, Me.EmptySpaceItem98, Me.LayoutControlItem50, Me.LayoutControlItem53, Me.LayoutControlItem54, Me.EmptySpaceItem100, Me.EmptySpaceItem101, Me.LayoutControlItem55, Me.LayoutControlItem56})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 746)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(878, 76)
        Me.LayoutControlGroup3.Text = "LayoutControlGroup3"
        Me.LayoutControlGroup3.TextVisible = False
        '
        'EmptySpaceItem56
        '
        Me.EmptySpaceItem56.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem56.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem56.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem56.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem56.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem56.CustomizationFormText = "계좌번호"
        Me.EmptySpaceItem56.Location = New System.Drawing.Point(612, 0)
        Me.EmptySpaceItem56.MaxSize = New System.Drawing.Size(87, 26)
        Me.EmptySpaceItem56.MinSize = New System.Drawing.Size(87, 26)
        Me.EmptySpaceItem56.Name = "EmptySpaceItem56"
        Me.EmptySpaceItem56.Size = New System.Drawing.Size(87, 26)
        Me.EmptySpaceItem56.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem56.Text = "계좌번호"
        Me.EmptySpaceItem56.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem56.TextVisible = True
        '
        'EmptySpaceItem99
        '
        Me.EmptySpaceItem99.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem99.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem99.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem99.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem99.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem99.CustomizationFormText = "폐업사유"
        Me.EmptySpaceItem99.Location = New System.Drawing.Point(376, 26)
        Me.EmptySpaceItem99.MaxSize = New System.Drawing.Size(65, 26)
        Me.EmptySpaceItem99.MinSize = New System.Drawing.Size(65, 26)
        Me.EmptySpaceItem99.Name = "EmptySpaceItem99"
        Me.EmptySpaceItem99.Size = New System.Drawing.Size(65, 26)
        Me.EmptySpaceItem99.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem99.Text = "폐업사유"
        Me.EmptySpaceItem99.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem99.TextVisible = True
        '
        'EmptySpaceItem95
        '
        Me.EmptySpaceItem95.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem95.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem95.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem95.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem95.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem95.CustomizationFormText = "거래은행"
        Me.EmptySpaceItem95.Location = New System.Drawing.Point(148, 0)
        Me.EmptySpaceItem95.MaxSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem95.MinSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem95.Name = "EmptySpaceItem95"
        Me.EmptySpaceItem95.Size = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem95.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem95.Text = "거래은행"
        Me.EmptySpaceItem95.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem95.TextVisible = True
        '
        'EmptySpaceItem96
        '
        Me.EmptySpaceItem96.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem96.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem96.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem96.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem96.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem96.CustomizationFormText = "②  국세환급금계좌신고"
        Me.EmptySpaceItem96.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem96.MaxSize = New System.Drawing.Size(148, 26)
        Me.EmptySpaceItem96.MinSize = New System.Drawing.Size(148, 26)
        Me.EmptySpaceItem96.Name = "EmptySpaceItem96"
        Me.EmptySpaceItem96.Size = New System.Drawing.Size(148, 26)
        Me.EmptySpaceItem96.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem96.Text = "②  국세환급금계좌신고"
        Me.EmptySpaceItem96.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem96.TextVisible = True
        '
        'EmptySpaceItem97
        '
        Me.EmptySpaceItem97.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem97.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem97.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem97.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem97.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem97.CustomizationFormText = "은행"
        Me.EmptySpaceItem97.Location = New System.Drawing.Point(376, 0)
        Me.EmptySpaceItem97.MaxSize = New System.Drawing.Size(65, 26)
        Me.EmptySpaceItem97.MinSize = New System.Drawing.Size(65, 26)
        Me.EmptySpaceItem97.Name = "EmptySpaceItem97"
        Me.EmptySpaceItem97.Size = New System.Drawing.Size(65, 26)
        Me.EmptySpaceItem97.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem97.Text = "은행"
        Me.EmptySpaceItem97.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem97.TextVisible = True
        '
        'EmptySpaceItem98
        '
        Me.EmptySpaceItem98.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem98.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem98.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem98.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem98.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem98.CustomizationFormText = "지점"
        Me.EmptySpaceItem98.Location = New System.Drawing.Point(561, 0)
        Me.EmptySpaceItem98.MaxSize = New System.Drawing.Size(51, 26)
        Me.EmptySpaceItem98.MinSize = New System.Drawing.Size(51, 26)
        Me.EmptySpaceItem98.Name = "EmptySpaceItem98"
        Me.EmptySpaceItem98.Size = New System.Drawing.Size(51, 26)
        Me.EmptySpaceItem98.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem98.Text = "지점"
        Me.EmptySpaceItem98.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem98.TextVisible = True
        '
        'LayoutControlItem50
        '
        Me.LayoutControlItem50.Control = Me.bank_cd
        Me.LayoutControlItem50.CustomizationFormText = "LayoutControlItem50"
        Me.LayoutControlItem50.Location = New System.Drawing.Point(217, 0)
        Me.LayoutControlItem50.MaxSize = New System.Drawing.Size(159, 26)
        Me.LayoutControlItem50.MinSize = New System.Drawing.Size(159, 26)
        Me.LayoutControlItem50.Name = "LayoutControlItem50"
        Me.LayoutControlItem50.Size = New System.Drawing.Size(159, 26)
        Me.LayoutControlItem50.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem50.Text = "LayoutControlItem50"
        Me.LayoutControlItem50.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem50.TextToControlDistance = 0
        Me.LayoutControlItem50.TextVisible = False
        '
        'LayoutControlItem53
        '
        Me.LayoutControlItem53.Control = Me.bank_loc
        Me.LayoutControlItem53.CustomizationFormText = "LayoutControlItem53"
        Me.LayoutControlItem53.Location = New System.Drawing.Point(441, 0)
        Me.LayoutControlItem53.MaxSize = New System.Drawing.Size(120, 26)
        Me.LayoutControlItem53.MinSize = New System.Drawing.Size(120, 26)
        Me.LayoutControlItem53.Name = "LayoutControlItem53"
        Me.LayoutControlItem53.Size = New System.Drawing.Size(120, 26)
        Me.LayoutControlItem53.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem53.Text = "LayoutControlItem53"
        Me.LayoutControlItem53.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem53.TextToControlDistance = 0
        Me.LayoutControlItem53.TextVisible = False
        '
        'LayoutControlItem54
        '
        Me.LayoutControlItem54.Control = Me.acct_no
        Me.LayoutControlItem54.CustomizationFormText = "LayoutControlItem54"
        Me.LayoutControlItem54.Location = New System.Drawing.Point(699, 0)
        Me.LayoutControlItem54.MaxSize = New System.Drawing.Size(155, 26)
        Me.LayoutControlItem54.MinSize = New System.Drawing.Size(155, 26)
        Me.LayoutControlItem54.Name = "LayoutControlItem54"
        Me.LayoutControlItem54.Size = New System.Drawing.Size(155, 26)
        Me.LayoutControlItem54.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem54.Text = "LayoutControlItem54"
        Me.LayoutControlItem54.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem54.TextToControlDistance = 0
        Me.LayoutControlItem54.TextVisible = False
        '
        'EmptySpaceItem100
        '
        Me.EmptySpaceItem100.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem100.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem100.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem100.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem100.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem100.CustomizationFormText = "③  폐      업     신     고"
        Me.EmptySpaceItem100.Location = New System.Drawing.Point(0, 26)
        Me.EmptySpaceItem100.MaxSize = New System.Drawing.Size(148, 26)
        Me.EmptySpaceItem100.MinSize = New System.Drawing.Size(148, 26)
        Me.EmptySpaceItem100.Name = "EmptySpaceItem100"
        Me.EmptySpaceItem100.Size = New System.Drawing.Size(148, 26)
        Me.EmptySpaceItem100.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem100.Text = "③  폐      업     신     고"
        Me.EmptySpaceItem100.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem100.TextVisible = True
        '
        'EmptySpaceItem101
        '
        Me.EmptySpaceItem101.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem101.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem101.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem101.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem101.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem101.CustomizationFormText = "폐업일자"
        Me.EmptySpaceItem101.Location = New System.Drawing.Point(148, 26)
        Me.EmptySpaceItem101.MaxSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem101.MinSize = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem101.Name = "EmptySpaceItem101"
        Me.EmptySpaceItem101.Size = New System.Drawing.Size(69, 26)
        Me.EmptySpaceItem101.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem101.Text = "폐업일자"
        Me.EmptySpaceItem101.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem101.TextVisible = True
        '
        'LayoutControlItem55
        '
        Me.LayoutControlItem55.Control = Me.close_dt
        Me.LayoutControlItem55.CustomizationFormText = "LayoutControlItem55"
        Me.LayoutControlItem55.Location = New System.Drawing.Point(217, 26)
        Me.LayoutControlItem55.MaxSize = New System.Drawing.Size(159, 26)
        Me.LayoutControlItem55.MinSize = New System.Drawing.Size(159, 26)
        Me.LayoutControlItem55.Name = "LayoutControlItem55"
        Me.LayoutControlItem55.Size = New System.Drawing.Size(159, 26)
        Me.LayoutControlItem55.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem55.Text = "LayoutControlItem55"
        Me.LayoutControlItem55.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem55.TextToControlDistance = 0
        Me.LayoutControlItem55.TextVisible = False
        '
        'LayoutControlItem56
        '
        Me.LayoutControlItem56.Control = Me.close_rmk
        Me.LayoutControlItem56.CustomizationFormText = "LayoutControlItem56"
        Me.LayoutControlItem56.Location = New System.Drawing.Point(441, 26)
        Me.LayoutControlItem56.MaxSize = New System.Drawing.Size(413, 26)
        Me.LayoutControlItem56.MinSize = New System.Drawing.Size(413, 26)
        Me.LayoutControlItem56.Name = "LayoutControlItem56"
        Me.LayoutControlItem56.Size = New System.Drawing.Size(413, 26)
        Me.LayoutControlItem56.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem56.Text = "LayoutControlItem56"
        Me.LayoutControlItem56.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem56.TextToControlDistance = 0
        Me.LayoutControlItem56.TextVisible = False
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CustomizationFormText = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem103, Me.EmptySpaceItem105, Me.EmptySpaceItem106, Me.EmptySpaceItem107, Me.EmptySpaceItem108, Me.EmptySpaceItem109, Me.LayoutControlItem57, Me.LayoutControlItem58, Me.EmptySpaceItem111, Me.EmptySpaceItem104, Me.EmptySpaceItem112, Me.EmptySpaceItem113, Me.EmptySpaceItem114, Me.EmptySpaceItem115, Me.LayoutControlItem59, Me.EmptySpaceItem110, Me.LayoutControlItem60, Me.LayoutControlItem61, Me.EmptySpaceItem118, Me.EmptySpaceItem119, Me.EmptySpaceItem120, Me.EmptySpaceItem117, Me.EmptySpaceItem121, Me.EmptySpaceItem123, Me.EmptySpaceItem122, Me.LayoutControlItem62, Me.EmptySpaceItem124, Me.EmptySpaceItem116, Me.LayoutControlItem63, Me.LayoutControlItem64, Me.EmptySpaceItem125, Me.EmptySpaceItem127, Me.EmptySpaceItem128, Me.EmptySpaceItem126, Me.EmptySpaceItem129, Me.LayoutControlItem65, Me.EmptySpaceItem130, Me.LayoutControlItem67, Me.EmptySpaceItem134, Me.EmptySpaceItem132, Me.EmptySpaceItem133, Me.EmptySpaceItem131, Me.EmptySpaceItem136, Me.EmptySpaceItem137, Me.LayoutControlItem66, Me.EmptySpaceItem138, Me.EmptySpaceItem94, Me.EmptySpaceItem139, Me.EmptySpaceItem140, Me.EmptySpaceItem141, Me.LayoutControlItem68})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 822)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(878, 206)
        Me.LayoutControlGroup4.Text = "LayoutControlGroup4"
        Me.LayoutControlGroup4.TextVisible = False
        '
        'EmptySpaceItem103
        '
        Me.EmptySpaceItem103.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem103.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem103.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem103.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem103.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem103.CustomizationFormText = "④ 과  세  표  준  명  세"
        Me.EmptySpaceItem103.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem103.MaxSize = New System.Drawing.Size(600, 26)
        Me.EmptySpaceItem103.MinSize = New System.Drawing.Size(600, 26)
        Me.EmptySpaceItem103.Name = "EmptySpaceItem103"
        Me.EmptySpaceItem103.Size = New System.Drawing.Size(604, 26)
        Me.EmptySpaceItem103.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem103.Text = "④ 과  세  표  준  명  세"
        Me.EmptySpaceItem103.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem103.TextVisible = True
        '
        'EmptySpaceItem105
        '
        Me.EmptySpaceItem105.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem105.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem105.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem105.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem105.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem105.CustomizationFormText = "업    태"
        Me.EmptySpaceItem105.Location = New System.Drawing.Point(0, 26)
        Me.EmptySpaceItem105.MaxSize = New System.Drawing.Size(178, 26)
        Me.EmptySpaceItem105.MinSize = New System.Drawing.Size(178, 26)
        Me.EmptySpaceItem105.Name = "EmptySpaceItem105"
        Me.EmptySpaceItem105.Size = New System.Drawing.Size(178, 26)
        Me.EmptySpaceItem105.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem105.Text = "업    태"
        Me.EmptySpaceItem105.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem105.TextVisible = True
        '
        'EmptySpaceItem106
        '
        Me.EmptySpaceItem106.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem106.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem106.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem106.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem106.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem106.CustomizationFormText = "업종코드"
        Me.EmptySpaceItem106.Location = New System.Drawing.Point(320, 26)
        Me.EmptySpaceItem106.MaxSize = New System.Drawing.Size(60, 26)
        Me.EmptySpaceItem106.MinSize = New System.Drawing.Size(60, 26)
        Me.EmptySpaceItem106.Name = "EmptySpaceItem106"
        Me.EmptySpaceItem106.Size = New System.Drawing.Size(60, 26)
        Me.EmptySpaceItem106.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem106.Text = "업종코드"
        Me.EmptySpaceItem106.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem106.TextVisible = True
        '
        'EmptySpaceItem107
        '
        Me.EmptySpaceItem107.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem107.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem107.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem107.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem107.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem107.CustomizationFormText = "종    목"
        Me.EmptySpaceItem107.Location = New System.Drawing.Point(178, 26)
        Me.EmptySpaceItem107.MaxSize = New System.Drawing.Size(142, 26)
        Me.EmptySpaceItem107.MinSize = New System.Drawing.Size(142, 26)
        Me.EmptySpaceItem107.Name = "EmptySpaceItem107"
        Me.EmptySpaceItem107.Size = New System.Drawing.Size(142, 26)
        Me.EmptySpaceItem107.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem107.Text = "종    목"
        Me.EmptySpaceItem107.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem107.TextVisible = True
        '
        'EmptySpaceItem108
        '
        Me.EmptySpaceItem108.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem108.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem108.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem108.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem108.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem108.CustomizationFormText = "금   액"
        Me.EmptySpaceItem108.Location = New System.Drawing.Point(380, 26)
        Me.EmptySpaceItem108.MaxSize = New System.Drawing.Size(220, 26)
        Me.EmptySpaceItem108.MinSize = New System.Drawing.Size(220, 26)
        Me.EmptySpaceItem108.Name = "EmptySpaceItem108"
        Me.EmptySpaceItem108.Size = New System.Drawing.Size(224, 26)
        Me.EmptySpaceItem108.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem108.Text = "금   액"
        Me.EmptySpaceItem108.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem108.TextVisible = True
        '
        'EmptySpaceItem109
        '
        Me.EmptySpaceItem109.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem109.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem109.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem109.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem109.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem109.CustomizationFormText = "26"
        Me.EmptySpaceItem109.Location = New System.Drawing.Point(0, 52)
        Me.EmptySpaceItem109.MaxSize = New System.Drawing.Size(28, 26)
        Me.EmptySpaceItem109.MinSize = New System.Drawing.Size(28, 26)
        Me.EmptySpaceItem109.Name = "EmptySpaceItem109"
        Me.EmptySpaceItem109.Size = New System.Drawing.Size(28, 26)
        Me.EmptySpaceItem109.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem109.Text = "26"
        Me.EmptySpaceItem109.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem109.TextVisible = True
        '
        'LayoutControlItem57
        '
        Me.LayoutControlItem57.Control = Me.tax_kd1
        Me.LayoutControlItem57.CustomizationFormText = "1"
        Me.LayoutControlItem57.Location = New System.Drawing.Point(28, 52)
        Me.LayoutControlItem57.MaxSize = New System.Drawing.Size(150, 26)
        Me.LayoutControlItem57.MinSize = New System.Drawing.Size(150, 26)
        Me.LayoutControlItem57.Name = "LayoutControlItem57"
        Me.LayoutControlItem57.Size = New System.Drawing.Size(150, 26)
        Me.LayoutControlItem57.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem57.Text = "1"
        Me.LayoutControlItem57.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem57.TextToControlDistance = 0
        Me.LayoutControlItem57.TextVisible = False
        '
        'LayoutControlItem58
        '
        Me.LayoutControlItem58.Control = Me.tax_ty1
        Me.LayoutControlItem58.CustomizationFormText = "LayoutControlItem58"
        Me.LayoutControlItem58.Location = New System.Drawing.Point(178, 52)
        Me.LayoutControlItem58.MaxSize = New System.Drawing.Size(142, 26)
        Me.LayoutControlItem58.MinSize = New System.Drawing.Size(142, 26)
        Me.LayoutControlItem58.Name = "LayoutControlItem58"
        Me.LayoutControlItem58.Size = New System.Drawing.Size(142, 26)
        Me.LayoutControlItem58.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem58.Text = "LayoutControlItem58"
        Me.LayoutControlItem58.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem58.TextToControlDistance = 0
        Me.LayoutControlItem58.TextVisible = False
        '
        'EmptySpaceItem111
        '
        Me.EmptySpaceItem111.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem111.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem111.CustomizationFormText = " "
        Me.EmptySpaceItem111.Location = New System.Drawing.Point(370, 52)
        Me.EmptySpaceItem111.MaxSize = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem111.MinSize = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem111.Name = "EmptySpaceItem111"
        Me.EmptySpaceItem111.Size = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem111.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem111.Text = " "
        Me.EmptySpaceItem111.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem111.TextVisible = True
        '
        'EmptySpaceItem104
        '
        Me.EmptySpaceItem104.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem104.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem104.CustomizationFormText = " "
        Me.EmptySpaceItem104.Location = New System.Drawing.Point(320, 52)
        Me.EmptySpaceItem104.MaxSize = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem104.MinSize = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem104.Name = "EmptySpaceItem104"
        Me.EmptySpaceItem104.Size = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem104.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem104.Text = " "
        Me.EmptySpaceItem104.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem104.TextVisible = True
        '
        'EmptySpaceItem112
        '
        Me.EmptySpaceItem112.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem112.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem112.CustomizationFormText = " "
        Me.EmptySpaceItem112.Location = New System.Drawing.Point(330, 52)
        Me.EmptySpaceItem112.MaxSize = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem112.MinSize = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem112.Name = "EmptySpaceItem112"
        Me.EmptySpaceItem112.Size = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem112.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem112.Text = " "
        Me.EmptySpaceItem112.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem112.TextVisible = True
        '
        'EmptySpaceItem113
        '
        Me.EmptySpaceItem113.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem113.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem113.CustomizationFormText = " "
        Me.EmptySpaceItem113.Location = New System.Drawing.Point(350, 52)
        Me.EmptySpaceItem113.MaxSize = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem113.MinSize = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem113.Name = "EmptySpaceItem113"
        Me.EmptySpaceItem113.Size = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem113.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem113.Text = " "
        Me.EmptySpaceItem113.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem113.TextVisible = True
        '
        'EmptySpaceItem114
        '
        Me.EmptySpaceItem114.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem114.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem114.CustomizationFormText = " "
        Me.EmptySpaceItem114.Location = New System.Drawing.Point(360, 52)
        Me.EmptySpaceItem114.MaxSize = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem114.MinSize = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem114.Name = "EmptySpaceItem114"
        Me.EmptySpaceItem114.Size = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem114.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem114.Text = " "
        Me.EmptySpaceItem114.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem114.TextVisible = True
        '
        'EmptySpaceItem115
        '
        Me.EmptySpaceItem115.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem115.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem115.CustomizationFormText = " "
        Me.EmptySpaceItem115.Location = New System.Drawing.Point(340, 52)
        Me.EmptySpaceItem115.MaxSize = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem115.MinSize = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem115.Name = "EmptySpaceItem115"
        Me.EmptySpaceItem115.Size = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem115.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem115.Text = " "
        Me.EmptySpaceItem115.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem115.TextVisible = True
        '
        'LayoutControlItem59
        '
        Me.LayoutControlItem59.Control = Me.tax_amt1
        Me.LayoutControlItem59.CustomizationFormText = "LayoutControlItem59"
        Me.LayoutControlItem59.Location = New System.Drawing.Point(380, 52)
        Me.LayoutControlItem59.MaxSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem59.MinSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem59.Name = "LayoutControlItem59"
        Me.LayoutControlItem59.Size = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem59.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem59.Text = "LayoutControlItem59"
        Me.LayoutControlItem59.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem59.TextToControlDistance = 0
        Me.LayoutControlItem59.TextVisible = False
        '
        'EmptySpaceItem110
        '
        Me.EmptySpaceItem110.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem110.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem110.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem110.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem110.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem110.CustomizationFormText = "EmptySpaceItem110"
        Me.EmptySpaceItem110.Location = New System.Drawing.Point(0, 78)
        Me.EmptySpaceItem110.MaxSize = New System.Drawing.Size(28, 26)
        Me.EmptySpaceItem110.MinSize = New System.Drawing.Size(28, 26)
        Me.EmptySpaceItem110.Name = "EmptySpaceItem110"
        Me.EmptySpaceItem110.Size = New System.Drawing.Size(28, 26)
        Me.EmptySpaceItem110.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem110.Text = "27"
        Me.EmptySpaceItem110.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem110.TextVisible = True
        '
        'LayoutControlItem60
        '
        Me.LayoutControlItem60.Control = Me.tax_kd2
        Me.LayoutControlItem60.CustomizationFormText = "LayoutControlItem60"
        Me.LayoutControlItem60.Location = New System.Drawing.Point(28, 78)
        Me.LayoutControlItem60.MaxSize = New System.Drawing.Size(150, 26)
        Me.LayoutControlItem60.MinSize = New System.Drawing.Size(150, 26)
        Me.LayoutControlItem60.Name = "LayoutControlItem60"
        Me.LayoutControlItem60.Size = New System.Drawing.Size(150, 26)
        Me.LayoutControlItem60.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem60.Text = "LayoutControlItem60"
        Me.LayoutControlItem60.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem60.TextToControlDistance = 0
        Me.LayoutControlItem60.TextVisible = False
        '
        'LayoutControlItem61
        '
        Me.LayoutControlItem61.Control = Me.tax_ty2
        Me.LayoutControlItem61.CustomizationFormText = "LayoutControlItem61"
        Me.LayoutControlItem61.Location = New System.Drawing.Point(178, 78)
        Me.LayoutControlItem61.MinSize = New System.Drawing.Size(140, 24)
        Me.LayoutControlItem61.Name = "LayoutControlItem61"
        Me.LayoutControlItem61.Size = New System.Drawing.Size(142, 26)
        Me.LayoutControlItem61.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem61.Text = "LayoutControlItem61"
        Me.LayoutControlItem61.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem61.TextToControlDistance = 0
        Me.LayoutControlItem61.TextVisible = False
        '
        'EmptySpaceItem118
        '
        Me.EmptySpaceItem118.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem118.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem118.CustomizationFormText = "EmptySpaceItem118"
        Me.EmptySpaceItem118.Location = New System.Drawing.Point(320, 78)
        Me.EmptySpaceItem118.Name = "EmptySpaceItem118"
        Me.EmptySpaceItem118.Size = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem118.Text = " "
        Me.EmptySpaceItem118.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem118.TextVisible = True
        '
        'EmptySpaceItem119
        '
        Me.EmptySpaceItem119.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem119.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem119.CustomizationFormText = "EmptySpaceItem119"
        Me.EmptySpaceItem119.Location = New System.Drawing.Point(330, 78)
        Me.EmptySpaceItem119.Name = "EmptySpaceItem119"
        Me.EmptySpaceItem119.Size = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem119.Text = " "
        Me.EmptySpaceItem119.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem119.TextVisible = True
        '
        'EmptySpaceItem120
        '
        Me.EmptySpaceItem120.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem120.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem120.CustomizationFormText = "EmptySpaceItem120"
        Me.EmptySpaceItem120.Location = New System.Drawing.Point(340, 78)
        Me.EmptySpaceItem120.Name = "EmptySpaceItem120"
        Me.EmptySpaceItem120.Size = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem120.Text = " "
        Me.EmptySpaceItem120.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem120.TextVisible = True
        '
        'EmptySpaceItem117
        '
        Me.EmptySpaceItem117.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem117.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem117.CustomizationFormText = "EmptySpaceItem117"
        Me.EmptySpaceItem117.Location = New System.Drawing.Point(350, 78)
        Me.EmptySpaceItem117.Name = "EmptySpaceItem117"
        Me.EmptySpaceItem117.Size = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem117.Text = " "
        Me.EmptySpaceItem117.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem117.TextVisible = True
        '
        'EmptySpaceItem121
        '
        Me.EmptySpaceItem121.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem121.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem121.CustomizationFormText = "EmptySpaceItem121"
        Me.EmptySpaceItem121.Location = New System.Drawing.Point(360, 78)
        Me.EmptySpaceItem121.Name = "EmptySpaceItem121"
        Me.EmptySpaceItem121.Size = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem121.Text = " "
        Me.EmptySpaceItem121.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem121.TextVisible = True
        '
        'EmptySpaceItem123
        '
        Me.EmptySpaceItem123.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem123.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem123.CustomizationFormText = "EmptySpaceItem123"
        Me.EmptySpaceItem123.Location = New System.Drawing.Point(370, 104)
        Me.EmptySpaceItem123.MaxSize = New System.Drawing.Size(0, 26)
        Me.EmptySpaceItem123.MinSize = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem123.Name = "EmptySpaceItem123"
        Me.EmptySpaceItem123.Size = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem123.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem123.Text = " "
        Me.EmptySpaceItem123.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem123.TextVisible = True
        '
        'EmptySpaceItem122
        '
        Me.EmptySpaceItem122.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem122.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem122.CustomizationFormText = "EmptySpaceItem122"
        Me.EmptySpaceItem122.Location = New System.Drawing.Point(370, 78)
        Me.EmptySpaceItem122.MinSize = New System.Drawing.Size(10, 24)
        Me.EmptySpaceItem122.Name = "EmptySpaceItem122"
        Me.EmptySpaceItem122.Size = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem122.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem122.Text = " "
        Me.EmptySpaceItem122.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem122.TextVisible = True
        '
        'LayoutControlItem62
        '
        Me.LayoutControlItem62.Control = Me.tax_amt2
        Me.LayoutControlItem62.CustomizationFormText = "LayoutControlItem62"
        Me.LayoutControlItem62.Location = New System.Drawing.Point(380, 78)
        Me.LayoutControlItem62.MaxSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem62.MinSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem62.Name = "LayoutControlItem62"
        Me.LayoutControlItem62.Size = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem62.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem62.Text = "LayoutControlItem62"
        Me.LayoutControlItem62.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem62.TextToControlDistance = 0
        Me.LayoutControlItem62.TextVisible = False
        '
        'EmptySpaceItem124
        '
        Me.EmptySpaceItem124.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem124.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem124.CustomizationFormText = " "
        Me.EmptySpaceItem124.Location = New System.Drawing.Point(370, 130)
        Me.EmptySpaceItem124.Name = "EmptySpaceItem124"
        Me.EmptySpaceItem124.Size = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem124.Text = " "
        Me.EmptySpaceItem124.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem124.TextVisible = True
        '
        'EmptySpaceItem116
        '
        Me.EmptySpaceItem116.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem116.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem116.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem116.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem116.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem116.CustomizationFormText = "28"
        Me.EmptySpaceItem116.Location = New System.Drawing.Point(0, 104)
        Me.EmptySpaceItem116.MaxSize = New System.Drawing.Size(28, 26)
        Me.EmptySpaceItem116.MinSize = New System.Drawing.Size(28, 26)
        Me.EmptySpaceItem116.Name = "EmptySpaceItem116"
        Me.EmptySpaceItem116.Size = New System.Drawing.Size(28, 26)
        Me.EmptySpaceItem116.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem116.Text = "28"
        Me.EmptySpaceItem116.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem116.TextVisible = True
        '
        'LayoutControlItem63
        '
        Me.LayoutControlItem63.Control = Me.tax_kd3
        Me.LayoutControlItem63.CustomizationFormText = "LayoutControlItem63"
        Me.LayoutControlItem63.Location = New System.Drawing.Point(28, 104)
        Me.LayoutControlItem63.MaxSize = New System.Drawing.Size(150, 26)
        Me.LayoutControlItem63.MinSize = New System.Drawing.Size(150, 26)
        Me.LayoutControlItem63.Name = "LayoutControlItem63"
        Me.LayoutControlItem63.Size = New System.Drawing.Size(150, 26)
        Me.LayoutControlItem63.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem63.Text = "LayoutControlItem63"
        Me.LayoutControlItem63.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem63.TextToControlDistance = 0
        Me.LayoutControlItem63.TextVisible = False
        '
        'LayoutControlItem64
        '
        Me.LayoutControlItem64.Control = Me.tax_ty3
        Me.LayoutControlItem64.CustomizationFormText = "LayoutControlItem64"
        Me.LayoutControlItem64.Location = New System.Drawing.Point(178, 104)
        Me.LayoutControlItem64.MaxSize = New System.Drawing.Size(142, 26)
        Me.LayoutControlItem64.MinSize = New System.Drawing.Size(142, 26)
        Me.LayoutControlItem64.Name = "LayoutControlItem64"
        Me.LayoutControlItem64.Size = New System.Drawing.Size(142, 26)
        Me.LayoutControlItem64.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem64.Text = "LayoutControlItem64"
        Me.LayoutControlItem64.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem64.TextToControlDistance = 0
        Me.LayoutControlItem64.TextVisible = False
        '
        'EmptySpaceItem125
        '
        Me.EmptySpaceItem125.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem125.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem125.CustomizationFormText = " "
        Me.EmptySpaceItem125.Location = New System.Drawing.Point(320, 104)
        Me.EmptySpaceItem125.Name = "EmptySpaceItem125"
        Me.EmptySpaceItem125.Size = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem125.Text = " "
        Me.EmptySpaceItem125.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem125.TextVisible = True
        '
        'EmptySpaceItem127
        '
        Me.EmptySpaceItem127.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem127.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem127.CustomizationFormText = " "
        Me.EmptySpaceItem127.Location = New System.Drawing.Point(330, 104)
        Me.EmptySpaceItem127.Name = "EmptySpaceItem127"
        Me.EmptySpaceItem127.Size = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem127.Text = " "
        Me.EmptySpaceItem127.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem127.TextVisible = True
        '
        'EmptySpaceItem128
        '
        Me.EmptySpaceItem128.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem128.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem128.CustomizationFormText = " "
        Me.EmptySpaceItem128.Location = New System.Drawing.Point(340, 104)
        Me.EmptySpaceItem128.Name = "EmptySpaceItem128"
        Me.EmptySpaceItem128.Size = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem128.Text = " "
        Me.EmptySpaceItem128.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem128.TextVisible = True
        '
        'EmptySpaceItem126
        '
        Me.EmptySpaceItem126.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem126.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem126.CustomizationFormText = " "
        Me.EmptySpaceItem126.Location = New System.Drawing.Point(350, 104)
        Me.EmptySpaceItem126.Name = "EmptySpaceItem126"
        Me.EmptySpaceItem126.Size = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem126.Text = " "
        Me.EmptySpaceItem126.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem126.TextVisible = True
        '
        'EmptySpaceItem129
        '
        Me.EmptySpaceItem129.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem129.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem129.CustomizationFormText = " "
        Me.EmptySpaceItem129.Location = New System.Drawing.Point(360, 104)
        Me.EmptySpaceItem129.Name = "EmptySpaceItem129"
        Me.EmptySpaceItem129.Size = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem129.Text = " "
        Me.EmptySpaceItem129.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem129.TextVisible = True
        '
        'LayoutControlItem65
        '
        Me.LayoutControlItem65.Control = Me.tax_amt3
        Me.LayoutControlItem65.CustomizationFormText = "LayoutControlItem65"
        Me.LayoutControlItem65.Location = New System.Drawing.Point(380, 104)
        Me.LayoutControlItem65.MaxSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem65.MinSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem65.Name = "LayoutControlItem65"
        Me.LayoutControlItem65.Size = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem65.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem65.Text = "LayoutControlItem65"
        Me.LayoutControlItem65.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem65.TextToControlDistance = 0
        Me.LayoutControlItem65.TextVisible = False
        '
        'EmptySpaceItem130
        '
        Me.EmptySpaceItem130.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem130.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem130.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem130.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem130.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem130.CustomizationFormText = "29"
        Me.EmptySpaceItem130.Location = New System.Drawing.Point(0, 130)
        Me.EmptySpaceItem130.MaxSize = New System.Drawing.Size(28, 26)
        Me.EmptySpaceItem130.MinSize = New System.Drawing.Size(28, 26)
        Me.EmptySpaceItem130.Name = "EmptySpaceItem130"
        Me.EmptySpaceItem130.Size = New System.Drawing.Size(28, 26)
        Me.EmptySpaceItem130.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem130.Text = "29"
        Me.EmptySpaceItem130.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem130.TextVisible = True
        '
        'LayoutControlItem67
        '
        Me.LayoutControlItem67.Control = Me.tax_ty4
        Me.LayoutControlItem67.CustomizationFormText = "LayoutControlItem67"
        Me.LayoutControlItem67.Location = New System.Drawing.Point(178, 130)
        Me.LayoutControlItem67.MaxSize = New System.Drawing.Size(142, 26)
        Me.LayoutControlItem67.MinSize = New System.Drawing.Size(142, 26)
        Me.LayoutControlItem67.Name = "LayoutControlItem67"
        Me.LayoutControlItem67.Size = New System.Drawing.Size(142, 26)
        Me.LayoutControlItem67.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem67.Text = "LayoutControlItem67"
        Me.LayoutControlItem67.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem67.TextToControlDistance = 0
        Me.LayoutControlItem67.TextVisible = False
        '
        'EmptySpaceItem134
        '
        Me.EmptySpaceItem134.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem134.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem134.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem134.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem134.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem134.CustomizationFormText = "수입금액제외"
        Me.EmptySpaceItem134.Location = New System.Drawing.Point(28, 130)
        Me.EmptySpaceItem134.MaxSize = New System.Drawing.Size(150, 26)
        Me.EmptySpaceItem134.MinSize = New System.Drawing.Size(150, 26)
        Me.EmptySpaceItem134.Name = "EmptySpaceItem134"
        Me.EmptySpaceItem134.Size = New System.Drawing.Size(150, 26)
        Me.EmptySpaceItem134.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem134.Text = "수입금액제외"
        Me.EmptySpaceItem134.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem134.TextVisible = True
        '
        'EmptySpaceItem132
        '
        Me.EmptySpaceItem132.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem132.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem132.CustomizationFormText = " "
        Me.EmptySpaceItem132.Location = New System.Drawing.Point(320, 130)
        Me.EmptySpaceItem132.Name = "EmptySpaceItem132"
        Me.EmptySpaceItem132.Size = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem132.Text = " "
        Me.EmptySpaceItem132.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem132.TextVisible = True
        '
        'EmptySpaceItem133
        '
        Me.EmptySpaceItem133.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem133.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem133.CustomizationFormText = " "
        Me.EmptySpaceItem133.Location = New System.Drawing.Point(330, 130)
        Me.EmptySpaceItem133.Name = "EmptySpaceItem133"
        Me.EmptySpaceItem133.Size = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem133.Text = " "
        Me.EmptySpaceItem133.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem133.TextVisible = True
        '
        'EmptySpaceItem131
        '
        Me.EmptySpaceItem131.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem131.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem131.CustomizationFormText = " "
        Me.EmptySpaceItem131.Location = New System.Drawing.Point(340, 130)
        Me.EmptySpaceItem131.Name = "EmptySpaceItem131"
        Me.EmptySpaceItem131.Size = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem131.Text = " "
        Me.EmptySpaceItem131.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem131.TextVisible = True
        '
        'EmptySpaceItem136
        '
        Me.EmptySpaceItem136.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem136.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem136.CustomizationFormText = " "
        Me.EmptySpaceItem136.Location = New System.Drawing.Point(350, 130)
        Me.EmptySpaceItem136.Name = "EmptySpaceItem136"
        Me.EmptySpaceItem136.Size = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem136.Text = " "
        Me.EmptySpaceItem136.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem136.TextVisible = True
        '
        'EmptySpaceItem137
        '
        Me.EmptySpaceItem137.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem137.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem137.CustomizationFormText = " "
        Me.EmptySpaceItem137.Location = New System.Drawing.Point(360, 130)
        Me.EmptySpaceItem137.Name = "EmptySpaceItem137"
        Me.EmptySpaceItem137.Size = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem137.Text = " "
        Me.EmptySpaceItem137.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem137.TextVisible = True
        '
        'LayoutControlItem66
        '
        Me.LayoutControlItem66.Control = Me.tax_amt4
        Me.LayoutControlItem66.CustomizationFormText = "LayoutControlItem66"
        Me.LayoutControlItem66.Location = New System.Drawing.Point(380, 130)
        Me.LayoutControlItem66.MaxSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem66.MinSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem66.Name = "LayoutControlItem66"
        Me.LayoutControlItem66.Size = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem66.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem66.Text = "LayoutControlItem66"
        Me.LayoutControlItem66.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem66.TextToControlDistance = 0
        Me.LayoutControlItem66.TextVisible = False
        '
        'EmptySpaceItem138
        '
        Me.EmptySpaceItem138.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem138.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem138.CustomizationFormText = " "
        Me.EmptySpaceItem138.Location = New System.Drawing.Point(320, 156)
        Me.EmptySpaceItem138.MaxSize = New System.Drawing.Size(60, 26)
        Me.EmptySpaceItem138.MinSize = New System.Drawing.Size(60, 26)
        Me.EmptySpaceItem138.Name = "EmptySpaceItem138"
        Me.EmptySpaceItem138.Size = New System.Drawing.Size(60, 26)
        Me.EmptySpaceItem138.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem138.Text = " "
        Me.EmptySpaceItem138.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem138.TextVisible = True
        '
        'EmptySpaceItem94
        '
        Me.EmptySpaceItem94.CustomizationFormText = "EmptySpaceItem94"
        Me.EmptySpaceItem94.Location = New System.Drawing.Point(604, 0)
        Me.EmptySpaceItem94.Name = "EmptySpaceItem94"
        Me.EmptySpaceItem94.Size = New System.Drawing.Size(250, 182)
        Me.EmptySpaceItem94.Text = "EmptySpaceItem94"
        Me.EmptySpaceItem94.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem139
        '
        Me.EmptySpaceItem139.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem139.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem139.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem139.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem139.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem139.CustomizationFormText = "30"
        Me.EmptySpaceItem139.Location = New System.Drawing.Point(0, 156)
        Me.EmptySpaceItem139.MaxSize = New System.Drawing.Size(28, 26)
        Me.EmptySpaceItem139.MinSize = New System.Drawing.Size(28, 26)
        Me.EmptySpaceItem139.Name = "EmptySpaceItem139"
        Me.EmptySpaceItem139.Size = New System.Drawing.Size(28, 26)
        Me.EmptySpaceItem139.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem139.Text = "30"
        Me.EmptySpaceItem139.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem139.TextVisible = True
        '
        'EmptySpaceItem140
        '
        Me.EmptySpaceItem140.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem140.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem140.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem140.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem140.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem140.CustomizationFormText = "합     계"
        Me.EmptySpaceItem140.Location = New System.Drawing.Point(28, 156)
        Me.EmptySpaceItem140.MaxSize = New System.Drawing.Size(150, 26)
        Me.EmptySpaceItem140.MinSize = New System.Drawing.Size(150, 26)
        Me.EmptySpaceItem140.Name = "EmptySpaceItem140"
        Me.EmptySpaceItem140.Size = New System.Drawing.Size(150, 26)
        Me.EmptySpaceItem140.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem140.Text = "합           계"
        Me.EmptySpaceItem140.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem140.TextVisible = True
        '
        'EmptySpaceItem141
        '
        Me.EmptySpaceItem141.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem141.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem141.CustomizationFormText = " "
        Me.EmptySpaceItem141.Location = New System.Drawing.Point(178, 156)
        Me.EmptySpaceItem141.MaxSize = New System.Drawing.Size(142, 26)
        Me.EmptySpaceItem141.MinSize = New System.Drawing.Size(142, 26)
        Me.EmptySpaceItem141.Name = "EmptySpaceItem141"
        Me.EmptySpaceItem141.Size = New System.Drawing.Size(142, 26)
        Me.EmptySpaceItem141.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem141.Text = " "
        Me.EmptySpaceItem141.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem141.TextVisible = True
        '
        'LayoutControlItem68
        '
        Me.LayoutControlItem68.Control = Me.tax_sum_amt
        Me.LayoutControlItem68.CustomizationFormText = "LayoutControlItem68"
        Me.LayoutControlItem68.Location = New System.Drawing.Point(380, 156)
        Me.LayoutControlItem68.MaxSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem68.MinSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem68.Name = "LayoutControlItem68"
        Me.LayoutControlItem68.Size = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem68.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem68.Text = "LayoutControlItem68"
        Me.LayoutControlItem68.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem68.TextToControlDistance = 0
        Me.LayoutControlItem68.TextVisible = False
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.CustomizationFormText = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem102, Me.EmptySpaceItem135, Me.EmptySpaceItem143, Me.EmptySpaceItem144, Me.LayoutControlItem69, Me.LayoutControlItem70, Me.LayoutControlItem71})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 1028)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(878, 50)
        Me.LayoutControlGroup5.Text = "LayoutControlGroup5"
        Me.LayoutControlGroup5.TextVisible = False
        '
        'EmptySpaceItem102
        '
        Me.EmptySpaceItem102.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem102.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem102.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem102.CustomizationFormText = "EmptySpaceItem102"
        Me.EmptySpaceItem102.Location = New System.Drawing.Point(324, 0)
        Me.EmptySpaceItem102.MaxSize = New System.Drawing.Size(107, 26)
        Me.EmptySpaceItem102.MinSize = New System.Drawing.Size(107, 26)
        Me.EmptySpaceItem102.Name = "EmptySpaceItem102"
        Me.EmptySpaceItem102.Size = New System.Drawing.Size(107, 26)
        Me.EmptySpaceItem102.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem102.Text = "사업자등록번호"
        Me.EmptySpaceItem102.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem102.TextVisible = True
        '
        'EmptySpaceItem135
        '
        Me.EmptySpaceItem135.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem135.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem135.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem135.CustomizationFormText = "세무대리인  "
        Me.EmptySpaceItem135.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem135.MaxSize = New System.Drawing.Size(124, 26)
        Me.EmptySpaceItem135.MinSize = New System.Drawing.Size(124, 26)
        Me.EmptySpaceItem135.Name = "EmptySpaceItem135"
        Me.EmptySpaceItem135.Size = New System.Drawing.Size(124, 26)
        Me.EmptySpaceItem135.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem135.Text = "세무대리인  "
        Me.EmptySpaceItem135.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem135.TextVisible = True
        '
        'EmptySpaceItem143
        '
        Me.EmptySpaceItem143.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem143.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem143.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem143.CustomizationFormText = "성  명"
        Me.EmptySpaceItem143.Location = New System.Drawing.Point(124, 0)
        Me.EmptySpaceItem143.MaxSize = New System.Drawing.Size(80, 26)
        Me.EmptySpaceItem143.MinSize = New System.Drawing.Size(80, 26)
        Me.EmptySpaceItem143.Name = "EmptySpaceItem143"
        Me.EmptySpaceItem143.Size = New System.Drawing.Size(80, 26)
        Me.EmptySpaceItem143.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem143.Text = "성  명"
        Me.EmptySpaceItem143.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem143.TextVisible = True
        '
        'EmptySpaceItem144
        '
        Me.EmptySpaceItem144.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem144.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem144.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem144.CustomizationFormText = "전화번호"
        Me.EmptySpaceItem144.Location = New System.Drawing.Point(580, 0)
        Me.EmptySpaceItem144.MaxSize = New System.Drawing.Size(132, 26)
        Me.EmptySpaceItem144.MinSize = New System.Drawing.Size(132, 26)
        Me.EmptySpaceItem144.Name = "EmptySpaceItem144"
        Me.EmptySpaceItem144.Size = New System.Drawing.Size(132, 26)
        Me.EmptySpaceItem144.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem144.Text = "전화번호"
        Me.EmptySpaceItem144.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem144.TextVisible = True
        '
        'LayoutControlItem69
        '
        Me.LayoutControlItem69.Control = Me.agent_nm
        Me.LayoutControlItem69.CustomizationFormText = "LayoutControlItem69"
        Me.LayoutControlItem69.Location = New System.Drawing.Point(204, 0)
        Me.LayoutControlItem69.MaxSize = New System.Drawing.Size(120, 26)
        Me.LayoutControlItem69.MinSize = New System.Drawing.Size(120, 26)
        Me.LayoutControlItem69.Name = "LayoutControlItem69"
        Me.LayoutControlItem69.Size = New System.Drawing.Size(120, 26)
        Me.LayoutControlItem69.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem69.Text = "LayoutControlItem69"
        Me.LayoutControlItem69.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem69.TextToControlDistance = 0
        Me.LayoutControlItem69.TextVisible = False
        '
        'LayoutControlItem70
        '
        Me.LayoutControlItem70.Control = Me.agent_no
        Me.LayoutControlItem70.CustomizationFormText = "LayoutControlItem70"
        Me.LayoutControlItem70.Location = New System.Drawing.Point(431, 0)
        Me.LayoutControlItem70.MaxSize = New System.Drawing.Size(149, 26)
        Me.LayoutControlItem70.MinSize = New System.Drawing.Size(149, 26)
        Me.LayoutControlItem70.Name = "LayoutControlItem70"
        Me.LayoutControlItem70.Size = New System.Drawing.Size(149, 26)
        Me.LayoutControlItem70.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem70.Text = "LayoutControlItem70"
        Me.LayoutControlItem70.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem70.TextToControlDistance = 0
        Me.LayoutControlItem70.TextVisible = False
        '
        'LayoutControlItem71
        '
        Me.LayoutControlItem71.Control = Me.agent_tel
        Me.LayoutControlItem71.CustomizationFormText = "LayoutControlItem71"
        Me.LayoutControlItem71.Location = New System.Drawing.Point(712, 0)
        Me.LayoutControlItem71.MaxSize = New System.Drawing.Size(142, 26)
        Me.LayoutControlItem71.MinSize = New System.Drawing.Size(142, 26)
        Me.LayoutControlItem71.Name = "LayoutControlItem71"
        Me.LayoutControlItem71.Size = New System.Drawing.Size(142, 26)
        Me.LayoutControlItem71.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem71.Text = "LayoutControlItem71"
        Me.LayoutControlItem71.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem71.TextToControlDistance = 0
        Me.LayoutControlItem71.TextVisible = False
        '
        'LayoutControlGroup6
        '
        Me.LayoutControlGroup6.CustomizationFormText = "LayoutControlGroup6"
        Me.LayoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem142, Me.EmptySpaceItem145, Me.EmptySpaceItem147, Me.EmptySpaceItem151, Me.EmptySpaceItem152, Me.EmptySpaceItem153, Me.EmptySpaceItem154, Me.EmptySpaceItem149, Me.EmptySpaceItem155, Me.EmptySpaceItem156, Me.LayoutControlItem72, Me.LayoutControlItem73, Me.EmptySpaceItem157, Me.LayoutControlItem74, Me.LayoutControlItem76, Me.EmptySpaceItem150, Me.EmptySpaceItem158, Me.EmptySpaceItem160, Me.EmptySpaceItem159, Me.LayoutControlItem78, Me.EmptySpaceItem161, Me.LayoutControlItem77, Me.EmptySpaceItem162, Me.EmptySpaceItem163, Me.EmptySpaceItem164, Me.EmptySpaceItem165, Me.EmptySpaceItem166, Me.EmptySpaceItem167, Me.EmptySpaceItem168, Me.EmptySpaceItem169, Me.LayoutControlItem79, Me.LayoutControlItem80, Me.EmptySpaceItem148, Me.EmptySpaceItem170, Me.EmptySpaceItem171, Me.LayoutControlItem81})
        Me.LayoutControlGroup6.Location = New System.Drawing.Point(0, 1078)
        Me.LayoutControlGroup6.Name = "LayoutControlGroup6"
        Me.LayoutControlGroup6.Size = New System.Drawing.Size(878, 154)
        Me.LayoutControlGroup6.Text = "LayoutControlGroup6"
        Me.LayoutControlGroup6.TextVisible = False
        '
        'EmptySpaceItem142
        '
        Me.EmptySpaceItem142.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem142.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem142.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem142.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem142.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem142.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.EmptySpaceItem142.CustomizationFormText = "면세사업          수입금액"
        Me.EmptySpaceItem142.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem142.MaxSize = New System.Drawing.Size(136, 130)
        Me.EmptySpaceItem142.MinSize = New System.Drawing.Size(136, 130)
        Me.EmptySpaceItem142.Name = "EmptySpaceItem142"
        Me.EmptySpaceItem142.Size = New System.Drawing.Size(136, 130)
        Me.EmptySpaceItem142.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem142.Text = "면세사업          수입금액"
        Me.EmptySpaceItem142.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem142.TextVisible = True
        '
        'EmptySpaceItem145
        '
        Me.EmptySpaceItem145.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem145.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem145.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem145.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem145.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem145.CustomizationFormText = "코 드 번 호"
        Me.EmptySpaceItem145.Location = New System.Drawing.Point(536, 0)
        Me.EmptySpaceItem145.MaxSize = New System.Drawing.Size(100, 26)
        Me.EmptySpaceItem145.MinSize = New System.Drawing.Size(100, 26)
        Me.EmptySpaceItem145.Name = "EmptySpaceItem145"
        Me.EmptySpaceItem145.Size = New System.Drawing.Size(100, 26)
        Me.EmptySpaceItem145.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem145.Text = "코 드 번 호"
        Me.EmptySpaceItem145.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem145.TextVisible = True
        '
        'EmptySpaceItem147
        '
        Me.EmptySpaceItem147.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem147.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem147.CustomizationFormText = "EmptySpaceItem147"
        Me.EmptySpaceItem147.Location = New System.Drawing.Point(616, 52)
        Me.EmptySpaceItem147.MaxSize = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem147.MinSize = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem147.Name = "EmptySpaceItem147"
        Me.EmptySpaceItem147.Size = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem147.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem147.Text = " "
        Me.EmptySpaceItem147.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem147.TextVisible = True
        '
        'EmptySpaceItem151
        '
        Me.EmptySpaceItem151.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem151.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem151.CustomizationFormText = "EmptySpaceItem151"
        Me.EmptySpaceItem151.Location = New System.Drawing.Point(616, 26)
        Me.EmptySpaceItem151.MaxSize = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem151.MinSize = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem151.Name = "EmptySpaceItem151"
        Me.EmptySpaceItem151.Size = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem151.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem151.Text = " "
        Me.EmptySpaceItem151.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem151.TextVisible = True
        '
        'EmptySpaceItem152
        '
        Me.EmptySpaceItem152.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem152.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem152.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem152.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem152.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem152.CustomizationFormText = "업    태"
        Me.EmptySpaceItem152.Location = New System.Drawing.Point(136, 0)
        Me.EmptySpaceItem152.MaxSize = New System.Drawing.Size(200, 26)
        Me.EmptySpaceItem152.MinSize = New System.Drawing.Size(200, 26)
        Me.EmptySpaceItem152.Name = "EmptySpaceItem152"
        Me.EmptySpaceItem152.Size = New System.Drawing.Size(200, 26)
        Me.EmptySpaceItem152.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem152.Text = "업    태"
        Me.EmptySpaceItem152.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem152.TextVisible = True
        '
        'EmptySpaceItem153
        '
        Me.EmptySpaceItem153.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem153.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem153.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem153.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem153.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem153.CustomizationFormText = "종    목"
        Me.EmptySpaceItem153.Location = New System.Drawing.Point(336, 0)
        Me.EmptySpaceItem153.MaxSize = New System.Drawing.Size(200, 26)
        Me.EmptySpaceItem153.MinSize = New System.Drawing.Size(200, 26)
        Me.EmptySpaceItem153.Name = "EmptySpaceItem153"
        Me.EmptySpaceItem153.Size = New System.Drawing.Size(200, 26)
        Me.EmptySpaceItem153.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem153.Text = "종    목"
        Me.EmptySpaceItem153.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem153.TextVisible = True
        '
        'EmptySpaceItem154
        '
        Me.EmptySpaceItem154.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem154.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem154.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem154.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem154.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem154.CustomizationFormText = "금    액"
        Me.EmptySpaceItem154.Location = New System.Drawing.Point(636, 0)
        Me.EmptySpaceItem154.MaxSize = New System.Drawing.Size(218, 26)
        Me.EmptySpaceItem154.MinSize = New System.Drawing.Size(218, 26)
        Me.EmptySpaceItem154.Name = "EmptySpaceItem154"
        Me.EmptySpaceItem154.Size = New System.Drawing.Size(218, 26)
        Me.EmptySpaceItem154.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem154.Text = "금    액"
        Me.EmptySpaceItem154.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem154.TextVisible = True
        '
        'EmptySpaceItem149
        '
        Me.EmptySpaceItem149.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem149.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem149.CustomizationFormText = " "
        Me.EmptySpaceItem149.Location = New System.Drawing.Point(136, 26)
        Me.EmptySpaceItem149.MaxSize = New System.Drawing.Size(43, 26)
        Me.EmptySpaceItem149.MinSize = New System.Drawing.Size(43, 26)
        Me.EmptySpaceItem149.Name = "EmptySpaceItem149"
        Me.EmptySpaceItem149.Size = New System.Drawing.Size(43, 26)
        Me.EmptySpaceItem149.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem149.Text = " "
        Me.EmptySpaceItem149.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem149.TextVisible = True
        '
        'EmptySpaceItem155
        '
        Me.EmptySpaceItem155.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem155.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem155.CustomizationFormText = " "
        Me.EmptySpaceItem155.Location = New System.Drawing.Point(136, 52)
        Me.EmptySpaceItem155.MaxSize = New System.Drawing.Size(43, 26)
        Me.EmptySpaceItem155.MinSize = New System.Drawing.Size(43, 26)
        Me.EmptySpaceItem155.Name = "EmptySpaceItem155"
        Me.EmptySpaceItem155.Size = New System.Drawing.Size(43, 26)
        Me.EmptySpaceItem155.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem155.Text = " "
        Me.EmptySpaceItem155.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem155.TextVisible = True
        '
        'EmptySpaceItem156
        '
        Me.EmptySpaceItem156.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem156.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem156.CustomizationFormText = " "
        Me.EmptySpaceItem156.Location = New System.Drawing.Point(136, 78)
        Me.EmptySpaceItem156.MaxSize = New System.Drawing.Size(43, 26)
        Me.EmptySpaceItem156.MinSize = New System.Drawing.Size(43, 26)
        Me.EmptySpaceItem156.Name = "EmptySpaceItem156"
        Me.EmptySpaceItem156.Size = New System.Drawing.Size(43, 26)
        Me.EmptySpaceItem156.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem156.Text = " "
        Me.EmptySpaceItem156.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem156.TextVisible = True
        '
        'LayoutControlItem72
        '
        Me.LayoutControlItem72.Control = Me.free_kd1
        Me.LayoutControlItem72.CustomizationFormText = "LayoutControlItem72"
        Me.LayoutControlItem72.Location = New System.Drawing.Point(179, 26)
        Me.LayoutControlItem72.MaxSize = New System.Drawing.Size(157, 26)
        Me.LayoutControlItem72.MinSize = New System.Drawing.Size(157, 26)
        Me.LayoutControlItem72.Name = "LayoutControlItem72"
        Me.LayoutControlItem72.Size = New System.Drawing.Size(157, 26)
        Me.LayoutControlItem72.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem72.Text = "LayoutControlItem72"
        Me.LayoutControlItem72.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem72.TextToControlDistance = 0
        Me.LayoutControlItem72.TextVisible = False
        '
        'LayoutControlItem73
        '
        Me.LayoutControlItem73.Control = Me.free_kd2
        Me.LayoutControlItem73.CustomizationFormText = "LayoutControlItem73"
        Me.LayoutControlItem73.Location = New System.Drawing.Point(179, 52)
        Me.LayoutControlItem73.MaxSize = New System.Drawing.Size(157, 26)
        Me.LayoutControlItem73.MinSize = New System.Drawing.Size(157, 26)
        Me.LayoutControlItem73.Name = "LayoutControlItem73"
        Me.LayoutControlItem73.Size = New System.Drawing.Size(157, 26)
        Me.LayoutControlItem73.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem73.Text = "LayoutControlItem73"
        Me.LayoutControlItem73.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem73.TextToControlDistance = 0
        Me.LayoutControlItem73.TextVisible = False
        '
        'EmptySpaceItem157
        '
        Me.EmptySpaceItem157.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem157.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem157.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem157.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem157.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem157.CustomizationFormText = "수입금액제외"
        Me.EmptySpaceItem157.Location = New System.Drawing.Point(179, 78)
        Me.EmptySpaceItem157.MaxSize = New System.Drawing.Size(157, 26)
        Me.EmptySpaceItem157.MinSize = New System.Drawing.Size(157, 26)
        Me.EmptySpaceItem157.Name = "EmptySpaceItem157"
        Me.EmptySpaceItem157.Size = New System.Drawing.Size(157, 26)
        Me.EmptySpaceItem157.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem157.Text = "수입금액제외"
        Me.EmptySpaceItem157.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem157.TextVisible = True
        '
        'LayoutControlItem74
        '
        Me.LayoutControlItem74.Control = Me.free_ty1
        Me.LayoutControlItem74.CustomizationFormText = "LayoutControlItem74"
        Me.LayoutControlItem74.Location = New System.Drawing.Point(336, 26)
        Me.LayoutControlItem74.MaxSize = New System.Drawing.Size(200, 26)
        Me.LayoutControlItem74.MinSize = New System.Drawing.Size(200, 26)
        Me.LayoutControlItem74.Name = "LayoutControlItem74"
        Me.LayoutControlItem74.Size = New System.Drawing.Size(200, 26)
        Me.LayoutControlItem74.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem74.Text = "LayoutControlItem74"
        Me.LayoutControlItem74.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem74.TextToControlDistance = 0
        Me.LayoutControlItem74.TextVisible = False
        '
        'LayoutControlItem76
        '
        Me.LayoutControlItem76.Control = Me.free_ty2
        Me.LayoutControlItem76.CustomizationFormText = "LayoutControlItem76"
        Me.LayoutControlItem76.Location = New System.Drawing.Point(336, 52)
        Me.LayoutControlItem76.MaxSize = New System.Drawing.Size(200, 26)
        Me.LayoutControlItem76.MinSize = New System.Drawing.Size(200, 26)
        Me.LayoutControlItem76.Name = "LayoutControlItem76"
        Me.LayoutControlItem76.Size = New System.Drawing.Size(200, 26)
        Me.LayoutControlItem76.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem76.Text = "LayoutControlItem76"
        Me.LayoutControlItem76.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem76.TextToControlDistance = 0
        Me.LayoutControlItem76.TextVisible = False
        '
        'EmptySpaceItem150
        '
        Me.EmptySpaceItem150.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem150.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem150.CustomizationFormText = "EmptySpaceItem150"
        Me.EmptySpaceItem150.Location = New System.Drawing.Point(536, 26)
        Me.EmptySpaceItem150.MaxSize = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem150.MinSize = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem150.Name = "EmptySpaceItem150"
        Me.EmptySpaceItem150.Size = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem150.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem150.Text = " "
        Me.EmptySpaceItem150.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem150.TextVisible = True
        '
        'EmptySpaceItem158
        '
        Me.EmptySpaceItem158.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem158.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem158.CustomizationFormText = " "
        Me.EmptySpaceItem158.Location = New System.Drawing.Point(556, 26)
        Me.EmptySpaceItem158.MaxSize = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem158.MinSize = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem158.Name = "EmptySpaceItem158"
        Me.EmptySpaceItem158.Size = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem158.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem158.Text = " "
        Me.EmptySpaceItem158.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem158.TextVisible = True
        '
        'EmptySpaceItem160
        '
        Me.EmptySpaceItem160.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem160.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem160.CustomizationFormText = " "
        Me.EmptySpaceItem160.Location = New System.Drawing.Point(576, 26)
        Me.EmptySpaceItem160.MaxSize = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem160.MinSize = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem160.Name = "EmptySpaceItem160"
        Me.EmptySpaceItem160.Size = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem160.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem160.Text = " "
        Me.EmptySpaceItem160.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem160.TextVisible = True
        '
        'EmptySpaceItem159
        '
        Me.EmptySpaceItem159.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem159.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem159.CustomizationFormText = " "
        Me.EmptySpaceItem159.Location = New System.Drawing.Point(596, 26)
        Me.EmptySpaceItem159.MaxSize = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem159.MinSize = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem159.Name = "EmptySpaceItem159"
        Me.EmptySpaceItem159.Size = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem159.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem159.Text = " "
        Me.EmptySpaceItem159.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem159.TextVisible = True
        '
        'LayoutControlItem78
        '
        Me.LayoutControlItem78.Control = Me.free_amt1
        Me.LayoutControlItem78.CustomizationFormText = "LayoutControlItem78"
        Me.LayoutControlItem78.Location = New System.Drawing.Point(636, 26)
        Me.LayoutControlItem78.MaxSize = New System.Drawing.Size(218, 26)
        Me.LayoutControlItem78.MinSize = New System.Drawing.Size(218, 26)
        Me.LayoutControlItem78.Name = "LayoutControlItem78"
        Me.LayoutControlItem78.Size = New System.Drawing.Size(218, 26)
        Me.LayoutControlItem78.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem78.Text = "LayoutControlItem78"
        Me.LayoutControlItem78.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem78.TextToControlDistance = 0
        Me.LayoutControlItem78.TextVisible = False
        '
        'EmptySpaceItem161
        '
        Me.EmptySpaceItem161.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem161.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem161.CustomizationFormText = " "
        Me.EmptySpaceItem161.Location = New System.Drawing.Point(536, 52)
        Me.EmptySpaceItem161.MaxSize = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem161.MinSize = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem161.Name = "EmptySpaceItem161"
        Me.EmptySpaceItem161.Size = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem161.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem161.Text = " "
        Me.EmptySpaceItem161.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem161.TextVisible = True
        '
        'LayoutControlItem77
        '
        Me.LayoutControlItem77.Control = Me.free_ty3
        Me.LayoutControlItem77.CustomizationFormText = "LayoutControlItem77"
        Me.LayoutControlItem77.Location = New System.Drawing.Point(336, 78)
        Me.LayoutControlItem77.MaxSize = New System.Drawing.Size(200, 26)
        Me.LayoutControlItem77.MinSize = New System.Drawing.Size(200, 26)
        Me.LayoutControlItem77.Name = "LayoutControlItem77"
        Me.LayoutControlItem77.Size = New System.Drawing.Size(200, 26)
        Me.LayoutControlItem77.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem77.Text = "LayoutControlItem77"
        Me.LayoutControlItem77.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem77.TextToControlDistance = 0
        Me.LayoutControlItem77.TextVisible = False
        '
        'EmptySpaceItem162
        '
        Me.EmptySpaceItem162.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem162.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem162.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem162.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem162.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem162.CustomizationFormText = "합         계"
        Me.EmptySpaceItem162.Location = New System.Drawing.Point(536, 104)
        Me.EmptySpaceItem162.MaxSize = New System.Drawing.Size(100, 26)
        Me.EmptySpaceItem162.MinSize = New System.Drawing.Size(100, 26)
        Me.EmptySpaceItem162.Name = "EmptySpaceItem162"
        Me.EmptySpaceItem162.Size = New System.Drawing.Size(100, 26)
        Me.EmptySpaceItem162.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem162.Text = "합         계"
        Me.EmptySpaceItem162.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem162.TextVisible = True
        '
        'EmptySpaceItem163
        '
        Me.EmptySpaceItem163.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem163.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem163.CustomizationFormText = " "
        Me.EmptySpaceItem163.Location = New System.Drawing.Point(556, 52)
        Me.EmptySpaceItem163.MaxSize = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem163.MinSize = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem163.Name = "EmptySpaceItem163"
        Me.EmptySpaceItem163.Size = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem163.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem163.Text = " "
        Me.EmptySpaceItem163.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem163.TextVisible = True
        '
        'EmptySpaceItem164
        '
        Me.EmptySpaceItem164.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem164.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem164.CustomizationFormText = " "
        Me.EmptySpaceItem164.Location = New System.Drawing.Point(576, 52)
        Me.EmptySpaceItem164.MaxSize = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem164.MinSize = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem164.Name = "EmptySpaceItem164"
        Me.EmptySpaceItem164.Size = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem164.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem164.Text = " "
        Me.EmptySpaceItem164.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem164.TextVisible = True
        '
        'EmptySpaceItem165
        '
        Me.EmptySpaceItem165.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem165.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem165.CustomizationFormText = " "
        Me.EmptySpaceItem165.Location = New System.Drawing.Point(596, 52)
        Me.EmptySpaceItem165.MaxSize = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem165.MinSize = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem165.Name = "EmptySpaceItem165"
        Me.EmptySpaceItem165.Size = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem165.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem165.Text = " "
        Me.EmptySpaceItem165.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem165.TextVisible = True
        '
        'EmptySpaceItem166
        '
        Me.EmptySpaceItem166.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem166.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem166.CustomizationFormText = " "
        Me.EmptySpaceItem166.Location = New System.Drawing.Point(536, 78)
        Me.EmptySpaceItem166.MaxSize = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem166.MinSize = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem166.Name = "EmptySpaceItem166"
        Me.EmptySpaceItem166.Size = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem166.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem166.Text = " "
        Me.EmptySpaceItem166.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem166.TextVisible = True
        '
        'EmptySpaceItem167
        '
        Me.EmptySpaceItem167.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem167.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem167.CustomizationFormText = " "
        Me.EmptySpaceItem167.Location = New System.Drawing.Point(556, 78)
        Me.EmptySpaceItem167.MaxSize = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem167.MinSize = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem167.Name = "EmptySpaceItem167"
        Me.EmptySpaceItem167.Size = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem167.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem167.Text = " "
        Me.EmptySpaceItem167.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem167.TextVisible = True
        '
        'EmptySpaceItem168
        '
        Me.EmptySpaceItem168.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem168.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem168.CustomizationFormText = " "
        Me.EmptySpaceItem168.Location = New System.Drawing.Point(576, 78)
        Me.EmptySpaceItem168.MaxSize = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem168.MinSize = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem168.Name = "EmptySpaceItem168"
        Me.EmptySpaceItem168.Size = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem168.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem168.Text = " "
        Me.EmptySpaceItem168.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem168.TextVisible = True
        '
        'EmptySpaceItem169
        '
        Me.EmptySpaceItem169.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem169.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem169.CustomizationFormText = " "
        Me.EmptySpaceItem169.Location = New System.Drawing.Point(596, 78)
        Me.EmptySpaceItem169.MaxSize = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem169.MinSize = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem169.Name = "EmptySpaceItem169"
        Me.EmptySpaceItem169.Size = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem169.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem169.Text = " "
        Me.EmptySpaceItem169.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem169.TextVisible = True
        '
        'LayoutControlItem79
        '
        Me.LayoutControlItem79.Control = Me.free_amt2
        Me.LayoutControlItem79.CustomizationFormText = "LayoutControlItem79"
        Me.LayoutControlItem79.Location = New System.Drawing.Point(636, 52)
        Me.LayoutControlItem79.MaxSize = New System.Drawing.Size(218, 26)
        Me.LayoutControlItem79.MinSize = New System.Drawing.Size(218, 26)
        Me.LayoutControlItem79.Name = "LayoutControlItem79"
        Me.LayoutControlItem79.Size = New System.Drawing.Size(218, 26)
        Me.LayoutControlItem79.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem79.Text = "LayoutControlItem79"
        Me.LayoutControlItem79.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem79.TextToControlDistance = 0
        Me.LayoutControlItem79.TextVisible = False
        '
        'LayoutControlItem80
        '
        Me.LayoutControlItem80.Control = Me.free_amt3
        Me.LayoutControlItem80.CustomizationFormText = "LayoutControlItem80"
        Me.LayoutControlItem80.Location = New System.Drawing.Point(636, 78)
        Me.LayoutControlItem80.MaxSize = New System.Drawing.Size(218, 26)
        Me.LayoutControlItem80.MinSize = New System.Drawing.Size(218, 26)
        Me.LayoutControlItem80.Name = "LayoutControlItem80"
        Me.LayoutControlItem80.Size = New System.Drawing.Size(218, 26)
        Me.LayoutControlItem80.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem80.Text = "LayoutControlItem80"
        Me.LayoutControlItem80.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem80.TextToControlDistance = 0
        Me.LayoutControlItem80.TextVisible = False
        '
        'EmptySpaceItem148
        '
        Me.EmptySpaceItem148.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem148.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem148.CustomizationFormText = " "
        Me.EmptySpaceItem148.Location = New System.Drawing.Point(616, 78)
        Me.EmptySpaceItem148.MaxSize = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem148.MinSize = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem148.Name = "EmptySpaceItem148"
        Me.EmptySpaceItem148.Size = New System.Drawing.Size(20, 26)
        Me.EmptySpaceItem148.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem148.Text = " "
        Me.EmptySpaceItem148.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem148.TextVisible = True
        '
        'EmptySpaceItem170
        '
        Me.EmptySpaceItem170.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem170.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem170.CustomizationFormText = " "
        Me.EmptySpaceItem170.Location = New System.Drawing.Point(136, 104)
        Me.EmptySpaceItem170.MaxSize = New System.Drawing.Size(200, 26)
        Me.EmptySpaceItem170.MinSize = New System.Drawing.Size(200, 26)
        Me.EmptySpaceItem170.Name = "EmptySpaceItem170"
        Me.EmptySpaceItem170.Size = New System.Drawing.Size(200, 26)
        Me.EmptySpaceItem170.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem170.Text = " "
        Me.EmptySpaceItem170.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem170.TextVisible = True
        '
        'EmptySpaceItem171
        '
        Me.EmptySpaceItem171.AppearanceItemCaption.BackColor = System.Drawing.Color.Silver
        Me.EmptySpaceItem171.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem171.CustomizationFormText = " "
        Me.EmptySpaceItem171.Location = New System.Drawing.Point(336, 104)
        Me.EmptySpaceItem171.MaxSize = New System.Drawing.Size(200, 26)
        Me.EmptySpaceItem171.MinSize = New System.Drawing.Size(200, 26)
        Me.EmptySpaceItem171.Name = "EmptySpaceItem171"
        Me.EmptySpaceItem171.Size = New System.Drawing.Size(200, 26)
        Me.EmptySpaceItem171.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem171.Text = " "
        Me.EmptySpaceItem171.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem171.TextVisible = True
        '
        'LayoutControlItem81
        '
        Me.LayoutControlItem81.Control = Me.free_sum_amt
        Me.LayoutControlItem81.CustomizationFormText = "LayoutControlItem81"
        Me.LayoutControlItem81.Location = New System.Drawing.Point(636, 104)
        Me.LayoutControlItem81.MaxSize = New System.Drawing.Size(218, 26)
        Me.LayoutControlItem81.MinSize = New System.Drawing.Size(218, 26)
        Me.LayoutControlItem81.Name = "LayoutControlItem81"
        Me.LayoutControlItem81.Size = New System.Drawing.Size(218, 26)
        Me.LayoutControlItem81.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem81.Text = "LayoutControlItem81"
        Me.LayoutControlItem81.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem81.TextToControlDistance = 0
        Me.LayoutControlItem81.TextVisible = False
        '
        'EmptySpaceItem146
        '
        Me.EmptySpaceItem146.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem146.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem146.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem146.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem146.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem146.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.EmptySpaceItem146.CustomizationFormText = "EmptySpaceItem146"
        Me.EmptySpaceItem146.Location = New System.Drawing.Point(0, 1232)
        Me.EmptySpaceItem146.Name = "EmptySpaceItem146"
        Me.EmptySpaceItem146.Size = New System.Drawing.Size(188, 52)
        Me.EmptySpaceItem146.Text = "계산서 교부                          및 수취명세"
        Me.EmptySpaceItem146.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem146.TextVisible = True
        '
        'EmptySpaceItem172
        '
        Me.EmptySpaceItem172.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem172.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem172.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem172.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem172.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem172.CustomizationFormText = "EmptySpaceItem172"
        Me.EmptySpaceItem172.Location = New System.Drawing.Point(188, 1232)
        Me.EmptySpaceItem172.MaxSize = New System.Drawing.Size(0, 26)
        Me.EmptySpaceItem172.MinSize = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem172.Name = "EmptySpaceItem172"
        Me.EmptySpaceItem172.Size = New System.Drawing.Size(340, 26)
        Me.EmptySpaceItem172.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem172.Text = "계산서 교부금액"
        Me.EmptySpaceItem172.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem172.TextVisible = True
        '
        'EmptySpaceItem173
        '
        Me.EmptySpaceItem173.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem173.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem173.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem173.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem173.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem173.CustomizationFormText = "EmptySpaceItem173"
        Me.EmptySpaceItem173.Location = New System.Drawing.Point(188, 1258)
        Me.EmptySpaceItem173.Name = "EmptySpaceItem173"
        Me.EmptySpaceItem173.Size = New System.Drawing.Size(340, 26)
        Me.EmptySpaceItem173.Text = "계산서 교부금액"
        Me.EmptySpaceItem173.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem173.TextVisible = True
        '
        'EmptySpaceItem174
        '
        Me.EmptySpaceItem174.CustomizationFormText = "EmptySpaceItem174"
        Me.EmptySpaceItem174.Location = New System.Drawing.Point(0, 1284)
        Me.EmptySpaceItem174.Name = "EmptySpaceItem174"
        Me.EmptySpaceItem174.Size = New System.Drawing.Size(1129, 10)
        Me.EmptySpaceItem174.Text = "EmptySpaceItem174"
        Me.EmptySpaceItem174.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem82
        '
        Me.LayoutControlItem82.Control = Me.notax_out
        Me.LayoutControlItem82.CustomizationFormText = "LayoutControlItem82"
        Me.LayoutControlItem82.Location = New System.Drawing.Point(528, 1232)
        Me.LayoutControlItem82.Name = "LayoutControlItem82"
        Me.LayoutControlItem82.Size = New System.Drawing.Size(350, 26)
        Me.LayoutControlItem82.Text = "LayoutControlItem82"
        Me.LayoutControlItem82.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem82.TextToControlDistance = 0
        Me.LayoutControlItem82.TextVisible = False
        '
        'LayoutControlItem83
        '
        Me.LayoutControlItem83.Control = Me.notax_in
        Me.LayoutControlItem83.CustomizationFormText = "LayoutControlItem83"
        Me.LayoutControlItem83.Location = New System.Drawing.Point(528, 1258)
        Me.LayoutControlItem83.MaxSize = New System.Drawing.Size(350, 26)
        Me.LayoutControlItem83.MinSize = New System.Drawing.Size(350, 26)
        Me.LayoutControlItem83.Name = "LayoutControlItem83"
        Me.LayoutControlItem83.Size = New System.Drawing.Size(350, 26)
        Me.LayoutControlItem83.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem83.Text = "LayoutControlItem83"
        Me.LayoutControlItem83.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem83.TextToControlDistance = 0
        Me.LayoutControlItem83.TextVisible = False
        '
        'EmptySpaceItem175
        '
        Me.EmptySpaceItem175.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem175.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem175.CustomizationFormText = " "
        Me.EmptySpaceItem175.Location = New System.Drawing.Point(349, 222)
        Me.EmptySpaceItem175.MaxSize = New System.Drawing.Size(236, 28)
        Me.EmptySpaceItem175.MinSize = New System.Drawing.Size(236, 28)
        Me.EmptySpaceItem175.Name = "EmptySpaceItem175"
        Me.EmptySpaceItem175.Size = New System.Drawing.Size(236, 28)
        Me.EmptySpaceItem175.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem175.Text = " "
        Me.EmptySpaceItem175.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem175.TextVisible = True
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cmdsale_miss
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(28, 196)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(285, 26)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cmdbuy_miss
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(28, 330)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(285, 26)
        Me.LayoutControlItem9.Text = "LayoutControlItem9"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextToControlDistance = 0
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.cmdetc
        Me.LayoutControlItem18.CustomizationFormText = "LayoutControlItem18"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(28, 382)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(285, 26)
        Me.LayoutControlItem18.Text = "LayoutControlItem18"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextToControlDistance = 0
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.cmddedu
        Me.LayoutControlItem19.CustomizationFormText = "LayoutControlItem19"
        Me.LayoutControlItem19.Location = New System.Drawing.Point(28, 434)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(285, 26)
        Me.LayoutControlItem19.Text = "LayoutControlItem19"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextToControlDistance = 0
        Me.LayoutControlItem19.TextVisible = False
        '
        'EmptySpaceItem44
        '
        Me.EmptySpaceItem44.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmptySpaceItem44.AppearanceItemCaption.Options.UseBackColor = True
        Me.EmptySpaceItem44.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem44.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem44.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem44.CustomizationFormText = "16"
        Me.EmptySpaceItem44.Location = New System.Drawing.Point(313, 434)
        Me.EmptySpaceItem44.MaxSize = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem44.MinSize = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem44.Name = "EmptySpaceItem44"
        Me.EmptySpaceItem44.Size = New System.Drawing.Size(36, 26)
        Me.EmptySpaceItem44.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem44.Text = "16"
        Me.EmptySpaceItem44.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem44.TextVisible = True
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.cmdetc_dedu
        Me.LayoutControlItem20.CustomizationFormText = "LayoutControlItem20"
        Me.LayoutControlItem20.Location = New System.Drawing.Point(104, 512)
        Me.LayoutControlItem20.MaxSize = New System.Drawing.Size(209, 26)
        Me.LayoutControlItem20.MinSize = New System.Drawing.Size(209, 26)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(209, 26)
        Me.LayoutControlItem20.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem20.Text = "LayoutControlItem20"
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem20.TextToControlDistance = 0
        Me.LayoutControlItem20.TextVisible = False
        '
        'LayoutControlItem38
        '
        Me.LayoutControlItem38.Control = Me.cmdadd
        Me.LayoutControlItem38.CustomizationFormText = "LayoutControlItem38"
        Me.LayoutControlItem38.Location = New System.Drawing.Point(0, 668)
        Me.LayoutControlItem38.MaxSize = New System.Drawing.Size(313, 26)
        Me.LayoutControlItem38.MinSize = New System.Drawing.Size(313, 26)
        Me.LayoutControlItem38.Name = "LayoutControlItem38"
        Me.LayoutControlItem38.Size = New System.Drawing.Size(313, 26)
        Me.LayoutControlItem38.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem38.Text = "LayoutControlItem38"
        Me.LayoutControlItem38.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem38.TextToControlDistance = 0
        Me.LayoutControlItem38.TextVisible = False
        '
        'FAC600
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FAC600"
        Me.Size = New System.Drawing.Size(1166, 795)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem55, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem57, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem58, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem59, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem60, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem64, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem65, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem66, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem67, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem68, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem69, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem70, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem71, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem72, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem73, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem74, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem75, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem76, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem77, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem78, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem79, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem80, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem81, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem82, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem83, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem84, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem85, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem86, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem87, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem88, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem89, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem90, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem91, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem92, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem93, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem99, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem95, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem96, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem97, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem98, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem100, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem101, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem55, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem103, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem105, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem106, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem107, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem108, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem109, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem57, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem58, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem111, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem104, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem112, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem113, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem114, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem115, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem59, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem110, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem60, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem118, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem119, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem120, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem117, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem121, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem123, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem122, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem62, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem124, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem116, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem63, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem64, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem125, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem127, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem128, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem126, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem129, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem65, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem130, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem67, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem134, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem132, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem133, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem131, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem136, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem137, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem66, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem138, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem94, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem139, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem140, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem141, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem68, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem102, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem135, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem143, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem144, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem69, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem70, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem71, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem142, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem145, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem147, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem151, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem152, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem153, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem154, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem149, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem155, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem156, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem72, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem73, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem157, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem74, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem76, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem150, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem158, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem160, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem159, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem78, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem161, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem77, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem162, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem163, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem164, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem165, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem166, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem167, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem168, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem169, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem79, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem80, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem148, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem170, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem171, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem81, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem146, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem172, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem173, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem174, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem82, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem83, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem175, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents work_dt As Frame7.eDate
    Friend WithEvents tax_dtf As Frame7.eDate
    Friend WithEvents mon_bc As Frame7.eCombo
    Friend WithEvents tax_dtt As Frame7.eDate
    Friend WithEvents tax_year As Frame7.eDate
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents notax_in As Frame7.eText
    Friend WithEvents notax_out As Frame7.eText
    Friend WithEvents free_sum_amt As Frame7.eText
    Friend WithEvents free_amt3 As Frame7.eText
    Friend WithEvents free_amt2 As Frame7.eText
    Friend WithEvents free_ty2 As Frame7.eText
    Friend WithEvents free_ty1 As Frame7.eText
    Friend WithEvents free_kd2 As Frame7.eText
    Friend WithEvents free_kd1 As Frame7.eText
    Friend WithEvents free_ty3 As Frame7.eText
    Friend WithEvents agent_tel As Frame7.eText
    Friend WithEvents agent_no As Frame7.eText
    Friend WithEvents agent_nm As Frame7.eText
    Friend WithEvents tax_sum_amt As Frame7.eText
    Friend WithEvents tax_amt4 As Frame7.eText
    Friend WithEvents tax_ty4 As Frame7.eText
    Friend WithEvents tax_amt3 As Frame7.eText
    Friend WithEvents tax_ty3 As Frame7.eText
    Friend WithEvents tax_kd3 As Frame7.eText
    Friend WithEvents tax_ty2 As Frame7.eText
    Friend WithEvents tax_amt2 As Frame7.eText
    Friend WithEvents tax_kd2 As Frame7.eText
    Friend WithEvents tax_amt1 As Frame7.eText
    Friend WithEvents tax_ty1 As Frame7.eText
    Friend WithEvents tax_kd1 As Frame7.eText
    Friend WithEvents close_rmk As Frame7.eText
    Friend WithEvents close_dt As Frame7.eText
    Friend WithEvents acct_no As Frame7.eText
    Friend WithEvents bank_loc As Frame7.eText
    Friend WithEvents bank_cd As Frame7.eText
    Friend WithEvents vat As Frame7.eText
    Friend WithEvents result_vat As Frame7.eText
    Friend WithEvents add_vat As Frame7.eText
    Friend WithEvents spc_vat As Frame7.eText
    Friend WithEvents plan_amt As Frame7.eText
    Friend WithEvents non_repay As Frame7.eText
    Friend WithEvents dedu_vat As Frame7.eText
    Friend WithEvents card_vat As Frame7.eText
    Friend WithEvents card_amt As Frame7.eText
    Friend WithEvents etc_vat As Frame7.eText
    Friend WithEvents give_amt As Frame7.eText
    Friend WithEvents buy_chakam_vat As Frame7.eText
    Friend WithEvents no_dedu_vat As Frame7.eText
    Friend WithEvents buy_tot_vat As Frame7.eText
    Friend WithEvents buy_etc_vat As Frame7.eText
    Friend WithEvents buy_iss_vat As Frame7.eText
    Friend WithEvents buy_miss_vat As Frame7.eText
    Friend WithEvents ast_vat As Frame7.eText
    Friend WithEvents buy_vat As Frame7.eText
    Friend WithEvents buy_chakam_amt As Frame7.eText
    Friend WithEvents no_dedu_amt As Frame7.eText
    Friend WithEvents buy_tot_amt As Frame7.eText
    Friend WithEvents buy_etc_amt As Frame7.eText
    Friend WithEvents buy_iss_amt As Frame7.eText
    Friend WithEvents buy_miss_amt As Frame7.eText
    Friend WithEvents ast_amt As Frame7.eText
    Friend WithEvents buy_amt As Frame7.eText
    Friend WithEvents sale_miss_vat As Frame7.eText
    Friend WithEvents bad_vat As Frame7.eText
    Friend WithEvents sale_tot_vat As Frame7.eText
    Friend WithEvents sale_etc_vat As Frame7.eText
    Friend WithEvents sale_card_vat As Frame7.eText
    Friend WithEvents sale_iss_vat As Frame7.eText
    Friend WithEvents sale_vat As Frame7.eText
    Friend WithEvents sale_tot_amt As Frame7.eText
    Friend WithEvents sale_miss_amt As Frame7.eText
    Friend WithEvents sale_zero_etc_amt As Frame7.eText
    Friend WithEvents sale_zero_amt As Frame7.eText
    Friend WithEvents sale_etc_amt As Frame7.eText
    Friend WithEvents sale_card_amt As Frame7.eText
    Friend WithEvents sale_iss_amt As Frame7.eText
    Friend WithEvents sale_amt As Frame7.eText
    Friend WithEvents free_amt1 As Frame7.eText
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem9 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem10 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem11 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem12 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem13 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem14 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem15 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem16 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem17 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem18 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem19 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem20 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem21 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem22 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem25 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem23 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem26 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem28 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem29 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem30 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem31 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem33 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem27 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem34 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem35 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem32 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem24 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem36 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem37 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem38 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem39 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem40 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem41 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem43 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem45 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem46 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem48 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem49 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem50 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem51 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem52 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem47 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem42 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem44 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem53 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem54 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem55 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem57 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem58 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem59 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem60 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem33 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem34 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem35 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem36 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem61 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem64 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem37 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem65 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem66 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem67 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem68 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem69 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem70 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem71 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem72 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem73 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem74 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem75 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem76 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem39 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem77 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem78 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem79 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem80 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem40 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem41 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem81 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem42 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem82 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem83 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem84 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem43 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem85 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem86 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem87 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem44 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem88 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem89 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem90 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem45 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem91 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem92 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem47 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem93 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem48 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem49 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem56 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem99 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem95 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem96 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem97 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem98 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem50 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem53 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem54 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem100 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem101 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem55 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem56 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem103 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem105 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem106 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem107 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem108 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem109 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem57 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem58 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem111 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem104 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem112 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem113 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem114 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem115 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem59 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem110 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem60 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem61 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem118 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem119 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem120 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem117 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem121 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem123 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem122 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem62 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem124 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem116 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem63 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem64 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem125 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem127 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem128 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem126 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem129 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem65 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem130 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem67 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem134 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem132 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem133 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem131 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem136 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem137 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem66 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem138 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem94 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem139 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem140 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem141 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem68 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem102 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem135 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem143 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem144 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem69 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem70 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem71 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem142 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem145 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem147 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem151 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem152 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem153 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem154 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem149 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem155 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem156 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem72 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem73 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem157 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem74 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem76 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem150 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem158 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem160 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem159 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem78 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem161 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem77 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem162 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem163 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem164 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem165 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem166 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem167 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem168 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem169 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem79 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem80 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem148 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem170 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem171 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem81 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem146 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem172 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem173 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem174 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem82 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem83 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem175 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents doc_bc As Frame7.eCombo
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents bs_cd As Frame7.eCombo
    Friend WithEvents cmdsale_miss As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdbuy_miss As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdetc_dedu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdetc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmddedu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdadd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem38 As DevExpress.XtraLayout.LayoutControlItem

End Class
