Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class PMC200

    Private dSet As DataSet

    Private Sub pmb100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        g10.RecordNavigator = True

        g20.RecordNavigator = True

        prj_cd.ReadOnly = True
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

                    Dim saveID As String = prj_cd.Text
                    Dim saveID2 As String = step_no.Text

                    Me.Open()

                    g10.Find("prj_cd=" + saveID)
                    g10.Find("step_no=" + saveID2)

                End If
                'Case MenuType.New

                '    New_Form()


                'Case MenuType.Delete

                '    Me.WorkSet("pmc100_f10").DeleteRow()

                '    MyBase.Open()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub
    'Private Sub New_Form()

    '    'prj_cd.Text = ""
    '    'step_no.Text = ""
    '    temp_cd.Text = ""



    '    'prj_cd.ReadOnly = False
    '    'step_no.ReadOnly = False

    '    Me.Open("pmc200_f10")
    '    Me.Open("pmc200_g20")


    'End Sub

    Private Sub g10_AfterMoveRow(sender As Object, PrevRowIndex As Integer, RowIndex As Integer) Handles g10.AfterMoveRow
        prj_cd.ReadOnly = True
        step_no.ReadOnly = True
        Me.Open("pmc200_f10")
        Me.Open("pmc200_g20")
    End Sub

    Private Sub work_btn_Click(sender As System.Object, e As System.EventArgs) Handles work_btn.Click
        If temp_cd.Text = "" Or step1_no.Text = "" Then
            MessageInfo("Templete 입력 하십시오!")
            Exit Sub
        Else
            'Dim P As New OpenParameters
            'P.Add("@temp_cd", temp_cd.Text)
            dSet = Me.OpenDataSet("pmc200_work") ', P)
            If Not IsEmpty(dSet) Then
                For Each dRow As Data.DataRow In dSet.Tables(0).Rows
                    g20.AddNewRow()
                    g20.Text("sq_no", g20.RowIndex) = dRow("sq_no")
                    g20.Text("chk_itm", g20.RowIndex) = dRow("chk_itm")

                Next
            End If
        End If

    End Sub

End Class
