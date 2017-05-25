Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes


Public Class DMB110
    Private ChgStop As Boolean


    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Init_Form()
    End Sub

    Public Sub Init_Form()

        treeFields.OptionsView.AutoWidth = False
        treeFields.OptionsBehavior.Editable = False
        'treeFields.OptionsBehavior.DragNodes = True
        treeFields.OptionsSelection.InvertSelection = True
        treeFields.OptionsView.ShowIndicator = False
        treeFields.FixedLineWidth = 1


        Me._Init_TreeField()

        EPanel2.SetSplitter(SplitContainer2, SplitContainer2.Panel2)
        EPanel3.SetSplitter(SplitContainer2, SplitContainer2.Panel1)
        ' EPanel20.SetSplitter(SplitContainer2, SplitContainer2.Panel2)

        'Btn_BomCopy.Enabled = False

    End Sub

    Private Sub _Init_TreeField()

        Me._Add_TreeField(treeFields, "      Part No.", "itm_cd", 200, , True)
        Me._Add_TreeField(treeFields, "Desc.", "itm_nm", 160)
        Me._Add_TreeField(treeFields, "Item ID", "itm_id", 10, False)
        'Me._Add_TreeField(treeFields, "Item Rev", "itm_rev", 10, False)
        Me._Add_TreeField(treeFields, "Qty.", "itm_qty", 70, , , True, False, , True)
        Me._Add_TreeField(treeFields, "단위", "um_bc", 60, , , True, False, , True)
        Me._Add_TreeField(treeFields, "생산공정", "prc_cd", 80, , , True, False, , True)
        Me._Add_TreeField(treeFields, "Key", "id", 100, False) 'PK

    End Sub



#Region " Tree Init & Open "


    Private Sub _Open_TreeView()
        Dim p As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing
        Dim n As DevExpress.XtraTreeList.Nodes.TreeListNode

        Try
            treeFields.BeginUnboundLoad()
            treeFields.ClearNodes()

            Dim prm As New OpenParameters
            prm.Add("@itm_pid", itm_pid.Text)
            prm.Add("@itm_rev", itm_rev.Text)

            Dim dSet As DataSet = OpenDataSet("dmb110_tree", prm)

            If IsEmpty(dSet) Then
                'Dim p1 As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing
                'treeFields.AppendNode(New Object() {"Not found Item", "", "", "", "", ""}, p1)
                n = Me._AddNode(p, itm_pcd.Text, itm_pnm.Text, itm_pid.Text, 1, "", "", "")
                n.StateImageIndex = 1
                'Me._SelectNode(n)
                treeFields.EndUnboundLoad()
                Exit Sub
            End If

            Dim pId As String, id As String, ItmCd As String, ItmNm As String, ItmId As String, qty As Decimal, umbc As String, prcCd As String
            Dim prodYn As String, semiYn As String, phanYn As String
            Dim ImgIdx As Integer = 0

            For Each r As DataRow In dSet.Tables(0).Rows
                id = r.Item("id")
                pId = r.Item("p_id")
                ItmCd = r.Item("itm_cd")
                ItmNm = r.Item("itm_nm")
                ItmId = ToDec(r.Item("itm_id"))
                'Itmrev = ToDec(r.Item("itm_rev"))
                qty = ToDec(r.Item("itm_qty"))
                umbc = ToStr(r.Item("um_bc"))
                prcCd = ToStr(r.Item("prc_cd"))

                prodYn = ToStr(r.Item("prod_yn"))
                semiYn = ToStr(r.Item("semi_yn"))
                phanYn = ToStr(r.Item("phantom_yn"))

                ImgIdx = 0

                'ImgIdx = 3

                If prodYn = "Y" Then '제품
                    ImgIdx = 1
                Else
                    If semiYn = "Y" Then '반제품
                        ImgIdx = 2
                    Else
                        If phanYn = "Y" Then
                            ImgIdx = 3 '가상품
                        End If
                    End If
                End If

                Try

                    p = treeFields.FindNodeByFieldValue("id", pId)
                    n = Me._AddNode(p, ItmCd, ItmNm, ItmId, qty, umbc, prcCd, id)
                    n.StateImageIndex = ImgIdx

                Catch ex As Exception

                End Try
            Next

            treeFields.EndUnboundLoad()

        Catch ex As Exception
            MessageInfo(Err.Description, "Tree Open()")
        End Try

    End Sub

    Private Function _AddNode(ByVal p As DevExpress.XtraTreeList.Nodes.TreeListNode, _
                              ByVal itmCd As String, ByVal itmNm As String, ByVal itmId As String, ByVal qty As Decimal,
                              ByVal umbc As String, ByVal prcCd As String, ByVal id As String _
                              ) As DevExpress.XtraTreeList.Nodes.TreeListNode

        Return treeFields.AppendNode(New Object() {itmCd, itmNm, itmId, qty, umbc, prcCd, id}, p)

    End Function

