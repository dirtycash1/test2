Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_PR1306_DRY
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
        Me.Clear()

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                '    'Me.Open()
                '    'Open_Form()
            Case MenuType.Save
                If Not Saves() Then Exit Sub

            Case MenuType.Cancel
                set_lot_no.Text = ""

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

        'If Check_Body() <> 0 Then
        '    Return 1
        'End If

        If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            Max_NO()  '전표채번..

            If MyBase.Save() Then
            End If

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
        p.Add("@mv_no", mv_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("WI_PR1306_stts_DRY", p)
        Dim stts As String = "S"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Sub Max_NO()
        mv_no.CodeNo = "WI_JA1420_DRY"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        mv_no.CodeDateField = mv_dt
    End Sub

    Private Function Del() As Boolean

        If mv_no.Text = Nothing Then
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
            p.Add("@mv_no", mv_no.Text)

            Me.Open("WI_PR1306_delete_DRY", p)

            Me.Clear()

            g_list.Open()

        End If

        Return True
    End Function

    Private Function ConFrim() As Boolean

        If mv_no.Text = Nothing Then
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

            p.Clear()
            p.Add("@mv_no", mv_no.Text)
            p.Add("@stts", "C")

            Me.Open("WI_PR1306_confirm_DRY", p)

            stts.Text = "C"

        End If

        Return True
    End Function

    Private Function DeConFrim() As Boolean

        If mv_no.Text = Nothing Then
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
            p.Add("@mv_no", mv_no.Text)
            p.Add("@stts", "S")

            Me.Open("WI_PR1306_confirm_DRY", p)

            p.Clear()
            p.Add("@mv_no", mv_no.Text)

            Me.Open("WI_PR1306_head_DRY", p)
            Me.Open("WI_PR1306_body_DRY", p)

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
        p.Add("@mv_no", "XXX")

        Me.Open("WI_PR1306_head_DRY", p)
        Me.Open("WI_PR1306_body_DRY", p)
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
        p.Add("@find_lot_no", "XXX")
        p.Add("@find_fa_cd", "XXX")
        p.Add("@find_stts", "XXX")

        Me.Open("WI_PR1306_list_DRY", p)
    End Sub

    Private Sub find_Clear2()
        p.Clear()
        p.Add("@find_from2", find_from2.Text)
        p.Add("@find_to2", find_to2.Text)
        p.Add("@find_gd_nm2", "XXX")
        p.Add("@find_lot_no2", "XXX")
        p.Add("@find_fa_cd2", "XXX")

        Me.Open("WI_PR1306_list2_DRY", p)
    End Sub

    Private Sub btn_find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        g_list.Open()
    End Sub

    Private Sub g_list_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        p.Clear()
        p.Add("@mv_no", g_list.Text("MV_NO", g_list.RowIndex))

        Me.Open("WI_PR1306_head_DRY", p)
        Me.Open("WI_PR1306_body_DRY", p)

        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    Private Function Check_Body() As Integer
        Dim ld_stockqty As Decimal = 0
        Dim ld_chulqty As Decimal

        With g_body
            For i As Integer = 0 To .RowCount - 1
                p.Clear()
                p.Add("@GD_CD", .Text("GD_CD", i))
                p.Add("@FMPS_GU", fmps_gu.Text)

                Dim dSet As Data.DataSet = Me.OpenDataSet("WI_PR1306_stock_DRY", p)

                Dim iRow As Integer = 0
                Dim dRow As DataRow, dRows As DataRowCollection

                If Not IsEmpty(dSet) Then
                    dRows = dSet.Tables(0).Rows

                    For Each dRow In dRows
                        ld_stockqty = ToDec(dRow("STOCK_QTY"))
                    Next
                Else
                    ld_stockqty = 0
                End If

                .Text("STOCK", i) = ld_stockqty

                ld_chulqty = .Text("CHUL_QTY", i)

                'If ld_chulqty > ld_stockqty Then
                '    MsgBox("재고수량 보다 출고 수량이 많습니다.")
                '    .Focus()
                '    .FocusedFieldName = "GD_CD"
                '    .RowIndex = 1
                '    .EditMode()
                '    Return 1
                'End If
            Next
        End With

        Return 0
    End Function

    Private Sub btn_find2_Click(sender As Object, e As System.EventArgs) Handles btn_find2.Click
        g_list2.Open()
    End Sub

    Private Sub g_list2_DoubleClick(sender As Object, e As System.EventArgs) Handles g_list2.DoubleClick
        Me.Clear()
        set_lot_no.Text = ""


        'pr_jobno.Text = g_list2.Text("JOB_NO", g_list2.RowIndex)
        sa_cd.Text = g_list2.Text("SA_CD", g_list2.RowIndex)
        'fmps_gu.Text = g_list2.Text("WH_CD", g_list2.RowIndex)
        ip_no.Text = g_list2.Text("IP_NO", g_list2.RowIndex)
        pr_dt.Text = g_list2.Text("IP_DT", g_list2.RowIndex)

        fa_cd.Text = g_list2.Text("FA_CD", g_list2.RowIndex)

        If fa_cd.Text = "02" Then
            tmps_gu.Text = "P003"
        Else
            tmps_gu.Text = "P001"
        End If

        setJobNO()

        If find_visible2.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    Private Sub setJobNO()
        If ip_no.Text = Nothing Then Exit Sub

        Dim s_pr_jobno As String = "", s_gong_cd As String = ""

        s_pr_jobno = ip_no.Text

        p.Clear()
        p.Add("@IP_NO", ip_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_pr1306_set_DRY", p)
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
                    .Text("LOT_NO", ll_row) = ToStr(dRow("LOT_NO"))
                    .Text("MV_QTY", ll_row) = ToStr(dRow("IP_QTY"))
                    '.Text("MV_QTY", ll_row) = ToStr(dRow("IP_QTY"))
                    '.Text("TUIP_QTY", ll_row) = ToStr(dRow("QTY") * job_qty.ToDec)

                Next
            End With
        Else
            Exit Sub
        End If

    End Sub

    Private Sub setJobNO2()
        If set_lot_no.Text = Nothing Then Exit Sub

        Dim s_pr_jobno As String = "", s_gong_cd As String = ""

        s_pr_jobno = set_lot_no.Text

        p.Clear()
        p.Add("@LOT_NO", set_lot_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_pr1306_set2_DRY", p)
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
                    .Text("LOT_NO", ll_row) = ToStr(dRow("LOT_NO"))
                    .Text("MV_QTY", ll_row) = ToStr(dRow("IP_QTY"))
                    .Text("SA_CD", ll_row) = ToStr(dRow("SA_CD"))
                    .Text("FA_CD", ll_row) = ToStr(dRow("FA_CD"))
                    .Text("IP_DT", ll_row) = ToStr(dRow("IP_DT"))
                    '.Text("MV_QTY", ll_row) = ToStr(dRow("IP_QTY"))
                    '.Text("TUIP_QTY", ll_row) = ToStr(dRow("QTY") * job_qty.ToDec)

                Next
            End With
        Else
            Exit Sub
        End If

        'If fa_cd.Text = "02" Then
        '    tmps_gu.Text = "P003"
        'Else
        '    tmps_gu.Text = "P001"
        'End If

    End Sub

    Private Sub btn_find_Click1(sender As Object, e As System.EventArgs) Handles btn_find.Click
        g_list.Open()
    End Sub

    Private Sub g_list_DoubleClick1(sender As Object, e As System.EventArgs) Handles g_list.DoubleClick
        set_lot_no.Text = ""
        p.Clear()
        p.Add("@mv_no", g_list.Text("MV_NO", g_list.RowIndex))

        Me.Open("wi_pr1306_head_DRY", p)
        Me.Open("wi_pr1306_body_DRY", p)

        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
    End Sub


    Private Sub btn_cancel_Click(sender As Object, e As System.EventArgs) Handles btn_cancel.Click
        Me.find_Clear()
    End Sub

    Private Sub btn_cancel2_Click(sender As Object, e As System.EventArgs) Handles btn_cancel2.Click
        Me.find_Clear2()
    End Sub

    Private Sub set_lot_no_TextChanged(sender As Object, oldValue As String) Handles set_lot_no.TextChanged
        Me.Clear()

        setJobNO2()
    End Sub
End Class
