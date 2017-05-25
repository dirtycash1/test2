Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class FAS100

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        EPanel1.SetSplitter(SplitContainer1, SplitContainer1.Panel1)
        EPanel2.SetSplitter(SplitContainer2, SplitContainer2.Panel1)

        'Me.Open()
        bank_cd.ReadOnly = False
        acct_no.ReadOnly = False
        bank_cd2.ReadOnly = False
        acct_no2.ReadOnly = False

        Dim wSet As Frame7.WorkSet
        wSet = Me.WorkSets("fas100_f10")
        AddHandler wSet.AfterOpen, AddressOf AfterOpen

    End Sub

    Private Sub AfterOpen(ByVal wSet As Frame7.WorkSet)
        g40.Text("fr_div_cd") = div_cd.Text
        g40.Text("fr_dept_cd") = mng_dept.Text
        g40.Text("fr_dept_nm") = mng_dept_nm.Text
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            'Case MenuType.New

            '    ast_no.Text = ""
            '    Me.OpenTrigger("fas100_g10")
            Case MenuType.Open
                Me.Open()
                bank_cd.ReadOnly = False
                acct_no.ReadOnly = False
                bank_cd2.ReadOnly = False
                acct_no2.ReadOnly = False

            Case MenuType.Delete

                If Me.Delete("fas100_f10") = ExcuteResult.Succeeded Then
                    Me.Open("fas100_f10")
                End If

            Case MenuType.Save

                If Me.Save() Then
                    Dim s1 As String = ast_no.Text
                    Dim s2 As String = fa_no.Text

                    Me.Open()

                    If s1 <> "" Then
                        g10.Find("ast_no=" + s1)
                    Else
                        g10.Find("fac_no=" + s2)
                    End If
                End If

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Public Overrides Sub NewForm()

        ast_no.Text = ""
        Me.OpenTrigger("fas100_g10")

    End Sub

    Public Sub NewForm2(ByVal facID As String, ByVal astNo As String, ByVal astNm As String, ByVal getDt As String, ByVal getAmt As String, ByVal modelCd As String)

        Me.NewForm()

        'fac_id.Text = facID
        ast_no.Text = astNo
        fa_no.Text = astNo
        ast_nm.Text = astNm
        get_amt.Text = ToDec(getAmt)
        get_dt.Text = getDt
        pjt_no.Text = modelCd

    End Sub