#End Region

    Private Sub _Add_TreeField(ByVal tList As TreeList, ByVal caption As String, ByVal fldNm As String, _
                          ByVal wid As Integer, _
                          Optional ByVal show As Boolean = True, _
                          Optional ByVal fixed As Boolean = False, _
                          Optional ByVal [readonly] As Boolean = False, _
                          Optional ByVal editable As Boolean = True, _
                          Optional ByVal checkbox As Boolean = False, _
                          Optional ByVal numeric As Boolean = False)

        Dim c As DevExpress.XtraTreeList.Columns.TreeListColumn

        c = tList.Columns.Add()
        c.Caption = caption
        c.FieldName = fldNm
        c.Width = wid
        c.Visible = show

        If numeric Then
            Dim edit As New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

            edit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            edit.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            edit.DisplayFormat.FormatString = "#,###.#####"
            edit.EditFormat.FormatString = "#,###.#####"
            c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            c.ColumnEdit = edit
        End If

        If checkbox Then
            Dim edit As New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit

            edit.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
            edit.ValueChecked = "1"
            edit.ValueGrayed = "0"
            edit.ValueUnchecked = "0"
            c.ColumnEdit = edit
        End If

        If fixed Then
            c.Fixed = Columns.FixedStyle.Left
        End If
        If [readonly] Then
            c.AppearanceCell.ForeColor = Color.Gray
        End If

        c.OptionsColumn.AllowEdit = editable

    End Sub

    Private Sub chk_expand_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_expand.CheckedChanged
        Me._ExpandTree()
    End Sub

    Private Sub _ExpandTree()
        If chk_expand.Checked Then
            treeFields.ExpandAll()
        Else
            treeFields.CollapseAll()
        End If

    End Sub


    Private Sub g10_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging
        If ColumnName = "chk" Then
            If g10.Text("bom_cnt") <> 0 And Value = "1" Then
                MsgBox("BOM 구성된 품목은 선택 할수 없습니다")
                g10.UpdateRow()
                g10.Text("chk", RowIndex) = "0"
                Exit Sub
            End If

        End If
    End Sub

    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.DoubleClick

        If g10.Text("bom_cnt") > 0 Then
            itm_pcd.Text = g10.Text("itm_cd")
            itm_pnm.Text = g10.Text("itm_nm")
            itm_pid.Text = g10.Text("itm_id")

        Else
            itm_pcd.Text = ""
            itm_pnm.Text = ""
            itm_pid.Text = ""
            MsgBox("BOM 구성품목이 아닙니다")
        End If
        Me._Open_TreeView()
        Me._ExpandTree()

    End Sub

    Private Sub Btn_BomCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_BomCopy.Click

        If Not CheckRequired(itm_pid) Then
            Exit Sub
        End If

        If g10.CheckedRows("chk") = 0 Then
            Exit Sub
        End If


        If Me.Save() Then
            Me.Open()
        End If


    End Sub

    Private Sub itm_pcd_TextChanged(ByVal sender As Object, ByVal oldValue As String) Handles itm_pcd.TextChanged
        Me._Open_TreeView()

        chk_expand.Checked = True
        treeFields.ExpandAll()
    End Sub

    Private Sub treeFields_AfterCollapse(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs) Handles treeFields.AfterCollapse
        e.Node.StateImageIndex = 1
    End Sub

    Private Sub treeFields_AfterExpand(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs) Handles treeFields.AfterExpand
        e.Node.StateImageIndex = 2
    End Sub


End Class
