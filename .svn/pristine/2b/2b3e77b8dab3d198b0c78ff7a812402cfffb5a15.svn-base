Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class LEA115

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Init_Form()
    End Sub

    Public Sub Init_Form()
        '자재 입고 번호 채번
        in_no.CodeNo = "LEA100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        in_no.CodeDateField = in_dt
        in_dt.Text = Now.ToLongDateString
        Me.New_Form()
    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    '    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

    '        Select Case mty

    '            Case MenuType.New

    '            Case MenuType.Save

    '            Case MenuType.Delete

    '            Case Else

    '                MyBase.MenuButton_Click(mty)

    '        End Select

    '    End Sub

    '######################################################################################
    '##            Open                                                                  ##
    '######################################################################################

    Private Sub New_Form()
        Try
            in_no.Text = ""
            MyBase.Open()

            g10.AddNewRow()
        Catch ex As Exception
            MessageError(ex)
        End Try
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
    Private Sub btn_price_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_price.Click

        g10.UpdateRow()

        For Row As Integer = 0 To g10.RowCount - 1
            Me.Set_Price(Row)
        Next
    End Sub

    Private Sub Set_Price(ByVal GetRow As Integer)
        Try
            With g10
                Dim p As New OpenParameters
                p.Add("@itm_id", .Text("itm_id", GetRow))
                p.Add("@cust_cd", .Text("cust_cd", GetRow))
                p.Add("@cury_bc", .Text("cury_bc", GetRow))
                p.Add("@po_fac", fac_cd.Text)
                p.Add("@po_dt", in_dt.Text)
                Dim dSet As DataSet = OpenDataSet("mmb100_cost", p)

                If Not IsEmpty(dSet) Then
                    .RowIndex = GetRow
                    .Text("in_up") = DataValue(dSet, "up")
                End If
            End With

        Catch ex As Exception
            MessageError(ex)
        End Try

    End Sub

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        If ColumnName = "itm_cd" Or ColumnName = "cust_nm" Then
            Me.Set_Price(RowIndex)
        End If
    End Sub
End Class
