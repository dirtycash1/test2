Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_SA1150
    Dim stts As String
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Clear()

        g_list.SelectRow = True

        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open()

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
        Dim ls_odgu As String = ""

        ls_odgu = od_gu.Text

        g_body.AddNewRow()

        If ls_odgu = "CD05203" Then
            g_body.Focus()
            g_body.FocusedFieldName = "OT_NO"
        Else
            g_body.Focus()
            g_body.FocusedFieldName = "GD_GU1"
        End If
    End Sub

    Private Function Saves() As Boolean

        If Check_Stts() = "C" Then '상태값 CHECK
            MsgBox("반품 승인된 자료입니다.!")
            Return False
        ElseIf Check_Stts() = "A" Then
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        Me.RTAMT()

        Max_NO()  '전표채번..

        If wf_check() <> 0 Then
            Return False
        End If

        If check_rm_qty() = 1 Then
            Return False
        End If

        If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else

            If MyBase.Save() Then
                stts1.Text = "S"
            End If

            g_list.Open()
        End If

        '거래처 체크
        If Not Me.Check_CsCd() Then
            Return False
        End If

        Return True
    End Function

    Private Function Check_Stts() As String
        p.Clear()
        p.Add("@rt_no", rt_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1150_stts", p)
        Dim stts As String = "S"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Sub Max_NO()
        rt_no.CodeNo = "WI_SA1150"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        rt_no.CodeDateField = rrt_dt
    End Sub

    Private Function Del() As Boolean

        If rt_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        '상태값 CHECK
        If Check_Stts() = "C" Then '상태값 CHECK
            MsgBox("반품 승인된 자료입니다.!")
            Return False
        ElseIf Check_Stts() = "A" Then
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        If MessageYesNo("삭제 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@rt_no", rt_no.Text)
            p.Add("@stts", "D")

            Me.Open("wi_sa1150_delete", p)

            Me.Clear()

            g_list.Open()
        End If

        Return True
    End Function

    Private Function ConFrim() As Boolean

        If rt_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        '상태값 CHECK
        If Check_Stts() = "C" Then '상태값 CHECK
            MsgBox("반품 승인된 자료입니다.!")
            Return False
        ElseIf Check_Stts() = "A" Then
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        Me.RTAMT()

        If wf_check() <> 0 Then
            Return False
        End If

        If check_rm_qty() = 1 Then
            Return False
        End If

        If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            If MyBase.Save() Then
            End If

            p.Clear()
            p.Add("@rt_no", rt_no.Text)
            p.Add("@stts", "A")

            Me.Open("wi_sa1150_confirm", p)

            p.Clear()
            p.Add("@rt_no", rt_no.Text)
            Me.Open("wi_sa1150_head", p)
            p.Clear()
            p.Add("@rt_no", rt_no.Text)
            Me.Open("wi_sa1150_body", p)

            g_list.Open()
        End If

        Return True
    End Function

    Private Function DeConFrim() As Boolean

        If rt_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        '상태값 CHECK
        If Check_Stts() = "S" Then
            MsgBox("확인된 자료가 아닙니다.!")
            Return False
        ElseIf Check_Stts() = "C" Then
            MsgBox("반품 승인된 자료입니다.!")
            Return False
        End If
        If MessageYesNo("확인취소 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@rt_no", rt_no.Text)
            p.Add("@stts", "S")

            Me.Open("wi_sa1150_confirm", p)

            p.Clear()
            p.Add("@rt_no", rt_no.Text)
            Me.Open("wi_sa1150_head", p)
            p.Clear()
            p.Add("@rt_no", rt_no.Text)
            Me.Open("wi_sa1150_body", p)
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
        p.Add("@rt_no", "XXX")

        Me.Open("wi_sa1150_head", p)
        Me.Open("wi_sa1150_body", p)
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

        Me.Open("wi_sa1150_list", p)
    End Sub

    Private Sub btn_find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_find.Click
        g_list.Open()
    End Sub

    Private Sub g_list_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g_list.DoubleClick
        p.Clear()
        p.Add("@rt_no", g_list.Text("RT_NO", g_list.RowIndex))

        Me.Open("wi_sa1150_head", p)
        Me.Open("wi_sa1150_body", p)

        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.find_Clear()

    End Sub

    Private Sub RTAMT()
        Dim sum_amt1, vat_amt1, rt_amt1 As Double
        Dim rsum_amt1, rvat_amt1, rrt_amt1 As Double

        With g_body
            .UpdateRow()
            For i As Integer = 0 To .RowCount - 1
                rt_amt1 = rt_amt1 + .ToDec("RT_AMT", i)
                vat_amt1 = vat_amt1 + .ToDec("VAT_AMT", i)
                sum_amt1 = sum_amt1 + .ToDec("SUM_AMT", i)

                rrt_amt1 = rrt_amt1 + .ToDec("RRT_AMT", i)
                rvat_amt1 = rvat_amt1 + .ToDec("RRT_VAMT", i)
                rsum_amt1 = rsum_amt1 + .ToDec("RRT_SAMT", i)
            Next
        End With

        rt_amt.Text = rt_amt1
        vat_amt.Text = vat_amt1
        sum_amt.Text = sum_amt1

        rrt_amt.Text = rrt_amt1
        rrt_vamt.Text = rvat_amt1
        rrt_samt.Text = rsum_amt1
    End Sub

    Private Sub g_body_CellValueChanged(ByVal sender As System.Object, ByVal ColumnName As System.String, ByVal RowIndex As System.Int32, ByRef Value As System.Object) Handles g_body.CellValueChanged
        With g_body
            If ColumnName = "RRT_QTY" Or ColumnName = "RT_PRI" Then
                .Text("RT_AMT") = .ToDec("RRT_QTY") * .ToDec("RT_PRI")
                .Text("VAT_AMT") = ((.ToDec("RRT_QTY") * .ToDec("RT_PRI")) * 0.1)
                .Text("SUM_AMT") = (.ToDec("RRT_QTY") * .ToDec("RT_PRI")) + (((.ToDec("RRT_QTY") * .ToDec("RT_PRI")) * 0.1))
                .Text("WON_AMT") = (.ToDec("RRT_QTY") * .ToDec("RT_PRI")) * 1 '<-차후 환율로 고쳐야함.

                .Text("RRT_AMT") = .ToDec("RRT_QTY") * .ToDec("RT_PRI")
                .Text("RRT_VAMT") = ((.ToDec("RRT_QTY") * .ToDec("RT_PRI")) * 0.1)
                .Text("RRT_SAMT") = (.ToDec("RRT_QTY") * .ToDec("RT_PRI")) + (((.ToDec("RRT_QTY") * .ToDec("RT_PRI")) * 0.1))

                Me.RTAMT()
            End If
        End With

        Select Case ColumnName
            Case "HOT_CD"
                Try
                    Me.popUP(Value)

                    'setPrice()

                    Dim sps As String
                    For i = 10 To 90 Step 10
                        sps = i.ToString()
                        g_body.ColumnReadOnly("SPEC" & sps) = True
                    Next

                    Me.hot_spec(Value)
                Catch ex As Exception

                End Try
            Case "SPEC10", "SPEC20", "SPEC30", "SPEC40", "SPEC50", "SPEC60", "SPEC70", "SPEC80", "SPEC90"
                'MsgBox(ColumnName)

                Try
                    Me.spec(Value)
                Catch ex As Exception

                End Try
            Case "OD_QTY", "OD_PRI"
                'totAmt()
                'Case "GD_CD"
                '    If Value = "" Then Exit Sub
                '    setPrice()
        End Select


    End Sub

#Region "컬럼값 변경 Function"

    Private Sub g_bodyClear()
        Try
            g_body.Text("HOT_CD", g_body.RowIndex) = ""
            g_body.Text("GD_CD", g_body.RowIndex) = ""
            g_body.Text("GD_NM", g_body.RowIndex) = ""
            g_body.Text("NM_NM", g_body.RowIndex) = ""
            g_body.Text("SPEC", g_body.RowIndex) = ""
            g_body.Text("UNIT_CD", g_body.RowIndex) = ""
            g_body.Text("SALE_CD", g_body.RowIndex) = ""

            g_body.Text("SPEC10", g_body.RowIndex) = ""
            g_body.Text("SPEC20", g_body.RowIndex) = ""
            g_body.Text("SPEC30", g_body.RowIndex) = ""
            g_body.Text("SPEC40", g_body.RowIndex) = ""
            g_body.Text("SPEC50", g_body.RowIndex) = ""
            g_body.Text("SPEC60", g_body.RowIndex) = ""
            g_body.Text("SPEC70", g_body.RowIndex) = ""
            g_body.Text("SPEC80", g_body.RowIndex) = ""
            g_body.Text("SPEC90", g_body.RowIndex) = ""
        Catch ex As Exception

        End Try


    End Sub

    Private Sub totAmt()
        Dim od_amt1 As Double, vat_amt1 As Double, AMT As Double

        With g_body
            .UpdateRow()
            For i As Integer = 0 To .RowCount - 1
                AMT = .ToDec("OD_QTY", i) * .ToDec("OD_PRI", i)
                .Text("AMT", i) = AMT
                .Text("DISCOUNT_AMT", i) = AMT * .ToDec("DISCOUNT_RT", i) / 100
                .Text("OD_AMT", i) = AMT - (AMT * .ToDec("DISCOUNT_RT", i) / 100)

                od_amt1 = od_amt1 + AMT - (AMT * .ToDec("DISCOUNT_RT", i) / 100)
                vat_amt1 = vat_amt1 + .ToDec("VAT_AMT", i)
            Next
        End With

        rrt_amt.Text = od_amt1
        vat_amt.Text = vat_amt1
        rrt_samt.Text = od_amt1 + vat_amt1
    End Sub

    Private Sub setPrice()
        p.Clear()
        p.Add("@cs_cd", cs_cd.Text)
        p.Add("@hot_cd", g_body.Text("HOT_CD", g_body.RowIndex))

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1150_price", p)
        Dim price As Decimal = 0, rate_rt As Decimal = 0

        'If Not IsEmpty(dSet) Then price = DataValue(dSet)

        'g_body.Text("OD_PRI", g_body.RowIndex) = price.ToString
        'g_body.Text("DISCOUNT_RT", g_body.RowIndex) = price.ToString
        'Return price

        Dim dRow As DataRow, dRows As DataRowCollection

        If IsEmpty(dSet) Then
            g_body.Text("OD_PRI", g_body.RowIndex) = ""
            g_body.Text("DISCOUNT_RT", g_body.RowIndex) = ""
            Exit Sub
        End If

        dRows = dSet.Tables(0).Rows

        For Each dRow In dRows
            g_body.Text("OD_PRI", g_body.RowIndex) = ToStr(dRow("price"))
            g_body.Text("DISCOUNT_RT", g_body.RowIndex) = ToStr(dRow("rate_rt"))
        Next

    End Sub

    Private Sub popUP(hot_cd As String)

        p.Clear()
        p.Add("@hot_cd", g_body.Text("HOT_CD", g_body.RowIndex))

        If g_body.Text("HOT_CD", g_body.RowIndex) = "" Then
            'g_bodyClear()
            Exit Sub
        End If


        'MsgBox(g_body.Text("HOT_CD", g_body.RowIndex))

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1150_hot_cd", p)
        Dim nm_cd As String = "", nm_nm As String = ""
        Dim dRow As DataRow, dRows As DataRowCollection

        If IsEmpty(dSet) Then
            g_bodyClear()
            Exit Sub
        End If

        dRows = dSet.Tables(0).Rows

        'g_bodyClear()

        For Each dRow In dRows
            nm_cd = ToStr(dRow("nm_cd"))
            nm_nm = ToStr(dRow("nm_nm"))

            g_body.Text("SALE_CD", g_body.RowIndex) = nm_cd
            g_body.Text("GD_CD", g_body.RowIndex) = nm_cd
            g_body.Text("GD_NM", g_body.RowIndex) = nm_nm

            g_body.Text("P10", g_body.RowIndex) = ToStr(dRow("P10"))
            g_body.Text("P20", g_body.RowIndex) = ToStr(dRow("P20"))
            g_body.Text("P30", g_body.RowIndex) = ToStr(dRow("P30"))
            g_body.Text("P40", g_body.RowIndex) = ToStr(dRow("P40"))
            g_body.Text("P50", g_body.RowIndex) = ToStr(dRow("P50"))
            g_body.Text("P60", g_body.RowIndex) = ToStr(dRow("P60"))
            g_body.Text("P70", g_body.RowIndex) = ToStr(dRow("P70"))
            g_body.Text("P80", g_body.RowIndex) = ToStr(dRow("P80"))
            g_body.Text("P90", g_body.RowIndex) = ToStr(dRow("P90"))

            g_body.Text("S10", g_body.RowIndex) = "10"
            g_body.Text("S20", g_body.RowIndex) = "20"
            g_body.Text("S30", g_body.RowIndex) = "30"
            g_body.Text("S40", g_body.RowIndex) = "40"
            g_body.Text("S50", g_body.RowIndex) = "50"
            g_body.Text("S60", g_body.RowIndex) = "60"
            g_body.Text("S70", g_body.RowIndex) = "70"
            g_body.Text("S80", g_body.RowIndex) = "80"
            g_body.Text("S90", g_body.RowIndex) = "90"

            If g_body.Text("P10", g_body.RowIndex) = "N" Then g_body.Text("SPEC10", g_body.RowIndex) = ""
            If g_body.Text("P20", g_body.RowIndex) = "N" Then g_body.Text("SPEC20", g_body.RowIndex) = ""
            If g_body.Text("P30", g_body.RowIndex) = "N" Then g_body.Text("SPEC30", g_body.RowIndex) = ""
            If g_body.Text("P40", g_body.RowIndex) = "N" Then g_body.Text("SPEC40", g_body.RowIndex) = ""
            If g_body.Text("P50", g_body.RowIndex) = "N" Then g_body.Text("SPEC50", g_body.RowIndex) = ""
            If g_body.Text("P60", g_body.RowIndex) = "N" Then g_body.Text("SPEC60", g_body.RowIndex) = ""
            If g_body.Text("P70", g_body.RowIndex) = "N" Then g_body.Text("SPEC70", g_body.RowIndex) = ""
            If g_body.Text("P80", g_body.RowIndex) = "N" Then g_body.Text("SPEC80", g_body.RowIndex) = ""
            If g_body.Text("P90", g_body.RowIndex) = "N" Then g_body.Text("SPEC90", g_body.RowIndex) = ""

        Next

    End Sub

    Private Sub spec(hot_cd As String)

        If g_body.Text("SALE_CD", g_body.RowIndex) = "" Then Exit Sub

        p.Clear()
        p.Add("@sale_cd", g_body.Text("SALE_CD", g_body.RowIndex))
        p.Add("@spec10", g_body.Text("SPEC10", g_body.RowIndex))
        p.Add("@spec20", g_body.Text("SPEC20", g_body.RowIndex))
        p.Add("@spec30", g_body.Text("SPEC30", g_body.RowIndex))
        p.Add("@spec40", g_body.Text("SPEC40", g_body.RowIndex))
        p.Add("@spec50", g_body.Text("SPEC50", g_body.RowIndex))
        p.Add("@spec60", g_body.Text("SPEC60", g_body.RowIndex))
        p.Add("@spec70", g_body.Text("SPEC70", g_body.RowIndex))
        p.Add("@spec80", g_body.Text("SPEC80", g_body.RowIndex))
        p.Add("@spec90", g_body.Text("SPEC90", g_body.RowIndex))

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1150_spec", p)
        'Dim nm_cd As String = "", nm_nm As String = ""
        Dim dRow As DataRow, dRows As DataRowCollection

        If IsEmpty(dSet) Then
            'g_body.Text("HOT_CD", g_body.RowIndex) = ""
            g_body.Text("GD_CD", g_body.RowIndex) = ""
            g_body.Text("GD_NM", g_body.RowIndex) = ""
            g_body.Text("SPEC", g_body.RowIndex) = ""
            g_body.Text("UNIT_CD", g_body.RowIndex) = ""
            'g_body.Text("SALE_CD", g_body.RowIndex) = ""
            Exit Sub
        End If

        dRows = dSet.Tables(0).Rows

        For Each dRow In dRows
            'nm_cd = ToStr(dRow("gd"))
            'nm_nm = ToStr(dRow("nm_nm"))

            g_body.Text("GD_CD", g_body.RowIndex) = ToStr(dRow("GD_CD"))
            g_body.Text("GD_NM", g_body.RowIndex) = ToStr(dRow("GD_NM"))
            g_body.Text("SPEC", g_body.RowIndex) = ToStr(dRow("SPEC"))
            g_body.Text("UNIT_CD", g_body.RowIndex) = ToStr(dRow("UNIT_CD"))

        Next

        'g_body.Focus()
        'g_body.FocusedFieldName = "MI_CHUL_QTY"
        ''g_body.RowIndex 
        'g_body.EditMode()

    End Sub

    Private Sub hot_spec(hot_cd As String)

        Dim sps As String
        For i = 10 To 90 Step 10
            sps = i.ToString()
            g_body.ColumnReadOnly("SPEC" & sps) = True
        Next

        p.Clear()
        p.Add("@hot_cd", hot_cd)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1150_hot_spec", p)
        'Dim nm_cd As String = "", nm_nm As String = ""
        Dim dRow As DataRow, dRows As DataRowCollection

        'g_bodyClear()

        If IsEmpty(dSet) Then


            ''g_body.Text("HOT_CD", g_body.RowIndex) = ""
            'g_body.Text("GD_CD", g_body.RowIndex) = ""
            'g_body.Text("GD_NM", g_body.RowIndex) = ""
            'g_body.Text("SPEC", g_body.RowIndex) = ""
            'g_body.Text("UNIT_CD", g_body.RowIndex) = ""
            ''g_body.Text("SALE_CD", g_body.RowIndex) = ""
            Exit Sub
        End If

        dRows = dSet.Tables(0).Rows

        For Each dRow In dRows
            'nm_cd = ToStr(dRow("gd"))
            'nm_nm = ToStr(dRow("nm_nm"))

            'g_body.Text("NM_CD", g_body.RowIndex) = ToStr(dRow("NM_CD"))
            g_body.ColumnReadOnly("SPEC" + ToStr(dRow("SPEC_CD"))) = False
        Next

        g_body.Focus()
        g_body.FocusedFieldName = "SPEC" + ToStr(dRows(0))
        'g_body.RowIndex 
        g_body.EditMode()

    End Sub

    Private Sub g_body_AfterMoveColumn(sender As Object, PrevColumnName As String, ColumnName As String) Handles g_body.AfterMoveColumn
        'If g_body.FieldName(g_body.ColumnIndex) = "SPEC10" Then
        If ColumnName = "SPEC10" Then
            If g_body.Text("P10", g_body.RowIndex) = "N" Then SetColumnFocus("SPEC20")
        End If

        If ColumnName = "SPEC20" Then
            If g_body.Text("P20", g_body.RowIndex) = "N" Then SetColumnFocus("SPEC30")
        End If

        If ColumnName = "SPE30" Then
            If g_body.Text("P30", g_body.RowIndex) = "N" Then SetColumnFocus("SPEC40")
        End If

        If ColumnName = "SPEC40" Then
            If g_body.Text("P40", g_body.RowIndex) = "N" Then SetColumnFocus("SPEC50")
        End If

        If ColumnName = "SPEC50" Then
            If g_body.Text("P50", g_body.RowIndex) = "N" Then SetColumnFocus("SPEC60")
        End If

        If ColumnName = "SPEC60" Then
            If g_body.Text("P60", g_body.RowIndex) = "N" Then SetColumnFocus("SPEC70")
        End If

        If ColumnName = "SPEC70" Then
            If g_body.Text("P70", g_body.RowIndex) = "N" Then SetColumnFocus("SPEC80")
        End If

        If ColumnName = "SPEC80" Then
            If g_body.Text("P80", g_body.RowIndex) = "N" Then SetColumnFocus("SPEC90")
        End If

        If ColumnName = "SPEC90" Then
            If g_body.Text("P90", g_body.RowIndex) = "N" Then SetColumnFocus("OD_QTY")
        End If
    End Sub

    Private Sub SetColumnFocus(columnName)
        For i = 0 To g_body.ColumnCount - 1
            If g_body.FieldName(i) = columnName Then
                g_body.ColumnIndex = i
                Exit Sub
            End If
        Next
    End Sub
#End Region

    Private Function wf_check() As Integer
        Dim ls_odgu, ls_otno, ls_gdcd, ls_otgdcd, ls_gdgu, ls_lotno As String

        'ls_odgu = od_gu.Text

        With g_body
            For i As Integer = 0 To .RowCount - 1
                ls_otno = .Text("OT_NO", i)
                ls_gdcd = .Text("GD_CD", i)
                ls_otgdcd = .Text("OT_GDCD", i)
                ls_gdgu = .Text("GD_GU", i)
                ls_lotno = .Text("LOT_NO", i)
                ls_odgu = .Text("OD_GU", i)

                If ls_odgu = "CD05203" Then
                    If ls_otno = "" Then
                        MsgBox("구분이 위탁이면 출하번호는 필수 입력필드입니다")
                        .Focus()
                        .FocusedFieldName = "OT_NO"
                        .RowIndex = i
                        .EditMode()
                        Return 1
                    End If

                    If ls_gdcd <> ls_otgdcd Then
                        MsgBox("위탁 출하된 품목과 같지 않습니다")
                        .Focus()
                        .FocusedFieldName = "OT_NO"
                        .RowIndex = i
                        .EditMode()
                        Return 1
                    End If
                Else
                    If ls_otno <> "" Then
                        MsgBox("구분이 위탁이면 아니면 출하번호를 입력할 수 없습니다")
                        .Focus()
                        .FocusedFieldName = "OT_NO"
                        .RowIndex = i
                        .EditMode()
                        Return 1
                    End If
                End If

                If ls_gdgu = "CD0651" Then '완반일 때 LOT 필수
                    If (ls_lotno = "") Then 'Or (ls_lotno = "*") Then
                        MsgBox("완반이면 LOT NO는 필수 입력필드입니다")
                        .Focus()
                        .FocusedFieldName = "LOT_NO"
                        .RowIndex = i
                        .EditMode()
                        Return 1
                    End If
                End If
            Next
        End With

        Return 0
    End Function

    Private Function check_rm_qty() As Integer
        Dim ls_rtno, ls_otno, ls_odgu As String
        Dim ll_otseq As Integer
        Dim ld_rmqty, ld_rtqty As Decimal

        ls_rtno = rt_no.Text
        ls_odgu = od_gu.Text

        If ls_odgu = "CD05203" Then
            For i As Integer = 0 To g_body.RowCount - 1
                ls_otno = g_body.Text("OT_NO", i)
                ll_otseq = g_body.ToDec("OT_SEQ", i)
                ld_rtqty = g_body.ToDec("RRT_QTY", i)

                p.Clear()
                p.Add("@ot_no", ls_otno)
                p.Add("@ot_seq", ll_otseq)
                p.Add("@rt_no", ls_rtno)

                Me.Open("wi_sa1150_rmqty_chk", p)

                Dim dSet As DataSet = Me.WorkSet("wi_sa1150_rmqty_chk").DataSet

                If Not IsEmpty(dSet) Then

                    Dim iRow As Integer = 0
                    Dim dRow As DataRow, dRows As DataRowCollection
                    dRows = dSet.Tables(0).Rows

                    For Each dRow In dRows
                        Try
                            ld_rmqty = ToDec(dRow("RM_QTY"))
                        Catch ex As Exception
                            MessageError(ex, , "Display()")
                        End Try

                        iRow += 1
                    Next

                    If ld_rtqty > ld_rmqty Then
                        MsgBox("잔량을 초과하였습니다.")
                        g_body.Focus()
                        g_body.FocusedFieldName = "RRT_QTY"
                        g_body.RowIndex = i
                        g_body.EditMode()
                        Return 1
                    End If
                End If
            Next
        End If
    End Function

    Private Sub g_body_CellValueChanging(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g_body.CellValueChanging
        Dim ls_gdgu1, ls_gdgu As String

        If ColumnName = "GD_GU1" Then
            ls_gdgu1 = Value

            ls_gdgu = "CD065" + ls_gdgu1

            g_body.Text("GD_GU", RowIndex) = ls_gdgu

        End If
    End Sub

    Private Sub cs_cd_TextChanged(sender As System.Object, oldValue As System.String) Handles cs_cd.TextChanged
        If g_body.RowCount > 0 Then Exit Sub

        g_body.AddNewRow()
        g_body.Focus()

    End Sub

End Class
