Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data
Imports System.Collections

Public Class WI_PR1124
    Dim p As New OpenParameters
    Dim t As Boolean

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If find_visible2.Checked Then MenuButton_Click(MenuType.Find)
        Me.Clear()
        'Me.Open()

        'MenuButton_Click(MenuType.Find)
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                'Me.Open()
                '    'Open_Form()
            Case MenuType.Save
                If Not Saves() Then Exit Sub
                If Not ConFrim() Then Exit Sub
            Case MenuType.Cancel
                temp_gong_cd.Text = ""
                temp_lot_no.Text = ""
                Me.Clear()

            Case MenuType.Confirm
                If Not ConFrim() Then Exit Sub

            Case MenuType.Deconfirm
                If Not DeConFrim() Then Exit Sub

            Case MenuType.Find
                Me.Find()

            Case MenuType.Delete
                If Not Del() Then Exit Sub

                'Case MenuType.New
                'New_Form()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub New_Form()
        'Clear()

        g_body1.AddNewRow()
    End Sub

    Private Function Saves() As Boolean

        If Check_Stts() = "C" Then '상태값 CHECK
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        Me.totQty()

        'If job_qty.ToDec < tot_qty.ToDec Then
        '    MsgBox("생산수량이 지시수량보다 많습니다.!")
        '    Return False
        'End If

        If job_qty.ToDec <> tot_qty.ToDec Then
            MsgBox("생산수량이 지시수량과 일치하지 않습니다.!")
            Return False
        End If

        If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            Max_NO()  '전표채번..

            If MyBase.Save() Then
                'MyBase.OpenTrigger("wi_sa1120_list")

                p.Clear()
                p.Add("@pr_no", pr_no.Text)

                'Me.Open("WI_PR1124_head", p)
                Me.Open("WI_PR1124_body4", p)
                'LJM
            Else
                Return False
            End If

            stts.Text = "S"
        End If

        '거래처 체크
        If Not Me.Check_CsCd() Then
            Return False
        End If

        Return True
    End Function

    Private Function Check_deconfirm() As String
        p.Clear()
        p.Add("@PR_NO", pr_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_pr1124_deconfirm", p)
        Dim stts As String = "Y"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Function Check_Stts() As String
        p.Clear()
        p.Add("@pr_no", pr_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("WI_PR1124_stts", p)
        Dim stts As String = "S"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Function setTime() As String
        p.Clear()

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_pr1124_time")
        Dim stts As String = ""

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Sub Max_NO()
        ' p/o 번호 채번
        pr_no.CodeNo = "WI_PR1124"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        pr_no.CodeDateField = pr_dt

    End Sub

    Private Function Del() As Boolean

        If pr_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        '상태값 CHECK
        If Check_Stts() = "C" Then
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        If MessageYesNo("삭제 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@pr_no", pr_no.Text)

            Me.Open("WI_PR1124_delete", p)

            Me.Clear()

            g_list.Open()

        End If

        Return True
    End Function

    Private Function ConFrim() As Boolean

        If pr_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        '상태값 CHECK
        If Check_Stts() = "C" Then
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            'Me.Open("WI_PR1124_confirm")

            p.Clear()
            p.Add("@pr_no", pr_no.Text)
            p.Add("@stts", "C")

            Me.Open("WI_PR1124_confirm", p)

            stts.Text = "C"
        End If

        Return True
    End Function

    Private Function DeConFrim() As Boolean

        If pr_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        '상태값 CHECK
        If Check_Stts() <> "C" Then
            MsgBox("확인된 자료가 아닙니다.!")
            Return False
        End If

        If Check_deconfirm() = "N" Then
            MsgBox("다음 생산실적이 등록된 자료입니다.!")
            Return False
        End If

        If MessageYesNo("확인취소 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@pr_no", pr_no.Text)
            p.Add("@stts", "S")

            Me.Open("WI_PR1124_confirm", p)

            stts.Text = "S"
        End If

        Return True
    End Function

    Private Function Check_CsCd() As Boolean
        Try
            Return True

        Catch ex As Exception
            MessageInfo(ex)
        End Try
    End Function

    Private Sub Clear()
        

        p.Clear()
        p.Add("@pr_no", "XXX")

        Me.Open("WI_PR1124_head", p)
        Me.Open("WI_PR1124_body", p)
        Me.Open("WI_PR1124_body1", p)
        Me.Open("WI_PR1124_body2", p)
        Me.Open("WI_PR1124_body3", p)
        Me.Open("WI_PR1124_body4", p)
        Me.Open("WI_PR1124_body5", p)

    End Sub
    Public Sub Open3(ByVal OUTRNO As String) ', ByVal OUTRDT As String) ', ByVal faccd As String, ByVal whcd As String) ' ByVal outwh As String,

        pr_no.Text = OUTRNO
        p.Clear()
        p.Add("@pr_no", pr_no.Text)
        Me.Open("WI_PR1124_head", p)
        Me.Open("WI_PR1124_body", p)
        Me.Open("WI_PR1124_body1", p)
        Me.Open("WI_PR1124_body2", p)
        Me.Open("WI_PR1124_body3", p)
        Me.Open("WI_PR1124_body4", p)
        Me.Open("WI_PR1124_body5", p)


    End Sub
    Private Sub Find()
        If spc_1.Panel1Collapsed = False Then
            spc_1.Panel1Collapsed = True
        Else
            spc_1.Panel1Collapsed = False

        End If
    End Sub

    Private Sub find_Clear()
        p.Clear()
        p.Add("@find_from", find_from.Text)
        p.Add("@find_to", find_to.Text)
        p.Add("@find_gd_nm", "XXX")
        p.Add("@find_stts", find_stts.Text)
        p.Add("@find_lot_no", find_lot_no.Text)
        p.Add("@find_mc_cd", find_mc_cd.Text)
        p.Add("@find_gong_cd", find_gong_cd.Text)

        Me.Open("WI_PR1124_list", p)
    End Sub

    Private Sub find_Clear2()
        p.Clear()
        p.Add("@find_from2", find_from2.Text)
        p.Add("@find_to2", find_to2.Text)
        p.Add("@find_gd_nm2", "XXX")
        p.Add("@find_lot_no2", find_lot_no2.Text)
        p.Add("@find_mc_cd2", find_mc_cd2.Text)
        p.Add("@find_gong_cd2", find_gong_cd2.Text)

        Me.Open("WI_PR1124_list2", p)
    End Sub

    Private Sub totQty()
        Dim sum_amt As Double

        With g_body1
            .UpdateRow()
            For i As Integer = 0 To .RowCount - 1
                sum_amt = sum_amt + .ToDec("NG_QTY", i)
            Next
        End With
        ng_qty.Text = sum_amt.ToString
        tot_qty.Text = pr_qty.ToDec + ng_qty.ToDec + sample_qty.ToDec


        'bi_amt.Text = sum_amt
    End Sub

    'Private Sub rate_TextChanged(ByVal sender As Object, ByVal oldValue As String) Handles Rate.TextChanged
    '    won_amt.Text = bal_amt.ToDec * Rate.ToDec
    'End Sub

    Private Sub btn_find2_Click(sender As Object, e As System.EventArgs) Handles btn_find2.Click
        g_list2.Open()
    End Sub

    Private Sub g_list2_DoubleClick(sender As Object, e As System.EventArgs) Handles g_list2.DoubleClick
        Me.Clear()
        'gd_cd.Text = g_list2.Text("GD_CD", g_list2.RowIndex)
        'gong_cd.Text = g_list2.Text("GONG_CD", g_list2.RowIndex)
        'lot_no.Text = g_list2.Text("LOT_NO", g_list2.RowIndex)

        temp_gong_cd.Text = g_list2.Text("GONG_CD", g_list2.RowIndex)
        temp_lot_no.Text = g_list2.Text("LOT_NO", g_list2.RowIndex)


        'pr_jobno.Text = g_list2.Text("JOB_NO", g_list2.RowIndex)
        'job_no.Text = g_list2.Text("JOB_NO", g_list2.RowIndex)
        'job_seq.Text = g_list2.Text("JOB_SEQ", g_list2.RowIndex)
        'gong_cd.Text = g_list2.Text("GONG_CD", g_list2.RowIndex)
        'wa_cd.Text = g_list2.Text("WA_CD", g_list2.RowIndex)
        'mc_cd.Text = g_list2.Text("MC_CD", g_list2.RowIndex)
        'job_qty.Text = g_list2.Text("JOB_QTY", g_list2.RowIndex)
        'gd_cd.Text = g_list2.Text("GD_CD", g_list2.RowIndex)
        'gd_nm.Text = g_list2.Text("GD_NM", g_list2.RowIndex)
        'spec.Text = g_list2.Text("SPEC", g_list2.RowIndex)
        'unit_cd.Text = g_list2.Text("UNIT_CD", g_list2.RowIndex)
        'new_gdcd.Text = g_list2.Text("GD_CD", g_list2.RowIndex)

        'setJobNO()

        If find_visible2.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    Private Sub ng_qty_TextChanged(sender As Object, oldValue As String) Handles ng_qty.TextChanged
        Me.totQty()

    End Sub

    Private Sub pr_qty_TextChanged(sender As Object, oldValue As String) Handles pr_qty.TextChanged
        With g_body
            .UpdateRow()
            For i As Integer = 0 To .RowCount - 1
                If Mid(.Text("GD_CD", i), 1, 1) = "B" Or Mid(.Text("GD_CD", i), 1, 1) = "b" Then
                    .Text("TUIP_QTY", i) = .ToDec("SO_QTY", i) * (pr_qty.ToDec + ng_qty.ToDec)
                End If
            Next
        End With

        Me.totQty()
    End Sub

    Private Sub btn_find_Click(sender As Object, e As System.EventArgs) Handles btn_find.Click
        g_list.Open()
    End Sub

    Private Sub btn_cancel2_Click(sender As Object, e As System.EventArgs) Handles btn_cancel2.Click
        find_Clear2()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As System.EventArgs) Handles btn_cancel.Click
        find_Clear()
    End Sub

    Private Sub g_list_DoubleClick(sender As Object, e As System.EventArgs) Handles g_list.DoubleClick
        temp_gong_cd.Text = ""
        temp_lot_no.Text = ""

        p.Clear()
        p.Add("@pr_no", g_list.Text("PR_NO", g_list.RowIndex))

        Me.Open("WI_PR1124_head", p)
        Me.Open("WI_PR1124_body", p)
        Me.Open("WI_PR1124_body1", p)
        Me.Open("WI_PR1124_body2", p)
        Me.Open("WI_PR1124_body3", p)
        Me.Open("WI_PR1124_body4", p)
        Me.Open("WI_PR1124_body5", p)

        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
    End Sub


    Private Sub setJobNO()

        If lot_no.Text = Nothing Then Exit Sub
        If gong_cd.Text = Nothing Then Exit Sub

        Dim s_pr_jobno As String = "", s_gong_cd As String = ""

        s_pr_jobno = lot_no.Text
        s_gong_cd = gong_cd.Text

        p.Clear()
        p.Add("@lot_no", s_pr_jobno)
        p.Add("@gong_cd", s_gong_cd)

        Dim dSet As Data.DataSet = Me.OpenDataSet("WI_PR1124_jobno", p)

        '-------------------------------------------------------------------

        'job_no.Text = ""
        'job_seq.Text = ""
        'pr_jobno.Text = ""
        'wa_cd.Text = ""
        'mc_cd.Text = ""
        'job_qty.Text = ""
        'gd_cd.Text = ""
        'gd_nm.Text = ""
        'spec.Text = ""
        'unit_cd.Text = ""
        'new_gdcd.Text = ""

        pr_no.Text = ""
        stts.Text = ""


        p.Clear()
        p.Add("@pr_no", "XXX")

        'Me.Open("WI_PR1124_head", p)
        Me.Open("WI_PR1124_body", p)
        Me.Open("WI_PR1124_body1", p)
        Me.Open("WI_PR1124_body2", p)
        Me.Open("WI_PR1124_body3", p)
        Me.Open("WI_PR1124_body4", p)
        Me.Open("WI_PR1124_body5", p)
        '-------------------------------------------------------------------

        'Me.Clear()

        If Not IsEmpty(dSet) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            For Each dRow In dRows
                job_no.Text = ToStr(dRow("job_no"))
                job_seq.Text = ToStr(dRow("job_seq"))
                pr_jobno.Text = ToStr(dRow("job_no"))
                wa_cd.Text = ToStr(dRow("wa_cd"))
                mc_cd.Text = ToStr(dRow("mc_cd"))
                job_qty.Text = ToStr(dRow("job_qty"))
                gd_cd.Text = ToStr(dRow("gd_cd"))
                gd_nm.Text = ToStr(dRow("gd_nm"))
                spec.Text = ToStr(dRow("spec"))
                unit_cd.Text = ToStr(dRow("unit_cd"))
                new_gdcd.Text = ToStr(dRow("gd_cd"))
                mate_no.Text = ToStr(dRow("MATE_NO"))
                u_whcd_yn.Text = ToStr(dRow("u_whcd_yn"))
            Next
        Else
            Me.Clear()
            'pr_jobno.Text = s_pr_jobno
            'gong_cd.Text = s_gong_cd
            Exit Sub
        End If

        p.Clear()
        p.Add("@GD_CD", gd_cd.Text)
        p.Add("@gong_cd", s_gong_cd)
        p.Add("@u_whcd_yn", u_whcd_yn.Text)

        Dim dSet2 As Data.DataSet = Me.OpenDataSet("WI_PR1124_gong", p)

        'Me.Clear()

        If Not IsEmpty(dSet2) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet2.Tables(0).Rows

            For Each dRow In dRows
                fwh_cd.Text = ToStr(dRow("FWH_CD"))
                twh_cd.Text = ToStr(dRow("TWH_CD"))
            Next
        Else
            Me.Clear()
            'pr_jobno.Text = s_pr_jobno
            'gong_cd.Text = s_gong_cd
            Exit Sub
        End If

        p.Clear()
        p.Add("@pr_no", "XXXX")
        Me.Open("WI_PR1124_body", p)

        p.Clear()
        p.Add("@JOB_NO", job_no.Text)
        p.Add("@GONG_CD", gong_cd.Text)

        dSet = Me.OpenDataSet("WI_PR1124_bom", p)
        Dim ll_row As Integer = 0

        If Not IsEmpty(dSet) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            With g_body
                ll_row = .RowIndex
                For Each dRow In dRows
                    .InsertNewRow(ll_row)

                    .Text("GD_CD", ll_row) = ToStr(dRow("GD_CD"))
                    .Text("GD_NM", ll_row) = ToStr(dRow("GD_NM"))
                    '.Text("SPEC", ll_row) = ToStr(dRow("SPEC"))
                    .Text("SO_QTY", ll_row) = ToStr(dRow("QTY"))
                    .Text("TUIP_QTY", ll_row) = ToStr(dRow("QTY") * job_qty.ToDec)

                    '.Text("LOT_NO", ll_row) = lot_no.Text
                    .Text("LOT_NO", ll_row) = ToStr(dRow("LOT_NO"))

                Next
            End With
        Else
            Exit Sub
        End If

    End Sub

    Private Sub lot_no_TextChanged(sender As Object, oldValue As String) Handles lot_no.TextChanged

        setJobNO()

    End Sub



    'Private Sub g_body5_DoubleClick(sender As Object, e As System.EventArgs) Handles g_body5.DoubleClick
    '    'MsgBox(g_body5.FieldName(g_body5.ColumnIndex + 3))

    '    If g_body5.FieldName(g_body5.ColumnIndex + 3) <> "FINAL_RESULT" Or
    '       g_body5.FieldName(g_body5.ColumnIndex + 3) <> "RS_01" Then

    '        g_body5.Text(g_body5.FieldName(g_body5.ColumnIndex + 3), g_body5.RowIndex) = g_body5.Text("RS_01", g_body5.RowIndex)

    '    End If
    'End Sub

    Private Sub g_body1_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g_body1.CellValueChanged
        If g_body1.FieldName(g_body1.ColumnIndex + 1) <> "NG_QTY" Then Exit Sub
        totQty()
    End Sub

    Private Sub spec_print_Click(sender As System.Object, e As System.EventArgs) Handles spec_print.Click

        Dim p As OpenParameters = New OpenParameters
        ' MessageInfo(Mid(lot_no.Text, 1, 1))
        If Mid(lot_no.Text, 1, 1) <> "B" And Mid(lot_no.Text, 1, 1) <> "b" Then
            p.Add("@lot_no", lot_no.Text)
            p.Add("@pr_no", pr_no.Text)
            ' MessageInfo(gong_cd.Text)
            If lot_no.Text <> "" And
                gong_cd.Text = "80" Then
                '   
                System7.ReportView.LoadView("WI_PR1124", "", "WI_PR1124_print", p, , False)
            Else
                MessageInfo("규격 검사만 출력 할수 있습니다. 또는 체크시트 번호가 없습니다.")
            End If
        Else
            ' MessageInfo("1")
            p.Add("@lot_no", lot_no.Text)
            ' p.Add("@pr_no", pr_no.Text)
            If lot_no.Text <> "" And
                gong_cd.Text = "80" Then
                'MessageInfo("1")
                System7.ReportView.LoadView("WI_PR1124_2", "", "WI_PR1124R2_print", p, , False)
            Else
                MessageInfo("규격 검사만 출력 할수 있습니다. 또는 체크시트 번호가 없습니다.")
            End If
        End If

        Return
    End Sub

 


    Private Sub temp_lot_no_TextChanged(sender As Object, oldValue As String) Handles temp_lot_no.TextChanged
        Me.Clear()
        'gd_cd.Text = g_list2.Text("GD_CD", g_list2.RowIndex)
        gong_cd.Text = temp_gong_cd.Text
        lot_no.Text = temp_lot_no.Text
    End Sub

    Private Sub temp_gong_cd_TextChanged(sender As Object, e As System.EventArgs) Handles temp_gong_cd.TextChanged
        Me.Clear()
        'gd_cd.Text = g_list2.Text("GD_CD", g_list2.RowIndex)
        gong_cd.Text = temp_gong_cd.Text
        lot_no.Text = temp_lot_no.Text
    End Sub


    Private Sub gong_cd_TextChanged(sender As Object, e As System.EventArgs) Handles gong_cd.TextChanged
        setJobNO()
    End Sub

    Private Sub find_lot_no_TextChanged(sender As Object, oldValue As String) Handles find_lot_no.TextChanged

        g_list.Open()
    End Sub

    Private Sub find_lot_no2_TextChanged(sender As Object, oldValue As String) Handles find_lot_no2.TextChanged
        g_list2.Open()
    End Sub

    Private Sub btn_start_Click(sender As Object, e As System.EventArgs) Handles btn_start.Click
        from_time.Text = setTime()
    End Sub

    Private Sub btn_end_Click(sender As Object, e As System.EventArgs) Handles btn_end.Click
        to_time.Text = setTime()
    End Sub

    Private Sub g_body5_AfterMoveColumn(sender As Object, PrevColumnName As String, ColumnName As String) Handles g_body5.AfterMoveColumn

        If g_body5.FieldName(g_body5.ColumnIndex + 3) = "RS_01" Then

        Else

            If g_body5.FieldName(g_body5.ColumnIndex + 3) <> "FINAL_RESULT" Or
               g_body5.FieldName(g_body5.ColumnIndex + 3) <> "RS_01" Then

                'abc = g_body5.Text(g_body5.FieldName(g_body5.ColumnIndex + 3), g_body5.RowIndex)
                'If g_body5.Text("RS_01", g_body5.RowIndex) <> g_body5.Text(g_body5.FieldName(g_body5.ColumnIndex + 3), g_body5.RowIndex) Then
                If g_body5.Text(g_body5.FieldName(g_body5.ColumnIndex + 3), g_body5.RowIndex) = "" Then
                    'If g_body5.Text(g_body5.FieldName(g_body5.ColumnIndex + 2)) = g_body5.Text(g_body5.FieldName(g_body5.ColumnIndex + 3), g_body5.RowIndex) Then

                    g_body5.Text(g_body5.FieldName(g_body5.ColumnIndex + 3), g_body5.RowIndex) = g_body5.Text(g_body5.FieldName(g_body5.ColumnIndex + 2), g_body5.RowIndex)

                    'Else
                    'End If
                End If
            End If
        End If

    End Sub

  

    'Private Sub g_body5_Keyup(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles g_body5.KeyDown
    '    'Dim abc As String
    '    If e.KeyCode = Keys.Enter Then
    '        If g_body5.FieldName(g_body5.ColumnIndex + 3) = "RS_01" Then

    '        Else

    '            If g_body5.FieldName(g_body5.ColumnIndex + 3) <> "FINAL_RESULT" Or
    '               g_body5.FieldName(g_body5.ColumnIndex + 3) <> "RS_01" Then

    '                'abc = g_body5.Text(g_body5.FieldName(g_body5.ColumnIndex + 3), g_body5.RowIndex)
    '                'If g_body5.Text("RS_01", g_body5.RowIndex) <> g_body5.Text(g_body5.FieldName(g_body5.ColumnIndex + 3), g_body5.RowIndex) Then
    '                If g_body5.Text(g_body5.FieldName(g_body5.ColumnIndex + 3), g_body5.RowIndex) = "" Then
    '                    'If g_body5.Text(g_body5.FieldName(g_body5.ColumnIndex + 2)) = g_body5.Text(g_body5.FieldName(g_body5.ColumnIndex + 3), g_body5.RowIndex) Then

    '                    g_body5.Text(g_body5.FieldName(g_body5.ColumnIndex + 3), g_body5.RowIndex) = g_body5.Text(g_body5.FieldName(g_body5.ColumnIndex + 2), g_body5.RowIndex)

    '                    'Else
    '                    'End If
    '                End If
    '            End If
    '        End If
    '    End If

    'End Sub

  

    'Private Sub g_body5_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles g_body5.KeyPress
    '    g_body5.Focus()
    '    MsgBox("11111")

    'End Sub

    'Private Sub g_body5_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles g_body5.KeyUp
    ''Dim abc As String
    'If e.KeyCode = Keys.Enter Then
    '    If g_body5.FieldName(g_body5.ColumnIndex + 3) = "RS_01" Then

    '    Else

    '        If g_body5.FieldName(g_body5.ColumnIndex + 3) <> "FINAL_RESULT" Or
    '           g_body5.FieldName(g_body5.ColumnIndex + 3) <> "RS_01" Then

    '            'abc = g_body5.Text(g_body5.FieldName(g_body5.ColumnIndex + 3), g_body5.RowIndex)
    '            'If g_body5.Text("RS_01", g_body5.RowIndex) <> g_body5.Text(g_body5.FieldName(g_body5.ColumnIndex + 3), g_body5.RowIndex) Then
    '            If g_body5.Text(g_body5.FieldName(g_body5.ColumnIndex + 3), g_body5.RowIndex) = "" Then
    '                'If g_body5.Text(g_body5.FieldName(g_body5.ColumnIndex + 2)) = g_body5.Text(g_body5.FieldName(g_body5.ColumnIndex + 3), g_body5.RowIndex) Then

    '                g_body5.Text(g_body5.FieldName(g_body5.ColumnIndex + 3), g_body5.RowIndex) = g_body5.Text(g_body5.FieldName(g_body5.ColumnIndex + 2), g_body5.RowIndex)

    '                'Else
    '                'End If
    '            End If
    '        End If
    '    End If
    'End If
    ' End Sub
End Class
