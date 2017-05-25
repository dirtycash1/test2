Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data
Imports System.Collections

Public Class WI_SA1261
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
        Me.Clear()

        'MenuButton_Click(MenuType.Find)
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open()
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

            Case MenuType.New
                New_Form()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub New_Form()
        'Clear()

        g_body.AddNewRow()
    End Sub

    Private Function Saves() As Boolean

        If Check_Stts() = "C" Then '상태값 CHECK
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        If LOT_AUTO.Text = "0" Then
            Me.TUIP_QTY()
        End If

        If Not TUIP_QTY2() Then Return False

        If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            Max_NO()  '전표채번..

            If Not MyBase.Save() Then Exit Function
            'MyBase.OpenTrigger("wi_sa1120_list")

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

        Dim dSet As Data.DataSet = Me.OpenDataSet("WI_SA1261_stts", p)
        Dim stts As String = "S"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Sub Max_NO()
        ' p/o 번호 채번
        pr_no.CodeNo = "WI_SA1261"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
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

            Me.Open("WI_SA1261_delete", p)

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

        If Not TUIP_QTY2() Then Return False

        If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            'Me.Open("WI_SA1261_confirm")

            p.Clear()
            p.Add("@pr_no", pr_no.Text)
            p.Add("@stts", "C")

            Me.Open("WI_SA1261_confirm", p)

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

        If MessageYesNo("확인취소 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@pr_no", pr_no.Text)
            p.Add("@stts", "S")

            Me.Open("WI_SA1261_confirm", p)

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
        'If find_visible.Checked Then MenuButton_Click(MenuType.Find)

        p.Clear()
        p.Add("@pr_no", "XXX")

        Me.Open("WI_SA1261_head", p)
        Me.Open("WI_SA1261_body", p)
        Me.Open("WI_SA1261_body1", p)

        p.Add("@pr_seq", 0)
        Me.Open("WI_SA1261_body2", p)

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

        Me.Open("WI_SA1261_list", p)
    End Sub

    Private Sub TUIP_QTY()
        Dim tot_qty As Double

        With g_body2
            .UpdateRow()
            For i As Integer = 0 To .RowCount - 1
                tot_qty = tot_qty + .ToDec("TUIP_QTY", i)
            Next
        End With

        g_body.Text("TUIP_QTY", g_body.RowIndex) = tot_qty.ToString

        'bi_amt.Text = sum_amt
    End Sub

    Private Function TUIP_QTY2() As Boolean
        Dim t As Boolean

        t = True

        With g_body
            '.Update()
            '.UpdateRow()
            For i As Integer = 0 To .RowCount - 1
                'MsgBox(g_body.Text("J0B_QTY", i))

                If (g_body.ToDec("PO_QTY", i) - g_body.ToDec("G_QTY", i)) < g_body.ToDec("TUIP_QTY", i) Then

                    MsgBox("지시수량보다 많습니다.!")
                    t = False

                    Exit For

                End If
            Next

        End With

        Return t
        'bi_amt.Text = sum_amt
    End Function

    Private Sub btn_find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        g_list.Open()
    End Sub

    'Private Sub rate_TextChanged(ByVal sender As Object, ByVal oldValue As String) Handles Rate.TextChanged
    '    won_amt.Text = bal_amt.ToDec * Rate.ToDec
    'End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.find_Clear()

    End Sub


    Private Sub g_list_DoubleClick1(sender As Object, e As System.EventArgs) Handles g_list.DoubleClick
        LOT_AUTO.Text = "0"
        Me.Clear()

        p.Clear()
        p.Add("@pr_no", g_list.Text("PR_NO", g_list.RowIndex))

        Me.Open("WI_SA1261_head", p)
        Me.Open("WI_SA1261_body", p)
        Me.Open("WI_SA1261_body1", p)

        If find_visible.Checked Then MenuButton_Click(MenuType.Find)

    End Sub

    Private Sub btn_cancel_Click1(sender As Object, e As System.EventArgs) Handles btn_cancel.Click
        find_Clear()

    End Sub

    Private Sub btn_find_Click1(sender As Object, e As System.EventArgs) Handles btn_find.Click
        g_list.Open()
    End Sub

    Private Sub popUP(s As String)
        p.Clear()
        p.Add("@hot_cd", s)

        If s = "" Then Exit Sub

        Dim dSet As Data.DataSet = Me.OpenDataSet("WI_SA1261_hot_cd", p)
        Dim nm_cd As String = "", nm_nm As String = ""
        Dim dRow As DataRow, dRows As DataRowCollection

        If IsEmpty(dSet) Then
            gd_cd.Text = ""
            'gd_nm.Text = ""
            'spec.Text = ""

            Exit Sub
        End If

        dRows = dSet.Tables(0).Rows

        For Each dRow In dRows
            nm_cd = ToStr(dRow("nm_cd"))
            nm_nm = ToStr(dRow("nm_nm"))
        Next

        '----------------------------------------------------------------------------
        'Dim popup As New WH_CO1201_F
        ''Dim p As String()

        ''If g_body.ColumnIndex <> 1 Then Exit Sub

        'popup.InitPopup(nm_cd, nm_nm, "")

        'If popup.ShowDialog() = DialogResult.OK Then

        '    If popup.ActiveControl.Tag IsNot Nothing Then
        '        Dim pReturn As eGrid = popup.ActiveControl.Tag
        '        Dim ll_row As Integer
        '        ll_row = pReturn.RowIndex

        '        gd_cd.Text = pReturn.Text("GD_CD", ll_row)
        '        'g_body.Text("GD_NM") = pReturn.Text("GD_NM", ll_row)
        '        'g_body.Text("SPEC") = pReturn.Text("SPEC", ll_row)
        '        'g_body.Text("UNIT_CD") = pReturn.Text("UNIT_CD", ll_row)

        '        '''멀티 선택시 ..
        '        'For i = 0 To pReturn.RowCount - 1
        '        '    'If pReturn.Text("CHK", i) = "1" Then
        '        '    'g_body.AddNewRow()

        '        '    g_body.Text("GD_CD") = pReturn.Text("GD_CD", i)
        '        '    g_body.Text("GD_NM") = pReturn.Text("GD_NM", i)
        '        '    g_body.Text("SPEC") = pReturn.Text("SPEC", i)
        '        '    g_body.Text("UNIT_CD") = pReturn.Text("UNIT_CD", i)

        '        '    ll_row = ll_row + 1

        '        '    g_body.InsertNewRow(ll_row)
        '        '    'End If
        '        'Next

        '        'g_body.DeleteRow(ll_row)


        '    Else
        '        ' 결과 파라미터가 없는경우
        '    End If

        'Else
        'End If
    End Sub

    Private Sub setJobNO()

        p.Clear()
        p.Add("@pr_jobno", pr_jobno.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1261_jobno", p)

        'Me.Clear()

        If Not IsEmpty(dSet) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            For Each dRow In dRows
                job_qty.Text = ToStr(dRow("JOB_QTY"))
                pr_qty.Text = ToStr(dRow("JOB_QTY"))
                fwh_cd.Text = ToStr(dRow("FWH_CD"))
                twh_cd.Text = ToStr(dRow("TWH_CD"))
                fwh_cd04.Text = ToStr(dRow("FWH_CD04"))
                fwh_cd05.Text = ToStr(dRow("FWH_CD05"))
                fa_cd.Text = ToStr(dRow("FA_CD"))
                nm_cd.Text = ToStr(dRow("NM_CD"))
                nm_nm.Text = ToStr(dRow("NM_NM"))
            Next
        End If

        p.Clear()
        p.Add("@pr_no", "XXXX")
        Me.Open("wi_sa1261_body", p)

        p.Clear()
        p.Add("@pr_jobno", pr_jobno.Text)

        dSet = Me.OpenDataSet("wi_sa1261_bom", p)
        Dim ll_row As Integer = 0

        If Not IsEmpty(dSet) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            With g_body
                ll_row = .RowIndex
                For Each dRow In dRows
                    .InsertNewRow(ll_row)
                    .Text("JOB_NO", ll_row) = ToStr(dRow("JOB_NO"))
                    .Text("JOB_SEQ", ll_row) = ToStr(dRow("JOB_SEQ"))
                    .Text("PR_SEQ", ll_row) = ToStr(dRow("JOB_SEQ"))
                    .Text("S_GDCD", ll_row) = ToStr(dRow("S_GDCD"))
                    .Text("GD_CD", ll_row) = ToStr(dRow("GD_CD"))
                    .Text("GD_NM", ll_row) = ToStr(dRow("GD_NM"))
                    .Text("SPEC", ll_row) = ToStr(dRow("SPEC"))
                    .Text("UNIT_CD", ll_row) = ToStr(dRow("UNIT_CD"))
                    .Text("PO_QTY", ll_row) = ToStr(dRow("PO_QTY"))
                    .Text("JOB_QTY", ll_row) = ToStr(dRow("JOB_QTY"))
                    .Text("G_QTY", ll_row) = ToStr(dRow("TUIP_QTY")) ' * job_qty.ToDec)

                Next
            End With

        End If

    End Sub

    'Private Sub pr_jobno_TextChanged(sender As Object, oldValue As String) Handles pr_jobno.TextChanged
    '    setJobNO()
    'End Sub

    Private Sub find_Clear2()
        p.Clear()
        p.Add("@find_from2", find_from2.Text)
        p.Add("@find_to2", find_to2.Text)
        p.Add("@find_pr_jobno2", "XXX")

        Me.Open("wi_sa1261_list2", p)
    End Sub

    Private Sub btn_find2_Click(sender As Object, e As System.EventArgs) Handles btn_find2.Click
        g_list2.Open()
    End Sub

    Private Sub btn_cancel2_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancel2.Click
        find_Clear2()
    End Sub

    Private Sub find_list2()
        Me.Clear()

        pr_jobno.Text = g_list2.Text("JOB_NO", g_list2.RowIndex)
        setJobNO()
    End Sub

    Private Sub g_list2_DoubleClick(sender As Object, e As System.EventArgs) Handles g_list2.DoubleClick
        find_list2()
        If find_visible2.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    Private Sub g_body2_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g_body2.CellValueChanged
        If Not ColumnName = "TUIP_QTY" Then Exit Sub

        Me.TUIP_QTY()

    End Sub

    Private Sub g_body_AfterMoveRow(sender As Object, PrevRowIndex As Integer, RowIndex As Integer) Handles g_body.AfterMoveRow
        If RowIndex < 0 Then Exit Sub

        p.Clear()
        p.Add("@pr_no", g_body.Text("PR_NO", RowIndex))
        p.Add("@pr_seq", g_body.Text("PR_SEQ", RowIndex))

        Me.Open("WI_SA1261_body2", p)
    End Sub

    Private Sub g_body_BeforeMoveRow(sender As Object, RowIndex As Integer, ByRef AllowMove As Boolean) Handles g_body.BeforeMoveRow
        If g_body2.DataChanged() Then
            'Select Case MessageYesNoCancel("저장하시겠습니까 ?")
            '    Case MsgBoxResult.Yes
            If Not Me.Saves() Then
                '저장에 실패 했으면 Move Row가 허용되면 안된다
                ' AllowMove = False
                Exit Sub
            End If
            '    Case MsgBoxResult.No
            ''No를 눌렀으면 저장하지 않고 Row를 변경한다
            'Exit Sub
            '    Case MsgBoxResult.Cancel
            ''취소를 눌렀으면 Row이동을 취소 한다 (Row를 변경하지 않는다)
            'AllowMove = False
            'End Select

        End If
    End Sub

    Private Sub LOT_AUTO_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles LOT_AUTO.CheckedChanged
        Dim tot_qty As Double
        If LOT_AUTO.Text = "1" Then

            With g_body
                .UpdateRow()
                For i As Integer = 0 To .RowCount - 1
                    g_body.RowIndex = i
                    tot_qty = .ToDec("PO_QTY", i)
                    g_body.Text("TUIP_QTY", g_body.RowIndex) = tot_qty.ToString
                Next
            End With
        Else
            With g_body
                .UpdateRow()
                For i As Integer = 0 To .RowCount - 1
                    g_body.RowIndex = i
                    tot_qty = "0"
                    g_body.Text("TUIP_QTY", g_body.RowIndex) = tot_qty.ToString
                Next
            End With
        End If



    End Sub
End Class
