Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_TR2180
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
        'Clear()

        g_body.AddNewRow()
    End Sub

    Private Function Saves() As Boolean

        If Check_Stts() = "C" Then '상태값 CHECK
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        Me.RTAMT()

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
        p.Add("@cn_no", cn_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_tr2180_stts", p)
        Dim stts As String = "S"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Sub Max_NO()
        cn_no.CodeNo = "WI_TR2180"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        cn_no.CodeDateField = cn_dt
    End Sub

    Private Function Del() As Boolean

        If cn_no.Text = Nothing Then
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
            p.Add("@cn_no", cn_no.Text)
            p.Add("@stts", "D")

            Me.Open("wi_tr2180_delete", p)

            Me.Clear()

            g_list.Open()
        End If

        Return True
    End Function

    Private Function ConFrim() As Boolean

        If cn_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        '상태값 CHECK
        If Check_Stts() = "C" Then '상태값 CHECK
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        Me.RTAMT()

        If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else

            p.Clear()
            p.Add("@cn_no", cn_no.Text)
            p.Add("@stts", "C")

            Me.Open("wi_tr2180_confirm", p)

            p.Clear()
            p.Add("@cn_no", cn_no.Text)

            Me.Open("wi_tr2180_head", p)

            p.Clear()
            p.Add("@cn_no", cn_no.Text)

            Me.Open("wi_tr2180_body", p)

            g_list.Open()
        End If

        Return True
    End Function

    Private Function DeConFrim() As Boolean

        If cn_no.Text = Nothing Then
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
            p.Add("@cn_no", cn_no.Text)
            p.Add("@stts", "S")

            Me.Open("wi_tr2180_confirm", p)

            p.Clear()
            p.Add("@cn_no", cn_no.Text)

            Me.Open("wi_tr2180_head", p)

            p.Clear()
            p.Add("@cn_no", cn_no.Text)

            Me.Open("wi_tr2180_body", p)
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
        p.Add("@cn_no", "XXX")

        Me.Open("wi_tr2180_head", p)
        Me.Open("wi_tr2180_body", p)
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

        Me.Open("wi_tr2180_list", p)
    End Sub

    Private Sub btn_find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_find.Click
        g_list.Open()
    End Sub

    Private Sub g_list_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g_list.DoubleClick
        p.Clear()
        p.Add("@cn_no", g_list.Text("CN_NO", g_list.RowIndex))

        Me.Open("wi_tr2180_head", p)
        Me.Open("wi_tr2180_body", p)

        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.find_Clear()

    End Sub
    Private Sub g_body_CellValueChanged(ByVal sender As System.Object, ByVal ColumnName As System.String, ByVal RowIndex As System.Int32, ByRef Value As System.Object) Handles g_body.CellValueChanged
        With g_body
            If ColumnName = "QTY" Or ColumnName = "PRICE" Then
                .Text("AMT") = .ToDec("QTY") * .ToDec("PRICE")

                Me.RTAMT()
            End If
        End With
    End Sub

    Private Sub RTAMT()
        Dim sum_amt1 As Double

        With g_body
            .UpdateRow()
            For i As Integer = 0 To .RowCount - 1
                sum_amt1 = sum_amt1 + .ToDec("AMT", i)
            Next
        End With

        cr_amt.Text = sum_amt1
    End Sub
End Class
