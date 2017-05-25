Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_SA1190
    Dim stts As String
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Clear()

        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Clear()

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

        Me.delete_row()

        If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            Max_NO()  '전표채번..

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
        p.Add("@deli_no", deli_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1190_stts", p)
        Dim stts As String = "S"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Sub Max_NO()
        deli_no.CodeNo = "WI_SA1190"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        deli_no.CodeDateField = deli_dt
    End Sub

    Private Function Del() As Boolean

        If deli_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        '상태값 CHECK
        If Check_Stts() = "C" Then '상태값 CHECK
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        If MessageYesNo("삭제 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@deli_no", deli_no.Text)
            p.Add("@stts", "D")

            Me.Open("wi_sa1190_delete", p)

            Me.Clear()

            g_list.Open()
        End If

        Return True
    End Function

    Private Function ConFrim() As Boolean

        If deli_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        '상태값 CHECK
        If Check_Stts() = "C" Then '상태값 CHECK
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        Me.delete_row()

        If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else

            p.Clear()
            p.Add("@deli_no", deli_no.Text)
            p.Add("@deli_dt", deli_dt.Text)
            p.Add("@stts", "C")

            Me.Open("wi_sa1190_confirm", p)

            p.Clear()
            p.Add("@deli_no", deli_no.Text)
            Me.Open("wi_sa1190_head", p)

            p.Clear()
            p.Add("@deli_no", deli_no.Text)
            Me.Open("wi_sa1190_body", p)
        End If

        Return True
    End Function

    Private Function DeConFrim() As Boolean

        If deli_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        '상태값 CHECK
        If Check_Stts() = "S" Then
            MsgBox("확인된 자료가 아닙니다.!")
            Return False
        End If
        If MessageYesNo("확인취소 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@deli_no", deli_no.Text)
            p.Add("@deli_dt", deli_dt.Text)
            p.Add("@stts", "S")

            Me.Open("wi_sa1190_deconfirm", p)

            p.Clear()
            p.Add("@deli_no", deli_no.Text)
            Me.Open("wi_sa1190_head", p)

            p.Clear()
            p.Add("@deli_no", deli_no.Text)
            Me.Open("wi_sa1190_body", p)
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
        p.Add("@deli_no", "XXX")

        Me.Open("wi_sa1190_head", p)

        p.Clear()
        p.Add("@deli_no", "XXX")
        Me.Open("wi_sa1190_body", p)

        head_otno.Text = ""
        delete_otno.Text = ""
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

        Me.Open("wi_sa1190_list", p)
    End Sub

    Private Sub btn_find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_find.Click
        g_list.Open()
    End Sub

    Private Sub g_list_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g_list.DoubleClick
        p.Clear()
        p.Add("@deli_no", g_list.Text("DELI_NO", g_list.RowIndex))

        Me.Open("wi_sa1190_head", p)

        p.Clear()
        p.Add("@deli_no", g_list.Text("DELI_NO", g_list.RowIndex))
        Me.Open("wi_sa1190_body", p)

        For i As Integer = 0 To g_body.RowCount - 1
            g_body.Text("CHK", i) = "1"
        Next

        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.find_Clear()
    End Sub

    Private Sub wf_setitem(a_cscd As String, a_deliplace As String)

        g_body.DeleteAll()

        p.Clear()
        p.Add("@CS_CD", a_cscd)
        p.Add("@DELI_PLACE", a_deliplace)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1190_ot_no", p)

        If Not IsEmpty(dSet) Then
            With g_body
                Dim iRow As Integer = 0
                Dim dRow As DataRow, dRows As DataRowCollection
                dRows = dSet.Tables(0).Rows

                iRow = .RowIndex

                If .Text("OT_NO", .RowIndex) <> Nothing Then iRow += 1

                For Each dRow In dRows
                    .InsertNewRow(iRow)

                    .Text("CHK", iRow) = "1"
                    .Text("OT_NO", iRow) = ToStr(dRow("OT_NO"))
                    .Text("OD_NO", iRow) = ToStr(dRow("OD_NO"))
                    .Text("OT_GU", iRow) = ToStr(dRow("OT_GU"))
                    .Text("OT_SEQ", iRow) = ToDec(dRow("OT_SEQ"))
                    .Text("GD_CD", iRow) = ToStr(dRow("GD_CD"))
                    .Text("GD_NM", iRow) = ToStr(dRow("GD_NM"))
                    .Text("SPEC", iRow) = ToStr(dRow("SPEC"))
                    .Text("QTY", iRow) = ToDec(dRow("OT_QTY"))

                    iRow += 1
                Next
            End With
        End If
    End Sub

    Private Sub cs_cd_TextChanged(sender As Object, oldValue As String) Handles cs_cd.TextChanged
        'If deli_place.Text <> "" Then
        '    Me.wf_setitem(cs_cd.Text, deli_place.Text)
        'End If

        g_body.DeleteAll()

    End Sub

    Private Sub deli_place_TextChanged(sender As Object, oldValue As String) Handles deli_place.TextChanged
        If cs_cd.Text <> "" Then
            Me.wf_setitem(cs_cd.Text, deli_place.Text)
        End If
    End Sub

    Private Sub head_otno_TextChanged(sender As Object, oldValue As String) Handles head_otno.TextChanged
        Me.find_otno()
    End Sub

    Private Sub delete_otno_TextChanged(sender As Object, oldValue As String) Handles delete_otno.TextChanged
        Me.find_otno1()
    End Sub

    Private Sub find_otno1()
        Dim ls_otno, ls_otno1 As String

        ls_otno = delete_otno.Text

        With g_body
            For i As Integer = 0 To .RowCount - 1
                ls_otno1 = .Text("OT_NO", i)

                If ls_otno = ls_otno1 Then
                    .UpdateRow()
                    .Text("CHK", i) = "0"
                End If
            Next
        End With
    End Sub

    Private Sub find_otno()
        Dim ls_otno, ls_otno1 As String

        ls_otno = head_otno.Text

        With g_body
            For i As Integer = 0 To .RowCount - 1
                ls_otno1 = .Text("OT_NO", i)

                If ls_otno = ls_otno1 Then
                    .UpdateRow()
                    .Text("CHK", i) = "1"
                End If
            Next
        End With
    End Sub

    Private Sub g_body_CellValueChanging(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g_body.CellValueChanging
        If ColumnName = "CHK" Then
            If Value = 1 Then
                head_otno.Text = g_body.Text("OT_NO")

                delete_otno.Text = "xxx"
            Else
                Dim ls_odno2 As String = ""

                delete_otno.Text = g_body.Text("OT_NO")

                head_otno.Text = "xxx"
            End If
        End If
    End Sub

    Private Sub delete_row()
        Dim ls_chk As String

        g_body.RowIndex = 0

        For i As Integer = 0 To g_body.RowCount + 1
            ls_chk = g_body.Text("CHK", i)

            If ls_chk = "0" Then
                g_body.DeleteRow(i)
                i = i - 1
            End If
        Next
    End Sub

    Private Sub but_print_Click(sender As System.Object, e As System.EventArgs) Handles but_print.Click
        Dim p As OpenParameters = New OpenParameters
        p.Add("@DELI_NO", deli_no.Text)

        System7.ReportView.LoadView("WI_SA1190", "", "wi_sa1190_print", p, , False)

    End Sub
End Class
