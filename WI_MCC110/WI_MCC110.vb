Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_MCC110

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
            Case MenuType.Print
                prints()
            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub
    Public Sub prints()
        Dim p As OpenParameters = New OpenParameters
        p.Add("@fr_dt", fr_dt.Text)
        p.Add("@to_dt", to_dt.Text)
        p.Add("@lot_no", LOT_NO.Text)
        p.Add("@mc_no", MC_NO.Text)
        p.Add("@mc_cd", MC_CD.Text)
        p.Add("@gd_cd", GD_CD.Text)
        p.Add("@fac_cd", FAC_CD.Text)
        'If lot_no.Text <> "" And stts.Text = "C" Then
        System7.ReportView.LoadView("WI_MCC110", "", "wi_mcc110_gprint", p, )

        'Else
    End Sub

    'Public Sub New_Form()
    '    Me.Open()

    'End Sub


End Class
