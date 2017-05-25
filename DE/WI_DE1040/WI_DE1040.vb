Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes

Public Class WI_DE1040

    Private ChgStop As Boolean
    Dim p As New OpenParameters
    Dim stts As String

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        g20.AllowFilter = False

        treeFields.OptionsView.AutoWidth = False
        treeFields.OptionsBehavior.Editable = False
        treeFields.OptionsSelection.InvertSelection = True
        treeFields.OptionsView.ShowIndicator = False
        treeFields.FixedLineWidth = 1

        Me._Init_TreeField()

        EPanel2.SetSplitter(SplitContainer2, SplitContainer2.Panel1)
        EPanel3.SetSplitter(SplitContainer2, SplitContainer2.Panel1)
        EPanel20.SetSplitter(SplitContainer2, SplitContainer2.Panel2)
    End Sub

    Private Sub _Init_TreeField()

        Me._Add_TreeField(treeFields, "      Part No.", "itm_cd", 200, , True)
        Me._Add_TreeField(treeFields, "Desc.", "itm_nm", 160)
        Me._Add_TreeField(treeFields, "Item ID", "itm_id", 10, False)
        Me._Add_TreeField(treeFields, "소요량.", "itm_qty", 70, , , True, False, , True)
        Me._Add_TreeField(treeFields, "단위", "um_bc", 60, , , True, False, , True)
        Me._Add_TreeField(treeFields, "순번", "prc_cd", 80, , , True, False, , True)
        Me._Add_TreeField(treeFields, "Key", "id", 100, False) 'PK
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Open

                Me._Open_TreeView()
                Me._ExpandTree()

                'Me.Open("WI_DE1040_g20")

            Case MenuType.Save
                If Not Saves() Then Exit Sub

            Case MenuType.Cancel
                Me.Clear()

            Case MenuType.Confirm
                If Not ConFrim() Then Exit Sub

            Case MenuType.Deconfirm
                'If Not DeConFrim() Then Exit Sub /*-BOM은 확인취소가 없음-*/

            Case MenuType.Delete
                If Not Del() Then Exit Sub

            Case Else

                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

