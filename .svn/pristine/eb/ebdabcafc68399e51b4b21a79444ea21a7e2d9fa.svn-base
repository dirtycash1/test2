Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAS501

    Private Sub FAS501_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        XtraTabControl1.TabPages(2).PageVisible = False
        XtraTabControl1.TabPages(3).PageVisible = False
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Open

                Me.Open_Form()

                'Case MenuType.New

            Case MenuType.Save

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Public Sub Open_Form()

        If XtraTabControl1.SelectedTabPageIndex = 0 Then

            MyBase.Open("fas501_g10")

        End If

        If XtraTabControl1.SelectedTabPageIndex = 1 Then

            MyBase.Open("fas501_g20")

        End If

        If XtraTabControl1.SelectedTabPageIndex = 2 Then

            MyBase.Open("fas501_g30")

        End If

        If XtraTabControl1.SelectedTabPageIndex = 3 Then

            MyBase.Open("fas501_g40")

        End If

    End Sub

End Class
