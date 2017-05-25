Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes

Public Class DMB100_EPL2

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        treeFields.OptionsView.AutoWidth = False
        treeFields.OptionsBehavior.Editable = False
        treeFields.OptionsSelection.InvertSelection = True
        treeFields.OptionsView.ShowIndicator = False
        treeFields.FixedLineWidth = 1

        Init_Form()
    End Sub

    Public Sub Init_Form()
        Me._Add_TreeField(treeFields, "    품목코드", "itm_cd", 250, , True)
        Me._Add_TreeField(treeFields, "품목명", "itm_nm", 160)
        Me._Add_TreeField(treeFields, "품목ID", "itm_id", 70, False)
        Me._Add_TreeField(treeFields, "구분", "itm_bc", 60)
        Me._Add_TreeField(treeFields, "대분류", "grp1_nm", 80)
        Me._Add_TreeField(treeFields, "엔진", "model_nm", 70)
        Me._Add_TreeField(treeFields, "U/S", "qty", 70, , , , , , True)
        Me._Add_TreeField(treeFields, "단위", "um_bc", 50)
        Me._Add_TreeField(treeFields, "거래처코드", "cust_cd", 80, False)
        Me._Add_TreeField(treeFields, "거래처명", "cust_nm", 150)
        Me._Add_TreeField(treeFields, "생산공정", "prc_nm", 70)
        Me._Add_TreeField(treeFields, "출고구분", "use_bc", 70)
        Me._Add_TreeField(treeFields, "조달구분", "src_bc", 75)
        Me._Add_TreeField(treeFields, "ECO No", "eco_no", 80, False)
        Me._Add_TreeField(treeFields, "Rev.", "draw_no", 50)
        Me._Add_TreeField(treeFields, "단가", "up", 70, , , , , , True)
        Me._Add_TreeField(treeFields, "매출금액", "amt2", 80, , , , , , True)
        Me._Add_TreeField(treeFields, "매입금액", "amt", 80, , , , , , True)
        Me._Add_TreeField(treeFields, "매입비율", "rt", 75, , , , , , True)
        Me._Add_TreeField(treeFields, "점유율", "itm_rt", 75, , , , , , True)
        Me._Add_TreeField(treeFields, "유상판매단가", "up2", 85, , , , , , True)
        Me._Add_TreeField(treeFields, "유상판매가", "amt3", 80, , , , , , True)
        Me._Add_TreeField(treeFields, "적용시작일", "fr_dt", 90)
        Me._Add_TreeField(treeFields, "적용종료일", "to_dt", 90)
        Me._Add_TreeField(treeFields, "Key", "id", 100, False) 'PK
        Me._Add_TreeField(treeFields, "PKey", "pid", 100, False) 'PK

        Dim styleFormatCondition1 As DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition = New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition()
        styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(192))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))))
        styleFormatCondition1.Appearance.Options.UseBackColor = True
        styleFormatCondition1.Column = treeFields.Columns(treeFields.Columns.Count - 1)
        styleFormatCondition1.ApplyToRow = True
        styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        styleFormatCondition1.Value1 = 0

        treeFields.FormatConditions.Add(styleFormatCondition1)
    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            'Case MenuType.New

            Case MenuType.Open

                Me._Open_TreeView()
                Me._ExpandTree()

                'Case MenuType.Save

                'Case MenuType.Delete

            Case Else

                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    '######################################################################################
    '##            Open                                                                  ##
    '######################################################################################

    Private Sub New_Form()
        Try

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

