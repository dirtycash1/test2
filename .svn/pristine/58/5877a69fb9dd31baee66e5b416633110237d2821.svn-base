Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class PMA100

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private oldPeriod As Integer = 0

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        img.Visible = False
        Me.SplitContainer2.SplitterDistance = 40
        Me.fac_id.CodeNo = "PMA100"

        AddHandler btn_pic.Click, AddressOf btn_pic_Click
        'AddHandler prd.TextChanged, AddressOf prd_TextChanged
        'AddHandler apply_dt.TextChanged, AddressOf apply_dt_TextChanged

        Me.New_Form()

    End Sub

    Public Sub Init_Form()

    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty
            Case MenuType.New
                Me.New_Form()

            Case MenuType.Save
                MyBase.Save()
                'If MyBase.Save() Then
                '    MyBase.Open()  '저장에 성공후 Open한다
                'End If
            Case MenuType.Delete

                If Me.Delete("pma100_f10") = ExcuteResult.Succeeded Then
                    Me.Open("pma100_f10")
                End If
            Case MenuType.Print
                DoPreview()
            Case Else

                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    '######################################################################################
    '##            Open                                                                  ##
    '######################################################################################

    Private Sub New_Form()
        Try
            fac_id.Text = ""
            Me.OpenTrigger("pma100_g10")    'g10을 기점으로 OpenTrigger로 작동하는 모든 Control들 조회

            fac_no.Focus()
        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Sub DoPreview()
        Dim rpt As Report_PMA100 = New Report_PMA100()
        rpt.SetDataBinding(g50.DataSet)
        Dim preview As MainForm = New MainForm()
        preview.DoPreview(rpt)

    End Sub

    Private Sub Open_Form()
        Try

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    '######################################################################################
    '##            Save                                                                  ##
    '######################################################################################

    Private Function Save_Form() As Boolean

        '        Dim ID As String = asset_id.Text
        Try

            '            If MyBase.Save() Then
            '                If ID = "" Then
            '                    f_asset_id.Text = asset_id.Text
            '                    Me.Open()
            '                Else
            '                    Form_Open()
            '                End If
            '            Else
            '                If ID = "" Then asset_id.Text = ""
            '            End If

        Catch ex As Exception
            '            If ID = "" Then asset_id.Text = ""
            '저장에 실패했으면 코드 채번을 반드시 취소한다
            MessageError(ex)
        End Try
    End Function

    Private Sub btn_pic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ImgLayoutControl.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always Then
            ImgLayoutControl.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Me.SplitContainer2.SplitterDistance = 40
        Else
            ImgLayoutControl.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Me.SplitContainer2.SplitterDistance = 220
        End If
    End Sub

    'Public Sub Open3(ByVal dSet As DataSet, ByVal sum_amt As Decimal, ByVal detailSeq As String)
    Public Sub Open3(ByVal p_fac_id As String, ByRef p_dept_cd As String, ByRef p_line_cd As String,
                    ByVal p_maker As String, ByVal p_plant_cd As String, ByVal entID As String,
                    ByVal p_pma220pk As String, ByVal p_detailSeq As String,
                    ByVal sum_amt As Decimal, ByVal p_fac_nm As String)
        New_Form()
        If p_fac_id <> String.Empty Then
            fac_id.Text = p_fac_id
            Me.OpenTrigger("pma100_g10")
            Return
        End If


        dept_cd.Text = p_dept_cd
        line_cd.Text = p_line_cd
        maker.Text = p_maker
        plant_cd.Text = p_plant_cd

        ent_id.Text = entID

        'pma220_pk.Text = p_pma220pk
        'IIf(dRow("inv_id") Is System.DBNull.Value, String.Empty, dRow("inv_id") + "/" + dRow("co_cd") + "/" +
        '                dRow("plan_year") + "/" + dRow("int_plan_rev").ToString())
        'pma225_pk.Text = p_detailSeq
        amt.Text = sum_amt.ToString()
        fac_nm.Text = p_fac_nm

    End Sub


    'Private Sub prd_TextChanged(ByVal sender As Object, ByVal oldValue As String)
    '    Dim period As Integer = Convert.ToInt32(prd.Text)
    '    Dim oldPeriod As Integer = 0 ' IIf(oldValue Is Nothing Or oldValue = "", 0, CInt(oldValue))
    '    If oldValue <> "" Then
    '        oldPeriod = CInt(oldValue)
    '    End If
    '    'Dim oldPeriod As String = IIf(oldValue Is Nothing Or oldValue = "", 0, oldValue)
    '    'Dim oldPeriod As Integer = IIf(oldValue Is Nothing Or oldValue = "", 0, 1)
    '    If period <= 0 Then
    '        next_chkdt.Text = Date.Today
    '        Return
    '    End If

    '    Dim tmpNext_chkdt As Date

    '    If oldPeriod <= 0 And period > 0 Then
    '        tmpNext_chkdt = DateAdd(DateInterval.Month, period, Convert.ToDateTime(apply_dt.EditText))
    '    Else
    '        tmpNext_chkdt = DateAdd(DateInterval.Month, (period - oldPeriod), Convert.ToDateTime(next_chkdt.EditText))
    '    End If

    '    If tmpNext_chkdt.Date < Date.Today Then
    '        While tmpNext_chkdt.Date < Date.Today
    '            tmpNext_chkdt = DateAdd(DateInterval.Month, period, tmpNext_chkdt)
    '        End While
    '    End If
    '    next_chkdt.Text = tmpNext_chkdt
    'End Sub

    'Private Sub apply_dt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If (prd.Text Is Nothing) Or (prd.Text = "") Or
    '        (apply_dt.EditText Is Nothing) Or (apply_dt.EditText = "") Then
    '        Return
    '    End If
    '    Dim period As Integer = Convert.ToInt32(prd.Text)
    '    If period <= 0 Then
    '        next_chkdt.Text = Date.Today
    '        Return
    '    End If

    '    Dim tmpNext_chkdt As Date = DateAdd(DateInterval.Month, period, Convert.ToDateTime(apply_dt.EditText))

    '    If tmpNext_chkdt.Date < Date.Today Then
    '        While tmpNext_chkdt.Date < Date.Today
    '            tmpNext_chkdt = DateAdd(DateInterval.Month, period, tmpNext_chkdt)
    '        End While
    '    End If
    '    next_chkdt.Text = tmpNext_chkdt
    'End Sub

    Private Sub btn_ast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ast.Click

        If ast_no.Text <> "" Then
            MessageInfo("이미 자산으로 등록되었습니다.")
            Exit Sub
        End If

        Dim menuName As String
        'If Parameter.System.Code = "CSI" Then
        '    menuName = "FAB100_CSI"
        'Else
        menuName = "FAS100"
        'End If
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName) 'New FormAttribute(menuName, menuText))
        If ctr IsNot Nothing Then
            ctr.NewForm2(fac_id.Text, fac_no.Text, fac_nm.Text, apply_dt.Text, amt.Text, "")
        End If
    End Sub


End Class
