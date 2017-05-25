Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class BCV700

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.Open("bcv700_g10")

        EPanel1.SetSplitter(SplitContainer1, SplitContainer1.Panel2)
        EPanel2.SetSplitter(SplitContainer1, SplitContainer1.Panel1)

        Me.New_Form()

        'XtraTabControl2.SelectedTabPageIndex = 1
        'XtraTabControl2.SelectedTabPageIndex = 0

        AddHandler Me.WorkSet("bcv700_f10").AfterOpen, AddressOf CheckFields

        g20.RecordNavigator = True
        g30.RecordNavigator = True
        g40.RecordNavigator = True
        g50.RecordNavigator = True
        g60.RecordNavigator = True
        g70.RecordNavigator = True

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            'Case MenuType.Open
            '    Me.Open()


            Case MenuType.Save
                If Not Check_Save() Then
                    Exit Sub
                End If
                If MyBase.Save() Then
                    MyBase.OpenTrigger("bcv700_g10")
                End If

            Case MenuType.New
                New_Form()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub CheckFields(ByVal wSet As Frame7.WorkSet)
        cust_cd.ReadOnly = True
        cust_nm.ReadOnly = True
        cust_enm.ReadOnly = True
        prt_nm.ReadOnly = True

        biz_no.ReadOnly = True
        ceo_nm.ReadOnly = True
        biz_type.ReadOnly = True
        biz_kind.ReadOnly = True
        addr_prt.ReadOnly = True
        f_zip_cd.ReadOnly = True
        'reg_no.ReadOnly = True
        license_no.ReadOnly = True
        sale_emp.ReadOnly = True
    End Sub


    Private Sub New_Form()
        cust_cd.Text = ""
        Me.OpenTrigger("bcv700_g10")

        cust_cd.ReadOnly = False
        cust_nm.ReadOnly = False
        cust_enm.ReadOnly = False
        prt_nm.ReadOnly = False

        biz_no.ReadOnly = False
        ceo_nm.ReadOnly = False
        biz_type.ReadOnly = False
        biz_kind.ReadOnly = False
        addr_prt.ReadOnly = False
        f_zip_cd.ReadOnly = False
        reg_no.ReadOnly = False
        license_no.ReadOnly = False
        sale_emp.ReadOnly = False

    End Sub

    Private Sub chk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_open.Click

        Me.Open()

    End Sub

    Private Function Check_Save() As Boolean

        ' 업데이트 시 사업자 등록 번호 체크 임시 해제... 11/21 이재만부장님요청
        'If Not Me.Check_BizNo() Then
        '    Return False
        'End If
        If sal_yn.Checked Then
            If Not CheckRequired(de_bc, tax_bc) Then
                Return False
            End If
        End If
        If pur_yn.Checked Then
            If Not CheckRequired(di_bc) Then
                Return False
            End If
        End If
        Return True
    End Function


    Private Function Check_BizNo() As Boolean
        Try
            Dim custNm As String, custCd As String
            If biz_no.Text = "" Then
                biz_no.Focus()
                Return True
            End If

            Dim p As OpenParameters = New OpenParameters
            Dim bizNo As String = biz_no.Text.Replace("-", "").Replace(" ", "")
            p.Add("@biz_no", bizNo)
            p.Add("@cust_cd", cust_cd.Text)
            Dim dSet As DataSet = OpenDataSet("bcv700_check_bizno", p)

            If Not IsEmpty(dSet) Then
                custCd = DataValue(dSet, "cust_cd")
                custNm = DataValue(dSet, "cust_nm")
                MessageInfo(" 이미 등록된 사업자번호입니다 [거래처코드 : " + custCd + " : " + custNm + "]")
                biz_no.Text = ""
                Return False
            End If

            Return True

        Catch ex As Exception
            MessageInfo(ex)
        End Try
    End Function



    Private Sub check_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles check.Click
        If biz_no.Text = "" Then
            biz_no.Focus()
            Exit Sub
        End If
        If Me.Check_BizNo() Then
            MessageInfo("OK")
        End If
    End Sub
    Private Function Check_RegNo() As Boolean
        Try
            Dim custNm As String, custCd As String
            If reg_no.Text = "" Then
                reg_no.Focus()
                Return True
            End If

            Dim p As OpenParameters = New OpenParameters
            Dim bizNo As String = reg_no.Text.Replace("-", "").Replace(" ", "")
            p.Add("@reg_no", bizNo)
            p.Add("@cust_cd", cust_cd.Text)
            Dim dSet As DataSet = OpenDataSet("bcv700_check_reg_no", p)

            If Not IsEmpty(dSet) Then
                custCd = DataValue(dSet, "cust_cd")
                custNm = DataValue(dSet, "cust_nm")
                MessageInfo(" 이미 등록된 주민번호입니다 [거래처코드 : " + custCd + " : " + custNm + "]")
                Return False
            End If

            Return True

        Catch ex As Exception
            MessageInfo(ex)
        End Try
    End Function

    Private Sub check_reg_Click(sender As System.Object, e As System.EventArgs) Handles check_reg.Click
        If reg_no.Text = "" Then
            reg_no.Focus()
            Exit Sub
        End If
        If Me.Check_RegNo() Then
            MessageInfo("OK")
        End If
    End Sub
    Private Function Check_LicNo() As Boolean
        Try
            Dim custNm As String, custCd As String
            If license_no.Text = "" Then
                license_no.Focus()
                Return True
            End If

            Dim p As OpenParameters = New OpenParameters
            Dim bizNo As String = license_no.Text.Replace("-", "").Replace(" ", "")
            p.Add("@license_no", bizNo)
            p.Add("@cust_cd", cust_cd.Text)
            Dim dSet As DataSet = OpenDataSet("bcv700_check_license_no", p)

            If Not IsEmpty(dSet) Then
                custCd = DataValue(dSet, "cust_cd")
                custNm = DataValue(dSet, "cust_nm")
                MessageInfo(" 이미 등록된 면허번호입니다 [거래처코드 : " + custCd + " : " + custNm + "]")
                Return False
            End If

            Return True

        Catch ex As Exception
            MessageInfo(ex)
        End Try
    End Function
    Private Sub check_lic_Click(sender As System.Object, e As System.EventArgs) Handles check_lic.Click
        If license_no.Text = "" Then
            license_no.Focus()
            Exit Sub
        End If
        If Me.Check_LicNo() Then
            MessageInfo("OK")
        End If
    End Sub
    Private Sub reg_no_TextChanged(sender As Object, oldValue As String) Handles reg_no.TextChanged
        If cust_nm.Text <> "" AndAlso prt_nm.Text = "" Then
            prt_nm.Text = cust_nm.Text
        End If
    End Sub
    Private Sub cust_nm_TextChanged(ByVal sender As Object, ByVal oldValue As String) Handles cust_nm.TextChanged
        If cust_nm.Text <> "" AndAlso prt_nm.Text = "" Then
            prt_nm.Text = cust_nm.Text
        End If
    End Sub

    Private Sub addr1_TextChanged(ByVal sender As Object, ByVal oldValue As String) Handles addr1.TextChanged
        If addr1.Text <> "" AndAlso addr_prt.Text = "" Then
            addr_prt.Text = addr1.Text
        End If
    End Sub

    Private Sub addr_prt_TextChanged(ByVal sender As Object, ByVal oldValue As String) Handles addr_prt.TextChanged
        If addr_prt.Text <> "" AndAlso addr1.Text = "" Then
            addr1.Text = addr_prt.Text
        End If
    End Sub

    Private Sub sal_yn_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sal_yn.CheckedChanged
        If sal_yn.Checked Then
            If de_bc.Text = "" Then de_bc.SelectedIndex = 0
            If tax_bc.Text = "" Then tax_bc.SelectedIndex = 0
            If sal_cust.Text = "" Then sal_cust.Text = cust_cd.Text
        End If
    End Sub

    Private Sub pur_yn_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles pur_yn.CheckedChanged
        If pur_yn.Checked Then
            If di_bc.Text = "" Then di_bc.SelectedIndex = 0
            If pur_cust.Text = "" Then pur_cust.Text = cust_cd.Text
        End If
    End Sub
   

    Private Sub pri_yn_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles pri_yn.CheckedChanged

    End Sub

    Private Sub use_yn_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles use_yn.CheckedChanged

    End Sub
End Class
