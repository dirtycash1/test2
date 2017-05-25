Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Collections
Imports System.Data

Public Class SDD185

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me._Open()

            Case MenuType.Save

            Case MenuType.New
                Me._Open()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub _Open()

        doc_no.Text = ""
        doc_dt.Text = ""

        Me.Open()

        Me.Sum_All()
    End Sub


    Private Sub btn_doc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_doc.Click

        If doc_no.Text <> "" Then
            MessageInfo("이미 전표가 발행되었습니다")
            Exit Sub
        End If

        If g10.CheckedRows("chk") = 0 Then
            MessageInfo("먼저 발행대상을 선택하세요")
            Exit Sub
        End If

        If Not CheckRequired(doc_dt) Then
            Exit Sub
        End If

        '작업전 체크
        With g10
            Dim custCd As String = ""
            For i As Integer = 0 To .RowCount - 1
                If .ToBool("chk", i) Then

                    ' 동일 거래처  체크
                    If custCd = "" Then
                        custCd = .Text("cust_cd", i)
                    End If

                    If custCd <> .Text("cust_cd", i) Then
                        MessageInfo("동일한 매출처만 전표처리 가능 합니다")
                        Exit Sub
                    End If

                    If .Text("doc_no", i) <> "" Then
                        MessageInfo("이미 전표가 발행된 건이 있습니다.")
                        Exit Sub
                    End If

                End If
            Next
        End With

        '작업시작

        Me._Work()

    End Sub

    Private Function _Work() As Boolean

        If MessageYesNo("전표를 생성하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        End If

        Dim dTbl As DataTable, dRow As DataRow
        Dim dSet As DataSet = Me.OpenDataSet("sdd185_save_data")

        dTbl = dSet.Tables(0)
        With g10
            .UpdateRow()

            dTbl.BeginLoadData()
            For i As Integer = 0 To .RowCount - 1
                If .ToBool("chk", i) Then
                    dRow = dTbl.NewRow()

                    dRow("tax_no") = .Text("tax_no", i)

                    dTbl.Rows.Add(dRow)
                End If
            Next
            dTbl.EndLoadData()
        End With

        If Me.Save Then
            Dim dSet2 As DataSet = Me.OpenDataSet("sdd185_work")
            If Not IsEmpty(dSet2) Then
                doc_no.Text = DataValue(dSet2)
                Me.Open()
                g10.Find("doc_no=" + doc_no.Text)
            End If
        End If

    End Function

    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.DoubleClick
        doc_no.Text = g10.Text("doc_no")
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        If doc_no.Text <> "" Then

            If MessageYesNo("전표를 삭제하시겠습니까?") = MsgBoxResult.No Then
                Exit Sub
            End If

            MyBase.Open("sdd185_delete")

            Me._Open()
        Else
            MessageInfo("전표번호를 먼저 선택하세요")
            Exit Sub
        End If
    End Sub

    Private Sub Sum_All()
        Dim iRow As Integer, sum_amt As Double, sum_vat As Double

        With g10
            For iRow = 0 To .RowCount - 1
                If .ToBool("chk", iRow) Then
                    sum_amt += .ToDec("item_amt", iRow)
                    sum_vat += .ToDec("vat_amt", iRow)
                End If
            Next
            item_amt.Text = sum_amt
            vat_amt.Text = sum_vat
            tot_amt.Text = ToDec(sum_amt) + ToDec(sum_vat)
        End With
    End Sub

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        If ColumnName = "chk" Then
            Me.Sum_All()
        End If
    End Sub

    Private Sub g10_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging
        With g10
            If .Text("doc_no") <> "" Then
                MessageInfo("이미 전표가 발행되었습니다.")
                .UpdateRow()
                Exit Sub
            End If

            If ColumnName = "chk" Then

                Dim custCd As String
                custCd = .Text("cust_cd")

                '  동일 거래처  체크
                For iRow = 0 To .RowCount - 1
                    If .ToBool("chk", iRow) And custCd <> .Text("cust_cd", iRow) Then
                        MessageInfo("동일한 매출처만 전표처리 가능 합니다")
                        .UpdateRow()
                        '.Text("chk") = ""
                        Exit Sub
                    End If
                Next

                'If Cust_Cnt > 0 Then
                '    MsgBox("동일한 거래처만 전표처리 가능 합니다")
                '    g20.UpdateRow()
                '    g20.Text("chk") = ""
                '    Exit Sub
                'End If

                If ToBool(Value) = True And .Text("doc_no") <> "" Then
                    MessageInfo("이미 전표가 발행되었습니다.")
                    .UpdateRow()
                    '.Text("chk") = ""
                    Exit Sub
                End If

                'Me.Sum_All()
            End If
            'If ColumnName = "set_amt" Or ColumnName = "set_vat" Then
            '    Me.Sum_All()
            'End If
        End With


    End Sub



    Private Sub btn_jump_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_jump.Click
        If doc_no.Text = "" Then
            Exit Sub
        End If

        Dim menuName As String
        'If Parameter.System.Code = "CSI" Then
        '    menuName = "FAB100_CSI"
        'Else
        menuName = "FAB100"
        'End If

        '화면을 띄운다
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName) 'New FormAttribute(menuName, menuText))
        If ctr IsNot Nothing Then
            ctr.Open2(doc_no.Text)
        End If

    End Sub


    Private Sub chk_all_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_all.CheckedChanged
        g10.CheckRows("chk", chk_all.Checked)
    End Sub

End Class
