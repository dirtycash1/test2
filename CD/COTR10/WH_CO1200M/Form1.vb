Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class Form1
    Private popup As WH_CO1200M
    Dim popGrid As eGrid

    Public Sub InitPopup()

        popup = New WH_CO1200M      'Form1 안에 불려지는 폼을 여기서 호출한다. 
        ' 참조부분에 추가되어 있어야 한다
        ' 불려지는 폼은 다른 일반 메뉴와 동일하게 구현하면 된다

        If popup IsNot Nothing Then
            popup.Dock = System.Windows.Forms.DockStyle.Fill

            'popup 화면에 버턴이 있다면 popup내에서 제어해도 되고 여기서도 제어 가능하다

            AddHandler popup.btn_find.Click, AddressOf btn_find_Click
            AddHandler popup.btn_cancel.Click, AddressOf btn_cancel_click
            AddHandler popup.btn_exit.Click, AddressOf btn_exit_click
            AddHandler popup.btn_ok.Click, AddressOf btn_ok_click

            Me.Controls.Add(popup)

            popup.Show()
        End If
    End Sub

    Private Sub btn_find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        popup.Open()
        '상황에 맞는 코딩을 한다

        'If popup.Save_Popup() Then
        '    Me.DialogResult = Windows.Forms.DialogResult.OK
        '    Exit Sub
        'End If
        'Me.DialogResult = Windows.Forms.DialogResult.None
    End Sub

    Private Sub btn_cancel_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        popup.find_search.Text = "zzzzzzzzzzzzzz"
        'popup.NewForm()
        'popup.g_multi.DeleteAll()
        popup.g_multi.Open()
        popup.find_search.Text = ""
        '상황에 맞는 코딩을 한다
    End Sub

    Private Sub btn_exit_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '상황에 맞는 코딩을 한다
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btn_ok_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '상황에 맞는 코딩을 한다
        'Dim parentForm As Windows.Forms.Form
        'Dim pf As Form
        'parentForm = popup.ParentForm

        Try
            popGrid = popup.g_multi

            popup.Tag = popGrid
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MessageInfo(ex)
        End Try

        'For i = 0 To popup.g_multi.RowCount - 1
        '    If popup.g_multi.Text("chk", i) = "1" Then
        '        'parentForm.
        '    End If
        'Next

        'Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

End Class