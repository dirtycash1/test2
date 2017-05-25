Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class WI_SA1120
    'Dim ls_stts As String
    Dim p As New OpenParameters


    Private Sub WI_SA1120_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Clear()

        g_list.SelectRow = True

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open()

            Case MenuType.Cancel

                Me.Clear()

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
        p.Add("@od_no", "XXX")

        Me.Open("wi_sa1120_head", p)
        Me.Open("wi_sa1120_body", p)

    End Sub

    Private Function Check_Stts() As String
        p.Clear()
        p.Add("@od_no", od_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1120_stts", p)
        Dim stts As String = "S"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function
    Private Sub Max_NO()
        ' od_no 번호 채번
        od_no.CodeNo = "WI_SA1120"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        od_no.CodeDateField = od_dt
    End Sub

    Private Function Saves() As Boolean

        If Check_Stts() = "C" Then '상태값 CHECK
            MsgBox("확인된 자료입니다.!")
            Return False
        End If


        If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            Max_NO()  '전표채번..

            If MyBase.Save() Then

            End If
        End If

        Return True
    End Function
    Private Function ConFrim() As Boolean

        If od_no.Text = Nothing Then
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
            p.Add("@od_no", od_no.Text)
            p.Add("@stts", "C")

            Me.Open("wi_sa1120_confirm", p)
        End If

        Return True
    End Function
    Private Function DeConFrim() As Boolean

        If od_no.Text = Nothing Then
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
            p.Add("@od_no", od_no.Text)
            p.Add("@stts", "S")

            Me.Open("wi_sa1120_deconfirm", p)
        End If

        Return True
    End Function

    Private Function Del() As Boolean

        If od_no.Text = Nothing Then
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
            p.Add("@od_no", od_no.Text)

            Me.Open("wi_sa1120_delete", p)

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
        '수주번호를 '' 로 한후 조회 시켜버림
        od_no.Text = ""
        Me.OpenTrigger("wi_sa1120_list")
        'BODY 한줄 추가
        g_body.AddNewRow()
    End Sub


    Private Sub btn_find_Click(sender As System.Object, e As System.EventArgs) Handles btn_find.Click
        g_list.Open()
    End Sub
    Private Sub find_Clear()

        find_cs_nm.Text = ""
        find_od_no.Text = ""
        find_stts.Text = "%"

        p.Clear()
        p.Add("@find_from", find_from.Text)
        p.Add("@find_to", find_to.Text)
        p.Add("@find_cs_nm", "XXX")
        p.Add("@find_od_no", find_od_no.Text)
        p.Add("@find_stts", find_stts.Text)

        Me.Open("wi_sa1120_list", p)

    End Sub
    Private Sub btn_cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancel.Click
        Me.find_Clear()
    End Sub

    Private Sub g_list_DoubleClick(sender As Object, e As System.EventArgs) Handles g_list.DoubleClick

        Dim p As New OpenParameters

        p.Add("@od_no", g_list.Text("OD_NO", g_list.RowIndex))
        Me.Open("wi_sa1120_head", p)
        Me.Open("wi_sa1120_body", p)

        '찾기 리스트에서 더블 클릭시 찾기를 없앤다.
        If find_visible.Checked Then MenuButton_Click(MenuType.Find)

    End Sub
End Class
