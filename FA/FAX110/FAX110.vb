Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class FAX110

    Private m_BaseCuryCd As String
    Private m_BaseCuryNm As String

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.m_BaseCuryCd = cury_bc.Text
        Me.m_BaseCuryNm = cury_bc.EditText
        Me.CheckCury()

        g20.AllowSort = False
        g50.AllowSort = False

        g50.RecordNavigator = True

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                If XtraTabControl1.SelectedTabPageIndex = 0 Then
                    Me._CheckCuryBc(g10)
                    Me._CheckCuryBc(g20)
                    Me.Open("fax110_g10")
                Else
                    Me._CheckCuryBc(g50)
                    Me.Open("fax110_g50")
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

#Region " 거래처검색조건 제어"

    Private m_fr_cust_cd As String
    Private m_to_cust_cd As String

    Private Sub cust_nm_TextChanged(ByVal sender As System.Object, ByVal oldValue As System.String) Handles cust_nm.TextChanged
        If m_stop_event Then Exit Sub
        m_stop_event = True

        If cust_nm.Text <> "" Then
            m_fr_cust_cd = fr_cust_cd.Text
            m_to_cust_cd = to_cust_cd.Text
            If fr_cust_cd.Text <> "" Then fr_cust_cd.Text = ""
            If to_cust_cd.Text <> "" Then to_cust_cd.Text = ""
        Else
            fr_cust_cd.Text = m_fr_cust_cd
            to_cust_cd.Text = m_to_cust_cd
        End If

        m_stop_event = False
    End Sub

    Private Sub cust_cd1_TextChanged(sender As Object, oldValue As String) Handles fr_cust_cd.TextChanged, to_cust_cd.TextChanged
        If m_stop_event Then Exit Sub
        m_stop_event = True

        cust_cd.Text = ""

        m_stop_event = False
    End Sub


#End Region

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


#Region " Jump "

    'Public Sub Open2(ByVal divcd As String, ByVal frdt As String, ByVal todt As String, ByVal acccd As String, ByVal mngno As String, ByVal mngval As String)

    '    div_cd.Text = divcd
    '    fr_dt.Text = frdt
    '    to_dt.Text = todt
    '    fr_acc_cd.Text = acccd
    '    'mng_no.Text = mngno
    '    cust_cd1.Text = mngval
    '    XtraTabControl1.SelectedTabPageIndex = 0
    '    MyBase.Open(WorkSets("fax110_g10"))
    '    'MyBase.Open(WorkSets("fax110_g20"))

    'End Sub

    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        'Dim menuName As String = "FAX110"

        ''화면을 띄운다
        'Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
        Me.Open3((g10.Text("acc_cd")), (g10.Text("mng_val")), (g10.Text("admin_val")))

    End Sub

    Public Sub Open3(ByVal acccd As String, ByVal mngno As String, ByVal mngval As String)

        'fr_acc_cd.Text = acccd
        'mng_no.Text = mngno
        'mng_val.Text = mngval
        'XtraTabControl1.SelectedTabPageIndex = 1
        'MyBase.Open(WorkSets("fax110_g50"))
        ''MyBase.Open(WorkSets("fax110_g40"))

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
        If Parameter.System.Code = "CSI" Then
            menuName = "FAB100_CSI"
        Else
            menuName = "FAB100"
        End If

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

        Dim fr_cust As String = ""
        Dim to_cust As String = ""

        If cust_cd.Text <> "" Then
            fr_cust = cust_cd.Text
            to_cust = cust_cd.Text
        Else
            fr_cust = fr_cust_cd.Text
            to_cust = to_cust_cd.Text
        End If

        Dim p As OpenParameters = New OpenParameters
        p.Add("@co_cd", co_cd.Text)
        p.Add("@div_cd", Replace(div_cd.Text, "'", ""))
        p.Add("@fr_dt", fr_dt.Text)
        p.Add("@to_dt", to_dt.Text)
        'p.Add("@mng_no", "010")
        p.Add("@fr_cust_cd", fr_cust)
        p.Add("@to_cust_cd", to_cust)
        p.Add("@fr_acc_cd", fr_acc)
        p.Add("@to_acc_cd", to_acc)
        p.Add("@cury_bc", cury_bc.Text)
        p.Add("@no_yn", no_yn.Text)
        p.Add("@up_yn", up_yn.Text)
        p.Add("@doc_yn", doc_yn.Text)
        p.Add("@sum_yn", "1")
        ReportView.LoadView("FAX110", "", "fax110_g50", p) '계정별원장
    End Sub
#End Region


    Private Sub sort_yn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sort_yn.CheckedChanged

        If sort_yn.Checked Then
            g10.VisibleIndex("acc_cd") = 0
            g10.VisibleIndex("acc_nm") = 1

            g50.VisibleIndex("acc_cd") = 0
            g50.VisibleIndex("acc_nm") = 1
        Else
            g10.VisibleIndex("mng_val") = 0
            g10.VisibleIndex("mng_dsc") = 1

            g50.VisibleIndex("mng_val") = 0
            g50.VisibleIndex("mng_dsc") = 1
        End If

    End Sub

    Public Sub Open2(ByVal coCd As String, ByVal custCd As String, ByVal accCd As String, Optional ByVal mon As String = "")
        If mon <> "" Then
            fr_dt.Text = mon + "-01"
            to_dt.Text = ToLastDate(mon + "-01")
        End If

        co_cd.Text = coCd

        fr_cust_cd.Text = custCd
        to_cust_cd.Text = custCd

        acc_cd.Text = accCd

        Me.Open("fax110_g10")
    End Sub



End Class
