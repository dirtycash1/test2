Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class FAS510

    Private Sub work_doc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles work_doc.Click

        If MessageYesNo("전표를 생성하시겠습니까 ?") = MsgBoxResult.No Then
            Exit Sub
        End If

        Me.Open("fas510_work")

        Me.Open()
    End Sub

    Private Sub doc_no_ButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles doc_no.ButtonClick
        Dim menuName As String
        'If Parameter.System.Code = "CSI" Then
        '    menuName = "FAB100_CSI"
        'Else
        menuName = "FAB100"
        'End If
        '화면을 띄운다
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName) 'New FormAttribute(menuName, menuText))
        If ctr IsNot Nothing Then
            ctr.Open2(doc_no.Text)
        End If
    End Sub

    Private Sub btn_jump_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_jump.Click
        If doc_no.Text = "" Then
            Exit Sub
        End If

        Dim menuName As String
        menuName = "FAB100"

        '화면을 띄운다
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
        If ctr IsNot Nothing Then
            ctr.Open2(doc_no.Text)
        End If
    End Sub


    Private Sub del_doc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles del_doc.Click
        If doc_no.Text = "" Then
            Exit Sub
        End If

        If MessageYesNo("전표를 삭제하시겠습니까 ?") = MsgBoxResult.No Then
            Exit Sub
        End If

        Me.Open("fas510_delete_doc")

        Me.Open()

    End Sub


End Class
