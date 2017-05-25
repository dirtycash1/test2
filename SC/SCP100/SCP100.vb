Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class SCP100

    Private Sub Menus_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ''system_cd.AddItem("CTNT", "CTNT")
        ''system_cd.Text = "CTNT"

        'Dim cd As String
        'If Parameter.System.WebSelectedIndex = 0 Then
        '    cd = Parameter.System.Code
        '    system_cd.AddItem(cd, cd)
        'Else
        '    Dim wl As Base7.Parameter.WebList
        '    For Each wl In Parameter.System.WebLists
        '        cd = wl.SystemCode
        '        system_cd.AddItem(cd, cd)
        '    Next
        'End If
        system_cd.Text = Parameter.System.Code
        'system_cd.Enabled = False
        g10.SelectRow = True

        chk_expand.Visible = False
        btn_refresh.Visible = False
        SplitContainer2.Panel1Collapsed = True

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Open

                Me.Open()

                'Me._Open_TreeView1()

            Case Else

                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    Private Sub _Open_TreeView1()
        On Error GoTo Err1

        TreeView1.BeginUpdate()

        TreeView1.Nodes.Clear()

        Dim dSet As DataSet = g10.DataSet
        If IsEmpty(dSet) Then
            TreeView1.EndUpdate()
            Exit Sub
        End If

        Dim dRows As DataRowCollection, dRow As DataRow
        dRows = DataSetRows(dSet)
        Dim tNode As TreeNode, pMenuID As String, menuID As String, menuNm As String, _
            chkApp As Boolean, chkHid As Boolean, chkUse As Boolean
        For Each dRow In dRows

            pMenuID = ToStr(dRow("up_cd"))
            menuID = ToStr(dRow("menu_cd"))
            menuNm = ToStr(dRow("title"))
            'chkApp = ToBool(dRow("app_yn"))
            'chkHid = ToBool(dRow("hid_yn"))
            'chkUse = ToBool(dRow("use_yn"))

            'Select Case iParams.Language_1
            'menuNm = ToStr(dRow("menu_nm"))

            'epym110f_g1.OpenParam("@lang_no", iParams.Language_1)

            If pMenuID = "" Then
                tNode = TreeView1.Nodes.Add(menuNm)
                tNode.Tag = menuID
                tNode.ImageIndex = 0
            Else
                tNode = FindNode(TreeView1.Nodes, pMenuID)
                If Not IsNothing(tNode) Then
                    tNode = tNode.Nodes.Add(menuNm)
                    tNode.Tag = menuID
                    tNode.ImageIndex = 0
                End If
            End If
            'If Not chkApp Then
            '    tNode.ForeColor = Color.DeepPink
            'End If
            'If chkHid Then
            '    tNode.ForeColor = Color.DarkGray
            'End If
            'If Not chkUse Then
            '    tNode.ForeColor = Color.Teal
            'End If

        Next

        ExpandTreeView()

        TreeView1.EndUpdate()

        Exit Sub

        '        Select Case rs![use_chk]
        '                 Case "-1"
        '                     tNode.Image = 1
        '                 Case Else
        '                     tNode.Image = 3
        '        End Select
        '     End If
Err1:
        MessageInfo(menuID + vbLf + Err.Description, "Tree Open()")
    End Sub

    'Private Sub AddTreeView(ByVal menuID As String, ByVal menuNm As String)
    'tNode = TreeView1.Nodes.Add(menuNm)
    'tNode.Tag = menuID
    'If (chkExpand.Checked) Then tNode.Expand()
    'End Sub

    '재귀호출에 의한 Node찾기
    Private Function FindNode(ByRef nc As TreeNodeCollection, ByVal menuID As String) As TreeNode
        Dim n As TreeNode, s As TreeNode
        If nc Is Nothing Then Return Nothing

        For Each n In nc
            If n.Tag = menuID Then
                Return n
            End If
            If Not IsNothing(n.Nodes) Then
                s = FindNode(n.Nodes, menuID)
                If Not IsNothing(s) Then
                    Return s
                End If
            End If
        Next
        Return Nothing
    End Function

    Private Sub ExpandTreeView()
        TreeView1.BeginUpdate()

        If chk_expand.Checked Then
            TreeView1.ExpandAll()
        Else
            TreeView1.CollapseAll()
        End If

        TreeView1.EndUpdate()
    End Sub

    Private Sub chk_expand_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_expand.CheckedChanged
        Me.ExpandTreeView()
    End Sub

    Private Sub btn_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_refresh.Click
        Me._Open_TreeView1()
    End Sub

    'Private Sub btn_apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_apply.Click
    '    If system_cd.Text <> "" Then Parameter.System.Code = system_cd.Text
    '    Parameter.MainFrame.Frame.ClearMenu()
    '    Parameter.MainFrame.Frame.CreateMenu(system_cd.Text)

    'End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect


        Dim f(0) As String
        f(0) = "menu_cd=" + e.Node.Tag

        g10.Find(f)

    End Sub

End Class
