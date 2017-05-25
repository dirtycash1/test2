Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_PR1520
    Dim p As New OpenParameters

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

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub btn_find_Click(sender As System.Object, e As System.EventArgs) Handles btn_find.Click

        If find_ym.Text = "" Then
            MsgBox("계획년월을 확인하세요.!")
            Return
        End If

        'If aply_rate.Text = "" Or aply_rate.Text = "0" Then
        '    MsgBox("적용배수를 확인하세요.!")
        '    Return
        'End If

        If MessageYesNo("생산계획을 생성 하시겠습니까?") = MsgBoxResult.No Then Exit Sub
        p.Clear()
        p.Add("@find_ym", find_ym.Text)
        p.Add("@find_model_no", find_model_no.Text)
        p.Add("@find_nm_cd", find_nm_cd.Text)

        Me.Open("WI_PR1520_insert", p)

        g_multi.Open()

    End Sub

    Private Sub g_multi_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g_multi.CellValueChanged
        If ColumnName = "SA_QTY" Or ColumnName = "TR_QTY" Then
            With g_multi
                .Text("TOT_QTY", .RowIndex) = .ToDec("SA_QTY", .RowIndex) + .ToDec("TR_QTY", .RowIndex)
                .Text("PLAN_QTY", .RowIndex) = .ToDec("TOT_QTY", .RowIndex) + .ToDec("OT_QTY", .RowIndex) - .ToDec("STOCK_QTY", .RowIndex) - .ToDec("PR_QTY", .RowIndex)
                If .ToDec("PLAN_QTY", .RowIndex) < 0 Then
                    .Text("PLAN_QTY", .RowIndex) = "0"
                End If
            End With
        End If

    End Sub
End Class
