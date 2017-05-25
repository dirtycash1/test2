Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_JA1423
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

        Dim dSet As Data.DataSet = Me.OpenDataSet("WI_JA1423_stts", p)
        Dim stts As String = "S"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Sub Max_NO()
        mv_no.CodeNo = "WI_JA1420"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
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

            Me.Open("WI_JA1423_delete", p)

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

            Me.Open("WI_JA1423_confirm", p)

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

            Me.Open("WI_JA1423_confirm", p)

            p.Clear()
            p.Add("@mv_no", mv_no.Text)

            Me.Open("WI_JA1423_head", p)
            Me.Open("WI_JA1423_body", p)

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

        Me.Open("WI_JA1423_head", p)
        Me.Open("WI_JA1423_body", p)
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
        p.Add("@find_mv_no", "XXX")
        p.Add("@find_tmps_gu", find_tmps_gu.Text)
        p.Add("@find_stts", find_tmps_gu.Text)

        Me.Open("WI_JA1423_list", p)
    End Sub

    Private Sub find_Clear2()
        p.Clear()
        p.Add("@find_help_gu2", find_from.Text)
        p.Add("@find_wh_cd2", find_to.Text)
        p.Add("@find_gd_cd2", "XXX")
        p.Add("@find_gd_nm2", "XXX")
        p.Add("@find_lot_no2", "XXX")

        Me.Open("WI_JA1423_stock", p)
    End Sub

    Private Sub btn_find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_find.Click
        g_list.Open()
    End Sub

    Private Sub g_list_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g_list.DoubleClick
        p.Clear()
        p.Add("@mv_no", g_list.Text("MV_NO", g_list.RowIndex))

        Me.Open("WI_JA1423_head", p)
        Me.Open("WI_JA1423_body", p)

        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.find_Clear()

    End Sub

    Private Function Check_Body() As Integer
        Dim ld_stockqty As Decimal = 0
        Dim ld_chulqty As Decimal

        With g_body
            For i As Integer = 0 To .RowCount - 1
                p.Clear()
                p.Add("@GD_CD", .Text("GD_CD", i))
                p.Add("@FMPS_GU", fmps_gu.Text)

                Dim dSet As Data.DataSet = Me.OpenDataSet("WI_JA1423_stock", p)

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


    Private Sub btn_cancel2_Click(sender As Object, e As System.EventArgs) Handles btn_cancel2.Click
        Me.find_Clear2()
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

    Private Sub fmps_gu_TextChanged(sender As Object, e As System.EventArgs) Handles fmps_gu.TextChanged
        find_wh_cd2.Text = fmps_gu.Text
    End Sub
End Class