#Region " Tree Init & Open "

    Private Sub _Open_TreeView()
        Dim p As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing
        Dim n As DevExpress.XtraTreeList.Nodes.TreeListNode

        Try
            treeFields.BeginUnboundLoad()
            treeFields.ClearNodes()

            Dim dSet As DataSet = OpenDataSet("WI_DE1040_tree")

            If IsEmpty(dSet) Then
                n = Me._AddNode(p, itm_cd.Text, itm_nm.Text, itm_id.Text, 1, "", "", "")
                n.StateImageIndex = 1
                Me._SelectNode(n)
                treeFields.EndUnboundLoad()
                Exit Sub
            End If

            Dim pId As String, id As String, ItmCd As String, ItmNm As String, ItmId As String, qty As Decimal, umbc As String, prcCd As String
            Dim ImgIdx As Integer = 0

            For Each r As DataRow In dSet.Tables(0).Rows
                id = r.Item("id")
                pId = r.Item("p_id")
                ItmCd = r.Item("itm_cd")
                ItmNm = r.Item("itm_nm")
                ItmId = ToDec(r.Item("itm_id"))
                qty = ToDec(r.Item("itm_qty"))
                umbc = ToStr(r.Item("um_bc"))
                prcCd = ToStr(r.Item("prc_cd"))

                ImgIdx = 0

                If id = "1" Then
                    ImgIdx = 1
                ElseIf id = "2" Then
                    ImgIdx = 2
                Else
                    ImgIdx = 3
                End If

                Try
                    p = treeFields.FindNodeByFieldValue("id", pId)
                    n = Me._AddNode(p, ItmCd, ItmNm, ItmId, qty, umbc, prcCd, id)
                    n.StateImageIndex = ImgIdx

                Catch ex As Exception

                End Try
            Next

            treeFields.EndUnboundLoad()

            Me._SelectNode(treeFields.Nodes(0))

        Catch ex As Exception
            MessageInfo(Err.Description, "Tree Open()")
        End Try

    End Sub

    Private Function _AddNode(ByVal p As DevExpress.XtraTreeList.Nodes.TreeListNode, _
                              ByVal itmCd As String, ByVal itmNm As String, ByVal itmId As String, ByVal qty As Decimal, ByVal umbc As String,
                              ByVal prcCd As String, ByVal id As String _
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

    Private Sub treeFields_AfterCollapse(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs) Handles treeFields.AfterCollapse
        'e.Node.StateImageIndex = 1
    End Sub

    Private Sub treeFields_AfterExpand(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs) Handles treeFields.AfterExpand
        'e.Node.StateImageIndex = 2
    End Sub

    Private Sub treeFields_AfterFocusNode(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs) Handles treeFields.AfterFocusNode
        If treeFields.Nodes.Count <= 0 Then Exit Sub

        Me._SelectNode(e.Node)
    End Sub

    Private Sub _SelectNode(ByVal n As DevExpress.XtraTreeList.Nodes.TreeListNode)
        If n Is Nothing Then
            Exit Sub
        End If

        pitm_cd.Text = n.Item("itm_cd")
        pitm_nm.Text = n.Item("itm_nm")
        pitm_id.Text = n.Item("itm_id")

        p.Clear()
        p.Add("@assyno", pitm_cd.Text)

        Me.Open("WI_DE1040_select", p)

        Dim dSet As DataSet = Me.OpenDataSet("WI_DE1040_select", p)
        Dim apply_dt As DateTime

        If Not IsEmpty(dSet) Then
            apply_dt = DataValue(dSet)
        Else
            apply_dt = Today()
        End If

        std_dt.Text = apply_dt

        Me.Open("WI_DE1040_select_stts", p)

        Dim dSet1 As DataSet = Me.OpenDataSet("WI_DE1040_select_stts", p)
        Dim stts As String

        If Not IsEmpty(dSet1) Then
            stts = DataValue(dSet1)
        Else
            stts = ""
        End If

        stts1.Text = stts

        Me.Open(g10.WorkSet)

        g10.AddNewRow()

    End Sub

    Private Sub itm_cd_TextChanged(ByVal sender As Object, ByVal oldValue As String) Handles itm_cd.TextChanged
        'Me._Open_TreeView()
        'chk_expand.Checked = True
        'treeFields.ExpandAll()

        ''Me.Open(g10.WorkSet)

        ''g10.AddNewRow()

        ''g20.Open()
        Me.Open("WI_DE1040_g20")

        Me._Open_TreeView()
        Me._ExpandTree()

    End Sub

    Private Sub g20_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g20.AfterMoveRow

        'If g20.RowCount = 0 Then
        '    Exit Sub
        'End If

        pitm_cd.Text = g20.Text("itm_cd")
        pitm_nm.Text = g20.Text("itm_nm")
        pitm_id.Text = g20.Text("itm_id")

        Me.Open(g10.WorkSet)

        g10.AddNewRow()

    End Sub

    Private Sub Clear()
        p.Clear()
        treeFields.ClearNodes()

        p.Add("@assyno", "XXX")
        p.Add("@itm_cd", "XXX")

        Me.Open("WI_DE1040_f10", p)
        Me.Open("WI_DE1040_g10", p)
    End Sub

    Private Function Saves() As Boolean

        If Check_Stts() = "C" Then '상태값 CHECK
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            If MyBase.Save() Then
            End If
        End If

        Me._Open_TreeView()
        Me._ExpandTree()

        'Me._Open_TreeView()
        'Me._ExpandTree()

        Return True
    End Function

    Private Function Check_Stts() As String
        p.Clear()
        p.Add("@assyno", pitm_cd.Text)

        Dim dSet As DataSet = Me.OpenDataSet("WI_DE1040_stts", p)
        Dim stts As String = "S"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Function ConFrim() As Boolean

        ''상태값 CHECK
        'If Check_Stts() = "C" Then
        '    MsgBox("확인된 자료입니다.!")
        '    Return False
        'End If

        'If pitm_cd.Text = Nothing Then
        '    MsgBox("자료를 확인하세요.!")
        '    Return False
        'End If

        'If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
        '    Exit Function
        'Else
        '    p.Clear()
        '    p.Add("@assyno", pitm_cd.Text)
        '    p.Add("@apply_dt", std_dt.Text)
        '    p.Add("@stts", "C")

        '    Me.Open("WI_DE1040_confirm", p)
        'End If

        Return True
    End Function

    Private Function DeConFrim() As Boolean
        '상태값 CHECK
        If Check_Stts() <> "C" Then
            MsgBox("확인된 자료가 아닙니다.!")
            Return False
        End If

        If pitm_cd.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        If MessageYesNo("확인취소 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@assyno", pitm_cd.Text)
            p.Add("@stts", "S")

            Me.Open("WI_DE1040_confirm", p)
        End If

        Return True
    End Function

    Private Function Del() As Boolean

        '상태값 CHECK
        If Check_Stts() = "C" Then
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        If pitm_cd.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        If MessageYesNo("삭제 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@assyno", pitm_cd.Text)
            p.Add("@APPLY_DT", std_dt.Text)

            Me.Open("WI_DE1040_delete", p)

            Me.Clear()

            g10.Open()

        End If

        Return True
    End Function
End Class
