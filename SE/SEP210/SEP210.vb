Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class SEP210

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        '수출 File번호 채번
        file_no.CodeNo = "SEP210"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        file_no.CodeDateField = open_dt
        Me.Open_Form()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty
            Case MenuType.Open

                Me.Open_Form()

            Case MenuType.Save

                Me.Save_Form()
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
        out_no.Text = ""
        Dim fileNo As String = file_no.Text
        Me.Open()
        g10.Find("file_no=" + fileNo)
    End Sub

    Public Sub Open2(GetOutNo As String)
        out_no.Text = GetOutNo
        Me.Open()
    End Sub

    Private Sub New_Form()

        file_no.Text = ""
        Me.Open("SEP210_f10")
        Me.Open("SEP210_g20")

    End Sub

    Private Sub Save_Form()

        work_ty.Text = "none"

        Me.CompAmt()
        If Me.progress_bc.Text <> "" And Me.progress_bc.Text <> "SE19010" Then
            MessageBox.Show("수출 마스터건의 후행(출고처리,b/l처리)작업이 진행되어 수정이 불가능합니다", "확인", MessageBoxButtons.OK)
            Exit Sub
        End If


        For ii As Integer = 0 To g20.DataSet.Tables(0).Rows.Count - 1
            g20.Text("fac_cd", ii) = fac_cd.Text
            g20.Text("wh_cd", ii) = wh_cd.Text

        Next
        'For ii As Integer = 0 To g20.DataSet.Tables(0).Rows.Count - 1

        'Next
        If MyBase.Save() Then
            Open_Form()
        End If
    End Sub

    Private Sub Delete_Form()

        
        'Me.CompAmt()
        If Me.progress_bc.Text <> "" And Me.progress_bc.Text <> "SE19010" Then
            MessageBox.Show("수출 마스터건의 후행(출고처리,b/l처리)작업이 진행되어 삭제가 불가능합니다", "확인", MessageBoxButtons.OK)
            Exit Sub
        End If

        If MyBase.Delete("SEP210_f10") Then
            Open_Form()
        End If

    End Sub


    '환율적용일이 바뀌면 환율을 자동으로 끌어온다
    '환율 구하는 데이타셋
    Private Sub GetExchRt()

        Dim p As New OpenParameters
        Dim Rt As Decimal

        p.Add("@std_dt", open_dt.Text)
        p.Add("@cury_bc", cury_bc.Text)

        Dim dSet As DataSet = OpenDataSet("SEP210_excht", p)

        If Not IsEmpty(dSet) Then
            Rt = DataValue(dSet, "ttm_rt")
        Else
            Rt = "1"
        End If

        ex_rt.Text = Rt

    End Sub

    Private Sub cury_bc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cury_bc.TextChanged, bank_cd.TextChanged
        GetExchRt()

    End Sub

    Private Sub open_dt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles open_dt.TextChanged
        GetExchRt()

    End Sub
    Private Sub g20_popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles g20.DoubleClick


        If Not CheckRequired(Me.open_dt, Me.cury_bc) Then
            Exit Sub
        End If


    End Sub
    'Private Sub g10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.Click

    '    Me.Open("SEP210_f10")
    '    Me.Open("SEP210_g20")
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

    Private Sub g20_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g20.CellValueChanged
        With g20
            If ColumnName = "itm_cd" And g20.Text("itm_cd") = "" Then
                If Not CheckRequired(Me.open_dt, Me.cury_bc, Me.cust_cd) Then
                    Exit Sub
                End If
            End If

            '    g20.RunPopup("itm_cd", True)
            'End If
            If ColumnName = "qty" Then
                'If g20.CheckRequired() Then
                '    If CDbl(g20.Text("lot_qty")) - CDbl(g20.Text("qty")) < 0 Then
                '        MessageBox.Show("Lot 재고수량 보다 더 많은 수주 수량이 등록되었습니다. Lot재고를 확인하세요", "Lot재고확인", MessageBoxButtons.OK)
                '        g20.Text("qty") = 0
                '        Exit Sub
                '    End If
                'End If
            End If
            If ColumnName = "qty" Or ColumnName = "up" Then
                .Text("famt") = .ToDec("qty") * .ToDec("up")
                .Text("korup") = .ToDec("up") * ex_rt.ToDec
                .Text("amt") = .ToDec("famt") * ex_rt.ToDec
            End If
        End With

        Me.CompAmt()
    End Sub

    Private Sub ex_rt_TextChanged(ByVal sender As Object, ByVal oldValue As String) Handles ex_rt.TextChanged
        'amt.Text = famt.ToDec * ex_rt.ToDec

        With g20
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

        With g20
            .UpdateRow()
            For i As Integer = 0 To .RowCount - 1
                If .IsDataRow(i) Then
                    sum_amt += .ToDec("amt", i)
                    sum_famt += .ToDec("famt", i)
                End If
            Next
        End With

        amt.Text = sum_amt
        famt.Text = sum_famt
    End Sub

    Private Sub btn_out_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_out.Click
        If order_bc.Text = "SE210100" And Me.in_whcd.Text = "" Then
            MessageBox.Show("이동처리시 거래처관리창고를 선택해야 합니다", "창고선택", MessageBoxButtons.OK)
            Exit Sub

        End If

        If order_bc.Text = "SE210100" Then
            For ii As Integer = 0 To g20.RowCount - 1
                If g20.Text("lotno", ii) = "" Then
                    MessageBox.Show("이동처리시 면장번호(lotno)가 입력되어야 합니다.", "면장번호 확인", MessageBoxButtons.OK)
                    Exit Sub
                End If
                'g20.Text("wh_cd", ii) = wh_cd.Text
            Next
        End If

        If Not CheckRequired(file_no, fac_cd, wh_cd, Me.cust_cd) Then
            Exit Sub
        End If
        For ii As Integer = 0 To g20.RowCount - 1
            g20.Text("fac_cd", ii) = fac_cd.Text
            g20.Text("wh_cd", ii) = wh_cd.Text
        Next
        If MessageYesNo("출고처리 하시겠습니까 ?") = MsgBoxResult.Yes Then

            Dim p As OpenParameters = New OpenParameters
         

            If g20.CheckedRows("chk") = 0 Then
                MessageInfo("선택된 행이 없습니다")
                Exit Sub
            End If

            With g20
                For i As Integer = 0 To .RowCount - 1
                    If .ToBool("chk", i) And .Text("out_no", i) <> "" Then
                        MessageInfo("이미 출고처리된 행이 있습니다.")
                        Exit Sub
                    End If
                Next
            End With

            work_ty.Text = "save"

            If Me.Save Then
                Me.Open_Form()
            End If

            'p.Add("@file_no", file_no.Text)
            'p.Add("@fac_cd", fac_cd.Text)
            'p.Add("@wh_cd", wh_cd.Text)

            'Dim dSet As DataSet = OpenDataSet("SEP210_out", p)

            'MessageInfo("출고 및 매출처리 완료 하였습니다")

            'Me.Open_Form()
        End If

    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        If MessageYesNo("출고처리 하시겠습니까 ?") = MsgBoxResult.Yes Then
            Dim p As OpenParameters = New OpenParameters
            If Not CheckRequired(file_no) Then
                Exit Sub
            End If

            If g20.CheckedRows("chk") = 0 Then
                MessageInfo("선택된 행이 없습니다")
                Exit Sub
            End If

            With g20
                For i As Integer = 0 To .RowCount - 1
                    If .ToBool("chk", i) And .Text("out_no", i) = "" Then
                        MessageInfo("출고처리된 행만 선택가능합니다.")
                        Exit Sub
                    End If
                Next
            End With

            work_ty.Text = "delete"

            If Me.Save Then
                Me.Open_Form()
            End If
        End If
    End Sub

    Private Sub order_bc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles order_bc.TextChanged
        If order_bc.Text = "SE210100" Then
            btn_out.Text = "출하이동"
            btn_cancel.Text = "출하이동취소"
        Else
            btn_out.Text = "출고처리"
            btn_cancel.Text = "출고취소"
        End If
    End Sub

    Private Sub fac_cd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fac_cd.TextChanged
        If fac_cd.Text <> "" Then
            For ii As Integer = 0 To g20.DataSet.Tables(0).Rows.Count - 1
                g20.Text("fac_cd", ii) = fac_cd.Text
            Next
        End If
    End Sub
    Private Sub wh_cd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wh_cd.TextChanged
        If wh_cd.Text <> "" Then
            For ii As Integer = 0 To g20.DataSet.Tables(0).Rows.Count - 1
                g20.Text("wh_cd", ii) = wh_cd.Text
            Next
        End If
    End Sub

     
    Private Sub btn_Invoice_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Invoice.Click
        Dim p As New OpenParameters
        p.Add("@invoiceno", Me.invo_no.Text)

        If cust_cd.Text = "SD01653" Then    '폭스바겐
            Dim dSet As DataSet = MyBase.OpenDataSet("SEP210_Print_Volkswagen", p)

            Dim report As New VolksPreviewControl

            'Dim rpt As New SEP.PreviewControl
            'Dim rpt As New SEP.PreviewControl
            'rpt.CreateReport("", "")
            Dim isprint As Windows.Forms.DialogResult
            isprint = MessageBox.Show("customs authrizotion 번호를 출력하시겠습니까?", "확인", MessageBoxButtons.YesNo)
            If isprint = DialogResult.OK Or isprint = DialogResult.Yes Then
                report.CreatReport(dSet, True)
            Else
                report.CreatReport(dSet, False)
            End If

        Else
            Dim dSet As DataSet = MyBase.OpenDataSet("SEP210_Print_other", p)

            Dim report As New OtherPreviewControl

            
            Dim isprint As Windows.Forms.DialogResult
            isprint = MessageBox.Show("customs authrizotion 번호를 출력하시겠습니까?", "확인", MessageBoxButtons.YesNo)
            If isprint = DialogResult.OK Or isprint = DialogResult.Yes Then
                report.CreatReport(dSet, True)
            Else
                report.CreatReport(dSet, False)
            End If

        End If

        'Dim report As New VolksPreviewControl
        'report.ShowRibbonPreviewDialog()

        'Dim report As New Invoice

        'report.Print()
        'report.PrintDialog()
        ''report.DataSource = fill
        'report.ShowDesignerDialog()
        'report.invoiceno.Value = invo_no
    End Sub

    Private Sub receiptdate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles receiptdate.TextChanged
        ship_dt.Text = receiptdate.Text
        loc_dt.Text = receiptdate.Text
    End Sub
End Class
