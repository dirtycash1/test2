Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data
Imports System.Collections

Public Class WI_PR1123
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If find_visible2.Checked Then MenuButton_Click(MenuType.Find)
        Me.Clear()
        'Me.Open()
        'MenuButton_Click(MenuType.Find)
        remark1.ReadOnly = True
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                'Me.Open()
                '    'Open_Form()

            Case MenuType.Save
                If Not Saves() Then Exit Sub

            Case MenuType.Cancel
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

        '20141229 특기사항 추가 smk
        'If InStr(1, remark.Text, "(분리,") <> 0 Then
        '    remark.Text = remark.Text
        'Else
        '    remark.Text = remark.Text + "(분리," + ps_nm.Text + ")"
        'End If

        If Check_Stts() = "C" Then '상태값 CHECK
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        Me.totQty()

        If job_qty.ToDec < tot_qty.ToDec Then
            MsgBox("합계수량이 지시수량보다 많습니다.!")
            Return False
        End If

        'If Check_Jisi() = "C" Then    '20160405smk
        'Else
        '    MsgBox("분리지시가 확인되지 않았습니다.")
        '    Return False
        'End If


        '20150130 smk  (지시수량 = 투입수량)
        'MsgBox(ToStr(g_body.Text("TUIP_QTY", g_body.RowIndex)))
        'If g_body.Text("TUIP_QTY", g_body.RowIndex) <> job_qty.ToDec Then     'job_qty.ToDec <--- .text로 하면 안됨!
        '    MsgBox("지시수량과 투입수량이 같지 않습니다.")
        '    Return False
        'End If


        If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            Max_NO()  '전표채번..

            If MyBase.Save() Then
                'MyBase.OpenTrigger("wi_sa1120_list")
            Else
                Return False
            End If

            '20150223 SMK (특이사항 저장)            
            If remark2.Text = "" Or ToStr(Len(LTrim(remark2.Text))) = 0 Then
            Else
                p.Add("@lot_no", lot_no.Text)
                p.Add("@gong_cd", gong_cd.Text)

                If InStr(1, remark2.Text, "(분리/") <> 0 Then  '분리라는 메모가 있으면,  
                    p.Add("@remark", remark2.Text)
                Else
                    p.Add("@remark", remark2.Text + "(분리/" + ps_nm.Text + ")")
                End If

                Me.Open("wi_pr1122_rmk_update", p)
            End If

            '20150107 smk (REMARK 저장)
            'p.Clear()
            'p.Add("@lot_no", lot_no.Text)
            'p.Add("@remark", remark.Text)
            'Dim rmk_len As Integer = 0
            'rmk_len = InStr(1, remark.Text, "2.분리")         '2.분리가 시작되는 글자위치를 찾아. 
            'If Len(remark.Text.Substring(rmk_len)) > 10 Then  '분리에 메모를 했다는 소리
            '    p.Add("@gong_cd", gong_cd.Text)
            '    Me.Open("wi_pr1122_rmk_update", p)
            'Else                    '분리에 메모하지 않았다면, 사출에 있는 메모 가져와서 분리에 저장을 해.
            '    p.Add("@gong_cd", "10")
            '    Dim dSet As Data.DataSet = Me.OpenDataSet("wi_pr1123_rmk", p)
            '    Dim iRow As Integer = 0
            '    Dim dRow As DataRow, dRows As DataRowCollection
            '    If Not IsEmpty(dSet) Then
            '        dRows = dSet.Tables(0).Rows
            '        For Each dRow In dRows   '그냥 사출 메모만 있음.
            '            remark.Text = ToStr(dRow("REMARK"))
            '        Next
            '    End If
            '    p.Clear()
            '    p.Add("@lot_no", lot_no.Text)
            '    p.Add("@remark", remark.Text)
            '    p.Add("@gong_cd", "20")
            '    Me.Open("wi_pr1122_rmk_update", p)
            'End If

            stts.Text = "S"
        End If

        '거래처 체크
        If Not Me.Check_CsCd() Then
            Return False
        End If

        Return True
    End Function

    Private Function Check_Stts() As String
        p.Clear()
        p.Add("@pr_no", pr_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("WI_PR1123_stts", p)
        Dim stts As String = "S"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Function Check_Jisi() As String   '20150630 smk
        p.Clear()
        p.Add("@find_lot_no2", lot_no.Text)
        p.Add("@find_from2", find_from2.Text)
        p.Add("@find_to2", find_to2.Text)
        p.Add("@find_mc_cd2", find_mc_cd2.Text)
        p.Add("@find_gd_nm2", find_gd_nm2.Text)
        p.Add("@find_job_no2", find_gd_nm2.Text)


        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_pr1123_list2", p)
        Dim stts As String = ""

        If Not IsEmpty(dSet) Then stts = "C"

        Return stts

    End Function


    Private Sub Max_NO()
        ' p/o 번호 채번
        pr_no.CodeNo = "WI_PR1123"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
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

            Me.Open("WI_PR1123_delete", p)

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
            'Me.Open("WI_PR1123_confirm")

            p.Clear()
            p.Add("@pr_no", pr_no.Text)
            p.Add("@stts", "C")

            Me.Open("WI_PR1123_confirm", p)

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

        If Check_deconfirm() = "Y" Then
            MsgBox("재고가 부족하여 취소할수 없습니다.!")
            Return False
        End If


        If Check_deconfirm2() = "Y" Then    '완제품 존재 여부 체크  20150128SMK
            MsgBox("완제품 지시가 내려져 취소할 수 없습니다.!")
            Return False
        End If


        If MessageYesNo("확인취소 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@pr_no", pr_no.Text)
            p.Add("@stts", "S")

            Me.Open("WI_PR1123_confirm", p)

            stts.Text = "S"
        End If

        Return True
    End Function

    Private Function Check_deconfirm() As String
        p.Clear()
        p.Add("@PR_NO", pr_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_pr1123_deconfirm", p)
        Dim stts As String = "N"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Function Check_deconfirm2() As String   '완제품 여부 체크 20150128SMK
        p.Clear()
        p.Add("@LOT_NO", lot_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_pr1123_deconfirm2", p)
        Dim stts As String = "N"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

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

        Me.Open("WI_PR1123_head", p)
        Me.Open("WI_PR1123_body", p)
        Me.Open("WI_PR1123_body1", p)
        Me.Open("WI_PR1123_body2", p)
        Me.Open("WI_PR1123_body3", p)
        Me.Open("WI_PR1123_body4", p)
        Me.Open("WI_PR1123_body5", p)

    End Sub
    Public Sub Open3(ByVal OUTRNO As String) ', ByVal OUTRDT As String) ', ByVal faccd As String, ByVal whcd As String) ' ByVal outwh As String,

        pr_no.Text = OUTRNO
        p.Clear()
        p.Add("@pr_no", pr_no.Text)
        Me.Open("WI_PR1123_head", p)
        Me.Open("WI_PR1123_body", p)
        Me.Open("WI_PR1123_body1", p)
        Me.Open("WI_PR1123_body2", p)
        Me.Open("WI_PR1123_body3", p)
        Me.Open("WI_PR1123_body4", p)
        Me.Open("WI_PR1123_body5", p)


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
        p.Add("@@find_lot_no", find_lot_no.Text)

        Me.Open("WI_PR1123_list", p)
    End Sub

    Private Sub find_Clear2()
        p.Clear()
        p.Add("@find_from2", find_from2.Text)
        p.Add("@find_to2", find_to2.Text)
        p.Add("@find_gd_nm2", "XXX")
        p.Add("@find_job_no2", find_job_no2.Text)
        p.Add("@@find_lot_no2", find_lot_no2.Text)

        Me.Open("WI_PR1123_list2", p)
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
    End Sub

    'Private Sub rate_TextChanged(ByVal sender As Object, ByVal oldValue As String) Handles Rate.TextChanged
    '    won_amt.Text = bal_amt.ToDec * Rate.ToDec
    'End Sub

    Private Sub btn_find2_Click(sender As Object, e As System.EventArgs) Handles btn_find2.Click
        g_list2.Open()
    End Sub

    Private Sub g_list2_DoubleClick(sender As Object, e As System.EventArgs) Handles g_list2.DoubleClick   '등록할 자료 
        Me.Clear()
        remark2.Text = ""
        temp_lot_no.Text = g_list2.Text("LOT_NO", g_list2.RowIndex)
        'setJobNO()

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

        If find_visible2.Checked Then MenuButton_Click(MenuType.Find)

        'smk 20150107 사출 REMARK 보여주기 
        p.Clear()
        p.Add("@lot_no", g_list2.Text("LOT_NO", g_list2.RowIndex))
        p.Add("@gong_cd", "10")
        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_pr1123_rmk", p)
        Dim iRow As Integer = 0
        Dim dRow As DataRow, dRows As DataRowCollection
        If Not IsEmpty(dSet) Then
            dRows = dSet.Tables(0).Rows
            For Each dRow In dRows
                remark1.Text = ToStr(dRow("REMARK"))
            Next
        End If

        'If Not IsEmpty(dSet) Then
        '    dRows = dSet.Tables(0).Rows
        '    For Each dRow In dRows          '등록할 자료에는 '사출'메모만 존재.
        '        If InStr(1, ToStr(dRow("REMARK")), "1.사출") <> 0 Then        '사출 메모가 있으면, 
        '            remark.Text = ToStr(dRow("REMARK")) + vbCrLf + "2.분리," + ps_nm.Text + ": "      '2.분리에서 줄바꿈.
        '        Else
        '            remark.Text = "2.분리," + ps_nm.Text + ": "       '사출 메모 없을때는, 그냥 표기만.
        '        End If
        '    Next
        'End If



        '20150105 smk 작업자 실적수량
        p.Add("@ps_cd", ps_cd.Text)   'Head의 ps_cd
        p.Add("@pr_dt", Today)
        p.Add("@gong_cd", gong_cd.Text)

        Dim dSet3 As Data.DataSet = Me.OpenDataSet("wi_pr1124_ps_qty2", p)
        Dim dRow3 As DataRow, dRows3 As DataRowCollection
        dRows3 = dSet3.Tables(0).Rows

        If Not IsEmpty(dSet3) Then
            For Each dRow3 In dRows3
                ps_qty.Text = ToStr(dRow3("ps_qty"))
                ps_qty.Title = ToStr(dRow3("PS_NM")) + " 작업량"
            Next
        Else
            ps_qty.Text = ""
            ps_qty.Title = "작업량"
        End If

        p.Add("@mc_cd", mc_cd.Text)    '기계코드 실적수량 SMK 
        Dim dSet4 As Data.DataSet = Me.OpenDataSet("wi_pr1124_mc_qty", p)
        Dim dRow4 As DataRow, dRows4 As DataRowCollection
        dRows4 = dSet4.Tables(0).Rows

        If Not IsEmpty(dSet4) Then
            For Each dRow4 In dRows4
                mc_qty.Text = ToStr(dRow4("MC_QTY"))
            Next
        Else
            mc_qty.Text = ""
        End If
        '20150105 smk end


    End Sub

    Private Sub ng_qty_TextChanged(sender As Object, oldValue As String) Handles ng_qty.TextChanged
        Me.totQty()

    End Sub

    Private Sub pr_qty_TextChanged(sender As Object, oldValue As String) Handles pr_qty.TextChanged
        'With g_body    'SMK 20150130 막음
        '    .UpdateRow()
        '    For i As Integer = 0 To .RowCount - 1
        '        .Text("TUIP_QTY", i) = .ToDec("SO_QTY", i) * (pr_qty.ToDec + ng_qty.ToDec + sample_qty.ToDec)
        '    Next
        'End With

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

    Private Sub g_list_DoubleClick(sender As Object, e As System.EventArgs) Handles g_list.DoubleClick    '검색자료 
        temp_lot_no.Text = ""

        p.Clear()
        p.Add("@pr_no", g_list.Text("PR_NO", g_list.RowIndex))

        Me.Open("WI_PR1123_head", p)
        Me.Open("WI_PR1123_body", p)
        Me.Open("WI_PR1123_body1", p)
        Me.Open("WI_PR1123_body2", p)
        Me.Open("WI_PR1123_body3", p)
        Me.Open("WI_PR1123_body4", p)
        Me.Open("WI_PR1123_body5", p)

        If find_visible.Checked Then MenuButton_Click(MenuType.Find)

        'smk 20141230   '검색자료 
        'p.Add("@lot_no", g_list.Text("LOT_NO", g_list.RowIndex))
        'p.Add("@gong_cd", "20")
        'Dim dSet As Data.DataSet = Me.OpenDataSet("wi_pr1123_rmk", p)

        'If Not IsEmpty(dSet) Then
        '    Dim dRow As DataRow, dRows As DataRowCollection
        '    dRows = dSet.Tables(0).Rows
        '    For Each dRow In dRows
        '        If InStr(1, ToStr(dRow("REMARK")), "2.분리") <> 0 And InStr(1, ToStr(dRow("REMARK")), "1.사출") <> 0 Then     '사출,분리 메모 둘다 있으면, 
        '            remark.Text = ToStr(dRow("REMARK")).Replace("2.분리", vbCrLf + "2.분리")   '2.분리라는 글자부터 줄바꿈

        '        ElseIf InStr(1, ToStr(dRow("REMARK")), "1.사출") <> 0 And InStr(1, ToStr(dRow("REMARK")), "2.분리") = 0 Then  '사출은 있고, 분리 메모 없으면,
        '            p.Add("@gong_cd", "10")     '사출메모만 보여줘.
        '            Dim dSet2 As Data.DataSet = Me.OpenDataSet("wi_pr1123_rmk", p)
        '            If Not IsEmpty(dSet2) Then
        '                Dim dRow2 As DataRow, dRows2 As DataRowCollection
        '                dRows2 = dSet2.Tables(0).Rows
        '                For Each dRow2 In dRows2
        '                    remark.Text = remark.Text + vbCrLf + "2.분리," + ps_nm.Text + ": "  '사출10에 있는 걸 나타낸다.
        '                Next
        '            End If

        '        ElseIf InStr(1, ToStr(dRow("REMARK")), "1.사출") = 0 And InStr(1, ToStr(dRow("REMARK")), "2.분리") <> 0 Then  '사출은 없고, 분리는 있으면, 
        '            remark.Text = ToStr(dRow("REMARK"))
        '        Else  '둘다 없는 경우 
        '            remark.Text = "2.분리," + ps_nm.Text + ": "       '그냥 표기만 해.
        '        End If
        '    Next
        'End If

        '20150217 SMK (특이사항-사출)
        p.Clear()
        p.Add("@lot_no", g_list.Text("LOT_NO", g_list.RowIndex))
        p.Add("@gong_cd", "10")
        Dim dSet_S As Data.DataSet = Me.OpenDataSet("wi_pr1123_rmk", p)
        If Not IsEmpty(dSet_S) Then
            Dim iRow_S As Integer = 0
            Dim dRow_S As DataRow, dRows_S As DataRowCollection
            dRows_S = dSet_S.Tables(0).Rows
            For Each dRow_S In dRows_S
                remark1.Text = ToStr(dRow_S("REMARK"))
            Next
        End If

        '20150217 SMK (특이사항-분리)
        p.Clear()
        p.Add("@lot_no", g_list.Text("LOT_NO", g_list.RowIndex))
        p.Add("@gong_cd", "20")
        Dim dSet_B As Data.DataSet = Me.OpenDataSet("wi_pr1123_rmk", p)
        If Not IsEmpty(dSet_B) Then
            Dim iRow_B As Integer = 0
            Dim dRow_B As DataRow, dRows_B As DataRowCollection
            dRows_B = dSet_B.Tables(0).Rows
            For Each dRow_B In dRows_B
                remark2.Text = ToStr(dRow_B("REMARK"))
            Next
        End If


        '20150203 smk 작업자 실적수량
        p.Add("@ps_cd", ps_cd.Text) 'g_body4.Text("PS_CD", g_body4.RowIndex))
        p.Add("@pr_dt", pr_dt.Text)
        p.Add("@gong_cd", gong_cd.Text)

        Dim dSet4 As Data.DataSet = Me.OpenDataSet("wi_pr1124_ps_qty2", p)
        Dim dRow4 As DataRow, dRows4 As DataRowCollection
        dRows4 = dSet4.Tables(0).Rows

        If Not IsEmpty(dSet4) Then
            For Each dRow4 In dRows4
                ps_qty.Text = ToStr(dRow4("ps_qty"))
                ps_qty.Title = ToStr(dRow4("PS_NM")) + " 작업량"
            Next
        Else
            ps_qty.Text = ""
            ps_qty.Title = "작업량"
        End If

        p.Add("@mc_cd", mc_cd.Text)    '기계코드 실적수량 SMK 
        Dim dSet5 As Data.DataSet = Me.OpenDataSet("wi_pr1124_mc_qty", p)
        Dim dRow5 As DataRow, dRows5 As DataRowCollection
        dRows5 = dSet5.Tables(0).Rows

        If Not IsEmpty(dSet5) Then
            For Each dRow5 In dRows5
                mc_qty.Text = ToStr(dRow5("MC_QTY"))
            Next
        Else
            mc_qty.Text = ""
        End If
        '20150203 smk end

    End Sub

    'Private Sub pr_jobno_TextChanged(sender As Object, oldValue As String) Handles pr_jobno.TextChanged
    '    'Me.Clear()

    '    setJobNO()
    'End Sub

    Private Sub setJobNO()

        If lot_no.Text = Nothing Then Exit Sub
        If gong_cd.Text = Nothing Then Exit Sub

        Dim s_pr_jobno As String = "", s_gong_cd As String = ""

        s_pr_jobno = lot_no.Text
        s_gong_cd = gong_cd.Text

        p.Clear()
        p.Add("@lot_no", lot_no.Text)
        p.Add("@gong_cd", gong_cd.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("WI_PR1123_jobno", p)

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
        p.Add("@pr_no", "XXXX")
        Me.Open("WI_PR1123_body", p)
        Me.Open("WI_PR1123_body1", p)
        Me.Open("WI_PR1123_body2", p)
        Me.Open("WI_PR1123_body3", p)
        Me.Open("WI_PR1123_body4", p)
        Me.Open("WI_PR1123_body5", p)


        p.Clear()
        p.Add("@GD_CD", gd_cd.Text)
        p.Add("@GONG_CD", gong_cd.Text)

        dSet = Me.OpenDataSet("WI_PR1123_bom", p)
        Dim ll_row As Integer = 0

        If Not IsEmpty(dSet) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            With g_body
                ll_row = .RowIndex
                For Each dRow In dRows
                    .InsertNewRow(ll_row)

                    .Text("GD_CD", ll_row) = ToStr(dRow("JA_CD"))
                    .Text("GD_NM", ll_row) = ToStr(dRow("GD_NM"))
                    '.Text("SPEC", ll_row) = ToStr(dRow("SPEC"))
                    .Text("SO_QTY", ll_row) = ToStr(dRow("QTY"))
                    .Text("TUIP_QTY", ll_row) = ToStr(dRow("QTY") * job_qty.ToDec)   '오픈되거나 LIST에서 선택시, 지시수량과 하단 투입량 맞춰줌.

                    'If ja_cd.Text = .Text("GD_CD", ll_row) Then
                    .Text("LOT_NO", ll_row) = lot_no.Text

                    'End If

                Next
            End With
        Else
            Exit Sub
        End If

    End Sub

    Private Sub gong_cd_TextChanged(sender As Object, e As System.EventArgs) Handles gong_cd.TextChanged
        setJobNO()
    End Sub

    Private Sub lot_no_TextChanged(sender As Object, oldValue As String) Handles lot_no.TextChanged
        setJobNO()
    End Sub

    Private Sub temp_lot_no_TextChanged(sender As Object, oldValue As String) Handles temp_lot_no.TextChanged
        Me.Clear()

        lot_no.Text = temp_lot_no.Text
    End Sub

    Private Sub g_body1_CellValueChanged1(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g_body1.CellValueChanged
        If g_body1.FieldName(g_body1.ColumnIndex + 1) <> "NG_QTY" Then Exit Sub
        'MsgBox(g_body1.FieldName(g_body1.ColumnIndex))
        totQty()
    End Sub

    Private Sub find_lot_no_TextChanged(sender As Object, oldValue As String) Handles find_lot_no.TextChanged
        g_list.Open()
    End Sub

    Private Sub find_lot_no2_TextChanged(sender As Object, oldValue As String) Handles find_lot_no2.TextChanged
        g_list2.Open()
    End Sub


    Private Sub spec_print_Click(sender As System.Object, e As System.EventArgs) Handles spec_print.Click
        Dim p As OpenParameters = New OpenParameters
        p.Add("@lot_no", lot_no.Text)
        p.Add("@pr_no", pr_no.Text)
        System7.ReportView.LoadView("WI_PR1123", "", "WI_PR1123_print", p, )
        'Dim p As OpenParameters = New OpenParameters
        '' MessageInfo(Mid(lot_no.Text, 1, 1))
        'If Mid(lot_no.Text, 1, 1) <> "B" And Mid(lot_no.Text, 1, 1) <> "b" Then
        '    p.Add("@lot_no", lot_no.Text)
        '    p.Add("@pr_no", pr_no.Text)
        '    ' MessageInfo(gong_cd.Text)
        '    If lot_no.Text <> "" And
        '        gong_cd.Text = "80" Then
        '        '   
        '        System7.ReportView.LoadView("WI_PR1124", "", "WI_PR1124_print", p, , False)
        '    Else
        '        MessageInfo("규격 검사만 출력 할수 있습니다. 또는 체크시트 번호가 없습니다.")
        '    End If
        'Else
        '    ' MessageInfo("1")
        '    p.Add("@lot_no", lot_no.Text)
        '    ' p.Add("@pr_no", pr_no.Text)
        '    If lot_no.Text <> "" And
        '        gong_cd.Text = "80" Then
        '        'MessageInfo("1")
        '        System7.ReportView.LoadView("WI_PR1124_2", "", "WI_PR1124R2_print", p, , False)
        '    Else
        '        MessageInfo("규격 검사만 출력 할수 있습니다. 또는 체크시트 번호가 없습니다.")
        '    End If
        'End If

        'Return
    End Sub
End Class
