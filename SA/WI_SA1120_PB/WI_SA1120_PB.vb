Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class WI_SA1120_PB
    'Dim ls_stts As String
    Dim p As New OpenParameters


    Private Sub WI_SA1120_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
        Me.Clear()

        g_list.SelectRow = True

        Dim sps As String
        For i = 10 To 90 Step 10
            sps = i.ToString()
            g_body.ColumnReadOnly("SPEC" & sps) = True
        Next

        g_body.ColumnReadOnly("OD_PRI") = True '20141119 SMK/첫화면로드시, 수주단가는 읽기전용으로 설정.

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open()

            Case MenuType.Cancel

                Me.Clear()
            Case MenuType.New
                New_Form()

            Case MenuType.Save

                If Not Saves() Then Exit Sub

            Case MenuType.Confirm

                If Not ConFrim() Then Exit Sub

            Case MenuType.Deconfirm

                If Not DeConFrim() Then Exit Sub

            Case MenuType.Find

                Me.Find()

            Case MenuType.Delete

                Me.Del()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub
    Public Sub open2(ByVal cust_cd As String)

        Me.Clear()

        cs_cd.Text = cust_cd
        'Me.Open()
        g_body.Focus()

    End Sub
    Public Sub Open_Form()

        Me.Open()

        g_body.AddNewRow()

    End Sub
    Private Sub Clear()
        p.Clear()
        p.Add("@od_no", "XXX")

        Me.Open("wi_sa1120_head_PB", p)
        Me.Open("wi_sa1120_body_PB", p)

        cs_cd.Focus()
        set_tmp.Text = " "
    End Sub

    Private Function Check_Stts() As String
        p.Clear()
        p.Add("@od_no", od_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1120_stts_PB", p)
        Dim stts As String = "S"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Function Check_Confirm_gu() As String
        p.Clear()
        p.Add("@od_no", od_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1120_confirm_gu_PB", p)
        Dim stts As String = ""

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Sub setPrice(hot_cd As String)
        p.Clear()
        p.Add("@cs_cd", cs_cd.Text)
        If hot_cd = "" Then
            p.Add("@hot_cd", g_body.Text("HOT_CD", g_body.RowIndex))
        Else
            p.Add("@hot_cd", hot_cd)
        End If
        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1120_price_PB", p)
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
            If od_gu.Text = "CD05203" Or od_gu.Text = "CD05205" Or od_gu.Text = "CD05208" Or od_gu.Text = "CD05209" Then
                g_body.Text("OD_PRI", g_body.RowIndex) = 0
                g_body.Text("DISCOUNT_RT", g_body.RowIndex) = 0
            Else
                g_body.Text("OD_PRI", g_body.RowIndex) = ToStr(dRow("price"))
                g_body.Text("DISCOUNT_RT", g_body.RowIndex) = ToStr(dRow("rate_rt"))
            End If
        Next
    End Sub

    Private Sub setPrice_jacd()
        p.Clear()
        p.Add("@cs_cd", cs_cd.Text)
        p.Add("@ja_cd", g_body.Text("GD_CD", g_body.RowIndex))

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1120_price_jacd_PB", p)
        Dim price As Decimal = 0, rate_rt As Decimal = 0

        Dim dRow As DataRow, dRows As DataRowCollection

        If IsEmpty(dSet) Then
            g_body.Text("OD_PRI", g_body.RowIndex) = ""
            g_body.Text("DISCOUNT_RT", g_body.RowIndex) = ""
            Exit Sub
        End If

        dRows = dSet.Tables(0).Rows

        For Each dRow In dRows
            If od_gu.Text = "CD05203" Or od_gu.Text = "CD05205" Or od_gu.Text = "CD05208" Or od_gu.Text = "CD05209" Then
                g_body.Text("OD_PRI", g_body.RowIndex) = 0
                g_body.Text("DISCOUNT_RT", g_body.RowIndex) = 0
            Else
                g_body.Text("OD_PRI", g_body.RowIndex) = ToStr(dRow("price"))
                g_body.Text("DISCOUNT_RT", g_body.RowIndex) = ToStr(dRow("rate_rt"))
            End If

        Next

    End Sub

    Private Sub Max_NO()
        ' od_no 번호 채번
        od_no.CodeNo = "WI_SA1120_PB"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        od_no.CodeDateField = od_dt
    End Sub

    Private Function Saves() As Boolean
        Dim ls_stts As String = ""

        ls_stts = Check_Stts()
        If ls_stts = "C" Then '상태값 CHECK
            MsgBox("접수된 자료입니다.!")
            Return False
        ElseIf ls_stts = "A" Then
            MsgBox("전송된 자료입니다.!")
            Return False
        End If

        totAmt()

        If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            Max_NO()  '전표채번..

            Dim i As Integer

            For i = 0 To g_body.RowCount - 1
                If g_body.Text("GD_CD", i) = "" Then
                    g_body.DeleteRow(i)
                    i = i - 1

                    If i = g_body.RowCount - 1 Then Exit For

                Else
                    'If g_body.ToDec("OD_QTY") < 1 Then    '음수는 입력NO -> 음수도 입력되도록 변경 
                    '    MsgBox("수량을 확인하세요.!")
                    '    Return False
                    'End If
                End If


                If od_gu.Text = "CD05201" Or od_gu.Text = "CD05202" Or od_gu.Text = "CD05204" Then
                    If g_body.ToDec("OD_PRI", i) < 1 Then
                        MsgBox("[수주단가] 항목은 필수 입력필드입니다.")
                        Return False
                    End If

                ElseIf od_gu.Text = "CD05210" Then 'smk 150723 매출에누리 (수주단가 알아서 입력)


                Else
                    If g_body.ToDec("OD_PRI", i) > 0 Then
                        MsgBox("[수주단가] 항목은 필수 미입력필드입니다.")
                        Return False
                    End If
                End If
            Next

            If deli_nm.Text <> "" Then
                p.Clear()
                p.Add("@deli_nm", deli_nm.Text)
                p.Add("@od_no", od_no.Text)
                Me.Open("wi_sa1120_head_deli_PB", p)
            End If

            If MyBase.Save() Then
            Else
                Return False
            End If
            stts.Text = "S"

        End If

        Return True
    End Function
    Private Function ConFrim() As Boolean

        If od_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        If od_amt.ToDec > cr_amt.ToDec Then
            MsgBox("여신잔액을 초과하였습니다.!")
            Return False
        End If
        Dim ls_stts As String = ""

        ls_stts = Check_Stts()
        If ls_stts = "C" Then '상태값 CHECK
            MsgBox("접수된 자료입니다.!")
            Return False
        ElseIf ls_stts = "A" Then
            MsgBox("전송된 자료입니다.!")
            Return False
        End If

        If MessageYesNo("전송 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else

            If MyBase.Save() Then
            Else
                Return False
            End If

            p.Clear()
            p.Add("@od_no", od_no.Text)
            p.Add("@stts", "A")

            Me.Open("wi_sa1120_confirm_PB", p)

            stts.Text = "A"

        End If

        Return True
    End Function

    Private Function DeConFrim() As Boolean

        If od_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        Dim ls_stts As String = ""

        ls_stts = Check_Stts()
        If ls_stts = "C" Then '상태값 CHECK
            MsgBox("접수된 자료입니다.!")
            Return False
        ElseIf ls_stts = "S" Then
            MsgBox("저장된 자료입니다.!")
            Return False
        End If

        '상태값 CHECK
        If Check_Confirm_gu() = "Y" Then
            MsgBox("수주 접수된 자료입니다.!")
            Return False
        End If

        If MessageYesNo("확인취소 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@od_no", od_no.Text)
            p.Add("@stts", "S")

            Me.Open("wi_sa1120_deconfirm_PB", p)

            stts.Text = "S"
        End If

        Return True
    End Function

    Private Function Del() As Boolean

        If od_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        Dim ls_stts As String = ""

        ls_stts = Check_Stts()
        If ls_stts = "C" Then '상태값 CHECK
            MsgBox("접수된 자료입니다.!")
            Return False
        ElseIf ls_stts = "A" Then
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        If MessageYesNo("삭제 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@od_no", od_no.Text)

            Me.Open("wi_sa1120_delete_PB", p)

            Me.Clear()

            g_list.Open()

        End If

        Return True
    End Function
    Private Sub Find()
        If spc_1.Panel1Collapsed = False Then
            spc_1.Panel1Collapsed = True
        Else
            spc_1.Panel1Collapsed = False
        End If
    End Sub

    Private Sub UNIT_QTY()  '낱개수량 구하기
        p.Clear()
        p.Add("@FROM_DT", Mid(find_from.Text, 1, 7) + "-01")
        p.Add("@TO_DT", od_dt.Text)                             'Mid(find_from.Text, 1, 7) + "-30")
        p.Add("@FIND_CS_CD", cs_cd.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1120_CLALEN_PB", p)
        Dim dRow As DataRow, dRows As DataRowCollection

        'If IsEmpty(dSet) Then
        'End If
        dRows = dSet.Tables(0).Rows
        For Each dRow In dRows
            EText1.Text = ToStr(FormatNumber(dRow("CLALEN_QTY"), 0))
            If dRow("CLALEN_QTY") >= 150 Then
                EText1.TextForeColor = Color.Red
            Else
                EText1.TextForeColor = Color.Black
            End If
        Next

        Dim dSet2 As Data.DataSet = Me.OpenDataSet("wi_sa1120_IRIS_PB", p)
        Dim dRow2 As DataRow, dRows2 As DataRowCollection

        dRows2 = dSet2.Tables(0).Rows
        For Each dRow2 In dRows2
            EText2.Text = ToStr(FormatNumber(dRow2("IRIS_QTY"), 0))
            If dRow2("IRIS_QTY") >= 200 Then
                EText2.TextForeColor = Color.Red
            Else
                EText2.TextForeColor = Color.Black
            End If
        Next
    End Sub

    Private Sub New_Form()
        ''수주번호를 '' 로 한후 조회 시켜버림
        'od_no.Text = ""
        'Me.OpenTrigger("wi_sa1120_list")
        ''BODY 한줄 추가
        g_body.AddNewRow()
        g_body.Focus()

        'g_body.EditMode()

    End Sub


    Private Sub btn_find_Click(sender As System.Object, e As System.EventArgs) Handles btn_find.Click
        g_list.Open()
    End Sub
    Private Sub find_Clear()

        find_cs_nm.Text = ""
        find_od_no.Text = ""
        find_stts.Text = "%"

        p.Clear()
        p.Add("@find_from", find_from.Text)
        p.Add("@find_to", find_to.Text)
        p.Add("@find_cs_nm", "XXX")
        p.Add("@find_od_no", find_od_no.Text)
        p.Add("@find_stts", find_stts.Text)

        Me.Open("wi_sa1120_list_PB", p)

    End Sub
    Private Sub btn_cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancel.Click
        Me.find_Clear()
    End Sub

    Private Sub g_list_DoubleClick(sender As Object, e As System.EventArgs) Handles g_list.DoubleClick

        Dim p As New OpenParameters

        p.Add("@od_no", g_list.Text("OD_NO", g_list.RowIndex))
        Me.Open("wi_sa1120_head_PB", p)
        Me.Open("wi_sa1120_body_PB", p)

        '찾기 리스트에서 더블 클릭시 찾기를 없앤다.
        If find_visible.Checked Then MenuButton_Click(MenuType.Find)

        UNIT_QTY()

    End Sub

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

    Private Sub popUP(hot_cd As String)

        p.Clear()
        p.Add("@hot_cd", g_body.Text("HOT_CD", g_body.RowIndex))

        If g_body.Text("HOT_CD", g_body.RowIndex) = "" Then
            'g_bodyClear()
            Exit Sub
        End If


        'MsgBox(g_body.Text("HOT_CD", g_body.RowIndex))

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1120_hot_cd_PB", p)
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
            g_body.Text("NM_NM", g_body.RowIndex) = nm_nm

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

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1120_spec_PB", p)
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
        
        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1120_hot_spec_PB", p)
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

    Private Sub g_body_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g_body.CellValueChanged

        Select Case ColumnName
            Case "HOT_CD"
                Try

                    Me.popUP(Value)

                    setPrice("")

                    Dim sps As String
                    For i = 10 To 90 Step 10
                        sps = i.ToString()
                        g_body.ColumnReadOnly("SPEC" & sps) = True
                    Next

                    'SMK_150722()
                    If ToStr(Value) = "99" Then
                        g_body.Text("SPEC30", g_body.RowIndex) = "0"
                        g_body.Focus()
                        g_body.FocusedFieldName = "GD_CD"
                        g_body.Text("OD_QTY", g_body.RowIndex) = 1
                    End If

                    'Dim sum_pri As Double
                    'Dim sum_amt As Double
                    'Dim sum_vat As Double
                    'Dim sum_vat2 As Double
                    'Dim sum_tot As Double
                    'Dim dis_amt As Double
                    'Dim sum_od_amt As Double

                    'If ToStr(Value) = "99" Then
                    '    g_body.Text("SPEC30", g_body.RowIndex) = "0"
                    '    g_body.Focus()
                    '    g_body.FocusedFieldName = "GD_CD"

                    '    For i = 0 To g_body.RowCount - 2

                    'sum_qty = sum_qty + g_body.Text("OD_QTY", i)
                    'g_body.Text("OD_QTY", g_body.RowIndex) = 1

                    'sum_pri = sum_pri + (g_body.Text("OD_PRI", i) * g_body.Text("OD_QTY", i))
                    'g_body.Text("OD_PRI", g_body.RowIndex) = -sum_pri

                    'sum_vat = sum_vat + g_body.Text("OT_VAT", i)
                    'g_body.Text("OT_VAT", g_body.RowIndex) = -sum_vat

                    'sum_vat2 = sum_vat2 + g_body.Text("VAT_AMT", i)
                    'g_body.Text("VAT_AMT", g_body.RowIndex) = -sum_vat2

                    'sum_tot = sum_tot + g_body.Text("OT_TOT", i)
                    'g_body.Text("OT_TOT", g_body.RowIndex) = -sum_tot

                    'sum_amt = sum_amt + g_body.Text("AMT", i)
                    'g_body.Text("AMT", g_body.RowIndex) = -sum_amt

                    'sum_od_amt = sum_od_amt + g_body.Text("OD_AMT", i)
                    'g_body.Text("OD_AMT", g_body.RowIndex) = -sum_od_amt

                    ''할인금액, 할인율도 마이너스 치기 20150728 smk
                    'dis_amt = dis_amt + g_body.Text("DISCOUNT_AMT", i)
                    'g_body.Text("DISCOUNT_AMT", g_body.RowIndex) = -dis_amt

                    'g_body.Text("DISCOUNT_RT", g_body.RowIndex) = g_body.Text("DISCOUNT_RT", g_body.RowIndex - 1)  '할인율은 제품들의 할인율 합계가 아니라, 동일한 할인율. 

                    '    Next
                    'End If

                    Me.hot_spec(Value)

                Catch ex As Exception

                End Try
            Case "SPEC10", "SPEC20", "SPEC30", "SPEC40", "SPEC50", "SPEC60", "SPEC70", "SPEC80", "SPEC90"

                Try
                    Me.spec(Value)
                Catch ex As Exception

                End Try
            Case "OD_QTY", "OD_PRI"

                totAmt()

            Case "GD_CD"
                If g_body.Text("HOT_CD", g_body.RowIndex) = "" Then setPrice_jacd()

        End Select

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

        If ColumnName = "OD_PRI" Then 'smk 150724 (단가enter)   --Or ColumnName = "OD_QTY" 
            If od_gu.Text = "CD05205" Or od_gu.Text = "CD05210" Then '프로모셤샘플, 매출에누리 - 단가로 이동
                'smk 컬럼이동시 변경
                Dim sum_pri As Double
                Dim sum_amt As Double
                Dim sum_vat As Double
                Dim sum_vat2 As Double
                Dim sum_tot As Double
                Dim dis_amt As Double
                Dim sum_od_amt As Double

                For A As Integer = 0 To g_body.RowCount - 1
                    If g_body.Text("HOT_CD", A) = "99" Then
                        For i = 0 To g_body.RowCount - 2
                            'sum_qty = sum_qty + g_body.Text("OD_QTY", i)
                            g_body.Text("OD_QTY", A) = 1

                            sum_pri = sum_pri + (g_body.Text("OD_PRI", i) * g_body.Text("OD_QTY", i))
                            g_body.Text("OD_PRI", g_body.RowIndex) = -sum_pri

                            'sum_pri = sum_pri + g_body.Text("OD_PRI", i)
                            'g_body.Text("OD_PRI", A) = -sum_pri

                            sum_vat = sum_vat + g_body.Text("OT_VAT", i)
                            g_body.Text("OT_VAT", A) = -sum_vat

                            sum_vat2 = sum_vat2 + g_body.ToDec("VAT_AMT", i)
                            g_body.Text("VAT_AMT", A) = -sum_vat2

                            sum_tot = sum_tot + g_body.Text("OT_TOT", i)
                            g_body.Text("OT_TOT", A) = -sum_tot

                            sum_amt = sum_amt + g_body.Text("AMT", i)
                            g_body.Text("AMT", A) = -sum_amt

                            sum_od_amt = sum_od_amt + g_body.ToDec("OD_AMT", i)
                            g_body.Text("OD_AMT", A) = -sum_od_amt

                            '할인금액, 할인율도 마이너스 치기 20150728 smk
                            dis_amt = dis_amt + g_body.ToDec("DISCOUNT_AMT", i)
                            g_body.Text("DISCOUNT_AMT", A) = -dis_amt

                            g_body.Text("DISCOUNT_RT", A) = g_body.Text("DISCOUNT_RT", A - 1)  '할인율은 제품들의 할인율 합계가 아니라, 동일한 할인율. 
                        Next

                    End If
                Next


            Else '그외나머지 줄바꿈
                g_body.AddNewRow()
                g_body.Focus()
            End If
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

    Private Sub totAmt()

        Dim od_amt1 As Double, vat_amt1 As Double, AMT As Double, VAT As Double, TOT As Double
        Dim dis_amt As Double, sum_od_amt As Double, sum_vat As Double, sum_tot As Double, sum_qty As Double, sum_pri As Double, sum_vat2 As Double
         With g_body
            .UpdateRow()
            For i As Integer = 0 To .RowCount - 1
                If .Text("AMT", i) = "99" Then  '매출에누리면, 
                    For H As Integer = 0 To .RowCount - 2
                        AMT = .ToDec("OD_QTY", H) * .ToDec("OD_PRI", H)
                        .Text("AMT", i) = AMT
                        dis_amt = dis_amt + g_body.ToDec("DISCOUNT_AMT", H)
                        .Text("DISCOUNT_AMT", i) = -dis_amt

                        sum_od_amt = sum_od_amt + g_body.ToDec("OD_AMT", H)
                        g_body.Text("OD_AMT", i) = -sum_od_amt

                        od_amt1 = od_amt1 + AMT - .ToDec("DISCOUNT_AMT", H)

                        sum_vat = sum_vat + g_body.Text("OT_VAT", H)
                        g_body.Text("OT_VAT", i) = -sum_vat

                        sum_tot = sum_tot + g_body.Text("OT_TOT", H)
                        g_body.Text("OT_TOT", i) = -sum_tot

                        vat_amt1 = vat_amt1 + .ToDec("VAT_AMT", H)

                        '추가
                        'sum_qty = sum_qty + g_body.Text("OD_QTY", H)
                        'g_body.Text("OD_QTY", i) = 1
                        'sum_pri = sum_pri + (g_body.Text("OD_PRI", H) * g_body.Text("OD_QTY", H))
                        'g_body.Text("OD_PRI", i) = -sum_pri
                        'sum_vat2 = sum_vat2 + g_body.ToDec("VAT_AMT", H)
                        'g_body.Text("VAT_AMT", i) = -sum_vat2
                        'g_body.Text("DISCOUNT_RT", i) = g_body.Text("DISCOUNT_RT", i - 1)  '할인율은 제품들의 할인율 합계가 아니라, 동일한 할인율. 
                    Next

                Else  '그외 로우
                    AMT = .ToDec("OD_QTY", i) * .ToDec("OD_PRI", i)
                    .Text("AMT", i) = AMT
                    .Text("DISCOUNT_AMT", i) = AMT * .ToDec("DISCOUNT_RT", i) / 100
                    .Text("OD_AMT", i) = AMT - (AMT * .ToDec("DISCOUNT_RT", i) / 100)

                    od_amt1 = od_amt1 + AMT - (AMT * .ToDec("DISCOUNT_RT", i) / 100)

                    VAT = .ToDec("AMT", i) * 0.1   '부가세 20140722 추가
                    .Text("OT_VAT", i) = VAT
                    TOT = .ToDec("AMT", i) + .ToDec("OT_VAT", i)  '합계금액 20140722 추가
                    .Text("OT_TOT", i) = TOT

                    vat_amt1 = vat_amt1 + .ToDec("VAT_AMT", i)
                End If

            Next
        End With

        od_amt.Text = od_amt1
        vat_amt.Text = vat_amt1
        tot_amt.Text = od_amt1 + vat_amt1

    End Sub

    Private Sub cs_cd_TextChanged(sender As Object, oldValue As String) Handles cs_cd.TextChanged
        UNIT_QTY()  '낱개수량 구하기

        If g_body.RowCount > 0 Then Exit Sub

        g_body.AddNewRow()
        g_body.Focus()

    End Sub

    Private Sub remk_TextChanged(sender As Object, oldValue As String) Handles remk.TextChanged
        'If remk.Text.Length > 19 Then   '2014-10-08 거래명세서 개선으로 "특기사항" text 길이 제한없음
        '    MessageInfo("19자 이내로 입력해 주세요.")
        '    'remk.Text = ""
        '    remk.Focus()
        '    Exit Sub
        'End If

        If g_body.RowCount = 0 Then g_body.AddNewRow()
        g_body.Focus()
    End Sub

    Private Sub od_gu_TextChanged(sender As Object, e As System.EventArgs) Handles od_gu.TextChanged
        Me.setPrice("")
        If od_gu.Text = "CD05204" Or od_gu.Text = "CD05205" Or od_gu.Text = "CD05210" Then 'SMK 매출에누리 추가 
            g_body.ColumnReadOnly("OD_PRI") = False
        Else
            g_body.ColumnReadOnly("OD_PRI") = True
        End If
    End Sub


    Private Sub set_tmp_TextChanged(sender As System.Object, e As System.EventArgs) Handles set_tmp.TextChanged
        g_body.DeleteAll()
        p.Clear()
        If set_tmp.Text = "" Then
            Exit Sub
        End If
        p.Add("@temp_no", set_tmp.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1120_settmp_PB", p)

        Dim dRow As DataRow, dRows As DataRowCollection

        If IsEmpty(dSet) Then
            g_body.Text("OD_PRI", g_body.RowIndex) = ""
            g_body.Text("DISCOUNT_RT", g_body.RowIndex) = ""
            Exit Sub
        End If

        '        select	a.temp_no, a.seq, a.gd_cd, b.gd_nm, b.spec, b.unit_cd, a.qty,  a.remk, 
        '       a.in_dt, a.in_pscd, in_ps_nm = c.emp_nm  
        'from	samt1041 a
        '        left outer join comt1200 b on a.gd_cd = b.gd_cd 
        '		left outer join hra100 c on a.in_pscd = c.emp_no 
        'where	a.temp_no = @temp_no 

        dRows = dSet.Tables(0).Rows

        For Each dRow In dRows
            g_body.AddNewRow()
            g_body.Text("HOT_CD") = ToStr(dRow("hot_cd"))
            g_body.Text("GD_CD") = ToStr(dRow("gd_cd"))
            'g_body.Text("GD_NM") = ToStr(dRow("gd_nm"))
            g_body.Text("OD_QTY") = ToStr(dRow("qty"))

            Me.setPrice(ToStr(dRow("hot_cd")))

            If ToStr(dRow("amt")) <> "" Then
                g_body.Text("OD_PRI") = ToStr(dRow("amt"))
            End If
        Next

    End Sub

    Private Function A() As Integer
        Throw New NotImplementedException
    End Function


End Class

