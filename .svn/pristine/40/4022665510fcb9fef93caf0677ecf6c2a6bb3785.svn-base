Imports Frame7
Imports Base7
Imports Base7.Shared

Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes
Imports System.Data
Imports DevExpress.XtraTreeList.Columns


Public Class PAM100
    Private m_Form As Control

    Private Sub Binding_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        treeFields.OptionsView.AutoWidth = False
        treeFields.OptionsBehavior.Editable = False
        'treeFields.OptionsBehavior.DragNodes = True
        treeFields.OptionsSelection.InvertSelection = True
        treeFields.OptionsView.ShowIndicator = False

        Me._Init_TreeField()
        Me._Open_TreeFields()

        pnlCopy.Visible = False
        bs_cd2.AddItem("%", "All")
        pay_kd2.AddItem("%", "All")

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me._Open()

            Case MenuType.New
                If XtraTabControl1.SelectedTabPageIndex = 0 Then g10.AddNewRow()
                If XtraTabControl1.SelectedTabPageIndex = 1 Then g20.AddNewRow()
                If XtraTabControl1.SelectedTabPageIndex = 2 Then g30.AddNewRow()

            Case MenuType.Save

                If Me._Save() Then
                    Me.Open_CompText()
                End If

            Case Else

                MyBase.MenuButton_Click(mty)

        End Select
    End Sub

    Private Sub _Open()
        Me.Open()
        Me._Open_TreeFields()
    End Sub

    Private Function _Save() As Boolean
        Dim sVal As String = comp_text2.Text

        'Code로 변환하여 저장한다
        Dim fld As String, cd As String, i As Integer = 0, j As Integer = 0
        For Each n As TreeListNode In treeFields.Nodes
            fld = n.GetDisplayText("fld")
            cd = "[" + n.GetDisplayText("cd") + "]"
            sVal = Replace(sVal, fld, cd)

            For Each n2 As TreeListNode In n.Nodes
                fld = n2.GetDisplayText("fld")
                cd = "[" + n2.GetDisplayText("cd") + "]"
                sVal = Replace(sVal, fld, cd)
            Next
        Next

        comp_text.Text = sVal

        If MyBase.Save() Then
            Return True
        End If
    End Function

    Private m_Origin_CompText As String     'CompText 변경여부 체크용

    Private Function Check_CompText() As Boolean
        If m_Origin_CompText <> comp_text2.Text Then
            Select Case MessageYesNoCancel("저장하시겠습니까 ? ")
                Case MsgBoxResult.Yes
                    If Not Me._Save() Then
                        Return False
                    End If
                Case MsgBoxResult.No
                    Return True
                Case MsgBoxResult.Cancel
                    Return False
            End Select
        End If
        Return True
    End Function

    Private Sub Open_CompText()

        Dim g As eGrid = Nothing
        If XtraTabControl1.SelectedTabPageIndex = 0 Then g = g10
        If XtraTabControl1.SelectedTabPageIndex = 1 Then g = g20
        If XtraTabControl1.SelectedTabPageIndex = 2 Then g = g30

        pay_cd.Text = g.Text("pay_cd")
        pay_nm.Text = g.EditText("pay_cd")


        Me.Open("pam100_f10")

        Dim sVal As String = comp_text.Text

        'Dim wSet As Frame7.WorkSet = Me.WorkSets("pam100_f10")
        'Dim sVal As String = wSet.GetValue("comp_text")

        'Code(comp_text) -> 명(comp_text2)으로 변환하여 조회한다
        Dim fld As String, cd As String, i As Integer = 0, j As Integer = 0
        For Each n As TreeListNode In treeFields.Nodes
            fld = n.GetDisplayText("fld")
            cd = "[" + n.GetDisplayText("cd") + "]"
            sVal = Replace(sVal, cd, fld)

            For Each n2 As TreeListNode In n.Nodes
                fld = n2.GetDisplayText("fld")
                cd = "[" + n2.GetDisplayText("cd") + "]"
                sVal = Replace(sVal, cd, fld)
            Next
        Next

        comp_text2.Text = ""
        comp_text2.SelectAll()
        comp_text2.SelectionFont = New Drawing.Font("돋움체", 10)
        comp_text2.Text = sVal          'comp_text 가 emax control이 아니라 RichText 라서 수동으로 값을 설정한다
        m_Origin_CompText = sVal        'CompText 변경여부 체크용

        Me._SetQueryColor(comp_text2)   '색상설정

    End Sub


