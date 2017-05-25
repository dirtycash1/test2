Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_JA1165
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
        Me.Clear()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                'Me.Open()
                '    'Open_Form()
            Case MenuType.Save
                If Not Saves() Then Exit Sub

            Case MenuType.Cancel
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

        g_body.AddNewRow()
    End Sub

    Private Sub Max_NO()
        ' p/o 번호 채번
        ip_no.CodeNo = "WI_ja1165"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        ip_no.CodeDateField = ip_dt

    End Sub

    Private Function Saves() As Boolean

        If Check_Stts() = "C" Then '상태값 CHECK
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        If Not Me.totQty() Then
            MsgBox("수량을 확인하세요.!")
            Return False
        End If


        'If job_qty.ToDec < tot_qty.ToDec Then
        '    MsgBox("합계수량이 지시수량보다 많습니다.!")
        '    Return False
        'End If


        If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            Max_NO()  '전표채번..

            If MyBase.Save() Then
                'MyBase.OpenTrigger("wi_sa1120_list")
            End If

            stts.Text = "S"
        End If        '

        Return True
    End Function

    Private Function totQty() As Boolean
        With g_body
            .UpdateRow()
            For i As Integer = 0 To .RowCount - 1
                If .ToDec("RM_QTY", i) < .ToDec("IP_QTY", i) + .ToDec("NG_QTY", i) Then Return False
            Next
        End With

        Return True
        'bi_amt.Text = sum_amt
    End Function

    Private Function check_totQty() As Boolean
        Dim i As Integer

        For i = 0 To g_body.RowCount - 1
            If g_body.ToDec("TOT_AMT", i) = 0 Then
                g_body.DeleteRow(i)
                i = i - 1
                g_body.UpdateRow()
                If i = g_body.RowCount - 1 Then Exit For
            End If
        Next


        MyBase.Save()
        Return True
    End Function

    Private Function Check_Stts() As String
        p.Clear()
        p.Add("@ip_no", ip_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("WI_ja1165_stts", p)
        Dim stts As String = "S"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Function Del() As Boolean
        
        If ip_no.Text = Nothing Then
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
            p.Add("@ip_no", ip_no.Text)

            Me.Open("WI_ja1165_delete", p)

            Me.Clear()

            g_list.Open()

        End If

        Return True
    End Function

    Private Function ConFrim() As Boolean
        If ip_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        '상태값 CHECK
        If Check_Stts() = "C" Then
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        If Not Me.totQty() Then
            MsgBox("수량을 확인하세요.!")
            Return False
        End If

        If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            'Me.Open("WI_PR1127_confirm")
            check_totQty()

            p.Clear()
            p.Add("@ip_no", ip_no.Text)
            p.Add("@stts", "C")

            Me.Open("WI_ja1165_confirm", p)

            stts.Text = "C"
        End If

        Return True
    End Function

    Private Function DeConFrim() As Boolean
        If ip_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        '상태값 CHECK
        If Check_Stts() <> "C" Then
            MsgBox("확인된 자료가 아닙니다.!")
            Return False
        End If

        If MessageYesNo("확인취소 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@ip_no", ip_no.Text)
            p.Add("@stts", "S")

            Me.Open("WI_ja1165_confirm", p)

            stts.Text = "S"
        End If

        Return True
    End Function

    Private Sub BalAmt()
        Dim sum_amt As Double

        With g_body
            .UpdateRow()
            For i As Integer = 0 To .RowCount - 1
                sum_amt = sum_amt + .ToDec("IP_AMT", i)
            Next
        End With

        'ip_amt.Text = sum_amt
    End Sub

    Private Sub Clear()
        p.Clear()
        p.Add("@ip_no", "XXX")

        Me.Open("wi_ja1165_head", p)
        Me.Open("wi_ja1165_body", p)
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
        p.Add("@find_cs_nm", "XXX")

        Me.Open("wi_ja1165_list", p)
    End Sub

    Private Sub find_Clear2()
        p.Clear()
        p.Add("@find_from2", find_from2.Text)
        p.Add("@find_to2", find_to2.Text)
        p.Add("@find_cs_nm2", "XXX")
        p.Add("@find_bal_no2", find_bal_no2.Text)

        Me.Open("wi_ja1165_rq_ip", p)
    End Sub

    Private Sub btn_find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_find.Click
        g_list.Open()
    End Sub

    Private Sub g_body_CellValueChanged(ByVal sender As System.Object, ByVal ColumnName As System.String, ByVal RowIndex As System.Int32, ByRef Value As System.Object) Handles g_body.CellValueChanged
        With g_body
            If ColumnName = "IP_QTY" Or ColumnName = "IP_PRI" Then
                .Text("IP_AMT") = .ToDec("IP_QTY") * .ToDec("IP_PRI")
                Me.BalAmt()
            End If
        End With
    End Sub

    Private Sub g_list_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g_list.DoubleClick
        p.Clear()
        p.Add("@ip_no", g_list.Text("IP_NO", g_list.RowIndex))

        Me.Open("wi_ja1165_head", p)
        Me.Open("wi_ja1165_body", p)

        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.find_Clear()
    End Sub

    Private Sub btn_find2_Click(sender As System.Object, e As System.EventArgs) Handles btn_find2.Click
        g_list2.Open()
    End Sub

    Private Sub g_list2_DoubleClick(sender As Object, e As System.EventArgs) Handles g_list2.DoubleClick
        Me.Clear()
        bal_no.Text = g_list2.Text("JOB_NO", g_list2.RowIndex)

        If find_visible2.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    Private Sub btn_cancel2_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancel2.Click
        find_Clear2()
    End Sub

    Private Sub find_list2()
        Me.Clear()

        p.Clear()
        p.Add("@ip_no", g_list2.Text("IP_NO", g_list.RowIndex))

        Me.Open("wi_ja1165_head", p)
        Me.Open("wi_ja1165_body", p)
    End Sub

    Private Sub bal_no_TextChanged(sender As Object, oldValue As String) Handles bal_no.TextChanged
        setJobNO()
    End Sub

    Private Sub setJobNO()

        If bal_no.Text = Nothing Then Exit Sub

        Dim s_pr_jobno As String = "", s_gong_cd As String = ""

        s_pr_jobno = bal_no.Text

        p.Clear()
        p.Add("@job_no", bal_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("WI_ja1165_jobno", p)

        'Me.Clear()

        If Not IsEmpty(dSet) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            For Each dRow In dRows
                bal_no.Text = ToStr(dRow("JOB_NO"))
                job_qty.Text = ToStr(dRow("JOB_QTY"))
                job_type.Text = ToStr(dRow("JOB_TYPE"))
                GD_CD.Text = ToStr(dRow("GD_CD"))
                gd_nm.Text = ToStr(dRow("gd_nm"))
                spec.Text = ToStr(dRow("spec"))
                unit_cd.Text = ToStr(dRow("unit_cd"))
                FWH_CD.Text = ToStr(dRow("FWH_CD"))
                TWH_CD.Text = ToStr(dRow("TWH_CD"))
                'ja_cd.Text = ToStr(dRow("ja_cd"))
                'lot_no.Text = ToStr(dRow("lot_no"))

            Next
        Else
            Me.Clear()
            'pr_jobno.Text = s_pr_jobno
            'gong_cd.Text = s_gong_cd
            Exit Sub
        End If

        p.Clear()
        p.Add("@IP_NO", "XXXX")
        Me.Open("WI_JA1165_body", p)

        p.Clear()
        p.Add("@JOB_NO", bal_no.Text)

        dSet = Me.OpenDataSet("WI_JA1165_SET", p)
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
                    .Text("SPEC", ll_row) = ToStr(dRow("SPEC"))
                    .Text("UNIT_CD", ll_row) = ToStr(dRow("UNIT_CD"))
                    .Text("BAL_QTY", ll_row) = ToStr(dRow("QTY"))
                    .Text("RM_QTY", ll_row) = ToStr(dRow("RM_QTY"))

                    'If ja_cd.Text = .Text("GD_CD", ll_row) Then
                    .Text("LOT_NO", ll_row) = ToStr(dRow("LOT_NO"))
                    .Text("IP_SEQ", ll_row) = ToStr(dRow("JOB_SEQ"))
                    .Text("BAL_SEQ", ll_row) = ToStr(dRow("JOB_SEQ"))
                    .Text("BAL_NO", ll_row) = ToStr(dRow("BAL_NO"))

                    'End If

                Next
            End With
        Else
            Exit Sub
        End If

    End Sub
    Private Sub g_body_ButtonPressed(sender As Object, columnName As String) Handles g_body.ButtonPressed

        Try
            If columnName = "CHK" Then

                If Me.Save() Then
                    'MessageInfo(Mid(g_body.Text("LOT_NO"), 1, 1))
                    'If Mid(g_body.Text("LOT_NO"), 1, 1) <> "B" And
                    '   Mid(g_body.Text("LOT_NO"), 1, 1) <> "b" Then
                    'Dim pp As OpenParameters = New OpenParameters
                    ' pp.Add("@lot_no", g_body.Text("LOT_NO"))
                    ' pp.Add("@chul_no", chul_no.Text)
                    ' System7.ReportView.LoadView("WI_JA1390", "", "WI_JA1390_print", pp, )
                    'Else
                    If stts.Text = "C" Then '170109smk 윤준경요청 
                        Dim pp As OpenParameters = New OpenParameters
                        pp.Add("@lot_no", g_body.Text("LOT_NO"))
                        pp.Add("@IP_QTY", g_body.Text("IP_QTY"))
                        pp.Add("@IP_NO", ip_no.Text)
                        'pp.Add("@chul_no", chul_no.Text)
                        System7.ReportView.LoadView("WI_JA1165", "", "WI_JA1165_PRINTS", pp, )

                        'End If
                    Else
                        MessageInfo("확인처리된 데이터가 아닙니다. 확인해주세요.")
                    End If

                End If
                End If

        Catch ex As Exception
            MessageError(ex)
        End Try





    End Sub
    Private Sub label_print_Click(sender As System.Object, e As System.EventArgs)
        Dim p As OpenParameters = New OpenParameters
        p.Add("@LOT_NO", g_body.Text("LOT_NO", g_body.RowIndex))
        'If lot_no.Text <> "" And stts.Text = "C" Then
        System7.ReportView.LoadView("WI_JA1165", "", "WI_JA1165_print", p, )
        'Else
        '    MessageInfo("확인 및 Notno가 없습니다. 다시 확인 하세요")
        'End If

        Return
    End Sub
End Class
