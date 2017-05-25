Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Functions
Imports System.Data

Public Class FAF301

    'Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    Me.New_Form()
    'End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            'Case MenuType.Open
            '    MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
            '    '사용하려면 재정의 가능하다
            'Case MenuType.Save

            'Case MenuType.New
            '    cust_cd.Text = ""
            '    itm_cd.Text = ""
            '    itm_nm.Text = ""
            '    emp_id.Text = ""
            '    emp_nm.Text = ""

            '    Me.New_Form()

            Case MenuType.Print
                Me.print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    'Public Sub New_Form()
    '    Me.Open()

    'End Sub

    Private Sub btn_save_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_save.Click

        If MessageYesNo("실행하시겠습니까?", "경고!!") = MsgBoxResult.No Then
            Exit Sub
        End If

        Me.Save()
        Me.Open()

    End Sub

    Public Sub print()
        Dim p As OpenParameters = New OpenParameters

        p.Add("@co_cd", co_cd.Text)
        p.Add("@plan_mon", plan_mon.Text)
        p.Add("@reg_id", 0)

        'System7.ReportView.LoadView("FAF301", "", "faf301_g10", p) '주간자금계획 출력

        Dim dSet As DataSet = Me.OpenDataSet("faf301_print")

        If IsEmpty(dSet) Then

            System7.ReportView.LoadView("FAF301", "", "faf301_g10", p) '주간자금계획 출력
           
        Else
            System7.ReportView.LoadView("FAF302", "", "faf301_g10", p) '주간자금계획 출력2


        End If

    End Sub


End Class
