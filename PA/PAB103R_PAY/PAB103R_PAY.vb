Public Class PAB103R_PAY

    Public Sub New()
        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()
        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
    End Sub

    Public Sub New(ByVal dSet As DataSet)
        InitializeComponent()
        Me.SetDateSet(dSet)
    End Sub

    Public Sub SetDateSet(ByVal dSet As DataSet)

        Me.DataSource = dSet

        '그룹핑
        Dim groupField1 = New DevExpress.XtraReports.UI.GroupField("emp_no")

        Me.GroupHeader1.GroupFields.Add(groupField1)


        paynm.DataBindings.Add("Text", dSet.Tables(0), "paynm")
        bs_nm.DataBindings.Add("Text", dSet.Tables(0), "bs_nm")
        dept_nm.DataBindings.Add("Text", dSet.Tables(0), "dept_nm")
        emp_no.DataBindings.Add("Text", dSet.Tables(0), "emp_no")
        emp_nm.DataBindings.Add("Text", dSet.Tables(0), "emp_nm")
        duty_nm.DataBindings.Add("Text", dSet.Tables(0), "duty_nm")
        step_nm.DataBindings.Add("Text", dSet.Tables(0), "step_nm")
        pay_cap.DataBindings.Add("Text", dSet.Tables(0), "pay_cap")
        pay_amt.DataBindings.Add("Text", dSet.Tables(0), "pay_amt", "{0:#,#}")
        del_cap.DataBindings.Add("Text", dSet.Tables(0), "del_cap")
        del_amt.DataBindings.Add("Text", dSet.Tables(0), "del_amt", "{0:#,#}")

        inout_cap.DataBindings.Add("Text", dSet.Tables(0), "inout_cap")
        inout_val.DataBindings.Add("Text", dSet.Tables(0), "inout_val", "{0:#,#.#}")

        pay.DataBindings.Add("Text", dSet.Tables(0), "pay", "{0:#,#}")

        tot_pay_amt.Text = String.Format("{0:#,#}", dSet.Tables(0).Compute("SUM(pay_amt)", String.Empty))
        tot_del_amt.Text = String.Format("{0:#,#}", dSet.Tables(0).Compute("SUM(del_amt)", String.Empty))
        tot_inout_val.Text = String.Format("{0:#,#.#}", dSet.Tables(0).Compute("SUM(inout_val)", String.Empty))




    End Sub



End Class