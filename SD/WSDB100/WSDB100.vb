Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WSDB100

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pnlCopy.Visible = False
        SplitContainer2.Panel1Collapsed = Not chk_show.Checked
    End Sub

    Private Sub WSDB100_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '수주 번호 채번
        so_no.CodeNo = "SDB100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        so_no.CodeDateField = so_dt

        Me.New_Form()

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                Me.Open_Form()

            Case MenuType.Save

                Me.SumAmt()

                If MyBase.Save() Then
                    Me.Open_Form()
                End If

            Case MenuType.Delete
                'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

            Case MenuType.New
                Me.New_Form()
                'Me.WorkSets("sdb100_g10").AddNew()  '특정Workset 신규처리

            Case MenuType.Print
                ' Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Public Sub Open_Form()
        union_yn.Text = "0"
        Me.Open()

        g20.AddNewRow()
    End Sub

    Public Sub New_Form()
        so_no.Text = ""

        Me.Open_Form()
    End Sub

    Public Sub Open2(ByVal SoNo As String)

        so_no.Text = SoNo

        Me.Open_Form()

    End Sub

    Private Sub btn_cust_items_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cust_items.Click

        union_yn.Text = "1"

        g20.Open()

        Me.SumAmt()

        'Me.Open("g

        'Dim p As New OpenParameters

        'p.Add("@so_no", so_no.Text)
        'p.Add("@so_dt", so_dt.Text)
        'p.Add("@cury_bc", cury_bc.Text)
        'p.Add("@cust_cd", cust_cd.Text)

        'Me.Open("sdb100_item", p)

        ''Me.OpenDataSet("mmb100_itm", p)
        ''g10.AddNewRow()
        ''MyBase.Open("mmb100_itm", p)
    End Sub


    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object)
        With g20
            If ColumnName = "so_amt" Or ColumnName = "so_qty" Then
                If .ToDec("so_qty") = 0 And .ToDec("so_amt") = 0 Then
                    If .Text("so_sq") <> "" Then
                        .Text("so_sq") = ""
                    End If
                Else
                    If .Text("so_sq") = "" Then
                        .Text("so_sq") = .GetNextNumber("so_sq").ToString
                    End If
                End If
            End If
            If ColumnName = "so_qty" Or ColumnName = "so_up" Then
                .Text("so_amt") = .ToDec("so_qty") * .ToDec("so_up")
            End If
            If ColumnName = "so_amt" Then
                .Text("so_vat") = .ToDec("so_amt") * vat_rt.ToDec / 100
            End If
            If ColumnName = "so_amt" Or ColumnName = "so_vat" Then
                Me.SumAmt()
            End If
        End With
    End Sub

    Private Sub CompAmt()
        Dim rt As Double = vat_rt.ToDec
        With g20
            For i As Integer = 0 To .RowCount - 1
                .RowIndex = i
                .Text("so_vat") = .ToDec("so_amt") * rt / 100
            Next
            .UpdateRow()
        End With
    End Sub

    Private Sub SumAmt()
        Dim sum_amt As Double, sum_vat As Double

        With g20
            .UpdateRow()
            For i As Integer = 0 To .RowCount - 1
                sum_amt = sum_amt + .ToDec("so_amt", i)
                sum_vat = sum_vat + .ToDec("so_vat", i)
            Next
        End With

        so_amt.Text = sum_amt
        so_vat.Text = sum_vat
        tot_amt.Text = sum_amt + sum_vat
    End Sub

    Private Sub vat_bc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles vat_bc.TextChanged

        Dim dSet As Data.DataSet = Me.OpenDataSet("sdb100_vat_rt")
        Dim rt As String = ""
        If Not IsEmpty(dSet) Then
            rt = DataValue(dSet)
        End If

        vat_rt.Text = rt
        ''부가세율에 따른 부가세산출공식 변경
        'g10.GridColumn("so_vat").CompuText = "[so_amt] * " + IIf(rt = "", "0", rt) + " / 100"

        Me.CompAmt()
        Me.SumAmt()
    End Sub

    Private Sub chk_show_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_show.CheckedChanged
        SplitContainer2.Panel1Collapsed = Not chk_show.Checked
    End Sub


    Private Sub btn_copy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_copy.Click
        pnlCopy.Visible = Not pnlCopy.Visible
    End Sub

End Class
