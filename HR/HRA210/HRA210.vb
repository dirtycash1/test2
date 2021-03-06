﻿Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class HRA210

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

        g10.RowHeight += 80
        g10.ColumnWidth("photo") += 80

        Tree_Open(TreeView1)

        If TreeView1.Nodes IsNot Nothing AndAlso 0 < TreeView1.Nodes.Count Then
            TreeView1.Nodes(0).Expand()
        End If

        Me._ExpandTree()


        'Me.Open("hra210_g10")

        'g10.AddNewRow()

    End Sub

    Private Sub Tree_Open(ByVal TreeView As Object)
        Try
            Dim dSet As DataSet, dRows As DataRowCollection, dRow As DataRow
            TreeView.BeginUpdate()
            TreeView.Nodes.Clear()

            'Command 생성
            dSet = Me.OpenDataSet("hra210_tree")
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

    Private Sub TreeView1_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect

        'If e.Node Is Nothing Then
        '    Exit Sub
        'End If

        'If e.Node.Tag = "" Then
        '    Exit Sub
        'End If

        'Dim s(0) As String
        's(0) = "dept_cd=" + e.Node.Tag

        'g10.Find(s)

        Dim p As New OpenParameters
        p.Add("@dept_cd", e.Node.Tag)
        p.Add("@dept_chk", dept_chk.Text)
        Me.Open("HRA210_g10", p)


    End Sub

    Private Sub expand_yn_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles expand_yn.CheckedChanged
        Me._ExpandTree()
    End Sub

    Private Sub _ExpandTree()
        For Each n As TreeNode In TreeView1.Nodes
            If expand_yn.Checked Then
                n.ExpandAll()
            Else
                n.Collapse()
            End If
        Next
    End Sub

    'Private Sub _ExpandPhoto()
    '    If big_chk.Checked Then
    '        g10.RowHeight() = "160"
    '    Else
    '        g10.RowHeight() = "80"
    '    End If
    'End Sub


    Private Sub g10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g10.Load
        g10.RowHeight = 80
    End Sub

    'Private Sub big_chk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me._ExpandPhoto()
    'End Sub

    Private Sub btn_p_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_p.Click
        If 500 <= g10.RowHeight Then
            Exit Sub
        End If
        g10.RowHeight += 80
        g10.ColumnWidth("photo") += 80
        'g10.BestFitColumns()
    End Sub

    Private Sub btn_m_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_m.Click
        If g10.RowHeight <= 80 Then
            Exit Sub
        End If
        g10.RowHeight -= 80
        g10.ColumnWidth("photo") -= 80
    End Sub

End Class






