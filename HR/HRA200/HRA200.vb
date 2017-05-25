Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class HRA200

    Private m_FocusedWorkSet As WorkSet
   
    'Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    Me.New_Form()
    'End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Open
                Me._Open()

            Case MenuType.Save

                If Me.Save() Then
                    Tree_Open(TreeView1)
                    TreeView1.Nodes(0).Expand()
                End If

                'Case MenuType.New
                '    dept_cd.Text = ""
                '    dept_nm.Text = ""
                '    use_yn.Text = "1"

                '    Me.New_Form()

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Private Sub _Open()

        Tree_Open(TreeView1)

        If TreeView1.Nodes IsNot Nothing AndAlso 0 < TreeView1.Nodes.Count Then
            TreeView1.Nodes(0).Expand()
        End If

        Me.Open("hra200_g10")

        g10.AddNewRow()

    End Sub

    Private Sub Tree_Open(ByVal TreeView As Object)
        Try
            Dim dSet As DataSet, dRows As DataRowCollection, dRow As DataRow
            TreeView.BeginUpdate()
            TreeView.Nodes.Clear()

            'Command 생성
            dSet = Me.OpenDataSet("hra200_tree")
            dRows = dSet.Tables(0).Rows
            Dim NodeDept As TreeNode
            Dim sCode As String, sName As String, sParent As String
            Dim ty As String
            For Each dRow In dRows
                sCode = CStr(dRow("cd"))       '코드
                sName = CStr(dRow("nm"))
                sParent = CStr(dRow("up"))
                ty = CStr(dRow("ty"))

                If sParent = "" Then
                    NodeDept = TreeView.Nodes.Add(sCode)
                    NodeDept.Text = "[" & sCode & "] " & sName
                    'NodeDept.Text = sName
                    NodeDept.Tag = sCode
                    NodeDept.ImageIndex = 0
                    NodeDept.ForeColor = Color.Blue
                    'NodeDept.NodeFont = New Font(NodeDept.NodeFont, FontStyle.Bold)
                    'If ty = "0" Then
                    '    NodeDept.Checked = True
                    '    NodeDept.ForeColor = Color.Blue
                    'End If
                Else
                    NodeDept = FindNode(TreeView.Nodes, sParent)
                    If Not IsNothing(NodeDept) Then
                        NodeDept = NodeDept.Nodes.Add(sCode)
                        NodeDept.Text = "[" & sCode & "] " & sName
                        'NodeDept.Text = sName
                        'NodeDept.Tag = sCode
                        NodeDept.Tag = sCode
                        NodeDept.ImageIndex = 0
                        NodeDept.ForeColor = Color.Black
                        'If ty = "0" Then
                        '    NodeDept.Checked = True
                        '    NodeDept.ForeColor = Color.Blue
                        'End If
                    End If
                End If
            Next
            TreeView.CollapseAll()
            TreeView.EndUpdate()
        Catch ex As Exception
            MessageInfo(ex.Message)
        End Try
    End Sub

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

    'Private Sub button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    dept_Tree_Open(TreeView1)
    '    TreeView1.Nodes(0).ExpandAll()
    'End Sub

    'Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    dept_Tree_Open(TreeView1)
    '    TreeView1.Nodes(0).Expand()
    'End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect

        If e.Node Is Nothing Then
            Exit Sub
        End If

        If e.Node.Tag = "" Then
            Exit Sub
        End If

        Dim s(0) As String
        s(0) = "dept_cd=" + e.Node.Tag

        g10.Find(s)

        'Dim p As New OpenParameters
        'p.Add("@dept_cd", e.Node.Tag)
        'p.Add("@use_yn", use_yn.Text)
        'Me.Open("hra200_g10", p)

        'g10.AddNewRow()

    End Sub

    Private Sub expand_yn_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles expand_yn.CheckedChanged
        If expand_yn.Checked Then
            TreeView1.Nodes(0).ExpandAll()
        Else
            TreeView1.Nodes(0).Collapse()
        End If
    End Sub

End Class
