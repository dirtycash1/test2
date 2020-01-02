Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class BCC210

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Parameter.System.Code = "CSI" Then
            XtraTabPage1.PageVisible = False
        End If

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                Me.open_chk()

            Case MenuType.Save

                Me.save_chk()

                'Case MenuType.New

            Case Else

                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Public Sub save_chk()

        If XtraTabControl1.SelectedTabPageIndex = 0 Then

            MyBase.Save("bcc210_g10")

        End If

        If XtraTabControl1.SelectedTabPageIndex = 1 Then

            MyBase.Save("bcc210_g20")

        End If

    End Sub

    Public Sub open_chk()

        If XtraTabControl1.SelectedTabPageIndex = 0 Then

            MyBase.Open("bcc210_g10")

        End If

        If XtraTabControl1.SelectedTabPageIndex = 1 Then

            MyBase.Open("bcc210_g20")

        End If

    End Sub


End Class
