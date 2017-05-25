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


Public Class WI_SA1133
    Dim p As New OpenParameters
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
        p.Clear()
        p.Add("@start_dt", start_dt.Text)
        p.Add("@end_dt", end_dt.Text)
        p.Add("@fr_dt", fr_dt.Text)
        p.Add("@to_dt", to_dt.Text)
        p.Add("@cs_cd", cs_cd.Text)
        p.Add("@ps_nm", ps_nm.Text)
        p.Add("@sign_all", sign_all.Text)

        If sign_yn.Text = "1" Then   '이미 출력된 데이터 조회시, 
            p.Add("@sign_yn", "Y")
        Else
            p.Add("@sign_yn", "N")
        End If

        Me.Open("wi_sa1133_g10", p)


    End Sub


    '작성완료 버튼 눌렀을때
    Private Sub btn_set_Click(sender As System.Object, e As System.EventArgs) Handles btn_set.Click

        'Max_NO()

        Dim p As OpenParameters = New OpenParameters
        p.Clear()

        Dim p2 As OpenParameters = New OpenParameters
        p2.Clear()

        'If sign_yn.Text = "0" Then   '미출력된 데이터 조회시, satr1133 데이터저장까지 해야함.

        With g10  'SATR1133 INSERT 
            For Row As Integer = 0 To g10.RowCount - 1
                If g10.Text("chk", Row) = "1" Then
                    p.Add("@start_dt", start_dt.Text)
                    p.Add("@end_dt", end_dt.Text)
                    p.Add("@fr_dt", fr_dt.Text)
                    p.Add("@to_dt", to_dt.Text)
                    p.Add("@ps_nm", ps_nm.Text)
                    p.Add("@cs_cd", g10.Text("CS_CD", Row))
                    p.Add("@gd_nm", g10.Text("GD_NM", Row))
                    p.Add("@sign_yn", g10.Text("SIGN_YN", Row))
                    'p.Add("@REG_NO", REG_NO.Text)

                    Me.OpenDataSet("wi_sa1133_update", p)
                End If

            Next
        End With


        'Else
        ' End If


        PRINT()


    End Sub


    Private Sub PRINT()

        save_ing.Visible = True
        save_end.Visible = False


        Dim p As OpenParameters = New OpenParameters
        'p.Clear()


        With g10
            For Row As Integer = 0 To g10.RowCount - 1
                p.Add("@cs_cd", g10.Text("CS_CD", Row))

                If g10.Text("chk", Row) = "1" And (g10.Text("ROW_NO", Row) = "1" Or g10.Text("ROW_NO", Row) = "2") Then
                    p.Add("@std_dt", Today)
                    System7.ReportView.LoadView("WI_SA1133", "", "wi_sa1133_print", p, Nothing, True, 1, "WI_SA1133_SUB", "wi_sa1133_print", p)
                End If


                'If g10.Text("chk", Row) = "1" Then
                '    p.Add("@std_dt", Today)
                '    System7.ReportView.LoadView("WI_SA1133", "", "wi_sa1133_print", p, Nothing, True, 1, "WI_SA1133_SUB", "wi_sa1133_print", p)
                'End If


                'If sign_yn.Text = "0" Then   '출력도,작성도 되지 않았을때
                '    'p.Add("@print_yn", "N")

                '    '작성에 체크된 데이터 & 같은거래처의 첫번째 데이터만 출력& 기초화면(출력,작성되지 않았을때)
                '    If g10.Text("chk", Row) = "1" And (g10.Text("ROW_NO", Row) = "1" Or g10.Text("ROW_NO", Row) = "2") Then
                '        p.Add("@std_dt", Today)
                '        System7.ReportView.LoadView("WI_SA1133", "", "wi_sa1133_print", p, Nothing, True, 1, "WI_SA1133_SUB", "wi_sa1133_print", p)
                '    End If


                'Else  '출력도, 작성도 이미 다 되었을때 
                '    'p.Add("@print_yn", "Y")

                '    If g10.Text("chk", Row) = "1" And g10.Text("ROW_NO", Row) = "1" Then
                '        p.Add("@std_dt", Today)
                '        System7.ReportView.LoadView("WI_SA1133", "", "wi_sa1133_print", p, Nothing, True, 1, "WI_SA1133_SUB", "wi_sa1133_print", p)
                '    End If

                'End If


            Next

        End With

        save_ing.Visible = False
        save_end.Visible = True

    End Sub

    Private Sub all_chk_CheckedChanged(sender As Object, e As EventArgs) Handles all_chk.CheckedChanged
        g10.CheckRows("chk", all_chk.Checked)
    End Sub

    Private Sub WI_SA1133_Load(sender As Object, e As EventArgs) Handles Me.Load
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

    '        System7.ReportView.LoadView("WI_SA1133", "", "wi_sa1133_print", p, Nothing, True, 1, "WI_SA1133_SUB", "wi_sa1133_print", p)
    '        '        System7.ReportView.LoadView("WI_SA1133", "", "wp_sa1285_print", p)

    ''With g10
    ''    For Row As Integer = 0 To g10.RowCount - 1

    ''        If g10.Text("chk", Row) = "1" Then
    ''            p.Add("@G_END", "2")

    ''        End If

    ''        'System7.ReportView.LoadView("WI_SA1133", "", "wp_sa1285_print", p, Nothing, False, 1, "sub", "wp_sa1285_print2", p2)
    ''        System7.ReportView.LoadView("WI_SA1133", "", "wp_sa1285_print", p)
    ''    Next
    ''End With

    '    End With
    'End Sub


    ' Private Sub Max_NO()
    ' REG_NO 번호 채번
    'With g10  'SATR1133 INSERT 

    'For Row As Integer = 0 To g10.RowCount - 1
    '    REG_NO.CodeNo = "WI_SA1133"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
    '    'g10.Text("REG_NO", Row).CodeDateField = REG_DT
    'Next
    'End With

    ' End Sub


End Class

