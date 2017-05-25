Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data


Public Class FAX100

    Private m_BaseCuryCd As String
    Private m_BaseCuryNm As String

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.m_BaseCuryCd = cury_bc.Text
        Me.m_BaseCuryNm = cury_bc.EditText

        g20.AllowSort = False
        g50.AllowSort = False

        g50.RecordNavigator = True

        Me.CheckCury()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                'If fr_acc_cd.Text <> "" And to_acc_cd.Text = "" Then
                '    to_acc_cd.Text = fr_acc_cd.Text
                'End If

                If f1 IsNot Nothing Then
                    mng_val.Text = f1.Text
                End If

                If XtraTabControl1.SelectedTabPageIndex = 0 Then
                    Me._CheckCuryBc(g10)
                    Me._CheckCuryBc(g20)
                    Me.Open("fax100_g10")
                Else
                    Me._CheckCuryBc(g50)
                    Me.Open("fax100_g50")
                End If
            Case MenuType.Print
                Me.Print()
            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select



        'Select Case mty
        '    Case MenuType.Open
        '        MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
        '        '사용하려면 재정의 가능하다

        '    Case MenuType.New
        '        mng_no.Text = ""
        '        mng_val.Text = ""
        '        fr_acc_cd.Text = ""
        '        to_acc_cd.Text = ""

        '    Case Else
        '        MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        'End Select

    End Sub

    Private Sub mng_no_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles mng_no.TextChanged
        _Disp_Mng_Fields()
    End Sub


    Public Sub CheckCury()

        Me._CheckCuryBc(g10)
        Me._CheckCuryBc(g20)
        Me._CheckCuryBc(g50)

    End Sub

    Public Sub _CheckCuryBc(ByVal grid As eGrid)
        Dim vis As Boolean = True
        If Me.m_BaseCuryCd = cury_bc.Text Then
            vis = False
        End If
        With grid
            .BandTitle("amt1") = cury_bc.EditText
            .BandTitle("bamt1") = m_BaseCuryNm

            .ShowBands = vis
            .ColumnVisible("bbas_amt") = vis
            .ColumnVisible("bamt1") = vis
            .ColumnVisible("bamt2") = vis
            .ColumnVisible("bend_amt") = vis

        End With
    End Sub


    Private Sub g10_AfterMoveRow(sender As Object, PrevRowIndex As Integer, RowIndex As Integer) Handles g10.AfterMoveRow
        If g10.RowCount = 0 Then
            g20.DataSet = Nothing
        Else
            g20.Open()
        End If
    End Sub

#Region " 계정검색조건 제어"

    Private m_fr_acc_cd As String
    Private m_to_acc_cd As String
    Private m_stop_event As Boolean

    Private Sub acc_nm_TextChanged(ByVal sender As System.Object, ByVal oldValue As System.String) Handles acc_nm.TextChanged
        If m_stop_event Then Exit Sub
        m_stop_event = True

        If acc_nm.Text <> "" Then
            m_fr_acc_cd = fr_acc_cd.Text
            m_to_acc_cd = to_acc_cd.Text
            If fr_acc_cd.Text <> "" Then fr_acc_cd.Text = ""
            If to_acc_cd.Text <> "" Then to_acc_cd.Text = ""
        Else
            fr_acc_cd.Text = m_fr_acc_cd
            to_acc_cd.Text = m_to_acc_cd
        End If

        m_stop_event = False
    End Sub

    Private Sub fr_acc_cd_TextChanged(sender As Object, oldValue As String) Handles fr_acc_cd.TextChanged, to_acc_cd.TextChanged
        If m_stop_event Then Exit Sub
        m_stop_event = True
        acc_cd.Text = ""
        m_stop_event = False
    End Sub

#End Region

    'Private Sub cury_bc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cury_bc.TextChanged
    '    Me.CheckCury()
    'End Sub

