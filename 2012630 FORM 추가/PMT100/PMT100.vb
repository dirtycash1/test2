Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class PMT100

    Private m_FocusedWorkSet As WorkSet

    Private Sub pmt100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'g10.RecordNavigator = True
        'g20.RecordNavigator = True
        'g30.RecordNavigator = True

        temp_cd.ReadOnly = True
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Open

                Me.Open()

                'Me.Tree_Open()

            Case MenuType.Save

                If Me.Save() Then

                    Dim saveID As String = temp_cd.Text
                    Dim saveID2 As String = g20.Text("step_no")

                    Me.Open()

                    g10.Find("temp_cd=" + saveID)
                    g20.Find("step_no=" + saveID2)

                End If

            Case MenuType.New

                New_Form()

            Case MenuType.Delete

                Me.WorkSet("pmt100_f10").DeleteRow()

                MyBase.Open()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub New_Form()

        temp_cd.Text = ""

        temp_cd.ReadOnly = False

        Me.OpenTrigger("pmt100_g10")
        Me.Tree_Open()

    End Sub
    Private Sub Tree_Open()
        Try
            Dim dSet As DataSet, dRows As DataRowCollection, dRow As DataRow
            TreeView1.BeginUpdate()
            TreeView1.Nodes.Clear()

            'Command 생성
            dSet = Me.OpenDataSet("PMT100_Tree")
            dRows = dSet.Tables(0).Rows
            Dim itm As TreeNode
            Dim accCd As String, accNm As String, sUp As String
            Dim docYn As String, mngYn As String, seqNo As String
            For Each dRow In dRows
                sUp = ToStr(dRow("up"))
                accCd = ToStr(dRow("code"))
                accNm = ToStr(dRow("name"))
                docYn = ToStr(dRow("use_yn"))
                mngYn = ToStr(dRow("mng_yn"))
                seqNo = ToStr(dRow("seq_no"))

                If sUp = "" Then
                    itm = TreeView1.Nodes.Add(accCd)
                    itm.Text = "[" & accCd & "] " & accNm
                    itm.Tag = accCd
                    itm.ImageIndex = 0
                    itm.ForeColor = Color.DarkViolet

                Else
                    itm = TreeItem(TreeView1.Nodes, sUp)
                    If Not IsNothing(itm) Then
                        itm = itm.Nodes.Add(accCd)
                        If mngYn = "0" Then
                            itm.Text = "[" & accCd & "] " & accNm
                        Else
                            itm.Text = "(" & seqNo & ") " & accNm
                        End If

                        itm.Tag = accCd

                        If docYn = "1" Then
                            itm.ForeColor = Color.Blue
                            itm.ImageIndex = 1
                            itm.SelectedImageIndex = 1
                        Else
                            If mngYn = "1" Then
                                itm.ForeColor = Color.DeepPink
                                itm.ImageIndex = 2
                                itm.SelectedImageIndex = 2
                                itm.Tag = sUp
                            Else
                                itm.ForeColor = Color.Green
                                itm.ImageIndex = 0
                            End If

                        End If

                    End If
                End If
            Next
            ExpandTreeView()
            TreeView1.EndUpdate()

        Catch ex As Exception
            MessageInfo(ex)
        End Try
    End Sub
    Private Function TreeItem(ByRef nc As TreeNodeCollection, ByVal cd As String) As TreeNode
        Dim n As TreeNode, s As TreeNode
        If nc Is Nothing Then Return Nothing

        For Each n In nc
            If n.Tag = cd Then
                Return n
            End If
            If Not IsNothing(n.Nodes) Then
                s = TreeItem(n.Nodes, cd)
                If Not IsNothing(s) Then
                    Return s
                End If
            End If
        Next
        Return Nothing
    End Function

    Private Sub ExpandTreeView()
        If exp_yn.Checked Then
            TreeView1.ExpandAll()
        Else
            TreeView1.CollapseAll()
        End If
    End Sub
    '[트리구조확장]
    Private Sub chk_expand_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles exp_yn.CheckedChanged
        Me.ExpandTreeView()
    End Sub

    Private Sub doc_chk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles doc_chk.CheckedChanged
        Me.Tree_Open()
    End Sub

    Private Sub g10_AfterMoveRow(sender As Object, PrevRowIndex As Integer, RowIndex As Integer) Handles g10.AfterMoveRow

        temp_cd.ReadOnly = True

        'g20.Open()
        'g30.Open()

        Me.Tree_Open()

        'Me.OpenTrigger("pmt100_g10")

    End Sub
    Private Sub btn_open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_open.Click

        Me.Tree_Open()

    End Sub

    'Private Sub g20_AfterMoveRow(sender As Object, PrevRowIndex As Integer, RowIndex As Integer) Handles g20.AfterMoveRow
    '    Me.Open("pmt100_g30")

    'End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        g20.Find("step_no=" + e.Node.Tag)
    End Sub

End Class