#Region "전표 관리"
    '1. 취득전표
    '전표생성
    Private Sub btn_doc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_doc.Click
        If doc_no.Text <> "" Then
            MessageInfo("이미 전표가 생성되었습니다.")
            Exit Sub
        End If

        If Not CheckRequired(cust_cd, vat_amt, tax_bc, asset_bc) Then
            Exit Sub
        End If

        If MessageYesNo("전표를 생성하시겠습니까 ?") = MsgBoxResult.No Then
            Exit Sub
        End If

        If ast_no.Text.Length <= 0 Then
            MessageInfo("등록된 자산이 아닙니다.")
            Exit Sub
        End If

        If contra_acct.Text = "" Then
            MessageInfo("상대계정을 입력하세요.")
            Exit Sub
        End If


        If Me.Save() Then

            '전표생성 WorkSet을 호출한다 -> 화면에 chk 된 행으로 전표를 생성한다
            Dim dSet As DataSet = Me.OpenDataSet("fas100_make_doc")

            '생성한 전표번호를 화면에 나타낸다
            If Not IsEmpty(dSet) Then
                doc_no.Text = DataValue(dSet)
            End If

            '작업후 조회한다
            Me.Open("fas100_f10")
        End If

    End Sub

    '전표보기
    Private Sub btn_show_doc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_show_doc.Click

        If doc_no.Text = "" Then
            MessageInfo("먼저 전표를 선택하세요.")
            Exit Sub
        End If

        If doc_no.Text <> "" Then
            Dim menuName As String
            menuName = "FAB100"

            Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
            If ctr IsNot Nothing Then
                ctr.Open2(doc_no.Text)
            End If
        End If
    End Sub

    '전표삭제
    Private Sub btn_del_doc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del_doc.Click
        If doc_no.Text <> "" Then

            If MessageYesNo("전표를 삭제하시겠습니까 ?") = MsgBoxResult.No Then
                Exit Sub
            End If

            If Me.Save() Then
                Me.Open("fas100_delete_doc")
                doc_no.Text = ""

                Me.Open("fas100_f10")
            End If
        End If
    End Sub

    'Private Sub btn_trans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Not Me.Save Then
    '        Exit Sub
    '    End If
    '    Me.Open("fas100_f10")

    '    If Not CheckRequired(ast_no, fa_no, acc_cd) Then
    '        Exit Sub
    '    End If

    '    Dim menuName As String
    '    menuName = "FAS710"

    '    Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
    '    If ctr IsNot Nothing Then
    '        ctr.Open2(ast_no.Text, fa_no.Text, acc_cd.Text)
    '    End If
    'End Sub

    '2. 자본적지출 전표
    '전표생성
    Private Sub btn2_doc_Click(sender As System.Object, e As System.EventArgs) Handles btn2_doc.Click

        If MessageYesNo("전표를 생성하시겠습니까 ?") = MsgBoxResult.No Then
            Exit Sub
        End If

        If ast_no.Text.Length <= 0 Then
            MessageInfo("등록된 자산이 아닙니다.")
            Exit Sub
        End If

        If contra_acct2.Text = "" Then
            MessageInfo("상대계정을 입력하세요.")
            Exit Sub
        End If

        If g20.CheckedRows("chk") = 0 Then
            MessageInfo("선택된 행이 없습니다.")
            Exit Sub
        End If

        'g20.SaveValue("chk", "1")
        g20.SaveValue("mdt", Format(Now, "yyyy-MM-dd hh:mm:ss.fff"))

        If Me.Save() Then

            Dim dSet As DataSet = Me.OpenDataSet("fas100_make_doc2")

            '생성한 전표번호를 화면에 나타낸다
            If Not IsEmpty(dSet) Then
                doc_no2.Text = DataValue(dSet)
            End If

            g20.Open()
        End If
    End Sub

    '전표삭제
    Private Sub btn2_del_Click(sender As System.Object, e As System.EventArgs) Handles btn2_delete.Click
        If doc_no2.Text = "" Then
            MessageInfo("먼저 전표를 선택하세요.")
            Exit Sub
        End If

        If MessageYesNo("전표를 삭제 하시겠습니까 ?") = MsgBoxResult.No Then
            Exit Sub
        End If

        Me.Open("fas100_delete_doc2")
        doc_no2.Text = ""

        '작업후 조회한다
        Me.Open()

        'If g20.CheckedRows("chk") = 0 Then
        '    MessageInfo(GetMessage("COM_NOT_SELECTED"))
        '    Exit Sub
        'End If

        'If MessageYesNo("전표를 삭제하시겠습니까 ?") = MsgBoxResult.No Then
        '    Exit Sub
        'End If

        'g20.SaveValue("ty", "2")

        'If Me.Save() Then
        '    g20.Open()
        'End If
    End Sub

    '전표보기
    Private Sub btn2_open_Click(sender As System.Object, e As System.EventArgs) Handles btn2_open.Click
        If doc_no2.Text = "" Then
            MessageInfo("먼저 전표를 선택하세요.")
            Exit Sub
        End If

        Dim menuName As String
        menuName = "FAB100"
        '화면을 띄운다
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
        If ctr IsNot Nothing Then
            ctr.Open2(doc_no2.Text)
        End If
    End Sub

    Private Sub btn_doc3_Click(sender As System.Object, e As System.EventArgs) Handles btn_doc3.Click
        If g30.CheckedRows("chk") = 0 Then
            MessageInfo(GetMessage("COM_NOT_SELECTED"))
            Exit Sub
        End If

        If MessageYesNo("전표를 생성하시겠습니까 ?") = MsgBoxResult.No Then
            Exit Sub
        End If

        g30.SaveValue("ty", "1")
        g30.SaveValue("mdt", Now)

        If Me.Save() Then

            Me.OpenDataSet("fas100_make_doc3")

            g30.Open()
        End If
    End Sub

    Private Sub btn_del3_Click(sender As System.Object, e As System.EventArgs) Handles btn_del3.Click
        If g30.CheckedRows("chk") = 0 Then
            MessageInfo(GetMessage("COM_NOT_SELECTED"))
            Exit Sub
        End If

        If MessageYesNo("전표를 삭제하시겠습니까 ?") = MsgBoxResult.No Then
            Exit Sub
        End If

        g30.SaveValue("ty", "2")

        If Me.Save() Then
            g30.Open()
        End If
    End Sub

