Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAR220

    Private Sub FAR220_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me._Open()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Open
                Me._Open()

            Case MenuType.Save
                If Me.Save() Then
                    Me._Open()
                End If

            Case Else
                MyBase.MenuButton_Click(mty)

        End Select
    End Sub

    Private Sub _Open()
        get_yn.Text = "0"
        g10.ColumnVisible("chk") = False

        Me.Open()
    End Sub

    Private Sub btn_get_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_get.Click
        get_yn.Text = "1"
        g10.ColumnVisible("chk") = True

        Me.Open()
    End Sub

    'Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.DoubleClick
    '    Dim menuName As String
    '    menuName = "FAB100"

    '    If g10.Text("doc_no") = "" Then
    '        MessageInfo("연결된 전표가 없습니다.")
    '        Exit Sub
    '    End If

    '    Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
    '    If ctr IsNot Nothing Then
    '        ctr.Open2(g10.Text("doc_no"))
    '    End If
    'End Sub

    Private Sub g20_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g20.DoubleClick
        Dim menuName As String = "FAB100"
        With g20
            If .Text("doc_no2") = "" Then
                MessageInfo("연결된 전표가 없습니다.")
                Exit Sub
            End If

            Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
            If ctr IsNot Nothing Then
                ctr.Open2(.Text("doc_no2"))
            End If
        End With
    End Sub

 
End Class
