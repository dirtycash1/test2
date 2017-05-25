Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_MD1000

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Open()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            'Case MenuType.Open
            '    MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
            '    '사용하려면 재정의 가능하다
            Case MenuType.Save

                If Me.Save() Then
                    Me.Open()
                End If
                'Case MenuType.New
                '    cust_cd.Text = ""
                '    itm_cd.Text = ""
                '    itm_nm.Text = ""
                '    emp_id.Text = ""
                '    emp_nm.Text = ""

                '    Me.New_Form()
                'Case MenuType.Print
                '    prints()
            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub
    'Public Sub prints()
    '    Dim p As OpenParameters = New OpenParameters
    '    '   p.Add("@in_no", in_no.Text)
    '    'If lot_no.Text <> "" And stts.Text = "C" Then
    '    System7.ReportView.LoadView("LEA130", "", "LEA130_print", p, )

    '    ' Else
    'End Sub
    Private Sub g_body_ButtonPressed(sender As Object, columnName As String) Handles g_multi.ButtonPressed
        If columnName = "CHK" Then
            ' If Me.Save() Then
            'Dim str As Integer
            'Str = CInt(Mid(g_multi.Text("mc_cd"), 3, 4))


            If ("8" = g_multi.Text("CORE_CNT")) Then
                Dim pp As OpenParameters = New OpenParameters
                pp.Add("@md_no", g_multi.Text("md_no"))
                System7.ReportView.LoadView("WI_MD1000R", "", "wi_md1000_print", pp)
            ElseIf ("16" = g_multi.Text("CORE_CNT")) Then
                Dim pp As OpenParameters = New OpenParameters
                pp.Add("@md_no", g_multi.Text("md_no"))
                System7.ReportView.LoadView("WI_MD1000R2", "", "wi_md1000_print2", pp)
            Else
                MsgBox("코어등록이 잘못 되었습니다.")

            End If


            'End If
        End If
    End Sub

    'Public Sub New_Form()
    '    Me.Open()

    'End Sub


    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        Dim pp As OpenParameters = New OpenParameters
        
        With g_multi
            For Row As Integer = 0 To g_multi.RowCount - 1

                If g_multi.Text("CHK2", Row) = "1" Then

                    If (9 > CInt(Mid(g_multi.Text("mc_cd"), 3, 4))) Then
                        pp.Add("@md_no", g_multi.Text("md_no"))
                        System7.ReportView.LoadView("WI_MD1000R", "", "wi_md1000_print", pp, , False)
                    Else
                        pp.Add("@md_no", g_multi.Text("md_no"))
                        System7.ReportView.LoadView("WI_MD1000R2", "", "wi_md1000_print2", pp, , False)

                    End If

                End If
            Next
        End With
    End Sub

    Private Sub all_chk_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles all_chk.CheckedChanged
        g_multi.CheckRows("CHK2", all_chk.Checked)
    End Sub
End Class
