Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class PMC100

    Private dSet As DataSet

    Private Sub pmb100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        g10.RecordNavigator = True

        prj_cd.ReadOnly = True
        step_no.ReadOnly = True

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Open
                Me.Open()
                'Me.OpenTrigger("pmc100_g10")

                'Me.Tree_Open()

            Case MenuType.Save

                If Me.Save() Then

                    Dim saveID As String = prj_cd.Text
                    Dim saveID2 As String = step_no.Text

                    Me.Open()

                    g10.Find("prj_cd=" + saveID)
                    g10.Find("step_no=" + saveID2)

                End If

            Case MenuType.New

                New_Form()

            Case MenuType.Delete

                Me.WorkSet("pmc100_f10").DeleteRow()

                MyBase.Open()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub New_Form()

        prj_cd.Text = ""
        step_no.Text = ""
        ent_id.Text = ""

        prj_cd.ReadOnly = False
        step_no.ReadOnly = False

        Me.Open("pmc100_f10")

    End Sub
   
    Private Sub g10_AfterMoveRow(sender As Object, PrevRowIndex As Integer, RowIndex As Integer) Handles g10.AfterMoveRow
        prj_cd.ReadOnly = True
        step_no.ReadOnly = True
    End Sub
End Class
