Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_WO1360
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If find_visible.Checked Then MenuButton_Click(MenuType.Find)

        If spc_1.Panel1Collapsed = False Then
            spc_1.Panel1Collapsed = True
        Else
            spc_1.Panel1Collapsed = False
        End If

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

                'Case MenuType.Confirm
                '    If Not ConFrim() Then Exit Sub

                'Case MenuType.Deconfirm
                'If Not DeConFrim() Then Exit Sub

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

        If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            If MyBase.Save() Then
                'MyBase.OpenTrigger("wi_sa1120_list")
            End If

            stts.Text = "S"
        End If

        Return True
    End Function

    Private Function Check_Stts() As String
        p.Clear()
        p.Add("@YM", ym.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("WI_WO1360_stts", p)
        Dim stts As String = "S"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Function Del() As Boolean
        '상태값 CHECK
        If Check_Stts() = "C" Then
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        If MessageYesNo("삭제 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@YM", ym.Text)

            Me.Open("WI_WO1360_delete", p)

            Me.Clear()

            g_list.Open()

        End If

        Return True
    End Function

    'Private Function ConFrim() As Boolean

    '    '상태값 CHECK
    '    If Check_Stts() = "C" Then
    '        MsgBox("확인된 자료입니다.!")
    '        Return False
    '    End If

    '    If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
    '        Exit Function
    '    Else

    '        p.Clear()
    '        p.Add("@YM", ym.Text)
    '        p.Add("@stts", "C")

    '        Me.Open("WI_WO1360_confirm", p)

    '        stts.Text = "C"
    '    End If

    '    Return True
    'End Function

    'Private Function DeConFrim() As Boolean

    '    '상태값 CHECK
    '    If Check_Stts() <> "C" Then
    '        MsgBox("확인된 자료가 아닙니다.!")
    '        Return False
    '    End If

    '    If MessageYesNo("확인취소 하시겠습니까?") = MsgBoxResult.No Then
    '        Exit Function
    '    Else
    '        p.Clear()
    '        p.Add("@YM", ym.Text)
    '        p.Add("@stts", "S")

    '        Me.Open("WI_WO1360_confirm", p)

    '        p.Clear()
    '        p.Add("@YM", ym.Text)

    '        Me.Open("WI_WO1360_head", p)
    '        Me.Open("WI_WO1360_body", p)

    '        stts.Text = "S"
    '    End If

    '    Return True
    'End Function

    Private Sub Clear()
        p.Clear()
        p.Add("@YM", "XXX")

        Me.Open("WI_WO1360_head", p)
        Me.Open("WI_WO1360_body", p)
    End Sub

    Private Sub Find()
        p.Clear()
        p.Add("@YM", ym.Text)

        Me.Open("WI_WO1360_head", p)
        Me.Open("WI_WO1360_body", p)
        'If spc_1.Panel1Collapsed = False Then
        '    spc_1.Panel1Collapsed = True
        'Else
        '    spc_1.Panel1Collapsed = False
        'End If
    End Sub

    'Private Sub find_Clear()
    '    p.Clear()
    '    p.Add("@find_fym", find_fym.Text)
    '    p.Add("@find_tym", find_fym.Text)
    '    p.Add("@find_stts", "XXX")

    '    Me.Open("WI_WO1360_list", p)
    'End Sub

    'Private Sub btn_find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_find.Click
    '    g_list.Open()
    'End Sub

    Private Sub g_body_CellValueChanged(ByVal sender As System.Object, ByVal ColumnName As System.String, ByVal RowIndex As System.Int32, ByRef Value As System.Object) Handles g_body.CellValueChanged
        With g_body
            If ColumnName = "STOCK_QTY" Or ColumnName = "STOCK_AMT" Then
                .Text("STOCK_PRI") = .ToDec("STOCK_AMT") / .ToDec("STOCK_QTY")
            End If
        End With
    End Sub

    Private Sub g_list_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g_list.DoubleClick
        p.Clear()
        p.Add("@YM", g_list.Text("YM", g_list.RowIndex))

        Me.Open("WI_WO1360_head", p)
        Me.Open("WI_WO1360_body", p)

        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    'Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
    '    Me.find_Clear()
    'End Sub
End Class
