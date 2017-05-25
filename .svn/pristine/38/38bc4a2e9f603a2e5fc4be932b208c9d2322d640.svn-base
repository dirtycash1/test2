Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAC500
    Dim this_fdt As String, this_tdt As String
    Dim pre_fdt As String, pre_tdt As String

    Dim cap As String
    Dim fix_chk As String
    Dim sCloseDt As String = ""

    Dim get부가세매입계정 As String, get부가세매출계정 As String

    'work_tax_sum, get_tax_term, get_close_dt, close

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        desc.Font = New Font("굴림", 9)
        desc2.Font = New Font("굴림", 9)

        Me.Open()
    End Sub

#Region " Event "

    '    '######################################################################################
    '    '##             Event                                                                ##
    '    '######################################################################################

    Private Sub btn_work_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_work.Click

        '        If Not epdc500f_f1.CheckBeforeOpen Then Exit Sub
        '        'If Not Me.CheckBeforWork() Then Exit Sub

        If end_yn.Checked Then
            desc2.TextAlign = ContentAlignment.MiddleCenter
            desc2.ForeColor = Color.Red
            desc2.Text = "마감 되었습니다."
            Exit Sub
        End If

        If MessageYesNo("[부가세 집계 작업]을 진행하시겠습니까?") <> MsgBoxResult.Yes Then Exit Sub

        If Not CheckRequired(bs_cd, tax_year, mon_bc) Then Exit Sub
        Dim startTm As String = Now

        Try
            If this_fdt = "" Or this_tdt = "" Or pre_fdt = "" Or pre_tdt = "" Then
                MessageInfo("신고분기의 기간정보가 정확 하지 않습니다.")
                '   MsgNote("신고분기의 기간정보가 정확 하지 않습니다.")
                'PutNote("DC500_3")
                Exit Sub
            End If

            Me.Cursor = Cursors.AppStarting
            desc2.TextAlign = ContentAlignment.MiddleCenter
            desc2.ForeColor = Color.Blue
            desc2.Text = "부가세 집계작업 중..." 'Common.Msg("DC500_6")
            'Label2.Text = "☞ 부가세작업 중 ~~~~~"
            Me.Refresh()


            'Dim p As New OpenParameters
            'p.Add("@biz_cd", biz_cd.Text)
            'p.Add("@std_year", std_year.Text)
            'p.Add("@term_ty", term_ty.Text)
            'p.Add("@reg_uid", Parameter.Login.ID)
            'p.Add("@id", "work_tax_sum")

            Dim dSet As DataSet = Rtn_dSet("work_tax_sum")

            '            Dim params As Object = Nothing
            '            AddParam(params, "@biz_cd", biz_cd.Text)
            '            AddParam(params, "@std_year", std_year.Text)
            '            AddParam(params, "@mon_bc", mon_bc.Text)
            '            'AddParam(params, "@fr_dt", this_fdt)
            '            'AddParam(params, "@to_dt", this_tdt)
            '            'AddParam(params, "@pre_fdt", pre_fdt)
            '            'AddParam(params, "@pre_tdt", pre_tdt)
            '            'AddParam(params, "@fix_chk", fix_chk)
            '            'AddParam(params, "@in_acc", get부가세매입계정)
            '            'AddParam(params, "@out_acc", get부가세매출계정)
            '            'AddParam(params, "@cap", cap)
            '            AddParam(params, "@reg_uid", iParams.Login_UserId)

            '            Dim dSet As DataSet = Open(Me.Name, "work_tax_sum", params)

            '            'work_uid.Text = iParams.Login_UserId
            '            'work_unm.Text = iParams.Login_UserNm

            If IsEmpty(dSet) Then
                MessageWarning("부가세작업 오류")
                '                MsgError(Msg("DC500_4"))
                desc2.Text = "☞ 부가세작업 오류"
                'Label2.Text = Msg("DC500_4")
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            Dim Msg As String = DataValue(dSet)
            If Msg.ToUpper = "OK" Then
                'end_yn.Checked = True
                '                '  MsgNote("[" & std_year.Text & "] 년도" & term_ty.ListText & " 부가세 집계작업이 성공적으로 완료 되었습니다.")
                '                PutNote("Z3010") ', vbLf, vbLf, "[" & std_year.Text & "]", term_ty.ListText)
                desc2.TextAlign = ContentAlignment.MiddleCenter
                desc2.ForeColor = Color.Blue
                desc2.Text = " 작업시작 : " & startTm & vbLf & _
                              " 작업종료 : " & Now & vbLf
                '" 작업자명 : " & iParams.Login_UserNm

            Else
                '                PutNote("Z3020", vbLf, vbLf, "[" & std_year.Text & "]", term_ty.ListText)
                '                'MsgNote("[" & std_year.Text & "] 년도" & term_ty.ListText & " 부가세 집계작업 오류" + vbLf + GetValue(dSet, 0))
                desc2.TextAlign = ContentAlignment.MiddleCenter
                desc2.ForeColor = Color.Red
                desc2.Text = Msg
                MessageWarning("☞ 부가세작업 오류")
                '                Label2.Text = Msg("DC500_4")
            End If

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            MessageError(ex, "btnWork_Click")
            '            MsgError(ex, "btnWork_Click")
            Me.Cursor = Cursors.Default
            '            Exit Sub
        End Try
    End Sub

    Private Sub bs_cd_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bs_cd.TextChanged
        Try

            'sCloseDt = ""
            'If bs_cd.Text = "" Then Exit Sub

            ''마감여부 조회
            'Open_Close()

            ''Dim p As New OpenParameters
            ''p.Add("@biz_cd", biz_cd.Text)
            ''p.Add("@std_year", std_year.Text)
            ''p.Add("@term_ty", term_ty.Text)
            ''p.Add("@reg_uid", Parameter.Login.ID)
            ''p.Add("@id", "get_close_dt")

            'Dim dSet As DataSet = Rtn_dSet("get_close_dt")

            ''            Dim params As String(,) = Nothing
            ''            AddParam(params, "@biz_cd", biz_cd.Text)

            ''            Dim dSet As DataSet = Open("EPDC500F", "get_close_dt", params)

            'If IsEmpty(dSet) Then
            '    MessageWarning("부가세 마감일체크")
            '    'PutError("DC500_5")
            '    'MsgError("부가세 마감일체크")
            '    Exit Sub
            'End If

            'sCloseDt = ToStr(DataValue(dSet, "vat_close_dt"))
            Me.SetTerm()

        Catch ex As Exception
            MessageError(ex, "biz_cd_Change")
            '            MsgError(ex, "biz_cd_Change")
        End Try
    End Sub

    Private Sub mon_bc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles mon_bc.TextChanged
        Dim dSet As DataSet, dRows As DataRowCollection, dRow As DataRow
        Dim mng_val As String = Nothing
        Dim P As New OpenParameters
        P.Add("@mon_bc", mon_bc.Text)
        'Command 생성
        dSet = Me.OpenDataSet("fac500_dt_sql", P)
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
        '마감여부 조회
        Open_Close()
        Me.SetTerm()
        If mon_bc.Text = "FA680800" Or mon_bc.Text = "FA680700" Or mon_bc.Text = "FA680750" Then
            chk9.Checked = True
            chk0.Checked = False
            chk1.Checked = False
            chk2.Checked = False
            chk3.Checked = False
            chk4.Checked = False
            chk5.Checked = False
            chk6.Checked = False
            chk7.Checked = False
            chk8.Checked = False
        Else
            chk9.Checked = False
            chk0.Checked = True
            chk1.Checked = True
            chk2.Checked = True
            chk3.Checked = True
            chk4.Checked = True
            chk5.Checked = True
            chk6.Checked = True
            chk7.Checked = True
            chk8.Checked = True
        End If
    End Sub

    Private Sub std_year_Change(ByVal sender As Object, ByVal e As System.EventArgs) Handles tax_year.TextChanged
        '마감여부 조회
        Open_Close()
        Me.SetTerm()
    End Sub

    Private Sub SetTerm()
        Try

            If mon_bc.Text = "" Or tax_year.Text = "" Then Exit Sub

            'Dim p As New OpenParameters
            'p.Add("@biz_cd", biz_cd.Text)
            'p.Add("@std_year", std_year.Text)
            'p.Add("@term_ty", term_ty.Text)
            'p.Add("@reg_uid", Parameter.Login.ID)
            'p.Add("@id", "get_tax_term")
            Dim dSet As DataSet = Rtn_dSet("get_tax_term")

            '            Dim params As Object = Nothing
            '            AddParam(params, "@std_year", std_year.Text)
            '            AddParam(params, "@term_ty", term_ty.Text)
            '            Dim dSet As DataSet = Open("epdc500f", "get_tax_term", params)

            If IsEmpty(dSet) Then
                MessageWarning("신고분기 정보오류")
                ' MsgError("신고분기 정보오류")
                'PutError("DC500_1")
                Exit Sub
            End If

            this_fdt = ToStr(DataValue(dSet, "fr_dt"))
            this_tdt = ToStr(DataValue(dSet, "to_dt"))
            pre_fdt = ToStr(DataValue(dSet, "pre_fr"))
            pre_tdt = ToStr(DataValue(dSet, "pre_to"))
            'cap = Strn(GetValue(dSet, "this_cap"))
            fix_chk = ToStr(DataValue(dSet, "fix_chk"))

            If sCloseDt >= this_tdt Then
                btn_work.Enabled = False
                desc.ForeColor = Color.Red
                desc.TextAlign = ContentAlignment.MiddleCenter
                desc.Text = "이미 마감처리되어 부가세 작업을 할 수 없습니다." & vbLf & _
                            "사업장등록의 부가세 마감일자를 조정후에 가능합니다." & vbLf & _
                            "마감일자 : " & sCloseDt
            Else
                btn_work.Enabled = True
                desc.ForeColor = Color.Blue
                desc.TextAlign = ContentAlignment.MiddleCenter
                desc.Text = "☞ 신고기간 : " & this_fdt & " ~ " & this_tdt '& vbLf & cap
            End If
            desc2.Text = ""
        Catch ex As Exception
            '            MsgError(ex, "Setdt")
            MessageError(ex, "Setdt")
        End Try
    End Sub

