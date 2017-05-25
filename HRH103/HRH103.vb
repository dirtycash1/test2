Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class HRH103

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Open()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            'Case MenuType.Open
            '    New_Form()
            Case MenuType.Save

                If Me.Save() Then
                    Me.Open()
                    'New_Form()
                End If

                'Case MenuType.New
                '    'bs_cd.Text = ""
                '    emp_no.Text = ""
                '    emp_nm.Text = ""
                '    'fr_dt.Text = ""
                '    'to_dt.Text = ""
                '    'dept_cd.Text = ""

                '    New_Form()


            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub
    Public Sub prints()
        Dim p As OpenParameters = New OpenParameters
        ' p.Add("@in_no", in_no.Text)
        'If lot_no.Text <> "" And stts.Text = "C" Then
        'HRH103.ReportView.LoadView("LEA130", "", "LEA130_print", p, )

        'Else
    End Sub

    'Public Sub New_Form()
    '    Me.Open()

    'End Sub


    Private Sub btn_ok_Click(sender As System.Object, e As System.EventArgs) Handles btn_ok.Click
        Dim chkct As Integer = 0
        Dim p As New OpenParameters

        For i = 0 To g_multi.RowCount - 1
            If g_multi.Text("chk", i) = "1" Then
                chkct = chkct + 1

                p.Clear()
                p.Add("@doc_no", g_multi.Text("doc_no", i))
                Me.OpenDataSet("hrh103_receipt", p)

            End If
        Next
        If chkct < 1 Then
            MessageInfo("선택된 행이 없습니다.")
        End If

        Me.Open()
    End Sub

    Private Sub g_multi_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g_multi.CellValueChanged

        Dim chk As Integer = 0
        For i = 0 To g_multi.RowCount - 1
            If g_multi.Text("chk", i) = "1" Then
                chk = chk + 1
            End If
        Next

        If chk > 1 Then
            MessageInfo("하나만 선택해주세요.")
            g_multi.Text("chk", RowIndex) = ""
            Exit Sub
        End If
    End Sub
End Class