#Region " Jump "

    Public Sub Open2(ByVal divcd As String, ByVal frdt As String, ByVal todt As String, ByVal acccd As String, ByVal mngno As String, ByVal mngval As String)

        div_cd.Text = divcd
        fr_dt.Text = frdt
        to_dt.Text = todt
        fr_acc_cd.Text = acccd
        mng_no.Text = mngno
        mng_val.Text = mngval
        XtraTabControl1.SelectedTabPageIndex = 0
        MyBase.Open(WorkSets("fax100_g10"))
        'MyBase.Open(WorkSets("fax100_g20"))

    End Sub

    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        'Dim menuName As String = "FAX100"

        ''화면을 띄운다
        'Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
        Me.Open3((g10.Text("acc_cd")), (g10.Text("mng_val")), (g10.Text("admin_val")))

    End Sub

    Public Sub Open3(ByVal acccd As String, ByVal mngno As String, ByVal mngval As String)

        'fr_acc_cd.Text = acccd
        'mng_no.Text = mngno
        'mng_val.Text = mngval
        'XtraTabControl1.SelectedTabPageIndex = 1
        'MyBase.Open(WorkSets("fax100_g50"))
        ''MyBase.Open(WorkSets("fax100_g40"))

    End Sub


    Private Sub g20_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g20.DoubleClick
        Jump_To_FAB100(g20.Text("doc_no"), g20.Text("doc_sq"))
    End Sub

    Private Sub g50_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g50.DoubleClick
        Jump_To_FAB100(g50.Text("doc_no"), g50.Text("doc_sq"))
    End Sub

    Private Sub Jump_To_FAB100(ByVal docNo As String, ByVal docSq As String)
        If docNo = "" Then
            Exit Sub
        End If

        Dim menuName As String
        'If Parameter.System.Code = "CSI" Then
        '    menuName = "FAB100_CSI"
        'Else
        menuName = "FAB100"
        'End If

        '화면을 띄운다
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName) 'New FormAttribute(menuName, menuText))
        If ctr IsNot Nothing Then
            ctr.Open2(docNo, docSq)
        End If
    End Sub


#End Region

#Region " Print "
    Private Sub Print()

        Dim fr_acc As String = ""
        Dim to_acc As String = ""

        If acc_cd.Text <> "" Then
            fr_acc = acc_cd.Text
            to_acc = acc_cd.Text
        Else
            fr_acc = fr_acc_cd.Text
            to_acc = to_acc_cd.Text
        End If

        Dim p As OpenParameters = New OpenParameters
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            p.Add("@co_cd", co_cd.Text)
            p.Add("@div_cd", Replace(div_cd.Text, "'", ""))
            p.Add("@fr_dt", fr_dt.Text)
            p.Add("@to_dt", to_dt.Text)
            p.Add("@mng_no", mng_no.Text)
            p.Add("@mng_val", mng_val.Text)
            p.Add("@acc_cd", fr_acc)
            p.Add("@fr_acc_cd", fr_acc)
            p.Add("@to_acc_cd", to_acc)
            p.Add("@cury_bc", cury_bc.Text)
            p.Add("@no_yn", no_yn.Text)
            p.Add("@up_yn", up_yn.Text)
            p.Add("@doc_yn", doc_yn.Text)
            p.Add("@sum_yn", "1")
            If prn_chk.Text = "1" Then
                System7.ReportView.LoadView("FAX103", "", "fax100_g10", p) '계정별원장 세로
            Else
                System7.ReportView.LoadView("FAX101", "", "fax100_g10", p) '계정별원장
            End If


        Else

            p.Add("@co_cd", co_cd.Text)
            p.Add("@div_cd", Replace(div_cd.Text, "'", ""))
            p.Add("@fr_dt", fr_dt.Text)
            p.Add("@to_dt", to_dt.Text)
            p.Add("@mng_no", mng_no.Text)
            p.Add("@mng_val", mng_val.Text)
            p.Add("@acc_cd", fr_acc)
            p.Add("@fr_acc_cd", fr_acc)
            p.Add("@to_acc_cd", to_acc)
            p.Add("@cury_bc", cury_bc.Text)
            p.Add("@no_yn", no_yn.Text)
            p.Add("@up_yn", up_yn.Text)
            p.Add("@doc_yn", doc_yn.Text)
            p.Add("@sum_yn", "1")
            If prn_chk.Text = "1" Then
                System7.ReportView.LoadView("FAX102", "", "fax100_g50", p) '계정별원장 세로 출력
            Else
                System7.ReportView.LoadView("FAX100", "", "fax100_g50", p) ' 가로 출력
            End If

        End If

    End Sub
#End Region



