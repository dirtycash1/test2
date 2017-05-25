Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class WI_DE1040_J
    Dim p As New OpenParameters
    Dim p_sub1 As New OpenParameters
    Dim p_sub2 As New OpenParameters
    Dim p_sub3 As New OpenParameters
    Dim p_sub4 As New OpenParameters
    Dim p_sub5 As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'CrystalReportViewer1.Visible = False
        'Panel1.Visible = False

        Panel2.Visible = True
        SplitContainer2.Visible = True
        SplitContainer3.Visible = True
        SplitContainer4.Visible = True
        SplitContainer5.Visible = True
        SplitContainer6.Visible = True

        p.Clear()
        p.Add("@base_dt", "2099-04-04")     '처음에 addrow가 되도록 아무거나 조회
        p.Add("@to_dt", "2099-04-30")
        p.Add("@gd_cd", "AH0002")
        p.Add("@code_no", "N")

        Me.Open("wi_de1040j_etc", p)
        Me.Open("wi_de1040j_g20", p)
        Me.Open("wi_de1040j_g40", p)
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open()
            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다
        End Select
    End Sub

    '버튼클릭시, 저장 기능
    '기초저장
    Private Sub bs_btn_Click(sender As System.Object, e As System.EventArgs) Handles bs_btn.Click
        Me.Save("wi_de1040j_g20")
    End Sub

    '입고저장
    Private Sub ip_btn_Click(sender As System.Object, e As System.EventArgs) Handles ip_btn.Click
        Me.Save("wi_de1040j_g40")
    End Sub

    '재고저장
    Private Sub j_btn_Click(sender As System.Object, e As System.EventArgs) Handles j_btn.Click
        Me.Save("wi_de1040j_g50")
    End Sub

    '기타출고저장
    Private Sub etc_btn_Click(sender As System.Object, e As System.EventArgs) Handles etc_btn.Click
        Me.Save("wi_de1040j_etc")
    End Sub

    '품목코드 헤더로 맞추기
    Private Sub etc_AddedRow(sender As Object, RowIndex As Integer) Handles etc.AddedRow
        etc.Text("GD_CD", RowIndex) = gd_cd.Text
        etc.Text("CODE_NO", RowIndex) = code_no.Text
        'etc.DeleteRow(etc.RowCount)
    End Sub

    Private Sub g20_AddedRow(sender As Object, RowIndex As Integer) Handles g20.AddedRow
        g20.Text("GD_CD", RowIndex) = gd_cd.Text
        g20.Text("BASE_DT", RowIndex) = Mid(base_dt.Text, 1, 7) + "-01"
        g20.Text("CODE_NO", RowIndex) = code_no.Text

    End Sub

    Private Sub g40_AddedRow(sender As Object, RowIndex As Integer) Handles g40.AddedRow
        g40.Text("GD_CD", RowIndex) = gd_cd.Text
        g40.Text("CODE_NO", RowIndex) = code_no.Text
    End Sub

    '원료관리대장 출력
    Private Sub button1_Click(sender As System.Object, e As System.EventArgs) Handles button1.Click
        p.Clear()
        p.Add("@base_dt", base_dt.Text)
        p.Add("@to_dt", to_dt.Text)
        p.Add("@gd_cd", gd_cd.Text)
        p.Add("@code_no", code_no.Text)

        p_sub1.Clear()
        p_sub1.Add("@base_dt", base_dt.Text)
        p_sub1.Add("@to_dt", to_dt.Text)
        p_sub1.Add("@gd_cd", gd_cd.Text)
        p_sub1.Add("@code_no", code_no.Text)

        p_sub2.Clear()
        p_sub2.Add("@base_dt", base_dt.Text)
        p_sub2.Add("@to_dt", to_dt.Text)
        p_sub2.Add("@gd_cd", gd_cd.Text)
        p_sub2.Add("@code_no", code_no.Text)

        p_sub3.Clear()
        p_sub3.Add("@base_dt", base_dt.Text)
        p_sub3.Add("@to_dt", to_dt.Text)
        p_sub3.Add("@gd_cd", gd_cd.Text)
        p_sub3.Add("@code_no", code_no.Text)

        p_sub4.Clear()
        p_sub4.Add("@base_dt", base_dt.Text)
        p_sub4.Add("@to_dt", to_dt.Text)
        p_sub4.Add("@gd_cd", gd_cd.Text)
        p_sub4.Add("@code_no", code_no.Text)

        p_sub5.Clear()
        p_sub5.Add("@gd_cd", gd_cd.Text)

        System7.ReportView2.LoadView("WI_DE1040J", "허가용 재고관리 프린트", "wi_de1040j_print", p, Nothing, True, 1,
                                    "SUB1", "wi_de1040j_sub1", p_sub1,
                                    "SUB2", "wi_de1040j_sub2", p_sub2,
                                    "ETC_STOCK", "wi_de1040j_sub3", p_sub3,
                                    "JEGO_STOCK", "wi_de1040j_sub4", p_sub4,
                                    "MB_NM", "wi_de1040j_sub5", p_sub5
                                    )
    End Sub

    Private Sub code_no_TextChanged(sender As Object, oldValue As String) Handles code_no.TextChanged
        For i As Integer = 0 To etc.RowCount - 1
            etc.Text("CODE_NO", i) = code_no.Text
        Next

        For i As Integer = 0 To g20.RowCount - 1
            g20.Text("CODE_NO", i) = code_no.Text
        Next

        For i As Integer = 0 To g40.RowCount - 1
            g40.Text("CODE_NO", i) = code_no.Text
        Next

    End Sub


    'Private Sub button1_Click(sender As System.Object, e As System.EventArgs) Handles button1.Click

    '    Panel1.Visible = True
    '    CrystalReportViewer1.Visible = True

    '    Panel2.Visible = False
    '    SplitContainer3.Visible = False
    '    SplitContainer4.Visible = False
    '    SplitContainer5.Visible = False
    '    SplitContainer6.Visible = False

    '    ''1.  완료 소스 
    '    Dim cryRpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    '    cryRpt.Load("\\192.168.2.150\허가용재고관리\WI_DE1040_JR.rpt")   '("C:\Users\Administrator\Desktop\WI_DE1040_JR\WI_DE1040_JR.rpt") 

    '    '기본 보고서
    '    Dim paramDefs As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinitions
    '    Dim paramDef As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition
    '    Dim values As New CrystalDecisions.Shared.ParameterValues
    '    Dim dis_val As New CrystalDecisions.Shared.ParameterDiscreteValue
    '    dis_val.Value = code_no.Text  '"N"
    '    paramDefs = cryRpt.DataDefinition.ParameterFields()
    '    paramDef = paramDefs.Item("@code_no")
    '    values = paramDef.CurrentValues

    '    Dim paramDefs2 As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinitions
    '    Dim paramDef2 As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition
    '    Dim values2 As New CrystalDecisions.Shared.ParameterValues
    '    Dim dis_val2 As New CrystalDecisions.Shared.ParameterDiscreteValue
    '    dis_val2.Value = gd_cd.Text  '"AH0002"
    '    paramDefs2 = cryRpt.DataDefinition.ParameterFields()
    '    paramDef2 = paramDefs2.Item("@gd_cd")
    '    values2 = paramDef2.CurrentValues

    '    Dim paramDefs3 As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinitions
    '    Dim paramDef3 As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition
    '    Dim values3 As New CrystalDecisions.Shared.ParameterValues
    '    Dim dis_val3 As New CrystalDecisions.Shared.ParameterDiscreteValue
    '    dis_val3.Value = base_dt.Text '"2015-04-01 00:00:00"
    '    paramDefs3 = cryRpt.DataDefinition.ParameterFields()
    '    paramDef3 = paramDefs3.Item("@base_dt")
    '    values3 = paramDef3.CurrentValues

    '    Dim paramDefs4 As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinitions
    '    Dim paramDef4 As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition
    '    Dim values4 As New CrystalDecisions.Shared.ParameterValues
    '    Dim dis_val4 As New CrystalDecisions.Shared.ParameterDiscreteValue
    '    dis_val4.Value = to_dt.Text '"2015-04-30 00:00:00"
    '    paramDefs4 = cryRpt.DataDefinition.ParameterFields()
    '    paramDef4 = paramDefs4.Item("@to_dt")
    '    values4 = paramDef4.CurrentValues


    '    '하위보고서1(SUB1)
    '    Dim sub1_paramDefs As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinitions
    '    Dim sub1_paramDef As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition
    '    Dim sub1_values As New CrystalDecisions.Shared.ParameterValues
    '    Dim sub1_dis_val As New CrystalDecisions.Shared.ParameterDiscreteValue
    '    sub1_dis_val.Value = code_no.Text  '"N"
    '    sub1_paramDefs = cryRpt.DataDefinition.ParameterFields()
    '    sub1_paramDef = sub1_paramDefs.Item("@code_no1")
    '    sub1_values = sub1_paramDef.CurrentValues

    '    Dim sub1_paramDefs2 As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinitions
    '    Dim sub1_paramDef2 As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition
    '    Dim sub1_values2 As New CrystalDecisions.Shared.ParameterValues
    '    Dim sub1_dis_val2 As New CrystalDecisions.Shared.ParameterDiscreteValue
    '    sub1_dis_val2.Value = gd_cd.Text  '"AH0002"
    '    sub1_paramDefs2 = cryRpt.DataDefinition.ParameterFields()
    '    sub1_paramDef2 = sub1_paramDefs2.Item("@gd_cd1")
    '    sub1_values2 = sub1_paramDef2.CurrentValues

    '    Dim sub1_paramDefs3 As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinitions
    '    Dim sub1_paramDef3 As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition
    '    Dim sub1_values3 As New CrystalDecisions.Shared.ParameterValues
    '    Dim sub1_dis_val3 As New CrystalDecisions.Shared.ParameterDiscreteValue
    '    sub1_dis_val3.Value = base_dt.Text '"2015-04-01 00:00:00"
    '    sub1_paramDefs3 = cryRpt.DataDefinition.ParameterFields()
    '    sub1_paramDef3 = sub1_paramDefs3.Item("@base_dt1")
    '    sub1_values3 = sub1_paramDef3.CurrentValues

    '    Dim sub1_paramDefs4 As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinitions
    '    Dim sub1_paramDef4 As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition
    '    Dim sub1_values4 As New CrystalDecisions.Shared.ParameterValues
    '    Dim sub1_dis_val4 As New CrystalDecisions.Shared.ParameterDiscreteValue
    '    sub1_dis_val4.Value = to_dt.Text '"2015-04-30 00:00:00"
    '    sub1_paramDefs4 = cryRpt.DataDefinition.ParameterFields()
    '    sub1_paramDef4 = sub1_paramDefs4.Item("@to_dt1")
    '    sub1_values4 = sub1_paramDef4.CurrentValues

    '    '하위보고서2(SUB2)
    '    Dim sub2_paramDefs As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinitions
    '    Dim sub2_paramDef As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition
    '    Dim sub2_values As New CrystalDecisions.Shared.ParameterValues
    '    Dim sub2_dis_val As New CrystalDecisions.Shared.ParameterDiscreteValue
    '    sub2_dis_val.Value = code_no.Text  '"N"
    '    sub2_paramDefs = cryRpt.DataDefinition.ParameterFields()
    '    sub2_paramDef = sub2_paramDefs.Item("@code_no2")
    '    sub2_values = sub2_paramDef.CurrentValues

    '    Dim sub2_paramDefs2 As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinitions
    '    Dim sub2_paramDef2 As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition
    '    Dim sub2_values2 As New CrystalDecisions.Shared.ParameterValues
    '    Dim sub2_dis_val2 As New CrystalDecisions.Shared.ParameterDiscreteValue
    '    sub2_dis_val2.Value = gd_cd.Text  '"AH0002"
    '    sub2_paramDefs2 = cryRpt.DataDefinition.ParameterFields()
    '    sub2_paramDef2 = sub2_paramDefs2.Item("@gd_cd2")
    '    sub2_values2 = sub2_paramDef2.CurrentValues

    '    Dim sub2_paramDefs3 As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinitions
    '    Dim sub2_paramDef3 As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition
    '    Dim sub2_values3 As New CrystalDecisions.Shared.ParameterValues
    '    Dim sub2_dis_val3 As New CrystalDecisions.Shared.ParameterDiscreteValue
    '    sub2_dis_val3.Value = base_dt.Text '"2015-04-01 00:00:00"
    '    sub2_paramDefs3 = cryRpt.DataDefinition.ParameterFields()
    '    sub2_paramDef3 = sub2_paramDefs3.Item("@base_dt2")
    '    sub2_values3 = sub2_paramDef3.CurrentValues

    '    Dim sub2_paramDefs4 As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinitions
    '    Dim sub2_paramDef4 As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition
    '    Dim sub2_values4 As New CrystalDecisions.Shared.ParameterValues
    '    Dim sub2_dis_val4 As New CrystalDecisions.Shared.ParameterDiscreteValue
    '    sub2_dis_val4.Value = to_dt.Text '"2015-04-30 00:00:00"
    '    sub2_paramDefs4 = cryRpt.DataDefinition.ParameterFields()
    '    sub2_paramDef4 = sub2_paramDefs4.Item("@to_dt2")
    '    sub2_values4 = sub2_paramDef4.CurrentValues

    '    '하위보고서3(ETC 기타)
    '    Dim sub3_paramDefs As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinitions
    '    Dim sub3_paramDef As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition
    '    Dim sub3_values As New CrystalDecisions.Shared.ParameterValues
    '    Dim sub3_dis_val As New CrystalDecisions.Shared.ParameterDiscreteValue
    '    sub3_dis_val.Value = code_no.Text  '"N"
    '    sub3_paramDefs = cryRpt.DataDefinition.ParameterFields()
    '    sub3_paramDef = sub3_paramDefs.Item("@code_no_etc")
    '    sub3_values = sub3_paramDef.CurrentValues

    '    Dim sub3_paramDefs2 As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinitions
    '    Dim sub3_paramDef2 As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition
    '    Dim sub3_values2 As New CrystalDecisions.Shared.ParameterValues
    '    Dim sub3_dis_val2 As New CrystalDecisions.Shared.ParameterDiscreteValue
    '    sub3_dis_val2.Value = gd_cd.Text  '"AH0002"
    '    sub3_paramDefs2 = cryRpt.DataDefinition.ParameterFields()
    '    sub3_paramDef2 = sub3_paramDefs2.Item("@gd_cd_etc")
    '    sub3_values2 = sub3_paramDef2.CurrentValues

    '    Dim sub3_paramDefs3 As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinitions
    '    Dim sub3_paramDef3 As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition
    '    Dim sub3_values3 As New CrystalDecisions.Shared.ParameterValues
    '    Dim sub3_dis_val3 As New CrystalDecisions.Shared.ParameterDiscreteValue
    '    sub3_dis_val3.Value = base_dt.Text '"2015-04-01 00:00:00"
    '    sub3_paramDefs3 = cryRpt.DataDefinition.ParameterFields()
    '    sub3_paramDef3 = sub3_paramDefs3.Item("@base_dt_etc")
    '    sub3_values3 = sub3_paramDef3.CurrentValues

    '    Dim sub3_paramDefs4 As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinitions
    '    Dim sub3_paramDef4 As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition
    '    Dim sub3_values4 As New CrystalDecisions.Shared.ParameterValues
    '    Dim sub3_dis_val4 As New CrystalDecisions.Shared.ParameterDiscreteValue
    '    sub3_dis_val4.Value = to_dt.Text '"2015-04-30 00:00:00"
    '    sub3_paramDefs4 = cryRpt.DataDefinition.ParameterFields()
    '    sub3_paramDef4 = sub3_paramDefs4.Item("@to_dt_etc")
    '    sub3_values4 = sub3_paramDef4.CurrentValues

    '    '하위보고서4(JEGO 재고)
    '    Dim sub4_paramDefs As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinitions
    '    Dim sub4_paramDef As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition
    '    Dim sub4_values As New CrystalDecisions.Shared.ParameterValues
    '    Dim sub4_dis_val As New CrystalDecisions.Shared.ParameterDiscreteValue
    '    sub4_dis_val.Value = code_no.Text  '"N"
    '    sub4_paramDefs = cryRpt.DataDefinition.ParameterFields()
    '    sub4_paramDef = sub4_paramDefs.Item("@code_no_je")
    '    sub4_values = sub4_paramDef.CurrentValues

    '    Dim sub4_paramDefs2 As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinitions
    '    Dim sub4_paramDef2 As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition
    '    Dim sub4_values2 As New CrystalDecisions.Shared.ParameterValues
    '    Dim sub4_dis_val2 As New CrystalDecisions.Shared.ParameterDiscreteValue
    '    sub4_dis_val2.Value = gd_cd.Text  '"AH0002"
    '    sub4_paramDefs2 = cryRpt.DataDefinition.ParameterFields()
    '    sub4_paramDef2 = sub4_paramDefs2.Item("@gd_cd_je")
    '    sub4_values2 = sub4_paramDef2.CurrentValues

    '    Dim sub4_paramDefs3 As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinitions
    '    Dim sub4_paramDef3 As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition
    '    Dim sub4_values3 As New CrystalDecisions.Shared.ParameterValues
    '    Dim sub4_dis_val3 As New CrystalDecisions.Shared.ParameterDiscreteValue
    '    sub4_dis_val3.Value = base_dt.Text '"2015-04-01 00:00:00"
    '    sub4_paramDefs3 = cryRpt.DataDefinition.ParameterFields()
    '    sub4_paramDef3 = sub4_paramDefs3.Item("@base_dt_je")
    '    sub4_values3 = sub4_paramDef3.CurrentValues

    '    Dim sub4_paramDefs4 As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinitions
    '    Dim sub4_paramDef4 As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition
    '    Dim sub4_values4 As New CrystalDecisions.Shared.ParameterValues
    '    Dim sub4_dis_val4 As New CrystalDecisions.Shared.ParameterDiscreteValue
    '    sub4_dis_val4.Value = to_dt.Text '"2015-04-30 00:00:00"
    '    sub4_paramDefs4 = cryRpt.DataDefinition.ParameterFields()
    '    sub4_paramDef4 = sub4_paramDefs4.Item("@to_dt_je")
    '    sub4_values4 = sub4_paramDef4.CurrentValues



    '    '넣기
    '    values.Clear()

    '    '1.crParameterDiscreteValue
    '    values.Add(dis_val)
    '    values2.Add(dis_val2)
    '    values3.Add(dis_val3)
    '    values4.Add(dis_val4)

    '    sub1_values.Add(sub1_dis_val)
    '    sub1_values2.Add(sub1_dis_val2)
    '    sub1_values3.Add(sub1_dis_val3)
    '    sub1_values4.Add(sub1_dis_val4)

    '    sub2_values.Add(sub2_dis_val)
    '    sub2_values2.Add(sub2_dis_val2)
    '    sub2_values3.Add(sub2_dis_val3)
    '    sub2_values4.Add(sub2_dis_val4)

    '    sub3_values.Add(sub3_dis_val)
    '    sub3_values2.Add(sub3_dis_val2)
    '    sub3_values3.Add(sub3_dis_val3)
    '    sub3_values4.Add(sub3_dis_val4)

    '    sub4_values.Add(sub4_dis_val)
    '    sub4_values2.Add(sub4_dis_val2)
    '    sub4_values3.Add(sub4_dis_val3)
    '    sub4_values4.Add(sub4_dis_val4)


    '    '2.crParameterValues
    '    paramDef.ApplyCurrentValues(values)
    '    paramDef2.ApplyCurrentValues(values2)
    '    paramDef3.ApplyCurrentValues(values3)
    '    paramDef4.ApplyCurrentValues(values4)

    '    sub1_paramDef.ApplyCurrentValues(sub1_values)
    '    sub1_paramDef2.ApplyCurrentValues(sub1_values2)
    '    sub1_paramDef3.ApplyCurrentValues(sub1_values3)
    '    sub1_paramDef4.ApplyCurrentValues(sub1_values4)

    '    sub2_paramDef.ApplyCurrentValues(sub2_values)
    '    sub2_paramDef2.ApplyCurrentValues(sub2_values2)
    '    sub2_paramDef3.ApplyCurrentValues(sub2_values3)
    '    sub2_paramDef4.ApplyCurrentValues(sub2_values4)

    '    sub3_paramDef.ApplyCurrentValues(sub3_values)
    '    sub3_paramDef2.ApplyCurrentValues(sub3_values2)
    '    sub3_paramDef3.ApplyCurrentValues(sub3_values3)
    '    sub3_paramDef4.ApplyCurrentValues(sub3_values4)

    '    sub4_paramDef.ApplyCurrentValues(sub4_values)
    '    sub4_paramDef2.ApplyCurrentValues(sub4_values2)
    '    sub4_paramDef3.ApplyCurrentValues(sub4_values3)
    '    sub4_paramDef4.ApplyCurrentValues(sub4_values4)


    '    '3.Add(crParameterDiscreteValue)
    '    values.Clear()

    '    values.Add(dis_val)
    '    values2.Add(dis_val2)
    '    values3.Add(dis_val3)
    '    values4.Add(dis_val4)

    '    sub1_values.Add(sub1_dis_val)
    '    sub1_values2.Add(sub1_dis_val2)
    '    sub1_values3.Add(sub1_dis_val3)
    '    sub1_values4.Add(sub1_dis_val4)

    '    sub2_values.Add(sub2_dis_val)
    '    sub2_values2.Add(sub2_dis_val2)
    '    sub2_values3.Add(sub2_dis_val3)
    '    sub2_values4.Add(sub2_dis_val4)

    '    sub3_values.Add(sub3_dis_val)
    '    sub3_values2.Add(sub3_dis_val2)
    '    sub3_values3.Add(sub3_dis_val3)
    '    sub3_values4.Add(sub3_dis_val4)

    '    sub4_values.Add(sub4_dis_val)
    '    sub4_values2.Add(sub4_dis_val2)
    '    sub4_values3.Add(sub4_dis_val3)
    '    sub4_values4.Add(sub4_dis_val4)



    '    '4.ApplyCurrentValues(crParameterValues)
    '    paramDef.ApplyCurrentValues(values)
    '    paramDef2.ApplyCurrentValues(values2)
    '    paramDef3.ApplyCurrentValues(values3)
    '    paramDef4.ApplyCurrentValues(values4)

    '    sub1_paramDef.ApplyCurrentValues(sub1_values)
    '    sub1_paramDef2.ApplyCurrentValues(sub1_values2)
    '    sub1_paramDef3.ApplyCurrentValues(sub1_values3)
    '    sub1_paramDef4.ApplyCurrentValues(sub1_values4)

    '    sub2_paramDef.ApplyCurrentValues(sub2_values)
    '    sub2_paramDef2.ApplyCurrentValues(sub2_values2)
    '    sub2_paramDef3.ApplyCurrentValues(sub2_values3)
    '    sub2_paramDef4.ApplyCurrentValues(sub2_values4)

    '    sub3_paramDef.ApplyCurrentValues(sub3_values)
    '    sub3_paramDef2.ApplyCurrentValues(sub3_values2)
    '    sub3_paramDef3.ApplyCurrentValues(sub3_values3)
    '    sub3_paramDef4.ApplyCurrentValues(sub3_values4)


    '    sub4_paramDef.ApplyCurrentValues(sub4_values)
    '    sub4_paramDef2.ApplyCurrentValues(sub4_values2)
    '    sub4_paramDef3.ApplyCurrentValues(sub4_values3)
    '    sub4_paramDef4.ApplyCurrentValues(sub4_values4)


    '    cryRpt.SetDatabaseLogon("sa", "inter07@")   '데이터베이스 로그인 ("아이디","패스워드")

    '    CrystalReportViewer1.ReportSource = cryRpt
    '    CrystalReportViewer1.Refresh()
    'End Sub


    'Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
    '    Panel2.Visible = True
    '    SplitContainer2.Visible = True
    '    SplitContainer3.Visible = True
    '    SplitContainer4.Visible = True
    '    SplitContainer5.Visible = True
    '    SplitContainer6.Visible = True
    'End Sub


    '''1 TEST 
    ''Dim params As New CrystalDecisions.Shared.ParameterFields()
    ''Dim param As New CrystalDecisions.Shared.ParameterField()
    ''Dim paramvalue As New CrystalDecisions.Shared.ParameterDiscreteValue()

    '''param.ParameterFieldName = "@code_no"
    '''paramvalue.Value = "N"
    '''param.CurrentValues.Add(paramvalue)

    '''params.Add(param)
    '''CrystalReportViewer1.ParameterFieldInfo = params

    ''CrystalReportViewer1.ReportSource = "C:\Users\Administrator\Desktop\WI_DE1040_JR\WI_DE1040_JR.rpt"

    ''2.TEST
    'Dim ds As New DataSet
    'Dim t As DataTable = ds.Tables.Add("Items")
    't.Columns.Add("id", Type.GetType("System.Int32"))
    't.Columns.Add("Item", Type.GetType("System.String"))

    'Dim r As DataRow
    'Dim i As Integer
    'For i = 0 To 9
    '    r = t.NewRow()
    '    r("id") = i
    '    r("Item") = "Item" & i
    '    t.Rows.Add(r)
    'Next

    'Dim objRpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    'objRpt.SetDataSource(ds.Tables(1))
    'CrystalReportViewer1.ReportSource = objRpt
    'CrystalReportViewer1.Refresh()
    'Dim myTableLogonInfos As CrystalDecisions.Shared.TableLogOnInfos = New CrystalDecisions.Shared.TableLogOnInfos()
    'Dim myTableLogonInfo As CrystalDecisions.Shared.TableLogOnInfo = New CrystalDecisions.Shared.TableLogOnInfo()
    'Dim myConnectionInfo As CrystalDecisions.Shared.ConnectionInfo = New CrystalDecisions.Shared.ConnectionInfo()
    'With myConnectionInfo
    '    .ServerName = "192.168.2.5"
    '    .DatabaseName = "ERP_2"
    '    .UserID = "sa"
    '    .Password = "inter07@"
    'End With
    'myTableLogonInfo.ConnectionInfo = myConnectionInfo



End Class