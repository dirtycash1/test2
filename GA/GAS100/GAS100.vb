Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Functions

Public Class GAS100

    'Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    Me.New_Form()
    '    pay_year.Text = Now().Year
    'End Sub
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.New_Form()
            Case MenuType.Save

                Me.Save()
                Me.Open()

            Case MenuType.New
                pay_year.Text = Now().Year
                'pay_bc.Text = ""
                emp_no.Text = ""
                emp_nm.Text = ""
                dept_cd.Text = ""


                Me.New_Form()


            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Private Sub New_Form()
        '검색필드에 “” 를  설정(검색되지않는 조건)하고 Open()
        MyBase.Open("gas100_g10")

        'Grid에 신규행을 추가
        g10.AddNewRow()

    End Sub



End Class
