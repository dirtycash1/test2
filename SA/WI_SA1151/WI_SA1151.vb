Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_SA1151
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

        g_body.AddNewRow()
    End Sub

    Private Function Saves() As Boolean

        If rt_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        If Check_Stts() = "C" Then '상태값 CHECK
            MsgBox("마감처리된 자료입니다.!")
            Return False
        End If

        If Check_Head() <> 0 Then
            Return False
        End If

        Me.RTAMT()

        If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            ''사원이나 입고일자는 기본적으로 박혀있으므로 기본기능에 맡겨버리면 저장이 안될거 같으므로 수정
            'p.Clear()
            'p.Add("@rt_no", rt_no.Text)
            'p.Add("@stts", "A")
            'p.Add("@rt_dt", rt_dt.Text)
            'p.Add("@wh_cd", wh_cd.Text)
            'p.Add("@ps_cd", ps_cd.Text)

            'Me.Open("wi_sa1151_confirm", p)

            If MyBase.Save() Then
            End If

            p.Clear()
            p.Add("@rt_no", rt_no.Text)
            p.Add("@stts", "A")
            p.Add("@rt_dt", rt_dt.Text)
            p.Add("@wh_cd", wh_cd.Text)
            p.Add("@ps_cd", ps_cd.Text)
            p.Add("@pl_cd", pl_cd.Text)
            p.Add("@RT_AMT", rt_amt.Text)
            p.Add("@VAT_AMT", vat_amt.Text)

            Me.Open("wi_sa1151_confirm", p)
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

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1151_stts", p)
        Dim stts As String = "A"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Function Del() As Boolean

        If rt_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        '상태값 CHECK
        If Check_Stts() = "C" Then '상태값 CHECK
            MsgBox("마감처리된 자료입니다.!")
            Return False
        End If

        If MessageYesNo("반송 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@rt_no", rt_no.Text)
            p.Add("@stts", "S")

            Me.Open("wi_sa1151_delete", p)

            Me.Clear()

            g_list.Open()
            g_list2.Open()
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
            MsgBox("마감처리된 자료입니다.!")
            Return False
        End If

        If Check_Head() <> 0 Then
            Return False
        End If

        Me.RTAMT()

        If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            If MyBase.Save() Then
            End If

            p.Clear()
            p.Add("@rt_no", rt_no.Text)
            p.Add("@stts", "C")
            p.Add("@rt_dt", rt_dt.Text)
            p.Add("@wh_cd", wh_cd.Text)
            p.Add("@ps_cd", ps_cd.Text)
            p.Add("@pl_cd", pl_cd.Text)
            p.Add("@RT_AMT", rt_amt.Text)
            p.Add("@VAT_AMT", vat_amt.Text)

            Me.Open("wi_sa1151_confirm", p)

            p.Clear()
            p.Add("@rt_no", rt_no.Text)
            Me.Open("wi_sa1151_head", p)
            p.Clear()
            p.Add("@rt_no", rt_no.Text)
            Me.Open("wi_sa1151_body", p)

            g_list.Open()
            g_list2.Open()
        End If

        Return True
    End Function

    Private Function DeConFrim() As Boolean

        If rt_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        If Check_Stts() <> "C" Then
            MsgBox("마감된 자료가 아닙니다.!")
            Return False
        End If

        If MessageYesNo("확인취소 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@rt_no", rt_no.Text)
            p.Add("@stts", "A")
            p.Add("@rt_dt", rt_dt.Text)
            p.Add("@wh_cd", wh_cd.Text)
            p.Add("@ps_cd", ps_cd.Text)
            p.Add("@pl_cd", pl_cd.Text)
            p.Add("@RT_AMT", rt_amt.Text)
            p.Add("@VAT_AMT", vat_amt.Text)

            Me.Open("wi_sa1151_confirm", p)

            p.Clear()
            p.Add("@rt_no", rt_no.Text)

            Me.Open("wi_sa1151_debunsan", p)

            p.Clear()
            p.Add("@rt_no", rt_no.Text)
            Me.Open("wi_sa1151_head", p)
            p.Clear()
            p.Add("@rt_no", rt_no.Text)
            Me.Open("wi_sa1151_body", p)

            g_list.Open()
            g_list2.Open()
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

        Me.Open("wi_sa1151_head", p)
        Me.Open("wi_sa1151_body", p)
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
        p.Add("@find_cs_nm", "XXX")

        Me.Open("wi_sa1151_list", p)
    End Sub

    Private Sub find_Clear2()
        p.Clear()
        p.Add("@find_from2", find_from2.Text)
        p.Add("@find_to2", find_to2.Text)
        p.Add("@find_cs_nm2", "XXX")

        Me.Open("wi_sa1151_rq_rt", p)
    End Sub

    Private Sub btn_find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_find.Click
        g_list.Open()
    End Sub

    Private Sub g_list_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g_list.DoubleClick
        p.Clear()
        p.Add("@rt_no", g_list.Text("RT_NO", g_list.RowIndex))

        Me.Open("wi_sa1151_head", p)
        Me.Open("wi_sa1151_body", p)

        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.find_Clear()
    End Sub

    Private Sub btn_find2_Click(sender As System.Object, e As System.EventArgs) Handles btn_find2.Click
        g_list2.Open()
    End Sub

    Private Sub g_list2_DoubleClick(sender As Object, e As System.EventArgs) Handles g_list2.DoubleClick
        find_list2()
        If find_visible2.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    Private Sub btn_cancel2_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancel2.Click
        find_Clear2()
    End Sub

    Private Sub find_list2()
        Me.Clear()

        p.Clear()
        p.Add("@rt_no", g_list2.Text("RT_NO", g_list2.RowIndex))

        Me.Open("wi_sa1151_body", p)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1151_set_head", p)

        If Not IsEmpty(dSet) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            For Each dRow In dRows
                rt_no.Text = ToStr(dRow("RT_NO"))
                cs_cd.Text = ToStr(dRow("CS_CD"))
                cs_nm.Text = ToStr(dRow("CS_NM"))
                cs_tel.Text = ToStr(dRow("CS_TEL"))
                cs_addr.Text = ToStr(dRow("CS_ADDR"))
                wh_cd.Text = ToStr(dRow("WH_CD"))
                od_gu.Text = ToStr(dRow("OD_GU"))
                remk.Text = ToStr(dRow("REMK"))
                rt_amt.Text = ToDec(dRow("RT_AMT"))
                vat_amt.Text = ToDec(dRow("VAT_AMT"))
                sum_amt.Text = ToDec(dRow("SUM_AMT"))
                stts1.Text = "A"
            Next
        End If

        'Me.Open("wi_sa1151_body", p)
    End Sub

    Private Function Check_Head() As Integer
        Dim ls_pscd As String, ls_whcd As String
        Dim ld_rtdt As Date

        ls_pscd = ps_cd.Text
        ld_rtdt = rt_dt.Text
        ls_whcd = wh_cd.Text

        If ls_pscd = Nothing Then
            MsgBox("[작성자] 항목은 필수 입력필드 입니다")
            Return 1
        End If

        If ld_rtdt = Nothing Then
            MsgBox("[반품일자] 항목은 필수 입력필드 입니다")
            Return 1
        End If

        If ls_whcd = Nothing Then
            MsgBox("[창고] 항목은 필수 입력필드 입니다")
            Return 1
        End If

        Return 0
    End Function

    Private Sub g_body_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g_body.CellValueChanged
        With g_body
            If ColumnName = "RT_QTY" Or ColumnName = "RT_PRI" Then
                .Text("RT_AMT") = .ToDec("RT_QTY") * .ToDec("RT_PRI")
                .Text("VAT_AMT") = ((.ToDec("RT_QTY") * .ToDec("RT_PRI")) * 0.1)
                .Text("SUM_AMT") = (.ToDec("RT_QTY") * .ToDec("RT_PRI")) + (((.ToDec("RT_QTY") * .ToDec("RT_PRI")) * 0.1))
                .Text("WON_AMT") = (.ToDec("RT_QTY") * .ToDec("RT_PRI")) * 1 '<-차후 환율로 고쳐야함.

                Me.RTAMT()
            End If
        End With
    End Sub

    Private Sub RTAMT()
        Dim sum_amt1, vat_amt1, rt_amt1 As Double

        With g_body
            .UpdateRow()
            For i As Integer = 0 To .RowCount - 1
                rt_amt1 = rt_amt1 + .ToDec("RT_AMT", i)
                vat_amt1 = vat_amt1 + .ToDec("VAT_AMT", i)
                sum_amt1 = sum_amt1 + .ToDec("SUM_AMT", i)
            Next
        End With

        rt_amt.Text = rt_amt1
        vat_amt.Text = vat_amt1
        sum_amt.Text = sum_amt1
    End Sub
End Class
