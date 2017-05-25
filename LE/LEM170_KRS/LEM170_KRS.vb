Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class LEM170_KRS

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Init_Form()
    End Sub

    Public Sub Init_Form()
        '품목이동 번호 채번
        mov_no.CodeNo = "LEM100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        mov_no.CodeDateField = out_dt

        Me.New_Form()
    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.New
                New_Form()

            Case MenuType.Open
                Open_Form()

            Case MenuType.Save
                If Me.Save Then Open_Form()

                'Case MenuType.Delete

            Case MenuType.Print
                Me.Print()

            Case Else

                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    '######################################################################################
    '##            Open                                                                  ##
    '######################################################################################

    Private Sub New_Form()
        Try
            mov_no.Text = ""
            Open_Form()
        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Sub Open_Form()
        Try
            Me.Open()
            If mov_no.Text <> "" Then
                out_dt.Enabled = False
                cust_cd.Enabled = False
            Else
                out_dt.Enabled = True
                cust_cd.Enabled = True
            End If

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

    Private Sub btn_price_Click(sender As System.Object, e As System.EventArgs) Handles btn_price.Click
        Try
            Dim p As New OpenParameters
            With g10
                g10.UpdateRow()

                For Row As Integer = 0 To .RowCount - 1
                    p.Add("@itm_id", .Text("to_itm_id", Row))
                    p.Add("@cust_cd", cust_cd.Text)
                    p.Add("@std_dt", out_dt.Text)
                    p.Add("@cury_bc", .Text("cury_bc", Row))
                    p.Add("@um_bc", .Text("um_bc", Row))
                    Dim dSet As DataSet = OpenDataSet("lem170_cost", p)

                    If Not IsEmpty(dSet) Then
                        'g10.RowIndex = Row
                        .Text("out_up", Row) = ToDec(DataValue(dSet, "up"))
                        dSet = Nothing

                    End If

                Next
            End With

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Sub Print()
        If mov_no.Text = "" Or g10.RowCount <= 0 Then Exit Sub
        Dim Type As String = "LEB160", Gubn As String = "0"

        Dim p As OpenParameters = New OpenParameters
        p.Add("@mov_no", mov_no.Text)
        p.Add("@gubn", Gubn)
        p.Add("@is_cost", "0")
        System7.ReportView.LoadView(Type, "", "lem170_krs_print", p)

    End Sub
End Class