#Region " Tree Open "

    Private Sub _Open_TreeFields()

        treeFields.BeginUnboundLoad()

        treeFields.ClearNodes()

        Dim dSet As DataSet = Me.OpenDataSet("pam100_items")
        If IsEmpty(dSet) Then
            Exit Sub
        End If

        Dim pCd As String, pNm As String, cCd As String, cNm As String, ix As String, ty As String, save As String = ""
        Dim p As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing

        For Each r As DataRow In dSet.Tables(0).Rows
            pCd = r.Item("pcd")
            pNm = r.Item("pnm")

            cCd = r.Item("cd")
            cNm = r.Item("nm")
            ty = r.Item("ty")
            ix = r.Item("ix")

            If pCd <> save Then
                p = Nothing
                p = treeFields.AppendNode(New Object() {ix, pNm, pCd, ty, "[" + ix + ":" + pNm + "]"}, p)
            End If

            treeFields.AppendNode(New Object() {ix, cNm, cCd, "", "[" + ix + "." + cNm + "]"}, p)

            save = pCd
        Next

        treeFields.EndUnboundLoad()

    End Sub

    Private Sub _Init_TreeField()
        Me._Add_TreeField(treeFields, "", "ix", 35)
        Me._Add_TreeField(treeFields, "기준정보", "nm", 140)
        Me._Add_TreeField(treeFields, "코드", "cd", 70)
        Me._Add_TreeField(treeFields, "Type", "ty", 70, False)
        Me._Add_TreeField(treeFields, "Field", "fld", 70, False)
    End Sub

    Private Sub _Add_TreeField(ByVal tList As TreeList, ByVal caption As String, ByVal fldNm As String, _
                  ByVal wid As Integer, _
                  Optional ByVal show As Boolean = True, _
                  Optional ByVal fixed As Boolean = False, _
                  Optional ByVal [readonly] As Boolean = False, _
                  Optional ByVal editable As Boolean = True, _
                  Optional ByVal checkbox As Boolean = False)

        Dim c As DevExpress.XtraTreeList.Columns.TreeListColumn

        c = tList.Columns.Add()
        c.Caption = caption
        c.FieldName = fldNm
        c.Width = wid
        c.Visible = show

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

#End Region

#Region " Event "

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If Me._Save() Then
            Me.Open_CompText()
        End If
    End Sub

    Private Sub chk_expand_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_expand.CheckedChanged
        If chk_expand.Checked Then
            treeFields.ExpandAll()
        Else
            treeFields.CollapseAll()
        End If
    End Sub

    Private Sub g10_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g10.AfterMoveRow
        If Check_CompText() Then
            Me.Open_CompText()
        End If
    End Sub

    Private Sub g20_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g20.AfterMoveRow
        If Check_CompText() Then
            Me.Open_CompText()
        End If
    End Sub

    Private Sub g30_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g30.AfterMoveRow
        If Check_CompText() Then
            Me.Open_CompText()
        End If
    End Sub

    Private Sub XtraTabControl1_Selecting(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageCancelEventArgs) Handles XtraTabControl1.Selecting
        If Not Check_CompText() Then
            e.Cancel = True
        End If
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        Me.Open_CompText()
    End Sub

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        If ColumnName = "pay_cd" AndAlso Value <> "" Then
            pay_cd.Text = g10.Text("pay_cd")
            pay_nm.Text = g10.EditText("pay_cd")
        End If
    End Sub
    Private Sub g20_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g20.CellValueChanged
        If ColumnName = "pay_cd" AndAlso Value <> "" Then
            pay_cd.Text = g20.Text("pay_cd")
            pay_nm.Text = g20.EditText("pay_cd")
        End If
    End Sub
    Private Sub g30_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g30.CellValueChanged
        If ColumnName = "pay_cd" AndAlso Value <> "" Then
            pay_cd.Text = g30.Text("pay_cd")
            pay_nm.Text = g30.EditText("pay_cd")
        End If
    End Sub

    Private Sub btn_test_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_test.Click
        If Me.Test Then
            MessageInfo("OK")
        Else
            MessageInfo("계산식 오류")
        End If
    End Sub

    Private Function Test() As Boolean
        If comp_text2.Text = "" Then
            Return False
        End If
        Dim sVal As String = comp_text2.Text

        'Code -> 숫자로 변환하여 조회한다
        Dim fld As String, i As Integer = 0, j As Integer = 0
        For Each n As TreeListNode In treeFields.Nodes
            fld = n.GetDisplayText("fld")
            sVal = Replace(sVal, fld, "1 ")
            For Each n2 As TreeListNode In n.Nodes
                fld = n2.GetDisplayText("fld")
                sVal = Replace(sVal, fld, "1 ")
            Next
        Next

        Try
            If Link.RunQuery("select " & sVal) Is Nothing Then
                Return False
            End If
        Catch ex As Exception
            'MessageInfo(ex)
            Return False
        End Try
        Return True
    End Function


    Private Sub treeFields_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles treeFields.MouseDown
        If e.Clicks <> 2 Then
            Return
        End If
        Dim hi As TreeListHitInfo = treeFields.CalcHitInfo(New Point(e.X, e.Y))
        Dim node As TreeListNode = hi.Node
        If node IsNot Nothing Then

            'Dim nm As String = node.GetDisplayText("nm")
            Dim ty As String = node.GetDisplayText("ty")
            Dim fld As String = node.GetDisplayText("fld")
            'Dim sv As String = node.GetDisplayText("sv")

            If ty = "no" Or pay_cd.Text = "" Then
                Exit Sub
            End If

            Dim iPos As Integer = comp_text2.SelectionStart
            Dim sTxt As String = comp_text2.Text
            Dim iLen As Integer = sTxt.Length

            'nm = "[" + ix + sv + nm + "] "

            comp_text2.Text = sTxt.Substring(0, iPos) + _
                             fld + " " + _
                             sTxt.Substring(iPos, iLen - iPos)

            Me._SetQueryColor(comp_text2)

            comp_text2.SelectionStart = iPos + fld.Length
            comp_text2.SelectionLength = 0
            comp_text2.Focus()

        End If
    End Sub

