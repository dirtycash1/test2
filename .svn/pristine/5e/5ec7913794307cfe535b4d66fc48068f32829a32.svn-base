Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class SEF100

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        '수출 File번호 채번
        file_no.CodeNo = "SEF100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        file_no.CodeDateField = open_dt

        Me.New_Form()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                Me.Open_Form()

            Case MenuType.Save

                Me.Save_Form()

            Case MenuType.New

                Me.New_Form()

            Case MenuType.Delete

                If Me.Delete("sef100_f10") = ExcuteResult.Succeeded Then

                    Me.Open()
                    'Me.New_Form()

                End If

            Case MenuType.Print
                ' Me.Print()
            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Private Sub Open_Form()
        Dim fileNo As String = file_no.Text
        Me.Open()
        g10.Find("file_no=" + fileNo)
    End Sub

    Private Sub New_Form()

        file_no.Text = ""
        Me.Open("sef100_f10")
        Me.Open("sef100_g20")

    End Sub

    Private Sub Save_Form()

        work_ty.Text = "none"

        Me.CompAmt()

        If Me.Save() Then
            Open_Form()
        End If
    End Sub



    '환율적용일이 바뀌면 환율을 자동으로 끌어온다
    '환율 구하는 데이타셋
    Private Sub GetExchRt()

        Dim p As New OpenParameters
        Dim Rt As String

        p.Add("@std_dt", open_dt.Text)
        p.Add("@cury_bc", cury_bc.Text)

        Dim dSet As DataSet = OpenDataSet("sef100_exchrt", p)

        If Not IsEmpty(dSet) Then
            Rt = DataValue(dSet, "ttm_rt")
        Else
            Rt = "1"
        End If

        ex_rt.Text = Rt

    End Sub

    Private Sub cury_bc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cury_bc.TextChanged, bank_cd.TextChanged
        GetExchRt()

    End Sub

    Private Sub open_dt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles open_dt.TextChanged
        GetExchRt()

    End Sub

    'Private Sub g10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.Click

    '    Me.Open("sef100_f10")
    '    Me.Open("sef100_g20")
    'End Sub


    'Private Sub g20_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g20.CellValueChanging

    '    If ColumnName = "qty" Or ColumnName = "up" Then
    '        ' 기준활율 매출
    '        If ToDec(Value) > 0 Then
    '            'g20.UpdateRow()
    '            Select Case ColumnName
    '                Case "qty"
    '                    g20.Text("famt") = Value * g20.ToDec("up")
    '                    g20.Text("amt") = Value * g20.ToDec("up") * ToDec(ex_rt.Text)
    '                Case "up"
    '                    g20.Text("famt") = Value * g20.ToDec("qty")
    '                    g20.Text("amt") = Value * g20.ToDec("qty") * ToDec(ex_rt.Text)

    '            End Select

    '            SumAmt()

    '        End If

    '    End If

    'End Sub

    Private Sub g20_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g20.CellValueChanged
        With g20
            If ColumnName = "qty" Or ColumnName = "up" Then
                .Text("famt") = .ToDec("qty") * .ToDec("up")
                .Text("amt") = .ToDec("famt") * ex_rt.ToDec
            End If
        End With

        Me.CompAmt()
    End Sub

    Private Sub ex_rt_TextChanged(ByVal sender As Object, ByVal oldValue As String) Handles ex_rt.TextChanged
        'amt.Text = famt.ToDec * ex_rt.ToDec

        With g20
            For i As Integer = 0 To .RowCount - 1
                If .IsDataRow(i) Then
                    .RowIndex = i
                    .Text("amt") = .ToDec("famt") * ex_rt.ToDec
                End If
            Next
        End With

        Me.CompAmt()
    End Sub

    Private Sub CompAmt()
        Dim sum_amt As Double, sum_famt As Double

        With g20
            .UpdateRow()
            For i As Integer = 0 To .RowCount - 1
                If .IsDataRow(i) Then
                    sum_amt += .ToDec("amt", i)
                    sum_famt += .ToDec("famt", i)
                End If
            Next
        End With

        amt.Text = sum_amt
        famt.Text = sum_famt
    End Sub

    Private Sub btn_out_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_out.Click

        If MessageYesNo("출고처리 하시겠습니까 ?") = MsgBoxResult.Yes Then

            Dim p As OpenParameters = New OpenParameters
            If Not CheckRequired(file_no, loc_dt) Then
                Exit Sub
            End If

            If g20.CheckedRows("chk") = 0 Then
                MessageInfo("선택된 행이 없습니다")
                Exit Sub
            End If

            With g20
                For i As Integer = 0 To .RowCount - 1
                    If .ToBool("chk", i) And .Text("out_no", i) <> "" Then
                        MessageInfo("이미 출고처리된 행이 있습니다.")
                        Exit Sub
                    End If
                Next
            End With

            work_ty.Text = "save"

            If Me.Save Then
                Me.Open_Form()
            End If

            'p.Add("@file_no", file_no.Text)
            'p.Add("@fac_cd", fac_cd.Text)
            'p.Add("@wh_cd", wh_cd.Text)

            'Dim dSet As DataSet = OpenDataSet("sef100_out", p)

            'MessageInfo("출고 및 매출처리 완료 하였습니다")

            'Me.Open_Form()
        End If

    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        If MessageYesNo("출고처리 하시겠습니까 ?") = MsgBoxResult.Yes Then
            Dim p As OpenParameters = New OpenParameters
            If Not CheckRequired(file_no) Then
                Exit Sub
            End If

            If g20.CheckedRows("chk") = 0 Then
                MessageInfo("선택된 행이 없습니다")
                Exit Sub
            End If

            With g20
                For i As Integer = 0 To .RowCount - 1
                    If .ToBool("chk", i) And .Text("out_no", i) = "" Then
                        MessageInfo("출고처리된 행만 선택가능합니다.")
                        Exit Sub
                    End If
                Next
            End With

            work_ty.Text = "delete"

            If Me.Save Then
                Me.Open_Form()
            End If
        End If
    End Sub
End Class
