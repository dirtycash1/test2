Imports Frame7
Imports Base7
Imports Base7.Shared
Public Class LEB150


    Private Sub LEB150_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Me.Open()

        '  제품 출하 번호 채번
        'out_no.CodeNo = "LEB100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        'out_no.CodeDateField = out_dt

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Save
                Me._Jump()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select
    End Sub

    Private m_StopEvent As Boolean

    Private Sub g10_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging

        If m_StopEvent Then
            Exit Sub
        End If

        m_StopEvent = True

        'Dim outqty As Integer
        Dim Cust_Cnt As Integer
        Dim Custcd As String

        If ColumnName = "chk" Then
            If Value = "1" Then
                Custcd = g10.Text("cust_cd")

                '  동일 거래처  체크
                For iRow = 0 To g10.RowCount - 1
                    If Custcd <> g10.Text("cust_cd", iRow) And g10.ToBool("chk", iRow) Then
                        Cust_Cnt = ToDec(Cust_Cnt) + 1
                    End If
                Next

                If Cust_Cnt > 0 Then
                    MessageInfo("동일한 거래처만 출하처리 가능 합니다")
                    g10.UpdateRow()
                    g10.Text("qty") = ""
                    g10.Text("chk", RowIndex) = ""
                    Exit Sub
                End If

                'If g10.Text("stat_bc") >= "SD201500" Then
                '    MessageInfo("완결된 품목을 선택하였습니다")
                '    g10.UpdateRow()
                '    g10.Text("qty") = ""
                '    g10.Text("chk", RowIndex) = ""
                '    Exit Sub
                'End If


                'If outqty >= Stock_qty Then
                '    If Stock_qty = 0 Then
                '        outqty = 0
                '    Else
                '        outqty = Stock_qty
                '    End If
                'End If

                'If outqty > 0 Then
                '    g10.Text("out_tot") = ToDec(outqty)

                'Else

                '    g10.Text("out_tot") = ""
                '    g10.Text("chk") = "0"
                'End If

                g10.Text("qty") = g10.Text("rem_qty")
            Else
                g10.Text("qty") = ""
            End If

        End If

        If ColumnName = "qty" Then

            g10.Text("chk") = IIf(Value = "", "0", "1")

        End If

        m_StopEvent = False


        'If ColumnName = "out_tot" Then
        '    If Value > "0" Then
        '        outqty = g10.ToDec("not_outqty")
        '        Stock_qty = g10.ToDec("stock_qty")

        '        If Value >= outqty Then
        '            g10.Text("out_tot") = outqty
        '            MsgBox("잔량보다 크게 출하 할수 없습니다")
        '            Exit Sub

        '        End If
        '        If Value >= Stock_qty Then
        '            'g10.Text("chk") = "0"
        '            g10.Text("out_tot") = outqty
        '            MsgBox("현재고 보다 크게 출하 할수 없습니다")
        '            Exit Sub
        '        End If

        '    End If
        'End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        Me._Jump()

    End Sub

    Private Sub _Jump()
        ''2. 데이타 검정
        'If Not CheckRequired(fac_cd, wh_cd, out_dt) Then
        '    Exit Sub
        'End If

        '선택 건수 확인
        If g10.CheckedRows("chk") = 0 Then
            Exit Sub
        End If



        Dim menuName As String = "LEB160"
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)

        ctr.Open3(g10.DataSet)

        ' If IsNothing(ctr) Then Exit Sub

        'For iRow = 0 To g10.RowCount - 1
        '    If g10.Text("chk", iRow) = "1" Then
        '        ctr.Open2(g10.Text("so_no", iRow), g10.Text("so_sq", iRow), g10.Text("itm_id", iRow), g10.Text("itm_cd", iRow), g10.Text("itm_nm", iRow), g10.Text("spec", iRow), g10.Text("out_tot", iRow), g10.Text("std_um", iRow), g10.Text("um_bc", iRow), _
        '                 g10.Text("cury_bc", iRow), g10.Text("so_up", iRow), g10.Text("cust_cd", iRow), g10.Text("cust_nm", iRow), fac_cd.Text, wh_cd.Text, out_dt.Text)
        '    End If
        'Next
    End Sub


    Private Sub SimpleButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click

        If g10.CheckedRows("chk") = 0 Then
            Exit Sub
        End If

        Dim menuName As String = "LEM120"
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)

        ctr.Open3(g10.DataSet)

    End Sub


End Class
