Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class SDD100

    Private Sub SDD100_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Open()

        '매출번호 채번
        sal_no.CodeNo = "SDD100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        sal_no.CodeDateField = sal_dt

        Me.New_Form()

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open_Form()

            Case MenuType.Save
                Me._Save()

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

    Public Sub _Save()
        Me.SumAmt()
        If MyBase.Save() Then
            MyBase.Open()
        End If
    End Sub

    Public Sub Open_Form()

        Me.Open()

        g10.AddNewRow()
    End Sub

    Public Sub New_Form()
        sal_no.Text = ""

        Me.Open_Form()
    End Sub


    Public Sub Open2(ByVal SalNo As String)

        sal_no.Text = SalNo

        Me.Open_Form()

    End Sub

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        With g10
            If ColumnName = "sal_up" Or ColumnName = "sal_qty" Then
                .Text("sal_famt") = .ToDec("sal_up") * .ToDec("sal_qty")
            End If

            If ColumnName = "sal_amt" Or ColumnName = "sal_famt" Or ColumnName = "vat_amt" Then
                If .ToDec("sal_qty") = 0 And .ToDec("sal_amt") = 0 And .ToDec("sal_famt") = 0 Then
                    If .Text("sal_sq") <> "" Then
                        .Text("sal_sq") = ""
                    End If
                Else
                    If .Text("sal_sq") = "" Then
                        .Text("sal_sq") = .GetNextNumber("sal_sq").ToString
                    End If
                End If
            End If

            If ColumnName = "sal_famt" Then
                .Text("sal_amt") = .ToDec("sal_famt") * IIf(ex_rt.ToDec = 0, 1, ex_rt.ToDec)
            End If

            If ColumnName = "sal_amt" Then
                .Text("vat_amt") = .ToDec("sal_amt") * vat_rt.ToDec / 100
            End If

            If ColumnName = "sal_amt" Or ColumnName = "sal_famt" Or ColumnName = "vat_amt" Then
                Me.SumAmt()
            End If

        End With
    End Sub

    Private Sub SumAmt()
        Dim sum_famt As Double, sum_amt As Double, sum_vat As Double

        With g10
            .UpdateCurrentRow()
            For i As Integer = 0 To .RowCount - 1
                sum_famt = sum_famt + .ToDec("sal_famt", i)
                sum_amt = sum_amt + .ToDec("sal_amt", i)
                sum_vat = sum_vat + .ToDec("vat_amt", i)
            Next
        End With

        sal_amt.Text = sum_amt
        sal_famt.Text = sum_famt
        vat_amt.Text = sum_vat
        tot_amt.Text = ToDec(sal_amt.Text) + ToDec(vat_amt.Text)

    End Sub

    Private Sub vat_bc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles vat_bc.TextChanged

        Dim dSet As Data.DataSet = Me.OpenDataSet("sdb100_vat_rt")
        Dim rt As String = ""
        If Not IsEmpty(dSet) Then
            rt = DataValue(dSet)
        End If

        vat_rt.Text = rt
        '부가세율에 따른 부가세산출공식 변경
        'g10.GridColumn("vat_amt").CompuText = "[sal_amt] * " + IIf(rt = "", "0", rt) + " / 100"

        Me.CompAmt()
        Me.SumAmt()
    End Sub

    Private Sub ex_rt_TextChanged(ByVal sender As Object, ByVal oldValue As String) Handles ex_rt.TextChanged
        'Dim rt As Decimal = ex_rt.ToDec
        'If rt = 0 Then
        '    rt = 1
        'End If
        '환율에 따른 공식 변경
        'g10.GridColumn("sal_amt").CompuText = "[sal_famt] * " + rt.ToString

        Me.CompAmt()
        Me.SumAmt()
    End Sub

    Private Sub CompAmt()
        Dim rt1 As Double = ex_rt.ToDec
        Dim rt2 As Double = vat_rt.ToDec
        With g10
            For i As Integer = 0 To .RowCount - 1
                .Text("sal_amt", i) = .ToDec("sal_famt", i) * rt1
                .Text("vat_amt", i) = .ToDec("sal_amt", i) * rt2 / 100
            Next
        End With
    End Sub

    Public Sub Open3(ByVal dSet As DataSet)

        Me.New_Form()
        g10.DeleteBlankRow()

        ent_bc.Text = "SD320100"    '출하매출
        btn_up.Visible = True

        Dim i As Integer = 0
        For Each dRow As DataRow In dSet.Tables(0).Rows
            If ToBool(dRow("chk")) Then

                If i = 0 Then
                    cust_cd.Text = ToStr(dRow("cust_cd2"))
                    ex_rt.Text = ToDec(dRow("ex_rt"))
                End If

                g10.AddNewRow()
                For Each Col As DataColumn In dSet.Tables(0).Columns
                    For k = 0 To g10.ColumnCount - 1
                        If g10.FieldName(k) = "stat_bc" Then
                        Else
                            If Col.ColumnName = g10.FieldName(k) Then
                                g10.Text(g10.FieldName(k), g10.RowIndex) = ToStr(dRow(Col.ColumnName))
                            End If
                        End If
                    Next
                Next
                g10.Text("sal_qty", g10.RowIndex) = ToStr(dRow("sal_qty"))
                g10.Text("sal_up", g10.RowIndex) = ToStr(dRow("out_up"))
            End If
        Next
      
    End Sub

    Public Sub Open4(ByVal dSet As DataSet)

        Me.New_Form()
        g10.DeleteBlankRow()

        ent_bc.Text = "SD320150"    '가공비 출하매출
        btn_up.Visible = False

        Dim i As Integer = 0
        For Each dRow As DataRow In dSet.Tables(0).Rows
            If ToBool(dRow("chk")) Then

                If i = 0 Then
                    cust_cd.Text = ToStr(dRow("cust_cd2"))
                End If

                g10.AddNewRow()
                For Each Col As DataColumn In dSet.Tables(0).Columns
                    For k = 0 To g10.ColumnCount - 1
                        If g10.FieldName(k) = "stat_bc" Then
                        Else
                            If Col.ColumnName = g10.FieldName(k) Then
                                g10.Text(g10.FieldName(k), g10.RowIndex) = ToStr(dRow(Col.ColumnName))
                            End If
                        End If
                    Next
                Next
                g10.Text("sal_qty", i) = ToStr(dRow("sal_qty"))
                g10.Text("sal_up", i) = ToStr(dRow("out_up"))
            End If
        Next
    End Sub

    '이동출하매출 (업체재고로부터 매출)
    Public Sub Open5(ByVal dSet As DataSet)

        Me.New_Form()
        g10.DeleteBlankRow()

        ent_bc.Text = "SD320130"    '이동출하매출 (재고로부터 매출)
        btn_up.Visible = True

        Dim i As Integer = 0
        For Each dRow As DataRow In dSet.Tables(0).Rows
            If ToBool(dRow("chk")) Then

                If i = 0 Then
                    cust_cd.Text = ToStr(dRow("cust_cd2"))
                End If

                g10.AddNewRow()
                For Each Col As DataColumn In dSet.Tables(0).Columns
                    For k = 0 To g10.ColumnCount - 1
                        If g10.FieldName(k) = "stat_bc" Then
                        Else
                            If Col.ColumnName = g10.FieldName(k) Then
                                g10.Text(g10.FieldName(k), g10.RowIndex) = ToStr(dRow(Col.ColumnName))
                            End If
                        End If
                    Next
                Next
                g10.Text("sal_qty", g10.RowIndex) = ToStr(dRow("sal_qty"))
                g10.Text("sal_up", g10.RowIndex) = ToStr(dRow("out_up"))
            End If
        Next
    End Sub

    '이동출하매출 (이동출고로 부터 매출) -> 이동번호저장 -> 매출처리 -> 출고처리
    Public Sub Open6(ByVal dSet As DataSet)

        Me.New_Form()
        g10.DeleteBlankRow()

        ent_bc.Text = "SD320130"    '이동출하매출 (이동출고로 부터 매출)
        btn_up.Visible = True

        Dim i As Integer = 0
        For Each dRow As DataRow In dSet.Tables(0).Rows
            If ToBool(dRow("chk")) Then
                If i = 0 Then
                    cust_cd.Text = ToStr(dRow("cust_cd2"))
                End If

                g10.AddNewRow()
                For Each Col As DataColumn In dSet.Tables(0).Columns
                    For k = 0 To g10.ColumnCount - 1
                        If g10.FieldName(k) = "stat_bc" Then
                        Else
                            If Col.ColumnName = g10.FieldName(k) Then
                                g10.Text(g10.FieldName(k), g10.RowIndex) = ToStr(dRow(Col.ColumnName))
                            End If
                        End If
                    Next
                Next
                '출고공장,창고
                g10.Text("fac_cd", g10.RowIndex) = ToStr(dRow("in_fac"))
                g10.Text("wh_cd", g10.RowIndex) = ToStr(dRow("in_wh"))
                g10.Text("sal_qty", g10.RowIndex) = ToStr(dRow("sal_qty"))
                g10.Text("sal_up", g10.RowIndex) = ToStr(dRow("out_up"))
              End If
        Next
    End Sub

    '최신단가 적용
    Private Sub btn_up_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_up.Click
        With g10
            Dim up As Decimal, p As New OpenParameters
            Dim dSet As Data.DataSet
            For i As Integer = 0 To .RowCount - 1
                p = New OpenParameters
                p.Add("@itm_id", .Text("itm_id", i))
                p.Add("@cust_cd", cust_cd.Text)
                p.Add("@fr_dt", sal_dt.Text)
                p.Add("@up_bc", "")
                p.Add("@cury_bc", "")

                dSet = Me.OpenDataSet("sdd100_price", p)
                up = ToDec(DataValue(dSet))

                .RowIndex = i
                .Text("sal_up") = up
                .UpdateCurrentRow()
            Next
        End With
    End Sub

End Class
