Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class LEA110


    Private Sub LEA110_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '자재 입고 번호 채번
        in_no.CodeNo = "LEA100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        in_no.CodeDateField = in_dt

        Me.New_Form()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                'MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                Open_Form()
                '사용하려면 재정의 가능하다
            Case MenuType.Save
                If MyBase.Save() Then
                    Open_Form()
                    'MyBase.Open()
                End If

            Case MenuType.New
                New_Form()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub



    Public Sub Open_Form()
        union_yn.Text = "0"
        MyBase.Open()
    End Sub

    Public Sub New_Form()
        in_no.Text = ""
        MyBase.Open()

        g10.AddNewRow()
    End Sub

    Public Sub Open2(ByVal inNo As String)
        in_no.Text = inNo
        MyBase.Open()
    End Sub

    Public Sub Open3(ByVal dSet As DataSet)
        Me.New_Form()
        g10.DeleteBlankRow()

        Dim i As Integer = 0
        For Each dRow As DataRow In dSet.Tables(0).Rows
            If ToBool(dRow("chk")) Then

                If i = 0 Then
                    cust_cd.Text = ToStr(dRow("cust_cd"))
                    fac_cd.Text = ToStr(dRow("in_fac"))
                    wh_cd.Text = ToStr(dRow("in_wh"))
                    ent_bc.Text = "LE900200" '구매입고
                End If

                g10.AddNewRow()
                g10.RowIndex = i
                'g10.Text("so_no") = ToStr(dRow("so_no"))
                'g10.Text("so_sq") = ToStr(dRow("so_sq"))
                'g10.Text("itm_id", i) = ToStr(dRow("itm_id"))
                g10.Text("itm_cd") = ToStr(dRow("itm_cd"))
                'g10.Text("itm_nm", i) = ToStr(dRow("itm_nm"))
                'g10.Text("itm_bc", i) = ToStr(dRow("itm_bc"))
                'g10.Text("spec", i) = ToStr(dRow("spec"))
                'g10.Text("model_cd", i) = ToStr(dRow("model_cd"))
                'g10.Text("spec1", i) = ToStr(dRow("spec1"))
                'g10.Text("std_um", i) = ToStr(dRow("std_um"))
                g10.Text("um_bc") = ToStr(dRow("dlv_um"))
                'g10.Text("cury_bc", i) = ToStr(dRow("cury_bc"))
                g10.Text("um_qty") = ToStr(dRow("qty"))

                g10.Text("po_no", i) = ToStr(dRow("po_no"))
                g10.Text("po_sq", i) = ToStr(dRow("po_sq"))

                'g10.Text("out_up", i) = ToStr(dRow("so_sq"))
                'g10.Text("out_amt", i) = Outtot * Soup

                i += 1
            End If


        Next


    End Sub

    Public Sub Open4(ByVal dSet As DataSet)
        Me.New_Form()
        g10.DeleteBlankRow()

        Dim i As Integer = 0
        For Each dRow As DataRow In dSet.Tables(0).Rows
            If ToBool(dRow("chk")) Then

                If i = 0 Then
                    cust_cd.Text = ToStr(dRow("cust_cd"))
                    fac_cd.Text = ToStr(dRow("in_fac"))
                    wh_cd.Text = ToStr(dRow("in_wh"))
                    ent_bc.Text = "LE900500" '긴급납품입고
                End If

                g10.AddNewRow()
                g10.RowIndex = i
                'g10.Text("so_no") = ToStr(dRow("so_no"))
                'g10.Text("so_sq") = ToStr(dRow("so_sq"))
                'g10.Text("itm_id", i) = ToStr(dRow("itm_id"))
                g10.Text("itm_cd") = ToStr(dRow("itm_cd"))
                'g10.Text("itm_nm", i) = ToStr(dRow("itm_nm"))
                'g10.Text("itm_bc", i) = ToStr(dRow("itm_bc"))
                'g10.Text("spec", i) = ToStr(dRow("spec"))
                'g10.Text("model_cd", i) = ToStr(dRow("model_cd"))
                'g10.Text("spec1", i) = ToStr(dRow("spec1"))
                'g10.Text("std_um", i) = ToStr(dRow("std_um"))
                g10.Text("um_bc") = ToStr(dRow("dlv_um"))
                'g10.Text("cury_bc", i) = ToStr(dRow("cury_bc"))
                g10.Text("um_qty") = ToStr(dRow("qty"))

                g10.Text("po_no", i) = ToStr(dRow("po_no"))
                g10.Text("po_sq", i) = ToStr(dRow("po_sq"))
                g10.Text("dlv_no", i) = ToStr(dRow("dlv_no"))
                g10.Text("dlv_sq", i) = ToStr(dRow("dlv_sq"))

                'g10.Text("out_up", i) = ToStr(dRow("so_sq"))
                'g10.Text("out_amt", i) = Outtot * Soup

                i += 1
            End If


        Next


    End Sub

    'Public Sub Open2(ByVal Pono As String, ByVal PoSeq As String, ByVal Itmid As String, ByVal Itmcd As String, ByVal Itmnm As String, ByVal Spec As String, ByVal Poqty As String, _
    '                 ByVal Custcd As String, ByVal Custnm As String, ByVal Infac As String, ByVal Inwh As String, ByVal Indt As String)

    '    cust_cd.Text = Custcd
    '    cust_nm.Text = Custnm
    '    fac_cd.Text = Infac
    '    wh_cd.Text = Inwh
    '    in_dt.Text = Indt
    '    With g10
    '        Dim jRow As Integer = 0
    '        g10.AddNewRow()
    '        jRow = g10.RowIndex
    '        g10.Text("po_no", jRow) = Pono
    '        g10.Text("po_sq", jRow) = PoSeq
    '        g10.Text("itm_id", jRow) = Itmid
    '        g10.Text("itm_cd", jRow) = Itmcd
    '        g10.Text("itm_nm", jRow) = Itmnm
    '        g10.Text("spec", jRow) = Spec
    '        ' g10.Text("dlv_um", jRow) = Umbc
    '        ' g10.Text("um_bc", jRow) = Std_Umbc
    '        g10.Text("in_qty", jRow) = Poqty
    '        g10.Text("in_bc", jRow) = "LE100100"

    '    End With
    'End Sub

    Private Sub btn_price_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_price.Click

        g10.UpdateRow()

        For i As Integer = 0 To g10.RowCount - 1
            Me.Set_Price(i)
        Next
    End Sub

    Private Sub Set_Price(ByVal rowInx As Integer)
        Dim p As New OpenParameters
        p.Add("@itm_id", g10.Text("itm_id", rowInx))
        p.Add("@cust_cd", cust_cd.Text)
        p.Add("@cury_bc", g10.Text("cury_bc", rowInx))
        p.Add("@po_fac", fac_cd.Text)
        p.Add("@po_dt", in_dt.Text)
        Dim dSet As DataSet = OpenDataSet("mmb100_cost", p)

        If Not IsEmpty(dSet) Then
            g10.RowIndex = rowInx
            g10.Text("in_up") = DataValue(dSet, "up")
        End If
    End Sub

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        With g10

            If ColumnName = "itm_cd" Then
                Me.Set_Price(RowIndex)
            End If


            If ColumnName = "in_amt" Or ColumnName = "um_qty" Then
                If .ToDec("um_qty") = 0 And .ToDec("in_amt") = 0 Then
                    If .Text("in_sq") <> "" Then
                        .Text("in_sq") = ""
                    End If
                Else
                    If .Text("in_sq") = "" Then
                        .Text("in_sq") = .GetNextNumber("in_sq").ToString
                    End If
                End If
            End If

            If ColumnName = "um_qty" Or ColumnName = "in_up" Then
                .Text("in_amt") = .ToDec("um_qty") * .ToDec("in_up")
            End If

        End With
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        union_yn.Text = "1"

        g10.Open()
    End Sub
End Class