#Region " Tree Init & Open "

    Private Sub _Open_TreeView()
        Dim p As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing
        Dim n As DevExpress.XtraTreeList.Nodes.TreeListNode


        Dim pId As String, id As String
        Dim ItmCd As String, ItmNm As String, ItmId As String, itmbc As String, grp1 As String, model As String
        Dim qty As Decimal, umbc As String, cust As String, custnm As String, prc As String, use As String, src As String
        Dim eco As String, draw As String, up As Decimal, amt2 As Decimal, amt As Decimal, rt As Decimal, itmrt As Decimal
        Dim up2 As Decimal, amt3 As Decimal, frdt As String, todt As String

        Dim prodYn As String, semiYn As String, phanYn As String

        Dim ImgIdx As Integer = 0
        Try
            Cursor.Current = Cursors.WaitCursor
            treeFields.BeginUnboundLoad()
            treeFields.ClearNodes()

            'Dim prm As New OpenParameters
            'prm.Add("@itm_id", itm_id.Text)
            'prm.Add("@itm_rev", itm_rev.Text)
            'Dim dSet As DataSet = OpenDataSet("dmb100_tree", prm)

            Dim dSet As DataSet = OpenDataSet("dmb100_epl2_tree")

            If IsEmpty(dSet) Then
                'Dim p1 As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing
                'treeFields.AppendNode(New Object() {"Not found Item", "", "", "", "", ""}, p1)
                'n = Me._AddNode(p, itm_cd.Text, itm_nm.Text, "", 1, "", "", "")
                'n.StateImageIndex = 1
                'Me._SelectNode(n)
                treeFields.EndUnboundLoad()
                Exit Sub
            End If


            For Each Row As DataRow In dSet.Tables(0).Rows

                id = Row.Item("id")
                pId = Row.Item("p_id")
                ItmCd = Row.Item("itm_cd")
                ItmNm = Row.Item("itm_nm")
                ItmId = ToDec(Row.Item("itm_id"))
                itmbc = ToStr(Row.Item("itm_bc"))
                grp1 = ToStr(Row.Item("grp1_nm"))
                model = ToStr(Row.Item("model_nm"))
                qty = ToDec(Row.Item("qty"))
                umbc = ToStr(Row.Item("um_bc"))
                cust = ToStr(Row.Item("cust_cd"))
                custnm = ToStr(Row.Item("cust_nm"))
                prc = ToStr(Row.Item("prc_nm"))
                use = ToStr(Row.Item("use_bc"))
                src = ToStr(Row.Item("src_bc"))
                eco = ToStr(Row.Item("eco_no"))
                draw = ToStr(Row.Item("draw_no"))

                up = ToDec(Row.Item("up"))
                amt2 = ToDec(Row.Item("amt2"))
                amt = ToDec(Row.Item("amt"))
                rt = ToDec(Row.Item("rt"))
                itmrt = ToDec(Row.Item("itm_rt"))
                up2 = ToDec(Row.Item("up2"))
                amt3 = ToDec(Row.Item("amt3"))
                frdt = ToStr(Row.Item("fr_dt"))
                todt = ToStr(Row.Item("to_dt"))


                prodYn = ToStr(Row.Item("prod_yn"))
                semiYn = ToStr(Row.Item("semi_yn"))
                phanYn = ToStr(Row.Item("phantom_yn"))

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
                    n = Me._AddNode(p, ItmCd, ItmNm, ItmId, itmbc, grp1, model, qty, umbc, _
                                    cust, custnm, prc, use, src, eco, draw, _
                                    up, amt2, amt, rt, itmrt, up2, amt3, frdt, todt, id, pId)
                    n.StateImageIndex = ImgIdx
                Catch ex As Exception

                End Try
            Next

            treeFields.EndUnboundLoad()

            'Me._SelectNode(treeFields.Nodes(0))

        Catch ex As Exception
            MessageInfo(Err.Description, "Tree Open()")
        Finally
            Cursor.Current = Cursors.Default
        End Try

    End Sub

    Private Function _AddNode(ByVal p As DevExpress.XtraTreeList.Nodes.TreeListNode, _
                              ByVal itmCd As String, _
                              ByVal itmNm As String, _
                              ByVal itmId As String, _
                              ByVal itmbc As String, _
                              ByVal grp1 As String, _
                              ByVal model As String, _
                              ByVal qty As Decimal, _
                              ByVal umbc As String, _
                              ByVal cust As String, _
                              ByVal custnm As String, _
                              ByVal prc As String, _
                              ByVal use As String, _
                              ByVal src As String, _
                              ByVal eco As String, _
                              ByVal draw As String, _
                              ByVal up As Decimal, _
                              ByVal amt2 As Decimal, _
                              ByVal amt As Decimal, _
                              ByVal rt As Decimal, _
                              ByVal itmrt As Decimal, _
                              ByVal up2 As Decimal, _
                              ByVal amt3 As Decimal, _
                              ByVal frdt As String, _
                              ByVal todt As String, _
                              ByVal id As String, _
                              ByVal pid As String
                              ) As DevExpress.XtraTreeList.Nodes.TreeListNode

        'Me._Add_TreeField(treeFields, "          품목코드", "itm_cd", 250, , True)
        'Me._Add_TreeField(treeFields, "품목명", "itm_nm", 160)
        'Me._Add_TreeField(treeFields, "품목ID", "itm_id", 70, False)
        'Me._Add_TreeField(treeFields, "구분", "itm_bc_nm", 60)
        'Me._Add_TreeField(treeFields, "대분류", "grp1_nm", 70)
        'Me._Add_TreeField(treeFields, "엔진", "model_nm", 60)
        'Me._Add_TreeField(treeFields, "U/S", "qty", 70, , , , , , True)
        'Me._Add_TreeField(treeFields, "단위", "um_bc", 60)
        'Me._Add_TreeField(treeFields, "거래처코드", "cust_cd", 80, False)
        'Me._Add_TreeField(treeFields, "거래처명", "cust_nm", 150)
        'Me._Add_TreeField(treeFields, "생산공정", "prc_nm", 70)
        'Me._Add_TreeField(treeFields, "출고구분", "use_bc", 70)
        'Me._Add_TreeField(treeFields, "조달구분", "src_bc", 75)
        'Me._Add_TreeField(treeFields, "ECO No", "eco_no", 80, False)
        'Me._Add_TreeField(treeFields, "Rev.", "draw_no", 70)
        'Me._Add_TreeField(treeFields, "단가", "up", 70, , , , , , True)
        'Me._Add_TreeField(treeFields, "매출금액", "amt2", 80, , , , , , True)
        'Me._Add_TreeField(treeFields, "매입금액", "amt", 80, , , , , , True)
        'Me._Add_TreeField(treeFields, "매입비율", "rt", 75, , , , , , True)
        'Me._Add_TreeField(treeFields, "점유율", "itm_rt", 75, , , , , , True)
        'Me._Add_TreeField(treeFields, "유상판매단가", "up2", 85, , , , , , True)
        'Me._Add_TreeField(treeFields, "유상판매가", "amt3", 80, , , , , , True)
        'Me._Add_TreeField(treeFields, "적용시작일", "fr_dt", 90)
        'Me._Add_TreeField(treeFields, "적용종료일", "to_dt", 90)
        'Me._Add_TreeField(treeFields, "Key", "id", 100, False) 'PK

        Return treeFields.AppendNode(New Object() {itmCd, _
                                                    itmNm, _
                                                    itmId, _
                                                    itmbc, _
                                                    grp1, _
                                                    model, _
                                                    qty, _
                                                    umbc, _
                                                    cust, _
                                                    custnm, _
                                                    prc, _
                                                    use, _
                                                    src, _
                                                    eco, _
                                                    draw, _
                                                    up, _
                                                    amt2, _
                                                    amt, _
                                                    rt, _
                                                    itmrt, _
                                                    up2, _
                                                    amt3, _
                                                    frdt, _
                                                    todt, _
                                                    id, pid}, p)

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
            edit.DisplayFormat.FormatString = "#,###.####"
            edit.EditFormat.FormatString = "#,###.####"
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

    '######################################################################################
    '##            Save                                                                  ##
    '######################################################################################

    Private Function Save_Form() As Boolean

        '        Dim ID As String = asset_id.Text
        Try

            '            If MyBase.Save() Then
            '                If ID = "" Then
            '                    f_asset_id.Text = asset_id.Text
            '                    Me.Open()
            '                Else
            '                    Form_Open()
            '                End If
            '            Else
            '                If ID = "" Then asset_id.Text = ""
            '            End If

        Catch ex As Exception
            '            If ID = "" Then asset_id.Text = ""
            '저장에 실패했으면 코드 채번을 반드시 취소한다
            MessageError(ex)
        End Try
    End Function


    '######################################################################################
    '##            사용자정의                                                            ##
    '######################################################################################

    '######################################################################################
    '##             Procedure                                                            ##
    '######################################################################################

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

End Class
