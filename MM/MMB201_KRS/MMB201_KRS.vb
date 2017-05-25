Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Parameter

Public Class MMB201_KRS

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Parameter.Login.UserKd = "SC700300" Then cust_cd.Enabled = False '외주사용자
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            'Case MenuType.Open
            '    MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
            '    '사용하려면 재정의 가능하다
            'Case MenuType.Save
            Case MenuType.Print
                Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    'Public Sub New_Form()
    '    Me.Open()

    'End Sub



    Private Sub g10_DoubleClick(sender As Object, e As System.EventArgs) Handles g10.DoubleClick
        Dim menuName As String = "MMB200_KRS"
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
        ctr.Open2(g10.Text("dlv_no"), g10.Text("dlv_dt"))
    End Sub

    Private Sub btn_prt_Click(sender As System.Object, e As System.EventArgs) Handles btn_prt.Click
        Print2

    End Sub

    Private Sub Print()

        If g10.RowCount <= 0 Then Exit Sub
        Dim p As OpenParameters = New OpenParameters
        p.Add("@dlv_no", g10.Text("dlv_no"))

        System7.ReportView.LoadView("MMB200", "", "MMB200_KRS_Print", p) '거래명세표
        System7.ReportView.LoadView("MMB200_2", "", "MMB200_KRS_Print2", p) '부품식별표

    End Sub

    Private Sub Print2()

        If g10.RowCount <= 0 Then Exit Sub
        Dim p As OpenParameters = New OpenParameters
        p.Add("@dlv_no", g10.Text("dlv_no"))
        p.Add("@dlv_sq", g10.Text("dlv_sq"))
        System7.ReportView.LoadView("MMB200_3", "", "MMB200_KRS_Print3", p) '부품식별표

    End Sub
End Class
