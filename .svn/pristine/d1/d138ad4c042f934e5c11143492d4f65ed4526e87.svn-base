Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Functions

Public Class HRK120

    'Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    Me.New_Form()
    'End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.New_Form()
            Case MenuType.Save

                If Me.Save() Then
                    '저장후 Open하려면 반드시 저장성공시에 만 Open한다
                    Me.New_Form()
                End If

            Case MenuType.New

                bs_cd.Text = ""
                fr_dt.Text = ""
                to_dt.Text = ""
                std_dt.Text = ""
                dept_cd.Text = ""
                emp_no.Text = ""
                emp_nm.Text = ""

                Me.New_Form()

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Private Sub New_Form()
        '검색필드에 “” 를  설정(검색되지않는 조건)하고 Open()
        MyBase.Open("HRK120_g10")

        'Grid에 신규행을 추가 -> Group 컬럼이 있는 상태에서 추가는 의미없음(어떤그룹 밑에 추가행이 생길지 모름)
        g10.AddNewRow()

    End Sub

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        If ColumnName = "fr_dt" Or ColumnName = "to_dt" Then
            With g10
                If .Text("fr_dt") = Nothing Or .Text("to_dt") = Nothing Then
                    .Text("work_year") = 0
                    .Text("work_month") = 0
                Else
                    Dim WorkYear As Integer = DateDiff(DateInterval.Year, CDate(.Text("fr_dt")), CDate(.Text("to_dt"))) - 1
                    Dim WorkMonth As Integer = DateDiff(DateInterval.Month, CDate(.Text("fr_dt")), CDate(.Text("to_dt")))

                    If WorkYear < 0 Then WorkYear = 0

                    .Text("work_year") = WorkYear
                    .Text("work_month") = WorkMonth - (WorkYear * 12)

                    If .Text("work_month") >= 12 Then
                        .Text("work_year") = .Text("work_year") + 1
                        .Text("work_month") = .Text("work_month") - 12
                    End If


                End If

            End With

        End If

    End Sub
End Class
