Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class MME030
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Open

                Me.Open_Form()

                'Case MenuType.Save

                'Me.save_Form()

            Case MenuType.New
                plan_dtf.Text = Now()
                plan_dtt.Text = Now()

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Public Sub Open_Form()

        Me.Init_Title()

        Dim dSet As DataSet = Me.OpenDataSet("mme030_g10")
        Me.Disp_Data(dSet)


    End Sub

#Region " 1. g10_생성 "

    'Case 1. DataSet을 이용한 Title 배열
    Private Sub Init_Title()


        '1. 컬럼배열을 만든다
        Dim plandtf As Date = plan_dtf.Text
        Dim plandtt As Date = plan_dtt.Text

        Dim cnt As Integer = DateDiff(DateInterval.Day, plandtf, plandtt)
        Dim arr(1, 0) As String, colNm As String, fldNm As String
        For i = 0 To cnt
            ReDim Preserve arr(1, i)     'Array를 증가시킨다

            fldNm = Format(DateAdd(DateInterval.Day, i, plandtf), "yyyy-MM-dd")
            colNm = Format(DateAdd(DateInterval.Day, i, plandtf), "MM-dd (ddd)")
            arr(0, i) = fldNm            'FieldName
            arr(1, i) = colNm            'Title
        Next

        g10.InsertArrayColumns("um_bc", arr, "qty")

    End Sub
    Private Sub Disp_Data(ByVal dSet As DataSet)

        If IsEmpty(dSet) Then
            Exit Sub
        End If

        Parameter.MainFrame.ProgBar.Visible = True
        Parameter.MainFrame.ProgBar.Minimum = 1
        Parameter.MainFrame.ProgBar.Maximum = dSet.Tables(0).Rows.Count
        Parameter.MainFrame.ProgBar.Value = 1
        Parameter.MainFrame.ProgBar.Step = 1

        Try
            Windows.Forms.Cursor.Current = Cursors.WaitCursor

            Dim dRow As DataRow, colNm As String, s1 As String = ""
            Dim iRow As Integer, iCnt As Integer

            With g10

                '추가와 쓰기가 가능해야 행이 추가 된다
                g10.AllowAddRows = True
                g10.Editable = True

                iRow = -1

                For Each dRow In dSet.Tables(0).Rows
                    If s1 <> dRow("itm_cd") Then

                        g10.AddNewRow()

                        iRow += 1
                        '.Row = iRow

                        .Text("itm_id", iRow) = ToStr(dRow("itm_id"))
                        .Text("itm_cd", iRow) = ToStr(dRow("itm_cd"))
                        .Text("itm_nm", iRow) = ToStr(dRow("itm_nm"))
                        .Text("cust_cd", iRow) = ToStr(dRow("cust_cd"))
                        .Text("cust_nm", iRow) = ToStr(dRow("cust_nm"))
                        .Text("um_bc", iRow) = ToStr(dRow("um_bc"))
                        .Text("bc", iRow) = ToStr(dRow("bc"))
                        .Text("bc_nm", iRow) = ToStr(dRow("bc_nm"))
                        .Text("rmk", iRow) = ToStr(dRow("rmk"))

                        s1 = ToStr(dRow("itm_cd"))

                    End If

                    colNm = ToStr(dRow("plan_dt"))


                    If colNm <> "" Then
                        .Text(colNm, iRow) = ToStr(dRow("qty"))
                    End If

                    iCnt += 1

                    Parameter.MainFrame.ProgBar.Value = iCnt

                Next

                .UpdateRow()

                '이것을 쓰야 수정없이 종료해도 저장질의를 하지 않는다
                ' 반드시 .UpdateRow() 를 먼저 쓰야 한다 그렇지 않으면 Row가 사라진다
                .DataChanged = False
            End With

        Catch ex As Exception
            MessageError(ex, , "Display()")

        Finally
            Parameter.MainFrame.ProgBar.Visible = False

            Me.Cursor = Cursors.Default
        End Try


    End Sub

#End Region


End Class
