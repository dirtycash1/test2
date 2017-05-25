Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class PIP120

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        '수출 File번호 채번
        bl_mngno.CodeNo = "PIP120"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        bl_mngno.CodeDateField = bl_dt
        Me.Open_Form()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty
            Case MenuType.Open

                Me.Open_Form()

            Case MenuType.Save
                If Save_BeforeCheck() Then
                    Me.Save_Form()
                End If

            Case MenuType.Delete

                Me.Delete_Form()

            Case MenuType.New

                Me.New_Form()

            Case MenuType.Print
                ' Me.Print()
            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Private Sub Open_Form()
        in_no.Text = ""
        Dim poNo As String = bl_mngnoq.Text
        Me.Open()
        g20.Find("bl_mngno=" + poNo)
    End Sub

    Public Sub Open2(GetOutNo As String)
        in_no.Text = GetOutNo
        If GetOutNo <> "" Then
            Dim FrDt As Date = GetOutNo.Substring(0, 4) & "-" & GetOutNo.Substring(4, 2) & "-" & GetOutNo.Substring(6, 2)
            FrDt = DateAdd(DateInterval.Month, -3, FrDt)
            fr_dt.Text = FrDt.ToShortDateString
        End If
        Me.Open()
    End Sub

    Private Sub New_Form()
        'Me.Open_Form()

        bl_mngno.Text = ""
        Me.Open("PIP120_f10")
        Me.Open("PIP120_g10")

    End Sub

    Private Sub Save_Form()

        work_ty.Text = "none"

        Me.CompAmt()
        'If Me.progress_bc.Text <> "" And Me.progress_bc.Text <> "SE19010" Then
        '    MessageBox.Show("수출 마스터건의 후행(출고처리,b/l처리)작업이 진행되어 수정이 불가능합니다", "확인", MessageBoxButtons.OK)
        '    Exit Sub
        'End If

        'For ii As Integer = 0 To g20.DataSet.Tables(0).Rows.Count - 1
        '    g20.Text("fac_cd", ii) = fac_cd.Text
        'Next
        'For ii As Integer = 0 To g20.DataSet.Tables(0).Rows.Count - 1
        '    g20.Text("wh_cd", ii) = wh_cd.Text
        'Next
        If MyBase.Save() Then
            Open_Form()
        End If
    End Sub

    Private Sub Delete_Form()


        'Me.CompAmt()
        If Me.progclss_bc.Text <> "" And Me.progclss_bc.Text <> "PI23010" Then
            MessageBox.Show("수출 마스터건의 후행(출고처리,b/l처리)작업이 진행되어 삭제가 불가능합니다", "확인", MessageBoxButtons.OK)
            Exit Sub
        End If

        If MyBase.Delete("PIP120_f10") Then
            Open_Form()
        End If

    End Sub


    '환율적용일이 바뀌면 환율을 자동으로 끌어온다
    '환율 구하는 데이타셋
    Private Sub GetExchRt()

        Dim p As New OpenParameters
        Dim Rt As Decimal

        p.Add("@std_dt", bl_dt.Text)
        p.Add("@cury_bc", cury_bc.Text)

        Dim dSet As DataSet = OpenDataSet("sep210_excht", p)

        If Not IsEmpty(dSet) Then
            Rt = DataValue(dSet, "ttm_rt")
        Else
            Rt = "1"
        End If

        ex_rt.Text = Rt

    End Sub

    Private Sub cury_bc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GetExchRt()

    End Sub

    Private Sub podate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GetExchRt()
    End Sub

    Private Function Save_BeforeCheck() As Boolean
        'If pay_bc.Text = "10" Then  'l/c인 경우에는 
        '    If Not CheckRequired(Me.note_no, Me.note_dt) Then
        '        Return False
        '    Else
        Return True
        '    End If
        'End If
    End Function

    Private Sub g10_popup(ByVal sender As Object, ByVal e As System.EventArgs)

        If Not CheckRequired(Me.bl_dt, Me.cury_bc) Then
            Exit Sub
        End If

    End Sub

    'Private Sub g10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.Click

    '    Me.Open("PIP120_f10")
    '    Me.Open("PIP120_g20")
    'End Sub


    'Private Sub g20_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g20.CellValueChanging

    '    If ColumnName = "qty" Or ColumnName = "up" Then
    '        ' 기준활율 매출
    '        If ToDec(Value) > 0 Then
    '            'g20.UpdateRow()
    '            Select Case ColumnName
    '                Case "qty"
    '                    g20.Text("famt") = Value * g20.ToDec("up")
    '                    g20.Text("amt") = Value * g20.ToDec("up") * ToDec(ex_rt.Text)
    '                Case "up"
    '                    g20.Text("famt") = Value * g20.ToDec("qty")
    '                    g20.Text("amt") = Value * g20.ToDec("qty") * ToDec(ex_rt.Text)

    '            End Select

    '            SumAmt()

    '        End If

    '    End If

    'End Sub

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        With g10
            'If ColumnName = "itm_cd" And g20.Text("itm_cd") = "" Then
            '    If Not CheckRequired(Me.bl_dt, Me.cury_bc, Me.cust_cd) Then
            '        Exit Sub
            '    End If
            'End If

            '    g20.RunPopup("itm_cd", True)
            'End If

            If ColumnName = "qty" Or ColumnName = "frn_up" Then
                .Text("frn_amt") = .ToDec("qty") * .ToDec("frn_up")
                .Text("up") = .ToDec("frn_up") * ex_rt.ToDec
                .Text("amt") = .ToDec("frn_amt") * ex_rt.ToDec
                .Text("lcqty") = .Text("qty")
                .Text("lcopenamt") = .Text("amt")
            End If

        End With

        Me.CompAmt()
    End Sub

    Private Sub ex_rt_TextChanged(ByVal sender As Object, ByVal oldValue As String)
        'amt.Text = famt.ToDec * ex_rt.ToDec

        With g10
            For i As Integer = 0 To .RowCount - 1
                If .IsDataRow(i) Then
                    .RowIndex = i
                    .Text("amt") = .ToDec("famt") * ex_rt.ToDec
                End If
            Next
        End With

        Me.CompAmt()
    End Sub

    Private Sub CompAmt()
        Dim sum_amt As Double, sum_famt As Double
        ' Dim sum_lcamt As Double
        With g10
            .UpdateRow()
            For i As Integer = 0 To .RowCount - 1
                If .IsDataRow(i) Then
                    sum_amt += .ToDec("amt", i)
                    sum_famt += .ToDec("frn_amt", i)

                End If
            Next
        End With

        amt.Text = sum_amt
        famt.Text = sum_famt
        'lcamt.Text = sum_lcamt
    End Sub

    Public Sub Open2(ByVal dSet As DataSet, ByVal pcust_cd As String, ByVal pcust_nm As String, ByVal pcury_bc As String, ByVal ppo_no As String, ByVal pex_rt As Decimal)

        Me.New_Form()
        g10.DeleteBlankRow()

        Dim i As Integer = 0
        For Each dRow As DataRow In dSet.Tables(0).Rows


            If i = 0 Then
                cust_cd.Text = pcust_cd
                cust_nm.Text = pcust_nm
                Me.cury_bc.Text = pcury_bc
                po_no.Text = ppo_no
                ex_rt.Text = pex_rt
            End If

            g10.AddNewRow()
            'g10.Text("out_no", i) = ToStr(dRow("out_no"))
            'g10.Text("out_sq", i) = ToStr(dRow("out_sq"))
            'g10.Text("itm_id") = ToDec(dRow("itm_id"))
            g10.WorkSet.DataSet.Tables(0).Rows(i)("itm_id") = ToDec(dRow("itm_id"))
            g10.Text("itm_nm") = ToStr(dRow("itm_nm"))

            g10.Text("itm_cd", i) = ToStr(dRow("itm_cd"))
            g10.Text("itm_bc") = ToStr(dRow("itm_bc"))
            g10.Text("model_cd", i) = ToStr(dRow("model_cd"))
            g10.Text("spec", i) = ToStr(dRow("spec"))
            g10.Text("um_bc", i) = ToStr(dRow("um_bc"))

            g10.Text("qty", i) = ToStr(dRow("in_qty"))
            g10.Text("rem_qty", i) = ToStr(dRow("in_qty"))
            g10.Text("frn_up", i) = ToStr(dRow("frn_up"))
            g10.Text("frn_amt", i) = ToStr(dRow("frn_amt"))
            g10.Text("up", i) = ToStr(dRow("up"))

            g10.Text("amt", i) = ToStr(dRow("amt"))
            g10.Text("up", i) = ToStr(dRow("up"))
            g10.Text("po_no", i) = ppo_no
            g10.Text("po_sq", i) = ToDec(dRow("po_sq"))
            'g10.WorkSet.DataSet.Tables(0).Rows(i)("po_sq") 
            '출고공장,창고
            'g10.Text("fac_cd", i) = ToStr(dRow("fac_cd"))
            'g10.Text("wh_cd", i) = ToStr(dRow("wh_cd"))
            g10.Text("stkaccno", i) = ToStr(dRow("stkaccno"))
            g10.Text("importaccno", i) = ToStr(dRow("importaccno"))
            i += 1
        Next
        'GetExchRt()

    End Sub

    Private Sub btn_In_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_In.Click
        If bl_mngno.Text = "" Then
            If MyBase.Save() = False Then Exit Sub
        End If

        Try
            If Me.progclss_bc.Text = "PIP23060" Then
                MessageBox.Show("비용처리가 진행 건입니다.", "진행확인", MessageBoxButtons.OK)
                Exit Sub
            End If
            For ii As Integer = 0 To g10.RowCount - 1
                If g10.Text("in_qty", ii) = 0 Then
                    MessageBox.Show("입고처리시 입고 수량을 먼저 저장하세요", "입고수량확인", MessageBoxButtons.OK)
                    Exit Sub
                End If
                If g10.Text("in_no", ii) <> "" Then
                    MessageBox.Show("입고처리가 완료 된 건입니다.", "입고처리확인", MessageBoxButtons.OK)
                    Exit Sub
                End If
            Next
            Dim p As New OpenParameters
            Dim dSet As New DataSet

            p = New OpenParameters
            p.Add("@ty", "A")
            p.Add("@bl_mngno", Me.bl_mngno.Text)

            dSet = Me.OpenDataSet("PIP125_In_Work", p)
            'up = ToDec(DataValue(dSet))
            If dSet.Tables(0).Rows(0)("status") = "OK" Then

                Me.progclss_bc.Text = "PI23050"
                MessageBox.Show("입고 처리가 완료 되었습니다.", "입고확인", MessageBoxButtons.OK)
                Me.bl_mngnoq.Text = bl_mngno.Text
                Open_Form()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_incancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_incancel.Click
        Try
            If Me.progclss_bc.Text = "PI23010" Then
                MessageBox.Show("입고등록이 처리되지 않아서 취소처리가 안 됩니다.", "입고취소 에러", MessageBoxButtons.OK)
                Exit Sub
            End If

            If Me.progclss_bc.Text = "PI23060" Then
                MessageBox.Show("비용처리가 진행 되어 입고 취소 처리가 안 됩니다.", "입고취소 에러", MessageBoxButtons.OK)
                Exit Sub
            End If

            Dim p As New OpenParameters
            Dim dSet As New DataSet

            p = New OpenParameters
            p.Add("@ty", "D")
            p.Add("@bl_mngno", Me.bl_mngno.Text)

            dSet = Me.OpenDataSet("PIP125_In_Work", p)
            'up = ToDec(DataValue(dSet))
            If dSet.Tables(0).Rows(0)("status") = "OK" Then
                MessageBox.Show("입고취소 처리가 완료 되었습니다.", "입고취소확인", MessageBoxButtons.OK)
                Me.bl_mngnoq.Text = bl_mngno.Text
                Open_Form()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCost.Click
        If progclss_bc.Text = "PI23010" Then 'L/C
            MessageBox.Show("입고등록 처리가 되지 않아서 비용처리를 할 수 없습니다.", "입고등록확인", MessageBoxButtons.OK)
            Exit Sub
        End If

        If progclss_bc.Text = "PI23060" Then 'L/C
            MessageBox.Show("B/L비용 등록이 완료 되었습니다.", "비용처리확인", MessageBoxButtons.OK)
            Exit Sub
        End If

        Dim menuName As String = "PIP130"
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
        ctr.OpenBLCost(g20.DataSet, Me.cust_cd.Text, Me.cust_nm.Text, Me.cury_bc.Text, Me.ex_rt.Text, Me.bl_no.Text, Me.po_no.Text, _
                    Me.famt.Text, Me.amt.Text, g10.Text("stkaccno"), g10.Text("importaccno"))
    End Sub
End Class
