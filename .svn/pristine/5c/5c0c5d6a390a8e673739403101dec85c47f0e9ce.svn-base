Imports Frame7
Imports Base7
Imports Base7.Shared
'Imports System.Math

Public Class FMR100

    Private Sub fmr100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        rep_no.CodeNo = "FMR100"
        rep_no.CodeDateField = rep_dt

        MyBase.Open()

        SplitContainer2.Panel2.BackColor = EPanel2.BackColor
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            'Case MenuType.Open

            '    Me.OpenTrigger("fmr100_g10")

            '    Me.Open("fmr100_g10")

            Case MenuType.Save

                If Me.Save() Then

                    Dim saveID As String = rep_no.Text

                    MyBase.Open()

                    g10.Find("rep_no=" + saveID)

                End If

            Case MenuType.New

                New_Form()

            Case MenuType.Delete

                Me.WorkSet("fmr100_f10").DeleteRow()

                MyBase.Open()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub New_Form()
        rep_no.Text = ""
        Me.OpenTrigger("fmr100_g10")
    End Sub

   
End Class
