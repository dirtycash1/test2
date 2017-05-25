Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data
Imports System.Collections

Public Class WI_PR1122
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If find_visible2.Checked Then MenuButton_Click(MenuType.Find)
        Me.Clear()

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open


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
        'Clear()

        g_body1.AddNewRow()
    End Sub

    Private Function Saves() As Boolean

        If Check_Stts() = "C" Then '상태값 CHECK
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        Me.totQty()


        If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            Max_NO()  '전표채번..

            '20160202 smk 중지코드 여부 확인
            p.Clear()
            p.Add("@gd_cd", new_gdcd.Text)

            Dim dSet As Data.DataSet = Me.OpenDataSet("wi_pr1122_stop_yn", p)
            If Not IsEmpty(dSet) Then
                Dim iRow As Integer = 0
                Dim dRow As DataRow, dRows As DataRowCollection
                dRows = dSet.Tables(0).Rows

                For Each dRow In dRows
                    If ToStr(dRow("stop_yn")) = "1" Then
                        MsgBox("중지코드 입니다. 입력된 양품은 불량으로 처리 됩니다.")


                        For i = 0 To g_body1.RowCount
                            g_body1.Text("NG_QTY", i) = ""
                        Next

                        g_body1.Text("NG_QTY", g_body1.RowCount - 1) = pr_qty.Text
              
                        ng_qty.Text = tot_qty.Text
                        pr_qty.Text = 0
                        pop_qty.Text = 0
                        tot_qty.Text = 0
                        sample_qty.Text = 0
                        stop_yn.Text = "1"

                        If MyBase.Save() Then
                        Else
                            Return False
                        End If

                    Else   '중지코드 아닐때 그냥저장
                        stop_yn.Text = "0"
                        If MyBase.Save() Then
                        Else
                            Return False
                        End If

                    End If
                Next
            End If

            '20150223 특기사항 추가 smk
            If remark.Text = "" Or ToStr(Len(LTrim(remark.Text))) = 0 Then
            Else
                p.Clear()
                p.Add("@lot_no", lot_no.Text)
                p.Add("@gong_cd", gong_cd.Text)

                If InStr(1, remark.Text, "(사출/") <> 0 Then  '사출이라는 메모가 있으면,  
                    p.Add("@remark", remark.Text)
                Else
                    p.Add("@remark", remark.Text + "(사출/" + ps_nm.Text + ")")
                End If
                Me.Open("wi_pr1122_rmk_update", p)
            End If

            stts.Text = "S"


        End If

        '거래처 체크
        If Not Me.Check_CsCd() Then
            Return False
        End If


        '20160202 smk 잠깐 막기 
        'If MyBase.Save() Then
        '    'MyBase.OpenTrigger("wi_sa1120_list") '원래 막힘
        'Else
        '    Return False

        'End If

        '20141230 smk (REMARK 저장)
        'p.Clear()
        'p.Add("@lot_no", lot_no.Text)
        'p.Add("@gong_cd", gong_cd.Text)
        'p.Add("@remark", remark.Text)
        'Me.Open("wi_pr1122_rmk_update", p)

        Return True
    End Function

    Private Function Check_Stts() As String
        p.Clear()
        p.Add("@pr_no", pr_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("WI_PR1122_stts", p)
        Dim stts As String = "S"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Sub Max_NO()
        ' p/o 번호 채번
        pr_no.CodeNo = "WI_PR1122"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
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

            Me.Open("WI_PR1122_delete", p)

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
            'Me.Open("WI_PR1122_confirm")

            p.Clear()
            p.Add("@pr_no", pr_no.Text)
            p.Add("@stts", "C")

            Me.Open("WI_PR1122_confirm", p)

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

        If Check_deconfirm2() = "Y" Then    '분리 존재 여부 체크  20150128SMK
            MsgBox("분리지시가 내려져 취소할 수 없습니다.!")
            Return False
        End If


        If MessageYesNo("확인취소 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@pr_no", pr_no.Text)
            p.Add("@stts", "S")

            Me.Open("WI_PR1122_confirm", p)

            stts.Text = "S"

            job_qty.Update()
        End If


        Return True
    End Function

    Private Function Check_deconfirm() As String
        p.Clear()
        p.Add("@PR_NO", pr_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_pr1122_deconfirm", p)
        Dim stts As String = "N"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Function Check_deconfirm2() As String   '분리 여부 체크 20150128SMK
        p.Clear()
        p.Add("@LOT_NO", lot_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_pr1122_deconfirm2", p)
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
        p.Add("@stop_yn", "XXX")

        Me.Open("WI_PR1122_head", p)
        Me.Open("WI_PR1122_body", p)
        Me.Open("WI_PR1122_body1", p)
        Me.Open("WI_PR1122_body2", p)
        Me.Open("WI_PR1122_body3", p)
        Me.Open("WI_PR1122_body4", p)
        Me.Open("WI_PR1122_body5", p)

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
        p.Add("@find_mc_cd", find_mc_cd.Text)
        p.Add("@find_lot_no", find_lot_no.Text)

        Me.Open("WI_PR1122_list", p)


    End Sub

    Private Sub find_Clear2()
        p.Clear()
        p.Add("@find_from2", find_from2.Text)
        p.Add("@find_to2", find_to2.Text)
        p.Add("@find_gd_nm2", "XXX")
        p.Add("@find_job_no2", find_job_no2.Text)
        p.Add("@find_mc_cd2", find_mc_cd2.Text)

        Me.Open("WI_PR1122_list2", p)
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
        tot_qty.Text = pop_qty.ToDec ' pr_qty.ToDec + ng_qty.ToDec + sample_qty.ToDec
        pr_qty.Text = pop_qty.ToDec - ng_qty.ToDec - sample_qty.ToDec

    End Sub

    Private Sub btn_find2_Click(sender As Object, e As System.EventArgs) Handles btn_find2.Click
        g_list2.Open()
    End Sub

    Private Sub g_list2_DoubleClick(sender As Object, e As System.EventArgs) Handles g_list2.DoubleClick
        Me.Clear()

        remark.Text = ""

        pr_jobno.Text = g_list2.Text("JOB_NO", g_list2.RowIndex)

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

        '20150116 SMK (불량이미지 조회)
        Call image_select()
        Call image_select2()
        Call image_select3()
        Call image_select4()
        Call image_select5()
        Call image_select6()
        Call image_select7()
        Call image_select8()
        Call image_select9()
        Call image_select10()
        Call image_select11()
        Call image_select12()


        '20160211 SMK (중지코드 여부 확인)
        p.Clear()
        p.Add("@gd_cd", new_gdcd.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_pr1122_stop_yn", p)
        If Not IsEmpty(dSet) Then
            Dim iRow As Integer = 0
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            For Each dRow In dRows
                If ToStr(dRow("stop_yn")) = "1" Then

                    p.Clear()
                    p.Add("@pr_no", g_list.Text("PR_NO", g_list.RowIndex))
                    p.Add("@stop_yn", "1")

                    Me.Open("WI_PR1122_body1", p)

                    For i = 0 To g_body1.RowCount
                        g_body1.Text("NG_QTY", i) = ""
                    Next

                    g_body1.Text("NG_QTY", g_body1.RowCount - 1) = pr_qty.Text

                Else

                End If
            Next
        End If

    End Sub

    Private Sub ng_qty_TextChanged(sender As Object, oldValue As String) Handles ng_qty.TextChanged
        Me.totQty()

    End Sub

    Private Sub pr_qty_TextChanged(sender As Object, oldValue As String) Handles pr_qty.TextChanged
        With g_body
            .UpdateRow()
            For i As Integer = 0 To .RowCount - 1
                .Text("TUIP_QTY", i) = .ToDec("SO_QTY", i) * (pr_qty.ToDec + ng_qty.ToDec + sample_qty.ToDec)
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
        p.Clear()
        p.Add("@pr_no", g_list.Text("PR_NO", g_list.RowIndex))


        '20160211 SMK (중지코드 여부 확인)
        p.Add("@gd_cd", new_gdcd.Text)

        Dim dSet1 As Data.DataSet = Me.OpenDataSet("wi_pr1122_stop_yn", p)
        If Not IsEmpty(dSet1) Then
            Dim iRow As Integer = 0
            Dim dRow1 As DataRow, dRows As DataRowCollection
            dRows = dSet1.Tables(0).Rows

            For Each dRow1 In dRows
                If ToStr(dRow1("stop_yn")) = "1" Then
                    p.Add("@stop_yn", "1")
                Else
                    p.Add("@stop_yn", "0")
                End If
            Next
        End If


        Me.Open("WI_PR1122_head", p)
        Me.Open("WI_PR1122_body", p)
        Me.Open("WI_PR1122_body1", p)
        Me.Open("WI_PR1122_body2", p)
        Me.Open("WI_PR1122_body3", p)
        Me.Open("WI_PR1122_body4", p)
        Me.Open("WI_PR1122_body5", p)

        'smk 20141230 
        p.Add("@lot_no", g_list.Text("LOT_NO", g_list.RowIndex))
        p.Add("@gong_cd", gong_cd.Text)
        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_pr1122_rmk", p)
        If Not IsEmpty(dSet) Then
                Dim iRow As Integer = 0
                Dim dRow As DataRow, dRows As DataRowCollection
                dRows = dSet.Tables(0).Rows

            For Each dRow In dRows
                remark.Text = ToStr(dRow("REMARK"))
            Next
        End If

        '20150116 SMK (불량이미지 조회)
        Call image_select()
        Call image_select2()
        Call image_select3()
        Call image_select4()
        Call image_select5()
        Call image_select6()
        Call image_select7()
        Call image_select8()
        Call image_select9()
        Call image_select10()
        Call image_select11()
        Call image_select12()

        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    Private Sub pr_jobno_TextChanged(sender As Object, oldValue As String) Handles pr_jobno.TextChanged
        'Me.Clear()
        setJobNO()
    End Sub

    Private Sub setJobNO()

        If pr_jobno.Text = Nothing Then Exit Sub
        If gong_cd.Text = Nothing Then Exit Sub

        Dim s_pr_jobno As String = "", s_gong_cd As String = ""

        s_pr_jobno = pr_jobno.Text
        s_gong_cd = gong_cd.Text

        p.Clear()
        p.Add("@pr_jobno", pr_jobno.Text)
        p.Add("@gong_cd", gong_cd.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("WI_PR1122_jobno", p)

        'Me.Clear()

        If Not IsEmpty(dSet) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            For Each dRow In dRows
                job_no.Text = ToStr(dRow("job_no"))
                job_seq.Text = ToStr(dRow("job_seq"))
                'gong_cd.Text = ToStr(dRow("gong_cd"))
                wa_cd.Text = ToStr(dRow("wa_cd"))
                mc_cd.Text = ToStr(dRow("mc_cd"))
                job_qty.Text = ToStr(dRow("job_qty"))
                gd_cd.Text = ToStr(dRow("gd_cd"))
                gd_nm.Text = ToStr(dRow("gd_nm"))
                spec.Text = ToStr(dRow("spec"))
                unit_cd.Text = ToStr(dRow("unit_cd"))
                new_gdcd.Text = ToStr(dRow("gd_cd"))
                mate_no.Text = ToStr(dRow("mate_no"))
                ja_cd.Text = ToStr(dRow("ja_cd"))
                mate_qty.Text = ToStr(dRow("mate_qty"))
                'lot_no.Text = ToStr(dRow("lot_no"))  '''''' 사출에서는 실적시 입력된다..
            Next
        Else
            Me.Clear()
            'pr_jobno.Text = s_pr_jobno
            'gong_cd.Text = s_gong_cd
            Exit Sub
        End If

        p.Clear()
        p.Add("@pr_no", "XXXX")
        Me.Open("WI_PR1122_body", p)

        p.Clear()
        p.Add("@GD_CD", gd_cd.Text)
        p.Add("@GONG_CD", gong_cd.Text)

        dSet = Me.OpenDataSet("WI_PR1122_bom", p)
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
                    ''.Text("TUIP_QTY", ll_row) = ToStr(dRow("QTY") * job_qty.ToDec)  '2012.09.11

                    If ja_cd.Text = .Text("GD_CD", ll_row) Then
                        .Text("LOT_NO", ll_row) = mate_no.Text
                        .Text("TUIP_QTY", ll_row) = mate_qty.Text
                    End If

                Next
            End With
        Else
            Exit Sub
        End If

    End Sub

    Private Sub gong_cd_TextChanged(sender As Object, e As System.EventArgs) Handles gong_cd.TextChanged
        setJobNO()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As System.EventArgs) Handles btn_save.Click
        If MessageYesNo("검사 결과를 저장 하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        Else
            Me.Save("wi_pr1122_body5")

        End If

    End Sub

    Private Sub btn_new_Click(sender As Object, e As System.EventArgs) Handles btn_new.Click
        If pr_no.Text = "" Then
            MsgBox("선택된 자료가 없습니다.!")
            Exit Sub
        End If

        If MessageYesNo("lot 분리 작업을 하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        Else
            p.Clear()
            p.Add("@pr_no", pr_no.Text)
            Me.Open("wi_pr1122_new", p)

        End If
    End Sub

    Private Sub g_body1_CellValueChanged1(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object)
        If g_body1.FieldName(g_body1.ColumnIndex + 1) <> "NG_QTY" Then Exit Sub
        'MsgBox(g_body1.FieldName(g_body1.ColumnIndex))
        totQty()
    End Sub

    '생산실적현황에서 넘어올때의 기능 
    Public Sub Open3(ByVal OUTRNO As String) ', ByVal OUTRDT As String) ', ByVal faccd As String, ByVal whcd As String) ' ByVal outwh As String,

        pr_no.Text = OUTRNO
        p.Clear()
        p.Add("@pr_no", pr_no.Text)

        '20160211 SMK (중지코드 여부 확인)
        p.Add("@gd_cd", new_gdcd.Text)
        Dim dSet1 As Data.DataSet = Me.OpenDataSet("wi_pr1122_stop_yn", p)
        If Not IsEmpty(dSet1) Then
            Dim iRow As Integer = 0
            Dim dRow1 As DataRow, dRows As DataRowCollection
            dRows = dSet1.Tables(0).Rows

            For Each dRow1 In dRows
                If ToStr(dRow1("stop_yn")) = "1" Then
                    p.Add("@stop_yn", "1")
                Else
                    p.Add("@stop_yn", "0")
                End If
            Next
        End If

        Me.Open("WI_PR1122_head", p)
        Me.Open("WI_PR1122_body", p)
        Me.Open("WI_PR1122_body1", p)
        Me.Open("WI_PR1122_body2", p)
        Me.Open("WI_PR1122_body3", p)
        Me.Open("WI_PR1122_body4", p)
        Me.Open("WI_PR1122_body5", p)

        '20150116 SMK (불량이미지 조회)
        Call image_select()
        Call image_select2()
        Call image_select3()
        Call image_select4()
        Call image_select5()
        Call image_select6()
        Call image_select7()
        Call image_select8()
        Call image_select9()
        Call image_select10()
        Call image_select11()
        Call image_select12()
    End Sub




    'Private Sub remark_TextChanged(sender As Object, e As System.EventArgs) Handles remark.TextChanged '20150216 SMK 

    '    '20141229 특기사항 추가 smk
    '    If InStr(1, remark.Text, "1.사출") <> 0 Then   '사출이라는 메모가 있으면, 
    '        remark.Text = remark.Text
    '    Else
    '        remark.Text = "1.사출," + ps_nm.Text + ": " + remark.Text
    '    End If

    'End Sub


    '이미지 삽입
    '#Region "FTP 관리"           

    '    Private Sub g_body1_ButtonPressed(sender As System.Object, columnName As System.String)

    '        Dim row_i As Integer = g_body1.RowIndex

    '        Dim fileID1 As String = g_body1.Text("file_id1", g_body1.RowIndex)
    '        Dim file_NM1 As String = g_body1.Text("file_nm1", g_body1.RowIndex)
    '        Dim fileID2 As String = g_body1.Text("file_id2", g_body1.RowIndex)
    '        Dim file_NM2 As String = g_body1.Text("file_nm2", g_body1.RowIndex)
    '        Dim fileID3 As String = g_body1.Text("file_id3", g_body1.RowIndex)
    '        Dim file_NM3 As String = g_body1.Text("file_nm3", g_body1.RowIndex)

    '        p.Clear()
    '        p.Add("@PR_NO", pr_no.Text)
    '        p.Add("@NG_CD", g_body1.Text("NG_CD", row_i))
    '        p.Add("@SEQ", g_body1.ToDec("PR_SEQ", row_i))

    '        If columnName = "upload1" Then          '파일첨부
    '            Call FileUpload("1")
    '        ElseIf columnName = "upload2" Then
    '            Call FileUpload("2")
    '        ElseIf columnName = "upload3" Then
    '            Call FileUpload("3")

    '        ElseIf columnName = "show1" Then         '파일보기
    '            [Shared].FileDownLoad(fileID1, file_NM1, , True)
    '        ElseIf columnName = "show2" Then
    '            [Shared].FileDownLoad(fileID2, file_NM2, , True)
    '        ElseIf columnName = "show3" Then
    '            [Shared].FileDownLoad(fileID3, file_NM3, , True)


    '        ElseIf columnName = "del1" Then         '파일삭제
    '            Try
    '                If [Shared].FileDelete(fileID1, file_NM1) = True Then
    '                    p.Add("@FILE_NO", "1")
    '                    p.Add("@FILE_ID", g_body1.Text("file_id1", row_i))
    '                    p.Add("@FILE_NM", g_body1.Text("file_nm1", row_i))
    '                    Me.Open("wi_pr1122_body1_imgDel", p)
    '                    g_body1.Text("file_nm1") = ""
    '                End If
    '            Catch ex As Exception
    '                MessageInfo(ex)
    '            End Try

    '        ElseIf columnName = "del2" Then
    '            Try
    '                If [Shared].FileDelete(fileID2, file_NM2) = True Then
    '                    p.Add("@FILE_NO", "2")
    '                    p.Add("@FILE_ID", g_body1.Text("file_id2", row_i))
    '                    p.Add("@FILE_NM", g_body1.Text("file_nm2", row_i))
    '                    Me.Open("wi_pr1122_body1_imgDel", p)
    '                    g_body1.Text("file_nm2") = ""
    '                End If
    '            Catch ex As Exception
    '                MessageInfo(ex)
    '            End Try

    '        ElseIf columnName = "del3" Then
    '            Try
    '                If [Shared].FileDelete(fileID3, file_NM3) = True Then
    '                    p.Add("@FILE_NO", "3")
    '                    p.Add("@FILE_ID", g_body1.Text("file_id3", row_i))
    '                    p.Add("@FILE_NM", g_body1.Text("file_nm3", row_i))
    '                    Me.Open("wi_pr1122_body1_imgDel", p)
    '                    g_body1.Text("file_nm3") = ""
    '                End If
    '            Catch ex As Exception
    '                MessageInfo(ex)
    '            End Try

    '            'ElseIf columnName = "down" Then
    '            '    [Shared].FileDownLoad(fileID, file_NM)
    '        End If

    '    End Sub
    '    Private Sub FileUpload(p1 As String)
    '        p.Clear()
    '        p.Add("@FILE_NO", p1)
    '        Dim row_i As Integer = g_body1.RowIndex
    '        Dim fileID As String = g_body1.Text("file_id" + p1, g_body1.RowIndex)

    '        Dim dialog As OpenFileDialog = New OpenFileDialog()
    '        dialog.Filter = "모든파일(*.*)|*.*"
    '        dialog.Title = "업로드할 파일을 선택 하세요"
    '        dialog.Multiselect = True

    '        'Dim FileID As String
    '        If dialog.ShowDialog() = DialogResult.OK Then

    '            If Not MyBase.Save("wi_pr1122_body1") Then
    '                '저장실패시 코드채번 취소
    '                Me.WorkSet("wi_pr1122_body1").RecoverCodeNo()
    '                Exit Sub
    '            Else
    '                'testm_no = estm_no.Text
    '                g_body1.Open()
    '            End If

    '            'Grid내 같은 File명 체크
    '            For Each FileNm As String In dialog.FileNames
    '                FileNm = System.IO.Path.GetFileName(FileNm)
    '                If Me._IsExists(g_body1, FileNm, p1) Then
    '                    MessageInfo("이미 같은 파일명을 가진 파일이 존재합니다." + _
    '                    vbLf + vbLf + "[" + FileNm + "]")
    '                    Exit Sub
    '                End If
    '            Next

    '            'g_body1.AllowAddRows = True

    '            Try
    '                For Each fullPath As String In dialog.FileNames

    '                    fileID = [Shared].FileUpload("", fullPath, "WI_PR1122", False)

    '                    If fullPath <> "" Then
    '                        Dim fileNm As String = System.IO.Path.GetFileName(fullPath)
    '                        Dim f As New System.IO.FileInfo(fullPath)

    '                        g_body1.Text("file_id" + p1, row_i) = fileID
    '                        g_body1.Text("file_nm" + p1, row_i) = fileNm
    '                        g_body1.Text("file_size" + p1, row_i) = f.Length.ToString

    '                    End If

    '                Next
    '                If g_body1.Text("NG_QTY", row_i) = "" Then

    '                Else
    '                    p.Add("@CID", ps_cd.Text)
    '                    p.Add("@FILE_ID", g_body1.Text("file_id" + p1, row_i))
    '                    p.Add("@FILE_NM", g_body1.Text("file_nm" + p1, row_i))
    '                    p.Add("@FILE_SIZE", g_body1.ToDec("file_size" + p1, row_i))
    '                    p.Add("@MID", ps_cd.Text)
    '                    p.Add("@NG_CD", g_body1.Text("NG_CD", row_i))
    '                    'p.Add("@NG_QTY", g_body1.Text("NG_QTY", row_i))
    '                    p.Add("@PR_NO", pr_no.Text)
    '                    p.Add("@SEQ", g_body1.ToDec("PR_SEQ", row_i))

    '                    Me.Open("wi_pr1122_body1_img", p)
    '                End If

    '            Catch ex As Exception
    '                MessageInfo(ex)
    '            Finally
    '                g_body1.AllowAddRows = False
    '            End Try

    '        End If

    '    End Sub

    '    Private Function _IsExists(ByVal g As eGrid, ByVal fileNm As String, p1 As String) As Boolean
    '        With g_body1
    '            For i As Integer = 0 To .RowCount - 1
    '                If .Text("file_nm" + p1, i) = fileNm Then Return True
    '            Next
    '        End With
    '        Return False
    '    End Function

    '#End Region             '이미지 삽입



#Region "1도.19.알떨어짐"
    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        PictureBox11.Visible = True
        PictureBox1.Visible = False
    End Sub
    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        PictureBox12.Visible = True
        PictureBox2.Visible = False
    End Sub
    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        PictureBox13.Visible = True
        PictureBox3.Visible = False
    End Sub
    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        PictureBox14.Visible = True
        PictureBox4.Visible = False
    End Sub
    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click
        PictureBox15.Visible = True
        PictureBox5.Visible = False
    End Sub
    Private Sub PictureBox6_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox6.Click
        PictureBox16.Visible = True
        PictureBox6.Visible = False
    End Sub
    Private Sub PictureBox7_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox7.Click
        PictureBox17.Visible = True
        PictureBox7.Visible = False
    End Sub
    Private Sub PictureBox8_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox8.Click
        PictureBox18.Visible = True
        PictureBox8.Visible = False
    End Sub
    Private Sub PictureBox9_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox9.Click
        PictureBox19.Visible = True
        PictureBox9.Visible = False
    End Sub

    Private Sub SAVE_IMG_Click(sender As System.Object, e As System.EventArgs) Handles SAVE_IMG.Click
        Dim one_do19 As String = ""

        p.Clear()
        p.Add("@PR_NO", pr_no.Text)
        p.Add("@PR_JOBNO", pr_jobno.Text)
        p.Add("@C_EMP", ps_cd.Text)
        p.Add("@M_EMP", ps_cd.Text)
        p.Add("@DO_GU", "1")     ' 1도짜리 

        If PictureBox11.Visible = True Then
            p.Add("@NG_CD", "19")   '불량코드 19 알떨어짐
            p.Add("@SPOT1", "1")
        Else
            p.Add("@NG_CD", "19")   '불량코드 19 알떨어짐
            p.Add("@SPOT1", "0")
        End If

        If PictureBox12.Visible = True Then
            p.Add("@NG_CD", "19")   '불량코드 19 알떨어짐
            p.Add("@SPOT2", "1")
        Else
            p.Add("@NG_CD", "19")   '불량코드 19 알떨어짐
            p.Add("@SPOT2", "0")
        End If

        If PictureBox13.Visible = True Then
            p.Add("@NG_CD", "19")   '불량코드 19 알떨어짐
            p.Add("@SPOT3", "1")
        Else
            p.Add("@NG_CD", "19")   '불량코드 19 알떨어짐
            p.Add("@SPOT3", "0")
        End If

        If PictureBox14.Visible = True Then
            p.Add("@NG_CD", "19")   '불량코드 19 알떨어짐
            p.Add("@SPOT4", "1")
        Else
            p.Add("@NG_CD", "19")   '불량코드 19 알떨어짐
            p.Add("@SPOT4", "0")
        End If

        If PictureBox15.Visible = True Then
            p.Add("@NG_CD", "19")   '불량코드 19 알떨어짐
            p.Add("@SPOT5", "1")
        Else
            p.Add("@NG_CD", "19")   '불량코드 19 알떨어짐
            p.Add("@SPOT5", "0")
        End If

        If PictureBox16.Visible = True Then
            p.Add("@NG_CD", "19")   '불량코드 19 알떨어짐
            p.Add("@SPOT6", "1")
        Else
            p.Add("@NG_CD", "19")   '불량코드 19 알떨어짐
            p.Add("@SPOT6", "0")
        End If

        If PictureBox17.Visible = True Then
            p.Add("@NG_CD", "19")   '불량코드 19 알떨어짐
            p.Add("@SPOT7", "1")
        Else
            p.Add("@NG_CD", "19")   '불량코드 19 알떨어짐
            p.Add("@SPOT7", "0")
        End If

        If PictureBox18.Visible = True Then
            p.Add("@NG_CD", "19")   '불량코드 19 알떨어짐
            p.Add("@SPOT8", "1")
        Else
            p.Add("@NG_CD", "19")   '불량코드 19 알떨어짐
            p.Add("@SPOT8", "0")
        End If

        If PictureBox19.Visible = True Then
            p.Add("@NG_CD", "19")   '불량코드 19 알떨어짐
            p.Add("@SPOT9", "1")
        Else
            p.Add("@NG_CD", "19")   '불량코드 19 알떨어짐
            p.Add("@SPOT9", "0")
        End If

        Me.Open("wi_pr1122_spot_save", p)

    End Sub

    Private Sub RESET_Click(sender As System.Object, e As System.EventArgs) Handles RESET.Click

        PictureBox1.Visible = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        PictureBox4.Visible = True
        PictureBox5.Visible = True
        PictureBox6.Visible = True
        PictureBox7.Visible = True
        PictureBox8.Visible = True
        PictureBox9.Visible = True

        PictureBox11.Visible = False
        PictureBox12.Visible = False
        PictureBox13.Visible = False
        PictureBox14.Visible = False
        PictureBox15.Visible = False
        PictureBox16.Visible = False
        PictureBox17.Visible = False
        PictureBox18.Visible = False
        PictureBox19.Visible = False

    End Sub

    Private Sub image_select()

        RESET.PerformClick()

        p.Clear()
        p.Add("@PR_NO", pr_no.Text)
        p.Add("@NG_CD", "19")
        p.Add("@DO_GU", "1")
        p.Add("@PR_JOBNO", pr_jobno.Text)

        'If pr_jobno.Text <> "" Then
        '    p.Add("@PR_JOBNO", pr_jobno.Text)
        'Else
        'End If

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_pr1122_spot_select", p)

        If Not IsEmpty(dSet) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            For Each dRow In dRows
                'If ToStr(dRow("NG_CD")) = "19" And ToStr(dRow("DO_GU")) = "1" Then
                '    p.Add("@DO_GU", "1")
                '    p.Add("@NG_CD", "19")

                If ToStr(dRow("SPOT1")) = "1" Then
                    PictureBox1.Visible = False
                    PictureBox11.Visible = True
                Else
                    PictureBox1.Visible = True
                    PictureBox11.Visible = False
                End If

                If ToStr(dRow("SPOT2")) = "1" Then
                    PictureBox2.Visible = False
                    PictureBox12.Visible = True
                Else
                    PictureBox2.Visible = True
                    PictureBox12.Visible = False
                End If

                If ToStr(dRow("SPOT3")) = "1" Then
                    PictureBox3.Visible = False
                    PictureBox13.Visible = True
                Else
                    PictureBox3.Visible = True
                    PictureBox13.Visible = False
                End If

                If ToStr(dRow("SPOT4")) = "1" Then
                    PictureBox4.Visible = False
                    PictureBox14.Visible = True
                Else
                    PictureBox4.Visible = True
                    PictureBox14.Visible = False
                End If

                If ToStr(dRow("SPOT5")) = "1" Then
                    PictureBox5.Visible = False
                    PictureBox15.Visible = True
                Else
                    PictureBox5.Visible = True
                    PictureBox15.Visible = False
                End If

                If ToStr(dRow("SPOT6")) = "1" Then
                    PictureBox6.Visible = False
                    PictureBox16.Visible = True
                Else
                    PictureBox6.Visible = True
                    PictureBox16.Visible = False
                End If

                If ToStr(dRow("SPOT7")) = "1" Then
                    PictureBox7.Visible = False
                    PictureBox17.Visible = True
                Else
                    PictureBox7.Visible = True
                    PictureBox17.Visible = False
                End If

                If ToStr(dRow("SPOT8")) = "1" Then
                    PictureBox8.Visible = False
                    PictureBox18.Visible = True
                Else
                    PictureBox8.Visible = True
                    PictureBox18.Visible = False
                End If

                If ToStr(dRow("SPOT9")) = "1" Then
                    PictureBox9.Visible = False
                    PictureBox19.Visible = True
                Else
                    PictureBox9.Visible = True
                    PictureBox19.Visible = False
                End If
                'End If

            Next
        Else
            Exit Sub
        End If

    End Sub
#End Region

#Region "1도.20.색상번짐"
    Private Sub PictureBox21_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox21.Click
        PictureBox31.Visible = True
        PictureBox21.Visible = False
    End Sub
    Private Sub PictureBox22_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox22.Click
        PictureBox32.Visible = True
        PictureBox22.Visible = False
    End Sub
    Private Sub PictureBox23_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox23.Click
        PictureBox33.Visible = True
        PictureBox23.Visible = False
    End Sub
    Private Sub PictureBox24_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox24.Click
        PictureBox34.Visible = True
        PictureBox24.Visible = False
    End Sub
    Private Sub PictureBox25_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox25.Click
        PictureBox35.Visible = True
        PictureBox25.Visible = False
    End Sub
    Private Sub PictureBox26_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox26.Click
        PictureBox36.Visible = True
        PictureBox26.Visible = False
    End Sub
    Private Sub PictureBox27_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox27.Click
        PictureBox37.Visible = True
        PictureBox27.Visible = False
    End Sub
    Private Sub PictureBox28_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox28.Click
        PictureBox38.Visible = True
        PictureBox28.Visible = False
    End Sub
    Private Sub PictureBox29_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox29.Click
        PictureBox39.Visible = True
        PictureBox29.Visible = False
    End Sub

    Private Sub SAVE_IMG2_Click(sender As System.Object, e As System.EventArgs) Handles SAVE_IMG2.Click
        Dim one_do20 As String = ""

        p.Clear()
        p.Add("@PR_NO", pr_no.Text)
        p.Add("@PR_JOBNO", pr_jobno.Text)
        p.Add("@C_EMP", ps_cd.Text)
        p.Add("@M_EMP", ps_cd.Text)
        p.Add("@DO_GU", "1")     ' 1도짜리 

        If PictureBox31.Visible = True Then
            p.Add("@NG_CD", "20")   '불량코드 20 색상번짐
            p.Add("@SPOT1", "1")
        Else
            p.Add("@NG_CD", "20")
            p.Add("@SPOT1", "0")
        End If

        If PictureBox32.Visible = True Then
            p.Add("@NG_CD", "20")   '불량코드 20 색상번짐
            p.Add("@SPOT2", "1")
        Else
            p.Add("@NG_CD", "20")
            p.Add("@SPOT2", "0")
        End If

        If PictureBox33.Visible = True Then
            p.Add("@NG_CD", "20")   '불량코드 20 색상번짐
            p.Add("@SPOT3", "1")
        Else
            p.Add("@NG_CD", "20")
            p.Add("@SPOT3", "0")
        End If

        If PictureBox34.Visible = True Then
            p.Add("@NG_CD", "20")   '불량코드 20 색상번짐
            p.Add("@SPOT4", "1")
        Else
            p.Add("@NG_CD", "20")
            p.Add("@SPOT4", "0")
        End If

        If PictureBox35.Visible = True Then
            p.Add("@NG_CD", "20")   '불량코드 20 색상번짐
            p.Add("@SPOT5", "1")
        Else
            p.Add("@NG_CD", "20")
            p.Add("@SPOT5", "0")
        End If

        If PictureBox36.Visible = True Then
            p.Add("@NG_CD", "20")     '불량코드 20 색상번짐
            p.Add("@SPOT6", "1")
        Else
            p.Add("@NG_CD", "20")
            p.Add("@SPOT6", "0")
        End If

        If PictureBox37.Visible = True Then
            p.Add("@NG_CD", "20")   '불량코드 20 색상번짐
            p.Add("@SPOT7", "1")
        Else
            p.Add("@NG_CD", "20")
            p.Add("@SPOT7", "0")
        End If

        If PictureBox38.Visible = True Then
            p.Add("@NG_CD", "20")   '불량코드 20 색상번짐
            p.Add("@SPOT8", "1")
        Else
            p.Add("@NG_CD", "20")
            p.Add("@SPOT8", "0")
        End If

        If PictureBox39.Visible = True Then
            p.Add("@NG_CD", "20")  '불량코드 20 색상번짐
            p.Add("@SPOT9", "1")
        Else
            p.Add("@NG_CD", "20")
            p.Add("@SPOT9", "0")
        End If

        Me.Open("wi_pr1122_spot_save", p)

    End Sub

    Private Sub RESET2_Click(sender As System.Object, e As System.EventArgs) Handles RESET2.Click

        PictureBox21.Visible = True
        PictureBox22.Visible = True
        PictureBox23.Visible = True
        PictureBox24.Visible = True
        PictureBox25.Visible = True
        PictureBox26.Visible = True
        PictureBox27.Visible = True
        PictureBox28.Visible = True
        PictureBox29.Visible = True

        PictureBox31.Visible = False
        PictureBox32.Visible = False
        PictureBox33.Visible = False
        PictureBox34.Visible = False
        PictureBox35.Visible = False
        PictureBox36.Visible = False
        PictureBox37.Visible = False
        PictureBox38.Visible = False
        PictureBox39.Visible = False

    End Sub

    Private Sub image_select2()

        RESET2.PerformClick()

        p.Clear()
        p.Add("@PR_NO", pr_no.Text)
        p.Add("@NG_CD", "20")
        p.Add("@DO_GU", "1")
        p.Add("@PR_JOBNO", pr_jobno.Text)

        'If pr_jobno.Text <> "" Then
        '    p.Add("@PR_JOBNO", pr_jobno.Text)
        'Else
        'End If

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_pr1122_spot_select", p)

        If Not IsEmpty(dSet) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            For Each dRow In dRows
                'If ToStr(dRow("NG_CD")) = "20" And ToStr(dRow("DO_GU")) = "1" Then
                '    p.Add("@DO_GU", "1")
                '    p.Add("@NG_CD", "20")

                If ToStr(dRow("SPOT1")) = "1" Then
                    PictureBox21.Visible = False
                    PictureBox31.Visible = True
                Else
                    PictureBox21.Visible = True
                    PictureBox31.Visible = False
                End If

                If ToStr(dRow("SPOT2")) = "1" Then
                    PictureBox22.Visible = False
                    PictureBox32.Visible = True
                Else
                    PictureBox22.Visible = True
                    PictureBox32.Visible = False
                End If

                If ToStr(dRow("SPOT3")) = "1" Then
                    PictureBox23.Visible = False
                    PictureBox33.Visible = True
                Else
                    PictureBox23.Visible = True
                    PictureBox33.Visible = False
                End If

                If ToStr(dRow("SPOT4")) = "1" Then
                    PictureBox24.Visible = False
                    PictureBox34.Visible = True
                Else
                    PictureBox24.Visible = True
                    PictureBox34.Visible = False
                End If

                If ToStr(dRow("SPOT5")) = "1" Then
                    PictureBox25.Visible = False
                    PictureBox35.Visible = True
                Else
                    PictureBox25.Visible = True
                    PictureBox35.Visible = False
                End If

                If ToStr(dRow("SPOT6")) = "1" Then
                    PictureBox26.Visible = False
                    PictureBox36.Visible = True
                Else
                    PictureBox26.Visible = True
                    PictureBox36.Visible = False
                End If

                If ToStr(dRow("SPOT7")) = "1" Then
                    PictureBox27.Visible = False
                    PictureBox37.Visible = True
                Else
                    PictureBox27.Visible = True
                    PictureBox37.Visible = False
                End If

                If ToStr(dRow("SPOT8")) = "1" Then
                    PictureBox28.Visible = False
                    PictureBox38.Visible = True
                Else
                    PictureBox28.Visible = True
                    PictureBox38.Visible = False
                End If

                If ToStr(dRow("SPOT9")) = "1" Then
                    PictureBox29.Visible = False
                    PictureBox39.Visible = True
                Else
                    PictureBox29.Visible = True
                    PictureBox39.Visible = False
                End If
                'End If

            Next
        Else
            Exit Sub
        End If

    End Sub
#End Region

#Region "1도.21.알+번짐"
    Private Sub PictureBox41_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox41.Click
        PictureBox51.Visible = True
        PictureBox41.Visible = False
    End Sub
    Private Sub PictureBox42_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox42.Click
        PictureBox52.Visible = True
        PictureBox42.Visible = False
    End Sub
    Private Sub PictureBox43_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox43.Click
        PictureBox53.Visible = True
        PictureBox43.Visible = False
    End Sub
    Private Sub PictureBox44_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox44.Click
        PictureBox54.Visible = True
        PictureBox44.Visible = False
    End Sub
    Private Sub PictureBox45_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox45.Click
        PictureBox55.Visible = True
        PictureBox45.Visible = False
    End Sub
    Private Sub PictureBox46_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox46.Click
        PictureBox56.Visible = True
        PictureBox46.Visible = False
    End Sub
    Private Sub PictureBox47_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox47.Click
        PictureBox57.Visible = True
        PictureBox47.Visible = False
    End Sub
    Private Sub PictureBox48_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox48.Click
        PictureBox58.Visible = True
        PictureBox48.Visible = False
    End Sub
    Private Sub PictureBox49_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox49.Click
        PictureBox59.Visible = True
        PictureBox49.Visible = False
    End Sub

    Private Sub SAVE_IMG3_Click(sender As System.Object, e As System.EventArgs) Handles SAVE_IMG3.Click
        Dim one_do20 As String = ""

        p.Clear()
        p.Add("@PR_NO", pr_no.Text)
        p.Add("@PR_JOBNO", pr_jobno.Text)
        p.Add("@C_EMP", ps_cd.Text)
        p.Add("@M_EMP", ps_cd.Text)
        p.Add("@DO_GU", "1")     ' 1도짜리 

        If PictureBox51.Visible = True Then
            p.Add("@NG_CD", "21")   '불량코드 21 알+번짐
            p.Add("@SPOT1", "1")
        Else
            p.Add("@NG_CD", "21")
            p.Add("@SPOT1", "0")
        End If

        If PictureBox52.Visible = True Then
            p.Add("@NG_CD", "21")   '불량코드 21 알+번짐
            p.Add("@SPOT2", "1")
        Else
            p.Add("@NG_CD", "21")
            p.Add("@SPOT2", "0")
        End If

        If PictureBox53.Visible = True Then
            p.Add("@NG_CD", "21")   '불량코드 21 알+번짐
            p.Add("@SPOT3", "1")
        Else
            p.Add("@NG_CD", "21")
            p.Add("@SPOT3", "0")
        End If

        If PictureBox54.Visible = True Then
            p.Add("@NG_CD", "21")   '불량코드 21 알+번짐
            p.Add("@SPOT4", "1")
        Else
            p.Add("@NG_CD", "21")
            p.Add("@SPOT4", "0")
        End If

        If PictureBox55.Visible = True Then
            p.Add("@NG_CD", "21")   '불량코드 21 알+번짐
            p.Add("@SPOT5", "1")
        Else
            p.Add("@NG_CD", "21")
            p.Add("@SPOT5", "0")
        End If

        If PictureBox56.Visible = True Then
            p.Add("@NG_CD", "21")     '불량코드 21 알+번짐
            p.Add("@SPOT6", "1")
        Else
            p.Add("@NG_CD", "21")
            p.Add("@SPOT6", "0")
        End If

        If PictureBox57.Visible = True Then
            p.Add("@NG_CD", "21")   '불량코드 21 알+번짐
            p.Add("@SPOT7", "1")
        Else
            p.Add("@NG_CD", "21")
            p.Add("@SPOT7", "0")
        End If

        If PictureBox58.Visible = True Then
            p.Add("@NG_CD", "21")   '불량코드 21 알+번짐
            p.Add("@SPOT8", "1")
        Else
            p.Add("@NG_CD", "21")
            p.Add("@SPOT8", "0")
        End If

        If PictureBox59.Visible = True Then
            p.Add("@NG_CD", "21")  '불량코드 21 알+번짐
            p.Add("@SPOT9", "1")
        Else
            p.Add("@NG_CD", "21")
            p.Add("@SPOT9", "0")
        End If

        Me.Open("wi_pr1122_spot_save", p)

    End Sub

    Private Sub RESET3_Click(sender As System.Object, e As System.EventArgs) Handles RESET3.Click

        PictureBox41.Visible = True
        PictureBox42.Visible = True
        PictureBox43.Visible = True
        PictureBox44.Visible = True
        PictureBox45.Visible = True
        PictureBox46.Visible = True
        PictureBox47.Visible = True
        PictureBox48.Visible = True
        PictureBox49.Visible = True

        PictureBox51.Visible = False
        PictureBox52.Visible = False
        PictureBox53.Visible = False
        PictureBox54.Visible = False
        PictureBox55.Visible = False
        PictureBox56.Visible = False
        PictureBox57.Visible = False
        PictureBox58.Visible = False
        PictureBox59.Visible = False

    End Sub

    Private Sub image_select3()

        RESET3.PerformClick()

        p.Clear()
        p.Add("@PR_NO", pr_no.Text)
        p.Add("@NG_CD", "21")
        p.Add("@DO_GU", "1")
        p.Add("@PR_JOBNO", pr_jobno.Text)

        'If pr_jobno.Text <> "" Then
        '    p.Add("@PR_JOBNO", pr_jobno.Text)
        'Else
        'End If

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_pr1122_spot_select", p)

        If Not IsEmpty(dSet) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            For Each dRow In dRows
                'If ToStr(dRow("NG_CD")) = "21" And ToStr(dRow("DO_GU")) = "1" Then
                '    p.Add("@DO_GU", "1")
                '    p.Add("@NG_CD", "21")

                If ToStr(dRow("SPOT1")) = "1" Then
                    PictureBox41.Visible = False
                    PictureBox51.Visible = True
                Else
                    PictureBox41.Visible = True
                    PictureBox51.Visible = False
                End If

                If ToStr(dRow("SPOT2")) = "1" Then
                    PictureBox42.Visible = False
                    PictureBox52.Visible = True
                Else
                    PictureBox42.Visible = True
                    PictureBox52.Visible = False
                End If

                If ToStr(dRow("SPOT3")) = "1" Then
                    PictureBox43.Visible = False
                    PictureBox53.Visible = True
                Else
                    PictureBox43.Visible = True
                    PictureBox53.Visible = False
                End If

                If ToStr(dRow("SPOT4")) = "1" Then
                    PictureBox44.Visible = False
                    PictureBox54.Visible = True
                Else
                    PictureBox44.Visible = True
                    PictureBox54.Visible = False
                End If

                If ToStr(dRow("SPOT5")) = "1" Then
                    PictureBox45.Visible = False
                    PictureBox55.Visible = True
                Else
                    PictureBox45.Visible = True
                    PictureBox55.Visible = False
                End If

                If ToStr(dRow("SPOT6")) = "1" Then
                    PictureBox46.Visible = False
                    PictureBox56.Visible = True
                Else
                    PictureBox46.Visible = True
                    PictureBox56.Visible = False
                End If

                If ToStr(dRow("SPOT7")) = "1" Then
                    PictureBox47.Visible = False
                    PictureBox57.Visible = True
                Else
                    PictureBox47.Visible = True
                    PictureBox57.Visible = False
                End If

                If ToStr(dRow("SPOT8")) = "1" Then
                    PictureBox48.Visible = False
                    PictureBox58.Visible = True
                Else
                    PictureBox48.Visible = True
                    PictureBox58.Visible = False
                End If

                If ToStr(dRow("SPOT9")) = "1" Then
                    PictureBox49.Visible = False
                    PictureBox59.Visible = True
                Else
                    PictureBox49.Visible = True
                    PictureBox59.Visible = False
                End If
                'End If

            Next
        Else
            Exit Sub
        End If

    End Sub
#End Region

#Region "1도.28.인쇄불량"
    Private Sub PictureBox61_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox61.Click
        PictureBox71.Visible = True
        PictureBox61.Visible = False
    End Sub
    Private Sub PictureBox62_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox62.Click
        PictureBox72.Visible = True
        PictureBox62.Visible = False
    End Sub
    Private Sub PictureBox63_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox63.Click
        PictureBox73.Visible = True
        PictureBox63.Visible = False
    End Sub
    Private Sub PictureBox64_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox64.Click
        PictureBox74.Visible = True
        PictureBox64.Visible = False
    End Sub
    Private Sub PictureBox65_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox65.Click
        PictureBox75.Visible = True
        PictureBox65.Visible = False
    End Sub
    Private Sub PictureBox66_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox66.Click
        PictureBox76.Visible = True
        PictureBox66.Visible = False
    End Sub
    Private Sub PictureBox67_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox67.Click
        PictureBox77.Visible = True
        PictureBox67.Visible = False
    End Sub
    Private Sub PictureBox68_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox68.Click
        PictureBox78.Visible = True
        PictureBox68.Visible = False
    End Sub
    Private Sub PictureBox69_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox69.Click
        PictureBox79.Visible = True
        PictureBox69.Visible = False
    End Sub

    Private Sub SAVE_IMG4_Click(sender As System.Object, e As System.EventArgs) Handles SAVE_IMG4.Click
        Dim one_do28 As String = ""

        p.Clear()
        p.Add("@PR_NO", pr_no.Text)
        p.Add("@PR_JOBNO", pr_jobno.Text)
        p.Add("@C_EMP", ps_cd.Text)
        p.Add("@M_EMP", ps_cd.Text)
        p.Add("@DO_GU", "1")     ' 1도짜리 

        If PictureBox71.Visible = True Then
            p.Add("@NG_CD", "28")   '불량코드 28 인쇄불량
            p.Add("@SPOT1", "1")
        Else
            p.Add("@NG_CD", "28")
            p.Add("@SPOT1", "0")
        End If

        If PictureBox72.Visible = True Then
            p.Add("@NG_CD", "28")   '불량코드 28 인쇄불량
            p.Add("@SPOT2", "1")
        Else
            p.Add("@NG_CD", "28")
            p.Add("@SPOT2", "0")
        End If

        If PictureBox73.Visible = True Then
            p.Add("@NG_CD", "28")   '불량코드 28 인쇄불량
            p.Add("@SPOT3", "1")
        Else
            p.Add("@NG_CD", "28")
            p.Add("@SPOT3", "0")
        End If

        If PictureBox74.Visible = True Then
            p.Add("@NG_CD", "28")   '불량코드 28 인쇄불량
            p.Add("@SPOT4", "1")
        Else
            p.Add("@NG_CD", "28")
            p.Add("@SPOT4", "0")
        End If

        If PictureBox75.Visible = True Then
            p.Add("@NG_CD", "28")   '불량코드 28 인쇄불량
            p.Add("@SPOT5", "1")
        Else
            p.Add("@NG_CD", "28")
            p.Add("@SPOT5", "0")
        End If

        If PictureBox76.Visible = True Then
            p.Add("@NG_CD", "28")     '불량코드 28 인쇄불량
            p.Add("@SPOT6", "1")
        Else
            p.Add("@NG_CD", "28")
            p.Add("@SPOT6", "0")
        End If

        If PictureBox77.Visible = True Then
            p.Add("@NG_CD", "28")   '불량코드 28 인쇄불량
            p.Add("@SPOT7", "1")
        Else
            p.Add("@NG_CD", "28")
            p.Add("@SPOT7", "0")
        End If

        If PictureBox78.Visible = True Then
            p.Add("@NG_CD", "28")   '불량코드 28 인쇄불량
            p.Add("@SPOT8", "1")
        Else
            p.Add("@NG_CD", "28")
            p.Add("@SPOT8", "0")
        End If

        If PictureBox79.Visible = True Then
            p.Add("@NG_CD", "28")  '불량코드 28 인쇄불량
            p.Add("@SPOT9", "1")
        Else
            p.Add("@NG_CD", "28")
            p.Add("@SPOT9", "0")
        End If

        Me.Open("wi_pr1122_spot_save", p)

    End Sub

    Private Sub RESET4_Click(sender As System.Object, e As System.EventArgs) Handles RESET4.Click

        PictureBox61.Visible = True
        PictureBox62.Visible = True
        PictureBox63.Visible = True
        PictureBox64.Visible = True
        PictureBox65.Visible = True
        PictureBox66.Visible = True
        PictureBox67.Visible = True
        PictureBox68.Visible = True
        PictureBox69.Visible = True

        PictureBox71.Visible = False
        PictureBox72.Visible = False
        PictureBox73.Visible = False
        PictureBox74.Visible = False
        PictureBox75.Visible = False
        PictureBox76.Visible = False
        PictureBox77.Visible = False
        PictureBox78.Visible = False
        PictureBox79.Visible = False

    End Sub

    Private Sub image_select4()

        RESET4.PerformClick()

        p.Clear()
        p.Add("@PR_NO", pr_no.Text)
        p.Add("@NG_CD", "28")
        p.Add("@DO_GU", "1")
        p.Add("@PR_JOBNO", pr_jobno.Text)

        'If pr_jobno.Text <> "" Then
        '    p.Add("@PR_JOBNO", pr_jobno.Text)
        'Else
        'End If

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_pr1122_spot_select", p)

        If Not IsEmpty(dSet) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            For Each dRow In dRows
                'If ToStr(dRow("NG_CD")) = "28" And ToStr(dRow("DO_GU")) = "1" Then
                '    p.Add("@DO_GU", "1")
                '    p.Add("@NG_CD", "28")

                If ToStr(dRow("SPOT1")) = "1" Then
                    PictureBox61.Visible = False
                    PictureBox71.Visible = True
                Else
                    PictureBox61.Visible = True
                    PictureBox71.Visible = False
                End If

                If ToStr(dRow("SPOT2")) = "1" Then
                    PictureBox62.Visible = False
                    PictureBox72.Visible = True
                Else
                    PictureBox62.Visible = True
                    PictureBox72.Visible = False
                End If

                If ToStr(dRow("SPOT3")) = "1" Then
                    PictureBox63.Visible = False
                    PictureBox73.Visible = True
                Else
                    PictureBox63.Visible = True
                    PictureBox73.Visible = False
                End If

                If ToStr(dRow("SPOT4")) = "1" Then
                    PictureBox64.Visible = False
                    PictureBox74.Visible = True
                Else
                    PictureBox64.Visible = True
                    PictureBox74.Visible = False
                End If

                If ToStr(dRow("SPOT5")) = "1" Then
                    PictureBox65.Visible = False
                    PictureBox75.Visible = True
                Else
                    PictureBox65.Visible = True
                    PictureBox75.Visible = False
                End If

                If ToStr(dRow("SPOT6")) = "1" Then
                    PictureBox66.Visible = False
                    PictureBox76.Visible = True
                Else
                    PictureBox66.Visible = True
                    PictureBox76.Visible = False
                End If

                If ToStr(dRow("SPOT7")) = "1" Then
                    PictureBox67.Visible = False
                    PictureBox77.Visible = True
                Else
                    PictureBox67.Visible = True
                    PictureBox77.Visible = False
                End If

                If ToStr(dRow("SPOT8")) = "1" Then
                    PictureBox68.Visible = False
                    PictureBox78.Visible = True
                Else
                    PictureBox68.Visible = True
                    PictureBox78.Visible = False
                End If

                If ToStr(dRow("SPOT9")) = "1" Then
                    PictureBox69.Visible = False
                    PictureBox79.Visible = True
                Else
                    PictureBox69.Visible = True
                    PictureBox79.Visible = False
                End If
                'End If

            Next
        Else
            Exit Sub
        End If

    End Sub
#End Region


#Region "2도.19.알떨어짐"
    Private Sub PictureBox81_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox81.Click
        PictureBox91.Visible = True
        PictureBox81.Visible = False
    End Sub
    Private Sub PictureBox82_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox82.Click
        PictureBox92.Visible = True
        PictureBox82.Visible = False
    End Sub
    Private Sub PictureBox83_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox83.Click
        PictureBox93.Visible = True
        PictureBox83.Visible = False
    End Sub
    Private Sub PictureBox84_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox84.Click
        PictureBox94.Visible = True
        PictureBox84.Visible = False
    End Sub
    Private Sub PictureBox85_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox85.Click
        PictureBox95.Visible = True
        PictureBox85.Visible = False
    End Sub
    Private Sub PictureBox86_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox86.Click
        PictureBox96.Visible = True
        PictureBox86.Visible = False
    End Sub
    Private Sub PictureBox87_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox87.Click
        PictureBox97.Visible = True
        PictureBox87.Visible = False
    End Sub
    Private Sub PictureBox88_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox88.Click
        PictureBox98.Visible = True
        PictureBox88.Visible = False
    End Sub
    Private Sub PictureBox89_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox89.Click
        PictureBox99.Visible = True
        PictureBox89.Visible = False
    End Sub

    Private Sub SAVE_IMG5_Click(sender As System.Object, e As System.EventArgs) Handles SAVE_IMG5.Click
        Dim one_do28 As String = ""

        p.Clear()
        p.Add("@PR_NO", pr_no.Text)
        p.Add("@PR_JOBNO", pr_jobno.Text)
        p.Add("@C_EMP", ps_cd.Text)
        p.Add("@M_EMP", ps_cd.Text)
        p.Add("@DO_GU", "2")     ' 2도짜리 

        If PictureBox91.Visible = True Then
            p.Add("@NG_CD", "19")   '불량코드 19 알떨어짐
            p.Add("@SPOT1", "1")
        Else
            p.Add("@NG_CD", "19")
            p.Add("@SPOT1", "0")
        End If

        If PictureBox92.Visible = True Then
            p.Add("@NG_CD", "19")   '불량코드 19 알떨어짐
            p.Add("@SPOT2", "1")
        Else
            p.Add("@NG_CD", "19")
            p.Add("@SPOT2", "0")
        End If

        If PictureBox93.Visible = True Then
            p.Add("@NG_CD", "19")   '불량코드 19 알떨어짐
            p.Add("@SPOT3", "1")
        Else
            p.Add("@NG_CD", "19")
            p.Add("@SPOT3", "0")
        End If

        If PictureBox94.Visible = True Then
            p.Add("@NG_CD", "19")   '불량코드 19 알떨어짐
            p.Add("@SPOT4", "1")
        Else
            p.Add("@NG_CD", "19")
            p.Add("@SPOT4", "0")
        End If

        If PictureBox95.Visible = True Then
            p.Add("@NG_CD", "19")   '불량코드 19 알떨어짐
            p.Add("@SPOT5", "1")
        Else
            p.Add("@NG_CD", "19")
            p.Add("@SPOT5", "0")
        End If

        If PictureBox96.Visible = True Then
            p.Add("@NG_CD", "19")     '불량코드 19 알떨어짐
            p.Add("@SPOT6", "1")
        Else
            p.Add("@NG_CD", "19")
            p.Add("@SPOT6", "0")
        End If

        If PictureBox97.Visible = True Then
            p.Add("@NG_CD", "19")   '불량코드 19 알떨어짐
            p.Add("@SPOT7", "1")
        Else
            p.Add("@NG_CD", "19")
            p.Add("@SPOT7", "0")
        End If

        If PictureBox98.Visible = True Then
            p.Add("@NG_CD", "19")   '불량코드 19 알떨어짐
            p.Add("@SPOT8", "1")
        Else
            p.Add("@NG_CD", "19")
            p.Add("@SPOT8", "0")
        End If

        If PictureBox99.Visible = True Then
            p.Add("@NG_CD", "19")  '불량코드 19 알떨어짐
            p.Add("@SPOT9", "1")
        Else
            p.Add("@NG_CD", "19")
            p.Add("@SPOT9", "0")
        End If

        Me.Open("wi_pr1122_spot_save", p)

    End Sub

    Private Sub RESET5_Click(sender As System.Object, e As System.EventArgs) Handles RESET5.Click

        PictureBox81.Visible = True
        PictureBox82.Visible = True
        PictureBox83.Visible = True
        PictureBox84.Visible = True
        PictureBox85.Visible = True
        PictureBox86.Visible = True
        PictureBox87.Visible = True
        PictureBox88.Visible = True
        PictureBox89.Visible = True

        PictureBox91.Visible = False
        PictureBox92.Visible = False
        PictureBox93.Visible = False
        PictureBox94.Visible = False
        PictureBox95.Visible = False
        PictureBox96.Visible = False
        PictureBox97.Visible = False
        PictureBox98.Visible = False
        PictureBox99.Visible = False

    End Sub

    Private Sub image_select5()

        RESET5.PerformClick()

        p.Clear()
        p.Add("@PR_NO", pr_no.Text)
        p.Add("@NG_CD", "19")
        p.Add("@DO_GU", "2")
        p.Add("@PR_JOBNO", pr_jobno.Text)

        'If pr_jobno.Text <> "" Then
        '    p.Add("@PR_JOBNO", pr_jobno.Text)
        'Else
        'End If

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_pr1122_spot_select", p)

        If Not IsEmpty(dSet) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            For Each dRow In dRows
                'If ToStr(dRow("NG_CD")) = "19" And ToStr(dRow("DO_GU")) = "2" Then
                '    p.Add("@DO_GU", "2")
                '    p.Add("@NG_CD", "19")

                If ToStr(dRow("SPOT1")) = "1" Then
                    PictureBox81.Visible = False
                    PictureBox91.Visible = True
                Else
                    PictureBox81.Visible = True
                    PictureBox91.Visible = False
                End If

                If ToStr(dRow("SPOT2")) = "1" Then
                    PictureBox82.Visible = False
                    PictureBox92.Visible = True
                Else
                    PictureBox82.Visible = True
                    PictureBox92.Visible = False
                End If

                If ToStr(dRow("SPOT3")) = "1" Then
                    PictureBox83.Visible = False
                    PictureBox93.Visible = True
                Else
                    PictureBox83.Visible = True
                    PictureBox93.Visible = False
                End If

                If ToStr(dRow("SPOT4")) = "1" Then
                    PictureBox84.Visible = False
                    PictureBox94.Visible = True
                Else
                    PictureBox84.Visible = True
                    PictureBox94.Visible = False
                End If

                If ToStr(dRow("SPOT5")) = "1" Then
                    PictureBox85.Visible = False
                    PictureBox95.Visible = True
                Else
                    PictureBox85.Visible = True
                    PictureBox95.Visible = False
                End If

                If ToStr(dRow("SPOT6")) = "1" Then
                    PictureBox86.Visible = False
                    PictureBox96.Visible = True
                Else
                    PictureBox86.Visible = True
                    PictureBox96.Visible = False
                End If

                If ToStr(dRow("SPOT7")) = "1" Then
                    PictureBox87.Visible = False
                    PictureBox97.Visible = True
                Else
                    PictureBox87.Visible = True
                    PictureBox97.Visible = False
                End If

                If ToStr(dRow("SPOT8")) = "1" Then
                    PictureBox88.Visible = False
                    PictureBox98.Visible = True
                Else
                    PictureBox88.Visible = True
                    PictureBox98.Visible = False
                End If

                If ToStr(dRow("SPOT9")) = "1" Then
                    PictureBox89.Visible = False
                    PictureBox99.Visible = True
                Else
                    PictureBox89.Visible = True
                    PictureBox99.Visible = False
                End If
                'End If

            Next
        Else
            Exit Sub
        End If

    End Sub
#End Region

#Region "2도.20.색상번짐"
    Private Sub PictureBox101_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox101.Click
        PictureBox111.Visible = True
        PictureBox101.Visible = False
    End Sub
    Private Sub PictureBox102_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox102.Click
        PictureBox112.Visible = True
        PictureBox102.Visible = False
    End Sub
    Private Sub PictureBox103_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox103.Click
        PictureBox113.Visible = True
        PictureBox103.Visible = False
    End Sub
    Private Sub PictureBox104_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox104.Click
        PictureBox114.Visible = True
        PictureBox104.Visible = False
    End Sub
    Private Sub PictureBox105_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox105.Click
        PictureBox115.Visible = True
        PictureBox105.Visible = False
    End Sub
    Private Sub PictureBox106_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox106.Click
        PictureBox116.Visible = True
        PictureBox106.Visible = False
    End Sub
    Private Sub PictureBox107_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox107.Click
        PictureBox117.Visible = True
        PictureBox107.Visible = False
    End Sub
    Private Sub PictureBox108_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox108.Click
        PictureBox118.Visible = True
        PictureBox108.Visible = False
    End Sub
    Private Sub PictureBox109_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox109.Click
        PictureBox119.Visible = True
        PictureBox109.Visible = False
    End Sub

    Private Sub SAVE_IMG6_Click(sender As System.Object, e As System.EventArgs) Handles SAVE_IMG6.Click
        Dim one_do28 As String = ""

        p.Clear()
        p.Add("@PR_NO", pr_no.Text)
        p.Add("@PR_JOBNO", pr_jobno.Text)
        p.Add("@C_EMP", ps_cd.Text)
        p.Add("@M_EMP", ps_cd.Text)
        p.Add("@DO_GU", "2")     ' 2도짜리 

        If PictureBox111.Visible = True Then
            p.Add("@NG_CD", "20")   '불량코드 20 색상번짐
            p.Add("@SPOT1", "1")
        Else
            p.Add("@NG_CD", "20")
            p.Add("@SPOT1", "0")
        End If

        If PictureBox112.Visible = True Then
            p.Add("@NG_CD", "20")   '불량코드 20 색상번짐
            p.Add("@SPOT2", "1")
        Else
            p.Add("@NG_CD", "20")
            p.Add("@SPOT2", "0")
        End If

        If PictureBox113.Visible = True Then
            p.Add("@NG_CD", "20")   '불량코드 20 색상번짐
            p.Add("@SPOT3", "1")
        Else
            p.Add("@NG_CD", "20")
            p.Add("@SPOT3", "0")
        End If

        If PictureBox114.Visible = True Then
            p.Add("@NG_CD", "20")   '불량코드 20 색상번짐
            p.Add("@SPOT4", "1")
        Else
            p.Add("@NG_CD", "20")
            p.Add("@SPOT4", "0")
        End If

        If PictureBox115.Visible = True Then
            p.Add("@NG_CD", "20")   '불량코드 20 색상번짐
            p.Add("@SPOT5", "1")
        Else
            p.Add("@NG_CD", "20")
            p.Add("@SPOT5", "0")
        End If

        If PictureBox116.Visible = True Then
            p.Add("@NG_CD", "20")     '불량코드 20 색상번짐
            p.Add("@SPOT6", "1")
        Else
            p.Add("@NG_CD", "20")
            p.Add("@SPOT6", "0")
        End If

        If PictureBox117.Visible = True Then
            p.Add("@NG_CD", "20")   '불량코드 20 색상번짐
            p.Add("@SPOT7", "1")
        Else
            p.Add("@NG_CD", "20")
            p.Add("@SPOT7", "0")
        End If

        If PictureBox118.Visible = True Then
            p.Add("@NG_CD", "20")   '불량코드 20 색상번짐
            p.Add("@SPOT8", "1")
        Else
            p.Add("@NG_CD", "20")
            p.Add("@SPOT8", "0")
        End If

        If PictureBox119.Visible = True Then
            p.Add("@NG_CD", "20")  '불량코드 20 색상번짐
            p.Add("@SPOT9", "1")
        Else
            p.Add("@NG_CD", "20")
            p.Add("@SPOT9", "0")
        End If

        Me.Open("wi_pr1122_spot_save", p)

    End Sub

    Private Sub RESET6_Click(sender As System.Object, e As System.EventArgs) Handles RESET6.Click

        PictureBox101.Visible = True
        PictureBox102.Visible = True
        PictureBox103.Visible = True
        PictureBox104.Visible = True
        PictureBox105.Visible = True
        PictureBox106.Visible = True
        PictureBox107.Visible = True
        PictureBox108.Visible = True
        PictureBox109.Visible = True

        PictureBox111.Visible = False
        PictureBox112.Visible = False
        PictureBox113.Visible = False
        PictureBox114.Visible = False
        PictureBox115.Visible = False
        PictureBox116.Visible = False
        PictureBox117.Visible = False
        PictureBox118.Visible = False
        PictureBox119.Visible = False

    End Sub

    Private Sub image_select6()

        RESET6.PerformClick()

        p.Clear()
        p.Add("@PR_NO", pr_no.Text)
        p.Add("@NG_CD", "20")
        p.Add("@DO_GU", "2")
        p.Add("@PR_JOBNO", pr_jobno.Text)

        'If pr_jobno.Text <> "" Then
        '    p.Add("@PR_JOBNO", pr_jobno.Text)
        'Else
        'End If

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_pr1122_spot_select", p)

        If Not IsEmpty(dSet) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            For Each dRow In dRows
                'If ToStr(dRow("NG_CD")) = "20" And ToStr(dRow("DO_GU")) = "2" Then
                '    p.Add("@DO_GU", "2")
                '    p.Add("@NG_CD", "20")

                If ToStr(dRow("SPOT1")) = "1" Then
                    PictureBox101.Visible = False
                    PictureBox111.Visible = True
                Else
                    PictureBox101.Visible = True
                    PictureBox111.Visible = False
                End If

                If ToStr(dRow("SPOT2")) = "1" Then
                    PictureBox102.Visible = False
                    PictureBox112.Visible = True
                Else
                    PictureBox102.Visible = True
                    PictureBox112.Visible = False
                End If

                If ToStr(dRow("SPOT3")) = "1" Then
                    PictureBox103.Visible = False
                    PictureBox113.Visible = True
                Else
                    PictureBox103.Visible = True
                    PictureBox113.Visible = False
                End If

                If ToStr(dRow("SPOT4")) = "1" Then
                    PictureBox104.Visible = False
                    PictureBox114.Visible = True
                Else
                    PictureBox104.Visible = True
                    PictureBox114.Visible = False
                End If

                If ToStr(dRow("SPOT5")) = "1" Then
                    PictureBox105.Visible = False
                    PictureBox115.Visible = True
                Else
                    PictureBox105.Visible = True
                    PictureBox115.Visible = False
                End If

                If ToStr(dRow("SPOT6")) = "1" Then
                    PictureBox106.Visible = False
                    PictureBox116.Visible = True
                Else
                    PictureBox106.Visible = True
                    PictureBox116.Visible = False
                End If

                If ToStr(dRow("SPOT7")) = "1" Then
                    PictureBox107.Visible = False
                    PictureBox117.Visible = True
                Else
                    PictureBox107.Visible = True
                    PictureBox117.Visible = False
                End If

                If ToStr(dRow("SPOT8")) = "1" Then
                    PictureBox108.Visible = False
                    PictureBox118.Visible = True
                Else
                    PictureBox108.Visible = True
                    PictureBox118.Visible = False
                End If

                If ToStr(dRow("SPOT9")) = "1" Then
                    PictureBox109.Visible = False
                    PictureBox119.Visible = True
                Else
                    PictureBox109.Visible = True
                    PictureBox119.Visible = False
                End If
                'End If

            Next
        Else
            Exit Sub
        End If

    End Sub
#End Region

#Region "2도.21.알+번짐"
    Private Sub PictureBox121_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox121.Click
        PictureBox131.Visible = True
        PictureBox121.Visible = False
    End Sub
    Private Sub PictureBox122_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox122.Click
        PictureBox132.Visible = True
        PictureBox122.Visible = False
    End Sub
    Private Sub PictureBox123_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox123.Click
        PictureBox133.Visible = True
        PictureBox123.Visible = False
    End Sub
    Private Sub PictureBox124_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox124.Click
        PictureBox134.Visible = True
        PictureBox124.Visible = False
    End Sub
    Private Sub PictureBox125_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox125.Click
        PictureBox135.Visible = True
        PictureBox125.Visible = False
    End Sub
    Private Sub PictureBox126_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox126.Click
        PictureBox136.Visible = True
        PictureBox126.Visible = False
    End Sub
    Private Sub PictureBox127_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox127.Click
        PictureBox137.Visible = True
        PictureBox127.Visible = False
    End Sub
    Private Sub PictureBox128_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox128.Click
        PictureBox138.Visible = True
        PictureBox128.Visible = False
    End Sub
    Private Sub PictureBox129_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox129.Click
        PictureBox139.Visible = True
        PictureBox129.Visible = False
    End Sub

    Private Sub SAVE_IMG7_Click(sender As System.Object, e As System.EventArgs) Handles SAVE_IMG7.Click
        Dim one_do28 As String = ""

        p.Clear()
        p.Add("@PR_NO", pr_no.Text)
        p.Add("@PR_JOBNO", pr_jobno.Text)
        p.Add("@C_EMP", ps_cd.Text)
        p.Add("@M_EMP", ps_cd.Text)
        p.Add("@DO_GU", "2")     ' 2도짜리 

        If PictureBox131.Visible = True Then
            p.Add("@NG_CD", "21")   '불량코드 21 알+번짐
            p.Add("@SPOT1", "1")
        Else
            p.Add("@NG_CD", "21")
            p.Add("@SPOT1", "0")
        End If

        If PictureBox132.Visible = True Then
            p.Add("@NG_CD", "21")   '불량코드 21 알+번짐
            p.Add("@SPOT2", "1")
        Else
            p.Add("@NG_CD", "21")
            p.Add("@SPOT2", "0")
        End If

        If PictureBox133.Visible = True Then
            p.Add("@NG_CD", "21")   '불량코드 21 알+번짐
            p.Add("@SPOT3", "1")
        Else
            p.Add("@NG_CD", "21")
            p.Add("@SPOT3", "0")
        End If

        If PictureBox134.Visible = True Then
            p.Add("@NG_CD", "21")   '불량코드 21 알+번짐
            p.Add("@SPOT4", "1")
        Else
            p.Add("@NG_CD", "21")
            p.Add("@SPOT4", "0")
        End If

        If PictureBox135.Visible = True Then
            p.Add("@NG_CD", "21")   '불량코드 21 알+번짐
            p.Add("@SPOT5", "1")
        Else
            p.Add("@NG_CD", "21")
            p.Add("@SPOT5", "0")
        End If

        If PictureBox136.Visible = True Then
            p.Add("@NG_CD", "21")     '불량코드 21 알+번짐
            p.Add("@SPOT6", "1")
        Else
            p.Add("@NG_CD", "21")
            p.Add("@SPOT6", "0")
        End If

        If PictureBox137.Visible = True Then
            p.Add("@NG_CD", "21")   '불량코드 21 알+번짐
            p.Add("@SPOT7", "1")
        Else
            p.Add("@NG_CD", "21")
            p.Add("@SPOT7", "0")
        End If

        If PictureBox138.Visible = True Then
            p.Add("@NG_CD", "21")   '불량코드 21 알+번짐
            p.Add("@SPOT8", "1")
        Else
            p.Add("@NG_CD", "21")
            p.Add("@SPOT8", "0")
        End If

        If PictureBox139.Visible = True Then
            p.Add("@NG_CD", "21")  '불량코드 21 알+번짐
            p.Add("@SPOT9", "1")
        Else
            p.Add("@NG_CD", "21")
            p.Add("@SPOT9", "0")
        End If

        Me.Open("wi_pr1122_spot_save", p)

    End Sub

    Private Sub RESET7_Click(sender As System.Object, e As System.EventArgs) Handles RESET7.Click

        PictureBox121.Visible = True
        PictureBox122.Visible = True
        PictureBox123.Visible = True
        PictureBox124.Visible = True
        PictureBox125.Visible = True
        PictureBox126.Visible = True
        PictureBox127.Visible = True
        PictureBox128.Visible = True
        PictureBox129.Visible = True

        PictureBox131.Visible = False
        PictureBox132.Visible = False
        PictureBox133.Visible = False
        PictureBox134.Visible = False
        PictureBox135.Visible = False
        PictureBox136.Visible = False
        PictureBox137.Visible = False
        PictureBox138.Visible = False
        PictureBox139.Visible = False

    End Sub

    Private Sub image_select7()

        RESET7.PerformClick()

        p.Clear()
        p.Add("@PR_NO", pr_no.Text)
        p.Add("@NG_CD", "21")
        p.Add("@DO_GU", "2")
        p.Add("@PR_JOBNO", pr_jobno.Text)

        'If pr_jobno.Text <> "" Then
        '    p.Add("@PR_JOBNO", pr_jobno.Text)
        'Else
        'End If

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_pr1122_spot_select", p)

        If Not IsEmpty(dSet) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            For Each dRow In dRows
                'If ToStr(dRow("NG_CD")) = "21" And ToStr(dRow("DO_GU")) = "2" Then
                '    p.Add("@DO_GU", "2")
                '    p.Add("@NG_CD", "21")

                If ToStr(dRow("SPOT1")) = "1" Then
                    PictureBox121.Visible = False
                    PictureBox131.Visible = True
                Else
                    PictureBox121.Visible = True
                    PictureBox131.Visible = False
                End If

                If ToStr(dRow("SPOT2")) = "1" Then
                    PictureBox122.Visible = False
                    PictureBox132.Visible = True
                Else
                    PictureBox122.Visible = True
                    PictureBox132.Visible = False
                End If

                If ToStr(dRow("SPOT3")) = "1" Then
                    PictureBox123.Visible = False
                    PictureBox133.Visible = True
                Else
                    PictureBox123.Visible = True
                    PictureBox133.Visible = False
                End If

                If ToStr(dRow("SPOT4")) = "1" Then
                    PictureBox124.Visible = False
                    PictureBox134.Visible = True
                Else
                    PictureBox124.Visible = True
                    PictureBox134.Visible = False
                End If

                If ToStr(dRow("SPOT5")) = "1" Then
                    PictureBox125.Visible = False
                    PictureBox135.Visible = True
                Else
                    PictureBox125.Visible = True
                    PictureBox135.Visible = False
                End If

                If ToStr(dRow("SPOT6")) = "1" Then
                    PictureBox126.Visible = False
                    PictureBox136.Visible = True
                Else
                    PictureBox126.Visible = True
                    PictureBox136.Visible = False
                End If

                If ToStr(dRow("SPOT7")) = "1" Then
                    PictureBox127.Visible = False
                    PictureBox137.Visible = True
                Else
                    PictureBox127.Visible = True
                    PictureBox137.Visible = False
                End If

                If ToStr(dRow("SPOT8")) = "1" Then
                    PictureBox128.Visible = False
                    PictureBox138.Visible = True
                Else
                    PictureBox128.Visible = True
                    PictureBox138.Visible = False
                End If

                If ToStr(dRow("SPOT9")) = "1" Then
                    PictureBox129.Visible = False
                    PictureBox139.Visible = True
                Else
                    PictureBox129.Visible = True
                    PictureBox139.Visible = False
                End If
                'End If

            Next
        Else
            Exit Sub
        End If

    End Sub
#End Region

#Region "2도.28.인쇄불량"
    Private Sub PictureBox141_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox141.Click
        PictureBox151.Visible = True
        PictureBox141.Visible = False
    End Sub
    Private Sub PictureBox142_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox142.Click
        PictureBox152.Visible = True
        PictureBox142.Visible = False
    End Sub
    Private Sub PictureBox143_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox143.Click
        PictureBox153.Visible = True
        PictureBox143.Visible = False
    End Sub
    Private Sub PictureBox144_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox144.Click
        PictureBox154.Visible = True
        PictureBox144.Visible = False
    End Sub
    Private Sub PictureBox145_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox145.Click
        PictureBox155.Visible = True
        PictureBox145.Visible = False
    End Sub
    Private Sub PictureBox146_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox146.Click
        PictureBox156.Visible = True
        PictureBox146.Visible = False
    End Sub
    Private Sub PictureBox147_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox147.Click
        PictureBox157.Visible = True
        PictureBox147.Visible = False
    End Sub
    Private Sub PictureBox148_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox148.Click
        PictureBox158.Visible = True
        PictureBox148.Visible = False
    End Sub
    Private Sub PictureBox149_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox149.Click
        PictureBox159.Visible = True
        PictureBox149.Visible = False
    End Sub

    Private Sub SAVE_IMG8_Click(sender As System.Object, e As System.EventArgs) Handles SAVE_IMG8.Click
        Dim one_do28 As String = ""

        p.Clear()
        p.Add("@PR_NO", pr_no.Text)
        p.Add("@PR_JOBNO", pr_jobno.Text)
        p.Add("@C_EMP", ps_cd.Text)
        p.Add("@M_EMP", ps_cd.Text)
        p.Add("@DO_GU", "2")     ' 2도짜리 

        If PictureBox151.Visible = True Then
            p.Add("@NG_CD", "28")   '불량코드 21 알+번짐
            p.Add("@SPOT1", "1")
        Else
            p.Add("@NG_CD", "28")
            p.Add("@SPOT1", "0")
        End If

        If PictureBox152.Visible = True Then
            p.Add("@NG_CD", "28")   '불량코드 21 알+번짐
            p.Add("@SPOT2", "1")
        Else
            p.Add("@NG_CD", "28")
            p.Add("@SPOT2", "0")
        End If

        If PictureBox153.Visible = True Then
            p.Add("@NG_CD", "28")   '불량코드 21 알+번짐
            p.Add("@SPOT3", "1")
        Else
            p.Add("@NG_CD", "28")
            p.Add("@SPOT3", "0")
        End If

        If PictureBox154.Visible = True Then
            p.Add("@NG_CD", "28")   '불량코드 21 알+번짐
            p.Add("@SPOT4", "1")
        Else
            p.Add("@NG_CD", "28")
            p.Add("@SPOT4", "0")
        End If

        If PictureBox155.Visible = True Then
            p.Add("@NG_CD", "28")   '불량코드 21 알+번짐
            p.Add("@SPOT5", "1")
        Else
            p.Add("@NG_CD", "28")
            p.Add("@SPOT5", "0")
        End If

        If PictureBox156.Visible = True Then
            p.Add("@NG_CD", "28")     '불량코드 21 알+번짐
            p.Add("@SPOT6", "1")
        Else
            p.Add("@NG_CD", "28")
            p.Add("@SPOT6", "0")
        End If

        If PictureBox157.Visible = True Then
            p.Add("@NG_CD", "28")   '불량코드 21 알+번짐
            p.Add("@SPOT7", "1")
        Else
            p.Add("@NG_CD", "28")
            p.Add("@SPOT7", "0")
        End If

        If PictureBox158.Visible = True Then
            p.Add("@NG_CD", "28")   '불량코드 21 알+번짐
            p.Add("@SPOT8", "1")
        Else
            p.Add("@NG_CD", "28")
            p.Add("@SPOT8", "0")
        End If

        If PictureBox159.Visible = True Then
            p.Add("@NG_CD", "28")  '불량코드 21 알+번짐
            p.Add("@SPOT9", "1")
        Else
            p.Add("@NG_CD", "28")
            p.Add("@SPOT9", "0")
        End If

        Me.Open("wi_pr1122_spot_save", p)

    End Sub

    Private Sub RESET8_Click(sender As System.Object, e As System.EventArgs) Handles RESET8.Click

        PictureBox141.Visible = True
        PictureBox142.Visible = True
        PictureBox143.Visible = True
        PictureBox144.Visible = True
        PictureBox145.Visible = True
        PictureBox146.Visible = True
        PictureBox147.Visible = True
        PictureBox148.Visible = True
        PictureBox149.Visible = True

        PictureBox151.Visible = False
        PictureBox152.Visible = False
        PictureBox153.Visible = False
        PictureBox154.Visible = False
        PictureBox155.Visible = False
        PictureBox156.Visible = False
        PictureBox157.Visible = False
        PictureBox158.Visible = False
        PictureBox159.Visible = False

    End Sub

    Private Sub image_select8()

        RESET8.PerformClick()

        p.Clear()
        p.Add("@PR_NO", pr_no.Text)
        p.Add("@NG_CD", "28")
        p.Add("@DO_GU", "2")
        p.Add("@PR_JOBNO", pr_jobno.Text)

        'If pr_jobno.Text <> "" Then
        '    p.Add("@PR_JOBNO", pr_jobno.Text)
        'Else
        'End If

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_pr1122_spot_select", p)

        If Not IsEmpty(dSet) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            For Each dRow In dRows
                'If ToStr(dRow("NG_CD")) = "28" And ToStr(dRow("DO_GU")) = "2" Then
                '    p.Add("@DO_GU", "2")
                '    p.Add("@NG_CD", "28")

                If ToStr(dRow("SPOT1")) = "1" Then
                    PictureBox141.Visible = False
                    PictureBox151.Visible = True
                Else
                    PictureBox141.Visible = True
                    PictureBox151.Visible = False
                End If

                If ToStr(dRow("SPOT2")) = "1" Then
                    PictureBox142.Visible = False
                    PictureBox152.Visible = True
                Else
                    PictureBox142.Visible = True
                    PictureBox152.Visible = False
                End If

                If ToStr(dRow("SPOT3")) = "1" Then
                    PictureBox143.Visible = False
                    PictureBox153.Visible = True
                Else
                    PictureBox143.Visible = True
                    PictureBox153.Visible = False
                End If

                If ToStr(dRow("SPOT4")) = "1" Then
                    PictureBox144.Visible = False
                    PictureBox154.Visible = True
                Else
                    PictureBox144.Visible = True
                    PictureBox154.Visible = False
                End If

                If ToStr(dRow("SPOT5")) = "1" Then
                    PictureBox145.Visible = False
                    PictureBox155.Visible = True
                Else
                    PictureBox145.Visible = True
                    PictureBox155.Visible = False
                End If

                If ToStr(dRow("SPOT6")) = "1" Then
                    PictureBox146.Visible = False
                    PictureBox156.Visible = True
                Else
                    PictureBox146.Visible = True
                    PictureBox156.Visible = False
                End If

                If ToStr(dRow("SPOT7")) = "1" Then
                    PictureBox147.Visible = False
                    PictureBox157.Visible = True
                Else
                    PictureBox147.Visible = True
                    PictureBox157.Visible = False
                End If

                If ToStr(dRow("SPOT8")) = "1" Then
                    PictureBox148.Visible = False
                    PictureBox158.Visible = True
                Else
                    PictureBox148.Visible = True
                    PictureBox158.Visible = False
                End If

                If ToStr(dRow("SPOT9")) = "1" Then
                    PictureBox149.Visible = False
                    PictureBox159.Visible = True
                Else
                    PictureBox149.Visible = True
                    PictureBox159.Visible = False
                End If
                'End If

            Next
        Else
            Exit Sub
        End If

    End Sub
#End Region


#Region "3도.19.알떨어짐"
    Private Sub PictureBox161_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox161.Click
        PictureBox171.Visible = True
        PictureBox161.Visible = False
    End Sub
    Private Sub PictureBox162_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox162.Click
        PictureBox172.Visible = True
        PictureBox162.Visible = False
    End Sub
    Private Sub PictureBox163_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox163.Click
        PictureBox173.Visible = True
        PictureBox163.Visible = False
    End Sub
    Private Sub PictureBox164_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox164.Click
        PictureBox174.Visible = True
        PictureBox164.Visible = False
    End Sub
    Private Sub PictureBox165_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox165.Click
        PictureBox175.Visible = True
        PictureBox165.Visible = False
    End Sub
    Private Sub PictureBox166_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox166.Click
        PictureBox176.Visible = True
        PictureBox166.Visible = False
    End Sub
    Private Sub PictureBox167_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox167.Click
        PictureBox177.Visible = True
        PictureBox167.Visible = False
    End Sub
    Private Sub PictureBox168_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox168.Click
        PictureBox178.Visible = True
        PictureBox168.Visible = False
    End Sub
    Private Sub PictureBox169_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox169.Click
        PictureBox179.Visible = True
        PictureBox169.Visible = False
    End Sub

    Private Sub SAVE_IMG9_Click(sender As System.Object, e As System.EventArgs) Handles SAVE_IMG9.Click
        Dim one_do28 As String = ""

        p.Clear()
        p.Add("@PR_NO", pr_no.Text)
        p.Add("@PR_JOBNO", pr_jobno.Text)
        p.Add("@C_EMP", ps_cd.Text)
        p.Add("@M_EMP", ps_cd.Text)
        p.Add("@DO_GU", "3")     ' 3도짜리 

        If PictureBox171.Visible = True Then
            p.Add("@NG_CD", "19")   '불량코드 19 알떨어짐
            p.Add("@SPOT1", "1")
        Else
            p.Add("@NG_CD", "19")
            p.Add("@SPOT1", "0")
        End If

        If PictureBox172.Visible = True Then
            p.Add("@NG_CD", "19")   '불량코드 19 알떨어짐
            p.Add("@SPOT2", "1")
        Else
            p.Add("@NG_CD", "19")
            p.Add("@SPOT2", "0")
        End If

        If PictureBox173.Visible = True Then
            p.Add("@NG_CD", "19")   '불량코드 19 알떨어짐
            p.Add("@SPOT3", "1")
        Else
            p.Add("@NG_CD", "19")
            p.Add("@SPOT3", "0")
        End If

        If PictureBox174.Visible = True Then
            p.Add("@NG_CD", "19")   '불량코드 19 알떨어짐
            p.Add("@SPOT4", "1")
        Else
            p.Add("@NG_CD", "19")
            p.Add("@SPOT4", "0")
        End If

        If PictureBox175.Visible = True Then
            p.Add("@NG_CD", "19")   '불량코드 19 알떨어짐
            p.Add("@SPOT5", "1")
        Else
            p.Add("@NG_CD", "19")
            p.Add("@SPOT5", "0")
        End If

        If PictureBox176.Visible = True Then
            p.Add("@NG_CD", "19")     '불량코드 19 알떨어짐
            p.Add("@SPOT6", "1")
        Else
            p.Add("@NG_CD", "19")
            p.Add("@SPOT6", "0")
        End If

        If PictureBox177.Visible = True Then
            p.Add("@NG_CD", "19")   '불량코드 19 알떨어짐
            p.Add("@SPOT7", "1")
        Else
            p.Add("@NG_CD", "19")
            p.Add("@SPOT7", "0")
        End If

        If PictureBox178.Visible = True Then
            p.Add("@NG_CD", "19")   '불량코드 19 알떨어짐
            p.Add("@SPOT8", "1")
        Else
            p.Add("@NG_CD", "19")
            p.Add("@SPOT8", "0")
        End If

        If PictureBox179.Visible = True Then
            p.Add("@NG_CD", "19")  '불량코드 19 알떨어짐
            p.Add("@SPOT9", "1")
        Else
            p.Add("@NG_CD", "19")
            p.Add("@SPOT9", "0")
        End If

        Me.Open("wi_pr1122_spot_save", p)

    End Sub

    Private Sub RESET9_Click(sender As System.Object, e As System.EventArgs) Handles RESET9.Click

        PictureBox161.Visible = True
        PictureBox162.Visible = True
        PictureBox163.Visible = True
        PictureBox164.Visible = True
        PictureBox165.Visible = True
        PictureBox166.Visible = True
        PictureBox167.Visible = True
        PictureBox168.Visible = True
        PictureBox169.Visible = True

        PictureBox171.Visible = False
        PictureBox172.Visible = False
        PictureBox173.Visible = False
        PictureBox174.Visible = False
        PictureBox175.Visible = False
        PictureBox176.Visible = False
        PictureBox177.Visible = False
        PictureBox178.Visible = False
        PictureBox179.Visible = False

    End Sub

    Private Sub image_select9()

        RESET9.PerformClick()

        p.Clear()
        p.Add("@PR_NO", pr_no.Text)
        p.Add("@NG_CD", "19")
        p.Add("@DO_GU", "3")
        p.Add("@PR_JOBNO", pr_jobno.Text)

        'If pr_jobno.Text <> "" Then
        '    p.Add("@PR_JOBNO", pr_jobno.Text)
        'Else
        'End If

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_pr1122_spot_select", p)

        If Not IsEmpty(dSet) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            For Each dRow In dRows
                'If ToStr(dRow("NG_CD")) = "28" And ToStr(dRow("DO_GU")) = "2" Then
                '    p.Add("@DO_GU", "2")
                '    p.Add("@NG_CD", "28")

                If ToStr(dRow("SPOT1")) = "1" Then
                    PictureBox161.Visible = False
                    PictureBox171.Visible = True
                Else
                    PictureBox161.Visible = True
                    PictureBox171.Visible = False
                End If

                If ToStr(dRow("SPOT2")) = "1" Then
                    PictureBox162.Visible = False
                    PictureBox172.Visible = True
                Else
                    PictureBox162.Visible = True
                    PictureBox172.Visible = False
                End If

                If ToStr(dRow("SPOT3")) = "1" Then
                    PictureBox163.Visible = False
                    PictureBox173.Visible = True
                Else
                    PictureBox163.Visible = True
                    PictureBox173.Visible = False
                End If

                If ToStr(dRow("SPOT4")) = "1" Then
                    PictureBox164.Visible = False
                    PictureBox174.Visible = True
                Else
                    PictureBox164.Visible = True
                    PictureBox174.Visible = False
                End If

                If ToStr(dRow("SPOT5")) = "1" Then
                    PictureBox165.Visible = False
                    PictureBox175.Visible = True
                Else
                    PictureBox165.Visible = True
                    PictureBox175.Visible = False
                End If

                If ToStr(dRow("SPOT6")) = "1" Then
                    PictureBox166.Visible = False
                    PictureBox176.Visible = True
                Else
                    PictureBox166.Visible = True
                    PictureBox176.Visible = False
                End If

                If ToStr(dRow("SPOT7")) = "1" Then
                    PictureBox167.Visible = False
                    PictureBox177.Visible = True
                Else
                    PictureBox167.Visible = True
                    PictureBox177.Visible = False
                End If

                If ToStr(dRow("SPOT8")) = "1" Then
                    PictureBox168.Visible = False
                    PictureBox178.Visible = True
                Else
                    PictureBox168.Visible = True
                    PictureBox178.Visible = False
                End If

                If ToStr(dRow("SPOT9")) = "1" Then
                    PictureBox169.Visible = False
                    PictureBox179.Visible = True
                Else
                    PictureBox169.Visible = True
                    PictureBox179.Visible = False
                End If
                'End If

            Next
        Else
            Exit Sub
        End If

    End Sub
#End Region

#Region "3도.20.색상번짐"
    Private Sub PictureBox181_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox181.Click
        PictureBox191.Visible = True
        PictureBox181.Visible = False
    End Sub
    Private Sub PictureBox182_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox182.Click
        PictureBox192.Visible = True
        PictureBox182.Visible = False
    End Sub
    Private Sub PictureBox183_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox183.Click
        PictureBox193.Visible = True
        PictureBox183.Visible = False
    End Sub
    Private Sub PictureBox184_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox184.Click
        PictureBox194.Visible = True
        PictureBox184.Visible = False
    End Sub
    Private Sub PictureBox185_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox185.Click
        PictureBox195.Visible = True
        PictureBox185.Visible = False
    End Sub
    Private Sub PictureBox186_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox186.Click
        PictureBox196.Visible = True
        PictureBox186.Visible = False
    End Sub
    Private Sub PictureBox187_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox187.Click
        PictureBox197.Visible = True
        PictureBox187.Visible = False
    End Sub
    Private Sub PictureBox188_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox188.Click
        PictureBox198.Visible = True
        PictureBox188.Visible = False
    End Sub
    Private Sub PictureBox189_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox189.Click
        PictureBox199.Visible = True
        PictureBox189.Visible = False
    End Sub

    Private Sub SAVE_IMG10_Click(sender As System.Object, e As System.EventArgs) Handles SAVE_IMG10.Click
        Dim one_do28 As String = ""

        p.Clear()
        p.Add("@PR_NO", pr_no.Text)
        p.Add("@PR_JOBNO", pr_jobno.Text)
        p.Add("@C_EMP", ps_cd.Text)
        p.Add("@M_EMP", ps_cd.Text)
        p.Add("@DO_GU", "3")     ' 3도짜리 

        If PictureBox191.Visible = True Then
            p.Add("@NG_CD", "20")   '불량코드 20 색상번짐
            p.Add("@SPOT1", "1")
        Else
            p.Add("@NG_CD", "20")
            p.Add("@SPOT1", "0")
        End If

        If PictureBox192.Visible = True Then
            p.Add("@NG_CD", "20")   '불량코드 20 색상번짐
            p.Add("@SPOT2", "1")
        Else
            p.Add("@NG_CD", "20")
            p.Add("@SPOT2", "0")
        End If

        If PictureBox193.Visible = True Then
            p.Add("@NG_CD", "20")   '불량코드 20 색상번짐
            p.Add("@SPOT3", "1")
        Else
            p.Add("@NG_CD", "20")
            p.Add("@SPOT3", "0")
        End If

        If PictureBox194.Visible = True Then
            p.Add("@NG_CD", "20")   '불량코드 20 색상번짐
            p.Add("@SPOT4", "1")
        Else
            p.Add("@NG_CD", "20")
            p.Add("@SPOT4", "0")
        End If

        If PictureBox195.Visible = True Then
            p.Add("@NG_CD", "20")   '불량코드 20 색상번짐
            p.Add("@SPOT5", "1")
        Else
            p.Add("@NG_CD", "20")
            p.Add("@SPOT5", "0")
        End If

        If PictureBox196.Visible = True Then
            p.Add("@NG_CD", "20")     '불량코드 20 색상번짐
            p.Add("@SPOT6", "1")
        Else
            p.Add("@NG_CD", "20")
            p.Add("@SPOT6", "0")
        End If

        If PictureBox197.Visible = True Then
            p.Add("@NG_CD", "20")   '불량코드 20 색상번짐
            p.Add("@SPOT7", "1")
        Else
            p.Add("@NG_CD", "20")
            p.Add("@SPOT7", "0")
        End If

        If PictureBox198.Visible = True Then
            p.Add("@NG_CD", "20")   '불량코드 20 색상번짐
            p.Add("@SPOT8", "1")
        Else
            p.Add("@NG_CD", "20")
            p.Add("@SPOT8", "0")
        End If

        If PictureBox199.Visible = True Then
            p.Add("@NG_CD", "20")  '불량코드 20 색상번짐
            p.Add("@SPOT9", "1")
        Else
            p.Add("@NG_CD", "20")
            p.Add("@SPOT9", "0")
        End If

        Me.Open("wi_pr1122_spot_save", p)

    End Sub

    Private Sub RESET10_Click(sender As System.Object, e As System.EventArgs) Handles RESET10.Click

        PictureBox181.Visible = True
        PictureBox182.Visible = True
        PictureBox183.Visible = True
        PictureBox184.Visible = True
        PictureBox185.Visible = True
        PictureBox186.Visible = True
        PictureBox187.Visible = True
        PictureBox188.Visible = True
        PictureBox189.Visible = True

        PictureBox191.Visible = False
        PictureBox192.Visible = False
        PictureBox193.Visible = False
        PictureBox194.Visible = False
        PictureBox195.Visible = False
        PictureBox196.Visible = False
        PictureBox197.Visible = False
        PictureBox198.Visible = False
        PictureBox199.Visible = False

    End Sub

    Private Sub image_select10()

        RESET10.PerformClick()

        p.Clear()
        p.Add("@PR_NO", pr_no.Text)
        p.Add("@NG_CD", "20")
        p.Add("@DO_GU", "3")
        p.Add("@PR_JOBNO", pr_jobno.Text)

        'If pr_jobno.Text <> "" Then
        '    p.Add("@PR_JOBNO", pr_jobno.Text)
        'Else
        'End If

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_pr1122_spot_select", p)

        If Not IsEmpty(dSet) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            For Each dRow In dRows
                'If ToStr(dRow("NG_CD")) = "28" And ToStr(dRow("DO_GU")) = "2" Then
                '    p.Add("@DO_GU", "2")
                '    p.Add("@NG_CD", "28")

                If ToStr(dRow("SPOT1")) = "1" Then
                    PictureBox181.Visible = False
                    PictureBox191.Visible = True
                Else
                    PictureBox181.Visible = True
                    PictureBox191.Visible = False
                End If

                If ToStr(dRow("SPOT2")) = "1" Then
                    PictureBox182.Visible = False
                    PictureBox192.Visible = True
                Else
                    PictureBox182.Visible = True
                    PictureBox192.Visible = False
                End If

                If ToStr(dRow("SPOT3")) = "1" Then
                    PictureBox183.Visible = False
                    PictureBox193.Visible = True
                Else
                    PictureBox183.Visible = True
                    PictureBox193.Visible = False
                End If

                If ToStr(dRow("SPOT4")) = "1" Then
                    PictureBox184.Visible = False
                    PictureBox194.Visible = True
                Else
                    PictureBox184.Visible = True
                    PictureBox194.Visible = False
                End If

                If ToStr(dRow("SPOT5")) = "1" Then
                    PictureBox185.Visible = False
                    PictureBox195.Visible = True
                Else
                    PictureBox185.Visible = True
                    PictureBox195.Visible = False
                End If

                If ToStr(dRow("SPOT6")) = "1" Then
                    PictureBox186.Visible = False
                    PictureBox196.Visible = True
                Else
                    PictureBox186.Visible = True
                    PictureBox196.Visible = False
                End If

                If ToStr(dRow("SPOT7")) = "1" Then
                    PictureBox187.Visible = False
                    PictureBox197.Visible = True
                Else
                    PictureBox187.Visible = True
                    PictureBox197.Visible = False
                End If

                If ToStr(dRow("SPOT8")) = "1" Then
                    PictureBox188.Visible = False
                    PictureBox198.Visible = True
                Else
                    PictureBox188.Visible = True
                    PictureBox198.Visible = False
                End If

                If ToStr(dRow("SPOT9")) = "1" Then
                    PictureBox189.Visible = False
                    PictureBox199.Visible = True
                Else
                    PictureBox189.Visible = True
                    PictureBox199.Visible = False
                End If
                'End If

            Next
        Else
            Exit Sub
        End If

    End Sub
#End Region

#Region "3도.21.알+번짐"
    Private Sub PictureBox201_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox201.Click
        PictureBox211.Visible = True
        PictureBox201.Visible = False
    End Sub
    Private Sub PictureBox202_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox202.Click
        PictureBox212.Visible = True
        PictureBox202.Visible = False
    End Sub
    Private Sub PictureBox203_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox203.Click
        PictureBox213.Visible = True
        PictureBox203.Visible = False
    End Sub
    Private Sub PictureBox204_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox204.Click
        PictureBox214.Visible = True
        PictureBox204.Visible = False
    End Sub
    Private Sub PictureBox205_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox205.Click
        PictureBox215.Visible = True
        PictureBox205.Visible = False
    End Sub
    Private Sub PictureBox206_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox206.Click
        PictureBox216.Visible = True
        PictureBox206.Visible = False
    End Sub
    Private Sub PictureBox207_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox207.Click
        PictureBox217.Visible = True
        PictureBox207.Visible = False
    End Sub
    Private Sub PictureBox208_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox208.Click
        PictureBox218.Visible = True
        PictureBox208.Visible = False
    End Sub
    Private Sub PictureBox209_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox209.Click
        PictureBox219.Visible = True
        PictureBox209.Visible = False
    End Sub

    Private Sub SAVE_IMG11_Click(sender As System.Object, e As System.EventArgs) Handles SAVE_IMG11.Click
        Dim one_do28 As String = ""

        p.Clear()
        p.Add("@PR_NO", pr_no.Text)
        p.Add("@PR_JOBNO", pr_jobno.Text)
        p.Add("@C_EMP", ps_cd.Text)
        p.Add("@M_EMP", ps_cd.Text)
        p.Add("@DO_GU", "3")     ' 3도짜리 

        If PictureBox211.Visible = True Then
            p.Add("@NG_CD", "21")   '불량코드 21 알+번짐
            p.Add("@SPOT1", "1")
        Else
            p.Add("@NG_CD", "21")
            p.Add("@SPOT1", "0")
        End If

        If PictureBox212.Visible = True Then
            p.Add("@NG_CD", "21")   '불량코드 21 알+번짐
            p.Add("@SPOT2", "1")
        Else
            p.Add("@NG_CD", "21")
            p.Add("@SPOT2", "0")
        End If

        If PictureBox213.Visible = True Then
            p.Add("@NG_CD", "21")   '불량코드 21 알+번짐
            p.Add("@SPOT3", "1")
        Else
            p.Add("@NG_CD", "21")
            p.Add("@SPOT3", "0")
        End If

        If PictureBox214.Visible = True Then
            p.Add("@NG_CD", "21")   '불량코드 21 알+번짐
            p.Add("@SPOT4", "1")
        Else
            p.Add("@NG_CD", "21")
            p.Add("@SPOT4", "0")
        End If

        If PictureBox215.Visible = True Then
            p.Add("@NG_CD", "21")   '불량코드 21 알+번짐
            p.Add("@SPOT5", "1")
        Else
            p.Add("@NG_CD", "21")
            p.Add("@SPOT5", "0")
        End If

        If PictureBox216.Visible = True Then
            p.Add("@NG_CD", "21")     '불량코드 21 알+번짐
            p.Add("@SPOT6", "1")
        Else
            p.Add("@NG_CD", "21")
            p.Add("@SPOT6", "0")
        End If

        If PictureBox217.Visible = True Then
            p.Add("@NG_CD", "21")   '불량코드 21 알+번짐
            p.Add("@SPOT7", "1")
        Else
            p.Add("@NG_CD", "21")
            p.Add("@SPOT7", "0")
        End If

        If PictureBox218.Visible = True Then
            p.Add("@NG_CD", "21")   '불량코드 21 알+번짐
            p.Add("@SPOT8", "1")
        Else
            p.Add("@NG_CD", "21")
            p.Add("@SPOT8", "0")
        End If

        If PictureBox219.Visible = True Then
            p.Add("@NG_CD", "21")  '불량코드 21 알+번짐
            p.Add("@SPOT9", "1")
        Else
            p.Add("@NG_CD", "21")
            p.Add("@SPOT9", "0")
        End If

        Me.Open("wi_pr1122_spot_save", p)

    End Sub

    Private Sub RESET11_Click(sender As System.Object, e As System.EventArgs) Handles RESET11.Click

        PictureBox201.Visible = True
        PictureBox202.Visible = True
        PictureBox203.Visible = True
        PictureBox204.Visible = True
        PictureBox205.Visible = True
        PictureBox206.Visible = True
        PictureBox207.Visible = True
        PictureBox208.Visible = True
        PictureBox209.Visible = True

        PictureBox211.Visible = False
        PictureBox212.Visible = False
        PictureBox213.Visible = False
        PictureBox214.Visible = False
        PictureBox215.Visible = False
        PictureBox216.Visible = False
        PictureBox217.Visible = False
        PictureBox218.Visible = False
        PictureBox219.Visible = False

    End Sub

    Private Sub image_select11()

        RESET11.PerformClick()

        p.Clear()
        p.Add("@PR_NO", pr_no.Text)
        p.Add("@NG_CD", "21")
        p.Add("@DO_GU", "3")
        p.Add("@PR_JOBNO", pr_jobno.Text)

        'If pr_jobno.Text <> "" Then
        '    p.Add("@PR_JOBNO", pr_jobno.Text)
        'Else
        'End If

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_pr1122_spot_select", p)

        If Not IsEmpty(dSet) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            For Each dRow In dRows
                'If ToStr(dRow("NG_CD")) = "28" And ToStr(dRow("DO_GU")) = "2" Then
                '    p.Add("@DO_GU", "2")
                '    p.Add("@NG_CD", "28")

                If ToStr(dRow("SPOT1")) = "1" Then
                    PictureBox201.Visible = False
                    PictureBox211.Visible = True
                Else
                    PictureBox201.Visible = True
                    PictureBox211.Visible = False
                End If

                If ToStr(dRow("SPOT2")) = "1" Then
                    PictureBox202.Visible = False
                    PictureBox212.Visible = True
                Else
                    PictureBox202.Visible = True
                    PictureBox212.Visible = False
                End If

                If ToStr(dRow("SPOT3")) = "1" Then
                    PictureBox203.Visible = False
                    PictureBox213.Visible = True
                Else
                    PictureBox203.Visible = True
                    PictureBox213.Visible = False
                End If

                If ToStr(dRow("SPOT4")) = "1" Then
                    PictureBox204.Visible = False
                    PictureBox214.Visible = True
                Else
                    PictureBox204.Visible = True
                    PictureBox214.Visible = False
                End If

                If ToStr(dRow("SPOT5")) = "1" Then
                    PictureBox205.Visible = False
                    PictureBox215.Visible = True
                Else
                    PictureBox205.Visible = True
                    PictureBox215.Visible = False
                End If

                If ToStr(dRow("SPOT6")) = "1" Then
                    PictureBox206.Visible = False
                    PictureBox216.Visible = True
                Else
                    PictureBox206.Visible = True
                    PictureBox216.Visible = False
                End If

                If ToStr(dRow("SPOT7")) = "1" Then
                    PictureBox207.Visible = False
                    PictureBox217.Visible = True
                Else
                    PictureBox207.Visible = True
                    PictureBox217.Visible = False
                End If

                If ToStr(dRow("SPOT8")) = "1" Then
                    PictureBox208.Visible = False
                    PictureBox218.Visible = True
                Else
                    PictureBox208.Visible = True
                    PictureBox218.Visible = False
                End If

                If ToStr(dRow("SPOT9")) = "1" Then
                    PictureBox209.Visible = False
                    PictureBox219.Visible = True
                Else
                    PictureBox209.Visible = True
                    PictureBox219.Visible = False
                End If
                'End If

            Next
        Else
            Exit Sub
        End If

    End Sub
#End Region

#Region "3도.28.인쇄불량"
    Private Sub PictureBox221_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox221.Click
        PictureBox231.Visible = True
        PictureBox221.Visible = False
    End Sub
    Private Sub PictureBox222_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox222.Click
        PictureBox232.Visible = True
        PictureBox222.Visible = False
    End Sub
    Private Sub PictureBox223_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox223.Click
        PictureBox233.Visible = True
        PictureBox223.Visible = False
    End Sub
    Private Sub PictureBox224_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox224.Click
        PictureBox234.Visible = True
        PictureBox224.Visible = False
    End Sub
    Private Sub PictureBox225_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox225.Click
        PictureBox235.Visible = True
        PictureBox225.Visible = False
    End Sub
    Private Sub PictureBox226_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox226.Click
        PictureBox236.Visible = True
        PictureBox226.Visible = False
    End Sub
    Private Sub PictureBox227_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox227.Click
        PictureBox237.Visible = True
        PictureBox227.Visible = False
    End Sub
    Private Sub PictureBox228_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox228.Click
        PictureBox238.Visible = True
        PictureBox228.Visible = False
    End Sub
    Private Sub PictureBox229_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox229.Click
        PictureBox239.Visible = True
        PictureBox229.Visible = False
    End Sub

    Private Sub SAVE_IMG12_Click(sender As System.Object, e As System.EventArgs) Handles SAVE_IMG12.Click
        Dim one_do28 As String = ""

        p.Clear()
        p.Add("@PR_NO", pr_no.Text)
        p.Add("@PR_JOBNO", pr_jobno.Text)
        p.Add("@C_EMP", ps_cd.Text)
        p.Add("@M_EMP", ps_cd.Text)
        p.Add("@DO_GU", "3")     ' 3도짜리 

        If PictureBox231.Visible = True Then
            p.Add("@NG_CD", "28")   '불량코드 28 인쇄불량
            p.Add("@SPOT1", "1")
        Else
            p.Add("@NG_CD", "28")
            p.Add("@SPOT1", "0")
        End If

        If PictureBox232.Visible = True Then
            p.Add("@NG_CD", "28")   '불량코드 28 인쇄불량
            p.Add("@SPOT2", "1")
        Else
            p.Add("@NG_CD", "28")
            p.Add("@SPOT2", "0")
        End If

        If PictureBox233.Visible = True Then
            p.Add("@NG_CD", "28")   '불량코드 28 인쇄불량
            p.Add("@SPOT3", "1")
        Else
            p.Add("@NG_CD", "28")
            p.Add("@SPOT3", "0")
        End If

        If PictureBox234.Visible = True Then
            p.Add("@NG_CD", "28")   '불량코드 28 인쇄불량
            p.Add("@SPOT4", "1")
        Else
            p.Add("@NG_CD", "28")
            p.Add("@SPOT4", "0")
        End If

        If PictureBox235.Visible = True Then
            p.Add("@NG_CD", "28")   '불량코드 28 인쇄불량
            p.Add("@SPOT5", "1")
        Else
            p.Add("@NG_CD", "28")
            p.Add("@SPOT5", "0")
        End If

        If PictureBox236.Visible = True Then
            p.Add("@NG_CD", "28")     '불량코드 28 인쇄불량
            p.Add("@SPOT6", "1")
        Else
            p.Add("@NG_CD", "28")
            p.Add("@SPOT6", "0")
        End If

        If PictureBox237.Visible = True Then
            p.Add("@NG_CD", "28")   '불량코드 28 인쇄불량
            p.Add("@SPOT7", "1")
        Else
            p.Add("@NG_CD", "28")
            p.Add("@SPOT7", "0")
        End If

        If PictureBox238.Visible = True Then
            p.Add("@NG_CD", "28")   '불량코드 28 인쇄불량
            p.Add("@SPOT8", "1")
        Else
            p.Add("@NG_CD", "28")
            p.Add("@SPOT8", "0")
        End If

        If PictureBox239.Visible = True Then
            p.Add("@NG_CD", "28")  '불량코드 28 인쇄불량
            p.Add("@SPOT9", "1")
        Else
            p.Add("@NG_CD", "28")
            p.Add("@SPOT9", "0")
        End If

        Me.Open("wi_pr1122_spot_save", p)

    End Sub

    Private Sub RESET12_Click(sender As System.Object, e As System.EventArgs) Handles RESET12.Click

        PictureBox221.Visible = True
        PictureBox222.Visible = True
        PictureBox223.Visible = True
        PictureBox224.Visible = True
        PictureBox225.Visible = True
        PictureBox226.Visible = True
        PictureBox227.Visible = True
        PictureBox228.Visible = True
        PictureBox229.Visible = True

        PictureBox231.Visible = False
        PictureBox232.Visible = False
        PictureBox233.Visible = False
        PictureBox234.Visible = False
        PictureBox235.Visible = False
        PictureBox236.Visible = False
        PictureBox237.Visible = False
        PictureBox238.Visible = False
        PictureBox239.Visible = False

    End Sub

    Private Sub image_select12()

        RESET12.PerformClick()

        p.Clear()
        p.Add("@PR_NO", pr_no.Text)
        p.Add("@NG_CD", "28")
        p.Add("@DO_GU", "3")
        p.Add("@PR_JOBNO", pr_jobno.Text)

        'If pr_jobno.Text <> "" Then
        '    p.Add("@PR_JOBNO", pr_jobno.Text)
        'Else
        'End If

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_pr1122_spot_select", p)

        If Not IsEmpty(dSet) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            For Each dRow In dRows
                'If ToStr(dRow("NG_CD")) = "28" And ToStr(dRow("DO_GU")) = "2" Then
                '    p.Add("@DO_GU", "2")
                '    p.Add("@NG_CD", "28")

                If ToStr(dRow("SPOT1")) = "1" Then
                    PictureBox221.Visible = False
                    PictureBox231.Visible = True
                Else
                    PictureBox221.Visible = True
                    PictureBox231.Visible = False
                End If

                If ToStr(dRow("SPOT2")) = "1" Then
                    PictureBox222.Visible = False
                    PictureBox232.Visible = True
                Else
                    PictureBox222.Visible = True
                    PictureBox232.Visible = False
                End If

                If ToStr(dRow("SPOT3")) = "1" Then
                    PictureBox223.Visible = False
                    PictureBox233.Visible = True
                Else
                    PictureBox223.Visible = True
                    PictureBox233.Visible = False
                End If

                If ToStr(dRow("SPOT4")) = "1" Then
                    PictureBox224.Visible = False
                    PictureBox234.Visible = True
                Else
                    PictureBox224.Visible = True
                    PictureBox234.Visible = False
                End If

                If ToStr(dRow("SPOT5")) = "1" Then
                    PictureBox225.Visible = False
                    PictureBox235.Visible = True
                Else
                    PictureBox225.Visible = True
                    PictureBox235.Visible = False
                End If

                If ToStr(dRow("SPOT6")) = "1" Then
                    PictureBox226.Visible = False
                    PictureBox236.Visible = True
                Else
                    PictureBox226.Visible = True
                    PictureBox236.Visible = False
                End If

                If ToStr(dRow("SPOT7")) = "1" Then
                    PictureBox227.Visible = False
                    PictureBox237.Visible = True
                Else
                    PictureBox227.Visible = True
                    PictureBox237.Visible = False
                End If

                If ToStr(dRow("SPOT8")) = "1" Then
                    PictureBox228.Visible = False
                    PictureBox238.Visible = True
                Else
                    PictureBox228.Visible = True
                    PictureBox238.Visible = False
                End If

                If ToStr(dRow("SPOT9")) = "1" Then
                    PictureBox229.Visible = False
                    PictureBox239.Visible = True
                Else
                    PictureBox229.Visible = True
                    PictureBox239.Visible = False
                End If
                'End If

            Next
        Else
            Exit Sub
        End If

    End Sub
#End Region

    Private Sub btn_lot_print_Click(sender As System.Object, e As System.EventArgs) Handles btn_lot_print.Click
        Dim p As OpenParameters = New OpenParameters
        p.Add("@lot_no", lot_no.Text)

        If lot_no.Text <> "" And
            System7.ReportView.LoadView("WI_PR1122", "", "WI_PR1122_print", p, ) Then
        Else
            MessageInfo("상태 값이 저장. 또는 체크시트 번호가 없습니다.")
        End If

        Return
    End Sub

    Private Sub g_body4_DoubleClick(sender As Object, e As System.EventArgs) Handles g_body4.DoubleClick

    End Sub
End Class
