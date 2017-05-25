Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_TR1180
    Dim stts As String
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Clear()

        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
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

            Case MenuType.New
                New_Form()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub New_Form()

        'g_body.AddNewRow()
    End Sub

    Private Function Saves() As Boolean

        If Check_Stts() = "C" Then '상태값 CHECK
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        Max_NO()  '전표채번..

        Me.IPAMT()
        Me.delete_row()

        If wf_check() = 1 Then
            Return False
        End If

        If check_misu_amt() = 1 Then
            Return False
        End If

        If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else

            If MyBase.Save() Then
                stts1.Text = "S"

                p.Clear()
                p.Add("@daeche_no", daeche_no.Text)

                Me.Open("wi_tr1180_insert_extr1182", p)

                g_list.Open()
            End If
        End If

        '거래처 체크
        If Not Me.Check_CsCd() Then
            Return False
        End If

        Return True
    End Function

    Private Function Check_Stts() As String
        p.Clear()
        p.Add("@daeche_no", daeche_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_tr1180_stts", p)
        Dim stts As String = "S"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Sub Max_NO()
        daeche_no.CodeNo = "WI_TR1180"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        daeche_no.CodeDateField = daeche_dt
    End Sub

    Private Function Del() As Boolean

        If daeche_no.Text = Nothing Then
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
            p.Add("@daeche_no", daeche_no.Text)
            p.Add("@stts", "D")

            Me.Open("wi_tr1180_delete", p)

            p.Clear()
            p.Add("@daeche_no", "XXX")

            Me.Open("wi_tr1180_head", p)
            Me.Open("wi_tr1180_body", p)
            Me.Open("wi_tr1180_body1", p)

            g_list.Open()
        End If

        Return True
    End Function

    Private Function ConFrim() As Boolean

        If daeche_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        '상태값 CHECK
        If Check_Stts() = "C" Then
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        Me.IPAMT()
        Me.delete_row()

        If wf_check() = 1 Then
            Return False
        End If

        If check_misu_amt() = 1 Then
            Return False
        End If

        If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else

            p.Clear()
            p.Add("@daeche_no", daeche_no.Text)
            p.Add("@stts", "C")

            Me.Open("wi_tr1180_confirm", p)

            p.Clear()
            p.Add("@daeche_no", daeche_no.Text)
            p.Add("@daeche_dt", daeche_dt.Text)
            p.Add("@ps_cd", ps_cd.Text)

            Me.Open("wi_tr1180_insert_actr1000", p)

            p.Clear()
            p.Add("@daeche_no", daeche_no.Text)

            Me.Open("wi_tr1180_insert_extr1182", p)

            stts1.Text = "C"
            g_list.Open()
        End If

        Return True
    End Function

    Private Function DeConFrim() As Boolean

        If daeche_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        '상태값 CHECK
        If Check_Stts() <> "C" Then
            MsgBox("확인된 자료가 아닙니다.!")
            Return False
        End If

        If wf_de_check() <> 0 Then
            Return False
        End If

        If MessageYesNo("확인취소 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@daeche_no", daeche_no.Text)
            p.Add("@stts", "S")

            Me.Open("wi_tr1180_deconfirm", p)

            p.Clear()
            p.Add("@daeche_no", daeche_no.Text)

            Me.Open("wi_tr1180_head", p)
            Me.Open("wi_tr1180_body", p)
            Me.Open("wi_tr1180_body1", p)

            g_list.Open()
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
        p.Add("@daeche_no", "XXX")

        Me.Open("wi_tr1180_head", p)
        Me.Open("wi_tr1180_body", p)
        Me.Open("wi_tr1180_body1", p)
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
        p.Add("@find_stts", find_stts.Text)
        p.Add("@find_cs_nm", find_cs_nm.Text)

        Me.Open("wi_tr1180_list", p)
    End Sub

    Private Sub btn_find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_find.Click
        g_list.Open()
    End Sub

    Private Sub g_list_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g_list.DoubleClick
        p.Clear()
        p.Add("@daeche_no", g_list.Text("DAECHE_NO", g_list.RowIndex))

        Me.Open("wi_tr1180_head", p)
        Me.Open("wi_tr1180_body", p)
        Me.Open("wi_tr1180_body1", p)

        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.find_Clear()
    End Sub

    Private Sub IPAMT()
        Dim ip_amt1, won_amt1 As Double

        With g_body
            .UpdateRow()
            For i As Integer = 0 To .RowCount - 1
                ip_amt1 = ip_amt1 + .ToDec("DAECHE_AMT", i)
                won_amt1 = won_amt1 + .ToDec("WON_AMT", i)
            Next
        End With

        daeche_amt.Text = ip_amt1
        won_amt.Text = won_amt1
    End Sub

    Private Sub cs_cd_TextChanged(sender As System.Object, oldValue As System.String) Handles cs_cd.TextChanged
        If cur_cd.Text <> "" Then
            Me.wf_set_body(cs_cd.Text, cur_cd.Text)
            Me.wf_set_body1(cs_cd.Text, cur_cd.Text)
        End If
    End Sub

    Private Sub cur_cd_TextChanged(sender As Object, e As System.EventArgs) Handles cur_cd.TextChanged
        If cs_cd.Text <> "" Then
            Me.wf_set_body(cs_cd.Text, cur_cd.Text)
            Me.wf_set_body1(cs_cd.Text, cur_cd.Text)
        End If
    End Sub

    Private Sub wf_set_body(a_cscd As String, a_curcd As String)

        g_body.DeleteAll()

        p.Clear()
        p.Add("@CUR_CD", a_curcd)
        p.Add("@CS_CD", a_cscd)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_tr1180_set_body", p)

        If Not IsEmpty(dSet) Then
            With g_body
                Dim iRow As Integer = 0
                Dim dRow As DataRow, dRows As DataRowCollection
                dRows = dSet.Tables(0).Rows

                iRow = .RowIndex

                If .Text("IP_NO", .RowIndex) <> Nothing Then iRow += 1

                For Each dRow In dRows
                    .InsertNewRow(iRow)

                    .Text("IP_NO", iRow) = ToStr(dRow("IP_NO"))
                    .Text("IP_SEQ", iRow) = ToDec(dRow("SEQ"))
                    .Text("OD_NO", iRow) = ToStr(dRow("OD_NO"))
                    .Text("RATE", iRow) = ToDec(dRow("RATE"))
                    .Text("PRE_AMT", iRow) = ToDec(dRow("IP_AMT"))
                    .Text("IN_AMT", iRow) = ToDec(dRow("DAECHE_AMT"))

                    iRow += 1
                Next
            End With
        End If

        If g_body.RowCount <= 0 Then
            MsgBox("수주별 선수금 내역이 없습니다!")
        End If
    End Sub

    Private Sub wf_set_body1(a_cscd As String, a_curcd As String)
        g_body1.DeleteAll()

        p.Clear()
        p.Add("@CUR_CD", a_curcd)
        p.Add("@CS_CD", a_cscd)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_tr1180_set_body1", p)

        If Not IsEmpty(dSet) Then
            With g_body1
                Dim iRow As Integer = 0
                Dim dRow As DataRow, dRows As DataRowCollection
                dRows = dSet.Tables(0).Rows

                iRow = .RowIndex

                If .Text("INV_NO", .RowIndex) <> Nothing Then iRow += 1

                For Each dRow In dRows
                    .InsertNewRow(iRow)

                    .Text("INV_NO", iRow) = ToStr(dRow("OT_NO"))
                    .Text("OD_NO", iRow) = ToStr(dRow("OD_NO"))
                    .Text("OD_RATE", iRow) = ToDec(dRow("RATE"))
                    .Text("OD_AMT", iRow) = ToDec(dRow("OD_AMT"))
                    .Text("IN_AMT", iRow) = ToDec(dRow("IN_AMT"))
                    'Text("WON_AMT", iRow) = (ToDec(dRow("OD_AMT")) * ToDec(dRow("RATE")))
                    .Text("INV_WONAMT", iRow) = Math.Round(ToDec(dRow("OD_AMT")) * ToDec(dRow("RATE")))
                    iRow += 1
                Next
            End With
        End If

        If g_body1.RowCount <= 0 Then
            MsgBox("수주별 대체금 내역이 없습니다!")
        End If
    End Sub

    Private Sub g_body_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g_body.CellValueChanged
        If ColumnName = "DAECHE_AMT" Then
            g_body.Text("WON_AMT") = Math.Round(g_body.ToDec("DAECHE_AMT") * g_body.ToDec("RATE"))

            Me.IPAMT()
        End If
    End Sub

    Private Sub g_body1_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g_body1.CellValueChanged
        If ColumnName = "IP_AMT" Then
            g_body1.Text("SUB_AMT") = g_body1.ToDec("OD_AMT") - g_body1.ToDec("IN_AMT") - g_body1.ToDec("IP_AMT")
            g_body1.Text("WON_AMT") = Math.Round(g_body1.ToDec("IP_AMT") * g_body1.ToDec("OD_RATE"))
        End If
    End Sub

    Private Function wf_check() As Integer
        Dim ld_vamt1, ld_pamt1, ld_namt1, ld_rmamt, ld_tamt1, ld_ipamt1, ld_sumip1 As Decimal

        With g_body
            .UpdateRow()
            For i As Integer = 0 To .RowCount - 1
                ld_namt1 = .ToDec("IN_AMT", i)
                ld_vamt1 = .ToDec("PRE_AMT", i)
                ld_pamt1 = .ToDec("DAECHE_AMT", i)

                If ld_pamt1 > (ld_vamt1 - ld_namt1) Then
                    MsgBox("미대체금액을 초과하였습니다.")
                    .Focus()
                    .FocusedFieldName = "DAECHE_AMT"
                    .RowIndex = i
                    .EditMode()
                    Return 1
                End If

                ld_rmamt += ld_namt1
                ld_tamt1 += ld_pamt1
            Next
        End With

        With g_body1
            For b As Integer = 0 To g_body1.RowCount - 1
                ld_ipamt1 = .ToDec("IP_AMT", b)

                ld_sumip1 += ld_ipamt1
            Next
        End With

        If ld_tamt1 <> ld_sumip1 Then
            MsgBox("대체금액의 합계가 일치하지 않습니다.")
            Return 1
        End If

        If g_body.RowCount() <= 0 Then
            MsgBox("대체할 항목이 없습니다.")
            Return 1
        End If

        If g_body1.RowCount() <= 0 Then
            MsgBox("대체할 항목이 없습니다.")
            Return 1
        End If

        Return 0
    End Function

    Private Sub delete_row()
        Dim ld_ipamt, ld_ipamt1 As Decimal

        For i As Integer = 0 To g_body.RowCount - 1
            ld_ipamt = g_body.ToDec("DAECHE_AMT", i)

            If ld_ipamt = 0 Then
                g_body.DeleteRow(i)
            End If
        Next

        For b As Integer = 0 To g_body1.RowCount - 1
            ld_ipamt1 = g_body1.ToDec("IP_AMT", b)

            If ld_ipamt1 = 0 Then
                g_body1.DeleteRow(b)
            End If
        Next
    End Sub

    Private Function check_misu_amt() As Integer
        Dim ls_invno, ls_odno, ls_ipno As String
        Dim ld_ipamt, ld_odamt, ld_suminamt As Decimal

        ls_ipno = daeche_no.Text

        For i As Integer = 0 To g_body1.RowCount - 1
            ls_invno = g_body1.Text("INV_NO", i)
            ls_odno = g_body1.Text("OD_NO", i)
            ld_ipamt = g_body1.ToDec("IP_AMT", i)
            ld_odamt = g_body1.ToDec("OD_AMT", i)

            p.Clear()
            p.Add("@INV_NO", ls_invno)
            p.Add("@OD_NO", ls_odno)
            p.Add("@DAECHE_NO", ls_ipno)

            Me.Open("wi_tr1180_misu_chk1", p)

            Dim dSet As DataSet = Me.WorkSet("wi_tr1180_misu_chk1").DataSet

            If Not IsEmpty(dSet) Then

                Dim iRow As Integer = 0
                Dim dRow As DataRow, dRows As DataRowCollection
                dRows = dSet.Tables(0).Rows

                For Each dRow In dRows
                    Try
                        ld_suminamt = ToDec(dRow("IN_AMT"))
                    Catch ex As Exception
                        MessageError(ex, , "Display()")
                    End Try

                    iRow += 1
                Next
            End If

            If ld_ipamt > (ld_odamt - ld_suminamt) Then
                MsgBox("수주 : " + ls_odno + " 의 미수금액을 초과하였습니다.")
                Return 1
            End If
        Next

        Return 0
    End Function

    Private Function wf_de_check() As Integer
        p.Clear()
        p.Add("@DAECHE_NO", daeche_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_tr1180_de_chk", p)
        Dim ls_slgu As String

        If Not IsEmpty(dSet) Then
            ls_slgu = DataValue(dSet)
        Else
            ls_slgu = "0"
        End If

        If ls_slgu = "1" Then
            MsgBox("해당 전표번호로 등록된 미승인 회계전표가 있습니다.")
            Return 1
        ElseIf ls_slgu = "2" Then
            MsgBox("해당 전표번호로 등록된 승인된 회계전표가 있습니다.")
            Return 1
        End If

        Return 0
    End Function
End Class
