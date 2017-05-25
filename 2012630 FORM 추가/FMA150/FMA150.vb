Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Functions

Public Class FMA150

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Open()

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                MyBase.Open()

            Case MenuType.Save
                'If f_fr_dt.Text = "" Then
                '    MsgBox("'적용시작일' 선택은 필수입니다.")
                '    Exit Sub
                'End If

                If Me.Save() Then

                    Dim saveID As String = g10.Text("itm_cd")

                    MyBase.Open()

                    g10.Find("itm_cd=" + saveID)


                End If


            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

End Class
