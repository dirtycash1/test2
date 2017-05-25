Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class PMT110

    Private dSet As DataSet

    Private Sub pmb100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        g10.RecordNavigator = True

        g20.RecordNavigator = True

        temp_cd.ReadOnly = True
        step_no.ReadOnly = True

        Me.Open()


    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Open
                Me.Open()
                'Me.OpenTrigger("pmc100_g10")

                'Me.Tree_Open()

            Case MenuType.Save

                If Me.Save() Then

                    Dim saveID As String = temp_cd.Text
                    Dim saveID2 As String = step_no.Text

                    Me.Open()

                    g10.Find("prj_cd=" + saveID)
                    g10.Find("step_no=" + saveID2)

                End If

            Case MenuType.New

                New_Form()

                'Case MenuType.Delete

                '    Me.WorkSet("pmc100_f10").DeleteRow()

                '    MyBase.Open()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub
    Private Sub New_Form()

        temp_cd.Text = ""
        step_no.Text = ""


        temp_cd.ReadOnly = False
        step_no.ReadOnly = False

        Me.Open("pmt110_f10")
        Me.Open("pmt110_g20")


    End Sub

    Private Sub g10_AfterMoveRow(sender As Object, PrevRowIndex As Integer, RowIndex As Integer) Handles g10.AfterMoveRow
        temp_cd.ReadOnly = True
        step_no.ReadOnly = True
        Me.Open("pmt110_g20")
    End Sub
End Class
