Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class PR_CHEM
    Public SelectSwitch As String = ""
    'Private temp_dlv As Integer = 0
    Dim p As New OpenParameters

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'SplitContainer3.Panel2Collapsed = True
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                'Me._Open()
            Case MenuType.Save
            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다
        End Select
    End Sub

    Private Sub btn_jo1_Click(sender As System.Object, e As System.EventArgs) Handles btn_jo1.Click
        p.Clear()
        g10.Visible = True
        g20.Visible = False
        g30.Visible = False

        p.Add("@fac_cd", fac_cd.Text)
        Me.Open("PR_CHEM_g10", p)

    End Sub

    Private Sub btn_jo2_Click(sender As System.Object, e As System.EventArgs) Handles btn_jo2.Click
        p.Clear()
        g10.Visible = False
        g20.Visible = True
        g30.Visible = False

        p.Add("@fac_cd", fac_cd.Text)
        p.Add("@from_dt", from_dt.Text + " 00:00:00")
        p.Add("@to_dt", to_dt.Text + " 23:59:59")

        Me.Open("PR_CHEM_g20", p)
    End Sub

    Private Sub btn_jo3_Click(sender As System.Object, e As System.EventArgs) Handles btn_jo3.Click
        p.Clear()
        g10.Visible = False
        g20.Visible = False
        g30.Visible = True

        p.Add("@fac_cd", fac_cd.Text)
        Me.Open("PR_CHEM_g30", p)
    End Sub

    Private Sub g10_Click(sender As Object, e As System.EventArgs) Handles g10.Click
        p.Clear()
        g_list1.Visible = True
        g_list2.Visible = False

        p.Add("@fac_cd", fac_cd.Text)
        p.Add("@lot_no", g10.Text("LOT_NO", g10.RowIndex))

        Me.Open("PR_CHEM_Click1", p)

    End Sub

    Private Sub g20_Click(sender As Object, e As System.EventArgs) Handles g20.Click
        p.Clear()
        g_list1.Visible = False
        g_list2.Visible = True

        p.Add("@from_dt", from_dt.Text + " 00:00:00")
        p.Add("@to_dt", to_dt.Text + " 23:59:59")
        p.Add("@gu", g20.Text("GU", g20.RowIndex))
        p.Add("@fac_cd", fac_cd.Text)
        p.Add("@lot_no", g20.Text("LOT_NO", g20.RowIndex))

        Me.Open("PR_CHEM_Click2", p)
    End Sub

    Private Sub g30_Click(sender As Object, e As System.EventArgs) Handles g30.Click
        p.Clear()
        g_list1.Visible = True
        g_list2.Visible = False

        p.Add("@fac_cd", fac_cd.Text)
        p.Add("@lot_no", g30.Text("LOT_NO", g30.RowIndex))

        Me.Open("PR_CHEM_Click1", p)
    End Sub

    '@lot_no 
    'p.Add("@cs_cd", cs_cd.Text)
    'If hot_cd = "" Then
    '    p.Add("@hot_cd", g_body.Text("HOT_CD", g_body.RowIndex))
    'Else
    '    p.Add("@hot_cd", hot_cd)
    'End If
    'Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1120_price", p)
    'Dim price As Decimal = 0, rate_rt As Decimal = 0
    'Dim dRow As DataRow, dRows As DataRowCollection
    'dRows = dSet.Tables(0).Rows
    'For Each dRow In dRows
    '    If od_gu.Text = "CD05203" Or od_gu.Text = "CD05205" Or od_gu.Text = "CD05208" Or od_gu.Text = "CD05209" Then
    '        g_body.Text("OD_PRI", g_body.RowIndex) = 0
    '        g_body.Text("DISCOUNT_RT", g_body.RowIndex) = 0
    '    Else
    '        g_body.Text("OD_PRI", g_body.RowIndex) = ToStr(dRow("price"))
    '        g_body.Text("DISCOUNT_RT", g_body.RowIndex) = ToStr(dRow("rate_rt"))
    '    End If
    'Next
End Class
