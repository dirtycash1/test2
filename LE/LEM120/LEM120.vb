Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class LEM120


    Private Sub LEM120_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '품목이동 번호 채번
        mov_no.CodeNo = "LEM100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        mov_no.CodeDateField = out_dt

        Me.New_Form()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                '사용하려면 재정의 가능하다
            Case MenuType.Save
                If MyBase.Save() Then
                    MyBase.Open()
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

    Public Sub New_Form()
        mov_no.Text = ""
        Me.Open()

        g10.AddNewRow()
    End Sub

    Public Sub Open2(ByVal movNo As String)
        mov_no.Text = movNo
        Me.Open()
    End Sub

    Public Sub Open3(ByVal dSet As DataSet, ByVal dSet2 As DataSet)
        Me.New_Form()
        g10.DeleteBlankRow()

        Dim i As Integer = 0
        For Each dRow As DataRow In dSet.Tables(0).Rows
            If ToStr(dRow("chk")) Then

                If i = 0 Then
                    cust_cd.Text = ToStr(dRow("cust_cd"))
                    out_fac.Text = ToStr(dRow("so_fac"))
                    ent_bc.Text = "LE920300"    '출하이동
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
                g10.Text("mov_qty", i) = ToStr(dRow("qty"))
                g10.Text("out_up", i) = ToStr(dRow("out_up"))
                g10.Text("out_amt", i) = g10.ToDec("out_up", i) * g10.ToDec("mov_qty", i)


                ''g10.Text("itm_id", i) = ToStr(dRow("itm_id"))
                'g10.Text("itm_cd", i) = ToStr(dRow("itm_cd"))
                ''g10.Text("itm_nm", i) = ToStr(dRow("itm_nm"))
                ''g10.Text("itm_bc", i) = ToStr(dRow("itm_bc"))
                ''g10.Text("spec", i) = ToStr(dRow("spec"))
                ''g10.Text("model_cd", i) = ToStr(dRow("model_cd"))
                ''g10.Text("spec1", i) = ToStr(dRow("spec1"))
                ''g10.Text("std_um", i) = ToStr(dRow("std_um"))
                'g10.Text("um_bc", i) = ToStr(dRow("um_bc"))
                ''g10.Text("cury_bc", i) = ToStr(dRow("cury_bc"))
                'g10.Text("mov_qty", i) = ToStr(dRow("qty"))
                ''g10.Text("out_up", i) = ToStr(dRow("so_sq"))
                ''g10.Text("out_amt", i) = Outtot * Soup
                'g10.Text("so_no", i) = ToStr(dRow("so_no"))
                'g10.Text("so_sq", i) = ToStr(dRow("so_sq"))

                i += 1
            End If
        Next

        For Each dRow As DataRow In dSet2.Tables(0).Rows
            If ToStr(dRow("chk")) Then

                If i = 0 Then
                    cust_cd.Text = ToStr(dRow("cust_cd"))
                    out_fac.Text = ToStr(dRow("so_fac"))
                    ent_bc.Text = "LE920300"    '출하이동
                End If

                g10.AddNewRow()
                For Each Col As DataColumn In dSet2.Tables(0).Columns
                    For k = 0 To g10.ColumnCount - 1
                        If g10.FieldName(k) = "stat_bc" Then
                        Else
                            If Col.ColumnName = g10.FieldName(k) Then
                                g10.Text(g10.FieldName(k), g10.RowIndex) = ToStr(dRow(Col.ColumnName))
                            End If
                        End If
                    Next
                Next
                g10.Text("mov_qty", i) = ToStr(dRow("qty"))
                g10.Text("out_up", i) = ToStr(dRow("out_up"))
                g10.Text("out_amt", i) = g10.ToDec("out_up", i) * g10.ToDec("mov_qty", i)
                i += 1
            End If


        Next
    End Sub

    Private Sub btn_prt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_prt.Click
        Dim Type, Gubn As String

        Type = print_ty.Text

        If Type = "" Then  '양식이 선택되지 않으면 표준으로 출력하기
            Type = "LEB160"
            Gubn = "0"
        Else
            Gubn = Mid(Type, Len(Type), 1)
        End If

        If mov_no.Text = "" Then
            MessageInfo("출고 번호가 누락 되었습니다.")
            Exit Sub
        End If
        Dim p As OpenParameters = New OpenParameters

        p.Add("@out_no", mov_no.Text)
        p.Add("@gubn", Gubn)
        p.Add("@is_cost", chk_up.Text)
        System7.ReportView.LoadView(Type, "", "LEM120_cust_Print", p)

        ' If Gubn = "6" Then
        'Dim p1 As OpenParameters = New OpenParameters

        'p1.Add("@out_no", out_no.Text)

        'System7.ReportView.LoadView(Type, "", "LEB160_cust_Print", p, , , , Type, "LEB160_cust_Print1", p1)
        'Exit Sub
        'End If
    End Sub

    Private Sub out_wh_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles out_wh.TextChanged

        With g10
            If .RowCount >= 0 Then
                Dim x As Integer
                For x = 0 To .RowCount - 1
                    Dim p As New OpenParameters
                    p.Add("@out_fac", out_fac.Text)
                    p.Add("@out_wh", out_wh.Text)
                    p.Add("@itm_id", .Text("itm_id", x))
                    Dim Dset As DataSet = OpenDataSet("lem120_getqty", p)
                    If Not IsEmpty(Dset) Then
                        .Text("stock_qty", x) = DataValue(Dset, 0)
                        'Dset = Nothing

                    End If
                Next
            End If
        End With

    End Sub


End Class
