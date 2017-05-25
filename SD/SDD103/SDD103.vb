Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Collections

Public Class SDD103

    Private Sub SDD103_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Open()

        '세금계산서번호 채번
        tax_no.CodeNo = "FAC100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        tax_no.CodeDateField = tax_dt

        Me.New_Form()

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                '사용하려면 재정의 가능하다
            Case MenuType.Save
                'If MyBase.Save() Then

                ' MyBase.Open()
                'End If

            Case MenuType.Delete
                'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

            Case MenuType.New
                New_Form()

            Case MenuType.Print
                ' Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Public Sub Open_Form()

        Me.Open()

        ' g10.AddNewRow()
    End Sub

    Public Sub New_Form()
        tax_no.Text = ""
        tax_dt.Text = ""

        Me.Open_Form()
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Dim custCd As String = "", vatBc As String = ""

        'Dim iCnt As Integer = CheckedGridRow(epfs102f_g1, "chk1")
        Dim itm As String = "", cnt As Decimal = 0, qty As Decimal = 0, up As Decimal = Nothing

        If Not CheckRequired(tax_dt) Then
            Exit Sub
        End If

        If g10.CheckedRows("chk") = 0 Then
            Exit Sub
        End If

        If MessageYesNo("세금계산서를 발행하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        End If

        '선택행 체크
        Dim iRow As Integer
        With g10
            For iRow = 0 To .RowCount - 1
                If .ToBool("chk", iRow) Then

                    If .Text("tax_no", iRow) <> "" Then
                        MessageInfo("이미 세금계산서가 발행된 것이 있습니다")
                        Exit Sub
                    End If

                    'cnt += .ToDec("cnt", iRow)
                    'qty += .ToDec("qty", iRow)
                    'If itm = "" Then
                    '    itm = .Text("item", iRow)
                    'End If

                    If custCd = "" Then
                        'bsCd = .Text("sal_bs", iRow)
                        vatBc = .Text("vat_bc", iRow)
                        custCd = .Text("cust_cd", iRow)
                    Else
                        If vatBc <> .Text("vat_bc", iRow) Or _
                           custCd <> .Text("cust_cd", iRow) Then
                            MessageInfo("[거래처], [계산서구분]은 같아야 합니다")
                            Exit Sub
                        End If
                    End If
                End If
            Next
        End With

        Me.Sum_All()

        'If cnt = 1 Then
        '    up = item_amt.ToDec / qty
        'Else
        '    itm = "매출 (" + itm + "외 " + Str(cnt - 1) + "건)"
        '    up = Nothing
        '    qty = Nothing
        'End If

        'g10.Text("item") = itm

        cust_cd2.Text = custCd
        tax_bc.Text = vatBc
        'item.Text = itm

        If MyBase.Save() Then
            Me.Open()
            g10.Find("tax_no=" + tax_no.Text)
        End If

        'Dim menuName As String = "FAC100"
        'Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
        'ctr.Open2(tax_no.Text)

        'New_Form()

    End Sub



    Private Sub Sum_All()
        Dim iRow As Integer, sum_amt As Double, sum_vat As Double

        With g10
            For iRow = 0 To .RowCount - 1
                If .IsDataRow(iRow) Then
                    If .ToBool("chk", iRow) Then
                        sum_amt += .ToDec("sal_amt", iRow)
                        sum_vat += .ToDec("vat_amt", iRow)
                    End If
                End If
            Next
            item_amt.Text = sum_amt
            vat_amt.Text = sum_vat
            tot_amt.Text = ToDec(sum_amt) + ToDec(sum_vat)
        End With
    End Sub

    'Private m_StopEvent As Boolean = False

    Private Sub g10_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging
        Dim custCd As String, vatBc As String
        Dim chkCnt As Integer = 0, chkCnt2 As Integer = 0

        'If m_StopEvent Then
        '    Exit Sub
        'End If
        'm_StopEvent = True
        With g10
            If ToBool(Value) And .Text("tax_no") <> "" Then
                MessageInfo("이미 계산서가 발행되었습니다.")
                .UpdateRow()
                Exit Sub
            End If

            If ColumnName = "chk" Then
                custCd = .Text("cust_cd")
                vatBc = .Text("vat_bc")

                '  동일 거래처  체크
                For iRow = 0 To g10.RowCount - 1
                    If custCd <> .Text("cust_cd", iRow) And .ToBool("chk", iRow) Then
                        chkCnt += 1
                    End If
                    If vatBc <> .Text("vat_bc", iRow) And .ToBool("chk", iRow) Then
                        chkCnt2 += 1
                    End If
                Next

                If chkCnt > 0 Or chkCnt2 > 0 Then
                    MessageInfo("[거래처], [계산서구분]은 같아야 합니다")
                    g10.UpdateRow()
                    'g10.Text("chk") = ""
                End If

                'If ToBool(Value) And g10.Text("tax_no") <> "" Then
                '    g10.UpdateRow()
                '    'g10.Text("chk") = ""
                'End If

                'g10.UpdateRow()
                Sum_All()
            End If

        End With

        'm_StopEvent = False
    End Sub

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        If ColumnName = "chk" Then
            Sum_All()
        End If
    End Sub


    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.DoubleClick

        tax_no.Text = g10.Text("tax_no")

    End Sub

    Private Sub btn_taxdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_taxdel.Click
        If tax_no.Text <> "" Then
            'Dim p As New OpenParameters

            ' p = New OpenParameters
            ' p.Add("@tax_no", tax_no.Text)


            If MessageYesNo("세금계산서를 삭제하시겠습니까?") = MsgBoxResult.No Then
                Exit Sub
            End If


            Me.Open("sdd103_delete")

            Me.New_Form()
        Else
            MessageInfo("먼저 세금계산서를 선택하세요")
            Exit Sub
        End If
    End Sub

    Private Sub btn_jump_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_jump.Click
        Dim menuName As String = "FAC100"
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
        ctr.Open2(tax_no.Text)
    End Sub

End Class