#End Region


    Private Sub contra_acct_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contra_acct.TextChanged
        If contra_acct.Text <> "1110101" And contra_acct.Text <> "" Then
            bank_cd.ReadOnly = False
            acct_no.ReadOnly = False
        Else
            bank_cd.Text = ""
            acct_no.Text = ""
            bank_cd.ReadOnly = True
            acct_no.ReadOnly = True
        End If
    End Sub

    Private Sub contra_acct2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contra_acct2.TextChanged
        If contra_acct2.Text <> "1110101" And contra_acct2.Text <> "" Then
            bank_cd2.ReadOnly = False
            acct_no2.ReadOnly = False
        Else
            bank_cd2.Text = ""
            acct_no2.Text = ""
            bank_cd2.ReadOnly = True
            acct_no2.ReadOnly = True
        End If
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabPage5.Focused Then
            doc_bc.Text = "FA300450"
        ElseIf XtraTabPage1.Focused Then
            doc_bc.Text = "FA300460"
        End If
    End Sub

    Private Sub g20_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g20.CellValueChanging
        If ColumnName = "tax_bc" Then

            If Value.Length > 0 Then
                Dim prm As New OpenParameters
                prm.Add("@tax_bc", Value)
                Dim dSet As DataSet = OpenDataSet("fas100_tax_change", prm)

                Dim vat_rate As Double = 0, dbl_get As Double = 0, dbl_vat As Double = 0
                vat_rate = Double.Parse(dSet.Tables(0).Rows(0)(0).ToString())

                If g20.Text("iss_amt").Length > 0 Then
                    dbl_get = Double.Parse(g20.Text("iss_amt"))
                Else
                    g20.Text("iss_vat") = "0"
                    Exit Sub
                End If

                If vat_rate = 0 Then
                    g20.Text("iss_vat") = "0"
                    Exit Sub

                End If

                dbl_vat = dbl_get / vat_rate

                g20.Text("iss_vat") = dbl_vat.ToString()

            End If
        End If

        If ColumnName = "iss_amt" Then

            If g20.Text("tax_bc").Length > 0 Then
                Dim prm As New OpenParameters
                prm.Add("@tax_bc", g20.Text("tax_bc"))
                Dim dSet As DataSet = OpenDataSet("fas200_tax_change", prm)

                Dim vat_rate As Double = 0, dbl_get As Double = 0, dbl_vat As Double = 0
                vat_rate = Double.Parse(dSet.Tables(0).Rows(0)(0).ToString())

                If Value.Length > 0 Then
                    dbl_get = Double.Parse(Value)
                Else
                    g20.Text("iss_vat") = "0"
                    Exit Sub
                End If

                If vat_rate = 0 Then
                    g20.Text("iss_vat") = "0"
                    Exit Sub

                End If

                dbl_vat = dbl_get / vat_rate

                g20.Text("iss_vat") = dbl_vat.ToString()

            End If

        End If
    End Sub


End Class
