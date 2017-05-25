Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class FAC770

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Init_Form()
    End Sub

    Public Sub Init_Form()
        New_Form()
    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.New
                New_Form()

            Case MenuType.Open
                If CheckRequired(bs_cd, otax_year, omon_bc) = False Then Exit Sub
                Open_Form()

            Case MenuType.Save
                Save_Form()

            Case MenuType.Delete
                If Me.Delete("fac770_f1") = ExcuteResult.Succeeded Then
                    Me.WorkSets("fac770_f1").AddNew()
                End If

            Case MenuType.Print
                Print()

            Case Else

                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    '######################################################################################
    '##            Open                                                                  ##
    '######################################################################################

    Private Sub New_Form()
        Try
            bs_cd.Text = ""
            omon_bc.Text = ""

            Open_Form()
            bs_cd.Text = Parameter.Login.BsCd
            otax_year.Text = Now.ToShortDateString

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Sub Open_Form()
        Try
            Dim CoCd As String = co_cd.Text
            Dim BsCd As String = bs_cd.Text
            Me.Open()

            If Me.WorkSets("fac770_f10").RowCount <= 0 Then
                co_cd.ReadOnly = False
                bs_cd.ReadOnly = False
                otax_year.ReadOnly = False
                omon_bc.ReadOnly = False

                If omon_bc.Text <> "" And tax_dtf.Text = "" Then
                    GetDay()
                End If
            Else
                co_cd.ReadOnly = True
                bs_cd.ReadOnly = True
                otax_year.ReadOnly = True
                omon_bc.ReadOnly = True
            End If

            If CoCd <> co_cd.Text Then
                co_cd.Text = CoCd
            End If

            If BsCd <> bs_cd.Text Then
                bs_cd.Text = BsCd
            End If

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    '######################################################################################
    '##            Save                                                                  ##
    '######################################################################################

    Private Function Save_Form() As Boolean

        Try

            Me.Save()

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Function


    '######################################################################################
    '##            사용자정의                                                            ##
    '######################################################################################

    '######################################################################################
    '##             Procedure                                                            ##
    '######################################################################################

    Private Sub omon_bc_TextChanging(ByVal sender As Object, ByVal e As System.EventArgs) Handles omon_bc.TextChanged
        GetDay()
    End Sub

    Private Sub GetDay()
        If omon_bc.Text = "" Then
            tax_dtf.Text = ""
            tax_dtt.Text = ""
            Exit Sub
        End If
        Try
            Dim P As New OpenParameters
            P.Add("@mon_bc", omon_bc.Text)
            'Command 생성
            Dim dSet As DataSet = Me.OpenDataSet("fac600_sql", P)
            Dim mng_val As String = Nothing

            For Each dRow As DataRow In dSet.Tables(0).Rows
                If Len(ToStr(dRow("mng_val"))) = 1 Then
                    mng_val = "0" & ToStr(dRow("mng_val"))
                ElseIf Len(ToStr(dRow("mng_val"))) = 2 Then
                    mng_val = ToStr(dRow("mng_val"))
                End If

                If ToStr(dRow("mng_sq")) = "1" Then
                    tax_dtf.Text = otax_year.Text & "-" & mng_val & ToStr("-01")
                ElseIf ToStr(dRow("mng_sq")) = "2" Then
                    Dim sdate As Date = otax_year.Text & "-" & mng_val & ToStr("-01")
                    tax_dtt.Text = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 1, sdate))
                    Exit For
                End If
            Next

            '기존입력중인 자료 재반영
            If g10.RowCount > 0 Then
                If tax_dtf.Text <> "" And tax_dtt.Text <> "" Then
                    Dim Dy As Double = GetDays()
                    For Row As Integer = 0 To g10.RowCount - 1
                        If g10.IsDataRow(Row) Then
                            g10.Text("int", Row) = Rounding(Dy * g10.ToDec("deposit", Row) * int_rt.ToDec * 0.01, 0) '보증금이자
                        End If
                    Next
                Else
                    For Row As Integer = 0 To g10.RowCount - 1
                        If g10.IsDataRow(Row) Then
                            g10.Text("int", Row) = 0 '보증금이자
                        End If
                    Next
                End If

                g10.RowIndex = 0
            End If
        Catch ex As Exception
            MessageError(ex)
        End Try

    End Sub

    Private Function GetDays() As Double
        If tax_dtf.Text = "" Or tax_dtt.Text = "" Then Return 0
        Dim FrDt As Date = tax_dtf.Text, ToDt As Date = tax_dtt.Text
        Dim Rtn As Double = (DateDiff(DateInterval.Day, FrDt, ToDt) + 1) / 365.0
        Return Rtn
    End Function

    Private Sub Print()
        If Me.WorkSets("fac770_f10").RowCount <= 0 Then Exit Sub
        Dim p As OpenParameters = New OpenParameters
        p.Add("@bs_cd", bs_cd.Text)
        p.Add("@tax_year", otax_year.Text)
        p.Add("@mon_bc", omon_bc.Text)
        System7.ReportView.LoadView(Me.Name, "", "fac770_Print", p) '부동산임대공급가액 명세서
    End Sub

    Private Sub g10_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        With g10
            If ColumnName = "deposit" Then '보증금
                .Text("int") = Rounding((GetDays() * .ToDec("deposit") * int_rt.ToDec * 0.01), 0) '보증금이자
            End If

            If ColumnName = "in_dt" Or ColumnName = "out_dt" Or ColumnName = "mon_amt" Then '입주일, 퇴거일, 월 임대료
                Dim MonTot As Double = 0
                If .Text("in_dt") <> "" And .Text("out_dt") <> "" And .ToDec("mon_amt") <> 0 Then
                    Dim FrDt As Date = .Text("in_dt"), ToDt As Date = .Text("out_dt")
                    MonTot = (DateDiff(DateInterval.Month, FrDt, ToDt) + 1) * .ToDec("mon_amt")
                End If
                .Text("mon_tot") = MonTot '월임대료계

            End If
        End With
    End Sub

    Private Sub int_rt_TextChanged(sender As Object, oldValue As String) Handles int_rt.TextChanged
        '기존입력중인 자료 재반영
        If g10.RowCount > 0 And tax_dtf.Text <> "" And tax_dtt.Text <> "" Then
            Dim Dy As Double = GetDays()
            For Row As Integer = 0 To g10.RowCount - 1
                If g10.IsDataRow(Row) Then
                    g10.Text("int", Row) = Rounding(Dy * g10.ToDec("deposit", Row) * int_rt.ToDec * 0.01, 0) '보증금이자
                End If
            Next
            g10.RowIndex = 0
        End If
    End Sub
End Class
