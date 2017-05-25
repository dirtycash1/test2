Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_SA1320

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

    'Public Sub New_Form()
    '    Me.Open()

    'End Sub

    Private Sub btn_rate_Click(sender As Object, e As System.EventArgs) Handles btn_rate.Click
        If MessageYesNo("할인율 일괄 적용 하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        Else
            Dim p As New OpenParameters
            p.Clear()
            p.Add("@from_dt", find_from.Text)
            p.Add("@to_dt", find_to.Text)
            p.Add("@cs_cd", find_cs_cd.Text)

            Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1320_rate", p)
            Dim stts As String = "Y"

            If Not IsEmpty(dSet) Then stts = DataValue(dSet)
        End If

    End Sub

    Private Sub btn_rate2_Click(sender As System.Object, e As System.EventArgs) Handles btn_rate2.Click
        If MessageYesNo("할인율 일괄 적용 하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        Else
            Dim p As New OpenParameters
            p.Clear()
            p.Add("@from_dt", find_from.Text)
            p.Add("@to_dt", find_to.Text)
            p.Add("@cs_cd", find_cs_cd.Text)
            p.Add("@ot_gu", find_ot_gu.Text)  '추가
            p.Add("@od_gu", find_od_gu.Text)  '추가

            Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1320_rate2", p)
            Dim stts As String = "Y"

            If Not IsEmpty(dSet) Then stts = DataValue(dSet)
        End If
    End Sub
End Class
