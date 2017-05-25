Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid.Columns
'Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Menu

Imports DevExpress.XtraGrid.Localization

Imports Frame7
Imports Base7
Imports DevExpress.XtraGrid.Views.Grid

Public Class HRA103

    Private Sub ECombo1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub HRA103_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        'MsgBox(GridView1.CustomizationForm.ContextMenuStrip.Items(0).Text)

        ECombo1.AddItem("111", "a111")
        ECombo1.AddItem("112", "a112")
        ECombo1.AddItem("113", "a113")
        ECombo1.AddItem("114", "a114")
        ECombo1.AddItem("115", "a115")
        ECombo1.AddItem("116", "a116")
        ECombo1.AddItem("211", "a211")
        ECombo1.AddItem("212", "a212")
        ECombo1.AddItem("213", "a213")
        ECombo1.AddItem("214", "a214")
        ECombo1.AddItem("215", "a215")
        ECombo1.AddItem("216", "a216")


        ECheckCombo1.AddItem("111", "a111")
        ECheckCombo1.AddItem("112", "a112")
        ECheckCombo1.AddItem("113", "a113")
        ECheckCombo1.AddItem("114", "a114")
        ECheckCombo1.AddItem("115", "a115")
        ECheckCombo1.AddItem("211", "a111")
        ECheckCombo1.AddItem("212", "a112")
        ECheckCombo1.AddItem("213", "a113")
        ECheckCombo1.AddItem("214", "a114")
        ECheckCombo1.AddItem("215", "a115")

        'EText1.Text = "123"
        ECheckCombo1.Text = "a113,a115"

        'EText1.FieldType = Frame7.FieldType.Decimal

        Dim a As intField
        a = EText1

        EText1.FieldType = Frame7.FieldType.Decimal
        'EText1.Mask = "#,###,###.####"
        'EText1.RoundType = RoundType.Round
        'EText1.RoundDigits = 6
        EText1.Format = "#,###.####0"
        EText1.Text = "123456"

        EText2.FieldType = Frame7.FieldType.Int
        EText2.Format = "#,###.####0"
        EText2.Text = "123456"

        'ECombo1.Free()


        ECombo1.Text = "212"
        ECombo1.Text = "213"
        'MsgBox(EText1.Value * EText3.Value)
        'MsgBox(EText1.Text * EText3.Text)



        'MsgBox(EText1.FieldType.ToString)

        TextEdit1.Properties.Mask.EditMask = "#,###.#####"
        TextEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        TextEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        'TextEdit1.Properties.Mask.UseMaskAsDisplayFormat = True

        'TextEdit1.Properties.EditFormat.FormatString = "#,###.##"
        'TextEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric

        'TextEdit1.Properties.DisplayFormat.FormatString = "#,###.##"
        'TextEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric

        'Math.Round(0.12, 2, MidpointRounding.AwayFromZero)


        'GridView1.Columns.AddField("item_cd")

        'Dim ds As DataSet = ReadUserData()


        ' '' ''dSet = ReadUserData()




        Me.test()

        'Dim dvManager As DataViewManager = New DataViewManager(dSet)
        'Dim dv As DataView = dvManager.CreateDataView(dSet.Tables(0))

        'GridControl1.DataSource = dSet
        'GridControl1.DataSource = dv
        ' '' ''GridControl1.DataSource = dSet.Tables(0)
        'GridControl1.DataSource = dSet.Tables(0).DefaultView

        GridView1.OptionsView.ColumnAutoWidth = False
        GridView1.OptionsSelection.MultiSelect = True
        'GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect


        'GridView1.FocusRectStyle = DrawFocusRectStyle.CellFocus
        'GridView1.OptionsSelection.EnableAppearanceFocusedCell = True
        'GridView1.OptionsSelection.EnableAppearanceFocusedRow = True
        'GridView1.OptionsSelection.InvertSelection = True

        GridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom
        'dSet.Tables(0).Rows.Count

        'GridView1.OptionsView.RowAutoHeight = True
        'GridView1.OptionsView.

        'GridControl1.UseEmbeddedNavigator = True

    End Sub

    Dim dSet As DataSet

    Private Sub test()
        CreateGridColumn(GridView1, "item_in_cd", "item_in_cd", 0)
        CreateGridColumn(GridView1, "item_cd", "item_cd", 0)
        CreateGridColumn(GridView1, "item_nm", "item_nm", 0)
        CreateGridColumn(GridView1, "unit_cd", "unit_cd", 0)
        CreateGridColumn(GridView1, "sale_chk", "sale_chk", 0)
        CreateGridColumn(GridView1, "fr_dt", "fr_dt", 0)
        CreateGridColumn(GridView1, "barcode", "barcode", 0)
        CreateGridColumn(GridView1, "draw_no", "draw_no", 0)
        CreateGridColumn(GridView1, "mana1_cd", "mana1_cd", 0)
        CreateGridColumn(GridView1, "reg_dt", "reg_dt", 0)
        CreateGridColumn(GridView1, "weight", "weight", 0)
        CreateGridColumn(GridView1, "reg_uid", "reg_uid", 0)
        'CreateGridColumn(GridView1, "Lenght (Exponential format)", "Lenght", 1, DevExpress.Utils.FormatType.Numeric, "e")
        'CreateGridColumn(GridView1, "Lenght (Hexadecimal format)", "Lenght", 2, DevExpress.Utils.FormatType.Numeric, "x")
        'CreateGridColumn(GridView1, "PurchaseDate (LongDate format)", "PurchaseDate", 3, DevExpress.Utils.FormatType.DateTime, "D")
        'CreateGridColumn(GridView1, "Custom Format", "Number", 4, DevExpress.Utils.FormatType.Custom, "B2")
        'InitData()
        'GridView1.BestFitColumns()

    End Sub


    Private Sub CreateGridColumn(ByVal cv As DevExpress.XtraGrid.Views.Base.ColumnView, ByVal caption As String, ByVal field As String, ByVal visibleindex As Integer) ', ByVal formatType As DevExpress.Utils.FormatType, ByVal formatString As String)
        Dim gc As DevExpress.XtraGrid.Columns.GridColumn = cv.Columns.Add

        gc.Caption = caption
        gc.FieldName = field
        'gc.ColumnEditName = field
        gc.Name = field
        gc.VisibleIndex = cv.Columns.Count
        'gc.VisibleIndex = visibleindex

        If field = "item_cd" Then
            Dim aa As New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()

            aa.Items.Add(New DevExpress.XtraEditors.Controls.ImageComboBoxItem("전체", "%"))
            aa.Items.Add(New DevExpress.XtraEditors.Controls.ImageComboBoxItem("AA", "aa"))
            aa.Items.Add(New DevExpress.XtraEditors.Controls.ImageComboBoxItem("BB", "bb"))
            aa.DropDownRows = 12
            aa.PopupSizeable = True
            aa.PopupFormMinSize = New Size(100, 80)
            'aa.PopupFormSize

            gc.ColumnEdit = aa
        End If

        If field = "unit_cd" Then
            Dim aa As New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()

            aa.Items.Add(New DevExpress.XtraEditors.Controls.ImageComboBoxItem("EA", "Z100100"))
            aa.Items.Add(New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Kg", "Z100500"))
            aa.DropDownRows = 12
            aa.PopupSizeable = True
            aa.PopupFormMinSize = New Size(100, 80)
            'aa.PopupFormSize

            gc.ColumnEdit = aa
        End If


        If field = "sale_chk" Then
            Dim aa As New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
            aa.ValueChecked = "1"
            aa.ValueGrayed = "0"
            aa.ValueUnchecked = "0"
            aa.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Standard
            'aa.AllowGrayed = False
            'aa.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
            'aa.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Standard
            'aa.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
            'aa.NullText = "0"
            'aa.PopupFormSize
            gc.ColumnEdit = aa
        End If

        If field = "fr_dt" Then
            Dim aa As New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit

            'aa.ShowWeekNumbers = True
            'aa.NullText = ""
            'aa.PopupFormSize
            gc.ColumnEdit = aa
        End If

        If field = "barcode" Then
            Dim aa As New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit

            aa.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
            'aa.ShowWeekNumbers = True
            'aa.NullText = ""
            'aa.PopupFormSize
            gc.ColumnEdit = aa
        End If

        If field = "draw_no" Then
            Dim aa As New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit

            'aa.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Defaul
            'aa.ShowWeekNumbers = True
            'aa.NullText = ""
            gc.ColumnEdit = aa
        End If
        If field = "mana1_cd" Then
            Dim aa As New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit

            'aa.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Defaul
            'aa.ShowWeekNumbers = True
            'aa.NullText = ""
            gc.ColumnEdit = aa
        End If
        If field = "reg_dt" Then
            Dim aa As New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit

            'aa.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Defaul
            'aa.ShowWeekNumbers = True
            'aa.NullText = ""
            gc.ColumnEdit = aa
        End If
        If field = "reg_uid" Then
            'Dim aa As New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
            'aa.EditFormat.FormatString = "#,###,###,###"
            'aa.DisplayFormat.FormatString = "{0:###,###.##}"
            'aa.Mask.EditMask = "#,###,###,###"
            'aa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            'gc.ColumnEdit = aa

            'aa.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Defaul
            'aa.ShowWeekNumbers = True
            'aa.NullText = ""
            gc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            gc.DisplayFormat.FormatString = "#,###"
            'gc.ColumnEdit = aa
            'gc.ColumnTyp
        End If
        If field = "weight" Then
            gc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            gc.DisplayFormat.FormatString = "#,###.#####"
        End If

        '
        '   LookUp 설정 방법
        '
        'If field = "item_cd" Then
        '    Dim aa As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        '    'Dim aa As New DevExpress.XtraEditors.Repository.RepositoryItemComboBox

        '    aa.AutoHeight = False
        '    aa.DropDownRows = 10
        '    aa.Name = "repositoryItemLookUpEdit1"
        '    aa.PopupWidth = 220
        '    aa.ValueMember = "item_cd"
        '    aa.DisplayMember = "item_nm"

        '    Dim ds As DataSet = ReadUserData()

        '    aa.DataSource = ds.Tables(0)
        '    gc.ColumnEdit = aa
        'End If



        'gc.DisplayFormat.FormatType = formatType
        'If (formatType = DevExpress.Utils.FormatType.Custom) Then
        '    GC.DisplayFormat.Format = New BaseFormatter()
        'End If
        'gc.DisplayFormat.FormatString = formatString

    End Sub

    Private Function ReadUserData() As DataSet

        Dim sqlCd As String = "System_Login"
        'Dim isDebug As String = IIf(Parameter.System.IsDebugger, "1", "0")

        'Dim qp As New QueryParameters
        'qp.Add("@item_cd", "11", QueryParameterType.Text, QueryParameterKind.Parameter)
        'qp.Add("@item_nm", "33", QueryParameterType.Dec, QueryParameterKind.Parameter)
        'qp.Add("<#item_nm>", "55", QueryParameterType.Text, QueryParameterKind.Macro)

        'MsgBox(Link.GetQueryText("OpenQuery"))

        'Dim sql As String = "EXEC System_Login '" + id.Text + "', '" + pwd.Text + "', '" & isDebug + "'"
        Dim dtSet As DataSet = Nothing

        Try
            dtSet = Link.ReadDataSet(sqlCd)

            'MsgBox(DataValue(dtSet))

        Catch ex As Exception
            MsgBox(ex.Message)
            'ThrowError(ex, Me, GetCurrentMethod())
        End Try

        Return dtSet

    End Function


    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        'MsgBox(EText1.Value * EText3.Value)
        'MsgBox(EText1.Text * EText3.Text)

        MsgBox(ECheckCombo1.Text)
        'MsgBox(ECombo1.Value)
    End Sub

    Private Sub EText3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextEdit1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextEdit1.Click

    End Sub

    Private Sub TextEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextEdit1.EditValueChanged

    End Sub

    Private Sub EText1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'MsgBox("Click")
    End Sub

    'Private Sub EText1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles EText1.Leave
    '    MsgBox("Leave")
    'End Sub

    Private Sub EText1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'MsgBox("LostFocus")
    End Sub

    Private Sub TextEdit1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextEdit1.Leave
        'MsgBox("Leave")
    End Sub

    Private Sub TextEdit1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextEdit1.LostFocus
        'TextEdit1.Text = Format(Base7.Share.ToDec(TextEdit1.Text), TextEdit1.Properties.Mask.EditMask)
        'MsgBox("LostFocus")
    End Sub

    Private Sub EText1_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean)
        'MsgBox(oldValue + "->" + newValue)
        'cancel = True
    End Sub

    Private Sub ECheckCombo1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ECheckCombo1.Load

    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'GridView1.UpdateCurrentRow()

        'MsgBox(GridView1.RowCount)
        ''GridView1.Appearance.

        'GridView1.MoveNext()

        'MsgBox("CancelEdit")
        'GridView1.GetDataRow(GridView1.FocusedRowHandle).CancelEdit()

        'MsgBox("RejectChanges")
        'GridView1.GetDataRow(GridView1.FocusedRowHandle).RejectChanges()



        Dim s(1) As String
        s(0) = "item_cd = MVK009"
        s(1) = "item_nm = LC"

        Find(s)
    End Sub

    Private Sub Find(ByVal findString() As String)
        Dim i As Integer, isMatch As Boolean, ele() As String
        If findString Is Nothing Then
            Exit Sub
        End If
        If findString.Length = 0 Then
            Exit Sub
        End If

        For i = 0 To GridView1.RowCount - 1
            isMatch = True
            For Each row As String In findString
                ele = Split(row, "=")
                If ele.Length <> 2 Then
                    MsgBox("Find string format error")
                    Exit Sub
                End If
                If GridView1.GetRowCellValue(i, ele(0).Trim) <> ele(1).Trim Then
                    isMatch = False
                    Exit For
                End If
            Next
            If isMatch Then
                GridView1.FocusedRowHandle = i
            End If
        Next
    End Sub


    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        'If GridView1.FocusedColumn.AbsoluteIndex - 1 < GridView1.Columns.Count Then
        'End If
    End Sub

    Private Sub GridView1_BeforeLeaveRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowAllowEventArgs) Handles GridView1.BeforeLeaveRow
        'If GridView1.FocusedRowModified Then
        '    MsgBox("FocusedRowModified")
        'End If
        'MsgBox(GridView1.FocusedRowHandle)
        'MsgBox("BeforeLeaveRow")
    End Sub

    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        'MsgBox("CellValueChanged")
        'GridView1.GetDataRow(GridView1.FocusedRowHandle).CancelEdit()
    End Sub

    Private Sub GridView1_CellValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanging
        'GridView1.UpdateCurrentRow()

        'MsgBox("CellValueChanging")
    End Sub

    Private Sub GridView1_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridView1.CustomColumnDisplayText

    End Sub

    Private Sub GridView1_CustomRowCellEdit(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles GridView1.CustomRowCellEdit
        'e.
    End Sub

    'Private Sub GridView1_ColumnChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.ColumnChanged
    '    'X
    '    If GridView1.FocusedColumn IsNot Nothing Then
    '        MsgBox("ColumnChanged -> " + GridView1.FocusedColumn.FieldName)
    '    End If
    'End Sub

    'Private Sub GridView1_ColumnPositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.ColumnPositionChanged
    '    'X
    '    If GridView1.FocusedColumn IsNot Nothing Then
    '        MsgBox("ColumnPositionChanged -> " + GridView1.FocusedColumn.FieldName)
    '    End If
    'End Sub

    'Private Sub GridView1_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DataSourceChanged
    '    'X
    '    MsgBox("DataSourceChanged")
    'End Sub

    'Private Sub GridView1_FocusedColumnChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles GridView1.FocusedColumnChanged
    '    MsgBox("FocusedColumnChanged")
    'End Sub

    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        'MsgBox("FocusedRowChanged")
        'Label1.Text = "Row:" + GridView1.FocusedRowHandle.ToString + " RowLevel:" + GridView1.GetRowLevel(GridView1.FocusedRowHandle).ToString _
        '+ " NextVisibleRow:" + GridView1.GetNextVisibleRow(GridView1.FocusedRowHandle).ToString _
        '+ " ChildRowCount:" + GridView1.GetChildRowCount(GridView1.FocusedRowHandle).ToString

    End Sub

    Private Sub GridView1_GridMenuItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.GridMenuItemClickEventArgs) Handles GridView1.GridMenuItemClick
        MsgBox(e.DXMenuItem.Caption)


    End Sub


    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown


        Select Case e.KeyCode
            Case Keys.Enter
                SendKeys.SendWait("{Tab}")
            Case Keys.ShiftKey
                MsgBox("Shift Down -> " + GridView1.FocusedColumn.ToString)
            Case Else
        End Select
        'Dim newCol As Integer = GridView1.FocusedColumn.VisibleIndex + 1
        'If GridView1.Columns.Count < newCol Then
        '    newCol = 0
        'End If
        'GridView1.FocusedColumn = GridView1.Columns(newCol)
    End Sub

    Private Sub GridView1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GridView1.KeyPress
        'Select Case e.KeyChar
        '    Case  
        '        MsgBox("Shift Up")
        '    Case Else
        'End Select
    End Sub

    Private Sub GridView1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyUp


        Select Case e.KeyCode
            Case Keys.ShiftKey
                MsgBox("Shift Up -> " + GridView1.FocusedColumn.ToString)
            Case Else
        End Select
    End Sub

    Private Sub GridView1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.LostFocus
    End Sub


    '    private void radioGroup1_SelectedIndexChanged(object sender, System.EventArgs e) {
    '	int style = (int)radioGroup1.EditValue;
    '	gridView1.FocusRectStyle = DrawFocusRectStyle.CellFocus;
    '	gridView1.OptionsSelection.EnableAppearanceFocusedCell = true;
    '	gridView1.OptionsSelection.EnableAppearanceFocusedRow = true;
    '	gridView1.OptionsSelection.InvertSelection = false;
    '	switch(style) {
    '		case 1: //Row
    '			gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
    '			gridView1.FocusRectStyle = DrawFocusRectStyle.RowFocus;
    '			break;
    '		case 2: //Cell
    '			gridView1.OptionsSelection.InvertSelection = true;
    '			break;
    '		case 4: //Cell Rect Only
    '			gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
    '			gridView1.OptionsSelection.EnableAppearanceFocusedRow = false;
    '			break;
    '		case 5: //None
    '			gridView1.FocusRectStyle = DrawFocusRectStyle.None;
    '			gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
    '			gridView1.OptionsSelection.EnableAppearanceFocusedRow = false;
    '			break;

    '	}
    '	SetFocusedColumnAppearance(null, gridView1.FocusedColumn);
    '	gridControl1.Focus();
    '}

    'private void SetFocusedColumnAppearance(DevExpress.XtraGrid.Columns.GridColumn col1, DevExpress.XtraGrid.Columns.GridColumn col2) {
    '	if(radioGroup1.EditValue == null) return;
    '	if(col1 != null )col1.AppearanceCell.Reset();
    '	if(col2 != null) 
    '		if(3.Equals(radioGroup1.EditValue)) {
    '			col2.AppearanceCell.BackColor = SystemColors.Highlight;
    '			col2.AppearanceCell.ForeColor = SystemColors.HighlightText;
    '		} else 
    '			col2.AppearanceCell.Reset();
    '}

    '    private void simpleButton1_Click(object sender, System.EventArgs e) {
    '	AddRow(gridView1);
    '}

    'void  AddRow(DevExpress.XtraGrid.Views.Grid.GridView view) {
    '	int currentRow;
    '	currentRow = view.FocusedRowHandle;
    '	if(currentRow < 0) 
    '		currentRow = view.GetDataRowHandleByGroupRowHandle(currentRow);
    '	view.AddNewRow();

    '	if(view.SortInfo.GroupCount == 0) return;

    '	foreach(DevExpress.XtraGrid.Columns.GridColumn groupColumn in view.GroupedColumns) {
    '		object val = view.GetRowCellValue(currentRow, groupColumn);
    '		view.SetRowCellValue(view.FocusedRowHandle, groupColumn, val);
    '	}
    '	view.UpdateCurrentRow();
    '	view.ShowEditor();
    '}



    Private Sub GridView1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridView1.MouseDown

    End Sub

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    End Sub


    Private Sub gridView1_ShowGridMenu(ByVal sender As Object, ByVal e As GridMenuEventArgs) Handles GridView1.ShowGridMenu
        If e.MenuType = GridMenuType.Column Then
            Dim menu As DevExpress.XtraGrid.Menu.GridViewColumnMenu = CType(e.Menu, GridViewColumnMenu)
            'Erasing the default menu items
            menu.Items(0).Caption = "1234"
            'menu.Items.Clear()
            If Not menu.Column Is Nothing Then
                'Adding new items
                menu.Items.Add(CreateCheckItem("Fixed None", menu.Column, FixedStyle.None, Nothing))
                menu.Items.Add(CreateCheckItem("Fixed Left", menu.Column, FixedStyle.Left, Nothing))
                'imageList2.Images(1)))
                menu.Items.Add(CreateCheckItem("Fixed Right", menu.Column, FixedStyle.Right, Nothing))
                'imageList2.Images(2)))
            End If
        End If
    End Sub

    'Create a menu item
    Function CreateCheckItem(ByVal caption As String, ByVal column As GridColumn, _
                             ByVal style As FixedStyle, ByVal image As Image) As DXMenuCheckItem
        Dim item As DXMenuCheckItem = New DXMenuCheckItem(caption, _
          column.Fixed = style, image, New EventHandler(AddressOf OnFixedClick))
        item.Tag = New MenuInfo(column, style)
        Return item
    End Function

    'Menu item click handler
    Sub OnFixedClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim item As DXMenuItem = CType(sender, DXMenuItem)
        Dim info As MenuInfo = CType(item.Tag, MenuInfo)
        If info Is Nothing Then Exit Sub
        info.Column.Fixed = info.Style
    End Sub

    'The class that stores menu specific information
    Class MenuInfo
        Public Sub New(ByVal column As GridColumn, ByVal style As FixedStyle)
            Me.Column = column
            Me.Style = style
        End Sub
        Public Style As FixedStyle
        Public Column As GridColumn
    End Class



    Private Sub bandedGridView1_GridMenuItemClick(ByVal sender As Object, ByVal e As GridMenuItemClickEventArgs) Handles GridView1.GridMenuItemClick
        If e.MenuType <> GridMenuType.Summary Or _
           e.DXMenuItem.Tag.Equals(GridStringId.MenuFooterCount) Then Exit Sub
        If e.Column.FieldName <> "ID" And e.Column.FieldName <> "Customer Name" _
          And e.Column.FieldName <> "Year" Then
            Dim sumFormat As String = e.SummaryFormat
            Dim subSumFormat As Integer = sumFormat.IndexOf("{0")
            If subSumFormat > 0 Then
                sumFormat = IIf(e.DXMenuItem.Tag.Equals(GridStringId.MenuFooterSum), _
                  "", sumFormat.Substring(0, subSumFormat)) + "{0:c}"
            End If
            e.SummaryFormat = sumFormat
        End If
    End Sub


End Class
