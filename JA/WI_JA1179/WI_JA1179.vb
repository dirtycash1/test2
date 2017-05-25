Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_JA1179
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
        Me.Clear()

        'MenuButton_Click(MenuType.Find)
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                '    'Me.Open()
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
                'New_Form()

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
            MsgBox("승인된 자료입니다.!")
            Return False
        End If

        Me.BalAmt()

        If Check_Head() <> 0 Then
            Return False
        End If

        If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            If MyBase.Save() Then
            End If

            p.Clear()
            p.Add("@chul_no", chul_no.Text)
            p.Add("@stts", "A")
            p.Add("@chul_dt", chul_dt.Text)
            p.Add("@wh_cd", wh_cd.Text)
            p.Add("@ps_cd", ps_cd.Text)
            p.Add("@pl_cd", pl_cd.Text)
            p.Add("@remk", remk.Text)

            Me.Open("wi_ja1179_confirm", p)

            stts.Text = "A"
        End If

        '거래처 체크
        If Not Me.Check_CsCd() Then
            Return False
        End If

        Return True
    End Function

    Private Function Check_Stts() As String
        p.Clear()
        p.Add("@chul_no", chul_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_ja1179_stts", p)
        Dim stts As String = "A"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Function Del() As Boolean

        If chul_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        '상태값 CHECK
        If Check_Stts() = "C" Then
            MsgBox("승인된 자료입니다.!")
            Return False
        End If

        If MessageYesNo("반송 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@chul_no", chul_no.Text)

            Me.Open("wi_ja1179_delete", p)

            Me.Clear()

            g_list.Open()
            g_list2.Open()

        End If

        Return True
    End Function

    Private Function ConFrim() As Boolean

        If chul_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        '상태값 CHECK
        If Check_Stts() = "C" Then
            MsgBox("승인된 자료입니다.!")
            Return False
        End If

        If Check_Head() <> 0 Then
            Return False
        End If

        If MessageYesNo("승인 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            If MyBase.Save() Then
            End If

            p.Clear()
            p.Add("@chul_no", chul_no.Text)
            p.Add("@stts", "C")
            p.Add("@chul_dt", chul_dt.Text)
            p.Add("@wh_cd", wh_cd.Text)
            p.Add("@ps_cd", ps_cd.Text)
            p.Add("@pl_cd", pl_cd.Text)
            p.Add("@remk", remk.Text)

            Me.Open("wi_ja1179_confirm", p)

            stts.Text = "C"

            g_list.Open()
            g_list2.Open()
        End If

        Return True
    End Function

    Private Function DeConFrim() As Boolean

        If chul_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        '상태값 CHECK
        If Check_Stts() <> "C" Then
            MsgBox("승인된 자료가 아닙니다.!")
            Return False
        End If

        If MessageYesNo("승인취소 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@chul_no", chul_no.Text)
            p.Add("@stts", "A")
            p.Add("@chul_dt", "")
            p.Add("@wh_cd", "")
            p.Add("@ps_cd", "")
            p.Add("@pl_cd", "")
            p.Add("@remk", remk.Text)

            Me.Open("wi_ja1179_confirm", p)

            p.Clear()
            p.Add("@chul_no", chul_no.Text)

            Me.Open("wi_ja1179_head", p)
            Me.Open("wi_ja1179_body", p)

            stts.Text = "A"

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

    Private Sub BalAmt()
        Dim sum_amt As Double

        With g_body
            .UpdateRow()
            For i As Integer = 0 To .RowCount - 1
                sum_amt = sum_amt + .ToDec("chul_AMT", i)
            Next
        End With

        'chul_amt.Text = sum_amt
        'won_amt.Text = sum_amt * rate.ToDec
    End Sub

    Private Sub Clear()
        p.Clear()
        p.Add("@chul_no", "XXX")

        Me.Open("wi_ja1179_head", p)
        Me.Open("wi_ja1179_body", p)
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

        Me.Open("wi_ja1179_list", p)
    End Sub

    Private Sub btn_find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_find.Click
        g_list.Open()
    End Sub

    Private Sub g_body_CellValueChanged(ByVal sender As System.Object, ByVal ColumnName As System.String, ByVal RowIndex As System.Int32, ByRef Value As System.Object) Handles g_body.CellValueChanged
        With g_body
            If ColumnName = "chul_QTY" Or ColumnName = "chul_PRI" Then
                .Text("chul_AMT") = .ToDec("chul_QTY") * .ToDec("chul_PRI")
                Me.BalAmt()
            End If
        End With
    End Sub

    Private Sub g_list_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g_list.DoubleClick
        p.Clear()
        p.Add("@chul_no", g_list.Text("CHUL_NO", g_list.RowIndex))

        Me.Open("wi_ja1179_head", p)
        Me.Open("wi_ja1179_body", p)

        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.find_Clear()

    End Sub

    Private Sub btn_find2_Click(sender As Object, e As System.EventArgs) Handles btn_find2.Click
        g_list2.Open()
    End Sub

    Private Sub find_Clear2()
        p.Clear()
        p.Add("@find_from2", find_from2.Text)
        p.Add("@find_to2", find_to2.Text)
        p.Add("@find_ps_nm2", "XXX")

        Me.Open("wi_ja1179_list2", p)
    End Sub

    Private Sub btn_cancel2_Click(sender As Object, e As System.EventArgs) Handles btn_cancel2.Click
        find_Clear2()
    End Sub

    Private Sub g_list2_DoubleClick(sender As Object, e As System.EventArgs) Handles g_list2.DoubleClick
        find_list2()

        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    Private Sub find_list2()
        p.Clear()
        p.Add("@chul_no", g_list2.Text("CHUL_NO", g_list2.RowIndex))

        Me.Open("wi_ja1179_body", p)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_ja1179_set_head", p)

        If Not IsEmpty(dSet) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            For Each dRow In dRows
                chul_no.Text = ToStr(dRow("CHUL_NO"))
                chul_type.Text = ToStr(dRow("CHUL_TYPE"))
                remk.Text = ToStr(dRow("REMK"))
                stts.Text = ToStr(dRow("STTS"))
                ps_cd.Text = ToStr(dRow("PS_CD1"))


            Next
        End If
    End Sub

    Private Function Check_Head() As Integer
        Dim ls_pscd, ls_whcd, ls_sacd As String
        Dim ls_lotno As String = ""
        Dim ld_chuldt As Date

        ls_pscd = ps_cd.Text
        ld_chuldt = chul_dt.Text
        ls_whcd = wh_cd.Text
        ls_sacd = sa_cd.Text

        If ls_pscd = "" Then
            MsgBox("[작성자] 항목은 필수 입력필드 입니다")
            ps_cd.Focus()
            Return 1
        End If

        If ld_chuldt = Nothing Then
            MsgBox("[출고일자] 항목은 필수 입력필드 입니다")
            chul_dt.Focus()
            Return 1
        End If

        If ls_whcd = "" Then
            MsgBox("[창고] 항목은 필수 입력필드 입니다")
            wh_cd.Focus()
            Return 1
        End If

        If ls_sacd = "" Then
            MsgBox("[사업장] 항목은 필수 입력필드 입니다")
            Return 1
        End If

        For i As Integer = 0 To g_body.RowCount - 1
            ls_lotno = g_body.Text("LOT_NO", i)

            If ls_lotno = "" Then
                MsgBox("[LOT NO.] 항목은 필수 입력필드 입니다")
                g_body.Focus()
                g_body.FocusedFieldName = "LOT_NO"
                g_body.RowIndex = i
                g_body.EditMode()
                Return 1
            End If
        Next

        Return 0
    End Function
End Class
