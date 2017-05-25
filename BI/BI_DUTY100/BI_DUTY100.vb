Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System7.ReportView
Imports System7.Reports
Imports System.Net.Mail
Imports System.Data
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports System.Runtime.CompilerServices
Imports System.Net
Imports System.Net.Configuration
Imports System.IO.FileLoadException


Public Class BI_DUTY100
    Dim p As New OpenParameters
    Dim p1 As OpenParameters = New OpenParameters
    Dim p2 As OpenParameters = New OpenParameters
    Dim p3 As OpenParameters = New OpenParameters

    Private Sub WI_BI_DUTY100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
        New_Form()
        'Me.Open()
        photo1.Visible = False
        photo2.Visible = False
        photo3.Visible = False

        Me.SplitContainer7.Panel1Collapsed = True
        Me.SplitContainer8.Panel1Collapsed = True
        Me.SplitContainer9.Panel1Collapsed = True

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open()

            Case MenuType.Cancel
                New_Form()
            Case MenuType.New
                New_Form()

            Case MenuType.Save
                If Not Saves() Then Else Me.Open() Exit Sub

            Case MenuType.Find
                Me.Find()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub


    Private Sub btn_find_Click(sender As System.Object, e As System.EventArgs) Handles btn_find.Click
        g_list.Open()
    End Sub

    Private Sub btn_cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancel.Click
        Me.New_Form()
    End Sub

    Private Sub g_list_DoubleClick(sender As Object, e As System.EventArgs) Handles g_list.DoubleClick

        night_dt.Text = g_list.Text("NIGHT_DT", g_list.RowIndex)
        night_gu.Text = g_list.Text("NIGHT_GU", g_list.RowIndex)
        emp_no.Text = g_list.Text("EMP_NO", g_list.RowIndex)
        du_no.Text = g_list.Text("DU_NO", g_list.RowIndex)

        p.Clear()

        p.Add("@night_dt", g_list.Text("NIGHT_DT", g_list.RowIndex))
        p.Add("@night_gu", g_list.Text("NIGHT_GU", g_list.RowIndex))
        p.Add("@emp_no", g_list.Text("EMP_NO", g_list.RowIndex))
        p.Add("@emp_nm", g_list.Text("EMP_NM", g_list.RowIndex))
        p.Add("@du_no", g_list.Text("DU_NO", g_list.RowIndex))


        Me.Open("bi_duty100_f10", p)
        Me.Open("bi_duty100_f20", p)
        Me.Open("bi_duty100_f30", p)


        '찾기 리스트에서 더블 클릭시 찾기를 없앤다.
        If find_visible.Checked Then MenuButton_Click(MenuType.Find)

        photo1.Visible = False
        photo2.Visible = False
        photo3.Visible = False

        Me.SplitContainer7.Panel1Collapsed = True
        Me.SplitContainer8.Panel1Collapsed = True
        Me.SplitContainer9.Panel1Collapsed = True


    End Sub

    Private Sub Find()
        If spc_1.Panel1Collapsed = False Then
            spc_1.Panel1Collapsed = True
        Else
            spc_1.Panel1Collapsed = False
        End If
    End Sub

    Private Function Saves() As Boolean
        Max_NO()  '전표채번

        If MyBase.Save() Then
        Else
            Return False
        End If

        Return True
    End Function


    Private Sub Max_NO()
        p.Clear()
        p.Add("@night_dt", night_dt.Text)
        p.Add("@emp_no", emp_no.Text)
        p.Add("@du_no", du_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("bi_du_no", p)
        Dim dRow As DataRow, dRows As DataRowCollection

        If IsEmpty(dSet) Then
            Exit Sub
        End If

        dRows = dSet.Tables(0).Rows

        For Each dRow In dRows
            du_no.Text = ToStr(dRow("DU_NO"))
        Next

    End Sub

    Private Sub New_Form()

        night_dt.Text = ""
        du_no.Text = ""

        p.Clear()
        p.Add("@fr_dt", "9999-12-01")
        p.Add("@to_dt", "9999-12-01")

        p.Add("@night_dt", "9999-12-01")
        p.Add("@night_gu", "xxx")
        p.Add("@emp_no", "xxxxx")
        p.Add("@emp_nm", "xxxxxx")
        p.Add("@du_no", "xxxxxx")


        Me.Open("bi_duty100_f10", p)
        Me.Open("bi_duty100_f20", p)
        Me.Open("bi_duty100_f30", p)

    End Sub


    Private Sub PRINT()

        If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
        Else
            If Not Saves() Then

            Else
                Me.Open()
            End If




            p1.Clear()
            p1.Add("@night_dt", night_dt.Text)
            p1.Add("@night_gu", night_gu.Text)
            p1.Add("@emp_no", emp_no.Text)
            p1.Add("@du_no", du_no.Text)
            p1.Add("@fac_cd", "01")


            p2.Clear()
            p2.Add("@night_dt", night_dt.Text)
            p2.Add("@night_gu", night_gu.Text)
            p2.Add("@emp_no", emp_no.Text)
            p2.Add("@du_no", du_no.Text)
            p2.Add("@fac_cd", "02")


            p3.Clear()
            p3.Add("@night_dt", night_dt.Text)
            p3.Add("@night_gu", night_gu.Text)
            p3.Add("@emp_no", emp_no.Text)
            p3.Add("@du_no", du_no.Text)
            p3.Add("@fac_cd", "03")


            System7.ReportView2.LoadView("BI_DUTY100", "당직일지", "duty100_print", p1, Nothing, True, 1,
                                        "SUB1", "duty100_print", p2,
                                        "SUB2", "duty100_print", p3)

            Exit Sub

        End If



        'With g10
        '    For Row As Integer = 0 To g10.RowCount - 1
        '        p.Add("@cs_cd", g10.Text("CS_CD", Row))

        '        If g10.Text("chk", Row) = "1" And (g10.Text("ROW_NO", Row) = "1" Or g10.Text("ROW_NO", Row) = "2") Then
        '            p.Add("@std_dt", Today)
        '            System7.ReportView.LoadView("WI_SA1133", "", "wi_sa1133_print", p, Nothing, True, 1, "WI_SA1133_SUB", "wi_sa1133_print", p)
        '        End If
        '    Next
        'End With

    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        PRINT()
    End Sub

    Private Sub btn_pic1_Click(sender As Object, e As EventArgs) Handles btn_pic1.Click
        'If photo1.Visible Then
        '    photo1.Visible = False
        '    'Me.SplitContainer7.SplitterDistance = 35
        '    Me.SplitContainer7.Panel1Collapsed = False
        'Else
        '    photo1.Visible = True
        '    'Me.SplitContainer7.SplitterDistance = 127
        '    Me.SplitContainer7.Panel1Collapsed = True
        'End If

        If Me.SplitContainer7.Panel1Collapsed = False Then
            Me.SplitContainer7.Panel1Collapsed = True
        Else
            Me.SplitContainer7.Panel1Collapsed = False
            photo1.Visible = True

        End If

    End Sub


    Private Sub btn_pic2_Click(sender As Object, e As EventArgs) Handles btn_pic2.Click

        If Me.SplitContainer8.Panel1Collapsed = False Then
            Me.SplitContainer8.Panel1Collapsed = True
        Else
            Me.SplitContainer8.Panel1Collapsed = False
            photo2.Visible = True
        End If

    End Sub

    Private Sub btn_pic3_Click(sender As Object, e As EventArgs) Handles btn_pic3.Click

        If Me.SplitContainer9.Panel1Collapsed = False Then
            Me.SplitContainer9.Panel1Collapsed = True
        Else
            Me.SplitContainer9.Panel1Collapsed = False
            photo3.Visible = True
        End If

    End Sub


End Class

