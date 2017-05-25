'Imports System.Windows.Forms.LinkLabel
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




Public Class WI_SA1134

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty
            'Case MenuType.Print
            '    Me.Print()
            Case MenuType.Open
                Retrieve()

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub


    Private Sub Retrieve()
        Dim p As OpenParameters = New OpenParameters
        'Dim p2 As OpenParameters = New OpenParameters

        p.Clear()
        p.Add("@start_dt", start_dt.Text)
        p.Add("@end_dt", end_dt.Text)

        p.Add("@cs_cd", cs_cd.Text)
        p.Add("@ps_cd", ps_cd.Text)

        Me.Open("wi_sa1134_g10", p)


    End Sub


    '작성완료 버튼 눌렀을때
    Private Sub btn_set_Click(sender As System.Object, e As System.EventArgs) Handles btn_set.Click

        save_ing.Visible = True
        save_end.Visible = False

        Dim p As OpenParameters = New OpenParameters
        Dim p2 As OpenParameters = New OpenParameters


        With g10  'SATR1134 INSERT 
            For Row As Integer = 0 To g10.RowCount - 1
                If g10.Text("chk", Row) = "1" Then

                    '판매단가변동내역
                    p.Add("@fr_dt", start_dt.Text)
                    p.Add("@to_dt", end_dt.Text)
                    p.Add("@cs_cd", g10.Text("CS_CD", Row))


                    '위탁내역
                    p2.Add("@fr_dt", start_dt.Text)
                    p2.Add("@to_dt", end_dt.Text)
                    p2.Add("@cs_cd", g10.Text("CS_CD", Row))

                    'System7.ReportView.LoadView("WI_SA1134", "", "wi_sa1134_print", p, Nothing, True, 1)

                    'Me.OpenDataSet("wi_sa1134_print", p)
                    System7.ReportView.LoadView("WI_SA1134", "", "wi_sa1134_print", p, Nothing, True, 1, "sub", "wi_sa1134_print2", p2)
                    'System7.ReportView.LoadView("WP_SA1285", "", "wp_sa1285_print", p, Nothing, True, 1, "sub", "wp_sa1285_print2", p2)


                End If

            Next
        End With


        save_ing.Visible = False
        save_end.Visible = True


    End Sub


    'Private Sub PRINT()

    '    save_ing.Visible = True
    '    save_end.Visible = False


    '    Dim p As OpenParameters = New OpenParameters


    '    With g10
    '        For Row As Integer = 0 To g10.RowCount - 1
    '            p.Add("@cs_cd", g10.Text("CS_CD", Row))

    '            If g10.Text("chk", Row) = "1" And (g10.Text("ROW_NO", Row) = "1" Or g10.Text("ROW_NO", Row) = "2") Then
    '                p.Add("@std_dt", Today)
    '                System7.ReportView.LoadView("WI_SA1134", "", "wi_sa1133_print", p, Nothing, True, 1, "WI_SA1133_SUB", "wi_sa1133_print", p)
    '            End If


    '        Next

    '    End With

    '    save_ing.Visible = False
    '    save_end.Visible = True

    'End Sub

    Private Sub all_chk_CheckedChanged(sender As Object, e As EventArgs) Handles all_chk.CheckedChanged
        g10.CheckRows("chk", all_chk.Checked)
    End Sub

    Private Sub WI_SA1134_Load(sender As Object, e As EventArgs) Handles Me.Load
        save_ing.Visible = False
        save_end.Visible = False
    End Sub








    'Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
    '    Dim p As OpenParameters = New OpenParameters
    '    p.Clear()

    '    With g10
    '        For Row As Integer = 0 To g10.RowCount - 1

    '            If g10.Text("chk", Row) = "1" Then
    '                p.Add("@std_dt", "2016-11-15")
    '                p.Add("@cs_cd", g10.Text("CS_CD", Row))


    '            End If

    '        Next

    '        WI_SA1134.ReportView.LoadView("WI_SA1134", "", "wi_sa1133_print", p, Nothing, True, 1, "WI_SA1133_SUB", "wi_sa1133_print", p)
    '        '        WI_SA1134.ReportView.LoadView("WI_SA1134", "", "wp_sa1285_print", p)

    ''With g10
    ''    For Row As Integer = 0 To g10.RowCount - 1

    ''        If g10.Text("chk", Row) = "1" Then
    ''            p.Add("@G_END", "2")

    ''        End If

    ''        'WI_SA1134.ReportView.LoadView("WI_SA1134", "", "wp_sa1285_print", p, Nothing, False, 1, "sub", "wp_sa1285_print2", p2)
    ''        WI_SA1134.ReportView.LoadView("WI_SA1134", "", "wp_sa1285_print", p)
    ''    Next
    ''End With

    '    End With
    'End Sub


    ' Private Sub Max_NO()
    ' REG_NO 번호 채번
    'With g10  'SATR1133 INSERT 

    'For Row As Integer = 0 To g10.RowCount - 1
    '    REG_NO.CodeNo = "WI_SA1134"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
    '    'g10.Text("REG_NO", Row).CodeDateField = REG_DT
    'Next
    'End With

    ' End Sub


End Class

