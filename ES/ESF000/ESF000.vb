Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Parameter
Imports System.Data

Public Class ESF000
    Private JmpObj(50) As String
    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        New_Form()
    End Sub

    Public Sub Init_Form()

    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    '    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

    '        Select Case mty

    '            Case MenuType.New

    '            Case MenuType.Save

    '            Case MenuType.Delete

    '            Case Else

    '                MyBase.MenuButton_Click(mty)

    '        End Select

    '    End Sub

    '######################################################################################
    '##            Open                                                                  ##
    '######################################################################################

    Private Sub New_Form()
        Try
            Dim dSet As DataSet = OpenDataSet("esf000_info")
            If Not IsEmpty(dSet) Then
                Dim dRows As DataRowCollection, dRow As DataRow
                Dim FormNm As String = "", Title As String = "", Cal As String = "", Tag As String = "", Cnt As Integer = 0
                dRows = DataSetRows(dSet)
                Dim GetObj(20) As DevExpress.XtraEditors.SimpleButton
                Dim BaseCtrl As Windows.Forms.Control.ControlCollection = Panel1.Controls, Ctrl As Windows.Forms.Control
                For Each Ctrl In BaseCtrl
                    If TypeOf Ctrl Is DevExpress.XtraEditors.SimpleButton Then
                        Cnt = CInt(Ctrl.Name.Replace("btn_", ""))
                        Ctrl.TabIndex = Cnt
                        Ctrl.Visible = False
                        GetObj(Cnt) = Ctrl
                    End If
                Next

                Cnt = 0
                For Each dRow In dRows
                    Cnt += 1
                    FormNm = ToStr(dRow("form_nm"))
                    Title = ToStr(dRow("tit"))
                    Cal = ToStr(dRow("cap"))
                    Tag = ToStr(dRow("tag"))

                    JmpObj(Cnt) = FormNm
                    GetObj(Cnt).Text = Title
                    GetObj(Cnt).ToolTipTitle = Title
                    GetObj(Cnt).ToolTip = Cal
                    SetBtnFont(GetObj(Cnt), Tag)

                    'Select Case Cnt
                    '    Case 1
                    '        btn_01.ToolTipTitle = Title
                    '        btn_01.ToolTip = Cal
                    '        SetBtnFont(btn_01, Tag)

                    '    Case 2
                    '        btn_02.ToolTipTitle = Title
                    '        btn_02.ToolTip = Cal
                    '        SetBtnFont(btn_02, Tag)

                    '    Case "btn_EPWS210F"
                    '        btn_EPWS210F.ToolTipTitle = Title
                    '        btn_EPWS210F.ToolTip = Cal
                    '        SetBtnFont(btn_EPWS210F, Tag)

                    '    Case "btn_EPWS260F"
                    '        btn_EPWS260F.ToolTipTitle = Title
                    '        btn_EPWS260F.ToolTip = Cal
                    '        SetBtnFont(btn_EPWS260F, Tag)

                    '    Case "btn_EPWH212F"
                    '        btn_EPWH212F.ToolTipTitle = Title
                    '        btn_EPWH212F.ToolTip = Cal
                    '        SetBtnFont(btn_EPWH212F, Tag)

                    '    Case "btn_EPWS130F"
                    '        btn_EPWS130F.ToolTipTitle = Title
                    '        btn_EPWS130F.ToolTip = Cal
                    '        SetBtnFont(btn_EPWS130F, Tag)

                    '    Case "btn_EPWS700F"
                    '        btn_EPWS700F.ToolTipTitle = Title
                    '        btn_EPWS700F.ToolTip = Cal
                    '        SetBtnFont(btn_EPWS700F, Tag)

                    '    Case "btn_EPWS600F"
                    '        btn_EPWS600F.ToolTipTitle = Title
                    '        btn_EPWS600F.ToolTip = Cal
                    '        SetBtnFont(btn_EPWS600F, Tag)

                    '    Case "btn_EPQG313F"
                    '        btn_EPQG313F.ToolTipTitle = Title
                    '        btn_EPQG313F.ToolTip = Cal
                    '        SetBtnFont(btn_EPQG313F, Tag)

                    '    Case "btn_EPWH222F"
                    '        btn_EPWH222F.ToolTipTitle = Title
                    '        btn_EPWH222F.ToolTip = Cal
                    '        SetBtnFont(btn_EPWH222F, Tag)

                    '    Case "btn_EPAA100F"
                    '        btn_EPAA100F.ToolTipTitle = Title
                    '        btn_EPAA100F.ToolTip = Cal
                    '        SetBtnFont(btn_EPAA100F, Tag)

                    '    Case "btn_EPDV200F"
                    '        btn_EPDV200F.ToolTipTitle = Title
                    '        btn_EPDV200F.ToolTip = Cal
                    '        SetBtnFont(btn_EPDV200F, Tag)

                    'End Select

                Next
            End If
        Catch ex As Exception
            MessageError(ex)
        End Try
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


    '######################################################################################
    '##            사용자정의                                                            ##
    '######################################################################################

    '######################################################################################
    '##             Procedure                                                            ##
    '######################################################################################
    Private Sub Panel1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.Resize
        'PalResize()
    End Sub

    Private Sub PalResize()
        With Panel1
            'H 325(실제290), W 990
            Dim W As Integer = .Width, H As Integer = .Height
            Dim StdL As Integer = 0, StdTop As Integer = 0
            If W <= 1025 Then
                StdL = 360
            Else
                StdL = (W - 1025) + 360
            End If

            btn_01.Left = StdL
            btn_03.Left = StdL
            btn_05.Left = StdL
            btn_07.Left = StdL
            btn_09.Left = StdL
            btn_11.Left = StdL

            StdL += 320
            btn_02.Left = StdL
            btn_04.Left = StdL
            btn_06.Left = StdL
            btn_08.Left = StdL
            btn_10.Left = StdL
            btn_12.Left = StdL

            StdTop = 116 '35
            btn_01.Top = StdTop
            btn_02.Top = StdTop

            StdTop += 75
            btn_03.Top = StdTop
            btn_04.Top = StdTop

            StdTop += 75
            btn_05.Top = StdTop
            btn_06.Top = StdTop

            StdTop += 75
            btn_07.Top = StdTop
            btn_08.Top = StdTop

            StdTop += 75
            btn_09.Top = StdTop
            btn_10.Top = StdTop

            StdTop += 75
            btn_11.Top = StdTop
            btn_12.Top = StdTop

        End With
    End Sub

    Private Sub SetBtnFont(ByVal GetObject As Object, ByVal GetTag As String)

        GetObject.Visible = True
        If GetTag <> "Y" Then GetObject.ForeColor = Color.DimGray
        GetObject.Tag = GetTag

    End Sub

    Private Sub CallForm(ByVal GetObject As Object)
        If GetObject.Tag <> "Y" Then
            MessageInfo("현재 프로그램 수정 반영중입니다.") '현재 프로그램 수정 반영중입니다.
        Else
            Dim GetFormNm As String = JmpObj(GetObject.TabIndex())
            If GetFormNm = "" Then Exit Sub
            Try
                Dim menuName As String = GetFormNm
                Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
                'If ctr Is Nothing Then Exit Sub
                'If menuName = "ESF130" Then
                '    ctr.Open2()
                'Else
                '    ctr.Open()
                'End If

            Catch ex As Exception
                MessageError(ex)
            End Try

        End If

    End Sub

    Private Sub btn_01_Click(sender As System.Object, e As System.EventArgs) Handles btn_01.Click, btn_02.Click, btn_03.Click, btn_04.Click, btn_05.Click, btn_06.Click, _
                                                                                    btn_07.Click, btn_08.Click, btn_09.Click, btn_10.Click, btn_11.Click, btn_12.Click
        CallForm(sender)
    End Sub


End Class
