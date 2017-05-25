Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class QMM100_KRS
    Private AfterRow As Boolean

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer2.SplitterDistance = 250
        g30.ShowRowHeaders = False

        img.SizeMode = ImageSizeMode.Stretch
        img.AutoSize = False
        img.Width = 110
        img.Height = 104

        With g60
            'Master 부분
            .GridColumn("insp_sq").IsMasterKey = True
            .GridColumn("insp_cd").IsMasterData = True
            '.GridColumn("iqc_no").IsMasterData = True
            '.GridColumn("iqc_sq").IsMasterData = True
            .GridColumn("insp_stnd").IsMasterData = True
            .GridColumn("insp_min").IsMasterData = True
            .GridColumn("insp_max").IsMasterData = True
            .GridColumn("insp_meth").IsMasterData = True
            .GridColumn("insp_tool").IsMasterData = True

            'Detail 부분
            .GridColumn("smp_no").IsDetailKey = True
            .GridColumn("insp_val").IsDetailData = True
            .GridColumn("ok_yn").IsDetailData = True
            '       select b.iqc_no, b.iqc_sq, b.smp_no, 
            '               insp_sq = a.seq_no, a.insp_cd,
            '               a.insp_stnd, a.insp_min, a.insp_max, a.insp_meth, a.insp_tool,	
            '               c.insp_val, c.ok_yn
        End With


        Open_g60()

        Select Case chk_no.Text
            Case "", "1"
                chk_no.Text = "1"
                r1.Checked = True
            Case "2"
                r2.Checked = True
            Case "3"
                r3.Checked = True
        End Select
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                Open_Form()

            Case MenuType.Save

                Me._Save()

            Case Else
                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    Private Sub Open_Form()
        If in_no.Text <> "" Then
            iqc_dt.Text = Now.ToShortDateString
            fr_dt.Text = Now.ToShortDateString
            in_no.Text = ""
        End If


        Dim DlvNo As String = "", DlvSq As String = ""
        Dim SmpNo As String = ""

        If g20.RowCount > 0 Then
            DlvNo = g20.Text("dlv_no")
            DlvSq = g20.Text("dlv_sq")
        End If

        'If g40.RowCount > 0 Then Row4 = g40.RowIndex
        If g40.RowCount > 0 Then SmpNo = g40.Text("smp_no")

        Me.Open()

        If g20.RowCount > 0 And DlvNo <> "" Then
            Dim Finder(1) As String
            Finder(0) = "dlv_no=" + DlvNo
            Finder(1) = "dlv_sq=" + DlvSq

            g20.Find(Finder)
            'If g20.Text("dlv_no") = DlvNo And g20.Text("dlv_sq") = DlvSq Then
            '    Open("qmm100_krs_f10") '부적합정보등록
            '    Open("qmm100_krs_g30") '수입검사불량조회
            '    Open("qmm100_krs_g40") '시료검사등록
            'End If
        End If

        If g40.RowCount > 0 And SmpNo <> "" Then g40.Find("smp_no=" & SmpNo)

    End Sub

    Public Sub Open2(GetOutNo As String)
        in_no.Text = GetOutNo
        If GetOutNo <> "" Then
            iqc_dt.Text = GetOutNo.Substring(0, 4) & "-" & GetOutNo.Substring(4, 2) & "-" & GetOutNo.Substring(6, 2)
            fr_dt.Text = iqc_dt.Text
        End If

        r3.Checked = True
        chk_no.Text = "3"

        Me.Open()
    End Sub

    Private Sub OpenImg(GetItmId As String)
        If Not chk_img.Checked Then
            If btn_resize.Visible = True Then
                btn_resize.Visible = False
                SplitContainer1.BringToFront()
            End If
            Exit Sub
        End If

        Try
            Dim P As New OpenParameters
            P.Add("@itm_id", GetItmId)
            Open("qmz100_sql", P) '검사기준사진

        Catch ex As Exception

        Finally
            If img.Image Is Nothing Then
                btn_resize.Visible = False
                SplitContainer1.BringToFront()
            Else
                img.BringToFront()
                btn_resize.BringToFront()
                btn_resize.Visible = True
            End If
        End Try

    End Sub

    Private Sub Open_g60()

        Dim SmpQty As Integer = g20.ToDec("smp_qty")
        Dim TitleNm As String = "시료"

        Dim Cal1(1) As String
        Cal1(0) = g60.ColumnTitle("insp_val")
        Cal1(1) = g60.ColumnTitle("ok_yn")

        Dim arr(1, 0) As String, inx As Integer = 0
        For Col As Integer = 1 To SmpQty
            ReDim Preserve arr(1, inx)      'Array를 증가시킨다

            arr(0, inx) = Col.ToString          'FieldName 으로 사용된다
            arr(1, inx) = TitleNm & Col         'Title로 사용된다

            inx += 1
        Next

        g60.InsertExpandColumns(arr)
        'g60.InsertMultiColumns(arr)

        g60.Open()
    End Sub

    Private Sub _Save()
        If Not CheckRequired(fac_cd, wh_cd, iqc_dt) Then
            Exit Sub
        End If

        If MessageYesNo("저장 하시겠습니까 ?") = MsgBoxResult.No Then
            Exit Sub
        End If

        If Me.Save() Then
            Dim saveNo As String = g20.Text("dlv_no")
            Dim saveSq As String = g20.Text("dlv_sq")

            If chk_show.Text = "1" Then
                Me.Open("qmm100_krs_g20")
            Else
                Open_Form()
            End If

            Dim find(1) As String
            find(0) = "dlv_no=" + saveNo
            find(1) = "dlv_sq=" + saveSq

            g20.Find(find)
        End If
    End Sub

    Private Sub chk_show_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_show.CheckedChanged

        If Not chk_show.Checked Then
            SplitContainer2.Panel1Collapsed = Not chk_show.Checked
            cust_cd.Text = ""
            Me.Open("qmm100_krs_g20")
        End If

        If chk_show.Checked Then
            SplitContainer2.Panel1Collapsed = Not chk_show.Checked
            Me.Open("qmm100_krs_g10")

            cust_cd.Text = g10.Text("cust_cd")
            Me.Open("qmm100_krs_g20")
        End If

        g20.ColumnVisible("cust_cd") = Not chk_show.Checked
        g20.ColumnVisible("cust_nm") = Not chk_show.Checked

    End Sub

    Private Sub btn_work_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_work.Click

        Me._Save()

    End Sub

    Private Sub btn_save2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save2.Click

        Dim saveNo As String = g40.Text("smp_no")

        Me._Save()

        g40.Find("smp_no=" + saveNo)
    End Sub


    'Private Sub chk_no_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_no.CheckedChanged
    '    Me.Open()
    'End Sub

    Private Sub chk_all_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_all.CheckedChanged
        g20.CheckRows("chk", chk_all.Checked)
    End Sub

    'Private Sub g40_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g40.AfterMoveRow
    '    g50.Text("iqc_no") = g20.Text("iqc_no")
    '    g50.Text("iqc_sq") = g20.Text("iqc_sq")
    '    g50.Text("smp_no") = g40.Text("smp_no")

    '    Me.Open("qmm100_g50")
    'End Sub

    Private Sub g10_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g10.AfterMoveRow
        If chk_show.Text = "1" Then
            cust_cd.Text = g10.Text("cust_cd")

            Me.Open("qmm100_krs_g20")
        End If
    End Sub

    Private m_StopEvent As Boolean

    Private Sub _AddSample(ByVal qty As Decimal)
        'Smple 수량으로 시료행 만들기
        If ToDec(qty) > 0 Then
            Dim cnt As Integer = g40.RowCount
            If cnt < qty Then
                For i As Integer = 1 To qty - cnt
                    g40.AddNewRow()
                    g40.Text("smp_no") = cnt + i
                Next
            End If
            g40.RowIndex = 0
        End If

        Try
            AfterRow = True
            Open_g60()

            Dim ColMax As Integer = g40.RowCount

            '검사기준상/하안치가 없는경우 자동으로 합격처리(쿼리에 사용하면 수정없는 자료이므로 저장이 안되는 상황발생됨)
            If g20.Text("iqc_no") = "" And g60.RowCount > 0 And ColMax > 0 Then

                With g60

                    For Row As Integer = 0 To .RowCount - 1
                        If .IsDataRow(Row) Then
                            If .ToDec("insp_min", Row) = 0 Or .ToDec("insp_max", Row) = 0 Then
                                For Col As Integer = 1 To ColMax
                                    .Text(Col & "&&ok_yn", Row) = "1"
                                Next
                            End If
                        End If
                    Next

                    .RowIndex = 0
                End With

                'g20.DataChanged = True

            End If

        Catch ex As Exception
        Finally
            AfterRow = False
        End Try

    End Sub

    Private Sub g20_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g20.AfterMoveRow
        If AfterRow Then Exit Sub
        'Smple 수량으로 시료행 만들기
        Me._AddSample(g20.ToDec("smp_qty"))
        OpenImg(g20.Text("itm_id"))
    End Sub

    Private Sub g20_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g20.CellValueChanged
        If ColumnName = "smp_qty" Then
            'Smple 수량으로 시료행 만들기
            Me._AddSample(ToDec(Value))
        End If
    End Sub

    Private Sub g20_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g20.CellValueChanging
        If m_StopEvent Then
            Exit Sub
        End If

        m_StopEvent = True

        With g20

            If ColumnName = "chk" Then

                If Value = "1" Then
                    .Text("ok_qty") = .ToDec("dlv_qty") - rtn_qty.ToDec '.ToDec("bad_qty")
                    .Text("bad_qty") = bad_qty.Text
                Else
                    .Text("ok_qty") = ""
                    .Text("brk_qty") = ""
                    .Text("bad_qty") = ""
                End If

            End If

            If ColumnName = "ok_qty" Then
                If (ToDec(Value) = 0 And .ToDec("chk") = 1) Or (ToDec(Value) <> 0 And .ToDec("chk") = 0) Then
                    .Text("chk") = IIf(ToDec(Value) = 0, "0", "1")
                End If
            End If

            If ColumnName = "bad_qty" Then

                '    .Text("ok_qty") = .ToDec("dlv_qty") - ToDec(Value)

                '    If .ToDec("ok_qty") <> 0 Then
                '        .Text("chk") = "1"
                '    End If
                '    'g10.Text("chk") = IIf(Value = "", "0", "1")

            End If

            'If ColumnName = "brk_qty" Then
            '    If ToDec(Value) <> 0 Then
            '        .Text("chk") = "1"
            '        .Text("ok_qty") = .ToDec("dlv_qty") - .ToDec("bad_qty")
            '    End If
            'End If

        End With

        m_StopEvent = False
    End Sub

    Private Sub g50_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g50.CellValueChanged
        With g50

            If g20.Text("chk") <> "1" Then g20.Text("chk") = "1"

            '측정값으로 합불판정
            If ColumnName = "insp_val" Then
                If .ToDec("insp_min") <= ToDec(Value) And ToDec(Value) <= .ToDec("insp_max") Then
                    .Text("ok_yn") = "1"
                Else
                    .Text("ok_yn") = "0"
                End If
            End If
            '검사항목으로 시료 합불판정
            If ColumnName = "ok_yn" Then
                For i As Integer = 0 To .RowCount - 1
                    If .Text("ok_yn", i) = "0" Or .Text("ok_yn", i) = "" Then
                        g40.Text("ok_yn") = "0"
                        Exit Sub
                    End If
                Next
                g40.Text("ok_yn") = "1"
            End If
        End With
    End Sub

    Private Sub g60_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g60.CellValueChanged
        If AfterRow Then Exit Sub
        With g60
            Dim BandCol As String = ColumnName.Replace("ok_yn", "").Replace("insp_val", "")
            Dim Row As Integer = 0
            If BandCol <> "" Then
                Row = BandCol.Replace("&", "")
            End If

            Dim Colm As String = ColumnName.Replace(BandCol, "")
            If g20.Text("chk") <> "1" Then g20.Text("chk") = "1"

            '측정값으로 합불판정
            If Colm = "insp_val" Then
                If .ToDec("insp_min") <= ToDec(Value) And ToDec(Value) <= .ToDec("insp_max") Then
                    .Text(BandCol & "ok_yn") = "1"
                Else
                    .Text(BandCol & "ok_yn") = "0"
                End If
            End If
            '검사항목으로 시료 합불판정
            If Colm = "ok_yn" Then
                For i As Integer = 0 To .RowCount - 1
                    If .Text(BandCol & "ok_yn", i) = "0" Or .Text(BandCol & "ok_yn", i) = "" Then
                        g40.Text("ok_yn", Row - 1) = "0"
                        Exit Sub
                    End If
                Next
                g40.Text("ok_yn", Row - 1) = "1"
            End If
        End With
    End Sub

    Private Sub g30_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g30.CellValueChanged
        With g30
            If ColumnName = "bad_qty" Then SumBadQty()
        End With
    End Sub

    Private Sub SumBadQty()

        Dim BadQty As Double = 0

        Try
            With g30

                For Row As Integer = 0 To .RowCount - 1
                    If .IsDataRow(Row) Then
                        BadQty += .ToDec("bad_qty", Row)
                    End If
                Next
            End With
            bad_qty.Text = BadQty
            g20.Text("bad_qty") = BadQty
            If BadQty > 0 Then
                g20.Text("chk") = "1"
            End If
            If BadQty > 0 And rsp_cust_nm.Text = "" Then rsp_cust_nm.Text = g20.Text("cust_cd")

        Catch ex As Exception

        End Try

    End Sub

    Private Sub rtn_qty_TextChanged(sender As Object, oldValue As String) Handles rtn_qty.TextChanged
        If g20.RowCount <= 0 Then Exit Sub
        Dim OkQty As Double = g20.ToDec("dlv_qty") - rtn_qty.ToDec
        g20.Text("ok_qty") = OkQty
        g20.Text("chk") = "1"
    End Sub

    Private Sub r_Click(sender As Object, e As System.EventArgs) Handles r1.Click, r2.Click, r3.Click
        If r1.Checked Then chk_no.Text = "1"
        If r2.Checked Then chk_no.Text = "2"
        If r3.Checked Then chk_no.Text = "3"
        Open_Form()
    End Sub

    Private Sub QMM100_KRS_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize, img.Resize
        If img.SizeMode = ImageSizeMode.Squeeze Then
            img.Width = IIf(Me.Width > 600, Me.Width - 400, Me.Width)
            img.Height = Me.Height
        End If
        Dim L As Long = Me.Width - img.Width
        img.Left = Me.Width - img.Width
    End Sub

    Private Sub btn_resize_Click(sender As System.Object, e As System.EventArgs) Handles btn_resize.Click
        If img.SizeMode = ImageSizeMode.Stretch Then
            img.AutoSize = True
            img.SizeMode = ImageSizeMode.Squeeze

            img.Width = IIf(Me.Width > 600, Me.Width - 400, Me.Width)
            img.Height = Me.Height
            btn_resize.Text = "><"
        Else
            img.SizeMode = ImageSizeMode.Stretch
            img.AutoSize = False
            img.Width = 110
            img.Height = 104
            btn_resize.Text = "<>"
        End If
    End Sub

    Private Sub chk_img_CheckedChanged(sender As Object, e As System.EventArgs) Handles chk_img.CheckedChanged
        If chk_img.Checked Then
            OpenImg(g20.Text("itm_id"))
        Else
            btn_resize.Visible = False
            SplitContainer1.BringToFront()
        End If

    End Sub

End Class
