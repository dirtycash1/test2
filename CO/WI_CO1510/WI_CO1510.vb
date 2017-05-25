Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_CO1510
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If find_visible.Checked Then MenuButton_Click(MenuType.Find)
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

        If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else


            'g_body.SaveValue("NM_CD", nm_cd.Text, False)
            g_body.SaveValue("MOLD_CD", mold_cd.Text, False)
            g_body.SaveValue("CR_GU", cr_gu.Text, False)
            g_body.SaveValue("CR_TYPE", cr_type.Text, False)

            If MyBase.Save() Then

                'MyBase.OpenTrigger("wi_sa1120_list")
            End If

        End If

  

        Return True
    End Function



    Private Function Del() As Boolean

        If MessageYesNo("삭제 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            'p.Add("@NM_CD", nm_cd.Text)
            p.Add("@CR_GU", cr_gu.Text)
            p.Add("@CR_TYPE", cr_type.Text)

            Me.Open("WI_CO1510_delete", p)

            Me.Clear()

            g_list.Open()

        End If

        Return True
    End Function

    Private Sub Clear()
        p.Clear()
        p.Add("@NM_CD", "XXX")
        p.Add("@MOLD_CD", "XXX")
        p.Add("@CR_GU", "XXX")
        p.Add("@CR_TYPE", "XXX")

        Me.Open("WI_CO1510_head", p)
        Me.Open("WI_CO1510_body", p)
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
        p.Add("@find_cr_nm", "XXX")
        Me.Open("WI_CO1510_list", p)
    End Sub

    Private Sub btn_find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_find.Click
        p.Clear()
        p.Add("@find_cr_nm", find_cr_nm.Text)
        Me.Open("WI_CO1510_list", p)
    End Sub

    Private Sub g_list_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g_list.DoubleClick
        p.Clear()
        p.Add("@NM_CD", g_list.Text("NM_CD", g_list.RowIndex))
        p.Add("@MOLD_CD", g_list.Text("MOLD_CD", g_list.RowIndex))
        p.Add("@CR_GU", g_list.Text("CR_GU", g_list.RowIndex))
        p.Add("@CR_TYPE", g_list.Text("CR_TYPE", g_list.RowIndex))

        Me.Open("WI_CO1510_head", p)
        Me.Open("WI_CO1510_body", p)

        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.find_Clear()

    End Sub

End Class
