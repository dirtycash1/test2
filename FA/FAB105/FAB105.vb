Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class FAB105
    Private FromNm As String = ""
    Private Sub FAB101_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Me.IsManager Then
            dept_cd.ReadOnly = False
        End If

    End Sub

    Public Sub Open2(ByVal GetFromNm As String)
        FromNm = GetFromNm
        MyBase.Open()
    End Sub

    Private Sub btn_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok.Click
        Add_Sample_Rows()
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        If g10.Text("doc_no") = "" Then
            Exit Sub
        End If

        If FromNm = "" Then FromNm = "FAB100"
        '전표화면 찾기
        Dim menuName As String = FromNm
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)

        ctr.Open2(g10.Text("doc_no"))

    End Sub


    'Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
    '    Select Case mty
    '        Case MenuType.Open

    '            MyBase.Open()

    '        Case Else
    '            MyBase.MenuButton_Click(mty)

    '    End Select

    'End Sub

    Private Function Add_Sample_Rows() As Boolean

        If g10.Text("doc_no") = "" Then
            Return True
        End If

        '전표화면 찾기
        If FromNm = "" Then FromNm = "FAB100"
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(FromNm)

        If ctr IsNot Nothing Then
            With g10
                ctr.Set_Sample_Master(.Text("co_cd"), .Text("div_cd"), .Text("title"), .Text("dept_cd"), .Text("doc_id"))
                ctr.Set_Sample_Rows(g20)
            End With
        End If
    End Function



End Class
