Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class SCM151
    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim cd As String
        If Parameter.System.WebSelectedIndex = 0 Then
            cd = Parameter.System.Code
            system_cd.AddItem(cd, cd)
        Else
            Dim wl As Base7.Parameter.WebList
            For Each wl In Parameter.System.WebLists
                cd = wl.SystemCode
                system_cd.AddItem(cd, cd)
            Next
        End If

        system_cd.Text = Parameter.System.Code
        g10.SelectRow = True
        g20.SelectRow = True
        g30.ShowRowHeaders = False

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            'Case MenuType.Open

            '    Me._Open()

            'Me.Open()
            Case MenuType.Save

                Me.Save()

            Case Else

                MyBase.MenuButton_Click(mty)

        End Select
    End Sub

    'Private Sub _Open()
    '    Try
    '        'If Not CheckBeforeOpen Then Exit Sub
    '        rol_cd.Text = ""
    '        Open_TreeView1()

    '    Catch ex As Exception
    '        MessageInfo(ex.Message, "Open")
    '    End Try
    'End Sub

    'Private Sub Open_TreeView1()

    '    TreeView1.BeginUpdate()

    '    Call TreeView1.Nodes.Clear()


    '    Dim p As New OpenParameters
    '    p.Add("@rol_nm", rol_nm.Text)


    '    Dim dSet As DataSet = OpenDataSet("scm150_role_tree", p)

    '    If IsEmpty(dSet) Then
    '        TreeView1.EndUpdate()
    '        Exit Sub
    '    End If

    '    Dim dRows As DataRowCollection, dRow As DataRow

    '    dRows = dSet.Tables(0).Rows
    '    Dim tNode As TreeNode, parent As String, roleId As String, roleNm As String
    '    For Each dRow In dRows

    '        parent = ToStr(dRow("parent"))
    '        roleId = ToStr(dRow("rol_cd"))
    '        roleNm = IIf(ToStr(dRow("nm")) <> "", "[" & ToStr(dRow("nm")) & "] ", "") & ToStr(dRow("rol_nm"))

    '        If parent = "" Then
    '            tNode = TreeView1.Nodes.Add(roleNm)
    '            tNode.Tag = roleId
    '            tNode.ImageIndex = 0
    '            tNode.ForeColor = Color.DarkViolet
    '        Else
    '            tNode = Me._FindNode(TreeView1.Nodes, parent)
    '            If Not IsNothing(tNode) Then
    '                tNode = tNode.Nodes.Add(roleNm)
    '                tNode.Tag = roleId
    '                tNode.ImageIndex = 0
    '                tNode.ForeColor = Color.Black
    '            End If
    '        End If

    '    Next

    '    ExpandTreeView(chk_expand, TreeView1)

    '    TreeView1.EndUpdate()

    '    'Focus Node를 제일 위로 옮긴다
    '    If Not IsNothing(TreeView1.Nodes) Then
    '        TreeView1.SelectedNode = TreeView1.Nodes(0)
    '    End If

    'End Sub

    Private Sub Open_TreeView()
        Try
            TreeView.BeginUpdate()

            Call TreeView.Nodes.Clear()

            Dim p As New OpenParameters
            p.Add("@system_cd", system_cd.Text)
            p.Add("@reg_id", reg_id.Text)

            Dim dSet As DataSet = OpenDataSet("scm151_menu_tree", p)

            If IsEmpty(dSet) Then
                TreeView.EndUpdate()
                Exit Sub
            End If


            Dim dRows As DataRowCollection, dRow As DataRow
            dRows = dSet.Tables(0).Rows
            Dim tNode As TreeNode, parent As String, Id As String, Nm As String
            Dim sPriv As String
            For Each dRow In dRows

                parent = ToStr(dRow("up_cd"))
                Id = ToStr(dRow("menu_cd"))
                Nm = ToStr(dRow("menu_nm"))
                sPriv = ToStr(dRow("read_yn"))

                If parent = "" Then
                    tNode = TreeView.Nodes.Add(Nm)
                    tNode.Tag = Id
                    tNode.ImageIndex = 0
                    tNode.ForeColor = Color.Red

                    If chk_expand.Checked Then tNode.Expand()

                    Select Case sPriv
                        Case "0"
                            tNode.ImageIndex = 0
                        Case "1"
                            tNode.ImageIndex = 1
                            'Case "X"
                            '    tNode.ImageIndex = 2
                            'Case Else
                            '    tNode.ImageIndex = 3
                    End Select

                Else
                    tNode = Me._FindNode(TreeView.Nodes, parent)
                    If Not IsNothing(tNode) Then
                        tNode = tNode.Nodes.Add(Nm)
                        tNode.Tag = Id
                        tNode.ImageIndex = 0
                        tNode.ForeColor = Color.Black

                        Select Case sPriv
                            Case "0"
                                tNode.ImageIndex = 0
                            Case "1"
                                tNode.ImageIndex = 1
                                'Case "X"
                                '    tNode.ImageIndex = 2
                                'Case Else
                                '    tNode.ImageIndex = 3

                        End Select
                    End If
                End If

            Next

            ExpandTreeView(chk_expand, TreeView)

            TreeView.EndUpdate()

            'Focus Node를 제일 위로 옮긴다
            If Not IsNothing(TreeView.Nodes) Then
                TreeView.SelectedNode = TreeView.Nodes(0)
            End If

        Catch ex As Exception
            MessageError(ex)
        End Try

    End Sub


    '[확장]
    Private Sub ExpandTreeView(ByVal objExp As Object, ByVal objTree As Object)
        If objExp.Checked Then
            objTree.ExpandAll()
        Else
            objTree.CollapseAll()
        End If
    End Sub

    '[재귀호출에 의한 Node찾기]
    Private Function _FindNode(ByRef nc As TreeNodeCollection, ByVal menuID As String) As TreeNode
        Dim n As TreeNode, s As TreeNode
        If nc Is Nothing Then Return Nothing

        For Each n In nc
            If n.Tag = menuID Then
                Return n
            End If
            If Not IsNothing(n.Nodes) Then
                s = Me._FindNode(n.Nodes, menuID)
                If Not IsNothing(s) Then
                    Return s
                End If
            End If
        Next
        Return Nothing
    End Function

    'Private Sub TreeView_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs)
    '    Try
    '        Dim parentNm As String, parentId As String
    '        parentNm = e.Node.Text
    '        parentId = e.Node.Tag

    '        If Not e.Node.Parent Is Nothing Then
    '            parentNm = e.Node.Parent.Text
    '            parentId = e.Node.Parent.Tag
    '        End If


    '        '종전조회된 정보와 클릭된 정보가 같은경우 재open하지 않는다
    '        ' If role_id.Text = parentId Then Exit Sub

    '        rol_cd.Text = parentId
    '        rol_nm2.Text = parentNm '& e.Node.Text

    '        Me.Open_TreeView()

    '    Catch ex As Exception
    '        MessageInfo(ex.Message, "TreeView1_AfterSelect")
    '    End Try
    'End Sub

    Private Sub TreeView_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView.AfterSelect
        e.Node.SelectedImageIndex = e.Node.ImageIndex
        Try
            Dim menuCd As String
            menuCd = e.Node.Tag

            'Dim oParam As Object = Nothing
            'AddParam(oParam, "@menu_cd", menuCd)

            Dim p As New OpenParameters
            p.Add("@system_cd", system_cd.Text)
            p.Add("@menu_cd", menuCd)
            p.Add("@reg_id", reg_id.Text)

            Me.Open("scm151_g30", p)

        Catch ex As Exception
            MessageInfo(ex.Message, "TreeView1_AfterSelect")
        End Try
    End Sub

    '[하위항목을 찾아 상위항목의 권한과 동일 하도록 변경처리]
    Private Function SetChildImage(ByRef nc As TreeNodeCollection, ByVal menuID As String, ByVal aNode As TreeNode) As TreeNode
        Dim n As TreeNode, s As TreeNode
        If nc Is Nothing Then Return Nothing

        For Each n In nc
            If n.Tag <> menuID Then
                If n.Parent.Tag = menuID Then
                    n.ImageIndex = aNode.ImageIndex
                End If
            End If

            If Not IsNothing(n.Nodes) Then
                s = SetChildImage(n.Nodes, n.Tag, n)
                If Not IsNothing(s) Then
                    Return s
                End If
            End If
        Next

        Return Nothing
    End Function


    Private v_LockEvent As Boolean

    '    Private Sub g30_CellValueChanged(ByVal sender As Object, ByVal colName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g30.CellValueChanged
    Private Sub g30_CellValueChanging(ByVal sender As Object, ByVal colName As String, ByVal RowIndex As Integer, ByRef Value As Object)
        With g30

            If v_LockEvent Then
                Exit Sub
            End If
            v_LockEvent = True

            If colName = "add_yn" Then
                If ToBool(Value) Then   'If .ToBool(colName) Then
                    .Text("mod_yn") = "1"
                End If
            End If
            If colName = "add_yn" Or colName = "mod_yn" Or colName = "del_yn" Or colName = "prt_yn" Then
                If ToBool(Value) Then   'If .ToBool(colName) Then
                    .Text("read_yn") = "1"
                End If
            End If
            If colName = "read_yn" Or colName = "add_yn" Or colName = "mod_yn" Or colName = "del_yn" Or colName = "prt_yn" Then
                If ToBool(Value) Or .ToBool("read_yn") Or .ToBool("add_yn") Or .ToBool("mod_yn") Or .ToBool("del_yn") Or .ToBool("prt_yn") Then
                    .Text("all_yn") = "1"
                Else
                    .Text("all_yn") = "0"
                End If
            End If
            If colName = "read_yn" Then
                If ToBool(Value) Then   'If .ToBool(colName) Then
                    .Text("all_yn") = "1"
                End If
            End If
            If colName = "all_yn" Then
                .Text("read_yn") = Value '.Text("all_yn")
                .Text("add_yn") = Value '.Text("all_yn")
                .Text("mod_yn") = Value '.Text("all_yn")
                .Text("del_yn") = Value '.Text("all_yn")
                .Text("prt_yn") = Value '.Text("all_yn")

            End If

            If .Text("form_cd") = "" Then
                If Not chk_under.Checked Then
                    v_LockEvent = False
                    Exit Sub
                End If
                Dim lv As Integer = .ToDec("lv")
                Dim iRow As Integer, oRow As Integer = .RowIndex

                For iRow = .RowIndex + 1 To .RowCount - 1
                    If .ToDec("lv", iRow) <= lv Then
                        Exit For
                    End If
                    'If .IsRecordRow(iRow) Then
                    If colName = "all_yn" Then
                        .Text("all_yn", iRow) = Value '.Text("all_yn")
                        .Text("read_yn", iRow) = Value '.Text("all_yn")
                        .Text("add_yn", iRow) = Value '.Text("all_yn")
                        .Text("mod_yn", iRow) = Value '.Text("all_yn")
                        .Text("del_yn", iRow) = Value '.Text("all_yn")
                        .Text("prt_yn", iRow) = Value '.Text("all_yn")
                    End If
                    If colName = "read_yn" Then .Text("read_yn", iRow) = Value '.Text("read_yn")
                    If colName = "add_yn" Then .Text("add_yn", iRow) = Value '.Text("add_yn")
                    If colName = "mod_yn" Then .Text("mod_yn", iRow) = Value '.Text("mod_yn")
                    If colName = "del_yn" Then .Text("del_yn", iRow) = Value '.Text("del_yn")
                    If colName = "prt_yn" Then .Text("prt_yn", iRow) = Value '.Text("prt_yn")

                    If .ToBool("add_yn", iRow) Then
                        .Text("mod_yn", iRow) = "1"
                    End If
                    If .ToBool("add_yn", iRow) Or .ToBool("mod_yn", iRow) Or .ToBool("del_yn", iRow) Or .ToBool("prt_yn", iRow) Then
                        .Text("read_yn", iRow) = "1"
                    End If

                    If .ToBool("read_yn", iRow) Or .ToBool("add_yn", iRow) Or .ToBool("mod_yn", iRow) Or .ToBool("del_yn", iRow) Or .ToBool("prt_yn", iRow) Then
                        .Text("all_yn", iRow) = "1"
                    Else
                        .Text("all_yn", iRow) = "0"
                    End If
                    'End If
                Next

                .RowIndex = oRow

            End If

        End With
        v_LockEvent = False
    End Sub

    Private Sub chk_expand_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_expand.CheckedChanged
        TreeView.BeginUpdate()
        Me.ExpandTreeView(chk_expand, TreeView)
        TreeView.EndUpdate()
    End Sub

    '[splitter resize]
    Private Sub optAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAll.CheckedChanged
        If optAll.Checked Then
            SplitContainer2.Panel1Collapsed = False
        End If
    End Sub

    Private Sub optMenu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optMenu.CheckedChanged
        If optMenu.Checked Then
            SplitContainer2.Panel1Collapsed = True
        End If
    End Sub

    Private Sub g10_AfterMoveRow(sender As Object, PrevRowIndex As Integer, RowIndex As Integer) Handles g10.AfterMoveRow
        Try
            reg_nm.Text = g10.Text("id") & " : " & g10.Text("nm")
            reg_id.Text = g10.Text("reg_id")
            Open_TreeView()

        Catch ex As Exception

        End Try

    End Sub
End Class
