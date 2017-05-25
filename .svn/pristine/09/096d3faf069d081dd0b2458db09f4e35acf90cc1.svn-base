Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Functions



Public Class MMB103

    Private Sub MMB103_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Open_Form()
    End Sub
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
               Open_Form()
                'MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                '사용하려면 재정의 가능하다
            Case MenuType.Save
                'If MyBase.Save() Then

                'MyBase.Open()
                'End If

            Case MenuType.Delete
                'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

            Case MenuType.New

            Case MenuType.Print
                ' Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub


    Private Sub Open_Form()
        Init_Title()

        Disp_Data1()
    End Sub
    Private Sub Init_Title()

        '1. 컬럼배열을 만든다
        Dim frDt As Date = fr_dt.Text
        Dim toDt As Date = to_dt.Text

        Dim cnt As Integer = DateDiff(DateInterval.Day, frDt, toDt)
        Dim arr(1, 0) As String, colNm As String, colFNm As String
        For i = 0 To cnt
            ReDim Preserve arr(1, i)     'Array를 증가시킨다


            colNm = Format(DateAdd(DateInterval.Day, i, frDt), "MM-dd")
            colFNm = Format(DateAdd(DateInterval.Day, i, frDt), "MM-dd")

            arr(0, i) = colFNm            'FieldName

            arr(1, i) = colNm             'Title
        Next

        '2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
        ' Ex) g10.InsertColumn("A", arr, "B")
        '     "A" 컬럼이후에 삽입된다
        '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
        '     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다

        g10.InsertArrayColumns("sum", arr, "qty")

    End Sub
    Private Sub Disp_Data1()
        Try
            'If ErrorChk Then
            'Exit Sub
            'End If

            Dim dSet As DataSet = Me.OpenDataSet("mmb103_g10")   'dma130 WorkSet이 등록되어있어야 한다

            If IsEmpty(dSet) Then
                Exit Sub
            End If

            Dim dRows As DataRowCollection, dRow As DataRow, Row As Integer = 0
            Dim sPartInCd As String = Nothing, dateCol As String = Nothing, sDataTy As String = Nothing
            Dim i As Integer = 0, j As Integer = 0, Sum As Double = 0

            Dim ty1 As String = "발주"
            Dim ty2 As String = "입고"



            g10.ColumnVisible("cust_nm") = chk_cust.Checked

            i = -1
            With g10
                .AllowAddRows = True
                ' .Editable = True
                '.UpdateRow()
                .AllowSort = False

                For Each dRow In dSet.Tables(0).Rows
                    If sPartInCd <> ToStr(dRow("itm_cd")) Then
                        '.UpdateRow()
                        g10.AddNewRow()
                        Sum = 0
                        i += 1
    
                        sPartInCd = ToStr(dRow("itm_cd"))
                        sDataTy = dRow("data_ty")

                        If chk_cust.Checked = True Then
                            '.Text("cust_cd", i) = dRow("cust_cd")
                            .Text("cust_nm", i) = ToStr(dRow("cust_nm"))

                        End If



                        .Text("itm_id", i) = ToStr(dRow("itm_id"))

                        .Text("itm_cd", i) = ToStr(dRow("itm_cd"))
                        .Text("itm_nm", i) = ToStr(dRow("itm_nm"))
                        .Text("spec", i) = ToStr(dRow("spec"))
                        .Text("um_bc", i) = ToStr(dRow("um_bc"))
                        .Text("itm_bc", i) = ToStr(dRow("itm_bc"))
                        .Text("grp1_cd", i) = ToStr(dRow("grp1_cd"))
                        .Text("grp2_cd", i) = ToStr(dRow("grp2_cd"))
                        .Text("grp3_cd", i) = ToStr(dRow("grp3_cd"))
                        ' .UpdateRow()

                        If dRow("data_ty") = "발주" Then

                            .Text("stock_qty", i) = ToDec(dRow("stock_qty"))
                            .Text("data_ty", i) = ty1 '"발주"

                            If Int(i / 2) Mod 2 = 0 Then
                                .Text("tog", i) = "Y"
                            Else
                                .Text("tog", i) = "N"
                            End If

                            dateCol = Format(dRow("std_dt"), "MM-dd")
                            .Text(dateCol, i) = ToDec(dRow("qty"))

                            Sum += ToDec(dRow("qty"))
                            .Text("sum", i) = Sum

                            i += 1
                            Row = i
                            g10.AddNewRow()
                            .Text("data_ty", i) = ty2 '"입고"

                            If Int(i / 2) Mod 2 = 0 Then
                                .Text("tog", i) = "Y"
                            Else
                                .Text("tog", i) = "N"
                            End If
                        Else
                            g10.AddNewRow()
                            .Text("data_ty", i) = ty1 '"발주"

                            If Int(i / 2) Mod 2 = 0 Then
                                .Text("tog", i) = "Y"
                            Else
                                .Text("tog", i) = "N"
                            End If

                            i += 1
                            Row = i

                            .Text("stock_qty", i) = ToDec(dRow("stock_qty"))
                            .Text("data_ty", i) = ty2 '"입고"

                            If Int(.RowIndex / 2) Mod 2 = 0 Then
                                .Text("tog", i) = "Y"
                            Else
                                .Text("tog", i) = "N"
                            End If

                            dateCol = Format(dRow("std_dt"), "MM-dd")
                            .Text(dateCol, i) = ToDec(dRow("qty"))

                            Sum += ToDec(dRow("qty"))
                            .Text("sum", i) = Sum

                        End If
                    Else
                        j = i
                        If dRow("data_ty") = "발주" Then
                            j = i - 1
                            Row = j
                        End If

                        If sDataTy <> dRow("data_ty") Then
                            Sum = 0
                            sDataTy = dRow("data_ty")
                        End If

                        .Text("stock_qty", j) = ToDec(dRow("stock_qty"))

                        dateCol = Format(dRow("std_dt"), "MM-dd")
                        .Text(dateCol, j) = ToDec(dRow("qty"))

                        Sum += ToDec(dRow("qty"))
                        .Text("sum", j) = Sum
                    End If

                Next
                .UpdateRow()
                .DataChanged = False
                .AllowAddRows = False

            End With
        Catch ex As Exception
            MessageInfo(ex, "Open_Form")
        End Try
    End Sub
    
End Class
