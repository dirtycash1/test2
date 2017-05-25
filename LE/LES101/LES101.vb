Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class LES101
    Private Sub chk_lot_CheckedChanged(sender As Object, e As System.EventArgs) Handles chk_lot.CheckedChanged
        MyBase.Open()
    End Sub

    Private Sub chk_inout_CheckedChanged(sender As Object, e As System.EventArgs) Handles chk_inout.CheckedChanged
        MyBase.Open()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            'Case MenuType.Open
            '    MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
            '    '사용하려면 재정의 가능하다
            Case MenuType.Save



            Case MenuType.Print
                Dim pp As OpenParameters = New OpenParameters
                pp.Clear()
                If chk_bu.text = 1 Then

                    ' pp.Add("@lot_no", g10.Text("LOT_NO"))
                    pp.Add("@fr_dt", fr_dt.Text)
                    pp.Add("@to_dt", to_dt.Text)
                    pp.Add("@bs_cd", bs_cd.Text)
                    pp.Add("@fac_cd", fac_cd.Text)
                    pp.Add("@wh_cd", wh_cd.Text)
                    pp.Add("@itm_bc", itm_bc.Text)
                    pp.Add("@itm_cd", itm_cd.Text)
                    pp.Add("@itm_nm", itm_nm.Text)
                    pp.Add("@grp1_cd", grp1_cd.Text)
                    pp.Add("@grp2_cd", grp2_cd.Text)
                    pp.Add("@grp3_cd", grp3_cd.Text)
                    pp.Add("@model_cd", model_cd.Text)
                    pp.Add("@spec1", spec1.Text)
                    pp.Add("@lot_no", lot_no.Text)
                    pp.Add("@chk_inout", chk_inout.Text)
                    pp.Add("@chk_lot", chk_lot.Text)
                    System7.ReportView.LoadView("LES101_2", "", "LES101S_print", pp, )
                Else
                    'Dim pp As OpenParameters = New OpenParameters
                    ' pp.Add("@lot_no", g10.Text("LOT_NO"))
                    pp.Add("@fr_dt", fr_dt.Text)
                    pp.Add("@to_dt", to_dt.Text)
                    pp.Add("@bs_cd", bs_cd.Text)
                    pp.Add("@fac_cd", fac_cd.Text)
                    pp.Add("@wh_cd", wh_cd.Text)
                    pp.Add("@itm_bc", itm_bc.Text)
                    pp.Add("@itm_cd", itm_cd.Text)
                    pp.Add("@itm_nm", itm_nm.Text)
                    pp.Add("@grp1_cd", grp1_cd.Text)
                    pp.Add("@grp2_cd", grp2_cd.Text)
                    pp.Add("@grp3_cd", grp3_cd.Text)
                    pp.Add("@model_cd", model_cd.Text)
                    pp.Add("@spec1", spec1.Text)
                    pp.Add("@lot_no", lot_no.Text)
                    pp.Add("@chk_inout", chk_inout.Text)
                    pp.Add("@chk_lot", chk_lot.Text)
                    System7.ReportView.LoadView("LES101", "", "LES101S_print", pp, )
                End If
                

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

End Class
