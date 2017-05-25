Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_JA1176
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

        Me.BalAmt()

        If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            Max_NO()  '전표채번..

            If MyBase.Save() Then
                'MyBase.OpenTrigger("wi_sa1120_list")
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
        p.Add("@chul_no", chul_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("WI_JA1176_stts", p)
        Dim stts As String = "S"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Sub Max_NO()
        ' p/o 번호 채번
        chul_no.CodeNo = "WI_JA1390"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        chul_no.CodeDateField = chul_dt
    End Sub

    Private Function Del() As Boolean

        If chul_no.Text = Nothing Then
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
            p.Add("@chul_no", chul_no.Text)

            Me.Open("WI_JA1176_delete", p)

            Me.Clear()

            g_list.Open()

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
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            'Me.Open("wi_ku1120_confirm")

            p.Clear()
            p.Add("@chul_no", chul_no.Text)
            p.Add("@stts", "C")

            Me.Open("WI_JA1176_confirm", p)

            stts.Text = "C"
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
            MsgBox("확인된 자료가 아닙니다.!")
            Return False
        End If

        If MessageYesNo("확인취소 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@chul_no", chul_no.Text)
            p.Add("@stts", "S")

            Me.Open("WI_JA1176_confirm", p)

            p.Clear()
            p.Add("@chul_no", chul_no.Text)

            Me.Open("WI_JA1176_head", p)
            Me.Open("WI_JA1176_body", p)

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

        Me.Open("WI_JA1176_head", p)
        Me.Open("WI_JA1176_body", p)
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
        p.Add("@find_stts", "XXX")
        p.Add("@find_chul_gu", "XXX")
        'p.Add("@find_stts", find_stts.Text)

        Me.Open("WI_JA1176_list", p)
    End Sub

    Private Sub find_Clear2()
        p.Clear()
        p.Add("@find_help_gu2", find_from.Text)
        p.Add("@find_wh_cd2", find_to.Text)
        p.Add("@find_gd_cd2", "XXX")
        p.Add("@find_gd_nm2", "XXX")
        p.Add("@find_lot_no2", "XXX")

        Me.Open("WI_JA1176_stock", p)
    End Sub

    Private Sub btn_find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_find.Click
        g_list.Open()
    End Sub

    Private Sub g_body_CellValueChanged(ByVal sender As System.Object, ByVal ColumnName As System.String, ByVal RowIndex As System.Int32, ByRef Value As System.Object) Handles g_body.CellValueChanged
        With g_body
            If ColumnName = "chul_QTY" Or ColumnName = "chul_PRI" Then
                .Text("chul_AMT") = .ToDec("chul_QTY") * .ToDec("chul_PRI")
                Me.BalAmt()
            ElseIf ColumnName = "SILSA_QTY" Then
                .Text("CHUL_QTY") = .ToDec("STOCK") - .ToDec("SILSA_QTY")
            End If
        End With
    End Sub

    Private Sub g_list_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g_list.DoubleClick
        p.Clear()
        p.Add("@chul_no", g_list.Text("CHUL_NO", g_list.RowIndex))

        Me.Open("WI_JA1176_head", p)
        Me.Open("WI_JA1176_body", p)

        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.find_Clear()

    End Sub

    Private Sub btn_find2_Click(sender As Object, e As System.EventArgs) Handles btn_find2.Click
        g_list2.Open()
    End Sub


    Private Sub btn_cancel2_Click(sender As Object, e As System.EventArgs) Handles btn_cancel2.Click
        Me.find_Clear2()
    End Sub

    Private Sub wh_cd_TextChanged(sender As Object, e As System.EventArgs) Handles wh_cd.TextChanged
        find_wh_cd2.Text = wh_cd.Text
    End Sub

    Private Sub g_list2_DoubleClick(sender As Object, e As System.EventArgs) Handles g_list2.DoubleClick
        Dim t As Boolean = False

        With g_body
            For i As Integer = 0 To .RowCount - 1
                If .Text("GD_CD", i) = g_list2.Text("GD_CD", g_list2.RowIndex) And .Text("LOT_NO", i) = g_list2.Text("LOT_NO", g_list2.RowIndex) Then
                    t = True
                    Exit For
                End If
            Next
        End With

        If Not t Then

            Dim ll_row As Integer = 0

            ll_row = g_body.RowCount 'g_body.RowIndex
            g_body.InsertNewRow(ll_row)

            g_body.Find("form_cd=" + g_body.Text("form_cd"))

            g_body.Text("GD_CD", ll_row) = g_list2.Text("GD_CD", g_list2.RowIndex)
            g_body.Text("LOT_NO", ll_row) = g_list2.Text("LOT_NO", g_list2.RowIndex)
            g_body.Text("STOCK_QTY", ll_row) = g_list2.Text("STOCK_QTY", g_list2.RowIndex)
        End If

        If find_visible2.Checked Then MenuButton_Click(MenuType.Find)

    End Sub

End Class
