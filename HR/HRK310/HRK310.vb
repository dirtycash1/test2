Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Functions

Public Class HRK310


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

                fr_dt.Text = ""
                to_dt.Text = ""
                fr1_dt.Text = ""
                to1_dt.Text = ""
                dept_cd.Text = ""
                emp_no.Text = ""
                emp_nm.Text = ""
                event_bc.Text = ""
                chk.Text = "1"

                Me.New_Form()

            Case MenuType.Print
                Me.print()


            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Private Sub New_Form()
        '검색필드에 “” 를  설정(검색되지않는 조건)하고 Open()
        MyBase.Open("HRK310_g10")

        'Grid에 신규행을 추가 -> Group 컬럼이 있는 상태에서 추가는 의미없음(어떤그룹 밑에 추가행이 생길지 모름)
        g10.AddNewRow()

    End Sub

    Private Sub print()
        Dim p As OpenParameters = New OpenParameters

        p.Add("@chk", chk.Text)
        p.Add("@co_cd", co_cd.Text)
        p.Add("@bs_cd", bs_cd.Text)
        p.Add("@event_bc", event_bc.Text)
        p.Add("@dept_cd", dept_cd.Text)
        p.Add("@emp_no", emp_no.Text)
        p.Add("@emp_nm", emp_nm.Text)
        p.Add("@fr_dt", fr_dt.Text)
        p.Add("@to_dt", to_dt.Text)
        p.Add("@fr1_dt", fr1_dt.Text)
        p.Add("@to1_dt", to1_dt.Text)
        p.Add("@std_year", Now.Year)
    

        System7.ReportView.LoadView("HRK310", "", "hrk310_print", p) '경조사출력

    End Sub

End Class
