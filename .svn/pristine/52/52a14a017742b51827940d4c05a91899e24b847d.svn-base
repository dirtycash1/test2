Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Parameter
Imports System.Data

Public Class ESF000_KRS
    Private JmpObj(100) As String
    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Init_Form()
    End Sub

    Public Sub Init_Form()
        New_Form2()
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

            Dim dSet As DataSet = OpenDataSet("esf000_krs_info")
            If Not IsEmpty(dSet) Then
                Dim dRows As DataRowCollection, dRow As DataRow
                Dim FormNm As String = "", Title As String = "", Cal As String = "", Tag As String = "", Cnt As Integer = 0
                dRows = DataSetRows(dSet)
                Dim GetObj(20) As DevExpress.XtraEditors.SimpleButton
                Dim BaseCtrl As Windows.Forms.Control.ControlCollection = Me.Controls, Ctrl As Windows.Forms.Control
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

                Next
            End If
        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Sub New_Form2()
        Try

            Dim dSet As DataSet = OpenDataSet("esf000_krs_info2")
            If Not IsEmpty(dSet) Then

                Dim FormNm As String = "", Title As String = "", Cal As String = "", Tag As String = "", Sq As Integer = 0, BtnTy As String = ""
                Dim dRows As DataRowCollection = DataSetRows(dSet)

                Dim GetObj(20) As DevExpress.XtraEditors.SimpleButton
                Dim GetObj2(20) As DevExpress.XtraEditors.DropDownButton

                Dim BaseCtrl As Windows.Forms.Control.ControlCollection = Me.Controls, Ctrl As Windows.Forms.Control
                For Each Ctrl In BaseCtrl
                    If TypeOf Ctrl Is DevExpress.XtraEditors.DropDownButton Then
                        Sq = CInt(Ctrl.Name.Replace("btnd_", ""))
                        Ctrl.TabIndex = Sq
                        Ctrl.Visible = False
                        GetObj2(Sq) = Ctrl
                    End If
                    If TypeName(Ctrl) = "SimpleButton" Then
                        Sq = CInt(Ctrl.Name.Replace("btn_", ""))
                        Ctrl.TabIndex = Sq
                        Ctrl.Visible = False
                        GetObj(Sq) = Ctrl
                    End If
                Next

                Sq = 0
                'Dim Cnt As Integer = -1
                For Each dRow As DataRow In dRows
                    Sq = ToDec(dRow("sq"))
                    If Sq > 0 Then
                        FormNm = ToStr(dRow("form_nm"))
                        Title = ToStr(dRow("tit"))
                        Cal = ToStr(dRow("cap"))
                        Tag = ToStr(dRow("tag"))
                        BtnTy = ToStr(dRow("btn_ty"))

                        If BtnTy = "D" Then 'DropDown
                            'JmpObj2(Sq) = FormNm
                            GetObj2(Sq).Text = Title
                            GetObj2(Sq).ToolTipTitle = Title
                            GetObj2(Sq).ToolTip = Cal
                            SetBtnFont(GetObj2(Sq), Tag)
                        Else
                            JmpObj(Sq) = FormNm
                            GetObj(Sq).Text = Title
                            GetObj(Sq).ToolTipTitle = Title
                            GetObj(Sq).ToolTip = Cal
                            SetBtnFont(GetObj(Sq), Tag)
                        End If
                    End If
                Next

                If dSet.Tables(1).Rows.Count <= 0 Then Exit Sub
                PupUp(GetObj2, DataSetRows(dSet, 1))

            End If
        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Sub PupUp(btn() As DevExpress.XtraEditors.DropDownButton, dRows As DataRowCollection)
        Try
            Dim BarMgr = New DevExpress.XtraBars.BarManager
            Dim Cnt As Integer = -1, FormNm As String = "", Title As String = "", Cal As String = "", Tag As String = "", Sq As Integer = 0
            Dim PopupMenu As New DevExpress.XtraBars.PopupMenu

            'PopupMenu.MenuDrawMode = DevExpress.XtraBars.MenuDrawMode.LargeImagesText

            'BarMgr.ap
            For Each dRow As DataRow In dRows
                Sq = ToDec(dRow("sq"))
                If Sq > 0 Then
                    Dim BarButtonItm As New DevExpress.XtraBars.BarButtonItem
                    Cnt += 1
                    FormNm = ToStr(dRow("form_nm"))
                    Title = ToStr(dRow("tit"))
                    Cal = ToStr(dRow("cap"))
                    Tag = ToStr(dRow("tag"))

                    BarButtonItm.Caption = Title
                    BarButtonItm.Id = Cnt
                    BarButtonItm.Name = "barbtn_" & FormNm
                    BarButtonItm.Tag = Tag
                    If Tag <> "Y" Then BarButtonItm.Enabled = False

                    'Dim eventMenuClick As EventHandler = New EventHandler(AddressOf _MenuButton_Click)
                    BarMgr.Items.Add(BarButtonItm)
                    PopupMenu.AddItem(BarButtonItm)
                    AddHandler BarButtonItm.ItemClick, AddressOf _MenuButton_Click
                End If
            Next
            PopupMenu.Manager = BarMgr
            PopupMenu.MenuAppearance.Menu.Font = New System.Drawing.Font("Tahoma", 14, FontStyle.Bold)
            btn(Sq).DropDownControl = PopupMenu

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
    Private Sub Panel1_Resize(ByVal sender As Object, ByVal e As System.EventArgs)
        'PalResize()
    End Sub

    'Private Sub PalResize()
    '    With Panel1
    '        'H 325(실제290), W 990
    '        Dim W As Integer = .Width, H As Integer = .Height
    '        Dim StdL As Integer = 0, StdTop As Integer = 0
    '        If W <= 1025 Then
    '            StdL = 360
    '        Else
    '            StdL = (W - 1025) + 360
    '        End If

    '        btn_01.Left = StdL
    '        btn_03.Left = StdL
    '        btn_05.Left = StdL
    '        btn_07.Left = StdL
    '        btn_09.Left = StdL
    '        btn_11.Left = StdL

    '        StdL += 320
    '        btn_02.Left = StdL
    '        btn_04.Left = StdL
    '        btn_06.Left = StdL
    '        btn_08.Left = StdL
    '        btn_10.Left = StdL
    '        btn_12.Left = StdL

    '        StdTop = 116 '35
    '        btn_01.Top = StdTop
    '        btn_02.Top = StdTop

    '        StdTop += 75
    '        btn_03.Top = StdTop
    '        btn_04.Top = StdTop

    '        StdTop += 75
    '        btn_05.Top = StdTop
    '        btn_06.Top = StdTop

    '        StdTop += 75
    '        btn_07.Top = StdTop
    '        btn_08.Top = StdTop

    '        StdTop += 75
    '        btn_09.Top = StdTop
    '        btn_10.Top = StdTop

    '        StdTop += 75
    '        btn_11.Top = StdTop
    '        btn_12.Top = StdTop

    '    End With
    'End Sub

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
                Cursor.Current = Cursors.WaitCursor
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
            Finally
                Cursor.Current = Cursors.Default
            End Try

        End If

    End Sub

    Private Sub CallForm2(ByVal GetObject As Object)
        If GetObject.Tag <> "Y" Then
            MessageInfo("현재 프로그램 수정 반영중입니다.") '현재 프로그램 수정 반영중입니다.
        Else
            Dim GetFormNm As String = GetObject.Name.ToString.Replace("barbtn_", "")
            If GetFormNm = "" Then Exit Sub
            Try
                Cursor.Current = Cursors.WaitCursor
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
            Finally
                Cursor.Current = Cursors.Default
            End Try

        End If

    End Sub

    Private Sub btn_Click(sender As System.Object, e As System.EventArgs) Handles btn_01.Click, btn_02.Click, btn_03.Click, btn_04.Click, btn_05.Click, btn_06.Click, _
                                                                                    btn_07.Click, btn_08.Click, btn_09.Click, btn_10.Click, btn_11.Click, btn_12.Click
        CallForm(sender)
    End Sub

    'Private Sub btnd_Click(sender As System.Object, e As System.EventArgs) Handles btnd_01.Click, btnd_02.Click, btnd_03.Click, btnd_04.Click, btnd_05.Click, btnd_06.Click, _
    '                                                                                btnd_07.Click, btnd_08.Click, btnd_09.Click, btnd_10.Click, btnd_11.Click, btnd_12.Click
    '    CallForm(sender)
    'End Sub

    'Private Sub btnd_ShowDropDownControl(sender As Object, e As DevExpress.XtraEditors.ShowDropDownControlEventArgs) Handles btnd_01.ShowDropDownControl, btnd_02.ShowDropDownControl, _
    '                                                                                                                            btnd_03.ShowDropDownControl, btnd_04.ShowDropDownControl, _
    '                                                                                                                            btnd_05.ShowDropDownControl, btnd_06.ShowDropDownControl, _
    '                                                                                                                            btnd_07.ShowDropDownControl, btnd_08.ShowDropDownControl, _
    '                                                                                                                            btnd_09.ShowDropDownControl, btnd_10.ShowDropDownControl, _
    '                                                                                                                            btnd_11.ShowDropDownControl, btnd_12.ShowDropDownControl
    '    CallForm2(sender)
    'End Sub

    Private Sub _MenuButton_Click(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        CallForm2(e.Item)
    End Sub

End Class
