Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class LEB160DBN

    Private Shared Property ReportView As Object


    Private Sub LEB160DBN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '자재 출하 번호 채번
        out_no.CodeNo = "LEB100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        out_no.CodeDateField = out_dt

        Me.New_Form()

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            'Case MenuType.Open
            '    MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
            '    '사용하려면 재정의 가능하다
            Case MenuType.Save

                If MyBase.Save() Then
                    Me.Open_Form()
                End If

            Case MenuType.Delete
                'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

            Case MenuType.New
                Me.New_Form()


            Case MenuType.Print
                ' Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub New_Form()
        out_no.Text = ""

        Me.Open()

        g10.AddNewRow()
    End Sub

    Private Sub Open_Form()

        union_yn.Text = "0"

        Me.Open()
    End Sub

    'Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click

    '    If Not CheckRequired(cust_cd2) Then Exit Sub

    '    Dim p As New OpenParameters

    '    p.Add("@out_no", out_no.Text)

    '    p.Add("@out_dt", out_dt.Text)
    '    p.Add("@cury_bc", cury_bc.Text)
    '    p.Add("@cust_cd", cust_cd2.Text)

    '    Me.Open("leb160_item", p)

    'End Sub

    'Public Sub Set_maxSq()

    '    Dim iRow As Integer, maxNo As Double

    '    For iRow = 0 To g10.RowCount - 1
    '        If maxNo < g10.ToDec("out_sq", iRow) Then
    '            maxNo = g10.ToDec("out_sq", iRow)
    '        End If
    '    Next
    '    g10.Text("out_sq") = maxNo + 1
    'End Sub

    'Private Sub g10_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object)

    '    If ColumnName = "out_qty" Then
    '        If Value > "0" And g10.ToDec("out_sq") = 0 Then
    '            Set_maxSq()
    '        ElseIf Value = "0" Then
    '            g10.Text("out_sq") = ""
    '        End If

    '    End If
    'End Sub

    Public Sub Open2(ByVal outNo As String)
        out_no.Text = outNo
        Me.Open()
    End Sub



    '수주출하등록(LEB150)에서 Jump
    Public Sub Open3(ByVal dSet As DataSet)
        Me.New_Form()
        g10.DeleteBlankRow()

        Dim i As Integer = 0
        For Each dRow As DataRow In dSet.Tables(0).Rows
            If ToStr(dRow("chk")) Then

                If i = 0 Then
                    cust_cd.Text = ToStr(dRow("cust_cd"))
                    ent_bc.Text = "LE910100"    '수주출하
                End If

                g10.AddNewRow()
                g10.Text("so_no", i) = ToStr(dRow("so_no"))
                g10.Text("so_sq", i) = ToStr(dRow("so_sq"))
                'g10.Text("itm_id", i) = ToStr(dRow("itm_id"))
                g10.Text("itm_cd", i) = ToStr(dRow("itm_cd"))
                'g10.Text("itm_nm", i) = ToStr(dRow("itm_nm"))
                'g10.Text("itm_bc", i) = ToStr(dRow("itm_bc"))
                'g10.Text("spec", i) = ToStr(dRow("spec"))
                'g10.Text("model_cd", i) = ToStr(dRow("model_cd"))
                'g10.Text("spec1", i) = ToStr(dRow("spec1"))
                'g10.Text("std_um", i) = ToStr(dRow("std_um"))
                g10.Text("um_bc", i) = ToStr(dRow("um_bc"))
                'g10.Text("cury_bc", i) = ToStr(dRow("cury_bc"))
                g10.Text("out_qty", i) = ToStr(dRow("qty"))
                'g10.Text("out_up", i) = ToStr(dRow("so_sq"))
                'g10.Text("out_amt", i) = Outtot * Soup

                i += 1
            End If


        Next

    End Sub


    Private Sub btn_prt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_prt.Click
        Dim Type, Gubn, ChkCost As String

        Type = print_ty.Text
        ChkCost = chk_cost.Text

        If Type = "" Then  '양식이 선택되지 않으면 표준으로 출력하기
            Type = "LEB160_DBN"
            ' Gubn = "0"
        Else
            ' Gubn = Mid(Type, Len(Type), 1)

        End If
        Gubn = "7"

        If out_no.Text = "" Then
            MessageInfo("출고 번호가 누락 되었습니다.")
            Exit Sub
        End If
        Dim p As OpenParameters = New OpenParameters

        p.Add("@out_no", out_no.Text)
        p.Add("@gubn", Gubn)
        p.Add("@chk_cost", ChkCost)

        System7.ReportView.LoadView(Type, "", "LEB160dbn_cust_Print", p)

        ' If Gubn = "6" Then
        'Dim p1 As OpenParameters = New OpenParameters

        'p1.Add("@out_no", out_no.Text)

        'LEB160DBN.ReportView.LoadView(Type, "", "LEB160_cust_Print", p, , , , Type, "LEB160_cust_Print1", p1)
        'Exit Sub
        'End If
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        If out_no.Text = "" Then
            MessageInfo("출고 번호가 누락 되었습니다.")
            Exit Sub
        End If

        Me.Print()
    End Sub
    Private Sub Print()
        Dim p As OpenParameters = New OpenParameters
        ' Dim Type As String
        'Type = print_ty.Text

        p.Add("@out_no", out_no.Text)


        System7.ReportView.LoadView("LEM101", "", "LEB160_out_Print", p)

    End Sub


    Private Sub btn_cust_items_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cust_items.Click
        union_yn.Text = "1"

        g10.Open()

    End Sub

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        With g10
            If ColumnName = "out_amt" Or ColumnName = "out_qty" Then
                If .ToDec("out_qty") = 0 And .ToDec("out_amt") = 0 Then
                    If .Text("out_sq") <> "" Then
                        .Text("out_sq") = ""
                    End If
                Else
                    If .Text("out_sq") = "" Then
                        .Text("out_sq") = .GetNextNumber("out_sq").ToString
                    End If
                End If
            End If

            If ColumnName = "out_qty" Or ColumnName = "out_up" Then

                .Text("out_amt") = .ToDec("out_qty") * .ToDec("out_up")
            End If

            ' If ColumnName = "out_amt" Or ColumnName = "vat_chk" Then
            'If .Text("vat_chk") = "1" Then
            ' .Text("out_up") = (.ToDec("out_amt") - .ToDec("out_amt") / 10.0) / .ToDec("out_qty")
            ' .Text("out_amt") = .ToDec("out_qty") * .ToDec("out_up")
            ' End If

            'End If

            'If ColumnName = "so_amt" Then
            ' .Text("so_vat") = .ToDec("so_amt") * vat_rt.ToDec / 100
            ' End If
            'If ColumnName = "so_amt" Or ColumnName = "so_vat" Then
            ' Me.SumAmt()
            ' End If

        End With
    End Sub
    Private Sub g10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g10.Load

    End Sub
End Class