#End Region

#Region " Query Text Control - Color Setting "


    Private Sub _SetQueryColor(ByVal tBox As System.Windows.Forms.RichTextBox)

        Dim txts As String() = New String() {"select", "from", "where", "and", "on", "join", "outer", "inner", "union", _
                                             "with", "left", "right", "ltrim", "rtrim", "as", "distinct", _
                                             "insert", "update", "delete", "into", "exec", "exists", "not", _
                                             "isnull", "all", "order", "group", "by", "if", "else", "begin", _
                                             "end", "set", "values", "case", "when", "then", "declare", _
                                             "varchar", "int", "decimal", "varchar", "nvarchar", "char", _
                                             "replace", "isnumeric", "isdate", "len", "raiserror", "or", "null", _
                                             "dateadd", "datediff", _
                                             "return", "substring", "between", "like", "sum", "min", "max", _
                                             "count", "having", "while", "outer", "in", "getdate()"}

        Me.__SetQueryColor(tBox, txts, System.Drawing.Color.Blue)

        Dim txts2 As String() = Nothing, txts3 As String() = Nothing
        Dim fld As String, i As Integer = 0, j As Integer = 0
        For Each n As TreeListNode In treeFields.Nodes
            fld = n.GetDisplayText("fld")
            ReDim Preserve txts2(i)
            txts2(i) = fld
            i += 1

            For Each n2 As TreeListNode In n.Nodes
                fld = n2.GetDisplayText("fld")
                ReDim Preserve txts3(j)
                txts3(j) = fld
                j += 1
            Next
        Next
        Me.__SetQueryColor(tBox, txts2, System.Drawing.Color.DeepPink)
        Me.__SetQueryColor(tBox, txts3, System.Drawing.Color.Green)

    End Sub

    Private Sub __SetQueryColor(ByVal tBox As System.Windows.Forms.RichTextBox, ByVal txts As String(), ByVal clr As System.Drawing.Color)
        If txts Is Nothing Then
            Exit Sub
        End If
        Dim sQry As String, iPos As Integer, iEnd As Integer, txt2 As String

        For Each txt As String In txts
            sQry = tBox.Text.ToLower

            'sQry = " " + tBox.Text.ToLower + " "
            'sQry = sQry.Replace(vbTab, " ")
            'sQry = sQry.Replace(vbLf, " ")
            'sQry = sQry.Replace("(", " ")
            'sQry = sQry.Replace(")", " ")
            'sQry = sQry.Replace(",", " ")

            txt2 = txt.ToLower '" " + txt.ToLower + " "
            iPos = InStr(sQry, txt2)

            If iPos = 0 Then
                Continue For
            End If

            While iPos <> 0
                iEnd = iPos + Len(txt) + 1  '+1 -> Space

                tBox.SelectionStart = iPos - 1
                tBox.SelectionLength = Len(txt)
                tBox.SelectionColor = clr 'System.Drawing.Color.Blue

                iPos = InStr(iEnd, sQry, txt2)
            End While
        Next
    End Sub

#End Region



    Private Sub btn_copy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_copy.Click
        pnlCopy.Visible = Not pnlCopy.Visible
    End Sub

    Private Sub btn_save2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save2.Click

        If MessageYesNo("To 쪽의 기존 계산식은 삭제되고 복사됩니다." + vbLf + vbLf + "복사 하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        End If

        If Not CheckRequired(bs_cd2, pay_kd2, co_cd, bs_cd, pay_bc, pay_kd) Then
            Exit Sub
        End If
        Me.Open("pam100_copy")
    End Sub

End Class
