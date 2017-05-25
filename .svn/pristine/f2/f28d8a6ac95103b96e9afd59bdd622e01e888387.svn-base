Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class LEM125

    Private Sub LEM125_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '품목이동 번호 채번
        mov_no.CodeNo = "LEM100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        mov_no.CodeDateField = out_dt
        mov_no.CodeParameterField = out_bs
        Me.Open()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                If mov_no.Text = "" Then
                    MyBase.Open("lem125_g10")
                    MyBase.Open("lem125_g20")
                    MyBase.Open("lem125_g30")
                    Exit Select
                End If
                MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                '사용하려면 재정의 가능하다
            Case MenuType.Save
                If MyBase.Save() Then
                    MyBase.Open()
                Else
                    mov_no.Text = "" : mov_f_no.Text = ""
                End If
            Case MenuType.Delete
                Me.WorkSet("lem125_f10").DeleteRow()
                Me.Open()
            Case MenuType.New
                mov_no.Text = "" : mov_f_no.Text = ""
                MyBase.Open()
                MyBase.Open("lem125_g20")
                MyBase.Open("lem125_g30")
            Case MenuType.Print
                Me.Print()
            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다
        End Select

    End Sub

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        With g10
            If ColumnName = "itm_cd" Then
                Dim up As Decimal, p As New OpenParameters
                Dim dSet As Data.DataSet
                p = New OpenParameters
                p.Add("@itm_id", .Text("itm_id"))
                p.Add("@cust_cd", cust_cd.Text)
                p.Add("@fr_dt", out_dt.Text)
                p.Add("@up_bc", "SD700100")
                p.Add("@cury_bc", "")

                dSet = Me.OpenDataSet("lem125_price", p)
                up = ToDec(DataValue(dSet))
                .Text("mov_up") = up
                .Text("mov_amt") = CDbl(.ToDec("mov_qty")) * CDbl(.ToDec("mov_up"))
            End If
            'If ColumnName = "mov_qty" Or ColumnName = "mov_up" Then
            '    .Text("mov_amt") = .ToDec("mov_qty") * .ToDec("mov_up")
            'End If
            sbweight_g10()
        End With
    End Sub

    Private m_StopEvent As Boolean

    Private Sub g20_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g20.CellValueChanged

        If m_StopEvent Then
            Exit Sub
        End If
        m_StopEvent = True

        Dim Cust_Cnt As Integer
        Dim Custcd As String
        Dim fld_Cnt As Integer
        Dim fldcd As String
        Dim transno As String
        Dim trans_Cnt As Integer
        Dim tcustcd As String

        If ColumnName = "chk" Then
            If Value = "1" Then
                Custcd = g20.Text("cust_cd2")
                transno = g20.Text("trans_no")
                tcustcd = g20.Text("tcust_cd")
                '  동일 거래처  체크
                For iRow = 0 To g20.RowCount - 1
                    If Custcd <> g20.Text("cust_cd2", iRow) And g20.ToBool("chk", iRow) Then
                        Cust_Cnt = ToDec(Cust_Cnt) + 1
                    End If
                Next
                If Cust_Cnt > 0 Then
                    MessageInfo("동일한 거래처만 출하처리 가능 합니다")
                    g20.UpdateRow()
                    g20.Text("qty") = ""
                    g20.Text("chk", RowIndex) = ""
                    m_StopEvent = False
                    Exit Sub
                End If
                fldcd = g20.Text("fld_cd")
                '  동일 거래처  체크
                For iRow = 0 To g20.RowCount - 1
                    If fldcd <> g20.Text("fld_cd", iRow) And g20.ToBool("chk", iRow) Then
                        fld_Cnt = ToDec(fld_Cnt) + 1
                    End If
                Next
                If fld_Cnt > 0 Then
                    MessageInfo("동일한 현장만 출하처리 가능 합니다")
                    g20.UpdateRow()
                    g20.Text("qty") = ""
                    g20.Text("chk", RowIndex) = ""
                    m_StopEvent = False
                    Exit Sub
                End If
                For iRow = 0 To g20.RowCount - 1
                    If transno <> g20.Text("trans_no", iRow) And g20.ToBool("chk", iRow) Then
                        trans_Cnt = ToDec(trans_Cnt) + 1
                    End If
                Next
                If trans_Cnt > 0 Then
                    MessageInfo("동일한 운송번호만 출하처리 가능 합니다")
                    g20.UpdateRow()
                    g20.Text("qty") = ""
                    g20.Text("chk", RowIndex) = ""
                    m_StopEvent = False
                    Exit Sub
                End If

                g20.Text("qty") = g20.Text("rem_qty")
                cust_cd.Text = Custcd
                fld_cd.Text = fldcd
                trans_no.Text = transno
                tcust_cd.Text = tcustcd
            Else
                g20.Text("qty") = ""
                cust_cd.Text = ""
                fld_cd.Text = ""
            End If
        End If
        'If ColumnName = "qty" Then
        '    g20.Text("chk") = IIf(Value = "", "0", "1")
        'End If
        sbweight()
        m_StopEvent = False
    End Sub

    Private Sub g30_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g30.CellValueChanged
        If m_StopEvent Then
            Exit Sub
        End If
        m_StopEvent = True

        Dim Cust_Cnt As Integer
        Dim Custcd As String
        Dim fld_Cnt As Integer
        Dim trans_Cnt As Integer
        Dim fldcd As String
        Dim transno As String
        Dim tcustcd As String

        If ColumnName = "chk" Then
            If Value = "1" Then
                Custcd = g30.Text("cust_cd")
                transno = g30.Text("trans_no")
                tcustcd = g30.Text("tcust_cd")
                '  동일 거래처  체크
                For iRow = 0 To g30.RowCount - 1
                    If Custcd <> g30.Text("cust_cd", iRow) And g30.ToBool("chk", iRow) Then
                        Cust_Cnt = ToDec(Cust_Cnt) + 1
                    End If
                Next
                If Cust_Cnt > 0 Then
                    MessageInfo("동일한 거래처만 출하처리 가능 합니다")
                    g30.UpdateRow()
                    g30.Text("qty") = ""
                    g30.Text("chk", RowIndex) = ""
                    m_StopEvent = False
                    Exit Sub
                End If
                fldcd = g30.Text("fld_cd")
                '  동일 거래처  체크
                For iRow = 0 To g30.RowCount - 1
                    If fldcd <> g30.Text("fld_cd", iRow) And g30.ToBool("chk", iRow) Then
                        fld_Cnt = ToDec(fld_Cnt) + 1
                    End If
                Next
                If fld_Cnt > 0 Then
                    MessageInfo("동일한 현장만 출하처리 가능 합니다")
                    g30.UpdateRow()
                    g30.Text("qty") = ""
                    g30.Text("chk", RowIndex) = ""
                    m_StopEvent = False
                    Exit Sub
                End If
                For iRow = 0 To g30.RowCount - 1
                    If transno <> g30.Text("trans_no", iRow) And g30.ToBool("chk", iRow) Then
                        trans_Cnt = ToDec(trans_Cnt) + 1
                    End If
                Next
                If trans_Cnt > 0 Then
                    MessageInfo("동일한 운송번호만 출하처리 가능 합니다")
                    g30.UpdateRow()
                    g30.Text("qty") = ""
                    g30.Text("chk", RowIndex) = ""
                    m_StopEvent = False
                    Exit Sub
                End If
                g30.Text("qty") = g30.Text("rem_qty")
                cust_cd.Text = Custcd
                fld_cd.Text = fldcd
                trans_no.Text = transno
                tcust_cd.Text = tcustcd
            Else
                g30.Text("qty") = ""
                'cust_cd.Text = ""
                'fld_cd.Text = ""
                'trans_no.Text = ""
            End If
        End If
        'If ColumnName = "qty" Then
        '    g30.Text("chk") = IIf(Value = "", "0", "1")
        'End If
        sbweight()
        m_StopEvent = False
    End Sub

    Private Sub sbweight()
        Dim weight As Double = 0
        For k = 0 To g20.RowCount - 1
            If g20.Text("chk", k) = "1" Then
                weight = weight + (g20.ToDec("qty", k) * g20.ToDec("weight", k))
            End If
        Next
        For k = 0 To g30.RowCount - 1
            If g30.Text("chk", k) = "1" Then
                weight = weight + (g30.ToDec("qty", k) * g30.ToDec("weight", k))
            End If
        Next
        tot_weight.Text = weight

        If weight >= 24 Then
            std_tranfee.Text = CDbl(reg_amt.ToDec) * weight
        Else
            std_tranfee.Text = CDbl(reg_amt.ToDec) * 24
        End If
    End Sub

    Private Sub sbweight_g10()
        Dim weight As Double = 0
        For k = 0 To g10.RowCount - 1
            weight = weight + (g10.ToDec("mov_qty", k) * g10.ToDec("weight", k))
        Next
        tot_weight.Text = weight
        If weight >= 24 Then
            std_tranfee.Text = CDbl(reg_amt.ToDec) * weight
        Else
            std_tranfee.Text = CDbl(reg_amt.ToDec) * 24
        End If
    End Sub

    Private Sub optgubn1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optgubn1.CheckedChanged
        If optgubn1.Checked = True Then
            so_f_dt.Title = "출하계획일자"
            g20.Visible = True
            g30.Visible = False
        Else
            so_f_dt.Title = "수주일자"
            g20.Visible = False
            g30.Visible = True
        End If
    End Sub

    Private Sub optgubn2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optgubn2.CheckedChanged
        If optgubn1.Checked = True Then
            so_f_dt.Title = "출하계획일자"
            g20.Visible = True
            g30.Visible = False
        Else
            so_f_dt.Title = "수주일자"
            g20.Visible = False
            g30.Visible = True
        End If
    End Sub

    Public Sub Print()

        If out_fac.Text = "" Then
            MsgBox("공장선택은 필수 입니다.")
            Exit Sub
        Else
            If g10.RowCount - 1 >= 0 Then
                If g10.Text("trans_no", g10.RowIndex) <> "" Then
                    Dim p As OpenParameters = New OpenParameters
                    p.Add("@trans_no", g10.Text("trans_no", g10.RowIndex))
                    If out_fac.Text = "200" Or out_fac.Text = "250" Or out_fac.Text = "350" Then
                        If g10.Text("grp1_cd", g10.RowIndex) = "300100" Or g10.Text("grp1_cd", g10.RowIndex) = "300150" Or
                            g10.Text("grp1_cd", g10.RowIndex) = "300200" Or g10.Text("grp1_cd", g10.RowIndex) = "300250" Or
                            g10.Text("grp1_cd", g10.RowIndex) = "300450" Or g10.Text("grp1_cd", g10.RowIndex) = "300500" Or
                            g10.Text("grp1_cd", g10.RowIndex) = "300550" Or g10.Text("grp1_cd", g10.RowIndex) = "300600" Or
                            g10.Text("grp1_cd", g10.RowIndex) = "300650" Or g10.Text("grp1_cd", g10.RowIndex) = "300700" Or
                            g10.Text("grp1_cd", g10.RowIndex) = "300750" Then
                            System7.ReportView.LoadView("LEB155", "", "lem125_Print", p)
                            Exit Sub
                        End If
                    ElseIf out_fac.Text = "200" Or out_fac.Text = "300" Then
                        If g10.Text("grp1_cd", g10.RowIndex) = "300300" Or g10.Text("grp1_cd", g10.RowIndex) = "300350" Or
                            g10.Text("grp1_cd", g10.RowIndex) = "300400" Then
                            System7.ReportView.LoadView("LEB156", "", "lem125_Print", p)
                            Exit Sub
                        End If
                    Else
                        System7.ReportView.LoadView("LEB157", "", "lem125_Print2", p)
                        Exit Sub
                    End If
                Else
                    MsgBox("선택된 행에 운송번호가 없습니다.")
                    Exit Sub
                End If
            Else
                MsgBox("출력할 항목이 없습니다")
                Exit Sub
            End If
        End If

    End Sub

    Private Sub car_bc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles car_bc.TextChanged
        Dim up As Decimal, p As New OpenParameters
        Dim dSet As Data.DataSet
        p = New OpenParameters
        p.Add("@bs_cd", out_bs.Text)
        p.Add("@fld_cd", fld_cd.Text)
        p.Add("@car_bc", car_bc.Text)
        dSet = Me.OpenDataSet("lem125_work", p)
        up = ToDec(DataValue(dSet))
        reg_amt.Text = up
        If tot_weight.ToDec >= 24 Then
            std_tranfee.Text = CDbl(reg_amt.ToDec) * CDbl(tot_weight.ToDec)
        Else
            std_tranfee.Text = CDbl(reg_amt.ToDec) * 24
        End If
    End Sub

    Private Sub fld_cd_TextChanged(ByVal sender As System.Object, ByVal oldValue As System.String) Handles fld_cd.TextChanged
        Dim up As Decimal, p As New OpenParameters
        Dim dSet As Data.DataSet
        p = New OpenParameters
        p.Add("@bs_cd", out_bs.Text)
        p.Add("@fld_cd", fld_cd.Text)
        p.Add("@car_bc", car_bc.Text)
        dSet = Me.OpenDataSet("lem125_work", p)
        up = ToDec(DataValue(dSet))
        reg_amt.Text = up
        If tot_weight.ToDec >= 24 Then
            std_tranfee.Text = CDbl(reg_amt.ToDec) * CDbl(tot_weight.ToDec)
        Else
            std_tranfee.Text = CDbl(reg_amt.ToDec) * 24
        End If
    End Sub

    Public Sub Open3(ByVal dSet As DataSet, ByVal dSet2 As DataSet, ByVal gubn As String)
        Try
            Me.New_Form()
            g10.DeleteBlankRow()

            Dim i As Integer = 0

            If dSet.Tables(0).DataSet.Tables.Count = 0 Then
                GoTo aaaaaaa
            End If
            For Each dRow As DataRow In dSet.Tables(0).Rows
                If ToStr(dRow("chk")) Then

                    If i = 0 Then
                        fld_cd.Text = ToStr(dRow("fld_cd"))
                        cust_cd.Text = ToStr(dRow("cust_cd"))
                        out_bs.Text = ToStr(dRow("outp_bs"))
                        'out_fac.Text = ToStr(dRow("fac_cd"))
                        If gubn = "1" Then
                            trans_no.Text = ToStr(dRow("trans_no"))
                            tcust_cd.Text = ToStr(dRow("tcust_cd"))
                        End If
                        ent_bc.Text = "LE920300"    '출하이동
                    End If

                    g10.AddNewRow()
                    For Each Col As DataColumn In dSet.Tables(0).Columns
                        For k = 0 To g10.ColumnCount - 1
                            If g10.FieldName(k) = "stat_bc" Then
                            Else
                                If Col.ColumnName = g10.FieldName(k) Then
                                    g10.Text(g10.FieldName(k), g10.RowIndex) = ToStr(dRow(Col.ColumnName))
                                End If
                            End If
                        Next
                    Next
                    g10.Text("mov_qty", i) = ToStr(dRow("qty"))
                    If ToDec(dRow("m_up")) > 0 Then
                        g10.Text("mov_up", i) = ToStr(dRow("m_up"))
                    Else
                        g10.Text("mov_up", i) = ToStr(dRow("out_up"))
                    End If
                    g10.Text("mov_amt", i) = g10.ToDec("mov_up", i) * g10.ToDec("mov_qty", i)
                    i += 1
                End If
            Next
