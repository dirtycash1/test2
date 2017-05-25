Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class MMB130

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Init_Form()

    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            'Case MenuType.New

            Case MenuType.Save
                If CheckRequired(po_dt, po_fac, po_bc, po_kd, in_fac, in_wh) = False Then Exit Sub
                If Me.Save() = True Then
                    Me.Open()
                End If
                'Case MenuType.Delete

            Case Else

                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    '######################################################################################
    '##            Open                                                                  ##
    '######################################################################################

    Private Sub New_Form()
        Try

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
        Dim p As New OpenParameters

        Try
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            With g10

                .UpdateRow()

                For Row As Integer = 0 To .RowCount - 1
                    p.Add("@itm_id", g10.Text("itm_id", Row))
                    p.Add("@cust_cd", g10.Text("cust_cd", Row))
                    p.Add("@cury_bc", g10.Text("cury_bc", Row))
                    p.Add("@po_fac", po_fac.Text)
                    p.Add("@po_dt", po_dt.Text)
                    Dim dSet As DataSet = OpenDataSet("mmb120_cost", p)

                    If Not IsEmpty(dSet) Then

                        '.RowIndex = Row
                        .Text("po_up", Row) = ToDec(DataValue(dSet, "up"))
                        .Text("ttm_rt", Row) = ToDec(DataValue(dSet, "ttm_rt"))

                    End If

                Next

            End With

        Catch ex As Exception
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
        End Try

        'Me.OpenDataSet("mmb100_itm", p)
        'g10.AddNewRow()
        'MyBase.Open("mmb100_itm", p)
    End Sub

    Private m_StopEvent As Boolean

    Private Sub g10_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging

        If m_StopEvent Then
            Exit Sub
        End If

        m_StopEvent = True

        If ColumnName = "chk" Then

            If Value = "1" Then
                g10.Text("po_qty") = g10.Text("req_qty")
            Else
                g10.Text("po_qty") = ""
            End If

        End If

        If ColumnName = "po_qty" Then

            g10.Text("chk") = IIf(ToDec(Value) = 0, "0", "1")

        End If

        m_StopEvent = False

    End Sub
End Class
