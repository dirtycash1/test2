Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class SDD130
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                '사용하려면 재정의 가능하다
            Case MenuType.Save
                'If MyBase.Save() Then

                'MyBase.Open()
                ' End If

            Case MenuType.Delete
                'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

            Case MenuType.New
                'Me.New_Form()

            Case MenuType.Print
                Call print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub
    Private Sub print()


        Dim p As OpenParameters = New OpenParameters

        p.Add("@fr_dt", fr_dt.Text)
        p.Add("@to_dt", to_dt.Text)
        p.Add("@cust_cd2", cust_cd2.Text)
        p.Add("@in_wh", in_wh.Text)
        p.Add("@itm_cd", itm_cd.Text)
        p.Add("@itm_nm", itm_nm.Text)
        p.Add("@model_cd", model_cd.Text)
        p.Add("@spec1", spec1.Text)

        System7.ReportView.LoadView("SDD130", "", "SDD130_Print", p)


    End Sub
    Private Sub g10_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging

        If ColumnName = "chk" Then

        End If

        Dim cnt As Integer = 0
        Dim custcd As String
        If ColumnName = "chk" Then
            If ToBool(Value) Then
                custcd = g10.Text("cust_cd2")

                '  동일 거래처  체크
                For iRow = 0 To g10.RowCount - 1
                    If custcd <> g10.Text("cust_cd2", iRow) And g10.ToBool("chk", iRow) Then
                        cnt += 1
                    End If
                Next
                If cnt > 0 Then
                    MessageInfo("동일한 매출처만 처리 가능 합니다")
                    g10.UpdateRow()
                    g10.Text("sal_qty") = ""
                    g10.Text("chk", RowIndex) = ""
                    Exit Sub
                End If
            End If

            If Value = "1" Then
                g10.Text("sal_qty") = g10.Text("end_qty")
            Else
                g10.Text("sal_qty") = ""
            End If
        End If

    End Sub


    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        If ColumnName = "sal_qty" Then
            If ToDec(Value) > 0 Then
                If ToDec(Value) > g10.ToDec("end_qty") Then
                    g10.Text("chk") = "0"
                    g10.Text("sal_qty") = "0"
                    MsgBox("미매출량보다 매출수량이 클 수 없습니다")
                    Exit Sub
                End If
            End If
        End If

    End Sub

    Private Sub btn_jump_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_jump.Click

        '선택 건수 확인
        If g10.CheckedRows("chk") = 0 Then
            MessageInfo("선택된 행이 없습니다.")
            Exit Sub
        End If

        Dim menuName As String = "SDD100"
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)

        ctr.Open5(g10.DataSet)

    End Sub



End Class
