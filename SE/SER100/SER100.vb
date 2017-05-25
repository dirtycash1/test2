Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class SER100

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Init_Form()
    End Sub

    Public Sub Init_Form()
        'Me.Open()

        '입금번호 채번
        pay_no.CodeNo = "SER100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        pay_no.CodeDateField = pay_dt

        Me.New_Form()
    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open_Form()

            Case MenuType.Save
                Me.Save_Form()

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

    '######################################################################################
    '##            Open                                                                  ##
    '######################################################################################

    Private Sub New_Form()
        Try
            pay_no.Text = ""
            Me.Open_Form()
        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Sub Open_Form()
        Try
            Me.Open()

            g10.AddNewRow()
        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Public Sub Open2(ByVal PayNo As String)

        pay_no.Text = PayNo

        Me.Open_Form()

    End Sub

    '수출B/L현황 -> 
    Public Sub Open3(ByVal dSet As DataSet)

        Me.New_Form()
        g20.DeleteBlankRow()

        Try
            Dim i As Integer = 0, Row As Integer = 0
            For Each dRow As DataRow In dSet.Tables(0).Rows
                If ToBool(dRow("chk")) Then
                    If ToStr(dRow("pay_no")) <> "" Then
                        Open2(dRow("pay_no"))
                        Exit For
                    End If

                    If i = 0 Then
                        cust_cd.Text = ToStr(dRow("cust_cd"))
                    End If

                    g20.AllowAddRows = True
                    g20.AddNewRow()
                    Row = g20.RowIndex

                    For Each Col As DataColumn In dSet.Tables(0).Columns
                        For k = 0 To g20.ColumnCount - 1
                            If g20.FieldName(k) = "stat_bc" Then
                            Else
                                If Col.ColumnName = g20.FieldName(k) Then
                                    g20.Text(g20.FieldName(k), Row) = ToStr(dRow(Col.ColumnName))
                                End If
                            End If
                        Next
                    Next

                    g20.Text("sal_no", Row) = ToStr(dRow("sal_no"))
                    g20.Text("sal_sq", Row) = ToStr(dRow("sal_sq"))
                    g20.Text("bl_no", Row) = ToStr(dRow("bl_no"))
                    g20.Text("invo_no", Row) = ToStr(dRow("invo_no"))
                    g20.Text("sal_amt", Row) = ToStr(dRow("sal_amt"))
                    g20.Text("sal_famt", Row) = ToStr(dRow("sal_famt"))
                End If
            Next
        Catch ex As Exception
        Finally
            g20.AllowAddRows = False
        End Try

    End Sub

    '######################################################################################
    '##            Save                                                                  ##
    '######################################################################################

    Private Function Save_Form() As Boolean

        '        Dim ID As String = asset_id.Text
        Try

            Me.SumAmt()
            If MyBase.Save() Then
                MyBase.Open()
            End If

        Catch ex As Exception
            '            If ID = "" Then asset_id.Text = ""
            '저장에 실패했으면 코드 채번을 반드시 취소한다
            MessageError(ex)
        End Try
    End Function


    '######################################################################################
    '##            사용자정의                                                            ##
    '######################################################################################

    '######################################################################################
    '##             Procedure                                                            ##
    '######################################################################################
    Private Sub SumAmt()
        Dim sum_famt As Double, sum_amt As Double

        With g10
            .UpdateCurrentRow()
            For i As Integer = 0 To .RowCount - 1
                sum_famt = sum_famt + .ToDec("pay_famt", i)
                sum_amt = sum_amt + .ToDec("pay_amt", i)
            Next
        End With

        pay_amt.Text = sum_amt
        pay_famt.Text = sum_famt
    End Sub

    Private Sub SumAmt2()
        Dim sum_famt As Double, sum_amt As Double

        With g20
            .UpdateCurrentRow()
            For i As Integer = 0 To .RowCount - 1
                sum_famt = sum_famt + .ToDec("pay_famt", i)
                sum_amt = sum_amt + .ToDec("pay_amt", i)
            Next
        End With

        bl_amt.Text = sum_amt
        bl_famt.Text = sum_famt
    End Sub

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        With g10

            If ColumnName = "pay_famt" Or ColumnName = "pay_amt" Then
                Me.SumAmt()
            End If

        End With
    End Sub

    Private Sub g20_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g20.CellValueChanged
        With g20

            If ColumnName = "pay_famt" Or ColumnName = "pay_amt" Then
                Me.SumAmt2()
            End If

        End With
    End Sub

    Private Sub ex_rt_TextChanged(ByVal sender As Object, ByVal oldValue As String) Handles ex_rt.TextChanged
        'Dim rt As Decimal = ex_rt.ToDec
        'If rt = 0 Then
        '    rt = 1
        'End If
        '환율에 따른 공식 변경
        'g10.GridColumn("sal_amt").CompuText = "[sal_famt] * " + rt.ToString

        Me.CompAmt()
        Me.SumAmt()
    End Sub

    Private Sub CompAmt()
        Dim rt1 As Double = ex_rt.ToDec
        With g10
            For i As Integer = 0 To .RowCount - 1
                .Text("sal_amt", i) = .ToDec("sal_famt", i) * rt1
            Next
        End With
    End Sub

    Private Sub btn_work_Click(sender As System.Object, e As System.EventArgs) Handles btn_work.Click

    End Sub

    Private Sub btn_del_Click(sender As System.Object, e As System.EventArgs) Handles btn_del.Click

    End Sub
End Class
