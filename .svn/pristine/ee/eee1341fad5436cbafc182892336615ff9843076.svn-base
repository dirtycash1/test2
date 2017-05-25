Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class FAA100
    Private m_FocusedWorkSet As WorkSet

    Private Sub FAA100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        EPanel1.SetSplitter(SplitContainer1, SplitContainer1.Panel1)
        EPanel21.SetSplitter(SplitContainer6, SplitContainer6.Panel2)
        EPanel22.SetSplitter(SplitContainer6, SplitContainer6.Panel1)

        g30.SelectRow = True
        g30.ShowFilterRow = True
        g30.RecordNavigator = True

        g40.SelectRow = True
        XtraTabControl2.SelectedTabPageIndex = 1
        XtraTabControl2.SelectedTabPageIndex = 0

        'XtraTabControl2.SelectedTabPageIndex = 1
        'XtraTabPage3.PageVisible = False

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                sys_cd.ReadOnly = True
                sys_cd.DefaultText = sys_cd.Text

                Me.Open()
                Me.Tree_Open()
            Case MenuType.Save
                If Me.Save() Then
                    Me.Open()
                End If
            Case MenuType.Delete
                Me.WorkSet("faa100_f10").DeleteRow()
                Me._Open_Form("*")

            Case MenuType.New
                sys_cd.ReadOnly = False
                sys_cd.DefaultText = sys_cd.Text

                acc_cd.Text = ""
                Me._Open_Form("*")

            Case MenuType.Excel
            Case MenuType.Print
        End Select

    End Sub

    Private Sub _Open_Form(ByVal accCd As String)

        Dim p As New OpenParameters
        p.Add("@acc_cd", accCd)
        p.Add("@sys_cd", sys_cd.Text)

        Me.Open("faa100_f10", p)
        Me.Open("faa100_g10", p)
        Me.Open("faa100_g20", p)
    End Sub

    Private Sub _Open_Acc(ByVal accCd As String)
        Me._Open_Form(accCd)

        Dim fnd(0) As String
        fnd(0) = "acc_cd=" + accCd
        g30.Find(fnd)
    End Sub


    '[트리구조확장]
    Private Sub chk_expand_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles exp_yn.CheckedChanged
        Me.ExpandTreeView()
    End Sub

    Private Sub doc_yn2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mng_yn.CheckedChanged
        Me.Tree_Open()
    End Sub

    Private Sub btn_open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_open.Click

        If XtraTabControl2.SelectedTabPageIndex = 0 Then
            sys_cd.ReadOnly = True
            sys_cd.DefaultText = sys_cd.Text

            Me.Tree_Open()
        Else
            g40.Open()

        End If

    End Sub

    Private Sub Tree_Open()
        Try
            Dim dSet As DataSet, dRows As DataRowCollection, dRow As DataRow
            TreeView1.BeginUpdate()
            TreeView1.Nodes.Clear()

            Dim P As New OpenParameters
            P.Add("@sys_cd", sys_cd.Text)
            P.Add("@mng_yn", mng_yn.Text)

            'Command 생성
            dSet = Me.OpenDataSet("FAA100_Tree", P)
            dRows = dSet.Tables(0).Rows
            Dim itm As TreeNode
            Dim accCd As String, accNm As String, sUp As String
            Dim docYn As String, mngYn As String, seqNo As String
            For Each dRow In dRows
                sUp = ToStr(dRow("up"))
                accCd = ToStr(dRow("code"))
                accNm = ToStr(dRow("name"))
                docYn = ToStr(dRow("doc_yn"))
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

    Private Sub TreeView1_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect

        Dim accCd As String = e.Node.Tag

        Me._Open_Acc(accCd)

    End Sub

    Private Sub ExpandTreeView()
        If exp_yn.Checked Then
            TreeView1.ExpandAll()
        Else
            TreeView1.CollapseAll()
        End If
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

    Private Sub btn_copy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_copy.Click

        If acc_cd.Text = "" Then
            MsgBox("계정을 먼저 선택하세요")
            Exit Sub
        End If

        Dim dSet1 As DataSet = Me.WorkSet("faa100_f10").DataSet
        Dim dSet2 As DataSet = Me.WorkSet("faa100_g10").DataSet
        Dim dSet3 As DataSet = Me.WorkSet("faa100_g20").DataSet

        Me._Open_Form("*")

        up_cd.Text = DataValue(dSet1, "up_cd")
        acc_bc.Text = DataValue(dSet1, "acc_bc")
        doc_yn.Text = DataValue(dSet1, "doc_yn")
        item_yn.Text = DataValue(dSet1, "item_yn")
        budg_yn.Text = DataValue(dSet1, "budg_yn")
        ctrl_yn.Text = DataValue(dSet1, "ctrl_yn")
        pay_yn.Text = DataValue(dSet1, "pay_yn")
        frgn_yn.Text = DataValue(dSet1, "frgn_yn")
        pre_yn.Text = DataValue(dSet1, "pre_yn")
        del_yn.Text = DataValue(dSet1, "del_yn")

        If Not IsEmpty(dSet2) Then
            With g10
                Dim iRow As Integer = 0
                Dim dRow As DataRow, dRows As DataRowCollection
                dRows = dSet2.Tables(0).Rows

                For Each dRow In dRows

                    .AddNewRow()
                    .RowIndex = iRow

                    .Text("seq_no", iRow) = ToStr(dRow("seq_no"))
                    .Text("mng_no", iRow) = ToStr(dRow("mng_no"))
                    .Text("req_yn", iRow) = ToStr(dRow("req_yn"))
                    .Text("title_yn", iRow) = ToStr(dRow("title_yn"))
                    .Text("code_yn", iRow) = ToStr(dRow("code_yn"))
                    .Text("name_yn", iRow) = ToStr(dRow("name_yn"))
                    .Text("pay_yn", iRow) = ToStr(dRow("pay_yn"))
                    .Text("carry_yn", iRow) = ToStr(dRow("carry_yn"))

                    iRow += 1
                Next
            End With
        End If

        If Not IsEmpty(dSet3) Then
            With g20
                Dim iRow As Integer = 0
                Dim dRow As DataRow, dRows As DataRowCollection
                dRows = dSet3.Tables(0).Rows

                For Each dRow In dRows
                    .AddNewRow()
                    .RowIndex = iRow

                    .Text("seq_no", iRow) = ToStr(dRow("seq_no"))
                    .Text("mng_no", iRow) = ToStr(dRow("mng_no"))
                    .Text("req_yn", iRow) = ToStr(dRow("req_yn"))
                    .Text("title_yn", iRow) = ToStr(dRow("title_yn"))
                    .Text("code_yn", iRow) = ToStr(dRow("code_yn"))
                    .Text("name_yn", iRow) = ToStr(dRow("name_yn"))
                    .Text("pay_yn", iRow) = ToStr(dRow("pay_yn"))
                    .Text("carry_yn", iRow) = ToStr(dRow("carry_yn"))

                    iRow += 1
                Next
            End With
        End If

        acc_cd.Focus()

    End Sub

    Private Sub btn_copy1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_copy1.Click
        With g10
            Dim iRow As Integer = 0
            Dim jRow As Integer = 0

            For iRow = 0 To .RowCount - 1

                g20.AddNewRow()
                jRow = g20.RowIndex
                g20.Text("seq_no", jRow) = .Text("seq_no", iRow)
                g20.Text("mng_no", jRow) = .Text("mng_no", iRow)
                g20.Text("req_yn", jRow) = .Text("req_yn", iRow)
                g20.Text("title_yn", jRow) = .Text("title_yn", iRow)
                g20.Text("code_yn", jRow) = .Text("code_yn", iRow)
                g20.Text("name_yn", jRow) = .Text("name_yn", iRow)
                g20.Text("pay_yn", jRow) = .Text("pay_yn", iRow)
                g20.Text("carry_yn", jRow) = .Text("carry_yn", iRow)

            Next
        End With
    End Sub

    Private Sub btn_copy2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_copy2.Click
        With g20
            Dim iRow As Integer = 0
            Dim jRow As Integer = 0

            For iRow = 0 To .RowCount - 1

                g10.AddNewRow()
                jRow = g10.RowIndex
                g10.Text("seq_no", jRow) = .Text("seq_no", iRow)
                g10.Text("mng_no", jRow) = .Text("mng_no", iRow)
                g10.Text("req_yn", jRow) = .Text("req_yn", iRow)
                g10.Text("title_yn", jRow) = .Text("title_yn", iRow)
                g10.Text("code_yn", jRow) = .Text("code_yn", iRow)
                g10.Text("name_yn", jRow) = .Text("name_yn", iRow)
                g10.Text("pay_yn", jRow) = .Text("pay_yn", iRow)
                g10.Text("carry_yn", jRow) = .Text("carry_yn", iRow)

            Next
        End With
    End Sub

    Private Sub acc_cd4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles acc_cd4.KeyDown, acc_nm4.KeyDown

        If e.KeyCode = Keys.Enter Then
            g40.Open()
        End If

    End Sub

    Private Sub g40_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g40.AfterMoveRow
        Dim accCd As String = g40.Text("acc_cd")

        Me._Open_Acc(accCd)
    End Sub

    Private Sub pay_bc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pay_bc.TextChanged

    End Sub
End Class