#End Region
    Private Sub Open_Close()
        '마감여부 조회
        'If bs_cd.Text = "" Or std_year.Text = "" Or term_ty.Text = "" Then Exit Sub
        'If Not Me.WorkSet("fac500_sql").CheckOpenParameters Then Exit Sub

        desc.Text = ""
        desc2.Text = ""
        end_yn.Checked = False

        'epdc500f_f1.OpenParams = epdc500f_f1.GetParams
        'Dim p As New OpenParameters
        'p.Add("@bs_cd", bs_cd.Text)
        'p.Add("@std_year", std_year.Text)
        'p.Add("@term_ty", term_ty.Text)
        'p.Add("@reg_uid", Parameter.Login.ID)
        'p.Add("@id", "")
        'Open("fac500", p)

        Dim dSet As DataSet = Rtn_dSet("close")

        If IsEmpty(dSet) Then Exit Sub

        Select Case DataValue(dSet)

            Case 0
                end_yn.Checked = False
                btn_close.Text = "마감처리"
                desc.TextAlign = ContentAlignment.MiddleCenter
                desc.ForeColor = Color.Blue
                desc.Text = "☞ 신고기간 : " & this_fdt & " ~ " & this_tdt

            Case 1
                end_yn.Checked = True
                btn_close.Text = "마감취소"
                desc.TextAlign = ContentAlignment.MiddleCenter
                desc.ForeColor = Color.Red
                desc.Text = "☞ 신고기간 : " & this_fdt & " ~ " & this_tdt & vbLf & _
                              "마감 되었습니다."
            Case 2

        End Select

        'If close_chk.Checked Then
        '    btn_close.Text = "마감취소"
        '    desc.TextAlign = ContentAlignment.MiddleCenter
        '    desc.ForeColor = Color.Red
        '    desc.Text = "☞ 신고기간 : " & this_fdt & " ~ " & this_tdt & vbLf & _
        '                  "마감 되었습니다."
        'End If
        'If Not close_chk.Checked Then
        '    btn_close.Text = "마감처리"
        '    desc.TextAlign = ContentAlignment.MiddleCenter
        '    desc.ForeColor = Color.Black
        '    desc.Text = "☞ 신고기간 : " & this_fdt & " ~ " & this_tdt
        'End If

    End Sub

    Private Function Rtn_dSet(ByVal GetId As String) As DataSet
        Rtn_dSet = Nothing
        Try

            If bs_cd.Text = "" Or tax_year.Text = "" Or mon_bc.Text = "" Then Return Nothing

            Dim p As New OpenParameters
            p.Add("@bscd", bs_cd.Text)
            p.Add("@taxyear", tax_year.Text)
            p.Add("@monbc", mon_bc.Text)
            p.Add("@workdt", work_dt.Text)
            p.Add("@taxdtf", tax_dtf.Text)
            p.Add("@taxdtt", tax_dtt.Text)
            p.Add("@chk1", chk1.Text)
            p.Add("@chk2", chk2.Text)
            p.Add("@chk3", chk3.Text)
            p.Add("@chk4", chk4.Text)
            p.Add("@chk5", chk5.Text)
            p.Add("@chk6", chk6.Text)
            p.Add("@chk7", chk7.Text)
            p.Add("@chk8", chk8.Text)
            p.Add("@chk0", chk0.Text)
            p.Add("@chk9", chk9.Text)
            p.Add("@work_id", GetId)
            Return OpenDataSet("fac500_sql", p)

        Catch ex As Exception
            MessageError(ex, "OpenDataSet")
        End Try

    End Function

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click

        Dim CloseChk As String = "0"
        If end_yn.Checked Then
            If MessageYesNo("[마감취소 작업]을 진행하시겠습니까?") <> MsgBoxResult.Yes Then Exit Sub
            CloseChk = "0"
        Else
            If MessageYesNo("[마감 작업]을 진행하시겠습니까?") <> MsgBoxResult.Yes Then Exit Sub
            CloseChk = "1"
        End If

        If Not CheckRequired(bs_cd, tax_year, mon_bc) Then Exit Sub

        Try
            end_yn.Text = CloseChk
            Me.WorkSet("fac500_f10").DataChanged = False
            'SaveTrans(epdc500f_f1)
            Me.Save()
            '마감여부 조회
            Open_Close()

        Catch ex As Exception
            MessageError(ex, "close_chk_Change")
            'MsgError(ex, "close_chk_Change")
        End Try
    End Sub

End Class
