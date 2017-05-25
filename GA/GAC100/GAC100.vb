Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Functions

Public Class GAC100

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        New_Form()
    End Sub
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                New_Form()
            Case MenuType.Save

                If Me.Save() Then
                    New_Form()
                End If

            Case MenuType.New
                emp_no.Text = ""
                emp_nm.Text = ""
                'fr_dt.Text = ""
                to_dt.Text = ""
                'dept_cd.Text = ""
                'dept_nm.Text = ""
                doc_bc.Text = ""

                New_Form()


            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub


    Private Sub New_Form()
        '검색필드에 “” 를  설정(검색되지않는 조건)하고 Open()
        MyBase.Open("GAC100_g10")

        'Grid에 신규행을 추가 -> Group 컬럼이 있는 상태에서 추가는 의미없음(어떤그룹 밑에 추가행이 생길지 모름)
        g10.AddNewRow()

    End Sub

End Class
