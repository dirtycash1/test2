Imports Frame7
Imports Base7
Imports Base7.Shared
Public Class MMR201


    'Private Sub MMB150_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    'End Sub

    'Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
    '    Select Case mty
    '        Case MenuType.Open
    '            MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
    '            '사용하려면 재정의 가능하다
    '        Case MenuType.Save
    '            'If MyBase.Save() Then

    '            ' MyBase.Open()
    '            'End If

    '        Case MenuType.Delete
    '            'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

    '        Case MenuType.New
    '            ' Me.WorkSets("mma100_g10").AddNew()  '특정Workset 신규처리

    '        Case MenuType.Print
    '            ' Me.Print()

    '        Case Else
    '            MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

    '    End Select

    'End Sub

    Private m_StopEvent As Boolean


    Private Sub g10_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging
        Dim Poqty As Integer
        Dim iRow, Cust_cnt As Integer, CustCd As String

        If m_StopEvent Then
            Return
        End If

        m_StopEvent = True

        Try
            If ColumnName = "chk" Then
                If Value = "1" Then
                    CustCd = g10.Text("cust_cd")
                    'Poqty = g10.ToDec("req_qty") - g10.ToDec("po_tot")
                    Poqty = g10.ToDec("mod_qty")

                    If Poqty > 0 Then
                        g10.Text("req_qty") = Poqty

                    Else
                        g10.Text("chk") = "0"
                        g10.Text("req_qty") = "0"
                    End If
                Else
                    g10.Text("req_qty") = "0"
                    g10.Text("chk") = "0"
                End If
            End If

            'If ColumnName = "qty" Then
            '    Poqty = g10.ToDec("req_qty")

            '    If ToDec(Value) > Poqty Then
            '        g10.Text("qty") = Poqty
            '        ' g10.Text("chk") = "0"
            '        MsgBox("미발주 수량만큼 구매의뢰 가능 합니다")
            '        Exit Sub
            '    End If
            '    If ToDec(Value) <= 0 Then
            '        g10.Text("chk") = "0"
            '    End If
            'End If

        Catch ex As Exception
        Finally
            m_StopEvent = False
        End Try
    End Sub

    Private Sub btn_reqpo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reqpo.Click


        '선택 건수 확인
        If g10.CheckedRows("chk") = 0 Then
            Exit Sub
        End If



        Dim menuName As String = "MMA100"
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)

        ctr.Open4(g10.DataSet)


        'Dim iRow As Integer = 0
        'Dim menuName As String = "MMB100"
        'Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)

        'For iRow = 0 To g10.RowCount - 1
        '    If g10.Text("chk", iRow) = "1" Then
        '        ctr.Open2(g10.Text("req_no", iRow), g10.Text("req_sq", iRow), g10.Text("itm_id", iRow), g10.Text("itm_cd", iRow), g10.Text("itm_nm", iRow), g10.Text("spec", iRow), g10.Text("qty", iRow), _
        '                  g10.Text("um_bc", iRow), g10.Text("std_um_bc", iRow), g10.Text("cust_cd", iRow), g10.Text("cust_nm", iRow))
        '    End If
        'Next


    End Sub



End Class