#Region " 관리항목 설정 "

    Private Const m_Mng_Popup = "FA210100"
    Private Const m_Mng_Combo = "FA210200"
    Private Const m_Mng_비고 = "FA210300"
    Private Const m_Mng_수치 = "FA210400"
    Private Const m_Mng_율 = "FA210450"
    Private Const m_Mng_년월일 = "FA210500"
    Private Const m_Mng_년월 = "FA210550"
    Private Const m_Mng_년 = "FA210600"

    Private f1 As Object
    Private f2 As Object

    Private Sub _Disp_Mng_Fields()

        If f1 IsNot Nothing Then f1.Dispose()
        If f2 IsNot Nothing Then f2.Dispose()

        f1 = Nothing
        f2 = Nothing

        If mng_no.Text = "" Then
            Exit Sub
        End If

        Dim p As New OpenParameters
        p.Add("@mng_no", mng_no.Text)

        Dim dSet As DataSet = OpenDataSet("fax100_get_mng", p)

        Dim ty As String = DataValue(dSet, "mng_bc")
        Dim pid As String = DataValue(dSet, "popup_id")
        Dim nm As String = mng_no.EditText


        Me.__New_Mng_Field(ty, nm, pid)


        If f1 IsNot Nothing Then f1.BringToFront()
        If f2 IsNot Nothing Then f2.BringToFront()

    End Sub

    Private Sub __New_Mng_Field(ByVal ty As String, ByVal nm As String, ByVal pid As String)


        Dim x1 As Integer, x2 As Integer, y As Integer = 28

        x1 = 352
        x2 = x1 + 244 + 30
        y = 52

        Select Case ty

            Case m_Mng_Popup

                f1 = New Frame7.eText
                f2 = New Frame7.eText

                Me.___Set_Field_Property(f1, nm, x1, y)
                Me.___Set_Field_Property2(f2, nm, x2, y)
                Me.___Set_Popup(f1, f2, pid) '"71")

            Case m_Mng_Combo

                f1 = New Frame7.eCombo
                Me.___Set_Field_Property(f1, nm, x1, y, 300)
                Me.___set_Combo(f1, pid)

            Case m_Mng_비고, m_Mng_수치, m_Mng_율

                f1 = New Frame7.eText
                'Dim w As Integer = IIf(ty = m_Mng_비고, 300, 240)
                Me.___Set_Field_Property(f1, nm, x1, y)

                If ty = m_Mng_수치 Or ty = m_Mng_율 Then
                    f1.FieldType = FieldType.Decimal
                    f1.RoundDigits = 4
                    f1.RoundType = RoundType.Truncation
                End If

            Case m_Mng_년월일, m_Mng_년월, m_Mng_년

                f1 = New Frame7.eDate
                Me.___Set_Field_Property(f1, nm, x1, y)

                If ty = m_Mng_년월일 Then CType(f1, eDate).FormatType = DateFormatType.Day
                If ty = m_Mng_년월 Then CType(f1, eDate).FormatType = DateFormatType.Month
                If ty = m_Mng_년 Then CType(f1, eDate).FormatType = DateFormatType.Year

        End Select

    End Sub

    Private Sub ___Set_Field_Property(ByVal f As Control, ByVal title As String, ByVal x As Integer, ByVal y As Integer, Optional ByVal w As Integer = 240)
        Me.EPanel1.Controls.Add(f)

        f.Font = New System.Drawing.Font("Tahoma", 9) '"맑은 고딕", 9)
        f.Location = New System.Drawing.Point(x, y)
        'f.Name = "f" + inx.ToString.Trim
        f.Size = New System.Drawing.Size(w + 30, 21)
        f.TabIndex = 100 + 1
        CType(f, intField).Title = title

    End Sub

    Private Sub ___Set_Field_Property2(ByVal f As Control, ByVal title As String, ByVal x As Integer, ByVal y As Integer, Optional ByVal w As Integer = 200)
        Me.EPanel1.Controls.Add(f)

        f.Font = New System.Drawing.Font("Tahoma", 9) '"맑은 고딕", 9)
        f.Location = New System.Drawing.Point(x, y)
        'f.Name = "n" + inx.ToString.Trim
        f.Size = New System.Drawing.Size(w, 21)
        f.TabIndex = 100 + 2

        f.TabStop = False
        CType(f, eText).TitleWidth = 0
        CType(f, eText).ReadOnly = True
    End Sub

    Private Sub ___Set_Popup(ByVal f1 As intField, ByVal f2 As intField, ByVal popupID As String)

        Dim dSet As DataSet

        Dim op As New OpenParameters
        op.Add("@mng_no", mng_no.Text)
        op.Add("@popup_id", popupID)

        dSet = Me.OpenDataSet("get_popup_fields", op)
        If IsEmpty(dSet) Then
            Exit Sub
        End If

        'Dim pid = DataValue(dSet, "popup_id")
        Dim subCd = DataValue(dSet, "sub_cd")
        Dim param = DataValue(dSet, "param")
        Dim params = DataValue(dSet, "params")
        Dim out1 = DataValue(dSet, "out1")
        Dim out2 = DataValue(dSet, "out2")
        Dim mainCd = DataValue(dSet, "main_cd")

        If Not (mainCd = "Popup" Or mainCd = "Dynamic") Then
            'MessageInfo(subCd + ": Popup 유형이 [" + mainCd + "] 입니다. [Popup] 이어야 합니다")
            Exit Sub
        End If

        Dim pup As Popup = New Popup
        f1.Popup = pup

        pup.BaseField = f1
        pup.PopupID = popupID
        pup.SubCode = subCd '"HR210"

        '-----------------------
        'Setting input
        '-----------------------
        If params = "" Then
            pup.AddInput(param, f1) '("@dept_cd", t1)
        Else
            Dim arr() As String, p As String, f As String, iFld As intField = Nothing
            arr = Split(params, ",")
            For Each ps As String In arr

                p = Split(ps, "=")(0)
                f = Split(ps, "=")(1)

                If f = "Me" Then            'Field를 체크
                    iFld = f1
                ElseIf p = "@co_cd" Then    'Parameter를 체크
                    iFld = co_cd
                ElseIf p = "@div_cd" Then   'Parameter를 체크
                    iFld = div_cd
                ElseIf p = "@bank_cd" Then  'Parameter를 체크
                    dummy.Text = "%"
                    iFld = dummy

                    'ElseIf f = "dept_cd" Then
                    '    iFld = dept_cd
                    'ElseIf f = "Prev" Then
                    '    If 0 < inx Then
                    '        For Each fld As intField In pnl2.Controls
                    '            If fld.Name = "f" + (inx - 1).ToString.Trim Then
                    '                iFld = fld
                    '                Exit For
                    '            End If
                    '        Next
                    '    End If
                End If

                If iFld IsNot Nothing Then
                    pup.AddInput(p, iFld)

                    If mainCd = "Dynamic" Then
                        Dim j = New Join()
                        j.FromControl = iFld
                        j.ToControl = f1
                        j.JoinType = JoinType.Indicate
                        Me.Joins.Add(j)
                    End If
                End If
            Next
        End If

        '-----------------------
        'Setting output
        '-----------------------
        pup.AddOutput(out1, f1)
        If f2 IsNot Nothing Then
            pup.AddOutput(out2, f2)
        End If

        If mainCd = "Dynamic" Then
            f1.GetIndicator(Nothing)
        End If

    End Sub

    Private Sub ___Set_Popup_old(ByVal f1 As intField, ByVal f2 As intField, ByVal popupID As String)

        Dim dSet As DataSet

        Dim p As New OpenParameters
        p.Add("@popup_id", popupID)

        dSet = Me.OpenDataSet("fax100_get_popup", p)
        If IsEmpty(dSet) Then
            Exit Sub
        End If

        'Dim pid = DataValue(dSet, "popup_id")
        Dim subCd = DataValue(dSet, "sub_cd")
        Dim param = DataValue(dSet, "param")
        Dim out1 = DataValue(dSet, "out1")
        Dim out2 = DataValue(dSet, "out2")
        Dim mainCd = DataValue(dSet, "main_cd")

        If mainCd <> "Popup" Then
            MessageInfo(subCd + ": Popup 유형이 [" + mainCd + "] 입니다. [Popup] 이어야 합니다")
            Exit Sub
        End If

        Dim pup As Popup = New Popup
        f1.Popup = pup

        pup.BaseField = f1
        pup.PopupID = popupID
        pup.SubCode = subCd '"HR210"

        pup.AddInput(param, f1) '("@dept_cd", f1)
        pup.AddOutput(out1, f1) '("dept_cd", f1)
        pup.AddOutput(out2, f2) '("dept_nm", f2)

    End Sub

    Private Sub ___set_Combo(ByVal f1 As intField, ByVal popupID As String)
        Dim p As New OpenParameters
        p.Add("@popup_id", popupID)

        Dim dSet As DataSet = Me.OpenDataSet("fax100_get_combo", p)
        If IsEmpty(dSet) Then
            Exit Sub
        End If

        CType(f1, eCombo).SetCombo(dSet)
    End Sub

#End Region

End Class
