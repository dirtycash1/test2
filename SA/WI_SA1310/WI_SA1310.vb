Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class WI_SA1310
    'Dim ls_stts As String
    Dim p As New OpenParameters


    Private Sub WI_SA1310_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
        Me.Clear()

        g_list.SelectRow = True

        Dim sps As String
        For i = 10 To 90 Step 10
            sps = i.ToString()
            g_body.ColumnReadOnly("SPEC" & sps) = True
        Next

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

    Public Sub Open_Form()

        Me.Open()

        g_body.AddNewRow()
    End Sub

    Private Sub Clear()
        p.Clear()
        p.Add("@mv_no", "XXX")

        Me.Open("wi_sa1310_head", p)
        Me.Open("wi_sa1310_body", p)

        from_cscd.Focus()

    End Sub

    Private Function Check_Stts() As String
        p.Clear()
        p.Add("@mv_no", mv_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1310_stts", p)
        Dim stts As String = "S"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Sub setPrice()
        p.Clear()
        p.Add("@cs_cd", from_cscd.Text)
        p.Add("@hot_cd", g_body.Text("HOT_CD", g_body.RowIndex))

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1310_price", p)
        Dim price As Decimal = 0, rate_rt As Decimal = 0

        Dim dRow As DataRow, dRows As DataRowCollection

        If IsEmpty(dSet) Then
            g_body.Text("MV_PRI", g_body.RowIndex) = ""
            g_body.Text("DISCOUNT_RT", g_body.RowIndex) = ""
            Exit Sub
        End If

        dRows = dSet.Tables(0).Rows

        For Each dRow In dRows
            g_body.Text("MV_PRI", g_body.RowIndex) = ToStr(dRow("price"))
            g_body.Text("DISCOUNT_RT", g_body.RowIndex) = ToStr(dRow("rate_rt"))
        Next

    End Sub

    Private Sub Max_NO()
        ' od_no 번호 채번
        mv_no.CodeNo = "WI_SA1310"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        mv_no.CodeDateField = mv_dt
    End Sub

    Private Function Saves() As Boolean

        If Check_Stts() = "C" Then '상태값 CHECK
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        totAmt()
        Me.delete_row()

        If wf_check() <> 0 Then
            Return False
        End If

        If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            Max_NO()  '전표채번..

            If MyBase.Save() Then
                stts1.Text = "S"
            End If
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

        totAmt()
        Me.delete_row()

        If wf_check() <> 0 Then
            Return False
        End If

        If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else

            p.Clear()
            p.Add("@mv_no", mv_no.Text)
            p.Add("@stts", "C")

            Me.Open("wi_sa1310_confirm", p)

            If wf_bunsan() = 1 Then
                Return False
            End If

            p.Clear()
            p.Add("@mv_no", mv_no.Text)
            Me.Open("wi_sa1310_head", p)
            p.Clear()
            p.Add("@mv_no", mv_no.Text)
            Me.Open("wi_sa1310_body", p)
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
            p.Add("@from_rtno", from_rtno.Text)
            p.Add("@to_odno", to_odno.Text)
            p.Add("@to_otno", to_otno.Text)
            p.Add("@stts", "S")

            Me.Open("wi_sa1310_deconfirm", p)

            p.Clear()
            p.Add("@mv_no", mv_no.Text)
            Me.Open("wi_sa1310_head", p)
            p.Clear()
            p.Add("@mv_no", mv_no.Text)
            Me.Open("wi_sa1310_body", p)

        End If

        Return True
    End Function

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
            p.Add("@stts", "D")

            Me.Open("wi_sa1310_delete", p)

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
        find_mv_no.Text = ""
        find_stts.Text = "%"

        p.Clear()
        p.Add("@find_from", find_from.Text)
        p.Add("@find_to", find_to.Text)
        p.Add("@find_cs_nm", "XXX")
        p.Add("@find_mv_no", find_mv_no.Text)
        p.Add("@find_stts", find_stts.Text)

        Me.Open("wi_sa1310_list", p)

    End Sub

    Private Sub btn_cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancel.Click
        Me.find_Clear()
    End Sub

    Private Sub g_list_DoubleClick(sender As Object, e As System.EventArgs) Handles g_list.DoubleClick

        Dim p As New OpenParameters

        p.Add("@mv_no", g_list.Text("MV_NO", g_list.RowIndex))
        Me.Open("wi_sa1310_head", p)
        Me.Open("wi_sa1310_body", p)

        '찾기 리스트에서 더블 클릭시 찾기를 없앤다.
        If find_visible.Checked Then MenuButton_Click(MenuType.Find)

    End Sub

    Private Sub popUP(hot_cd As String)

        p.Clear()
        p.Add("@hot_cd", g_body.Text("HOT_CD", g_body.RowIndex))

        If g_body.Text("HOT_CD", g_body.RowIndex) = "" Then Exit Sub

        'MsgBox(g_body.Text("HOT_CD", g_body.RowIndex))

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1310_hot_cd", p)
        Dim nm_cd As String = "", nm_nm As String = ""
        Dim dRow As DataRow, dRows As DataRowCollection

        If IsEmpty(dSet) Then
            g_body.Text("HOT_CD", g_body.RowIndex) = ""
            g_body.Text("GD_CD", g_body.RowIndex) = ""
            g_body.Text("GD_NM", g_body.RowIndex) = ""
            g_body.Text("SPEC", g_body.RowIndex) = ""
            g_body.Text("UNIT_CD", g_body.RowIndex) = ""
            g_body.Text("SALE_CD", g_body.RowIndex) = ""
            Exit Sub
        End If

        dRows = dSet.Tables(0).Rows

        For Each dRow In dRows
            nm_cd = ToStr(dRow("nm_cd"))
            nm_nm = ToStr(dRow("nm_nm"))

            g_body.Text("SALE_CD", g_body.RowIndex) = nm_cd
            g_body.Text("NM_NM", g_body.RowIndex) = nm_nm
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

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1310_spec", p)
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

        g_body.Focus()
        g_body.FocusedFieldName = "LOT_NO" '+ ToStr(dRows(0))

        'g_body.RowIndex 
        g_body.EditMode()

    End Sub

    Private Sub hot_spec(hot_cd As String)

        Dim sps As String
        For i = 10 To 90 Step 10
            sps = i.ToString()
            g_body.ColumnReadOnly("SPEC" & sps) = True
        Next

        p.Clear()
        p.Add("@hot_cd", hot_cd)
        
        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1310_hot_spec", p)
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

            'g_body.Text("NM_CD", g_body.RowIndex) = ToStr(dRow("NM_CD"))
            g_body.ColumnReadOnly("SPEC" + ToStr(dRow("SPEC_CD"))) = False
        Next

        g_body.Focus()
        g_body.FocusedFieldName = "SPEC" + ToStr(dRows(0))
        'g_body.RowIndex 
        g_body.EditMode()

    End Sub

    Private Sub g_body_AfterMoveRow(sender As Object, PrevRowIndex As Integer, RowIndex As Integer) Handles g_body.AfterMoveRow
        Try
            Me.popUP(g_body.Text("HOT_CD", RowIndex))
            Me.hot_spec(g_body.Text("HOT_CD", RowIndex))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub g_body_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g_body.CellValueChanged
        Select Case ColumnName
            Case "HOT_CD"
                Try
                    Me.popUP(Value)

                    setPrice()

                    Dim sps As String
                    For i = 10 To 90 Step 10
                        sps = i.ToString()
                        g_body.ColumnReadOnly("SPEC" & sps) = True
                    Next

                    Me.hot_spec(Value)
                Catch ex As Exception

                End Try
            Case "SPEC10", "SPEC20", "SPEC30", "SPEC40", "SPEC50", "SPEC60", "SPEC70", "SPEC80", "SPEC90"
                Try
                    Me.spec(Value)
                Catch ex As Exception

                End Try
            Case "MV_QTY", "MV_PRI"
                totAmt()
                'Case "GD_CD"
                '    If Value = "" Then Exit Sub
                '    setPrice()
        End Select
    End Sub

    Private Sub totAmt()
        Dim od_amt1 As Double, vat_amt1 As Double, AMT As Double

        With g_body
            .UpdateRow()
            For i As Integer = 0 To .RowCount - 1
                AMT = .ToDec("MV_QTY", i) * .ToDec("MV_PRI", i)
                .Text("DISCOUNT_AMT", i) = AMT * .ToDec("DISCOUNT_RT", i) / 100
                .Text("MV_AMT", i) = AMT - (AMT * .ToDec("DISCOUNT_RT", i) / 100)

                od_amt1 = od_amt1 + AMT - (AMT * .ToDec("DISCOUNT_RT", i) / 100)
                vat_amt1 = vat_amt1 + .ToDec("VAT_AMT", i)
            Next
        End With

        from_mvamt.Text = od_amt1
        to_mvamt.Text = od_amt1

        from_vatamt.Text = vat_amt1
        to_vatamt.Text = vat_amt1

        from_totamt.Text = od_amt1 + vat_amt1
        to_totamt.Text = od_amt1 + vat_amt1
    End Sub

    'Private Sub g_body_AddedRow(sender As Object, RowIndex As Integer) Handles g_body.AddedRow
    '    g_body.Text("HOT_CD", RowIndex) = g_body.Text("HOT_CD", RowIndex - 1)
    '    g_body.Text("GD_NM", RowIndex) = g_body.Text("GD_NM", RowIndex - 1)
    '    g_body.Text("SPEC10", RowIndex) = g_body.Text("SPEC10", RowIndex - 1)
    '    g_body.Text("SPEC20", RowIndex) = g_body.Text("SPEC20", RowIndex - 1)
    '    g_body.Text("SPEC30", RowIndex) = g_body.Text("SPEC30", RowIndex - 1)
    '    g_body.Text("SPEC40", RowIndex) = g_body.Text("SPEC40", RowIndex - 1)
    '    g_body.Text("SALE_CD", RowIndex) = g_body.Text("SALE_CD", RowIndex - 1)
    '    g_body.Text("SPEC50", RowIndex) = g_body.Text("SPEC50", RowIndex - 1)
    '    g_body.Text("SPEC60", RowIndex) = g_body.Text("SPEC60", RowIndex - 1)
    '    g_body.Text("SPEC70", RowIndex) = g_body.Text("SPEC70", RowIndex - 1)
    '    g_body.Text("SPEC80", RowIndex) = g_body.Text("SPEC80", RowIndex - 1)
    '    g_body.Text("SPEC90", RowIndex) = g_body.Text("SPEC90", RowIndex - 1)
    '    g_body.Text("MV_QTY", RowIndex) = ""
    '    g_body.Text("MV_PRI", RowIndex) = g_body.Text("MV_PRI", RowIndex - 1)

    'End Sub

    Private Function wf_bunsan() As Integer
        p.Clear()
        p.Add("@MV_NO", mv_no.Text)
        p.Add("@MV_DT", mv_dt.Text)
        p.Add("@OD_GU", od_gu.Text)

        Me.Open("wi_sa1310_bunsan", p)
    End Function

    Private Sub delete_row()
        Dim ls_gdcd As String

        For i As Integer = 0 To g_body.RowCount - 1
            ls_gdcd = g_body.Text("GD_CD", i)

            If ls_gdcd = "" Then
                g_body.DeleteRow(i)
            End If
        Next
    End Sub

    Private Function wf_check() As Integer
        Dim ls_fcscd, ls_tcscd As String

        ls_fcscd = from_cscd.Text
        ls_tcscd = to_cscd.Text

        If ls_fcscd = ls_tcscd Then
            MsgBox("FROM 거래처와 TO 거래처가 같습니다.")
            from_cscd.Focus()
            Return 1
        End If
    End Function
End Class

