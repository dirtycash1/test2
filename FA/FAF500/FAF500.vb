Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAF500

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.New_Form()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            'Case MenuType.Open
            '    MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
            '    '사용하려면 재정의 가능하다
            'Case MenuType.Save

            Case MenuType.New

                Me.New_Form()

            Case MenuType.Print

                Dim p As OpenParameters = New OpenParameters
                p.Add("@co_cd", co_cd.Text)
                p.Add("@div_cd", div_cd.Text)
                p.Add("@fr_dt", fr_dt.Text)
                p.Add("@to_dt", to_dt.Text)
                p.Add("@no_yn", no_yn.Text)

                System7.ReportView.LoadView("FAF500", "", "faf500_print", p) '자금일보

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Public Sub New_Form()
        Me.Open()

    End Sub

    Private Sub but1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but1.Click
        Dim p As OpenParameters = New OpenParameters
        p.Add("@co_cd", co_cd.Text)
        p.Add("@div_cd", div_cd.Text)
        p.Add("@fr_dt", fr_dt.Text)
        p.Add("@to_dt", to_dt.Text)
        p.Add("@no_yn", no_yn.Text)

        System7.ReportView.LoadView("FAF500", "", "faf500_print", p) '자금일보
    End Sub

    Private Sub but2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but2.Click
        Dim p As OpenParameters = New OpenParameters
        p.Add("@co_cd", co_cd.Text)
        p.Add("@div_cd", div_cd.Text)
        p.Add("@fr_dt", fr_dt.Text)
        p.Add("@to_dt", to_dt.Text)
        p.Add("@no_yn", no_yn.Text)

        System7.ReportView.LoadView("FAF501", "", "faf501_print", p) '자금일보
    End Sub
End Class