aaaaaaa:
            If dSet2.Tables(0).DataSet.Tables.Count = 0 Then
                Exit Sub
            End If
            For Each dRow As DataRow In dSet2.Tables(0).Rows
                If ToStr(dRow("chk")) Then

                    If i = 0 Then
                        fld_cd.Text = ToStr(dRow("fld_cd"))
                        cust_cd.Text = ToStr(dRow("cust_cd"))
                        out_bs.Text = ToStr(dRow("sal_bs"))
                        'out_fac.Text = ToStr(dRow("so_fac"))
                        ent_bc.Text = "LE920300"    '출하이동
                    End If

                    g10.AddNewRow()
                    For Each Col As DataColumn In dSet2.Tables(0).Columns
                        For k = 0 To g10.ColumnCount - 1
                            If g10.FieldName(k) = "stat_bc" Then
                            Else
                                If Col.ColumnName = g10.FieldName(k) Then
                                    g10.Text(g10.FieldName(k), g10.RowIndex) = ToStr(dRow(Col.ColumnName))
                                End If
                            End If
                        Next
                    Next
                    g10.Text("mov_qty", i) = ToStr(dRow("qty"))
                    If ToStr(dRow("m_up")) > 0 Then
                        g10.Text("mov_up", i) = ToStr(dRow("m_up"))
                    Else
                        g10.Text("mov_up", i) = ToStr(dRow("out_up"))
                    End If
                    g10.Text("mov_amt", i) = g10.ToDec("mov_up", i) * g10.ToDec("mov_qty", i)
                    i += 1
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        If g20.RowCount = 0 And g30.RowCount = 0 Then
            Exit Sub
        End If
        Me.Open3(g20.DataSet, g30.DataSet, "1")
        Dim up As Decimal, p As New OpenParameters
        Dim dSet As Data.DataSet
        p = New OpenParameters
        p.Add("@bs_cd", out_bs.Text)
        p.Add("@fld_cd", fld_cd.Text)
        p.Add("@car_bc", car_bc.Text)
        dSet = Me.OpenDataSet("lem125_work", p)
        up = ToDec(DataValue(dSet))
        reg_amt.Text = up
        sbweight_g10()
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        If g20.RowCount = 0 And g30.RowCount = 0 Then
            Exit Sub
        End If
        Me.Open3(g20.DataSet, g30.DataSet, "2")
        Dim up As Decimal, p As New OpenParameters
        Dim dSet As Data.DataSet
        p = New OpenParameters
        p.Add("@bs_cd", out_bs.Text)
        p.Add("@fld_cd", fld_cd.Text)
        p.Add("@car_bc", car_bc.Text)
        dSet = Me.OpenDataSet("lem125_work", p)
        up = ToDec(DataValue(dSet))
        reg_amt.Text = up
        sbweight_g10()
    End Sub

    Public Sub New_Form()
        mov_no.Text = ""
        MyBase.Open()
        g10.AddNewRow()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        MyBase.Open("lem125_g20")
        MyBase.Open("lem125_g30")
    End Sub

    Private Sub mov_f_no_TextChanged(ByVal sender As Object, ByVal oldValue As String) Handles mov_f_no.TextChanged
        mov_no.Text = mov_f_no.Text
        If Len(mov_no.Text) > 0 Then
            MyBase.Open()
        End If
    End Sub

    Public Sub Open2(ByVal movNo As String)
        mov_no.Text = movNo
        MyBase.Open()
    End Sub
End Class
