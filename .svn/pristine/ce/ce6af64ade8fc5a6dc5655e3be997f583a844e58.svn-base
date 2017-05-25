Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAY100

    Private m_BaseCuryCd As String
    Private m_BaseCuryNm As String

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.m_BaseCuryCd = cury_bc.Text
        Me.m_BaseCuryNm = cury_bc.EditText

        g20.AllowSort = False
        g50.AllowSort = False
        g70.AllowSort = False

        g50.RecordNavigator = True
        g70.RecordNavigator = True

        Me.CheckCury()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                Me.Open()

            Case MenuType.Print
                Me.Print()
            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Public Overrides Sub Open()
        'If fr_acc_cd.Text <> "" And to_acc_cd.Text = "" Then
        '    to_acc_cd.Text = fr_acc_cd.Text
        'End If

        Select Case XtraTabControl1.SelectedTabPageIndex
            Case 0
                Me._CheckCuryBc(g10)
                Me._CheckCuryBc(g20)
                MyBase.Open("fay100_g10")
            Case 1
                Me._CheckCuryBc(g50)
                MyBase.Open("fay100_g50")
            Case 2
                Me._CheckCuryBc(g70)
                MyBase.Open("fay100_g70")
        End Select

    End Sub

    Public Sub Open2(ByVal coCd As String, ByVal divCd As String, ByVal frDt As String, ByVal toDt As String, ByVal frAcc As String, ByVal toAcc As String)
        co_cd.Text = coCd
        div_cd.Text = divCd
        fr_dt.Text = frDt
        to_dt.Text = toDt
        acc_cd.Text = ""
        fr_acc_cd.Text = frAcc
        to_acc_cd.Text = toAcc

        Me.Open()
    End Sub

    Public Sub CheckCury()

        Me._CheckCuryBc(g10)
        Me._CheckCuryBc(g20)
        Me._CheckCuryBc(g50)
        Me._CheckCuryBc(g70)

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


#Region "Jump"

    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim menuName As String = "FAX100"

        '화면을 띄운다
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
        With g10
            ctr.Open2(.Text("div_cd"), .Text("fr_dt"), .Text("to_dt"), .Text("acc_cd"), .Text("mng_no"), .Text(""))
        End With

    End Sub

    Private Sub g20_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g20.DoubleClick
        Dim menuName As String
        'If Parameter.System.Code = "CSI" Then
        '    menuName = "FAB100_CSI"
        'Else
        menuName = "FAB100"
        'End If
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName) 'New FormAttribute(menuName, menuText))
        If ctr IsNot Nothing Then
            ctr.Open2(g20.Text("doc_no"), g20.Text("doc_sq"))
        End If
    End Sub

    Private Sub g50_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g50.DoubleClick
        Dim menuName As String
        'If Parameter.System.Code = "CSI" Then
        '    menuName = "FAB100_CSI"
        'Else
        menuName = "FAB100"
        'End If
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName) 'New FormAttribute(menuName, menuText))
        If ctr IsNot Nothing Then
            ctr.Open2(g50.Text("doc_no"), g50.Text("doc_sq"))
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
        p.Add("@co_cd", co_cd.Text)
        p.Add("@div_cd", Replace(div_cd.Text, "'", ""))
        p.Add("@fr_dt", fr_dt.Text)
        p.Add("@to_dt", to_dt.Text)
        p.Add("@acc_cd", acc_cd.Text)
        p.Add("@fr_acc_cd", fr_acc)
        p.Add("@to_acc_cd", to_acc)
        p.Add("@cury_bc", cury_bc.Text)
        p.Add("@no_yn", no_yn.Text)
        p.Add("@up_yn", up_yn.Text)
        p.Add("@doc_yn", doc_yn.Text)
        System7.ReportView.LoadView("FAY100", "", "fay100_g50", p) '계정별원장
    End Sub
#End Region

End Class
