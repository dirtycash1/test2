Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_SA1161
    Dim stts As String
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Clear()

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
        'Clear()

        g_body.AddNewRow()
    End Sub

    Private Function Saves() As Boolean

        If Check_Stts() = "C" Then '상태값 CHECK
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        If wf_check() <> 0 Then
            Return False
        End If

        Me.SALEAMT()

        If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            Max_NO()  '전표채번..

            If MyBase.Save() Then
                'MyBase.OpenTrigger("wi_sa1120_list")
                stts1.Text = "S"
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
        p.Add("@ip_no", ip_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1161_stts", p)
        Dim stts As String = "S"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Sub Max_NO()
        ip_no.CodeNo = "WI_SA1161"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        ip_no.CodeDateField = ip_dt
    End Sub

    Private Function Del() As Boolean

        If ip_no.Text = Nothing Then
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
            p.Add("@ip_no", ip_no.Text)
            p.Add("@stts", "D")

            Me.Open("wi_sa1161_delete", p)

            p.Clear()
            p.Add("@ip_no", "XXX")

            Me.Open("wi_sa1161_head", p)
            Me.Open("wi_sa1161_body", p)

            g_list.Open()
        End If

        Return True
    End Function

    Private Function ConFrim() As Boolean

        If ip_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        '상태값 CHECK
        If Check_Stts() = "C" Then
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        If wf_check() <> 0 Then
            Return False
        End If

        Me.SALEAMT()

        If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            If MyBase.Save() Then
            End If

            p.Clear()
            p.Add("@ip_no", ip_no.Text)
            p.Add("@stts", "C")

            Me.Open("wi_sa1161_confirm", p)

            p.Clear()
            p.Add("@ip_no", ip_no.Text)
            p.Add("@ip_dt", ip_dt.Text)
            p.Add("@ps_cd", ps_cd.Text)

            Me.Open("wi_sa1161_insert", p)

            Me.Clear()

            g_list.Open()
        End If

        Return True
    End Function

    Private Function DeConFrim() As Boolean

        If ip_no.Text = Nothing Then
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
            p.Add("@ip_no", ip_no.Text)
            p.Add("@stts", "S")

            Me.Open("wi_sa1161_deconfirm", p)

            p.Clear()
            p.Add("@ip_no", ip_no.Text)

            Me.Open("wi_sa1161_head", p)
            Me.Open("wi_sa1161_body", p)
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
        p.Add("@ip_no", "XXX")

        Me.Open("wi_sa1161_head", p)

        p.Clear()
        p.Add("@ip_no", "XXX")
        Me.Open("wi_sa1161_body", p)
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

        Me.Open("wi_sa1161_list", p)
    End Sub

    Private Sub btn_find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_find.Click
        g_list.Open()
    End Sub

    Private Sub g_list_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g_list.DoubleClick
        p.Clear()
        p.Add("@ip_no", g_list.Text("IP_NO", g_list.RowIndex))

        Me.Open("wi_sa1161_head", p)

        p.Clear()
        p.Add("@ip_no", g_list.Text("IP_NO", g_list.RowIndex))
        Me.Open("wi_sa1161_body", p)

        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.find_Clear()

    End Sub

    Private Sub SALEAMT()
        Dim ip_amt As Double

        With g_body
            .UpdateRow()
            For i As Integer = 0 To .RowCount - 1
                ip_amt = ip_amt + .ToDec("IP_AMT", i)
            Next
        End With

        sale_amt.Text = ip_amt
    End Sub

    Private Function wf_check() As Integer
        Dim ls_cscd As String, ls_ipno As String, ls_sucscd As String, ls_ipgu As String
        Dim ls_acno, ls_cardcd, ls_draftno, ls_exdt, ls_isdt, ls_jatagu As String

        ls_ipno = ip_no.Text

        With g_body
            For i As Integer = 0 To .RowCount - 1
                ls_cscd = .Text("CS_CD", i)
                ls_sucscd = .Text("SU_CSCD", i)
                ls_ipgu = .Text("IP_GU", i)
                ls_acno = .Text("AC_NO", i)
                ls_cardcd = .Text("CARD_CD", i)
                ls_draftno = .Text("DRAFT_NO", i)
                ls_exdt = .Text("EX_DT", i)
                ls_isdt = .Text("IS_DT", i)
                ls_jatagu = .Text("JATA_GU", i)

                If ls_ipno <> "" Then
                    If ls_cscd = "" Then
                        MsgBox("거래처 항목은 필수 입력필드입니다")
                        .Focus()
                        .FocusedFieldName = "CS_CD"
                        .RowIndex = i
                        .EditMode()
                        Return 1
                    End If

                    If ls_sucscd = "" Then
                        MsgBox("매출처 항목은 필수 입력필드입니다")
                        .Focus()
                        .FocusedFieldName = "SU_CSCD"
                        .RowIndex = i
                        .EditMode()
                        Return 1
                    End If

                    If ls_ipgu = "" Then
                        MsgBox("수금구분 항목은 필수 입력필드입니다")
                        .Focus()
                        .FocusedFieldName = "IP_GU"
                        .RowIndex = i
                        .EditMode()
                        Return 1
                    End If

                    If ls_ipgu = "3" Then
                        If ls_acno = "" Then
                            MsgBox("수금구분이 보통예금일 때 계좌번호는 필수 입력필드입니다.")
                            .Focus()
                            .FocusedFieldName = "AC_NO"
                            .RowIndex = i
                            .EditMode()
                            Return 1
                        End If
                    ElseIf ls_ipgu = "2" Then
                        If ls_cardcd = "" Then
                            MsgBox("수금구분이 카드일 때 카드사는 필수 입력필드입니다.")
                            .Focus()
                            .FocusedFieldName = "CARD_CD"
                            .RowIndex = i
                            .EditMode()
                            Return 1
                        End If

                        If ls_draftno = "" Then
                            MsgBox("수금구분이 카드일 때 승인(어음)번호는 필수 입력필드입니다.")
                            .Focus()
                            .FocusedFieldName = "DRAFT_NO"
                            .RowIndex = i
                            .EditMode()
                            Return 1
                        End If
                    ElseIf ls_ipgu = "10" Or ls_ipgu = "11" Then
                        If ls_cardcd = "" Then
                            MsgBox("수금구분이 계좌이체/가상계좌일 때 카드사(금융기관)는 필수 입력필드입니다.")
                            .Focus()
                            .FocusedFieldName = "CARD_CD"
                            .RowIndex = i
                            .EditMode()
                            Return 1
                        End If

                        If ls_draftno = "" Then
                            MsgBox("수금구분이 계좌이체/가상계좌일 때 승인(주문)번호는 필수 입력필드입니다.")
                            .Focus()
                            .FocusedFieldName = "DRAFT_NO"
                            .RowIndex = i
                            .EditMode()
                            Return 1
                        End If

                    ElseIf ls_ipgu = "4" Then
                        If ls_draftno = "" Then
                            MsgBox("수금구분이 어음일 때 승인(어음)번호는 필수 입력필드입니다.")
                            .Focus()
                            .FocusedFieldName = "DRAFT_NO"
                            .RowIndex = i
                            .EditMode()
                            Return 1
                        End If

                        If ls_jatagu = "" Then
                            MsgBox("수금구분이 어음일 때 자수/타수는 필수 입력필드입니다.")
                            .Focus()
                            .FocusedFieldName = "JATA_GU"
                            .RowIndex = i
                            .EditMode()
                            Return 1
                        End If
                    End If
                End If
            Next
        End With

        If g_body.RowCount() = 0 Then
            MsgBox("등록할 거래처가 없습니다.")
            Return 1
        End If

        Return 0
    End Function

    Private Sub g_body_CellValueChanging(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g_body.CellValueChanging
        If ColumnName = "IP_GU" Then

            Dim ls_ipgu As String = "", ls_ipgucd As String = ""

            If Not IsDBNull(Value) Then
                ls_ipgucd = Value
            End If
            'ls_ipgucd = Value

            ls_ipgu = "CD051" + ls_ipgucd

            g_body.Text("IPGU_CD", RowIndex) = ls_ipgu
        ElseIf ColumnName = "CS_CD" Then
            Dim ls_cscd As String = ""
            If Not IsDBNull(Value) Then
                ls_cscd = Value
            End If

            'wf_set_misu(RowIndex, ls_cscd)

            '/////////////////////////////////
            '    Dim ls_ipgu As String = "", ls_ipgucd As String = ""

            '    ls_ipgucd = Value

            '    ls_ipgu = "CD051" + ls_ipgucd

            '    g_body.Text("IPGU_CD", RowIndex) = ls_ipgu
            'ElseIf ColumnName = "CS_CD" Then
            '    Dim ls_cscd As String = ""

            '    ls_cscd = Value

            '    wf_set_misu(RowIndex, ls_cscd)*/
        End If
    End Sub

    Private Sub wf_set_misu(a_row As Integer, a_cscd As String)
        Dim ls_cscd As String
        Dim ld_date As Date

        ls_cscd = a_cscd
        ld_date = ip_dt.Text

        p.Clear()
        p.Add("@date", ld_date)
        p.Add("@cs_cd", ls_cscd)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1161_misu", p)

        If Not IsEmpty(dSet) Then
            Dim iRow As Integer = 0
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            iRow = a_row

            For Each dRow In dRows
                g_body.Text("RM_AMT", iRow) = ToDec(dRow("RM_AMT"))
            Next
        End If
    End Sub

    Private Sub ip_dt_TextChanged(sender As Object, e As System.EventArgs) Handles ip_dt.TextChanged
        If g_body.RowCount() >= 0 Then
            Me.wf_set_misu1()
        End If
    End Sub

    Private Sub wf_set_misu1()
        Dim ls_cscd As String = ""
        Dim ld_date As Date
        Dim ld_rmamt As Decimal = 0

        ld_date = ip_dt.Text

        With g_body
            For i As Integer = 0 To .RowCount - 1
                ls_cscd = .Text("CS_CD", i)

                If ls_cscd <> "" Then
                    p.Clear()
                    p.Add("@date", ld_date)
                    p.Add("@cs_cd", ls_cscd)

                    Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1161_misu", p)

                    If Not IsEmpty(dSet) Then
                        Dim iRow As Integer = 0
                        Dim dRow As DataRow, dRows As DataRowCollection
                        dRows = dSet.Tables(0).Rows

                        iRow = i

                        For Each dRow In dRows
                            ld_rmamt = ToDec(dRow("RM_AMT"))

                            .Text("RM_AMT", iRow) = ToDec(dRow("RM_AMT"))
                        Next
                    End If
                End If
            Next
        End With
    End Sub
End Class
