Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_SA1152T
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

        If Check_Stts() = "C" Then '상태값 CHECK
            MsgBox("반품 승인된 자료입니다.!")
            Return False
        ElseIf Check_Stts() = "A" Then
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        Me.RTAMT()
        Me.delete_row()

        Max_NO()  '전표채번..

        'If check_rm_qty() = 1 Then
        '    Return False
        'End If

        If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            If MyBase.Save() Then
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
        p.Add("@rt_no", rt_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1152t_stts", p)
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

            Me.Open("wi_sa1152t_delete", p)

            Me.Clear()
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
        Me.delete_row()

        'If check_rm_qty() = 1 Then
        '    Return False
        'End If

        If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else

            p.Clear()
            p.Add("@rt_no", rt_no.Text)
            p.Add("@stts", "A")

            Me.Open("wi_sa1152t_confirm", p)

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

            Me.Open("wi_sa1152t_confirm", p)

            p.Clear()
            p.Add("@rt_no", rt_no.Text)
            Me.Open("wi_sa1152t_head", p)

            p.Clear()
            p.Add("@rt_no", rt_no.Text)
            Me.Open("wi_sa1152t_body", p)

            p.Clear()
            p.Add("@rt_no", rt_no.Text)
            Me.Open("wi_sa1152t_body1", p)
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

        Me.Open("wi_sa1152t_head", p)
        Me.Open("wi_sa1152t_body", p)
        Me.Open("wi_sa1152t_body1", p)
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
        p.Add("@find_cs_nm", find_cs_nm.Text)

        Me.Open("wi_sa1152t_list", p)
    End Sub

    Private Sub btn_find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_find.Click
        g_list.Open()
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.find_Clear()
    End Sub

    Private Sub g_list_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g_list.DoubleClick
        p.Clear()
        p.Add("@rt_no", g_list.Text("RT_NO", g_list.RowIndex))

        Me.Open("wi_sa1152t_head", p)
        Me.Open("wi_sa1152t_body", p)
        Me.Open("wi_sa1152t_body1", p)

        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    Private Sub RTAMT()

        Dim won_amt1, rt_amt1 As Double

        With g_body
            .UpdateRow()
            For i As Integer = 0 To .RowCount - 1
                rt_amt1 = rt_amt1 + .ToDec("RT_AMT", i)
                won_amt1 = won_amt1 + .ToDec("WON_AMT", i)
            Next
        End With

        rt_amt.Text = rt_amt1
        won_amt.Text = won_amt1
    End Sub

    Private Sub g_body_CellValueChanged(ByVal sender As System.Object, ByVal ColumnName As System.String, ByVal RowIndex As System.Int32, ByRef Value As System.Object) Handles g_body.CellValueChanged
        Dim ls_odno As String = ""

        With g_body
            If ColumnName = "RT_QTY" Or ColumnName = "RT_PRI" Then
                .Text("RT_AMT") = .ToDec("RT_QTY") * .ToDec("RT_PRI")
                .Text("WON_AMT") = (.ToDec("RT_QTY") * .ToDec("RT_PRI")) * .ToDec("INV_RATE")

                Me.RTAMT()
            ElseIf ColumnName = "OD_NO" Or ColumnName = "OD_SEQ" Then 'Or ColumnName = "OT_NO" Then
                Me.Setitem_body1(.Text("OD_NO", RowIndex), .ToDec("OD_SEQ", RowIndex)) ', .Text("OT_NO", RowIndex))

            End If
        End With
    End Sub

    Private Sub delete_row()
        Dim ld_rtqty, ld_rtqty1 As Decimal

        For i As Integer = 0 To g_body.RowCount - 1
            ld_rtqty = g_body.ToDec("RT_QTY", i)

            If ld_rtqty = 0 Then
                g_body.DeleteRow(i)
            End If
        Next

        For b As Integer = 0 To g_body1.RowCount - 1
            ld_rtqty1 = g_body1.ToDec("RT_QTY", b)

            If ld_rtqty1 = 0 Then
                g_body1.DeleteRow(b)
            End If
        Next
    End Sub

    Private Sub Setitem_body1(a_odno As String, a_odseq As Decimal) ', a_otno As String)

        p.Clear()
        p.Add("@CS_CD", cs_cd.Text)
        p.Add("@OD_NO", a_odno)
        p.Add("@OD_SEQ", a_odseq)
        ' p.Add("@OT_NO", a_otno)


        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1152t_set_body1", p)

        If Not IsEmpty(dSet) Then
            With g_body1
                Dim iRow As Integer = 0
                Dim dRow As DataRow, dRows As DataRowCollection
                dRows = dSet.Tables(0).Rows

                iRow = .RowIndex

                If .Text("OT_NO", .RowIndex) <> Nothing Then iRow += 1

                For Each dRow In dRows
                    .InsertNewRow(iRow)

                    .Text("OT_NO", iRow) = ToStr(dRow("OT_NO"))
                    .Text("OT_SEQ", iRow) = ToDec(dRow("SEQ"))
                    .Text("OD_NO", iRow) = ToStr(dRow("OD_NO"))
                    .Text("OD_SEQ", iRow) = ToDec(dRow("OD_SEQ"))
                    .Text("GD_CD", iRow) = ToStr(dRow("GD_CD"))
                    .Text("GD_NM", iRow) = ToStr(dRow("GD_NM"))
                    .Text("SPEC", iRow) = ToStr(dRow("SPEC"))
                    .Text("UNIT_CD", iRow) = ToStr(dRow("UNIT_CD"))
                    .Text("LOT_NO", iRow) = ToStr(dRow("LOT_NO"))
                    .Text("RT_PRI", iRow) = ToDec(dRow("OT_PRI"))
                    .Text("RT_QTY", iRow) = ToDec(dRow("RT_QTY"))
                    .Text("RT_AMT", iRow) = ToDec(dRow("OT_PRI")) * ToDec(dRow("OT_QTY"))
                    .Text("OT_QTY", iRow) = ToDec(dRow("OT_QTY"))

                    iRow += 1
                Next
            End With
        End If
    End Sub
End Class
