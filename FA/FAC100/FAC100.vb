Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAC100

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        tax_no.CodeNo = "FAC100"
        tax_no.CodeDateField = tax_dt

        Me._NewForm()

        AddHandler Me.WorkSet("fac100_f1").AfterOpen, AddressOf AfterOpen

    End Sub

    Private Sub AfterOpen(ByVal wSet As WorkSet)
        '유형전표는 Red로 표시
        stat_bc.TextForeColor = IIf(stat_bc.Text = m_Approved, Color.DeepPink, Color.Black)
    End Sub


    Private m_Approved = "FA350500"   '승인상태

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                MyBase.Open()
                'Me.Open("fac100_f1")
                'Me.Open("fac100_g10")

            Case MenuType.Save

                Me.SumAmt()

                If stat_bc.Text = m_Approved Then
                    MessageInfo("이미 [전표승인] 되어 저장할 수 없습니다.")
                    Exit Select
                End If

                Me.Save()

                'If tax_no.Text = "" Then
                '    Me.Open("fac100_f2")
                'End If
                'MyBase.Save("fac100_f1")
                'MyBase.Open("fac100_f1")
                'MyBase.Save("fac100_g10")

            Case MenuType.Delete
                Me.WorkSets("fac100_f1").DeleteRow()

                MyBase.Open()

                'Me.WorkSets("fac100_g10").DeleteRow()

            Case MenuType.New

                Me._NewForm()

                'Me.WorkSets("fac100_f1").AddNew()
                'g10.DeleteAll()
                'Me.WorkSets("fac100_g10").AddNew()

            Case MenuType.Print
                Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    Private Sub _NewForm()
        tax_no.Text = ""
        Me.Open()
        Me.WorkSets("fac100_g10").AddNew()
    End Sub

    Public Sub Open2(ByVal taxno As String)
        tax_no.Text = taxno

        Me.Open()
    End Sub

#Region " Event "

    Private Sub card_no_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles card_no.Click
        card_no.SelectionStart = 0
    End Sub

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged

        'If g10.RowIndex < 0 Or g10.RowCount < 1 Then Exit Sub

        '[자동전표발행세금계산서는 품목과 규격만 변경가능하다]
        If ColumnName = "qty" Or ColumnName = "up" Then

            g10.Text("item_amt", g10.RowIndex) = Val(g10.Text("qty", g10.RowIndex)) * Val(g10.Text("up", g10.RowIndex))

        End If

        If ColumnName = "item_amt" Then

            g10.Text("vat_amt", g10.RowIndex) = Val(g10.Text("item_amt", g10.RowIndex)) * 0.1

        End If


        If g10.RowIndex < 0 Then Exit Sub

        Me.SumAmt()

        'vat_amt.Text = vat_Sum(0, g10.RowIndex)


    End Sub

    Private Sub SumAmt()

        Dim i As Integer
        'Dim j As Integer
        Dim itemsum(2) As Double

        For i = 0 To g10.RowIndex

            itemsum(0) = itemsum(0) + Val(g10.Text("item_amt", i))
            itemsum(1) = itemsum(1) + Val(g10.Text("vat_amt", i))
            itemsum(2) = itemsum(2) + Val(g10.Text("amt", i))

        Next

        item_amt.Text = itemsum(0)
        vat_amt.Text = itemsum(1)
        amt.Text = itemsum(0) + itemsum(1)

    End Sub


#End Region

    Private Sub Print()

        If g10.RowCount <= 0 Then Exit Sub
        If tax_no.Text = "" Then
            MessageInfo("[계산서번호]는 필수 입력입니다.")
            Exit Sub
        End If

        If tax_kd.Text <> "FA600200" Then
            MessageInfo("매출세금계산서]만 출력이 가능합니다.")
            Exit Sub
        End If

        Dim p As OpenParameters = New OpenParameters
        p.Add("@tax_no", tax_no.Text)

        System7.ReportView.LoadView("fac100", "", "fac100_Print", p) '계산서

    End Sub

End Class
