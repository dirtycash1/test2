Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class LEB600_KRS

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.New
                New_Form()

            Case MenuType.Open
                If CheckRequired(o_date, o_fac_cd) = True Then
                    Me.Open()
                End If

            Case MenuType.Save
                Me._Save()

            Case Else

                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    Private Sub New_Form()
        Try
            Dim FacCd As String = o_fac_cd.Text
            o_fac_cd.Text = ""
            Me.Open()
            o_fac_cd.Text = FacCd
            g20.DataSource = Nothing

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    '######################################################################################
    '##            Open                                                                  ##
    '######################################################################################

    Private Sub _Save()
        Me.Save("leb600_krs_g20")
        Dim str_wo_no As String = String.Empty

        For i = 0 To g10.RowCount - 1
            If g10.Text("chk", i) = 1 Then
                str_wo_no += g10.Text("wo_no", i) + "~"
            End If
        Next

        Dim params As OpenParameters = New OpenParameters
        params.Add("@str", str_wo_no.Substring(0, str_wo_no.Length - 1))

        Me.OpenDataSet("leb600_krs_save", params)
    End Sub

    Private Sub Open_Form()
        Try

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    '######################################################################################
    '##            Save                                                                  ##
    '######################################################################################

    Private Function Save_Form() As Boolean

        '        Dim ID As String = asset_id.Text
        Try

            '            If MyBase.Save() Then
            '                If ID = "" Then
            '                    f_asset_id.Text = asset_id.Text
            '                    Me.Open()
            '                Else
            '                    Form_Open()
            '                End If
            '            Else
            '                If ID = "" Then asset_id.Text = ""
            '            End If

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

    Private Sub g10_CellValueChanged(sender As System.Object, ColumnName As System.String, RowIndex As System.Int32, ByRef Value As System.Object) Handles g10.CellValueChanged
        If ColumnName = "chk" Then
            If g10.Text("chk", g10.RowIndex) = "0" Then
                g10.Text("iss_qty", g10.RowIndex) = 0
            End If
            If g10.Text("chk", g10.RowIndex) = "1" Then
                g10.Text("iss_qty", g10.RowIndex) = Val(g10.Text("ord_qty", g10.RowIndex))
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click

        If g10.CheckedRows("chk") = 0 Then
            Exit Sub
        End If

        Dim dTbl As DataTable, dRow As DataRow
        Dim dset As DataSet = Me.OpenDataSet("leb600_krs_btn")

        dTbl = dset.Tables(0)
        With g10
            .UpdateRow()

            dTbl.BeginLoadData()
            For i As Integer = 0 To .RowCount - 1
                If .ToBool("chk", i) Then
                    dRow = dTbl.NewRow()
                    dRow("itm_id") = .Text("itm_id", i)
                    dRow("wo_dt") = o_date.Text
                    dRow("wo_qty") = .Text("ord_qty", i)
                    dRow("mc_cd") = .Text("mc_cd", i)
                    dTbl.Rows.Add(dRow)
                End If
            Next
            dTbl.EndLoadData()
        End With

        If Me.Save("leb600_krs_btn") Then

            g20.Open()
            For Row As Integer = 0 To g20.RowCount - 1
                If g20.IsDataRow(Row) Then
                    g20.Text(1, Row) = g20.Text(1, Row)
                End If
            Next
            If g20.RowCount > 0 Then g20.RowIndex = 0
        End If

    End Sub
End Class
