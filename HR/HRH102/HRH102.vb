Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Functions

Public Class HRH102

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Open()
        'New_Form()
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

    Private Sub New_Form()
        '검색필드에 “” 를  설정(검색되지않는 조건)하고 Open()
        'MyBase.Open("gat100_g10")

        'Grid에 신규행을 추가 -> Group 컬럼이 있는 상태에서 추가는 의미없음(어떤그룹 밑에 추가행이 생길지 모름)
        'g10.AddNewRow()
        'g10.Find("")
    End Sub



    ''그룹웨어 연동
    'Private Sub go_gw_Click(sender As System.Object, e As System.EventArgs) Handles go_gw.Click
    '    Dim chkct As Integer = 0
    '    Dim p As New OpenParameters

    '    For i = 0 To g10.RowCount - 1
    '        If g10.Text("chk", i) = "1" Then
    '            chkct = chkct + 1

    '            p.Clear()
    '            p.Add("@doc_no", g10.Text("doc_no", i))
    '            Me.OpenDataSet("hrh102_receipt", p)

    '        End If
    '    Next
    '    If chkct < 1 Then
    '        MessageInfo("선택된 행이 없습니다.")
    '    End If

    '    Me.Open()

    'End Sub



    Private Sub g10_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged

        Dim chk As Integer = 0
        For i = 0 To g10.RowCount - 1
            If g10.Text("chk", i) = "1" Then
                chk = chk + 1
            End If
        Next

        If chk > 1 Then
            MessageInfo("하나만 선택해주세요.")
            g10.Text("chk", RowIndex) = ""
            Exit Sub
        End If
    End Sub

End Class
