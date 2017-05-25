Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Card
Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class HRA220
    Private Sub HRA220_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'DoUpdateViewStyle("CardView")
        dept_Tree_Open(TreeView1)
        TreeView1.Nodes(0).Expand()
        g10.RowHeight = 100
        AddHandler TreeView1.AfterSelect, AddressOf TreeView1_AfterSelect
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        Dim dSet As DataSet
        Dim p As New OpenParameters
        p.Add("@dept_cd", e.Node.Tag)
        dSet = Me.OpenDataSet("hra220_g20", p)
        Try
            gridControl1.DataSource = Nothing
            gridControl1.DataSource = dSet.Tables(0)
            GridControl2.DataSource = Nothing
            GridControl2.DataSource = dSet.Tables(0)

            layoutView1.OptionsCarouselMode.CardCount = CInt(Fix(20))
            layoutView1.OptionsCarouselMode.RollAngle = CSng((CInt(Fix(50))) / 360.0F * 2 * Math.PI)
            layoutView1.OptionsCarouselMode.PitchAngle = CSng((CInt(Fix(100))) / 360.0F * 2 * Math.PI)
            layoutView1.OptionsCarouselMode.RollAngle = CSng((CInt(Fix(40))) / 360.0F * 2 * Math.PI)
            layoutView1.OptionsCarouselMode.BottomCardAlphaLevel = (CInt(Fix(20))) / 100.0F
            layoutView1.OptionsCarouselMode.BottomCardScale = (CInt(Fix(50))) / 100.0F

            LayoutView2.OptionsCarouselMode.CardCount = CInt(Fix(20))
            LayoutView2.OptionsCarouselMode.RollAngle = CSng((CInt(Fix(50))) / 360.0F * 2 * Math.PI)
            LayoutView2.OptionsCarouselMode.PitchAngle = CSng((CInt(Fix(100))) / 360.0F * 2 * Math.PI)
            LayoutView2.OptionsCarouselMode.RollAngle = CSng((CInt(Fix(40))) / 360.0F * 2 * Math.PI)
            LayoutView2.OptionsCarouselMode.BottomCardAlphaLevel = (CInt(Fix(20))) / 100.0F
            LayoutView2.OptionsCarouselMode.BottomCardScale = (CInt(Fix(50))) / 100.0F
            If DBNull.Value.Equals(gridControl1.DataSource.rows(0).item("emp_no")) Then
                Exit Sub
            Else
                p.Add("@emp_no", gridControl1.DataSource.Rows(0).item("emp_no"))
                Me.Open("hra220_g10", p)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dept_Tree_Open(ByVal TreeView As Object)
        Try
            Dim dSet As DataSet, dRows As DataRowCollection, dRow As DataRow
            TreeView.BeginUpdate()
            TreeView.Nodes.Clear()
            'Command 생성
            dSet = Me.OpenDataSet("hra220_dept_tree")
            dRows = dSet.Tables(0).Rows
            Dim NodeDept As TreeNode
            Dim sCode As String, sName As String, sParent As String
            Dim yn As String, sCodein As String
            For Each dRow In dRows
                sCode = CStr(dRow("code"))       '코드
                sName = CStr(dRow("name"))
                sParent = CStr(dRow("parent"))
                yn = CStr(dRow("use_ty"))
                sCodein = CStr(dRow("code"))
                If sParent = "" Then
                    NodeDept = TreeView.Nodes.Add(sCode)
                    NodeDept.Text = sName
                    NodeDept.Tag = sCodein
                    NodeDept.ImageIndex = 0
                    NodeDept.ForeColor = Color.Blue
                    If yn = "0" Then
                        NodeDept.Checked = True
                        NodeDept.ForeColor = Color.Blue
                    End If
                Else
                    NodeDept = FindNode(TreeView.Nodes, sParent)
                    If Not IsNothing(NodeDept) Then
                        NodeDept = NodeDept.Nodes.Add(sCode)
                        NodeDept.Text = sName
                        NodeDept.Tag = sCodein
                        NodeDept.ImageIndex = 0
                        NodeDept.ForeColor = Color.Black
                        If yn = "0" Then
                            NodeDept.Checked = True
                            NodeDept.ForeColor = Color.Blue
                        End If
                    End If
                End If
            Next
            TreeView.CollapseAll()
            TreeView.EndUpdate()
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "알림")
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

    Private Sub layoutView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles layoutView1.FocusedRowChanged
        Dim p As New OpenParameters
        Dim Row As Integer = sender.FocusedRowHandle
        If DBNull.Value.Equals(gridControl1.DataSource.rows(Row).item("emp_no")) Then
            Exit Sub
        Else
            p.Add("@emp_no", gridControl1.DataSource.Rows(Row).item("emp_no"))
            Me.Open("hra220_g10", p)
        End If
    End Sub
   
End Class
